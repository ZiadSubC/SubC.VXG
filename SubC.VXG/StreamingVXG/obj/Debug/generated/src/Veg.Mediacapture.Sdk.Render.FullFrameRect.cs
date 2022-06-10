using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Render {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/render/FullFrameRect", DoNotGenerateAcw=true)]
	public partial class FullFrameRect : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/render/FullFrameRect", typeof (FullFrameRect));

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

		protected FullFrameRect (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']/constructor[@name='FullFrameRect' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.render.Texture2dProgram']]"
		[Register (".ctor", "(Lveg/mediacapture/sdk/render/Texture2dProgram;)V", "")]
		public unsafe FullFrameRect (global::Veg.Mediacapture.Sdk.Render.Texture2dProgram program) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lveg/mediacapture/sdk/render/Texture2dProgram;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((program == null) ? IntPtr.Zero : ((global::Java.Lang.Object) program).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (program);
			}
		}

		static Delegate cb_getProgram;
#pragma warning disable 0169
		static Delegate GetGetProgramHandler ()
		{
			if (cb_getProgram == null)
				cb_getProgram = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProgram);
			return cb_getProgram;
		}

		static IntPtr n_GetProgram (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.FullFrameRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Program);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.Render.Texture2dProgram Program {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']/method[@name='getProgram' and count(parameter)=0]"
			[Register ("getProgram", "()Lveg/mediacapture/sdk/render/Texture2dProgram;", "GetGetProgramHandler")]
			get {
				const string __id = "getProgram.()Lveg/mediacapture/sdk/render/Texture2dProgram;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.Texture2dProgram> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_changeProgram_Lveg_mediacapture_sdk_render_Texture2dProgram_;
#pragma warning disable 0169
		static Delegate GetChangeProgram_Lveg_mediacapture_sdk_render_Texture2dProgram_Handler ()
		{
			if (cb_changeProgram_Lveg_mediacapture_sdk_render_Texture2dProgram_ == null)
				cb_changeProgram_Lveg_mediacapture_sdk_render_Texture2dProgram_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ChangeProgram_Lveg_mediacapture_sdk_render_Texture2dProgram_);
			return cb_changeProgram_Lveg_mediacapture_sdk_render_Texture2dProgram_;
		}

		static void n_ChangeProgram_Lveg_mediacapture_sdk_render_Texture2dProgram_ (IntPtr jnienv, IntPtr native__this, IntPtr native_program)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.FullFrameRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var program = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.Texture2dProgram> (native_program, JniHandleOwnership.DoNotTransfer);
			__this.ChangeProgram (program);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']/method[@name='changeProgram' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.render.Texture2dProgram']]"
		[Register ("changeProgram", "(Lveg/mediacapture/sdk/render/Texture2dProgram;)V", "GetChangeProgram_Lveg_mediacapture_sdk_render_Texture2dProgram_Handler")]
		public virtual unsafe void ChangeProgram (global::Veg.Mediacapture.Sdk.Render.Texture2dProgram program)
		{
			const string __id = "changeProgram.(Lveg/mediacapture/sdk/render/Texture2dProgram;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((program == null) ? IntPtr.Zero : ((global::Java.Lang.Object) program).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (program);
			}
		}

		static Delegate cb_createTextureObject;
