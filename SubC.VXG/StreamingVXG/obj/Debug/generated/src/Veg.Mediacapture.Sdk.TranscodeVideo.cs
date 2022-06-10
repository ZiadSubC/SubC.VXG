using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/TranscodeVideo", DoNotGenerateAcw=true)]
	public partial class TranscodeVideo : global::Java.Lang.Object, global::Java.Lang.IRunnable {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/field[@name='SDEC_BB_COUNT']"
		[Register ("SDEC_BB_COUNT")]
		public const int SdecBbCount = (int) 30;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/field[@name='sdec_bb']"
		[Register ("sdec_bb")]
		public static IList<Java.Nio.ByteBuffer> SdecBb {
			get {
				const string __id = "sdec_bb.[Ljava/nio/ByteBuffer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<global::Java.Nio.ByteBuffer>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sdec_bb.[Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::Java.Nio.ByteBuffer>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo.EncodeThread']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/TranscodeVideo$EncodeThread", DoNotGenerateAcw=true)]
		public partial class EncodeThread : global::Java.Lang.Object, global::Java.Lang.IRunnable {
			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/TranscodeVideo$EncodeThread", typeof (EncodeThread));

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

			protected EncodeThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo.EncodeThread']/constructor[@name='TranscodeVideo.EncodeThread' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.TranscodeVideo']]"
			[Register (".ctor", "(Lveg/mediacapture/sdk/TranscodeVideo;)V", "")]
			public unsafe EncodeThread (global::Veg.Mediacapture.Sdk.TranscodeVideo __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo.EncodeThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo.EncodeThread']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/TranscodeVideo", typeof (TranscodeVideo));

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

		protected TranscodeVideo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/constructor[@name='TranscodeVideo' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[3][@type='veg.mediacapture.sdk.MediaCaptureCallback']]"
		[Register (".ctor", "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/MediaCaptureCallback;)V", "")]
		public unsafe TranscodeVideo (global::Android.Content.Context context, global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/MediaCaptureCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [2] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (@callback);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FramesCount_in;
		}
#pragma warning restore 0169

		public virtual unsafe int FramesCount_in {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='getFramesCount_in' and count(parameter)=0]"
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

		static Delegate cb_SetCURBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetCURBitrate_IHandler ()
		{
			if (cb_SetCURBitrate_I == null)
				cb_SetCURBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCURBitrate_I);
			return cb_SetCURBitrate_I;
		}

		static void n_SetCURBitrate_I (IntPtr jnienv, IntPtr native__this, int bitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCURBitrate (bitrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='SetCURBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetCURBitrate", "(I)V", "GetSetCURBitrate_IHandler")]
		public virtual unsafe void SetCURBitrate (int bitrate)
		{
			const string __id = "SetCURBitrate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitrate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_SetImgFile_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetImgFile_Ljava_lang_String_Handler ()
		{
			if (cb_SetImgFile_Ljava_lang_String_ == null)
				cb_SetImgFile_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetImgFile_Ljava_lang_String_);
			return cb_SetImgFile_Ljava_lang_String_;
		}

		static void n_SetImgFile_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sFile)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sFile = JNIEnv.GetString (native_sFile, JniHandleOwnership.DoNotTransfer);
			__this.SetImgFile (sFile);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='SetImgFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("SetImgFile", "(Ljava/lang/String;)V", "GetSetImgFile_Ljava_lang_String_Handler")]
		public virtual unsafe void SetImgFile (string sFile)
		{
			const string __id = "SetImgFile.(Ljava/lang/String;)V";
			IntPtr native_sFile = JNIEnv.NewString (sFile);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sFile);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sFile);
			}
		}

		static Delegate cb_SetImgQuality_I;
