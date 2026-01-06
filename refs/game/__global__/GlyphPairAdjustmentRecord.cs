public struct GlyphPairAdjustmentRecord : IEquatable<GlyphPairAdjustmentRecord> // TypeDefIndex: 18695
{
	// Fields
	[SerializeField]
	[NativeName("firstAdjustmentRecord")]
	private GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x0
	[SerializeField]
	[NativeName("secondAdjustmentRecord")]
	private GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x14
	[SerializeField]
	private FontFeatureLookupFlags m_FeatureLookupFlags; // 0x28

	// Properties
	public GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public GlyphAdjustmentRecord secondAdjustmentRecord { get; }
	public FontFeatureLookupFlags featureLookupFlags { get; }

	// Methods

	// RVA: 0x2D4AB90 Offset: 0x2D49590 VA: 0x182D4AB90
	public GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x281EAA0 Offset: 0x281D4A0 VA: 0x18281EAA0
	public void set_firstAdjustmentRecord(GlyphAdjustmentRecord value) { }

	// RVA: 0x1670D10 Offset: 0x166F710 VA: 0x181670D10
	public GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x1263FC0 Offset: 0x12629C0 VA: 0x181263FC0
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x2D4AB60 Offset: 0x2D49560 VA: 0x182D4AB60
	public void .ctor(GlyphAdjustmentRecord firstAdjustmentRecord, GlyphAdjustmentRecord secondAdjustmentRecord) { }

	[ExcludeFromDocs]
	// RVA: 0x2D4AAF0 Offset: 0x2D494F0 VA: 0x182D4AAF0 Slot: 2
	public override int GetHashCode() { }

	[ExcludeFromDocs]
	// RVA: 0x2D4A9B0 Offset: 0x2D493B0 VA: 0x182D4A9B0 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x2D4AA30 Offset: 0x2D49430 VA: 0x182D4AA30 Slot: 4
	public bool Equals(GlyphPairAdjustmentRecord other) { }
}
