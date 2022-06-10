using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Camera {

	// Metadata.xml XPath interface reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='ExternalCameraDelegate']"
	[Register ("veg/mediacapture/sdk/camera/ExternalCameraDelegate", "", "Veg.Mediacapture.Sdk.Camera.IExternalCameraDelegateInvoker")]
	public partial interface IExternalCameraDelegate : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='ExternalCameraDelegate']/method[@name='requestCamera' and count(parameter)=0]"
		[Register ("requestCamera", "()Ljava/lang/Object;", "GetRequestCameraHandler:Veg.Mediacapture.Sdk.Camera.IExternalCameraDelegateInvoker, StreamingVXG")]
		global::Java.Lang.Object RequestCamera ();

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/ExternalCameraDelegate", DoNotGenerateAcw=true)]
	internal partial class IExternalCameraDelegateInvoker : global::Java.Lang.Object, IExternalCameraDelegate {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/ExternalCameraDelegate", typeof (IExternalCameraDelegateInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IExternalCameraDelegate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IExternalCameraDelegate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'veg.mediacapture.sdk.camera.ExternalCameraDelegate'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IExternalCameraDelegateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_requestCamera;
#pragma warning disable 0169
		static Delegate GetRequestCameraHandler ()
		{
			if (cb_requestCamera == null)
				cb_requestCamera = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_RequestCamera);
			return cb_requestCamera;
		}

		static IntPtr n_RequestCamera (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.IExternalCameraDelegate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RequestCamera ());
		}
#pragma warning restore 0169

		IntPtr id_requestCamera;
		public unsafe global::Java.Lang.Object RequestCamera ()
		{
			if (id_requestCamera == IntPtr.Zero)
				id_requestCamera = JNIEnv.GetMethodID (class_ref, "requestCamera", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_requestCamera), JniHandleOwnership.TransferLocalRef);
		}

	}
}
