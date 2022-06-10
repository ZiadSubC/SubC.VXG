using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVFormatContext", DoNotGenerateAcw=true)]
	public partial class AVFormatContext : global::AU.Notzed.Jjmpeg.AVObject {
		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/field[@name='AVSEEK_FLAG_ANY']"
		[Register ("AVSEEK_FLAG_ANY")]
		public const int AvseekFlagAny = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/field[@name='AVSEEK_FLAG_BACKWARD']"
		[Register ("AVSEEK_FLAG_BACKWARD")]
		public const int AvseekFlagBackward = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/field[@name='AVSEEK_FLAG_BYTE']"
		[Register ("AVSEEK_FLAG_BYTE")]
		public const int AvseekFlagByte = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/field[@name='AVSEEK_FLAG_FRAME']"
		[Register ("AVSEEK_FLAG_FRAME")]
		public const int AvseekFlagFrame = (int) 8;

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVFormatContext", typeof (AVFormatContext));

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

		protected AVFormatContext (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BitRate;
		}
#pragma warning restore 0169

		public virtual unsafe int BitRate {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getBitRate' and count(parameter)=0]"
			[Register ("getBitRate", "()I", "GetGetBitRateHandler")]
			get {
				const string __id = "getBitRate.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Duration;
		}
#pragma warning restore 0169

		public virtual unsafe long Duration {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getDuration' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Flags = p0;
		}
#pragma warning restore 0169

		public virtual unsafe int Flags {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getFlags' and count(parameter)=0]"
			[Register ("getFlags", "()I", "GetGetFlagsHandler")]
			get {
				const string __id = "getFlags.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='setFlags' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getIOContext;
#pragma warning disable 0169
		static Delegate GetGetIOContextHandler ()
		{
			if (cb_getIOContext == null)
				cb_getIOContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetIOContext);
			return cb_getIOContext;
		}

		static IntPtr n_GetIOContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IOContext);
		}
#pragma warning restore 0169

		static Delegate cb_setIOContext_Lau_notzed_jjmpeg_AVIOContext_;
#pragma warning disable 0169
		static Delegate GetSetIOContext_Lau_notzed_jjmpeg_AVIOContext_Handler ()
		{
			if (cb_setIOContext_Lau_notzed_jjmpeg_AVIOContext_ == null)
				cb_setIOContext_Lau_notzed_jjmpeg_AVIOContext_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetIOContext_Lau_notzed_jjmpeg_AVIOContext_);
			return cb_setIOContext_Lau_notzed_jjmpeg_AVIOContext_;
		}

		static void n_SetIOContext_Lau_notzed_jjmpeg_AVIOContext_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IOContext = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.AVIOContext IOContext {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getIOContext' and count(parameter)=0]"
			[Register ("getIOContext", "()Lau/notzed/jjmpeg/AVIOContext;", "GetGetIOContextHandler")]
			get {
				const string __id = "getIOContext.()Lau/notzed/jjmpeg/AVIOContext;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVIOContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='setIOContext' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVIOContext']]"
			[Register ("setIOContext", "(Lau/notzed/jjmpeg/AVIOContext;)V", "GetSetIOContext_Lau_notzed_jjmpeg_AVIOContext_Handler")]
			set {
				const string __id = "setIOContext.(Lau/notzed/jjmpeg/AVIOContext;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getInputFormat;
#pragma warning disable 0169
		static Delegate GetGetInputFormatHandler ()
		{
			if (cb_getInputFormat == null)
				cb_getInputFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetInputFormat);
			return cb_getInputFormat;
		}

		static IntPtr n_GetInputFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.InputFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setInputFormat_Lau_notzed_jjmpeg_AVInputFormat_;
#pragma warning disable 0169
		static Delegate GetSetInputFormat_Lau_notzed_jjmpeg_AVInputFormat_Handler ()
		{
			if (cb_setInputFormat_Lau_notzed_jjmpeg_AVInputFormat_ == null)
				cb_setInputFormat_Lau_notzed_jjmpeg_AVInputFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetInputFormat_Lau_notzed_jjmpeg_AVInputFormat_);
			return cb_setInputFormat_Lau_notzed_jjmpeg_AVInputFormat_;
		}

		static void n_SetInputFormat_Lau_notzed_jjmpeg_AVInputFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVInputFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.InputFormat = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.AVInputFormat InputFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getInputFormat' and count(parameter)=0]"
			[Register ("getInputFormat", "()Lau/notzed/jjmpeg/AVInputFormat;", "GetGetInputFormatHandler")]
			get {
				const string __id = "getInputFormat.()Lau/notzed/jjmpeg/AVInputFormat;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVInputFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='setInputFormat' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVInputFormat']]"
			[Register ("setInputFormat", "(Lau/notzed/jjmpeg/AVInputFormat;)V", "GetSetInputFormat_Lau_notzed_jjmpeg_AVInputFormat_Handler")]
			set {
				const string __id = "setInputFormat.(Lau/notzed/jjmpeg/AVInputFormat;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getNBStreams;
#pragma warning disable 0169
		static Delegate GetGetNBStreamsHandler ()
		{
			if (cb_getNBStreams == null)
				cb_getNBStreams = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetNBStreams);
			return cb_getNBStreams;
		}

		static int n_GetNBStreams (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NBStreams;
		}
#pragma warning restore 0169

		public virtual unsafe int NBStreams {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getNBStreams' and count(parameter)=0]"
			[Register ("getNBStreams", "()I", "GetGetNBStreamsHandler")]
			get {
				const string __id = "getNBStreams.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOutputFormat;
#pragma warning disable 0169
		static Delegate GetGetOutputFormatHandler ()
		{
			if (cb_getOutputFormat == null)
				cb_getOutputFormat = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetOutputFormat);
			return cb_getOutputFormat;
		}

		static IntPtr n_GetOutputFormat (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OutputFormat);
		}
#pragma warning restore 0169

		static Delegate cb_setOutputFormat_Lau_notzed_jjmpeg_AVOutputFormat_;
#pragma warning disable 0169
		static Delegate GetSetOutputFormat_Lau_notzed_jjmpeg_AVOutputFormat_Handler ()
		{
			if (cb_setOutputFormat_Lau_notzed_jjmpeg_AVOutputFormat_ == null)
				cb_setOutputFormat_Lau_notzed_jjmpeg_AVOutputFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetOutputFormat_Lau_notzed_jjmpeg_AVOutputFormat_);
			return cb_setOutputFormat_Lau_notzed_jjmpeg_AVOutputFormat_;
		}

		static void n_SetOutputFormat_Lau_notzed_jjmpeg_AVOutputFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OutputFormat = p0;
		}
