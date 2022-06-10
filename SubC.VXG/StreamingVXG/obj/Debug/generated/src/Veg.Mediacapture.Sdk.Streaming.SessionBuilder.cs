using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/SessionBuilder", DoNotGenerateAcw=true)]
	public partial class SessionBuilder : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/field[@name='AUDIO_AAC']"
		[Register ("AUDIO_AAC")]
		public const int AudioAac = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/field[@name='AUDIO_AMRNB']"
		[Register ("AUDIO_AMRNB")]
		public const int AudioAmrnb = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/field[@name='AUDIO_NONE']"
		[Register ("AUDIO_NONE")]
		public const int AudioNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "SessionBuilder";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/field[@name='VIDEO_H263']"
		[Register ("VIDEO_H263")]
		public const int VideoH263 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/field[@name='VIDEO_H264']"
		[Register ("VIDEO_H264")]
		public const int VideoH264 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/field[@name='VIDEO_NONE']"
		[Register ("VIDEO_NONE")]
		public const int VideoNone = (int) 0;

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/SessionBuilder", typeof (SessionBuilder));

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

		protected SessionBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getAudioEncoder;
#pragma warning disable 0169
		static Delegate GetGetAudioEncoderHandler ()
		{
			if (cb_getAudioEncoder == null)
				cb_getAudioEncoder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioEncoder);
			return cb_getAudioEncoder;
		}

		static int n_GetAudioEncoder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioEncoder;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getAudioEncoder' and count(parameter)=0]"
			[Register ("getAudioEncoder", "()I", "GetGetAudioEncoderHandler")]
			get {
				const string __id = "getAudioEncoder.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCamera;
#pragma warning disable 0169
		static Delegate GetGetCameraHandler ()
		{
			if (cb_getCamera == null)
				cb_getCamera = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCamera);
			return cb_getCamera;
		}

		static int n_GetCamera (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Camera;
		}
