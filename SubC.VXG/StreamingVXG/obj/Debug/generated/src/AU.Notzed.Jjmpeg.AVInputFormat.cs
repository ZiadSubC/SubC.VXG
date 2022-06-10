using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVInputFormat']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVInputFormat", DoNotGenerateAcw=true)]
	public partial class AVInputFormat : global::AU.Notzed.Jjmpeg.AVObject, global::AU.Notzed.Jjmpeg.IAVFormat {
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVInputFormat", typeof (AVInputFormat));

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

		protected AVInputFormat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVInputFormat']/constructor[@name='AVInputFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe AVInputFormat (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVInputFormat']/constructor[@name='AVInputFormat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe AVInputFormat (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVInputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags;
		}
#pragma warning restore 0169

		public virtual unsafe int Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVInputFormat']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVInputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LongName);
		}
#pragma warning restore 0169

		public virtual unsafe string LongName {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVInputFormat']/method[@name='getLongName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVInputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Name);
		}
#pragma warning restore 0169

		public virtual unsafe string Name {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVInputFormat']/method[@name='getName' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVInputFormat> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVInputFormat']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
