using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Config']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/mp4/MP4Config", DoNotGenerateAcw=true)]
	public partial class MP4Config : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/mp4/MP4Config", typeof (MP4Config));

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

		protected MP4Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Config']/constructor[@name='MP4Config' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe MP4Config (string path) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Config']/constructor[@name='MP4Config' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe MP4Config (string profil, string sps, string pps) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_profil = JNIEnv.NewString (profil);
			IntPtr native_sps = JNIEnv.NewString (sps);
			IntPtr native_pps = JNIEnv.NewString (pps);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_profil);
				__args [1] = new JniArgumentValue (native_sps);
				__args [2] = new JniArgumentValue (native_pps);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_profil);
				JNIEnv.DeleteLocalRef (native_sps);
				JNIEnv.DeleteLocalRef (native_pps);
			}
		}

		static Delegate cb_getB64PPS;
#pragma warning disable 0169
		static Delegate GetGetB64PPSHandler ()
		{
			if (cb_getB64PPS == null)
				cb_getB64PPS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetB64PPS);
			return cb_getB64PPS;
		}

		static IntPtr n_GetB64PPS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.B64PPS);
		}
#pragma warning restore 0169

		public virtual unsafe string B64PPS {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Config']/method[@name='getB64PPS' and count(parameter)=0]"
			[Register ("getB64PPS", "()Ljava/lang/String;", "GetGetB64PPSHandler")]
			get {
				const string __id = "getB64PPS.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getB64SPS;
#pragma warning disable 0169
		static Delegate GetGetB64SPSHandler ()
		{
			if (cb_getB64SPS == null)
				cb_getB64SPS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetB64SPS);
			return cb_getB64SPS;
		}

		static IntPtr n_GetB64SPS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.B64SPS);
		}
#pragma warning restore 0169

		public virtual unsafe string B64SPS {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Config']/method[@name='getB64SPS' and count(parameter)=0]"
			[Register ("getB64SPS", "()Ljava/lang/String;", "GetGetB64SPSHandler")]
			get {
				const string __id = "getB64SPS.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getProfileLevel;
#pragma warning disable 0169
		static Delegate GetGetProfileLevelHandler ()
		{
			if (cb_getProfileLevel == null)
				cb_getProfileLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProfileLevel);
			return cb_getProfileLevel;
		}

		static IntPtr n_GetProfileLevel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Config> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ProfileLevel);
		}
#pragma warning restore 0169

		public virtual unsafe string ProfileLevel {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='MP4Config']/method[@name='getProfileLevel' and count(parameter)=0]"
			[Register ("getProfileLevel", "()Ljava/lang/String;", "GetGetProfileLevelHandler")]
			get {
				const string __id = "getProfileLevel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
