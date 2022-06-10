using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVCodecContext", DoNotGenerateAcw=true)]
	public partial class AVCodecContext : global::AU.Notzed.Jjmpeg.AVObject {
		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AVCODEC_MAX_AUDIO_FRAME_SIZE']"
		[Register ("AVCODEC_MAX_AUDIO_FRAME_SIZE")]
		public const int AvcodecMaxAudioFrameSize = (int) 192000;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AVMEDIA_TYPE_ATTACHMENT']"
		[Register ("AVMEDIA_TYPE_ATTACHMENT")]
		public const int AvmediaTypeAttachment = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AVMEDIA_TYPE_AUDIO']"
		[Register ("AVMEDIA_TYPE_AUDIO")]
		public const int AvmediaTypeAudio = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AVMEDIA_TYPE_DATA']"
		[Register ("AVMEDIA_TYPE_DATA")]
		public const int AvmediaTypeData = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AVMEDIA_TYPE_NB']"
		[Register ("AVMEDIA_TYPE_NB")]
		public const int AvmediaTypeNb = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AVMEDIA_TYPE_SUBTITLE']"
		[Register ("AVMEDIA_TYPE_SUBTITLE")]
		public const int AvmediaTypeSubtitle = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AVMEDIA_TYPE_UNKNOWN']"
		[Register ("AVMEDIA_TYPE_UNKNOWN")]
		public const int AvmediaTypeUnknown = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AVMEDIA_TYPE_VIDEO']"
		[Register ("AVMEDIA_TYPE_VIDEO")]
		public const int AvmediaTypeVideo = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AV_NOPTS_VALUE']"
		[Register ("AV_NOPTS_VALUE")]
		public const long AvNoptsValue = (long) -9223372036854775808;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='AV_TIME_BASE']"
		[Register ("AV_TIME_BASE")]
		public const long AvTimeBase = (long) 1000000;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_8X8DCT']"
		[Register ("CODEC_FLAG2_8X8DCT")]
		public const int CodecFlag28x8dct = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_AUD']"
		[Register ("CODEC_FLAG2_AUD")]
		public const int CodecFlag2Aud = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_BIT_RESERVOIR']"
		[Register ("CODEC_FLAG2_BIT_RESERVOIR")]
		public const int CodecFlag2BitReservoir = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_BPYRAMID']"
		[Register ("CODEC_FLAG2_BPYRAMID")]
		public const int CodecFlag2Bpyramid = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_BRDO']"
		[Register ("CODEC_FLAG2_BRDO")]
		public const int CodecFlag2Brdo = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_CHUNKS']"
		[Register ("CODEC_FLAG2_CHUNKS")]
		public const int CodecFlag2Chunks = (int) 32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_DROP_FRAME_TIMECODE']"
		[Register ("CODEC_FLAG2_DROP_FRAME_TIMECODE")]
		public const int CodecFlag2DropFrameTimecode = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_FAST']"
		[Register ("CODEC_FLAG2_FAST")]
		public const int CodecFlag2Fast = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_FASTPSKIP']"
		[Register ("CODEC_FLAG2_FASTPSKIP")]
		public const int CodecFlag2Fastpskip = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_INTRA_REFRESH']"
		[Register ("CODEC_FLAG2_INTRA_REFRESH")]
		public const int CodecFlag2IntraRefresh = (int) 2097152;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_INTRA_VLC']"
		[Register ("CODEC_FLAG2_INTRA_VLC")]
		public const int CodecFlag2IntraVlc = (int) 2048;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_LOCAL_HEADER']"
		[Register ("CODEC_FLAG2_LOCAL_HEADER")]
		public const int CodecFlag2LocalHeader = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_MBTREE']"
		[Register ("CODEC_FLAG2_MBTREE")]
		public const int CodecFlag2Mbtree = (int) 262144;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_MEMC_ONLY']"
		[Register ("CODEC_FLAG2_MEMC_ONLY")]
		public const int CodecFlag2MemcOnly = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_MIXED_REFS']"
		[Register ("CODEC_FLAG2_MIXED_REFS")]
		public const int CodecFlag2MixedRefs = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_NON_LINEAR_QUANT']"
		[Register ("CODEC_FLAG2_NON_LINEAR_QUANT")]
		public const int CodecFlag2NonLinearQuant = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_NO_OUTPUT']"
		[Register ("CODEC_FLAG2_NO_OUTPUT")]
		public const int CodecFlag2NoOutput = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_PSY']"
		[Register ("CODEC_FLAG2_PSY")]
		public const int CodecFlag2Psy = (int) 524288;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_SKIP_RD']"
		[Register ("CODEC_FLAG2_SKIP_RD")]
		public const int CodecFlag2SkipRd = (int) 16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_SSIM']"
		[Register ("CODEC_FLAG2_SSIM")]
		public const int CodecFlag2Ssim = (int) 1048576;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_STRICT_GOP']"
		[Register ("CODEC_FLAG2_STRICT_GOP")]
		public const int CodecFlag2StrictGop = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG2_WPRED']"
		[Register ("CODEC_FLAG2_WPRED")]
		public const int CodecFlag2Wpred = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_4MV']"
		[Register ("CODEC_FLAG_4MV")]
		public const int CodecFlag4mv = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_AC_PRED']"
		[Register ("CODEC_FLAG_AC_PRED")]
		public const int CodecFlagAcPred = (int) 16777216;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_ALT_SCAN']"
		[Register ("CODEC_FLAG_ALT_SCAN")]
		public const int CodecFlagAltScan = (int) 1048576;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_BITEXACT']"
		[Register ("CODEC_FLAG_BITEXACT")]
		public const int CodecFlagBitexact = (int) 8388608;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_CBP_RD']"
		[Register ("CODEC_FLAG_CBP_RD")]
		public const int CodecFlagCbpRd = (int) 67108864;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_CLOSED_GOP']"
		[Register ("CODEC_FLAG_CLOSED_GOP")]
		public const int CodecFlagClosedGop = (int) -2147483648;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_EMU_EDGE']"
		[Register ("CODEC_FLAG_EMU_EDGE")]
		public const int CodecFlagEmuEdge = (int) 16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_EXTERN_HUFF']"
		[Register ("CODEC_FLAG_EXTERN_HUFF")]
		public const int CodecFlagExternHuff = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_GLOBAL_HEADER']"
		[Register ("CODEC_FLAG_GLOBAL_HEADER")]
		public const int CodecFlagGlobalHeader = (int) 4194304;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_GMC']"
		[Register ("CODEC_FLAG_GMC")]
		public const int CodecFlagGmc = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_GRAY']"
		[Register ("CODEC_FLAG_GRAY")]
		public const int CodecFlagGray = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_H263P_AIV']"
		[Register ("CODEC_FLAG_H263P_AIV")]
		public const int CodecFlagH263pAiv = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_H263P_SLICE_STRUCT']"
		[Register ("CODEC_FLAG_H263P_SLICE_STRUCT")]
		public const int CodecFlagH263pSliceStruct = (int) 268435456;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_H263P_UMV']"
		[Register ("CODEC_FLAG_H263P_UMV")]
		public const int CodecFlagH263pUmv = (int) 33554432;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_INPUT_PRESERVED']"
		[Register ("CODEC_FLAG_INPUT_PRESERVED")]
		public const int CodecFlagInputPreserved = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_INTERLACED_DCT']"
		[Register ("CODEC_FLAG_INTERLACED_DCT")]
		public const int CodecFlagInterlacedDct = (int) 262144;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_INTERLACED_ME']"
		[Register ("CODEC_FLAG_INTERLACED_ME")]
		public const int CodecFlagInterlacedMe = (int) 536870912;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_LOOP_FILTER']"
		[Register ("CODEC_FLAG_LOOP_FILTER")]
		public const int CodecFlagLoopFilter = (int) 2048;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_LOW_DELAY']"
		[Register ("CODEC_FLAG_LOW_DELAY")]
		public const int CodecFlagLowDelay = (int) 524288;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_MV0']"
		[Register ("CODEC_FLAG_MV0")]
		public const int CodecFlagMv0 = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_NORMALIZE_AQP']"
		[Register ("CODEC_FLAG_NORMALIZE_AQP")]
		public const int CodecFlagNormalizeAqp = (int) 131072;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_OBMC']"
		[Register ("CODEC_FLAG_OBMC")]
		public const int CodecFlagObmc = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_PART']"
		[Register ("CODEC_FLAG_PART")]
		public const int CodecFlagPart = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_PASS1']"
		[Register ("CODEC_FLAG_PASS1")]
		public const int CodecFlagPass1 = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_PASS2']"
		[Register ("CODEC_FLAG_PASS2")]
		public const int CodecFlagPass2 = (int) 1024;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_PSNR']"
		[Register ("CODEC_FLAG_PSNR")]
		public const int CodecFlagPsnr = (int) 32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_QPEL']"
		[Register ("CODEC_FLAG_QPEL")]
		public const int CodecFlagQpel = (int) 16;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_QP_RD']"
		[Register ("CODEC_FLAG_QP_RD")]
		public const int CodecFlagQpRd = (int) 134217728;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_QSCALE']"
		[Register ("CODEC_FLAG_QSCALE")]
		public const int CodecFlagQscale = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='CODEC_FLAG_SVCD_SCAN_OFFSET']"
		[Register ("CODEC_FLAG_SVCD_SCAN_OFFSET")]
		public const int CodecFlagSvcdScanOffset = (int) 1073741824;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='FF_MB_DECISION_BITS']"
		[Register ("FF_MB_DECISION_BITS")]
		public const int FfMbDecisionBits = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='FF_MB_DECISION_RD']"
		[Register ("FF_MB_DECISION_RD")]
		public const int FfMbDecisionRd = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='FF_MB_DECISION_SIMPLE']"
		[Register ("FF_MB_DECISION_SIMPLE")]
		public const int FfMbDecisionSimple = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/field[@name='FF_MIN_BUFFER_SIZE']"
		[Register ("FF_MIN_BUFFER_SIZE")]
		public const int FfMinBufferSize = (int) 16384;

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVCodecContext", typeof (AVCodecContext));

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

		protected AVCodecContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/constructor[@name='AVCodecContext' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		protected unsafe AVCodecContext (int p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/constructor[@name='AVCodecContext' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		protected unsafe AVCodecContext (long p) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getBitRate;
#pragma warning disable 0169
		static Delegate GetGetBitRateHandler ()
		{
			if (cb_getBitRate == null)
				cb_getBitRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetBitRate);
			return cb_getBitRate;
		}

		static int n_GetBitRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitRate;
		}
#pragma warning restore 0169

		static Delegate cb_setBitRate_I;
#pragma warning disable 0169
		static Delegate GetSetBitRate_IHandler ()
		{
			if (cb_setBitRate_I == null)
				cb_setBitRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetBitRate_I);
			return cb_setBitRate_I;
		}

		static void n_SetBitRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BitRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int BitRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getBitRate' and count(parameter)=0]"
			[Register ("getBitRate", "()I", "GetGetBitRateHandler")]
			get {
				const string __id = "getBitRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setBitRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBitRate", "(I)V", "GetSetBitRate_IHandler")]
			set {
				const string __id = "setBitRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getChannelLayout;
#pragma warning disable 0169
		static Delegate GetGetChannelLayoutHandler ()
		{
			if (cb_getChannelLayout == null)
				cb_getChannelLayout = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetChannelLayout);
			return cb_getChannelLayout;
		}

		static long n_GetChannelLayout (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChannelLayout;
		}
