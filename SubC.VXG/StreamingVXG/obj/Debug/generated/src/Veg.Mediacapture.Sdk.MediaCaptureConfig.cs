using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig", DoNotGenerateAcw=true)]
	public partial class MediaCaptureConfig : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='AVCProfileBaseline']"
		[Register ("AVCProfileBaseline")]
		public const int AVCProfileBaseline = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='AVCProfileHigh']"
		[Register ("AVCProfileHigh")]
		public const int AVCProfileHigh = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='AVCProfileMain']"
		[Register ("AVCProfileMain")]
		public const int AVCProfileMain = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='AudioFormatMC']"
		[Register ("AudioFormatMC")]
		public IList<string> AudioFormatMC {
			get {
				const string __id = "AudioFormatMC.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "AudioFormatMC.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='BITRATE_MODE_ADAPTIVE']"
		[Register ("BITRATE_MODE_ADAPTIVE")]
		public const int BitrateModeAdaptive = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='BITRATE_MODE_CBR']"
		[Register ("BITRATE_MODE_CBR")]
		public const int BitrateModeCbr = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='BITRATE_MODE_CQ']"
		[Register ("BITRATE_MODE_CQ")]
		public const int BitrateModeCq = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='BITRATE_MODE_VBR']"
		[Register ("BITRATE_MODE_VBR")]
		public const int BitrateModeVbr = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='CAMERA_FACING_BACK']"
		[Register ("CAMERA_FACING_BACK")]
		public const int CameraFacingBack = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='CAMERA_FACING_FRONT']"
		[Register ("CAMERA_FACING_FRONT")]
		public const int CameraFacingFront = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='CAMERA_FILTER_CUSTOM_FRAGMENT_SHADER']"
		[Register ("CAMERA_FILTER_CUSTOM_FRAGMENT_SHADER")]
		public const int CameraFilterCustomFragmentShader = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='CAMERA_FILTER_CUSTOM_VERTEX_SHADER']"
		[Register ("CAMERA_FILTER_CUSTOM_VERTEX_SHADER")]
		public const int CameraFilterCustomVertexShader = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='CAMERA_FILTER_FLIP_X']"
		[Register ("CAMERA_FILTER_FLIP_X")]
		public const int CameraFilterFlipX = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='CAMERA_FILTER_NONE']"
		[Register ("CAMERA_FILTER_NONE")]
		public const int CameraFilterNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='MAX_STREAMER_TYPES']"
		[Register ("MAX_STREAMER_TYPES")]
		public const int MaxStreamerTypes = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='MC_ORIENTATION_LANDSCAPE']"
		[Register ("MC_ORIENTATION_LANDSCAPE")]
		public const int McOrientationLandscape = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='MC_ORIENTATION_PORTRAIT']"
		[Register ("MC_ORIENTATION_PORTRAIT")]
		public const int McOrientationPortrait = (int) 90;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_AAC']"
		[Register ("TYPE_AUDIO_AAC")]
		public const string TypeAudioAac = (string) "audio/mp4a-latm";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_AC3']"
		[Register ("TYPE_AUDIO_AC3")]
		public const string TypeAudioAc3 = (string) "audio/ac3";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_AMR_N']"
		[Register ("TYPE_AUDIO_AMR_N")]
		public const string TypeAudioAmrN = (string) "audio/3gpp";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_AMR_WB']"
		[Register ("TYPE_AUDIO_AMR_WB")]
		public const string TypeAudioAmrWb = (string) "audio/amr-wb";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_EAC3']"
		[Register ("TYPE_AUDIO_EAC3")]
		public const string TypeAudioEac3 = (string) "audio/eac3";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_FLAC']"
		[Register ("TYPE_AUDIO_FLAC")]
		public const string TypeAudioFlac = (string) "audio/flac";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_G711_ALAW']"
		[Register ("TYPE_AUDIO_G711_ALAW")]
		public const string TypeAudioG711Alaw = (string) "audio/g711-alaw";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_G711_MLAW']"
		[Register ("TYPE_AUDIO_G711_MLAW")]
		public const string TypeAudioG711Mlaw = (string) "audio/g711-mlaw";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_MPEG']"
		[Register ("TYPE_AUDIO_MPEG")]
		public const string TypeAudioMpeg = (string) "audio/mpeg";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_MSGSM']"
		[Register ("TYPE_AUDIO_MSGSM")]
		public const string TypeAudioMsgsm = (string) "audio/gsm";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_OPUS']"
		[Register ("TYPE_AUDIO_OPUS")]
		public const string TypeAudioOpus = (string) "audio/opus";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_QCELP']"
		[Register ("TYPE_AUDIO_QCELP")]
		public const string TypeAudioQcelp = (string) "audio/qcelp";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_RAW']"
		[Register ("TYPE_AUDIO_RAW")]
		public const string TypeAudioRaw = (string) "audio/raw";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_AUDIO_VORBIS']"
		[Register ("TYPE_AUDIO_VORBIS")]
		public const string TypeAudioVorbis = (string) "audio/vorbis";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_TEXT_CEA_608']"
		[Register ("TYPE_TEXT_CEA_608")]
		public const string TypeTextCea608 = (string) "text/cea-608";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_TEXT_VTT']"
		[Register ("TYPE_TEXT_VTT")]
		public const string TypeTextVtt = (string) "text/vtt";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_VIDEO_AVC']"
		[Register ("TYPE_VIDEO_AVC")]
		public const string TypeVideoAvc = (string) "video/avc";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_VIDEO_H263']"
		[Register ("TYPE_VIDEO_H263")]
		public const string TypeVideoH263 = (string) "video/3gpp";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_VIDEO_HEVC']"
		[Register ("TYPE_VIDEO_HEVC")]
		public const string TypeVideoHevc = (string) "video/hevc";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_VIDEO_MPEG2']"
		[Register ("TYPE_VIDEO_MPEG2")]
		public const string TypeVideoMpeg2 = (string) "video/mpeg2";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_VIDEO_MPEG4']"
		[Register ("TYPE_VIDEO_MPEG4")]
		public const string TypeVideoMpeg4 = (string) "video/mp4v-es";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_VIDEO_RAW']"
		[Register ("TYPE_VIDEO_RAW")]
		public const string TypeVideoRaw = (string) "video/raw";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_VIDEO_VP8']"
		[Register ("TYPE_VIDEO_VP8")]
		public const string TypeVideoVp8 = (string) "video/x-vnd.on2.vp8";

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TYPE_VIDEO_VP9']"
		[Register ("TYPE_VIDEO_VP9")]
		public const string TypeVideoVp9 = (string) "video/x-vnd.on2.vp9";


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='TextFormatMC']"
		[Register ("TextFormatMC")]
		public IList<string> TextFormatMC {
			get {
				const string __id = "TextFormatMC.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "TextFormatMC.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='VideoFormatMC']"
		[Register ("VideoFormatMC")]
		public IList<string> VideoFormatMC {
			get {
				const string __id = "VideoFormatMC.[Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<string>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "VideoFormatMC.[Ljava/lang/String;";

				IntPtr native_value = global::Android.Runtime.JavaArray<string>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='videoCustomHeight']"
		[Register ("videoCustomHeight")]
		public int VideoCustomHeight {
			get {
				const string __id = "videoCustomHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "videoCustomHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/field[@name='videoCustomWidth']"
		[Register ("videoCustomWidth")]
		public int VideoCustomWidth {
			get {
				const string __id = "videoCustomWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "videoCustomWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CameraVideoPreviewMode']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode", DoNotGenerateAcw=true)]
		public sealed partial class CameraVideoPreviewMode : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CameraVideoPreviewMode']/field[@name='CVP_MODE_CUSTOM']"
			[Register ("CVP_MODE_CUSTOM")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode CvpModeCustom {
				get {
					const string __id = "CVP_MODE_CUSTOM.Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CameraVideoPreviewMode']/field[@name='CVP_MODE_DEVICE_PREFERRED']"
			[Register ("CVP_MODE_DEVICE_PREFERRED")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode CvpModeDevicePreferred {
				get {
					const string __id = "CVP_MODE_DEVICE_PREFERRED.Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CameraVideoPreviewMode']/field[@name='CVP_MODE_ENCODE_NEAREST']"
			[Register ("CVP_MODE_ENCODE_NEAREST")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode CvpModeEncodeNearest {
				get {
					const string __id = "CVP_MODE_ENCODE_NEAREST.Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode", typeof (CameraVideoPreviewMode));

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

			internal CameraVideoPreviewMode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CameraVideoPreviewMode']/method[@name='forValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forValue", "(I)Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode ForValue (int value)
			{
				const string __id = "forValue.(I)Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CameraVideoPreviewMode']/method[@name='val' and count(parameter)=0]"
			[Register ("val", "()I", "")]
			public unsafe int Val ()
			{
				const string __id = "val.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CameraVideoPreviewMode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CameraVideoPreviewMode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCaptureConfig$CameraVideoPreviewMode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CameraVideoPreviewMode));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureModes']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$CaptureModes", DoNotGenerateAcw=true)]
		public sealed partial class CaptureModes : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureModes']/field[@name='PP_MODE_ALL']"
			[Register ("PP_MODE_ALL")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes PpModeAll {
				get {
					const string __id = "PP_MODE_ALL.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureModes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureModes']/field[@name='PP_MODE_AUDIO']"
			[Register ("PP_MODE_AUDIO")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes PpModeAudio {
				get {
					const string __id = "PP_MODE_AUDIO.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureModes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureModes']/field[@name='PP_MODE_VIDEO']"
			[Register ("PP_MODE_VIDEO")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes PpModeVideo {
				get {
					const string __id = "PP_MODE_VIDEO.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureModes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$CaptureModes", typeof (CaptureModes));

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

			internal CaptureModes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureModes']/method[@name='val' and count(parameter)=0]"
			[Register ("val", "()I", "")]
			public unsafe int Val ()
			{
				const string __id = "val.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureModes']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureModes;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureModes;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureModes']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureModes;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureModes;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureModes));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$CaptureSources", DoNotGenerateAcw=true)]
		public sealed partial class CaptureSources : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/field[@name='PP_MODE_CAMERA']"
			[Register ("PP_MODE_CAMERA")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources PpModeCamera {
				get {
					const string __id = "PP_MODE_CAMERA.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/field[@name='PP_MODE_EXTERNAL']"
			[Register ("PP_MODE_EXTERNAL")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources PpModeExternal {
				get {
					const string __id = "PP_MODE_EXTERNAL.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/field[@name='PP_MODE_OFFSCREEN_SURFACE']"
			[Register ("PP_MODE_OFFSCREEN_SURFACE")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources PpModeOffscreenSurface {
				get {
					const string __id = "PP_MODE_OFFSCREEN_SURFACE.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/field[@name='PP_MODE_SURFACE']"
			[Register ("PP_MODE_SURFACE")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources PpModeSurface {
				get {
					const string __id = "PP_MODE_SURFACE.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/field[@name='PP_MODE_VIRTUAL_DISPLAY']"
			[Register ("PP_MODE_VIRTUAL_DISPLAY")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources PpModeVirtualDisplay {
				get {
					const string __id = "PP_MODE_VIRTUAL_DISPLAY.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$CaptureSources", typeof (CaptureSources));

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

			internal CaptureSources (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/method[@name='forValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forValue", "(I)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources ForValue (int value)
			{
				const string __id = "forValue.(I)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/method[@name='val' and count(parameter)=0]"
			[Register ("val", "()I", "")]
			public unsafe int Val ()
			{
				const string __id = "val.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureSources']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureSources;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureSources));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureTransType']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType", DoNotGenerateAcw=true)]
		public sealed partial class CaptureTransType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureTransType']/field[@name='VT_HW_DEC']"
			[Register ("VT_HW_DEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType VtHwDec {
				get {
					const string __id = "VT_HW_DEC.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureTransType']/field[@name='VT_RND_WND']"
			[Register ("VT_RND_WND")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType VtRndWnd {
				get {
					const string __id = "VT_RND_WND.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType", typeof (CaptureTransType));

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

			internal CaptureTransType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureTransType']/method[@name='forType' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.CaptureTransType']]"
			[Register ("forType", "(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;)I", "")]
			public static unsafe int ForType (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType type)
			{
				const string __id = "forType.(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (type);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureTransType']/method[@name='forValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forValue", "(I)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType ForValue (int value)
			{
				const string __id = "forValue.(I)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureTransType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureTransType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution", DoNotGenerateAcw=true)]
		public sealed partial class CaptureVideoResolution : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_1280x720']"
			[Register ("VR_1280x720")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR1280x720 {
				get {
					const string __id = "VR_1280x720.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_176x144']"
			[Register ("VR_176x144")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR176x144 {
				get {
					const string __id = "VR_176x144.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_1920x1080']"
			[Register ("VR_1920x1080")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR1920x1080 {
				get {
					const string __id = "VR_1920x1080.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_1920x1200']"
			[Register ("VR_1920x1200")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR1920x1200 {
				get {
					const string __id = "VR_1920x1200.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_320x240']"
			[Register ("VR_320x240")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR320x240 {
				get {
					const string __id = "VR_320x240.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_352x288']"
			[Register ("VR_352x288")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR352x288 {
				get {
					const string __id = "VR_352x288.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_3840x2160']"
			[Register ("VR_3840x2160")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR3840x2160 {
				get {
					const string __id = "VR_3840x2160.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_4096x2160']"
			[Register ("VR_4096x2160")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR4096x2160 {
				get {
					const string __id = "VR_4096x2160.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_640x360']"
			[Register ("VR_640x360")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR640x360 {
				get {
					const string __id = "VR_640x360.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_640x480']"
			[Register ("VR_640x480")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR640x480 {
				get {
					const string __id = "VR_640x480.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_720x405']"
			[Register ("VR_720x405")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR720x405 {
				get {
					const string __id = "VR_720x405.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_720x480']"
			[Register ("VR_720x480")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR720x480 {
				get {
					const string __id = "VR_720x480.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_720x576']"
			[Register ("VR_720x576")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR720x576 {
				get {
					const string __id = "VR_720x576.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_864x486']"
			[Register ("VR_864x486")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR864x486 {
				get {
					const string __id = "VR_864x486.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_960x540']"
			[Register ("VR_960x540")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VR960x540 {
				get {
					const string __id = "VR_960x540.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/field[@name='VR_CUSTOM']"
			[Register ("VR_CUSTOM")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VrCustom {
				get {
					const string __id = "VR_CUSTOM.Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution", typeof (CaptureVideoResolution));

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

			internal CaptureVideoResolution (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/method[@name='forType' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.CaptureVideoResolution']]"
			[Register ("forType", "(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)I", "")]
			public static unsafe int ForType (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution type)
			{
				const string __id = "forType.(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (type);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/method[@name='forValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forValue", "(I)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution ForValue (int value)
			{
				const string __id = "forValue.(I)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.CaptureVideoResolution']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.Overlay']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$Overlay", DoNotGenerateAcw=true)]
		public partial class Overlay : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$Overlay", typeof (Overlay));

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

			protected Overlay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.Overlay']/constructor[@name='MediaCaptureConfig.Overlay' and count(parameter)=4 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[2][@type='android.graphics.Bitmap'] and parameter[3][@type='float[]'] and parameter[4][@type='int']]"
			[Register (".ctor", "(Lveg/mediacapture/sdk/MediaCaptureConfig;Landroid/graphics/Bitmap;[FI)V", "")]
			public unsafe Overlay (global::Veg.Mediacapture.Sdk.MediaCaptureConfig __self, global::Android.Graphics.Bitmap b, float[] map, int level) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Landroid/graphics/Bitmap;[FI)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_map = JNIEnv.NewArray (map);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [4];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
					__args [2] = new JniArgumentValue (native_map);
					__args [3] = new JniArgumentValue (level);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					if (map != null) {
						JNIEnv.CopyArray (native_map, map);
						JNIEnv.DeleteLocalRef (native_map);
					}
					global::System.GC.KeepAlive (__self);
					global::System.GC.KeepAlive (b);
					global::System.GC.KeepAlive (map);
				}
			}

			static Delegate cb_getBitmap;
#pragma warning disable 0169
			static Delegate GetGetBitmapHandler ()
			{
				if (cb_getBitmap == null)
					cb_getBitmap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBitmap);
				return cb_getBitmap;
			}

			static IntPtr n_GetBitmap (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Bitmap);
			}
#pragma warning restore 0169

			public virtual unsafe global::Android.Graphics.Bitmap Bitmap {
				// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.Overlay']/method[@name='getBitmap' and count(parameter)=0]"
				[Register ("getBitmap", "()Landroid/graphics/Bitmap;", "GetGetBitmapHandler")]
				get {
					const string __id = "getBitmap.()Landroid/graphics/Bitmap;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_getHidden;
#pragma warning disable 0169
			static Delegate GetGetHiddenHandler ()
			{
				if (cb_getHidden == null)
					cb_getHidden = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetHidden);
				return cb_getHidden;
			}

			static IntPtr n_GetHidden (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Hidden);
			}
#pragma warning restore 0169

			static Delegate cb_setHidden_Ljava_lang_Boolean_;
#pragma warning disable 0169
			static Delegate GetSetHidden_Ljava_lang_Boolean_Handler ()
			{
				if (cb_setHidden_Ljava_lang_Boolean_ == null)
					cb_setHidden_Ljava_lang_Boolean_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetHidden_Ljava_lang_Boolean_);
				return cb_setHidden_Ljava_lang_Boolean_;
			}

			static void n_SetHidden_Ljava_lang_Boolean_ (IntPtr jnienv, IntPtr native__this, IntPtr native_hidden)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var hidden = global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (native_hidden, JniHandleOwnership.DoNotTransfer);
				__this.Hidden = hidden;
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Boolean Hidden {
				// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.Overlay']/method[@name='getHidden' and count(parameter)=0]"
				[Register ("getHidden", "()Ljava/lang/Boolean;", "GetGetHiddenHandler")]
				get {
					const string __id = "getHidden.()Ljava/lang/Boolean;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.Overlay']/method[@name='setHidden' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
				[Register ("setHidden", "(Ljava/lang/Boolean;)V", "GetSetHidden_Ljava_lang_Boolean_Handler")]
				set {
					const string __id = "setHidden.(Ljava/lang/Boolean;)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
						global::System.GC.KeepAlive (value);
					}
				}
			}

			static Delegate cb_getLevel;
#pragma warning disable 0169
			static Delegate GetGetLevelHandler ()
			{
				if (cb_getLevel == null)
					cb_getLevel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLevel);
				return cb_getLevel;
			}

			static int n_GetLevel (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Level;
			}
#pragma warning restore 0169

			public virtual unsafe int Level {
				// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.Overlay']/method[@name='getLevel' and count(parameter)=0]"
				[Register ("getLevel", "()I", "GetGetLevelHandler")]
				get {
					const string __id = "getLevel.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_getMapMatrix;
#pragma warning disable 0169
			static Delegate GetGetMapMatrixHandler ()
			{
				if (cb_getMapMatrix == null)
					cb_getMapMatrix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMapMatrix);
				return cb_getMapMatrix;
			}

			static IntPtr n_GetMapMatrix (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetMapMatrix ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.Overlay']/method[@name='getMapMatrix' and count(parameter)=0]"
			[Register ("getMapMatrix", "()[F", "GetGetMapMatrixHandler")]
			public virtual unsafe float[] GetMapMatrix ()
			{
				const string __id = "getMapMatrix.()[F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
				} finally {
				}
			}

			static Delegate cb_setMapMatrix_arrayF;
#pragma warning disable 0169
			static Delegate GetSetMapMatrix_arrayFHandler ()
			{
				if (cb_setMapMatrix_arrayF == null)
					cb_setMapMatrix_arrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetMapMatrix_arrayF);
				return cb_setMapMatrix_arrayF;
			}

			static void n_SetMapMatrix_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_newMapMatrix)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var newMapMatrix = (float[]) JNIEnv.GetArray (native_newMapMatrix, JniHandleOwnership.DoNotTransfer, typeof (float));
				__this.SetMapMatrix (newMapMatrix);
				if (newMapMatrix != null)
					JNIEnv.CopyArray (newMapMatrix, native_newMapMatrix);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.Overlay']/method[@name='setMapMatrix' and count(parameter)=1 and parameter[1][@type='float[]']]"
			[Register ("setMapMatrix", "([F)V", "GetSetMapMatrix_arrayFHandler")]
			public virtual unsafe void SetMapMatrix (float[] newMapMatrix)
			{
				const string __id = "setMapMatrix.([F)V";
				IntPtr native_newMapMatrix = JNIEnv.NewArray (newMapMatrix);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_newMapMatrix);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					if (newMapMatrix != null) {
						JNIEnv.CopyArray (native_newMapMatrix, newMapMatrix);
						JNIEnv.DeleteLocalRef (native_newMapMatrix);
					}
					global::System.GC.KeepAlive (newMapMatrix);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.OverlayPosition']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition", DoNotGenerateAcw=true)]
		public sealed partial class OverlayPosition : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.OverlayPosition']/field[@name='BottomLeft']"
			[Register ("BottomLeft")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition BottomLeft {
				get {
					const string __id = "BottomLeft.Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.OverlayPosition']/field[@name='BottomRight']"
			[Register ("BottomRight")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition BottomRight {
				get {
					const string __id = "BottomRight.Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.OverlayPosition']/field[@name='Center']"
			[Register ("Center")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition Center {
				get {
					const string __id = "Center.Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.OverlayPosition']/field[@name='TopLeft']"
			[Register ("TopLeft")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition TopLeft {
				get {
					const string __id = "TopLeft.Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.OverlayPosition']/field[@name='TopRight']"
			[Register ("TopRight")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition TopRight {
				get {
					const string __id = "TopRight.Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition", typeof (OverlayPosition));

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

			internal OverlayPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.OverlayPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.OverlayPosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCaptureConfig$OverlayPosition;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.OverlayPosition));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.StreamerTypes']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes", DoNotGenerateAcw=true)]
		public sealed partial class StreamerTypes : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.StreamerTypes']/field[@name='STREAM_TYPE_RTMP_PUBLISH']"
			[Register ("STREAM_TYPE_RTMP_PUBLISH")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes StreamTypeRtmpPublish {
				get {
					const string __id = "STREAM_TYPE_RTMP_PUBLISH.Lveg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.StreamerTypes']/field[@name='STREAM_TYPE_RTSP_SERVER']"
			[Register ("STREAM_TYPE_RTSP_SERVER")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes StreamTypeRtspServer {
				get {
					const string __id = "STREAM_TYPE_RTSP_SERVER.Lveg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes", typeof (StreamerTypes));

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

			internal StreamerTypes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.StreamerTypes']/method[@name='forValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forValue", "(I)Lveg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes ForValue (int value)
			{
				const string __id = "forValue.(I)Lveg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.StreamerTypes']/method[@name='val' and count(parameter)=0]"
			[Register ("val", "()I", "")]
			public unsafe int Val ()
			{
				const string __id = "val.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.StreamerTypes']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.StreamerTypes']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCaptureConfig$StreamerTypes;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.StreamerTypes));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.VideoTimestampType']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType", DoNotGenerateAcw=true)]
		public sealed partial class VideoTimestampType : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.VideoTimestampType']/field[@name='GENERATED']"
			[Register ("GENERATED")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType Generated {
				get {
					const string __id = "GENERATED.Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.VideoTimestampType']/field[@name='SOURCE']"
			[Register ("SOURCE")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType Source {
				get {
					const string __id = "SOURCE.Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.VideoTimestampType']/field[@name='SOURCE_WITH_FRAMERATE_CONTROL']"
			[Register ("SOURCE_WITH_FRAMERATE_CONTROL")]
			public static global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType SourceWithFramerateControl {
				get {
					const string __id = "SOURCE_WITH_FRAMERATE_CONTROL.Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType", typeof (VideoTimestampType));

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

			internal VideoTimestampType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.VideoTimestampType']/method[@name='forValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forValue", "(I)Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType ForValue (int value)
			{
				const string __id = "forValue.(I)Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.VideoTimestampType']/method[@name='val' and count(parameter)=0]"
			[Register ("val", "()I", "")]
			public unsafe int Val ()
			{
				const string __id = "val.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.VideoTimestampType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig.VideoTimestampType']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCaptureConfig", typeof (MediaCaptureConfig));

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

		protected MediaCaptureConfig (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/constructor[@name='MediaCaptureConfig' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MediaCaptureConfig () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/constructor[@name='MediaCaptureConfig' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig']]"
		[Register (".ctor", "(Lveg/mediacapture/sdk/MediaCaptureConfig;)V", "")]
		public unsafe MediaCaptureConfig (global::Veg.Mediacapture.Sdk.MediaCaptureConfig src) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lveg/mediacapture/sdk/MediaCaptureConfig;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((src == null) ? IntPtr.Zero : ((global::Java.Lang.Object) src).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (src);
			}
		}

		static Delegate cb_getAudioBitrate;
#pragma warning disable 0169
		static Delegate GetGetAudioBitrateHandler ()
		{
			if (cb_getAudioBitrate == null)
				cb_getAudioBitrate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioBitrate);
			return cb_getAudioBitrate;
		}

		static int n_GetAudioBitrate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioBitrate;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetAudioBitrate_IHandler ()
		{
			if (cb_setAudioBitrate_I == null)
				cb_setAudioBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioBitrate_I);
			return cb_setAudioBitrate_I;
		}

		static void n_SetAudioBitrate_I (IntPtr jnienv, IntPtr native__this, int nkbps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioBitrate = nkbps;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getAudioBitrate' and count(parameter)=0]"
			[Register ("getAudioBitrate", "()I", "GetGetAudioBitrateHandler")]
			get {
				const string __id = "getAudioBitrate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAudioBitrate", "(I)V", "GetSetAudioBitrate_IHandler")]
			set {
				const string __id = "setAudioBitrate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioCaptureVolume;
#pragma warning disable 0169
		static Delegate GetGetAudioCaptureVolumeHandler ()
		{
			if (cb_getAudioCaptureVolume == null)
				cb_getAudioCaptureVolume = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetAudioCaptureVolume);
			return cb_getAudioCaptureVolume;
		}

		static float n_GetAudioCaptureVolume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioCaptureVolume;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioCaptureVolume_F;
#pragma warning disable 0169
		static Delegate GetSetAudioCaptureVolume_FHandler ()
		{
			if (cb_setAudioCaptureVolume_F == null)
				cb_setAudioCaptureVolume_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetAudioCaptureVolume_F);
			return cb_setAudioCaptureVolume_F;
		}

		static void n_SetAudioCaptureVolume_F (IntPtr jnienv, IntPtr native__this, float audioCaptureVolume)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioCaptureVolume = audioCaptureVolume;
		}
#pragma warning restore 0169

		public virtual unsafe float AudioCaptureVolume {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getAudioCaptureVolume' and count(parameter)=0]"
			[Register ("getAudioCaptureVolume", "()F", "GetGetAudioCaptureVolumeHandler")]
			get {
				const string __id = "getAudioCaptureVolume.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioCaptureVolume' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAudioCaptureVolume", "(F)V", "GetSetAudioCaptureVolume_FHandler")]
			set {
				const string __id = "setAudioCaptureVolume.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioChannels;
#pragma warning disable 0169
		static Delegate GetGetAudioChannelsHandler ()
		{
			if (cb_getAudioChannels == null)
				cb_getAudioChannels = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioChannels);
			return cb_getAudioChannels;
		}

		static int n_GetAudioChannels (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioChannels;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioChannels_I;
#pragma warning disable 0169
		static Delegate GetSetAudioChannels_IHandler ()
		{
			if (cb_setAudioChannels_I == null)
				cb_setAudioChannels_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioChannels_I);
			return cb_setAudioChannels_I;
		}

		static void n_SetAudioChannels_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioChannels = n;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioChannels {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getAudioChannels' and count(parameter)=0]"
			[Register ("getAudioChannels", "()I", "GetGetAudioChannelsHandler")]
			get {
				const string __id = "getAudioChannels.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioChannels' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAudioChannels", "(I)V", "GetSetAudioChannels_IHandler")]
			set {
				const string __id = "setAudioChannels.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioFormat;
#pragma warning disable 0169
		static Delegate GetGetAudioFormatHandler ()
		{
			if (cb_getAudioFormat == null)
				cb_getAudioFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioFormat);
			return cb_getAudioFormat;
		}

		static IntPtr n_GetAudioFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AudioFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setAudioFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAudioFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setAudioFormat_Ljava_lang_String_ == null)
				cb_setAudioFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAudioFormat_Ljava_lang_String_);
			return cb_setAudioFormat_Ljava_lang_String_;
		}

		static void n_SetAudioFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var n = JNIEnv.GetString (native_n, JniHandleOwnership.DoNotTransfer);
			__this.AudioFormat = n;
		}
#pragma warning restore 0169

		public virtual unsafe string AudioFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getAudioFormat' and count(parameter)=0]"
			[Register ("getAudioFormat", "()Ljava/lang/String;", "GetGetAudioFormatHandler")]
			get {
				const string __id = "getAudioFormat.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAudioFormat", "(Ljava/lang/String;)V", "GetSetAudioFormat_Ljava_lang_String_Handler")]
			set {
				const string __id = "setAudioFormat.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isAudioMute;
#pragma warning disable 0169
		static Delegate GetIsAudioMuteHandler ()
		{
			if (cb_isAudioMute == null)
				cb_isAudioMute = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAudioMute);
			return cb_isAudioMute;
		}

		static bool n_IsAudioMute (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioMute;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioMute_Z;
#pragma warning disable 0169
		static Delegate GetSetAudioMute_ZHandler ()
		{
			if (cb_setAudioMute_Z == null)
				cb_setAudioMute_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAudioMute_Z);
			return cb_setAudioMute_Z;
		}

		static void n_SetAudioMute_Z (IntPtr jnienv, IntPtr native__this, bool mute)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioMute = mute;
		}
#pragma warning restore 0169

		public virtual unsafe bool AudioMute {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isAudioMute' and count(parameter)=0]"
			[Register ("isAudioMute", "()Z", "GetIsAudioMuteHandler")]
			get {
				const string __id = "isAudioMute.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioMute' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAudioMute", "(Z)V", "GetSetAudioMute_ZHandler")]
			set {
				const string __id = "setAudioMute.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioOutputCapture;
#pragma warning disable 0169
		static Delegate GetGetAudioOutputCaptureHandler ()
		{
			if (cb_getAudioOutputCapture == null)
				cb_getAudioOutputCapture = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetAudioOutputCapture);
			return cb_getAudioOutputCapture;
		}

		static bool n_GetAudioOutputCapture (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioOutputCapture;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioOutputCapture_Z;
#pragma warning disable 0169
		static Delegate GetSetAudioOutputCapture_ZHandler ()
		{
			if (cb_setAudioOutputCapture_Z == null)
				cb_setAudioOutputCapture_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAudioOutputCapture_Z);
			return cb_setAudioOutputCapture_Z;
		}

		static void n_SetAudioOutputCapture_Z (IntPtr jnienv, IntPtr native__this, bool audioOutputCapture)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioOutputCapture = audioOutputCapture;
		}
#pragma warning restore 0169

		public virtual unsafe bool AudioOutputCapture {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getAudioOutputCapture' and count(parameter)=0]"
			[Register ("getAudioOutputCapture", "()Z", "GetGetAudioOutputCaptureHandler")]
			get {
				const string __id = "getAudioOutputCapture.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioOutputCapture' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAudioOutputCapture", "(Z)V", "GetSetAudioOutputCapture_ZHandler")]
			set {
				const string __id = "setAudioOutputCapture.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioOutputCaptureVolume;
#pragma warning disable 0169
		static Delegate GetGetAudioOutputCaptureVolumeHandler ()
		{
			if (cb_getAudioOutputCaptureVolume == null)
				cb_getAudioOutputCaptureVolume = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetAudioOutputCaptureVolume);
			return cb_getAudioOutputCaptureVolume;
		}

		static float n_GetAudioOutputCaptureVolume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioOutputCaptureVolume;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioOutputCaptureVolume_F;
#pragma warning disable 0169
		static Delegate GetSetAudioOutputCaptureVolume_FHandler ()
		{
			if (cb_setAudioOutputCaptureVolume_F == null)
				cb_setAudioOutputCaptureVolume_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetAudioOutputCaptureVolume_F);
			return cb_setAudioOutputCaptureVolume_F;
		}

		static void n_SetAudioOutputCaptureVolume_F (IntPtr jnienv, IntPtr native__this, float audioOutputCaptureVolume)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioOutputCaptureVolume = audioOutputCaptureVolume;
		}
#pragma warning restore 0169

		public virtual unsafe float AudioOutputCaptureVolume {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getAudioOutputCaptureVolume' and count(parameter)=0]"
			[Register ("getAudioOutputCaptureVolume", "()F", "GetGetAudioOutputCaptureVolumeHandler")]
			get {
				const string __id = "getAudioOutputCaptureVolume.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioOutputCaptureVolume' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAudioOutputCaptureVolume", "(F)V", "GetSetAudioOutputCaptureVolume_FHandler")]
			set {
				const string __id = "setAudioOutputCaptureVolume.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioSamplingRate;
#pragma warning disable 0169
		static Delegate GetGetAudioSamplingRateHandler ()
		{
			if (cb_getAudioSamplingRate == null)
				cb_getAudioSamplingRate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioSamplingRate);
			return cb_getAudioSamplingRate;
		}

		static int n_GetAudioSamplingRate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioSamplingRate;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioSamplingRate_I;
#pragma warning disable 0169
		static Delegate GetSetAudioSamplingRate_IHandler ()
		{
			if (cb_setAudioSamplingRate_I == null)
				cb_setAudioSamplingRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioSamplingRate_I);
			return cb_setAudioSamplingRate_I;
		}

		static void n_SetAudioSamplingRate_I (IntPtr jnienv, IntPtr native__this, int n)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioSamplingRate = n;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioSamplingRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getAudioSamplingRate' and count(parameter)=0]"
			[Register ("getAudioSamplingRate", "()I", "GetGetAudioSamplingRateHandler")]
			get {
				const string __id = "getAudioSamplingRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioSamplingRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAudioSamplingRate", "(I)V", "GetSetAudioSamplingRate_IHandler")]
			set {
				const string __id = "setAudioSamplingRate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAudioSource;
#pragma warning disable 0169
		static Delegate GetGetAudioSourceHandler ()
		{
			if (cb_getAudioSource == null)
				cb_getAudioSource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioSource);
			return cb_getAudioSource;
		}

		static int n_GetAudioSource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioSource;
		}
#pragma warning restore 0169

		static Delegate cb_setAudioSource_I;
#pragma warning disable 0169
		static Delegate GetSetAudioSource_IHandler ()
		{
			if (cb_setAudioSource_I == null)
				cb_setAudioSource_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetAudioSource_I);
			return cb_setAudioSource_I;
		}

		static void n_SetAudioSource_I (IntPtr jnienv, IntPtr native__this, int audioSource)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AudioSource = audioSource;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getAudioSource' and count(parameter)=0]"
			[Register ("getAudioSource", "()I", "GetGetAudioSourceHandler")]
			get {
				const string __id = "getAudioSource.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setAudioSource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAudioSource", "(I)V", "GetSetAudioSource_IHandler")]
			set {
				const string __id = "setAudioSource.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCameraApiVersion;
#pragma warning disable 0169
		static Delegate GetGetCameraApiVersionHandler ()
		{
			if (cb_getCameraApiVersion == null)
				cb_getCameraApiVersion = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCameraApiVersion);
			return cb_getCameraApiVersion;
		}

		static int n_GetCameraApiVersion (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CameraApiVersion;
		}
#pragma warning restore 0169

		static Delegate cb_setCameraApiVersion_I;
#pragma warning disable 0169
		static Delegate GetSetCameraApiVersion_IHandler ()
		{
			if (cb_setCameraApiVersion_I == null)
				cb_setCameraApiVersion_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCameraApiVersion_I);
			return cb_setCameraApiVersion_I;
		}

		static void n_SetCameraApiVersion_I (IntPtr jnienv, IntPtr native__this, int api)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CameraApiVersion = api;
		}
#pragma warning restore 0169

		public virtual unsafe int CameraApiVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getCameraApiVersion' and count(parameter)=0]"
			[Register ("getCameraApiVersion", "()I", "GetGetCameraApiVersionHandler")]
			get {
				const string __id = "getCameraApiVersion.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setCameraApiVersion' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCameraApiVersion", "(I)V", "GetSetCameraApiVersion_IHandler")]
			set {
				const string __id = "setCameraApiVersion.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCameraCustomFragmentShader;
#pragma warning disable 0169
		static Delegate GetGetCameraCustomFragmentShaderHandler ()
		{
			if (cb_getCameraCustomFragmentShader == null)
				cb_getCameraCustomFragmentShader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCameraCustomFragmentShader);
			return cb_getCameraCustomFragmentShader;
		}

		static IntPtr n_GetCameraCustomFragmentShader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CameraCustomFragmentShader);
		}
#pragma warning restore 0169

		static Delegate cb_setCameraCustomFragmentShader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCameraCustomFragmentShader_Ljava_lang_String_Handler ()
		{
			if (cb_setCameraCustomFragmentShader_Ljava_lang_String_ == null)
				cb_setCameraCustomFragmentShader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCameraCustomFragmentShader_Ljava_lang_String_);
			return cb_setCameraCustomFragmentShader_Ljava_lang_String_;
		}

		static void n_SetCameraCustomFragmentShader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.CameraCustomFragmentShader = s;
		}
#pragma warning restore 0169

		public virtual unsafe string CameraCustomFragmentShader {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getCameraCustomFragmentShader' and count(parameter)=0]"
			[Register ("getCameraCustomFragmentShader", "()Ljava/lang/String;", "GetGetCameraCustomFragmentShaderHandler")]
			get {
				const string __id = "getCameraCustomFragmentShader.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setCameraCustomFragmentShader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCameraCustomFragmentShader", "(Ljava/lang/String;)V", "GetSetCameraCustomFragmentShader_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCameraCustomFragmentShader.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCameraCustomVertexShader;
#pragma warning disable 0169
		static Delegate GetGetCameraCustomVertexShaderHandler ()
		{
			if (cb_getCameraCustomVertexShader == null)
				cb_getCameraCustomVertexShader = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCameraCustomVertexShader);
			return cb_getCameraCustomVertexShader;
		}

		static IntPtr n_GetCameraCustomVertexShader (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CameraCustomVertexShader);
		}
#pragma warning restore 0169

		static Delegate cb_setCameraCustomVertexShader_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetCameraCustomVertexShader_Ljava_lang_String_Handler ()
		{
			if (cb_setCameraCustomVertexShader_Ljava_lang_String_ == null)
				cb_setCameraCustomVertexShader_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetCameraCustomVertexShader_Ljava_lang_String_);
			return cb_setCameraCustomVertexShader_Ljava_lang_String_;
		}

		static void n_SetCameraCustomVertexShader_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.CameraCustomVertexShader = s;
		}
#pragma warning restore 0169

		public virtual unsafe string CameraCustomVertexShader {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getCameraCustomVertexShader' and count(parameter)=0]"
			[Register ("getCameraCustomVertexShader", "()Ljava/lang/String;", "GetGetCameraCustomVertexShaderHandler")]
			get {
				const string __id = "getCameraCustomVertexShader.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setCameraCustomVertexShader' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setCameraCustomVertexShader", "(Ljava/lang/String;)V", "GetSetCameraCustomVertexShader_Ljava_lang_String_Handler")]
			set {
				const string __id = "setCameraCustomVertexShader.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getCameraFacing;
#pragma warning disable 0169
		static Delegate GetGetCameraFacingHandler ()
		{
			if (cb_getCameraFacing == null)
				cb_getCameraFacing = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCameraFacing);
			return cb_getCameraFacing;
		}

		static int n_GetCameraFacing (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CameraFacing;
		}
#pragma warning restore 0169

		static Delegate cb_setCameraFacing_I;
#pragma warning disable 0169
		static Delegate GetSetCameraFacing_IHandler ()
		{
			if (cb_setCameraFacing_I == null)
				cb_setCameraFacing_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCameraFacing_I);
			return cb_setCameraFacing_I;
		}

		static void n_SetCameraFacing_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CameraFacing = i;
		}
#pragma warning restore 0169

		public virtual unsafe int CameraFacing {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getCameraFacing' and count(parameter)=0]"
			[Register ("getCameraFacing", "()I", "GetGetCameraFacingHandler")]
			get {
				const string __id = "getCameraFacing.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setCameraFacing' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCameraFacing", "(I)V", "GetSetCameraFacing_IHandler")]
			set {
				const string __id = "setCameraFacing.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCameraFilter;
#pragma warning disable 0169
		static Delegate GetGetCameraFilterHandler ()
		{
			if (cb_getCameraFilter == null)
				cb_getCameraFilter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCameraFilter);
			return cb_getCameraFilter;
		}

		static int n_GetCameraFilter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CameraFilter;
		}
#pragma warning restore 0169

		static Delegate cb_setCameraFilter_I;
#pragma warning disable 0169
		static Delegate GetSetCameraFilter_IHandler ()
		{
			if (cb_setCameraFilter_I == null)
				cb_setCameraFilter_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCameraFilter_I);
			return cb_setCameraFilter_I;
		}

		static void n_SetCameraFilter_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CameraFilter = i;
		}
#pragma warning restore 0169

		public virtual unsafe int CameraFilter {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getCameraFilter' and count(parameter)=0]"
			[Register ("getCameraFilter", "()I", "GetGetCameraFilterHandler")]
			get {
				const string __id = "getCameraFilter.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setCameraFilter' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCameraFilter", "(I)V", "GetSetCameraFilter_IHandler")]
			set {
				const string __id = "setCameraFilter.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCaptureMode;
#pragma warning disable 0169
		static Delegate GetGetCaptureModeHandler ()
		{
			if (cb_getCaptureMode == null)
				cb_getCaptureMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCaptureMode);
			return cb_getCaptureMode;
		}

		static int n_GetCaptureMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CaptureMode;
		}
#pragma warning restore 0169

		static Delegate cb_setCaptureMode_I;
#pragma warning disable 0169
		static Delegate GetSetCaptureMode_IHandler ()
		{
			if (cb_setCaptureMode_I == null)
				cb_setCaptureMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCaptureMode_I);
			return cb_setCaptureMode_I;
		}

		static void n_SetCaptureMode_I (IntPtr jnienv, IntPtr native__this, int val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CaptureMode = val;
		}
#pragma warning restore 0169

		public virtual unsafe int CaptureMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getCaptureMode' and count(parameter)=0]"
			[Register ("getCaptureMode", "()I", "GetGetCaptureModeHandler")]
			get {
				const string __id = "getCaptureMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setCaptureMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCaptureMode", "(I)V", "GetSetCaptureMode_IHandler")]
			set {
				const string __id = "setCaptureMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCaptureSource;
#pragma warning disable 0169
		static Delegate GetGetCaptureSourceHandler ()
		{
			if (cb_getCaptureSource == null)
				cb_getCaptureSource = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetCaptureSource);
			return cb_getCaptureSource;
		}

		static int n_GetCaptureSource (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CaptureSource;
		}
#pragma warning restore 0169

		static Delegate cb_setCaptureSource_I;
#pragma warning disable 0169
		static Delegate GetSetCaptureSource_IHandler ()
		{
			if (cb_setCaptureSource_I == null)
				cb_setCaptureSource_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetCaptureSource_I);
			return cb_setCaptureSource_I;
		}

		static void n_SetCaptureSource_I (IntPtr jnienv, IntPtr native__this, int val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CaptureSource = val;
		}
#pragma warning restore 0169

		public virtual unsafe int CaptureSource {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getCaptureSource' and count(parameter)=0]"
			[Register ("getCaptureSource", "()I", "GetGetCaptureSourceHandler")]
			get {
				const string __id = "getCaptureSource.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setCaptureSource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCaptureSource", "(I)V", "GetSetCaptureSource_IHandler")]
			set {
				const string __id = "setCaptureSource.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isCaptureAudio;
#pragma warning disable 0169
		static Delegate GetIsCaptureAudioHandler ()
		{
			if (cb_isCaptureAudio == null)
				cb_isCaptureAudio = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCaptureAudio);
			return cb_isCaptureAudio;
		}

		static bool n_IsCaptureAudio (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCaptureAudio;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCaptureAudio {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isCaptureAudio' and count(parameter)=0]"
			[Register ("isCaptureAudio", "()Z", "GetIsCaptureAudioHandler")]
			get {
				const string __id = "isCaptureAudio.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isCaptureVideo;
#pragma warning disable 0169
		static Delegate GetIsCaptureVideoHandler ()
		{
			if (cb_isCaptureVideo == null)
				cb_isCaptureVideo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsCaptureVideo);
			return cb_isCaptureVideo;
		}

		static bool n_IsCaptureVideo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCaptureVideo;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCaptureVideo {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isCaptureVideo' and count(parameter)=0]"
			[Register ("isCaptureVideo", "()Z", "GetIsCaptureVideoHandler")]
			get {
				const string __id = "isCaptureVideo.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLicenseFileName;
#pragma warning disable 0169
		static Delegate GetGetLicenseFileNameHandler ()
		{
			if (cb_getLicenseFileName == null)
				cb_getLicenseFileName = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLicenseFileName);
			return cb_getLicenseFileName;
		}

		static IntPtr n_GetLicenseFileName (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LicenseFileName);
		}
#pragma warning restore 0169

		static Delegate cb_setLicenseFileName_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLicenseFileName_Ljava_lang_String_Handler ()
		{
			if (cb_setLicenseFileName_Ljava_lang_String_ == null)
				cb_setLicenseFileName_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLicenseFileName_Ljava_lang_String_);
			return cb_setLicenseFileName_Ljava_lang_String_;
		}

		static void n_SetLicenseFileName_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			__this.LicenseFileName = name;
		}
#pragma warning restore 0169

		public virtual unsafe string LicenseFileName {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getLicenseFileName' and count(parameter)=0]"
			[Register ("getLicenseFileName", "()Ljava/lang/String;", "GetGetLicenseFileNameHandler")]
			get {
				const string __id = "getLicenseFileName.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setLicenseFileName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLicenseFileName", "(Ljava/lang/String;)V", "GetSetLicenseFileName_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLicenseFileName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getMulticastEnabled;
#pragma warning disable 0169
		static Delegate GetGetMulticastEnabledHandler ()
		{
			if (cb_getMulticastEnabled == null)
				cb_getMulticastEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetMulticastEnabled);
			return cb_getMulticastEnabled;
		}

		static bool n_GetMulticastEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MulticastEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool MulticastEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getMulticastEnabled' and count(parameter)=0]"
			[Register ("getMulticastEnabled", "()Z", "GetGetMulticastEnabledHandler")]
			get {
				const string __id = "getMulticastEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMulticastIP;
#pragma warning disable 0169
		static Delegate GetGetMulticastIPHandler ()
		{
			if (cb_getMulticastIP == null)
				cb_getMulticastIP = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMulticastIP);
			return cb_getMulticastIP;
		}

		static IntPtr n_GetMulticastIP (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MulticastIP);
		}
#pragma warning restore 0169

		public virtual unsafe string MulticastIP {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getMulticastIP' and count(parameter)=0]"
			[Register ("getMulticastIP", "()Ljava/lang/String;", "GetGetMulticastIPHandler")]
			get {
				const string __id = "getMulticastIP.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMulticastTTL;
#pragma warning disable 0169
		static Delegate GetGetMulticastTTLHandler ()
		{
			if (cb_getMulticastTTL == null)
				cb_getMulticastTTL = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMulticastTTL);
			return cb_getMulticastTTL;
		}

		static int n_GetMulticastTTL (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MulticastTTL;
		}
#pragma warning restore 0169

		public virtual unsafe int MulticastTTL {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getMulticastTTL' and count(parameter)=0]"
			[Register ("getMulticastTTL", "()I", "GetGetMulticastTTLHandler")]
			get {
				const string __id = "getMulticastTTL.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOverlays;
#pragma warning disable 0169
		static Delegate GetGetOverlaysHandler ()
		{
			if (cb_getOverlays == null)
				cb_getOverlays = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOverlays);
			return cb_getOverlays;
		}

		static IntPtr n_GetOverlays (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay>.ToLocalJniHandle (__this.Overlays);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> Overlays {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getOverlays' and count(parameter)=0]"
			[Register ("getOverlays", "()Ljava/util/List;", "GetGetOverlaysHandler")]
			get {
				const string __id = "getOverlays.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPort;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetPortHandler ()
		{
			if (cb_getPort == null)
				cb_getPort = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPort);
			return cb_getPort;
		}

		[Obsolete]
		static int n_GetPort (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Port;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int Port {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getPort' and count(parameter)=0]"
			[Register ("getPort", "()I", "GetGetPortHandler")]
			get {
				const string __id = "getPort.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPortSec;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetPortSecHandler ()
		{
			if (cb_getPortSec == null)
				cb_getPortSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPortSec);
			return cb_getPortSec;
		}

		[Obsolete]
		static int n_GetPortSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PortSec;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int PortSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getPortSec' and count(parameter)=0]"
			[Register ("getPortSec", "()I", "GetGetPortSecHandler")]
			get {
				const string __id = "getPortSec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPreviewScaleType;
#pragma warning disable 0169
		static Delegate GetGetPreviewScaleTypeHandler ()
		{
			if (cb_getPreviewScaleType == null)
				cb_getPreviewScaleType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPreviewScaleType);
			return cb_getPreviewScaleType;
		}

		static int n_GetPreviewScaleType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PreviewScaleType;
		}
#pragma warning restore 0169

		static Delegate cb_setPreviewScaleType_I;
#pragma warning disable 0169
		static Delegate GetSetPreviewScaleType_IHandler ()
		{
			if (cb_setPreviewScaleType_I == null)
				cb_setPreviewScaleType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetPreviewScaleType_I);
			return cb_setPreviewScaleType_I;
		}

		static void n_SetPreviewScaleType_I (IntPtr jnienv, IntPtr native__this, int scaleType)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PreviewScaleType = scaleType;
		}
#pragma warning restore 0169

		public virtual unsafe int PreviewScaleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getPreviewScaleType' and count(parameter)=0]"
			[Register ("getPreviewScaleType", "()I", "GetGetPreviewScaleTypeHandler")]
			get {
				const string __id = "getPreviewScaleType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setPreviewScaleType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPreviewScaleType", "(I)V", "GetSetPreviewScaleType_IHandler")]
			set {
				const string __id = "setPreviewScaleType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordFlags;
#pragma warning disable 0169
		static Delegate GetGetRecordFlagsHandler ()
		{
			if (cb_getRecordFlags == null)
				cb_getRecordFlags = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordFlags);
			return cb_getRecordFlags;
		}

		static int n_GetRecordFlags (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordFlags;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordFlags_I;
#pragma warning disable 0169
		static Delegate GetSetRecordFlags_IHandler ()
		{
			if (cb_setRecordFlags_I == null)
				cb_setRecordFlags_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordFlags_I);
			return cb_setRecordFlags_I;
		}

		static void n_SetRecordFlags_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordFlags = i;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordFlags {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordFlags' and count(parameter)=0]"
			[Register ("getRecordFlags", "()I", "GetGetRecordFlagsHandler")]
			get {
				const string __id = "getRecordFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordFlags' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordFlags", "(I)V", "GetSetRecordFlags_IHandler")]
			set {
				const string __id = "setRecordFlags.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordFlagsSec;
#pragma warning disable 0169
		static Delegate GetGetRecordFlagsSecHandler ()
		{
			if (cb_getRecordFlagsSec == null)
				cb_getRecordFlagsSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordFlagsSec);
			return cb_getRecordFlagsSec;
		}

		static int n_GetRecordFlagsSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordFlagsSec;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordFlagsSec_I;
#pragma warning disable 0169
		static Delegate GetSetRecordFlagsSec_IHandler ()
		{
			if (cb_setRecordFlagsSec_I == null)
				cb_setRecordFlagsSec_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordFlagsSec_I);
			return cb_setRecordFlagsSec_I;
		}

		static void n_SetRecordFlagsSec_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordFlagsSec = i;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordFlagsSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordFlagsSec' and count(parameter)=0]"
			[Register ("getRecordFlagsSec", "()I", "GetGetRecordFlagsSecHandler")]
			get {
				const string __id = "getRecordFlagsSec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordFlagsSec' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordFlagsSec", "(I)V", "GetSetRecordFlagsSec_IHandler")]
			set {
				const string __id = "setRecordFlagsSec.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordPath;
#pragma warning disable 0169
		static Delegate GetGetRecordPathHandler ()
		{
			if (cb_getRecordPath == null)
				cb_getRecordPath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRecordPath);
			return cb_getRecordPath;
		}

		static IntPtr n_GetRecordPath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RecordPath);
		}
#pragma warning restore 0169

		static Delegate cb_setRecordPath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRecordPath_Ljava_lang_String_Handler ()
		{
			if (cb_setRecordPath_Ljava_lang_String_ == null)
				cb_setRecordPath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRecordPath_Ljava_lang_String_);
			return cb_setRecordPath_Ljava_lang_String_;
		}

		static void n_SetRecordPath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.RecordPath = s;
		}
#pragma warning restore 0169

		public virtual unsafe string RecordPath {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordPath' and count(parameter)=0]"
			[Register ("getRecordPath", "()Ljava/lang/String;", "GetGetRecordPathHandler")]
			get {
				const string __id = "getRecordPath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordPath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRecordPath", "(Ljava/lang/String;)V", "GetSetRecordPath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRecordPath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRecordPathSec;
#pragma warning disable 0169
		static Delegate GetGetRecordPathSecHandler ()
		{
			if (cb_getRecordPathSec == null)
				cb_getRecordPathSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRecordPathSec);
			return cb_getRecordPathSec;
		}

		static IntPtr n_GetRecordPathSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RecordPathSec);
		}
#pragma warning restore 0169

		static Delegate cb_setRecordPathSec_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRecordPathSec_Ljava_lang_String_Handler ()
		{
			if (cb_setRecordPathSec_Ljava_lang_String_ == null)
				cb_setRecordPathSec_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRecordPathSec_Ljava_lang_String_);
			return cb_setRecordPathSec_Ljava_lang_String_;
		}

		static void n_SetRecordPathSec_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.RecordPathSec = s;
		}
#pragma warning restore 0169

		public virtual unsafe string RecordPathSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordPathSec' and count(parameter)=0]"
			[Register ("getRecordPathSec", "()Ljava/lang/String;", "GetGetRecordPathSecHandler")]
			get {
				const string __id = "getRecordPathSec.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordPathSec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRecordPathSec", "(Ljava/lang/String;)V", "GetSetRecordPathSec_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRecordPathSec.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRecordPrefix;
#pragma warning disable 0169
		static Delegate GetGetRecordPrefixHandler ()
		{
			if (cb_getRecordPrefix == null)
				cb_getRecordPrefix = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRecordPrefix);
			return cb_getRecordPrefix;
		}

		static IntPtr n_GetRecordPrefix (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RecordPrefix);
		}
#pragma warning restore 0169

		static Delegate cb_setRecordPrefix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRecordPrefix_Ljava_lang_String_Handler ()
		{
			if (cb_setRecordPrefix_Ljava_lang_String_ == null)
				cb_setRecordPrefix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRecordPrefix_Ljava_lang_String_);
			return cb_setRecordPrefix_Ljava_lang_String_;
		}

		static void n_SetRecordPrefix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.RecordPrefix = s;
		}
#pragma warning restore 0169

		public virtual unsafe string RecordPrefix {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordPrefix' and count(parameter)=0]"
			[Register ("getRecordPrefix", "()Ljava/lang/String;", "GetGetRecordPrefixHandler")]
			get {
				const string __id = "getRecordPrefix.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordPrefix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRecordPrefix", "(Ljava/lang/String;)V", "GetSetRecordPrefix_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRecordPrefix.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRecordPrefixSec;
#pragma warning disable 0169
		static Delegate GetGetRecordPrefixSecHandler ()
		{
			if (cb_getRecordPrefixSec == null)
				cb_getRecordPrefixSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRecordPrefixSec);
			return cb_getRecordPrefixSec;
		}

		static IntPtr n_GetRecordPrefixSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RecordPrefixSec);
		}
#pragma warning restore 0169

		static Delegate cb_setRecordPrefixSec_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetRecordPrefixSec_Ljava_lang_String_Handler ()
		{
			if (cb_setRecordPrefixSec_Ljava_lang_String_ == null)
				cb_setRecordPrefixSec_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetRecordPrefixSec_Ljava_lang_String_);
			return cb_setRecordPrefixSec_Ljava_lang_String_;
		}

		static void n_SetRecordPrefixSec_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_s)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var s = JNIEnv.GetString (native_s, JniHandleOwnership.DoNotTransfer);
			__this.RecordPrefixSec = s;
		}
#pragma warning restore 0169

		public virtual unsafe string RecordPrefixSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordPrefixSec' and count(parameter)=0]"
			[Register ("getRecordPrefixSec", "()Ljava/lang/String;", "GetGetRecordPrefixSecHandler")]
			get {
				const string __id = "getRecordPrefixSec.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordPrefixSec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setRecordPrefixSec", "(Ljava/lang/String;)V", "GetSetRecordPrefixSec_Ljava_lang_String_Handler")]
			set {
				const string __id = "setRecordPrefixSec.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getRecordSplitSize;
#pragma warning disable 0169
		static Delegate GetGetRecordSplitSizeHandler ()
		{
			if (cb_getRecordSplitSize == null)
				cb_getRecordSplitSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordSplitSize);
			return cb_getRecordSplitSize;
		}

		static int n_GetRecordSplitSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordSplitSize;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordSplitSize_I;
#pragma warning disable 0169
		static Delegate GetSetRecordSplitSize_IHandler ()
		{
			if (cb_setRecordSplitSize_I == null)
				cb_setRecordSplitSize_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordSplitSize_I);
			return cb_setRecordSplitSize_I;
		}

		static void n_SetRecordSplitSize_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordSplitSize = i;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordSplitSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordSplitSize' and count(parameter)=0]"
			[Register ("getRecordSplitSize", "()I", "GetGetRecordSplitSizeHandler")]
			get {
				const string __id = "getRecordSplitSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordSplitSize' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordSplitSize", "(I)V", "GetSetRecordSplitSize_IHandler")]
			set {
				const string __id = "setRecordSplitSize.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordSplitSizeSec;
#pragma warning disable 0169
		static Delegate GetGetRecordSplitSizeSecHandler ()
		{
			if (cb_getRecordSplitSizeSec == null)
				cb_getRecordSplitSizeSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordSplitSizeSec);
			return cb_getRecordSplitSizeSec;
		}

		static int n_GetRecordSplitSizeSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordSplitSizeSec;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordSplitSizeSec_I;
#pragma warning disable 0169
		static Delegate GetSetRecordSplitSizeSec_IHandler ()
		{
			if (cb_setRecordSplitSizeSec_I == null)
				cb_setRecordSplitSizeSec_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordSplitSizeSec_I);
			return cb_setRecordSplitSizeSec_I;
		}

		static void n_SetRecordSplitSizeSec_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordSplitSizeSec = i;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordSplitSizeSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordSplitSizeSec' and count(parameter)=0]"
			[Register ("getRecordSplitSizeSec", "()I", "GetGetRecordSplitSizeSecHandler")]
			get {
				const string __id = "getRecordSplitSizeSec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordSplitSizeSec' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordSplitSizeSec", "(I)V", "GetSetRecordSplitSizeSec_IHandler")]
			set {
				const string __id = "setRecordSplitSizeSec.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordSplitTime;
#pragma warning disable 0169
		static Delegate GetGetRecordSplitTimeHandler ()
		{
			if (cb_getRecordSplitTime == null)
				cb_getRecordSplitTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordSplitTime);
			return cb_getRecordSplitTime;
		}

		static int n_GetRecordSplitTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordSplitTime;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordSplitTime_I;
#pragma warning disable 0169
		static Delegate GetSetRecordSplitTime_IHandler ()
		{
			if (cb_setRecordSplitTime_I == null)
				cb_setRecordSplitTime_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordSplitTime_I);
			return cb_setRecordSplitTime_I;
		}

		static void n_SetRecordSplitTime_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordSplitTime = i;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordSplitTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordSplitTime' and count(parameter)=0]"
			[Register ("getRecordSplitTime", "()I", "GetGetRecordSplitTimeHandler")]
			get {
				const string __id = "getRecordSplitTime.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordSplitTime' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordSplitTime", "(I)V", "GetSetRecordSplitTime_IHandler")]
			set {
				const string __id = "setRecordSplitTime.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordSplitTimeSec;
#pragma warning disable 0169
		static Delegate GetGetRecordSplitTimeSecHandler ()
		{
			if (cb_getRecordSplitTimeSec == null)
				cb_getRecordSplitTimeSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordSplitTimeSec);
			return cb_getRecordSplitTimeSec;
		}

		static int n_GetRecordSplitTimeSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordSplitTimeSec;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordSplitTimeSec_I;
#pragma warning disable 0169
		static Delegate GetSetRecordSplitTimeSec_IHandler ()
		{
			if (cb_setRecordSplitTimeSec_I == null)
				cb_setRecordSplitTimeSec_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordSplitTimeSec_I);
			return cb_setRecordSplitTimeSec_I;
		}

		static void n_SetRecordSplitTimeSec_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordSplitTimeSec = i;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordSplitTimeSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordSplitTimeSec' and count(parameter)=0]"
			[Register ("getRecordSplitTimeSec", "()I", "GetGetRecordSplitTimeSecHandler")]
			get {
				const string __id = "getRecordSplitTimeSec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordSplitTimeSec' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordSplitTimeSec", "(I)V", "GetSetRecordSplitTimeSec_IHandler")]
			set {
				const string __id = "setRecordSplitTimeSec.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordTimeshift;
#pragma warning disable 0169
		static Delegate GetGetRecordTimeshiftHandler ()
		{
			if (cb_getRecordTimeshift == null)
				cb_getRecordTimeshift = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordTimeshift);
			return cb_getRecordTimeshift;
		}

		static int n_GetRecordTimeshift (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordTimeshift;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordTimeshift_I;
#pragma warning disable 0169
		static Delegate GetSetRecordTimeshift_IHandler ()
		{
			if (cb_setRecordTimeshift_I == null)
				cb_setRecordTimeshift_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordTimeshift_I);
			return cb_setRecordTimeshift_I;
		}

		static void n_SetRecordTimeshift_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordTimeshift = i;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordTimeshift {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordTimeshift' and count(parameter)=0]"
			[Register ("getRecordTimeshift", "()I", "GetGetRecordTimeshiftHandler")]
			get {
				const string __id = "getRecordTimeshift.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordTimeshift' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordTimeshift", "(I)V", "GetSetRecordTimeshift_IHandler")]
			set {
				const string __id = "setRecordTimeshift.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRecordTimeshiftSec;
#pragma warning disable 0169
		static Delegate GetGetRecordTimeshiftSecHandler ()
		{
			if (cb_getRecordTimeshiftSec == null)
				cb_getRecordTimeshiftSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRecordTimeshiftSec);
			return cb_getRecordTimeshiftSec;
		}

		static int n_GetRecordTimeshiftSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RecordTimeshiftSec;
		}
#pragma warning restore 0169

		static Delegate cb_setRecordTimeshiftSec_I;
#pragma warning disable 0169
		static Delegate GetSetRecordTimeshiftSec_IHandler ()
		{
			if (cb_setRecordTimeshiftSec_I == null)
				cb_setRecordTimeshiftSec_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetRecordTimeshiftSec_I);
			return cb_setRecordTimeshiftSec_I;
		}

		static void n_SetRecordTimeshiftSec_I (IntPtr jnienv, IntPtr native__this, int i)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecordTimeshiftSec = i;
		}
#pragma warning restore 0169

		public virtual unsafe int RecordTimeshiftSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getRecordTimeshiftSec' and count(parameter)=0]"
			[Register ("getRecordTimeshiftSec", "()I", "GetGetRecordTimeshiftSecHandler")]
			get {
				const string __id = "getRecordTimeshiftSec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecordTimeshiftSec' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRecordTimeshiftSec", "(I)V", "GetSetRecordTimeshiftSec_IHandler")]
			set {
				const string __id = "setRecordTimeshiftSec.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRecording;
#pragma warning disable 0169
		static Delegate GetIsRecordingHandler ()
		{
			if (cb_isRecording == null)
				cb_isRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRecording);
			return cb_isRecording;
		}

		static bool n_IsRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Recording;
		}
#pragma warning restore 0169

		static Delegate cb_setRecording_Z;
#pragma warning disable 0169
		static Delegate GetSetRecording_ZHandler ()
		{
			if (cb_setRecording_Z == null)
				cb_setRecording_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetRecording_Z);
			return cb_setRecording_Z;
		}

		static void n_SetRecording_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Recording = enable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Recording {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isRecording' and count(parameter)=0]"
			[Register ("isRecording", "()Z", "GetIsRecordingHandler")]
			get {
				const string __id = "isRecording.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setRecording' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRecording", "(Z)V", "GetSetRecording_ZHandler")]
			set {
				const string __id = "setRecording.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSSLCert;
#pragma warning disable 0169
		static Delegate GetGetSSLCertHandler ()
		{
			if (cb_getSSLCert == null)
				cb_getSSLCert = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSSLCert);
			return cb_getSSLCert;
		}

		static IntPtr n_GetSSLCert (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SSLCert);
		}
#pragma warning restore 0169

		public virtual unsafe string SSLCert {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSSLCert' and count(parameter)=0]"
			[Register ("getSSLCert", "()Ljava/lang/String;", "GetGetSSLCertHandler")]
			get {
				const string __id = "getSSLCert.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSSLKey;
#pragma warning disable 0169
		static Delegate GetGetSSLKeyHandler ()
		{
			if (cb_getSSLKey == null)
				cb_getSSLKey = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSSLKey);
			return cb_getSSLKey;
		}

		static IntPtr n_GetSSLKey (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SSLKey);
		}
#pragma warning restore 0169

		public virtual unsafe string SSLKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSSLKey' and count(parameter)=0]"
			[Register ("getSSLKey", "()Ljava/lang/String;", "GetGetSSLKeyHandler")]
			get {
				const string __id = "getSSLKey.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSecVideoBitrate;
#pragma warning disable 0169
		static Delegate GetGetSecVideoBitrateHandler ()
		{
			if (cb_getSecVideoBitrate == null)
				cb_getSecVideoBitrate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSecVideoBitrate);
			return cb_getSecVideoBitrate;
		}

		static int n_GetSecVideoBitrate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecVideoBitrate;
		}
#pragma warning restore 0169

		static Delegate cb_setSecVideoBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetSecVideoBitrate_IHandler ()
		{
			if (cb_setSecVideoBitrate_I == null)
				cb_setSecVideoBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSecVideoBitrate_I);
			return cb_setSecVideoBitrate_I;
		}

		static void n_SetSecVideoBitrate_I (IntPtr jnienv, IntPtr native__this, int nkbps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SecVideoBitrate = nkbps;
		}
#pragma warning restore 0169

		public virtual unsafe int SecVideoBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecVideoBitrate' and count(parameter)=0]"
			[Register ("getSecVideoBitrate", "()I", "GetGetSecVideoBitrateHandler")]
			get {
				const string __id = "getSecVideoBitrate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setSecVideoBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSecVideoBitrate", "(I)V", "GetSetSecVideoBitrate_IHandler")]
			set {
				const string __id = "setSecVideoBitrate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSecVideoFramerate;
#pragma warning disable 0169
		static Delegate GetGetSecVideoFramerateHandler ()
		{
			if (cb_getSecVideoFramerate == null)
				cb_getSecVideoFramerate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSecVideoFramerate);
			return cb_getSecVideoFramerate;
		}

		static int n_GetSecVideoFramerate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecVideoFramerate;
		}
#pragma warning restore 0169

		static Delegate cb_setSecVideoFramerate_I;
#pragma warning disable 0169
		static Delegate GetSetSecVideoFramerate_IHandler ()
		{
			if (cb_setSecVideoFramerate_I == null)
				cb_setSecVideoFramerate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSecVideoFramerate_I);
			return cb_setSecVideoFramerate_I;
		}

		static void n_SetSecVideoFramerate_I (IntPtr jnienv, IntPtr native__this, int fps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SecVideoFramerate = fps;
		}
#pragma warning restore 0169

		public virtual unsafe int SecVideoFramerate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecVideoFramerate' and count(parameter)=0]"
			[Register ("getSecVideoFramerate", "()I", "GetGetSecVideoFramerateHandler")]
			get {
				const string __id = "getSecVideoFramerate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setSecVideoFramerate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSecVideoFramerate", "(I)V", "GetSetSecVideoFramerate_IHandler")]
			set {
				const string __id = "setSecVideoFramerate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSecVideoHeight;
#pragma warning disable 0169
		static Delegate GetGetSecVideoHeightHandler ()
		{
			if (cb_getSecVideoHeight == null)
				cb_getSecVideoHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSecVideoHeight);
			return cb_getSecVideoHeight;
		}

		static int n_GetSecVideoHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecVideoHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int SecVideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecVideoHeight' and count(parameter)=0]"
			[Register ("getSecVideoHeight", "()I", "GetGetSecVideoHeightHandler")]
			get {
				const string __id = "getSecVideoHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSecVideoKeyFrameInterval;
#pragma warning disable 0169
		static Delegate GetGetSecVideoKeyFrameIntervalHandler ()
		{
			if (cb_getSecVideoKeyFrameInterval == null)
				cb_getSecVideoKeyFrameInterval = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSecVideoKeyFrameInterval);
			return cb_getSecVideoKeyFrameInterval;
		}

		static int n_GetSecVideoKeyFrameInterval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecVideoKeyFrameInterval;
		}
#pragma warning restore 0169

		static Delegate cb_setSecVideoKeyFrameInterval_I;
#pragma warning disable 0169
		static Delegate GetSetSecVideoKeyFrameInterval_IHandler ()
		{
			if (cb_setSecVideoKeyFrameInterval_I == null)
				cb_setSecVideoKeyFrameInterval_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetSecVideoKeyFrameInterval_I);
			return cb_setSecVideoKeyFrameInterval_I;
		}

		static void n_SetSecVideoKeyFrameInterval_I (IntPtr jnienv, IntPtr native__this, int interval)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SecVideoKeyFrameInterval = interval;
		}
#pragma warning restore 0169

		public virtual unsafe int SecVideoKeyFrameInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecVideoKeyFrameInterval' and count(parameter)=0]"
			[Register ("getSecVideoKeyFrameInterval", "()I", "GetGetSecVideoKeyFrameIntervalHandler")]
			get {
				const string __id = "getSecVideoKeyFrameInterval.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setSecVideoKeyFrameInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSecVideoKeyFrameInterval", "(I)V", "GetSetSecVideoKeyFrameInterval_IHandler")]
			set {
				const string __id = "setSecVideoKeyFrameInterval.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSecVideoResolution;
#pragma warning disable 0169
		static Delegate GetGetSecVideoResolutionHandler ()
		{
			if (cb_getSecVideoResolution == null)
				cb_getSecVideoResolution = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecVideoResolution);
			return cb_getSecVideoResolution;
		}

		static IntPtr n_GetSecVideoResolution (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SecVideoResolution);
		}
#pragma warning restore 0169

		static Delegate cb_setSecVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_;
#pragma warning disable 0169
		static Delegate GetSetSecVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_Handler ()
		{
			if (cb_setSecVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ == null)
				cb_setSecVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSecVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_);
			return cb_setSecVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_;
		}

		static void n_SetSecVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vr = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (native_vr, JniHandleOwnership.DoNotTransfer);
			__this.SecVideoResolution = vr;
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution SecVideoResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecVideoResolution' and count(parameter)=0]"
			[Register ("getSecVideoResolution", "()Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;", "GetGetSecVideoResolutionHandler")]
			get {
				const string __id = "getSecVideoResolution.()Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setSecVideoResolution' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.CaptureVideoResolution']]"
			[Register ("setSecVideoResolution", "(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)V", "GetSetSecVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_Handler")]
			set {
				const string __id = "setSecVideoResolution.(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getSecVideoSrcFilePath;
#pragma warning disable 0169
		static Delegate GetGetSecVideoSrcFilePathHandler ()
		{
			if (cb_getSecVideoSrcFilePath == null)
				cb_getSecVideoSrcFilePath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSecVideoSrcFilePath);
			return cb_getSecVideoSrcFilePath;
		}

		static IntPtr n_GetSecVideoSrcFilePath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SecVideoSrcFilePath);
		}
#pragma warning restore 0169

		static Delegate cb_setSecVideoSrcFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecVideoSrcFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setSecVideoSrcFilePath_Ljava_lang_String_ == null)
				cb_setSecVideoSrcFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSecVideoSrcFilePath_Ljava_lang_String_);
			return cb_setSecVideoSrcFilePath_Ljava_lang_String_;
		}

		static void n_SetSecVideoSrcFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.SecVideoSrcFilePath = path;
		}
#pragma warning restore 0169

		public virtual unsafe string SecVideoSrcFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecVideoSrcFilePath' and count(parameter)=0]"
			[Register ("getSecVideoSrcFilePath", "()Ljava/lang/String;", "GetGetSecVideoSrcFilePathHandler")]
			get {
				const string __id = "getSecVideoSrcFilePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setSecVideoSrcFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setSecVideoSrcFilePath", "(Ljava/lang/String;)V", "GetSetSecVideoSrcFilePath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setSecVideoSrcFilePath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getSecVideoUseSrcFile;
#pragma warning disable 0169
		static Delegate GetGetSecVideoUseSrcFileHandler ()
		{
			if (cb_getSecVideoUseSrcFile == null)
				cb_getSecVideoUseSrcFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetSecVideoUseSrcFile);
			return cb_getSecVideoUseSrcFile;
		}

		static bool n_GetSecVideoUseSrcFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecVideoUseSrcFile;
		}
#pragma warning restore 0169

		static Delegate cb_setSecVideoUseSrcFile_Z;
#pragma warning disable 0169
		static Delegate GetSetSecVideoUseSrcFile_ZHandler ()
		{
			if (cb_setSecVideoUseSrcFile_Z == null)
				cb_setSecVideoUseSrcFile_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSecVideoUseSrcFile_Z);
			return cb_setSecVideoUseSrcFile_Z;
		}

		static void n_SetSecVideoUseSrcFile_Z (IntPtr jnienv, IntPtr native__this, bool use)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SecVideoUseSrcFile = use;
		}
#pragma warning restore 0169

		public virtual unsafe bool SecVideoUseSrcFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecVideoUseSrcFile' and count(parameter)=0]"
			[Register ("getSecVideoUseSrcFile", "()Z", "GetGetSecVideoUseSrcFileHandler")]
			get {
				const string __id = "getSecVideoUseSrcFile.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setSecVideoUseSrcFile' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSecVideoUseSrcFile", "(Z)V", "GetSetSecVideoUseSrcFile_ZHandler")]
			set {
				const string __id = "setSecVideoUseSrcFile.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSecVideoWidth;
#pragma warning disable 0169
		static Delegate GetGetSecVideoWidthHandler ()
		{
			if (cb_getSecVideoWidth == null)
				cb_getSecVideoWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetSecVideoWidth);
			return cb_getSecVideoWidth;
		}

		static int n_GetSecVideoWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecVideoWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int SecVideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecVideoWidth' and count(parameter)=0]"
			[Register ("getSecVideoWidth", "()I", "GetGetSecVideoWidthHandler")]
			get {
				const string __id = "getSecVideoWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSecureStreamingEnabled;
#pragma warning disable 0169
		static Delegate GetGetSecureStreamingEnabledHandler ()
		{
			if (cb_getSecureStreamingEnabled == null)
				cb_getSecureStreamingEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetSecureStreamingEnabled);
			return cb_getSecureStreamingEnabled;
		}

		static bool n_GetSecureStreamingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SecureStreamingEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool SecureStreamingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getSecureStreamingEnabled' and count(parameter)=0]"
			[Register ("getSecureStreamingEnabled", "()Z", "GetGetSecureStreamingEnabledHandler")]
			get {
				const string __id = "getSecureStreamingEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStreamType;
#pragma warning disable 0169
		static Delegate GetGetStreamTypeHandler ()
		{
			if (cb_getStreamType == null)
				cb_getStreamType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStreamType);
			return cb_getStreamType;
		}

		static int n_GetStreamType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StreamType;
		}
#pragma warning restore 0169

		static Delegate cb_setStreamType_I;
#pragma warning disable 0169
		static Delegate GetSetStreamType_IHandler ()
		{
			if (cb_setStreamType_I == null)
				cb_setStreamType_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetStreamType_I);
			return cb_setStreamType_I;
		}

		static void n_SetStreamType_I (IntPtr jnienv, IntPtr native__this, int val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StreamType = val;
		}
#pragma warning restore 0169

		public virtual unsafe int StreamType {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getStreamType' and count(parameter)=0]"
			[Register ("getStreamType", "()I", "GetGetStreamTypeHandler")]
			get {
				const string __id = "getStreamType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setStreamType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStreamType", "(I)V", "GetSetStreamType_IHandler")]
			set {
				const string __id = "setStreamType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isStreaming;
#pragma warning disable 0169
		static Delegate GetIsStreamingHandler ()
		{
			if (cb_isStreaming == null)
				cb_isStreaming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsStreaming);
			return cb_isStreaming;
		}

		static bool n_IsStreaming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Streaming;
		}
#pragma warning restore 0169

		static Delegate cb_setStreaming_Z;
#pragma warning disable 0169
		static Delegate GetSetStreaming_ZHandler ()
		{
			if (cb_setStreaming_Z == null)
				cb_setStreaming_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetStreaming_Z);
			return cb_setStreaming_Z;
		}

		static void n_SetStreaming_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Streaming = enable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Streaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isStreaming' and count(parameter)=0]"
			[Register ("isStreaming", "()Z", "GetIsStreamingHandler")]
			get {
				const string __id = "isStreaming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setStreaming' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setStreaming", "(Z)V", "GetSetStreaming_ZHandler")]
			set {
				const string __id = "setStreaming.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransFormat;
#pragma warning disable 0169
		static Delegate GetGetTransFormatHandler ()
		{
			if (cb_getTransFormat == null)
				cb_getTransFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransFormat);
			return cb_getTransFormat;
		}

		static IntPtr n_GetTransFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TransFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setTransFormat_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetTransFormat_Ljava_lang_String_Handler ()
		{
			if (cb_setTransFormat_Ljava_lang_String_ == null)
				cb_setTransFormat_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTransFormat_Ljava_lang_String_);
			return cb_setTransFormat_Ljava_lang_String_;
		}

		static void n_SetTransFormat_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_format)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var format = JNIEnv.GetString (native_format, JniHandleOwnership.DoNotTransfer);
			__this.TransFormat = format;
		}
#pragma warning restore 0169

		public virtual unsafe string TransFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getTransFormat' and count(parameter)=0]"
			[Register ("getTransFormat", "()Ljava/lang/String;", "GetGetTransFormatHandler")]
			get {
				const string __id = "getTransFormat.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setTransFormat' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setTransFormat", "(Ljava/lang/String;)V", "GetSetTransFormat_Ljava_lang_String_Handler")]
			set {
				const string __id = "setTransFormat.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getTransFps;
#pragma warning disable 0169
		static Delegate GetGetTransFpsHandler ()
		{
			if (cb_getTransFps == null)
				cb_getTransFps = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_D) n_GetTransFps);
			return cb_getTransFps;
		}

		static double n_GetTransFps (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransFps;
		}
#pragma warning restore 0169

		static Delegate cb_setTransFps_D;
#pragma warning disable 0169
		static Delegate GetSetTransFps_DHandler ()
		{
			if (cb_setTransFps_D == null)
				cb_setTransFps_D = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPD_V) n_SetTransFps_D);
			return cb_setTransFps_D;
		}

		static void n_SetTransFps_D (IntPtr jnienv, IntPtr native__this, double fps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TransFps = fps;
		}
#pragma warning restore 0169

		public virtual unsafe double TransFps {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getTransFps' and count(parameter)=0]"
			[Register ("getTransFps", "()D", "GetGetTransFpsHandler")]
			get {
				const string __id = "getTransFps.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setTransFps' and count(parameter)=1 and parameter[1][@type='double']]"
			[Register ("setTransFps", "(D)V", "GetSetTransFps_DHandler")]
			set {
				const string __id = "setTransFps.(D)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransHeight;
#pragma warning disable 0169
		static Delegate GetGetTransHeightHandler ()
		{
			if (cb_getTransHeight == null)
				cb_getTransHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTransHeight);
			return cb_getTransHeight;
		}

		static int n_GetTransHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransHeight;
		}
#pragma warning restore 0169

		static Delegate cb_setTransHeight_I;
#pragma warning disable 0169
		static Delegate GetSetTransHeight_IHandler ()
		{
			if (cb_setTransHeight_I == null)
				cb_setTransHeight_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTransHeight_I);
			return cb_setTransHeight_I;
		}

		static void n_SetTransHeight_I (IntPtr jnienv, IntPtr native__this, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TransHeight = height;
		}
#pragma warning restore 0169

		public virtual unsafe int TransHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getTransHeight' and count(parameter)=0]"
			[Register ("getTransHeight", "()I", "GetGetTransHeightHandler")]
			get {
				const string __id = "getTransHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setTransHeight' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTransHeight", "(I)V", "GetSetTransHeight_IHandler")]
			set {
				const string __id = "setTransHeight.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTransType;
#pragma warning disable 0169
		static Delegate GetGetTransTypeHandler ()
		{
			if (cb_getTransType == null)
				cb_getTransType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransType);
			return cb_getTransType;
		}

		static IntPtr n_GetTransType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TransType);
		}
#pragma warning restore 0169

		static Delegate cb_setTransType_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureTransType_;
#pragma warning disable 0169
		static Delegate GetSetTransType_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureTransType_Handler ()
		{
			if (cb_setTransType_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureTransType_ == null)
				cb_setTransType_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureTransType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTransType_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureTransType_);
			return cb_setTransType_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureTransType_;
		}

		static void n_SetTransType_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureTransType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.TransType = type;
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType TransType {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getTransType' and count(parameter)=0]"
			[Register ("getTransType", "()Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;", "GetGetTransTypeHandler")]
			get {
				const string __id = "getTransType.()Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureTransType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setTransType' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.CaptureTransType']]"
			[Register ("setTransType", "(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;)V", "GetSetTransType_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureTransType_Handler")]
			set {
				const string __id = "setTransType.(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureTransType;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getTransWidth;
#pragma warning disable 0169
		static Delegate GetGetTransWidthHandler ()
		{
			if (cb_getTransWidth == null)
				cb_getTransWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTransWidth);
			return cb_getTransWidth;
		}

		static int n_GetTransWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setTransWidth_I;
#pragma warning disable 0169
		static Delegate GetSetTransWidth_IHandler ()
		{
			if (cb_setTransWidth_I == null)
				cb_setTransWidth_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTransWidth_I);
			return cb_setTransWidth_I;
		}

		static void n_SetTransWidth_I (IntPtr jnienv, IntPtr native__this, int width)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TransWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe int TransWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getTransWidth' and count(parameter)=0]"
			[Register ("getTransWidth", "()I", "GetGetTransWidthHandler")]
			get {
				const string __id = "getTransWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setTransWidth' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTransWidth", "(I)V", "GetSetTransWidth_IHandler")]
			set {
				const string __id = "setTransWidth.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isTranscoding;
#pragma warning disable 0169
		static Delegate GetIsTranscodingHandler ()
		{
			if (cb_isTranscoding == null)
				cb_isTranscoding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsTranscoding);
			return cb_isTranscoding;
		}

		static bool n_IsTranscoding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Transcoding;
		}
#pragma warning restore 0169

		static Delegate cb_setTranscoding_Z;
#pragma warning disable 0169
		static Delegate GetSetTranscoding_ZHandler ()
		{
			if (cb_setTranscoding_Z == null)
				cb_setTranscoding_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetTranscoding_Z);
			return cb_setTranscoding_Z;
		}

		static void n_SetTranscoding_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Transcoding = enable;
		}
#pragma warning restore 0169

		public virtual unsafe bool Transcoding {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isTranscoding' and count(parameter)=0]"
			[Register ("isTranscoding", "()Z", "GetIsTranscodingHandler")]
			get {
				const string __id = "isTranscoding.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setTranscoding' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setTranscoding", "(Z)V", "GetSetTranscoding_ZHandler")]
			set {
				const string __id = "setTranscoding.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getUrl;
#pragma warning disable 0169
		static Delegate GetGetUrlHandler ()
		{
			if (cb_getUrl == null)
				cb_getUrl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUrl);
			return cb_getUrl;
		}

		static IntPtr n_GetUrl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Url);
		}
#pragma warning restore 0169

		static Delegate cb_setUrl_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setUrl_Ljava_lang_String_ == null)
				cb_setUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUrl_Ljava_lang_String_);
			return cb_setUrl_Ljava_lang_String_;
		}

		[Obsolete]
		static void n_SetUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.Url = url;
		}
