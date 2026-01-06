public class TMP_GlyphPairAdjustmentRecord // TypeDefIndex: 14916
{
	// Fields
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_FirstAdjustmentRecord; // 0x10
	[SerializeField]
	internal TMP_GlyphAdjustmentRecord m_SecondAdjustmentRecord; // 0x24
	[SerializeField]
	internal FontFeatureLookupFlags m_FeatureLookupFlags; // 0x38

	// Properties
	public TMP_GlyphAdjustmentRecord firstAdjustmentRecord { get; set; }
	public TMP_GlyphAdjustmentRecord secondAdjustmentRecord { get; set; }
	public FontFeatureLookupFlags featureLookupFlags { get; set; }

	// Methods

	// RVA: 0x167B3A0 Offset: 0x1679DA0 VA: 0x18167B3A0
	public TMP_GlyphAdjustmentRecord get_firstAdjustmentRecord() { }

	// RVA: 0x2BEEB10 Offset: 0x2BED510 VA: 0x182BEEB10
	public void set_firstAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x2BEEAF0 Offset: 0x2BED4F0 VA: 0x182BEEAF0
	public TMP_GlyphAdjustmentRecord get_secondAdjustmentRecord() { }

	// RVA: 0x2BEEB20 Offset: 0x2BED520 VA: 0x182BEEB20
	public void set_secondAdjustmentRecord(TMP_GlyphAdjustmentRecord value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public FontFeatureLookupFlags get_featureLookupFlags() { }

	// RVA: 0x4E2930 Offset: 0x4E1330 VA: 0x1804E2930
	public void set_featureLookupFlags(FontFeatureLookupFlags value) { }

	// RVA: 0x2BEE8F0 Offset: 0x2BED2F0 VA: 0x182BEE8F0
	public void .ctor(TMP_GlyphAdjustmentRecord firstAdjustmentRecord, TMP_GlyphAdjustmentRecord secondAdjustmentRecord) { }

	// RVA: 0x2BEE940 Offset: 0x2BED340 VA: 0x182BEE940
	internal void .ctor(GlyphPairAdjustmentRecord glyphPairAdjustmentRecord) { }
}
