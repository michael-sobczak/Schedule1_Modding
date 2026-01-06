public class KerningTable // TypeDefIndex: 14910
{
	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0x2BEC690 Offset: 0x2BEB090 VA: 0x182BEC690
	public void .ctor() { }

	// RVA: 0x2BEC190 Offset: 0x2BEAB90 VA: 0x182BEC190
	public void AddKerningPair() { }

	// RVA: 0x2BEC030 Offset: 0x2BEAA30 VA: 0x182BEC030
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0x2BEBEC0 Offset: 0x2BEA8C0 VA: 0x182BEBEC0
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0x2BEC2E0 Offset: 0x2BEACE0 VA: 0x182BEC2E0
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0x2BEC3F0 Offset: 0x2BEADF0 VA: 0x182BEC3F0
	public void RemoveKerningPair(int index) { }

	// RVA: 0x2BEC450 Offset: 0x2BEAE50 VA: 0x182BEC450
	public void SortKerningPairs() { }
}
