public static class KeywordsUtility // TypeDefIndex: 10814
{
	// Fields
	private static Dictionary<BlurType, string> BlurTypes; // 0x0
	private static Dictionary<DilateQuality, string> DilateQualityKeywords; // 0x8

	// Methods

	// RVA: 0x541110 Offset: 0x53FB10 VA: 0x180541110
	public static string GetBackKeyword(ComplexMaskingMode mode) { }

	// RVA: 0x5413E0 Offset: 0x53FDE0 VA: 0x1805413E0
	public static string GetTextureArrayCutoutKeyword() { }

	// RVA: 0x541290 Offset: 0x53FC90 VA: 0x180541290
	public static string GetDilateQualityKeyword(DilateQuality quality) { }

	// RVA: 0x541380 Offset: 0x53FD80 VA: 0x180541380
	public static string GetEnabledInfoBufferKeyword() { }

	// RVA: 0x541350 Offset: 0x53FD50 VA: 0x180541350
	public static string GetEdgeMaskKeyword() { }

	// RVA: 0x5413B0 Offset: 0x53FDB0 VA: 0x1805413B0
	public static string GetInfoBufferStageKeyword() { }

	// RVA: 0x5411E0 Offset: 0x53FBE0 VA: 0x1805411E0
	public static string GetBlurKeyword(BlurType type) { }

	// RVA: 0x541260 Offset: 0x53FC60 VA: 0x180541260
	public static string GetCutoutKeyword() { }

	// RVA: 0x540D30 Offset: 0x53F730 VA: 0x180540D30
	public static void GetAllBlurKeywords(List<string> list) { }

	// RVA: 0x540F20 Offset: 0x53F920 VA: 0x180540F20
	public static void GetAllDilateKeywords(List<string> list) { }

	// RVA: 0x541410 Offset: 0x53FE10 VA: 0x180541410
	private static void .cctor() { }
}