#pragma warning restore 0169

		static Delegate cb_setChannelLayout_J;
#pragma warning disable 0169
		static Delegate GetSetChannelLayout_JHandler ()
		{
			if (cb_setChannelLayout_J == null)
				cb_setChannelLayout_J = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJ_V) n_SetChannelLayout_J);
			return cb_setChannelLayout_J;
		}

		static void n_SetChannelLayout_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ChannelLayout = p0;
		}
#pragma warning restore 0169

		public virtual unsafe long ChannelLayout {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getChannelLayout' and count(parameter)=0]"
			[Register ("getChannelLayout", "()J", "GetGetChannelLayoutHandler")]
			get {
				const string __id = "getChannelLayout.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setChannelLayout' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("setChannelLayout", "(J)V", "GetSetChannelLayout_JHandler")]
			set {
				const string __id = "setChannelLayout.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getChannels;
#pragma warning disable 0169
		static Delegate GetGetChannelsHandler ()
		{
			if (cb_getChannels == null)
				cb_getChannels = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetChannels);
			return cb_getChannels;
		}

		static int n_GetChannels (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Channels;
		}
#pragma warning restore 0169

		static Delegate cb_setChannels_I;
#pragma warning disable 0169
		static Delegate GetSetChannels_IHandler ()
		{
			if (cb_setChannels_I == null)
				cb_setChannels_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetChannels_I);
			return cb_setChannels_I;
		}

		static void n_SetChannels_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Channels = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Channels {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getChannels' and count(parameter)=0]"
			[Register ("getChannels", "()I", "GetGetChannelsHandler")]
			get {
				const string __id = "getChannels.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setChannels' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setChannels", "(I)V", "GetSetChannels_IHandler")]
			set {
				const string __id = "setChannels.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCodecID;
#pragma warning disable 0169
		static Delegate GetGetCodecIDHandler ()
		{
			if (cb_getCodecID == null)
				cb_getCodecID = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCodecID);
			return cb_getCodecID;
		}

		static int n_GetCodecID (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodecID;
		}
#pragma warning restore 0169

		static Delegate cb_setCodecID_I;
#pragma warning disable 0169
		static Delegate GetSetCodecID_IHandler ()
		{
			if (cb_setCodecID_I == null)
				cb_setCodecID_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCodecID_I);
			return cb_setCodecID_I;
		}

		static void n_SetCodecID_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CodecID = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CodecID {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getCodecID' and count(parameter)=0]"
			[Register ("getCodecID", "()I", "GetGetCodecIDHandler")]
			get {
				const string __id = "getCodecID.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setCodecID' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCodecID", "(I)V", "GetSetCodecID_IHandler")]
			set {
				const string __id = "setCodecID.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCodecType;
#pragma warning disable 0169
		static Delegate GetGetCodecTypeHandler ()
		{
			if (cb_getCodecType == null)
				cb_getCodecType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCodecType);
			return cb_getCodecType;
		}

		static int n_GetCodecType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodecType;
		}
