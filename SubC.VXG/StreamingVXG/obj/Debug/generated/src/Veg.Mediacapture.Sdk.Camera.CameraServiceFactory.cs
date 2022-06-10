using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraServiceFactory']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraServiceFactory", DoNotGenerateAcw=true)]
	public partial class CameraServiceFactory : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraServiceFactory", typeof (CameraServiceFactory));

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

		protected CameraServiceFactory (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraServiceFactory']/constructor[@name='CameraServiceFactory' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CameraServiceFactory () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraServiceFactory']/method[@name='build' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int'] and parameter[3][@type='java.lang.Object']]"
		[Register ("build", "(Landroid/content/Context;ILjava/lang/Object;)Lveg/mediacapture/sdk/camera/CameraService;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Camera.ICameraService Build (global::Android.Content.Context context, int api, global::Java.Lang.Object external)
		{
			const string __id = "build.(Landroid/content/Context;ILjava/lang/Object;)Lveg/mediacapture/sdk/camera/CameraService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (api);
				__args [2] = new JniArgumentValue ((external == null) ? IntPtr.Zero : ((global::Java.Lang.Object) external).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (external);
			}
		}

	}
}