using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Recordmc {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/recordmc/CameraSurfaceRenderer", DoNotGenerateAcw=true)]
	public partial class CameraSurfaceRenderer : global::Java.Lang.Object, global::Android.Opengl.GLSurfaceView.IRenderer {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/field[@name='sCSRenderer']"
		[Register ("sCSRenderer")]
		public static global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer SCSRenderer {
			get {
				const string __id = "sCSRenderer.Lveg/mediacapture/sdk/recordmc/CameraSurfaceRenderer;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "sCSRenderer.Lveg/mediacapture/sdk/recordmc/CameraSurfaceRenderer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/recordmc/CameraSurfaceRenderer", typeof (CameraSurfaceRenderer));

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

		protected CameraSurfaceRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/constructor[@name='CameraSurfaceRenderer' and count(parameter)=4 and parameter[1][@type='android.content.Context'] and parameter[2][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[3][@type='veg.mediacapture.sdk.InternalDataCallback'] and parameter[4][@type='veg.mediacapture.sdk.MediaCaptureCallback']]"
		[Register (".ctor", "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;)V", "")]
		public unsafe CameraSurfaceRenderer (global::Android.Content.Context context, global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IInternalDataCallback callback_internal, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [2] = new JniArgumentValue ((callback_internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callback_internal).Handle);
				__args [3] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (callback_internal);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_getSurface;
#pragma warning disable 0169
		static Delegate GetGetSurfaceHandler ()
		{
			if (cb_getSurface == null)
				cb_getSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurface);
			return cb_getSurface;
		}

		static IntPtr n_GetSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Surface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.Surface Surface {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='getSurface' and count(parameter)=0]"
			[Register ("getSurface", "()Landroid/view/Surface;", "GetGetSurfaceHandler")]
			get {
				const string __id = "getSurface.()Landroid/view/Surface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_ApplyBitrate_IZ;
#pragma warning disable 0169
		static Delegate GetApplyBitrate_IZHandler ()
		{
			if (cb_ApplyBitrate_IZ == null)
				cb_ApplyBitrate_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_V) n_ApplyBitrate_IZ);
			return cb_ApplyBitrate_IZ;
		}

		static void n_ApplyBitrate_IZ (IntPtr jnienv, IntPtr native__this, int bitrate, bool is_secondary)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyBitrate (bitrate, is_secondary);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='ApplyBitrate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("ApplyBitrate", "(IZ)V", "GetApplyBitrate_IZHandler")]
		public virtual unsafe void ApplyBitrate (int bitrate, bool is_secondary)
		{
			const string __id = "ApplyBitrate.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bitrate);
				__args [1] = new JniArgumentValue (is_secondary);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ApplyFramerate_IZ;
#pragma warning disable 0169
		static Delegate GetApplyFramerate_IZHandler ()
		{
			if (cb_ApplyFramerate_IZ == null)
				cb_ApplyFramerate_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_V) n_ApplyFramerate_IZ);
			return cb_ApplyFramerate_IZ;
		}

		static void n_ApplyFramerate_IZ (IntPtr jnienv, IntPtr native__this, int fps, bool is_secondary)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyFramerate (fps, is_secondary);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='ApplyFramerate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("ApplyFramerate", "(IZ)V", "GetApplyFramerate_IZHandler")]
		public virtual unsafe void ApplyFramerate (int fps, bool is_secondary)
		{
			const string __id = "ApplyFramerate.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fps);
				__args [1] = new JniArgumentValue (is_secondary);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_changeFilterMode_I;
#pragma warning disable 0169
		static Delegate GetChangeFilterMode_IHandler ()
		{
			if (cb_changeFilterMode_I == null)
				cb_changeFilterMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_ChangeFilterMode_I);
			return cb_changeFilterMode_I;
		}

		static void n_ChangeFilterMode_I (IntPtr jnienv, IntPtr native__this, int filter)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChangeFilterMode (filter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='changeFilterMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("changeFilterMode", "(I)V", "GetChangeFilterMode_IHandler")]
		public virtual unsafe void ChangeFilterMode (int filter)
		{
			const string __id = "changeFilterMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (filter);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_notifyPausing;
#pragma warning disable 0169
		static Delegate GetNotifyPausingHandler ()
		{
			if (cb_notifyPausing == null)
				cb_notifyPausing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_NotifyPausing);
			return cb_notifyPausing;
		}

		static void n_NotifyPausing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyPausing ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='notifyPausing' and count(parameter)=0]"
		[Register ("notifyPausing", "()V", "GetNotifyPausingHandler")]
		public virtual unsafe void NotifyPausing ()
		{
			const string __id = "notifyPausing.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
#pragma warning disable 0169
		static Delegate GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler ()
		{
			if (cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ == null)
				cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_);
			return cb_onDrawFrame_Ljavax_microedition_khronos_opengles_GL10_;
		}

		static void n_OnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unused)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var unused = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_unused, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFrame (unused);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='onDrawFrame' and count(parameter)=1 and parameter[1][@type='javax.microedition.khronos.opengles.GL10']]"
		[Register ("onDrawFrame", "(Ljavax/microedition/khronos/opengles/GL10;)V", "GetOnDrawFrame_Ljavax_microedition_khronos_opengles_GL10_Handler")]
		public virtual unsafe void OnDrawFrame (global::Javax.Microedition.Khronos.Opengles.IGL10 unused)
		{
			const string __id = "onDrawFrame.(Ljavax/microedition/khronos/opengles/GL10;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((unused == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unused).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (unused);
			}
		}

		static Delegate cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
