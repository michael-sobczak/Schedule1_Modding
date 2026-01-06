public static class XRSettings // TypeDefIndex: 19205
{
	// Properties
	public static bool enabled { get; }
	[NativeName("Active")]
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static bool isDeviceActive { get; }
	[NativeName("RenderScale")]
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static float eyeTextureResolutionScale { get; set; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static int eyeTextureWidth { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static int eyeTextureHeight { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	[NativeName("IntermediateEyeTextureDesc")]
	public static RenderTextureDescriptor eyeTextureDesc { get; }
	public static float renderViewportScale { get; }
	[NativeName("RenderViewportScale")]
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	internal static float renderViewportScaleInternal { get; }
	[NativeName("DeviceName")]
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static string loadedDeviceName { get; }
	public static string[] supportedDevices { get; }
	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	public static XRSettings.StereoRenderingMode stereoRenderingMode { get; }

	// Methods

	[StaticAccessor("GetIVRDeviceScripting()", 3)]
	// RVA: 0x2F5F450 Offset: 0x2F5DE50 VA: 0x182F5F450
	public static bool get_enabled() { }

	// RVA: 0x2F5F5A0 Offset: 0x2F5DFA0 VA: 0x182F5F5A0
	public static bool get_isDeviceActive() { }

	// RVA: 0x2F5F540 Offset: 0x2F5DF40 VA: 0x182F5F540
	public static float get_eyeTextureResolutionScale() { }

	// RVA: 0x2F5F690 Offset: 0x2F5E090 VA: 0x182F5F690
	public static void set_eyeTextureResolutionScale(float value) { }

	// RVA: 0x2F5F570 Offset: 0x2F5DF70 VA: 0x182F5F570
	public static int get_eyeTextureWidth() { }

	// RVA: 0x2F5F510 Offset: 0x2F5DF10 VA: 0x182F5F510
	public static int get_eyeTextureHeight() { }

	// RVA: 0x2F5F4C0 Offset: 0x2F5DEC0 VA: 0x182F5F4C0
	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	// RVA: 0x2F5F600 Offset: 0x2F5E000 VA: 0x182F5F600
	public static float get_renderViewportScale() { }

	// RVA: 0x2F5F600 Offset: 0x2F5E000 VA: 0x182F5F600
	internal static float get_renderViewportScaleInternal() { }

	// RVA: 0x2F5F5D0 Offset: 0x2F5DFD0 VA: 0x182F5F5D0
	public static string get_loadedDeviceName() { }

	// RVA: 0x2F5F660 Offset: 0x2F5E060 VA: 0x182F5F660
	public static string[] get_supportedDevices() { }

	// RVA: 0x2F5F630 Offset: 0x2F5E030 VA: 0x182F5F630
	public static XRSettings.StereoRenderingMode get_stereoRenderingMode() { }

	// RVA: 0x2F5F480 Offset: 0x2F5DE80 VA: 0x182F5F480
	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) { }
}
