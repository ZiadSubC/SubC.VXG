using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "android.media.cts", Managed="Android.Media.Cts")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "au.notzed.jjmpeg", Managed="AU.Notzed.Jjmpeg")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "au.notzed.jjmpeg.exception", Managed="AU.Notzed.Jjmpeg.Exception")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk", Managed="Veg.Mediacapture.Sdk")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.api", Managed="Veg.Mediacapture.Sdk.Api")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.camera", Managed="Veg.Mediacapture.Sdk.Camera")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.recordmc", Managed="Veg.Mediacapture.Sdk.Recordmc")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.render", Managed="Veg.Mediacapture.Sdk.Render")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.streaming", Managed="Veg.Mediacapture.Sdk.Streaming")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.streaming.audio", Managed="Veg.Mediacapture.Sdk.Streaming.Audio")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.streaming.exceptions", Managed="Veg.Mediacapture.Sdk.Streaming.Exceptions")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.streaming.mp4", Managed="Veg.Mediacapture.Sdk.Streaming.Mp4")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.streaming.rtcp", Managed="Veg.Mediacapture.Sdk.Streaming.Rtcp")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.streaming.rtp", Managed="Veg.Mediacapture.Sdk.Streaming.Rtp")]
[assembly:global::Android.Runtime.NamespaceMapping (Java = "veg.mediacapture.sdk.streaming.video", Managed="Veg.Mediacapture.Sdk.Streaming.Video")]

delegate double _JniMarshal_PP_D (IntPtr jnienv, IntPtr klass);
delegate float _JniMarshal_PP_F (IntPtr jnienv, IntPtr klass);
delegate int _JniMarshal_PP_I (IntPtr jnienv, IntPtr klass);
delegate long _JniMarshal_PP_J (IntPtr jnienv, IntPtr klass);
delegate IntPtr _JniMarshal_PP_L (IntPtr jnienv, IntPtr klass);
delegate void _JniMarshal_PP_V (IntPtr jnienv, IntPtr klass);
delegate bool _JniMarshal_PP_Z (IntPtr jnienv, IntPtr klass);
delegate sbyte _JniMarshal_PPB_B (IntPtr jnienv, IntPtr klass, sbyte p0);
delegate int _JniMarshal_PPB_I (IntPtr jnienv, IntPtr klass, sbyte p0);
delegate void _JniMarshal_PPD_V (IntPtr jnienv, IntPtr klass, double p0);
delegate void _JniMarshal_PPF_V (IntPtr jnienv, IntPtr klass, float p0);
delegate sbyte _JniMarshal_PPI_B (IntPtr jnienv, IntPtr klass, int p0);
delegate int _JniMarshal_PPI_I (IntPtr jnienv, IntPtr klass, int p0);
delegate long _JniMarshal_PPI_J (IntPtr jnienv, IntPtr klass, int p0);
delegate IntPtr _JniMarshal_PPI_L (IntPtr jnienv, IntPtr klass, int p0);
delegate void _JniMarshal_PPI_V (IntPtr jnienv, IntPtr klass, int p0);
delegate bool _JniMarshal_PPI_Z (IntPtr jnienv, IntPtr klass, int p0);
delegate int _JniMarshal_PPII_I (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate void _JniMarshal_PPII_V (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate int _JniMarshal_PPIII_I (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2);
delegate int _JniMarshal_PPIIII_I (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPIIII_V (IntPtr jnienv, IntPtr klass, int p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPIILL_V (IntPtr jnienv, IntPtr klass, int p0, int p1, IntPtr p2, IntPtr p3);
delegate int _JniMarshal_PPIJI_I (IntPtr jnienv, IntPtr klass, int p0, long p1, int p2);
delegate int _JniMarshal_PPIJJJI_I (IntPtr jnienv, IntPtr klass, int p0, long p1, long p2, long p3, int p4);
delegate IntPtr _JniMarshal_PPIL_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPIL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1);
delegate void _JniMarshal_PPILI_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, int p2);
delegate IntPtr _JniMarshal_PPILII_L (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, int p2, int p3);
delegate void _JniMarshal_PPILL_V (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2);
delegate int _JniMarshal_PPILLII_I (IntPtr jnienv, IntPtr klass, int p0, IntPtr p1, IntPtr p2, int p3, int p4);
delegate int _JniMarshal_PPIZ_I (IntPtr jnienv, IntPtr klass, int p0, bool p1);
delegate long _JniMarshal_PPIZ_J (IntPtr jnienv, IntPtr klass, int p0, bool p1);
delegate void _JniMarshal_PPIZ_V (IntPtr jnienv, IntPtr klass, int p0, bool p1);
delegate bool _JniMarshal_PPIZ_Z (IntPtr jnienv, IntPtr klass, int p0, bool p1);
delegate void _JniMarshal_PPIZZ_V (IntPtr jnienv, IntPtr klass, int p0, bool p1, bool p2);
delegate void _JniMarshal_PPJ_V (IntPtr jnienv, IntPtr klass, long p0);
delegate long _JniMarshal_PPJI_J (IntPtr jnienv, IntPtr klass, long p0, int p1);
delegate void _JniMarshal_PPJZ_V (IntPtr jnienv, IntPtr klass, long p0, bool p1);
delegate int _JniMarshal_PPL_I (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate IntPtr _JniMarshal_PPL_L (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPL_V (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate bool _JniMarshal_PPL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0);
delegate void _JniMarshal_PPLF_V (IntPtr jnienv, IntPtr klass, IntPtr p0, float p1);
delegate void _JniMarshal_PPLI_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1);
delegate IntPtr _JniMarshal_PPLII_L (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate void _JniMarshal_PPLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2);
delegate void _JniMarshal_PPLIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, int p3);
delegate int _JniMarshal_PPLIIJ_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, long p3);
delegate void _JniMarshal_PPLIIJ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, long p3);
delegate int _JniMarshal_PPLIIL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, IntPtr p3);
delegate void _JniMarshal_PPLIIZIII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, int p2, bool p3, int p4, int p5, int p6);
delegate int _JniMarshal_PPLIL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, int p1, IntPtr p2);
delegate void _JniMarshal_PPLJ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1);
delegate void _JniMarshal_PPLJJ_V (IntPtr jnienv, IntPtr klass, IntPtr p0, long p1, long p2);
delegate int _JniMarshal_PPLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate IntPtr _JniMarshal_PPLL_L (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLL_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate bool _JniMarshal_PPLL_Z (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1);
delegate void _JniMarshal_PPLLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3);
delegate void _JniMarshal_PPLLIIIILLII_V (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, int p2, int p3, int p4, int p5, IntPtr p6, IntPtr p7, int p8, int p9);
delegate int _JniMarshal_PPLLL_I (IntPtr jnienv, IntPtr klass, IntPtr p0, IntPtr p1, IntPtr p2);
delegate IntPtr _JniMarshal_PPZ_L (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZ_V (IntPtr jnienv, IntPtr klass, bool p0);
delegate void _JniMarshal_PPZIII_V (IntPtr jnienv, IntPtr klass, bool p0, int p1, int p2, int p3);
delegate void _JniMarshal_PPZLI_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1, int p2);
delegate void _JniMarshal_PPZLL_V (IntPtr jnienv, IntPtr klass, bool p0, IntPtr p1, IntPtr p2);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Event | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

