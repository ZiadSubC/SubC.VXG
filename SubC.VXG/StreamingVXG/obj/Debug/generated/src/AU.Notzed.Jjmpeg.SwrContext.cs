using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwrContext']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/SwrContext", DoNotGenerateAcw=true)]
	public partial class SwrContext : global::AU.Notzed.Jjmpeg.AVObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/SwrContext", typeof (SwrContext));

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

		protected SwrContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwrContext']/constructor[@name='SwrContext' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe SwrContext (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwrContext']/constructor[@name='SwrContext' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe SwrContext (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_convert_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVFrame_;
#pragma warning disable 0169
		static Delegate GetConvert_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVFrame_Handler ()
		{
			if (cb_convert_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVFrame_ == null)
				cb_convert_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_Convert_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVFrame_);
			return cb_convert_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVFrame_;
		}

		static int n_Convert_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dst, IntPtr native_src)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwrContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dst = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_dst, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_src, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Convert (dst, src);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwrContext']/method[@name='convert' and count(parameter)=2 and parameter[1][@type='au.notzed.jjmpeg.AVFrame'] and parameter[2][@type='au.notzed.jjmpeg.AVFrame']]"
		[Register ("convert", "(Lau/notzed/jjmpeg/AVFrame;Lau/notzed/jjmpeg/AVFrame;)I", "GetConvert_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVFrame_Handler")]
		public virtual unsafe int Convert (global::AU.Notzed.Jjmpeg.AVFrame dst, global::AU.Notzed.Jjmpeg.AVFrame src)
		{
			const string __id = "convert.(Lau/notzed/jjmpeg/AVFrame;Lau/notzed/jjmpeg/AVFrame;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dst == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dst).Handle);
				__args [1] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (dst);
				global::System.GC.KeepAlive (src);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwrContext']/method[@name='create' and count(parameter)=6 and parameter[1][@type='long'] and parameter[2][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[3][@type='int'] and parameter[4][@type='long'] and parameter[5][@type='au.notzed.jjmpeg.SampleFormat'] and parameter[6][@type='int']]"
		[Register ("create", "(JLau/notzed/jjmpeg/SampleFormat;IJLau/notzed/jjmpeg/SampleFormat;I)Lau/notzed/jjmpeg/SwrContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.SwrContext Create (long dstLayout, global::AU.Notzed.Jjmpeg.SampleFormat dstFormat, int dstRate, long srcLayout, global::AU.Notzed.Jjmpeg.SampleFormat srcFormat, int srcRate)
		{
			const string __id = "create.(JLau/notzed/jjmpeg/SampleFormat;IJLau/notzed/jjmpeg/SampleFormat;I)Lau/notzed/jjmpeg/SwrContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (dstLayout);
				__args [1] = new JniArgumentValue ((dstFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dstFormat).Handle);
				__args [2] = new JniArgumentValue (dstRate);
				__args [3] = new JniArgumentValue (srcLayout);
				__args [4] = new JniArgumentValue ((srcFormat == null) ? IntPtr.Zero : ((global::Java.Lang.Object) srcFormat).Handle);
				__args [5] = new JniArgumentValue (srcRate);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwrContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (dstFormat);
				global::System.GC.KeepAlive (srcFormat);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwrContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwrContext']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCompensation_II;
#pragma warning disable 0169
		static Delegate GetSetCompensation_IIHandler ()
		{
			if (cb_setCompensation_II == null)
				cb_setCompensation_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_SetCompensation_II);
			return cb_setCompensation_II;
		}

		static int n_SetCompensation_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SwrContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetCompensation (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='SwrContext']/method[@name='setCompensation' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCompensation", "(II)I", "GetSetCompensation_IIHandler")]
		public virtual unsafe int SetCompensation (int p0, int p1)
		{
			const string __id = "setCompensation.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