#pragma warning restore 0169

		public virtual unsafe string Url {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getUrl' and count(parameter)=0]"
			[Register ("getUrl", "()Ljava/lang/String;", "GetGetUrlHandler")]
			get {
				const string __id = "getUrl.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrl", "(Ljava/lang/String;)V", "GetSetUrl_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUrl.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getUrlSec;
#pragma warning disable 0169
		static Delegate GetGetUrlSecHandler ()
		{
			if (cb_getUrlSec == null)
				cb_getUrlSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetUrlSec);
			return cb_getUrlSec;
		}

		static IntPtr n_GetUrlSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.UrlSec);
		}
#pragma warning restore 0169

		static Delegate cb_setUrlSec_Ljava_lang_String_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetUrlSec_Ljava_lang_String_Handler ()
		{
			if (cb_setUrlSec_Ljava_lang_String_ == null)
				cb_setUrlSec_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetUrlSec_Ljava_lang_String_);
			return cb_setUrlSec_Ljava_lang_String_;
		}

		[Obsolete]
		static void n_SetUrlSec_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_url)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.UrlSec = url;
		}
#pragma warning restore 0169

		public virtual unsafe string UrlSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getUrlSec' and count(parameter)=0]"
			[Register ("getUrlSec", "()Ljava/lang/String;", "GetGetUrlSecHandler")]
			get {
				const string __id = "getUrlSec.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUrlSec' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setUrlSec", "(Ljava/lang/String;)V", "GetSetUrlSec_Ljava_lang_String_Handler")]
			set {
				const string __id = "setUrlSec.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_isUseAVSync;
#pragma warning disable 0169
		static Delegate GetIsUseAVSyncHandler ()
		{
			if (cb_isUseAVSync == null)
				cb_isUseAVSync = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseAVSync);
			return cb_isUseAVSync;
		}

		static bool n_IsUseAVSync (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseAVSync;
		}
