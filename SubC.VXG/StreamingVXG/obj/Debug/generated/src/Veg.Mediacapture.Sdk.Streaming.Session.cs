using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk.Streaming {

	// Metadata.xml XPath class reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']"
	[global::Android.Runtime.Register ("veg/mediacapture/sdk/streaming/Session", DoNotGenerateAcw=true)]
	public partial class Session : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/field[@name='LOG_LEVEL']"
		[Register ("LOG_LEVEL")]
		public const int LogLevel = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/field[@name='TAG']"
		[Register ("TAG")]
		public const string Tag = (string) "Session";


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/field[@name='gnClipin']"
		[Register ("gnClipin")]
		public static int GnClipin {
			get {
				const string __id = "gnClipin.I";

				var __v = _members.StaticFields.GetInt32Value (__id);
				return __v;
			}
			set {
				const string __id = "gnClipin.I";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/field[@name='gnHRV_end_pts']"
		[Register ("gnHRV_end_pts")]
		public static long GnHRVEndPts {
			get {
				const string __id = "gnHRV_end_pts.J";

				var __v = _members.StaticFields.GetInt64Value (__id);
				return __v;
			}
			set {
				const string __id = "gnHRV_end_pts.J";

				try {
					_members.StaticFields.SetValue (__id, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/field[@name='gsSessionName']"
		[Register ("gsSessionName")]
		public static string GsSessionName {
			get {
				const string __id = "gsSessionName.Ljava/lang/String;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "gsSessionName.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.StaticFields.SetValue (__id, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/streaming/Session", typeof (Session));

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

		protected Session (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/constructor[@name='Session' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Session () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/constructor[@name='Session' and count(parameter)=2 and parameter[1][@type='java.net.InetAddress'] and parameter[2][@type='java.net.InetAddress']]"
		[Register (".ctor", "(Ljava/net/InetAddress;Ljava/net/InetAddress;)V", "")]
		public unsafe Session (global::Java.Net.InetAddress origin, global::Java.Net.InetAddress destination) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/net/InetAddress;Ljava/net/InetAddress;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((origin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) origin).Handle);
				__args [1] = new JniArgumentValue ((destination == null) ? IntPtr.Zero : ((global::Java.Lang.Object) destination).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (origin);
				global::System.GC.KeepAlive (destination);
			}
		}

		static Delegate cb_getAudioTrack;
#pragma warning disable 0169
		static Delegate GetGetAudioTrackHandler ()
		{
			if (cb_getAudioTrack == null)
				cb_getAudioTrack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAudioTrack);
			return cb_getAudioTrack;
		}

		static IntPtr n_GetAudioTrack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AudioTrack);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream AudioTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='getAudioTrack' and count(parameter)=0]"
			[Register ("getAudioTrack", "()Lveg/mediacapture/sdk/streaming/audio/AudioStream;", "GetGetAudioTrackHandler")]
			get {
				const string __id = "getAudioTrack.()Lveg/mediacapture/sdk/streaming/audio/AudioStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int Clipin {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='GetClipin' and count(parameter)=0]"
			[Register ("GetClipin", "()I", "")]
			get {
				const string __id = "GetClipin.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='SetClipin' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("SetClipin", "(I)V", "")]
			set {
				const string __id = "SetClipin.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDestination;
#pragma warning disable 0169
		static Delegate GetGetDestinationHandler ()
		{
			if (cb_getDestination == null)
				cb_getDestination = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDestination);
			return cb_getDestination;
		}

		static IntPtr n_GetDestination (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Destination);
		}
#pragma warning restore 0169

		static Delegate cb_setDestination_Ljava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetSetDestination_Ljava_net_InetAddress_Handler ()
		{
			if (cb_setDestination_Ljava_net_InetAddress_ == null)
				cb_setDestination_Ljava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDestination_Ljava_net_InetAddress_);
			return cb_setDestination_Ljava_net_InetAddress_;
		}

		static void n_SetDestination_Ljava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_destination)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var destination = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_destination, JniHandleOwnership.DoNotTransfer);
			__this.Destination = destination;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Net.InetAddress Destination {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='getDestination' and count(parameter)=0]"
			[Register ("getDestination", "()Ljava/net/InetAddress;", "GetGetDestinationHandler")]
			get {
				const string __id = "getDestination.()Ljava/net/InetAddress;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='setDestination' and count(parameter)=1 and parameter[1][@type='java.net.InetAddress']]"
			[Register ("setDestination", "(Ljava/net/InetAddress;)V", "GetSetDestination_Ljava_net_InetAddress_Handler")]
			set {
				const string __id = "setDestination.(Ljava/net/InetAddress;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		public static unsafe long HRV_end_pts {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='GetHRV_end_pts' and count(parameter)=0]"
			[Register ("GetHRV_end_pts", "()J", "")]
			get {
				const string __id = "GetHRV_end_pts.()J";
				try {
					var __rm = _members.StaticMethods.InvokeInt64Method (__id, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='SetHRV_end_pts' and count(parameter)=1 and parameter[1][@type='long']]"
			[Register ("SetHRV_end_pts", "(J)V", "")]
			set {
				const string __id = "SetHRV_end_pts.(J)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStreaming;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStreaming {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='isStreaming' and count(parameter)=0]"
			[Register ("isStreaming", "()Z", "GetIsStreamingHandler")]
			get {
				const string __id = "isStreaming.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getProjection;
#pragma warning disable 0169
		static Delegate GetGetProjectionHandler ()
		{
			if (cb_getProjection == null)
				cb_getProjection = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetProjection);
			return cb_getProjection;
		}

		static IntPtr n_GetProjection (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Projection);
		}
#pragma warning restore 0169

		static Delegate cb_setProjection_Landroid_media_projection_MediaProjection_;
#pragma warning disable 0169
		static Delegate GetSetProjection_Landroid_media_projection_MediaProjection_Handler ()
		{
			if (cb_setProjection_Landroid_media_projection_MediaProjection_ == null)
				cb_setProjection_Landroid_media_projection_MediaProjection_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetProjection_Landroid_media_projection_MediaProjection_);
			return cb_setProjection_Landroid_media_projection_MediaProjection_;
		}

		static void n_SetProjection_Landroid_media_projection_MediaProjection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_projection)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var projection = global::Java.Lang.Object.GetObject<global::Android.Media.Projection.MediaProjection> (native_projection, JniHandleOwnership.DoNotTransfer);
			__this.Projection = projection;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Media.Projection.MediaProjection Projection {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='getProjection' and count(parameter)=0]"
			[Register ("getProjection", "()Landroid/media/projection/MediaProjection;", "GetGetProjectionHandler")]
			get {
				const string __id = "getProjection.()Landroid/media/projection/MediaProjection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Media.Projection.MediaProjection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='setProjection' and count(parameter)=1 and parameter[1][@type='android.media.projection.MediaProjection']]"
			[Register ("setProjection", "(Landroid/media/projection/MediaProjection;)V", "GetSetProjection_Landroid_media_projection_MediaProjection_Handler")]
			set {
				const string __id = "setProjection.(Landroid/media/projection/MediaProjection;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getSessionDescription;
#pragma warning disable 0169
		static Delegate GetGetSessionDescriptionHandler ()
		{
			if (cb_getSessionDescription == null)
				cb_getSessionDescription = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetSessionDescription);
			return cb_getSessionDescription;
		}

		static IntPtr n_GetSessionDescription (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionDescription);
		}
#pragma warning restore 0169

		public virtual unsafe string SessionDescription {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='getSessionDescription' and count(parameter)=0]"
			[Register ("getSessionDescription", "()Ljava/lang/String;", "GetGetSessionDescriptionHandler")]
			get {
				const string __id = "getSessionDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe string SessionName {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='GetSessionName' and count(parameter)=0]"
			[Register ("GetSessionName", "()Ljava/lang/String;", "")]
			get {
				const string __id = "GetSessionName.()Ljava/lang/String;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='SetSessionName' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("SetSessionName", "(Ljava/lang/String;)V", "")]
			set {
				const string __id = "SetSessionName.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.StaticMethods.InvokeVoidMethod (__id, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getVideoTrack;
#pragma warning disable 0169
		static Delegate GetGetVideoTrackHandler ()
		{
			if (cb_getVideoTrack == null)
				cb_getVideoTrack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetVideoTrack);
			return cb_getVideoTrack;
		}

		static IntPtr n_GetVideoTrack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VideoTrack);
		}
#pragma warning restore 0169

		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream VideoTrack {
			// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='getVideoTrack' and count(parameter)=0]"
			[Register ("getVideoTrack", "()Lveg/mediacapture/sdk/streaming/video/VideoStream;", "GetGetVideoTrackHandler")]
			get {
				const string __id = "getVideoTrack.()Lveg/mediacapture/sdk/streaming/video/VideoStream;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_GetMP4Mux_I;
#pragma warning disable 0169
		static Delegate GetGetMP4Mux_IHandler ()
		{
			if (cb_GetMP4Mux_I == null)
				cb_GetMP4Mux_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetMP4Mux_I);
			return cb_GetMP4Mux_I;
		}

		static IntPtr n_GetMP4Mux_I (IntPtr jnienv, IntPtr native__this, int type)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMP4Mux (type));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='GetMP4Mux' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("GetMP4Mux", "(I)Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;", "GetGetMP4Mux_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj GetMP4Mux (int type)
		{
			const string __id = "GetMP4Mux.(I)Lveg/mediacapture/sdk/streaming/mp4/MP4Muxj;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (type);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.MP4Muxj> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_SetMP4Mux_ILjava_lang_String_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetMP4Mux_ILjava_lang_String_Landroid_content_Context_Handler ()
		{
			if (cb_SetMP4Mux_ILjava_lang_String_Landroid_content_Context_ == null)
				cb_SetMP4Mux_ILjava_lang_String_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPILL_V) n_SetMP4Mux_ILjava_lang_String_Landroid_content_Context_);
			return cb_SetMP4Mux_ILjava_lang_String_Landroid_content_Context_;
		}

		static void n_SetMP4Mux_ILjava_lang_String_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, int type, IntPtr native_filename, IntPtr native_ctx)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var filename = JNIEnv.GetString (native_filename, JniHandleOwnership.DoNotTransfer);
			var ctx = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_ctx, JniHandleOwnership.DoNotTransfer);
			__this.SetMP4Mux (type, filename, ctx);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='SetMP4Mux' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.content.Context']]"
		[Register ("SetMP4Mux", "(ILjava/lang/String;Landroid/content/Context;)V", "GetSetMP4Mux_ILjava_lang_String_Landroid_content_Context_Handler")]
		public virtual unsafe void SetMP4Mux (int type, string filename, global::Android.Content.Context ctx)
		{
			const string __id = "SetMP4Mux.(ILjava/lang/String;Landroid/content/Context;)V";
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (type);
				__args [1] = new JniArgumentValue (native_filename);
				__args [2] = new JniArgumentValue ((ctx == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ctx).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_filename);
				global::System.GC.KeepAlive (ctx);
			}
		}

		static Delegate cb_addAudioTrack_Lveg_mediacapture_sdk_streaming_audio_AudioStream_;
#pragma warning disable 0169
		static Delegate GetAddAudioTrack_Lveg_mediacapture_sdk_streaming_audio_AudioStream_Handler ()
		{
			if (cb_addAudioTrack_Lveg_mediacapture_sdk_streaming_audio_AudioStream_ == null)
				cb_addAudioTrack_Lveg_mediacapture_sdk_streaming_audio_AudioStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddAudioTrack_Lveg_mediacapture_sdk_streaming_audio_AudioStream_);
			return cb_addAudioTrack_Lveg_mediacapture_sdk_streaming_audio_AudioStream_;
		}

		static void n_AddAudioTrack_Lveg_mediacapture_sdk_streaming_audio_AudioStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var track = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream> (native_track, JniHandleOwnership.DoNotTransfer);
			__this.AddAudioTrack (track);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='addAudioTrack' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.audio.AudioStream']]"
		[Register ("addAudioTrack", "(Lveg/mediacapture/sdk/streaming/audio/AudioStream;)V", "GetAddAudioTrack_Lveg_mediacapture_sdk_streaming_audio_AudioStream_Handler")]
		public virtual unsafe void AddAudioTrack (global::Veg.Mediacapture.Sdk.Streaming.Audio.AudioStream track)
		{
			const string __id = "addAudioTrack.(Lveg/mediacapture/sdk/streaming/audio/AudioStream;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (track);
			}
		}

		static Delegate cb_addVideoTrack_Lveg_mediacapture_sdk_streaming_video_VideoStream_;
#pragma warning disable 0169
		static Delegate GetAddVideoTrack_Lveg_mediacapture_sdk_streaming_video_VideoStream_Handler ()
		{
			if (cb_addVideoTrack_Lveg_mediacapture_sdk_streaming_video_VideoStream_ == null)
				cb_addVideoTrack_Lveg_mediacapture_sdk_streaming_video_VideoStream_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddVideoTrack_Lveg_mediacapture_sdk_streaming_video_VideoStream_);
			return cb_addVideoTrack_Lveg_mediacapture_sdk_streaming_video_VideoStream_;
		}

		static void n_AddVideoTrack_Lveg_mediacapture_sdk_streaming_video_VideoStream_ (IntPtr jnienv, IntPtr native__this, IntPtr native_track)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var track = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream> (native_track, JniHandleOwnership.DoNotTransfer);
			__this.AddVideoTrack (track);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='addVideoTrack' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.video.VideoStream']]"
		[Register ("addVideoTrack", "(Lveg/mediacapture/sdk/streaming/video/VideoStream;)V", "GetAddVideoTrack_Lveg_mediacapture_sdk_streaming_video_VideoStream_Handler")]
		public virtual unsafe void AddVideoTrack (global::Veg.Mediacapture.Sdk.Streaming.Video.VideoStream track)
		{
			const string __id = "addVideoTrack.(Lveg/mediacapture/sdk/streaming/video/VideoStream;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((track == null) ? IntPtr.Zero : ((global::Java.Lang.Object) track).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (track);
			}
		}

		static Delegate cb_flush;
