using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVRational", DoNotGenerateAcw=true)]
	public partial class AVRational : global::AU.Notzed.Jjmpeg.AVObject {

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/field[@name='AV_TIME_BASE_Q']"
		[Register ("AV_TIME_BASE_Q")]
		public static global::AU.Notzed.Jjmpeg.AVRational AvTimeBaseQ {
			get {
				const string __id = "AV_TIME_BASE_Q.Lau/notzed/jjmpeg/AVRational;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVRational", typeof (AVRational));

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

		protected AVRational (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/constructor[@name='AVRational' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe AVRational (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/constructor[@name='AVRational' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe AVRational (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDen;
#pragma warning disable 0169
		static Delegate GetGetDenHandler ()
		{
			if (cb_getDen == null)
				cb_getDen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDen);
			return cb_getDen;
		}

		static int n_GetDen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Den;
		}
#pragma warning restore 0169

		static Delegate cb_setDen_I;
#pragma warning disable 0169
		static Delegate GetSetDen_IHandler ()
		{
			if (cb_setDen_I == null)
				cb_setDen_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetDen_I);
			return cb_setDen_I;
		}

		static void n_SetDen_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Den = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Den {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/method[@name='getDen' and count(parameter)=0]"
			[Register ("getDen", "()I", "GetGetDenHandler")]
			get {
				const string __id = "getDen.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/method[@name='setDen' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDen", "(I)V", "GetSetDen_IHandler")]
			set {
				const string __id = "setDen.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNum;
#pragma warning disable 0169
		static Delegate GetGetNumHandler ()
		{
			if (cb_getNum == null)
				cb_getNum = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNum);
			return cb_getNum;
		}

		static int n_GetNum (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Num;
		}
#pragma warning restore 0169

		static Delegate cb_setNum_I;
#pragma warning disable 0169
		static Delegate GetSetNum_IHandler ()
		{
			if (cb_setNum_I == null)
				cb_setNum_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetNum_I);
			return cb_setNum_I;
		}

		static void n_SetNum_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Num = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Num {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/method[@name='getNum' and count(parameter)=0]"
			[Register ("getNum", "()I", "GetGetNumHandler")]
			get {
				const string __id = "getNum.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/method[@name='setNum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNum", "(I)V", "GetSetNum_IHandler")]
			set {
				const string __id = "setNum.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_q2d;
#pragma warning disable 0169
		static Delegate GetQ2dHandler ()
		{
			if (cb_q2d == null)
				cb_q2d = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_Q2d);
			return cb_q2d;
		}

		static double n_Q2d (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Q2d ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/method[@name='q2d' and count(parameter)=0]"
		[Register ("q2d", "()D", "GetQ2dHandler")]
		public virtual unsafe double Q2d ()
		{
			const string __id = "q2d.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/method[@name='rescaleQ' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='au.notzed.jjmpeg.AVRational'] and parameter[3][@type='au.notzed.jjmpeg.AVRational']]"
		[Register ("rescaleQ", "(JLau/notzed/jjmpeg/AVRational;Lau/notzed/jjmpeg/AVRational;)J", "")]
		public static unsafe long RescaleQ (long a, global::AU.Notzed.Jjmpeg.AVRational bq, global::AU.Notzed.Jjmpeg.AVRational cq)
		{
			const string __id = "rescaleQ.(JLau/notzed/jjmpeg/AVRational;Lau/notzed/jjmpeg/AVRational;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (a);
				__args [1] = new JniArgumentValue ((bq == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bq).Handle);
				__args [2] = new JniArgumentValue ((cq == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cq).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (bq);
				global::System.GC.KeepAlive (cq);
			}
		}

		static Delegate cb_scale_JI;
#pragma warning disable 0169
		static Delegate GetScale_JIHandler ()
		{
			if (cb_scale_JI == null)
				cb_scale_JI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJI_J) n_Scale_JI);
			return cb_scale_JI;
		}

		static long n_Scale_JI (IntPtr jnienv, IntPtr native__this, long v, int s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVRational> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale (v, s);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRational']/method[@name='scale' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("scale", "(JI)J", "GetScale_JIHandler")]
		public virtual unsafe long Scale (long v, int s)
		{
			const string __id = "scale.(JI)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (v);
				__args [1] = new JniArgumentValue (s);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVRationalAbstract']/method[@name='rescale' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("rescale", "(JJJ)J", "")]
		public static unsafe long Rescale (long a, long b, long c)
		{
			const string __id = "rescale.(JJJ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (a);
				__args [1] = new JniArgumentValue (b);
				__args [2] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