#pragma warning restore 0169

		static Delegate cb_setUseAVSync_Z;
#pragma warning disable 0169
		static Delegate GetSetUseAVSync_ZHandler ()
		{
			if (cb_setUseAVSync_Z == null)
				cb_setUseAVSync_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseAVSync_Z);
			return cb_setUseAVSync_Z;
		}

		static void n_SetUseAVSync_Z (IntPtr jnienv, IntPtr native__this, bool av)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseAVSync = av;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseAVSync {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isUseAVSync' and count(parameter)=0]"
			[Register ("isUseAVSync", "()Z", "GetIsUseAVSyncHandler")]
			get {
				const string __id = "isUseAVSync.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUseAVSync' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseAVSync", "(Z)V", "GetSetUseAVSync_ZHandler")]
			set {
				const string __id = "setUseAVSync.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseMainRecording;
#pragma warning disable 0169
		static Delegate GetIsUseMainRecordingHandler ()
		{
			if (cb_isUseMainRecording == null)
				cb_isUseMainRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseMainRecording);
			return cb_isUseMainRecording;
		}

		static bool n_IsUseMainRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseMainRecording;
		}
#pragma warning restore 0169

		static Delegate cb_setUseMainRecording_Z;
#pragma warning disable 0169
		static Delegate GetSetUseMainRecording_ZHandler ()
		{
			if (cb_setUseMainRecording_Z == null)
				cb_setUseMainRecording_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseMainRecording_Z);
			return cb_setUseMainRecording_Z;
		}

		static void n_SetUseMainRecording_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseMainRecording = b;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseMainRecording {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isUseMainRecording' and count(parameter)=0]"
			[Register ("isUseMainRecording", "()Z", "GetIsUseMainRecordingHandler")]
			get {
				const string __id = "isUseMainRecording.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUseMainRecording' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseMainRecording", "(Z)V", "GetSetUseMainRecording_ZHandler")]
			set {
				const string __id = "setUseMainRecording.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseMainStreaming;
#pragma warning disable 0169
		static Delegate GetIsUseMainStreamingHandler ()
		{
			if (cb_isUseMainStreaming == null)
				cb_isUseMainStreaming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseMainStreaming);
			return cb_isUseMainStreaming;
		}

		static bool n_IsUseMainStreaming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseMainStreaming;
		}
