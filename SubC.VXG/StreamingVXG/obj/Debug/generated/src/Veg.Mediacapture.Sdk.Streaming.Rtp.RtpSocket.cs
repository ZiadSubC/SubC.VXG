using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Rtp {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/rtp/RtpSocket", DoNotGenerateAcw=true)]
	public partial class RtpSocket : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/field[@name='MTU']"
		[Register ("MTU")]
		public const int Mtu = (int) 1500;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/field[@name='RTP_HEADER_LENGTH']"
		[Register ("RTP_HEADER_LENGTH")]
		public const int RtpHeaderLength = (int) 12;

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/rtp/RtpSocket", typeof (RtpSocket));

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

		protected RtpSocket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/constructor[@name='RtpSocket' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RtpSocket () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getLocalPort;
#pragma warning disable 0169
		static Delegate GetGetLocalPortHandler ()
		{
			if (cb_getLocalPort == null)
				cb_getLocalPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLocalPort);
			return cb_getLocalPort;
		}

		static int n_GetLocalPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalPort;
		}
#pragma warning restore 0169

		public virtual unsafe int LocalPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='getLocalPort' and count(parameter)=0]"
			[Register ("getLocalPort", "()I", "GetGetLocalPortHandler")]
			get {
				const string __id = "getLocalPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPort);
			return cb_getPort;
		}

		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				const string __id = "getPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SSRC = ssrc;
		}
#pragma warning restore 0169

		public virtual unsafe int SSRC {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='getSSRC' and count(parameter)=0]"
			[Register ("getSSRC", "()I", "GetGetSSRCHandler")]
			get {
				const string __id = "getSSRC.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='setSSRC' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBuffer;
#pragma warning disable 0169
		static Delegate GetGetBufferHandler ()
		{
			if (cb_getBuffer == null)
				cb_getBuffer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBuffer);
			return cb_getBuffer;
		}

		static IntPtr n_GetBuffer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBuffer ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='getBuffer' and count(parameter)=0]"
		[Register ("getBuffer", "()[B", "GetGetBufferHandler")]
		public virtual unsafe byte[] GetBuffer ()
		{
			const string __id = "getBuffer.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_markNextPacket;
#pragma warning disable 0169
		static Delegate GetMarkNextPacketHandler ()
		{
			if (cb_markNextPacket == null)
				cb_markNextPacket = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_MarkNextPacket);
			return cb_markNextPacket;
		}

		static void n_MarkNextPacket (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MarkNextPacket ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='markNextPacket' and count(parameter)=0]"
		[Register ("markNextPacket", "()V", "GetMarkNextPacketHandler")]
		public virtual unsafe void MarkNextPacket ()
		{
			const string __id = "markNextPacket.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send (length);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='send' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("send", "(I)V", "GetSend_IHandler")]
		public virtual unsafe void Send (int length)
		{
			const string __id = "send.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDestination_Ljava_net_InetAddress_I;
#pragma warning disable 0169
		static Delegate GetSetDestination_Ljava_net_InetAddress_IHandler ()
		{
			if (cb_setDestination_Ljava_net_InetAddress_I == null)
				cb_setDestination_Ljava_net_InetAddress_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetDestination_Ljava_net_InetAddress_I);
			return cb_setDestination_Ljava_net_InetAddress_I;
		}

		static void n_SetDestination_Ljava_net_InetAddress_I (IntPtr jnienv, IntPtr native__this, IntPtr native_dest, int dport)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_dest, JniHandleOwnership.DoNotTransfer);
			__this.SetDestination (dest, dport);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='setDestination' and count(parameter)=2 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int']]"
		[Register ("setDestination", "(Ljava/net/InetAddress;I)V", "GetSetDestination_Ljava_net_InetAddress_IHandler")]
		public virtual unsafe void SetDestination (global::Java.Net.InetAddress dest, int dport)
		{
			const string __id = "setDestination.(Ljava/net/InetAddress;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dest == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dest).Handle);
				__args [1] = new JniArgumentValue (dport);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dest);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeToLive (ttl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='setTimeToLive' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_updateTimestamp_J;
#pragma warning disable 0169
		static Delegate GetUpdateTimestamp_JHandler ()
		{
			if (cb_updateTimestamp_J == null)
				cb_updateTimestamp_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_UpdateTimestamp_J);
			return cb_updateTimestamp_J;
		}

		static void n_UpdateTimestamp_J (IntPtr jnienv, IntPtr native__this, long timestamp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.RtpSocket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateTimestamp (timestamp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='RtpSocket']/method[@name='updateTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("updateTimestamp", "(J)V", "GetUpdateTimestamp_JHandler")]
		public virtual unsafe void UpdateTimestamp (long timestamp)
		{
			const string __id = "updateTimestamp.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (timestamp);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
