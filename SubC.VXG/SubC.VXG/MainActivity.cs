using Android.App;
using System;
using Android.Hardware.Camera2;
using System.Runtime.Remoting.Contexts;
using Android.Util;
using Android.Content;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Graphics;
using Android.Views;
//using SubC.Streaming;
using System.Collections.Generic;
using System.Threading.Tasks;
using Veg.Mediacapture.Sdk;
using static Veg.Mediacapture.Sdk.MediaCapture;
using static Veg.Mediacapture.Sdk.MediaCaptureConfig;

namespace SubC.VXG
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private CameraDevice mCameraDevice;
        private MediaCapture capture;

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

            var preview = FindViewById<AutoFitTextureView>(Resource.Id.ImagePreview);
            var cameraManager = (CameraManager)GetSystemService(CameraService);
            while (!preview.IsAvailable)
            {
                await Task.Delay(TimeSpan.FromMilliseconds(100));
            }
            mCameraDevice = await OpenCameraAsync("0", cameraManager);
            var surface = new Surface(preview.SurfaceTexture);
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

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}