using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Api {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/api/ThreadHelper", DoNotGenerateAcw=true)]
	public abstract partial class ThreadHelper : global::Java.Lang.Object, global::Java.Lang.IRunnable {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/api/ThreadHelper", typeof (ThreadHelper));

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

		protected ThreadHelper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/constructor[@name='ThreadHelper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		protected unsafe ThreadHelper () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_is_running;
#pragma warning disable 0169
		static Delegate GetIs_runningHandler ()
		{
			if (cb_is_running == null)
				cb_is_running = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Is_running);
			return cb_is_running;
		}

		static bool n_Is_running (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Api.ThreadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_running ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='is_running' and count(parameter)=0]"
		[Register ("is_running", "()Z", "GetIs_runningHandler")]
		public virtual unsafe bool Is_running ()
		{
			const string __id = "is_running.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_is_started;
#pragma warning disable 0169
		static Delegate GetIs_startedHandler ()
		{
			if (cb_is_started == null)
				cb_is_started = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_Is_started);
			return cb_is_started;
		}

		static bool n_Is_started (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Api.ThreadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_started ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='is_started' and count(parameter)=0]"
		[Register ("is_started", "()Z", "GetIs_startedHandler")]
		public virtual unsafe bool Is_started ()
		{
			const string __id = "is_started.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Api.ThreadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_runt;
#pragma warning disable 0169
		static Delegate GetRuntHandler ()
		{
			if (cb_runt == null)
				cb_runt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Runt);
			return cb_runt;
		}

		static void n_Runt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Api.ThreadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Runt ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='runt' and count(parameter)=0]"
		[Register ("runt", "()V", "GetRuntHandler")]
		public abstract void Runt ();

		static Delegate cb_sleep_J;
#pragma warning disable 0169
		static Delegate GetSleep_JHandler ()
		{
			if (cb_sleep_J == null)
				cb_sleep_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Sleep_J);
			return cb_sleep_J;
		}

		static void n_Sleep_J (IntPtr jnienv, IntPtr native__this, long millis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Api.ThreadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Sleep (millis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='sleep' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("sleep", "(J)V", "GetSleep_JHandler")]
		public virtual unsafe void Sleep (long millis)
		{
			const string __id = "sleep.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (millis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_start == null)
				cb_start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Api.ThreadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop_J;
#pragma warning disable 0169
		static Delegate GetStop_JHandler ()
		{
			if (cb_stop_J == null)
				cb_stop_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_Stop_J);
			return cb_stop_J;
		}

		static void n_Stop_J (IntPtr jnienv, IntPtr native__this, long wait_millis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Api.ThreadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop (wait_millis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("stop", "(J)V", "GetStop_JHandler")]
		public virtual unsafe void Stop (long wait_millis)
		{
			const string __id = "stop.(J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (wait_millis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_wakeup;
#pragma warning disable 0169
		static Delegate GetWakeupHandler ()
		{
			if (cb_wakeup == null)
				cb_wakeup = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Wakeup);
			return cb_wakeup;
		}

		static void n_Wakeup (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Api.ThreadHelper> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Wakeup ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='wakeup' and count(parameter)=0]"
		[Register ("wakeup", "()V", "GetWakeupHandler")]
		public virtual unsafe void Wakeup ()
		{
			const string __id = "wakeup.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/api/ThreadHelper", DoNotGenerateAcw=true)]
	internal partial class ThreadHelperInvoker : ThreadHelper {
		public ThreadHelperInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/api/ThreadHelper", typeof (ThreadHelperInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.api']/class[@name='ThreadHelper']/method[@name='runt' and count(parameter)=0]"
		[Register ("runt", "()V", "GetRuntHandler")]
		public override unsafe void Runt ()
		{
			const string __id = "runt.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