#pragma warning restore 0169

		static Delegate cb_setCodecType_I;
#pragma warning disable 0169
		static Delegate GetSetCodecType_IHandler ()
		{
			if (cb_setCodecType_I == null)
				cb_setCodecType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCodecType_I);
			return cb_setCodecType_I;
		}

		static void n_SetCodecType_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CodecType = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CodecType {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getCodecType' and count(parameter)=0]"
			[Register ("getCodecType", "()I", "GetGetCodecTypeHandler")]
			get {
				const string __id = "getCodecType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setCodecType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCodecType", "(I)V", "GetSetCodecType_IHandler")]
			set {
				const string __id = "setCodecType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCodedFrame;
#pragma warning disable 0169
		static Delegate GetGetCodedFrameHandler ()
		{
			if (cb_getCodedFrame == null)
				cb_getCodedFrame = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCodedFrame);
			return cb_getCodedFrame;
		}

		static IntPtr n_GetCodedFrame (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CodedFrame);
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.AVFrame CodedFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getCodedFrame' and count(parameter)=0]"
			[Register ("getCodedFrame", "()Lau/notzed/jjmpeg/AVFrame;", "GetGetCodedFrameHandler")]
			get {
				const string __id = "getCodedFrame.()Lau/notzed/jjmpeg/AVFrame;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCodedHeight;
#pragma warning disable 0169
		static Delegate GetGetCodedHeightHandler ()
		{
			if (cb_getCodedHeight == null)
				cb_getCodedHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCodedHeight);
			return cb_getCodedHeight;
		}

		static int n_GetCodedHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodedHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setCodedHeight_I;
#pragma warning disable 0169
		static Delegate GetSetCodedHeight_IHandler ()
		{
			if (cb_setCodedHeight_I == null)
				cb_setCodedHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCodedHeight_I);
			return cb_setCodedHeight_I;
		}

		static void n_SetCodedHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CodedHeight = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CodedHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getCodedHeight' and count(parameter)=0]"
			[Register ("getCodedHeight", "()I", "GetGetCodedHeightHandler")]
			get {
				const string __id = "getCodedHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setCodedHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCodedHeight", "(I)V", "GetSetCodedHeight_IHandler")]
			set {
				const string __id = "setCodedHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCodedWidth;
#pragma warning disable 0169
		static Delegate GetGetCodedWidthHandler ()
		{
			if (cb_getCodedWidth == null)
				cb_getCodedWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCodedWidth);
			return cb_getCodedWidth;
		}

		static int n_GetCodedWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CodedWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setCodedWidth_I;
#pragma warning disable 0169
		static Delegate GetSetCodedWidth_IHandler ()
		{
			if (cb_setCodedWidth_I == null)
				cb_setCodedWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCodedWidth_I);
			return cb_setCodedWidth_I;
		}

		static void n_SetCodedWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CodedWidth = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int CodedWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getCodedWidth' and count(parameter)=0]"
			[Register ("getCodedWidth", "()I", "GetGetCodedWidthHandler")]
			get {
				const string __id = "getCodedWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setCodedWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCodedWidth", "(I)V", "GetSetCodedWidth_IHandler")]
			set {
				const string __id = "setCodedWidth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getErrorConcealment;
#pragma warning disable 0169
		static Delegate GetGetErrorConcealmentHandler ()
		{
			if (cb_getErrorConcealment == null)
				cb_getErrorConcealment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetErrorConcealment);
			return cb_getErrorConcealment;
		}

		static int n_GetErrorConcealment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ErrorConcealment;
		}
#pragma warning restore 0169

		static Delegate cb_setErrorConcealment_I;
#pragma warning disable 0169
		static Delegate GetSetErrorConcealment_IHandler ()
		{
			if (cb_setErrorConcealment_I == null)
				cb_setErrorConcealment_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetErrorConcealment_I);
			return cb_setErrorConcealment_I;
		}

		static void n_SetErrorConcealment_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ErrorConcealment = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ErrorConcealment {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getErrorConcealment' and count(parameter)=0]"
			[Register ("getErrorConcealment", "()I", "GetGetErrorConcealmentHandler")]
			get {
				const string __id = "getErrorConcealment.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setErrorConcealment' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setErrorConcealment", "(I)V", "GetSetErrorConcealment_IHandler")]
			set {
				const string __id = "setErrorConcealment.(I)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flags = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getFrameNumber;
#pragma warning disable 0169
		static Delegate GetGetFrameNumberHandler ()
		{
			if (cb_getFrameNumber == null)
				cb_getFrameNumber = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFrameNumber);
			return cb_getFrameNumber;
		}

		static int n_GetFrameNumber (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameNumber;
		}
#pragma warning restore 0169

		public virtual unsafe int FrameNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getFrameNumber' and count(parameter)=0]"
			[Register ("getFrameNumber", "()I", "GetGetFrameNumberHandler")]
			get {
				const string __id = "getFrameNumber.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFrameSize;
#pragma warning disable 0169
		static Delegate GetGetFrameSizeHandler ()
		{
			if (cb_getFrameSize == null)
				cb_getFrameSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetFrameSize);
			return cb_getFrameSize;
		}

		static int n_GetFrameSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameSize;
		}
