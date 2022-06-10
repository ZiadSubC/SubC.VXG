using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Veg.Mediacapture.Sdk {

	// Metadata.xml XPath interface reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']"
	[Register ("veg/mediacapture/sdk/InternalDataCallback", "", "Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker")]
	public partial interface IInternalDataCallback : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnCameraDied' and count(parameter)=0]"
		[Register ("OnCameraDied", "()V", "GetOnCameraDiedHandler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		void OnCameraDied ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnCameraSurfaceChanged' and count(parameter)=3 and parameter[1][@type='android.graphics.SurfaceTexture'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("OnCameraSurfaceChanged", "(Landroid/graphics/SurfaceTexture;II)V", "GetOnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_IIHandler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		void OnCameraSurfaceChanged (global::Android.Graphics.SurfaceTexture p0, int p1, int p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnCameraSurfaceReady' and count(parameter)=1 and parameter[1][@type='android.graphics.SurfaceTexture']]"
		[Register ("OnCameraSurfaceReady", "(Landroid/graphics/SurfaceTexture;)V", "GetOnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_Handler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		void OnCameraSurfaceReady (global::Android.Graphics.SurfaceTexture p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnMediaCodecFrame' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.nio.ByteBuffer'] and parameter[4][@type='android.media.MediaCodec.BufferInfo']]"
		[Register ("OnMediaCodecFrame", "(IILjava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V", "GetOnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		void OnMediaCodecFrame (int p0, int p1, global::Java.Nio.ByteBuffer p2, global::Android.Media.MediaCodec.BufferInfo p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnMediaFrameAudio' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.AudioPacket']]"
		[Register ("OnMediaFrameAudio", "(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)V", "GetOnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		void OnMediaFrameAudio (global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnMediaFrameVideo' and count(parameter)=1 and parameter[1][@type='veg.mediacapture.sdk.streaming.mp4.VideoFrame']]"
		[Register ("OnMediaFrameVideo", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V", "GetOnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		void OnMediaFrameVideo (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnRenderStateChanged' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("OnRenderStateChanged", "(I)V", "GetOnRenderStateChanged_IHandler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		void OnRenderStateChanged (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnRequestExternalCamera' and count(parameter)=0]"
		[Register ("OnRequestExternalCamera", "()Ljava/lang/Object;", "GetOnRequestExternalCameraHandler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		global::Java.Lang.Object OnRequestExternalCamera ();

		// Metadata.xml XPath method reference: path="/api/package[@name='veg.mediacapture.sdk']/interface[@name='InternalDataCallback']/method[@name='OnUpdateDuration' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='boolean']]"
		[Register ("OnUpdateDuration", "(JZ)V", "GetOnUpdateDuration_JZHandler:Veg.Mediacapture.Sdk.IInternalDataCallbackInvoker, StreamingVXG")]
		void OnUpdateDuration (long p0, bool p1);

	}

	[global::Android.Runtime.Register ("veg/mediacapture/sdk/InternalDataCallback", DoNotGenerateAcw=true)]
	internal partial class IInternalDataCallbackInvoker : global::Java.Lang.Object, IInternalDataCallback {
		static readonly JniPeerMembers _members = new XAPeerMembers ("veg/mediacapture/sdk/InternalDataCallback", typeof (IInternalDataCallbackInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IInternalDataCallback GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IInternalDataCallback> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'veg.mediacapture.sdk.InternalDataCallback'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IInternalDataCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraDied ();
		}
#pragma warning restore 0169

		IntPtr id_OnCameraDied;
		public unsafe void OnCameraDied ()
		{
			if (id_OnCameraDied == IntPtr.Zero)
				id_OnCameraDied = JNIEnv.GetMethodID (class_ref, "OnCameraDied", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCameraDied);
		}

		static Delegate cb_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II;
#pragma warning disable 0169
		static Delegate GetOnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_IIHandler ()
		{
			if (cb_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II == null)
				cb_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLII_V) n_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II);
			return cb_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II;
		}

		static void n_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraSurfaceChanged (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II;
		public unsafe void OnCameraSurfaceChanged (global::Android.Graphics.SurfaceTexture p0, int p1, int p2)
		{
			if (id_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II == IntPtr.Zero)
				id_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II = JNIEnv.GetMethodID (class_ref, "OnCameraSurfaceChanged", "(Landroid/graphics/SurfaceTexture;II)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCameraSurfaceChanged_Landroid_graphics_SurfaceTexture_II, __args);
		}

		static Delegate cb_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_;
#pragma warning disable 0169
		static Delegate GetOnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_Handler ()
		{
			if (cb_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_ == null)
				cb_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_);
			return cb_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_;
		}

		static void n_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.SurfaceTexture> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCameraSurfaceReady (p0);
		}
#pragma warning restore 0169

		IntPtr id_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_;
		public unsafe void OnCameraSurfaceReady (global::Android.Graphics.SurfaceTexture p0)
		{
			if (id_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_ == IntPtr.Zero)
				id_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_ = JNIEnv.GetMethodID (class_ref, "OnCameraSurfaceReady", "(Landroid/graphics/SurfaceTexture;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnCameraSurfaceReady_Landroid_graphics_SurfaceTexture_, __args);
		}

		static Delegate cb_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
#pragma warning disable 0169
		static Delegate GetOnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_Handler ()
		{
			if (cb_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == null)
				cb_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIILL_V) n_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_);
			return cb_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		}

		static void n_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2, IntPtr native_p3)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p2 = global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (native_p2, JniHandleOwnership.DoNotTransfer);
			var p3 = global::Java.Lang.Object.GetObject<global::Android.Media.MediaCodec.BufferInfo> (native_p3, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaCodecFrame (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_;
		public unsafe void OnMediaCodecFrame (int p0, int p1, global::Java.Nio.ByteBuffer p2, global::Android.Media.MediaCodec.BufferInfo p3)
		{
			if (id_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ == IntPtr.Zero)
				id_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_ = JNIEnv.GetMethodID (class_ref, "OnMediaCodecFrame", "(IILjava/nio/ByteBuffer;Landroid/media/MediaCodec$BufferInfo;)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaCodecFrame_IILjava_nio_ByteBuffer_Landroid_media_MediaCodec_BufferInfo_, __args);
		}

		static Delegate cb_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
#pragma warning disable 0169
		static Delegate GetOnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_Handler ()
		{
			if (cb_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ == null)
				cb_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_);
			return cb_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
		}

		static void n_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaFrameAudio (p0);
		}
#pragma warning restore 0169

		IntPtr id_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_;
		public unsafe void OnMediaFrameAudio (global::Veg.Mediacapture.Sdk.Streaming.Mp4.AudioPacket p0)
		{
			if (id_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ == IntPtr.Zero)
				id_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_ = JNIEnv.GetMethodID (class_ref, "OnMediaFrameAudio", "(Lveg/mediacapture/sdk/streaming/mp4/AudioPacket;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaFrameAudio_Lveg_mediacapture_sdk_streaming_mp4_AudioPacket_, __args);
		}

		static Delegate cb_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
#pragma warning disable 0169
		static Delegate GetOnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_Handler ()
		{
			if (cb_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ == null)
				cb_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_);
			return cb_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
		}

		static void n_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnMediaFrameVideo (p0);
		}
#pragma warning restore 0169

		IntPtr id_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_;
		public unsafe void OnMediaFrameVideo (global::Veg.Mediacapture.Sdk.Streaming.Mp4.VideoFrame p0)
		{
			if (id_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ == IntPtr.Zero)
				id_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_ = JNIEnv.GetMethodID (class_ref, "OnMediaFrameVideo", "(Lveg/mediacapture/sdk/streaming/mp4/VideoFrame;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnMediaFrameVideo_Lveg_mediacapture_sdk_streaming_mp4_VideoFrame_, __args);
		}

		static Delegate cb_OnRenderStateChanged_I;
#pragma warning disable 0169
		static Delegate GetOnRenderStateChanged_IHandler ()
		{
			if (cb_OnRenderStateChanged_I == null)
				cb_OnRenderStateChanged_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_OnRenderStateChanged_I);
			return cb_OnRenderStateChanged_I;
		}

		static void n_OnRenderStateChanged_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnRenderStateChanged (p0);
		}
#pragma warning restore 0169

		IntPtr id_OnRenderStateChanged_I;
		public unsafe void OnRenderStateChanged (int p0)
		{
			if (id_OnRenderStateChanged_I == IntPtr.Zero)
				id_OnRenderStateChanged_I = JNIEnv.GetMethodID (class_ref, "OnRenderStateChanged", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnRenderStateChanged_I, __args);
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
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnRequestExternalCamera ());
		}
#pragma warning restore 0169

		IntPtr id_OnRequestExternalCamera;
		public unsafe global::Java.Lang.Object OnRequestExternalCamera ()
		{
			if (id_OnRequestExternalCamera == IntPtr.Zero)
				id_OnRequestExternalCamera = JNIEnv.GetMethodID (class_ref, "OnRequestExternalCamera", "()Ljava/lang/Object;");
			return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_OnRequestExternalCamera), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_OnUpdateDuration_JZ;
#pragma warning disable 0169
		static Delegate GetOnUpdateDuration_JZHandler ()
		{
			if (cb_OnUpdateDuration_JZ == null)
				cb_OnUpdateDuration_JZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPJZ_V) n_OnUpdateDuration_JZ);
			return cb_OnUpdateDuration_JZ;
		}

		static void n_OnUpdateDuration_JZ (IntPtr jnienv, IntPtr native__this, long p0, bool p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Veg.Mediacapture.Sdk.IInternalDataCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnUpdateDuration (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_OnUpdateDuration_JZ;
		public unsafe void OnUpdateDuration (long p0, bool p1)
		{
			if (id_OnUpdateDuration_JZ == IntPtr.Zero)
				id_OnUpdateDuration_JZ = JNIEnv.GetMethodID (class_ref, "OnUpdateDuration", "(JZ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_OnUpdateDuration_JZ, __args);
		}

	}
}
