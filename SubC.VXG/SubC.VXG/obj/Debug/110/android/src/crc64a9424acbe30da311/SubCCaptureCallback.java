package crc64a9424acbe30da311;


public class SubCCaptureCallback
	extends android.hardware.camera2.CameraCaptureSession.CaptureCallback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCaptureBufferLost:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/view/Surface;J)V:GetOnCaptureBufferLost_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_Landroid_view_Surface_JHandler\n" +
			"n_onCaptureCompleted:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/TotalCaptureResult;)V:GetOnCaptureCompleted_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_Landroid_hardware_camera2_TotalCaptureResult_Handler\n" +
			"n_onCaptureFailed:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/CaptureFailure;)V:GetOnCaptureFailed_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_Landroid_hardware_camera2_CaptureFailure_Handler\n" +
			"n_onCaptureProgressed:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;Landroid/hardware/camera2/CaptureResult;)V:GetOnCaptureProgressed_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_Landroid_hardware_camera2_CaptureResult_Handler\n" +
			"n_onCaptureSequenceAborted:(Landroid/hardware/camera2/CameraCaptureSession;I)V:GetOnCaptureSequenceAborted_Landroid_hardware_camera2_CameraCaptureSession_IHandler\n" +
			"n_onCaptureSequenceCompleted:(Landroid/hardware/camera2/CameraCaptureSession;IJ)V:GetOnCaptureSequenceCompleted_Landroid_hardware_camera2_CameraCaptureSession_IJHandler\n" +
			"n_onCaptureStarted:(Landroid/hardware/camera2/CameraCaptureSession;Landroid/hardware/camera2/CaptureRequest;JJ)V:GetOnCaptureStarted_Landroid_hardware_camera2_CameraCaptureSession_Landroid_hardware_camera2_CaptureRequest_JJHandler\n" +
			"";
		mono.android.Runtime.register ("SubC.VXG.SubCCaptureCallback, SubC.VXG", SubCCaptureCallback.class, __md_methods);
	}


	public SubCCaptureCallback ()
	{
		super ();
		if (getClass () == SubCCaptureCallback.class)
			mono.android.TypeManager.Activate ("SubC.VXG.SubCCaptureCallback, SubC.VXG", "", this, new java.lang.Object[] {  });
	}


	public void onCaptureBufferLost (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.view.Surface p2, long p3)
	{
		n_onCaptureBufferLost (p0, p1, p2, p3);
	}

	private native void n_onCaptureBufferLost (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.view.Surface p2, long p3);


	public void onCaptureCompleted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.TotalCaptureResult p2)
	{
		n_onCaptureCompleted (p0, p1, p2);
	}

	private native void n_onCaptureCompleted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.TotalCaptureResult p2);


	public void onCaptureFailed (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.CaptureFailure p2)
	{
		n_onCaptureFailed (p0, p1, p2);
	}

	private native void n_onCaptureFailed (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.CaptureFailure p2);


	public void onCaptureProgressed (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.CaptureResult p2)
	{
		n_onCaptureProgressed (p0, p1, p2);
	}

	private native void n_onCaptureProgressed (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, android.hardware.camera2.CaptureResult p2);


	public void onCaptureSequenceAborted (android.hardware.camera2.CameraCaptureSession p0, int p1)
	{
		n_onCaptureSequenceAborted (p0, p1);
	}

	private native void n_onCaptureSequenceAborted (android.hardware.camera2.CameraCaptureSession p0, int p1);


	public void onCaptureSequenceCompleted (android.hardware.camera2.CameraCaptureSession p0, int p1, long p2)
	{
		n_onCaptureSequenceCompleted (p0, p1, p2);
	}

	private native void n_onCaptureSequenceCompleted (android.hardware.camera2.CameraCaptureSession p0, int p1, long p2);


	public void onCaptureStarted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, long p2, long p3)
	{
		n_onCaptureStarted (p0, p1, p2, p3);
	}

	private native void n_onCaptureStarted (android.hardware.camera2.CameraCaptureSession p0, android.hardware.camera2.CaptureRequest p1, long p2, long p3);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
