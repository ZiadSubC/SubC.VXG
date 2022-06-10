using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Rtp {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/rtp/AACADTSPacketizer", DoNotGenerateAcw=true)]
	public partial class AACADTSPacketizer : global::Veg.Mediacapture.Sdk.Streaming.Rtp.AbstractPacketizer, global::Java.Lang.IRunnable {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/field[@name='MEDIA_TYPE_AUDIO_AAC']"
		[Register ("MEDIA_TYPE_AUDIO_AAC")]
		public const int MediaTypeAudioAac = (int) 4;

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/rtp/AACADTSPacketizer", typeof (AACADTSPacketizer));

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

		protected AACADTSPacketizer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/constructor[@name='AACADTSPacketizer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AACADTSPacketizer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AACADTSPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Is_data_ready ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/method[@name='is_data_ready' and count(parameter)=0]"
		[Register ("is_data_ready", "()Z", "GetIs_data_readyHandler")]
		public override unsafe bool Is_data_ready ()
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AACADTSPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/method[@name='pause' and count(parameter)=0]"
		[Register ("pause", "()V", "GetPauseHandler")]
		public override unsafe void Pause ()
		{
			const string __id = "pause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AACADTSPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setSamplingRate_I;
#pragma warning disable 0169
		static Delegate GetSetSamplingRate_IHandler ()
		{
			if (cb_setSamplingRate_I == null)
				cb_setSamplingRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSamplingRate_I);
			return cb_setSamplingRate_I;
		}

		static void n_SetSamplingRate_I (IntPtr jnienv, IntPtr native__this, int samplingRate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AACADTSPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSamplingRate (samplingRate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/method[@name='setSamplingRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSamplingRate", "(I)V", "GetSetSamplingRate_IHandler")]
		public virtual unsafe void SetSamplingRate (int samplingRate)
		{
			const string __id = "setSamplingRate.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (samplingRate);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AACADTSPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (start_time);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/method[@name='start' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("start", "(J)V", "GetStart_JHandler")]
		public override unsafe void Start (long start_time)
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.AACADTSPacketizer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='AACADTSPacketizer']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public override unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}