using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Recordmc {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/recordmc/OffscreenSurfaceRenderer", DoNotGenerateAcw=true)]
	public partial class OffscreenSurfaceRenderer : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/recordmc/OffscreenSurfaceRenderer", typeof (OffscreenSurfaceRenderer));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected OffscreenSurfaceRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/constructor[@name='OffscreenSurfaceRenderer' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[3][@type='veg.mediacapture.sdk.InternalDataCallback'] and parameter[4][@type='veg.mediacapture.sdk.MediaCaptureCallback'] and parameter[5][@type='android.media.projection.MediaProjection']]"
		[Register (".ctor", "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;Landroid/media/projection/MediaProjection;)V", "")]
		public unsafe OffscreenSurfaceRenderer (global::Android.Content.Context context, global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IInternalDataCallback callback_internal, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback, global::Android.Media.Projection.MediaProjection mediaProjection) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;Landroid/media/projection/MediaProjection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [2] = new JniArgumentValue ((callback_internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callback_internal).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [4] = new JniArgumentValue ((mediaProjection == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mediaProjection).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (callback_internal);
				global::System.GC.KeepAlive (@callback);
				global::System.GC.KeepAlive (mediaProjection);
			}
		}

		static Delegate cb_getSurface;
#pragma warning disable 0169
		static Delegate GetGetSurfaceHandler ()
		{
			if (cb_getSurface == null)
				cb_getSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurface);
			return cb_getSurface;
		}

		static IntPtr n_GetSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Surface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.Surface Surface {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='getSurface' and count(parameter)=0]"
			[Register ("getSurface", "()Landroid/view/Surface;", "GetGetSurfaceHandler")]
			get {
				const string __id = "getSurface.()Landroid/view/Surface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSurfaceTexture;
#pragma warning disable 0169
		static Delegate GetGetSurfaceTextureHandler ()
		{
			if (cb_getSurfaceTexture == null)
				cb_getSurfaceTexture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurfaceTexture);
			return cb_getSurfaceTexture;
		}

		static IntPtr n_GetSurfaceTexture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceTexture);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.SurfaceTexture SurfaceTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='getSurfaceTexture' and count(parameter)=0]"
			[Register ("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", "GetGetSurfaceTextureHandler")]
			get {
				const string __id = "getSurfaceTexture.()Landroid/graphics/SurfaceTexture;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_ApplyBitrate_IZ;
#pragma warning disable 0169
		static Delegate GetApplyBitrate_IZHandler ()
		{
			if (cb_ApplyBitrate_IZ == null)
				cb_ApplyBitrate_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_V) n_ApplyBitrate_IZ);
			return cb_ApplyBitrate_IZ;
		}

		static void n_ApplyBitrate_IZ (IntPtr jnienv, IntPtr native__this, int bitrate, bool is_secondary)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyBitrate (bitrate, is_secondary);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='ApplyBitrate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("ApplyBitrate", "(IZ)V", "GetApplyBitrate_IZHandler")]
		public virtual unsafe void ApplyBitrate (int bitrate, bool is_secondary)
		{
			const string __id = "ApplyBitrate.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bitrate);
				__args [1] = new JniArgumentValue (is_secondary);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ApplyFramerate_IZ;
#pragma warning disable 0169
		static Delegate GetApplyFramerate_IZHandler ()
		{
			if (cb_ApplyFramerate_IZ == null)
				cb_ApplyFramerate_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_V) n_ApplyFramerate_IZ);
			return cb_ApplyFramerate_IZ;
		}

		static void n_ApplyFramerate_IZ (IntPtr jnienv, IntPtr native__this, int fps, bool is_secondary)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyFramerate (fps, is_secondary);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='ApplyFramerate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("ApplyFramerate", "(IZ)V", "GetApplyFramerate_IZHandler")]
		public virtual unsafe void ApplyFramerate (int fps, bool is_secondary)
		{
			const string __id = "ApplyFramerate.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fps);
				__args [1] = new JniArgumentValue (is_secondary);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_Close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_Close == null)
				cb_Close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_Close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='Close' and count(parameter)=0]"
		[Register ("Close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "Close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_FrameAvailable;
#pragma warning disable 0169
		static Delegate GetFrameAvailableHandler ()
		{
			if (cb_FrameAvailable == null)
				cb_FrameAvailable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FrameAvailable);
			return cb_FrameAvailable;
		}

		static void n_FrameAvailable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FrameAvailable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='FrameAvailable' and count(parameter)=0]"
		[Register ("FrameAvailable", "()V", "GetFrameAvailableHandler")]
		public virtual unsafe void FrameAvailable ()
		{
			const string __id = "FrameAvailable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_notifyPausing;
#pragma warning disable 0169
		static Delegate GetNotifyPausingHandler ()
		{
			if (cb_notifyPausing == null)
				cb_notifyPausing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_NotifyPausing);
			return cb_notifyPausing;
		}

		static void n_NotifyPausing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyPausing ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='notifyPausing' and count(parameter)=0]"
		[Register ("notifyPausing", "()V", "GetNotifyPausingHandler")]
		public virtual unsafe void NotifyPausing ()
		{
			const string __id = "notifyPausing.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onVideoEncoderQuit;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoderQuitHandler ()
		{
			if (cb_onVideoEncoderQuit == null)
				cb_onVideoEncoderQuit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnVideoEncoderQuit);
			return cb_onVideoEncoderQuit;
		}

		static void n_OnVideoEncoderQuit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoderQuit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='onVideoEncoderQuit' and count(parameter)=0]"
		[Register ("onVideoEncoderQuit", "()V", "GetOnVideoEncoderQuitHandler")]
		public virtual unsafe void OnVideoEncoderQuit ()
		{
			const string __id = "onVideoEncoderQuit.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onVideoEncoderStartFailed;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoderStartFailedHandler ()
		{
			if (cb_onVideoEncoderStartFailed == null)
				cb_onVideoEncoderStartFailed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnVideoEncoderStartFailed);
			return cb_onVideoEncoderStartFailed;
		}

		static void n_OnVideoEncoderStartFailed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoderStartFailed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='onVideoEncoderStartFailed' and count(parameter)=0]"
		[Register ("onVideoEncoderStartFailed", "()V", "GetOnVideoEncoderStartFailedHandler")]
		public virtual unsafe void OnVideoEncoderStartFailed ()
		{
			const string __id = "onVideoEncoderStartFailed.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler ()
		{
			if (cb_onVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ == null)
				cb_onVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_);
			return cb_onVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
		}

		static void n_OnVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ (IntPtr jnienv, IntPtr native__this, IntPtr native_video_encoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var video_encoder = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (native_video_encoder, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoderStarted (video_encoder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='onVideoEncoderStarted' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.recordmc.VideoEncoderCore']]"
		[Register ("onVideoEncoderStarted", "(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V", "GetOnVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler")]
		public virtual unsafe void OnVideoEncoderStarted (global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore video_encoder)
		{
			const string __id = "onVideoEncoderStarted.(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((video_encoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) video_encoder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (video_encoder);
			}
		}

		static Delegate cb_onVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler ()
		{
			if (cb_onVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ == null)
				cb_onVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_);
			return cb_onVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
		}

		static void n_OnVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ (IntPtr jnienv, IntPtr native__this, IntPtr native_video_encoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var video_encoder = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (native_video_encoder, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoderStopped (video_encoder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='onVideoEncoderStopped' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.recordmc.VideoEncoderCore']]"
		[Register ("onVideoEncoderStopped", "(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V", "GetOnVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler")]
		public virtual unsafe void OnVideoEncoderStopped (global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore video_encoder)
		{
			const string __id = "onVideoEncoderStopped.(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((video_encoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) video_encoder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (video_encoder);
			}
		}

		static Delegate cb_startRecord;
#pragma warning disable 0169
		static Delegate GetStartRecordHandler ()
		{
			if (cb_startRecord == null)
				cb_startRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartRecord);
			return cb_startRecord;
		}

		static void n_StartRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartRecord ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='startRecord' and count(parameter)=0]"
		[Register ("startRecord", "()V", "GetStartRecordHandler")]
		public virtual unsafe void StartRecord ()
		{
			const string __id = "startRecord.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopRecord;
#pragma warning disable 0169
		static Delegate GetStopRecordHandler ()
		{
			if (cb_stopRecord == null)
				cb_stopRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopRecord);
			return cb_stopRecord;
		}

		static void n_StopRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.OffscreenSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecord ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='OffscreenSurfaceRenderer']/method[@name='stopRecord' and count(parameter)=0]"
		[Register ("stopRecord", "()V", "GetStopRecordHandler")]
		public virtual unsafe void StopRecord ()
		{
			const string __id = "stopRecord.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