#pragma warning disable 0169
		static Delegate GetSetImgQuality_IHandler ()
		{
			if (cb_SetImgQuality_I == null)
				cb_SetImgQuality_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetImgQuality_I);
			return cb_SetImgQuality_I;
		}

		static void n_SetImgQuality_I (IntPtr jnienv, IntPtr native__this, int quality)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetImgQuality (quality);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='SetImgQuality' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetImgQuality", "(I)V", "GetSetImgQuality_IHandler")]
		public virtual unsafe void SetImgQuality (int quality)
		{
			const string __id = "SetImgQuality.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (quality);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_SetLRVBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetLRVBitrate_IHandler ()
		{
			if (cb_SetLRVBitrate_I == null)
				cb_SetLRVBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLRVBitrate_I);
			return cb_SetLRVBitrate_I;
		}

		static void n_SetLRVBitrate_I (IntPtr jnienv, IntPtr native__this, int bitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLRVBitrate (bitrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='SetLRVBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("SetLRVBitrate", "(I)V", "GetSetLRVBitrate_IHandler")]
		public virtual unsafe void SetLRVBitrate (int bitrate)
		{
			const string __id = "SetLRVBitrate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitrate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_encode_frame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetEncode_frame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler ()
		{
			if (cb_encode_frame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ == null)
				cb_encode_frame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Encode_frame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_);
			return cb_encode_frame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
		}

		static void n_Encode_frame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vf = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> (native_vf, JniHandleOwnership.DoNotTransfer);
			__this.Encode_frame (vf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='encode_frame' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
		[Register ("encode_frame", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V", "GetEncode_frame_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler")]
		public virtual unsafe void Encode_frame (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame vf)
		{
			const string __id = "encode_frame.(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((vf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (vf);
			}
		}

		static Delegate cb_filecopy_Ljava_io_File_Ljava_io_File_;
#pragma warning disable 0169
		static Delegate GetFilecopy_Ljava_io_File_Ljava_io_File_Handler ()
		{
			if (cb_filecopy_Ljava_io_File_Ljava_io_File_ == null)
				cb_filecopy_Ljava_io_File_Ljava_io_File_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_Filecopy_Ljava_io_File_Ljava_io_File_);
			return cb_filecopy_Ljava_io_File_Ljava_io_File_;
		}

		static void n_Filecopy_Ljava_io_File_Ljava_io_File_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src, IntPtr native_dst)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_src, JniHandleOwnership.DoNotTransfer);
			var dst = global::Java.Lang.Object.GetObject<global::Java.IO.File> (native_dst, JniHandleOwnership.DoNotTransfer);
			__this.Filecopy (src, dst);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='filecopy' and count(parameter)=2 and parameter[1][@type='java.io.File'] and parameter[2][@type='java.io.File']]"
		[Register ("filecopy", "(Ljava/io/File;Ljava/io/File;)V", "GetFilecopy_Ljava_io_File_Ljava_io_File_Handler")]
		public virtual unsafe void Filecopy (global::Java.IO.File src, global::Java.IO.File dst)
		{
			const string __id = "filecopy.(Ljava/io/File;Ljava/io/File;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (dst);
			}
		}

		static Delegate cb_is_started;
#pragma warning disable 0169
		static Delegate GetIs_startedHandler ()
		{
			if (cb_is_started == null)
				cb_is_started = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Is_started);
			return cb_is_started;
		}

		static bool n_Is_started (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_started ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='is_started' and count(parameter)=0]"
		[Register ("is_started", "()Z", "GetIs_startedHandler")]
		public virtual unsafe bool Is_started ()
		{
			const string __id = "is_started.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vf = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> (native_vf, JniHandleOwnership.DoNotTransfer);
			__this.PutFrame (vf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='putFrame' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
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

		static Delegate cb_putSPSPPS_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetPutSPSPPS_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_putSPSPPS_Ljava_nio_ByteBuffer_ == null)
				cb_putSPSPPS_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutSPSPPS_Ljava_nio_ByteBuffer_);
			return cb_putSPSPPS_Ljava_nio_ByteBuffer_;
		}

		static void n_PutSPSPPS_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bbSPSPPS)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bbSPSPPS = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_bbSPSPPS, JniHandleOwnership.DoNotTransfer);
			__this.PutSPSPPS (bbSPSPPS);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='putSPSPPS' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("putSPSPPS", "(Ljava/nio/ByteBuffer;)V", "GetPutSPSPPS_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void PutSPSPPS (global::Java.Nio.ByteBuffer bbSPSPPS)
		{
			const string __id = "putSPSPPS.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bbSPSPPS == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bbSPSPPS).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bbSPSPPS);
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (start_time);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='start' and count(parameter)=1 and parameter[1][@type='long']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.TranscodeVideo> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='TranscodeVideo']/method[@name='stop' and count(parameter)=0]"
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
