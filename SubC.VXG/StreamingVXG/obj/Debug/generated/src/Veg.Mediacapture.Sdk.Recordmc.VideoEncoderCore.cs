using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Recordmc {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/recordmc/VideoEncoderCore", DoNotGenerateAcw=true)]
	public partial class VideoEncoderCore : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/field[@name='MUXER_ENABLED']"
		[Register ("MUXER_ENABLED")]
		public const bool MuxerEnabled = (bool) false;

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore.RecorderMCFrame']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/recordmc/VideoEncoderCore$RecorderMCFrame", DoNotGenerateAcw=true)]
		public partial class RecorderMCFrame : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore.RecorderMCFrame']/field[@name='frame']"
			[Register ("frame")]
			public global::Java.Nio.ByteBuffer Frame {
				get {
					const string __id = "frame.Ljava/nio/ByteBuffer;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "frame.Ljava/nio/ByteBuffer;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore.RecorderMCFrame']/field[@name='frame_info']"
			[Register ("frame_info")]
			public global::Android.Media.MediaCodec.BufferInfo FrameInfo {
				get {
					const string __id = "frame_info.Landroid/media/MediaCodec$BufferInfo;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.BufferInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "frame_info.Landroid/media/MediaCodec$BufferInfo;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/recordmc/VideoEncoderCore$RecorderMCFrame", typeof (RecorderMCFrame));

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

			protected RecorderMCFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore.RecorderMCFrame']/constructor[@name='VideoEncoderCore.RecorderMCFrame' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.recordmc.VideoEncoderCore']]"
			[Register (".ctor", "(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V", "")]
			public unsafe RecorderMCFrame (global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/recordmc/VideoEncoderCore", typeof (VideoEncoderCore));

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

		protected VideoEncoderCore (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/constructor[@name='VideoEncoderCore' and count(parameter)=10 and parameter[1][@type='android.content.Context'] and parameter[2][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[3][@type='veg.mediacapture.sdk.InternalDataCallback'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='java.io.File'] and parameter[10][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;IIIIILjava/io/File;Z)V", "")]
		public unsafe VideoEncoderCore (global::Android.Content.Context context, global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IInternalDataCallback callback_internal, int width, int height, int bitRate, int fps, int iframe_interval, global::Java.IO.File outputFile, bool is_secondary) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;IIIIILjava/io/File;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [2] = new JniArgumentValue ((callback_internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callback_internal).Handle);
				__args [3] = new JniArgumentValue (width);
				__args [4] = new JniArgumentValue (height);
				__args [5] = new JniArgumentValue (bitRate);
				__args [6] = new JniArgumentValue (fps);
				__args [7] = new JniArgumentValue (iframe_interval);
				__args [8] = new JniArgumentValue ((outputFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputFile).Handle);
				__args [9] = new JniArgumentValue (is_secondary);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (callback_internal);
				global::System.GC.KeepAlive (outputFile);
			}
		}

		static Delegate cb_getInputSurface;
#pragma warning disable 0169
		static Delegate GetGetInputSurfaceHandler ()
		{
			if (cb_getInputSurface == null)
				cb_getInputSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInputSurface);
			return cb_getInputSurface;
		}

		static IntPtr n_GetInputSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputSurface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.Surface InputSurface {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='getInputSurface' and count(parameter)=0]"
			[Register ("getInputSurface", "()Landroid/view/Surface;", "GetGetInputSurfaceHandler")]
			get {
				const string __id = "getInputSurface.()Landroid/view/Surface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isMuxStarted;
#pragma warning disable 0169
		static Delegate GetIsMuxStartedHandler ()
		{
			if (cb_isMuxStarted == null)
				cb_isMuxStarted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsMuxStarted);
			return cb_isMuxStarted;
		}

		static bool n_IsMuxStarted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsMuxStarted;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsMuxStarted {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='isMuxStarted' and count(parameter)=0]"
			[Register ("isMuxStarted", "()Z", "GetIsMuxStartedHandler")]
			get {
				const string __id = "isMuxStarted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_drainEncoder_Z;
#pragma warning disable 0169
		static Delegate GetDrainEncoder_ZHandler ()
		{
			if (cb_drainEncoder_Z == null)
				cb_drainEncoder_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_DrainEncoder_Z);
			return cb_drainEncoder_Z;
		}

		static void n_DrainEncoder_Z (IntPtr jnienv, IntPtr native__this, bool endOfStream)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrainEncoder (endOfStream);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='drainEncoder' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("drainEncoder", "(Z)V", "GetDrainEncoder_ZHandler")]
		public virtual unsafe void DrainEncoder (bool endOfStream)
		{
			const string __id = "drainEncoder.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (endOfStream);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_putAudioFormat_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetPutAudioFormat_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_putAudioFormat_Landroid_media_MediaFormat_ == null)
				cb_putAudioFormat_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutAudioFormat_Landroid_media_MediaFormat_);
			return cb_putAudioFormat_Landroid_media_MediaFormat_;
		}

		static int n_PutAudioFormat_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audio_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var audio_format = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_audio_format, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutAudioFormat (audio_format);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='putAudioFormat' and count(parameter)=1 and parameter[1][@type='android.media.MediaFormat']]"
		[Register ("putAudioFormat", "(Landroid/media/MediaFormat;)I", "GetPutAudioFormat_Landroid_media_MediaFormat_Handler")]
		public virtual unsafe int PutAudioFormat (global::Android.Media.MediaFormat audio_format)
		{
			const string __id = "putAudioFormat.(Landroid/media/MediaFormat;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((audio_format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audio_format).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (audio_format);
			}
		}

		static Delegate cb_putAudioFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
