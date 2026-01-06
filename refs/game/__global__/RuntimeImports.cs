public static class RuntimeImports // TypeDefIndex: 4268
{
	// Methods

	// RVA: 0x1B1B070 Offset: 0x1B19A70 VA: 0x181B1B070
	internal static void RhZeroMemory(ref byte b, ulong byteLength) { }

	// RVA: 0x1B1B070 Offset: 0x1B19A70 VA: 0x181B1B070
	private static void ZeroMemory(void* p, uint byteLength) { }

	// RVA: 0x1B1B050 Offset: 0x1B19A50 VA: 0x181B1B050
	internal static void Memmove(byte* dest, byte* src, uint len) { }

	// RVA: 0x1B1B060 Offset: 0x1B19A60 VA: 0x181B1B060
	internal static void Memmove_wbarrier(byte* dest, byte* src, uint len, IntPtr type_handle) { }

	// RVA: 0x1B1B080 Offset: 0x1B19A80 VA: 0x181B1B080
	internal static void _ecvt_s(byte* buffer, int sizeInBytes, double value, int count, int* dec, int* sign) { }
}
