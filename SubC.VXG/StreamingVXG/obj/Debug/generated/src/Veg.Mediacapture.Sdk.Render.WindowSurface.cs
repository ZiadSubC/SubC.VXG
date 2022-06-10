using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Render {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='WindowSurface']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/render/WindowSurface", DoNotGenerateAcw=true)]
	public partial class WindowSurface : global::Veg.Mediacapture.Sdk.Render.EglSurfaceBase {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/render/WindowSurface", typeof (WindowSurface));

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

		protected WindowSurface (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='WindowSurface']/constructor[@name='WindowSurface' and count(parameter)=2 and parameter[1][@type='veg.mediacapture.sdk.render.EglCore'] and parameter[2][@type='android.graphics.SurfaceTexture']]"
		[Register (".ctor", "(Lveg/mediacapture/sdk/render/EglCore;Landroid/graphics/SurfaceTexture;)V", "")]
		public unsafe WindowSurface (global::Veg.Mediacapture.Sdk.Render.EglCore eglCore, global::Android.Graphics.SurfaceTexture surfaceTexture) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lveg/mediacapture/sdk/render/EglCore;Landroid/graphics/SurfaceTexture;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((eglCore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eglCore).Handle);
				__args [1] = new JniArgumentValue ((surfaceTexture == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surfaceTexture).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eglCore);
				global::System.GC.KeepAlive (surfaceTexture);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='WindowSurface']/constructor[@name='WindowSurface' and count(parameter)=3 and parameter[1][@type='veg.mediacapture.sdk.render.EglCore'] and parameter[2][@type='android.view.Surface'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Lveg/mediacapture/sdk/render/EglCore;Landroid/view/Surface;Z)V", "")]
		public unsafe WindowSurface (global::Veg.Mediacapture.Sdk.Render.EglCore eglCore, global::Android.Views.Surface surface, bool releaseSurface) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lveg/mediacapture/sdk/render/EglCore;Landroid/view/Surface;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((eglCore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eglCore).Handle);
				__args [1] = new JniArgumentValue ((surface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surface).Handle);
				__args [2] = new JniArgumentValue (releaseSurface);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eglCore);
				global::System.GC.KeepAlive (surface);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='WindowSurface']/constructor[@name='WindowSurface' and count(parameter)=3 and parameter[1][@type='veg.mediacapture.sdk.render.EglCore'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lveg/mediacapture/sdk/render/EglCore;II)V", "")]
		public unsafe WindowSurface (global::Veg.Mediacapture.Sdk.Render.EglCore eglCore, int width, int height) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lveg/mediacapture/sdk/render/EglCore;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((eglCore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) eglCore).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (eglCore);
			}
		}

		static Delegate cb_recreate_Lveg_mediacapture_sdk_render_EglCore_;
#pragma warning disable 0169
		static Delegate GetRecreate_Lveg_mediacapture_sdk_render_EglCore_Handler ()
		{
			if (cb_recreate_Lveg_mediacapture_sdk_render_EglCore_ == null)
				cb_recreate_Lveg_mediacapture_sdk_render_EglCore_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Recreate_Lveg_mediacapture_sdk_render_EglCore_);
			return cb_recreate_Lveg_mediacapture_sdk_render_EglCore_;
		}

		static void n_Recreate_Lveg_mediacapture_sdk_render_EglCore_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newEglCore)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.WindowSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var newEglCore = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.EglCore> (native_newEglCore, JniHandleOwnership.DoNotTransfer);
			__this.Recreate (newEglCore);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='WindowSurface']/method[@name='recreate' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.render.EglCore']]"
		[Register ("recreate", "(Lveg/mediacapture/sdk/render/EglCore;)V", "GetRecreate_Lveg_mediacapture_sdk_render_EglCore_Handler")]
		public virtual unsafe void Recreate (global::Veg.Mediacapture.Sdk.Render.EglCore newEglCore)
		{
			const string __id = "recreate.(Lveg/mediacapture/sdk/render/EglCore;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((newEglCore == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newEglCore).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (newEglCore);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.WindowSurface> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='WindowSurface']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
