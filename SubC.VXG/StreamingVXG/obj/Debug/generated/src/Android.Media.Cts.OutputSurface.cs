using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Android.Media.Cts {

	// Metadata.xml XPath class reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']"
	[global::Android.Runtime.Register ("android/media/cts/OutputSurface", DoNotGenerateAcw=true)]
	public abstract partial class OutputSurface : global::Java.Lang.Object, global::Android.Graphics.SurfaceTexture.IOnFrameAvailableListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("android/media/cts/OutputSurface", typeof (OutputSurface));

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

		protected OutputSurface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/constructor[@name='OutputSurface' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe OutputSurface () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Surface);
		}
#pragma warning restore 0169

		public abstract global::Android.Views.Surface Surface {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='getSurface' and count(parameter)=0]"
			[Register ("getSurface", "()Landroid/view/Surface;", "GetGetSurfaceHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceTexture);
		}
#pragma warning restore 0169

		public abstract global::Android.Graphics.SurfaceTexture SurfaceTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='getSurfaceTexture' and count(parameter)=0]"
			[Register ("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", "GetGetSurfaceTextureHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextureId;
		}
#pragma warning restore 0169

		public abstract int TextureId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='getTextureId' and count(parameter)=0]"
			[Register ("getTextureId", "()I", "GetGetTextureIdHandler")]
			get; 
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
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AwaitNewImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='awaitNewImage' and count(parameter)=0]"
		[Register ("awaitNewImage", "()Z", "GetAwaitNewImageHandler")]
		public abstract bool AwaitNewImage ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawImage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='drawImage' and count(parameter)=0]"
		[Register ("drawImage", "()V", "GetDrawImageHandler")]
		public abstract void DrawImage ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public abstract void Release ();

		static Delegate cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_ == null)
				cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFrameAvailable_Landroid_graphics_SurfaceTexture_);
			return cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnFrameAvailable_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surfaceTexture)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Android.Media.Cts.OutputSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var surfaceTexture = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_surfaceTexture, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameAvailable (surfaceTexture);
		}
#pragma warning restore 0169

		[Register ("onFrameAvailable", "(Landroid/graphics/SurfaceTexture;)V", "GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler")]
		public abstract void OnFrameAvailable (global::Android.Graphics.SurfaceTexture surfaceTexture);

	}

	[global::Android.Runtime.Register ("android/media/cts/OutputSurface", DoNotGenerateAcw=true)]
	internal partial class OutputSurfaceInvoker : OutputSurface {
		public OutputSurfaceInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("android/media/cts/OutputSurface", typeof (OutputSurfaceInvoker));

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

		public override unsafe global::Android.Views.Surface Surface {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='getSurface' and count(parameter)=0]"
			[Register ("getSurface", "()Landroid/view/Surface;", "GetGetSurfaceHandler")]
			get {
				const string __id = "getSurface.()Landroid/view/Surface;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe global::Android.Graphics.SurfaceTexture SurfaceTexture {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='getSurfaceTexture' and count(parameter)=0]"
			[Register ("getSurfaceTexture", "()Landroid/graphics/SurfaceTexture;", "GetGetSurfaceTextureHandler")]
			get {
				const string __id = "getSurfaceTexture.()Landroid/graphics/SurfaceTexture;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe int TextureId {
			// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='getTextureId' and count(parameter)=0]"
			[Register ("getTextureId", "()I", "GetGetTextureIdHandler")]
			get {
				const string __id = "getTextureId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='awaitNewImage' and count(parameter)=0]"
		[Register ("awaitNewImage", "()Z", "GetAwaitNewImageHandler")]
		public override unsafe bool AwaitNewImage ()
		{
			const string __id = "awaitNewImage.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='drawImage' and count(parameter)=0]"
		[Register ("drawImage", "()V", "GetDrawImageHandler")]
		public override unsafe void DrawImage ()
		{
			const string __id = "drawImage.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='android.media.cts']/class[@name='OutputSurface']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public override unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		[Register ("onFrameAvailable", "(Landroid/graphics/SurfaceTexture;)V", "GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler")]
		public override unsafe void OnFrameAvailable (global::Android.Graphics.SurfaceTexture surfaceTexture)
		{
			const string __id = "onFrameAvailable.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surfaceTexture == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceTexture).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (surfaceTexture);
			}
		}

	}
}
