internal class DynamicAtlas : AtlasBase // TypeDefIndex: 6167
{
	// Fields
	private Dictionary<Texture, DynamicAtlas.TextureInfo> m_Database; // 0x18
	private DynamicAtlasPage m_PointPage; // 0x20
	private DynamicAtlasPage m_BilinearPage; // 0x28
	private ColorSpace m_ColorSpace; // 0x30
	private List<IPanel> m_Panels; // 0x38
	private int m_MinAtlasSize; // 0x40
	private int m_MaxAtlasSize; // 0x44
	private int m_MaxSubTextureSize; // 0x48
	private DynamicAtlasFilters m_ActiveFilters; // 0x4C
	private DynamicAtlasCustomFilter m_CustomFilter; // 0x50

	// Properties
	internal bool isInitialized { get; }
	public int minAtlasSize { set; }
	public int maxAtlasSize { set; }
	public static DynamicAtlasFilters defaultFilters { get; }
	public DynamicAtlasFilters activeFilters { set; }
	public int maxSubTextureSize { get; set; }
	public DynamicAtlasCustomFilter customFilter { set; }

	// Methods

	// RVA: 0x2DB7C50 Offset: 0x2DB6650 VA: 0x182DB7C50
	internal bool get_isInitialized() { }

	// RVA: 0x2DB70E0 Offset: 0x2DB5AE0 VA: 0x182DB70E0 Slot: 7
	protected override void OnAssignedToPanel(IPanel panel) { }

	// RVA: 0x2DB71B0 Offset: 0x2DB5BB0 VA: 0x182DB71B0 Slot: 8
	protected override void OnRemovedFromPanel(IPanel panel) { }

	// RVA: 0x2DB72C0 Offset: 0x2DB5CC0 VA: 0x182DB72C0 Slot: 6
	public override void Reset() { }

	// RVA: 0x2DB6D70 Offset: 0x2DB5770 VA: 0x182DB6D70
	private void InitPages() { }

	// RVA: 0x2DB6CE0 Offset: 0x2DB56E0 VA: 0x182DB6CE0
	private void DestroyPages() { }

	// RVA: 0x2DB7590 Offset: 0x2DB5F90 VA: 0x182DB7590 Slot: 4
	public override bool TryGetAtlas(VisualElement ve, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

	// RVA: 0x2DB7440 Offset: 0x2DB5E40 VA: 0x182DB7440 Slot: 5
	public override void ReturnAtlas(VisualElement ve, Texture2D src, TextureId atlas) { }

	// RVA: 0x2DB7240 Offset: 0x2DB5C40 VA: 0x182DB7240 Slot: 9
	protected override void OnUpdateDynamicTextures(IPanel panel) { }

	// RVA: 0x2DB6E90 Offset: 0x2DB5890 VA: 0x182DB6E90
	internal static bool IsTextureFormatSupported(TextureFormat format) { }

	// RVA: 0x2DB6F20 Offset: 0x2DB5920 VA: 0x182DB6F20 Slot: 10
	public virtual bool IsTextureValid(Texture2D texture, FilterMode atlasFilterMode) { }

	// RVA: 0x2DB7D30 Offset: 0x2DB6730 VA: 0x182DB7D30
	public void set_minAtlasSize(int value) { }

	// RVA: 0x2DB7CF0 Offset: 0x2DB66F0 VA: 0x182DB7CF0
	public void set_maxAtlasSize(int value) { }

	// RVA: 0x24A4B80 Offset: 0x24A3580 VA: 0x1824A4B80
	public static DynamicAtlasFilters get_defaultFilters() { }

	// RVA: 0x2DB7C70 Offset: 0x2DB6670 VA: 0x182DB7C70
	public void set_activeFilters(DynamicAtlasFilters value) { }

	// RVA: 0x1E06CB0 Offset: 0x1E056B0 VA: 0x181E06CB0
	public int get_maxSubTextureSize() { }

	// RVA: 0x2DB7D10 Offset: 0x2DB6710 VA: 0x182DB7D10
	public void set_maxSubTextureSize(int value) { }

	// RVA: 0x2DB7C90 Offset: 0x2DB6690 VA: 0x182DB7C90
	public void set_customFilter(DynamicAtlasCustomFilter value) { }

	// RVA: 0x2DB7AF0 Offset: 0x2DB64F0 VA: 0x182DB7AF0
	public void .ctor() { }
}
