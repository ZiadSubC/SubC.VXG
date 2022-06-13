// <copyright file="CameraCaptureStillPictureSessionCallback.cs" company="SubC Imaging">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SubC.VXG
{
    using Android.Hardware.Camera2;
    using Android.Util;

    /// <summary>
    /// Callback for capturing pictures.
    /// </summary>
    public class CameraCaptureStillPictureSessionCallback : CameraCaptureSession.CaptureCallback
    {
        private static readonly string TAG = "CameraCaptureStillPictureSessionCallback";

        private readonly MainActivity owner;

        /// <param name="owner">For throwing exceptions.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public CameraCaptureStillPictureSessionCallback(MainActivity owner)
        {
            if (owner == null)
                throw new System.ArgumentNullException("owner");
            this.owner = owner;
        }

        /// <param name="session">Creating session.</param>
        /// <param name="request"> creating a capture request.</param>
        /// <param name="result">Getting result.</param>
        public override void OnCaptureCompleted(CameraCaptureSession session, CaptureRequest request, TotalCaptureResult result)
        {
            // If something goes wrong with the save (or the handler isn't even
            // registered, this code will toast a success message regardless...)
            //owner.ShowToast("Saved: " + owner.mFile);
            //Log.Debug(TAG, owner.mFile.ToString());
            //owner.UnlockFocus();
            owner.TakePicture();
        }
    }
}