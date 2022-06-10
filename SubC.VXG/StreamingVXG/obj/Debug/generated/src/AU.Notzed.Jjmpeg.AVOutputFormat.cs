using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVOutputFormat", DoNotGenerateAcw=true)]
	public partial class AVOutputFormat : global::AU.Notzed.Jjmpeg.AVObject, global::AU.Notzed.Jjmpeg.IAVFormat {
		public static class InterfaceConsts {
			// The following are fields from: au.notzed.jjmpeg.AVFormat

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_ALLOW_FLUSH']"
			[Register ("AVFMT_ALLOW_FLUSH")]
			public const int AvfmtAllowFlush = (int) 65536;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_GENERIC_INDEX']"
			[Register ("AVFMT_GENERIC_INDEX")]
			public const int AvfmtGenericIndex = (int) 256;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_GLOBALHEADER']"
			[Register ("AVFMT_GLOBALHEADER")]
			public const int AvfmtGlobalheader = (int) 64;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NEEDNUMBER']"
			[Register ("AVFMT_NEEDNUMBER")]
			public const int AvfmtNeednumber = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOBINSEARCH']"
			[Register ("AVFMT_NOBINSEARCH")]
			public const int AvfmtNobinsearch = (int) 8192;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NODIMENSIONS']"
			[Register ("AVFMT_NODIMENSIONS")]
			public const int AvfmtNodimensions = (int) 2048;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOFILE']"
			[Register ("AVFMT_NOFILE")]
			public const int AvfmtNofile = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOGENSEARCH']"
			[Register ("AVFMT_NOGENSEARCH")]
			public const int AvfmtNogensearch = (int) 16384;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOSTREAMS']"
			[Register ("AVFMT_NOSTREAMS")]
			public const int AvfmtNostreams = (int) 4096;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOTIMESTAMPS']"
			[Register ("AVFMT_NOTIMESTAMPS")]
			public const int AvfmtNotimestamps = (int) 128;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NO_BYTE_SEEK']"
			[Register ("AVFMT_NO_BYTE_SEEK")]
			public const int AvfmtNoByteSeek = (int) 32768;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_RAWPICTURE']"
			[Register ("AVFMT_RAWPICTURE")]
			public const int AvfmtRawpicture = (int) 32;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_SHOW_IDS']"
			[Register ("AVFMT_SHOW_IDS")]
			public const int AvfmtShowIds = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_TS_DISCONT']"
			[Register ("AVFMT_TS_DISCONT")]
			public const int AvfmtTsDiscont = (int) 512;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_TS_NONSTRICT']"
			[Register ("AVFMT_TS_NONSTRICT")]
			public const int AvfmtTsNonstrict = (int) 134217728;

			// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_VARIABLE_FPS']"
			[Register ("AVFMT_VARIABLE_FPS")]
			public const int AvfmtVariableFps = (int) 1024;

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVOutputFormat", typeof (AVOutputFormat));

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

		protected AVOutputFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/constructor[@name='AVOutputFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe AVOutputFormat (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/constructor[@name='AVOutputFormat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe AVOutputFormat (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAudioCodec;
#pragma warning disable 0169
		static Delegate GetGetAudioCodecHandler ()
		{
			if (cb_getAudioCodec == null)
				cb_getAudioCodec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioCodec);
			return cb_getAudioCodec;
		}

		static int n_GetAudioCodec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioCodec;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioCodec {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='getAudioCodec' and count(parameter)=0]"
			[Register ("getAudioCodec", "()I", "GetGetAudioCodecHandler")]
			get {
				const string __id = "getAudioCodec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getExtensions;
#pragma warning disable 0169
		static Delegate GetGetExtensionsHandler ()
		{
			if (cb_getExtensions == null)
				cb_getExtensions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetExtensions);
			return cb_getExtensions;
		}

		static IntPtr n_GetExtensions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Extensions);
		}
#pragma warning restore 0169

		public virtual unsafe string Extensions {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='getExtensions' and count(parameter)=0]"
			[Register ("getExtensions", "()Ljava/lang/String;", "GetGetExtensionsHandler")]
			get {
				const string __id = "getExtensions.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFlags);
			return cb_getFlags;
		}

		static int n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags;
		}
