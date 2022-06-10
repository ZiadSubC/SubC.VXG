using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Rtp {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/rtp/MPEG2TSWriter", DoNotGenerateAcw=true)]
	public partial class MPEG2TSWriter : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='PTSaheadOfPCRus']"
		[Register ("PTSaheadOfPCRus")]
		public long PTSaheadOfPCRus {
			get {
				const string __id = "PTSaheadOfPCRus.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "PTSaheadOfPCRus.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "MPEG2TSWriter";


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mContinuityCounter']"
		[Register ("mContinuityCounter")]
		public sbyte MContinuityCounter {
			get {
				const string __id = "mContinuityCounter.B";

				var __v = _members.InstanceFields.GetSByteValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mContinuityCounter.B";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mCrcTable']"
		[Register ("mCrcTable")]
		public IList<int> MCrcTable {
			get {
				const string __id = "mCrcTable.[I";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCrcTable.[I";

				IntPtr native_value = global::Android.Runtime.JavaArray<int>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mH264AccessUnitDelimiter']"
		[Register ("mH264AccessUnitDelimiter")]
		public IList<byte> MH264AccessUnitDelimiter {
			get {
				const string __id = "mH264AccessUnitDelimiter.[B";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mH264AccessUnitDelimiter.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mMpegtsBAOS']"
		[Register ("mMpegtsBAOS")]
		public global::Java.IO.ByteArrayOutputStream MMpegtsBAOS {
			get {
				const string __id = "mMpegtsBAOS.Ljava/io/ByteArrayOutputStream;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.IO.ByteArrayOutputStream> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMpegtsBAOS.Ljava/io/ByteArrayOutputStream;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mNumTSPacketsBeforeMeta']"
		[Register ("mNumTSPacketsBeforeMeta")]
		public long MNumTSPacketsBeforeMeta {
			get {
				const string __id = "mNumTSPacketsBeforeMeta.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mNumTSPacketsBeforeMeta.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mNumTSPacketsWritten']"
		[Register ("mNumTSPacketsWritten")]
		public long MNumTSPacketsWritten {
			get {
				const string __id = "mNumTSPacketsWritten.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mNumTSPacketsWritten.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mPATContinuityCounter']"
		[Register ("mPATContinuityCounter")]
		public sbyte MPATContinuityCounter {
			get {
				const string __id = "mPATContinuityCounter.B";

				var __v = _members.InstanceFields.GetSByteValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mPATContinuityCounter.B";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mPMTContinuityCounter']"
		[Register ("mPMTContinuityCounter")]
		public sbyte MPMTContinuityCounter {
			get {
				const string __id = "mPMTContinuityCounter.B";

				var __v = _members.InstanceFields.GetSByteValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mPMTContinuityCounter.B";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mTimeStamp']"
		[Register ("mTimeStamp")]
		public long MTimeStamp {
			get {
				const string __id = "mTimeStamp.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTimeStamp.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/field[@name='mTimeStampIncr']"
		[Register ("mTimeStampIncr")]
		public long MTimeStampIncr {
			get {
				const string __id = "mTimeStampIncr.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTimeStampIncr.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/rtp/MPEG2TSWriter", typeof (MPEG2TSWriter));

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

		protected MPEG2TSWriter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/constructor[@name='MPEG2TSWriter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MPEG2TSWriter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_crc32_arrayBII;
#pragma warning disable 0169
		static Delegate GetCrc32_arrayBIIHandler ()
		{
			if (cb_crc32_arrayBII == null)
				cb_crc32_arrayBII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_L) n_Crc32_arrayBII);
			return cb_crc32_arrayBII;
		}

		static IntPtr n_Crc32_arrayBII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, int offset, int length)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = (byte[]) JNIEnv.GetArray (native_data, JniHandleOwnership.DoNotTransfer, typeof (byte));
			IntPtr __ret = JNIEnv.NewArray (__this.Crc32 (data, offset, length));
			if (data != null)
				JNIEnv.CopyArray (data, native_data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='crc32' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("crc32", "([BII)[B", "GetCrc32_arrayBIIHandler")]
		public virtual unsafe byte[] Crc32 (byte[] data, int offset, int length)
		{
			const string __id = "crc32.([BII)[B";
			IntPtr native_data = JNIEnv.NewArray (data);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_data);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (byte[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (data != null) {
					JNIEnv.CopyArray (native_data, data);
					JNIEnv.DeleteLocalRef (native_data);
				}
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_initCrcTable;
#pragma warning disable 0169
		static Delegate GetInitCrcTableHandler ()
		{
			if (cb_initCrcTable == null)
				cb_initCrcTable = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitCrcTable);
			return cb_initCrcTable;
		}

		static void n_InitCrcTable (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitCrcTable ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='initCrcTable' and count(parameter)=0]"
		[Register ("initCrcTable", "()V", "GetInitCrcTableHandler")]
		public virtual unsafe void InitCrcTable ()
		{
			const string __id = "initCrcTable.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_input_arrayBIIJ;
#pragma warning disable 0169
		static Delegate GetInput_arrayBIIJHandler ()
		{
			if (cb_input_arrayBIIJ == null)
				cb_input_arrayBIIJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIIJ_V) n_Input_arrayBIIJ);
			return cb_input_arrayBIIJ;
		}

		static void n_Input_arrayBIIJ (IntPtr jnienv, IntPtr native__this, IntPtr native_h264nalu, int offset, int length, long rtpTimestamp)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var h264nalu = (byte[]) JNIEnv.GetArray (native_h264nalu, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Input (h264nalu, offset, length, rtpTimestamp);
			if (h264nalu != null)
				JNIEnv.CopyArray (h264nalu, native_h264nalu);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='input' and count(parameter)=4 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("input", "([BIIJ)V", "GetInput_arrayBIIJHandler")]
		public virtual unsafe void Input (byte[] h264nalu, int offset, int length, long rtpTimestamp)
		{
			const string __id = "input.([BIIJ)V";
			IntPtr native_h264nalu = JNIEnv.NewArray (h264nalu);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_h264nalu);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				__args [3] = new JniArgumentValue (rtpTimestamp);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (h264nalu != null) {
					JNIEnv.CopyArray (native_h264nalu, h264nalu);
					JNIEnv.DeleteLocalRef (native_h264nalu);
				}
				global::System.GC.KeepAlive (h264nalu);
			}
		}

		static Delegate cb_output_arrayB;
#pragma warning disable 0169
		static Delegate GetOutput_arrayBHandler ()
		{
			if (cb_output_arrayB == null)
				cb_output_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Output_arrayB);
			return cb_output_arrayB;
		}

		static void n_Output_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_mpegtsunit)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var mpegtsunit = (byte[]) JNIEnv.GetArray (native_mpegtsunit, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.Output (mpegtsunit);
			if (mpegtsunit != null)
				JNIEnv.CopyArray (mpegtsunit, native_mpegtsunit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='output' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("output", "([B)V", "GetOutput_arrayBHandler")]
		public virtual unsafe void Output (byte[] mpegtsunit)
		{
			const string __id = "output.([B)V";
			IntPtr native_mpegtsunit = JNIEnv.NewArray (mpegtsunit);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_mpegtsunit);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (mpegtsunit != null) {
					JNIEnv.CopyArray (native_mpegtsunit, mpegtsunit);
					JNIEnv.DeleteLocalRef (native_mpegtsunit);
				}
				global::System.GC.KeepAlive (mpegtsunit);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeAccessUnit_arrayBJ;
#pragma warning disable 0169
		static Delegate GetWriteAccessUnit_arrayBJHandler ()
		{
			if (cb_writeAccessUnit_arrayBJ == null)
				cb_writeAccessUnit_arrayBJ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLJ_V) n_WriteAccessUnit_arrayBJ);
			return cb_writeAccessUnit_arrayBJ;
		}

		static void n_WriteAccessUnit_arrayBJ (IntPtr jnienv, IntPtr native__this, IntPtr native_accessUnit, long timeUs)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var accessUnit = (byte[]) JNIEnv.GetArray (native_accessUnit, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.WriteAccessUnit (accessUnit, timeUs);
			if (accessUnit != null)
				JNIEnv.CopyArray (accessUnit, native_accessUnit);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='writeAccessUnit' and count(parameter)=2 and parameter[1][@type='byte[]'] and parameter[2][@type='long']]"
		[Register ("writeAccessUnit", "([BJ)V", "GetWriteAccessUnit_arrayBJHandler")]
		public virtual unsafe void WriteAccessUnit (byte[] accessUnit, long timeUs)
		{
			const string __id = "writeAccessUnit.([BJ)V";
			IntPtr native_accessUnit = JNIEnv.NewArray (accessUnit);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_accessUnit);
				__args [1] = new JniArgumentValue (timeUs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (accessUnit != null) {
					JNIEnv.CopyArray (native_accessUnit, accessUnit);
					JNIEnv.DeleteLocalRef (native_accessUnit);
				}
				global::System.GC.KeepAlive (accessUnit);
			}
		}

		static Delegate cb_writePAT;
#pragma warning disable 0169
		static Delegate GetWritePATHandler ()
		{
			if (cb_writePAT == null)
				cb_writePAT = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WritePAT);
			return cb_writePAT;
		}

		static void n_WritePAT (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WritePAT ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='writePAT' and count(parameter)=0]"
		[Register ("writePAT", "()V", "GetWritePATHandler")]
		public virtual unsafe void WritePAT ()
		{
			const string __id = "writePAT.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writePMT;
#pragma warning disable 0169
		static Delegate GetWritePMTHandler ()
		{
			if (cb_writePMT == null)
				cb_writePMT = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WritePMT);
			return cb_writePMT;
		}

		static void n_WritePMT (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WritePMT ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='writePMT' and count(parameter)=0]"
		[Register ("writePMT", "()V", "GetWritePMTHandler")]
		public virtual unsafe void WritePMT ()
		{
			const string __id = "writePMT.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_writeTS;
#pragma warning disable 0169
		static Delegate GetWriteTSHandler ()
		{
			if (cb_writeTS == null)
				cb_writeTS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_WriteTS);
			return cb_writeTS;
		}

		static void n_WriteTS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Rtp.MPEG2TSWriter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WriteTS ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.rtp']/class[@name='MPEG2TSWriter']/method[@name='writeTS' and count(parameter)=0]"
		[Register ("writeTS", "()V", "GetWriteTSHandler")]
		public virtual unsafe void WriteTS ()
		{
			const string __id = "writeTS.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