#pragma warning disable 0169
		static Delegate GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler ()
		{
			if (cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II == null)
				cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II);
			return cb_onSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II;
		}

		static void n_OnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_II (IntPtr jnienv, IntPtr native__this, IntPtr native_gl, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gl = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_gl, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceChanged (gl, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='onSurfaceChanged' and count(parameter)=3 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("onSurfaceChanged", "(Ljavax/microedition/khronos/opengles/GL10;II)V", "GetOnSurfaceChanged_Ljavax_microedition_khronos_opengles_GL10_IIHandler")]
		public virtual unsafe void OnSurfaceChanged (global::Javax.Microedition.Khronos.Opengles.IGL10 gl, int width, int height)
		{
			const string __id = "onSurfaceChanged.(Ljavax/microedition/khronos/opengles/GL10;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((gl == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gl).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (gl);
			}
		}

		static Delegate cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
#pragma warning disable 0169
		static Delegate GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler ()
		{
			if (cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ == null)
				cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_);
			return cb_onSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_;
		}

		static void n_OnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_unused, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var unused = (global::Javax.Microedition.Khronos.Opengles.IGL10)global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Opengles.IGL10> (native_unused, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Javax.Microedition.Khronos.Egl.EGLConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.OnSurfaceCreated (unused, config);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='onSurfaceCreated' and count(parameter)=2 and parameter[1][@type='javax.microedition.khronos.opengles.GL10'] and parameter[2][@type='javax.microedition.khronos.egl.EGLConfig']]"
		[Register ("onSurfaceCreated", "(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V", "GetOnSurfaceCreated_Ljavax_microedition_khronos_opengles_GL10_Ljavax_microedition_khronos_egl_EGLConfig_Handler")]
		public virtual unsafe void OnSurfaceCreated (global::Javax.Microedition.Khronos.Opengles.IGL10 unused, global::Javax.Microedition.Khronos.Egl.EGLConfig config)
		{
			const string __id = "onSurfaceCreated.(Ljavax/microedition/khronos/opengles/GL10;Ljavax/microedition/khronos/egl/EGLConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((unused == null) ? IntPtr.Zero : ((global::Java.Lang.Object) unused).Handle);
				__args [1] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (unused);
				global::System.GC.KeepAlive (config);
			}
		}

		static Delegate cb_onVideoEncoderQuit;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoderQuitHandler ()
		{
			if (cb_onVideoEncoderQuit == null)
				cb_onVideoEncoderQuit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnVideoEncoderQuit);
			return cb_onVideoEncoderQuit;
		}

		static void n_OnVideoEncoderQuit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoderQuit ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='onVideoEncoderQuit' and count(parameter)=0]"
		[Register ("onVideoEncoderQuit", "()V", "GetOnVideoEncoderQuitHandler")]
		public virtual unsafe void OnVideoEncoderQuit ()
		{
			const string __id = "onVideoEncoderQuit.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onVideoEncoderStartFailed;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoderStartFailedHandler ()
		{
			if (cb_onVideoEncoderStartFailed == null)
				cb_onVideoEncoderStartFailed = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnVideoEncoderStartFailed);
			return cb_onVideoEncoderStartFailed;
		}

		static void n_OnVideoEncoderStartFailed (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoderStartFailed ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='onVideoEncoderStartFailed' and count(parameter)=0]"
		[Register ("onVideoEncoderStartFailed", "()V", "GetOnVideoEncoderStartFailedHandler")]
		public virtual unsafe void OnVideoEncoderStartFailed ()
		{
			const string __id = "onVideoEncoderStartFailed.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler ()
		{
			if (cb_onVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ == null)
				cb_onVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_);
			return cb_onVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
		}

		static void n_OnVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ (IntPtr jnienv, IntPtr native__this, IntPtr native_video_encoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var video_encoder = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (native_video_encoder, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoderStarted (video_encoder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='onVideoEncoderStarted' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.recordmc.VideoEncoderCore']]"
		[Register ("onVideoEncoderStarted", "(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V", "GetOnVideoEncoderStarted_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler")]
		public virtual unsafe void OnVideoEncoderStarted (global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore video_encoder)
		{
			const string __id = "onVideoEncoderStarted.(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((video_encoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) video_encoder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (video_encoder);
			}
		}

		static Delegate cb_onVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
#pragma warning disable 0169
		static Delegate GetOnVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler ()
		{
			if (cb_onVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ == null)
				cb_onVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_);
			return cb_onVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_;
		}

		static void n_OnVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_ (IntPtr jnienv, IntPtr native__this, IntPtr native_video_encoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var video_encoder = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore> (native_video_encoder, JniHandleOwnership.DoNotTransfer);
			__this.OnVideoEncoderStopped (video_encoder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='onVideoEncoderStopped' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.recordmc.VideoEncoderCore']]"
		[Register ("onVideoEncoderStopped", "(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V", "GetOnVideoEncoderStopped_Lveg_mediacapture_sdk_recordmc_VideoEncoderCore_Handler")]
		public virtual unsafe void OnVideoEncoderStopped (global::Veg.Mediacapture.Sdk.Recordmc.VideoEncoderCore video_encoder)
		{
			const string __id = "onVideoEncoderStopped.(Lveg/mediacapture/sdk/recordmc/VideoEncoderCore;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((video_encoder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) video_encoder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (video_encoder);
			}
		}

		static Delegate cb_setCameraPreviewSize_II;
#pragma warning disable 0169
		static Delegate GetSetCameraPreviewSize_IIHandler ()
		{
			if (cb_setCameraPreviewSize_II == null)
				cb_setCameraPreviewSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetCameraPreviewSize_II);
			return cb_setCameraPreviewSize_II;
		}

		static void n_SetCameraPreviewSize_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraPreviewSize (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='setCameraPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCameraPreviewSize", "(II)V", "GetSetCameraPreviewSize_IIHandler")]
		public virtual unsafe void SetCameraPreviewSize (int width, int height)
		{
			const string __id = "setCameraPreviewSize.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCameraPreviewViewport_IIII;
#pragma warning disable 0169
		static Delegate GetSetCameraPreviewViewport_IIIIHandler ()
		{
			if (cb_setCameraPreviewViewport_IIII == null)
				cb_setCameraPreviewViewport_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_V) n_SetCameraPreviewViewport_IIII);
			return cb_setCameraPreviewViewport_IIII;
		}

		static void n_SetCameraPreviewViewport_IIII (IntPtr jnienv, IntPtr native__this, int x, int y, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCameraPreviewViewport (x, y, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='setCameraPreviewViewport' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setCameraPreviewViewport", "(IIII)V", "GetSetCameraPreviewViewport_IIIIHandler")]
		public virtual unsafe void SetCameraPreviewViewport (int x, int y, int width, int height)
		{
			const string __id = "setCameraPreviewViewport.(IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startRecord;
#pragma warning disable 0169
		static Delegate GetStartRecordHandler ()
		{
			if (cb_startRecord == null)
				cb_startRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartRecord);
			return cb_startRecord;
		}

		static void n_StartRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartRecord ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='startRecord' and count(parameter)=0]"
		[Register ("startRecord", "()V", "GetStartRecordHandler")]
		public virtual unsafe void StartRecord ()
		{
			const string __id = "startRecord.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stopRecord;
#pragma warning disable 0169
		static Delegate GetStopRecordHandler ()
		{
			if (cb_stopRecord == null)
				cb_stopRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopRecord);
			return cb_stopRecord;
		}

		static void n_StopRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecord ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='stopRecord' and count(parameter)=0]"
		[Register ("stopRecord", "()V", "GetStopRecordHandler")]
		public virtual unsafe void StopRecord ()
		{
			const string __id = "stopRecord.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateFilter;
#pragma warning disable 0169
		static Delegate GetUpdateFilterHandler ()
		{
			if (cb_updateFilter == null)
				cb_updateFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_UpdateFilter);
			return cb_updateFilter;
		}

		static void n_UpdateFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.CameraSurfaceRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateFilter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='CameraSurfaceRenderer']/method[@name='updateFilter' and count(parameter)=0]"
		[Register ("updateFilter", "()V", "GetUpdateFilterHandler")]
		public virtual unsafe void UpdateFilter ()
		{
			const string __id = "updateFilter.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
