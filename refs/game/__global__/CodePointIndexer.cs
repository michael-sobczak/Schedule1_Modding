internal class CodePointIndexer // TypeDefIndex: 3493
{
	// Fields
	private readonly CodePointIndexer.TableRange[] ranges; // 0x10
	public readonly int TotalCount; // 0x18
	private int defaultIndex; // 0x1C
	private int defaultCP; // 0x20

	// Methods

	// RVA: 0x1A84B10 Offset: 0x1A83510 VA: 0x181A84B10
	public void .ctor(int[] starts, int[] ends, int defaultIndex, int defaultCP) { }

	// RVA: 0x1A84A90 Offset: 0x1A83490 VA: 0x181A84A90
	public int ToIndex(int cp) { }
}