#pragma warning restore 0169

		static Delegate cb_setUseMainStreaming_Z;
#pragma warning disable 0169
		static Delegate GetSetUseMainStreaming_ZHandler ()
		{
			if (cb_setUseMainStreaming_Z == null)
				cb_setUseMainStreaming_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseMainStreaming_Z);
			return cb_setUseMainStreaming_Z;
		}

		static void n_SetUseMainStreaming_Z (IntPtr jnienv, IntPtr native__this, bool b)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseMainStreaming = b;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseMainStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isUseMainStreaming' and count(parameter)=0]"
			[Register ("isUseMainStreaming", "()Z", "GetIsUseMainStreamingHandler")]
			get {
				const string __id = "isUseMainStreaming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUseMainStreaming' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseMainStreaming", "(Z)V", "GetSetUseMainStreaming_ZHandler")]
			set {
				const string __id = "setUseMainStreaming.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseSec;
#pragma warning disable 0169
		static Delegate GetIsUseSecHandler ()
		{
			if (cb_isUseSec == null)
				cb_isUseSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseSec);
			return cb_isUseSec;
		}

		static bool n_IsUseSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseSec;
		}
#pragma warning restore 0169

		static Delegate cb_setUseSec_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSec_ZHandler ()
		{
			if (cb_setUseSec_Z == null)
				cb_setUseSec_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseSec_Z);
			return cb_setUseSec_Z;
		}

		static void n_SetUseSec_Z (IntPtr jnienv, IntPtr native__this, bool sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseSec = sec;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isUseSec' and count(parameter)=0]"
			[Register ("isUseSec", "()Z", "GetIsUseSecHandler")]
			get {
				const string __id = "isUseSec.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUseSec' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseSec", "(Z)V", "GetSetUseSec_ZHandler")]
			set {
				const string __id = "setUseSec.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseSecControl;
#pragma warning disable 0169
		static Delegate GetIsUseSecControlHandler ()
		{
			if (cb_isUseSecControl == null)
				cb_isUseSecControl = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseSecControl);
			return cb_isUseSecControl;
		}

		static bool n_IsUseSecControl (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseSecControl;
		}