#pragma warning restore 0169

		static Delegate cb_setFlags_I;
#pragma warning disable 0169
		static Delegate GetSetFlags_IHandler ()
		{
			if (cb_setFlags_I == null)
				cb_setFlags_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetFlags_I);
			return cb_setFlags_I;
		}

		static void n_SetFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flags = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFlags", "(I)V", "GetSetFlags_IHandler")]
			set {
				const string __id = "setFlags.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLongName;
#pragma warning disable 0169
		static Delegate GetGetLongNameHandler ()
		{
			if (cb_getLongName == null)
				cb_getLongName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLongName);
			return cb_getLongName;
		}

		static IntPtr n_GetLongName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LongName);
		}
#pragma warning restore 0169

		public virtual unsafe string LongName {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='getLongName' and count(parameter)=0]"
			[Register ("getLongName", "()Ljava/lang/String;", "GetGetLongNameHandler")]
			get {
				const string __id = "getLongName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMimeType;
#pragma warning disable 0169
		static Delegate GetGetMimeTypeHandler ()
		{
			if (cb_getMimeType == null)
				cb_getMimeType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMimeType);
			return cb_getMimeType;
		}

		static IntPtr n_GetMimeType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MimeType);
		}
#pragma warning restore 0169

		public virtual unsafe string MimeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='getMimeType' and count(parameter)=0]"
			[Register ("getMimeType", "()Ljava/lang/String;", "GetGetMimeTypeHandler")]
			get {
				const string __id = "getMimeType.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getName;
#pragma warning disable 0169
		static Delegate GetGetNameHandler ()
		{
			if (cb_getName == null)
				cb_getName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetName);
			return cb_getName;
		}

		static IntPtr n_GetName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='getName' and count(parameter)=0]"
			[Register ("getName", "()Ljava/lang/String;", "GetGetNameHandler")]
			get {
				const string __id = "getName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSubtitleCodec;
#pragma warning disable 0169
		static Delegate GetGetSubtitleCodecHandler ()
		{
			if (cb_getSubtitleCodec == null)
				cb_getSubtitleCodec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSubtitleCodec);
			return cb_getSubtitleCodec;
		}

		static int n_GetSubtitleCodec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SubtitleCodec;
		}
#pragma warning restore 0169

		public virtual unsafe int SubtitleCodec {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='getSubtitleCodec' and count(parameter)=0]"
			[Register ("getSubtitleCodec", "()I", "GetGetSubtitleCodecHandler")]
			get {
				const string __id = "getSubtitleCodec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVideoCodec;
#pragma warning disable 0169
		static Delegate GetGetVideoCodecHandler ()
		{
			if (cb_getVideoCodec == null)
				cb_getVideoCodec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoCodec);
			return cb_getVideoCodec;
		}

		static int n_GetVideoCodec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoCodec;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoCodec {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='getVideoCodec' and count(parameter)=0]"
			[Register ("getVideoCodec", "()I", "GetGetVideoCodecHandler")]
			get {
				const string __id = "getVideoCodec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormat']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVOutputFormatAbstract']/method[@name='guessFormat' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("guessFormat", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lau/notzed/jjmpeg/AVOutputFormat;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVOutputFormat GuessFormat (string short_name, string filename, string mime_type)
		{
			const string __id = "guessFormat.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lau/notzed/jjmpeg/AVOutputFormat;";
			IntPtr native_short_name = JNIEnv.NewString (short_name);
			IntPtr native_filename = JNIEnv.NewString (filename);
			IntPtr native_mime_type = JNIEnv.NewString (mime_type);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_short_name);
				__args [1] = new JniArgumentValue (native_filename);
				__args [2] = new JniArgumentValue (native_mime_type);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_short_name);
				JNIEnv.DeleteLocalRef (native_filename);
				JNIEnv.DeleteLocalRef (native_mime_type);
			}
		}

	}
}
