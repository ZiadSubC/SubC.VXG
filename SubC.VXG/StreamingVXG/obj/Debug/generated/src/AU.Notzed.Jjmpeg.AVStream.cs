using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVStream", DoNotGenerateAcw=true)]
	public partial class AVStream : global::AU.Notzed.Jjmpeg.AVObject {
		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVStream", typeof (AVStream));

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

		protected AVStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/constructor[@name='AVStream' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe AVStream (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/constructor[@name='AVStream' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe AVStream (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getCodec;
#pragma warning disable 0169
		static Delegate GetGetCodecHandler ()
		{
			if (cb_getCodec == null)
				cb_getCodec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCodec);
			return cb_getCodec;
		}

		static IntPtr n_GetCodec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Codec);
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.AVCodecContext Codec {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='getCodec' and count(parameter)=0]"
			[Register ("getCodec", "()Lau/notzed/jjmpeg/AVCodecContext;", "GetGetCodecHandler")]
			get {
				const string __id = "getCodec.()Lau/notzed/jjmpeg/AVCodecContext;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDuration;
#pragma warning disable 0169
		static Delegate GetGetDurationHandler ()
		{
			if (cb_getDuration == null)
				cb_getDuration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDuration);
			return cb_getDuration;
		}

		static long n_GetDuration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='getDuration' and count(parameter)=0]"
			[Register ("getDuration", "()J", "GetGetDurationHandler")]
			get {
				const string __id = "getDuration.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getId;
#pragma warning disable 0169
		static Delegate GetGetIdHandler ()
		{
			if (cb_getId == null)
				cb_getId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetId);
			return cb_getId;
		}

		static int n_GetId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Id;
		}
#pragma warning restore 0169

		public virtual unsafe int Id {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='getId' and count(parameter)=0]"
			[Register ("getId", "()I", "GetGetIdHandler")]
			get {
				const string __id = "getId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndex;
#pragma warning disable 0169
		static Delegate GetGetIndexHandler ()
		{
			if (cb_getIndex == null)
				cb_getIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIndex);
			return cb_getIndex;
		}

		static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Index;
		}
#pragma warning restore 0169

		public virtual unsafe int Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()I", "GetGetIndexHandler")]
			get {
				const string __id = "getIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNBFrames;
#pragma warning disable 0169
		static Delegate GetGetNBFramesHandler ()
		{
			if (cb_getNBFrames == null)
				cb_getNBFrames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetNBFrames);
			return cb_getNBFrames;
		}

		static long n_GetNBFrames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NBFrames;
		}
#pragma warning restore 0169

		public virtual unsafe long NBFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='getNBFrames' and count(parameter)=0]"
			[Register ("getNBFrames", "()J", "GetGetNBFramesHandler")]
			get {
				const string __id = "getNBFrames.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRFrameRate;
#pragma warning disable 0169
		static Delegate GetGetRFrameRateHandler ()
		{
			if (cb_getRFrameRate == null)
				cb_getRFrameRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRFrameRate);
			return cb_getRFrameRate;
		}

		static IntPtr n_GetRFrameRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RFrameRate);
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.AVRational RFrameRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='getRFrameRate' and count(parameter)=0]"
			[Register ("getRFrameRate", "()Lau/notzed/jjmpeg/AVRational;", "GetGetRFrameRateHandler")]
			get {
				const string __id = "getRFrameRate.()Lau/notzed/jjmpeg/AVRational;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTime;
		}
#pragma warning restore 0169

		public virtual unsafe long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()J", "GetGetStartTimeHandler")]
			get {
				const string __id = "getStartTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTimeBase;
#pragma warning disable 0169
		static Delegate GetGetTimeBaseHandler ()
		{
			if (cb_getTimeBase == null)
				cb_getTimeBase = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTimeBase);
			return cb_getTimeBase;
		}

		static IntPtr n_GetTimeBase (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeBase);
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.AVRational TimeBase {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='getTimeBase' and count(parameter)=0]"
			[Register ("getTimeBase", "()Lau/notzed/jjmpeg/AVRational;", "GetGetTimeBaseHandler")]
			get {
				const string __id = "getTimeBase.()Lau/notzed/jjmpeg/AVRational;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVStream']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
