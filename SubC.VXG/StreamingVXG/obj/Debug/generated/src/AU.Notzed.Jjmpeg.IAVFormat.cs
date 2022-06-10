using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace AU.Notzed.Jjmpeg {

	[Register ("au/notzed/jjmpeg/AVFormat", DoNotGenerateAcw=true)]
	public abstract class AVFormat : Java.Lang.Object {
		internal AVFormat ()
		{
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_ALLOW_FLUSH']"
		[Register ("AVFMT_ALLOW_FLUSH")]
		public const int AvfmtAllowFlush = (int) 65536;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_GENERIC_INDEX']"
		[Register ("AVFMT_GENERIC_INDEX")]
		public const int AvfmtGenericIndex = (int) 256;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_GLOBALHEADER']"
		[Register ("AVFMT_GLOBALHEADER")]
		public const int AvfmtGlobalheader = (int) 64;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NEEDNUMBER']"
		[Register ("AVFMT_NEEDNUMBER")]
		public const int AvfmtNeednumber = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOBINSEARCH']"
		[Register ("AVFMT_NOBINSEARCH")]
		public const int AvfmtNobinsearch = (int) 8192;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NODIMENSIONS']"
		[Register ("AVFMT_NODIMENSIONS")]
		public const int AvfmtNodimensions = (int) 2048;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOFILE']"
		[Register ("AVFMT_NOFILE")]
		public const int AvfmtNofile = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOGENSEARCH']"
		[Register ("AVFMT_NOGENSEARCH")]
		public const int AvfmtNogensearch = (int) 16384;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOSTREAMS']"
		[Register ("AVFMT_NOSTREAMS")]
		public const int AvfmtNostreams = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NOTIMESTAMPS']"
		[Register ("AVFMT_NOTIMESTAMPS")]
		public const int AvfmtNotimestamps = (int) 128;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_NO_BYTE_SEEK']"
		[Register ("AVFMT_NO_BYTE_SEEK")]
		public const int AvfmtNoByteSeek = (int) 32768;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_RAWPICTURE']"
		[Register ("AVFMT_RAWPICTURE")]
		public const int AvfmtRawpicture = (int) 32;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_SHOW_IDS']"
		[Register ("AVFMT_SHOW_IDS")]
		public const int AvfmtShowIds = (int) 8;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_TS_DISCONT']"
		[Register ("AVFMT_TS_DISCONT")]
		public const int AvfmtTsDiscont = (int) 512;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_TS_NONSTRICT']"
		[Register ("AVFMT_TS_NONSTRICT")]
		public const int AvfmtTsNonstrict = (int) 134217728;

		// Metadata.xml XPath field reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']/field[@name='AVFMT_VARIABLE_FPS']"
		[Register ("AVFMT_VARIABLE_FPS")]
		public const int AvfmtVariableFps = (int) 1024;

	}

	[Register ("au/notzed/jjmpeg/AVFormat", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'AVFormat' type. This type will be removed in a future release.", error: true)]
	public abstract class AVFormatConsts : AVFormat {
		private AVFormatConsts ()
		{
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='au.notzed.jjmpeg']/interface[@name='AVFormat']"
	[Register ("au/notzed/jjmpeg/AVFormat", "", "AU.Notzed.Jjmpeg.IAVFormatInvoker")]
	public partial interface IAVFormat : IJavaObject, IJavaPeerable {
	}

	[global::Android.Runtime.Register ("au/notzed/jjmpeg/AVFormat", DoNotGenerateAcw=true)]
	internal partial class IAVFormatInvoker : global::Java.Lang.Object, IAVFormat {
		static readonly JniPeerMembers _members = new XAPeerMembers ("au/notzed/jjmpeg/AVFormat", typeof (IAVFormatInvoker));

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

		public static IAVFormat GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAVFormat> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'au.notzed.jjmpeg.AVFormat'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAVFormatInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

	}
}