#pragma warning restore 0169

		static Delegate cb_setFrameSize_I;
#pragma warning disable 0169
		static Delegate GetSetFrameSize_IHandler ()
		{
			if (cb_setFrameSize_I == null)
				cb_setFrameSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetFrameSize_I);
			return cb_setFrameSize_I;
		}

		static void n_SetFrameSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FrameSize = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int FrameSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getFrameSize' and count(parameter)=0]"
			[Register ("getFrameSize", "()I", "GetGetFrameSizeHandler")]
			get {
				const string __id = "getFrameSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setFrameSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFrameSize", "(I)V", "GetSetFrameSize_IHandler")]
			set {
				const string __id = "setFrameSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGOPSize;
#pragma warning disable 0169
		static Delegate GetGetGOPSizeHandler ()
		{
			if (cb_getGOPSize == null)
				cb_getGOPSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetGOPSize);
			return cb_getGOPSize;
		}

		static int n_GetGOPSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GOPSize;
		}
#pragma warning restore 0169

		static Delegate cb_setGOPSize_I;
#pragma warning disable 0169
		static Delegate GetSetGOPSize_IHandler ()
		{
			if (cb_setGOPSize_I == null)
				cb_setGOPSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetGOPSize_I);
			return cb_setGOPSize_I;
		}

		static void n_SetGOPSize_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GOPSize = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int GOPSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getGOPSize' and count(parameter)=0]"
			[Register ("getGOPSize", "()I", "GetGetGOPSizeHandler")]
			get {
				const string __id = "getGOPSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setGOPSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGOPSize", "(I)V", "GetSetGOPSize_IHandler")]
			set {
				const string __id = "setGOPSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		static Delegate cb_setHeight_I;
#pragma warning disable 0169
		static Delegate GetSetHeight_IHandler ()
		{
			if (cb_setHeight_I == null)
				cb_setHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetHeight_I);
			return cb_setHeight_I;
		}

		static void n_SetHeight_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Height = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "GetGetHeightHandler")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeight", "(I)V", "GetSetHeight_IHandler")]
			set {
				const string __id = "setHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIdctAlgo;
#pragma warning disable 0169
		static Delegate GetGetIdctAlgoHandler ()
		{
			if (cb_getIdctAlgo == null)
				cb_getIdctAlgo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetIdctAlgo);
			return cb_getIdctAlgo;
		}

		static int n_GetIdctAlgo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IdctAlgo;
		}
#pragma warning restore 0169

		static Delegate cb_setIdctAlgo_I;
#pragma warning disable 0169
		static Delegate GetSetIdctAlgo_IHandler ()
		{
			if (cb_setIdctAlgo_I == null)
				cb_setIdctAlgo_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetIdctAlgo_I);
			return cb_setIdctAlgo_I;
		}

		static void n_SetIdctAlgo_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IdctAlgo = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int IdctAlgo {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getIdctAlgo' and count(parameter)=0]"
			[Register ("getIdctAlgo", "()I", "GetGetIdctAlgoHandler")]
			get {
				const string __id = "getIdctAlgo.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setIdctAlgo' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIdctAlgo", "(I)V", "GetSetIdctAlgo_IHandler")]
			set {
				const string __id = "setIdctAlgo.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLowres;
#pragma warning disable 0169
		static Delegate GetGetLowresHandler ()
		{
			if (cb_getLowres == null)
				cb_getLowres = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLowres);
			return cb_getLowres;
		}

		static int n_GetLowres (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Lowres;
		}
#pragma warning restore 0169

		static Delegate cb_setLowres_I;
#pragma warning disable 0169
		static Delegate GetSetLowres_IHandler ()
		{
			if (cb_setLowres_I == null)
				cb_setLowres_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLowres_I);
			return cb_setLowres_I;
		}

		static void n_SetLowres_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Lowres = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Lowres {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getLowres' and count(parameter)=0]"
			[Register ("getLowres", "()I", "GetGetLowresHandler")]
			get {
				const string __id = "getLowres.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setLowres' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLowres", "(I)V", "GetSetLowres_IHandler")]
			set {
				const string __id = "setLowres.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxBFrames;
#pragma warning disable 0169
		static Delegate GetGetMaxBFramesHandler ()
		{
			if (cb_getMaxBFrames == null)
				cb_getMaxBFrames = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxBFrames);
			return cb_getMaxBFrames;
		}

		static int n_GetMaxBFrames (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxBFrames;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxBFrames_I;
#pragma warning disable 0169
		static Delegate GetSetMaxBFrames_IHandler ()
		{
			if (cb_setMaxBFrames_I == null)
				cb_setMaxBFrames_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxBFrames_I);
			return cb_setMaxBFrames_I;
		}

		static void n_SetMaxBFrames_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxBFrames = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MaxBFrames {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getMaxBFrames' and count(parameter)=0]"
			[Register ("getMaxBFrames", "()I", "GetGetMaxBFramesHandler")]
			get {
				const string __id = "getMaxBFrames.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setMaxBFrames' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaxBFrames", "(I)V", "GetSetMaxBFrames_IHandler")]
			set {
				const string __id = "setMaxBFrames.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMbDecision;
#pragma warning disable 0169
		static Delegate GetGetMbDecisionHandler ()
		{
			if (cb_getMbDecision == null)
				cb_getMbDecision = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMbDecision);
			return cb_getMbDecision;
		}

		static int n_GetMbDecision (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MbDecision;
		}
#pragma warning restore 0169

		static Delegate cb_setMbDecision_I;
#pragma warning disable 0169
		static Delegate GetSetMbDecision_IHandler ()
		{
			if (cb_setMbDecision_I == null)
				cb_setMbDecision_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMbDecision_I);
			return cb_setMbDecision_I;
		}

		static void n_SetMbDecision_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MbDecision = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int MbDecision {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getMbDecision' and count(parameter)=0]"
			[Register ("getMbDecision", "()I", "GetGetMbDecisionHandler")]
			get {
				const string __id = "getMbDecision.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setMbDecision' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMbDecision", "(I)V", "GetSetMbDecision_IHandler")]
			set {
				const string __id = "setMbDecision.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPixFmt;
#pragma warning disable 0169
		static Delegate GetGetPixFmtHandler ()
		{
			if (cb_getPixFmt == null)
				cb_getPixFmt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPixFmt);
			return cb_getPixFmt;
		}

		static IntPtr n_GetPixFmt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PixFmt);
		}
