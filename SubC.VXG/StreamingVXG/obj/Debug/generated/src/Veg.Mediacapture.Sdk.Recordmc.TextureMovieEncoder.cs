using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Recordmc {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/recordmc/TextureMovieEncoder", DoNotGenerateAcw=true)]
	public partial class TextureMovieEncoder : global::Java.Lang.Object, global::Java.Lang.IRunnable {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/field[@name='mReadyFence']"
		[Register ("mReadyFence")]
		public global::Java.Lang.Object MReadyFence {
			get {
				const string __id = "mReadyFence.Ljava/lang/Object;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mReadyFence.Ljava/lang/Object;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder.EncoderConfig']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/recordmc/TextureMovieEncoder$EncoderConfig", DoNotGenerateAcw=true)]
		public partial class EncoderConfig : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/recordmc/TextureMovieEncoder$EncoderConfig", typeof (EncoderConfig));

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

			protected EncoderConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder.EncoderConfig']/constructor[@name='TextureMovieEncoder.EncoderConfig' and count(parameter)=13 and parameter[1][@type='java.io.File'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='android.opengl.EGLContext'] and parameter[8][@type='android.content.Context'] and parameter[9][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[10][@type='veg.mediacapture.sdk.InternalDataCallback'] and parameter[11][@type='veg.mediacapture.sdk.MediaCaptureCallback'] and parameter[12][@type='boolean'] and parameter[13][@type='boolean']]"
			[Register (".ctor", "(Ljava/io/File;IIIIILandroid/opengl/EGLContext;Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;ZZ)V", "")]
			public unsafe EncoderConfig (global::Java.IO.File outputFile, int width, int height, int bitRate, int fps, int iframe_interval, global::Android.Opengl.EGLContext sharedEglContext, global::Android.Content.Context context, global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IInternalDataCallback callback_internal, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback, bool is_secondary, bool is_transcoding) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Ljava/io/File;IIIIILandroid/opengl/EGLContext;Landroid/content/Context;Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/InternalDataCallback;Lveg/mediacapture/sdk/MediaCaptureCallback;ZZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [13];
					__args [0] = new JniArgumentValue ((outputFile == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputFile).Handle);
					__args [1] = new JniArgumentValue (width);
					__args [2] = new JniArgumentValue (height);
					__args [3] = new JniArgumentValue (bitRate);
					__args [4] = new JniArgumentValue (fps);
					__args [5] = new JniArgumentValue (iframe_interval);
					__args [6] = new JniArgumentValue ((sharedEglContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedEglContext).Handle);
					__args [7] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [8] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
					__args [9] = new JniArgumentValue ((callback_internal == null) ? IntPtr.Zero : ((global::Java.Lang.Object) callback_internal).Handle);
					__args [10] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
					__args [11] = new JniArgumentValue (is_secondary);
					__args [12] = new JniArgumentValue (is_transcoding);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (outputFile);
					global::System.GC.KeepAlive (sharedEglContext);
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (config);
					global::System.GC.KeepAlive (callback_internal);
					global::System.GC.KeepAlive (@callback);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/recordmc/TextureMovieEncoder", typeof (TextureMovieEncoder));

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

		protected TextureMovieEncoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/constructor[@name='TextureMovieEncoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe TextureMovieEncoder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isRecording;
#pragma warning disable 0169
		static Delegate GetIsRecordingHandler ()
		{
			if (cb_isRecording == null)
				cb_isRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRecording);
			return cb_isRecording;
		}

		static bool n_IsRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecording;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRecording {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='isRecording' and count(parameter)=0]"
			[Register ("isRecording", "()Z", "GetIsRecordingHandler")]
			get {
				const string __id = "isRecording.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_frameAvailable_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetFrameAvailable_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_frameAvailable_Landroid_graphics_SurfaceTexture_ == null)
				cb_frameAvailable_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FrameAvailable_Landroid_graphics_SurfaceTexture_);
			return cb_frameAvailable_Landroid_graphics_SurfaceTexture_;
		}

		static void n_FrameAvailable_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_st)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var st = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_st, JniHandleOwnership.DoNotTransfer);
			__this.FrameAvailable (st);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='frameAvailable' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("frameAvailable", "(Landroid/graphics/SurfaceTexture;)V", "GetFrameAvailable_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void FrameAvailable (global::Android.Graphics.SurfaceTexture st)
		{
			const string __id = "frameAvailable.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((st == null) ? IntPtr.Zero : ((global::Java.Lang.Object) st).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (st);
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetBitrate_IHandler ()
		{
			if (cb_setBitrate_I == null)
				cb_setBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBitrate_I);
			return cb_setBitrate_I;
		}

		static void n_SetBitrate_I (IntPtr jnienv, IntPtr native__this, int bitRate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBitrate (bitRate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='setBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBitrate", "(I)V", "GetSetBitrate_IHandler")]
		public virtual unsafe void SetBitrate (int bitRate)
		{
			const string __id = "setBitrate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitRate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFramerate_I;
#pragma warning disable 0169
		static Delegate GetSetFramerate_IHandler ()
		{
			if (cb_setFramerate_I == null)
				cb_setFramerate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetFramerate_I);
			return cb_setFramerate_I;
		}

		static void n_SetFramerate_I (IntPtr jnienv, IntPtr native__this, int fps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFramerate (fps);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='setFramerate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setFramerate", "(I)V", "GetSetFramerate_IHandler")]
		public virtual unsafe void SetFramerate (int fps)
		{
			const string __id = "setFramerate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (fps);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTextureId_I;
#pragma warning disable 0169
		static Delegate GetSetTextureId_IHandler ()
		{
			if (cb_setTextureId_I == null)
				cb_setTextureId_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTextureId_I);
			return cb_setTextureId_I;
		}

		static void n_SetTextureId_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTextureId (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='setTextureId' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTextureId", "(I)V", "GetSetTextureId_IHandler")]
		public virtual unsafe void SetTextureId (int id)
		{
			const string __id = "setTextureId.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startRecording_Lveg_mediacapture_sdk_recordmc_TextureMovieEncoder_EncoderConfig_;
#pragma warning disable 0169
		static Delegate GetStartRecording_Lveg_mediacapture_sdk_recordmc_TextureMovieEncoder_EncoderConfig_Handler ()
		{
			if (cb_startRecording_Lveg_mediacapture_sdk_recordmc_TextureMovieEncoder_EncoderConfig_ == null)
				cb_startRecording_Lveg_mediacapture_sdk_recordmc_TextureMovieEncoder_EncoderConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_StartRecording_Lveg_mediacapture_sdk_recordmc_TextureMovieEncoder_EncoderConfig_);
			return cb_startRecording_Lveg_mediacapture_sdk_recordmc_TextureMovieEncoder_EncoderConfig_;
		}

		static void n_StartRecording_Lveg_mediacapture_sdk_recordmc_TextureMovieEncoder_EncoderConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder.EncoderConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.StartRecording (config);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='startRecording' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.recordmc.TextureMovieEncoder.EncoderConfig']]"
		[Register ("startRecording", "(Lveg/mediacapture/sdk/recordmc/TextureMovieEncoder$EncoderConfig;)V", "GetStartRecording_Lveg_mediacapture_sdk_recordmc_TextureMovieEncoder_EncoderConfig_Handler")]
		public virtual unsafe void StartRecording (global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder.EncoderConfig config)
		{
			const string __id = "startRecording.(Lveg/mediacapture/sdk/recordmc/TextureMovieEncoder$EncoderConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

		static Delegate cb_stopRecording;
#pragma warning disable 0169
		static Delegate GetStopRecordingHandler ()
		{
			if (cb_stopRecording == null)
				cb_stopRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopRecording);
			return cb_stopRecording;
		}

		static void n_StopRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecording ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='stopRecording' and count(parameter)=0]"
		[Register ("stopRecording", "()V", "GetStopRecordingHandler")]
		public virtual unsafe void StopRecording ()
		{
			const string __id = "stopRecording.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateSharedContext_Landroid_opengl_EGLContext_;
#pragma warning disable 0169
		static Delegate GetUpdateSharedContext_Landroid_opengl_EGLContext_Handler ()
		{
			if (cb_updateSharedContext_Landroid_opengl_EGLContext_ == null)
				cb_updateSharedContext_Landroid_opengl_EGLContext_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_UpdateSharedContext_Landroid_opengl_EGLContext_);
			return cb_updateSharedContext_Landroid_opengl_EGLContext_;
		}

		static void n_UpdateSharedContext_Landroid_opengl_EGLContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sharedContext)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.TextureMovieEncoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sharedContext = global::Java.Lang.Object.GetObject<global::Android.Opengl.EGLContext> (native_sharedContext, JniHandleOwnership.DoNotTransfer);
			__this.UpdateSharedContext (sharedContext);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='TextureMovieEncoder']/method[@name='updateSharedContext' and count(parameter)=1 and parameter[1][@type='android.opengl.EGLContext']]"
		[Register ("updateSharedContext", "(Landroid/opengl/EGLContext;)V", "GetUpdateSharedContext_Landroid_opengl_EGLContext_Handler")]
		public virtual unsafe void UpdateSharedContext (global::Android.Opengl.EGLContext sharedContext)
		{
			const string __id = "updateSharedContext.(Landroid/opengl/EGLContext;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((sharedContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sharedContext).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (sharedContext);
			}
		}

	}
}
