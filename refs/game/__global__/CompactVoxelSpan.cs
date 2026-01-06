public struct CompactVoxelSpan // TypeDefIndex: 13358
{
	// Fields
	public ushort y; // 0x0
	public uint con; // 0x4
	public uint h; // 0x8
	public int reg; // 0xC

	// Methods

	// RVA: 0xB7D7B0 Offset: 0xB7C1B0 VA: 0x180B7D7B0
	public void .ctor(ushort bottom, uint height) { }

	// RVA: 0xB7D780 Offset: 0xB7C180 VA: 0x180B7D780
	public void SetConnection(int dir, uint value) { }

	// RVA: 0xB7D770 Offset: 0xB7C170 VA: 0x180B7D770
	public int GetConnection(int dir) { }
}
