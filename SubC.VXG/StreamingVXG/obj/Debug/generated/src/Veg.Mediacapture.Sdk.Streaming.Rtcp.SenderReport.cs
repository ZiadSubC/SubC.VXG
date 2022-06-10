using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Rtcp {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/rtcp/SenderReport", DoNotGenerateAcw=true)]
	public partial class SenderReport : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/field[@name='MTU']"
		[Register ("MTU")]
		public const int Mtu = (int) 1500;

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/rtcp/SenderReport", typeof (SenderReport));

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

		protected SenderReport (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/constructor[@name='SenderReport' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SenderReport () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LocalPort;
		}
#pragma warning restore 0169

		public virtual unsafe int LocalPort {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='getLocalPort' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='getPort' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SSRC = ssrc;
		}
#pragma warning restore 0169

		public virtual unsafe int SSRC {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='getSSRC' and count(parameter)=0]"
			[Register ("getSSRC", "()I", "GetGetSSRCHandler")]
			get {
				const string __id = "getSSRC.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='setSSRC' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_send;
#pragma warning disable 0169
		static Delegate GetSendHandler ()
		{
			if (cb_send == null)
				cb_send = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Send);
			return cb_send;
		}

		static void n_Send (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Send ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='send' and count(parameter)=0]"
		[Register ("send", "()V", "GetSendHandler")]
		public virtual unsafe void Send ()
		{
			const string __id = "send.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dest = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_dest, JniHandleOwnership.DoNotTransfer);
			__this.SetDestination (dest, dport);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='setDestination' and count(parameter)=2 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='int']]"
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

		static Delegate cb_setNtpTimestamp_J;
#pragma warning disable 0169
		static Delegate GetSetNtpTimestamp_JHandler ()
		{
			if (cb_setNtpTimestamp_J == null)
				cb_setNtpTimestamp_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetNtpTimestamp_J);
			return cb_setNtpTimestamp_J;
		}

		static void n_SetNtpTimestamp_J (IntPtr jnienv, IntPtr native__this, long ts)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNtpTimestamp (ts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='setNtpTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setNtpTimestamp", "(J)V", "GetSetNtpTimestamp_JHandler")]
		public virtual unsafe void SetNtpTimestamp (long ts)
		{
			const string __id = "setNtpTimestamp.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setRtpTimestamp_J;
#pragma warning disable 0169
		static Delegate GetSetRtpTimestamp_JHandler ()
		{
			if (cb_setRtpTimestamp_J == null)
				cb_setRtpTimestamp_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetRtpTimestamp_J);
			return cb_setRtpTimestamp_J;
		}

		static void n_SetRtpTimestamp_J (IntPtr jnienv, IntPtr native__this, long ts)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRtpTimestamp (ts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='setRtpTimestamp' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("setRtpTimestamp", "(J)V", "GetSetRtpTimestamp_JHandler")]
		public virtual unsafe void SetRtpTimestamp (long ts)
		{
			const string __id = "setRtpTimestamp.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_update_I;
#pragma warning disable 0169
		static Delegate GetUpdate_IHandler ()
		{
			if (cb_update_I == null)
				cb_update_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Update_I);
			return cb_update_I;
		}

		static void n_Update_I (IntPtr jnienv, IntPtr native__this, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtcp.SenderReport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Update (length);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtcp']/class[@name='SenderReport']/method[@name='update' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("update", "(I)V", "GetUpdate_IHandler")]
		public virtual unsafe void Update (int length)
		{
			const string __id = "update.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (length);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
