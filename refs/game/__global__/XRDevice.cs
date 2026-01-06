public static class XRDevice // TypeDefIndex: 19206
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static Action<string> deviceLoaded; // 0x0

	// Methods

	[StaticAccessor("GetIVRDevice()", 3)]
	[NativeName("DisableAutoVRCameraTracking")]
	// RVA: 0x2F5F3A0 Offset: 0x2F5DDA0 VA: 0x182F5F3A0
	public static void DisableAutoXRCameraTracking(Camera camera, bool disabled) { }

	[RequiredByNativeCode]
	// RVA: 0x2F5F3F0 Offset: 0x2F5DDF0 VA: 0x182F5F3F0
	private static void InvokeDeviceLoaded(string loadedDeviceName) { }
}
