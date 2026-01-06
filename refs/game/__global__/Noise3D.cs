public static class Noise3D // TypeDefIndex: 311
{
	// Fields
	private static bool ms_IsSupportedChecked; // 0x0
	private static bool ms_IsSupported; // 0x1
	private static Texture3D ms_NoiseTexture; // 0x8
	private const int kMinShaderLevel = 35;

	// Properties
	public static bool isSupported { get; }
	public static bool isProperlyLoaded { get; }
	public static string isNotSupportedString { get; }

	// Methods

	// RVA: 0x7B3CC0 Offset: 0x7B26C0 VA: 0x1807B3CC0
	public static bool get_isSupported() { }

	// RVA: 0x7B3C50 Offset: 0x7B2650 VA: 0x1807B3C50
	public static bool get_isProperlyLoaded() { }

	// RVA: 0x7B3BC0 Offset: 0x7B25C0 VA: 0x1807B3BC0
	public static string get_isNotSupportedString() { }

	[RuntimeInitializeOnLoadMethod]
	// RVA: 0x7B3BB0 Offset: 0x7B25B0 VA: 0x1807B3BB0
	private static void OnStartUp() { }

	// RVA: 0x7B3A70 Offset: 0x7B2470 VA: 0x1807B3A70
	public static void LoadIfNeeded() { }
}
