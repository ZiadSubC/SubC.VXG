using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/Camera2APIImpl", DoNotGenerateAcw=true)]
	public partial class Camera2APIImpl : global::Java.Lang.Object, global::Veg.Mediacapture.Sdk.Camera.ICameraService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/Camera2APIImpl", typeof (Camera2APIImpl));

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

		protected Camera2APIImpl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/constructor[@name='Camera2APIImpl' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Camera2APIImpl (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/constructor[@name='Camera2APIImpl' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.hardware.camera2.CameraDevice']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/hardware/camera2/CameraDevice;)V", "")]
		public unsafe Camera2APIImpl (global::Android.Content.Context context, global::Android.Hardware.Camera2.CameraDevice camera) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/hardware/camera2/CameraDevice;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((camera == null) ? IntPtr.Zero : ((global::Java.Lang.Object) camera).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (camera);
			}
		}

		static Delegate cb_getMaxZoom;
#pragma warning disable 0169
		static Delegate GetGetMaxZoomHandler ()
		{
			if (cb_getMaxZoom == null)
				cb_getMaxZoom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxZoom);
			return cb_getMaxZoom;
		}

		static int n_GetMaxZoom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getMaxZoom' and count(parameter)=0]"
			[Register ("getMaxZoom", "()I", "GetGetMaxZoomHandler")]
			get {
				const string __id = "getMaxZoom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNumberOfCameras;
#pragma warning disable 0169
		static Delegate GetGetNumberOfCamerasHandler ()
		{
			if (cb_getNumberOfCameras == null)
				cb_getNumberOfCameras = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNumberOfCameras);
			return cb_getNumberOfCameras;
		}

		static int n_GetNumberOfCameras (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfCameras;
		}
#pragma warning restore 0169

		public virtual unsafe int NumberOfCameras {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getNumberOfCameras' and count(parameter)=0]"
			[Register ("getNumberOfCameras", "()I", "GetGetNumberOfCamerasHandler")]
			get {
				const string __id = "getNumberOfCameras.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPreferredPreviewSizeForVideo;
#pragma warning disable 0169
		static Delegate GetGetPreferredPreviewSizeForVideoHandler ()
		{
			if (cb_getPreferredPreviewSizeForVideo == null)
				cb_getPreferredPreviewSizeForVideo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPreferredPreviewSizeForVideo);
			return cb_getPreferredPreviewSizeForVideo;
		}

		static IntPtr n_GetPreferredPreviewSizeForVideo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreferredPreviewSizeForVideo);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize PreferredPreviewSizeForVideo {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getPreferredPreviewSizeForVideo' and count(parameter)=0]"
			[Register ("getPreferredPreviewSizeForVideo", "()Lveg/mediacapture/sdk/camera/CameraService$Size;", "GetGetPreferredPreviewSizeForVideoHandler")]
			get {
				const string __id = "getPreferredPreviewSizeForVideo.()Lveg/mediacapture/sdk/camera/CameraService$Size;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedFocusModes;
#pragma warning disable 0169
		static Delegate GetGetSupportedFocusModesHandler ()
		{
			if (cb_getSupportedFocusModes == null)
				cb_getSupportedFocusModes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedFocusModes);
			return cb_getSupportedFocusModes;
		}

		static IntPtr n_GetSupportedFocusModes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode>.ToLocalJniHandle (__this.SupportedFocusModes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> SupportedFocusModes {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getSupportedFocusModes' and count(parameter)=0]"
			[Register ("getSupportedFocusModes", "()Ljava/util/List;", "GetGetSupportedFocusModesHandler")]
			get {
				const string __id = "getSupportedFocusModes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedPreviewFpsRange;
#pragma warning disable 0169
		static Delegate GetGetSupportedPreviewFpsRangeHandler ()
		{
			if (cb_getSupportedPreviewFpsRange == null)
				cb_getSupportedPreviewFpsRange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedPreviewFpsRange);
			return cb_getSupportedPreviewFpsRange;
		}

		static IntPtr n_GetSupportedPreviewFpsRange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (__this.SupportedPreviewFpsRange);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<int[]> SupportedPreviewFpsRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getSupportedPreviewFpsRange' and count(parameter)=0]"
			[Register ("getSupportedPreviewFpsRange", "()Ljava/util/List;", "GetGetSupportedPreviewFpsRangeHandler")]
			get {
				const string __id = "getSupportedPreviewFpsRange.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<int[]>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedPreviewSizes;
#pragma warning disable 0169
		static Delegate GetGetSupportedPreviewSizesHandler ()
		{
			if (cb_getSupportedPreviewSizes == null)
				cb_getSupportedPreviewSizes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedPreviewSizes);
			return cb_getSupportedPreviewSizes;
		}

		static IntPtr n_GetSupportedPreviewSizes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize>.ToLocalJniHandle (__this.SupportedPreviewSizes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize> SupportedPreviewSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getSupportedPreviewSizes' and count(parameter)=0]"
			[Register ("getSupportedPreviewSizes", "()Ljava/util/List;", "GetGetSupportedPreviewSizesHandler")]
			get {
				const string __id = "getSupportedPreviewSizes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSupportedVideoSizes;
#pragma warning disable 0169
		static Delegate GetGetSupportedVideoSizesHandler ()
		{
			if (cb_getSupportedVideoSizes == null)
				cb_getSupportedVideoSizes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSupportedVideoSizes);
			return cb_getSupportedVideoSizes;
		}

		static IntPtr n_GetSupportedVideoSizes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize>.ToLocalJniHandle (__this.SupportedVideoSizes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize> SupportedVideoSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getSupportedVideoSizes' and count(parameter)=0]"
			[Register ("getSupportedVideoSizes", "()Ljava/util/List;", "GetGetSupportedVideoSizesHandler")]
			get {
				const string __id = "getSupportedVideoSizes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getZoomRatios;
#pragma warning disable 0169
		static Delegate GetGetZoomRatiosHandler ()
		{
			if (cb_getZoomRatios == null)
				cb_getZoomRatios = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetZoomRatios);
			return cb_getZoomRatios;
		}

		static IntPtr n_GetZoomRatios (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ZoomRatios);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> ZoomRatios {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getZoomRatios' and count(parameter)=0]"
			[Register ("getZoomRatios", "()Ljava/util/List;", "GetGetZoomRatiosHandler")]
			get {
				const string __id = "getZoomRatios.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_bindToMediaRecorder_Landroid_media_MediaRecorder_;
#pragma warning disable 0169
		static Delegate GetBindToMediaRecorder_Landroid_media_MediaRecorder_Handler ()
		{
			if (cb_bindToMediaRecorder_Landroid_media_MediaRecorder_ == null)
				cb_bindToMediaRecorder_Landroid_media_MediaRecorder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_BindToMediaRecorder_Landroid_media_MediaRecorder_);
			return cb_bindToMediaRecorder_Landroid_media_MediaRecorder_;
		}

		static void n_BindToMediaRecorder_Landroid_media_MediaRecorder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_recorder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var recorder = global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (native_recorder, JniHandleOwnership.DoNotTransfer);
			__this.BindToMediaRecorder (recorder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='bindToMediaRecorder' and count(parameter)=1 and parameter[1][@type='android.media.MediaRecorder']]"
		[Register ("bindToMediaRecorder", "(Landroid/media/MediaRecorder;)V", "GetBindToMediaRecorder_Landroid_media_MediaRecorder_Handler")]
		public virtual unsafe void BindToMediaRecorder (global::Android.Media.MediaRecorder recorder)
		{
			const string __id = "bindToMediaRecorder.(Landroid/media/MediaRecorder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((recorder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) recorder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (recorder);
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_flatten;
#pragma warning disable 0169
		static Delegate GetFlattenHandler ()
		{
			if (cb_flatten == null)
				cb_flatten = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Flatten);
			return cb_flatten;
		}

		static IntPtr n_Flatten (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Flatten ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='flatten' and count(parameter)=0]"
		[Register ("flatten", "()Ljava/lang/String;", "GetFlattenHandler")]
		public virtual unsafe string Flatten ()
		{
			const string __id = "flatten.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCameraInfoByNumber_I;
#pragma warning disable 0169
		static Delegate GetGetCameraInfoByNumber_IHandler ()
		{
			if (cb_getCameraInfoByNumber_I == null)
				cb_getCameraInfoByNumber_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetCameraInfoByNumber_I);
			return cb_getCameraInfoByNumber_I;
		}

		static IntPtr n_GetCameraInfoByNumber_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCameraInfoByNumber (number));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getCameraInfoByNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCameraInfoByNumber", "(I)Lveg/mediacapture/sdk/camera/CameraService$CameraInfo;", "GetGetCameraInfoByNumber_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceCameraInfo GetCameraInfoByNumber (int number)
		{
			const string __id = "getCameraInfoByNumber.(I)Lveg/mediacapture/sdk/camera/CameraService$CameraInfo;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceCameraInfo> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getCameraTypeByNumber_I;
#pragma warning disable 0169
		static Delegate GetGetCameraTypeByNumber_IHandler ()
		{
			if (cb_getCameraTypeByNumber_I == null)
				cb_getCameraTypeByNumber_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetCameraTypeByNumber_I);
			return cb_getCameraTypeByNumber_I;
		}

		static IntPtr n_GetCameraTypeByNumber_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCameraTypeByNumber (number));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getCameraTypeByNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCameraTypeByNumber", "(I)Lveg/mediacapture/sdk/camera/CameraService$Facing;", "GetGetCameraTypeByNumber_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing GetCameraTypeByNumber (int number)
		{
			const string __id = "getCameraTypeByNumber.(I)Lveg/mediacapture/sdk/camera/CameraService$Facing;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOrientation_I;
#pragma warning disable 0169
		static Delegate GetGetOrientation_IHandler ()
		{
			if (cb_getOrientation_I == null)
				cb_getOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetOrientation_I);
			return cb_getOrientation_I;
		}

		static int n_GetOrientation_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOrientation (number);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='getOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOrientation", "(I)I", "GetGetOrientation_IHandler")]
		public virtual unsafe int GetOrientation (int number)
		{
			const string __id = "getOrientation.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isFlashModeSupported;
#pragma warning disable 0169
		static Delegate GetIsFlashModeSupportedHandler ()
		{
			if (cb_isFlashModeSupported == null)
				cb_isFlashModeSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsFlashModeSupported);
			return cb_isFlashModeSupported;
		}

		static IntPtr n_IsFlashModeSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsFlashModeSupported ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='isFlashModeSupported' and count(parameter)=0]"
		[Register ("isFlashModeSupported", "()Ljava/lang/Boolean;", "GetIsFlashModeSupportedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsFlashModeSupported ()
		{
			const string __id = "isFlashModeSupported.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isSmoothZoomSupported;
#pragma warning disable 0169
		static Delegate GetIsSmoothZoomSupportedHandler ()
		{
			if (cb_isSmoothZoomSupported == null)
				cb_isSmoothZoomSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsSmoothZoomSupported);
			return cb_isSmoothZoomSupported;
		}

		static IntPtr n_IsSmoothZoomSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsSmoothZoomSupported ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='isSmoothZoomSupported' and count(parameter)=0]"
		[Register ("isSmoothZoomSupported", "()Ljava/lang/Boolean;", "GetIsSmoothZoomSupportedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsSmoothZoomSupported ()
		{
			const string __id = "isSmoothZoomSupported.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_isZoomSupported;
#pragma warning disable 0169
		static Delegate GetIsZoomSupportedHandler ()
		{
			if (cb_isZoomSupported == null)
				cb_isZoomSupported = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_IsZoomSupported);
			return cb_isZoomSupported;
		}

		static IntPtr n_IsZoomSupported (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsZoomSupported ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='isZoomSupported' and count(parameter)=0]"
		[Register ("isZoomSupported", "()Ljava/lang/Boolean;", "GetIsZoomSupportedHandler")]
		public virtual unsafe global::Java.Lang.Boolean IsZoomSupported ()
		{
			const string __id = "isZoomSupported.()Ljava/lang/Boolean;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_open_I;
#pragma warning disable 0169
		static Delegate GetOpen_IHandler ()
		{
			if (cb_open_I == null)
				cb_open_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Open_I);
			return cb_open_I;
		}

		static IntPtr n_Open_I (IntPtr jnienv, IntPtr native__this, int number)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Open (number));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='open' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("open", "(I)Lveg/mediacapture/sdk/camera/CameraService;", "GetOpen_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Camera.ICameraService Open (int number)
		{
			const string __id = "open.(I)Lveg/mediacapture/sdk/camera/CameraService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_;
#pragma warning disable 0169
		static Delegate GetOpen_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_Handler ()
		{
			if (cb_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_ == null)
				cb_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_);
			return cb_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_;
		}

		static IntPtr n_Open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_ (IntPtr jnienv, IntPtr native__this, int number, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (number, @callback));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='open' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='veg.mediacapture.sdk.camera.CameraService.StateCallback']]"
		[Register ("open", "(ILveg/mediacapture/sdk/camera/CameraService$StateCallback;)Lveg/mediacapture/sdk/camera/CameraService;", "GetOpen_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_Handler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Camera.ICameraService Open (int number, global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback @callback)
		{
			const string __id = "open.(ILveg/mediacapture/sdk/camera/CameraService$StateCallback;)Lveg/mediacapture/sdk/camera/CameraService;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_setDirectParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDirectParam_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setDirectParam_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setDirectParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetDirectParam_Ljava_lang_String_Ljava_lang_String_);
			return cb_setDirectParam_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetDirectParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_key, IntPtr native_value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			var value = JNIEnv.GetString (native_value, JniHandleOwnership.DoNotTransfer);
			__this.SetDirectParam (key, value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setDirectParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDirectParam", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetDirectParam_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetDirectParam (string key, string value)
		{
			const string __id = "setDirectParam.(Ljava/lang/String;Ljava/lang/String;)V";
			IntPtr native_key = JNIEnv.NewString (key);
			IntPtr native_value = JNIEnv.NewString (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_key);
				__args [1] = new JniArgumentValue (native_value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_key);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_setDisplayOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayOrientation_IHandler ()
		{
			if (cb_setDisplayOrientation_I == null)
				cb_setDisplayOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDisplayOrientation_I);
			return cb_setDisplayOrientation_I;
		}

		static void n_SetDisplayOrientation_I (IntPtr jnienv, IntPtr native__this, int orientation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayOrientation (orientation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setDisplayOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDisplayOrientation", "(I)V", "GetSetDisplayOrientation_IHandler")]
		public virtual unsafe void SetDisplayOrientation (int orientation)
		{
			const string __id = "setDisplayOrientation.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (orientation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_;
#pragma warning disable 0169
		static Delegate GetSetFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_Handler ()
		{
			if (cb_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_ == null)
				cb_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_);
			return cb_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_;
		}

		static void n_SetFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			__this.SetFlashMode (mode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setFlashMode' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService.FlashMode']]"
		[Register ("setFlashMode", "(Lveg/mediacapture/sdk/camera/CameraService$FlashMode;)V", "GetSetFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_Handler")]
		public virtual unsafe void SetFlashMode (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode mode)
		{
			const string __id = "setFlashMode.(Lveg/mediacapture/sdk/camera/CameraService$FlashMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mode);
			}
		}

		static Delegate cb_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_;
#pragma warning disable 0169
		static Delegate GetSetFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_Handler ()
		{
			if (cb_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_ == null)
				cb_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_);
			return cb_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_;
		}

		static void n_SetFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mode = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (native_mode, JniHandleOwnership.DoNotTransfer);
			__this.SetFocusMode (mode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setFocusMode' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService.FocusMode']]"
		[Register ("setFocusMode", "(Lveg/mediacapture/sdk/camera/CameraService$FocusMode;)V", "GetSetFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_Handler")]
		public virtual unsafe void SetFocusMode (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode mode)
		{
			const string __id = "setFocusMode.(Lveg/mediacapture/sdk/camera/CameraService$FocusMode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mode);
			}
		}

		static Delegate cb_setPreviewDisplay_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSetPreviewDisplay_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_setPreviewDisplay_Landroid_view_SurfaceHolder_ == null)
				cb_setPreviewDisplay_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPreviewDisplay_Landroid_view_SurfaceHolder_);
			return cb_setPreviewDisplay_Landroid_view_SurfaceHolder_;
		}

		static void n_SetPreviewDisplay_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewDisplay (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setPreviewDisplay' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V", "GetSetPreviewDisplay_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SetPreviewDisplay (global::Android.Views.ISurfaceHolder holder)
		{
			const string __id = "setPreviewDisplay.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_setPreviewSize_II;
#pragma warning disable 0169
		static Delegate GetSetPreviewSize_IIHandler ()
		{
			if (cb_setPreviewSize_II == null)
				cb_setPreviewSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetPreviewSize_II);
			return cb_setPreviewSize_II;
		}

		static void n_SetPreviewSize_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewSize (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setPreviewSize", "(II)V", "GetSetPreviewSize_IIHandler")]
		public virtual unsafe void SetPreviewSize (int width, int height)
		{
			const string __id = "setPreviewSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPreviewTexture_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetSetPreviewTexture_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_setPreviewTexture_Landroid_graphics_SurfaceTexture_ == null)
				cb_setPreviewTexture_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPreviewTexture_Landroid_graphics_SurfaceTexture_);
			return cb_setPreviewTexture_Landroid_graphics_SurfaceTexture_;
		}

		static void n_SetPreviewTexture_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_texture)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var texture = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_texture, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewTexture (texture);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setPreviewTexture' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("setPreviewTexture", "(Landroid/graphics/SurfaceTexture;)V", "GetSetPreviewTexture_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void SetPreviewTexture (global::Android.Graphics.SurfaceTexture texture)
		{
			const string __id = "setPreviewTexture.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((texture == null) ? IntPtr.Zero : ((global::Java.Lang.Object) texture).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (texture);
			}
		}

		static Delegate cb_setRotation_I;
#pragma warning disable 0169
		static Delegate GetSetRotation_IHandler ()
		{
			if (cb_setRotation_I == null)
				cb_setRotation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRotation_I);
			return cb_setRotation_I;
		}

		static void n_SetRotation_I (IntPtr jnienv, IntPtr native__this, int rotation)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotation (rotation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRotation", "(I)V", "GetSetRotation_IHandler")]
		public virtual unsafe void SetRotation (int rotation)
		{
			const string __id = "setRotation.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rotation);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setZoom_I;
#pragma warning disable 0169
		static Delegate GetSetZoom_IHandler ()
		{
			if (cb_setZoom_I == null)
				cb_setZoom_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetZoom_I);
			return cb_setZoom_I;
		}

		static void n_SetZoom_I (IntPtr jnienv, IntPtr native__this, int value)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoom", "(I)V", "GetSetZoom_IHandler")]
		public virtual unsafe void SetZoom (int value)
		{
			const string __id = "setZoom.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startPreview;
#pragma warning disable 0169
		static Delegate GetStartPreviewHandler ()
		{
			if (cb_startPreview == null)
				cb_startPreview = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartPreview);
			return cb_startPreview;
		}

		static void n_StartPreview (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartPreview ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='startPreview' and count(parameter)=0]"
		[Register ("startPreview", "()V", "GetStartPreviewHandler")]
		public virtual unsafe void StartPreview ()
		{
			const string __id = "startPreview.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetStop_Ljava_lang_Boolean_Handler ()
		{
			if (cb_stop_Ljava_lang_Boolean_ == null)
				cb_stop_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Stop_Ljava_lang_Boolean_);
			return cb_stop_Ljava_lang_Boolean_;
		}

		static void n_Stop_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_isCancelAutoFocus)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var isCancelAutoFocus = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_isCancelAutoFocus, JniHandleOwnership.DoNotTransfer);
			__this.Stop (isCancelAutoFocus);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("stop", "(Ljava/lang/Boolean;)V", "GetStop_Ljava_lang_Boolean_Handler")]
		public virtual unsafe void Stop (global::Java.Lang.Boolean isCancelAutoFocus)
		{
			const string __id = "stop.(Ljava/lang/Boolean;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((isCancelAutoFocus == null) ? IntPtr.Zero : ((global::Java.Lang.Object) isCancelAutoFocus).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (isCancelAutoFocus);
			}
		}

		static Delegate cb_stopPreview;
#pragma warning disable 0169
		static Delegate GetStopPreviewHandler ()
		{
			if (cb_stopPreview == null)
				cb_stopPreview = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopPreview);
			return cb_stopPreview;
		}

		static void n_StopPreview (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPreview ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='stopPreview' and count(parameter)=0]"
		[Register ("stopPreview", "()V", "GetStopPreviewHandler")]
		public virtual unsafe void StopPreview ()
		{
			const string __id = "stopPreview.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_unlock;
#pragma warning disable 0169
		static Delegate GetUnlockHandler ()
		{
			if (cb_unlock == null)
				cb_unlock = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Unlock);
			return cb_unlock;
		}

		static void n_Unlock (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.Camera2APIImpl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='Camera2APIImpl']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler")]
		public virtual unsafe void Unlock ()
		{
			const string __id = "unlock.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
