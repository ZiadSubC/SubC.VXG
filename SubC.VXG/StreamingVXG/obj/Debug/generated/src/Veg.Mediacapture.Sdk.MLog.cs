using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/MLog", DoNotGenerateAcw=true)]
	public partial class MLog : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/field[@name='app']"
		[Register ("app")]
		public static global::Android.Content.Context App {
			get {
				const string __id = "app.Landroid/content/Context;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "app.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/field[@name='isSignedWithDebugKey']"
		[Register ("isSignedWithDebugKey")]
		public static global::Java.Lang.Boolean IsSignedWithDebugKey {
			get {
				const string __id = "isSignedWithDebugKey.Ljava/lang/Boolean;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "isSignedWithDebugKey.Ljava/lang/Boolean;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MLog", typeof (MLog));

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

		protected MLog (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/constructor[@name='MLog' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;I)V", "")]
		public unsafe MLog (string tag, int level) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_tag);
				__args [1] = new JniArgumentValue (level);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static Delegate cb_d_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetD_Ljava_lang_String_Handler ()
		{
			if (cb_d_Ljava_lang_String_ == null)
				cb_d_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_D_Ljava_lang_String_);
			return cb_d_Ljava_lang_String_;
		}

		static void n_D_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.D (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/method[@name='d' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("d", "(Ljava/lang/String;)V", "GetD_Ljava_lang_String_Handler")]
		public virtual unsafe void D (string msg)
		{
			const string __id = "d.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_e_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_E_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.E (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "GetE_Ljava_lang_String_Handler")]
		public virtual unsafe void E (string msg)
		{
			const string __id = "e.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_i_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Handler ()
		{
			if (cb_i_Ljava_lang_String_ == null)
				cb_i_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_I_Ljava_lang_String_);
			return cb_i_Ljava_lang_String_;
		}

		static void n_I_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.I (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "GetI_Ljava_lang_String_Handler")]
		public virtual unsafe void I (string msg)
		{
			const string __id = "i.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_signedWithDebug;
#pragma warning disable 0169
		static Delegate GetSignedWithDebugHandler ()
		{
			if (cb_signedWithDebug == null)
				cb_signedWithDebug = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_SignedWithDebug);
			return cb_signedWithDebug;
		}

		static bool n_SignedWithDebug (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SignedWithDebug ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/method[@name='signedWithDebug' and count(parameter)=0]"
		[Register ("signedWithDebug", "()Z", "GetSignedWithDebugHandler")]
		protected virtual unsafe bool SignedWithDebug ()
		{
			const string __id = "signedWithDebug.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_v_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Handler ()
		{
			if (cb_v_Ljava_lang_String_ == null)
				cb_v_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_V_Ljava_lang_String_);
			return cb_v_Ljava_lang_String_;
		}

		static void n_V_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.V (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "GetV_Ljava_lang_String_Handler")]
		public virtual unsafe void V (string msg)
		{
			const string __id = "v.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

		static Delegate cb_w_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Handler ()
		{
			if (cb_w_Ljava_lang_String_ == null)
				cb_w_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_W_Ljava_lang_String_);
			return cb_w_Ljava_lang_String_;
		}

		static void n_W_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_msg)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MLog> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var msg = JNIEnv.GetString (native_msg, JniHandleOwnership.DoNotTransfer);
			__this.W (msg);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MLog']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "GetW_Ljava_lang_String_Handler")]
		public virtual unsafe void W (string msg)
		{
			const string __id = "w.(Ljava/lang/String;)V";
			IntPtr native_msg = JNIEnv.NewString (msg);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_msg);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_msg);
			}
		}

	}
}