#pragma warning restore 0169

		public virtual unsafe global::AU.Notzed.Jjmpeg.AVOutputFormat OutputFormat {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getOutputFormat' and count(parameter)=0]"
			[Register ("getOutputFormat", "()Lau/notzed/jjmpeg/AVOutputFormat;", "GetGetOutputFormatHandler")]
			get {
				const string __id = "getOutputFormat.()Lau/notzed/jjmpeg/AVOutputFormat;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVOutputFormat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='setOutputFormat' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVOutputFormat']]"
			[Register ("setOutputFormat", "(Lau/notzed/jjmpeg/AVOutputFormat;)V", "GetSetOutputFormat_Lau_notzed_jjmpeg_AVOutputFormat_Handler")]
			set {
				const string __id = "setOutputFormat.(Lau/notzed/jjmpeg/AVOutputFormat;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getStartTime;
#pragma warning disable 0169
		static Delegate GetGetStartTimeHandler ()
		{
			if (cb_getStartTime == null)
				cb_getStartTime = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_J) n_GetStartTime);
			return cb_getStartTime;
		}

		static long n_GetStartTime (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartTime;
		}
#pragma warning restore 0169

		public virtual unsafe long StartTime {
			// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getStartTime' and count(parameter)=0]"
			[Register ("getStartTime", "()J", "GetGetStartTimeHandler")]
			get {
				const string __id = "getStartTime.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_closeInput;
#pragma warning disable 0169
		static Delegate GetCloseInputHandler ()
		{
			if (cb_closeInput == null)
				cb_closeInput = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CloseInput);
			return cb_closeInput;
		}

		static void n_CloseInput (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CloseInput ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='closeInput' and count(parameter)=0]"
		[Register ("closeInput", "()V", "GetCloseInputHandler")]
		public virtual unsafe void CloseInput ()
		{
			const string __id = "closeInput.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Dispose ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='dispose' and count(parameter)=0]"
		[Register ("dispose", "()V", "GetDisposeHandler")]
		public override unsafe void Dispose ()
		{
			const string __id = "dispose.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_findStreamInfo;
#pragma warning disable 0169
		static Delegate GetFindStreamInfoHandler ()
		{
			if (cb_findStreamInfo == null)
				cb_findStreamInfo = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FindStreamInfo);
			return cb_findStreamInfo;
		}

		static void n_FindStreamInfo (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FindStreamInfo ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='findStreamInfo' and count(parameter)=0]"
		[Register ("findStreamInfo", "()V", "GetFindStreamInfoHandler")]
		public virtual unsafe void FindStreamInfo ()
		{
			const string __id = "findStreamInfo.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_findStreamInfo_arrayLau_notzed_jjmpeg_AVDictionary_;
#pragma warning disable 0169
		static Delegate GetFindStreamInfo_arrayLau_notzed_jjmpeg_AVDictionary_Handler ()
		{
			if (cb_findStreamInfo_arrayLau_notzed_jjmpeg_AVDictionary_ == null)
				cb_findStreamInfo_arrayLau_notzed_jjmpeg_AVDictionary_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_FindStreamInfo_arrayLau_notzed_jjmpeg_AVDictionary_);
			return cb_findStreamInfo_arrayLau_notzed_jjmpeg_AVDictionary_;
		}

		static void n_FindStreamInfo_arrayLau_notzed_jjmpeg_AVDictionary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_options)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var options = (global::AU.Notzed.Jjmpeg.AVDictionary[]) JNIEnv.GetArray (native_options, JniHandleOwnership.DoNotTransfer, typeof (global::AU.Notzed.Jjmpeg.AVDictionary));
			__this.FindStreamInfo (options);
			if (options != null)
				JNIEnv.CopyArray (options, native_options);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='findStreamInfo' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVDictionary[]']]"
		[Register ("findStreamInfo", "([Lau/notzed/jjmpeg/AVDictionary;)V", "GetFindStreamInfo_arrayLau_notzed_jjmpeg_AVDictionary_Handler")]
		public virtual unsafe void FindStreamInfo (global::AU.Notzed.Jjmpeg.AVDictionary[] options)
		{
			const string __id = "findStreamInfo.([Lau/notzed/jjmpeg/AVDictionary;)V";
			IntPtr native_options = JNIEnv.NewArray (options);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_options);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (options != null) {
					JNIEnv.CopyArray (native_options, options);
					JNIEnv.DeleteLocalRef (native_options);
				}
				global::System.GC.KeepAlive (options);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRTSPBitRate (channel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getRTSPBitRate' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRTSPClients (channel));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getRTSPClients' and count(parameter)=1 and parameter[1][@type='int']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetRTSPFps (channel);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getRTSPFps' and count(parameter)=1 and parameter[1][@type='int']]"
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

		static Delegate cb_getStreamAt_I;
#pragma warning disable 0169
		static Delegate GetGetStreamAt_IHandler ()
		{
			if (cb_getStreamAt_I == null)
				cb_getStreamAt_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetStreamAt_I);
			return cb_getStreamAt_I;
		}

		static IntPtr n_GetStreamAt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetStreamAt (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='getStreamAt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getStreamAt", "(I)Lau/notzed/jjmpeg/AVStream;", "GetGetStreamAt_IHandler")]
		public virtual unsafe global::AU.Notzed.Jjmpeg.AVStream GetStreamAt (int p0)
		{
			const string __id = "getStreamAt.(I)Lau/notzed/jjmpeg/AVStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_interleavedWriteFrame_Lau_notzed_jjmpeg_AVPacket_;
#pragma warning disable 0169
		static Delegate GetInterleavedWriteFrame_Lau_notzed_jjmpeg_AVPacket_Handler ()
		{
			if (cb_interleavedWriteFrame_Lau_notzed_jjmpeg_AVPacket_ == null)
				cb_interleavedWriteFrame_Lau_notzed_jjmpeg_AVPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_InterleavedWriteFrame_Lau_notzed_jjmpeg_AVPacket_);
			return cb_interleavedWriteFrame_Lau_notzed_jjmpeg_AVPacket_;
		}

		static int n_InterleavedWriteFrame_Lau_notzed_jjmpeg_AVPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pkt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pkt = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (native_pkt, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.InterleavedWriteFrame (pkt);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='interleavedWriteFrame' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVPacket']]"
		[Register ("interleavedWriteFrame", "(Lau/notzed/jjmpeg/AVPacket;)I", "GetInterleavedWriteFrame_Lau_notzed_jjmpeg_AVPacket_Handler")]
		public virtual unsafe int InterleavedWriteFrame (global::AU.Notzed.Jjmpeg.AVPacket pkt)
		{
			const string __id = "interleavedWriteFrame.(Lau/notzed/jjmpeg/AVPacket;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pkt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pkt).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (pkt);
			}
		}

		static Delegate cb_newStream_Lau_notzed_jjmpeg_AVCodec_;
#pragma warning disable 0169
		static Delegate GetNewStream_Lau_notzed_jjmpeg_AVCodec_Handler ()
		{
			if (cb_newStream_Lau_notzed_jjmpeg_AVCodec_ == null)
				cb_newStream_Lau_notzed_jjmpeg_AVCodec_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_NewStream_Lau_notzed_jjmpeg_AVCodec_);
			return cb_newStream_Lau_notzed_jjmpeg_AVCodec_;
		}

		static IntPtr n_NewStream_Lau_notzed_jjmpeg_AVCodec_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVCodec> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.NewStream (p0));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='newStream' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVCodec']]"
		[Register ("newStream", "(Lau/notzed/jjmpeg/AVCodec;)Lau/notzed/jjmpeg/AVStream;", "GetNewStream_Lau_notzed_jjmpeg_AVCodec_Handler")]
		public virtual unsafe global::AU.Notzed.Jjmpeg.AVStream NewStream (global::AU.Notzed.Jjmpeg.AVCodec p0)
		{
			const string __id = "newStream.(Lau/notzed/jjmpeg/AVCodec;)Lau/notzed/jjmpeg/AVStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='open' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("open", "(Ljava/lang/String;)Lau/notzed/jjmpeg/AVFormatContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVFormatContext Open (string name)
		{
			const string __id = "open.(Ljava/lang/String;)Lau/notzed/jjmpeg/AVFormatContext;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		static Delegate cb_openInput_Ljava_lang_String_Lau_notzed_jjmpeg_AVInputFormat_;
#pragma warning disable 0169
		static Delegate GetOpenInput_Ljava_lang_String_Lau_notzed_jjmpeg_AVInputFormat_Handler ()
		{
			if (cb_openInput_Ljava_lang_String_Lau_notzed_jjmpeg_AVInputFormat_ == null)
				cb_openInput_Ljava_lang_String_Lau_notzed_jjmpeg_AVInputFormat_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OpenInput_Ljava_lang_String_Lau_notzed_jjmpeg_AVInputFormat_);
			return cb_openInput_Ljava_lang_String_Lau_notzed_jjmpeg_AVInputFormat_;
		}

		static void n_OpenInput_Ljava_lang_String_Lau_notzed_jjmpeg_AVInputFormat_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_fmt)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var name = JNIEnv.GetString (native_name, JniHandleOwnership.DoNotTransfer);
			var fmt = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVInputFormat> (native_fmt, JniHandleOwnership.DoNotTransfer);
			__this.OpenInput (name, fmt);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='openInput' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='au.notzed.jjmpeg.AVInputFormat']]"
		[Register ("openInput", "(Ljava/lang/String;Lau/notzed/jjmpeg/AVInputFormat;)V", "GetOpenInput_Ljava_lang_String_Lau_notzed_jjmpeg_AVInputFormat_Handler")]
		public virtual unsafe void OpenInput (string name, global::AU.Notzed.Jjmpeg.AVInputFormat fmt)
		{
			const string __id = "openInput.(Ljava/lang/String;Lau/notzed/jjmpeg/AVInputFormat;)V";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_name);
				__args [1] = new JniArgumentValue ((fmt == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fmt).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
				global::System.GC.KeepAlive (fmt);
			}
		}

		static Delegate cb_readFrame_Lau_notzed_jjmpeg_AVPacket_;
