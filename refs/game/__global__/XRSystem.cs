public static class XRSystem // TypeDefIndex: 13498
{
	// Fields
	private static XRLayout s_Layout; // 0x0
	private static Func<XRPassCreateInfo, XRPass> s_PassAllocator; // 0x8
	private static List<XRDisplaySubsystem> s_DisplayList; // 0x10
	private static XRDisplaySubsystem s_Display; // 0x18
	private static MSAASamples s_MSAASamples; // 0x20
	private static Material s_OcclusionMeshMaterial; // 0x28
	private static Material s_MirrorViewMaterial; // 0x30
	private static Action<XRLayout, Camera> s_LayoutOverride; // 0x38
	public static readonly XRPass emptyPass; // 0x40
	[CompilerGenerated]
	private static bool <singlePassAllowed>k__BackingField; // 0x48
	[CompilerGenerated]
	private static FoveatedRenderingCaps <foveatedRenderingCaps>k__BackingField; // 0x4C
	[CompilerGenerated]
	private static bool <dumpDebugInfo>k__BackingField; // 0x50

	// Properties
	public static bool displayActive { get; }
	public static bool isHDRDisplayOutputActive { get; }
	public static bool singlePassAllowed { get; set; }
	public static FoveatedRenderingCaps foveatedRenderingCaps { get; set; }
	public static bool dumpDebugInfo { get; set; }

	// Methods

	// RVA: 0x29E3260 Offset: 0x29E1C60 VA: 0x1829E3260
	public static XRDisplaySubsystem GetActiveDisplay() { }

	// RVA: 0x29E4B00 Offset: 0x29E3500 VA: 0x1829E4B00
	public static bool get_displayActive() { }

	// RVA: 0x29E4C30 Offset: 0x29E3630 VA: 0x1829E4C30
	public static bool get_isHDRDisplayOutputActive() { }

	[CompilerGenerated]
	// RVA: 0x29E4CF0 Offset: 0x29E36F0 VA: 0x1829E4CF0
	public static bool get_singlePassAllowed() { }

	[CompilerGenerated]
	// RVA: 0x29E4E00 Offset: 0x29E3800 VA: 0x1829E4E00
	public static void set_singlePassAllowed(bool value) { }

	[CompilerGenerated]
	// RVA: 0x29E4BE0 Offset: 0x29E35E0 VA: 0x1829E4BE0
	public static FoveatedRenderingCaps get_foveatedRenderingCaps() { }

	[CompilerGenerated]
	// RVA: 0x29E4DA0 Offset: 0x29E37A0 VA: 0x1829E4DA0
	public static void set_foveatedRenderingCaps(FoveatedRenderingCaps value) { }

	[CompilerGenerated]
	// RVA: 0x29E4B90 Offset: 0x29E3590 VA: 0x1829E4B90
	public static bool get_dumpDebugInfo() { }

	[CompilerGenerated]
	// RVA: 0x29E4D40 Offset: 0x29E3740 VA: 0x1829E4D40
	public static void set_dumpDebugInfo(bool value) { }

	// RVA: 0x29E3300 Offset: 0x29E1D00 VA: 0x1829E3300
	public static void Initialize(Func<XRPassCreateInfo, XRPass> passAllocator, Shader occlusionMeshPS, Shader mirrorViewPS) { }

	// RVA: 0x29E42E0 Offset: 0x29E2CE0 VA: 0x1829E42E0
	public static void SetDisplayMSAASamples(MSAASamples msaaSamples) { }

	// RVA: 0x29E32B0 Offset: 0x29E1CB0 VA: 0x1829E32B0
	public static MSAASamples GetDisplayMSAASamples() { }

	// RVA: 0x29E4610 Offset: 0x29E3010 VA: 0x1829E4610
	public static void SetRenderScale(float renderScale) { }

	// RVA: 0x29E3720 Offset: 0x29E2120 VA: 0x1829E3720
	public static XRLayout NewLayout() { }

	// RVA: 0x29E3050 Offset: 0x29E1A50 VA: 0x1829E3050
	public static void EndLayout() { }

	// RVA: 0x29E4220 Offset: 0x29E2C20 VA: 0x1829E4220
	public static void RenderMirrorView(CommandBuffer cmd, Camera camera) { }

	// RVA: 0x29E2E70 Offset: 0x29E1870 VA: 0x1829E2E70
	public static void Dispose() { }

	// RVA: 0x29E44D0 Offset: 0x29E2ED0 VA: 0x1829E44D0
	internal static void SetDisplayZRange(float zNear, float zFar) { }

	// RVA: 0x29E45A0 Offset: 0x29E2FA0 VA: 0x1829E45A0
	private static void SetLayoutOverride(Action<XRLayout, Camera> action) { }

	[RuntimeInitializeOnLoadMethod(3)]
	// RVA: 0x29E47B0 Offset: 0x29E31B0 VA: 0x1829E47B0
	private static void XRSystemInit() { }

	// RVA: 0x29E3ED0 Offset: 0x29E28D0 VA: 0x1829E3ED0
	private static void RefreshDeviceInfo() { }

	// RVA: 0x29E21F0 Offset: 0x29E0BF0 VA: 0x1829E21F0
	internal static void CreateDefaultLayout(Camera camera) { }

	// RVA: 0x29E3820 Offset: 0x29E2220 VA: 0x1829E3820
	internal static void ReconfigurePass(XRPass xrPass, Camera camera) { }

	// RVA: 0x29E2040 Offset: 0x29E0A40 VA: 0x1829E2040
	private static bool CanUseSinglePass(Camera camera, XRDisplaySubsystem.XRRenderPass renderPass) { }

	// RVA: 0x29E1C30 Offset: 0x29E0630 VA: 0x1829E1C30
	private static XRView BuildView(XRDisplaySubsystem.XRRenderPass renderPass, XRDisplaySubsystem.XRRenderParameter renderParameter) { }

	// RVA: 0x29E1700 Offset: 0x29E0100 VA: 0x1829E1700
	private static XRPassCreateInfo BuildPass(XRDisplaySubsystem.XRRenderPass xrRenderPass, ScriptableCullingParameters cullingParameters) { }

	// RVA: 0x29E4840 Offset: 0x29E3240 VA: 0x1829E4840
	private static void .cctor() { }
}
