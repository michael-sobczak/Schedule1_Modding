internal struct MarkToMarkAdjustmentRecord // TypeDefIndex: 18699
{
	// Fields
	[SerializeField]
	[NativeName("baseMarkGlyphID")]
	private uint m_BaseMarkGlyphID; // 0x0
	[SerializeField]
	[NativeName("baseMarkAnchor")]
	private GlyphAnchorPoint m_BaseMarkGlyphAnchorPoint; // 0x4
	[SerializeField]
	[NativeName("combiningMarkGlyphID")]
	private uint m_CombiningMarkGlyphID; // 0xC
	[SerializeField]
	[NativeName("combiningMarkPositionAdjustment")]
	private MarkPositionAdjustment m_CombiningMarkPositionAdjustment; // 0x10

	// Properties
	public uint baseMarkGlyphID { get; }
	public GlyphAnchorPoint baseMarkGlyphAnchorPoint { get; }
	public uint combiningMarkGlyphID { get; }
	public MarkPositionAdjustment combiningMarkPositionAdjustment { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public uint get_baseMarkGlyphID() { }

	// RVA: 0x2D2B1C0 Offset: 0x2D29BC0 VA: 0x182D2B1C0
	public GlyphAnchorPoint get_baseMarkGlyphAnchorPoint() { }

	// RVA: 0x1094770 Offset: 0x1093170 VA: 0x181094770
	public uint get_combiningMarkGlyphID() { }

	// RVA: 0x2D31640 Offset: 0x2D30040 VA: 0x182D31640
	public MarkPositionAdjustment get_combiningMarkPositionAdjustment() { }
}
