public static class LightmapperUtils // TypeDefIndex: 12330
{
	// Methods

	// RVA: 0x2CF1860 Offset: 0x2CF0260 VA: 0x182CF1860
	public static LightMode Extract(LightmapBakeType baketype) { }

	// RVA: 0x2CF0F00 Offset: 0x2CEF900 VA: 0x182CF0F00
	public static LinearColor ExtractIndirect(Light l) { }

	// RVA: 0x2CF0F90 Offset: 0x2CEF990 VA: 0x182CF0F90
	public static float ExtractInnerCone(Light l) { }

	// RVA: 0x2CF0E80 Offset: 0x2CEF880 VA: 0x182CF0E80
	private static Color ExtractColorTemperature(Light l) { }

	// RVA: 0x2CF0E20 Offset: 0x2CEF820 VA: 0x182CF0E20
	private static void ApplyColorTemperature(Color cct, ref LinearColor lightColor) { }

	// RVA: 0x2CF12C0 Offset: 0x2CEFCC0 VA: 0x182CF12C0
	public static void Extract(Light l, ref DirectionalLight dir) { }

	// RVA: 0x2CF1580 Offset: 0x2CEFF80 VA: 0x182CF1580
	public static void Extract(Light l, ref PointLight point) { }

	// RVA: 0x2CF1880 Offset: 0x2CF0280 VA: 0x182CF1880
	public static void Extract(Light l, ref SpotLight spot) { }

	// RVA: 0x2CF0FE0 Offset: 0x2CEF9E0 VA: 0x182CF0FE0
	public static void Extract(Light l, ref RectangleLight rect) { }

	// RVA: 0x2CF1580 Offset: 0x2CEFF80 VA: 0x182CF1580
	public static void Extract(Light l, ref DiscLight disc) { }

	// RVA: 0x2CF1BB0 Offset: 0x2CF05B0 VA: 0x182CF1BB0
	public static void Extract(Light l, out Cookie cookie) { }
}
