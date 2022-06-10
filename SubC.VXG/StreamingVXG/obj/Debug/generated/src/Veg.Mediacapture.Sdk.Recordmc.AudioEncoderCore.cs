using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Recordmc {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/recordmc/AudioEncoderCore", DoNotGenerateAcw=true)]
	public partial class AudioEncoderCore : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/field[@name='AUDIO_SAMPLING_RATES']"
		[Register ("AUDIO_SAMPLING_RATES")]
		public static IList<int> AudioSamplingRates {
			get {
				const string __id = "AUDIO_SAMPLING_RATES.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AudioEncoderCore";

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/recordmc/AudioEncoderCore", typeof (AudioEncoderCore));

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

		protected AudioEncoderCore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/constructor[@name='AudioEncoderCore' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[3][@type='veg.mediacapture.sdk.InternalDataCallback'] and parameter[4][@type='veg.mediacapture.sdk.MediaCaptureCallback']]"
		[Register (".ctor", "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;)V", "")]
		public unsafe AudioEncoderCore (global::Android.Content.Context context, global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IInternalDataCallback callback_internal, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [2] = new JniArgumentValue ((callback_internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callback_internal).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (callback_internal);
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/constructor[@name='AudioEncoderCore' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[3][@type='veg.mediacapture.sdk.InternalDataCallback'] and parameter[4][@type='veg.mediacapture.sdk.MediaCaptureCallback'] and parameter[5][@type='android.media.projection.MediaProjection']]"
		[Register (".ctor", "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;Landroid/media/projection/MediaProjection;)V", "")]
		public unsafe AudioEncoderCore (global::Android.Content.Context context, global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IInternalDataCallback callback_internal, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback, global::Android.Media.Projection.MediaProjection mediaProjection) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_IsStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_IsStarted == null)
				cb_IsStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStarted);
			return cb_IsStarted;
		}

		static bool n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.AudioEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/method[@name='IsStarted' and count(parameter)=0]"
			[Register ("IsStarted", "()Z", "GetIsStartedHandler")]
			get {
				const string __id = "IsStarted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMuxerCount;
#pragma warning disable 0169
		static Delegate GetGetMuxerCountHandler ()
		{
			if (cb_getMuxerCount == null)
				cb_getMuxerCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMuxerCount);
			return cb_getMuxerCount;
		}

		static int n_GetMuxerCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.AudioEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MuxerCount;
		}
#pragma warning restore 0169

		public virtual unsafe int MuxerCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/method[@name='getMuxerCount' and count(parameter)=0]"
			[Register ("getMuxerCount", "()I", "GetGetMuxerCountHandler")]
			get {
				const string __id = "getMuxerCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addMuxer_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
#pragma warning disable 0169
		static Delegate GetAddMuxer_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler ()
		{
			if (cb_addMuxer_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ == null)
				cb_addMuxer_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddMuxer_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_);
			return cb_addMuxer_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
		}

		static void n_AddMuxer_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ (IntPtr jnienv, IntPtr native__this, IntPtr native_muxer)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.AudioEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var muxer = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (native_muxer, JniHandleOwnership.DoNotTransfer);
			__this.AddMuxer (muxer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/method[@name='addMuxer' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.recordmc.VideoEncoderCore']]"
		[Register ("addMuxer", "(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V", "GetAddMuxer_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler")]
		public virtual unsafe void AddMuxer (global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore muxer)
		{
			const string __id = "addMuxer.(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((muxer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) muxer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (muxer);
			}
		}

		static Delegate cb_clearMuxers;
#pragma warning disable 0169
		static Delegate GetClearMuxersHandler ()
		{
			if (cb_clearMuxers == null)
				cb_clearMuxers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearMuxers);
			return cb_clearMuxers;
		}

		static void n_ClearMuxers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.AudioEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMuxers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/method[@name='clearMuxers' and count(parameter)=0]"
		[Register ("clearMuxers", "()V", "GetClearMuxersHandler")]
		public virtual unsafe void ClearMuxers ()
		{
			const string __id = "clearMuxers.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Release);
			return cb_release;
		}

		static int n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.AudioEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()I", "GetReleaseHandler")]
		public virtual unsafe int Release ()
		{
			const string __id = "release.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Start);
			return cb_start;
		}

		static int n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.AudioEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()I", "GetStartHandler")]
		public virtual unsafe int Start ()
		{
			const string __id = "start.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Stop);
			return cb_stop;
		}

		static int n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.AudioEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='AudioEncoderCore']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()I", "GetStopHandler")]
		public virtual unsafe int Stop ()
		{
			const string __id = "stop.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