#pragma warning restore 0169

		static Delegate cb_setUseSecControl_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSecControl_ZHandler ()
		{
			if (cb_setUseSecControl_Z == null)
				cb_setUseSecControl_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseSecControl_Z);
			return cb_setUseSecControl_Z;
		}

		static void n_SetUseSecControl_Z (IntPtr jnienv, IntPtr native__this, bool control)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseSecControl = control;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseSecControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isUseSecControl' and count(parameter)=0]"
			[Register ("isUseSecControl", "()Z", "GetIsUseSecControlHandler")]
			get {
				const string __id = "isUseSecControl.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUseSecControl' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseSecControl", "(Z)V", "GetSetUseSecControl_ZHandler")]
			set {
				const string __id = "setUseSecControl.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseSecRecord;
#pragma warning disable 0169
		static Delegate GetIsUseSecRecordHandler ()
		{
			if (cb_isUseSecRecord == null)
				cb_isUseSecRecord = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseSecRecord);
			return cb_isUseSecRecord;
		}

		static bool n_IsUseSecRecord (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseSecRecord;
		}
#pragma warning restore 0169

		static Delegate cb_setUseSecRecord_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSecRecord_ZHandler ()
		{
			if (cb_setUseSecRecord_Z == null)
				cb_setUseSecRecord_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseSecRecord_Z);
			return cb_setUseSecRecord_Z;
		}

		static void n_SetUseSecRecord_Z (IntPtr jnienv, IntPtr native__this, bool sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseSecRecord = sec;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseSecRecord {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isUseSecRecord' and count(parameter)=0]"
			[Register ("isUseSecRecord", "()Z", "GetIsUseSecRecordHandler")]
			get {
				const string __id = "isUseSecRecord.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUseSecRecord' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseSecRecord", "(Z)V", "GetSetUseSecRecord_ZHandler")]
			set {
				const string __id = "setUseSecRecord.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseSecStreaming;
#pragma warning disable 0169
		static Delegate GetIsUseSecStreamingHandler ()
		{
			if (cb_isUseSecStreaming == null)
				cb_isUseSecStreaming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseSecStreaming);
			return cb_isUseSecStreaming;
		}

		static bool n_IsUseSecStreaming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseSecStreaming;
		}