#pragma warning disable 0169
		static Delegate GetCreateTextureObjectHandler ()
		{
			if (cb_createTextureObject == null)
				cb_createTextureObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_CreateTextureObject);
			return cb_createTextureObject;
		}

		static int n_CreateTextureObject (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.FullFrameRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CreateTextureObject ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']/method[@name='createTextureObject' and count(parameter)=0]"
		[Register ("createTextureObject", "()I", "GetCreateTextureObjectHandler")]
		public virtual unsafe int CreateTextureObject ()
		{
			const string __id = "createTextureObject.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_drawFrame_IarrayF;
#pragma warning disable 0169
		static Delegate GetDrawFrame_IarrayFHandler ()
		{
			if (cb_drawFrame_IarrayF == null)
				cb_drawFrame_IarrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_DrawFrame_IarrayF);
			return cb_drawFrame_IarrayF;
		}

		static void n_DrawFrame_IarrayF (IntPtr jnienv, IntPtr native__this, int textureId, IntPtr native_texMatrix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.FullFrameRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var texMatrix = (float[]) JNIEnv.GetArray (native_texMatrix, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawFrame (textureId, texMatrix);
			if (texMatrix != null)
				JNIEnv.CopyArray (texMatrix, native_texMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']/method[@name='drawFrame' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='float[]']]"
		[Register ("drawFrame", "(I[F)V", "GetDrawFrame_IarrayFHandler")]
		public virtual unsafe void DrawFrame (int textureId, float[] texMatrix)
		{
			const string __id = "drawFrame.(I[F)V";
			IntPtr native_texMatrix = JNIEnv.NewArray (texMatrix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (textureId);
				__args [1] = new JniArgumentValue (native_texMatrix);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (texMatrix != null) {
					JNIEnv.CopyArray (native_texMatrix, texMatrix);
					JNIEnv.DeleteLocalRef (native_texMatrix);
				}
				global::System.GC.KeepAlive (texMatrix);
			}
		}

		static Delegate cb_drawFrame_IarrayFarrayF;
#pragma warning disable 0169
		static Delegate GetDrawFrame_IarrayFarrayFHandler ()
		{
			if (cb_drawFrame_IarrayFarrayF == null)
				cb_drawFrame_IarrayFarrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_V) n_DrawFrame_IarrayFarrayF);
			return cb_drawFrame_IarrayFarrayF;
		}

		static void n_DrawFrame_IarrayFarrayF (IntPtr jnienv, IntPtr native__this, int textureId, IntPtr native_texMatrix, IntPtr native_mvpMatrix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.FullFrameRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var texMatrix = (float[]) JNIEnv.GetArray (native_texMatrix, JniHandleOwnership.DoNotTransfer, typeof (float));
			var mvpMatrix = (float[]) JNIEnv.GetArray (native_mvpMatrix, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawFrame (textureId, texMatrix, mvpMatrix);
			if (texMatrix != null)
				JNIEnv.CopyArray (texMatrix, native_texMatrix);
			if (mvpMatrix != null)
				JNIEnv.CopyArray (mvpMatrix, native_mvpMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']/method[@name='drawFrame' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float[]'] and parameter[3][@type='float[]']]"
		[Register ("drawFrame", "(I[F[F)V", "GetDrawFrame_IarrayFarrayFHandler")]
		public virtual unsafe void DrawFrame (int textureId, float[] texMatrix, float[] mvpMatrix)
		{
			const string __id = "drawFrame.(I[F[F)V";
			IntPtr native_texMatrix = JNIEnv.NewArray (texMatrix);
			IntPtr native_mvpMatrix = JNIEnv.NewArray (mvpMatrix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (textureId);
				__args [1] = new JniArgumentValue (native_texMatrix);
				__args [2] = new JniArgumentValue (native_mvpMatrix);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (texMatrix != null) {
					JNIEnv.CopyArray (native_texMatrix, texMatrix);
					JNIEnv.DeleteLocalRef (native_texMatrix);
				}
				if (mvpMatrix != null) {
					JNIEnv.CopyArray (native_mvpMatrix, mvpMatrix);
					JNIEnv.DeleteLocalRef (native_mvpMatrix);
				}
				global::System.GC.KeepAlive (texMatrix);
				global::System.GC.KeepAlive (mvpMatrix);
			}
		}

		static Delegate cb_loadBitmap_ILandroid_graphics_Bitmap_I;
#pragma warning disable 0169
		static Delegate GetLoadBitmap_ILandroid_graphics_Bitmap_IHandler ()
		{
			if (cb_loadBitmap_ILandroid_graphics_Bitmap_I == null)
				cb_loadBitmap_ILandroid_graphics_Bitmap_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILI_V) n_LoadBitmap_ILandroid_graphics_Bitmap_I);
			return cb_loadBitmap_ILandroid_graphics_Bitmap_I;
		}

		static void n_LoadBitmap_ILandroid_graphics_Bitmap_I (IntPtr jnienv, IntPtr native__this, int textureId, IntPtr native_bitmap, int level)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.FullFrameRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			__this.LoadBitmap (textureId, bitmap, level);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']/method[@name='loadBitmap' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='int']]"
		[Register ("loadBitmap", "(ILandroid/graphics/Bitmap;I)V", "GetLoadBitmap_ILandroid_graphics_Bitmap_IHandler")]
		public virtual unsafe void LoadBitmap (int textureId, global::Android.Graphics.Bitmap bitmap, int level)
		{
			const string __id = "loadBitmap.(ILandroid/graphics/Bitmap;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (textureId);
				__args [1] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [2] = new JniArgumentValue (level);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bitmap);
			}
		}

		static Delegate cb_release_Z;
#pragma warning disable 0169
		static Delegate GetRelease_ZHandler ()
		{
			if (cb_release_Z == null)
				cb_release_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_Release_Z);
			return cb_release_Z;
		}

		static void n_Release_Z (IntPtr jnienv, IntPtr native__this, bool doEglCleanup)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Render.FullFrameRect> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release (doEglCleanup);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.render']/class[@name='FullFrameRect']/method[@name='release' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("release", "(Z)V", "GetRelease_ZHandler")]
		public virtual unsafe void Release (bool doEglCleanup)
		{
			const string __id = "release.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (doEglCleanup);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