#pragma warning restore 0169

		static Delegate cb_setPixFmt_Lau_notzed_jjmpeg_PixelFormat_;
#pragma warning disable 0169
		static Delegate GetSetPixFmt_Lau_notzed_jjmpeg_PixelFormat_Handler ()
		{
			if (cb_setPixFmt_Lau_notzed_jjmpeg_PixelFormat_ == null)
				cb_setPixFmt_Lau_notzed_jjmpeg_PixelFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPixFmt_Lau_notzed_jjmpeg_PixelFormat_);
			return cb_setPixFmt_Lau_notzed_jjmpeg_PixelFormat_;
		}

		static void n_SetPixFmt_Lau_notzed_jjmpeg_PixelFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.PixelFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.PixFmt = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.PixelFormat PixFmt {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getPixFmt' and count(parameter)=0]"
			[Register ("getPixFmt", "()Lau/notzed/jjmpeg/PixelFormat;", "GetGetPixFmtHandler")]
			get {
				const string __id = "getPixFmt.()Lau/notzed/jjmpeg/PixelFormat;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.PixelFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setPixFmt' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.PixelFormat']]"
			[Register ("setPixFmt", "(Lau/notzed/jjmpeg/PixelFormat;)V", "GetSetPixFmt_Lau_notzed_jjmpeg_PixelFormat_Handler")]
			set {
				const string __id = "setPixFmt.(Lau/notzed/jjmpeg/PixelFormat;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getSampleFmt;
#pragma warning disable 0169
		static Delegate GetGetSampleFmtHandler ()
		{
			if (cb_getSampleFmt == null)
				cb_getSampleFmt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSampleFmt);
			return cb_getSampleFmt;
		}

		static IntPtr n_GetSampleFmt (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SampleFmt);
		}
#pragma warning restore 0169

		static Delegate cb_setSampleFmt_Lau_notzed_jjmpeg_SampleFormat_;
#pragma warning disable 0169
		static Delegate GetSetSampleFmt_Lau_notzed_jjmpeg_SampleFormat_Handler ()
		{
			if (cb_setSampleFmt_Lau_notzed_jjmpeg_SampleFormat_ == null)
				cb_setSampleFmt_Lau_notzed_jjmpeg_SampleFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSampleFmt_Lau_notzed_jjmpeg_SampleFormat_);
			return cb_setSampleFmt_Lau_notzed_jjmpeg_SampleFormat_;
		}

		static void n_SetSampleFmt_Lau_notzed_jjmpeg_SampleFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SampleFmt = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.SampleFormat SampleFmt {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getSampleFmt' and count(parameter)=0]"
			[Register ("getSampleFmt", "()Lau/notzed/jjmpeg/SampleFormat;", "GetGetSampleFmtHandler")]
			get {
				const string __id = "getSampleFmt.()Lau/notzed/jjmpeg/SampleFormat;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.SampleFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setSampleFmt' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.SampleFormat']]"
			[Register ("setSampleFmt", "(Lau/notzed/jjmpeg/SampleFormat;)V", "GetSetSampleFmt_Lau_notzed_jjmpeg_SampleFormat_Handler")]
			set {
				const string __id = "setSampleFmt.(Lau/notzed/jjmpeg/SampleFormat;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getSampleRate;
#pragma warning disable 0169
		static Delegate GetGetSampleRateHandler ()
		{
			if (cb_getSampleRate == null)
				cb_getSampleRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSampleRate);
			return cb_getSampleRate;
		}

		static int n_GetSampleRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SampleRate;
		}
#pragma warning restore 0169

		static Delegate cb_setSampleRate_I;
#pragma warning disable 0169
		static Delegate GetSetSampleRate_IHandler ()
		{
			if (cb_setSampleRate_I == null)
				cb_setSampleRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSampleRate_I);
			return cb_setSampleRate_I;
		}

		static void n_SetSampleRate_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SampleRate = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getSampleRate' and count(parameter)=0]"
			[Register ("getSampleRate", "()I", "GetGetSampleRateHandler")]
			get {
				const string __id = "getSampleRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setSampleRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSampleRate", "(I)V", "GetSetSampleRate_IHandler")]
			set {
				const string __id = "setSampleRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSkipFrame;
#pragma warning disable 0169
		static Delegate GetGetSkipFrameHandler ()
		{
			if (cb_getSkipFrame == null)
				cb_getSkipFrame = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSkipFrame);
			return cb_getSkipFrame;
		}

		static int n_GetSkipFrame (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipFrame;
		}
#pragma warning restore 0169

		static Delegate cb_setSkipFrame_I;
#pragma warning disable 0169
		static Delegate GetSetSkipFrame_IHandler ()
		{
			if (cb_setSkipFrame_I == null)
				cb_setSkipFrame_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSkipFrame_I);
			return cb_setSkipFrame_I;
		}

		static void n_SetSkipFrame_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipFrame = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int SkipFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getSkipFrame' and count(parameter)=0]"
			[Register ("getSkipFrame", "()I", "GetGetSkipFrameHandler")]
			get {
				const string __id = "getSkipFrame.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setSkipFrame' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSkipFrame", "(I)V", "GetSetSkipFrame_IHandler")]
			set {
				const string __id = "setSkipFrame.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStrictStdCompliance;
#pragma warning disable 0169
		static Delegate GetGetStrictStdComplianceHandler ()
		{
			if (cb_getStrictStdCompliance == null)
				cb_getStrictStdCompliance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStrictStdCompliance);
			return cb_getStrictStdCompliance;
		}

		static int n_GetStrictStdCompliance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StrictStdCompliance;
		}
#pragma warning restore 0169

		static Delegate cb_setStrictStdCompliance_I;
#pragma warning disable 0169
		static Delegate GetSetStrictStdCompliance_IHandler ()
		{
			if (cb_setStrictStdCompliance_I == null)
				cb_setStrictStdCompliance_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStrictStdCompliance_I);
			return cb_setStrictStdCompliance_I;
		}

		static void n_SetStrictStdCompliance_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StrictStdCompliance = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int StrictStdCompliance {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getStrictStdCompliance' and count(parameter)=0]"
			[Register ("getStrictStdCompliance", "()I", "GetGetStrictStdComplianceHandler")]
			get {
				const string __id = "getStrictStdCompliance.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setStrictStdCompliance' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStrictStdCompliance", "(I)V", "GetSetStrictStdCompliance_IHandler")]
			set {
				const string __id = "setStrictStdCompliance.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getThreadCount;
#pragma warning disable 0169
		static Delegate GetGetThreadCountHandler ()
		{
			if (cb_getThreadCount == null)
				cb_getThreadCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetThreadCount);
			return cb_getThreadCount;
		}

		static int n_GetThreadCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ThreadCount;
		}
