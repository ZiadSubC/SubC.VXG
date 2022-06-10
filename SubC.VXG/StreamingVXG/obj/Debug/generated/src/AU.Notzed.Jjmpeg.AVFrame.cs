using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVFrame", DoNotGenerateAcw=true)]
	public partial class AVFrame : global::AU.Notzed.Jjmpeg.AVObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVFrame", typeof (AVFrame));

		internal static new IntPtr class_ref {
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

		protected AVFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getCodedPictureNumber;
#pragma warning disable 0169
		static Delegate GetGetCodedPictureNumberHandler ()
		{
			if (cb_getCodedPictureNumber == null)
				cb_getCodedPictureNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCodedPictureNumber);
			return cb_getCodedPictureNumber;
		}

		static int n_GetCodedPictureNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodedPictureNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int CodedPictureNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getCodedPictureNumber' and count(parameter)=0]"
			[Register ("getCodedPictureNumber", "()I", "GetGetCodedPictureNumberHandler")]
			get {
				const string __id = "getCodedPictureNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDisplayPictureNumber;
#pragma warning disable 0169
		static Delegate GetGetDisplayPictureNumberHandler ()
		{
			if (cb_getDisplayPictureNumber == null)
				cb_getDisplayPictureNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDisplayPictureNumber);
			return cb_getDisplayPictureNumber;
		}

		static int n_GetDisplayPictureNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisplayPictureNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int DisplayPictureNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getDisplayPictureNumber' and count(parameter)=0]"
			[Register ("getDisplayPictureNumber", "()I", "GetGetDisplayPictureNumberHandler")]
			get {
				const string __id = "getDisplayPictureNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isKeyFrame;
#pragma warning disable 0169
		static Delegate GetIsKeyFrameHandler ()
		{
			if (cb_isKeyFrame == null)
				cb_isKeyFrame = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsKeyFrame);
			return cb_isKeyFrame;
		}

		static bool n_IsKeyFrame (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsKeyFrame;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsKeyFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='isKeyFrame' and count(parameter)=0]"
			[Register ("isKeyFrame", "()Z", "GetIsKeyFrameHandler")]
			get {
				const string __id = "isKeyFrame.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getKeyFrame;
#pragma warning disable 0169
		static Delegate GetGetKeyFrameHandler ()
		{
			if (cb_getKeyFrame == null)
				cb_getKeyFrame = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetKeyFrame);
			return cb_getKeyFrame;
		}

		static int n_GetKeyFrame (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeyFrame;
		}
#pragma warning restore 0169

		public virtual unsafe int KeyFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getKeyFrame' and count(parameter)=0]"
			[Register ("getKeyFrame", "()I", "GetGetKeyFrameHandler")]
			get {
				const string __id = "getKeyFrame.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNbSamples;
#pragma warning disable 0169
		static Delegate GetGetNbSamplesHandler ()
		{
			if (cb_getNbSamples == null)
				cb_getNbSamples = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNbSamples);
			return cb_getNbSamples;
		}

		static int n_GetNbSamples (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NbSamples;
		}
#pragma warning restore 0169

		static Delegate cb_setNbSamples_I;
#pragma warning disable 0169
		static Delegate GetSetNbSamples_IHandler ()
		{
			if (cb_setNbSamples_I == null)
				cb_setNbSamples_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetNbSamples_I);
			return cb_setNbSamples_I;
		}

		static void n_SetNbSamples_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NbSamples = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int NbSamples {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getNbSamples' and count(parameter)=0]"
			[Register ("getNbSamples", "()I", "GetGetNbSamplesHandler")]
			get {
				const string __id = "getNbSamples.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='setNbSamples' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNbSamples", "(I)V", "GetSetNbSamples_IHandler")]
			set {
				const string __id = "setNbSamples.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPTS;
#pragma warning disable 0169
		static Delegate GetGetPTSHandler ()
		{
			if (cb_getPTS == null)
				cb_getPTS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPTS);
			return cb_getPTS;
		}

		static long n_GetPTS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PTS;
		}
#pragma warning restore 0169

		static Delegate cb_setPTS_J;
