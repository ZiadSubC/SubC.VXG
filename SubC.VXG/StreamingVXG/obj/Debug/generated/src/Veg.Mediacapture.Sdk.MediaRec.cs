using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaRec", DoNotGenerateAcw=true)]
	public partial class MediaRec : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MediaRec";

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaRec", typeof (MediaRec));

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

		protected MediaRec (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/constructor[@name='MediaRec' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaRec () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_isHead;
#pragma warning disable 0169
		static Delegate GetIsHeadHandler ()
		{
			if (cb_isHead == null)
				cb_isHead = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHead);
			return cb_isHead;
		}

		static bool n_IsHead (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHead;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHead {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='isHead' and count(parameter)=0]"
			[Register ("isHead", "()Z", "GetIsHeadHandler")]
			get {
				const string __id = "isHead.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isStarted;
#pragma warning disable 0169
		static Delegate GetIsStartedHandler ()
		{
			if (cb_isStarted == null)
				cb_isStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStarted);
			return cb_isStarted;
		}

		static bool n_IsStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='isStarted' and count(parameter)=0]"
			[Register ("isStarted", "()Z", "GetIsStartedHandler")]
			get {
				const string __id = "isStarted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
#pragma warning disable 0169
		static Delegate GetPutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler ()
		{
			if (cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ == null)
				cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_);
			return cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
		}

		static int n_PutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_af)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var af = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket> (native_af, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutAudio (af);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='putAudio' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.AudioPacket']]"
		[Register ("putAudio", "(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)I", "GetPutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler")]
		public virtual unsafe int PutAudio (global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket af)
		{
			const string __id = "putAudio.(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((af == null) ? IntPtr.Zero : ((global::Java.Lang.Object) af).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (af);
			}
		}

		static Delegate cb_putHeaderVideo_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetPutHeaderVideo_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_putHeaderVideo_Ljava_nio_ByteBuffer_ == null)
				cb_putHeaderVideo_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutHeaderVideo_Ljava_nio_ByteBuffer_);
			return cb_putHeaderVideo_Ljava_nio_ByteBuffer_;
		}

		static void n_PutHeaderVideo_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bh)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bh = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bh, JniHandleOwnership.DoNotTransfer);
			__this.PutHeaderVideo (bh);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='putHeaderVideo' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("putHeaderVideo", "(Ljava/nio/ByteBuffer;)V", "GetPutHeaderVideo_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void PutHeaderVideo (global::Java.Nio.ByteBuffer bh)
		{
			const string __id = "putHeaderVideo.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bh == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bh).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bh);
			}
		}

		static Delegate cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetPutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler ()
		{
			if (cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ == null)
				cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_);
			return cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
		}

		static int n_PutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vf = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> (native_vf, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutVideo (vf);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='putVideo' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
		[Register ("putVideo", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)I", "GetPutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler")]
		public virtual unsafe int PutVideo (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame vf)
		{
			const string __id = "putVideo.(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((vf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vf).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (vf);
			}
		}

		static Delegate cb_setAudioParams_ZIII;
#pragma warning disable 0169
		static Delegate GetSetAudioParams_ZIIIHandler ()
		{
			if (cb_setAudioParams_ZIII == null)
				cb_setAudioParams_ZIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZIII_V) n_SetAudioParams_ZIII);
			return cb_setAudioParams_ZIII;
		}

		static void n_SetAudioParams_ZIII (IntPtr jnienv, IntPtr native__this, bool audio_enable, int samplingrate, int config, int codec_id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioParams (audio_enable, samplingrate, config, codec_id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='setAudioParams' and count(parameter)=4 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setAudioParams", "(ZIII)V", "GetSetAudioParams_ZIIIHandler")]
		public virtual unsafe void SetAudioParams (bool audio_enable, int samplingrate, int config, int codec_id)
		{
			const string __id = "setAudioParams.(ZIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (audio_enable);
				__args [1] = new JniArgumentValue (samplingrate);
				__args [2] = new JniArgumentValue (config);
				__args [3] = new JniArgumentValue (codec_id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetUrl (url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
		public virtual unsafe void SetUrl (string url)
		{
			const string __id = "setUrl.(Ljava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_setVideoParams_IIII;
#pragma warning disable 0169
		static Delegate GetSetVideoParams_IIIIHandler ()
		{
			if (cb_setVideoParams_IIII == null)
				cb_setVideoParams_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_SetVideoParams_IIII);
			return cb_setVideoParams_IIII;
		}

		static void n_SetVideoParams_IIII (IntPtr jnienv, IntPtr native__this, int width, int height, int fps, int bitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoParams (width, height, fps, bitrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='setVideoParams' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setVideoParams", "(IIII)V", "GetSetVideoParams_IIIIHandler")]
		public virtual unsafe void SetVideoParams (int width, int height, int fps, int bitrate)
		{
			const string __id = "setVideoParams.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				__args [2] = new JniArgumentValue (fps);
				__args [3] = new JniArgumentValue (bitrate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='start' and count(parameter)=0]"
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
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaRec> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaRec']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
