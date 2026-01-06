public class TMP_FontFeatureTable // TypeDefIndex: 14919
{
	// Fields
	[SerializeField]
	internal List<MultipleSubstitutionRecord> m_MultipleSubstitutionRecords; // 0x10
	[SerializeField]
	internal List<LigatureSubstitutionRecord> m_LigatureSubstitutionRecords; // 0x18
	[SerializeField]
	internal List<GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecords; // 0x20
	[SerializeField]
	internal List<MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecords; // 0x28
	[SerializeField]
	internal List<MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecords; // 0x30
	internal Dictionary<uint, List<LigatureSubstitutionRecord>> m_LigatureSubstitutionRecordLookup; // 0x38
	internal Dictionary<uint, GlyphPairAdjustmentRecord> m_GlyphPairAdjustmentRecordLookup; // 0x40
	internal Dictionary<uint, MarkToBaseAdjustmentRecord> m_MarkToBaseAdjustmentRecordLookup; // 0x48
	internal Dictionary<uint, MarkToMarkAdjustmentRecord> m_MarkToMarkAdjustmentRecordLookup; // 0x50

	// Properties
	public List<MultipleSubstitutionRecord> multipleSubstitutionRecords { get; set; }
	public List<LigatureSubstitutionRecord> ligatureRecords { get; set; }
	public List<GlyphPairAdjustmentRecord> glyphPairAdjustmentRecords { get; set; }
	public List<MarkToBaseAdjustmentRecord> MarkToBaseAdjustmentRecords { get; set; }
	public List<MarkToMarkAdjustmentRecord> MarkToMarkAdjustmentRecords { get; set; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public List<MultipleSubstitutionRecord> get_multipleSubstitutionRecords() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_multipleSubstitutionRecords(List<MultipleSubstitutionRecord> value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public List<LigatureSubstitutionRecord> get_ligatureRecords() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ligatureRecords(List<LigatureSubstitutionRecord> value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public List<GlyphPairAdjustmentRecord> get_glyphPairAdjustmentRecords() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_glyphPairAdjustmentRecords(List<GlyphPairAdjustmentRecord> value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public List<MarkToBaseAdjustmentRecord> get_MarkToBaseAdjustmentRecords() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_MarkToBaseAdjustmentRecords(List<MarkToBaseAdjustmentRecord> value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public List<MarkToMarkAdjustmentRecord> get_MarkToMarkAdjustmentRecords() { }

	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_MarkToMarkAdjustmentRecords(List<MarkToMarkAdjustmentRecord> value) { }

	// RVA: 0x2BEE000 Offset: 0x2BECA00 VA: 0x182BEE000
	public void .ctor() { }

	// RVA: 0x2BED940 Offset: 0x2BEC340 VA: 0x182BED940
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x2BEDB80 Offset: 0x2BEC580 VA: 0x182BEDB80
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x2BEDDC0 Offset: 0x2BEC7C0 VA: 0x182BEDDC0
	public void SortMarkToMarkAdjustmentRecords() { }
}
