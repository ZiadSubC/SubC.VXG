// <copyright file="CameraSessionCallback.cs" company="SubC Imaging">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SubC.VXG
{
    using System;
    using Android.Hardware.Camera2;
    using Android.Views;

    /// <summary>
    /// Session callback.
    /// </summary>
    public class CameraSessionCallback : CameraCaptureSession.StateCallback
    {
        /// <summary>
        /// event handler.
        /// </summary>
        public event EventHandler<CameraCaptureSession> Configured;

        /// <summary>
        /// event handler.
        /// </summary>
        public event EventHandler<CameraCaptureSession> ConfigureFailed;

        /// <param name="session">Creating session.</param>
        public override void OnConfigured(CameraCaptureSession session)
        {
            Configured?.Invoke(this, session);
        }

        /// <param name="session">Failed session.</param>
        public override void OnConfigureFailed(CameraCaptureSession session)
        {
            ConfigureFailed?.Invoke(this, session);
        }
    }

    /// <summary>
    /// Event args class.
    /// </summary>
    public class CaptureEventArgs : EventArgs
    {
        /// <param name="session">capture session.</param>
        /// <param name="captureResult">result.</param>
        public CaptureEventArgs(
            CameraCaptureSession session,
            CaptureResult captureResult
            //,
            //File sessionFile
            )
        {
            Session = session;
            CaptureResult = captureResult;
            //SessionFile = sessionFile;
        }

        /// <summary>
        /// Gets capture result.
        /// </summary>
        public CaptureResult CaptureResult { get; }

        /// <summary>
        /// Gets capture session.
        /// </summary>
        public CameraCaptureSession Session { get; }

        //public File SessionFile { get; }
    }

    /// <summary>
    /// Capture callback.
    /// </summary>
    public class SubCCaptureCallback : CameraCaptureSession.CaptureCallback
    {
        /// <summary>
        /// Event for completed capture.
        /// </summary>
        public event EventHandler<CaptureEventArgs> CaptureCompleted;

        /// <summary>
        /// Event for failed capture.
        /// </summary>
        public event EventHandler CaptureFailed;

        /// <summary>
        /// Event for progressed capture.
        /// </summary>
        public event EventHandler<CaptureEventArgs> CaptureProgressed;

        /// <summary>
        /// Event for started capture.
        /// </summary>
        public event EventHandler CaptureStarted;

        /// <summary>
        /// Event for sequence capture.
        /// </summary>
        public event EventHandler SequenceCompleted;

        /// <param name="session">capture session.</param>
        /// <param name="request">capture request.</param>
        /// <param name="target">for surface.</param>
        /// <param name="frameNumber">frame number.</param>
        public override void OnCaptureBufferLost(CameraCaptureSession session, CaptureRequest request, Surface target, long frameNumber)
        {
            System.Console.WriteLine("OnCaptureBufferLost");
            base.OnCaptureBufferLost(session, request, target, frameNumber);
        }

        /// <param name="session">capture session.</param>
        /// <param name="request">capture request.</param>
        /// <param name="result">for result.</param>
        public override void OnCaptureCompleted(CameraCaptureSession session, CaptureRequest request, TotalCaptureResult result)
        {
            CaptureCompleted?.Invoke(this, new CaptureEventArgs(session, result));
            base.OnCaptureCompleted(session, request, result);
        }

        /// <param name="session">capture session.</param>
        /// <param name="request">capture request.</param>
        /// <param name="failure">for failure.</param>
        public override void OnCaptureFailed(CameraCaptureSession session, CaptureRequest request, CaptureFailure failure)
        {
            System.Console.WriteLine("OnCaptureFailed: " + (request.Tag ?? "Unknown") + " Reason: " + failure.Reason);
            base.OnCaptureFailed(session, request, failure);
            CaptureFailed?.Invoke(this, EventArgs.Empty);
        }

        /// <param name="session">capture session.</param>
        /// <param name="request">capture request.</param>
        /// <param name="partialResult">for partial result.</param>
        public override void OnCaptureProgressed(CameraCaptureSession session, CaptureRequest request, CaptureResult partialResult)
        {
            CaptureProgressed?.Invoke(this, new CaptureEventArgs(session, partialResult));
            base.OnCaptureProgressed(session, request, partialResult);
        }

        /// <param name="session">capture session.</param>
        /// <param name="sequenceId">for ID of sequence.</param>
        public override void OnCaptureSequenceAborted(CameraCaptureSession session, int sequenceId)
        {
            System.Console.WriteLine("OnCaptureSequenceAborted");
            base.OnCaptureSequenceAborted(session, sequenceId);
        }

        /// <param name="session">capture session.</param>
        /// <param name="sequenceId">for ID of sequence.</param>
        /// <param name="frameNumber">for frame number.</param>
        public override void OnCaptureSequenceCompleted(CameraCaptureSession session, int sequenceId, long frameNumber)
        {
            base.OnCaptureSequenceCompleted(session, sequenceId, frameNumber);
            SequenceCompleted?.Invoke(this, null);
        }

        /// <param name="session">capture session.</param>
        /// <param name="request">capture request.</param>
        /// <param name="timestamp">time stamp.</param>
        /// <param name="frameNumber">frame number.</param>
        public override void OnCaptureStarted(CameraCaptureSession session, CaptureRequest request, long timestamp, long frameNumber)
        {
            CaptureStarted?.Invoke(this, EventArgs.Empty);
            base.OnCaptureStarted(session, request, timestamp, frameNumber);
        }
    }
}