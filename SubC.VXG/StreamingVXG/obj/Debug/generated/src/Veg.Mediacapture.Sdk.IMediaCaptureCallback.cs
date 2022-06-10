using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='MediaCaptureCallback']"
	[Register ("veg/mediacapture/sdk/MediaCaptureCallback", "", "Veg.Mediacapture.Sdk.IMediaCaptureCallbackInvoker")]
	public partial interface IMediaCaptureCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='MediaCaptureCallback']/method[@name='OnCaptureReceiveData' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("OnCaptureReceiveData", "(Ljava/nio/ByteBuffer;IIJ)I", "GetOnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJHandler:Veg.Mediacapture.Sdk.IMediaCaptureCallbackInvoker, StreamingVXG")]
		int OnCaptureReceiveData (global::Java.Nio.ByteBuffer p0, int p1, int p2, long p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='MediaCaptureCallback']/method[@name='OnCaptureStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("OnCaptureStatus", "(I)I", "GetOnCaptureStatus_IHandler:Veg.Mediacapture.Sdk.IMediaCaptureCallbackInvoker, StreamingVXG")]
		int OnCaptureStatus (int p0);

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureCallback", DoNotGenerateAcw=true)]
	internal partial class IMediaCaptureCallbackInvoker : global::Java.Lang.Object, IMediaCaptureCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureCallback", typeof (IMediaCaptureCallbackInvoker));

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

		public static IMediaCaptureCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMediaCaptureCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'veg.mediacapture.sdk.MediaCaptureCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMediaCaptureCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ;
#pragma warning disable 0169
		static Delegate GetOnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJHandler ()
		{
			if (cb_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ == null)
				cb_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIJ_I) n_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ);
			return cb_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ;
		}

		static int n_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2, long p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IMediaCaptureCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.OnCaptureReceiveData (p0, p1, p2, p3);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ;
		public unsafe int OnCaptureReceiveData (global::Java.Nio.ByteBuffer p0, int p1, int p2, long p3)
		{
			if (id_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ == IntPtr.Zero)
				id_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ = JNIEnv.GetMethodID (class_ref, "OnCaptureReceiveData", "(Ljava/nio/ByteBuffer;IIJ)I");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			var __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_OnCaptureReceiveData_Ljava_nio_ByteBuffer_IIJ, __args);
			return __ret;
		}

		static Delegate cb_OnCaptureStatus_I;
#pragma warning disable 0169
		static Delegate GetOnCaptureStatus_IHandler ()
		{
			if (cb_OnCaptureStatus_I == null)
				cb_OnCaptureStatus_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_OnCaptureStatus_I);
			return cb_OnCaptureStatus_I;
		}

		static int n_OnCaptureStatus_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IMediaCaptureCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OnCaptureStatus (p0);
		}
#pragma warning restore 0169

		IntPtr id_OnCaptureStatus_I;
		public unsafe int OnCaptureStatus (int p0)
		{
			if (id_OnCaptureStatus_I == IntPtr.Zero)
				id_OnCaptureStatus_I = JNIEnv.GetMethodID (class_ref, "OnCaptureStatus", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_OnCaptureStatus_I, __args);
		}

	}
}