#pragma warning disable 0169
		static Delegate GetReadFrame_Lau_notzed_jjmpeg_AVPacket_Handler ()
		{
			if (cb_readFrame_Lau_notzed_jjmpeg_AVPacket_ == null)
				cb_readFrame_Lau_notzed_jjmpeg_AVPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_ReadFrame_Lau_notzed_jjmpeg_AVPacket_);
			return cb_readFrame_Lau_notzed_jjmpeg_AVPacket_;
		}

		static int n_ReadFrame_Lau_notzed_jjmpeg_AVPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_packet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var packet = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (native_packet, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.ReadFrame (packet);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='readFrame' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVPacket']]"
		[Register ("readFrame", "(Lau/notzed/jjmpeg/AVPacket;)I", "GetReadFrame_Lau_notzed_jjmpeg_AVPacket_Handler")]
		public virtual unsafe int ReadFrame (global::AU.Notzed.Jjmpeg.AVPacket packet)
		{
			const string __id = "readFrame.(Lau/notzed/jjmpeg/AVPacket;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((packet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) packet).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (packet);
			}
		}

		static Delegate cb_seekFile_IJJJI;
#pragma warning disable 0169
		static Delegate GetSeekFile_IJJJIHandler ()
		{
			if (cb_seekFile_IJJJI == null)
				cb_seekFile_IJJJI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJJJI_I) n_SeekFile_IJJJI);
			return cb_seekFile_IJJJI;
		}

		static int n_SeekFile_IJJJI (IntPtr jnienv, IntPtr native__this, int p0, long p1, long p2, long p3, int p4)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeekFile (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='seekFile' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='long'] and parameter[4][@type='long'] and parameter[5][@type='int']]"
		[Register ("seekFile", "(IJJJI)I", "GetSeekFile_IJJJIHandler")]
		public virtual unsafe int SeekFile (int p0, long p1, long p2, long p3, int p4)
		{
			const string __id = "seekFile.(IJJJI)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				__args [3] = new JniArgumentValue (p3);
				__args [4] = new JniArgumentValue (p4);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_seekFrame_IJI;
#pragma warning disable 0169
		static Delegate GetSeekFrame_IJIHandler ()
		{
			if (cb_seekFrame_IJI == null)
				cb_seekFrame_IJI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIJI_I) n_SeekFrame_IJI);
			return cb_seekFrame_IJI;
		}

		static int n_SeekFrame_IJI (IntPtr jnienv, IntPtr native__this, int p0, long p1, int p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SeekFrame (p0, p1, p2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='seekFrame' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='long'] and parameter[3][@type='int']]"
		[Register ("seekFrame", "(IJI)I", "GetSeekFrame_IJIHandler")]
		public virtual unsafe int SeekFrame (int p0, long p1, int p2)
		{
			const string __id = "seekFrame.(IJI)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
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

		static void n_SetMulticast_ZLjava_lang_String_I (IntPtr jnienv, IntPtr native__this, bool enabled, IntPtr native_ipaddr, int ttl)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var ipaddr = JNIEnv.GetString (native_ipaddr, JniHandleOwnership.DoNotTransfer);
			__this.SetMulticast (enabled, ipaddr, ttl);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='setMulticast' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register ("setMulticast", "(ZLjava/lang/String;I)V", "GetSetMulticast_ZLjava_lang_String_IHandler")]
		public virtual unsafe void SetMulticast (bool enabled, string ipaddr, int ttl)
		{
			const string __id = "setMulticast.(ZLjava/lang/String;I)V";
			IntPtr native_ipaddr = JNIEnv.NewString (ipaddr);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (enabled);
				__args [1] = new JniArgumentValue (native_ipaddr);
				__args [2] = new JniArgumentValue (ttl);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_ipaddr);
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
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var cert = JNIEnv.GetString (native_cert, JniHandleOwnership.DoNotTransfer);
			var key = JNIEnv.GetString (native_key, JniHandleOwnership.DoNotTransfer);
			__this.SetSecureStreaming (enabled, cert, key);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='setSecureStreaming' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
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

		static Delegate cb_writeFrame_Lau_notzed_jjmpeg_AVPacket_;