#pragma warning disable 0169
		static Delegate GetFlushHandler ()
		{
			if (cb_flush == null)
				cb_flush = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Flush);
			return cb_flush;
		}

		static void n_Flush (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flush ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='flush' and count(parameter)=0]"
		[Register ("flush", "()V", "GetFlushHandler")]
		public virtual unsafe void Flush ()
		{
			const string __id = "flush.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getTrack_I;
#pragma warning disable 0169
		static Delegate GetGetTrack_IHandler ()
		{
			if (cb_getTrack_I == null)
				cb_getTrack_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetTrack_I);
			return cb_getTrack_I;
		}

		static IntPtr n_GetTrack_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTrack (id));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='getTrack' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTrack", "(I)Lveg/mediacapture/sdk/streaming/Stream;", "GetGetTrack_IHandler")]
		public virtual unsafe global::Veg.Mediacapture.Sdk.Streaming.IStream GetTrack (int id)
		{
			const string __id = "getTrack.(I)Lveg/mediacapture/sdk/streaming/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.IStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_get_start_time;
#pragma warning disable 0169
		static Delegate GetGet_start_timeHandler ()
		{
			if (cb_get_start_time == null)
				cb_get_start_time = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_Get_start_time);
			return cb_get_start_time;
		}

		static long n_Get_start_time (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Get_start_time ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='get_start_time' and count(parameter)=0]"
		[Register ("get_start_time", "()J", "GetGet_start_timeHandler")]
		public virtual unsafe long Get_start_time ()
		{
			const string __id = "get_start_time.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_pause_I;
#pragma warning disable 0169
		static Delegate GetPause_IHandler ()
		{
			if (cb_pause_I == null)
				cb_pause_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Pause_I);
			return cb_pause_I;
		}

		static void n_Pause_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Pause (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='pause' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("pause", "(I)V", "GetPause_IHandler")]
		public virtual unsafe void Pause (int id)
		{
			const string __id = "pause.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_prepare_I;
#pragma warning disable 0169
		static Delegate GetPrepare_IHandler ()
		{
			if (cb_prepare_I == null)
				cb_prepare_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Prepare_I);
			return cb_prepare_I;
		}

		static void n_Prepare_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Prepare (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='prepare' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("prepare", "(I)V", "GetPrepare_IHandler")]
		public virtual unsafe void Prepare (int id)
		{
			const string __id = "prepare.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeAudioTrack;
#pragma warning disable 0169
		static Delegate GetRemoveAudioTrackHandler ()
		{
			if (cb_removeAudioTrack == null)
				cb_removeAudioTrack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveAudioTrack);
			return cb_removeAudioTrack;
		}

		static void n_RemoveAudioTrack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAudioTrack ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='removeAudioTrack' and count(parameter)=0]"
		[Register ("removeAudioTrack", "()V", "GetRemoveAudioTrackHandler")]
		public virtual unsafe void RemoveAudioTrack ()
		{
			const string __id = "removeAudioTrack.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeVideoTrack;
#pragma warning disable 0169
		static Delegate GetRemoveVideoTrackHandler ()
		{
			if (cb_removeVideoTrack == null)
				cb_removeVideoTrack = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RemoveVideoTrack);
			return cb_removeVideoTrack;
		}

		static void n_RemoveVideoTrack (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveVideoTrack ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='removeVideoTrack' and count(parameter)=0]"
		[Register ("removeVideoTrack", "()V", "GetRemoveVideoTrackHandler")]
		public virtual unsafe void RemoveVideoTrack ()
		{
			const string __id = "removeVideoTrack.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setContext_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetContext_Landroid_content_Context_Handler ()
		{
			if (cb_setContext_Landroid_content_Context_ == null)
				cb_setContext_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetContext_Landroid_content_Context_);
			return cb_setContext_Landroid_content_Context_;
		}

		static void n_SetContext_Landroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_context)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var context = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_context, JniHandleOwnership.DoNotTransfer);
			__this.SetContext (context);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='setContext' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("setContext", "(Landroid/content/Context;)V", "GetSetContext_Landroid_content_Context_Handler")]
		public virtual unsafe void SetContext (global::Android.Content.Context context)
		{
			const string __id = "setContext.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		static Delegate cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_;
#pragma warning disable 0169
		static Delegate GetSetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_Handler ()
		{
			if (cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ == null)
				cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_);
			return cb_setInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_;
		}

		static void n_SetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_cb)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cb = (global::Veg.Mediacapture.Sdk.IInternalDataCallback)global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (native_cb, JniHandleOwnership.DoNotTransfer);
			__this.SetInternalDataCallback (cb);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='setInternalDataCallback' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.InternalDataCallback']]"
		[Register ("setInternalDataCallback", "(Lveg/mediacapture/sdk/InternalDataCallback;)V", "GetSetInternalDataCallback_Lveg_mediacapture_sdk_InternalDataCallback_Handler")]
		public virtual unsafe void SetInternalDataCallback (global::Veg.Mediacapture.Sdk.IInternalDataCallback cb)
		{
			const string __id = "setInternalDataCallback.(Lveg/mediacapture/sdk/InternalDataCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((cb == null) ? IntPtr.Zero : ((global::Java.Lang.Object) cb).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (cb);
			}
		}

		static Delegate cb_setOrigin_Ljava_net_InetAddress_;