#pragma warning disable 0169
		static Delegate GetSetPTS_JHandler ()
		{
			if (cb_setPTS_J == null)
				cb_setPTS_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetPTS_J);
			return cb_setPTS_J;
		}

		static void n_SetPTS_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PTS = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long PTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getPTS' and count(parameter)=0]"
			[Register ("getPTS", "()J", "GetGetPTSHandler")]
			get {
				const string __id = "getPTS.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='setPTS' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setPTS", "(J)V", "GetSetPTS_JHandler")]
			set {
				const string __id = "setPTS.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_alloc_III;
#pragma warning disable 0169
		static Delegate GetAlloc_IIIHandler ()
		{
			if (cb_alloc_III == null)
				cb_alloc_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIII_I) n_Alloc_III);
			return cb_alloc_III;
		}

		static int n_Alloc_III (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Alloc (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='alloc' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("alloc", "(III)I", "GetAlloc_IIIHandler")]
		public virtual unsafe int Alloc (int p0, int p1, int p2)
		{
			const string __id = "alloc.(III)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_copy_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_PixelFormat_II;
#pragma warning disable 0169
		static Delegate GetCopy_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_PixelFormat_IIHandler ()
		{
			if (cb_copy_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_PixelFormat_II == null)
				cb_copy_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_PixelFormat_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLII_V) n_Copy_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_PixelFormat_II);
			return cb_copy_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_PixelFormat_II;
		}

		static void n_Copy_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_PixelFormat_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, int p2, int p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.PixelFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Copy (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='copy' and count(parameter)=4 and parameter[1][@type='au.notzed.jjmpeg.AVFrame'] and parameter[2][@type='au.notzed.jjmpeg.PixelFormat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("copy", "(Lau/notzed/jjmpeg/AVFrame;Lau/notzed/jjmpeg/PixelFormat;II)V", "GetCopy_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_PixelFormat_IIHandler")]
		public virtual unsafe void Copy (global::AU.Notzed.Jjmpeg.AVFrame p0, global::AU.Notzed.Jjmpeg.PixelFormat p1, int p2, int p3)
		{
			const string __id = "copy.(Lau/notzed/jjmpeg/AVFrame;Lau/notzed/jjmpeg/PixelFormat;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lau/notzed/jjmpeg/AVFrame;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVFrame Create ()
		{
			const string __id = "create.()Lau/notzed/jjmpeg/AVFrame;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='create' and count(parameter)=3 and parameter[1][@type='au.notzed.jjmpeg.PixelFormat'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("create", "(Lau/notzed/jjmpeg/PixelFormat;II)Lau/notzed/jjmpeg/AVFrame;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVFrame Create (global::AU.Notzed.Jjmpeg.PixelFormat fmt, int width, int height)
		{
			const string __id = "create.(Lau/notzed/jjmpeg/PixelFormat;II)Lau/notzed/jjmpeg/AVFrame;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((fmt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fmt).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fmt);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='create' and count(parameter)=3 and parameter[1][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("create", "(Lau/notzed/jjmpeg/SampleFormat;II)Lau/notzed/jjmpeg/AVFrame;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVFrame Create (global::AU.Notzed.Jjmpeg.SampleFormat fmt, int channels, int samples)
		{
			const string __id = "create.(Lau/notzed/jjmpeg/SampleFormat;II)Lau/notzed/jjmpeg/AVFrame;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((fmt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fmt).Handle);
				__args [1] = new JniArgumentValue (channels);
				__args [2] = new JniArgumentValue (samples);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fmt);
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_I;
#pragma warning disable 0169
		static Delegate GetFillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_IHandler ()
		{
			if (cb_fillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_I == null)
				cb_fillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILI_V) n_FillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_I);
			return cb_fillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_I;
		}

		static void n_FillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_I (IntPtr jnienv, IntPtr native__this, int channels, IntPtr native_fmt, int samples)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fmt = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (native_fmt, JniHandleOwnership.DoNotTransfer);
			__this.FillAudioFrame (channels, fmt, samples);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='fillAudioFrame' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[3][@type='int']]"
		[Register ("fillAudioFrame", "(ILau/notzed/jjmpeg/SampleFormat;I)V", "GetFillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_IHandler")]
		public virtual unsafe void FillAudioFrame (int channels, global::AU.Notzed.Jjmpeg.SampleFormat fmt, int samples)
		{
			const string __id = "fillAudioFrame.(ILau/notzed/jjmpeg/SampleFormat;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (channels);
				__args [1] = new JniArgumentValue ((fmt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fmt).Handle);
				__args [2] = new JniArgumentValue (samples);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fmt);
			}
		}

		static Delegate cb_fillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_Ljava_nio_ByteBuffer_II;
