using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Media.Cts {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']"
	[global::Android.Runtime.Register ("android/media/cts/OutputSurface18", DoNotGenerateAcw=true)]
	public partial class OutputSurface18 : global::Android.Media.Cts.OutputSurface {
		// Metadata.xml XPath field reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 4;

		static readonly JniPeerMembers _members = new XAPeerMembers ("android/media/cts/OutputSurface18", typeof (OutputSurface18));

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

		protected OutputSurface18 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/constructor[@name='OutputSurface18' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OutputSurface18 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/constructor[@name='OutputSurface18' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe OutputSurface18 (int width, int height) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Surface);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Views.Surface Surface {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='getSurface' and count(parameter)=0]"
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

		static Delegate cb_getSurfaceTexture;
#pragma warning disable 0169
		static Delegate GetGetSurfaceTextureHandler ()
		{
			if (cb_getSurfaceTexture == null)
				cb_getSurfaceTexture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurfaceTexture);
			return cb_getSurfaceTexture;
		}

		static IntPtr n_GetSurfaceTexture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceTexture);
		}
#pragma warning restore 0169

		public override unsafe global::Android.Graphics.SurfaceTexture SurfaceTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='getSurfaceTexture' and count(parameter)=0]"
			[Register ("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", "GetGetSurfaceTextureHandler")]
			get {
				const string __id = "getSurfaceTexture.()Landroid/graphics/SurfaceTexture;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTextureId;
#pragma warning disable 0169
		static Delegate GetGetTextureIdHandler ()
		{
			if (cb_getTextureId == null)
				cb_getTextureId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTextureId);
			return cb_getTextureId;
		}

		static int n_GetTextureId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextureId;
		}
#pragma warning restore 0169

		public override unsafe int TextureId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='getTextureId' and count(parameter)=0]"
			[Register ("getTextureId", "()I", "GetGetTextureIdHandler")]
			get {
				const string __id = "getTextureId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_awaitNewImage;
#pragma warning disable 0169
		static Delegate GetAwaitNewImageHandler ()
		{
			if (cb_awaitNewImage == null)
				cb_awaitNewImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_AwaitNewImage);
			return cb_awaitNewImage;
		}

		static bool n_AwaitNewImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AwaitNewImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='awaitNewImage' and count(parameter)=0]"
		[Register ("awaitNewImage", "()Z", "GetAwaitNewImageHandler")]
		public override unsafe bool AwaitNewImage ()
		{
			const string __id = "awaitNewImage.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_changeFragmentShader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetChangeFragmentShader_Ljava_lang_String_Handler ()
		{
			if (cb_changeFragmentShader_Ljava_lang_String_ == null)
				cb_changeFragmentShader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ChangeFragmentShader_Ljava_lang_String_);
			return cb_changeFragmentShader_Ljava_lang_String_;
		}

		static void n_ChangeFragmentShader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fragmentShader)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var fragmentShader = JNIEnv.GetString (native_fragmentShader, JniHandleOwnership.DoNotTransfer);
			__this.ChangeFragmentShader (fragmentShader);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='changeFragmentShader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("changeFragmentShader", "(Ljava/lang/String;)V", "GetChangeFragmentShader_Ljava_lang_String_Handler")]
		public virtual unsafe void ChangeFragmentShader (string fragmentShader)
		{
			const string __id = "changeFragmentShader.(Ljava/lang/String;)V";
			IntPtr native_fragmentShader = JNIEnv.NewString (fragmentShader);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fragmentShader);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_fragmentShader);
			}
		}

		static Delegate cb_checkForNewImage_I;
#pragma warning disable 0169
		static Delegate GetCheckForNewImage_IHandler ()
		{
			if (cb_checkForNewImage_I == null)
				cb_checkForNewImage_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_CheckForNewImage_I);
			return cb_checkForNewImage_I;
		}

		static bool n_CheckForNewImage_I (IntPtr jnienv, IntPtr native__this, int timeoutMs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CheckForNewImage (timeoutMs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='checkForNewImage' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("checkForNewImage", "(I)Z", "GetCheckForNewImage_IHandler")]
		public virtual unsafe bool CheckForNewImage (int timeoutMs)
		{
			const string __id = "checkForNewImage.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timeoutMs);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_drawImage;
#pragma warning disable 0169
		static Delegate GetDrawImageHandler ()
		{
			if (cb_drawImage == null)
				cb_drawImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DrawImage);
			return cb_drawImage;
		}

		static void n_DrawImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='drawImage' and count(parameter)=0]"
		[Register ("drawImage", "()V", "GetDrawImageHandler")]
		public override unsafe void DrawImage ()
		{
			const string __id = "drawImage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_makeCurrent;
#pragma warning disable 0169
		static Delegate GetMakeCurrentHandler ()
		{
			if (cb_makeCurrent == null)
				cb_makeCurrent = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MakeCurrent);
			return cb_makeCurrent;
		}

		static void n_MakeCurrent (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MakeCurrent ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='makeCurrent' and count(parameter)=0]"
		[Register ("makeCurrent", "()V", "GetMakeCurrentHandler")]
		public virtual unsafe void MakeCurrent ()
		{
			const string __id = "makeCurrent.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_ == null)
				cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFrameAvailable_Landroid_graphics_SurfaceTexture_);
			return cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnFrameAvailable_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_st)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var st = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_st, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameAvailable (st);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='onFrameAvailable' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onFrameAvailable", "(Landroid/graphics/SurfaceTexture;)V", "GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler")]
		public override unsafe void OnFrameAvailable (global::Android.Graphics.SurfaceTexture st)
		{
			const string __id = "onFrameAvailable.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((st == null) ? IntPtr.Zero : ((global::Java.Lang.Object) st).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (st);
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface18> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface18']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public override unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