#pragma warning disable 0169
		static Delegate GetWriteFrame_Lau_notzed_jjmpeg_AVPacket_Handler ()
		{
			if (cb_writeFrame_Lau_notzed_jjmpeg_AVPacket_ == null)
				cb_writeFrame_Lau_notzed_jjmpeg_AVPacket_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_WriteFrame_Lau_notzed_jjmpeg_AVPacket_);
			return cb_writeFrame_Lau_notzed_jjmpeg_AVPacket_;
		}

		static int n_WriteFrame_Lau_notzed_jjmpeg_AVPacket_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVPacket> (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.WriteFrame (p0);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='writeFrame' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVPacket']]"
		[Register ("writeFrame", "(Lau/notzed/jjmpeg/AVPacket;)I", "GetWriteFrame_Lau_notzed_jjmpeg_AVPacket_Handler")]
		public virtual unsafe int WriteFrame (global::AU.Notzed.Jjmpeg.AVPacket p0)
		{
			const string __id = "writeFrame.(Lau/notzed/jjmpeg/AVPacket;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p0);
			}
		}

		static Delegate cb_writeHeader_Lau_notzed_jjmpeg_AVDictionary_;
#pragma warning disable 0169
		static Delegate GetWriteHeader_Lau_notzed_jjmpeg_AVDictionary_Handler ()
		{
			if (cb_writeHeader_Lau_notzed_jjmpeg_AVDictionary_ == null)
				cb_writeHeader_Lau_notzed_jjmpeg_AVDictionary_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_WriteHeader_Lau_notzed_jjmpeg_AVDictionary_);
			return cb_writeHeader_Lau_notzed_jjmpeg_AVDictionary_;
		}

		static void n_WriteHeader_Lau_notzed_jjmpeg_AVDictionary_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dict)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dict = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVDictionary> (native_dict, JniHandleOwnership.DoNotTransfer);
			__this.WriteHeader (dict);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='writeHeader' and count(parameter)=1 and parameter[1][@type='au.notzed.jjmpeg.AVDictionary']]"
		[Register ("writeHeader", "(Lau/notzed/jjmpeg/AVDictionary;)V", "GetWriteHeader_Lau_notzed_jjmpeg_AVDictionary_Handler")]
		public virtual unsafe void WriteHeader (global::AU.Notzed.Jjmpeg.AVDictionary dict)
		{
			const string __id = "writeHeader.(Lau/notzed/jjmpeg/AVDictionary;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dict == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dict).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dict);
			}
		}

		static Delegate cb_writeTrailer;
