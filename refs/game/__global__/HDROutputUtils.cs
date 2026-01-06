public static class HDROutputUtils // TypeDefIndex: 13869
{
	// Methods

	// RVA: 0x2A54570 Offset: 0x2A52F70 VA: 0x182A54570
	public static bool GetColorSpaceForGamut(ColorGamut gamut, out int colorspace) { }

	// RVA: 0x2A543D0 Offset: 0x2A52DD0 VA: 0x182A543D0
	public static bool GetColorEncodingForGamut(ColorGamut gamut, out int encoding) { }

	// RVA: 0x2A54120 Offset: 0x2A52B20 VA: 0x182A54120
	public static void ConfigureHDROutput(Material material, ColorGamut gamut, HDROutputUtils.Operation operations) { }

	// RVA: 0x2A53DA0 Offset: 0x2A527A0 VA: 0x182A53DA0
	public static void ConfigureHDROutput(MaterialPropertyBlock properties, ColorGamut gamut) { }

	// RVA: 0x2A53B80 Offset: 0x2A52580 VA: 0x182A53B80
	public static void ConfigureHDROutput(Material material, HDROutputUtils.Operation operations) { }

	// RVA: 0x2A53E70 Offset: 0x2A52870 VA: 0x182A53E70
	public static void ConfigureHDROutput(ComputeShader computeShader, ColorGamut gamut, HDROutputUtils.Operation operations) { }

	// RVA: 0x2A547E0 Offset: 0x2A531E0 VA: 0x182A547E0
	public static bool IsShaderVariantValid(ShaderKeywordSet shaderKeywordSet, bool isHDREnabled) { }
}