#pragma warning restore 0169

		static Delegate cb_setUseSecStreaming_Z;
#pragma warning disable 0169
		static Delegate GetSetUseSecStreaming_ZHandler ()
		{
			if (cb_setUseSecStreaming_Z == null)
				cb_setUseSecStreaming_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseSecStreaming_Z);
			return cb_setUseSecStreaming_Z;
		}

		static void n_SetUseSecStreaming_Z (IntPtr jnienv, IntPtr native__this, bool sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseSecStreaming = sec;
		}
#pragma warning restore 0169

		public virtual unsafe bool UseSecStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='isUseSecStreaming' and count(parameter)=0]"
			[Register ("isUseSecStreaming", "()Z", "GetIsUseSecStreamingHandler")]
			get {
				const string __id = "isUseSecStreaming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUseSecStreaming' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseSecStreaming", "(Z)V", "GetSetUseSecStreaming_ZHandler")]
			set {
				const string __id = "setUseSecStreaming.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoAVCProfile;
#pragma warning disable 0169
		static Delegate GetGetVideoAVCProfileHandler ()
		{
			if (cb_getVideoAVCProfile == null)
				cb_getVideoAVCProfile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoAVCProfile);
			return cb_getVideoAVCProfile;
		}

		static int n_GetVideoAVCProfile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoAVCProfile;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoAVCProfile_I;
#pragma warning disable 0169
		static Delegate GetSetVideoAVCProfile_IHandler ()
		{
			if (cb_setVideoAVCProfile_I == null)
				cb_setVideoAVCProfile_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoAVCProfile_I);
			return cb_setVideoAVCProfile_I;
		}

		static void n_SetVideoAVCProfile_I (IntPtr jnienv, IntPtr native__this, int profile)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoAVCProfile = profile;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoAVCProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoAVCProfile' and count(parameter)=0]"
			[Register ("getVideoAVCProfile", "()I", "GetGetVideoAVCProfileHandler")]
			get {
				const string __id = "getVideoAVCProfile.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoAVCProfile' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoAVCProfile", "(I)V", "GetSetVideoAVCProfile_IHandler")]
			set {
				const string __id = "setVideoAVCProfile.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoBitrate;
#pragma warning disable 0169
		static Delegate GetGetVideoBitrateHandler ()
		{
			if (cb_getVideoBitrate == null)
				cb_getVideoBitrate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoBitrate);
			return cb_getVideoBitrate;
		}

		static int n_GetVideoBitrate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoBitrate;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoBitrate_I;
#pragma warning disable 0169
		static Delegate GetSetVideoBitrate_IHandler ()
		{
			if (cb_setVideoBitrate_I == null)
				cb_setVideoBitrate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoBitrate_I);
			return cb_setVideoBitrate_I;
		}

		static void n_SetVideoBitrate_I (IntPtr jnienv, IntPtr native__this, int nkbps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoBitrate = nkbps;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoBitrate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoBitrate' and count(parameter)=0]"
			[Register ("getVideoBitrate", "()I", "GetGetVideoBitrateHandler")]
			get {
				const string __id = "getVideoBitrate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoBitrate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoBitrate", "(I)V", "GetSetVideoBitrate_IHandler")]
			set {
				const string __id = "setVideoBitrate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoBitrateMode;
#pragma warning disable 0169
		static Delegate GetGetVideoBitrateModeHandler ()
		{
			if (cb_getVideoBitrateMode == null)
				cb_getVideoBitrateMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoBitrateMode);
			return cb_getVideoBitrateMode;
		}

		static int n_GetVideoBitrateMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoBitrateMode;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoBitrateMode_I;
#pragma warning disable 0169
		static Delegate GetSetVideoBitrateMode_IHandler ()
		{
			if (cb_setVideoBitrateMode_I == null)
				cb_setVideoBitrateMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoBitrateMode_I);
			return cb_setVideoBitrateMode_I;
		}

		static void n_SetVideoBitrateMode_I (IntPtr jnienv, IntPtr native__this, int bitrate_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoBitrateMode = bitrate_mode;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoBitrateMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoBitrateMode' and count(parameter)=0]"
			[Register ("getVideoBitrateMode", "()I", "GetGetVideoBitrateModeHandler")]
			get {
				const string __id = "getVideoBitrateMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoBitrateMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoBitrateMode", "(I)V", "GetSetVideoBitrateMode_IHandler")]
			set {
				const string __id = "setVideoBitrateMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoFramerate;
#pragma warning disable 0169
		static Delegate GetGetVideoFramerateHandler ()
		{
			if (cb_getVideoFramerate == null)
				cb_getVideoFramerate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoFramerate);
			return cb_getVideoFramerate;
		}

		static int n_GetVideoFramerate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoFramerate;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoFramerate_I;
