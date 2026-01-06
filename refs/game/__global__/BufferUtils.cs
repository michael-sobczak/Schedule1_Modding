internal static class BufferUtils // TypeDefIndex: 11169
{
	// Methods

	[NullableContext(1)]
	// RVA: 0x1D5B390 Offset: 0x1D59D90 VA: 0x181D5B390
	public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize) { }

	// RVA: 0x1D5B410 Offset: 0x1D59E10 VA: 0x181D5B410
	public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer) { }

	// RVA: 0x1D5B2F0 Offset: 0x1D59CF0 VA: 0x181D5B2F0
	public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer) { }
}
