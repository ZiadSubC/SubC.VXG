using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Rtp {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/rtp/AbstractPacketizer", DoNotGenerateAcw=true)]
	public abstract partial class AbstractPacketizer : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='buffer']"
		[Register ("buffer")]
		protected IList<byte> Buffer {
			get {
				const string __id = "buffer.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "buffer.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='is']"
		[Register ("is")]
		protected global::System.IO.Stream Is {
			get {
				const string __id = "is.Ljava/io/InputStream;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "is.Ljava/io/InputStream;";

				IntPtr native_value = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='mConfigMain']"
		[Register ("mConfigMain")]
		protected global::Veg.Mediacapture.Sdk.MediaCaptureConfig MConfigMain {
			get {
				const string __id = "mConfigMain.Lveg/mediacapture/sdk/MediaCaptureConfig;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mConfigMain.Lveg/mediacapture/sdk/MediaCaptureConfig;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='m_start_time']"
		[Register ("m_start_time")]
		protected long MStartTime {
			get {
				const string __id = "m_start_time.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "m_start_time.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='m_state']"
		[Register ("m_state")]
		protected int MState {
			get {
				const string __id = "m_state.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "m_state.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='mbitrate']"
		[Register ("mbitrate")]
		protected int Mbitrate {
			get {
				const string __id = "mbitrate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mbitrate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='mconfig']"
		[Register ("mconfig")]
		protected global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Config Mconfig {
			get {
				const string __id = "mconfig.Lveg/mediacapture/sdk/streaming/mp4/MP4Config;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Config> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mconfig.Lveg/mediacapture/sdk/streaming/mp4/MP4Config;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='media_callback']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='mp4muxHRV']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='mp4muxLRV']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='report']"
		[Register ("report")]
		protected global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport Report {
			get {
				const string __id = "report.Lveg/mediacapture/sdk/streaming/rtcp/SenderReport;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "report.Lveg/mediacapture/sdk/streaming/rtcp/SenderReport;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='rtphl']"
		[Register ("rtphl")]
		protected const int Rtphl = (int) 12;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='socket']"
		[Register ("socket")]
		protected global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket Socket {
			get {
				const string __id = "socket.Lveg/mediacapture/sdk/streaming/rtp/RtpSocket;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "socket.Lveg/mediacapture/sdk/streaming/rtp/RtpSocket;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/field[@name='ts']"
		[Register ("ts")]
		protected long Ts {
			get {
				const string __id = "ts.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "ts.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer.Statistics']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/rtp/AbstractPacketizer$Statistics", DoNotGenerateAcw=true)]
		protected internal partial class Statistics : global::Java.Lang.Object {
			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer.Statistics']/field[@name='COUNT']"
			[Register ("COUNT")]
			public const int Count = (int) 50;

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/rtp/AbstractPacketizer$Statistics", typeof (Statistics));

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

			protected Statistics (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer.Statistics']/constructor[@name='AbstractPacketizer.Statistics' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			protected unsafe Statistics () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_average;
#pragma warning disable 0169
			static Delegate GetAverageHandler ()
			{
				if (cb_average == null)
					cb_average = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_Average);
				return cb_average;
			}

			static long n_Average (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Average ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer.Statistics']/method[@name='average' and count(parameter)=0]"
			[Register ("average", "()J", "GetAverageHandler")]
			public virtual unsafe long Average ()
			{
				const string __id = "average.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_push_J;
#pragma warning disable 0169
			static Delegate GetPush_JHandler ()
			{
				if (cb_push_J == null)
					cb_push_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Push_J);
				return cb_push_J;
			}

			static void n_Push_J (IntPtr jnienv, IntPtr native__this, long duration)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer.Statistics> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Push (duration);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer.Statistics']/method[@name='push' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("push", "(J)V", "GetPush_JHandler")]
			public virtual unsafe void Push (long duration)
			{
				const string __id = "push.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (duration);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/rtp/AbstractPacketizer", typeof (AbstractPacketizer));

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

		protected AbstractPacketizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/constructor[@name='AbstractPacketizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AbstractPacketizer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getRtcpSocket;
#pragma warning disable 0169
		static Delegate GetGetRtcpSocketHandler ()
		{
			if (cb_getRtcpSocket == null)
				cb_getRtcpSocket = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRtcpSocket);
			return cb_getRtcpSocket;
		}

		static IntPtr n_GetRtcpSocket (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RtcpSocket);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport RtcpSocket {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='getRtcpSocket' and count(parameter)=0]"
			[Register ("getRtcpSocket", "()Lveg/mediacapture/sdk/streaming/rtcp/SenderReport;", "GetGetRtcpSocketHandler")]
			get {
				const string __id = "getRtcpSocket.()Lveg/mediacapture/sdk/streaming/rtcp/SenderReport;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRtpSocket;
#pragma warning disable 0169
		static Delegate GetGetRtpSocketHandler ()
		{
			if (cb_getRtpSocket == null)
				cb_getRtpSocket = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRtpSocket);
			return cb_getRtpSocket;
		}

		static IntPtr n_GetRtpSocket (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RtpSocket);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket RtpSocket {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='getRtpSocket' and count(parameter)=0]"
			[Register ("getRtpSocket", "()Lveg/mediacapture/sdk/streaming/rtp/RtpSocket;", "GetGetRtpSocketHandler")]
			get {
				const string __id = "getRtpSocket.()Lveg/mediacapture/sdk/streaming/rtp/RtpSocket;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SSRC;
		}
#pragma warning restore 0169

		static Delegate cb_setSSRC_I;
#pragma warning disable 0169
		static Delegate GetSetSSRC_IHandler ()
		{
			if (cb_setSSRC_I == null)
				cb_setSSRC_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSSRC_I);
			return cb_setSSRC_I;
		}

		static void n_SetSSRC_I (IntPtr jnienv, IntPtr native__this, int ssrc)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SSRC = ssrc;
		}
#pragma warning restore 0169

		public virtual unsafe int SSRC {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='getSSRC' and count(parameter)=0]"
			[Register ("getSSRC", "()I", "GetGetSSRCHandler")]
			get {
				const string __id = "getSSRC.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setSSRC' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSSRC", "(I)V", "GetSetSSRC_IHandler")]
			set {
				const string __id = "setSSRC.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetStartTime);
			return cb_getStartTime;
		}

		static long n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTime;
		}
#pragma warning restore 0169

		static Delegate cb_setStartTime_J;
#pragma warning disable 0169
		static Delegate GetSetStartTime_JHandler ()
		{
			if (cb_setStartTime_J == null)
				cb_setStartTime_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetStartTime_J);
			return cb_setStartTime_J;
		}

		static void n_SetStartTime_J (IntPtr jnienv, IntPtr native__this, long start_time)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTime = start_time;
		}
#pragma warning restore 0169

		public virtual unsafe long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()J", "GetGetStartTimeHandler")]
			get {
				const string __id = "getStartTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setStartTime' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setStartTime", "(J)V", "GetSetStartTime_JHandler")]
			set {
				const string __id = "setStartTime.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mp4mux = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (native_mp4mux, JniHandleOwnership.DoNotTransfer);
			__this.SetMP4MuxHRV (mp4mux);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='SetMP4MuxHRV' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.MP4Muxj']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mp4mux = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (native_mp4mux, JniHandleOwnership.DoNotTransfer);
			__this.SetMP4MuxLRV (mp4mux);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='SetMP4MuxLRV' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.MP4Muxj']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_data_ready ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='is_data_ready' and count(parameter)=0]"
		[Register ("is_data_ready", "()Z", "GetIs_data_readyHandler")]
		public abstract bool Is_data_ready ();

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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public abstract void Pause ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='printBuffer' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("printBuffer", "([BII)Ljava/lang/String;", "")]
		protected static unsafe string PrintBuffer (byte[] buffer, int start, int end)
		{
			const string __id = "printBuffer.([BII)Ljava/lang/String;";
			IntPtr native_buffer = JNIEnv.NewArray (buffer);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_buffer);
				__args [1] = new JniArgumentValue (start);
				__args [2] = new JniArgumentValue (end);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (buffer != null) {
					JNIEnv.CopyArray (native_buffer, buffer);
					JNIEnv.DeleteLocalRef (native_buffer);
				}
				global::System.GC.KeepAlive (buffer);
			}
		}

		static Delegate cb_send_I;
#pragma warning disable 0169
		static Delegate GetSend_IHandler ()
		{
			if (cb_send_I == null)
				cb_send_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Send_I);
			return cb_send_I;
		}

		static void n_Send_I (IntPtr jnienv, IntPtr native__this, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send (length);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='send' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("send", "(I)V", "GetSend_IHandler")]
		protected virtual unsafe void Send (int length)
		{
			const string __id = "send.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setConfig_Lveg_mediacapture_sdk_streaming_mp4_MP4Config_;
#pragma warning disable 0169
		static Delegate GetSetConfig_Lveg_mediacapture_sdk_streaming_mp4_MP4Config_Handler ()
		{
			if (cb_setConfig_Lveg_mediacapture_sdk_streaming_mp4_MP4Config_ == null)
				cb_setConfig_Lveg_mediacapture_sdk_streaming_mp4_MP4Config_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConfig_Lveg_mediacapture_sdk_streaming_mp4_MP4Config_);
			return cb_setConfig_Lveg_mediacapture_sdk_streaming_mp4_MP4Config_;
		}

		static void n_SetConfig_Lveg_mediacapture_sdk_streaming_mp4_MP4Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Config> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.SetConfig (config);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setConfig' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.MP4Config']]"
		[Register ("setConfig", "(Lveg/mediacapture/sdk/streaming/mp4/MP4Config;)V", "GetSetConfig_Lveg_mediacapture_sdk_streaming_mp4_MP4Config_Handler")]
		public virtual unsafe void SetConfig (global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Config config)
		{
			const string __id = "setConfig.(Lveg/mediacapture/sdk/streaming/mp4/MP4Config;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

		static Delegate cb_setConfigMain_Lveg_mediacapture_sdk_MediaCaptureConfig_;
#pragma warning disable 0169
		static Delegate GetSetConfigMain_Lveg_mediacapture_sdk_MediaCaptureConfig_Handler ()
		{
			if (cb_setConfigMain_Lveg_mediacapture_sdk_MediaCaptureConfig_ == null)
				cb_setConfigMain_Lveg_mediacapture_sdk_MediaCaptureConfig_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetConfigMain_Lveg_mediacapture_sdk_MediaCaptureConfig_);
			return cb_setConfigMain_Lveg_mediacapture_sdk_MediaCaptureConfig_;
		}

		static void n_SetConfigMain_Lveg_mediacapture_sdk_MediaCaptureConfig_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.SetConfigMain (config);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setConfigMain' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig']]"
		[Register ("setConfigMain", "(Lveg/mediacapture/sdk/MediaCaptureConfig;)V", "GetSetConfigMain_Lveg_mediacapture_sdk_MediaCaptureConfig_Handler")]
		public virtual unsafe void SetConfigMain (global::Veg.Mediacapture.Sdk.MediaCaptureConfig config)
		{
			const string __id = "setConfigMain.(Lveg/mediacapture/sdk/MediaCaptureConfig;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (config);
			}
		}

		static Delegate cb_setDestination_Ljava_net_InetAddress_II;
#pragma warning disable 0169
		static Delegate GetSetDestination_Ljava_net_InetAddress_IIHandler ()
		{
			if (cb_setDestination_Ljava_net_InetAddress_II == null)
				cb_setDestination_Ljava_net_InetAddress_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_SetDestination_Ljava_net_InetAddress_II);
			return cb_setDestination_Ljava_net_InetAddress_II;
		}

		static void n_SetDestination_Ljava_net_InetAddress_II (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int rtpPort, int rtcpPort)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_dest, JniHandleOwnership.DoNotTransfer);
			__this.SetDestination (dest, rtpPort, rtcpPort);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setDestination' and count(parameter)=3 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setDestination", "(Ljava/net/InetAddress;II)V", "GetSetDestination_Ljava_net_InetAddress_IIHandler")]
		public virtual unsafe void SetDestination (global::Java.Net.InetAddress dest, int rtpPort, int rtcpPort)
		{
			const string __id = "setDestination.(Ljava/net/InetAddress;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue (rtpPort);
				__args [2] = new JniArgumentValue (rtcpPort);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dest);
			}
		}

		static Delegate cb_setInputStream_Ljava_io_InputStream_;