#pragma warning disable 0169
		static Delegate GetSetVideoFramerate_IHandler ()
		{
			if (cb_setVideoFramerate_I == null)
				cb_setVideoFramerate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoFramerate_I);
			return cb_setVideoFramerate_I;
		}

		static void n_SetVideoFramerate_I (IntPtr jnienv, IntPtr native__this, int fps)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoFramerate = fps;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoFramerate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoFramerate' and count(parameter)=0]"
			[Register ("getVideoFramerate", "()I", "GetGetVideoFramerateHandler")]
			get {
				const string __id = "getVideoFramerate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoFramerate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoFramerate", "(I)V", "GetSetVideoFramerate_IHandler")]
			set {
				const string __id = "setVideoFramerate.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoHeight;
#pragma warning disable 0169
		static Delegate GetGetVideoHeightHandler ()
		{
			if (cb_getVideoHeight == null)
				cb_getVideoHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoHeight);
			return cb_getVideoHeight;
		}

		static int n_GetVideoHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoHeight' and count(parameter)=0]"
			[Register ("getVideoHeight", "()I", "GetGetVideoHeightHandler")]
			get {
				const string __id = "getVideoHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVideoKeyFrameInterval;
#pragma warning disable 0169
		static Delegate GetGetVideoKeyFrameIntervalHandler ()
		{
			if (cb_getVideoKeyFrameInterval == null)
				cb_getVideoKeyFrameInterval = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoKeyFrameInterval);
			return cb_getVideoKeyFrameInterval;
		}

		static int n_GetVideoKeyFrameInterval (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoKeyFrameInterval;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoKeyFrameInterval_I;
#pragma warning disable 0169
		static Delegate GetSetVideoKeyFrameInterval_IHandler ()
		{
			if (cb_setVideoKeyFrameInterval_I == null)
				cb_setVideoKeyFrameInterval_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoKeyFrameInterval_I);
			return cb_setVideoKeyFrameInterval_I;
		}

		static void n_SetVideoKeyFrameInterval_I (IntPtr jnienv, IntPtr native__this, int interval)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoKeyFrameInterval = interval;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoKeyFrameInterval {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoKeyFrameInterval' and count(parameter)=0]"
			[Register ("getVideoKeyFrameInterval", "()I", "GetGetVideoKeyFrameIntervalHandler")]
			get {
				const string __id = "getVideoKeyFrameInterval.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoKeyFrameInterval' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoKeyFrameInterval", "(I)V", "GetSetVideoKeyFrameInterval_IHandler")]
			set {
				const string __id = "setVideoKeyFrameInterval.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoMaxLatency;
#pragma warning disable 0169
		static Delegate GetGetVideoMaxLatencyHandler ()
		{
			if (cb_getVideoMaxLatency == null)
				cb_getVideoMaxLatency = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoMaxLatency);
			return cb_getVideoMaxLatency;
		}

		static int n_GetVideoMaxLatency (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoMaxLatency;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoMaxLatency_I;
#pragma warning disable 0169
		static Delegate GetSetVideoMaxLatency_IHandler ()
		{
			if (cb_setVideoMaxLatency_I == null)
				cb_setVideoMaxLatency_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoMaxLatency_I);
			return cb_setVideoMaxLatency_I;
		}

		static void n_SetVideoMaxLatency_I (IntPtr jnienv, IntPtr native__this, int ms)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoMaxLatency = ms;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoMaxLatency {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoMaxLatency' and count(parameter)=0]"
			[Register ("getVideoMaxLatency", "()I", "GetGetVideoMaxLatencyHandler")]
			get {
				const string __id = "getVideoMaxLatency.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoMaxLatency' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoMaxLatency", "(I)V", "GetSetVideoMaxLatency_IHandler")]
			set {
				const string __id = "setVideoMaxLatency.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoOrientation;
#pragma warning disable 0169
		static Delegate GetGetVideoOrientationHandler ()
		{
			if (cb_getVideoOrientation == null)
				cb_getVideoOrientation = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoOrientation);
			return cb_getVideoOrientation;
		}

		static int n_GetVideoOrientation (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoOrientation;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoOrientation_I;
#pragma warning disable 0169
		static Delegate GetSetVideoOrientation_IHandler ()
		{
			if (cb_setVideoOrientation_I == null)
				cb_setVideoOrientation_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoOrientation_I);
			return cb_setVideoOrientation_I;
		}

		static void n_SetVideoOrientation_I (IntPtr jnienv, IntPtr native__this, int angle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoOrientation = angle;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoOrientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoOrientation' and count(parameter)=0]"
			[Register ("getVideoOrientation", "()I", "GetGetVideoOrientationHandler")]
			get {
				const string __id = "getVideoOrientation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoOrientation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoOrientation", "(I)V", "GetSetVideoOrientation_IHandler")]
			set {
				const string __id = "setVideoOrientation.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoPreviewMode;
#pragma warning disable 0169
		static Delegate GetGetVideoPreviewModeHandler ()
		{
			if (cb_getVideoPreviewMode == null)
				cb_getVideoPreviewMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoPreviewMode);
			return cb_getVideoPreviewMode;
		}

		static int n_GetVideoPreviewMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoPreviewMode;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoPreviewMode_I;
#pragma warning disable 0169
		static Delegate GetSetVideoPreviewMode_IHandler ()
		{
			if (cb_setVideoPreviewMode_I == null)
				cb_setVideoPreviewMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoPreviewMode_I);
			return cb_setVideoPreviewMode_I;
		}

		static void n_SetVideoPreviewMode_I (IntPtr jnienv, IntPtr native__this, int mode_val)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoPreviewMode = mode_val;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoPreviewMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoPreviewMode' and count(parameter)=0]"
			[Register ("getVideoPreviewMode", "()I", "GetGetVideoPreviewModeHandler")]
			get {
				const string __id = "getVideoPreviewMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoPreviewMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoPreviewMode", "(I)V", "GetSetVideoPreviewMode_IHandler")]
			set {
				const string __id = "setVideoPreviewMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoPreviewModeCustomResolutionHeight;
#pragma warning disable 0169
		static Delegate GetGetVideoPreviewModeCustomResolutionHeightHandler ()
		{
			if (cb_getVideoPreviewModeCustomResolutionHeight == null)
				cb_getVideoPreviewModeCustomResolutionHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoPreviewModeCustomResolutionHeight);
			return cb_getVideoPreviewModeCustomResolutionHeight;
		}

		static int n_GetVideoPreviewModeCustomResolutionHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoPreviewModeCustomResolutionHeight;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoPreviewModeCustomResolutionHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoPreviewModeCustomResolutionHeight' and count(parameter)=0]"
			[Register ("getVideoPreviewModeCustomResolutionHeight", "()I", "GetGetVideoPreviewModeCustomResolutionHeightHandler")]
			get {
				const string __id = "getVideoPreviewModeCustomResolutionHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVideoPreviewModeCustomResolutionWidth;
#pragma warning disable 0169
		static Delegate GetGetVideoPreviewModeCustomResolutionWidthHandler ()
		{
			if (cb_getVideoPreviewModeCustomResolutionWidth == null)
				cb_getVideoPreviewModeCustomResolutionWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoPreviewModeCustomResolutionWidth);
			return cb_getVideoPreviewModeCustomResolutionWidth;
		}

		static int n_GetVideoPreviewModeCustomResolutionWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoPreviewModeCustomResolutionWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoPreviewModeCustomResolutionWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoPreviewModeCustomResolutionWidth' and count(parameter)=0]"
			[Register ("getVideoPreviewModeCustomResolutionWidth", "()I", "GetGetVideoPreviewModeCustomResolutionWidthHandler")]
			get {
				const string __id = "getVideoPreviewModeCustomResolutionWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getVideoResolution;
#pragma warning disable 0169
		static Delegate GetGetVideoResolutionHandler ()
		{
			if (cb_getVideoResolution == null)
				cb_getVideoResolution = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoResolution);
			return cb_getVideoResolution;
		}

		static IntPtr n_GetVideoResolution (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoResolution);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_;
#pragma warning disable 0169
		static Delegate GetSetVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_Handler ()
		{
			if (cb_setVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ == null)
				cb_setVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_);
			return cb_setVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_;
		}

		static void n_SetVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vr = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (native_vr, JniHandleOwnership.DoNotTransfer);
			__this.VideoResolution = vr;
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution VideoResolution {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoResolution' and count(parameter)=0]"
			[Register ("getVideoResolution", "()Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;", "GetGetVideoResolutionHandler")]
			get {
				const string __id = "getVideoResolution.()Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoResolution' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.CaptureVideoResolution']]"
			[Register ("setVideoResolution", "(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)V", "GetSetVideoResolution_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_Handler")]
			set {
				const string __id = "setVideoResolution.(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getVideoSecAVCProfile;
#pragma warning disable 0169
		static Delegate GetGetVideoSecAVCProfileHandler ()
		{
			if (cb_getVideoSecAVCProfile == null)
				cb_getVideoSecAVCProfile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoSecAVCProfile);
			return cb_getVideoSecAVCProfile;
		}

		static int n_GetVideoSecAVCProfile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSecAVCProfile;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoSecAVCProfile_I;
#pragma warning disable 0169
		static Delegate GetSetVideoSecAVCProfile_IHandler ()
		{
			if (cb_setVideoSecAVCProfile_I == null)
				cb_setVideoSecAVCProfile_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoSecAVCProfile_I);
			return cb_setVideoSecAVCProfile_I;
		}

		static void n_SetVideoSecAVCProfile_I (IntPtr jnienv, IntPtr native__this, int profile)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoSecAVCProfile = profile;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoSecAVCProfile {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoSecAVCProfile' and count(parameter)=0]"
			[Register ("getVideoSecAVCProfile", "()I", "GetGetVideoSecAVCProfileHandler")]
			get {
				const string __id = "getVideoSecAVCProfile.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoSecAVCProfile' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoSecAVCProfile", "(I)V", "GetSetVideoSecAVCProfile_IHandler")]
			set {
				const string __id = "setVideoSecAVCProfile.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoSecBitrateMode;
#pragma warning disable 0169
		static Delegate GetGetVideoSecBitrateModeHandler ()
		{
			if (cb_getVideoSecBitrateMode == null)
				cb_getVideoSecBitrateMode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoSecBitrateMode);
			return cb_getVideoSecBitrateMode;
		}

		static int n_GetVideoSecBitrateMode (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSecBitrateMode;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoSecBitrateMode_I;
#pragma warning disable 0169
		static Delegate GetSetVideoSecBitrateMode_IHandler ()
		{
			if (cb_setVideoSecBitrateMode_I == null)
				cb_setVideoSecBitrateMode_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoSecBitrateMode_I);
			return cb_setVideoSecBitrateMode_I;
		}

		static void n_SetVideoSecBitrateMode_I (IntPtr jnienv, IntPtr native__this, int bitrate_mode)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoSecBitrateMode = bitrate_mode;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoSecBitrateMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoSecBitrateMode' and count(parameter)=0]"
			[Register ("getVideoSecBitrateMode", "()I", "GetGetVideoSecBitrateModeHandler")]
			get {
				const string __id = "getVideoSecBitrateMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoSecBitrateMode' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoSecBitrateMode", "(I)V", "GetSetVideoSecBitrateMode_IHandler")]
			set {
				const string __id = "setVideoSecBitrateMode.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoSecMaxLatency;
#pragma warning disable 0169
		static Delegate GetGetVideoSecMaxLatencyHandler ()
		{
			if (cb_getVideoSecMaxLatency == null)
				cb_getVideoSecMaxLatency = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoSecMaxLatency);
			return cb_getVideoSecMaxLatency;
		}

		static int n_GetVideoSecMaxLatency (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoSecMaxLatency;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoSecMaxLatency_I;
#pragma warning disable 0169
		static Delegate GetSetVideoSecMaxLatency_IHandler ()
		{
			if (cb_setVideoSecMaxLatency_I == null)
				cb_setVideoSecMaxLatency_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetVideoSecMaxLatency_I);
			return cb_setVideoSecMaxLatency_I;
		}

		static void n_SetVideoSecMaxLatency_I (IntPtr jnienv, IntPtr native__this, int ms)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoSecMaxLatency = ms;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoSecMaxLatency {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoSecMaxLatency' and count(parameter)=0]"
			[Register ("getVideoSecMaxLatency", "()I", "GetGetVideoSecMaxLatencyHandler")]
			get {
				const string __id = "getVideoSecMaxLatency.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoSecMaxLatency' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setVideoSecMaxLatency", "(I)V", "GetSetVideoSecMaxLatency_IHandler")]
			set {
				const string __id = "setVideoSecMaxLatency.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoSrcFilePath;
#pragma warning disable 0169
		static Delegate GetGetVideoSrcFilePathHandler ()
		{
			if (cb_getVideoSrcFilePath == null)
				cb_getVideoSrcFilePath = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoSrcFilePath);
			return cb_getVideoSrcFilePath;
		}

		static IntPtr n_GetVideoSrcFilePath (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.VideoSrcFilePath);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoSrcFilePath_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetVideoSrcFilePath_Ljava_lang_String_Handler ()
		{
			if (cb_setVideoSrcFilePath_Ljava_lang_String_ == null)
				cb_setVideoSrcFilePath_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoSrcFilePath_Ljava_lang_String_);
			return cb_setVideoSrcFilePath_Ljava_lang_String_;
		}

		static void n_SetVideoSrcFilePath_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var path = JNIEnv.GetString (native_path, JniHandleOwnership.DoNotTransfer);
			__this.VideoSrcFilePath = path;
		}
#pragma warning restore 0169

		public virtual unsafe string VideoSrcFilePath {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoSrcFilePath' and count(parameter)=0]"
			[Register ("getVideoSrcFilePath", "()Ljava/lang/String;", "GetGetVideoSrcFilePathHandler")]
			get {
				const string __id = "getVideoSrcFilePath.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoSrcFilePath' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setVideoSrcFilePath", "(Ljava/lang/String;)V", "GetSetVideoSrcFilePath_Ljava_lang_String_Handler")]
			set {
				const string __id = "setVideoSrcFilePath.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVideoSupportedRes;
#pragma warning disable 0169
		static Delegate GetGetVideoSupportedResHandler ()
		{
			if (cb_getVideoSupportedRes == null)
				cb_getVideoSupportedRes = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoSupportedRes);
			return cb_getVideoSupportedRes;
		}

		static IntPtr n_GetVideoSupportedRes (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution>.ToLocalJniHandle (__this.VideoSupportedRes);
		}
#pragma warning restore 0169

		static Delegate cb_setVideoSupportedRes_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetVideoSupportedRes_Ljava_util_List_Handler ()
		{
			if (cb_setVideoSupportedRes_Ljava_util_List_ == null)
				cb_setVideoSupportedRes_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoSupportedRes_Ljava_util_List_);
			return cb_setVideoSupportedRes_Ljava_util_List_;
		}

		static void n_SetVideoSupportedRes_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_list)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var list = global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution>.FromJniHandle (native_list, JniHandleOwnership.DoNotTransfer);
			__this.VideoSupportedRes = list;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> VideoSupportedRes {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoSupportedRes' and count(parameter)=0]"
			[Register ("getVideoSupportedRes", "()Ljava/util/List;", "GetGetVideoSupportedResHandler")]
			get {
				const string __id = "getVideoSupportedRes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoSupportedRes' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;veg.mediacapture.sdk.MediaCaptureConfig.CaptureVideoResolution&gt;']]"
			[Register ("setVideoSupportedRes", "(Ljava/util/List;)V", "GetSetVideoSupportedRes_Ljava_util_List_Handler")]
			set {
				const string __id = "setVideoSupportedRes.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getVideoUseSrcFile;
#pragma warning disable 0169
		static Delegate GetGetVideoUseSrcFileHandler ()
		{
			if (cb_getVideoUseSrcFile == null)
				cb_getVideoUseSrcFile = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetVideoUseSrcFile);
			return cb_getVideoUseSrcFile;
		}

		static bool n_GetVideoUseSrcFile (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoUseSrcFile;
		}
#pragma warning restore 0169

		static Delegate cb_setVideoUseSrcFile_Z;
#pragma warning disable 0169
		static Delegate GetSetVideoUseSrcFile_ZHandler ()
		{
			if (cb_setVideoUseSrcFile_Z == null)
				cb_setVideoUseSrcFile_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetVideoUseSrcFile_Z);
			return cb_setVideoUseSrcFile_Z;
		}

		static void n_SetVideoUseSrcFile_Z (IntPtr jnienv, IntPtr native__this, bool use)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.VideoUseSrcFile = use;
		}