#pragma warning disable 0169
		static Delegate GetWriteTrailerHandler ()
		{
			if (cb_writeTrailer == null)
				cb_writeTrailer = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_WriteTrailer);
			return cb_writeTrailer;
		}

		static int n_WriteTrailer (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WriteTrailer ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContext']/method[@name='writeTrailer' and count(parameter)=0]"
		[Register ("writeTrailer", "()I", "GetWriteTrailerHandler")]
		public virtual unsafe int WriteTrailer ()
		{
			const string __id = "writeTrailer.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContextAbstract']/method[@name='allocContext' and count(parameter)=0]"
		[Register ("allocContext", "()Lau/notzed/jjmpeg/AVFormatContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVFormatContext AllocContext ()
		{
			const string __id = "allocContext.()Lau/notzed/jjmpeg/AVFormatContext;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContextAbstract']/method[@name='allocContext2' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("allocContext2", "(Ljava/lang/String;Ljava/lang/String;)Lau/notzed/jjmpeg/AVFormatContext;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVFormatContext AllocContext2 (string format, string filename)
		{
			const string __id = "allocContext2.(Ljava/lang/String;Ljava/lang/String;)Lau/notzed/jjmpeg/AVFormatContext;";
			IntPtr native_format = JNIEnv.NewString (format);
			IntPtr native_filename = JNIEnv.NewString (filename);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_format);
				__args [1] = new JniArgumentValue (native_filename);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_format);
				JNIEnv.DeleteLocalRef (native_filename);
			}
		}

		static Delegate cb_freeContext;
#pragma warning disable 0169
		static Delegate GetFreeContextHandler ()
		{
			if (cb_freeContext == null)
				cb_freeContext = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_FreeContext);
			return cb_freeContext;
		}

		static void n_FreeContext (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVFormatContext> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FreeContext ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContextAbstract']/method[@name='freeContext' and count(parameter)=0]"
		[Register ("freeContext", "()V", "GetFreeContextHandler")]
		protected virtual unsafe void FreeContext ()
		{
			const string __id = "freeContext.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContextAbstract']/method[@name='networkInit' and count(parameter)=0]"
		[Register ("networkInit", "()I", "")]
		public static unsafe int NetworkInit ()
		{
			const string __id = "networkInit.()I";
			try {
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVFormatContextAbstract']/method[@name='registerAll' and count(parameter)=0]"
		[Register ("registerAll", "()V", "")]
		public static unsafe void RegisterAll ()
		{
			const string __id = "registerAll.()V";
			try {
				_members.StaticMethods.InvokeVoidMethod (__id, null);
			} finally {
			}
		}

	}
}