#pragma warning disable 0169
		static Delegate GetSetInputStream_Ljava_io_InputStream_Handler ()
		{
			if (cb_setInputStream_Ljava_io_InputStream_ == null)
				cb_setInputStream_Ljava_io_InputStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetInputStream_Ljava_io_InputStream_);
			return cb_setInputStream_Ljava_io_InputStream_;
		}

		static void n_SetInputStream_Ljava_io_InputStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native__is)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @is = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native__is, JniHandleOwnership.DoNotTransfer);
			__this.SetInputStream (@is);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setInputStream' and count(parameter)=1 and parameter[1][@type='java.io.InputStream']]"
		[Register ("setInputStream", "(Ljava/io/InputStream;)V", "GetSetInputStream_Ljava_io_InputStream_Handler")]
		public virtual unsafe void SetInputStream (global::System.IO.Stream @is)
		{
			const string __id = "setInputStream.(Ljava/io/InputStream;)V";
			IntPtr native__is = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (@is);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__is);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__is);
				global::System.GC.KeepAlive (@is);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cb = (global::Veg.Mediacapture.Sdk.IInternalDataCallback)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (native_cb, JniHandleOwnership.DoNotTransfer);
			__this.SetInternalDataCallback (cb);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setInternalDataCallback' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.InternalDataCallback']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeToLive (ttl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setTimeToLive' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_setVideoEncodingBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetVideoEncodingBitrate_IHandler ()
		{
			if (cb_setVideoEncodingBitrate_I == null)
				cb_setVideoEncodingBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoEncodingBitrate_I);
			return cb_setVideoEncodingBitrate_I;
		}

		static void n_SetVideoEncodingBitrate_I (IntPtr jnienv, IntPtr native__this, int bitrate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoEncodingBitrate (bitrate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='setVideoEncodingBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setVideoEncodingBitrate", "(I)V", "GetSetVideoEncodingBitrate_IHandler")]
		public virtual unsafe void SetVideoEncodingBitrate (int bitrate)
		{
			const string __id = "setVideoEncodingBitrate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (bitrate);
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

		static void n_Start_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='start' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("start", "(J)V", "GetStart_JHandler")]
		public abstract void Start (long p0);

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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public abstract void Stop ();

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/rtp/AbstractPacketizer", DoNotGenerateAcw=true)]
	internal partial class AbstractPacketizerInvoker : AbstractPacketizer {
		public AbstractPacketizerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/rtp/AbstractPacketizer", typeof (AbstractPacketizerInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='is_data_ready' and count(parameter)=0]"
		[Register ("is_data_ready", "()Z", "GetIs_data_readyHandler")]
		public override unsafe bool Is_data_ready ()
		{
			const string __id = "is_data_ready.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public override unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='start' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("start", "(J)V", "GetStart_JHandler")]
		public override unsafe void Start (long p0)
		{
			const string __id = "start.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AbstractPacketizer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
