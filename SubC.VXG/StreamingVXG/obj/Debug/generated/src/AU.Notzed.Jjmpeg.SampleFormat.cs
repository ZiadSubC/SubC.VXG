using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/SampleFormat", DoNotGenerateAcw=true)]
	public abstract partial class SampleFormat : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/field[@name='SAMPLE_FMT_DBL']"
		[Register ("SAMPLE_FMT_DBL")]
		public static global::AU.Notzed.Jjmpeg.SampleFormat SampleFmtDbl {
			get {
				const string __id = "SAMPLE_FMT_DBL.Lau/notzed/jjmpeg/SampleFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/field[@name='SAMPLE_FMT_FLT']"
		[Register ("SAMPLE_FMT_FLT")]
		public static global::AU.Notzed.Jjmpeg.SampleFormat SampleFmtFlt {
			get {
				const string __id = "SAMPLE_FMT_FLT.Lau/notzed/jjmpeg/SampleFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/field[@name='SAMPLE_FMT_NONE']"
		[Register ("SAMPLE_FMT_NONE")]
		public static global::AU.Notzed.Jjmpeg.SampleFormat SampleFmtNone {
			get {
				const string __id = "SAMPLE_FMT_NONE.Lau/notzed/jjmpeg/SampleFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/field[@name='SAMPLE_FMT_S16']"
		[Register ("SAMPLE_FMT_S16")]
		public static global::AU.Notzed.Jjmpeg.SampleFormat SampleFmtS16 {
			get {
				const string __id = "SAMPLE_FMT_S16.Lau/notzed/jjmpeg/SampleFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/field[@name='SAMPLE_FMT_S32']"
		[Register ("SAMPLE_FMT_S32")]
		public static global::AU.Notzed.Jjmpeg.SampleFormat SampleFmtS32 {
			get {
				const string __id = "SAMPLE_FMT_S32.Lau/notzed/jjmpeg/SampleFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/field[@name='SAMPLE_FMT_U8']"
		[Register ("SAMPLE_FMT_U8")]
		public static global::AU.Notzed.Jjmpeg.SampleFormat SampleFmtU8 {
			get {
				const string __id = "SAMPLE_FMT_U8.Lau/notzed/jjmpeg/SampleFormat;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/SampleFormat", typeof (SampleFormat));

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

		protected SampleFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getByteSize;
#pragma warning disable 0169
		static Delegate GetGetByteSizeHandler ()
		{
			if (cb_getByteSize == null)
				cb_getByteSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetByteSize);
			return cb_getByteSize;
		}

		static int n_GetByteSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ByteSize;
		}
#pragma warning restore 0169

		public abstract int ByteSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='getByteSize' and count(parameter)=0]"
			[Register ("getByteSize", "()I", "GetGetByteSizeHandler")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='fromC' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromC", "(I)Lau/notzed/jjmpeg/SampleFormat;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.SampleFormat FromC (int fmtid)
		{
			const string __id = "fromC.(I)Lau/notzed/jjmpeg/SampleFormat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fmtid);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getBuffer_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetGetBuffer_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_getBuffer_Ljava_nio_ByteBuffer_ == null)
				cb_getBuffer_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetBuffer_Ljava_nio_ByteBuffer_);
			return cb_getBuffer_Ljava_nio_ByteBuffer_;
		}

		static IntPtr n_GetBuffer_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBuffer (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='getBuffer' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getBuffer", "(Ljava/nio/ByteBuffer;)Ljava/nio/Buffer;", "GetGetBuffer_Ljava_nio_ByteBuffer_Handler")]
		public abstract global::Java.Nio.Buffer GetBuffer (global::Java.Nio.ByteBuffer p0);

		static Delegate cb_toC;
#pragma warning disable 0169
		static Delegate GetToCHandler ()
		{
			if (cb_toC == null)
				cb_toC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_ToC);
			return cb_toC;
		}

		static int n_ToC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ToC ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='toC' and count(parameter)=0]"
		[Register ("toC", "()I", "GetToCHandler")]
		public virtual unsafe int ToC ()
		{
			const string __id = "toC.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='toC' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.SampleFormat']]"
		[Register ("toC", "(Lau/notzed/jjmpeg/SampleFormat;)I", "")]
		public static unsafe int ToC (global::AU.Notzed.Jjmpeg.SampleFormat p)
		{
			const string __id = "toC.(Lau/notzed/jjmpeg/SampleFormat;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lau/notzed/jjmpeg/SampleFormat;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.SampleFormat ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lau/notzed/jjmpeg/SampleFormat;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lau/notzed/jjmpeg/SampleFormat;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.SampleFormat[] Values ()
		{
			const string __id = "values.()[Lau/notzed/jjmpeg/SampleFormat;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::AU.Notzed.Jjmpeg.SampleFormat[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::AU.Notzed.Jjmpeg.SampleFormat));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("au/notzed/jjmpeg/SampleFormat", DoNotGenerateAcw=true)]
	internal partial class SampleFormatInvoker : SampleFormat {
		public SampleFormatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/SampleFormat", typeof (SampleFormatInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int ByteSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='getByteSize' and count(parameter)=0]"
			[Register ("getByteSize", "()I", "GetGetByteSizeHandler")]
			get {
				const string __id = "getByteSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SampleFormat']/method[@name='getBuffer' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getBuffer", "(Ljava/nio/ByteBuffer;)Ljava/nio/Buffer;", "GetGetBuffer_Ljava_nio_ByteBuffer_Handler")]
		public override unsafe global::Java.Nio.Buffer GetBuffer (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "getBuffer.(Ljava/nio/ByteBuffer;)Ljava/nio/Buffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}
}
