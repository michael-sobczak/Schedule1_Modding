public struct BitField64 // TypeDefIndex: 15731
{
	// Fields
	public ulong Value; // 0x0

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong initialValue = 0) { }

	// RVA: 0xC7BFF0 Offset: 0xC7A9F0 VA: 0x180C7BFF0
	public void Clear() { }

	// RVA: 0x271BC30 Offset: 0x271A630 VA: 0x18271BC30
	public void SetBits(int pos, bool value) { }

	// RVA: 0x271BC60 Offset: 0x271A660 VA: 0x18271BC60
	public void SetBits(int pos, bool value, int numBits = 1) { }

	// RVA: 0x271BBE0 Offset: 0x271A5E0 VA: 0x18271BBE0
	public ulong GetBits(int pos, int numBits = 1) { }

	// RVA: 0x271BC10 Offset: 0x271A610 VA: 0x18271BC10
	public bool IsSet(int pos) { }

	// RVA: 0x271BD00 Offset: 0x271A700 VA: 0x18271BD00
	public bool TestNone(int pos, int numBits = 1) { }

	// RVA: 0x271BCD0 Offset: 0x271A6D0 VA: 0x18271BCD0
	public bool TestAny(int pos, int numBits = 1) { }

	// RVA: 0x271BCA0 Offset: 0x271A6A0 VA: 0x18271BCA0
	public bool TestAll(int pos, int numBits = 1) { }

	// RVA: 0x271BAB0 Offset: 0x271A4B0 VA: 0x18271BAB0
	public int CountBits() { }

	// RVA: 0x271BB10 Offset: 0x271A510 VA: 0x18271BB10
	public int CountLeadingZeros() { }

	// RVA: 0x271BB70 Offset: 0x271A570 VA: 0x18271BB70
	public int CountTrailingZeros() { }

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: 0x271B9E0 Offset: 0x271A3E0 VA: 0x18271B9E0
	private static void CheckArgs(int pos, int numBits) { }
}
