using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='Utils']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/api/Utils", DoNotGenerateAcw=true)]
	public partial class Utils : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/api/Utils", typeof (Utils));

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

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='Utils']/method[@name='bytesToHex' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("bytesToHex", "([B)Ljava/lang/String;", "")]
		public static unsafe string BytesToHex (byte[] bytes)
		{
			const string __id = "bytesToHex.([B)Ljava/lang/String;";
			IntPtr native_bytes = JNIEnv.NewArray (bytes);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_bytes);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bytes != null) {
					JNIEnv.CopyArray (native_bytes, bytes);
					JNIEnv.DeleteLocalRef (native_bytes);
				}
				global::System.GC.KeepAlive (bytes);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='Utils']/method[@name='getIPAddress' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("getIPAddress", "(Z)Ljava/lang/String;", "")]
		public static unsafe string GetIPAddress (bool useIPv4)
		{
			const string __id = "getIPAddress.(Z)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (useIPv4);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='Utils']/method[@name='getMACAddress' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getMACAddress", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string GetMACAddress (string interfaceName)
		{
			const string __id = "getMACAddress.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_interfaceName = JNIEnv.NewString (interfaceName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_interfaceName);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_interfaceName);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='Utils']/method[@name='getUTF8Bytes' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getUTF8Bytes", "(Ljava/lang/String;)[B", "")]
		public static unsafe byte[] GetUTF8Bytes (string str)
		{
			const string __id = "getUTF8Bytes.(Ljava/lang/String;)[B";
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='Utils']/method[@name='loadFileAsString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadFileAsString", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string LoadFileAsString (string filename)
		{
			const string __id = "loadFileAsString.(Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_filename);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

	}
}
