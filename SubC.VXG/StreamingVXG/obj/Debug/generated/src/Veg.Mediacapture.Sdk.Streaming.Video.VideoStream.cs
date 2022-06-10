using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/video/VideoStream", DoNotGenerateAcw=true)]
	public abstract partial class VideoStream : global::Veg.Mediacapture.Sdk.Streaming.MediaStream {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "VideoStream";


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='isAutoFocusing']"
		[Register ("isAutoFocusing")]
		protected bool IsAutoFocusing {
			get {
				const string __id = "isAutoFocusing.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isAutoFocusing.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='isFocused']"
		[Register ("isFocused")]
		protected bool IsFocused {
			get {
				const string __id = "isFocused.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isFocused.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='isSamsungS4Zoom']"
		[Register ("isSamsungS4Zoom")]
		protected bool IsSamsungS4Zoom {
			get {
				const string __id = "isSamsungS4Zoom.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isSamsungS4Zoom.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='isSmoothZoom']"
		[Register ("isSmoothZoom")]
		protected bool IsSmoothZoom {
			get {
				const string __id = "isSmoothZoom.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isSmoothZoom.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='isZoomStarted']"
		[Register ("isZoomStarted")]
		protected bool IsZoomStarted {
			get {
				const string __id = "isZoomStarted.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "isZoomStarted.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mCamera2']"
		[Register ("mCamera2")]
		protected global::Veg.Mediacapture.Sdk.Camera.ICameraService MCamera2 {
			get {
				const string __id = "mCamera2.Lveg/mediacapture/sdk/camera/CameraService;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.ICameraService> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCamera2.Lveg/mediacapture/sdk/camera/CameraService;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mCameraId']"
		[Register ("mCameraId")]
		protected int MCameraId {
			get {
				const string __id = "mCameraId.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mCameraId.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mFlashState']"
		[Register ("mFlashState")]
		protected bool MFlashState {
			get {
				const string __id = "mFlashState.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mFlashState.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mQuality']"
		[Register ("mQuality")]
		protected global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality MQuality {
			get {
				const string __id = "mQuality.Lveg/mediacapture/sdk/streaming/video/VideoQuality;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mQuality.Lveg/mediacapture/sdk/streaming/video/VideoQuality;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mQualityHasChanged']"
		[Register ("mQualityHasChanged")]
		protected bool MQualityHasChanged {
			get {
				const string __id = "mQualityHasChanged.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mQualityHasChanged.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mSurfaceHolder']"
		[Register ("mSurfaceHolder")]
		protected global::Android.Views.ISurfaceHolder MSurfaceHolder {
			get {
				const string __id = "mSurfaceHolder.Landroid/view/SurfaceHolder;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSurfaceHolder.Landroid/view/SurfaceHolder;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mSurfaceHolderCallback']"
		[Register ("mSurfaceHolderCallback")]
		protected global::Android.Views.ISurfaceHolderCallback MSurfaceHolderCallback {
			get {
				const string __id = "mSurfaceHolderCallback.Landroid/view/SurfaceHolder$Callback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolderCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSurfaceHolderCallback.Landroid/view/SurfaceHolder$Callback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mSurfaceTexture']"
		[Register ("mSurfaceTexture")]
		protected global::Android.Graphics.SurfaceTexture MSurfaceTexture {
			get {
				const string __id = "mSurfaceTexture.Landroid/graphics/SurfaceTexture;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSurfaceTexture.Landroid/graphics/SurfaceTexture;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mVideoEncoder']"
		[Register ("mVideoEncoder")]
		protected int MVideoEncoder {
			get {
				const string __id = "mVideoEncoder.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mVideoEncoder.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mZoomMax']"
		[Register ("mZoomMax")]
		protected int MZoomMax {
			get {
				const string __id = "mZoomMax.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mZoomMax.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='mZoomVal']"
		[Register ("mZoomVal")]
		protected int MZoomVal {
			get {
				const string __id = "mZoomVal.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mZoomVal.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/field[@name='m_cameraInfo']"
		[Register ("m_cameraInfo")]
		protected global::Veg.Mediacapture.Sdk.Camera.CameraServiceCameraInfo MCameraInfo {
			get {
				const string __id = "m_cameraInfo.Lveg/mediacapture/sdk/camera/CameraService$CameraInfo;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.CameraServiceCameraInfo> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "m_cameraInfo.Lveg/mediacapture/sdk/camera/CameraService$CameraInfo;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/video/VideoStream", typeof (VideoStream));

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

		protected VideoStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/constructor[@name='VideoStream' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe VideoStream (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/constructor[@name='VideoStream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(ILandroid/content/Context;)V", "")]
		public unsafe VideoStream (int camera, global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILandroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (camera);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_getFlashState;
#pragma warning disable 0169
		static Delegate GetGetFlashStateHandler ()
		{
			if (cb_getFlashState == null)
				cb_getFlashState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetFlashState);
			return cb_getFlashState;
		}

		static bool n_GetFlashState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FlashState;
		}
#pragma warning restore 0169

		static Delegate cb_setFlashState_Z;
#pragma warning disable 0169
		static Delegate GetSetFlashState_ZHandler ()
		{
			if (cb_setFlashState_Z == null)
				cb_setFlashState_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFlashState_Z);
			return cb_setFlashState_Z;
		}

		static void n_SetFlashState_Z (IntPtr jnienv, IntPtr native__this, bool state)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlashState = state;
		}
#pragma warning restore 0169

		public virtual unsafe bool FlashState {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='getFlashState' and count(parameter)=0]"
			[Register ("getFlashState", "()Z", "GetGetFlashStateHandler")]
			get {
				const string __id = "getFlashState.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setFlashState' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlashState", "(Z)V", "GetSetFlashState_ZHandler")]
			set {
				const string __id = "setFlashState.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getProjection;
#pragma warning disable 0169
		static Delegate GetGetProjectionHandler ()
		{
			if (cb_getProjection == null)
				cb_getProjection = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProjection);
			return cb_getProjection;
		}

		static IntPtr n_GetProjection (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Projection);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Media.Projection.MediaProjection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Landroid/media/projection/MediaProjection;", "GetGetProjectionHandler")]
			get {
				const string __id = "getProjection.()Landroid/media/projection/MediaProjection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Media.Projection.MediaProjection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getZoom;
#pragma warning disable 0169
		static Delegate GetGetZoomHandler ()
		{
			if (cb_getZoom == null)
				cb_getZoom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetZoom);
			return cb_getZoom;
		}

		static int n_GetZoom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Zoom;
		}
#pragma warning restore 0169

		static Delegate cb_setZoom_I;
#pragma warning disable 0169
		static Delegate GetSetZoom_IHandler ()
		{
			if (cb_setZoom_I == null)
				cb_setZoom_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetZoom_I);
			return cb_setZoom_I;
		}

		static void n_SetZoom_I (IntPtr jnienv, IntPtr native__this, int zoomVal)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Zoom = zoomVal;
		}
#pragma warning restore 0169

		public virtual unsafe int Zoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='getZoom' and count(parameter)=0]"
			[Register ("getZoom", "()I", "GetGetZoomHandler")]
			get {
				const string __id = "getZoom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZoom", "(I)V", "GetSetZoom_IHandler")]
			set {
				const string __id = "setZoom.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getZoomVal;
#pragma warning disable 0169
		static Delegate GetGetZoomValHandler ()
		{
			if (cb_getZoomVal == null)
				cb_getZoomVal = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetZoomVal);
			return cb_getZoomVal;
		}

		static int n_GetZoomVal (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZoomVal;
		}
#pragma warning restore 0169

		public virtual unsafe int ZoomVal {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='getZoomVal' and count(parameter)=0]"
			[Register ("getZoomVal", "()I", "GetGetZoomValHandler")]
			get {
				const string __id = "getZoomVal.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_TakeScreenshotImage;
#pragma warning disable 0169
		static Delegate GetTakeScreenshotImageHandler ()
		{
			if (cb_TakeScreenshotImage == null)
				cb_TakeScreenshotImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TakeScreenshotImage);
			return cb_TakeScreenshotImage;
		}

		static IntPtr n_TakeScreenshotImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TakeScreenshotImage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='TakeScreenshotImage' and count(parameter)=0]"
		[Register ("TakeScreenshotImage", "()Landroid/media/Image;", "GetTakeScreenshotImageHandler")]
		public virtual unsafe global::Android.Media.Image TakeScreenshotImage ()
		{
			const string __id = "TakeScreenshotImage.()Landroid/media/Image;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Media.Image> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_check_device;
#pragma warning disable 0169
		static Delegate GetCheck_deviceHandler ()
		{
			if (cb_check_device == null)
				cb_check_device = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Check_device);
			return cb_check_device;
		}

		static void n_Check_device (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Check_device ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='check_device' and count(parameter)=0]"
		[Register ("check_device", "()V", "GetCheck_deviceHandler")]
		public virtual unsafe void Check_device ()
		{
			const string __id = "check_device.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_generateSessionDescription;
#pragma warning disable 0169
		static Delegate GetGenerateSessionDescriptionHandler ()
		{
			if (cb_generateSessionDescription == null)
				cb_generateSessionDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GenerateSessionDescription);
			return cb_generateSessionDescription;
		}

		static IntPtr n_GenerateSessionDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateSessionDescription ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='generateSessionDescription' and count(parameter)=0]"
		[Register ("generateSessionDescription", "()Ljava/lang/String;", "GetGenerateSessionDescriptionHandler")]
		public abstract string GenerateSessionDescription ();

		static Delegate cb_prepare_preview;
#pragma warning disable 0169
		static Delegate GetPrepare_previewHandler ()
		{
			if (cb_prepare_preview == null)
				cb_prepare_preview = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Prepare_preview);
			return cb_prepare_preview;
		}

		static void n_Prepare_preview (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Prepare_preview ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='prepare_preview' and count(parameter)=0]"
		[Register ("prepare_preview", "()V", "GetPrepare_previewHandler")]
		public virtual unsafe void Prepare_preview ()
		{
			const string __id = "prepare_preview.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCamera_I;
#pragma warning disable 0169
		static Delegate GetSetCamera_IHandler ()
		{
			if (cb_setCamera_I == null)
				cb_setCamera_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCamera_I);
			return cb_setCamera_I;
		}

		static void n_SetCamera_I (IntPtr jnienv, IntPtr native__this, int camera)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCamera (camera);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setCamera' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCamera", "(I)V", "GetSetCamera_IHandler")]
		public virtual unsafe void SetCamera (int camera)
		{
			const string __id = "setCamera.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (camera);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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

		static void n_SetPreviewDisplay_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surfaceHolder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var surfaceHolder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_surfaceHolder, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewDisplay (surfaceHolder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setPreviewDisplay' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("setPreviewDisplay", "(Landroid/view/SurfaceHolder;)V", "GetSetPreviewDisplay_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SetPreviewDisplay (global::Android.Views.ISurfaceHolder surfaceHolder)
		{
			const string __id = "setPreviewDisplay.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surfaceHolder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceHolder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (surfaceHolder);
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

		static void n_SetPreviewTexture_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surfaceTexture)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var surfaceTexture = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_surfaceTexture, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviewTexture (surfaceTexture);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setPreviewTexture' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("setPreviewTexture", "(Landroid/graphics/SurfaceTexture;)V", "GetSetPreviewTexture_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void SetPreviewTexture (global::Android.Graphics.SurfaceTexture surfaceTexture)
		{
			const string __id = "setPreviewTexture.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surfaceTexture == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceTexture).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (surfaceTexture);
			}
		}

		static Delegate cb_setProjectionManager_Landroid_media_projection_MediaProjectionManager_;
#pragma warning disable 0169
		static Delegate GetSetProjectionManager_Landroid_media_projection_MediaProjectionManager_Handler ()
		{
			if (cb_setProjectionManager_Landroid_media_projection_MediaProjectionManager_ == null)
				cb_setProjectionManager_Landroid_media_projection_MediaProjectionManager_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProjectionManager_Landroid_media_projection_MediaProjectionManager_);
			return cb_setProjectionManager_Landroid_media_projection_MediaProjectionManager_;
		}

		static void n_SetProjectionManager_Landroid_media_projection_MediaProjectionManager_ (IntPtr jnienv, IntPtr native__this, IntPtr native_projectionManager)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var projectionManager = global::Java.Lang.Object.GetObject<global::Android.Media.Projection.MediaProjectionManager> (native_projectionManager, JniHandleOwnership.DoNotTransfer);
			__this.SetProjectionManager (projectionManager);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setProjectionManager' and count(parameter)=1 and parameter[1][@type='android.media.projection.MediaProjectionManager']]"
		[Register ("setProjectionManager", "(Landroid/media/projection/MediaProjectionManager;)V", "GetSetProjectionManager_Landroid_media_projection_MediaProjectionManager_Handler")]
		public virtual unsafe void SetProjectionManager (global::Android.Media.Projection.MediaProjectionManager projectionManager)
		{
			const string __id = "setProjectionManager.(Landroid/media/projection/MediaProjectionManager;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((projectionManager == null) ? IntPtr.Zero : ((global::Java.Lang.Object) projectionManager).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (projectionManager);
			}
		}

		static Delegate cb_setResultCodeData_ILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetSetResultCodeData_ILandroid_content_Intent_Handler ()
		{
			if (cb_setResultCodeData_ILandroid_content_Intent_ == null)
				cb_setResultCodeData_ILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetResultCodeData_ILandroid_content_Intent_);
			return cb_setResultCodeData_ILandroid_content_Intent_;
		}

		static void n_SetResultCodeData_ILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int resultCode, IntPtr native_resultData)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var resultData = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_resultData, JniHandleOwnership.DoNotTransfer);
			__this.SetResultCodeData (resultCode, resultData);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setResultCodeData' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("setResultCodeData", "(ILandroid/content/Intent;)V", "GetSetResultCodeData_ILandroid_content_Intent_Handler")]
		public virtual unsafe void SetResultCodeData (int resultCode, global::Android.Content.Intent resultData)
		{
			const string __id = "setResultCodeData.(ILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (resultCode);
				__args [1] = new JniArgumentValue ((resultData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resultData).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (resultData);
			}
		}

		static Delegate cb_setVideoEncoder_I;
#pragma warning disable 0169
		static Delegate GetSetVideoEncoder_IHandler ()
		{
			if (cb_setVideoEncoder_I == null)
				cb_setVideoEncoder_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoEncoder_I);
			return cb_setVideoEncoder_I;
		}

		static void n_SetVideoEncoder_I (IntPtr jnienv, IntPtr native__this, int videoEncoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoEncoder (videoEncoder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setVideoEncoder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setVideoEncoder", "(I)V", "GetSetVideoEncoder_IHandler")]
		protected virtual unsafe void SetVideoEncoder (int videoEncoder)
		{
			const string __id = "setVideoEncoder.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (videoEncoder);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVideoEncodingBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetVideoEncodingBitrate_IHandler ()
		{
			if (cb_setVideoEncodingBitrate_I == null)
				cb_setVideoEncodingBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoEncodingBitrate_I);
			return cb_setVideoEncodingBitrate_I;
		}

		static void n_SetVideoEncodingBitrate_I (IntPtr jnienv, IntPtr native__this, int bitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoEncodingBitrate (bitrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setVideoEncodingBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setVideoEncodingBitrate", "(I)V", "GetSetVideoEncodingBitrate_IHandler")]
		public virtual unsafe void SetVideoEncodingBitrate (int bitrate)
		{
			const string __id = "setVideoEncodingBitrate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitrate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVideoFramerate_I;
#pragma warning disable 0169
		static Delegate GetSetVideoFramerate_IHandler ()
		{
			if (cb_setVideoFramerate_I == null)
				cb_setVideoFramerate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoFramerate_I);
			return cb_setVideoFramerate_I;
		}

		static void n_SetVideoFramerate_I (IntPtr jnienv, IntPtr native__this, int rate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoFramerate (rate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setVideoFramerate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setVideoFramerate", "(I)V", "GetSetVideoFramerate_IHandler")]
		public virtual unsafe void SetVideoFramerate (int rate)
		{
			const string __id = "setVideoFramerate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (rate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_;
#pragma warning disable 0169
		static Delegate GetSetVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_Handler ()
		{
			if (cb_setVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ == null)
				cb_setVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_);
			return cb_setVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_;
		}

		static void n_SetVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ (IntPtr jnienv, IntPtr native__this, IntPtr native_videoQuality)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var videoQuality = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (native_videoQuality, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoQuality (videoQuality);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setVideoQuality' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.video.VideoQuality']]"
		[Register ("setVideoQuality", "(Lveg/mediacapture/sdk/streaming/video/VideoQuality;)V", "GetSetVideoQuality_Lveg_mediacapture_sdk_streaming_video_VideoQuality_Handler")]
		public virtual unsafe void SetVideoQuality (global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality videoQuality)
		{
			const string __id = "setVideoQuality.(Lveg/mediacapture/sdk/streaming/video/VideoQuality;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((videoQuality == null) ? IntPtr.Zero : ((global::Java.Lang.Object) videoQuality).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (videoQuality);
			}
		}

		static Delegate cb_setVideoSize_II;
#pragma warning disable 0169
		static Delegate GetSetVideoSize_IIHandler ()
		{
			if (cb_setVideoSize_II == null)
				cb_setVideoSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetVideoSize_II);
			return cb_setVideoSize_II;
		}

		static void n_SetVideoSize_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoSize (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='setVideoSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setVideoSize", "(II)V", "GetSetVideoSize_IIHandler")]
		public virtual unsafe void SetVideoSize (int width, int height)
		{
			const string __id = "setVideoSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stop_preview;
#pragma warning disable 0169
		static Delegate GetStop_previewHandler ()
		{
			if (cb_stop_preview == null)
				cb_stop_preview = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop_preview);
			return cb_stop_preview;
		}

		static void n_Stop_preview (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop_preview ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='stop_preview' and count(parameter)=0]"
		[Register ("stop_preview", "()V", "GetStop_previewHandler")]
		public virtual unsafe void Stop_preview ()
		{
			const string __id = "stop_preview.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/video/VideoStream", DoNotGenerateAcw=true)]
	internal partial class VideoStreamInvoker : VideoStream {
		public VideoStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/video/VideoStream", typeof (VideoStreamInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoStream']/method[@name='generateSessionDescription' and count(parameter)=0]"
		[Register ("generateSessionDescription", "()Ljava/lang/String;", "GetGenerateSessionDescriptionHandler")]
		public override unsafe string GenerateSessionDescription ()
		{
			const string __id = "generateSessionDescription.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public override unsafe bool IsCheckedStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='isCheckedStream' and count(parameter)=0]"
			[Register ("isCheckedStream", "()Z", "GetIsCheckedStreamHandler")]
			get {
				const string __id = "isCheckedStream.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
