public struct BitField32 // TypeDefIndex: 15729
{
	// Fields
	public uint Value; // 0x0

	// Methods

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint initialValue = 0) { }

	// RVA: 0x186E7B0 Offset: 0x186D1B0 VA: 0x18186E7B0
	public void Clear() { }

	// RVA: 0x271B850 Offset: 0x271A250 VA: 0x18271B850
	public void SetBits(int pos, bool value) { }

	// RVA: 0x271B880 Offset: 0x271A280 VA: 0x18271B880
	public void SetBits(int pos, bool value, int numBits) { }

	// RVA: 0x271B820 Offset: 0x271A220 VA: 0x18271B820
	public uint GetBits(int pos, int numBits = 1) { }

	// RVA: 0x271B840 Offset: 0x271A240 VA: 0x18271B840
	public bool IsSet(int pos) { }

	// RVA: 0x271B920 Offset: 0x271A320 VA: 0x18271B920
	public bool TestNone(int pos, int numBits = 1) { }

	// RVA: 0x271B8F0 Offset: 0x271A2F0 VA: 0x18271B8F0
	public bool TestAny(int pos, int numBits = 1) { }

	// RVA: 0x271B8C0 Offset: 0x271A2C0 VA: 0x18271B8C0
	public bool TestAll(int pos, int numBits = 1) { }

	// RVA: 0x271B740 Offset: 0x271A140 VA: 0x18271B740
	public int CountBits() { }

	// RVA: 0x271B780 Offset: 0x271A180 VA: 0x18271B780
	public int CountLeadingZeros() { }

	// RVA: 0x271B7D0 Offset: 0x271A1D0 VA: 0x18271B7D0
	public int CountTrailingZeros() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271B670 Offset: 0x271A070 VA: 0x18271B670
	private static void CheckArgs(int pos, int numBits) { }
}
