public struct GlyphAdjustmentRecord : IEquatable<GlyphAdjustmentRecord> // TypeDefIndex: 18694
{
	// Fields
	[SerializeField]
	[NativeName("glyphIndex")]
	private uint m_GlyphIndex; // 0x0
	[SerializeField]
	[NativeName("glyphValueRecord")]
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50
	public uint get_glyphIndex() { }

	// RVA: 0x2CFFC90 Offset: 0x2CFE690 VA: 0x182CFFC90
	public GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x18CC830 Offset: 0x18CB230 VA: 0x1818CC830
	public void .ctor(uint glyphIndex, GlyphValueRecord glyphValueRecord) { }

	[ExcludeFromDocs]
	// RVA: 0x2D4A7C0 Offset: 0x2D491C0 VA: 0x182D4A7C0 Slot: 2
	public override int GetHashCode() { }

	[ExcludeFromDocs]
	// RVA: 0x2D4A750 Offset: 0x2D49150 VA: 0x182D4A750 Slot: 0
	public override bool Equals(object obj) { }

	[ExcludeFromDocs]
	// RVA: 0x2D4A6C0 Offset: 0x2D490C0 VA: 0x182D4A6C0 Slot: 4
	public bool Equals(GlyphAdjustmentRecord other) { }
}
