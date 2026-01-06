internal struct Bitwise // TypeDefIndex: 15728
{
	// Methods

	// RVA: 0x271BD30 Offset: 0x271A730 VA: 0x18271BD30
	internal static int AlignDown(int value, int alignPow2) { }

	// RVA: 0x271BD40 Offset: 0x271A740 VA: 0x18271BD40
	internal static int AlignUp(int value, int alignPow2) { }

	// RVA: 0xDA30B0 Offset: 0xDA1AB0 VA: 0x180DA30B0
	internal static int FromBool(bool value) { }

	// RVA: 0x271BD60 Offset: 0x271A760 VA: 0x18271BD60
	internal static uint ExtractBits(uint input, int pos, uint mask) { }

	// RVA: 0x271CE40 Offset: 0x271B840 VA: 0x18271CE40
	internal static uint ReplaceBits(uint input, int pos, uint mask, uint value) { }

	// RVA: 0x271CE60 Offset: 0x271B860 VA: 0x18271CE60
	internal static uint SetBits(uint input, int pos, uint mask, bool value) { }

	// RVA: 0x271BD50 Offset: 0x271A750 VA: 0x18271BD50
	internal static ulong ExtractBits(ulong input, int pos, ulong mask) { }

	// RVA: 0x271CE10 Offset: 0x271B810 VA: 0x18271CE10
	internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value) { }

	// RVA: 0x271CE90 Offset: 0x271B890 VA: 0x18271CE90
	internal static ulong SetBits(ulong input, int pos, ulong mask, bool value) { }

	// RVA: 0x271CEC0 Offset: 0x271B8C0 VA: 0x18271CEC0
	internal static int lzcnt(byte value) { }

	// RVA: 0x271CF60 Offset: 0x271B960 VA: 0x18271CF60
	internal static int tzcnt(byte value) { }

	// RVA: 0x271CF10 Offset: 0x271B910 VA: 0x18271CF10
	internal static int lzcnt(ushort value) { }

	// RVA: 0x271CFB0 Offset: 0x271B9B0 VA: 0x18271CFB0
	internal static int tzcnt(ushort value) { }

	// RVA: 0x271C080 Offset: 0x271AA80 VA: 0x18271C080
	private static int FindUlong(ulong* ptr, int beginBit, int endBit, int numBits) { }

	// RVA: 0x271BED0 Offset: 0x271A8D0 VA: 0x18271BED0
	private static int FindUint(ulong* ptr, int beginBit, int endBit, int numBits) { }

	// RVA: 0x271C4E0 Offset: 0x271AEE0 VA: 0x18271C4E0
	private static int FindUshort(ulong* ptr, int beginBit, int endBit, int numBits) { }

	// RVA: 0x271BD70 Offset: 0x271A770 VA: 0x18271BD70
	private static int FindByte(ulong* ptr, int beginBit, int endBit, int numBits) { }

	// RVA: 0x271C260 Offset: 0x271AC60 VA: 0x18271C260
	private static int FindUpto14bits(ulong* ptr, int beginBit, int endBit, int numBits) { }

	// RVA: 0x271C390 Offset: 0x271AD90 VA: 0x18271C390
	private static int FindUpto6bits(ulong* ptr, int beginBit, int endBit, int numBits) { }

	// RVA: 0x271C630 Offset: 0x271B030 VA: 0x18271C630
	internal static int FindWithBeginEnd(ulong* ptr, int beginBit, int endBit, int numBits) { }

	// RVA: 0x271CDF0 Offset: 0x271B7F0 VA: 0x18271CDF0
	internal static int Find(ulong* ptr, int pos, int count, int numBits) { }
}
