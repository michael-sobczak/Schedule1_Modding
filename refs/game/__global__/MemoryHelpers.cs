internal static class MemoryHelpers // TypeDefIndex: 7820
{
	// Methods

	// RVA: 0x278D640 Offset: 0x278C040 VA: 0x18278D640
	public static bool Compare(void* ptr1, void* ptr2, MemoryHelpers.BitRegion region) { }

	// RVA: 0x278D6C0 Offset: 0x278C0C0 VA: 0x18278D6C0
	public static uint ComputeFollowingByteOffset(uint byteOffset, uint sizeInBits) { }

	// RVA: 0x278E130 Offset: 0x278CB30 VA: 0x18278E130
	public static void WriteSingleBit(void* ptr, uint bitOffset, bool value) { }

	// RVA: 0x278DDB0 Offset: 0x278C7B0 VA: 0x18278DDB0
	public static bool ReadSingleBit(void* ptr, uint bitOffset) { }

	// RVA: 0x278D860 Offset: 0x278C260 VA: 0x18278D860
	public static void MemCpyBitRegion(void* destination, void* source, uint bitOffset, uint bitCount) { }

	// RVA: 0x278D6E0 Offset: 0x278C0E0 VA: 0x18278D6E0
	public static bool MemCmpBitRegion(void* ptr1, void* ptr2, uint bitOffset, uint bitCount, void* mask) { }

	// RVA: 0x278DA70 Offset: 0x278C470 VA: 0x18278DA70
	public static void MemSet(void* destination, int numBytes, byte value) { }

	// RVA: 0x278D960 Offset: 0x278C360 VA: 0x18278D960
	public static void MemCpyMasked(void* destination, void* source, int numBytes, void* mask) { }

	// RVA: 0x278DBE0 Offset: 0x278C5E0 VA: 0x18278DBE0
	public static uint ReadMultipleBitsAsUInt(void* ptr, uint bitOffset, uint bitCount) { }

	// RVA: 0x278E160 Offset: 0x278CB60 VA: 0x18278E160
	public static void WriteUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, uint value) { }

	// RVA: 0x278DDE0 Offset: 0x278C7E0 VA: 0x18278DDE0
	public static int ReadTwosComplementMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount) { }

	// RVA: 0x278E0B0 Offset: 0x278CAB0 VA: 0x18278E0B0
	public static void WriteIntAsTwosComplementMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value) { }

	// RVA: 0x278DB40 Offset: 0x278C540 VA: 0x18278DB40
	public static int ReadExcessKMultipleBitsAsInt(void* ptr, uint bitOffset, uint bitCount) { }

	// RVA: 0x278E080 Offset: 0x278CA80 VA: 0x18278E080
	public static void WriteIntAsExcessKMultipleBits(void* ptr, uint bitOffset, uint bitCount, int value) { }

	// RVA: 0x278DB70 Offset: 0x278C570 VA: 0x18278DB70
	public static float ReadMultipleBitsAsNormalizedUInt(void* ptr, uint bitOffset, uint bitCount) { }

	// RVA: 0x278E0C0 Offset: 0x278CAC0 VA: 0x18278E0C0
	public static void WriteNormalizedUIntAsMultipleBits(void* ptr, uint bitOffset, uint bitCount, float value) { }

	// RVA: 0x278DDF0 Offset: 0x278C7F0 VA: 0x18278DDF0
	public static void SetBitsInBuffer(void* buffer, int byteOffset, int bitOffset, int sizeInBits, bool value) { }

	// RVA: -1 Offset: -1
	public static void Swap<TValue>(ref TValue a, ref TValue b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4B9E0 Offset: 0xE4A3E0 VA: 0x180E4B9E0
	|-MemoryHelpers.Swap<object>
	|
	|-RVA: 0xEFF930 Offset: 0xEFE330 VA: 0x180EFF930
	|-MemoryHelpers.Swap<float>
	|
	|-RVA: 0xE4B840 Offset: 0xE4A240 VA: 0x180E4B840
	|-MemoryHelpers.Swap<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xEFF940 Offset: 0xEFE340 VA: 0x180EFF940
	|-MemoryHelpers.Swap<InputManager.StateChangeMonitorListener>
	|
	|-RVA: 0xEFF920 Offset: 0xEFE320 VA: 0x180EFF920
	|-MemoryHelpers.Swap<MemoryHelpers.BitRegion>
	*/

	// RVA: 0x278D5C0 Offset: 0x278BFC0 VA: 0x18278D5C0
	public static uint AlignNatural(uint offset, uint sizeInBytes) { }
}
