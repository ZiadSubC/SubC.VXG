using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/mp4/MP4Muxj", DoNotGenerateAcw=true)]
	public partial class MP4Muxj : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/field[@name='MP4MUX_TYPE_HRV']"
		[Register ("MP4MUX_TYPE_HRV")]
		public const int Mp4muxTypeHrv = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/field[@name='MP4MUX_TYPE_LRV']"
		[Register ("MP4MUX_TYPE_LRV")]
		public const int Mp4muxTypeLrv = (int) 2;

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/mp4/MP4Muxj", typeof (MP4Muxj));

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

		protected MP4Muxj (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/constructor[@name='MP4Muxj' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(ILandroid/content/Context;)V", "")]
		public unsafe MP4Muxj (int type, global::Android.Content.Context ctx) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILandroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue ((ctx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ctx).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (ctx);
			}
		}

		static Delegate cb_getFramesCount_in;
#pragma warning disable 0169
		static Delegate GetGetFramesCount_inHandler ()
		{
			if (cb_getFramesCount_in == null)
				cb_getFramesCount_in = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFramesCount_in);
			return cb_getFramesCount_in;
		}

		static int n_GetFramesCount_in (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FramesCount_in;
		}
#pragma warning restore 0169

		public virtual unsafe int FramesCount_in {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='getFramesCount_in' and count(parameter)=0]"
			[Register ("getFramesCount_in", "()I", "GetGetFramesCount_inHandler")]
			get {
				const string __id = "getFramesCount_in.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_IsHRV;
#pragma warning disable 0169
		static Delegate GetIsHRVHandler ()
		{
			if (cb_IsHRV == null)
				cb_IsHRV = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHRV);
			return cb_IsHRV;
		}

		static bool n_IsHRV (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHRV;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHRV {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='IsHRV' and count(parameter)=0]"
			[Register ("IsHRV", "()Z", "GetIsHRVHandler")]
			get {
				const string __id = "IsHRV.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_IsLRV;
#pragma warning disable 0169
		static Delegate GetIsLRVHandler ()
		{
			if (cb_IsLRV == null)
				cb_IsLRV = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsLRV);
			return cb_IsLRV;
		}

		static bool n_IsLRV (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLRV;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLRV {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='IsLRV' and count(parameter)=0]"
			[Register ("IsLRV", "()Z", "GetIsLRVHandler")]
			get {
				const string __id = "IsLRV.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStarted;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='IsStarted' and count(parameter)=0]"
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

		static Delegate cb_SetFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetFile_Ljava_lang_String_Handler ()
		{
			if (cb_SetFile_Ljava_lang_String_ == null)
				cb_SetFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFile_Ljava_lang_String_);
			return cb_SetFile_Ljava_lang_String_;
		}

		static void n_SetFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_filename)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			__this.SetFile (filename);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='SetFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetFile", "(Ljava/lang/String;)V", "GetSetFile_Ljava_lang_String_Handler")]
		public virtual unsafe void SetFile (string filename)
		{
			const string __id = "SetFile.(Ljava/lang/String;)V";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filename);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_SetMaxDuration_I;
#pragma warning disable 0169
		static Delegate GetSetMaxDuration_IHandler ()
		{
			if (cb_SetMaxDuration_I == null)
				cb_SetMaxDuration_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxDuration_I);
			return cb_SetMaxDuration_I;
		}

		static void n_SetMaxDuration_I (IntPtr jnienv, IntPtr native__this, int seconds)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxDuration (seconds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='SetMaxDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetMaxDuration", "(I)V", "GetSetMaxDuration_IHandler")]
		public virtual unsafe void SetMaxDuration (int seconds)
		{
			const string __id = "SetMaxDuration.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (seconds);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_putAudio_Ljava_nio_ByteBuffer_JJ;
#pragma warning disable 0169
		static Delegate GetPutAudio_Ljava_nio_ByteBuffer_JJHandler ()
		{
			if (cb_putAudio_Ljava_nio_ByteBuffer_JJ == null)
				cb_putAudio_Ljava_nio_ByteBuffer_JJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJJ_V) n_PutAudio_Ljava_nio_ByteBuffer_JJ);
			return cb_putAudio_Ljava_nio_ByteBuffer_JJ;
		}

		static void n_PutAudio_Ljava_nio_ByteBuffer_JJ (IntPtr jnienv, IntPtr native__this, IntPtr native_framebuf, long pts, long duration)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var framebuf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_framebuf, JniHandleOwnership.DoNotTransfer);
			__this.PutAudio (framebuf, pts, duration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='putAudio' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("putAudio", "(Ljava/nio/ByteBuffer;JJ)V", "GetPutAudio_Ljava_nio_ByteBuffer_JJHandler")]
		public virtual unsafe void PutAudio (global::Java.Nio.ByteBuffer framebuf, long pts, long duration)
		{
			const string __id = "putAudio.(Ljava/nio/ByteBuffer;JJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((framebuf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) framebuf).Handle);
				__args [1] = new JniArgumentValue (pts);
				__args [2] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (framebuf);
			}
		}

		static Delegate cb_putFrame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetPutFrame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler ()
		{
			if (cb_putFrame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ == null)
				cb_putFrame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutFrame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_);
			return cb_putFrame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
		}

		static void n_PutFrame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vf = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> (native_vf, JniHandleOwnership.DoNotTransfer);
			__this.PutFrame (vf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='putFrame' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
		[Register ("putFrame", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V", "GetPutFrame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler")]
		public virtual unsafe void PutFrame (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame vf)
		{
			const string __id = "putFrame.(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((vf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (vf);
			}
		}

		static Delegate cb_putPPS_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetPutPPS_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_putPPS_Ljava_nio_ByteBuffer_ == null)
				cb_putPPS_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutPPS_Ljava_nio_ByteBuffer_);
			return cb_putPPS_Ljava_nio_ByteBuffer_;
		}

		static void n_PutPPS_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_framebuf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var framebuf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_framebuf, JniHandleOwnership.DoNotTransfer);
			__this.PutPPS (framebuf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='putPPS' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("putPPS", "(Ljava/nio/ByteBuffer;)V", "GetPutPPS_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void PutPPS (global::Java.Nio.ByteBuffer framebuf)
		{
			const string __id = "putPPS.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((framebuf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) framebuf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (framebuf);
			}
		}

		static Delegate cb_putSPS_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetPutSPS_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_putSPS_Ljava_nio_ByteBuffer_ == null)
				cb_putSPS_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutSPS_Ljava_nio_ByteBuffer_);
			return cb_putSPS_Ljava_nio_ByteBuffer_;
		}

		static void n_PutSPS_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_framebuf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var framebuf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_framebuf, JniHandleOwnership.DoNotTransfer);
			__this.PutSPS (framebuf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='putSPS' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("putSPS", "(Ljava/nio/ByteBuffer;)V", "GetPutSPS_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void PutSPS (global::Java.Nio.ByteBuffer framebuf)
		{
			const string __id = "putSPS.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((framebuf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) framebuf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (framebuf);
			}
		}

		static Delegate cb_setAudioConfig_I;
#pragma warning disable 0169
		static Delegate GetSetAudioConfig_IHandler ()
		{
			if (cb_setAudioConfig_I == null)
				cb_setAudioConfig_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioConfig_I);
			return cb_setAudioConfig_I;
		}

		static void n_SetAudioConfig_I (IntPtr jnienv, IntPtr native__this, int mConfig)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioConfig (mConfig);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='setAudioConfig' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioConfig", "(I)V", "GetSetAudioConfig_IHandler")]
		public virtual unsafe void SetAudioConfig (int mConfig)
		{
			const string __id = "setAudioConfig.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mConfig);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSamplingRate_I;
#pragma warning disable 0169
		static Delegate GetSetSamplingRate_IHandler ()
		{
			if (cb_setSamplingRate_I == null)
				cb_setSamplingRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSamplingRate_I);
			return cb_setSamplingRate_I;
		}

		static void n_SetSamplingRate_I (IntPtr jnienv, IntPtr native__this, int samplingRate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSamplingRate (samplingRate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='setSamplingRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSamplingRate", "(I)V", "GetSetSamplingRate_IHandler")]
		public virtual unsafe void SetSamplingRate (int samplingRate)
		{
			const string __id = "setSamplingRate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (samplingRate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start_J;
#pragma warning disable 0169
		static Delegate GetStart_JHandler ()
		{
			if (cb_start_J == null)
				cb_start_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Start_J);
			return cb_start_J;
		}

		static void n_Start_J (IntPtr jnienv, IntPtr native__this, long start_time)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (start_time);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='start' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("start", "(J)V", "GetStart_JHandler")]
		public virtual unsafe void Start (long start_time)
		{
			const string __id = "start.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (start_time);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stat_print;
#pragma warning disable 0169
		static Delegate GetStat_printHandler ()
		{
			if (cb_stat_print == null)
				cb_stat_print = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stat_print);
			return cb_stat_print;
		}

		static void n_Stat_print (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stat_print ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='stat_print' and count(parameter)=0]"
		[Register ("stat_print", "()V", "GetStat_printHandler")]
		public virtual unsafe void Stat_print ()
		{
			const string __id = "stat_print.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Muxj']/method[@name='stop' and count(parameter)=0]"
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
