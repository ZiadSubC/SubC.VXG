using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg.exception']/class[@name='AVIOException']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/exception/AVIOException", DoNotGenerateAcw=true)]
	public partial class AVIOException : global::Java.IO.IOException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/exception/AVIOException", typeof (AVIOException));

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

		protected AVIOException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg.exception']/class[@name='AVIOException']/constructor[@name='AVIOException' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AVIOException (int errno) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (errno);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg.exception']/class[@name='AVIOException']/constructor[@name='AVIOException' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(ILjava/lang/String;)V", "")]
		public unsafe AVIOException (int errno, string what) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_what = JNIEnv.NewString (what);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (errno);
				__args [1] = new JniArgumentValue (native_what);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_what);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg.exception']/class[@name='AVIOException']/constructor[@name='AVIOException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe AVIOException (string what) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_what = JNIEnv.NewString (what);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_what);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_what);
			}
		}

	}
}
