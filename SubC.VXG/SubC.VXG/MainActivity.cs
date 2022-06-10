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

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SubC.VXG
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private CameraDevice mCameraDevice;

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

            CameraCaptureSession captureSession = null;

            var tcs = new TaskCompletionSource<bool>();

            var failedHandler = new EventHandler<CameraCaptureSession>((s, e) =>
            {
                captureSession = e;
                tcs.TrySetResult(false);
            });

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

            var previewSurfaces = new List<Surface>();

            previewSurfaces.Add(surface);

            //try
            //{
            mCameraDevice.CreateCaptureSession(previewSurfaces, sessionCallback, handler);
            //}
            //catch (Exception e)
            //{
            //    tcs.TrySetResult(false);
            //    throw e;
            //}
            var mPreviewBuilder = mCameraDevice.CreateCaptureRequest(CameraTemplate.Preview);

            mPreviewBuilder.AddTarget(surface);
            var request = mPreviewBuilder.Build();

            captureSession.SetRepeatingRequest(request, null, null);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}