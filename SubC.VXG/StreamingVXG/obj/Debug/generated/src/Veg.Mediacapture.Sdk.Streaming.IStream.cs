using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming {

	// Metadata.xml XPath interface reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']"
	[Register ("veg/mediacapture/sdk/streaming/Stream", "", "Veg.Mediacapture.Sdk.Streaming.IStreamInvoker")]
	public partial interface IStream : IJavaObject, IJavaPeerable {
		bool IsCheckedStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='isCheckedStream' and count(parameter)=0]"
			[Register ("isCheckedStream", "()Z", "GetIsCheckedStreamHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
			get; 
		}

		bool IsStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='isStreaming' and count(parameter)=0]"
			[Register ("isStreaming", "()Z", "GetIsStreamingHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
			get; 
		}

		int SSRC {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='getSSRC' and count(parameter)=0]"
			[Register ("getSSRC", "()I", "GetGetSSRCHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
			get; 
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='generateSessionDescription' and count(parameter)=0]"
		[Register ("generateSessionDescription", "()Ljava/lang/String;", "GetGenerateSessionDescriptionHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		string GenerateSessionDescription ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='getDestinationPorts' and count(parameter)=0]"
		[Register ("getDestinationPorts", "()[I", "GetGetDestinationPortsHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		int[] GetDestinationPorts ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='getLocalPorts' and count(parameter)=0]"
		[Register ("getLocalPorts", "()[I", "GetGetLocalPortsHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		int[] GetLocalPorts ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='is_data_ready' and count(parameter)=0]"
		[Register ("is_data_ready", "()Z", "GetIs_data_readyHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		bool Is_data_ready ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("prepare", "(Ljava/lang/String;)V", "GetPrepare_Ljava_lang_String_Handler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void Prepare (string p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void Release ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='setDestinationAddress' and count(parameter)=1 and parameter[1][@type='java.net.InetAddress']]"
		[Register ("setDestinationAddress", "(Ljava/net/InetAddress;)V", "GetSetDestinationAddress_Ljava_net_InetAddress_Handler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void SetDestinationAddress (global::Java.Net.InetAddress p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='setDestinationPorts' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDestinationPorts", "(I)V", "GetSetDestinationPorts_IHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void SetDestinationPorts (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='setDestinationPorts' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setDestinationPorts", "(II)V", "GetSetDestinationPorts_IIHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void SetDestinationPorts (int p0, int p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='setTimeToLive' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeToLive", "(I)V", "GetSetTimeToLive_IHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void SetTimeToLive (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='start' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("start", "(J)V", "GetStart_JHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void Start (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/interface[@name='Stream']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler:Veg.Mediacapture.Sdk.Streaming.IStreamInvoker, StreamingVXG")]
		void Stop ();

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/Stream", DoNotGenerateAcw=true)]
	internal partial class IStreamInvoker : global::Java.Lang.Object, IStream {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/Stream", typeof (IStreamInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IStream GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IStream> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'veg.mediacapture.sdk.streaming.Stream'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IStreamInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCheckedStream;
		}
#pragma warning restore 0169

		IntPtr id_isCheckedStream;
		public unsafe bool IsCheckedStream {
			get {
				if (id_isCheckedStream == IntPtr.Zero)
					id_isCheckedStream = JNIEnv.GetMethodID (class_ref, "isCheckedStream", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isCheckedStream);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStreaming;
		}
#pragma warning restore 0169

		IntPtr id_isStreaming;
		public unsafe bool IsStreaming {
			get {
				if (id_isStreaming == IntPtr.Zero)
					id_isStreaming = JNIEnv.GetMethodID (class_ref, "isStreaming", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isStreaming);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SSRC;
		}
#pragma warning restore 0169

		IntPtr id_getSSRC;
		public unsafe int SSRC {
			get {
				if (id_getSSRC == IntPtr.Zero)
					id_getSSRC = JNIEnv.GetMethodID (class_ref, "getSSRC", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getSSRC);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GenerateSessionDescription ());
		}
#pragma warning restore 0169

		IntPtr id_generateSessionDescription;
		public unsafe string GenerateSessionDescription ()
		{
			if (id_generateSessionDescription == IntPtr.Zero)
				id_generateSessionDescription = JNIEnv.GetMethodID (class_ref, "generateSessionDescription", "()Ljava/lang/String;");
			return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateSessionDescription), JniHandleOwnership.TransferLocalRef);
		}

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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDestinationPorts ());
		}
#pragma warning restore 0169

		IntPtr id_getDestinationPorts;
		public unsafe int[] GetDestinationPorts ()
		{
			if (id_getDestinationPorts == IntPtr.Zero)
				id_getDestinationPorts = JNIEnv.GetMethodID (class_ref, "getDestinationPorts", "()[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDestinationPorts), JniHandleOwnership.TransferLocalRef, typeof (int));
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLocalPorts ());
		}
#pragma warning restore 0169

		IntPtr id_getLocalPorts;
		public unsafe int[] GetLocalPorts ()
		{
			if (id_getLocalPorts == IntPtr.Zero)
				id_getLocalPorts = JNIEnv.GetMethodID (class_ref, "getLocalPorts", "()[I");
			return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLocalPorts), JniHandleOwnership.TransferLocalRef, typeof (int));
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_data_ready ();
		}
#pragma warning restore 0169

		IntPtr id_is_data_ready;
		public unsafe bool Is_data_ready ()
		{
			if (id_is_data_ready == IntPtr.Zero)
				id_is_data_ready = JNIEnv.GetMethodID (class_ref, "is_data_ready", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_is_data_ready);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		IntPtr id_pause;
		public unsafe void Pause ()
		{
			if (id_pause == IntPtr.Zero)
				id_pause = JNIEnv.GetMethodID (class_ref, "pause", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_pause);
		}

		static Delegate cb_prepare_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetPrepare_Ljava_lang_String_Handler ()
		{
			if (cb_prepare_Ljava_lang_String_ == null)
				cb_prepare_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Prepare_Ljava_lang_String_);
			return cb_prepare_Ljava_lang_String_;
		}

		static void n_Prepare_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (p0);
		}
#pragma warning restore 0169

		IntPtr id_prepare_Ljava_lang_String_;
		public unsafe void Prepare (string p0)
		{
			if (id_prepare_Ljava_lang_String_ == IntPtr.Zero)
				id_prepare_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "prepare", "(Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_prepare_Ljava_lang_String_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		IntPtr id_release;
		public unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
		}

		static Delegate cb_setDestinationAddress_Ljava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetSetDestinationAddress_Ljava_net_InetAddress_Handler ()
		{
			if (cb_setDestinationAddress_Ljava_net_InetAddress_ == null)
				cb_setDestinationAddress_Ljava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDestinationAddress_Ljava_net_InetAddress_);
			return cb_setDestinationAddress_Ljava_net_InetAddress_;
		}

		static void n_SetDestinationAddress_Ljava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetDestinationAddress (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDestinationAddress_Ljava_net_InetAddress_;
		public unsafe void SetDestinationAddress (global::Java.Net.InetAddress p0)
		{
			if (id_setDestinationAddress_Ljava_net_InetAddress_ == IntPtr.Zero)
				id_setDestinationAddress_Ljava_net_InetAddress_ = JNIEnv.GetMethodID (class_ref, "setDestinationAddress", "(Ljava/net/InetAddress;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDestinationAddress_Ljava_net_InetAddress_, __args);
		}

		static Delegate cb_setDestinationPorts_I;
#pragma warning disable 0169
		static Delegate GetSetDestinationPorts_IHandler ()
		{
			if (cb_setDestinationPorts_I == null)
				cb_setDestinationPorts_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDestinationPorts_I);
			return cb_setDestinationPorts_I;
		}

		static void n_SetDestinationPorts_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDestinationPorts (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDestinationPorts_I;
		public unsafe void SetDestinationPorts (int p0)
		{
			if (id_setDestinationPorts_I == IntPtr.Zero)
				id_setDestinationPorts_I = JNIEnv.GetMethodID (class_ref, "setDestinationPorts", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDestinationPorts_I, __args);
		}

		static Delegate cb_setDestinationPorts_II;
#pragma warning disable 0169
		static Delegate GetSetDestinationPorts_IIHandler ()
		{
			if (cb_setDestinationPorts_II == null)
				cb_setDestinationPorts_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetDestinationPorts_II);
			return cb_setDestinationPorts_II;
		}

		static void n_SetDestinationPorts_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDestinationPorts (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_setDestinationPorts_II;
		public unsafe void SetDestinationPorts (int p0, int p1)
		{
			if (id_setDestinationPorts_II == IntPtr.Zero)
				id_setDestinationPorts_II = JNIEnv.GetMethodID (class_ref, "setDestinationPorts", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDestinationPorts_II, __args);
		}

		static Delegate cb_setTimeToLive_I;
#pragma warning disable 0169
		static Delegate GetSetTimeToLive_IHandler ()
		{
			if (cb_setTimeToLive_I == null)
				cb_setTimeToLive_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeToLive_I);
			return cb_setTimeToLive_I;
		}

		static void n_SetTimeToLive_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeToLive (p0);
		}
#pragma warning restore 0169

		IntPtr id_setTimeToLive_I;
		public unsafe void SetTimeToLive (int p0)
		{
			if (id_setTimeToLive_I == IntPtr.Zero)
				id_setTimeToLive_I = JNIEnv.GetMethodID (class_ref, "setTimeToLive", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setTimeToLive_I, __args);
		}

		static Delegate cb_start_J;
#pragma warning disable 0169
		static Delegate GetStart_JHandler ()
		{
			if (cb_start_J == null)
				cb_start_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Start_J);
			return cb_start_J;
		}

		static void n_Start_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0);
		}
#pragma warning restore 0169

		IntPtr id_start_J;
		public unsafe void Start (long p0)
		{
			if (id_start_J == IntPtr.Zero)
				id_start_J = JNIEnv.GetMethodID (class_ref, "start", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_start_J, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		IntPtr id_stop;
		public unsafe void Stop ()
		{
			if (id_stop == IntPtr.Zero)
				id_stop = JNIEnv.GetMethodID (class_ref, "stop", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_stop);
		}

	}
}