#pragma warning restore 0169

		static Delegate cb_setThreadCount_I;
#pragma warning disable 0169
		static Delegate GetSetThreadCount_IHandler ()
		{
			if (cb_setThreadCount_I == null)
				cb_setThreadCount_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetThreadCount_I);
			return cb_setThreadCount_I;
		}

		static void n_SetThreadCount_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ThreadCount = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int ThreadCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getThreadCount' and count(parameter)=0]"
			[Register ("getThreadCount", "()I", "GetGetThreadCountHandler")]
			get {
				const string __id = "getThreadCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setThreadCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setThreadCount", "(I)V", "GetSetThreadCount_IHandler")]
			set {
				const string __id = "setThreadCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TimeBase);
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.AVRational TimeBase {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getTimeBase' and count(parameter)=0]"
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

		static Delegate cb_getTimeBaseDen;
#pragma warning disable 0169
		static Delegate GetGetTimeBaseDenHandler ()
		{
			if (cb_getTimeBaseDen == null)
				cb_getTimeBaseDen = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeBaseDen);
			return cb_getTimeBaseDen;
		}

		static int n_GetTimeBaseDen (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeBaseDen;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeBaseDen_I;
#pragma warning disable 0169
		static Delegate GetSetTimeBaseDen_IHandler ()
		{
			if (cb_setTimeBaseDen_I == null)
				cb_setTimeBaseDen_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeBaseDen_I);
			return cb_setTimeBaseDen_I;
		}

		static void n_SetTimeBaseDen_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimeBaseDen = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TimeBaseDen {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getTimeBaseDen' and count(parameter)=0]"
			[Register ("getTimeBaseDen", "()I", "GetGetTimeBaseDenHandler")]
			get {
				const string __id = "getTimeBaseDen.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setTimeBaseDen' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeBaseDen", "(I)V", "GetSetTimeBaseDen_IHandler")]
			set {
				const string __id = "setTimeBaseDen.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTimeBaseNum;
#pragma warning disable 0169
		static Delegate GetGetTimeBaseNumHandler ()
		{
			if (cb_getTimeBaseNum == null)
				cb_getTimeBaseNum = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTimeBaseNum);
			return cb_getTimeBaseNum;
		}

		static int n_GetTimeBaseNum (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TimeBaseNum;
		}
#pragma warning restore 0169

		static Delegate cb_setTimeBaseNum_I;
#pragma warning disable 0169
		static Delegate GetSetTimeBaseNum_IHandler ()
		{
			if (cb_setTimeBaseNum_I == null)
				cb_setTimeBaseNum_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeBaseNum_I);
			return cb_setTimeBaseNum_I;
		}

		static void n_SetTimeBaseNum_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TimeBaseNum = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int TimeBaseNum {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getTimeBaseNum' and count(parameter)=0]"
			[Register ("getTimeBaseNum", "()I", "GetGetTimeBaseNumHandler")]
			get {
				const string __id = "getTimeBaseNum.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setTimeBaseNum' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTimeBaseNum", "(I)V", "GetSetTimeBaseNum_IHandler")]
			set {
				const string __id = "setTimeBaseNum.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		static Delegate cb_setWidth_I;
#pragma warning disable 0169
		static Delegate GetSetWidth_IHandler ()
		{
			if (cb_setWidth_I == null)
				cb_setWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetWidth_I);
			return cb_setWidth_I;
		}

		static void n_SetWidth_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Width = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "GetGetWidthHandler")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWidth", "(I)V", "GetSetWidth_IHandler")]
			set {
				const string __id = "setWidth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_Close);
			return cb_close;
		}

		static int n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()I", "GetCloseHandler")]
		public virtual unsafe int Close ()
		{
			const string __id = "close.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='create' and count(parameter)=0]"
		[Register ("create", "()Lau/notzed/jjmpeg/AVCodecContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVCodecContext Create ()
		{
			const string __id = "create.()Lau/notzed/jjmpeg/AVCodecContext;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='create3' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVCodec']]"
		[Register ("create3", "(Lau/notzed/jjmpeg/AVCodec;)Lau/notzed/jjmpeg/AVCodecContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVCodecContext Create3 (global::AU.Notzed.Jjmpeg.AVCodec c)
		{
			const string __id = "create3.(Lau/notzed/jjmpeg/AVCodec;)Lau/notzed/jjmpeg/AVCodecContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_debug;
#pragma warning disable 0169
		static Delegate GetDebugHandler ()
		{
			if (cb_debug == null)
				cb_debug = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Debug);
			return cb_debug;
		}

		static void n_Debug (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Debug ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='debug' and count(parameter)=0]"
		[Register ("debug", "()V", "GetDebugHandler")]
		public virtual unsafe void Debug ()
		{
			const string __id = "debug.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_decodeAudio_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_;
#pragma warning disable 0169
		static Delegate GetDecodeAudio_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_Handler ()
		{
			if (cb_decodeAudio_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_ == null)
				cb_decodeAudio_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_DecodeAudio_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_);
			return cb_decodeAudio_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_;
		}

		static int n_DecodeAudio_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frame, IntPtr native_packet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var frame = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			var packet = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (native_packet, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DecodeAudio (frame, packet);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='decodeAudio' and count(parameter)=2 and parameter[1][@type='au.notzed.jjmpeg.AVFrame'] and parameter[2][@type='au.notzed.jjmpeg.AVPacket']]"
		[Register ("decodeAudio", "(Lau/notzed/jjmpeg/AVFrame;Lau/notzed/jjmpeg/AVPacket;)I", "GetDecodeAudio_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_Handler")]
		public virtual unsafe int DecodeAudio (global::AU.Notzed.Jjmpeg.AVFrame frame, global::AU.Notzed.Jjmpeg.AVPacket packet)
		{
			const string __id = "decodeAudio.(Lau/notzed/jjmpeg/AVFrame;Lau/notzed/jjmpeg/AVPacket;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				__args [1] = new JniArgumentValue ((packet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packet).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (frame);
				global::System.GC.KeepAlive (packet);
			}
		}

		static Delegate cb_decodeAudio_Lau_notzed_jjmpeg_AVSamples_Lau_notzed_jjmpeg_AVPacket_;
#pragma warning disable 0169
		static Delegate GetDecodeAudio_Lau_notzed_jjmpeg_AVSamples_Lau_notzed_jjmpeg_AVPacket_Handler ()
		{
			if (cb_decodeAudio_Lau_notzed_jjmpeg_AVSamples_Lau_notzed_jjmpeg_AVPacket_ == null)
				cb_decodeAudio_Lau_notzed_jjmpeg_AVSamples_Lau_notzed_jjmpeg_AVPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_DecodeAudio_Lau_notzed_jjmpeg_AVSamples_Lau_notzed_jjmpeg_AVPacket_);
			return cb_decodeAudio_Lau_notzed_jjmpeg_AVSamples_Lau_notzed_jjmpeg_AVPacket_;
		}

		static int n_DecodeAudio_Lau_notzed_jjmpeg_AVSamples_Lau_notzed_jjmpeg_AVPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_samples, IntPtr native_packet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var samples = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (native_samples, JniHandleOwnership.DoNotTransfer);
			var packet = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (native_packet, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.DecodeAudio (samples, packet);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='decodeAudio' and count(parameter)=2 and parameter[1][@type='au.notzed.jjmpeg.AVSamples'] and parameter[2][@type='au.notzed.jjmpeg.AVPacket']]"
		[Register ("decodeAudio", "(Lau/notzed/jjmpeg/AVSamples;Lau/notzed/jjmpeg/AVPacket;)I", "GetDecodeAudio_Lau_notzed_jjmpeg_AVSamples_Lau_notzed_jjmpeg_AVPacket_Handler")]
		public virtual unsafe int DecodeAudio (global::AU.Notzed.Jjmpeg.AVSamples samples, global::AU.Notzed.Jjmpeg.AVPacket packet)
		{
			const string __id = "decodeAudio.(Lau/notzed/jjmpeg/AVSamples;Lau/notzed/jjmpeg/AVPacket;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((samples == null) ? IntPtr.Zero : ((global::Java.Lang.Object) samples).Handle);
				__args [1] = new JniArgumentValue ((packet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packet).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (samples);
				global::System.GC.KeepAlive (packet);
			}
		}

		static Delegate cb_decodeVideo_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_;
#pragma warning disable 0169
		static Delegate GetDecodeVideo_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_Handler ()
		{
			if (cb_decodeVideo_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_ == null)
				cb_decodeVideo_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_DecodeVideo_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_);
			return cb_decodeVideo_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_;
		}

		static bool n_DecodeVideo_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_frame, IntPtr native_packet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var frame = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_frame, JniHandleOwnership.DoNotTransfer);
			var packet = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (native_packet, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.DecodeVideo (frame, packet);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='decodeVideo' and count(parameter)=2 and parameter[1][@type='au.notzed.jjmpeg.AVFrame'] and parameter[2][@type='au.notzed.jjmpeg.AVPacket']]"
		[Register ("decodeVideo", "(Lau/notzed/jjmpeg/AVFrame;Lau/notzed/jjmpeg/AVPacket;)Z", "GetDecodeVideo_Lau_notzed_jjmpeg_AVFrame_Lau_notzed_jjmpeg_AVPacket_Handler")]
		public virtual unsafe bool DecodeVideo (global::AU.Notzed.Jjmpeg.AVFrame frame, global::AU.Notzed.Jjmpeg.AVPacket packet)
		{
			const string __id = "decodeVideo.(Lau/notzed/jjmpeg/AVFrame;Lau/notzed/jjmpeg/AVPacket;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((frame == null) ? IntPtr.Zero : ((global::Java.Lang.Object) frame).Handle);
				__args [1] = new JniArgumentValue ((packet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packet).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (frame);
				global::System.GC.KeepAlive (packet);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_encodeAudio_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVSamples_;
#pragma warning disable 0169
		static Delegate GetEncodeAudio_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVSamples_Handler ()
		{
			if (cb_encodeAudio_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVSamples_ == null)
				cb_encodeAudio_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVSamples_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_EncodeAudio_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVSamples_);
			return cb_encodeAudio_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVSamples_;
		}

		static int n_EncodeAudio_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVSamples_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, IntPtr native_samples)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			var samples = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVSamples> (native_samples, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EncodeAudio (buf, samples);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='encodeAudio' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='au.notzed.jjmpeg.AVSamples']]"
		[Register ("encodeAudio", "(Ljava/nio/ByteBuffer;Lau/notzed/jjmpeg/AVSamples;)I", "GetEncodeAudio_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVSamples_Handler")]
		public virtual unsafe int EncodeAudio (global::Java.Nio.ByteBuffer buf, global::AU.Notzed.Jjmpeg.AVSamples samples)
		{
			const string __id = "encodeAudio.(Ljava/nio/ByteBuffer;Lau/notzed/jjmpeg/AVSamples;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				__args [1] = new JniArgumentValue ((samples == null) ? IntPtr.Zero : ((global::Java.Lang.Object) samples).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buf);
				global::System.GC.KeepAlive (samples);
			}
		}

		static Delegate cb_encodeAudio_Ljava_nio_ByteBuffer_ILjava_nio_ShortBuffer_;
