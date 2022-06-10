using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVPacket", DoNotGenerateAcw=true)]
	public partial class AVPacket : global::AU.Notzed.Jjmpeg.AVObject {
		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/field[@name='AV_PKT_FLAG_KEY']"
		[Register ("AV_PKT_FLAG_KEY")]
		public const int AvPktFlagKey = (int) 1;

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVPacket", typeof (AVPacket));

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

		protected AVPacket (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getDTS;
#pragma warning disable 0169
		static Delegate GetGetDTSHandler ()
		{
			if (cb_getDTS == null)
				cb_getDTS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetDTS);
			return cb_getDTS;
		}

		static long n_GetDTS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DTS;
		}
#pragma warning restore 0169

		static Delegate cb_setDTS_J;
#pragma warning disable 0169
		static Delegate GetSetDTS_JHandler ()
		{
			if (cb_setDTS_J == null)
				cb_setDTS_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetDTS_J);
			return cb_setDTS_J;
		}

		static void n_SetDTS_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DTS = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long DTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='getDTS' and count(parameter)=0]"
			[Register ("getDTS", "()J", "GetGetDTSHandler")]
			get {
				const string __id = "getDTS.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='setDTS' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setDTS", "(J)V", "GetSetDTS_JHandler")]
			set {
				const string __id = "setDTS.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFlags;
#pragma warning disable 0169
		static Delegate GetGetFlagsHandler ()
		{
			if (cb_getFlags == null)
				cb_getFlags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFlags);
			return cb_getFlags;
		}

		static int n_GetFlags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flags;
		}
#pragma warning restore 0169

		static Delegate cb_setFlags_I;
#pragma warning disable 0169
		static Delegate GetSetFlags_IHandler ()
		{
			if (cb_setFlags_I == null)
				cb_setFlags_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetFlags_I);
			return cb_setFlags_I;
		}

		static void n_SetFlags_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flags = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFlags", "(I)V", "GetSetFlags_IHandler")]
			set {
				const string __id = "setFlags.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPTS;
#pragma warning disable 0169
		static Delegate GetGetPTSHandler ()
		{
			if (cb_getPTS == null)
				cb_getPTS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPTS);
			return cb_getPTS;
		}

		static long n_GetPTS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PTS;
		}
#pragma warning restore 0169

		static Delegate cb_setPTS_J;
#pragma warning disable 0169
		static Delegate GetSetPTS_JHandler ()
		{
			if (cb_setPTS_J == null)
				cb_setPTS_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetPTS_J);
			return cb_setPTS_J;
		}

		static void n_SetPTS_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PTS = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long PTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='getPTS' and count(parameter)=0]"
			[Register ("getPTS", "()J", "GetGetPTSHandler")]
			get {
				const string __id = "getPTS.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='setPTS' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setPTS", "(J)V", "GetSetPTS_JHandler")]
			set {
				const string __id = "setPTS.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPos;
#pragma warning disable 0169
		static Delegate GetGetPosHandler ()
		{
			if (cb_getPos == null)
				cb_getPos = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetPos);
			return cb_getPos;
		}

		static long n_GetPos (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Pos;
		}
#pragma warning restore 0169

		public virtual unsafe long Pos {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='getPos' and count(parameter)=0]"
			[Register ("getPos", "()J", "GetGetPosHandler")]
			get {
				const string __id = "getPos.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSize);
			return cb_getSize;
		}

		static int n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		public virtual unsafe int Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()I", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStreamIndex;
