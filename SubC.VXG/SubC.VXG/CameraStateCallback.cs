// <copyright file="CameraStateCallback.cs" company="SubC Imaging">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SubC.VXG
{
    using System;
    using Android.Hardware.Camera2;
    using Android.Runtime;

    /// <summary>
    /// Callback for camera state.
    /// </summary>
    public class CameraStateCallback : CameraDevice.StateCallback
    {
        /// <summary>
        /// Handler for disconnected camera.
        /// </summary>
        public event EventHandler<CameraDevice> Disconnected;

        /// <summary>
        /// Handler for camera error.
        /// </summary>
        public event EventHandler<CameraErrorArgs> Error;

        /// <summary>
        /// Handler for opened camera.
        /// </summary>
        public event EventHandler<CameraDevice> Opened;

        /// <param name="camera">Camera device.</param>
        public override void OnDisconnected(CameraDevice camera)
        {
            Disconnected?.Invoke(this, camera);
        }

        /// <param name="camera">Camera device.</param>
        /// <param name="error">Camera error.</param>
        public override void OnError(CameraDevice camera, [GeneratedEnum] Android.Hardware.Camera2.CameraError error)
        {
            Error?.Invoke(this, new CameraErrorArgs(camera, error));
        }

        /// <param name="camera">Camera device.</param>
        public override void OnOpened(CameraDevice camera)
        {
            Opened?.Invoke(this, camera);
        }
    }
}