#pragma warning disable 0169
		static Delegate GetEncodeAudio_Ljava_nio_ByteBuffer_ILjava_nio_ShortBuffer_Handler ()
		{
			if (cb_encodeAudio_Ljava_nio_ByteBuffer_ILjava_nio_ShortBuffer_ == null)
				cb_encodeAudio_Ljava_nio_ByteBuffer_ILjava_nio_ShortBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_I) n_EncodeAudio_Ljava_nio_ByteBuffer_ILjava_nio_ShortBuffer_);
			return cb_encodeAudio_Ljava_nio_ByteBuffer_ILjava_nio_ShortBuffer_;
		}

		static int n_EncodeAudio_Ljava_nio_ByteBuffer_ILjava_nio_ShortBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.ShortBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EncodeAudio (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='encodeAudio' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ShortBuffer']]"
		[Register ("encodeAudio", "(Ljava/nio/ByteBuffer;ILjava/nio/ShortBuffer;)I", "GetEncodeAudio_Ljava_nio_ByteBuffer_ILjava_nio_ShortBuffer_Handler")]
		public virtual unsafe int EncodeAudio (global::Java.Nio.ByteBuffer p0, int p1, global::Java.Nio.ShortBuffer p2)
		{
			const string __id = "encodeAudio.(Ljava/nio/ByteBuffer;ILjava/nio/ShortBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_encodeVideo_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVFrame_;
#pragma warning disable 0169
		static Delegate GetEncodeVideo_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVFrame_Handler ()
		{
			if (cb_encodeVideo_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVFrame_ == null)
				cb_encodeVideo_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_EncodeVideo_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVFrame_);
			return cb_encodeVideo_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVFrame_;
		}

		static int n_EncodeVideo_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_buf, IntPtr native_pict)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var buf = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_buf, JniHandleOwnership.DoNotTransfer);
			var pict = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_pict, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EncodeVideo (buf, pict);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='encodeVideo' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='au.notzed.jjmpeg.AVFrame']]"
		[Register ("encodeVideo", "(Ljava/nio/ByteBuffer;Lau/notzed/jjmpeg/AVFrame;)I", "GetEncodeVideo_Ljava_nio_ByteBuffer_Lau_notzed_jjmpeg_AVFrame_Handler")]
		public virtual unsafe int EncodeVideo (global::Java.Nio.ByteBuffer buf, global::AU.Notzed.Jjmpeg.AVFrame pict)
		{
			const string __id = "encodeVideo.(Ljava/nio/ByteBuffer;Lau/notzed/jjmpeg/AVFrame;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((buf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buf).Handle);
				__args [1] = new JniArgumentValue ((pict == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pict).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buf);
				global::System.GC.KeepAlive (pict);
			}
		}

		static Delegate cb_encodeVideo_Ljava_nio_ByteBuffer_ILau_notzed_jjmpeg_AVFrame_;
