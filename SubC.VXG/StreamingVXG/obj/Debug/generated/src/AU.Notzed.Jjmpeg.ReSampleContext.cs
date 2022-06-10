using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='ReSampleContext']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/ReSampleContext", DoNotGenerateAcw=true)]
	public partial class ReSampleContext : global::AU.Notzed.Jjmpeg.AVObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/ReSampleContext", typeof (ReSampleContext));

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

		protected ReSampleContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='ReSampleContext']/constructor[@name='ReSampleContext' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe ReSampleContext (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='ReSampleContext']/constructor[@name='ReSampleContext' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe ReSampleContext (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.ReSampleContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='ReSampleContext']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='ReSampleContext']/method[@name='create' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[6][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='double']]"
		[Register ("create", "(IIIILau/notzed/jjmpeg/SampleFormat;Lau/notzed/jjmpeg/SampleFormat;IIID)Lau/notzed/jjmpeg/ReSampleContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.ReSampleContext Create (int output_channels, int input_channels, int output_rate, int input_rate, global::AU.Notzed.Jjmpeg.SampleFormat sample_fmt_out, global::AU.Notzed.Jjmpeg.SampleFormat sample_fmt_in, int filter_length, int log2_phase_count, int linear, double cutoff)
		{
			const string __id = "create.(IIIILau/notzed/jjmpeg/SampleFormat;Lau/notzed/jjmpeg/SampleFormat;IIID)Lau/notzed/jjmpeg/ReSampleContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (output_channels);
				__args [1] = new JniArgumentValue (input_channels);
				__args [2] = new JniArgumentValue (output_rate);
				__args [3] = new JniArgumentValue (input_rate);
				__args [4] = new JniArgumentValue ((sample_fmt_out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sample_fmt_out).Handle);
				__args [5] = new JniArgumentValue ((sample_fmt_in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sample_fmt_in).Handle);
				__args [6] = new JniArgumentValue (filter_length);
				__args [7] = new JniArgumentValue (log2_phase_count);
				__args [8] = new JniArgumentValue (linear);
				__args [9] = new JniArgumentValue (cutoff);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.ReSampleContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (sample_fmt_out);
				global::System.GC.KeepAlive (sample_fmt_in);
			}
		}

		static Delegate cb_dispose;
#pragma warning disable 0169
		static Delegate GetDisposeHandler ()
		{
			if (cb_dispose == null)
				cb_dispose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Dispose);
			return cb_dispose;
		}

		static void n_Dispose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.ReSampleContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='ReSampleContext']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resampleClose;
#pragma warning disable 0169
		static Delegate GetResampleCloseHandler ()
		{
			if (cb_resampleClose == null)
				cb_resampleClose = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResampleClose);
			return cb_resampleClose;
		}

		static void n_ResampleClose (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.ReSampleContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResampleClose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='ReSampleContext']/method[@name='resampleClose' and count(parameter)=0]"
		[Register ("resampleClose", "()V", "GetResampleCloseHandler")]
		public virtual unsafe void ResampleClose ()
		{
			const string __id = "resampleClose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='ReSampleContextAbstract']/method[@name='resampleInit' and count(parameter)=10 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[6][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[7][@type='int'] and parameter[8][@type='int'] and parameter[9][@type='int'] and parameter[10][@type='double']]"
		[Register ("resampleInit", "(IIIILau/notzed/jjmpeg/SampleFormat;Lau/notzed/jjmpeg/SampleFormat;IIID)Lau/notzed/jjmpeg/ReSampleContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.ReSampleContext ResampleInit (int output_channels, int input_channels, int output_rate, int input_rate, global::AU.Notzed.Jjmpeg.SampleFormat sample_fmt_out, global::AU.Notzed.Jjmpeg.SampleFormat sample_fmt_in, int filter_length, int log2_phase_count, int linear, double cutoff)
		{
			const string __id = "resampleInit.(IIIILau/notzed/jjmpeg/SampleFormat;Lau/notzed/jjmpeg/SampleFormat;IIID)Lau/notzed/jjmpeg/ReSampleContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (output_channels);
				__args [1] = new JniArgumentValue (input_channels);
				__args [2] = new JniArgumentValue (output_rate);
				__args [3] = new JniArgumentValue (input_rate);
				__args [4] = new JniArgumentValue ((sample_fmt_out == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sample_fmt_out).Handle);
				__args [5] = new JniArgumentValue ((sample_fmt_in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) sample_fmt_in).Handle);
				__args [6] = new JniArgumentValue (filter_length);
				__args [7] = new JniArgumentValue (log2_phase_count);
				__args [8] = new JniArgumentValue (linear);
				__args [9] = new JniArgumentValue (cutoff);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.ReSampleContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (sample_fmt_out);
				global::System.GC.KeepAlive (sample_fmt_in);
			}
		}

	}
}
