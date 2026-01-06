internal sealed class InflateCodes // TypeDefIndex: 16657
{
	// Fields
	private const int START = 0;
	private const int LEN = 1;
	private const int LENEXT = 2;
	private const int DIST = 3;
	private const int DISTEXT = 4;
	private const int COPY = 5;
	private const int LIT = 6;
	private const int WASH = 7;
	private const int END = 8;
	private const int BADCODE = 9;
	internal int mode; // 0x10
	internal int len; // 0x14
	internal int[] tree; // 0x18
	internal int tree_index; // 0x20
	internal int need; // 0x24
	internal int lit; // 0x28
	internal int bitsToGet; // 0x2C
	internal int dist; // 0x30
	internal byte lbits; // 0x34
	internal byte dbits; // 0x35
	internal int[] ltree; // 0x38
	internal int ltree_index; // 0x40
	internal int[] dtree; // 0x48
	internal int dtree_index; // 0x50

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x1E715A0 Offset: 0x1E6FFA0 VA: 0x181E715A0
	internal void Init(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index) { }

	// RVA: 0x1E71600 Offset: 0x1E70000 VA: 0x181E71600
	internal int Process(InflateBlocks blocks, int r) { }

	// RVA: 0x1E70BD0 Offset: 0x1E6F5D0 VA: 0x181E70BD0
	internal int InflateFast(int bl, int bd, int[] tl, int tl_index, int[] td, int td_index, InflateBlocks s, ZlibCodec z) { }
}
