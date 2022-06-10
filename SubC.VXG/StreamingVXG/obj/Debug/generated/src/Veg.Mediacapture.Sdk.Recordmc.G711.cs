using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Recordmc {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='G711']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/recordmc/G711", DoNotGenerateAcw=true)]
	public partial class G711 : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/recordmc/G711", typeof (G711));

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

		protected G711 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='G711']/constructor[@name='G711' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe G711 () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_alaw2linear_B;
#pragma warning disable 0169
		static Delegate GetAlaw2linear_BHandler ()
		{
			if (cb_alaw2linear_B == null)
				cb_alaw2linear_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_I) n_Alaw2linear_B);
			return cb_alaw2linear_B;
		}

		static int n_Alaw2linear_B (IntPtr jnienv, IntPtr native__this, sbyte a_val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.G711> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Alaw2linear (a_val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='G711']/method[@name='alaw2linear' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("alaw2linear", "(B)I", "GetAlaw2linear_BHandler")]
		public virtual unsafe int Alaw2linear (sbyte a_val)
		{
			const string __id = "alaw2linear.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (a_val);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_alaw2ulaw_B;
#pragma warning disable 0169
		static Delegate GetAlaw2ulaw_BHandler ()
		{
			if (cb_alaw2ulaw_B == null)
				cb_alaw2ulaw_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_B) n_Alaw2ulaw_B);
			return cb_alaw2ulaw_B;
		}

		static sbyte n_Alaw2ulaw_B (IntPtr jnienv, IntPtr native__this, sbyte aval)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.G711> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Alaw2ulaw (aval);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='G711']/method[@name='alaw2ulaw' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("alaw2ulaw", "(B)B", "GetAlaw2ulaw_BHandler")]
		public virtual unsafe sbyte Alaw2ulaw (sbyte aval)
		{
			const string __id = "alaw2ulaw.(B)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (aval);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_linear2alaw_I;
#pragma warning disable 0169
		static Delegate GetLinear2alaw_IHandler ()
		{
			if (cb_linear2alaw_I == null)
				cb_linear2alaw_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_B) n_Linear2alaw_I);
			return cb_linear2alaw_I;
		}

		static sbyte n_Linear2alaw_I (IntPtr jnienv, IntPtr native__this, int pcm_val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.G711> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Linear2alaw (pcm_val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='G711']/method[@name='linear2alaw' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("linear2alaw", "(I)B", "GetLinear2alaw_IHandler")]
		public virtual unsafe sbyte Linear2alaw (int pcm_val)
		{
			const string __id = "linear2alaw.(I)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pcm_val);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_linear2ulaw_I;
#pragma warning disable 0169
		static Delegate GetLinear2ulaw_IHandler ()
		{
			if (cb_linear2ulaw_I == null)
				cb_linear2ulaw_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_B) n_Linear2ulaw_I);
			return cb_linear2ulaw_I;
		}

		static sbyte n_Linear2ulaw_I (IntPtr jnienv, IntPtr native__this, int pcm_val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.G711> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Linear2ulaw (pcm_val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='G711']/method[@name='linear2ulaw' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("linear2ulaw", "(I)B", "GetLinear2ulaw_IHandler")]
		public virtual unsafe sbyte Linear2ulaw (int pcm_val)
		{
			const string __id = "linear2ulaw.(I)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (pcm_val);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ulaw2alaw_B;
#pragma warning disable 0169
		static Delegate GetUlaw2alaw_BHandler ()
		{
			if (cb_ulaw2alaw_B == null)
				cb_ulaw2alaw_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_B) n_Ulaw2alaw_B);
			return cb_ulaw2alaw_B;
		}

		static sbyte n_Ulaw2alaw_B (IntPtr jnienv, IntPtr native__this, sbyte uval)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.G711> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ulaw2alaw (uval);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='G711']/method[@name='ulaw2alaw' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("ulaw2alaw", "(B)B", "GetUlaw2alaw_BHandler")]
		public virtual unsafe sbyte Ulaw2alaw (sbyte uval)
		{
			const string __id = "ulaw2alaw.(B)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (uval);
				var __rm = _members.InstanceMethods.InvokeVirtualSByteMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_ulaw2linear_B;
#pragma warning disable 0169
		static Delegate GetUlaw2linear_BHandler ()
		{
			if (cb_ulaw2linear_B == null)
				cb_ulaw2linear_B = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPB_I) n_Ulaw2linear_B);
			return cb_ulaw2linear_B;
		}

		static int n_Ulaw2linear_B (IntPtr jnienv, IntPtr native__this, sbyte u_val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Recordmc.G711> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Ulaw2linear (u_val);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.recordmc']/class[@name='G711']/method[@name='ulaw2linear' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("ulaw2linear", "(B)I", "GetUlaw2linear_BHandler")]
		public virtual unsafe int Ulaw2linear (sbyte u_val)
		{
			const string __id = "ulaw2linear.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (u_val);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