#pragma warning restore 0169

		public virtual unsafe int Camera {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getCamera' and count(parameter)=0]"
			[Register ("getCamera", "()I", "GetGetCameraHandler")]
			get {
				const string __id = "getCamera.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lveg/mediacapture/sdk/MediaCaptureConfig;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Lveg/mediacapture/sdk/MediaCaptureConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				const string __id = "getContext.()Landroid/content/Context;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDestination;
#pragma warning disable 0169
		static Delegate GetGetDestinationHandler ()
		{
			if (cb_getDestination == null)
				cb_getDestination = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDestination);
			return cb_getDestination;
		}

		static IntPtr n_GetDestination (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Destination);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetAddress Destination {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getDestination' and count(parameter)=0]"
			[Register ("getDestination", "()Ljava/net/InetAddress;", "GetGetDestinationHandler")]
			get {
				const string __id = "getDestination.()Ljava/net/InetAddress;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFlashState;
#pragma warning disable 0169
		static Delegate GetGetFlashStateHandler ()
		{
			if (cb_getFlashState == null)
				cb_getFlashState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetFlashState);
			return cb_getFlashState;
		}

		static bool n_GetFlashState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FlashState;
		}
#pragma warning restore 0169

		public virtual unsafe bool FlashState {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getFlashState' and count(parameter)=0]"
			[Register ("getFlashState", "()Z", "GetGetFlashStateHandler")]
			get {
				const string __id = "getFlashState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lveg/mediacapture/sdk/streaming/SessionBuilder;", "")]
			get {
				const string __id = "getInstance.()Lveg/mediacapture/sdk/streaming/SessionBuilder;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrigin;
#pragma warning disable 0169
		static Delegate GetGetOriginHandler ()
		{
			if (cb_getOrigin == null)
				cb_getOrigin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOrigin);
			return cb_getOrigin;
		}

		static IntPtr n_GetOrigin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Origin);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetAddress Origin {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getOrigin' and count(parameter)=0]"
			[Register ("getOrigin", "()Ljava/net/InetAddress;", "GetGetOriginHandler")]
			get {
				const string __id = "getOrigin.()Ljava/net/InetAddress;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSurfaceHolder;
#pragma warning disable 0169
		static Delegate GetGetSurfaceHolderHandler ()
		{
			if (cb_getSurfaceHolder == null)
				cb_getSurfaceHolder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurfaceHolder);
			return cb_getSurfaceHolder;
		}

		static IntPtr n_GetSurfaceHolder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceHolder);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.ISurfaceHolder SurfaceHolder {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getSurfaceHolder' and count(parameter)=0]"
			[Register ("getSurfaceHolder", "()Landroid/view/SurfaceHolder;", "GetGetSurfaceHolderHandler")]
			get {
				const string __id = "getSurfaceHolder.()Landroid/view/SurfaceHolder;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeToLive;
#pragma warning disable 0169
		static Delegate GetGetTimeToLiveHandler ()
		{
			if (cb_getTimeToLive == null)
				cb_getTimeToLive = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeToLive);
			return cb_getTimeToLive;
		}

		static int n_GetTimeToLive (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeToLive;
		}
#pragma warning restore 0169

		public virtual unsafe int TimeToLive {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getTimeToLive' and count(parameter)=0]"
			[Register ("getTimeToLive", "()I", "GetGetTimeToLiveHandler")]
			get {
				const string __id = "getTimeToLive.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVideoEncoder;
#pragma warning disable 0169
		static Delegate GetGetVideoEncoderHandler ()
		{
			if (cb_getVideoEncoder == null)
				cb_getVideoEncoder = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoEncoder);
			return cb_getVideoEncoder;
		}

		static int n_GetVideoEncoder (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoEncoder;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoEncoder {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getVideoEncoder' and count(parameter)=0]"
			[Register ("getVideoEncoder", "()I", "GetGetVideoEncoderHandler")]
			get {
				const string __id = "getVideoEncoder.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVideoQuality;
#pragma warning disable 0169
		static Delegate GetGetVideoQualityHandler ()
		{
			if (cb_getVideoQuality == null)
				cb_getVideoQuality = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoQuality);
			return cb_getVideoQuality;
		}

		static IntPtr n_GetVideoQuality (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoQuality);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality VideoQuality {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='getVideoQuality' and count(parameter)=0]"
			[Register ("getVideoQuality", "()Lveg/mediacapture/sdk/streaming/video/VideoQuality;", "GetGetVideoQualityHandler")]
			get {
				const string __id = "getVideoQuality.()Lveg/mediacapture/sdk/streaming/video/VideoQuality;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lveg/mediacapture/sdk/streaming/Session;", "GetBuildHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Session Build ()
		{
			const string __id = "build.()Lveg/mediacapture/sdk/streaming/Session;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetCloneHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder Clone ()
		{
			const string __id = "clone.()Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAudioEncoder_I;
#pragma warning disable 0169
		static Delegate GetSetAudioEncoder_IHandler ()
		{
			if (cb_setAudioEncoder_I == null)
				cb_setAudioEncoder_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetAudioEncoder_I);
			return cb_setAudioEncoder_I;
		}

		static IntPtr n_SetAudioEncoder_I (IntPtr jnienv, IntPtr native__this, int encoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAudioEncoder (encoder));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setAudioEncoder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioEncoder", "(I)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetAudioEncoder_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetAudioEncoder (int encoder)
		{
			const string __id = "setAudioEncoder.(I)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (encoder);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setCamera_I;
#pragma warning disable 0169
		static Delegate GetSetCamera_IHandler ()
		{
			if (cb_setCamera_I == null)
				cb_setCamera_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetCamera_I);
			return cb_setCamera_I;
		}

		static IntPtr n_SetCamera_I (IntPtr jnienv, IntPtr native__this, int camera)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetCamera (camera));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCamera", "(I)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetCamera_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetCamera (int camera)
		{
			const string __id = "setCamera.(I)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (camera);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_;
#pragma warning disable 0169
		static Delegate GetSetConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_Handler ()
		{
			if (cb_setConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_ == null)
				cb_setConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_);
			return cb_setConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_;
		}

		static IntPtr n_SetConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetConfig (config));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig']]"
		[Register ("setConfig", "(Lveg/mediacapture/sdk/MediaCaptureConfig;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetConfig (global::Veg.Mediacapture.Sdk.MediaCaptureConfig config)
		{
			const string __id = "setConfig.(Lveg/mediacapture/sdk/MediaCaptureConfig;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static IntPtr n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetContext (context));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetContext (global::Android.Content.Context context)
		{
			const string __id = "setContext.(Landroid/content/Context;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_setDestination_Ljava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetSetDestination_Ljava_net_InetAddress_Handler ()
		{
			if (cb_setDestination_Ljava_net_InetAddress_ == null)
				cb_setDestination_Ljava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetDestination_Ljava_net_InetAddress_);
			return cb_setDestination_Ljava_net_InetAddress_;
		}

		static IntPtr n_SetDestination_Ljava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_destination)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var destination = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_destination, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDestination (destination));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setDestination' and count(parameter)=1 and parameter[1][@type='java.net.InetAddress']]"
		[Register ("setDestination", "(Ljava/net/InetAddress;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetDestination_Ljava_net_InetAddress_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetDestination (global::Java.Net.InetAddress destination)
		{
			const string __id = "setDestination.(Ljava/net/InetAddress;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((destination == null) ? IntPtr.Zero : ((global::Java.Lang.Object) destination).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (destination);
			}
		}

		static Delegate cb_setFlashEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetFlashEnabled_ZHandler ()
		{
			if (cb_setFlashEnabled_Z == null)
				cb_setFlashEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_L) n_SetFlashEnabled_Z);
			return cb_setFlashEnabled_Z;
		}

		static IntPtr n_SetFlashEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetFlashEnabled (enabled));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setFlashEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFlashEnabled", "(Z)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetFlashEnabled_ZHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetFlashEnabled (bool enabled)
		{
			const string __id = "setFlashEnabled.(Z)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_;
#pragma warning disable 0169
		static Delegate GetSetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_Handler ()
		{
			if (cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ == null)
				cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_);
			return cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_;
		}

		static IntPtr n_SetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cb = (global::Veg.Mediacapture.Sdk.IInternalDataCallback)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (native_cb, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetInternalDataCallback (cb));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setInternalDataCallback' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.InternalDataCallback']]"
		[Register ("setInternalDataCallback", "(Lveg/mediacapture/sdk/InternalDataCallback;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetInternalDataCallback (global::Veg.Mediacapture.Sdk.IInternalDataCallback cb)
		{
			const string __id = "setInternalDataCallback.(Lveg/mediacapture/sdk/InternalDataCallback;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cb).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (cb);
			}
		}

		static Delegate cb_setOrigin_Ljava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetSetOrigin_Ljava_net_InetAddress_Handler ()
		{
			if (cb_setOrigin_Ljava_net_InetAddress_ == null)
				cb_setOrigin_Ljava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetOrigin_Ljava_net_InetAddress_);
			return cb_setOrigin_Ljava_net_InetAddress_;
		}

		static IntPtr n_SetOrigin_Ljava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_origin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var origin = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_origin, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetOrigin (origin));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setOrigin' and count(parameter)=1 and parameter[1][@type='java.net.InetAddress']]"
		[Register ("setOrigin", "(Ljava/net/InetAddress;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetOrigin_Ljava_net_InetAddress_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetOrigin (global::Java.Net.InetAddress origin)
		{
			const string __id = "setOrigin.(Ljava/net/InetAddress;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((origin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) origin).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (origin);
			}
		}

		static Delegate cb_setPermissionRequestResult_ILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetPermissionRequestResult_ILandroid_content_Intent_Handler ()
		{
			if (cb_setPermissionRequestResult_ILandroid_content_Intent_ == null)
				cb_setPermissionRequestResult_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_SetPermissionRequestResult_ILandroid_content_Intent_);
			return cb_setPermissionRequestResult_ILandroid_content_Intent_;
		}

		static IntPtr n_SetPermissionRequestResult_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int code, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPermissionRequestResult (code, data));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setPermissionRequestResult' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("setPermissionRequestResult", "(ILandroid/content/Intent;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetPermissionRequestResult_ILandroid_content_Intent_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetPermissionRequestResult (int code, global::Android.Content.Intent data)
		{
			const string __id = "setPermissionRequestResult.(ILandroid/content/Intent;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_setProjectionManager_Landroid_media_projection_MediaProjectionManager_;
#pragma warning disable 0169
		static Delegate GetSetProjectionManager_Landroid_media_projection_MediaProjectionManager_Handler ()
		{
			if (cb_setProjectionManager_Landroid_media_projection_MediaProjectionManager_ == null)
				cb_setProjectionManager_Landroid_media_projection_MediaProjectionManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetProjectionManager_Landroid_media_projection_MediaProjectionManager_);
			return cb_setProjectionManager_Landroid_media_projection_MediaProjectionManager_;
		}

		static IntPtr n_SetProjectionManager_Landroid_media_projection_MediaProjectionManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_projectionManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var projectionManager = global::Java.Lang.Object.GetObject<global::Android.Media.Projection.MediaProjectionManager> (native_projectionManager, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetProjectionManager (projectionManager));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setProjectionManager' and count(parameter)=1 and parameter[1][@type='android.media.projection.MediaProjectionManager']]"
		[Register ("setProjectionManager", "(Landroid/media/projection/MediaProjectionManager;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetProjectionManager_Landroid_media_projection_MediaProjectionManager_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetProjectionManager (global::Android.Media.Projection.MediaProjectionManager projectionManager)
		{
			const string __id = "setProjectionManager.(Landroid/media/projection/MediaProjectionManager;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((projectionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) projectionManager).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (projectionManager);
			}
		}

		static Delegate cb_setSurfaceHolder_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSetSurfaceHolder_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_setSurfaceHolder_Landroid_view_SurfaceHolder_ == null)
				cb_setSurfaceHolder_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetSurfaceHolder_Landroid_view_SurfaceHolder_);
			return cb_setSurfaceHolder_Landroid_view_SurfaceHolder_;
		}

		static IntPtr n_SetSurfaceHolder_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surfaceHolder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var surfaceHolder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_surfaceHolder, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSurfaceHolder (surfaceHolder));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setSurfaceHolder' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setSurfaceHolder", "(Landroid/view/SurfaceHolder;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetSurfaceHolder_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetSurfaceHolder (global::Android.Views.ISurfaceHolder surfaceHolder)
		{
			const string __id = "setSurfaceHolder.(Landroid/view/SurfaceHolder;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surfaceHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceHolder).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (surfaceHolder);
			}
		}

		static Delegate cb_setTimeToLive_I;