#pragma warning disable 0169
		static Delegate GetSetOrigin_Ljava_net_InetAddress_Handler ()
		{
			if (cb_setOrigin_Ljava_net_InetAddress_ == null)
				cb_setOrigin_Ljava_net_InetAddress_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOrigin_Ljava_net_InetAddress_);
			return cb_setOrigin_Ljava_net_InetAddress_;
		}

		static void n_SetOrigin_Ljava_net_InetAddress_ (IntPtr jnienv, IntPtr native__this, IntPtr native_origin)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var origin = global::Java.Lang.Object.GetObject<global::Java.Net.InetAddress> (native_origin, JniHandleOwnership.DoNotTransfer);
			__this.SetOrigin (origin);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='setOrigin' and count(parameter)=1 and parameter[1][@type='java.net.InetAddress']]"
		[Register ("setOrigin", "(Ljava/net/InetAddress;)V", "GetSetOrigin_Ljava_net_InetAddress_Handler")]
		public virtual unsafe void SetOrigin (global::Java.Net.InetAddress origin)
		{
			const string __id = "setOrigin.(Ljava/net/InetAddress;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((origin == null) ? IntPtr.Zero : ((global::Java.Lang.Object) origin).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (origin);
			}
		}

		static Delegate cb_setTimeToLive_I;