#pragma warning disable 0169
		static Delegate GetPutAudioFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler ()
		{
			if (cb_putAudioFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == null)
				cb_putAudioFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_PutAudioFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_);
			return cb_putAudioFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		}

		static int n_PutAudioFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_audio_frame, IntPtr native_audio_buffer_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var audio_frame = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_audio_frame, JniHandleOwnership.DoNotTransfer);
			var audio_buffer_info = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.BufferInfo> (native_audio_buffer_info, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutAudioFrame (audio_frame, audio_buffer_info);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='putAudioFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='android.media.MediaCodec.BufferInfo']]"
		[Register ("putAudioFrame", "(Ljava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)I", "GetPutAudioFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler")]
		public virtual unsafe int PutAudioFrame (global::Java.Nio.ByteBuffer audio_frame, global::Android.Media.MediaCodec.BufferInfo audio_buffer_info)
		{
			const string __id = "putAudioFrame.(Ljava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((audio_frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audio_frame).Handle);
				__args [1] = new JniArgumentValue ((audio_buffer_info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) audio_buffer_info).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (audio_frame);
				global::System.GC.KeepAlive (audio_buffer_info);
			}
		}

		static Delegate cb_putVideoFormat_Landroid_media_MediaFormat_;
#pragma warning disable 0169
		static Delegate GetPutVideoFormat_Landroid_media_MediaFormat_Handler ()
		{
			if (cb_putVideoFormat_Landroid_media_MediaFormat_ == null)
				cb_putVideoFormat_Landroid_media_MediaFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutVideoFormat_Landroid_media_MediaFormat_);
			return cb_putVideoFormat_Landroid_media_MediaFormat_;
		}

		static int n_PutVideoFormat_Landroid_media_MediaFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_video_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var video_format = global::Java.Lang.Object.GetObject<global::Android.Media.MediaFormat> (native_video_format, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutVideoFormat (video_format);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='putVideoFormat' and count(parameter)=1 and parameter[1][@type='android.media.MediaFormat']]"
		[Register ("putVideoFormat", "(Landroid/media/MediaFormat;)I", "GetPutVideoFormat_Landroid_media_MediaFormat_Handler")]
		public virtual unsafe int PutVideoFormat (global::Android.Media.MediaFormat video_format)
		{
			const string __id = "putVideoFormat.(Landroid/media/MediaFormat;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((video_format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) video_format).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (video_format);
			}
		}

		static Delegate cb_putVideoFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
#pragma warning disable 0169
		static Delegate GetPutVideoFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler ()
		{
			if (cb_putVideoFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == null)
				cb_putVideoFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_PutVideoFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_);
			return cb_putVideoFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		}

		static int n_PutVideoFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ (IntPtr jnienv, IntPtr native__this, IntPtr native_video_frame, IntPtr native_video_buffer_info)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var video_frame = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_video_frame, JniHandleOwnership.DoNotTransfer);
			var video_buffer_info = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.BufferInfo> (native_video_buffer_info, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.PutVideoFrame (video_frame, video_buffer_info);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='putVideoFrame' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='android.media.MediaCodec.BufferInfo']]"
		[Register ("putVideoFrame", "(Ljava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)I", "GetPutVideoFrame_Ljava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler")]
		public virtual unsafe int PutVideoFrame (global::Java.Nio.ByteBuffer video_frame, global::Android.Media.MediaCodec.BufferInfo video_buffer_info)
		{
			const string __id = "putVideoFrame.(Ljava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((video_frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) video_frame).Handle);
				__args [1] = new JniArgumentValue ((video_buffer_info == null) ? IntPtr.Zero : ((global::Java.Lang.Object) video_buffer_info).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (video_frame);
				global::System.GC.KeepAlive (video_buffer_info);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetBitrate_IHandler ()
		{
			if (cb_setBitrate_I == null)
				cb_setBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBitrate_I);
			return cb_setBitrate_I;
		}

		static void n_SetBitrate_I (IntPtr jnienv, IntPtr native__this, int bitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBitrate (bitrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='setBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBitrate", "(I)V", "GetSetBitrate_IHandler")]
		public virtual unsafe void SetBitrate (int bitrate)
		{
			const string __id = "setBitrate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitrate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScalingMode_I;
#pragma warning disable 0169
		static Delegate GetSetScalingMode_IHandler ()
		{
			if (cb_setScalingMode_I == null)
				cb_setScalingMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetScalingMode_I);
			return cb_setScalingMode_I;
		}

		static void n_SetScalingMode_I (IntPtr jnienv, IntPtr native__this, int mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScalingMode (mode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='VideoEncoderCore']/method[@name='setScalingMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setScalingMode", "(I)V", "GetSetScalingMode_IHandler")]
		public virtual unsafe void SetScalingMode (int mode)
		{
			const string __id = "setScalingMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
