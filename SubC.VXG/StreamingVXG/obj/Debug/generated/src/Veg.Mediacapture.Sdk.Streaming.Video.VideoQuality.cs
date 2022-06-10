using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Video {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/video/VideoQuality", DoNotGenerateAcw=true)]
	public partial class VideoQuality : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/field[@name='bitrate']"
		[Register ("bitrate")]
		public int Bitrate {
			get {
				const string __id = "bitrate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "bitrate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/field[@name='defaultVideoQualiy']"
		[Register ("defaultVideoQualiy")]
		public static global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality DefaultVideoQualiy {
			get {
				const string __id = "defaultVideoQualiy.Lveg/mediacapture/sdk/streaming/video/VideoQuality;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/field[@name='framerate']"
		[Register ("framerate")]
		public int Framerate {
			get {
				const string __id = "framerate.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "framerate.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/field[@name='orientation']"
		[Register ("orientation")]
		public int Orientation {
			get {
				const string __id = "orientation.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "orientation.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/field[@name='resX']"
		[Register ("resX")]
		public int ResX {
			get {
				const string __id = "resX.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "resX.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/field[@name='resY']"
		[Register ("resY")]
		public int ResY {
			get {
				const string __id = "resY.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "resY.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/video/VideoQuality", typeof (VideoQuality));

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

		protected VideoQuality (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/constructor[@name='VideoQuality' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoQuality () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/constructor[@name='VideoQuality' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register (".ctor", "(IIII)V", "")]
		public unsafe VideoQuality (int resX, int resY, int framerate, int bitrate) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (resX);
				__args [1] = new JniArgumentValue (resY);
				__args [2] = new JniArgumentValue (framerate);
				__args [3] = new JniArgumentValue (bitrate);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/constructor[@name='VideoQuality' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register (".ctor", "(IIIII)V", "")]
		public unsafe VideoQuality (int resX, int resY, int framerate, int bitrate, int orientation) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIIII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (resX);
				__args [1] = new JniArgumentValue (resY);
				__args [2] = new JniArgumentValue (framerate);
				__args [3] = new JniArgumentValue (bitrate);
				__args [4] = new JniArgumentValue (orientation);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clone;
#pragma warning disable 0169
		static Delegate GetCloneHandler ()
		{
			if (cb_clone == null)
				cb_clone = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Clone);
			return cb_clone;
		}

		static IntPtr n_Clone (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Clone ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/method[@name='clone' and count(parameter)=0]"
		[Register ("clone", "()Lveg/mediacapture/sdk/streaming/video/VideoQuality;", "GetCloneHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality Clone ()
		{
			const string __id = "clone.()Lveg/mediacapture/sdk/streaming/video/VideoQuality;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_equals_Lveg_mediacapture_sdk_streaming_video_VideoQuality_;
#pragma warning disable 0169
		static Delegate GetEquals_Lveg_mediacapture_sdk_streaming_video_VideoQuality_Handler ()
		{
			if (cb_equals_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ == null)
				cb_equals_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Lveg_mediacapture_sdk_streaming_video_VideoQuality_);
			return cb_equals_Lveg_mediacapture_sdk_streaming_video_VideoQuality_;
		}

		static bool n_Equals_Lveg_mediacapture_sdk_streaming_video_VideoQuality_ (IntPtr jnienv, IntPtr native__this, IntPtr native_quality)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var quality = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (native_quality, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Equals (quality);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/method[@name='equals' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.video.VideoQuality']]"
		[Register ("equals", "(Lveg/mediacapture/sdk/streaming/video/VideoQuality;)Z", "GetEquals_Lveg_mediacapture_sdk_streaming_video_VideoQuality_Handler")]
		public virtual unsafe bool Equals (global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality quality)
		{
			const string __id = "equals.(Lveg/mediacapture/sdk/streaming/video/VideoQuality;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((quality == null) ? IntPtr.Zero : ((global::Java.Lang.Object) quality).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (quality);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/method[@name='merge' and count(parameter)=2 and parameter[1][@type='veg.mediacapture.sdk.streaming.video.VideoQuality'] and parameter[2][@type='veg.mediacapture.sdk.streaming.video.VideoQuality']]"
		[Register ("merge", "(Lveg/mediacapture/sdk/streaming/video/VideoQuality;Lveg/mediacapture/sdk/streaming/video/VideoQuality;)Lveg/mediacapture/sdk/streaming/video/VideoQuality;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality Merge (global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality videoQuality, global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality withVideoQuality)
		{
			const string __id = "merge.(Lveg/mediacapture/sdk/streaming/video/VideoQuality;Lveg/mediacapture/sdk/streaming/video/VideoQuality;)Lveg/mediacapture/sdk/streaming/video/VideoQuality;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((videoQuality == null) ? IntPtr.Zero : ((global::Java.Lang.Object) videoQuality).Handle);
				__args [1] = new JniArgumentValue ((withVideoQuality == null) ? IntPtr.Zero : ((global::Java.Lang.Object) withVideoQuality).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (videoQuality);
				global::System.GC.KeepAlive (withVideoQuality);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.video']/class[@name='VideoQuality']/method[@name='parseQuality' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parseQuality", "(Ljava/lang/String;)Lveg/mediacapture/sdk/streaming/video/VideoQuality;", "")]
		public static unsafe global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality ParseQuality (string str)
		{
			const string __id = "parseQuality.(Ljava/lang/String;)Lveg/mediacapture/sdk/streaming/video/VideoQuality;";
			IntPtr native_str = JNIEnv.NewString (str);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_str);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoQuality> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_str);
			}
		}

	}
}
