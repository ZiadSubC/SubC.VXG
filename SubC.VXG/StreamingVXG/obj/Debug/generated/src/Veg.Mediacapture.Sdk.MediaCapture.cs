using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture", DoNotGenerateAcw=true)]
	public partial class MediaCapture : global::Android.Widget.FrameLayout, global::Android.Graphics.SurfaceTexture.IOnFrameAvailableListener, global::Android.Views.ISurfaceHolderCallback, global::Veg.Mediacapture.Sdk.IInternalDataCallback {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='DISABLE_CAMERA']"
		[Register ("DISABLE_CAMERA")]
		public static bool DisableCamera {
			get {
				const string __id = "DISABLE_CAMERA.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "DISABLE_CAMERA.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='FILTER_BLACK_WHITE']"
		[Register ("FILTER_BLACK_WHITE")]
		public const int FilterBlackWhite = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='FILTER_BLUR']"
		[Register ("FILTER_BLUR")]
		public const int FilterBlur = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='FILTER_EDGE_DETECT']"
		[Register ("FILTER_EDGE_DETECT")]
		public const int FilterEdgeDetect = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='FILTER_EMBOSS']"
		[Register ("FILTER_EMBOSS")]
		public const int FilterEmboss = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='FILTER_NONE']"
		[Register ("FILTER_NONE")]
		public const int FilterNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='FILTER_SHARPEN']"
		[Register ("FILTER_SHARPEN")]
		public const int FilterSharpen = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MAX_DURATION_RESTART_SEC']"
		[Register ("MAX_DURATION_RESTART_SEC")]
		public static long MaxDurationRestartSec {
			get {
				const string __id = "MAX_DURATION_RESTART_SEC.J";

				var __v = _members.StaticFields.GetInt64Value (__id);
				return __v;
			}
			set {
				const string __id = "MAX_DURATION_RESTART_SEC.J";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MNEW_VERSION']"
		[Register ("MNEW_VERSION")]
		public const int MnewVersion = (int) 21;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_DURATION_CHANGE']"
		[Register ("MSG_APP_DURATION_CHANGE")]
		public const int MsgAppDurationChange = (int) 1236;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_REC_STATE']"
		[Register ("MSG_APP_REC_STATE")]
		public const int MsgAppRecState = (int) 1234;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_REC_STATE_START']"
		[Register ("MSG_APP_REC_STATE_START")]
		public const int MsgAppRecStateStart = (int) 1243;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_SERVICE_DOCUMENT_STATE']"
		[Register ("MSG_APP_SERVICE_DOCUMENT_STATE")]
		public const int MsgAppServiceDocumentState = (int) 1238;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_SERVICE_STATE']"
		[Register ("MSG_APP_SERVICE_STATE")]
		public const int MsgAppServiceState = (int) 1237;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_SERVICE_STORAGE']"
		[Register ("MSG_APP_SERVICE_STORAGE")]
		public const int MsgAppServiceStorage = (int) 1240;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_SERVICE_WAIT_FINISH']"
		[Register ("MSG_APP_SERVICE_WAIT_FINISH")]
		public const int MsgAppServiceWaitFinish = (int) 1239;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_STORAGE_PREPARE']"
		[Register ("MSG_APP_STORAGE_PREPARE")]
		public const int MsgAppStoragePrepare = (int) 1241;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_APP_ZOOM_STATE']"
		[Register ("MSG_APP_ZOOM_STATE")]
		public const int MsgAppZoomState = (int) 1235;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_CAPTURE_NOTIFY_CODE']"
		[Register ("MSG_CAPTURE_NOTIFY_CODE")]
		public const int MsgCaptureNotifyCode = (int) 1245;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_SET_SURFACE_TEXTURE']"
		[Register ("MSG_SET_SURFACE_TEXTURE")]
		public const int MsgSetSurfaceTexture = (int) 1242;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='MSG_SET_SURFACE_TEXTURE_CHANGED']"
		[Register ("MSG_SET_SURFACE_TEXTURE_CHANGED")]
		public const int MsgSetSurfaceTextureChanged = (int) 1244;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='PERMISSION_CODE']"
		[Register ("PERMISSION_CODE")]
		public const int PermissionCode = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='SOURCE_AUDIO_PUSH']"
		[Register ("SOURCE_AUDIO_PUSH")]
		public const int SourceAudioPush = (int) 171;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='USE_FFMPEG_0_10']"
		[Register ("USE_FFMPEG_0_10")]
		public const bool UseFfmpeg010 = (bool) false;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='USE_RTSP_SERVER']"
		[Register ("USE_RTSP_SERVER")]
		public bool UseRtspServer {
			get {
				const string __id = "USE_RTSP_SERVER.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "USE_RTSP_SERVER.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='handler_msg']"
		[Register ("handler_msg")]
		public global::Veg.Mediacapture.Sdk.MediaCapture.MediaCaptureHandler HandlerMsg {
			get {
				const string __id = "handler_msg.Lveg/mediacapture/sdk/MediaCapture$MediaCaptureHandler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.MediaCaptureHandler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "handler_msg.Lveg/mediacapture/sdk/MediaCapture$MediaCaptureHandler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mCachedLicense']"
		[Register ("mCachedLicense")]
		protected static string MCachedLicense {
			get {
				const string __id = "mCachedLicense.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCachedLicense.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mCachedLicenseName']"
		[Register ("mCachedLicenseName")]
		protected static string MCachedLicenseName {
			get {
				const string __id = "mCachedLicenseName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCachedLicenseName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mCallback']"
		[Register ("mCallback")]
		public global::Veg.Mediacapture.Sdk.IMediaCaptureCallback MCallback {
			get {
				const string __id = "mCallback.Lveg/mediacapture/sdk/MediaCaptureCallback;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IMediaCaptureCallback> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCallback.Lveg/mediacapture/sdk/MediaCaptureCallback;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mCaptureThread']"
		[Register ("mCaptureThread")]
		protected global::Java.Lang.Thread MCaptureThread {
			get {
				const string __id = "mCaptureThread.Ljava/lang/Thread;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCaptureThread.Ljava/lang/Thread;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mConfig']"
		[Register ("mConfig")]
		protected global::Veg.Mediacapture.Sdk.MediaCaptureConfig MConfig {
			get {
				const string __id = "mConfig.Lveg/mediacapture/sdk/MediaCaptureConfig;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mConfig.Lveg/mediacapture/sdk/MediaCaptureConfig;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mContext']"
		[Register ("mContext")]
		protected static global::Android.Content.Context MContext {
			get {
				const string __id = "mContext.Landroid/content/Context;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContext.Landroid/content/Context;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mIS_WINDOW']"
		[Register ("mIS_WINDOW")]
		public bool MISWINDOW {
			get {
				const string __id = "mIS_WINDOW.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mIS_WINDOW.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mLicenseBytes']"
		[Register ("mLicenseBytes")]
		protected static IList<byte> MLicenseBytes {
			get {
				const string __id = "mLicenseBytes.[B";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<byte>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLicenseBytes.[B";

				IntPtr native_value = global::Android.Runtime.JavaArray<byte>.ToLocalJniHandle (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mMediaExtractorThread']"
		[Register ("mMediaExtractorThread")]
		protected global::Java.Lang.Thread MMediaExtractorThread {
			get {
				const string __id = "mMediaExtractorThread.Ljava/lang/Thread;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMediaExtractorThread.Ljava/lang/Thread;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mPackageName']"
		[Register ("mPackageName")]
		protected static string MPackageName {
			get {
				const string __id = "mPackageName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPackageName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='mSecMediaExtractorThread']"
		[Register ("mSecMediaExtractorThread")]
		protected global::Java.Lang.Thread MSecMediaExtractorThread {
			get {
				const string __id = "mSecMediaExtractorThread.Ljava/lang/Thread;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Thread> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSecMediaExtractorThread.Ljava/lang/Thread;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='m_record_new_segment']"
		[Register ("m_record_new_segment")]
		public bool MRecordNewSegment {
			get {
				const string __id = "m_record_new_segment.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "m_record_new_segment.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='m_record_new_segment_sec']"
		[Register ("m_record_new_segment_sec")]
		public bool MRecordNewSegmentSec {
			get {
				const string __id = "m_record_new_segment_sec.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "m_record_new_segment_sec.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='sNETWORK_ON']"
		[Register ("sNETWORK_ON")]
		public static bool SNETWORKON {
			get {
				const string __id = "sNETWORK_ON.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "sNETWORK_ON.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='sRECORDING_ON']"
		[Register ("sRECORDING_ON")]
		public static bool SRECORDINGON {
			get {
				const string __id = "sRECORDING_ON.Z";

				var __v = _members.StaticFields.GetBooleanValue (__id);
				return __v;
			}
			set {
				const string __id = "sRECORDING_ON.Z";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='sREC_STATUS']"
		[Register ("sREC_STATUS")]
		public static int SRECSTATUS {
			get {
				const string __id = "sREC_STATUS.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "sREC_STATUS.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='sREC_STATUS_SEC']"
		[Register ("sREC_STATUS_SEC")]
		public static int SRECSTATUSSEC {
			get {
				const string __id = "sREC_STATUS_SEC.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "sREC_STATUS_SEC.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='sSTREAM_STATUS']"
		[Register ("sSTREAM_STATUS")]
		public static int SSTREAMSTATUS {
			get {
				const string __id = "sSTREAM_STATUS.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "sSTREAM_STATUS.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='sSTREAM_STATUS_RTSP']"
		[Register ("sSTREAM_STATUS_RTSP")]
		public static int SSTREAMSTATUSRTSP {
			get {
				const string __id = "sSTREAM_STATUS_RTSP.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "sSTREAM_STATUS_RTSP.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='sSTREAM_STATUS_SEC']"
		[Register ("sSTREAM_STATUS_SEC")]
		public static int SSTREAMSTATUSSEC {
			get {
				const string __id = "sSTREAM_STATUS_SEC.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "sSTREAM_STATUS_SEC.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_duration']"
		[Register ("stat_duration")]
		public long StatDuration {
			get {
				const string __id = "stat_duration.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stat_duration.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_duration_sec']"
		[Register ("stat_duration_sec")]
		public long StatDurationSec {
			get {
				const string __id = "stat_duration_sec.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stat_duration_sec.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_duration_total']"
		[Register ("stat_duration_total")]
		public long StatDurationTotal {
			get {
				const string __id = "stat_duration_total.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stat_duration_total.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_duration_total_sec']"
		[Register ("stat_duration_total_sec")]
		public long StatDurationTotalSec {
			get {
				const string __id = "stat_duration_total_sec.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stat_duration_total_sec.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_file_name']"
		[Register ("stat_file_name")]
		public string StatFileName {
			get {
				const string __id = "stat_file_name.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stat_file_name.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_file_name_sec']"
		[Register ("stat_file_name_sec")]
		public string StatFileNameSec {
			get {
				const string __id = "stat_file_name_sec.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stat_file_name_sec.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_file_name_stopped']"
		[Register ("stat_file_name_stopped")]
		public string StatFileNameStopped {
			get {
				const string __id = "stat_file_name_stopped.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stat_file_name_stopped.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_file_name_stopped_sec']"
		[Register ("stat_file_name_stopped_sec")]
		public string StatFileNameStoppedSec {
			get {
				const string __id = "stat_file_name_stopped_sec.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "stat_file_name_stopped_sec.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_file_size']"
		[Register ("stat_file_size")]
		public long StatFileSize {
			get {
				const string __id = "stat_file_size.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stat_file_size.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_file_size_sec']"
		[Register ("stat_file_size_sec")]
		public long StatFileSizeSec {
			get {
				const string __id = "stat_file_size_sec.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stat_file_size_sec.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_file_size_total']"
		[Register ("stat_file_size_total")]
		public long StatFileSizeTotal {
			get {
				const string __id = "stat_file_size_total.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stat_file_size_total.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='stat_file_size_total_sec']"
		[Register ("stat_file_size_total_sec")]
		public long StatFileSizeTotalSec {
			get {
				const string __id = "stat_file_size_total_sec.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "stat_file_size_total_sec.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/field[@name='waitStartOpenThread']"
		[Register ("waitStartOpenThread")]
		protected global::Veg.Mediacapture.Sdk.MediaCapture.WaitNotify WaitStartOpenThread {
			get {
				const string __id = "waitStartOpenThread.Lveg/mediacapture/sdk/MediaCapture$WaitNotify;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.WaitNotify> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "waitStartOpenThread.Lveg/mediacapture/sdk/MediaCapture$WaitNotify;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.AdaptiveBitrateControl']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$AdaptiveBitrateControl", DoNotGenerateAcw=true)]
		public partial class AdaptiveBitrateControl : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$AdaptiveBitrateControl", typeof (AdaptiveBitrateControl));

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

			protected AdaptiveBitrateControl (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.AdaptiveBitrateControl']/constructor[@name='MediaCapture.AdaptiveBitrateControl' and count(parameter)=2 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture'] and parameter[2][@type='boolean']]"
			[Register (".ctor", "(Lveg/mediacapture/sdk/MediaCapture;Z)V", "")]
			public unsafe AdaptiveBitrateControl (global::Veg.Mediacapture.Sdk.MediaCapture __self, bool is_sec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";Z)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue (is_sec);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

			static Delegate cb_putA_II;
#pragma warning disable 0169
			static Delegate GetPutA_IIHandler ()
			{
				if (cb_putA_II == null)
					cb_putA_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_PutA_II);
				return cb_putA_II;
			}

			static void n_PutA_II (IntPtr jnienv, IntPtr native__this, int size, int frames_in_buf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.AdaptiveBitrateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PutA (size, frames_in_buf);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.AdaptiveBitrateControl']/method[@name='putA' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("putA", "(II)V", "GetPutA_IIHandler")]
			public virtual unsafe void PutA (int size, int frames_in_buf)
			{
				const string __id = "putA.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (size);
					__args [1] = new JniArgumentValue (frames_in_buf);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_putV_II;
#pragma warning disable 0169
			static Delegate GetPutV_IIHandler ()
			{
				if (cb_putV_II == null)
					cb_putV_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_V) n_PutV_II);
				return cb_putV_II;
			}

			static void n_PutV_II (IntPtr jnienv, IntPtr native__this, int size, int frames_in_buf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.AdaptiveBitrateControl> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.PutV (size, frames_in_buf);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.AdaptiveBitrateControl']/method[@name='putV' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
			[Register ("putV", "(II)V", "GetPutV_IIHandler")]
			public virtual unsafe void PutV (int size, int frames_in_buf)
			{
				const string __id = "putV.(II)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue (size);
					__args [1] = new JniArgumentValue (frames_in_buf);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes", DoNotGenerateAcw=true)]
		public sealed partial class CaptureNotifyCodes : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_CLOSED']"
			[Register ("CAP_CLOSED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapClosed {
				get {
					const string __id = "CAP_CLOSED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_ERROR']"
			[Register ("CAP_ERROR")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapError {
				get {
					const string __id = "CAP_ERROR.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_FILESTREAM_START_FAILED']"
			[Register ("CAP_FILESTREAM_START_FAILED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapFilestreamStartFailed {
				get {
					const string __id = "CAP_FILESTREAM_START_FAILED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_OPENED']"
			[Register ("CAP_OPENED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapOpened {
				get {
					const string __id = "CAP_OPENED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_PREVIEW_START_FAILED']"
			[Register ("CAP_PREVIEW_START_FAILED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapPreviewStartFailed {
				get {
					const string __id = "CAP_PREVIEW_START_FAILED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_RECORD_FRAG_STARTED']"
			[Register ("CAP_RECORD_FRAG_STARTED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapRecordFragStarted {
				get {
					const string __id = "CAP_RECORD_FRAG_STARTED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_RECORD_FRAG_STARTED_SEC']"
			[Register ("CAP_RECORD_FRAG_STARTED_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapRecordFragStartedSec {
				get {
					const string __id = "CAP_RECORD_FRAG_STARTED_SEC.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_RECORD_FRAG_STOPPED']"
			[Register ("CAP_RECORD_FRAG_STOPPED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapRecordFragStopped {
				get {
					const string __id = "CAP_RECORD_FRAG_STOPPED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_RECORD_FRAG_STOPPED_SEC']"
			[Register ("CAP_RECORD_FRAG_STOPPED_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapRecordFragStoppedSec {
				get {
					const string __id = "CAP_RECORD_FRAG_STOPPED_SEC.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_RECORD_STARTED']"
			[Register ("CAP_RECORD_STARTED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapRecordStarted {
				get {
					const string __id = "CAP_RECORD_STARTED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_RECORD_STARTED_SEC']"
			[Register ("CAP_RECORD_STARTED_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapRecordStartedSec {
				get {
					const string __id = "CAP_RECORD_STARTED_SEC.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_RECORD_STOPPED']"
			[Register ("CAP_RECORD_STOPPED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapRecordStopped {
				get {
					const string __id = "CAP_RECORD_STOPPED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_RECORD_STOPPED_SEC']"
			[Register ("CAP_RECORD_STOPPED_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapRecordStoppedSec {
				get {
					const string __id = "CAP_RECORD_STOPPED_SEC.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_STARTED']"
			[Register ("CAP_STARTED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapStarted {
				get {
					const string __id = "CAP_STARTED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_STOPPED']"
			[Register ("CAP_STOPPED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapStopped {
				get {
					const string __id = "CAP_STOPPED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_SURFACE_CHANGED']"
			[Register ("CAP_SURFACE_CHANGED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapSurfaceChanged {
				get {
					const string __id = "CAP_SURFACE_CHANGED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_SURFACE_CREATED']"
			[Register ("CAP_SURFACE_CREATED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapSurfaceCreated {
				get {
					const string __id = "CAP_SURFACE_CREATED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_SURFACE_DESTROYED']"
			[Register ("CAP_SURFACE_DESTROYED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapSurfaceDestroyed {
				get {
					const string __id = "CAP_SURFACE_DESTROYED.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/field[@name='CAP_TIME']"
			[Register ("CAP_TIME")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes CapTime {
				get {
					const string __id = "CAP_TIME.Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes", typeof (CaptureNotifyCodes));

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

			internal CaptureNotifyCodes (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/method[@name='forType' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture.CaptureNotifyCodes']]"
			[Register ("forType", "(Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;)I", "")]
			public static unsafe int ForType (global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes type)
			{
				const string __id = "forType.(Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (type);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/method[@name='forValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forValue", "(I)Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes ForValue (int value)
			{
				const string __id = "forValue.(I)Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureNotifyCodes']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCapture$CaptureNotifyCodes;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCapture.CaptureNotifyCodes));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$CaptureState", DoNotGenerateAcw=true)]
		public sealed partial class CaptureState : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/field[@name='Closed']"
			[Register ("Closed")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState Closed {
				get {
					const string __id = "Closed.Lveg/mediacapture/sdk/MediaCapture$CaptureState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/field[@name='Closing']"
			[Register ("Closing")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState Closing {
				get {
					const string __id = "Closing.Lveg/mediacapture/sdk/MediaCapture$CaptureState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/field[@name='Opened']"
			[Register ("Opened")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState Opened {
				get {
					const string __id = "Opened.Lveg/mediacapture/sdk/MediaCapture$CaptureState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/field[@name='Opening']"
			[Register ("Opening")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState Opening {
				get {
					const string __id = "Opening.Lveg/mediacapture/sdk/MediaCapture$CaptureState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/field[@name='Paused']"
			[Register ("Paused")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState Paused {
				get {
					const string __id = "Paused.Lveg/mediacapture/sdk/MediaCapture$CaptureState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/field[@name='Started']"
			[Register ("Started")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState Started {
				get {
					const string __id = "Started.Lveg/mediacapture/sdk/MediaCapture$CaptureState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/field[@name='Stopped']"
			[Register ("Stopped")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState Stopped {
				get {
					const string __id = "Stopped.Lveg/mediacapture/sdk/MediaCapture$CaptureState;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$CaptureState", typeof (CaptureState));

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

			internal CaptureState (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/method[@name='forType' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture.CaptureState']]"
			[Register ("forType", "(Lveg/mediacapture/sdk/MediaCapture$CaptureState;)I", "")]
			public static unsafe int ForType (global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState type)
			{
				const string __id = "forType.(Lveg/mediacapture/sdk/MediaCapture$CaptureState;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (type);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/method[@name='forValue' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("forValue", "(I)Lveg/mediacapture/sdk/MediaCapture$CaptureState;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState ForValue (int value)
			{
				const string __id = "forValue.(I)Lveg/mediacapture/sdk/MediaCapture$CaptureState;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCapture$CaptureState;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCapture$CaptureState;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.CaptureState']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCapture$CaptureState;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCapture$CaptureState;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.MediaCaptureHandler']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$MediaCaptureHandler", DoNotGenerateAcw=true)]
		public partial class MediaCaptureHandler : global::Android.OS.Handler {
			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$MediaCaptureHandler", typeof (MediaCaptureHandler));

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

			protected MediaCaptureHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.MediaCaptureHandler']/constructor[@name='MediaCapture.MediaCaptureHandler' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture']]"
			[Register (".ctor", "(Lveg/mediacapture/sdk/MediaCapture;)V", "")]
			public unsafe MediaCaptureHandler (global::Veg.Mediacapture.Sdk.MediaCapture __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$PlayerRecordFlags", DoNotGenerateAcw=true)]
		public sealed partial class PlayerRecordFlags : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/field[@name='PP_RECORD_AUTO_START']"
			[Register ("PP_RECORD_AUTO_START")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags PpRecordAutoStart {
				get {
					const string __id = "PP_RECORD_AUTO_START.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/field[@name='PP_RECORD_DISABLE_AUDIO']"
			[Register ("PP_RECORD_DISABLE_AUDIO")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags PpRecordDisableAudio {
				get {
					const string __id = "PP_RECORD_DISABLE_AUDIO.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/field[@name='PP_RECORD_DISABLE_VIDEO']"
			[Register ("PP_RECORD_DISABLE_VIDEO")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags PpRecordDisableVideo {
				get {
					const string __id = "PP_RECORD_DISABLE_VIDEO.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/field[@name='PP_RECORD_NO_START']"
			[Register ("PP_RECORD_NO_START")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags PpRecordNoStart {
				get {
					const string __id = "PP_RECORD_NO_START.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/field[@name='PP_RECORD_SPLIT_BY_SIZE']"
			[Register ("PP_RECORD_SPLIT_BY_SIZE")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags PpRecordSplitBySize {
				get {
					const string __id = "PP_RECORD_SPLIT_BY_SIZE.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/field[@name='PP_RECORD_SPLIT_BY_TIME']"
			[Register ("PP_RECORD_SPLIT_BY_TIME")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags PpRecordSplitByTime {
				get {
					const string __id = "PP_RECORD_SPLIT_BY_TIME.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$PlayerRecordFlags", typeof (PlayerRecordFlags));

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

			internal PlayerRecordFlags (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/method[@name='forType' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture.PlayerRecordFlags']]"
			[Register ("forType", "(Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;)I", "")]
			public static unsafe int ForType (global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags type)
			{
				const string __id = "forType.(Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (type);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordFlags']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCapture$PlayerRecordFlags;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordFlags));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$PlayerRecordStat", DoNotGenerateAcw=true)]
		public sealed partial class PlayerRecordStat : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_ACTUAL_BITRATE']"
			[Register ("PP_RECORD_STAT_ACTUAL_BITRATE")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatActualBitrate {
				get {
					const string __id = "PP_RECORD_STAT_ACTUAL_BITRATE.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_ACTUAL_BITRATE_SEC']"
			[Register ("PP_RECORD_STAT_ACTUAL_BITRATE_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatActualBitrateSec {
				get {
					const string __id = "PP_RECORD_STAT_ACTUAL_BITRATE_SEC.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_ACTUAL_FRAMERATE']"
			[Register ("PP_RECORD_STAT_ACTUAL_FRAMERATE")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatActualFramerate {
				get {
					const string __id = "PP_RECORD_STAT_ACTUAL_FRAMERATE.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_ACTUAL_FRAMERATE_SEC']"
			[Register ("PP_RECORD_STAT_ACTUAL_FRAMERATE_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatActualFramerateSec {
				get {
					const string __id = "PP_RECORD_STAT_ACTUAL_FRAMERATE_SEC.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_DURATION']"
			[Register ("PP_RECORD_STAT_DURATION")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatDuration {
				get {
					const string __id = "PP_RECORD_STAT_DURATION.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_DURATION_SEC']"
			[Register ("PP_RECORD_STAT_DURATION_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatDurationSec {
				get {
					const string __id = "PP_RECORD_STAT_DURATION_SEC.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_DURATION_TOTAL']"
			[Register ("PP_RECORD_STAT_DURATION_TOTAL")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatDurationTotal {
				get {
					const string __id = "PP_RECORD_STAT_DURATION_TOTAL.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_DURATION_TOTAL_SEC']"
			[Register ("PP_RECORD_STAT_DURATION_TOTAL_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatDurationTotalSec {
				get {
					const string __id = "PP_RECORD_STAT_DURATION_TOTAL_SEC.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_FILE_NAME']"
			[Register ("PP_RECORD_STAT_FILE_NAME")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatFileName {
				get {
					const string __id = "PP_RECORD_STAT_FILE_NAME.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_FILE_NAME_SEC']"
			[Register ("PP_RECORD_STAT_FILE_NAME_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatFileNameSec {
				get {
					const string __id = "PP_RECORD_STAT_FILE_NAME_SEC.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_FILE_NAME_STOPPED']"
			[Register ("PP_RECORD_STAT_FILE_NAME_STOPPED")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatFileNameStopped {
				get {
					const string __id = "PP_RECORD_STAT_FILE_NAME_STOPPED.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_FILE_NAME_STOPPED_SEC']"
			[Register ("PP_RECORD_STAT_FILE_NAME_STOPPED_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatFileNameStoppedSec {
				get {
					const string __id = "PP_RECORD_STAT_FILE_NAME_STOPPED_SEC.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_LASTERROR']"
			[Register ("PP_RECORD_STAT_LASTERROR")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatLasterror {
				get {
					const string __id = "PP_RECORD_STAT_LASTERROR.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_SIZE']"
			[Register ("PP_RECORD_STAT_SIZE")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatSize {
				get {
					const string __id = "PP_RECORD_STAT_SIZE.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_SIZE_SEC']"
			[Register ("PP_RECORD_STAT_SIZE_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatSizeSec {
				get {
					const string __id = "PP_RECORD_STAT_SIZE_SEC.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_SIZE_TOTAL']"
			[Register ("PP_RECORD_STAT_SIZE_TOTAL")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatSizeTotal {
				get {
					const string __id = "PP_RECORD_STAT_SIZE_TOTAL.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/field[@name='PP_RECORD_STAT_SIZE_TOTAL_SEC']"
			[Register ("PP_RECORD_STAT_SIZE_TOTAL_SEC")]
			public static global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat PpRecordStatSizeTotalSec {
				get {
					const string __id = "PP_RECORD_STAT_SIZE_TOTAL_SEC.Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$PlayerRecordStat", typeof (PlayerRecordStat));

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

			internal PlayerRecordStat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/method[@name='forType' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture.PlayerRecordStat']]"
			[Register ("forType", "(Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;)I", "")]
			public static unsafe int ForType (global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat type)
			{
				const string __id = "forType.(Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((type == null) ? IntPtr.Zero : ((global::Java.Lang.Object) type).Handle);
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (type);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.PlayerRecordStat']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;", "")]
			public static unsafe global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat[] Values ()
			{
				const string __id = "values.()[Lveg/mediacapture/sdk/MediaCapture$PlayerRecordStat;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Veg.Mediacapture.Sdk.MediaCapture.PlayerRecordStat));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$RecThread", DoNotGenerateAcw=true)]
		public partial class RecThread : global::Veg.Mediacapture.Sdk.Api.ThreadHelper {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/field[@name='is_sec']"
			[Register ("is_sec")]
			public bool IsSec {
				get {
					const string __id = "is_sec.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "is_sec.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/field[@name='last_pts_audio']"
			[Register ("last_pts_audio")]
			public long LastPtsAudio {
				get {
					const string __id = "last_pts_audio.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "last_pts_audio.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/field[@name='last_pts_video']"
			[Register ("last_pts_video")]
			public long LastPtsVideo {
				get {
					const string __id = "last_pts_video.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "last_pts_video.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/field[@name='listFrames_a']"
			[Register ("listFrames_a")]
			public global::Java.Util.Concurrent.CopyOnWriteArrayList ListFramesA {
				get {
					const string __id = "listFrames_a.Ljava/util/concurrent/CopyOnWriteArrayList;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CopyOnWriteArrayList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "listFrames_a.Ljava/util/concurrent/CopyOnWriteArrayList;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/field[@name='listFrames_v']"
			[Register ("listFrames_v")]
			public global::Java.Util.Concurrent.CopyOnWriteArrayList ListFramesV {
				get {
					const string __id = "listFrames_v.Ljava/util/concurrent/CopyOnWriteArrayList;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CopyOnWriteArrayList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "listFrames_v.Ljava/util/concurrent/CopyOnWriteArrayList;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/field[@name='nstat_reconnect_count']"
			[Register ("nstat_reconnect_count")]
			public int NstatReconnectCount {
				get {
					const string __id = "nstat_reconnect_count.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "nstat_reconnect_count.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$RecThread", typeof (RecThread));

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

			protected RecThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/constructor[@name='MediaCapture.RecThread' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture']]"
			[Register (".ctor", "(Lveg/mediacapture/sdk/MediaCapture;)V", "")]
			public unsafe RecThread (global::Veg.Mediacapture.Sdk.MediaCapture __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

			static Delegate cb_getPaused;
#pragma warning disable 0169
			static Delegate GetGetPausedHandler ()
			{
				if (cb_getPaused == null)
					cb_getPaused = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetPaused);
				return cb_getPaused;
			}

			static bool n_GetPaused (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Paused;
			}
#pragma warning restore 0169

			static Delegate cb_setPaused_Z;
#pragma warning disable 0169
			static Delegate GetSetPaused_ZHandler ()
			{
				if (cb_setPaused_Z == null)
					cb_setPaused_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetPaused_Z);
				return cb_setPaused_Z;
			}

			static void n_SetPaused_Z (IntPtr jnienv, IntPtr native__this, bool paused)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Paused = paused;
			}
#pragma warning restore 0169

			public virtual unsafe bool Paused {
				// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='getPaused' and count(parameter)=0]"
				[Register ("getPaused", "()Z", "GetGetPausedHandler")]
				get {
					const string __id = "getPaused.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
				// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='setPaused' and count(parameter)=1 and parameter[1][@type='boolean']]"
				[Register ("setPaused", "(Z)V", "GetSetPaused_ZHandler")]
				set {
					const string __id = "setPaused.(Z)V";
					try {
						JniArgumentValue* __args = stackalloc JniArgumentValue [1];
						__args [0] = new JniArgumentValue (value);
						_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
					} finally {
					}
				}
			}

			static Delegate cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
#pragma warning disable 0169
			static Delegate GetPutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler ()
			{
				if (cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ == null)
					cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_);
				return cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
			}

			static int n_PutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_af)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var af = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket> (native_af, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PutAudio (af);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='putAudio' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.AudioPacket']]"
			[Register ("putAudio", "(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)I", "GetPutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler")]
			public virtual unsafe int PutAudio (global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket af)
			{
				const string __id = "putAudio.(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((af == null) ? IntPtr.Zero : ((global::Java.Lang.Object) af).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (af);
				}
			}

			static Delegate cb_putAudioList_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetPutAudioList_Ljava_util_List_Handler ()
			{
				if (cb_putAudioList_Ljava_util_List_ == null)
					cb_putAudioList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutAudioList_Ljava_util_List_);
				return cb_putAudioList_Ljava_util_List_;
			}

			static void n_PutAudioList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_list)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var list = global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket>.FromJniHandle (native_list, JniHandleOwnership.DoNotTransfer);
				__this.PutAudioList (list);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='putAudioList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;veg.mediacapture.sdk.streaming.mp4.AudioPacket&gt;']]"
			[Register ("putAudioList", "(Ljava/util/List;)V", "GetPutAudioList_Ljava_util_List_Handler")]
			public virtual unsafe void PutAudioList (global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket> list)
			{
				const string __id = "putAudioList.(Ljava/util/List;)V";
				IntPtr native_list = global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket>.ToLocalJniHandle (list);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_list);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_list);
					global::System.GC.KeepAlive (list);
				}
			}

			static Delegate cb_putSPSPPS_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetPutSPSPPS_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_putSPSPPS_Ljava_nio_ByteBuffer_ == null)
					cb_putSPSPPS_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutSPSPPS_Ljava_nio_ByteBuffer_);
				return cb_putSPSPPS_Ljava_nio_ByteBuffer_;
			}

			static int n_PutSPSPPS_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encodedData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var encodedData = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_encodedData, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PutSPSPPS (encodedData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='putSPSPPS' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("putSPSPPS", "(Ljava/nio/ByteBuffer;)I", "GetPutSPSPPS_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe int PutSPSPPS (global::Java.Nio.ByteBuffer encodedData)
			{
				const string __id = "putSPSPPS.(Ljava/nio/ByteBuffer;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((encodedData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) encodedData).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (encodedData);
				}
			}

			static Delegate cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
#pragma warning disable 0169
			static Delegate GetPutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler ()
			{
				if (cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ == null)
					cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_);
				return cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
			}

			static int n_PutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var vf = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> (native_vf, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PutVideo (vf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='putVideo' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
			[Register ("putVideo", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)I", "GetPutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler")]
			public virtual unsafe int PutVideo (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame vf)
			{
				const string __id = "putVideo.(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((vf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vf).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (vf);
				}
			}

			static Delegate cb_putVideoList_Ljava_util_List_;
#pragma warning disable 0169
			static Delegate GetPutVideoList_Ljava_util_List_Handler ()
			{
				if (cb_putVideoList_Ljava_util_List_ == null)
					cb_putVideoList_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_PutVideoList_Ljava_util_List_);
				return cb_putVideoList_Ljava_util_List_;
			}

			static void n_PutVideoList_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_list)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var list = global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame>.FromJniHandle (native_list, JniHandleOwnership.DoNotTransfer);
				__this.PutVideoList (list);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='putVideoList' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;veg.mediacapture.sdk.streaming.mp4.VideoFrame&gt;']]"
			[Register ("putVideoList", "(Ljava/util/List;)V", "GetPutVideoList_Ljava_util_List_Handler")]
			public virtual unsafe void PutVideoList (global::System.Collections.Generic.IList<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> list)
			{
				const string __id = "putVideoList.(Ljava/util/List;)V";
				IntPtr native_list = global::Android.Runtime.JavaList<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame>.ToLocalJniHandle (list);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_list);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_list);
					global::System.GC.KeepAlive (list);
				}
			}

			static Delegate cb_runt;
#pragma warning disable 0169
			static Delegate GetRuntHandler ()
			{
				if (cb_runt == null)
					cb_runt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Runt);
				return cb_runt;
			}

			static void n_Runt (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Runt ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='runt' and count(parameter)=0]"
			[Register ("runt", "()V", "GetRuntHandler")]
			public override unsafe void Runt ()
			{
				const string __id = "runt.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_setSecondaryMode_Z;
#pragma warning disable 0169
			static Delegate GetSetSecondaryMode_ZHandler ()
			{
				if (cb_setSecondaryMode_Z == null)
					cb_setSecondaryMode_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetSecondaryMode_Z);
				return cb_setSecondaryMode_Z;
			}

			static void n_SetSecondaryMode_Z (IntPtr jnienv, IntPtr native__this, bool sec)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.RecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.SetSecondaryMode (sec);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.RecThread']/method[@name='setSecondaryMode' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSecondaryMode", "(Z)V", "GetSetSecondaryMode_ZHandler")]
			public virtual unsafe void SetSecondaryMode (bool sec)
			{
				const string __id = "setSecondaryMode.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (sec);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StopRecThread']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$StopRecThread", DoNotGenerateAcw=true)]
		public partial class StopRecThread : global::Java.Lang.Object, global::Java.Lang.IRunnable {
			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$StopRecThread", typeof (StopRecThread));

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

			protected StopRecThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StopRecThread']/constructor[@name='MediaCapture.StopRecThread' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture']]"
			[Register (".ctor", "(Lveg/mediacapture/sdk/MediaCapture;)V", "")]
			public unsafe StopRecThread (global::Veg.Mediacapture.Sdk.MediaCapture __self) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

			static Delegate cb_run;
#pragma warning disable 0169
			static Delegate GetRunHandler ()
			{
				if (cb_run == null)
					cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
				return cb_run;
			}

			static void n_Run (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StopRecThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Run ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StopRecThread']/method[@name='run' and count(parameter)=0]"
			[Register ("run", "()V", "GetRunHandler")]
			public virtual unsafe void Run ()
			{
				const string __id = "run.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$StreamThread", DoNotGenerateAcw=true)]
		public partial class StreamThread : global::Veg.Mediacapture.Sdk.Api.ThreadHelper {

			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='first_pts_audio']"
			[Register ("first_pts_audio")]
			public long FirstPtsAudio {
				get {
					const string __id = "first_pts_audio.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "first_pts_audio.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='first_pts_video']"
			[Register ("first_pts_video")]
			public long FirstPtsVideo {
				get {
					const string __id = "first_pts_video.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "first_pts_video.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='is_sec']"
			[Register ("is_sec")]
			public bool IsSec {
				get {
					const string __id = "is_sec.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "is_sec.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='last_pts_audio']"
			[Register ("last_pts_audio")]
			public long LastPtsAudio {
				get {
					const string __id = "last_pts_audio.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "last_pts_audio.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='last_pts_video']"
			[Register ("last_pts_video")]
			public long LastPtsVideo {
				get {
					const string __id = "last_pts_video.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "last_pts_video.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='last_pts_video_buffer']"
			[Register ("last_pts_video_buffer")]
			public long LastPtsVideoBuffer {
				get {
					const string __id = "last_pts_video_buffer.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "last_pts_video_buffer.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='listFrames_a']"
			[Register ("listFrames_a")]
			public global::Java.Util.Concurrent.CopyOnWriteArrayList ListFramesA {
				get {
					const string __id = "listFrames_a.Ljava/util/concurrent/CopyOnWriteArrayList;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CopyOnWriteArrayList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "listFrames_a.Ljava/util/concurrent/CopyOnWriteArrayList;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='listFrames_v']"
			[Register ("listFrames_v")]
			public global::Java.Util.Concurrent.CopyOnWriteArrayList ListFramesV {
				get {
					const string __id = "listFrames_v.Ljava/util/concurrent/CopyOnWriteArrayList;";

					var __v = _members.InstanceFields.GetObjectValue (__id, this);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.CopyOnWriteArrayList> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
				set {
					const string __id = "listFrames_v.Ljava/util/concurrent/CopyOnWriteArrayList;";

					IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
					try {
						_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
					} finally {
						global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/field[@name='nstat_reconnect_count']"
			[Register ("nstat_reconnect_count")]
			public int NstatReconnectCount {
				get {
					const string __id = "nstat_reconnect_count.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "nstat_reconnect_count.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$StreamThread", typeof (StreamThread));

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

			protected StreamThread (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/constructor[@name='MediaCapture.StreamThread' and count(parameter)=3 and parameter[1][@type='veg.mediacapture.sdk.MediaCapture'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
			[Register (".ctor", "(Lveg/mediacapture/sdk/MediaCapture;IZ)V", "")]
			public unsafe StreamThread (global::Veg.Mediacapture.Sdk.MediaCapture __self, int stream_type, bool sec) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";IZ)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					__args [1] = new JniArgumentValue (stream_type);
					__args [2] = new JniArgumentValue (sec);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (__self);
				}
			}

			static Delegate cb_getRTSPBitRate_I;
#pragma warning disable 0169
			static Delegate GetGetRTSPBitRate_IHandler ()
			{
				if (cb_getRTSPBitRate_I == null)
					cb_getRTSPBitRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRTSPBitRate_I);
				return cb_getRTSPBitRate_I;
			}

			static int n_GetRTSPBitRate_I (IntPtr jnienv, IntPtr native__this, int channel)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRTSPBitRate (channel);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='getRTSPBitRate' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRTSPBitRate", "(I)I", "GetGetRTSPBitRate_IHandler")]
			public virtual unsafe int GetRTSPBitRate (int channel)
			{
				const string __id = "getRTSPBitRate.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (channel);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_getRTSPClients_I;
#pragma warning disable 0169
			static Delegate GetGetRTSPClients_IHandler ()
			{
				if (cb_getRTSPClients_I == null)
					cb_getRTSPClients_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetRTSPClients_I);
				return cb_getRTSPClients_I;
			}

			static IntPtr n_GetRTSPClients_I (IntPtr jnienv, IntPtr native__this, int channel)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewArray (__this.GetRTSPClients (channel));
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='getRTSPClients' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRTSPClients", "(I)[Ljava/lang/String;", "GetGetRTSPClients_IHandler")]
			public virtual unsafe string[] GetRTSPClients (int channel)
			{
				const string __id = "getRTSPClients.(I)[Ljava/lang/String;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (channel);
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
					return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
				} finally {
				}
			}

			static Delegate cb_getRTSPFps_I;
#pragma warning disable 0169
			static Delegate GetGetRTSPFps_IHandler ()
			{
				if (cb_getRTSPFps_I == null)
					cb_getRTSPFps_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRTSPFps_I);
				return cb_getRTSPFps_I;
			}

			static int n_GetRTSPFps_I (IntPtr jnienv, IntPtr native__this, int channel)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetRTSPFps (channel);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='getRTSPFps' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("getRTSPFps", "(I)I", "GetGetRTSPFps_IHandler")]
			public virtual unsafe int GetRTSPFps (int channel)
			{
				const string __id = "getRTSPFps.(I)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (channel);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
#pragma warning disable 0169
			static Delegate GetPutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler ()
			{
				if (cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ == null)
					cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_);
				return cb_putAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
			}

			static int n_PutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_af)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var af = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket> (native_af, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PutAudio (af);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='putAudio' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.AudioPacket']]"
			[Register ("putAudio", "(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)I", "GetPutAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler")]
			public virtual unsafe int PutAudio (global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket af)
			{
				const string __id = "putAudio.(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((af == null) ? IntPtr.Zero : ((global::Java.Lang.Object) af).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (af);
				}
			}

			static Delegate cb_putSPSPPS_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetPutSPSPPS_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_putSPSPPS_Ljava_nio_ByteBuffer_ == null)
					cb_putSPSPPS_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutSPSPPS_Ljava_nio_ByteBuffer_);
				return cb_putSPSPPS_Ljava_nio_ByteBuffer_;
			}

			static int n_PutSPSPPS_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encodedData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var encodedData = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_encodedData, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PutSPSPPS (encodedData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='putSPSPPS' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("putSPSPPS", "(Ljava/nio/ByteBuffer;)I", "GetPutSPSPPS_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe int PutSPSPPS (global::Java.Nio.ByteBuffer encodedData)
			{
				const string __id = "putSPSPPS.(Ljava/nio/ByteBuffer;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((encodedData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) encodedData).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (encodedData);
				}
			}

			static Delegate cb_putSPSPPS_sec_Ljava_nio_ByteBuffer_;
#pragma warning disable 0169
			static Delegate GetPutSPSPPS_sec_Ljava_nio_ByteBuffer_Handler ()
			{
				if (cb_putSPSPPS_sec_Ljava_nio_ByteBuffer_ == null)
					cb_putSPSPPS_sec_Ljava_nio_ByteBuffer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutSPSPPS_sec_Ljava_nio_ByteBuffer_);
				return cb_putSPSPPS_sec_Ljava_nio_ByteBuffer_;
			}

			static int n_PutSPSPPS_sec_Ljava_nio_ByteBuffer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_encodedData)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var encodedData = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_encodedData, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PutSPSPPS_sec (encodedData);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='putSPSPPS_sec' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
			[Register ("putSPSPPS_sec", "(Ljava/nio/ByteBuffer;)I", "GetPutSPSPPS_sec_Ljava_nio_ByteBuffer_Handler")]
			public virtual unsafe int PutSPSPPS_sec (global::Java.Nio.ByteBuffer encodedData)
			{
				const string __id = "putSPSPPS_sec.(Ljava/nio/ByteBuffer;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((encodedData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) encodedData).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (encodedData);
				}
			}

			static Delegate cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
#pragma warning disable 0169
			static Delegate GetPutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler ()
			{
				if (cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ == null)
					cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_PutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_);
				return cb_putVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
			}

			static int n_PutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vf)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var vf = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> (native_vf, JniHandleOwnership.DoNotTransfer);
				int __ret = __this.PutVideo (vf);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='putVideo' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
			[Register ("putVideo", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)I", "GetPutVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler")]
			public virtual unsafe int PutVideo (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame vf)
			{
				const string __id = "putVideo.(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)I";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((vf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vf).Handle);
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
					return __rm;
				} finally {
					global::System.GC.KeepAlive (vf);
				}
			}

			static Delegate cb_runt;
#pragma warning disable 0169
			static Delegate GetRuntHandler ()
			{
				if (cb_runt == null)
					cb_runt = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Runt);
				return cb_runt;
			}

			static void n_Runt (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Runt ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='runt' and count(parameter)=0]"
			[Register ("runt", "()V", "GetRuntHandler")]
			public override unsafe void Runt ()
			{
				const string __id = "runt.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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

			static void n_SetMulticast_ZLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, bool e, IntPtr native_ip, int ttl)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var ip = JNIEnv.GetString (native_ip, JniHandleOwnership.DoNotTransfer);
				__this.SetMulticast (e, ip, ttl);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='setMulticast' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
			[Register ("setMulticast", "(ZLjava/lang/String;I)V", "GetSetMulticast_ZLjava_lang_String_IHandler")]
			public virtual unsafe void SetMulticast (bool e, string ip, int ttl)
			{
				const string __id = "setMulticast.(ZLjava/lang/String;I)V";
				IntPtr native_ip = JNIEnv.NewString (ip);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (e);
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

			static void n_SetSecureStreaming_ZLjava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, bool e, IntPtr native_cert, IntPtr native_key)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.StreamThread> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var cert = JNIEnv.GetString (native_cert, JniHandleOwnership.DoNotTransfer);
				var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
				__this.SetSecureStreaming (e, cert, key);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.StreamThread']/method[@name='setSecureStreaming' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
			[Register ("setSecureStreaming", "(ZLjava/lang/String;Ljava/lang/String;)V", "GetSetSecureStreaming_ZLjava_lang_String_Ljava_lang_String_Handler")]
			public virtual unsafe void SetSecureStreaming (bool e, string cert, string key)
			{
				const string __id = "setSecureStreaming.(ZLjava/lang/String;Ljava/lang/String;)V";
				IntPtr native_cert = JNIEnv.NewString (cert);
				IntPtr native_key = JNIEnv.NewString (key);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (e);
					__args [1] = new JniArgumentValue (native_cert);
					__args [2] = new JniArgumentValue (native_key);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_cert);
					JNIEnv.DeleteLocalRef (native_key);
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.WaitNotify']"
		[global::Android.Runtime.Register ("veg/mediacapture/sdk/MediaCapture$WaitNotify", DoNotGenerateAcw=true)]
		public partial class WaitNotify : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture$WaitNotify", typeof (WaitNotify));

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

			protected WaitNotify (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.WaitNotify']/constructor[@name='MediaCapture.WaitNotify' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe WaitNotify () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			static Delegate cb_getObject;
#pragma warning disable 0169
			static Delegate GetGetObjectHandler ()
			{
				if (cb_getObject == null)
					cb_getObject = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetObject);
				return cb_getObject;
			}

			static IntPtr n_GetObject (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.WaitNotify> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Object);
			}
#pragma warning restore 0169

			public virtual unsafe global::Java.Lang.Object Object {
				// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.WaitNotify']/method[@name='getObject' and count(parameter)=0]"
				[Register ("getObject", "()Ljava/lang/Object;", "GetGetObjectHandler")]
				get {
					const string __id = "getObject.()Ljava/lang/Object;";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
						return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static Delegate cb_notify_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetNotify_Ljava_lang_String_Handler ()
			{
				if (cb_notify_Ljava_lang_String_ == null)
					cb_notify_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Notify_Ljava_lang_String_);
				return cb_notify_Ljava_lang_String_;
			}

			static void n_Notify_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.WaitNotify> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				__this.Notify (text);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.WaitNotify']/method[@name='notify' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("notify", "(Ljava/lang/String;)V", "GetNotify_Ljava_lang_String_Handler")]
			protected virtual unsafe void Notify (string text)
			{
				const string __id = "notify.(Ljava/lang/String;)V";
				IntPtr native_text = JNIEnv.NewString (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
				}
			}

			static Delegate cb_wait_Ljava_lang_String_;
#pragma warning disable 0169
			static Delegate GetWait_Ljava_lang_String_Handler ()
			{
				if (cb_wait_Ljava_lang_String_ == null)
					cb_wait_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Wait_Ljava_lang_String_);
				return cb_wait_Ljava_lang_String_;
			}

			static bool n_Wait_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.WaitNotify> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Wait (text);
				return __ret;
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture.WaitNotify']/method[@name='wait' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("wait", "(Ljava/lang/String;)Z", "GetWait_Ljava_lang_String_Handler")]
			public virtual unsafe bool Wait (string text)
			{
				const string __id = "wait.(Ljava/lang/String;)Z";
				IntPtr native_text = JNIEnv.NewString (text);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_text);
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
					return __rm;
				} finally {
					JNIEnv.DeleteLocalRef (native_text);
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/MediaCapture", typeof (MediaCapture));

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

		protected MediaCapture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/constructor[@name='MediaCapture' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe MediaCapture (global::Android.Content.Context context, global::Android.Util.IAttributeSet attr) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attr).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attr);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/constructor[@name='MediaCapture' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;Z)V", "")]
		public unsafe MediaCapture (global::Android.Content.Context context, global::Android.Util.IAttributeSet attr, bool is_window) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;Z)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attr == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attr).Handle);
				__args [2] = new JniArgumentValue (is_window);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attr);
			}
		}

		static Delegate cb_getAudioPackets;
#pragma warning disable 0169
		static Delegate GetGetAudioPacketsHandler ()
		{
			if (cb_getAudioPackets == null)
				cb_getAudioPackets = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetAudioPackets);
			return cb_getAudioPackets;
		}

		static int n_GetAudioPackets (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AudioPackets;
		}
#pragma warning restore 0169

		public virtual unsafe int AudioPackets {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getAudioPackets' and count(parameter)=0]"
			[Register ("getAudioPackets", "()I", "GetGetAudioPacketsHandler")]
			get {
				const string __id = "getAudioPackets.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int AudioShare_AudioFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getAudioShare_AudioFormat' and count(parameter)=0]"
			[Register ("getAudioShare_AudioFormat", "()I", "")]
			get {
				const string __id = "getAudioShare_AudioFormat.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int AudioShare_BufferSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getAudioShare_BufferSize' and count(parameter)=0]"
			[Register ("getAudioShare_BufferSize", "()I", "")]
			get {
				const string __id = "getAudioShare_BufferSize.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int AudioShare_Channels {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getAudioShare_Channels' and count(parameter)=0]"
			[Register ("getAudioShare_Channels", "()I", "")]
			get {
				const string __id = "getAudioShare_Channels.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int AudioShare_SampleRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getAudioShare_SampleRate' and count(parameter)=0]"
			[Register ("getAudioShare_SampleRate", "()I", "")]
			get {
				const string __id = "getAudioShare_SampleRate.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int AudioShare_Source {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getAudioShare_Source' and count(parameter)=0]"
			[Register ("getAudioShare_Source", "()I", "")]
			get {
				const string __id = "getAudioShare_Source.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.MediaCaptureConfig Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lveg/mediacapture/sdk/MediaCaptureConfig;", "GetGetConfigHandler")]
			get {
				const string __id = "getConfig.()Lveg/mediacapture/sdk/MediaCaptureConfig;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getDuration' and count(parameter)=0]"
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

		static Delegate cb_getFlash;
#pragma warning disable 0169
		static Delegate GetGetFlashHandler ()
		{
			if (cb_getFlash == null)
				cb_getFlash = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_GetFlash);
			return cb_getFlash;
		}

		static bool n_GetFlash (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Flash;
		}
#pragma warning restore 0169

		static Delegate cb_setFlash_Z;
#pragma warning disable 0169
		static Delegate GetSetFlash_ZHandler ()
		{
			if (cb_setFlash_Z == null)
				cb_setFlash_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFlash_Z);
			return cb_setFlash_Z;
		}

		static void n_SetFlash_Z (IntPtr jnienv, IntPtr native__this, bool flashEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flash = flashEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool Flash {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getFlash' and count(parameter)=0]"
			[Register ("getFlash", "()Z", "GetGetFlashHandler")]
			get {
				const string __id = "getFlash.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='setFlash' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setFlash", "(Z)V", "GetSetFlash_ZHandler")]
			set {
				const string __id = "setFlash.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		public static unsafe bool IsAudioShare {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='isAudioShare' and count(parameter)=0]"
			[Register ("isAudioShare", "()Z", "")]
			get {
				const string __id = "isAudioShare.()Z";
				try {
					var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isRecordingPaused;
#pragma warning disable 0169
		static Delegate GetIsRecordingPausedHandler ()
		{
			if (cb_isRecordingPaused == null)
				cb_isRecordingPaused = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRecordingPaused);
			return cb_isRecordingPaused;
		}

		static bool n_IsRecordingPaused (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsRecordingPaused;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsRecordingPaused {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='isRecordingPaused' and count(parameter)=0]"
			[Register ("isRecordingPaused", "()Z", "GetIsRecordingPausedHandler")]
			get {
				const string __id = "isRecordingPaused.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isUseTimeshift;
#pragma warning disable 0169
		static Delegate GetIsUseTimeshiftHandler ()
		{
			if (cb_isUseTimeshift == null)
				cb_isUseTimeshift = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseTimeshift);
			return cb_isUseTimeshift;
		}

		static bool n_IsUseTimeshift (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUseTimeshift;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUseTimeshift {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='isUseTimeshift' and count(parameter)=0]"
			[Register ("isUseTimeshift", "()Z", "GetIsUseTimeshiftHandler")]
			get {
				const string __id = "isUseTimeshift.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastAudioPTS;
#pragma warning disable 0169
		static Delegate GetGetLastAudioPTSHandler ()
		{
			if (cb_getLastAudioPTS == null)
				cb_getLastAudioPTS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLastAudioPTS);
			return cb_getLastAudioPTS;
		}

		static long n_GetLastAudioPTS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastAudioPTS;
		}
#pragma warning restore 0169

		public virtual unsafe long LastAudioPTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getLastAudioPTS' and count(parameter)=0]"
			[Register ("getLastAudioPTS", "()J", "GetGetLastAudioPTSHandler")]
			get {
				const string __id = "getLastAudioPTS.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLastVideoPTS;
#pragma warning disable 0169
		static Delegate GetGetLastVideoPTSHandler ()
		{
			if (cb_getLastVideoPTS == null)
				cb_getLastVideoPTS = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetLastVideoPTS);
			return cb_getLastVideoPTS;
		}

		static long n_GetLastVideoPTS (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LastVideoPTS;
		}
#pragma warning restore 0169

		public virtual unsafe long LastVideoPTS {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getLastVideoPTS' and count(parameter)=0]"
			[Register ("getLastVideoPTS", "()J", "GetGetLastVideoPTSHandler")]
			get {
				const string __id = "getLastVideoPTS.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe string LibVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getLibVersion' and count(parameter)=0]"
			[Register ("getLibVersion", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLibVersion.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected static unsafe string License {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getLicense' and count(parameter)=0]"
			[Register ("getLicense", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLicense.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		protected static unsafe string Path {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getPath' and count(parameter)=0]"
			[Register ("getPath", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getPath.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getRECStatus;
#pragma warning disable 0169
		static Delegate GetGetRECStatusHandler ()
		{
			if (cb_getRECStatus == null)
				cb_getRECStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRECStatus);
			return cb_getRECStatus;
		}

		static int n_GetRECStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RECStatus;
		}
#pragma warning restore 0169

		public virtual unsafe int RECStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getRECStatus' and count(parameter)=0]"
			[Register ("getRECStatus", "()I", "GetGetRECStatusHandler")]
			get {
				const string __id = "getRECStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRECStatusSec;
#pragma warning disable 0169
		static Delegate GetGetRECStatusSecHandler ()
		{
			if (cb_getRECStatusSec == null)
				cb_getRECStatusSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRECStatusSec);
			return cb_getRECStatusSec;
		}

		static int n_GetRECStatusSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RECStatusSec;
		}
#pragma warning restore 0169

		public virtual unsafe int RECStatusSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getRECStatusSec' and count(parameter)=0]"
			[Register ("getRECStatusSec", "()I", "GetGetRECStatusSecHandler")]
			get {
				const string __id = "getRECStatusSec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRTMPStatus;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetRTMPStatusHandler ()
		{
			if (cb_getRTMPStatus == null)
				cb_getRTMPStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetRTMPStatus);
			return cb_getRTMPStatus;
		}

		[Obsolete]
		static int n_GetRTMPStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RTMPStatus;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe int RTMPStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getRTMPStatus' and count(parameter)=0]"
			[Register ("getRTMPStatus", "()I", "GetGetRTMPStatusHandler")]
			get {
				const string __id = "getRTMPStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRTSPAddr;
#pragma warning disable 0169
		static Delegate GetGetRTSPAddrHandler ()
		{
			if (cb_getRTSPAddr == null)
				cb_getRTSPAddr = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetRTSPAddr);
			return cb_getRTSPAddr;
		}

		static IntPtr n_GetRTSPAddr (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.RTSPAddr);
		}
#pragma warning restore 0169

		public virtual unsafe string RTSPAddr {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getRTSPAddr' and count(parameter)=0]"
			[Register ("getRTSPAddr", "()Ljava/lang/String;", "GetGetRTSPAddrHandler")]
			get {
				const string __id = "getRTSPAddr.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStatReconnectCount;
#pragma warning disable 0169
		static Delegate GetGetStatReconnectCountHandler ()
		{
			if (cb_getStatReconnectCount == null)
				cb_getStatReconnectCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStatReconnectCount);
			return cb_getStatReconnectCount;
		}

		static int n_GetStatReconnectCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StatReconnectCount;
		}
#pragma warning restore 0169

		public virtual unsafe int StatReconnectCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getStatReconnectCount' and count(parameter)=0]"
			[Register ("getStatReconnectCount", "()I", "GetGetStatReconnectCountHandler")]
			get {
				const string __id = "getStatReconnectCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getState;
#pragma warning disable 0169
		static Delegate GetGetStateHandler ()
		{
			if (cb_getState == null)
				cb_getState = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetState);
			return cb_getState;
		}

		static IntPtr n_GetState (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.State);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState State {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getState' and count(parameter)=0]"
			[Register ("getState", "()Lveg/mediacapture/sdk/MediaCapture$CaptureState;", "GetGetStateHandler")]
			get {
				const string __id = "getState.()Lveg/mediacapture/sdk/MediaCapture$CaptureState;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture.CaptureState> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getStreamStatus;
#pragma warning disable 0169
		static Delegate GetGetStreamStatusHandler ()
		{
			if (cb_getStreamStatus == null)
				cb_getStreamStatus = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStreamStatus);
			return cb_getStreamStatus;
		}

		static int n_GetStreamStatus (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StreamStatus;
		}
#pragma warning restore 0169

		public virtual unsafe int StreamStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getStreamStatus' and count(parameter)=0]"
			[Register ("getStreamStatus", "()I", "GetGetStreamStatusHandler")]
			get {
				const string __id = "getStreamStatus.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStreamStatusSec;
#pragma warning disable 0169
		static Delegate GetGetStreamStatusSecHandler ()
		{
			if (cb_getStreamStatusSec == null)
				cb_getStreamStatusSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetStreamStatusSec);
			return cb_getStreamStatusSec;
		}

		static int n_GetStreamStatusSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StreamStatusSec;
		}
#pragma warning restore 0169

		public virtual unsafe int StreamStatusSec {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getStreamStatusSec' and count(parameter)=0]"
			[Register ("getStreamStatusSec", "()I", "GetGetStreamStatusSecHandler")]
			get {
				const string __id = "getStreamStatusSec.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSurface;
#pragma warning disable 0169
		static Delegate GetGetSurfaceHandler ()
		{
			if (cb_getSurface == null)
				cb_getSurface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurface);
			return cb_getSurface;
		}

		static IntPtr n_GetSurface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Surface);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.Surface Surface {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getSurface' and count(parameter)=0]"
			[Register ("getSurface", "()Landroid/view/Surface;", "GetGetSurfaceHandler")]
			get {
				const string __id = "getSurface.()Landroid/view/Surface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.Surface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSurfaceView;
#pragma warning disable 0169
		static Delegate GetGetSurfaceViewHandler ()
		{
			if (cb_getSurfaceView == null)
				cb_getSurfaceView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSurfaceView);
			return cb_getSurfaceView;
		}

		static IntPtr n_GetSurfaceView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SurfaceView);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.SurfaceView SurfaceView {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getSurfaceView' and count(parameter)=0]"
			[Register ("getSurfaceView", "()Landroid/view/SurfaceView;", "GetGetSurfaceViewHandler")]
			get {
				const string __id = "getSurfaceView.()Landroid/view/SurfaceView;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.SurfaceView> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getVideoPackets;
#pragma warning disable 0169
		static Delegate GetGetVideoPacketsHandler ()
		{
			if (cb_getVideoPackets == null)
				cb_getVideoPackets = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetVideoPackets);
			return cb_getVideoPackets;
		}

		static int n_GetVideoPackets (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VideoPackets;
		}
#pragma warning restore 0169

		public virtual unsafe int VideoPackets {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getVideoPackets' and count(parameter)=0]"
			[Register ("getVideoPackets", "()I", "GetGetVideoPacketsHandler")]
			get {
				const string __id = "getVideoPackets.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getZoom;
#pragma warning disable 0169
		static Delegate GetGetZoomHandler ()
		{
			if (cb_getZoom == null)
				cb_getZoom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetZoom);
			return cb_getZoom;
		}

		static int n_GetZoom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Zoom;
		}
#pragma warning restore 0169

		static Delegate cb_setZoom_I;
#pragma warning disable 0169
		static Delegate GetSetZoom_IHandler ()
		{
			if (cb_setZoom_I == null)
				cb_setZoom_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetZoom_I);
			return cb_setZoom_I;
		}

		static void n_SetZoom_I (IntPtr jnienv, IntPtr native__this, int zoomVal)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Zoom = zoomVal;
		}
#pragma warning restore 0169

		public virtual unsafe int Zoom {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getZoom' and count(parameter)=0]"
			[Register ("getZoom", "()I", "GetGetZoomHandler")]
			get {
				const string __id = "getZoom.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='setZoom' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZoom", "(I)V", "GetSetZoom_IHandler")]
			set {
				const string __id = "setZoom.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_ApplyVideoBitrate_IZ;
#pragma warning disable 0169
		static Delegate GetApplyVideoBitrate_IZHandler ()
		{
			if (cb_ApplyVideoBitrate_IZ == null)
				cb_ApplyVideoBitrate_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_V) n_ApplyVideoBitrate_IZ);
			return cb_ApplyVideoBitrate_IZ;
		}

		static void n_ApplyVideoBitrate_IZ (IntPtr jnienv, IntPtr native__this, int bitrate, bool is_secondary)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ApplyVideoBitrate (bitrate, is_secondary);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='ApplyVideoBitrate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("ApplyVideoBitrate", "(IZ)V", "GetApplyVideoBitrate_IZHandler")]
		public virtual unsafe void ApplyVideoBitrate (int bitrate, bool is_secondary)
		{
			const string __id = "ApplyVideoBitrate.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (bitrate);
				__args [1] = new JniArgumentValue (is_secondary);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_Close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_Close == null)
				cb_Close = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Close);
			return cb_Close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='Close' and count(parameter)=0]"
		[Register ("Close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "Close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_OnCameraDied;
#pragma warning disable 0169
		static Delegate GetOnCameraDiedHandler ()
		{
			if (cb_OnCameraDied == null)
				cb_OnCameraDied = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnCameraDied);
			return cb_OnCameraDied;
		}

		static void n_OnCameraDied (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraDied ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnCameraDied' and count(parameter)=0]"
		[Register ("OnCameraDied", "()V", "GetOnCameraDiedHandler")]
		public virtual unsafe void OnCameraDied ()
		{
			const string __id = "OnCameraDied.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II == null)
				cb_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II);
			return cb_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_surface, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var surface = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_surface, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraSurfaceChanged (surface, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnCameraSurfaceChanged' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("OnCameraSurfaceChanged", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_IIHandler")]
		public virtual unsafe void OnCameraSurfaceChanged (global::Android.Graphics.SurfaceTexture surface, int width, int height)
		{
			const string __id = "OnCameraSurfaceChanged.(Landroid/graphics/SurfaceTexture;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((surface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surface).Handle);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (surface);
			}
		}

		static Delegate cb_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_ == null)
				cb_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_);
			return cb_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surface)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var surface = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_surface, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraSurfaceReady (surface);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnCameraSurfaceReady' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("OnCameraSurfaceReady", "(Landroid/graphics/SurfaceTexture;)V", "GetOnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void OnCameraSurfaceReady (global::Android.Graphics.SurfaceTexture surface)
		{
			const string __id = "OnCameraSurfaceReady.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surface).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (surface);
			}
		}

		static Delegate cb_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
#pragma warning disable 0169
		static Delegate GetOnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler ()
		{
			if (cb_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == null)
				cb_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIILL_V) n_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_);
			return cb_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		}

		static void n_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ (IntPtr jnienv, IntPtr native__this, int stream_type, int width, IntPtr native_encodedData, IntPtr native_bufferInfo)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var encodedData = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_encodedData, JniHandleOwnership.DoNotTransfer);
			var bufferInfo = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.BufferInfo> (native_bufferInfo, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaCodecFrame (stream_type, width, encodedData, bufferInfo);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnMediaCodecFrame' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='android.media.MediaCodec.BufferInfo']]"
		[Register ("OnMediaCodecFrame", "(IILjava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V", "GetOnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler")]
		public virtual unsafe void OnMediaCodecFrame (int stream_type, int width, global::Java.Nio.ByteBuffer encodedData, global::Android.Media.MediaCodec.BufferInfo bufferInfo)
		{
			const string __id = "OnMediaCodecFrame.(IILjava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (stream_type);
				__args [1] = new JniArgumentValue (width);
				__args [2] = new JniArgumentValue ((encodedData == null) ? IntPtr.Zero : ((global::Java.Lang.Object) encodedData).Handle);
				__args [3] = new JniArgumentValue ((bufferInfo == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bufferInfo).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (encodedData);
				global::System.GC.KeepAlive (bufferInfo);
			}
		}

		static Delegate cb_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
#pragma warning disable 0169
		static Delegate GetOnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler ()
		{
			if (cb_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ == null)
				cb_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_);
			return cb_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
		}

		static void n_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_af)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var af = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket> (native_af, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaFrameAudio (af);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnMediaFrameAudio' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.AudioPacket']]"
		[Register ("OnMediaFrameAudio", "(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)V", "GetOnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler")]
		public virtual unsafe void OnMediaFrameAudio (global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket af)
		{
			const string __id = "OnMediaFrameAudio.(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((af == null) ? IntPtr.Zero : ((global::Java.Lang.Object) af).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (af);
			}
		}

		static Delegate cb_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetOnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler ()
		{
			if (cb_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ == null)
				cb_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_);
			return cb_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
		}

		static void n_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_vf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var vf = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> (native_vf, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaFrameVideo (vf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnMediaFrameVideo' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
		[Register ("OnMediaFrameVideo", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V", "GetOnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler")]
		public virtual unsafe void OnMediaFrameVideo (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame vf)
		{
			const string __id = "OnMediaFrameVideo.(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((vf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (vf);
			}
		}

		static Delegate cb_OnRenderStateChanged_I;
#pragma warning disable 0169
		static Delegate GetOnRenderStateChanged_IHandler ()
		{
			if (cb_OnRenderStateChanged_I == null)
				cb_OnRenderStateChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnRenderStateChanged_I);
			return cb_OnRenderStateChanged_I;
		}

		static void n_OnRenderStateChanged_I (IntPtr jnienv, IntPtr native__this, int newstate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRenderStateChanged (newstate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnRenderStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("OnRenderStateChanged", "(I)V", "GetOnRenderStateChanged_IHandler")]
		public virtual unsafe void OnRenderStateChanged (int newstate)
		{
			const string __id = "OnRenderStateChanged.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (newstate);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_OnRequestExternalCamera;
#pragma warning disable 0169
		static Delegate GetOnRequestExternalCameraHandler ()
		{
			if (cb_OnRequestExternalCamera == null)
				cb_OnRequestExternalCamera = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_OnRequestExternalCamera);
			return cb_OnRequestExternalCamera;
		}

		static IntPtr n_OnRequestExternalCamera (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnRequestExternalCamera ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnRequestExternalCamera' and count(parameter)=0]"
		[Register ("OnRequestExternalCamera", "()Ljava/lang/Object;", "GetOnRequestExternalCameraHandler")]
		public virtual unsafe global::Java.Lang.Object OnRequestExternalCamera ()
		{
			const string __id = "OnRequestExternalCamera.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_OnUpdateDuration_JZ;
#pragma warning disable 0169
		static Delegate GetOnUpdateDuration_JZHandler ()
		{
			if (cb_OnUpdateDuration_JZ == null)
				cb_OnUpdateDuration_JZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJZ_V) n_OnUpdateDuration_JZ);
			return cb_OnUpdateDuration_JZ;
		}

		static void n_OnUpdateDuration_JZ (IntPtr jnienv, IntPtr native__this, long duration, bool end)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateDuration (duration, end);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='OnUpdateDuration' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("OnUpdateDuration", "(JZ)V", "GetOnUpdateDuration_JZHandler")]
		public virtual unsafe void OnUpdateDuration (long duration, bool end)
		{
			const string __id = "OnUpdateDuration.(JZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (duration);
				__args [1] = new JniArgumentValue (end);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_;
#pragma warning disable 0169
		static Delegate GetOpen_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Handler ()
		{
			if (cb_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_ == null)
				cb_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_I) n_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_);
			return cb_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_;
		}

		static int n_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Veg.Mediacapture.Sdk.IMediaCaptureCallback)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IMediaCaptureCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Open (config, @callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='Open' and count(parameter)=2 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[2][@type='veg.mediacapture.sdk.MediaCaptureCallback']]"
		[Register ("Open", "(Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/MediaCaptureCallback;)I", "GetOpen_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Handler")]
		public virtual unsafe int Open (global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback)
		{
			const string __id = "Open.(Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/MediaCaptureCallback;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Lveg_mediacapture_sdk_camera_ExternalCameraDelegate_;
#pragma warning disable 0169
		static Delegate GetOpen_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Lveg_mediacapture_sdk_camera_ExternalCameraDelegate_Handler ()
		{
			if (cb_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Lveg_mediacapture_sdk_camera_ExternalCameraDelegate_ == null)
				cb_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Lveg_mediacapture_sdk_camera_ExternalCameraDelegate_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLL_I) n_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Lveg_mediacapture_sdk_camera_ExternalCameraDelegate_);
			return cb_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Lveg_mediacapture_sdk_camera_ExternalCameraDelegate_;
		}

		static int n_Open_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Lveg_mediacapture_sdk_camera_ExternalCameraDelegate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config, IntPtr native__callback, IntPtr native__delegate)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var config = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCaptureConfig> (native_config, JniHandleOwnership.DoNotTransfer);
			var @callback = (global::Veg.Mediacapture.Sdk.IMediaCaptureCallback)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IMediaCaptureCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			var @delegate = (global::Veg.Mediacapture.Sdk.Camera.IExternalCameraDelegate)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Camera.IExternalCameraDelegate> (native__delegate, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Open (config, @callback, @delegate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='Open' and count(parameter)=3 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureConfig'] and parameter[2][@type='veg.mediacapture.sdk.MediaCaptureCallback'] and parameter[3][@type='veg.mediacapture.sdk.camera.ExternalCameraDelegate']]"
		[Register ("Open", "(Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/MediaCaptureCallback;Lveg/mediacapture/sdk/camera/ExternalCameraDelegate;)I", "GetOpen_Lveg_mediacapture_sdk_MediaCaptureConfig_Lveg_mediacapture_sdk_MediaCaptureCallback_Lveg_mediacapture_sdk_camera_ExternalCameraDelegate_Handler")]
		public virtual unsafe int Open (global::Veg.Mediacapture.Sdk.MediaCaptureConfig config, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback, global::Veg.Mediacapture.Sdk.Camera.IExternalCameraDelegate @delegate)
		{
			const string __id = "Open.(Lveg/mediacapture/sdk/MediaCaptureConfig;Lveg/mediacapture/sdk/MediaCaptureCallback;Lveg/mediacapture/sdk/camera/ExternalCameraDelegate;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((config == null) ? IntPtr.Zero : ((global::Java.Lang.Object) config).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				__args [2] = new JniArgumentValue ((@delegate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @delegate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (config);
				global::System.GC.KeepAlive (@callback);
				global::System.GC.KeepAlive (@delegate);
			}
		}

		static Delegate cb_PauseRecording;
#pragma warning disable 0169
		static Delegate GetPauseRecordingHandler ()
		{
			if (cb_PauseRecording == null)
				cb_PauseRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_PauseRecording);
			return cb_PauseRecording;
		}

		static void n_PauseRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PauseRecording ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='PauseRecording' and count(parameter)=0]"
		[Register ("PauseRecording", "()V", "GetPauseRecordingHandler")]
		public virtual unsafe void PauseRecording ()
		{
			const string __id = "PauseRecording.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='RequestPermission' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register ("RequestPermission", "(Landroid/content/Context;I)V", "")]
		public static unsafe void RequestPermission (global::Android.Content.Context context, int captureSource)
		{
			const string __id = "RequestPermission.(Landroid/content/Context;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (captureSource);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_ResumeRecording;
#pragma warning disable 0169
		static Delegate GetResumeRecordingHandler ()
		{
			if (cb_ResumeRecording == null)
				cb_ResumeRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ResumeRecording);
			return cb_ResumeRecording;
		}

		static void n_ResumeRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResumeRecording ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='ResumeRecording' and count(parameter)=0]"
		[Register ("ResumeRecording", "()V", "GetResumeRecordingHandler")]
		public virtual unsafe void ResumeRecording ()
		{
			const string __id = "ResumeRecording.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='SetPermissionRequestResults' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='android.content.Intent']]"
		[Register ("SetPermissionRequestResults", "(ILandroid/content/Intent;)V", "")]
		public static unsafe void SetPermissionRequestResults (int code, global::Android.Content.Intent data)
		{
			const string __id = "SetPermissionRequestResults.(ILandroid/content/Intent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (code);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_SetRecordingNewSegment;
#pragma warning disable 0169
		static Delegate GetSetRecordingNewSegmentHandler ()
		{
			if (cb_SetRecordingNewSegment == null)
				cb_SetRecordingNewSegment = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetRecordingNewSegment);
			return cb_SetRecordingNewSegment;
		}

		static void n_SetRecordingNewSegment (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRecordingNewSegment ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='SetRecordingNewSegment' and count(parameter)=0]"
		[Register ("SetRecordingNewSegment", "()V", "GetSetRecordingNewSegmentHandler")]
		public virtual unsafe void SetRecordingNewSegment ()
		{
			const string __id = "SetRecordingNewSegment.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_SetRecordingNewSegmentSec;
#pragma warning disable 0169
		static Delegate GetSetRecordingNewSegmentSecHandler ()
		{
			if (cb_SetRecordingNewSegmentSec == null)
				cb_SetRecordingNewSegmentSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_SetRecordingNewSegmentSec);
			return cb_SetRecordingNewSegmentSec;
		}

		static void n_SetRecordingNewSegmentSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRecordingNewSegmentSec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='SetRecordingNewSegmentSec' and count(parameter)=0]"
		[Register ("SetRecordingNewSegmentSec", "()V", "GetSetRecordingNewSegmentSecHandler")]
		public virtual unsafe void SetRecordingNewSegmentSec ()
		{
			const string __id = "SetRecordingNewSegmentSec.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_Start;
#pragma warning disable 0169
		static Delegate GetStartHandler ()
		{
			if (cb_Start == null)
				cb_Start = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Start);
			return cb_Start;
		}

		static void n_Start (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='Start' and count(parameter)=0]"
		[Register ("Start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "Start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StartRecording;
#pragma warning disable 0169
		static Delegate GetStartRecordingHandler ()
		{
			if (cb_StartRecording == null)
				cb_StartRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartRecording);
			return cb_StartRecording;
		}

		static void n_StartRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartRecording ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StartRecording' and count(parameter)=0]"
		[Register ("StartRecording", "()V", "GetStartRecordingHandler")]
		public virtual unsafe void StartRecording ()
		{
			const string __id = "StartRecording.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StartRecordingSec;
#pragma warning disable 0169
		static Delegate GetStartRecordingSecHandler ()
		{
			if (cb_StartRecordingSec == null)
				cb_StartRecordingSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartRecordingSec);
			return cb_StartRecordingSec;
		}

		static void n_StartRecordingSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartRecordingSec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StartRecordingSec' and count(parameter)=0]"
		[Register ("StartRecordingSec", "()V", "GetStartRecordingSecHandler")]
		public virtual unsafe void StartRecordingSec ()
		{
			const string __id = "StartRecordingSec.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StartStreaming;
#pragma warning disable 0169
		static Delegate GetStartStreamingHandler ()
		{
			if (cb_StartStreaming == null)
				cb_StartStreaming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartStreaming);
			return cb_StartStreaming;
		}

		static void n_StartStreaming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartStreaming ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StartStreaming' and count(parameter)=0]"
		[Register ("StartStreaming", "()V", "GetStartStreamingHandler")]
		public virtual unsafe void StartStreaming ()
		{
			const string __id = "StartStreaming.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StartStreaming_I;
#pragma warning disable 0169
		static Delegate GetStartStreaming_IHandler ()
		{
			if (cb_StartStreaming_I == null)
				cb_StartStreaming_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_StartStreaming_I);
			return cb_StartStreaming_I;
		}

		static void n_StartStreaming_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartStreaming (streamer_type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StartStreaming' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("StartStreaming", "(I)V", "GetStartStreaming_IHandler")]
		public virtual unsafe void StartStreaming (int streamer_type)
		{
			const string __id = "StartStreaming.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_StartStreamingSec;
#pragma warning disable 0169
		static Delegate GetStartStreamingSecHandler ()
		{
			if (cb_StartStreamingSec == null)
				cb_StartStreamingSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartStreamingSec);
			return cb_StartStreamingSec;
		}

		static void n_StartStreamingSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartStreamingSec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StartStreamingSec' and count(parameter)=0]"
		[Register ("StartStreamingSec", "()V", "GetStartStreamingSecHandler")]
		public virtual unsafe void StartStreamingSec ()
		{
			const string __id = "StartStreamingSec.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StartStreamingSec_I;
#pragma warning disable 0169
		static Delegate GetStartStreamingSec_IHandler ()
		{
			if (cb_StartStreamingSec_I == null)
				cb_StartStreamingSec_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_StartStreamingSec_I);
			return cb_StartStreamingSec_I;
		}

		static void n_StartStreamingSec_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartStreamingSec (streamer_type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StartStreamingSec' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("StartStreamingSec", "(I)V", "GetStartStreamingSec_IHandler")]
		public virtual unsafe void StartStreamingSec (int streamer_type)
		{
			const string __id = "StartStreamingSec.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_StartTranscoding;
#pragma warning disable 0169
		static Delegate GetStartTranscodingHandler ()
		{
			if (cb_StartTranscoding == null)
				cb_StartTranscoding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StartTranscoding);
			return cb_StartTranscoding;
		}

		static void n_StartTranscoding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartTranscoding ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StartTranscoding' and count(parameter)=0]"
		[Register ("StartTranscoding", "()V", "GetStartTranscodingHandler")]
		public virtual unsafe void StartTranscoding ()
		{
			const string __id = "StartTranscoding.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_Stop;
#pragma warning disable 0169
		static Delegate GetStopHandler ()
		{
			if (cb_Stop == null)
				cb_Stop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Stop);
			return cb_Stop;
		}

		static void n_Stop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='Stop' and count(parameter)=0]"
		[Register ("Stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "Stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StopRecording;
#pragma warning disable 0169
		static Delegate GetStopRecordingHandler ()
		{
			if (cb_StopRecording == null)
				cb_StopRecording = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopRecording);
			return cb_StopRecording;
		}

		static void n_StopRecording (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecording ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StopRecording' and count(parameter)=0]"
		[Register ("StopRecording", "()V", "GetStopRecordingHandler")]
		public virtual unsafe void StopRecording ()
		{
			const string __id = "StopRecording.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StopRecordingSec;
#pragma warning disable 0169
		static Delegate GetStopRecordingSecHandler ()
		{
			if (cb_StopRecordingSec == null)
				cb_StopRecordingSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopRecordingSec);
			return cb_StopRecordingSec;
		}

		static void n_StopRecordingSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopRecordingSec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StopRecordingSec' and count(parameter)=0]"
		[Register ("StopRecordingSec", "()V", "GetStopRecordingSecHandler")]
		public virtual unsafe void StopRecordingSec ()
		{
			const string __id = "StopRecordingSec.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StopStreaming;
#pragma warning disable 0169
		static Delegate GetStopStreamingHandler ()
		{
			if (cb_StopStreaming == null)
				cb_StopStreaming = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopStreaming);
			return cb_StopStreaming;
		}

		static void n_StopStreaming (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopStreaming ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StopStreaming' and count(parameter)=0]"
		[Register ("StopStreaming", "()V", "GetStopStreamingHandler")]
		public virtual unsafe void StopStreaming ()
		{
			const string __id = "StopStreaming.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StopStreaming_I;
#pragma warning disable 0169
		static Delegate GetStopStreaming_IHandler ()
		{
			if (cb_StopStreaming_I == null)
				cb_StopStreaming_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_StopStreaming_I);
			return cb_StopStreaming_I;
		}

		static void n_StopStreaming_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopStreaming (streamer_type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StopStreaming' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("StopStreaming", "(I)V", "GetStopStreaming_IHandler")]
		public virtual unsafe void StopStreaming (int streamer_type)
		{
			const string __id = "StopStreaming.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_StopStreamingSec;
#pragma warning disable 0169
		static Delegate GetStopStreamingSecHandler ()
		{
			if (cb_StopStreamingSec == null)
				cb_StopStreamingSec = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopStreamingSec);
			return cb_StopStreamingSec;
		}

		static void n_StopStreamingSec (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopStreamingSec ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StopStreamingSec' and count(parameter)=0]"
		[Register ("StopStreamingSec", "()V", "GetStopStreamingSecHandler")]
		public virtual unsafe void StopStreamingSec ()
		{
			const string __id = "StopStreamingSec.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_StopStreamingSec_I;
#pragma warning disable 0169
		static Delegate GetStopStreamingSec_IHandler ()
		{
			if (cb_StopStreamingSec_I == null)
				cb_StopStreamingSec_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_StopStreamingSec_I);
			return cb_StopStreamingSec_I;
		}

		static void n_StopStreamingSec_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopStreamingSec (streamer_type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StopStreamingSec' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("StopStreamingSec", "(I)V", "GetStopStreamingSec_IHandler")]
		public virtual unsafe void StopStreamingSec (int streamer_type)
		{
			const string __id = "StopStreamingSec.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_StopTranscoding;
#pragma warning disable 0169
		static Delegate GetStopTranscodingHandler ()
		{
			if (cb_StopTranscoding == null)
				cb_StopTranscoding = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopTranscoding);
			return cb_StopTranscoding;
		}

		static void n_StopTranscoding (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopTranscoding ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='StopTranscoding' and count(parameter)=0]"
		[Register ("StopTranscoding", "()V", "GetStopTranscodingHandler")]
		public virtual unsafe void StopTranscoding ()
		{
			const string __id = "StopTranscoding.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_TakeScreenshotBitmap;
#pragma warning disable 0169
		static Delegate GetTakeScreenshotBitmapHandler ()
		{
			if (cb_TakeScreenshotBitmap == null)
				cb_TakeScreenshotBitmap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TakeScreenshotBitmap);
			return cb_TakeScreenshotBitmap;
		}

		static IntPtr n_TakeScreenshotBitmap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TakeScreenshotBitmap ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='TakeScreenshotBitmap' and count(parameter)=0]"
		[Register ("TakeScreenshotBitmap", "()Landroid/graphics/Bitmap;", "GetTakeScreenshotBitmapHandler")]
		public virtual unsafe global::Android.Graphics.Bitmap TakeScreenshotBitmap ()
		{
			const string __id = "TakeScreenshotBitmap.()Landroid/graphics/Bitmap;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_TakeScreenshotImage;
#pragma warning disable 0169
		static Delegate GetTakeScreenshotImageHandler ()
		{
			if (cb_TakeScreenshotImage == null)
				cb_TakeScreenshotImage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_TakeScreenshotImage);
			return cb_TakeScreenshotImage;
		}

		static IntPtr n_TakeScreenshotImage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TakeScreenshotImage ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='TakeScreenshotImage' and count(parameter)=0]"
		[Register ("TakeScreenshotImage", "()Landroid/media/Image;", "GetTakeScreenshotImageHandler")]
		public virtual unsafe global::Android.Media.Image TakeScreenshotImage ()
		{
			const string __id = "TakeScreenshotImage.()Landroid/media/Image;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Media.Image> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_cameraSurfaceReady_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetCameraSurfaceReady_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_cameraSurfaceReady_Landroid_graphics_SurfaceTexture_ == null)
				cb_cameraSurfaceReady_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CameraSurfaceReady_Landroid_graphics_SurfaceTexture_);
			return cb_cameraSurfaceReady_Landroid_graphics_SurfaceTexture_;
		}

		static void n_CameraSurfaceReady_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_surface)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var surface = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_surface, JniHandleOwnership.DoNotTransfer);
			__this.CameraSurfaceReady (surface);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='cameraSurfaceReady' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("cameraSurfaceReady", "(Landroid/graphics/SurfaceTexture;)V", "GetCameraSurfaceReady_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void CameraSurfaceReady (global::Android.Graphics.SurfaceTexture surface)
		{
			const string __id = "cameraSurfaceReady.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((surface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) surface).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (surface);
			}
		}

		static Delegate cb_getAudioPackets_IZ;
#pragma warning disable 0169
		static Delegate GetGetAudioPackets_IZHandler ()
		{
			if (cb_getAudioPackets_IZ == null)
				cb_getAudioPackets_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_I) n_GetAudioPackets_IZ);
			return cb_getAudioPackets_IZ;
		}

		static int n_GetAudioPackets_IZ (IntPtr jnienv, IntPtr native__this, int streamer_type, bool is_sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAudioPackets (streamer_type, is_sec);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getAudioPackets' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getAudioPackets", "(IZ)I", "GetGetAudioPackets_IZHandler")]
		public virtual unsafe int GetAudioPackets (int streamer_type, bool is_sec)
		{
			const string __id = "getAudioPackets.(IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (is_sec);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getLastAudioPTS_IZ;
#pragma warning disable 0169
		static Delegate GetGetLastAudioPTS_IZHandler ()
		{
			if (cb_getLastAudioPTS_IZ == null)
				cb_getLastAudioPTS_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_J) n_GetLastAudioPTS_IZ);
			return cb_getLastAudioPTS_IZ;
		}

		static long n_GetLastAudioPTS_IZ (IntPtr jnienv, IntPtr native__this, int streamer_type, bool is_sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLastAudioPTS (streamer_type, is_sec);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getLastAudioPTS' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getLastAudioPTS", "(IZ)J", "GetGetLastAudioPTS_IZHandler")]
		public virtual unsafe long GetLastAudioPTS (int streamer_type, bool is_sec)
		{
			const string __id = "getLastAudioPTS.(IZ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (is_sec);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getLastVideoPTS_IZ;
#pragma warning disable 0169
		static Delegate GetGetLastVideoPTS_IZHandler ()
		{
			if (cb_getLastVideoPTS_IZ == null)
				cb_getLastVideoPTS_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_J) n_GetLastVideoPTS_IZ);
			return cb_getLastVideoPTS_IZ;
		}

		static long n_GetLastVideoPTS_IZ (IntPtr jnienv, IntPtr native__this, int streamer_type, bool is_sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetLastVideoPTS (streamer_type, is_sec);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getLastVideoPTS' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getLastVideoPTS", "(IZ)J", "GetGetLastVideoPTS_IZHandler")]
		public virtual unsafe long GetLastVideoPTS (int streamer_type, bool is_sec)
		{
			const string __id = "getLastVideoPTS.(IZ)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (is_sec);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPropLong_I;
#pragma warning disable 0169
		static Delegate GetGetPropLong_IHandler ()
		{
			if (cb_getPropLong_I == null)
				cb_getPropLong_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_J) n_GetPropLong_I);
			return cb_getPropLong_I;
		}

		static long n_GetPropLong_I (IntPtr jnienv, IntPtr native__this, int prop)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetPropLong (prop);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getPropLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPropLong", "(I)J", "GetGetPropLong_IHandler")]
		public virtual unsafe long GetPropLong (int prop)
		{
			const string __id = "getPropLong.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (prop);
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getPropString_I;
#pragma warning disable 0169
		static Delegate GetGetPropString_IHandler ()
		{
			if (cb_getPropString_I == null)
				cb_getPropString_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetPropString_I);
			return cb_getPropString_I;
		}

		static IntPtr n_GetPropString_I (IntPtr jnienv, IntPtr native__this, int prop)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetPropString (prop));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getPropString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPropString", "(I)Ljava/lang/String;", "GetGetPropString_IHandler")]
		public virtual unsafe string GetPropString (int prop)
		{
			const string __id = "getPropString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (prop);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRTSPBitRate_I;
#pragma warning disable 0169
		static Delegate GetGetRTSPBitRate_IHandler ()
		{
			if (cb_getRTSPBitRate_I == null)
				cb_getRTSPBitRate_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRTSPBitRate_I);
			return cb_getRTSPBitRate_I;
		}

		static int n_GetRTSPBitRate_I (IntPtr jnienv, IntPtr native__this, int channel)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRTSPBitRate (channel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getRTSPBitRate' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRTSPBitRate", "(I)I", "GetGetRTSPBitRate_IHandler")]
		public virtual unsafe int GetRTSPBitRate (int channel)
		{
			const string __id = "getRTSPBitRate.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channel);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getRTSPClients_I;
#pragma warning disable 0169
		static Delegate GetGetRTSPClients_IHandler ()
		{
			if (cb_getRTSPClients_I == null)
				cb_getRTSPClients_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetRTSPClients_I);
			return cb_getRTSPClients_I;
		}

		static IntPtr n_GetRTSPClients_I (IntPtr jnienv, IntPtr native__this, int channel)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRTSPClients (channel));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getRTSPClients' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRTSPClients", "(I)[Ljava/lang/String;", "GetGetRTSPClients_IHandler")]
		public virtual unsafe string[] GetRTSPClients (int channel)
		{
			const string __id = "getRTSPClients.(I)[Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channel);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getRTSPFps_I;
#pragma warning disable 0169
		static Delegate GetGetRTSPFps_IHandler ()
		{
			if (cb_getRTSPFps_I == null)
				cb_getRTSPFps_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetRTSPFps_I);
			return cb_getRTSPFps_I;
		}

		static int n_GetRTSPFps_I (IntPtr jnienv, IntPtr native__this, int channel)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRTSPFps (channel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getRTSPFps' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getRTSPFps", "(I)I", "GetGetRTSPFps_IHandler")]
		public virtual unsafe int GetRTSPFps (int channel)
		{
			const string __id = "getRTSPFps.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (channel);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getSPSPPSsize_arrayB;
#pragma warning disable 0169
		static Delegate GetGetSPSPPSsize_arrayBHandler ()
		{
			if (cb_getSPSPPSsize_arrayB == null)
				cb_getSPSPPSsize_arrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetSPSPPSsize_arrayB);
			return cb_getSPSPPSsize_arrayB;
		}

		static int n_GetSPSPPSsize_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_frame)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var frame = (byte[]) JNIEnv.GetArray (native_frame, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.GetSPSPPSsize (frame);
			if (frame != null)
				JNIEnv.CopyArray (frame, native_frame);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getSPSPPSsize' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("getSPSPPSsize", "([B)I", "GetGetSPSPPSsize_arrayBHandler")]
		public virtual unsafe int GetSPSPPSsize (byte[] frame)
		{
			const string __id = "getSPSPPSsize.([B)I";
			IntPtr native_frame = JNIEnv.NewArray (frame);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_frame);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (frame != null) {
					JNIEnv.CopyArray (native_frame, frame);
					JNIEnv.DeleteLocalRef (native_frame);
				}
				global::System.GC.KeepAlive (frame);
			}
		}

		static Delegate cb_getStatReconnectCount_IZ;
#pragma warning disable 0169
		static Delegate GetGetStatReconnectCount_IZHandler ()
		{
			if (cb_getStatReconnectCount_IZ == null)
				cb_getStatReconnectCount_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_I) n_GetStatReconnectCount_IZ);
			return cb_getStatReconnectCount_IZ;
		}

		static int n_GetStatReconnectCount_IZ (IntPtr jnienv, IntPtr native__this, int streamer_type, bool is_sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetStatReconnectCount (streamer_type, is_sec);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getStatReconnectCount' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getStatReconnectCount", "(IZ)I", "GetGetStatReconnectCount_IZHandler")]
		public virtual unsafe int GetStatReconnectCount (int streamer_type, bool is_sec)
		{
			const string __id = "getStatReconnectCount.(IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (is_sec);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getStreamStatus_I;
#pragma warning disable 0169
		static Delegate GetGetStreamStatus_IHandler ()
		{
			if (cb_getStreamStatus_I == null)
				cb_getStreamStatus_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_I) n_GetStreamStatus_I);
			return cb_getStreamStatus_I;
		}

		static int n_GetStreamStatus_I (IntPtr jnienv, IntPtr native__this, int streamer_type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetStreamStatus (streamer_type);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getStreamStatus' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStreamStatus", "(I)I", "GetGetStreamStatus_IHandler")]
		public virtual unsafe int GetStreamStatus (int streamer_type)
		{
			const string __id = "getStreamStatus.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamer_type);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getVideoPackets_IZ;
#pragma warning disable 0169
		static Delegate GetGetVideoPackets_IZHandler ()
		{
			if (cb_getVideoPackets_IZ == null)
				cb_getVideoPackets_IZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIZ_I) n_GetVideoPackets_IZ);
			return cb_getVideoPackets_IZ;
		}

		static int n_GetVideoPackets_IZ (IntPtr jnienv, IntPtr native__this, int streamer_type, bool is_sec)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetVideoPackets (streamer_type, is_sec);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='getVideoPackets' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("getVideoPackets", "(IZ)I", "GetGetVideoPackets_IZHandler")]
		public virtual unsafe int GetVideoPackets (int streamer_type, bool is_sec)
		{
			const string __id = "getVideoPackets.(IZ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (streamer_type);
				__args [1] = new JniArgumentValue (is_sec);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='get_clip_str' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("get_clip_str", "(J)Ljava/lang/String;", "")]
		public static unsafe string Get_clip_str (long val)
		{
			const string __id = "get_clip_str.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (val);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='get_clip_str2' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("get_clip_str2", "(J)Ljava/lang/String;", "")]
		public static unsafe string Get_clip_str2 (long val)
		{
			const string __id = "get_clip_str2.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (val);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='get_clip_str3' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("get_clip_str3", "(J)Ljava/lang/String;", "")]
		public static unsafe string Get_clip_str3 (long val)
		{
			const string __id = "get_clip_str3.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (val);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_indexOf_arrayBIarrayB;
#pragma warning disable 0169
		static Delegate GetIndexOf_arrayBIarrayBHandler ()
		{
			if (cb_indexOf_arrayBIarrayB == null)
				cb_indexOf_arrayBIarrayB = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_I) n_IndexOf_arrayBIarrayB);
			return cb_indexOf_arrayBIarrayB;
		}

		static int n_IndexOf_arrayBIarrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_outerArray, int startOffset, IntPtr native_smallerArray)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var outerArray = (byte[]) JNIEnv.GetArray (native_outerArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			var smallerArray = (byte[]) JNIEnv.GetArray (native_smallerArray, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.IndexOf (outerArray, startOffset, smallerArray);
			if (outerArray != null)
				JNIEnv.CopyArray (outerArray, native_outerArray);
			if (smallerArray != null)
				JNIEnv.CopyArray (smallerArray, native_smallerArray);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='indexOf' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='byte[]']]"
		[Register ("indexOf", "([BI[B)I", "GetIndexOf_arrayBIarrayBHandler")]
		public virtual unsafe int IndexOf (byte[] outerArray, int startOffset, byte[] smallerArray)
		{
			const string __id = "indexOf.([BI[B)I";
			IntPtr native_outerArray = JNIEnv.NewArray (outerArray);
			IntPtr native_smallerArray = JNIEnv.NewArray (smallerArray);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_outerArray);
				__args [1] = new JniArgumentValue (startOffset);
				__args [2] = new JniArgumentValue (native_smallerArray);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (outerArray != null) {
					JNIEnv.CopyArray (native_outerArray, outerArray);
					JNIEnv.DeleteLocalRef (native_outerArray);
				}
				if (smallerArray != null) {
					JNIEnv.CopyArray (native_smallerArray, smallerArray);
					JNIEnv.DeleteLocalRef (native_smallerArray);
				}
				global::System.GC.KeepAlive (outerArray);
				global::System.GC.KeepAlive (smallerArray);
			}
		}

		static Delegate cb_onDestroy;
#pragma warning disable 0169
		static Delegate GetOnDestroyHandler ()
		{
			if (cb_onDestroy == null)
				cb_onDestroy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDestroy);
			return cb_onDestroy;
		}

		static void n_OnDestroy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnDestroy ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='onDestroy' and count(parameter)=0]"
		[Register ("onDestroy", "()V", "GetOnDestroyHandler")]
		public virtual unsafe void OnDestroy ()
		{
			const string __id = "onDestroy.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_ == null)
				cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnFrameAvailable_Landroid_graphics_SurfaceTexture_);
			return cb_onFrameAvailable_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnFrameAvailable_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_arg0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var arg0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_arg0, JniHandleOwnership.DoNotTransfer);
			__this.OnFrameAvailable (arg0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='onFrameAvailable' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("onFrameAvailable", "(Landroid/graphics/SurfaceTexture;)V", "GetOnFrameAvailable_Landroid_graphics_SurfaceTexture_Handler")]
		public virtual unsafe void OnFrameAvailable (global::Android.Graphics.SurfaceTexture arg0)
		{
			const string __id = "onFrameAvailable.(Landroid/graphics/SurfaceTexture;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((arg0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) arg0).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (arg0);
			}
		}

		static Delegate cb_onPause;
#pragma warning disable 0169
		static Delegate GetOnPauseHandler ()
		{
			if (cb_onPause == null)
				cb_onPause = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnPause);
			return cb_onPause;
		}

		static void n_OnPause (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPause ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='onPause' and count(parameter)=0]"
		[Register ("onPause", "()V", "GetOnPauseHandler")]
		public virtual unsafe void OnPause ()
		{
			const string __id = "onPause.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			const string __id = "onResume.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStart;
#pragma warning disable 0169
		static Delegate GetOnStartHandler ()
		{
			if (cb_onStart == null)
				cb_onStart = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStart);
			return cb_onStart;
		}

		static void n_OnStart (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStart ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='onStart' and count(parameter)=0]"
		[Register ("onStart", "()V", "GetOnStartHandler")]
		public virtual unsafe void OnStart ()
		{
			const string __id = "onStart.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onStop;
#pragma warning disable 0169
		static Delegate GetOnStopHandler ()
		{
			if (cb_onStop == null)
				cb_onStop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnStop);
			return cb_onStop;
		}

		static void n_OnStop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnStop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='onStop' and count(parameter)=0]"
		[Register ("onStop", "()V", "GetOnStopHandler")]
		public virtual unsafe void OnStop ()
		{
			const string __id = "onStop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='pushAudioSharePacket' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("pushAudioSharePacket", "(Ljava/nio/ByteBuffer;IJ)I", "")]
		public static unsafe int PushAudioSharePacket (global::Java.Nio.ByteBuffer buffer, int size, long pts)
		{
			const string __id = "pushAudioSharePacket.(Ljava/nio/ByteBuffer;IJ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((buffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) buffer).Handle);
				__args [1] = new JniArgumentValue (size);
				__args [2] = new JniArgumentValue (pts);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (buffer);
			}
		}

		static Delegate cb_setCameraPreviewSize_II;
#pragma warning disable 0169
		static Delegate GetSetCameraPreviewSize_IIHandler ()
		{
			if (cb_setCameraPreviewSize_II == null)
				cb_setCameraPreviewSize_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPII_I) n_SetCameraPreviewSize_II);
			return cb_setCameraPreviewSize_II;
		}

		static int n_SetCameraPreviewSize_II (IntPtr jnienv, IntPtr native__this, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetCameraPreviewSize (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='setCameraPreviewSize' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setCameraPreviewSize", "(II)I", "GetSetCameraPreviewSize_IIHandler")]
		public virtual unsafe int SetCameraPreviewSize (int width, int height)
		{
			const string __id = "setCameraPreviewSize.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setCameraPreviewViewport_IIII;
#pragma warning disable 0169
		static Delegate GetSetCameraPreviewViewport_IIIIHandler ()
		{
			if (cb_setCameraPreviewViewport_IIII == null)
				cb_setCameraPreviewViewport_IIII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIIII_I) n_SetCameraPreviewViewport_IIII);
			return cb_setCameraPreviewViewport_IIII;
		}

		static int n_SetCameraPreviewViewport_IIII (IntPtr jnienv, IntPtr native__this, int x, int y, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SetCameraPreviewViewport (x, y, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='setCameraPreviewViewport' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setCameraPreviewViewport", "(IIII)I", "GetSetCameraPreviewViewport_IIIIHandler")]
		public virtual unsafe int SetCameraPreviewViewport (int x, int y, int width, int height)
		{
			const string __id = "setCameraPreviewViewport.(IIII)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
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

		static void n_SetMulticast_ZLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, bool e, IntPtr native_ip, int ttl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ip = JNIEnv.GetString (native_ip, JniHandleOwnership.DoNotTransfer);
			__this.SetMulticast (e, ip, ttl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='setMulticast' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setMulticast", "(ZLjava/lang/String;I)V", "GetSetMulticast_ZLjava_lang_String_IHandler")]
		public virtual unsafe void SetMulticast (bool e, string ip, int ttl)
		{
			const string __id = "setMulticast.(ZLjava/lang/String;I)V";
			IntPtr native_ip = JNIEnv.NewString (ip);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (e);
				__args [1] = new JniArgumentValue (native_ip);
				__args [2] = new JniArgumentValue (ttl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ip);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='startAudioShare' and count(parameter)=6 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='veg.mediacapture.sdk.MediaCaptureCallback']]"
		[Register ("startAudioShare", "(IIIIILveg/mediacapture/sdk/MediaCaptureCallback;)I", "")]
		public static unsafe int StartAudioShare (int audioSource, int sampleRate, int channelConfig, int audioFormat, int bufferSize, global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback)
		{
			const string __id = "startAudioShare.(IIIIILveg/mediacapture/sdk/MediaCaptureCallback;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (audioSource);
				__args [1] = new JniArgumentValue (sampleRate);
				__args [2] = new JniArgumentValue (channelConfig);
				__args [3] = new JniArgumentValue (audioFormat);
				__args [4] = new JniArgumentValue (bufferSize);
				__args [5] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='startAudioShare' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureCallback']]"
		[Register ("startAudioShare", "(Lveg/mediacapture/sdk/MediaCaptureCallback;)I", "")]
		public static unsafe int StartAudioShare (global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback)
		{
			const string __id = "startAudioShare.(Lveg/mediacapture/sdk/MediaCaptureCallback;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='stopAudioShare' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.MediaCaptureCallback']]"
		[Register ("stopAudioShare", "(Lveg/mediacapture/sdk/MediaCaptureCallback;)I", "")]
		public static unsafe int StopAudioShare (global::Veg.Mediacapture.Sdk.IMediaCaptureCallback @callback)
		{
			const string __id = "stopAudioShare.(Lveg/mediacapture/sdk/MediaCaptureCallback;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
#pragma warning disable 0169
		static Delegate GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler ()
		{
			if (cb_surfaceChanged_Landroid_view_SurfaceHolder_III == null)
				cb_surfaceChanged_Landroid_view_SurfaceHolder_III = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIII_V) n_SurfaceChanged_Landroid_view_SurfaceHolder_III);
			return cb_surfaceChanged_Landroid_view_SurfaceHolder_III;
		}

		static void n_SurfaceChanged_Landroid_view_SurfaceHolder_III (IntPtr jnienv, IntPtr native__this, IntPtr native_holder, int native_format, int width, int height)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			var format = (global::Android.Graphics.Format) native_format;
			__this.SurfaceChanged (holder, format, width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='surfaceChanged' and count(parameter)=4 and parameter[1][@type='android.view.SurfaceHolder'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("surfaceChanged", "(Landroid/view/SurfaceHolder;III)V", "GetSurfaceChanged_Landroid_view_SurfaceHolder_IIIHandler")]
		public virtual unsafe void SurfaceChanged (global::Android.Views.ISurfaceHolder holder, [global::Android.Runtime.GeneratedEnum] global::Android.Graphics.Format format, int width, int height)
		{
			const string __id = "surfaceChanged.(Landroid/view/SurfaceHolder;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				__args [1] = new JniArgumentValue ((int) format);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_surfaceCreated_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceCreated_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceCreated_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SurfaceCreated_Landroid_view_SurfaceHolder_);
			return cb_surfaceCreated_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceCreated_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceCreated (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='surfaceCreated' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceCreated", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceCreated_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceCreated (global::Android.Views.ISurfaceHolder holder)
		{
			const string __id = "surfaceCreated.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

		static Delegate cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
#pragma warning disable 0169
		static Delegate GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler ()
		{
			if (cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ == null)
				cb_surfaceDestroyed_Landroid_view_SurfaceHolder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SurfaceDestroyed_Landroid_view_SurfaceHolder_);
			return cb_surfaceDestroyed_Landroid_view_SurfaceHolder_;
		}

		static void n_SurfaceDestroyed_Landroid_view_SurfaceHolder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_holder)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.MediaCapture> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var holder = (global::Android.Views.ISurfaceHolder)global::Java.Lang.Object.GetObject<global::Android.Views.ISurfaceHolder> (native_holder, JniHandleOwnership.DoNotTransfer);
			__this.SurfaceDestroyed (holder);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/class[@name='MediaCapture']/method[@name='surfaceDestroyed' and count(parameter)=1 and parameter[1][@type='android.view.SurfaceHolder']]"
		[Register ("surfaceDestroyed", "(Landroid/view/SurfaceHolder;)V", "GetSurfaceDestroyed_Landroid_view_SurfaceHolder_Handler")]
		public virtual unsafe void SurfaceDestroyed (global::Android.Views.ISurfaceHolder holder)
		{
			const string __id = "surfaceDestroyed.(Landroid/view/SurfaceHolder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((holder == null) ? IntPtr.Zero : ((global::Java.Lang.Object) holder).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (holder);
			}
		}

	}
}
