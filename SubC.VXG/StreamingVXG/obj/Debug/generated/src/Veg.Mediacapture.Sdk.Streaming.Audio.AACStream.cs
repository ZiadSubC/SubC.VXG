using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AACStream']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/audio/AACStream", DoNotGenerateAcw=true)]
	public partial class AACStream : global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AACStream']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AACStream']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "AACStream";


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AACStream']/field[@name='sADTSSamplingRates']"
		[Register ("sADTSSamplingRates")]
		public static IList<int> SADTSSamplingRates {
			get {
				const string __id = "sADTSSamplingRates.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AACStream']/field[@name='sAudioObjectTypes']"
		[Register ("sAudioObjectTypes")]
		public static IList<string> SAudioObjectTypes {
			get {
				const string __id = "sAudioObjectTypes.[Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/audio/AACStream", typeof (AACStream));

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

		protected AACStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AACStream']/constructor[@name='AACStream' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AACStream (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AACStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCheckedStream;
		}
#pragma warning restore 0169

		public override unsafe bool IsCheckedStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AACStream']/method[@name='isCheckedStream' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AACStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateSessionDescription ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AACStream']/method[@name='generateSessionDescription' and count(parameter)=0]"
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

	}
}
