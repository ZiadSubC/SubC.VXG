using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVIOContext", DoNotGenerateAcw=true)]
	public abstract partial class AVIOContext : global::AU.Notzed.Jjmpeg.AVObject {
		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='ALLOC_STREAMED']"
		[Register ("ALLOC_STREAMED")]
		public const int AllocStreamed = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='ALLOC_WRITE']"
		[Register ("ALLOC_WRITE")]
		public const int AllocWrite = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='AVSEEK_SIZE']"
		[Register ("AVSEEK_SIZE")]
		public const int AvseekSize = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='SEEK_CUR']"
		[Register ("SEEK_CUR")]
		public const int SeekCur = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='SEEK_END']"
		[Register ("SEEK_END")]
		public const int SeekEnd = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='SEEK_SET']"
		[Register ("SEEK_SET")]
		public const int SeekSet = (int) 0;


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='URL_RDONLY']"
		[Register ("URL_RDONLY")]
		public static int UrlRdonly {
			get {
				const string __id = "URL_RDONLY.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='URL_RDWR']"
		[Register ("URL_RDWR")]
		public static int UrlRdwr {
			get {
				const string __id = "URL_RDWR.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/field[@name='URL_WRONLY']"
		[Register ("URL_WRONLY")]
		public static int UrlWronly {
			get {
				const string __id = "URL_WRONLY.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVIOContext", typeof (AVIOContext));

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

		protected AVIOContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/constructor[@name='AVIOContext' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe AVIOContext (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/constructor[@name='AVIOContext' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe AVIOContext (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/method[@name='allocContext' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("allocContext", "(II)Lau/notzed/jjmpeg/AVIOContext;", "")]
		protected static unsafe global::AU.Notzed.Jjmpeg.AVIOContext AllocContext (int size, int flags)
		{
			const string __id = "allocContext.(II)Lau/notzed/jjmpeg/AVIOContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (size);
				__args [1] = new JniArgumentValue (flags);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Close);
			return cb_close;
		}

		static int n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()I", "GetCloseHandler")]
		public virtual unsafe int Close ()
		{
			const string __id = "close.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/method[@name='open' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("open", "(Ljava/lang/String;I)Lau/notzed/jjmpeg/AVIOContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVIOContext Open (string url, int flags)
		{
			const string __id = "open.(Ljava/lang/String;I)Lau/notzed/jjmpeg/AVIOContext;";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_url);
				__args [1] = new JniArgumentValue (flags);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_probeInput_Ljava_lang_String_II;
#pragma warning disable 0169
		static Delegate GetProbeInput_Ljava_lang_String_IIHandler ()
		{
			if (cb_probeInput_Ljava_lang_String_II == null)
				cb_probeInput_Ljava_lang_String_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_ProbeInput_Ljava_lang_String_II);
			return cb_probeInput_Ljava_lang_String_II;
		}

		static IntPtr n_ProbeInput_Ljava_lang_String_II (IntPtr jnienv, IntPtr native__this, IntPtr native_filename, int offset, int max_probe_size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ProbeInput (filename, offset, max_probe_size));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/method[@name='probeInput' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("probeInput", "(Ljava/lang/String;II)Lau/notzed/jjmpeg/AVInputFormat;", "GetProbeInput_Ljava_lang_String_IIHandler")]
		public virtual unsafe global::AU.Notzed.Jjmpeg.AVInputFormat ProbeInput (string filename, int offset, int max_probe_size)
		{
			const string __id = "probeInput.(Ljava/lang/String;II)Lau/notzed/jjmpeg/AVInputFormat;";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_filename);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (max_probe_size);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVInputFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_readPacket_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetReadPacket_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_readPacket_Ljava_nio_ByteBuffer_ == null)
				cb_readPacket_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_ReadPacket_Ljava_nio_ByteBuffer_);
			return cb_readPacket_Ljava_nio_ByteBuffer_;
		}

		static int n_ReadPacket_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dst)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dst = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_dst, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadPacket (dst);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/method[@name='readPacket' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("readPacket", "(Ljava/nio/ByteBuffer;)I", "GetReadPacket_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int ReadPacket (global::Java.Nio.ByteBuffer dst)
		{
			const string __id = "readPacket.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (dst);
			}
		}

		static Delegate cb_seek_JI;
#pragma warning disable 0169
		static Delegate GetSeek_JIHandler ()
		{
			if (cb_seek_JI == null)
				cb_seek_JI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJI_J) n_Seek_JI);
			return cb_seek_JI;
		}

		static long n_Seek_JI (IntPtr jnienv, IntPtr native__this, long offset, int whence)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Seek (offset, whence);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/method[@name='seek' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("seek", "(JI)J", "GetSeek_JIHandler")]
		public virtual unsafe long Seek (long offset, int whence)
		{
			const string __id = "seek.(JI)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (offset);
				__args [1] = new JniArgumentValue (whence);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_writePacket_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetWritePacket_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_writePacket_Ljava_nio_ByteBuffer_ == null)
				cb_writePacket_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_WritePacket_Ljava_nio_ByteBuffer_);
			return cb_writePacket_Ljava_nio_ByteBuffer_;
		}

		static int n_WritePacket_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_src, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.WritePacket (src);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVIOContext']/method[@name='writePacket' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("writePacket", "(Ljava/nio/ByteBuffer;)I", "GetWritePacket_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe int WritePacket (global::Java.Nio.ByteBuffer src)
		{
			const string __id = "writePacket.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

	}

	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVIOContext", DoNotGenerateAcw=true)]
	internal partial class AVIOContextInvoker : AVIOContext {
		public AVIOContextInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVIOContext", typeof (AVIOContextInvoker));

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

	}
}
