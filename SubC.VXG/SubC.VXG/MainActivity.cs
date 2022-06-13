// <copyright file="MainActivity.cs" company="SubC Imaging">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SubC.VXG
{
    using System;

    //using SubC.Streaming;
    using System.Collections.Generic;
    using System.Runtime.Remoting.Contexts;
    using System.Threading.Tasks;
    using Android.App;
    using Android.Content;
    using Android.Graphics;
    using Android.Hardware.Camera2;
    using Android.Media;
    using Android.OS;
    using Android.Runtime;
    using Android.Util;
    using Android.Views;
    using AndroidX.AppCompat.App;
    using Veg.Mediacapture.Sdk;
    using static Veg.Mediacapture.Sdk.MediaCapture;
    using static Veg.Mediacapture.Sdk.MediaCaptureConfig;
    using Orientation = Android.Content.Res.Orientation;

    /// <summary> Implementing a camera app that captures pictures and records videos as well as stream live feed using Camera2. </summary>
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        /// <summary> Initializing camera preview state. </summary>
        public const int STATE_PREVIEW = 0;

        /// <summary> Waiting for focus to be locked. </summary>
        public const int STATE_WAITING_LOCK = 1;

        /// <summary> Handles background tasks. </summary>
        public Handler mBackgroundHandler;

        /// <summary> Creating a capture session. </summary>
        public CameraCaptureSession mCaptureSession;

        /// <summary> Builder for camera preview. </summary>
        public CaptureRequest.Builder mPreviewRequestBuilder;

        /// <summary> Current state for taking pictures. </summary>
        public int mState = STATE_PREVIEW;

        /// <summary> Builder for taking pictures. </summary>
        public CaptureRequest.Builder stillCaptureBuilder;

        private MediaCapture capture;
        private CameraDevice mCameraDevice;
        private ImageReader mImageReader;

        /// <param name="cameraId"> camera ID. </param>
        /// <param name="cameraManager">A <see cref="CameraManager"/>.</param>
        /// <returns>A call to openCamera function for a separate handler representing the result of the asynchronous operation.</returns>
        public static Task<CameraDevice> OpenCameraAsync(string cameraId, CameraManager cameraManager)
        {
            //create a new background thread to open the camera on
            var backgroundThread = new HandlerThread("CameraBackground");
            backgroundThread.Start();
            var handler = new Android.OS.Handler(backgroundThread.Looper);

            return OpenCameraAsync(cameraId, cameraManager, new CameraStateCallback(), handler);
        }

        /// <summary>
        /// Gets a <see cref="CameraDevice"/> from a <see cref="Context"/> and a cameraId.
        /// </summary>
        /// <param name="cameraId">Camera Id.</param>
        /// <param name="cameraManager">A <see cref="CameraManager"/>.</param>
        /// <param name="stateCallback">A <see cref="CameraStateCallback"/>.</param>
        /// <param name="backgroundHandler">A background handler.</param>
        /// <returns>A task of CameraDevice.</returns>
        public static async Task<CameraDevice> OpenCameraAsync(string cameraId, CameraManager cameraManager, CameraStateCallback stateCallback, Android.OS.Handler backgroundHandler)
        {
            var tcs = new TaskCompletionSource<CameraDevice>();
            var handler = new EventHandler<CameraDevice>((s, e) =>
            {
                tcs.SetResult(e);
            });

            stateCallback.Opened += handler;

            try
            {
                cameraManager.OpenCamera(cameraId, stateCallback, backgroundHandler);
            }
            catch (Java.IO.IOException e)
            {
                throw new System.Exception(e.ToString());
            }

            var c = await tcs.Task;

            stateCallback.Opened -= handler;

            return c;
        }

        /// <summary>
        /// To be called for capuring pictures.
        /// </summary>
        public void CaptureStillPicture()
        {
            try
            {
                // This is the CaptureRequest.Builder that we use to take a picture.
                stillCaptureBuilder = mCameraDevice.CreateCaptureRequest(CameraTemplate.StillCapture);

                stillCaptureBuilder.AddTarget(mImageReader.Surface);

                // Use the same AE and AF modes as the preview.
                stillCaptureBuilder.Set(CaptureRequest.ControlAfMode, (int)ControlAFMode.ContinuousPicture);
                // SetAutoFlash(stillCaptureBuilder);
                mCaptureSession.StopRepeating();
                mCaptureSession.Capture(stillCaptureBuilder.Build(), new CameraCaptureStillPictureSessionCallback(this), null);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }

        /// <summary>
        /// Calls picture activity and takePicture for action.
        /// </summary>
        /// <param name="v"> ID for picture button and info. </param>
        public async void OnClick(View v)
        {
            if (v.Id == Resource.Id.picture)
            {
                TakePicture();
            }
            else if (v.Id == Resource.Id.info)
            {
            }
        }

        /// <param name="requestCode">Request Code.</param>
        /// <param name="permissions">Set permissions.</param>
        /// <param name="grantResults">Get results.</param>
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        /// <summary>
        /// Set setup settings/features for streaming.
        /// </summary>
        public void StreamingSetup()
        {
            capture = new MediaCapture(this, null);
            var config = capture.Config;

            config.Streaming = (false);
            config.Recording = (false);
            config.Transcoding = (false);
            config.PreviewScaleType = (0);

            //set portrait
            //config.VideoOrientation = (McOrientationPortrait);
            config.VideoOrientation = (McOrientationLandscape);

            //set camera facing
            //config.setCameraFacing(MediaCaptureConfig.CAMERA_FACING_BACK);
            //config.setCameraFacing(MediaCaptureConfig.CAMERA_FACING_FRONT);

            //video only
            config.CaptureMode = (CaptureModes.PpModeVideo.Val()/* | MediaCaptureConfig.CaptureModes.PP_MODE_AUDIO.val()*/);

            //main channel
            config.CaptureSource = (CaptureSources.PpModeExternal.Val());
            config.StreamType = (StreamerTypes.StreamTypeRtspServer.Val());
            config.Url = ("rtsp://@:" + "5540");
            config.UrlSec = ("rtsp://@:" + "5540");

            config.UseSec = (true);
            config.VideoResolution = (CaptureVideoResolution.VrCustom);

            IWindowManager wm = GetSystemService(WindowService).JavaCast<IWindowManager>();
            Display display = wm.DefaultDisplay;
            DisplayMetrics metrics = new DisplayMetrics();
            display.GetRealMetrics(metrics);

            // Note: please don't be confused here
            // Display size is always returned by Display.getRealMetrics() in portrait mode, ex. (1080x1920)
            // In the EncoderSDK we always set the width as a maximal dimension and
            // the actual orientation controlled by the setVideoOrientation()
            //config.setCustomVideoResolution(metrics.heightPixels, metrics.widthPixels);

            //config.setVideoResolution(CaptureVideoResolution.VR_1920x1080);
            config.VideoBitrate = (8000);
            config.SetVideoTimestampType(VideoTimestampType.Source);
            //config.setVideoFramerate(60);
            config.VideoFramerate = (55);
            config.VideoKeyFrameInterval = (1);
            config.VideoBitrateMode = (BitrateModeVbr);

            //secondary channel
            config.SecVideoResolution = (CaptureVideoResolution.VR320x240);
            config.SecVideoFramerate = (60);
            config.SecVideoKeyFrameInterval = (1);
            config.SecVideoBitrate = (400);
            config.VideoSecBitrateMode = (MediaCaptureConfig.BitrateModeVbr);

            config.Transcoding = (true);
            config.TransWidth = (1080);
            config.TransHeight = (1920);
            config.TransFps = (1);
            config.TransFormat = (TypeVideoRaw);

            MediaCapture.RequestPermission(this, config.CaptureSource);

            capture.Open(config, null);
        }

        /// <summary>
        /// Calls LockFocus function before taking pictures.
        /// </summary>
        public void TakePicture()
        {
            LockFocus();
        }

        /// <param name="savedInstanceState">Initializing OnCreate.</param>
        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            StreamingSetup();

            CameraCaptureSession captureSession = null;

            var tcs = new TaskCompletionSource<bool>();

            //var failedHandler = new EventHandler<CameraCaptureSession>((s, e) =>
            //{
            //    captureSession = e;
            //    tcs.TrySetResult(false);
            //});
            var configuredHandler = new EventHandler<CameraCaptureSession>((s, e) =>
            {
                captureSession = e;
                tcs.TrySetResult(true);
            });

            var sessionCallbackThread = new HandlerThread("SessionCallbackThread");
            sessionCallbackThread.Start();
            var handler = new Android.OS.Handler(sessionCallbackThread.Looper);

            var sessionCallback = new CameraSessionCallback();
            sessionCallback.Configured += configuredHandler;
            //sessionCallback.ConfigureFailed += failedHandler;
            var imagePreview = FindViewById<AutoFitTextureView>(Resource.Id.imagePreview);
            var cameraManager = (CameraManager)GetSystemService(CameraService);
            while (!imagePreview.IsAvailable)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(100));
            }

            mCameraDevice = await OpenCameraAsync("0", cameraManager);
            var surface = new Surface(imagePreview.SurfaceTexture);
            var streamSurfaces = capture.Surface;
            var sessionSurfaces = new List<Surface>();

            sessionSurfaces.Add(surface);
            sessionSurfaces.Add(streamSurfaces);

            //try
            //{
            mCameraDevice.CreateCaptureSession(sessionSurfaces, sessionCallback, handler);
            //}
            //catch (Exception e)
            //{
            //    tcs.TrySetResult(false);
            //    throw e;
            //}
            var mSessionBuilder = mCameraDevice.CreateCaptureRequest(CameraTemplate.Preview);

            mSessionBuilder.AddTarget(surface);
            mSessionBuilder.AddTarget(streamSurfaces);
            var request = mSessionBuilder.Build();

            mSessionBuilder.SetTag(CaptureRequest.ControlAeTargetFpsRange);

            captureSession.SetRepeatingRequest(request, null, null);
            capture.StartStreaming();
        }

        private void LockFocus()
        {
            try
            {
                // This is how to tell the camera to lock focus.
                mPreviewRequestBuilder.Set(CaptureRequest.ControlAfTrigger, (int)ControlAFTrigger.Start);
                // Tell #mCaptureCallback to wait for the lock.
                mState = STATE_WAITING_LOCK;
                mCaptureSession.Capture(mPreviewRequestBuilder.Build(), null,
                        mBackgroundHandler);
            }
            catch (CameraAccessException e)
            {
                e.PrintStackTrace();
            }
        }
    }
}