#pragma warning disable 0169
		static Delegate GetGetStreamIndexHandler ()
		{
			if (cb_getStreamIndex == null)
				cb_getStreamIndex = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStreamIndex);
			return cb_getStreamIndex;
		}

		static int n_GetStreamIndex (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StreamIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setStreamIndex_I;
#pragma warning disable 0169
		static Delegate GetSetStreamIndex_IHandler ()
		{
			if (cb_setStreamIndex_I == null)
				cb_setStreamIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStreamIndex_I);
			return cb_setStreamIndex_I;
		}

		static void n_SetStreamIndex_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StreamIndex = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int StreamIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='getStreamIndex' and count(parameter)=0]"
			[Register ("getStreamIndex", "()I", "GetGetStreamIndexHandler")]
			get {
				const string __id = "getStreamIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='setStreamIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStreamIndex", "(I)V", "GetSetStreamIndex_IHandler")]
			set {
				const string __id = "setStreamIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_consume_I;
#pragma warning disable 0169
		static Delegate GetConsume_IHandler ()
		{
			if (cb_consume_I == null)
				cb_consume_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_Consume_I);
			return cb_consume_I;
		}

		static int n_Consume_I (IntPtr jnienv, IntPtr native__this, int len)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Consume (len);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='consume' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("consume", "(I)I", "GetConsume_IHandler")]
		public virtual unsafe int Consume (int len)
		{
			const string __id = "consume.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (len);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lau/notzed/jjmpeg/AVPacket;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVPacket Create ()
		{
			const string __id = "create.()Lau/notzed/jjmpeg/AVPacket;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_dupPacket;
#pragma warning disable 0169
		static Delegate GetDupPacketHandler ()
		{
			if (cb_dupPacket == null)
				cb_dupPacket = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_DupPacket);
			return cb_dupPacket;
		}

		static int n_DupPacket (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DupPacket ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='dupPacket' and count(parameter)=0]"
		[Register ("dupPacket", "()I", "GetDupPacketHandler")]
		public virtual unsafe int DupPacket ()
		{
			const string __id = "dupPacket.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_freePacket;
#pragma warning disable 0169
		static Delegate GetFreePacketHandler ()
		{
			if (cb_freePacket == null)
				cb_freePacket = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FreePacket);
			return cb_freePacket;
		}

		static void n_FreePacket (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreePacket ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='freePacket' and count(parameter)=0]"
		[Register ("freePacket", "()V", "GetFreePacketHandler")]
		public virtual unsafe void FreePacket ()
		{
			const string __id = "freePacket.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_initPacket;
#pragma warning disable 0169
		static Delegate GetInitPacketHandler ()
		{
			if (cb_initPacket == null)
				cb_initPacket = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitPacket);
			return cb_initPacket;
		}

		static void n_InitPacket (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitPacket ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='initPacket' and count(parameter)=0]"
		[Register ("initPacket", "()V", "GetInitPacketHandler")]
		public virtual unsafe void InitPacket ()
		{
			const string __id = "initPacket.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setData_Ljava_nio_ByteBuffer_I;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_nio_ByteBuffer_IHandler ()
		{
			if (cb_setData_Ljava_nio_ByteBuffer_I == null)
				cb_setData_Ljava_nio_ByteBuffer_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_SetData_Ljava_nio_ByteBuffer_I);
			return cb_setData_Ljava_nio_ByteBuffer_I;
		}

		static void n_SetData_Ljava_nio_ByteBuffer_I (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (data, size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='setData' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("setData", "(Ljava/nio/ByteBuffer;I)V", "GetSetData_Ljava_nio_ByteBuffer_IHandler")]
		public virtual unsafe void SetData (global::Java.Nio.ByteBuffer data, int size)
		{
			const string __id = "setData.(Ljava/nio/ByteBuffer;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_setSrc_Lau_notzed_jjmpeg_AVPacket_;
#pragma warning disable 0169
		static Delegate GetSetSrc_Lau_notzed_jjmpeg_AVPacket_Handler ()
		{
			if (cb_setSrc_Lau_notzed_jjmpeg_AVPacket_ == null)
				cb_setSrc_Lau_notzed_jjmpeg_AVPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSrc_Lau_notzed_jjmpeg_AVPacket_);
			return cb_setSrc_Lau_notzed_jjmpeg_AVPacket_;
		}

		static void n_SetSrc_Lau_notzed_jjmpeg_AVPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_src)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var src = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (native_src, JniHandleOwnership.DoNotTransfer);
			__this.SetSrc (src);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVPacket']/method[@name='setSrc' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVPacket']]"
		[Register ("setSrc", "(Lau/notzed/jjmpeg/AVPacket;)V", "GetSetSrc_Lau_notzed_jjmpeg_AVPacket_Handler")]
		public virtual unsafe void SetSrc (global::AU.Notzed.Jjmpeg.AVPacket src)
		{
			const string __id = "setSrc.(Lau/notzed/jjmpeg/AVPacket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

	}
}
