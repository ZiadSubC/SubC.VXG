using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVNative']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVNative", DoNotGenerateAcw=true)]
	public abstract partial class AVNative : global::Java.Lang.Ref.WeakReference {
		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVNative", typeof (AVNative));

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

		protected AVNative (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVNative']/constructor[@name='AVNative' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVObject']]"
		[Register (".ctor", "(Lau/notzed/jjmpeg/AVObject;)V", "")]
		protected unsafe AVNative (global::AU.Notzed.Jjmpeg.AVObject jobject) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lau/notzed/jjmpeg/AVObject;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((jobject == null) ? IntPtr.Zero : ((global::Java.Lang.Object) jobject).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (jobject);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVNative']/method[@name='check' and count(parameter)=0]"
		[Register ("check", "()V", "")]
		public static unsafe void Check ()
		{
			const string __id = "check.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVNative> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVNative']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public virtual unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVNative']/method[@name='getVersions' and count(parameter)=0]"
		[Register ("getVersions", "()[I", "")]
		public static unsafe int[] GetVersions ()
		{
			const string __id = "getVersions.()[I";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVNative", DoNotGenerateAcw=true)]
	internal partial class AVNativeInvoker : AVNative {
		public AVNativeInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVNative", typeof (AVNativeInvoker));

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

	}
}
