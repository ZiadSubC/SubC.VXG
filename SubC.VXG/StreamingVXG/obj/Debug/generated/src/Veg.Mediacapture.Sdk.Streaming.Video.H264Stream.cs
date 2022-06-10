using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='H264Stream']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/video/H264Stream", DoNotGenerateAcw=true)]
	public partial class H264Stream : global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='H264Stream']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/video/H264Stream", typeof (H264Stream));

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

		protected H264Stream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='H264Stream']/constructor[@name='H264Stream' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe H264Stream (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='H264Stream']/constructor[@name='H264Stream' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Context']]"
		[Register (".ctor", "(ILandroid/content/Context;)V", "")]
		public unsafe H264Stream (int cameraId, global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILandroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (cameraId);
				__args [1] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_isCheckedStream;
#pragma warning disable 0169
		static Delegate GetIsCheckedStreamHandler ()
		{
			if (cb_isCheckedStream == null)
				cb_isCheckedStream = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCheckedStream);
			return cb_isCheckedStream;
		}

		static bool n_IsCheckedStream (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.H264Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCheckedStream;
		}
#pragma warning restore 0169

		public override unsafe bool IsCheckedStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='H264Stream']/method[@name='isCheckedStream' and count(parameter)=0]"
			[Register ("isCheckedStream", "()Z", "GetIsCheckedStreamHandler")]
			get {
				const string __id = "isCheckedStream.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.H264Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateSessionDescription ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='H264Stream']/method[@name='generateSessionDescription' and count(parameter)=0]"
		[Register ("generateSessionDescription", "()Ljava/lang/String;", "GetGenerateSessionDescriptionHandler")]
		public override unsafe string GenerateSessionDescription ()
		{
			const string __id = "generateSessionDescription.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPreferences_Landroid_content_SharedPreferences_;
#pragma warning disable 0169
		static Delegate GetSetPreferences_Landroid_content_SharedPreferences_Handler ()
		{
			if (cb_setPreferences_Landroid_content_SharedPreferences_ == null)
				cb_setPreferences_Landroid_content_SharedPreferences_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPreferences_Landroid_content_SharedPreferences_);
			return cb_setPreferences_Landroid_content_SharedPreferences_;
		}

		static void n_SetPreferences_Landroid_content_SharedPreferences_ (IntPtr jnienv, IntPtr native__this, IntPtr native_prefs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.H264Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var prefs = (global::Android.Content.ISharedPreferences)global::Java.Lang.Object.GetObject<global::Android.Content.ISharedPreferences> (native_prefs, JniHandleOwnership.DoNotTransfer);
			__this.SetPreferences (prefs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='H264Stream']/method[@name='setPreferences' and count(parameter)=1 and parameter[1][@type='android.content.SharedPreferences']]"
		[Register ("setPreferences", "(Landroid/content/SharedPreferences;)V", "GetSetPreferences_Landroid_content_SharedPreferences_Handler")]
		public virtual unsafe void SetPreferences (global::Android.Content.ISharedPreferences prefs)
		{
			const string __id = "setPreferences.(Landroid/content/SharedPreferences;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((prefs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) prefs).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (prefs);
			}
		}

	}
}
