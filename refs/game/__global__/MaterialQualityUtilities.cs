public static class MaterialQualityUtilities // TypeDefIndex: 13871
{
	// Fields
	public static string[] KeywordNames; // 0x0
	public static string[] EnumNames; // 0x8
	public static ShaderKeyword[] Keywords; // 0x10

	// Methods

	[Extension]
	// RVA: 0x2A55C50 Offset: 0x2A54650 VA: 0x182A55C50
	public static MaterialQuality GetHighestQuality(MaterialQuality levels) { }

	[Extension]
	// RVA: 0x2A55A80 Offset: 0x2A54480 VA: 0x182A55A80
	public static MaterialQuality GetClosestQuality(MaterialQuality availableLevels, MaterialQuality requestedLevel) { }

	[Extension]
	// RVA: 0x2A55CE0 Offset: 0x2A546E0 VA: 0x182A55CE0
	public static void SetGlobalShaderKeywords(MaterialQuality level) { }

	[Extension]
	// RVA: 0x2A55E10 Offset: 0x2A54810 VA: 0x182A55E10
	public static void SetGlobalShaderKeywords(MaterialQuality level, CommandBuffer cmd) { }

	[Extension]
	// RVA: 0x2A55F60 Offset: 0x2A54960 VA: 0x182A55F60
	public static int ToFirstIndex(MaterialQuality level) { }

	// RVA: 0x2A55A70 Offset: 0x2A54470 VA: 0x182A55A70
	public static MaterialQuality FromIndex(int index) { }

	// RVA: 0x2A55FF0 Offset: 0x2A549F0 VA: 0x182A55FF0
	private static void .cctor() { }
}