#pragma warning disable 0169
		static Delegate GetFillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_Ljava_nio_ByteBuffer_IIHandler ()
		{
			if (cb_fillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_Ljava_nio_ByteBuffer_II == null)
				cb_fillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_Ljava_nio_ByteBuffer_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILLII_I) n_FillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_Ljava_nio_ByteBuffer_II);
			return cb_fillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_Ljava_nio_ByteBuffer_II;
		}

		static int n_FillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_Ljava_nio_ByteBuffer_II (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2, int p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (native_p1, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.FillAudioFrame (p0, p1, p2, p3, p4);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='fillAudioFrame' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("fillAudioFrame", "(ILau/notzed/jjmpeg/SampleFormat;Ljava/nio/ByteBuffer;II)I", "GetFillAudioFrame_ILau_notzed_jjmpeg_SampleFormat_Ljava_nio_ByteBuffer_IIHandler")]
		public virtual unsafe int FillAudioFrame (int p0, global::AU.Notzed.Jjmpeg.SampleFormat p1, global::Java.Nio.ByteBuffer p2, int p3, int p4)
		{
			const string __id = "fillAudioFrame.(ILau/notzed/jjmpeg/SampleFormat;Ljava/nio/ByteBuffer;II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p1);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_free;
#pragma warning disable 0169
		static Delegate GetFreeHandler ()
		{
			if (cb_free == null)
				cb_free = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Free);
			return cb_free;
		}

		static void n_Free (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Free ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='free' and count(parameter)=0]"
		[Register ("free", "()V", "GetFreeHandler")]
		public virtual unsafe void Free ()
		{
			const string __id = "free.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getFrameDefaults;
#pragma warning disable 0169
		static Delegate GetGetFrameDefaultsHandler ()
		{
			if (cb_getFrameDefaults == null)
				cb_getFrameDefaults = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_GetFrameDefaults);
			return cb_getFrameDefaults;
		}

		static void n_GetFrameDefaults (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GetFrameDefaults ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getFrameDefaults' and count(parameter)=0]"
		[Register ("getFrameDefaults", "()V", "GetGetFrameDefaultsHandler")]
		public virtual unsafe void GetFrameDefaults ()
		{
			const string __id = "getFrameDefaults.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getLineSizeAt_I;
#pragma warning disable 0169
		static Delegate GetGetLineSizeAt_IHandler ()
		{
			if (cb_getLineSizeAt_I == null)
				cb_getLineSizeAt_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetLineSizeAt_I);
			return cb_getLineSizeAt_I;
		}

		static int n_GetLineSizeAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLineSizeAt (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getLineSizeAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getLineSizeAt", "(I)I", "GetGetLineSizeAt_IHandler")]
		public virtual unsafe int GetLineSizeAt (int p0)
		{
			const string __id = "getLineSizeAt.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPlaneAt_ILau_notzed_jjmpeg_PixelFormat_II;
#pragma warning disable 0169
		static Delegate GetGetPlaneAt_ILau_notzed_jjmpeg_PixelFormat_IIHandler ()
		{
			if (cb_getPlaneAt_ILau_notzed_jjmpeg_PixelFormat_II == null)
				cb_getPlaneAt_ILau_notzed_jjmpeg_PixelFormat_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILII_L) n_GetPlaneAt_ILau_notzed_jjmpeg_PixelFormat_II);
			return cb_getPlaneAt_ILau_notzed_jjmpeg_PixelFormat_II;
		}

		static IntPtr n_GetPlaneAt_ILau_notzed_jjmpeg_PixelFormat_II (IntPtr jnienv, IntPtr native__this, int index, IntPtr native_fmt, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fmt = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.PixelFormat> (native_fmt, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPlaneAt (index, fmt, width, height));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getPlaneAt' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='au.notzed.jjmpeg.PixelFormat'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getPlaneAt", "(ILau/notzed/jjmpeg/PixelFormat;II)Lau/notzed/jjmpeg/AVPlane;", "GetGetPlaneAt_ILau_notzed_jjmpeg_PixelFormat_IIHandler")]
		public virtual unsafe global::AU.Notzed.Jjmpeg.AVPlane GetPlaneAt (int index, global::AU.Notzed.Jjmpeg.PixelFormat fmt, int width, int height)
		{
			const string __id = "getPlaneAt.(ILau/notzed/jjmpeg/PixelFormat;II)Lau/notzed/jjmpeg/AVPlane;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue ((fmt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fmt).Handle);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPlane> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (fmt);
			}
		}

		static Delegate cb_getSamples_Lau_notzed_jjmpeg_SampleFormat_IarrayS;
#pragma warning disable 0169
		static Delegate GetGetSamples_Lau_notzed_jjmpeg_SampleFormat_IarraySHandler ()
		{
			if (cb_getSamples_Lau_notzed_jjmpeg_SampleFormat_IarrayS == null)
				cb_getSamples_Lau_notzed_jjmpeg_SampleFormat_IarrayS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_I) n_GetSamples_Lau_notzed_jjmpeg_SampleFormat_IarrayS);
			return cb_getSamples_Lau_notzed_jjmpeg_SampleFormat_IarrayS;
		}

		static int n_GetSamples_Lau_notzed_jjmpeg_SampleFormat_IarrayS (IntPtr jnienv, IntPtr native__this, IntPtr native_fmt, int channels, IntPtr native_samples)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fmt = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (native_fmt, JniHandleOwnership.DoNotTransfer);
			var samples = (short[]) JNIEnv.GetArray (native_samples, JniHandleOwnership.DoNotTransfer, typeof (short));
			int __ret = __this.GetSamples (fmt, channels, samples);
			if (samples != null)
				JNIEnv.CopyArray (samples, native_samples);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='getSamples' and count(parameter)=3 and parameter[1][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[2][@type='int'] and parameter[3][@type='short[]']]"
		[Register ("getSamples", "(Lau/notzed/jjmpeg/SampleFormat;I[S)I", "GetGetSamples_Lau_notzed_jjmpeg_SampleFormat_IarraySHandler")]
		public virtual unsafe int GetSamples (global::AU.Notzed.Jjmpeg.SampleFormat fmt, int channels, short[] samples)
		{
			const string __id = "getSamples.(Lau/notzed/jjmpeg/SampleFormat;I[S)I";
			IntPtr native_samples = JNIEnv.NewArray (samples);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((fmt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fmt).Handle);
				__args [1] = new JniArgumentValue (channels);
				__args [2] = new JniArgumentValue (native_samples);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (samples != null) {
					JNIEnv.CopyArray (native_samples, samples);
					JNIEnv.DeleteLocalRef (native_samples);
				}
				global::System.GC.KeepAlive (fmt);
				global::System.GC.KeepAlive (samples);
			}
		}

		static Delegate cb_get_bitrate_enc;
