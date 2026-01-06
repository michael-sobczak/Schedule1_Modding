public static class Buffer // TypeDefIndex: 3801
{
	// Methods

	// RVA: 0x1C9A970 Offset: 0x1C99370 VA: 0x181C9A970
	internal static bool InternalBlockCopy(Array src, int srcOffsetBytes, Array dst, int dstOffsetBytes, int byteCount) { }

	// RVA: 0x1C9A8C0 Offset: 0x1C992C0 VA: 0x181C9A8C0
	internal static int IndexOfByte(byte* src, byte value, int index, int count) { }

	// RVA: 0x1C9AE50 Offset: 0x1C99850 VA: 0x181C9AE50
	private static int _ByteLength(Array array) { }

	// RVA: 0x1C9AE30 Offset: 0x1C99830 VA: 0x181C9AE30
	internal static void ZeroMemory(byte* src, long len) { }

	[ReliabilityContract(3, 2)]
	// RVA: 0x1C9AC80 Offset: 0x1C99680 VA: 0x181C9AC80
	internal static void Memcpy(byte* pDest, int destIndex, byte[] src, int srcIndex, int len) { }

	// RVA: 0x1C9A980 Offset: 0x1C99380 VA: 0x181C9A980
	internal static void InternalMemcpy(byte* dest, byte* src, int count) { }

	// RVA: 0x1C9A810 Offset: 0x1C99210 VA: 0x181C9A810
	public static int ByteLength(Array array) { }

	// RVA: 0x1C9A580 Offset: 0x1C98F80 VA: 0x181C9A580
	public static void BlockCopy(Array src, int srcOffset, Array dst, int dstOffset, int count) { }

	[CLSCompliant(False)]
	// RVA: 0x1C9AD00 Offset: 0x1C99700 VA: 0x181C9AD00
	public static void MemoryCopy(void* source, void* destination, long destinationSizeInBytes, long sourceBytesToCopy) { }

	// RVA: 0x1C9AF90 Offset: 0x1C99990 VA: 0x181C9AF90
	internal static void memcpy4(byte* dest, byte* src, int size) { }

	// RVA: 0x1C9AF10 Offset: 0x1C99910 VA: 0x181C9AF10
	internal static void memcpy2(byte* dest, byte* src, int size) { }

	// RVA: 0x1C9AE60 Offset: 0x1C99860 VA: 0x181C9AE60
	private static void memcpy1(byte* dest, byte* src, int size) { }

	// RVA: 0x1C9A990 Offset: 0x1C99390 VA: 0x181C9A990
	internal static void Memcpy(byte* dest, byte* src, int len) { }

	// RVA: 0x1C9ACD0 Offset: 0x1C996D0 VA: 0x181C9ACD0
	internal static void Memmove(byte* dest, byte* src, uint len) { }

	// RVA: -1 Offset: -1
	internal static void Memmove<T>(ref T destination, ref T source, ulong elementCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5AAE0 Offset: 0xE594E0 VA: 0x180E5AAE0
	|-Buffer.Memmove<byte>
	|
	|-RVA: 0xE5AAF0 Offset: 0xE594F0 VA: 0x180E5AAF0
	|-Buffer.Memmove<char>
	|-Buffer.Memmove<ushort>
	|
	|-RVA: 0xE5ABF0 Offset: 0xE595F0 VA: 0x180E5ABF0
	|-Buffer.Memmove<int>
	|-Buffer.Memmove<uint>
	|
	|-RVA: 0xE5AB00 Offset: 0xE59500 VA: 0x180E5AB00
	|-Buffer.Memmove<__Il2CppFullySharedGenericType>
	|
	|-RVA: 0xE5AC00 Offset: 0xE59600 VA: 0x180E5AC00
	|-Buffer.Memmove<jvalue>
	*/
}
