using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Camera {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.CameraInfo']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraService$CameraInfo", DoNotGenerateAcw=true)]
	public partial class CameraServiceCameraInfo : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.CameraInfo']/field[@name='facing']"
		[Register ("facing")]
		public global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing Facing {
			get {
				const string __id = "facing.Lveg/mediacapture/sdk/camera/CameraService$Facing;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "facing.Lveg/mediacapture/sdk/camera/CameraService$Facing;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.CameraInfo']/field[@name='orientation']"
		[Register ("orientation")]
		public int Orientation {
			get {
				const string __id = "orientation.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "orientation.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraService$CameraInfo", typeof (CameraServiceCameraInfo));

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

		protected CameraServiceCameraInfo (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.CameraInfo']/constructor[@name='CameraService.CameraInfo' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CameraServiceCameraInfo () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Facing']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraService$Facing", DoNotGenerateAcw=true)]
	public sealed partial class CameraServiceFacing : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Facing']/field[@name='BACK']"
		[Register ("BACK")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing Back {
			get {
				const string __id = "BACK.Lveg/mediacapture/sdk/camera/CameraService$Facing;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Facing']/field[@name='EXTERNAL']"
		[Register ("EXTERNAL")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing External {
			get {
				const string __id = "EXTERNAL.Lveg/mediacapture/sdk/camera/CameraService$Facing;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Facing']/field[@name='FRONT']"
		[Register ("FRONT")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing Front {
			get {
				const string __id = "FRONT.Lveg/mediacapture/sdk/camera/CameraService$Facing;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Facing']/field[@name='UNKNOWN']"
		[Register ("UNKNOWN")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing Unknown {
			get {
				const string __id = "UNKNOWN.Lveg/mediacapture/sdk/camera/CameraService$Facing;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraService$Facing", typeof (CameraServiceFacing));

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

		internal CameraServiceFacing (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Facing']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()I", "")]
		public unsafe int Value ()
		{
			const string __id = "value.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Facing']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/camera/CameraService$Facing;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/camera/CameraService$Facing;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Facing']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lveg/mediacapture/sdk/camera/CameraService$Facing;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing[] Values ()
		{
			const string __id = "values.()[Lveg/mediacapture/sdk/camera/CameraService$Facing;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraService$FlashMode", DoNotGenerateAcw=true)]
	public sealed partial class CameraServiceFlashMode : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']/field[@name='AUTO']"
		[Register ("AUTO")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode Auto {
			get {
				const string __id = "AUTO.Lveg/mediacapture/sdk/camera/CameraService$FlashMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']/field[@name='OFF']"
		[Register ("OFF")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode Off {
			get {
				const string __id = "OFF.Lveg/mediacapture/sdk/camera/CameraService$FlashMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']/field[@name='ON']"
		[Register ("ON")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode On {
			get {
				const string __id = "ON.Lveg/mediacapture/sdk/camera/CameraService$FlashMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']/field[@name='RED_EYE']"
		[Register ("RED_EYE")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode RedEye {
			get {
				const string __id = "RED_EYE.Lveg/mediacapture/sdk/camera/CameraService$FlashMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']/field[@name='TORCH']"
		[Register ("TORCH")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode Torch {
			get {
				const string __id = "TORCH.Lveg/mediacapture/sdk/camera/CameraService$FlashMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraService$FlashMode", typeof (CameraServiceFlashMode));

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

		internal CameraServiceFlashMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()I", "")]
		public unsafe int Value ()
		{
			const string __id = "value.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/camera/CameraService$FlashMode;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/camera/CameraService$FlashMode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FlashMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lveg/mediacapture/sdk/camera/CameraService$FlashMode;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode[] Values ()
		{
			const string __id = "values.()[Lveg/mediacapture/sdk/camera/CameraService$FlashMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraService$FocusMode", DoNotGenerateAcw=true)]
	public sealed partial class CameraServiceFocusMode : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/field[@name='AUTO']"
		[Register ("AUTO")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode Auto {
			get {
				const string __id = "AUTO.Lveg/mediacapture/sdk/camera/CameraService$FocusMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/field[@name='CONTINUOUS_PICTURE']"
		[Register ("CONTINUOUS_PICTURE")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode ContinuousPicture {
			get {
				const string __id = "CONTINUOUS_PICTURE.Lveg/mediacapture/sdk/camera/CameraService$FocusMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/field[@name='CONTINUOUS_VIDEO']"
		[Register ("CONTINUOUS_VIDEO")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode ContinuousVideo {
			get {
				const string __id = "CONTINUOUS_VIDEO.Lveg/mediacapture/sdk/camera/CameraService$FocusMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/field[@name='EDOF']"
		[Register ("EDOF")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode Edof {
			get {
				const string __id = "EDOF.Lveg/mediacapture/sdk/camera/CameraService$FocusMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/field[@name='MACRO']"
		[Register ("MACRO")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode Macro {
			get {
				const string __id = "MACRO.Lveg/mediacapture/sdk/camera/CameraService$FocusMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/field[@name='OFF']"
		[Register ("OFF")]
		public static global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode Off {
			get {
				const string __id = "OFF.Lveg/mediacapture/sdk/camera/CameraService$FocusMode;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraService$FocusMode", typeof (CameraServiceFocusMode));

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

		internal CameraServiceFocusMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/method[@name='value' and count(parameter)=0]"
		[Register ("value", "()I", "")]
		public unsafe int Value ()
		{
			const string __id = "value.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/camera/CameraService$FocusMode;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/camera/CameraService$FocusMode;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.FocusMode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lveg/mediacapture/sdk/camera/CameraService$FocusMode;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode[] Values ()
		{
			const string __id = "values.()[Lveg/mediacapture/sdk/camera/CameraService$FocusMode;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode));
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Size']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraService$Size", DoNotGenerateAcw=true)]
	public partial class CameraServiceSize : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Size']/field[@name='height']"
		[Register ("height")]
		public int Height {
			get {
				const string __id = "height.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "height.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Size']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				const string __id = "width.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "width.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraService$Size", typeof (CameraServiceSize));

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

		protected CameraServiceSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.Size']/constructor[@name='CameraService.Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe CameraServiceSize (int w, int h) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (w);
				__args [1] = new JniArgumentValue (h);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraService$StateCallback", DoNotGenerateAcw=true)]
	public abstract partial class CameraServiceStateCallback : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraService$StateCallback", typeof (CameraServiceStateCallback));

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

		protected CameraServiceStateCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']/constructor[@name='CameraService.StateCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CameraServiceStateCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_onClosed_Lveg_mediacapture_sdk_camera_CameraService_;
#pragma warning disable 0169
		static Delegate GetOnClosed_Lveg_mediacapture_sdk_camera_CameraService_Handler ()
		{
			if (cb_onClosed_Lveg_mediacapture_sdk_camera_CameraService_ == null)
				cb_onClosed_Lveg_mediacapture_sdk_camera_CameraService_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnClosed_Lveg_mediacapture_sdk_camera_CameraService_);
			return cb_onClosed_Lveg_mediacapture_sdk_camera_CameraService_;
		}

		static void n_OnClosed_Lveg_mediacapture_sdk_camera_CameraService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_camera)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var camera = (global::Veg.Mediacapture.Sdk.Camera.ICameraService)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (native_camera, JniHandleOwnership.DoNotTransfer);
			__this.OnClosed (camera);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']/method[@name='onClosed' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService']]"
		[Register ("onClosed", "(Lveg/mediacapture/sdk/camera/CameraService;)V", "GetOnClosed_Lveg_mediacapture_sdk_camera_CameraService_Handler")]
		public virtual unsafe void OnClosed (global::Veg.Mediacapture.Sdk.Camera.ICameraService camera)
		{
			const string __id = "onClosed.(Lveg/mediacapture/sdk/camera/CameraService;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((camera == null) ? IntPtr.Zero : ((global::Java.Lang.Object) camera).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (camera);
			}
		}

		static Delegate cb_onDisconnected_Lveg_mediacapture_sdk_camera_CameraService_;
#pragma warning disable 0169
		static Delegate GetOnDisconnected_Lveg_mediacapture_sdk_camera_CameraService_Handler ()
		{
			if (cb_onDisconnected_Lveg_mediacapture_sdk_camera_CameraService_ == null)
				cb_onDisconnected_Lveg_mediacapture_sdk_camera_CameraService_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDisconnected_Lveg_mediacapture_sdk_camera_CameraService_);
			return cb_onDisconnected_Lveg_mediacapture_sdk_camera_CameraService_;
		}

		static void n_OnDisconnected_Lveg_mediacapture_sdk_camera_CameraService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Veg.Mediacapture.Sdk.Camera.ICameraService)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDisconnected (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']/method[@name='onDisconnected' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService']]"
		[Register ("onDisconnected", "(Lveg/mediacapture/sdk/camera/CameraService;)V", "GetOnDisconnected_Lveg_mediacapture_sdk_camera_CameraService_Handler")]
		public abstract void OnDisconnected (global::Veg.Mediacapture.Sdk.Camera.ICameraService p0);

		static Delegate cb_onError_Lveg_mediacapture_sdk_camera_CameraService_I;
#pragma warning disable 0169
		static Delegate GetOnError_Lveg_mediacapture_sdk_camera_CameraService_IHandler ()
		{
			if (cb_onError_Lveg_mediacapture_sdk_camera_CameraService_I == null)
				cb_onError_Lveg_mediacapture_sdk_camera_CameraService_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_OnError_Lveg_mediacapture_sdk_camera_CameraService_I);
			return cb_onError_Lveg_mediacapture_sdk_camera_CameraService_I;
		}

		static void n_OnError_Lveg_mediacapture_sdk_camera_CameraService_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Veg.Mediacapture.Sdk.Camera.ICameraService)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnError (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService'] and parameter[2][@type='int']]"
		[Register ("onError", "(Lveg/mediacapture/sdk/camera/CameraService;I)V", "GetOnError_Lveg_mediacapture_sdk_camera_CameraService_IHandler")]
		public abstract void OnError (global::Veg.Mediacapture.Sdk.Camera.ICameraService p0, int p1);

		static Delegate cb_onOpened_Lveg_mediacapture_sdk_camera_CameraService_;
#pragma warning disable 0169
		static Delegate GetOnOpened_Lveg_mediacapture_sdk_camera_CameraService_Handler ()
		{
			if (cb_onOpened_Lveg_mediacapture_sdk_camera_CameraService_ == null)
				cb_onOpened_Lveg_mediacapture_sdk_camera_CameraService_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnOpened_Lveg_mediacapture_sdk_camera_CameraService_);
			return cb_onOpened_Lveg_mediacapture_sdk_camera_CameraService_;
		}

		static void n_OnOpened_Lveg_mediacapture_sdk_camera_CameraService_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Veg.Mediacapture.Sdk.Camera.ICameraService)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnOpened (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']/method[@name='onOpened' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService']]"
		[Register ("onOpened", "(Lveg/mediacapture/sdk/camera/CameraService;)V", "GetOnOpened_Lveg_mediacapture_sdk_camera_CameraService_Handler")]
		public abstract void OnOpened (global::Veg.Mediacapture.Sdk.Camera.ICameraService p0);

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraService$StateCallback", DoNotGenerateAcw=true)]
	internal partial class CameraServiceStateCallbackInvoker : CameraServiceStateCallback {
		public CameraServiceStateCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraService$StateCallback", typeof (CameraServiceStateCallbackInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']/method[@name='onDisconnected' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService']]"
		[Register ("onDisconnected", "(Lveg/mediacapture/sdk/camera/CameraService;)V", "GetOnDisconnected_Lveg_mediacapture_sdk_camera_CameraService_Handler")]
		public override unsafe void OnDisconnected (global::Veg.Mediacapture.Sdk.Camera.ICameraService p0)
		{
			const string __id = "onDisconnected.(Lveg/mediacapture/sdk/camera/CameraService;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']/method[@name='onError' and count(parameter)=2 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService'] and parameter[2][@type='int']]"
		[Register ("onError", "(Lveg/mediacapture/sdk/camera/CameraService;I)V", "GetOnError_Lveg_mediacapture_sdk_camera_CameraService_IHandler")]
		public override unsafe void OnError (global::Veg.Mediacapture.Sdk.Camera.ICameraService p0, int p1)
		{
			const string __id = "onError.(Lveg/mediacapture/sdk/camera/CameraService;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/class[@name='CameraService.StateCallback']/method[@name='onOpened' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService']]"
		[Register ("onOpened", "(Lveg/mediacapture/sdk/camera/CameraService;)V", "GetOnOpened_Lveg_mediacapture_sdk_camera_CameraService_Handler")]
		public override unsafe void OnOpened (global::Veg.Mediacapture.Sdk.Camera.ICameraService p0)
		{
			const string __id = "onOpened.(Lveg/mediacapture/sdk/camera/CameraService;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']"
	[Register ("veg/mediacapture/sdk/camera/CameraService", "", "Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker")]
	public partial interface ICameraService : IJavaObject, IJavaPeerable {
		int MaxZoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getMaxZoom' and count(parameter)=0]"
			[Register ("getMaxZoom", "()I", "GetGetMaxZoomHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
			get; 
		}

		int NumberOfCameras {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getNumberOfCameras' and count(parameter)=0]"
			[Register ("getNumberOfCameras", "()I", "GetGetNumberOfCamerasHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
			get; 
		}

		global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize PreferredPreviewSizeForVideo {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getPreferredPreviewSizeForVideo' and count(parameter)=0]"
			[Register ("getPreferredPreviewSizeForVideo", "()Lveg/mediacapture/sdk/camera/CameraService$Size;", "GetGetPreferredPreviewSizeForVideoHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> SupportedFocusModes {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getSupportedFocusModes' and count(parameter)=0]"
			[Register ("getSupportedFocusModes", "()Ljava/util/List;", "GetGetSupportedFocusModesHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
			get; 
		}

		global::System.Collections.Generic.IList<int[]> SupportedPreviewFpsRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getSupportedPreviewFpsRange' and count(parameter)=0]"
			[Register ("getSupportedPreviewFpsRange", "()Ljava/util/List;", "GetGetSupportedPreviewFpsRangeHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize> SupportedPreviewSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getSupportedPreviewSizes' and count(parameter)=0]"
			[Register ("getSupportedPreviewSizes", "()Ljava/util/List;", "GetGetSupportedPreviewSizesHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize> SupportedVideoSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getSupportedVideoSizes' and count(parameter)=0]"
			[Register ("getSupportedVideoSizes", "()Ljava/util/List;", "GetGetSupportedVideoSizesHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
			get; 
		}

		global::System.Collections.Generic.IList<global::Java.Lang.Integer> ZoomRatios {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getZoomRatios' and count(parameter)=0]"
			[Register ("getZoomRatios", "()Ljava/util/List;", "GetGetZoomRatiosHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='bindToMediaRecorder' and count(parameter)=1 and parameter[1][@type='android.media.MediaRecorder']]"
		[Register ("bindToMediaRecorder", "(Landroid/media/MediaRecorder;)V", "GetBindToMediaRecorder_Landroid_media_MediaRecorder_Handler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void BindToMediaRecorder (global::Android.Media.MediaRecorder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void Close ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='flatten' and count(parameter)=0]"
		[Register ("flatten", "()Ljava/lang/String;", "GetFlattenHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		string Flatten ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getCameraInfoByNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCameraInfoByNumber", "(I)Lveg/mediacapture/sdk/camera/CameraService$CameraInfo;", "GetGetCameraInfoByNumber_IHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		global::Veg.Mediacapture.Sdk.Camera.CameraServiceCameraInfo GetCameraInfoByNumber (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getCameraTypeByNumber' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCameraTypeByNumber", "(I)Lveg/mediacapture/sdk/camera/CameraService$Facing;", "GetGetCameraTypeByNumber_IHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing GetCameraTypeByNumber (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='getOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getOrientation", "(I)I", "GetGetOrientation_IHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		int GetOrientation (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='isFlashModeSupported' and count(parameter)=0]"
		[Register ("isFlashModeSupported", "()Ljava/lang/Boolean;", "GetIsFlashModeSupportedHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		global::Java.Lang.Boolean IsFlashModeSupported ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='isSmoothZoomSupported' and count(parameter)=0]"
		[Register ("isSmoothZoomSupported", "()Ljava/lang/Boolean;", "GetIsSmoothZoomSupportedHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		global::Java.Lang.Boolean IsSmoothZoomSupported ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='isZoomSupported' and count(parameter)=0]"
		[Register ("isZoomSupported", "()Ljava/lang/Boolean;", "GetIsZoomSupportedHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		global::Java.Lang.Boolean IsZoomSupported ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='open' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("open", "(I)Lveg/mediacapture/sdk/camera/CameraService;", "GetOpen_IHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		global::Veg.Mediacapture.Sdk.Camera.ICameraService Open (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='open' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='veg.mediacapture.sdk.camera.CameraService.StateCallback']]"
		[Register ("open", "(ILveg/mediacapture/sdk/camera/CameraService$StateCallback;)Lveg/mediacapture/sdk/camera/CameraService;", "GetOpen_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_Handler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		global::Veg.Mediacapture.Sdk.Camera.ICameraService Open (int p0, global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setDirectParam' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("setDirectParam", "(Ljava/lang/String;Ljava/lang/String;)V", "GetSetDirectParam_Ljava_lang_String_Ljava_lang_String_Handler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetDirectParam (string p0, string p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setDisplayOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDisplayOrientation", "(I)V", "GetSetDisplayOrientation_IHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetDisplayOrientation (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setFlashMode' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService.FlashMode']]"
		[Register ("setFlashMode", "(Lveg/mediacapture/sdk/camera/CameraService$FlashMode;)V", "GetSetFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_Handler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetFlashMode (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setFocusMode' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.camera.CameraService.FocusMode']]"
		[Register ("setFocusMode", "(Lveg/mediacapture/sdk/camera/CameraService$FocusMode;)V", "GetSetFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_Handler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetFocusMode (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setPreviewDisplay' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V", "GetSetPreviewDisplay_Landroid_view_SurfaceHolder_Handler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetPreviewDisplay (global::Android.Views.ISurfaceHolder p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setPreviewSize", "(II)V", "GetSetPreviewSize_IIHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetPreviewSize (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setPreviewTexture' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("setPreviewTexture", "(Landroid/graphics/SurfaceTexture;)V", "GetSetPreviewTexture_Landroid_graphics_SurfaceTexture_Handler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetPreviewTexture (global::Android.Graphics.SurfaceTexture p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setRotation", "(I)V", "GetSetRotation_IHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetRotation (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoom", "(I)V", "GetSetZoom_IHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void SetZoom (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='startPreview' and count(parameter)=0]"
		[Register ("startPreview", "()V", "GetStartPreviewHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void StartPreview ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("stop", "(Ljava/lang/Boolean;)V", "GetStop_Ljava_lang_Boolean_Handler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void Stop (global::Java.Lang.Boolean p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='stopPreview' and count(parameter)=0]"
		[Register ("stopPreview", "()V", "GetStopPreviewHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void StopPreview ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.camera']/interface[@name='CameraService']/method[@name='unlock' and count(parameter)=0]"
		[Register ("unlock", "()V", "GetUnlockHandler:Veg.Mediacapture.Sdk.Camera.ICameraServiceInvoker, StreamingVXG")]
		void Unlock ();

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/camera/CameraService", DoNotGenerateAcw=true)]
	internal partial class ICameraServiceInvoker : global::Java.Lang.Object, ICameraService {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/camera/CameraService", typeof (ICameraServiceInvoker));

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

		public static ICameraService GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICameraService> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'veg.mediacapture.sdk.camera.CameraService'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICameraServiceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxZoom;
		}
#pragma warning restore 0169

		IntPtr id_getMaxZoom;
		public unsafe int MaxZoom {
			get {
				if (id_getMaxZoom == IntPtr.Zero)
					id_getMaxZoom = JNIEnv.GetMethodID (class_ref, "getMaxZoom", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxZoom);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NumberOfCameras;
		}
#pragma warning restore 0169

		IntPtr id_getNumberOfCameras;
		public unsafe int NumberOfCameras {
			get {
				if (id_getNumberOfCameras == IntPtr.Zero)
					id_getNumberOfCameras = JNIEnv.GetMethodID (class_ref, "getNumberOfCameras", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getNumberOfCameras);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreferredPreviewSizeForVideo);
		}
#pragma warning restore 0169

		IntPtr id_getPreferredPreviewSizeForVideo;
		public unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize PreferredPreviewSizeForVideo {
			get {
				if (id_getPreferredPreviewSizeForVideo == IntPtr.Zero)
					id_getPreferredPreviewSizeForVideo = JNIEnv.GetMethodID (class_ref, "getPreferredPreviewSizeForVideo", "()Lveg/mediacapture/sdk/camera/CameraService$Size;");
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPreferredPreviewSizeForVideo), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode>.ToLocalJniHandle (__this.SupportedFocusModes);
		}
#pragma warning restore 0169

		IntPtr id_getSupportedFocusModes;
		public unsafe global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> SupportedFocusModes {
			get {
				if (id_getSupportedFocusModes == IntPtr.Zero)
					id_getSupportedFocusModes = JNIEnv.GetMethodID (class_ref, "getSupportedFocusModes", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedFocusModes), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<int[]>.ToLocalJniHandle (__this.SupportedPreviewFpsRange);
		}
#pragma warning restore 0169

		IntPtr id_getSupportedPreviewFpsRange;
		public unsafe global::System.Collections.Generic.IList<int[]> SupportedPreviewFpsRange {
			get {
				if (id_getSupportedPreviewFpsRange == IntPtr.Zero)
					id_getSupportedPreviewFpsRange = JNIEnv.GetMethodID (class_ref, "getSupportedPreviewFpsRange", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<int[]>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedPreviewFpsRange), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize>.ToLocalJniHandle (__this.SupportedPreviewSizes);
		}
#pragma warning restore 0169

		IntPtr id_getSupportedPreviewSizes;
		public unsafe global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize> SupportedPreviewSizes {
			get {
				if (id_getSupportedPreviewSizes == IntPtr.Zero)
					id_getSupportedPreviewSizes = JNIEnv.GetMethodID (class_ref, "getSupportedPreviewSizes", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedPreviewSizes), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize>.ToLocalJniHandle (__this.SupportedVideoSizes);
		}
#pragma warning restore 0169

		IntPtr id_getSupportedVideoSizes;
		public unsafe global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize> SupportedVideoSizes {
			get {
				if (id_getSupportedVideoSizes == IntPtr.Zero)
					id_getSupportedVideoSizes = JNIEnv.GetMethodID (class_ref, "getSupportedVideoSizes", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Camera.CameraServiceSize>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSupportedVideoSizes), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ZoomRatios);
		}
#pragma warning restore 0169

		IntPtr id_getZoomRatios;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> ZoomRatios {
			get {
				if (id_getZoomRatios == IntPtr.Zero)
					id_getZoomRatios = JNIEnv.GetMethodID (class_ref, "getZoomRatios", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getZoomRatios), JniHandleOwnership.TransferLocalRef);
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

		static void n_BindToMediaRecorder_Landroid_media_MediaRecorder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BindToMediaRecorder (p0);
		}
#pragma warning restore 0169

		IntPtr id_bindToMediaRecorder_Landroid_media_MediaRecorder_;
		public unsafe void BindToMediaRecorder (global::Android.Media.MediaRecorder p0)
		{
			if (id_bindToMediaRecorder_Landroid_media_MediaRecorder_ == IntPtr.Zero)
				id_bindToMediaRecorder_Landroid_media_MediaRecorder_ = JNIEnv.GetMethodID (class_ref, "bindToMediaRecorder", "(Landroid/media/MediaRecorder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_bindToMediaRecorder_Landroid_media_MediaRecorder_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		IntPtr id_close;
		public unsafe void Close ()
		{
			if (id_close == IntPtr.Zero)
				id_close = JNIEnv.GetMethodID (class_ref, "close", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_close);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Flatten ());
		}
#pragma warning restore 0169

		IntPtr id_flatten;
		public unsafe string Flatten ()
		{
			if (id_flatten == IntPtr.Zero)
				id_flatten = JNIEnv.GetMethodID (class_ref, "flatten", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_flatten), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getCameraInfoByNumber_I;
#pragma warning disable 0169
		static Delegate GetGetCameraInfoByNumber_IHandler ()
		{
			if (cb_getCameraInfoByNumber_I == null)
				cb_getCameraInfoByNumber_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetCameraInfoByNumber_I);
			return cb_getCameraInfoByNumber_I;
		}

		static IntPtr n_GetCameraInfoByNumber_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCameraInfoByNumber (p0));
		}
#pragma warning restore 0169

		IntPtr id_getCameraInfoByNumber_I;
		public unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceCameraInfo GetCameraInfoByNumber (int p0)
		{
			if (id_getCameraInfoByNumber_I == IntPtr.Zero)
				id_getCameraInfoByNumber_I = JNIEnv.GetMethodID (class_ref, "getCameraInfoByNumber", "(I)Lveg/mediacapture/sdk/camera/CameraService$CameraInfo;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceCameraInfo> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCameraInfoByNumber_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getCameraTypeByNumber_I;
#pragma warning disable 0169
		static Delegate GetGetCameraTypeByNumber_IHandler ()
		{
			if (cb_getCameraTypeByNumber_I == null)
				cb_getCameraTypeByNumber_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetCameraTypeByNumber_I);
			return cb_getCameraTypeByNumber_I;
		}

		static IntPtr n_GetCameraTypeByNumber_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetCameraTypeByNumber (p0));
		}
#pragma warning restore 0169

		IntPtr id_getCameraTypeByNumber_I;
		public unsafe global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing GetCameraTypeByNumber (int p0)
		{
			if (id_getCameraTypeByNumber_I == IntPtr.Zero)
				id_getCameraTypeByNumber_I = JNIEnv.GetMethodID (class_ref, "getCameraTypeByNumber", "(I)Lveg/mediacapture/sdk/camera/CameraService$Facing;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFacing> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCameraTypeByNumber_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getOrientation_I;
#pragma warning disable 0169
		static Delegate GetGetOrientation_IHandler ()
		{
			if (cb_getOrientation_I == null)
				cb_getOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetOrientation_I);
			return cb_getOrientation_I;
		}

		static int n_GetOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetOrientation (p0);
		}
#pragma warning restore 0169

		IntPtr id_getOrientation_I;
		public unsafe int GetOrientation (int p0)
		{
			if (id_getOrientation_I == IntPtr.Zero)
				id_getOrientation_I = JNIEnv.GetMethodID (class_ref, "getOrientation", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getOrientation_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsFlashModeSupported ());
		}
#pragma warning restore 0169

		IntPtr id_isFlashModeSupported;
		public unsafe global::Java.Lang.Boolean IsFlashModeSupported ()
		{
			if (id_isFlashModeSupported == IntPtr.Zero)
				id_isFlashModeSupported = JNIEnv.GetMethodID (class_ref, "isFlashModeSupported", "()Ljava/lang/Boolean;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isFlashModeSupported), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsSmoothZoomSupported ());
		}
#pragma warning restore 0169

		IntPtr id_isSmoothZoomSupported;
		public unsafe global::Java.Lang.Boolean IsSmoothZoomSupported ()
		{
			if (id_isSmoothZoomSupported == IntPtr.Zero)
				id_isSmoothZoomSupported = JNIEnv.GetMethodID (class_ref, "isSmoothZoomSupported", "()Ljava/lang/Boolean;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isSmoothZoomSupported), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IsZoomSupported ());
		}
#pragma warning restore 0169

		IntPtr id_isZoomSupported;
		public unsafe global::Java.Lang.Boolean IsZoomSupported ()
		{
			if (id_isZoomSupported == IntPtr.Zero)
				id_isZoomSupported = JNIEnv.GetMethodID (class_ref, "isZoomSupported", "()Ljava/lang/Boolean;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_isZoomSupported), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_open_I;
#pragma warning disable 0169
		static Delegate GetOpen_IHandler ()
		{
			if (cb_open_I == null)
				cb_open_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_Open_I);
			return cb_open_I;
		}

		static IntPtr n_Open_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Open (p0));
		}
#pragma warning restore 0169

		IntPtr id_open_I;
		public unsafe global::Veg.Mediacapture.Sdk.Camera.ICameraService Open (int p0)
		{
			if (id_open_I == IntPtr.Zero)
				id_open_I = JNIEnv.GetMethodID (class_ref, "open", "(I)Lveg/mediacapture/sdk/camera/CameraService;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_open_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_;
#pragma warning disable 0169
		static Delegate GetOpen_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_Handler ()
		{
			if (cb_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_ == null)
				cb_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_L) n_Open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_);
			return cb_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_;
		}

		static IntPtr n_Open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Open (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_;
		public unsafe global::Veg.Mediacapture.Sdk.Camera.ICameraService Open (int p0, global::Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback p1)
		{
			if (id_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_ == IntPtr.Zero)
				id_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_ = JNIEnv.GetMethodID (class_ref, "open", "(ILveg/mediacapture/sdk/camera/CameraService$StateCallback;)Lveg/mediacapture/sdk/camera/CameraService;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_open_ILveg_mediacapture_sdk_camera_CameraService_StateCallback_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_setDirectParam_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetDirectParam_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setDirectParam_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_setDirectParam_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetDirectParam_Ljava_lang_String_Ljava_lang_String_);
			return cb_setDirectParam_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_SetDirectParam_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SetDirectParam (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setDirectParam_Ljava_lang_String_Ljava_lang_String_;
		public unsafe void SetDirectParam (string p0, string p1)
		{
			if (id_setDirectParam_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_setDirectParam_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setDirectParam", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDirectParam_Ljava_lang_String_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

		static Delegate cb_setDisplayOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetDisplayOrientation_IHandler ()
		{
			if (cb_setDisplayOrientation_I == null)
				cb_setDisplayOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDisplayOrientation_I);
			return cb_setDisplayOrientation_I;
		}

		static void n_SetDisplayOrientation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDisplayOrientation (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDisplayOrientation_I;
		public unsafe void SetDisplayOrientation (int p0)
		{
			if (id_setDisplayOrientation_I == IntPtr.Zero)
				id_setDisplayOrientation_I = JNIEnv.GetMethodID (class_ref, "setDisplayOrientation", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDisplayOrientation_I, __args);
		}

		static Delegate cb_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_;
#pragma warning disable 0169
		static Delegate GetSetFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_Handler ()
		{
			if (cb_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_ == null)
				cb_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_);
			return cb_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_;
		}

		static void n_SetFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFlashMode (p0);
		}
#pragma warning restore 0169

		IntPtr id_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_;
		public unsafe void SetFlashMode (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode p0)
		{
			if (id_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_ == IntPtr.Zero)
				id_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_ = JNIEnv.GetMethodID (class_ref, "setFlashMode", "(Lveg/mediacapture/sdk/camera/CameraService$FlashMode;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFlashMode_Lveg_mediacapture_sdk_camera_CameraService_FlashMode_, __args);
		}

		static Delegate cb_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_;
#pragma warning disable 0169
		static Delegate GetSetFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_Handler ()
		{
			if (cb_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_ == null)
				cb_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_);
			return cb_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_;
		}

		static void n_SetFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetFocusMode (p0);
		}
#pragma warning restore 0169

		IntPtr id_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_;
		public unsafe void SetFocusMode (global::Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode p0)
		{
			if (id_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_ == IntPtr.Zero)
				id_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_ = JNIEnv.GetMethodID (class_ref, "setFocusMode", "(Lveg/mediacapture/sdk/camera/CameraService$FocusMode;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setFocusMode_Lveg_mediacapture_sdk_camera_CameraService_FocusMode_, __args);
		}

		static Delegate cb_setPreviewDisplay_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSetPreviewDisplay_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_setPreviewDisplay_Landroid_view_SurfaceHolder_ == null)
				cb_setPreviewDisplay_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPreviewDisplay_Landroid_view_SurfaceHolder_);
			return cb_setPreviewDisplay_Landroid_view_SurfaceHolder_;
		}

		static void n_SetPreviewDisplay_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewDisplay (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPreviewDisplay_Landroid_view_SurfaceHolder_;
		public unsafe void SetPreviewDisplay (global::Android.Views.ISurfaceHolder p0)
		{
			if (id_setPreviewDisplay_Landroid_view_SurfaceHolder_ == IntPtr.Zero)
				id_setPreviewDisplay_Landroid_view_SurfaceHolder_ = JNIEnv.GetMethodID (class_ref, "setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreviewDisplay_Landroid_view_SurfaceHolder_, __args);
		}

		static Delegate cb_setPreviewSize_II;
#pragma warning disable 0169
		static Delegate GetSetPreviewSize_IIHandler ()
		{
			if (cb_setPreviewSize_II == null)
				cb_setPreviewSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetPreviewSize_II);
			return cb_setPreviewSize_II;
		}

		static void n_SetPreviewSize_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewSize (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setPreviewSize_II;
		public unsafe void SetPreviewSize (int p0, int p1)
		{
			if (id_setPreviewSize_II == IntPtr.Zero)
				id_setPreviewSize_II = JNIEnv.GetMethodID (class_ref, "setPreviewSize", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreviewSize_II, __args);
		}

		static Delegate cb_setPreviewTexture_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetSetPreviewTexture_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_setPreviewTexture_Landroid_graphics_SurfaceTexture_ == null)
				cb_setPreviewTexture_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPreviewTexture_Landroid_graphics_SurfaceTexture_);
			return cb_setPreviewTexture_Landroid_graphics_SurfaceTexture_;
		}

		static void n_SetPreviewTexture_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewTexture (p0);
		}
#pragma warning restore 0169

		IntPtr id_setPreviewTexture_Landroid_graphics_SurfaceTexture_;
		public unsafe void SetPreviewTexture (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_setPreviewTexture_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_setPreviewTexture_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "setPreviewTexture", "(Landroid/graphics/SurfaceTexture;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setPreviewTexture_Landroid_graphics_SurfaceTexture_, __args);
		}

		static Delegate cb_setRotation_I;
#pragma warning disable 0169
		static Delegate GetSetRotation_IHandler ()
		{
			if (cb_setRotation_I == null)
				cb_setRotation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRotation_I);
			return cb_setRotation_I;
		}

		static void n_SetRotation_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotation (p0);
		}
#pragma warning restore 0169

		IntPtr id_setRotation_I;
		public unsafe void SetRotation (int p0)
		{
			if (id_setRotation_I == IntPtr.Zero)
				id_setRotation_I = JNIEnv.GetMethodID (class_ref, "setRotation", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setRotation_I, __args);
		}

		static Delegate cb_setZoom_I;
#pragma warning disable 0169
		static Delegate GetSetZoom_IHandler ()
		{
			if (cb_setZoom_I == null)
				cb_setZoom_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetZoom_I);
			return cb_setZoom_I;
		}

		static void n_SetZoom_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (p0);
		}
#pragma warning restore 0169

		IntPtr id_setZoom_I;
		public unsafe void SetZoom (int p0)
		{
			if (id_setZoom_I == IntPtr.Zero)
				id_setZoom_I = JNIEnv.GetMethodID (class_ref, "setZoom", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setZoom_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartPreview ();
		}
#pragma warning restore 0169

		IntPtr id_startPreview;
		public unsafe void StartPreview ()
		{
			if (id_startPreview == IntPtr.Zero)
				id_startPreview = JNIEnv.GetMethodID (class_ref, "startPreview", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_startPreview);
		}

		static Delegate cb_stop_Ljava_lang_Boolean_;
#pragma warning disable 0169
		static Delegate GetStop_Ljava_lang_Boolean_Handler ()
		{
			if (cb_stop_Ljava_lang_Boolean_ == null)
				cb_stop_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Stop_Ljava_lang_Boolean_);
			return cb_stop_Ljava_lang_Boolean_;
		}

		static void n_Stop_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Stop (p0);
		}
#pragma warning restore 0169

		IntPtr id_stop_Ljava_lang_Boolean_;
		public unsafe void Stop (global::Java.Lang.Boolean p0)
		{
			if (id_stop_Ljava_lang_Boolean_ == IntPtr.Zero)
				id_stop_Ljava_lang_Boolean_ = JNIEnv.GetMethodID (class_ref, "stop", "(Ljava/lang/Boolean;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop_Ljava_lang_Boolean_, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopPreview ();
		}
#pragma warning restore 0169

		IntPtr id_stopPreview;
		public unsafe void StopPreview ()
		{
			if (id_stopPreview == IntPtr.Zero)
				id_stopPreview = JNIEnv.GetMethodID (class_ref, "stopPreview", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stopPreview);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Unlock ();
		}
#pragma warning restore 0169

		IntPtr id_unlock;
		public unsafe void Unlock ()
		{
			if (id_unlock == IntPtr.Zero)
				id_unlock = JNIEnv.GetMethodID (class_ref, "unlock", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_unlock);
		}

	}
}