#pragma warning disable 0169
		static Delegate GetSetTimeToLive_IHandler ()
		{
			if (cb_setTimeToLive_I == null)
				cb_setTimeToLive_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTimeToLive_I);
			return cb_setTimeToLive_I;
		}

		static void n_SetTimeToLive_I (IntPtr jnienv, IntPtr native__this, int ttl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTimeToLive (ttl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='setTimeToLive' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTimeToLive", "(I)V", "GetSetTimeToLive_IHandler")]
		public virtual unsafe void SetTimeToLive (int ttl)
		{
			const string __id = "setTimeToLive.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (ttl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='start' and count(parameter)=0]"
		[Register ("start", "()V", "GetStartHandler")]
		public virtual unsafe void Start ()
		{
			const string __id = "start.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_start_I;
#pragma warning disable 0169
		static Delegate GetStart_IHandler ()
		{
			if (cb_start_I == null)
				cb_start_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Start_I);
			return cb_start_I;
		}

		static void n_Start_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Start (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='start' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("start", "(I)V", "GetStart_IHandler")]
		public virtual unsafe void Start (int id)
		{
			const string __id = "start.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='stop' and count(parameter)=0]"
		[Register ("stop", "()V", "GetStopHandler")]
		public virtual unsafe void Stop ()
		{
			const string __id = "stop.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_stop_I;
#pragma warning disable 0169
		static Delegate GetStop_IHandler ()
		{
			if (cb_stop_I == null)
				cb_stop_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Stop_I);
			return cb_stop_I;
		}

		static void n_Stop_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Stop (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='stop' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("stop", "(I)V", "GetStop_IHandler")]
		public virtual unsafe void Stop (int id)
		{
			const string __id = "stop.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_trackExists_I;
#pragma warning disable 0169
		static Delegate GetTrackExists_IHandler ()
		{
			if (cb_trackExists_I == null)
				cb_trackExists_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_TrackExists_I);
			return cb_trackExists_I;
		}

		static bool n_TrackExists_I (IntPtr jnienv, IntPtr native__this, int id)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Session> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TrackExists (id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk.streaming']/class[@name='Session']/method[@name='trackExists' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("trackExists", "(I)Z", "GetTrackExists_IHandler")]
		public virtual unsafe bool TrackExists (int id)
		{
			const string __id = "trackExists.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (id);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