#pragma warning disable 0169
		static Delegate GetEncodeVideo_Ljava_nio_ByteBuffer_ILau_notzed_jjmpeg_AVFrame_Handler ()
		{
			if (cb_encodeVideo_Ljava_nio_ByteBuffer_ILau_notzed_jjmpeg_AVFrame_ == null)
				cb_encodeVideo_Ljava_nio_ByteBuffer_ILau_notzed_jjmpeg_AVFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_I) n_EncodeVideo_Ljava_nio_ByteBuffer_ILau_notzed_jjmpeg_AVFrame_);
			return cb_encodeVideo_Ljava_nio_ByteBuffer_ILau_notzed_jjmpeg_AVFrame_;
		}

		static int n_EncodeVideo_Ljava_nio_ByteBuffer_ILau_notzed_jjmpeg_AVFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, IntPtr native_p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFrame> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.EncodeVideo (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='encodeVideo' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='au.notzed.jjmpeg.AVFrame']]"
		[Register ("encodeVideo", "(Ljava/nio/ByteBuffer;ILau/notzed/jjmpeg/AVFrame;)I", "GetEncodeVideo_Ljava_nio_ByteBuffer_ILau_notzed_jjmpeg_AVFrame_Handler")]
		public virtual unsafe int EncodeVideo (global::Java.Nio.ByteBuffer p0, int p1, global::AU.Notzed.Jjmpeg.AVFrame p2)
		{
			const string __id = "encodeVideo.(Ljava/nio/ByteBuffer;ILau/notzed/jjmpeg/AVFrame;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p2);
			}
		}

		static Delegate cb_flushBuffers;
#pragma warning disable 0169
		static Delegate GetFlushBuffersHandler ()
		{
			if (cb_flushBuffers == null)
				cb_flushBuffers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FlushBuffers);
			return cb_flushBuffers;
		}

		static void n_FlushBuffers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FlushBuffers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='flushBuffers' and count(parameter)=0]"
		[Register ("flushBuffers", "()V", "GetFlushBuffersHandler")]
		public virtual unsafe void FlushBuffers ()
		{
			const string __id = "flushBuffers.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_open_Lau_notzed_jjmpeg_AVCodec_;
#pragma warning disable 0169
		static Delegate GetOpen_Lau_notzed_jjmpeg_AVCodec_Handler ()
		{
			if (cb_open_Lau_notzed_jjmpeg_AVCodec_ == null)
				cb_open_Lau_notzed_jjmpeg_AVCodec_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Open_Lau_notzed_jjmpeg_AVCodec_);
			return cb_open_Lau_notzed_jjmpeg_AVCodec_;
		}

		static void n_Open_Lau_notzed_jjmpeg_AVCodec_ (IntPtr jnienv, IntPtr native__this, IntPtr native_codec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var codec = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodec> (native_codec, JniHandleOwnership.DoNotTransfer);
			__this.Open (codec);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='open' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVCodec']]"
		[Register ("open", "(Lau/notzed/jjmpeg/AVCodec;)V", "GetOpen_Lau_notzed_jjmpeg_AVCodec_Handler")]
		public virtual unsafe void Open (global::AU.Notzed.Jjmpeg.AVCodec codec)
		{
			const string __id = "open.(Lau/notzed/jjmpeg/AVCodec;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((codec == null) ? IntPtr.Zero : ((global::Java.Lang.Object) codec).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (codec);
			}
		}

		static Delegate cb_setExtradata_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
		static Delegate GetSetExtradata_Ljava_nio_ByteBuffer_Handler ()
		{
			if (cb_setExtradata_Ljava_nio_ByteBuffer_ == null)
				cb_setExtradata_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetExtradata_Ljava_nio_ByteBuffer_);
			return cb_setExtradata_Ljava_nio_ByteBuffer_;
		}

		static void n_SetExtradata_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetExtradata (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContext']/method[@name='setExtradata' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("setExtradata", "(Ljava/nio/ByteBuffer;)V", "GetSetExtradata_Ljava_nio_ByteBuffer_Handler")]
		public virtual unsafe void SetExtradata (global::Java.Nio.ByteBuffer p0)
		{
			const string __id = "setExtradata.(Ljava/nio/ByteBuffer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContextAbstract']/method[@name='allocContext' and count(parameter)=0]"
		[Register ("allocContext", "()Lau/notzed/jjmpeg/AVCodecContext;", "")]
		protected static unsafe global::AU.Notzed.Jjmpeg.AVCodecContext AllocContext ()
		{
			const string __id = "allocContext.()Lau/notzed/jjmpeg/AVCodecContext;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVCodecContextAbstract']/method[@name='allocContext3' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVCodec']]"
		[Register ("allocContext3", "(Lau/notzed/jjmpeg/AVCodec;)Lau/notzed/jjmpeg/AVCodecContext;", "")]
		protected static unsafe global::AU.Notzed.Jjmpeg.AVCodecContext AllocContext3 (global::AU.Notzed.Jjmpeg.AVCodec c)
		{
			const string __id = "allocContext3.(Lau/notzed/jjmpeg/AVCodec;)Lau/notzed/jjmpeg/AVCodecContext;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodecContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

	}
}
