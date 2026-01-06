public struct TMP_GlyphAdjustmentRecord // TypeDefIndex: 14915
{
	// Fields
	[SerializeField]
	internal uint m_GlyphIndex; // 0x0
	[SerializeField]
	internal TMP_GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; set; }
	public TMP_GlyphValueRecord glyphValueRecord { get; set; }

	// Methods

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public uint get_glyphIndex() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_glyphIndex(uint value) { }

	// RVA: 0x109F680 Offset: 0x109E080 VA: 0x18109F680
	public TMP_GlyphValueRecord get_glyphValueRecord() { }

	// RVA: 0x2BEE8E0 Offset: 0x2BED2E0 VA: 0x182BEE8E0
	public void set_glyphValueRecord(TMP_GlyphValueRecord value) { }

	// RVA: 0x18CC830 Offset: 0x18CB230 VA: 0x1818CC830
	public void .ctor(uint glyphIndex, TMP_GlyphValueRecord glyphValueRecord) { }

	// RVA: 0x2BEE810 Offset: 0x2BED210 VA: 0x182BEE810
	internal void .ctor(GlyphAdjustmentRecord adjustmentRecord) { }
}
