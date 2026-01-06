public class DynamicAtlasSettings // TypeDefIndex: 6671
{
	// Fields
	[SerializeField]
	[HideInInspector]
	private int m_MinAtlasSize; // 0x10
	[HideInInspector]
	[SerializeField]
	private int m_MaxAtlasSize; // 0x14
	[HideInInspector]
	[SerializeField]
	private int m_MaxSubTextureSize; // 0x18
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasFilters m_ActiveFilters; // 0x1C
	private DynamicAtlasCustomFilter m_CustomFilter; // 0x20

	// Properties
	public int minAtlasSize { get; set; }
	public int maxAtlasSize { get; set; }
	public int maxSubTextureSize { get; set; }
	public DynamicAtlasFilters activeFilters { get; set; }
	public static DynamicAtlasFilters defaultFilters { get; }
	public DynamicAtlasCustomFilter customFilter { get; set; }
	public static DynamicAtlasSettings defaults { get; }

	// Methods

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_minAtlasSize() { }

	// RVA: 0x48C850 Offset: 0x48B250 VA: 0x18048C850
	public void set_minAtlasSize(int value) { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_maxAtlasSize() { }

	// RVA: 0x65C890 Offset: 0x65B290 VA: 0x18065C890
	public void set_maxAtlasSize(int value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_maxSubTextureSize() { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_maxSubTextureSize(int value) { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public DynamicAtlasFilters get_activeFilters() { }

	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	public void set_activeFilters(DynamicAtlasFilters value) { }

	// RVA: 0x2EA1940 Offset: 0x2EA0340 VA: 0x182EA1940
	public static DynamicAtlasFilters get_defaultFilters() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public DynamicAtlasCustomFilter get_customFilter() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	// RVA: 0x2EA1950 Offset: 0x2EA0350 VA: 0x182EA1950
	public static DynamicAtlasSettings get_defaults() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
