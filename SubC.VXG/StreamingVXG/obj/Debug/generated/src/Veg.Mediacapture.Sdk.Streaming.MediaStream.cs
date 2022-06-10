using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/MediaStream", DoNotGenerateAcw=true)]
	public abstract partial class MediaStream : global::Java.Lang.Object, global::Veg.Mediacapture.Sdk.Streaming.IStream {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='MODE_DEFAULT']"
		[Register ("MODE_DEFAULT")]
		public const int ModeDefault = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='MODE_STREAMING']"
		[Register ("MODE_STREAMING")]
		public const int ModeStreaming = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='TAG']"
		[Register ("TAG")]
		protected const string Tag = (string) "MediaStream";


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mConfig']"
		[Register ("mConfig")]
		protected global::Veg.Mediacapture.Sdk.MediaCaptureConfig MConfig {
			get {
				const string __id = "mConfig.Lveg/mediacapture/sdk/MediaCaptureConfig;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mConfig.Lveg/mediacapture/sdk/MediaCaptureConfig;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mContext']"
		[Register ("mContext")]
		protected global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mMediaRecorder']"
		[Register ("mMediaRecorder")]
		protected global::Android.Media.MediaRecorder MMediaRecorder {
			get {
				const string __id = "mMediaRecorder.Landroid/media/MediaRecorder;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Media.MediaRecorder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMediaRecorder.Landroid/media/MediaRecorder;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mModeDefaultWasUsed']"
		[Register ("mModeDefaultWasUsed")]
		protected bool MModeDefaultWasUsed {
			get {
				const string __id = "mModeDefaultWasUsed.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mModeDefaultWasUsed.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mPacketizer']"
		[Register ("mPacketizer")]
		protected global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer MPacketizer {
			get {
				const string __id = "mPacketizer.Lveg/mediacapture/sdk/streaming/rtp/AbstractPacketizer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPacketizer.Lveg/mediacapture/sdk/streaming/rtp/AbstractPacketizer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mStreaming']"
		[Register ("mStreaming")]
		protected bool MStreaming {
			get {
				const string __id = "mStreaming.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mStreaming.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='media_callback']"
		[Register ("media_callback")]
		protected global::Veg.Mediacapture.Sdk.IInternalDataCallback MediaCallback {
			get {
				const string __id = "media_callback.Lveg/mediacapture/sdk/InternalDataCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "media_callback.Lveg/mediacapture/sdk/InternalDataCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mode']"
		[Register ("mode")]
		protected int Mode {
			get {
				const string __id = "mode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mp4muxHRV']"
		[Register ("mp4muxHRV")]
		protected global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj Mp4muxHRV {
			get {
				const string __id = "mp4muxHRV.Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mp4muxHRV.Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/field[@name='mp4muxLRV']"
		[Register ("mp4muxLRV")]
		protected global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj Mp4muxLRV {
			get {
				const string __id = "mp4muxLRV.Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mp4muxLRV.Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/MediaStream", typeof (MediaStream));

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

		protected MediaStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/constructor[@name='MediaStream' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe MediaStream (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isStreaming;
#pragma warning disable 0169
		static Delegate GetIsStreamingHandler ()
		{
			if (cb_isStreaming == null)
				cb_isStreaming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStreaming);
			return cb_isStreaming;
		}

		static bool n_IsStreaming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStreaming;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='isStreaming' and count(parameter)=0]"
			[Register ("isStreaming", "()Z", "GetIsStreamingHandler")]
			get {
				const string __id = "isStreaming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPacketizer;
#pragma warning disable 0169
		static Delegate GetGetPacketizerHandler ()
		{
			if (cb_getPacketizer == null)
				cb_getPacketizer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPacketizer);
			return cb_getPacketizer;
		}

		static IntPtr n_GetPacketizer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Packetizer);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer Packetizer {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='getPacketizer' and count(parameter)=0]"
			[Register ("getPacketizer", "()Lveg/mediacapture/sdk/streaming/rtp/AbstractPacketizer;", "GetGetPacketizerHandler")]
			get {
				const string __id = "getPacketizer.()Lveg/mediacapture/sdk/streaming/rtp/AbstractPacketizer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSSRC;
#pragma warning disable 0169
		static Delegate GetGetSSRCHandler ()
		{
			if (cb_getSSRC == null)
				cb_getSSRC = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSSRC);
			return cb_getSSRC;
		}

		static int n_GetSSRC (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SSRC;
		}
#pragma warning restore 0169

		public virtual unsafe int SSRC {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='getSSRC' and count(parameter)=0]"
			[Register ("getSSRC", "()I", "GetGetSSRCHandler")]
			get {
				const string __id = "getSSRC.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_SetMP4MuxHRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_;
#pragma warning disable 0169
		static Delegate GetSetMP4MuxHRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_Handler ()
		{
			if (cb_SetMP4MuxHRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_ == null)
				cb_SetMP4MuxHRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMP4MuxHRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_);
			return cb_SetMP4MuxHRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_;
		}

		static void n_SetMP4MuxHRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mp4mux)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mp4mux = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (native_mp4mux, JniHandleOwnership.DoNotTransfer);
			__this.SetMP4MuxHRV (mp4mux);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='SetMP4MuxHRV' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.MP4Muxj']]"
		[Register ("SetMP4MuxHRV", "(Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;)V", "GetSetMP4MuxHRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_Handler")]
		public virtual unsafe void SetMP4MuxHRV (global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj mp4mux)
		{
			const string __id = "SetMP4MuxHRV.(Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mp4mux == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mp4mux).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mp4mux);
			}
		}

		static Delegate cb_SetMP4MuxLRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_;
#pragma warning disable 0169
		static Delegate GetSetMP4MuxLRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_Handler ()
		{
			if (cb_SetMP4MuxLRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_ == null)
				cb_SetMP4MuxLRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMP4MuxLRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_);
			return cb_SetMP4MuxLRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_;
		}

		static void n_SetMP4MuxLRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mp4mux)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mp4mux = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (native_mp4mux, JniHandleOwnership.DoNotTransfer);
			__this.SetMP4MuxLRV (mp4mux);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='SetMP4MuxLRV' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.MP4Muxj']]"
		[Register ("SetMP4MuxLRV", "(Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;)V", "GetSetMP4MuxLRV_Lveg_mediacapture_sdk_streaming_mp4_MP4Muxj_Handler")]
		public virtual unsafe void SetMP4MuxLRV (global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj mp4mux)
		{
			const string __id = "SetMP4MuxLRV.(Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mp4mux == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mp4mux).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mp4mux);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateSessionDescription ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='generateSessionDescription' and count(parameter)=0]"
		[Register ("generateSessionDescription", "()Ljava/lang/String;", "GetGenerateSessionDescriptionHandler")]
		public abstract string GenerateSessionDescription ();

		static Delegate cb_getDestinationPorts;
#pragma warning disable 0169
		static Delegate GetGetDestinationPortsHandler ()
		{
			if (cb_getDestinationPorts == null)
				cb_getDestinationPorts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDestinationPorts);
			return cb_getDestinationPorts;
		}

		static IntPtr n_GetDestinationPorts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDestinationPorts ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='getDestinationPorts' and count(parameter)=0]"
		[Register ("getDestinationPorts", "()[I", "GetGetDestinationPortsHandler")]
		public virtual unsafe int[] GetDestinationPorts ()
		{
			const string __id = "getDestinationPorts.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getLocalPorts;
#pragma warning disable 0169
		static Delegate GetGetLocalPortsHandler ()
		{
			if (cb_getLocalPorts == null)
				cb_getLocalPorts = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLocalPorts);
			return cb_getLocalPorts;
		}

		static IntPtr n_GetLocalPorts (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocalPorts ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='getLocalPorts' and count(parameter)=0]"
		[Register ("getLocalPorts", "()[I", "GetGetLocalPortsHandler")]
		public virtual unsafe int[] GetLocalPorts ()
		{
			const string __id = "getLocalPorts.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_is_data_ready;
#pragma warning disable 0169
		static Delegate GetIs_data_readyHandler ()
		{
			if (cb_is_data_ready == null)
				cb_is_data_ready = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Is_data_ready);
			return cb_is_data_ready;
		}

		static bool n_Is_data_ready (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_data_ready ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='is_data_ready' and count(parameter)=0]"
		[Register ("is_data_ready", "()Z", "GetIs_data_readyHandler")]
		public virtual unsafe bool Is_data_ready ()
		{
			const string __id = "is_data_ready.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pause;
#pragma warning disable 0169
		static Delegate GetPauseHandler ()
		{
			if (cb_pause == null)
				cb_pause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Pause);
			return cb_pause;
		}

		static void n_Pause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public virtual unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_prepare_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrepare_Ljava_lang_String_Handler ()
		{
			if (cb_prepare_Ljava_lang_String_ == null)
				cb_prepare_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Prepare_Ljava_lang_String_);
			return cb_prepare_Ljava_lang_String_;
		}

		static void n_Prepare_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sFile)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sFile = JNIEnv.GetString (native_sFile, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (sFile);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("prepare", "(Ljava/lang/String;)V", "GetPrepare_Ljava_lang_String_Handler")]
		public virtual unsafe void Prepare (string sFile)
		{
			const string __id = "prepare.(Ljava/lang/String;)V";
			IntPtr native_sFile = JNIEnv.NewString (sFile);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sFile);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sFile);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			const string __id = "release.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_;
#pragma warning disable 0169
		static Delegate GetSetConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_Handler ()
		{
			if (cb_setConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_ == null)
				cb_setConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_);
			return cb_setConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_;
		}

		static void n_SetConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.SetConfig (config);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig']]"
		[Register ("setConfig", "(Lveg/mediacapture/sdk/MediaCaptureConfig;)V", "GetSetConfig_Lveg_mediacapture_sdk_MediaCaptureConfig_Handler")]
		public virtual unsafe void SetConfig (global::Veg.Mediacapture.Sdk.MediaCaptureConfig config)
		{
			const string __id = "setConfig.(Lveg/mediacapture/sdk/MediaCaptureConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

		static Delegate cb_setDestinationAddress_Ljava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetSetDestinationAddress_Ljava_net_InetAddress_Handler ()
		{
			if (cb_setDestinationAddress_Ljava_net_InetAddress_ == null)
				cb_setDestinationAddress_Ljava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDestinationAddress_Ljava_net_InetAddress_);
			return cb_setDestinationAddress_Ljava_net_InetAddress_;
		}

		static void n_SetDestinationAddress_Ljava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dest)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_dest, JniHandleOwnership.DoNotTransfer);
			__this.SetDestinationAddress (dest);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='setDestinationAddress' and count(parameter)=1 and parameter[1][@type='java.net.InetAddress']]"
		[Register ("setDestinationAddress", "(Ljava/net/InetAddress;)V", "GetSetDestinationAddress_Ljava_net_InetAddress_Handler")]
		public virtual unsafe void SetDestinationAddress (global::Java.Net.InetAddress dest)
		{
			const string __id = "setDestinationAddress.(Ljava/net/InetAddress;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dest);
			}
		}

		static Delegate cb_setDestinationPorts_I;
#pragma warning disable 0169
		static Delegate GetSetDestinationPorts_IHandler ()
		{
			if (cb_setDestinationPorts_I == null)
				cb_setDestinationPorts_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDestinationPorts_I);
			return cb_setDestinationPorts_I;
		}

		static void n_SetDestinationPorts_I (IntPtr jnienv, IntPtr native__this, int dport)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDestinationPorts (dport);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='setDestinationPorts' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDestinationPorts", "(I)V", "GetSetDestinationPorts_IHandler")]
		public virtual unsafe void SetDestinationPorts (int dport)
		{
			const string __id = "setDestinationPorts.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dport);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDestinationPorts_II;
#pragma warning disable 0169
		static Delegate GetSetDestinationPorts_IIHandler ()
		{
			if (cb_setDestinationPorts_II == null)
				cb_setDestinationPorts_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetDestinationPorts_II);
			return cb_setDestinationPorts_II;
		}

		static void n_SetDestinationPorts_II (IntPtr jnienv, IntPtr native__this, int rtpPort, int rtcpPort)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDestinationPorts (rtpPort, rtcpPort);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='setDestinationPorts' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDestinationPorts", "(II)V", "GetSetDestinationPorts_IIHandler")]
		public virtual unsafe void SetDestinationPorts (int rtpPort, int rtcpPort)
		{
			const string __id = "setDestinationPorts.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (rtpPort);
				__args [1] = new JniArgumentValue (rtcpPort);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_;
#pragma warning disable 0169
		static Delegate GetSetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_Handler ()
		{
			if (cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ == null)
				cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_);
			return cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_;
		}

		static void n_SetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cb = (global::Veg.Mediacapture.Sdk.IInternalDataCallback)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (native_cb, JniHandleOwnership.DoNotTransfer);
			__this.SetInternalDataCallback (cb);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='setInternalDataCallback' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.InternalDataCallback']]"
		[Register ("setInternalDataCallback", "(Lveg/mediacapture/sdk/InternalDataCallback;)V", "GetSetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_Handler")]
		public virtual unsafe void SetInternalDataCallback (global::Veg.Mediacapture.Sdk.IInternalDataCallback cb)
		{
			const string __id = "setInternalDataCallback.(Lveg/mediacapture/sdk/InternalDataCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cb).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cb);
			}
		}

		static Delegate cb_setMode_I;
#pragma warning disable 0169
		static Delegate GetSetMode_IHandler ()
		{
			if (cb_setMode_I == null)
				cb_setMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMode_I);
			return cb_setMode_I;
		}

		static void n_SetMode_I (IntPtr jnienv, IntPtr native__this, int mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMode (mode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMode", "(I)V", "GetSetMode_IHandler")]
		public virtual unsafe void SetMode (int mode)
		{
			const string __id = "setMode.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mode);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTimeToLive_I;
#pragma warning disable 0169
		static Delegate GetSetTimeToLive_IHandler ()
		{
			if (cb_setTimeToLive_I == null)
				cb_setTimeToLive_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeToLive_I);
			return cb_setTimeToLive_I;
		}

		static void n_SetTimeToLive_I (IntPtr jnienv, IntPtr native__this, int ttl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeToLive (ttl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='setTimeToLive' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeToLive", "(I)V", "GetSetTimeToLive_IHandler")]
		public virtual unsafe void SetTimeToLive (int ttl)
		{
			const string __id = "setTimeToLive.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ttl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start_J;
#pragma warning disable 0169
		static Delegate GetStart_JHandler ()
		{
			if (cb_start_J == null)
				cb_start_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Start_J);
			return cb_start_J;
		}

		static void n_Start_J (IntPtr jnienv, IntPtr native__this, long start_time)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (start_time);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='start' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("start", "(J)V", "GetStart_JHandler")]
		public virtual unsafe void Start (long start_time)
		{
			const string __id = "start.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (start_time);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_stop == null)
				cb_stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.MediaStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCheckedStream;
		}
#pragma warning restore 0169

		public abstract bool IsCheckedStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='MediaStream']/method[@name='isCheckedStream' and count(parameter)=0]"
			[Register ("isCheckedStream", "()Z", "GetIsCheckedStreamHandler")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/MediaStream", DoNotGenerateAcw=true)]
	internal partial class MediaStreamInvoker : MediaStream {
		public MediaStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/MediaStream", typeof (MediaStreamInvoker));

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