#pragma warning disable 0169
		static Delegate GetSetTimeToLive_IHandler ()
		{
			if (cb_setTimeToLive_I == null)
				cb_setTimeToLive_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetTimeToLive_I);
			return cb_setTimeToLive_I;
		}

		static IntPtr n_SetTimeToLive_I (IntPtr jnienv, IntPtr native__this, int ttl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTimeToLive (ttl));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setTimeToLive' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeToLive", "(I)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetTimeToLive_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetTimeToLive (int ttl)
		{
			const string __id = "setTimeToLive.(I)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ttl);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setVideoEncoder_I;
#pragma warning disable 0169
		static Delegate GetSetVideoEncoder_IHandler ()
		{
			if (cb_setVideoEncoder_I == null)
				cb_setVideoEncoder_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_SetVideoEncoder_I);
			return cb_setVideoEncoder_I;
		}

		static IntPtr n_SetVideoEncoder_I (IntPtr jnienv, IntPtr native__this, int encoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetVideoEncoder (encoder));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setVideoEncoder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setVideoEncoder", "(I)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetVideoEncoder_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetVideoEncoder (int encoder)
		{
			const string __id = "setVideoEncoder.(I)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (encoder);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_;
#pragma warning disable 0169
		static Delegate GetSetVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_Handler ()
		{
			if (cb_setVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ == null)
				cb_setVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_SetVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_);
			return cb_setVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_;
		}

		static IntPtr n_SetVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ (IntPtr jnienv, IntPtr native__this, IntPtr native_quality)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var quality = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (native_quality, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetVideoQuality (quality));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='SessionBuilder']/method[@name='setVideoQuality' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.video.VideoQuality']]"
		[Register ("setVideoQuality", "(Lveg/mediacapture/sdk/streaming/video/VideoQuality;)Lveg/mediacapture/sdk/streaming/SessionBuilder;", "GetSetVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder SetVideoQuality (global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality quality)
		{
			const string __id = "setVideoQuality.(Lveg/mediacapture/sdk/streaming/video/VideoQuality;)Lveg/mediacapture/sdk/streaming/SessionBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((quality == null) ? IntPtr.Zero : ((global::Java.Lang.Object) quality).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.SessionBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (quality);
			}
		}

	}
}
