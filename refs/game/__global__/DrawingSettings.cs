public struct DrawingSettings : IEquatable<DrawingSettings> // TypeDefIndex: 12246
{
	// Fields
	public static readonly int maxShaderPasses; // 0x0
	private SortingSettings m_SortingSettings; // 0x0
	[FixedBuffer(typeof(int), 16)]
	internal DrawingSettings.<shaderPassNames>e__FixedBuffer shaderPassNames; // 0x60
	private PerObjectData m_PerObjectData; // 0xA0
	private DrawRendererFlags m_Flags; // 0xA4
	private int m_OverrideShaderID; // 0xA8
	private int m_OverrideShaderPassIndex; // 0xAC
	private int m_OverrideMaterialInstanceId; // 0xB0
	private int m_OverrideMaterialPassIndex; // 0xB4
	private int m_fallbackMaterialInstanceId; // 0xB8
	private int m_MainLightIndex; // 0xBC
	private int m_UseSrpBatcher; // 0xC0

	// Properties
	public SortingSettings sortingSettings { get; set; }
	public PerObjectData perObjectData { set; }
	public bool enableDynamicBatching { set; }
	public bool enableInstancing { set; }
	public Material overrideMaterial { set; }
	public Shader overrideShader { set; }
	public int overrideMaterialPassIndex { set; }
	public int overrideShaderPassIndex { set; }
	public Material fallbackMaterial { set; }
	public int mainLightIndex { set; }

	// Methods

	// RVA: 0x2CDF970 Offset: 0x2CDE370 VA: 0x182CDF970
	public void .ctor(ShaderTagId shaderPassName, SortingSettings sortingSettings) { }

	// RVA: 0x2CDFA80 Offset: 0x2CDE480 VA: 0x182CDFA80
	public SortingSettings get_sortingSettings() { }

	// RVA: 0x2CDFCB0 Offset: 0x2CDE6B0 VA: 0x182CDFCB0
	public void set_sortingSettings(SortingSettings value) { }

	// RVA: 0x5B3AF0 Offset: 0x5B24F0 VA: 0x1805B3AF0
	public void set_perObjectData(PerObjectData value) { }

	// RVA: 0x2CDFBB0 Offset: 0x2CDE5B0 VA: 0x182CDFBB0
	public void set_enableDynamicBatching(bool value) { }

	// RVA: 0x2CDFBD0 Offset: 0x2CDE5D0 VA: 0x182CDFBD0
	public void set_enableInstancing(bool value) { }

	// RVA: 0x2CDFC30 Offset: 0x2CDE630 VA: 0x182CDFC30
	public void set_overrideMaterial(Material value) { }

	// RVA: 0x2CDFC70 Offset: 0x2CDE670 VA: 0x182CDFC70
	public void set_overrideShader(Shader value) { }

	// RVA: 0x10F9800 Offset: 0x10F8200 VA: 0x1810F9800
	public void set_overrideMaterialPassIndex(int value) { }

	// RVA: 0xBBA820 Offset: 0xBB9220 VA: 0x180BBA820
	public void set_overrideShaderPassIndex(int value) { }

	// RVA: 0x2CDFBF0 Offset: 0x2CDE5F0 VA: 0x182CDFBF0
	public void set_fallbackMaterial(Material value) { }

	// RVA: 0x4E8E00 Offset: 0x4E7800 VA: 0x1804E8E00
	public void set_mainLightIndex(int value) { }

	// RVA: 0x2CDF680 Offset: 0x2CDE080 VA: 0x182CDF680
	public ShaderTagId GetShaderPassName(int index) { }

	// RVA: 0x2CDF7E0 Offset: 0x2CDE1E0 VA: 0x182CDF7E0
	public void SetShaderPassName(int index, ShaderTagId shaderPassName) { }

	// RVA: 0x2CDF120 Offset: 0x2CDDB20 VA: 0x182CDF120 Slot: 4
	public bool Equals(DrawingSettings other) { }

	// RVA: 0x2CDEFE0 Offset: 0x2CDD9E0 VA: 0x182CDEFE0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2CDF620 Offset: 0x2CDE020 VA: 0x182CDF620 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2CDFAC0 Offset: 0x2CDE4C0 VA: 0x182CDFAC0
	public static bool op_Equality(DrawingSettings left, DrawingSettings right) { }

	// RVA: 0x2CDF930 Offset: 0x2CDE330 VA: 0x182CDF930
	private static void .cctor() { }
}
