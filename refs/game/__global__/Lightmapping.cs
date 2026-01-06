public static class Lightmapping // TypeDefIndex: 12333
{
	// Fields
	[RequiredByNativeCode]
	private static readonly Lightmapping.RequestLightsDelegate s_DefaultDelegate; // 0x0
	[RequiredByNativeCode]
	private static Lightmapping.RequestLightsDelegate s_RequestLightsDelegate; // 0x8

	// Methods

	[RequiredByNativeCode]
	// RVA: 0x2CF1E90 Offset: 0x2CF0890 VA: 0x182CF1E90
	public static void SetDelegate(Lightmapping.RequestLightsDelegate del) { }

	[RequiredByNativeCode]
	// RVA: 0x2CF1CF0 Offset: 0x2CF06F0 VA: 0x182CF1CF0
	public static Lightmapping.RequestLightsDelegate GetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x2CF1E20 Offset: 0x2CF0820 VA: 0x182CF1E20
	public static void ResetDelegate() { }

	[RequiredByNativeCode]
	// RVA: 0x2CF1D40 Offset: 0x2CF0740 VA: 0x182CF1D40
	internal static void RequestLights(Light[] lights, IntPtr outLightsPtr, int outLightsCount) { }

	// RVA: 0x2CF1F20 Offset: 0x2CF0920 VA: 0x182CF1F20
	private static void .cctor() { }
}
