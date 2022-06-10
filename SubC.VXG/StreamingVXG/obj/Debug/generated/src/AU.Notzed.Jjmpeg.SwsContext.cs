using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/SwsContext", DoNotGenerateAcw=true)]
	public partial class SwsContext : global::AU.Notzed.Jjmpeg.AVObject {
		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_AREA']"
		[Register ("SWS_AREA")]
		public const int SwsArea = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_BICUBIC']"
		[Register ("SWS_BICUBIC")]
		public const int SwsBicubic = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_BICUBLIN']"
		[Register ("SWS_BICUBLIN")]
		public const int SwsBicublin = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_BILINEAR']"
		[Register ("SWS_BILINEAR")]
		public const int SwsBilinear = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_FAST_BILINEAR']"
		[Register ("SWS_FAST_BILINEAR")]
		public const int SwsFastBilinear = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_GAUSS']"
		[Register ("SWS_GAUSS")]
		public const int SwsGauss = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_LANCZOS']"
		[Register ("SWS_LANCZOS")]
		public const int SwsLanczos = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_POINT']"
		[Register ("SWS_POINT")]
		public const int SwsPoint = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_SINC']"
		[Register ("SWS_SINC")]
		public const int SwsSinc = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_SPLINE']"
		[Register ("SWS_SPLINE")]
		public const int SwsSpline = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/field[@name='SWS_X']"
		[Register ("SWS_X")]
		public const int SwsX = (int) 8;

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/SwsContext", typeof (SwsContext));

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

		protected SwsContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/constructor[@name='SwsContext' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe SwsContext (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/constructor[@name='SwsContext' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe SwsContext (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/method[@name='create' and count(parameter)=7 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='au.notzed.jjmpeg.PixelFormat'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='au.notzed.jjmpeg.PixelFormat'] and parameter[7][@type='int']]"
		[Register ("create", "(IILau/notzed/jjmpeg/PixelFormat;IILau/notzed/jjmpeg/PixelFormat;I)Lau/notzed/jjmpeg/SwsContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.SwsContext Create (int srcW, int srcH, global::AU.Notzed.Jjmpeg.PixelFormat srcFormat, int dstW, int dstH, global::AU.Notzed.Jjmpeg.PixelFormat dstFormat, int flags)
		{
			const string __id = "create.(IILau/notzed/jjmpeg/PixelFormat;IILau/notzed/jjmpeg/PixelFormat;I)Lau/notzed/jjmpeg/SwsContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (srcW);
				__args [1] = new JniArgumentValue (srcH);
				__args [2] = new JniArgumentValue ((srcFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcFormat).Handle);
				__args [3] = new JniArgumentValue (dstW);
				__args [4] = new JniArgumentValue (dstH);
				__args [5] = new JniArgumentValue ((dstFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstFormat).Handle);
				__args [6] = new JniArgumentValue (flags);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwsContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (srcFormat);
				global::System.GC.KeepAlive (dstFormat);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_freeContext;
#pragma warning disable 0169
		static Delegate GetFreeContextHandler ()
		{
			if (cb_freeContext == null)
				cb_freeContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FreeContext);
			return cb_freeContext;
		}

		static void n_FreeContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreeContext ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/method[@name='freeContext' and count(parameter)=0]"
		[Register ("freeContext", "()V", "GetFreeContextHandler")]
		public virtual unsafe void FreeContext ()
		{
			const string __id = "freeContext.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_scale_Lau_notzed_jjmpeg_AVFrame_IILau_notzed_jjmpeg_AVFrame_;
#pragma warning disable 0169
		static Delegate GetScale_Lau_notzed_jjmpeg_AVFrame_IILau_notzed_jjmpeg_AVFrame_Handler ()
		{
			if (cb_scale_Lau_notzed_jjmpeg_AVFrame_IILau_notzed_jjmpeg_AVFrame_ == null)
				cb_scale_Lau_notzed_jjmpeg_AVFrame_IILau_notzed_jjmpeg_AVFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_I) n_Scale_Lau_notzed_jjmpeg_AVFrame_IILau_notzed_jjmpeg_AVFrame_);
			return cb_scale_Lau_notzed_jjmpeg_AVFrame_IILau_notzed_jjmpeg_AVFrame_;
		}

		static int n_Scale_Lau_notzed_jjmpeg_AVFrame_IILau_notzed_jjmpeg_AVFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src, int srcSliceY, int srcSliceH, IntPtr native_dst)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_src, JniHandleOwnership.DoNotTransfer);
			var dst = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Scale (src, srcSliceY, srcSliceH, dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/method[@name='scale' and count(parameter)=4 and parameter[1][@type='au.notzed.jjmpeg.AVFrame'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='au.notzed.jjmpeg.AVFrame']]"
		[Register ("scale", "(Lau/notzed/jjmpeg/AVFrame;IILau/notzed/jjmpeg/AVFrame;)I", "GetScale_Lau_notzed_jjmpeg_AVFrame_IILau_notzed_jjmpeg_AVFrame_Handler")]
		public virtual unsafe int Scale (global::AU.Notzed.Jjmpeg.AVFrame src, int srcSliceY, int srcSliceH, global::AU.Notzed.Jjmpeg.AVFrame dst)
		{
			const string __id = "scale.(Lau/notzed/jjmpeg/AVFrame;IILau/notzed/jjmpeg/AVFrame;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (srcSliceY);
				__args [2] = new JniArgumentValue (srcSliceH);
				__args [3] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (dst);
			}
		}

		static Delegate cb_scale_Lau_notzed_jjmpeg_AVFrame_IIarrayB;
#pragma warning disable 0169
		static Delegate GetScale_Lau_notzed_jjmpeg_AVFrame_IIarrayBHandler ()
		{
			if (cb_scale_Lau_notzed_jjmpeg_AVFrame_IIarrayB == null)
				cb_scale_Lau_notzed_jjmpeg_AVFrame_IIarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_I) n_Scale_Lau_notzed_jjmpeg_AVFrame_IIarrayB);
			return cb_scale_Lau_notzed_jjmpeg_AVFrame_IIarrayB;
		}

		static int n_Scale_Lau_notzed_jjmpeg_AVFrame_IIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_src, int srcSliceY, int srcSliceH, IntPtr native_dst)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_src, JniHandleOwnership.DoNotTransfer);
			var dst = (byte[]) JNIEnv.GetArray (native_dst, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Scale (src, srcSliceY, srcSliceH, dst);
			if (dst != null)
				JNIEnv.CopyArray (dst, native_dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/method[@name='scale' and count(parameter)=4 and parameter[1][@type='au.notzed.jjmpeg.AVFrame'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='byte[]']]"
		[Register ("scale", "(Lau/notzed/jjmpeg/AVFrame;II[B)I", "GetScale_Lau_notzed_jjmpeg_AVFrame_IIarrayBHandler")]
		public virtual unsafe int Scale (global::AU.Notzed.Jjmpeg.AVFrame src, int srcSliceY, int srcSliceH, byte[] dst)
		{
			const string __id = "scale.(Lau/notzed/jjmpeg/AVFrame;II[B)I";
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (srcSliceY);
				__args [2] = new JniArgumentValue (srcSliceH);
				__args [3] = new JniArgumentValue (native_dst);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (dst);
			}
		}

		static Delegate cb_scale_Lau_notzed_jjmpeg_AVFrame_IIarrayI;
#pragma warning disable 0169
		static Delegate GetScale_Lau_notzed_jjmpeg_AVFrame_IIarrayIHandler ()
		{
			if (cb_scale_Lau_notzed_jjmpeg_AVFrame_IIarrayI == null)
				cb_scale_Lau_notzed_jjmpeg_AVFrame_IIarrayI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIL_I) n_Scale_Lau_notzed_jjmpeg_AVFrame_IIarrayI);
			return cb_scale_Lau_notzed_jjmpeg_AVFrame_IIarrayI;
		}

		static int n_Scale_Lau_notzed_jjmpeg_AVFrame_IIarrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_src, int srcSliceY, int srcSliceH, IntPtr native_dst)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwsContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_src, JniHandleOwnership.DoNotTransfer);
			var dst = (int[]) JNIEnv.GetArray (native_dst, JniHandleOwnership.DoNotTransfer, typeof (int));
			int __ret = __this.Scale (src, srcSliceY, srcSliceH, dst);
			if (dst != null)
				JNIEnv.CopyArray (dst, native_dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwsContext']/method[@name='scale' and count(parameter)=4 and parameter[1][@type='au.notzed.jjmpeg.AVFrame'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int[]']]"
		[Register ("scale", "(Lau/notzed/jjmpeg/AVFrame;II[I)I", "GetScale_Lau_notzed_jjmpeg_AVFrame_IIarrayIHandler")]
		public virtual unsafe int Scale (global::AU.Notzed.Jjmpeg.AVFrame src, int srcSliceY, int srcSliceH, int[] dst)
		{
			const string __id = "scale.(Lau/notzed/jjmpeg/AVFrame;II[I)I";
			IntPtr native_dst = JNIEnv.NewArray (dst);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				__args [1] = new JniArgumentValue (srcSliceY);
				__args [2] = new JniArgumentValue (srcSliceH);
				__args [3] = new JniArgumentValue (native_dst);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (dst != null) {
					JNIEnv.CopyArray (native_dst, dst);
					JNIEnv.DeleteLocalRef (native_dst);
				}
				global::System.GC.KeepAlive (src);
				global::System.GC.KeepAlive (dst);
			}
		}

	}
}
