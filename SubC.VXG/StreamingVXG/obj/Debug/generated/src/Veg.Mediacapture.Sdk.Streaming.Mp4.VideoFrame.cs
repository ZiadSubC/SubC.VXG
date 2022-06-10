using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming.Mp4 {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/mp4/VideoFrame", DoNotGenerateAcw=true)]
	public partial class VideoFrame : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='VIDEO_FRAME_FLAG_END_OF_STREAM']"
		[Register ("VIDEO_FRAME_FLAG_END_OF_STREAM")]
		public const int VideoFrameFlagEndOfStream = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='VIDEO_FRAME_FLAG_PROCESSED']"
		[Register ("VIDEO_FRAME_FLAG_PROCESSED")]
		public const int VideoFrameFlagProcessed = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='VIDEO_FRAME_SPSPPS']"
		[Register ("VIDEO_FRAME_SPSPPS")]
		public const int VideoFrameSpspps = (int) 4;


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='flags']"
		[Register ("flags")]
		public int Flags {
			get {
				const string __id = "flags.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "flags.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='frame_num']"
		[Register ("frame_num")]
		public int FrameNum {
			get {
				const string __id = "frame_num.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "frame_num.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='frame_size']"
		[Register ("frame_size")]
		public int FrameSize {
			get {
				const string __id = "frame_size.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "frame_size.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='framebuf']"
		[Register ("framebuf")]
		public global::Java.Nio.ByteBuffer Framebuf {
			get {
				const string __id = "framebuf.Ljava/nio/ByteBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "framebuf.Ljava/nio/ByteBuffer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='is_key']"
		[Register ("is_key")]
		public bool IsKey {
			get {
				const string __id = "is_key.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "is_key.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='pts']"
		[Register ("pts")]
		public long Pts {
			get {
				const string __id = "pts.J";

				var __v = _members.InstanceFields.GetInt64Value (__id, this);
				return __v;
			}
			set {
				const string __id = "pts.J";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/field[@name='width']"
		[Register ("width")]
		public int Width {
			get {
				const string __id = "width.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "width.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/mp4/VideoFrame", typeof (VideoFrame));

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

		protected VideoFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/constructor[@name='VideoFrame' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe VideoFrame () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming.mp4']/class[@name='VideoFrame']/constructor[@name='VideoFrame' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
		[Register (".ctor", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V", "")]
		public unsafe VideoFrame (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame vf) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((vf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) vf).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (vf);
			}
		}

	}
}
