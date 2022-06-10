using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"veg/mediacapture/sdk/camera",
					},
					new Converter<string, Type>[]{
						lookup_veg_mediacapture_sdk_camera_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_veg_mediacapture_sdk_camera_mappings;
		static Type lookup_veg_mediacapture_sdk_camera_package (string klass)
		{
			if (package_veg_mediacapture_sdk_camera_mappings == null) {
				package_veg_mediacapture_sdk_camera_mappings = new string[]{
					"veg/mediacapture/sdk/camera/CameraService$CameraInfo:Veg.Mediacapture.Sdk.Camera.CameraServiceCameraInfo",
					"veg/mediacapture/sdk/camera/CameraService$Facing:Veg.Mediacapture.Sdk.Camera.CameraServiceFacing",
					"veg/mediacapture/sdk/camera/CameraService$FlashMode:Veg.Mediacapture.Sdk.Camera.CameraServiceFlashMode",
					"veg/mediacapture/sdk/camera/CameraService$FocusMode:Veg.Mediacapture.Sdk.Camera.CameraServiceFocusMode",
					"veg/mediacapture/sdk/camera/CameraService$Size:Veg.Mediacapture.Sdk.Camera.CameraServiceSize",
					"veg/mediacapture/sdk/camera/CameraService$StateCallback:Veg.Mediacapture.Sdk.Camera.CameraServiceStateCallback",
				};
			}

			return Lookup (package_veg_mediacapture_sdk_camera_mappings, klass);
		}
	}
}
