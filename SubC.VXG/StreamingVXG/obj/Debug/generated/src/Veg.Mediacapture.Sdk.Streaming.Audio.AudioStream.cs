using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Audio {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/audio/AudioStream", DoNotGenerateAcw=true)]
	public abstract partial class AudioStream : global::Veg.Mediacapture.Sdk.Streaming.MediaStream {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/field[@name='mAudioBitrate']"
		[Register ("mAudioBitrate")]
		protected int MAudioBitrate {
			get {
				const string __id = "mAudioBitrate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mAudioBitrate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/field[@name='mAudioEncoder']"
		[Register ("mAudioEncoder")]
		protected int MAudioEncoder {
			get {
				const string __id = "mAudioEncoder.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mAudioEncoder.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/field[@name='mAudioSource']"
		[Register ("mAudioSource")]
		protected int MAudioSource {
			get {
				const string __id = "mAudioSource.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mAudioSource.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/field[@name='mConfig']"
		[Register ("mConfig")]
		protected int MConfig {
			get {
				const string __id = "mConfig.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mConfig.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/field[@name='mOutputFormat']"
		[Register ("mOutputFormat")]
		protected int MOutputFormat {
			get {
				const string __id = "mOutputFormat.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mOutputFormat.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/field[@name='mSamplingRate']"
		[Register ("mSamplingRate")]
		protected int MSamplingRate {
			get {
				const string __id = "mSamplingRate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mSamplingRate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/audio/AudioStream", typeof (AudioStream));

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

		protected AudioStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/constructor[@name='AudioStream' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe AudioStream (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getAudioBitrate;
#pragma warning disable 0169
		static Delegate GetGetAudioBitrateHandler ()
		{
			if (cb_getAudioBitrate == null)
				cb_getAudioBitrate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioBitrate);
			return cb_getAudioBitrate;
		}

		static int n_GetAudioBitrate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioBitrate;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetAudioBitrate_IHandler ()
		{
			if (cb_setAudioBitrate_I == null)
				cb_setAudioBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioBitrate_I);
			return cb_setAudioBitrate_I;
		}

		static void n_SetAudioBitrate_I (IntPtr jnienv, IntPtr native__this, int audioBitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioBitrate = audioBitrate;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/method[@name='getAudioBitrate' and count(parameter)=0]"
			[Register ("getAudioBitrate", "()I", "GetGetAudioBitrateHandler")]
			get {
				const string __id = "getAudioBitrate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/method[@name='setAudioBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAudioBitrate", "(I)V", "GetSetAudioBitrate_IHandler")]
			set {
				const string __id = "setAudioBitrate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioSamplingRate;
#pragma warning disable 0169
		static Delegate GetGetAudioSamplingRateHandler ()
		{
			if (cb_getAudioSamplingRate == null)
				cb_getAudioSamplingRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioSamplingRate);
			return cb_getAudioSamplingRate;
		}

		static int n_GetAudioSamplingRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioSamplingRate;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioSamplingRate_I;
#pragma warning disable 0169
		static Delegate GetSetAudioSamplingRate_IHandler ()
		{
			if (cb_setAudioSamplingRate_I == null)
				cb_setAudioSamplingRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioSamplingRate_I);
			return cb_setAudioSamplingRate_I;
		}

		static void n_SetAudioSamplingRate_I (IntPtr jnienv, IntPtr native__this, int samplingRate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioSamplingRate = samplingRate;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioSamplingRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/method[@name='getAudioSamplingRate' and count(parameter)=0]"
			[Register ("getAudioSamplingRate", "()I", "GetGetAudioSamplingRateHandler")]
			get {
				const string __id = "getAudioSamplingRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/method[@name='setAudioSamplingRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAudioSamplingRate", "(I)V", "GetSetAudioSamplingRate_IHandler")]
			set {
				const string __id = "setAudioSamplingRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setAudioEncoder_I;
#pragma warning disable 0169
		static Delegate GetSetAudioEncoder_IHandler ()
		{
			if (cb_setAudioEncoder_I == null)
				cb_setAudioEncoder_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioEncoder_I);
			return cb_setAudioEncoder_I;
		}

		static void n_SetAudioEncoder_I (IntPtr jnienv, IntPtr native__this, int audioEncoder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioEncoder (audioEncoder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/method[@name='setAudioEncoder' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioEncoder", "(I)V", "GetSetAudioEncoder_IHandler")]
		public virtual unsafe void SetAudioEncoder (int audioEncoder)
		{
			const string __id = "setAudioEncoder.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (audioEncoder);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAudioSource_I;
#pragma warning disable 0169
		static Delegate GetSetAudioSource_IHandler ()
		{
			if (cb_setAudioSource_I == null)
				cb_setAudioSource_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioSource_I);
			return cb_setAudioSource_I;
		}

		static void n_SetAudioSource_I (IntPtr jnienv, IntPtr native__this, int audioSource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAudioSource (audioSource);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/method[@name='setAudioSource' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAudioSource", "(I)V", "GetSetAudioSource_IHandler")]
		public virtual unsafe void SetAudioSource (int audioSource)
		{
			const string __id = "setAudioSource.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (audioSource);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOutputFormat_I;
#pragma warning disable 0169
		static Delegate GetSetOutputFormat_IHandler ()
		{
			if (cb_setOutputFormat_I == null)
				cb_setOutputFormat_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetOutputFormat_I);
			return cb_setOutputFormat_I;
		}

		static void n_SetOutputFormat_I (IntPtr jnienv, IntPtr native__this, int outputFormat)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOutputFormat (outputFormat);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.audio']/class[@name='AudioStream']/method[@name='setOutputFormat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setOutputFormat", "(I)V", "GetSetOutputFormat_IHandler")]
		public virtual unsafe void SetOutputFormat (int outputFormat)
		{
			const string __id = "setOutputFormat.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (outputFormat);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/audio/AudioStream", DoNotGenerateAcw=true)]
	internal partial class AudioStreamInvoker : AudioStream {
		public AudioStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/audio/AudioStream", typeof (AudioStreamInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='generateSessionDescription' and count(parameter)=0]"
		[Register ("generateSessionDescription", "()Ljava/lang/String;", "GetGenerateSessionDescriptionHandler")]
		public override unsafe string GenerateSessionDescription ()
		{
			const string __id = "generateSessionDescription.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public override unsafe bool IsCheckedStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='isCheckedStream' and count(parameter)=0]"
			[Register ("isCheckedStream", "()Z", "GetIsCheckedStreamHandler")]
			get {
				const string __id = "isCheckedStream.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
