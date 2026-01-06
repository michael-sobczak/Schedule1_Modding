internal struct DynamicBitfield // TypeDefIndex: 7456
{
	// Fields
	public InlinedArray<ulong> array; // 0x0
	public int length; // 0x18

	// Methods

	// RVA: 0x281F810 Offset: 0x281E210 VA: 0x18281F810
	public void SetLength(int newLength) { }

	// RVA: 0x281F780 Offset: 0x281E180 VA: 0x18281F780
	public void SetBit(int bitIndex) { }

	// RVA: 0x281F870 Offset: 0x281E270 VA: 0x18281F870
	public bool TestBit(int bitIndex) { }

	// RVA: 0x281F6F0 Offset: 0x281E0F0 VA: 0x18281F6F0
	public void ClearBit(int bitIndex) { }

	// RVA: 0x281F670 Offset: 0x281E070 VA: 0x18281F670
	public bool AnyBitIsSet() { }

	// RVA: 0x281F6E0 Offset: 0x281E0E0 VA: 0x18281F6E0
	private static int BitCountToULongCount(int bitCount) { }
}
