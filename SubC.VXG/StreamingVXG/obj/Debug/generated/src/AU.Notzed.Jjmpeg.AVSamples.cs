using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVSamples", DoNotGenerateAcw=true)]
	public partial class AVSamples : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVSamples", typeof (AVSamples));

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

		protected AVSamples (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']/constructor[@name='AVSamples' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.SampleFormat']]"
		[Register (".ctor", "(Lau/notzed/jjmpeg/SampleFormat;)V", "")]
		public unsafe AVSamples (global::AU.Notzed.Jjmpeg.SampleFormat format) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lau/notzed/jjmpeg/SampleFormat;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (format);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']/constructor[@name='AVSamples' and count(parameter)=3 and parameter[1][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Lau/notzed/jjmpeg/SampleFormat;II)V", "")]
		public unsafe AVSamples (global::AU.Notzed.Jjmpeg.SampleFormat format, int channels, int frameSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lau/notzed/jjmpeg/SampleFormat;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [1] = new JniArgumentValue (channels);
				__args [2] = new JniArgumentValue (frameSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (format);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Buffer);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.ByteBuffer Buffer {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']/method[@name='getBuffer' and count(parameter)=0]"
			[Register ("getBuffer", "()Ljava/nio/ByteBuffer;", "GetGetBufferHandler")]
			get {
				const string __id = "getBuffer.()Ljava/nio/ByteBuffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFormat;
#pragma warning disable 0169
		static Delegate GetGetFormatHandler ()
		{
			if (cb_getFormat == null)
				cb_getFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFormat);
			return cb_getFormat;
		}

		static IntPtr n_GetFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Format);
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.SampleFormat Format {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']/method[@name='getFormat' and count(parameter)=0]"
			[Register ("getFormat", "()Lau/notzed/jjmpeg/SampleFormat;", "GetGetFormatHandler")]
			get {
				const string __id = "getFormat.()Lau/notzed/jjmpeg/SampleFormat;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSamples;
#pragma warning disable 0169
		static Delegate GetGetSamplesHandler ()
		{
			if (cb_getSamples == null)
				cb_getSamples = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSamples);
			return cb_getSamples;
		}

		static IntPtr n_GetSamples (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Samples);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Nio.Buffer Samples {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']/method[@name='getSamples' and count(parameter)=0]"
			[Register ("getSamples", "()Ljava/nio/Buffer;", "GetGetSamplesHandler")]
			get {
				const string __id = "getSamples.()Ljava/nio/Buffer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Nio.Buffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_fill_Lau_notzed_jjmpeg_AVSamples_;
#pragma warning disable 0169
		static Delegate GetFill_Lau_notzed_jjmpeg_AVSamples_Handler ()
		{
			if (cb_fill_Lau_notzed_jjmpeg_AVSamples_ == null)
				cb_fill_Lau_notzed_jjmpeg_AVSamples_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Fill_Lau_notzed_jjmpeg_AVSamples_);
			return cb_fill_Lau_notzed_jjmpeg_AVSamples_;
		}

		static bool n_Fill_Lau_notzed_jjmpeg_AVSamples_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (native_src, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Fill (src);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']/method[@name='fill' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVSamples']]"
		[Register ("fill", "(Lau/notzed/jjmpeg/AVSamples;)Z", "GetFill_Lau_notzed_jjmpeg_AVSamples_Handler")]
		public virtual unsafe bool Fill (global::AU.Notzed.Jjmpeg.AVSamples src)
		{
			const string __id = "fill.(Lau/notzed/jjmpeg/AVSamples;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_pad;
#pragma warning disable 0169
		static Delegate GetPadHandler ()
		{
			if (cb_pad == null)
				cb_pad = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Pad);
			return cb_pad;
		}

		static void n_Pad (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pad ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVSamples']/method[@name='pad' and count(parameter)=0]"
		[Register ("pad", "()V", "GetPadHandler")]
		public virtual unsafe void Pad ()
		{
			const string __id = "pad.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