#pragma warning disable 0169
		static Delegate GetGet_bitrate_encHandler ()
		{
			if (cb_get_bitrate_enc == null)
				cb_get_bitrate_enc = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Get_bitrate_enc);
			return cb_get_bitrate_enc;
		}

		static int n_Get_bitrate_enc (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_bitrate_enc ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='get_bitrate_enc' and count(parameter)=0]"
		[Register ("get_bitrate_enc", "()I", "GetGet_bitrate_encHandler")]
		public virtual unsafe int Get_bitrate_enc ()
		{
			const string __id = "get_bitrate_enc.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_loadTexture2D_Lau_notzed_jjmpeg_PixelFormat_IIZIII;
#pragma warning disable 0169
		static Delegate GetLoadTexture2D_Lau_notzed_jjmpeg_PixelFormat_IIZIIIHandler ()
		{
			if (cb_loadTexture2D_Lau_notzed_jjmpeg_PixelFormat_IIZIII == null)
				cb_loadTexture2D_Lau_notzed_jjmpeg_PixelFormat_IIZIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIZIII_V) n_LoadTexture2D_Lau_notzed_jjmpeg_PixelFormat_IIZIII);
			return cb_loadTexture2D_Lau_notzed_jjmpeg_PixelFormat_IIZIII;
		}

		static void n_LoadTexture2D_Lau_notzed_jjmpeg_PixelFormat_IIZIII (IntPtr jnienv, IntPtr native__this, IntPtr native_fmt, int width, int height, bool create, int tex0, int tex1, int tex2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fmt = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.PixelFormat> (native_fmt, JniHandleOwnership.DoNotTransfer);
			__this.LoadTexture2D (fmt, width, height, create, tex0, tex1, tex2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='loadTexture2D' and count(parameter)=7 and parameter[1][@type='au.notzed.jjmpeg.PixelFormat'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='boolean'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int']]"
		[Register ("loadTexture2D", "(Lau/notzed/jjmpeg/PixelFormat;IIZIII)V", "GetLoadTexture2D_Lau_notzed_jjmpeg_PixelFormat_IIZIIIHandler")]
		public virtual unsafe void LoadTexture2D (global::AU.Notzed.Jjmpeg.PixelFormat fmt, int width, int height, bool create, int tex0, int tex1, int tex2)
		{
			const string __id = "loadTexture2D.(Lau/notzed/jjmpeg/PixelFormat;IIZIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((fmt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fmt).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				__args [3] = new JniArgumentValue (create);
				__args [4] = new JniArgumentValue (tex0);
				__args [5] = new JniArgumentValue (tex1);
				__args [6] = new JniArgumentValue (tex2);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (fmt);
			}
		}

		static Delegate cb_set_bitrate_enc_I;
#pragma warning disable 0169
		static Delegate GetSet_bitrate_enc_IHandler ()
		{
			if (cb_set_bitrate_enc_I == null)
				cb_set_bitrate_enc_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Set_bitrate_enc_I);
			return cb_set_bitrate_enc_I;
		}

		static void n_Set_bitrate_enc_I (IntPtr jnienv, IntPtr native__this, int bitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Set_bitrate_enc (bitrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFrame']/method[@name='set_bitrate_enc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("set_bitrate_enc", "(I)V", "GetSet_bitrate_enc_IHandler")]
		public virtual unsafe void Set_bitrate_enc (int bitrate)
		{
			const string __id = "set_bitrate_enc.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitrate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