#pragma warning restore 0169

		public virtual unsafe bool VideoUseSrcFile {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoUseSrcFile' and count(parameter)=0]"
			[Register ("getVideoUseSrcFile", "()Z", "GetGetVideoUseSrcFileHandler")]
			get {
				const string __id = "getVideoUseSrcFile.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoUseSrcFile' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVideoUseSrcFile", "(Z)V", "GetSetVideoUseSrcFile_ZHandler")]
			set {
				const string __id = "setVideoUseSrcFile.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoWidth;
#pragma warning disable 0169
		static Delegate GetGetVideoWidthHandler ()
		{
			if (cb_getVideoWidth == null)
				cb_getVideoWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoWidth);
			return cb_getVideoWidth;
		}

		static int n_GetVideoWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoWidth;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoWidth' and count(parameter)=0]"
			[Register ("getVideoWidth", "()I", "GetGetVideoWidthHandler")]
			get {
				const string __id = "getVideoWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb__getStreamingOn_IZ;
#pragma warning disable 0169
		static Delegate Get_getStreamingOn_IZHandler ()
		{
			if (cb__getStreamingOn_IZ == null)
				cb__getStreamingOn_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_Z) n__getStreamingOn_IZ);
			return cb__getStreamingOn_IZ;
		}

		static bool n__getStreamingOn_IZ (IntPtr jnienv, IntPtr native__this, int streamer_type, bool is_sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this._getStreamingOn (streamer_type, is_sec);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='_getStreamingOn' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("_getStreamingOn", "(IZ)Z", "Get_getStreamingOn_IZHandler")]
		public virtual unsafe bool _getStreamingOn (int streamer_type, bool is_sec)
		{
			const string __id = "_getStreamingOn.(IZ)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (is_sec);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb__setStreamingOn_IZZ;
#pragma warning disable 0169
		static Delegate Get_setStreamingOn_IZZHandler ()
		{
			if (cb__setStreamingOn_IZZ == null)
				cb__setStreamingOn_IZZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZZ_V) n__setStreamingOn_IZZ);
			return cb__setStreamingOn_IZZ;
		}

		static void n__setStreamingOn_IZZ (IntPtr jnienv, IntPtr native__this, int streamer_type, bool is_sec, bool set_on)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this._setStreamingOn (streamer_type, is_sec, set_on);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='_setStreamingOn' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='boolean'] and parameter[3][@type='boolean']]"
		[Register ("_setStreamingOn", "(IZZ)V", "Get_setStreamingOn_IZZHandler")]
		public virtual unsafe void _setStreamingOn (int streamer_type, bool is_sec, bool set_on)
		{
			const string __id = "_setStreamingOn.(IZZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (is_sec);
				__args [2] = new JniArgumentValue (set_on);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_addOverlay_Landroid_graphics_Bitmap_arrayF;
#pragma warning disable 0169
		static Delegate GetAddOverlay_Landroid_graphics_Bitmap_arrayFHandler ()
		{
			if (cb_addOverlay_Landroid_graphics_Bitmap_arrayF == null)
				cb_addOverlay_Landroid_graphics_Bitmap_arrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_L) n_AddOverlay_Landroid_graphics_Bitmap_arrayF);
			return cb_addOverlay_Landroid_graphics_Bitmap_arrayF;
		}

		static IntPtr n_AddOverlay_Landroid_graphics_Bitmap_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_bitmap, IntPtr native_mapMatrix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bitmap = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (native_bitmap, JniHandleOwnership.DoNotTransfer);
			var mapMatrix = (float[]) JNIEnv.GetArray (native_mapMatrix, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.AddOverlay (bitmap, mapMatrix));
			if (mapMatrix != null)
				JNIEnv.CopyArray (mapMatrix, native_mapMatrix);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='addOverlay' and count(parameter)=2 and parameter[1][@type='android.graphics.Bitmap'] and parameter[2][@type='float[]']]"
		[Register ("addOverlay", "(Landroid/graphics/Bitmap;[F)Lveg/mediacapture/sdk/MediaCaptureConfig$Overlay;", "GetAddOverlay_Landroid_graphics_Bitmap_arrayFHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay AddOverlay (global::Android.Graphics.Bitmap bitmap, float[] mapMatrix)
		{
			const string __id = "addOverlay.(Landroid/graphics/Bitmap;[F)Lveg/mediacapture/sdk/MediaCaptureConfig$Overlay;";
			IntPtr native_mapMatrix = JNIEnv.NewArray (mapMatrix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((bitmap == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bitmap).Handle);
				__args [1] = new JniArgumentValue (native_mapMatrix);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (mapMatrix != null) {
					JNIEnv.CopyArray (native_mapMatrix, mapMatrix);
					JNIEnv.DeleteLocalRef (native_mapMatrix);
				}
				global::System.GC.KeepAlive (bitmap);
				global::System.GC.KeepAlive (mapMatrix);
			}
		}

		static Delegate cb_getPort_I;
#pragma warning disable 0169
		static Delegate GetGetPort_IHandler ()
		{
			if (cb_getPort_I == null)
				cb_getPort_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetPort_I);
			return cb_getPort_I;
		}

		static int n_GetPort_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPort (streamer_type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getPort' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPort", "(I)I", "GetGetPort_IHandler")]
		public virtual unsafe int GetPort (int streamer_type)
		{
			const string __id = "getPort.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPortSec_I;
#pragma warning disable 0169
		static Delegate GetGetPortSec_IHandler ()
		{
			if (cb_getPortSec_I == null)
				cb_getPortSec_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetPortSec_I);
			return cb_getPortSec_I;
		}

		static int n_GetPortSec_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPortSec (streamer_type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getPortSec' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPortSec", "(I)I", "GetGetPortSec_IHandler")]
		public virtual unsafe int GetPortSec (int streamer_type)
		{
			const string __id = "getPortSec.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getUrl_I;
#pragma warning disable 0169
		static Delegate GetGetUrl_IHandler ()
		{
			if (cb_getUrl_I == null)
				cb_getUrl_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetUrl_I);
			return cb_getUrl_I;
		}

		static IntPtr n_GetUrl_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetUrl (streamer_type));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getUrl' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUrl", "(I)Ljava/lang/String;", "GetGetUrl_IHandler")]
		public virtual unsafe string GetUrl (int streamer_type)
		{
			const string __id = "getUrl.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getUrlSec_I;
#pragma warning disable 0169
		static Delegate GetGetUrlSec_IHandler ()
		{
			if (cb_getUrlSec_I == null)
				cb_getUrlSec_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetUrlSec_I);
			return cb_getUrlSec_I;
		}

		static IntPtr n_GetUrlSec_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetUrlSec (streamer_type));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getUrlSec' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getUrlSec", "(I)Ljava/lang/String;", "GetGetUrlSec_IHandler")]
		public virtual unsafe string GetUrlSec (int streamer_type)
		{
			const string __id = "getUrlSec.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getVideoHeight_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_;
#pragma warning disable 0169
		static Delegate GetGetVideoHeight_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_Handler ()
		{
			if (cb_getVideoHeight_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ == null)
				cb_getVideoHeight_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetVideoHeight_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_);
			return cb_getVideoHeight_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_;
		}

		static int n_GetVideoHeight_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vr = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (native_vr, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetVideoHeight (vr);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoHeight' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.CaptureVideoResolution']]"
		[Register ("getVideoHeight", "(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)I", "GetGetVideoHeight_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_Handler")]
		public virtual unsafe int GetVideoHeight (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution vr)
		{
			const string __id = "getVideoHeight.(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((vr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vr).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (vr);
			}
		}

		static Delegate cb_getVideoTimestampType;
#pragma warning disable 0169
		static Delegate GetGetVideoTimestampTypeHandler ()
		{
			if (cb_getVideoTimestampType == null)
				cb_getVideoTimestampType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoTimestampType);
			return cb_getVideoTimestampType;
		}

		static IntPtr n_GetVideoTimestampType (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetVideoTimestampType ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoTimestampType' and count(parameter)=0]"
		[Register ("getVideoTimestampType", "()Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;", "GetGetVideoTimestampTypeHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType GetVideoTimestampType ()
		{
			const string __id = "getVideoTimestampType.()Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getVideoWidth_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_;
#pragma warning disable 0169
		static Delegate GetGetVideoWidth_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_Handler ()
		{
			if (cb_getVideoWidth_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ == null)
				cb_getVideoWidth_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetVideoWidth_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_);
			return cb_getVideoWidth_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_;
		}

		static int n_GetVideoWidth_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vr)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vr = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution> (native_vr, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetVideoWidth (vr);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='getVideoWidth' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.CaptureVideoResolution']]"
		[Register ("getVideoWidth", "(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)I", "GetGetVideoWidth_Lveg_mediacapture_sdk_MediaCaptureConfig_CaptureVideoResolution_Handler")]
		public virtual unsafe int GetVideoWidth (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.CaptureVideoResolution vr)
		{
			const string __id = "getVideoWidth.(Lveg/mediacapture/sdk/MediaCaptureConfig$CaptureVideoResolution;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((vr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vr).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (vr);
			}
		}

		static Delegate cb_print;
#pragma warning disable 0169
		static Delegate GetPrintHandler ()
		{
			if (cb_print == null)
				cb_print = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Print);
			return cb_print;
		}

		static void n_Print (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Print ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='print' and count(parameter)=0]"
		[Register ("print", "()V", "GetPrintHandler")]
		public virtual unsafe void Print ()
		{
			const string __id = "print.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeOverlay_Lveg_mediacapture_sdk_MediaCaptureConfig_Overlay_;
#pragma warning disable 0169
		static Delegate GetRemoveOverlay_Lveg_mediacapture_sdk_MediaCaptureConfig_Overlay_Handler ()
		{
			if (cb_removeOverlay_Lveg_mediacapture_sdk_MediaCaptureConfig_Overlay_ == null)
				cb_removeOverlay_Lveg_mediacapture_sdk_MediaCaptureConfig_Overlay_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RemoveOverlay_Lveg_mediacapture_sdk_MediaCaptureConfig_Overlay_);
			return cb_removeOverlay_Lveg_mediacapture_sdk_MediaCaptureConfig_Overlay_;
		}

		static void n_RemoveOverlay_Lveg_mediacapture_sdk_MediaCaptureConfig_Overlay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_overlay)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var overlay = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay> (native_overlay, JniHandleOwnership.DoNotTransfer);
			__this.RemoveOverlay (overlay);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='removeOverlay' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.Overlay']]"
		[Register ("removeOverlay", "(Lveg/mediacapture/sdk/MediaCaptureConfig$Overlay;)V", "GetRemoveOverlay_Lveg_mediacapture_sdk_MediaCaptureConfig_Overlay_Handler")]
		public virtual unsafe void RemoveOverlay (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.Overlay overlay)
		{
			const string __id = "removeOverlay.(Lveg/mediacapture/sdk/MediaCaptureConfig$Overlay;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((overlay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) overlay).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (overlay);
			}
		}

		static Delegate cb_resetToDefault;
#pragma warning disable 0169
		static Delegate GetResetToDefaultHandler ()
		{
			if (cb_resetToDefault == null)
				cb_resetToDefault = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResetToDefault);
			return cb_resetToDefault;
		}

		static void n_ResetToDefault (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetToDefault ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='resetToDefault' and count(parameter)=0]"
		[Register ("resetToDefault", "()V", "GetResetToDefaultHandler")]
		public virtual unsafe void ResetToDefault ()
		{
			const string __id = "resetToDefault.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCustomVideoResolution_II;
#pragma warning disable 0169
		static Delegate GetSetCustomVideoResolution_IIHandler ()
		{
			if (cb_setCustomVideoResolution_II == null)
				cb_setCustomVideoResolution_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetCustomVideoResolution_II);
			return cb_setCustomVideoResolution_II;
		}

		static void n_SetCustomVideoResolution_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCustomVideoResolution (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setCustomVideoResolution' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCustomVideoResolution", "(II)V", "GetSetCustomVideoResolution_IIHandler")]
		public virtual unsafe void SetCustomVideoResolution (int width, int height)
		{
			const string __id = "setCustomVideoResolution.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMulticast_ZLjava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSetMulticast_ZLjava_lang_String_IHandler ()
		{
			if (cb_setMulticast_ZLjava_lang_String_I == null)
				cb_setMulticast_ZLjava_lang_String_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZLI_V) n_SetMulticast_ZLjava_lang_String_I);
			return cb_setMulticast_ZLjava_lang_String_I;
		}

		static void n_SetMulticast_ZLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, bool enabled, IntPtr native_ip, int ttl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ip = JNIEnv.GetString (native_ip, JniHandleOwnership.DoNotTransfer);
			__this.SetMulticast (enabled, ip, ttl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setMulticast' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setMulticast", "(ZLjava/lang/String;I)V", "GetSetMulticast_ZLjava_lang_String_IHandler")]
		public virtual unsafe void SetMulticast (bool enabled, string ip, int ttl)
		{
			const string __id = "setMulticast.(ZLjava/lang/String;I)V";
			IntPtr native_ip = JNIEnv.NewString (ip);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (enabled);
				__args [1] = new JniArgumentValue (native_ip);
				__args [2] = new JniArgumentValue (ttl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
			}
		}

		static Delegate cb_setSecureStreaming_ZLjava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSecureStreaming_ZLjava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_setSecureStreaming_ZLjava_lang_String_Ljava_lang_String_ == null)
				cb_setSecureStreaming_ZLjava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZLL_V) n_SetSecureStreaming_ZLjava_lang_String_Ljava_lang_String_);
			return cb_setSecureStreaming_ZLjava_lang_String_Ljava_lang_String_;
		}

		static void n_SetSecureStreaming_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool enabled, IntPtr native_cert, IntPtr native_key)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cert = JNIEnv.GetString (native_cert, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.SetSecureStreaming (enabled, cert, key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setSecureStreaming' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("setSecureStreaming", "(ZLjava/lang/String;Ljava/lang/String;)V", "GetSetSecureStreaming_ZLjava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void SetSecureStreaming (bool enabled, string cert, string key)
		{
			const string __id = "setSecureStreaming.(ZLjava/lang/String;Ljava/lang/String;)V";
			IntPtr native_cert = JNIEnv.NewString (cert);
			IntPtr native_key = JNIEnv.NewString (key);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (enabled);
				__args [1] = new JniArgumentValue (native_cert);
				__args [2] = new JniArgumentValue (native_key);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_cert);
				JNIEnv.DeleteLocalRef (native_key);
			}
		}

		static Delegate cb_setUrl_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrl_ILjava_lang_String_Handler ()
		{
			if (cb_setUrl_ILjava_lang_String_ == null)
				cb_setUrl_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetUrl_ILjava_lang_String_);
			return cb_setUrl_ILjava_lang_String_;
		}

		static void n_SetUrl_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int streamer_type, IntPtr native_url)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetUrl (streamer_type, url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUrl' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setUrl", "(ILjava/lang/String;)V", "GetSetUrl_ILjava_lang_String_Handler")]
		public virtual unsafe void SetUrl (int streamer_type, string url)
		{
			const string __id = "setUrl.(ILjava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_setUrlSec_ILjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetUrlSec_ILjava_lang_String_Handler ()
		{
			if (cb_setUrlSec_ILjava_lang_String_ == null)
				cb_setUrlSec_ILjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIL_V) n_SetUrlSec_ILjava_lang_String_);
			return cb_setUrlSec_ILjava_lang_String_;
		}

		static void n_SetUrlSec_ILjava_lang_String_ (IntPtr jnienv, IntPtr native__this, int streamer_type, IntPtr native_url)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var url = JNIEnv.GetString (native_url, JniHandleOwnership.DoNotTransfer);
			__this.SetUrlSec (streamer_type, url);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setUrlSec' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String']]"
		[Register ("setUrlSec", "(ILjava/lang/String;)V", "GetSetUrlSec_ILjava_lang_String_Handler")]
		public virtual unsafe void SetUrlSec (int streamer_type, string url)
		{
			const string __id = "setUrlSec.(ILjava/lang/String;)V";
			IntPtr native_url = JNIEnv.NewString (url);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (native_url);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_url);
			}
		}

		static Delegate cb_setVideoPreviewModeCustomResolution_II;
#pragma warning disable 0169
		static Delegate GetSetVideoPreviewModeCustomResolution_IIHandler ()
		{
			if (cb_setVideoPreviewModeCustomResolution_II == null)
				cb_setVideoPreviewModeCustomResolution_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_SetVideoPreviewModeCustomResolution_II);
			return cb_setVideoPreviewModeCustomResolution_II;
		}

		static void n_SetVideoPreviewModeCustomResolution_II (IntPtr jnienv, IntPtr native__this, int w, int h)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoPreviewModeCustomResolution (w, h);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoPreviewModeCustomResolution' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setVideoPreviewModeCustomResolution", "(II)V", "GetSetVideoPreviewModeCustomResolution_IIHandler")]
		public virtual unsafe void SetVideoPreviewModeCustomResolution (int w, int h)
		{
			const string __id = "setVideoPreviewModeCustomResolution.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (w);
				__args [1] = new JniArgumentValue (h);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVideoTimestampType_Lveg_mediacapture_sdk_MediaCaptureConfig_VideoTimestampType_;
#pragma warning disable 0169
		static Delegate GetSetVideoTimestampType_Lveg_mediacapture_sdk_MediaCaptureConfig_VideoTimestampType_Handler ()
		{
			if (cb_setVideoTimestampType_Lveg_mediacapture_sdk_MediaCaptureConfig_VideoTimestampType_ == null)
				cb_setVideoTimestampType_Lveg_mediacapture_sdk_MediaCaptureConfig_VideoTimestampType_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetVideoTimestampType_Lveg_mediacapture_sdk_MediaCaptureConfig_VideoTimestampType_);
			return cb_setVideoTimestampType_Lveg_mediacapture_sdk_MediaCaptureConfig_VideoTimestampType_;
		}

		static void n_SetVideoTimestampType_Lveg_mediacapture_sdk_MediaCaptureConfig_VideoTimestampType_ (IntPtr jnienv, IntPtr native__this, IntPtr native_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var type = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType> (native_type, JniHandleOwnership.DoNotTransfer);
			__this.SetVideoTimestampType (type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCaptureConfig']/method[@name='setVideoTimestampType' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig.VideoTimestampType']]"
		[Register ("setVideoTimestampType", "(Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;)V", "GetSetVideoTimestampType_Lveg_mediacapture_sdk_MediaCaptureConfig_VideoTimestampType_Handler")]
		public virtual unsafe void SetVideoTimestampType (global::Veg.Mediacapture.Sdk.MediaCaptureConfig.VideoTimestampType type)
		{
			const string __id = "setVideoTimestampType.(Lveg/mediacapture/sdk/MediaCaptureConfig$VideoTimestampType;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (type);
			}
		}

	}
}
