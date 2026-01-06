internal struct MarkToBaseAdjustmentRecord // TypeDefIndex: 18698
{
	// Fields
	[NativeName("baseGlyphID")]
	[SerializeField]
	private uint m_BaseGlyphID; // 0x0
	[NativeName("baseAnchor")]
	[SerializeField]
	private GlyphAnchorPoint m_BaseGlyphAnchorPoint; // 0x4
	[SerializeField]
	[NativeName("markGlyphID")]
	private uint m_MarkGlyphID; // 0xC
	[NativeName("markPositionAdjustment")]
	[SerializeField]
	private MarkPositionAdjustment m_MarkPositionAdjustment; // 0x10

	// Properties
	public uint baseGlyphID { get; }
	public GlyphAnchorPoint baseGlyphAnchorPoint { get; }
	public uint markGlyphID { get; }
	public MarkPositionAdjustment markPositionAdjustment { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public uint get_baseGlyphID() { }

	// RVA: 0x2D2B1C0 Offset: 0x2D29BC0 VA: 0x182D2B1C0
	public GlyphAnchorPoint get_baseGlyphAnchorPoint() { }

	// RVA: 0x1094770 Offset: 0x1093170 VA: 0x181094770
	public uint get_markGlyphID() { }

	// RVA: 0x2D31640 Offset: 0x2D30040 VA: 0x182D31640
	public MarkPositionAdjustment get_markPositionAdjustment() { }
}
