public class SupportedRenderingFeatures // TypeDefIndex: 12278
{
	// Fields
	private static SupportedRenderingFeatures s_Active; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.ReflectionProbeModes <reflectionProbeModes>k__BackingField; // 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <defaultMixedLightingModes>k__BackingField; // 0x14
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private SupportedRenderingFeatures.LightmapMixedBakeModes <mixedLightingModes>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private LightmapBakeType <lightmapBakeTypes>k__BackingField; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private LightmapsMode <lightmapsModes>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <enlightenLightmapper>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enlighten>k__BackingField; // 0x25
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <lightProbeProxyVolumes>k__BackingField; // 0x26
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <motionVectors>k__BackingField; // 0x27
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <receiveShadows>k__BackingField; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <reflectionProbes>k__BackingField; // 0x29
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <reflectionProbesBlendDistance>k__BackingField; // 0x2A
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <rendererPriority>k__BackingField; // 0x2B
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendersUIOverlay>k__BackingField; // 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnvironmentLighting>k__BackingField; // 0x2D
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesFog>k__BackingField; // 0x2E
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesRealtimeReflectionProbes>k__BackingField; // 0x2F
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesOtherLightingSettings>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <editableMaterialRenderQueue>k__BackingField; // 0x31
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesLODBias>k__BackingField; // 0x32
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesMaximumLODLevel>k__BackingField; // 0x33
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <overridesEnableLODCrossFade>k__BackingField; // 0x34
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <rendererProbes>k__BackingField; // 0x35
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <particleSystemInstancing>k__BackingField; // 0x36
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <autoAmbientProbeBaking>k__BackingField; // 0x37
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <autoDefaultReflectionProbeBaking>k__BackingField; // 0x38
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesShadowmask>k__BackingField; // 0x39
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <overridesLightProbeSystem>k__BackingField; // 0x3A
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <supportsHDR>k__BackingField; // 0x3B
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private string <overridesLightProbeSystemWarningMessage>k__BackingField; // 0x40

	// Properties
	public static SupportedRenderingFeatures active { get; set; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes defaultMixedLightingModes { get; }
	public SupportedRenderingFeatures.LightmapMixedBakeModes mixedLightingModes { get; }
	public LightmapBakeType lightmapBakeTypes { get; }
	public LightmapsMode lightmapsModes { get; }
	[Obsolete("Bake with the Progressive Lightmapper. The backend that uses Enlighten to bake is deprecated.", False)]
	public bool enlightenLightmapper { get; }
	public bool enlighten { get; }
	public bool motionVectors { set; }
	public bool rendersUIOverlay { get; set; }
	public bool autoAmbientProbeBaking { get; }
	public bool autoDefaultReflectionProbeBaking { get; }
	public bool overridesLightProbeSystem { get; }
	public bool supportsHDR { set; }

	// Methods

	// RVA: 0x2CFEFD0 Offset: 0x2CFD9D0 VA: 0x182CFEFD0
	public static SupportedRenderingFeatures get_active() { }

	// RVA: 0x2CFF0B0 Offset: 0x2CFDAB0 VA: 0x182CFF0B0
	public static void set_active(SupportedRenderingFeatures value) { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_defaultMixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public SupportedRenderingFeatures.LightmapMixedBakeModes get_mixedLightingModes() { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public LightmapBakeType get_lightmapBakeTypes() { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public LightmapsMode get_lightmapsModes() { }

	[CompilerGenerated]
	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_enlightenLightmapper() { }

	[CompilerGenerated]
	// RVA: 0x563D80 Offset: 0x562780 VA: 0x180563D80
	public bool get_enlighten() { }

	[CompilerGenerated]
	// RVA: 0x1D7E560 Offset: 0x1D7CF60 VA: 0x181D7E560
	public void set_motionVectors(bool value) { }

	[CompilerGenerated]
	// RVA: 0x1ECD6B0 Offset: 0x1ECC0B0 VA: 0x181ECD6B0
	public bool get_rendersUIOverlay() { }

	[CompilerGenerated]
	// RVA: 0x1ECD6C0 Offset: 0x1ECC0C0 VA: 0x181ECD6C0
	public void set_rendersUIOverlay(bool value) { }

	[CompilerGenerated]
	// RVA: 0x2ACF800 Offset: 0x2ACE200 VA: 0x182ACF800
	public bool get_autoAmbientProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_autoDefaultReflectionProbeBaking() { }

	[CompilerGenerated]
	// RVA: 0x1B24E10 Offset: 0x1B23810 VA: 0x181B24E10
	public bool get_overridesLightProbeSystem() { }

	[CompilerGenerated]
	// RVA: 0x2CFF120 Offset: 0x2CFDB20 VA: 0x182CFF120
	public void set_supportsHDR(bool value) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFE4C0 Offset: 0x2CFCEC0 VA: 0x182CFE4C0
	internal static void FallbackMixedLightingModeByRef(IntPtr fallbackModePtr) { }

	// RVA: 0x2CFECA0 Offset: 0x2CFD6A0 VA: 0x182CFECA0
	internal static bool IsMixedLightingModeSupported(MixedLightingMode mixedMode) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFEB40 Offset: 0x2CFD540 VA: 0x182CFEB40
	internal static void IsMixedLightingModeSupportedByRef(MixedLightingMode mixedMode, IntPtr isSupportedPtr) { }

	// RVA: 0x2CFE8F0 Offset: 0x2CFD2F0 VA: 0x182CFE8F0
	internal static bool IsLightmapBakeTypeSupported(LightmapBakeType bakeType) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFE7F0 Offset: 0x2CFD1F0 VA: 0x182CFE7F0
	internal static void IsLightmapBakeTypeSupportedByRef(LightmapBakeType bakeType, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFEAC0 Offset: 0x2CFD4C0 VA: 0x182CFEAC0
	internal static void IsLightmapsModeSupportedByRef(LightmapsMode mode, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFEA30 Offset: 0x2CFD430 VA: 0x182CFEA30
	internal static void IsLightmapperSupportedByRef(int lightmapper, IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFEDF0 Offset: 0x2CFD7F0 VA: 0x182CFEDF0
	internal static void IsUIOverlayRenderedBySRP(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFE710 Offset: 0x2CFD110 VA: 0x182CFE710
	internal static void IsAutoAmbientProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFE780 Offset: 0x2CFD180 VA: 0x182CFE780
	internal static void IsAutoDefaultReflectionProbeBakingSupported(IntPtr isSupportedPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFEE60 Offset: 0x2CFD860 VA: 0x182CFEE60
	internal static void OverridesLightProbeSystem(IntPtr overridesPtr) { }

	[RequiredByNativeCode]
	// RVA: 0x2CFE4A0 Offset: 0x2CFCEA0 VA: 0x182CFE4A0
	internal static void FallbackLightmapperByRef(IntPtr lightmapperPtr) { }

	// RVA: 0x2CFEF40 Offset: 0x2CFD940 VA: 0x182CFEF40
	public void .ctor() { }

	// RVA: 0x2CFEED0 Offset: 0x2CFD8D0 VA: 0x182CFEED0
	private static void .cctor() { }
}
