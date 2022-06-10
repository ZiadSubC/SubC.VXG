using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	// Metadata.xml XPath class reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']"
	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVMediaType", DoNotGenerateAcw=true)]
	public sealed partial class AVMediaType : global::Java.Lang.Enum {

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/field[@name='AVMEDIA_TYPE_ATTACHMENT']"
		[Register ("AVMEDIA_TYPE_ATTACHMENT")]
		public static global::AU.Notzed.Jjmpeg.AVMediaType AvmediaTypeAttachment {
			get {
				const string __id = "AVMEDIA_TYPE_ATTACHMENT.Lau/notzed/jjmpeg/AVMediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/field[@name='AVMEDIA_TYPE_AUDIO']"
		[Register ("AVMEDIA_TYPE_AUDIO")]
		public static global::AU.Notzed.Jjmpeg.AVMediaType AvmediaTypeAudio {
			get {
				const string __id = "AVMEDIA_TYPE_AUDIO.Lau/notzed/jjmpeg/AVMediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/field[@name='AVMEDIA_TYPE_DATA']"
		[Register ("AVMEDIA_TYPE_DATA")]
		public static global::AU.Notzed.Jjmpeg.AVMediaType AvmediaTypeData {
			get {
				const string __id = "AVMEDIA_TYPE_DATA.Lau/notzed/jjmpeg/AVMediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/field[@name='AVMEDIA_TYPE_NB']"
		[Register ("AVMEDIA_TYPE_NB")]
		public static global::AU.Notzed.Jjmpeg.AVMediaType AvmediaTypeNb {
			get {
				const string __id = "AVMEDIA_TYPE_NB.Lau/notzed/jjmpeg/AVMediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/field[@name='AVMEDIA_TYPE_SUBTITLE']"
		[Register ("AVMEDIA_TYPE_SUBTITLE")]
		public static global::AU.Notzed.Jjmpeg.AVMediaType AvmediaTypeSubtitle {
			get {
				const string __id = "AVMEDIA_TYPE_SUBTITLE.Lau/notzed/jjmpeg/AVMediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/field[@name='AVMEDIA_TYPE_UNKNOWN']"
		[Register ("AVMEDIA_TYPE_UNKNOWN")]
		public static global::AU.Notzed.Jjmpeg.AVMediaType AvmediaTypeUnknown {
			get {
				const string __id = "AVMEDIA_TYPE_UNKNOWN.Lau/notzed/jjmpeg/AVMediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/field[@name='AVMEDIA_TYPE_VIDEO']"
		[Register ("AVMEDIA_TYPE_VIDEO")]
		public static global::AU.Notzed.Jjmpeg.AVMediaType AvmediaTypeVideo {
			get {
				const string __id = "AVMEDIA_TYPE_VIDEO.Lau/notzed/jjmpeg/AVMediaType;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVMediaType", typeof (AVMediaType));

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

		internal AVMediaType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/method[@name='fromC' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromC", "(I)Lau/notzed/jjmpeg/AVMediaType;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVMediaType FromC (int i)
		{
			const string __id = "fromC.(I)Lau/notzed/jjmpeg/AVMediaType;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/method[@name='toC' and count(parameter)=0]"
		[Register ("toC", "()I", "")]
		public unsafe int ToC ()
		{
			const string __id = "toC.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lau/notzed/jjmpeg/AVMediaType;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVMediaType ValueOf (string name)
		{
			const string __id = "valueOf.(Ljava/lang/String;)Lau/notzed/jjmpeg/AVMediaType;";
			IntPtr native_name = JNIEnv.NewString (name);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_name);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::AU.Notzed.Jjmpeg.AVMediaType> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_name);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='au.notzed.jjmpeg']/class[@name='AVMediaType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lau/notzed/jjmpeg/AVMediaType;", "")]
		public static unsafe global::AU.Notzed.Jjmpeg.AVMediaType[] Values ()
		{
			const string __id = "values.()[Lau/notzed/jjmpeg/AVMediaType;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return (global::AU.Notzed.Jjmpeg.AVMediaType[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::AU.Notzed.Jjmpeg.AVMediaType));
			} finally {
			}
		}

	}
}
