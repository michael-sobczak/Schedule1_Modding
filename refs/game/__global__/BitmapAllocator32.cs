internal struct BitmapAllocator32 // TypeDefIndex: 7148
{
	// Fields
	private int m_PageHeight; // 0x0
	private List<BitmapAllocator32.Page> m_Pages; // 0x8
	private List<uint> m_AllocMap; // 0x10
	private int m_EntryWidth; // 0x18
	private int m_EntryHeight; // 0x1C

	// Properties
	public int entryWidth { get; }
	public int entryHeight { get; }

	// Methods

	// RVA: 0x2E13120 Offset: 0x2E11B20 VA: 0x182E13120
	public void Construct(int pageHeight, int entryWidth = 1, int entryHeight = 1) { }

	// RVA: 0x2E132C0 Offset: 0x2E11CC0 VA: 0x182E132C0
	public void ForceFirstAlloc(ushort firstPageX, ushort firstPageY) { }

	// RVA: 0x2E12C80 Offset: 0x2E11680 VA: 0x182E12C80
	public BMPAlloc Allocate(BaseShaderInfoStorage storage) { }

	// RVA: 0x2E13470 Offset: 0x2E11E70 VA: 0x182E13470
	public void Free(BMPAlloc alloc) { }

	// RVA: 0x10EB2A0 Offset: 0x10E9CA0 VA: 0x1810EB2A0
	public int get_entryWidth() { }

	// RVA: 0x180D280 Offset: 0x180BC80 VA: 0x18180D280
	public int get_entryHeight() { }

	// RVA: 0x2E135B0 Offset: 0x2E11FB0 VA: 0x182E135B0
	internal void GetAllocPageAtlasLocation(int page, out ushort x, out ushort y) { }

	// RVA: 0x2E13240 Offset: 0x2E11C40 VA: 0x182E13240
	private static byte CountTrailingZeroes(uint val) { }
}
