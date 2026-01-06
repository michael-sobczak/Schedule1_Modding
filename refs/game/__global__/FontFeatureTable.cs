public class FontFeatureTable // TypeDefIndex: 16708
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

	// Methods

	// RVA: 0x2D56550 Offset: 0x2D54F50 VA: 0x182D56550
	internal void .ctor() { }

	// RVA: 0x2D55E90 Offset: 0x2D54890 VA: 0x182D55E90
	public void SortGlyphPairAdjustmentRecords() { }

	// RVA: 0x2D560D0 Offset: 0x2D54AD0 VA: 0x182D560D0
	public void SortMarkToBaseAdjustmentRecords() { }

	// RVA: 0x2D56310 Offset: 0x2D54D10 VA: 0x182D56310
	public void SortMarkToMarkAdjustmentRecords() { }
}
