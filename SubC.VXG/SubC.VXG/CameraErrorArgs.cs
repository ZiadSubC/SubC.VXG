// <copyright file="CameraErrorArgs.cs" company="SubC Imaging">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SubC.VXG
{
    using System;
    using Android.Hardware.Camera2;

    /// <summary>
    /// Error arguments.
    /// </summary>
    public class CameraErrorArgs : EventArgs
    {
        /// <param name="camera">Camera device.</param>
        /// <param name="error">Camera error.</param>
        public CameraErrorArgs(CameraDevice camera, Android.Hardware.Camera2.CameraError error)
        {
            Camera = camera;
            Error = error;
        }

        /// <summary>
        /// Gets Camera object of cameraDevice.
        /// </summary>
        public CameraDevice Camera { get; }

        /// <summary>
        /// gets error from CameraError.
        /// </summary>
        public Android.Hardware.Camera2.CameraError Error { get; }
    }
}