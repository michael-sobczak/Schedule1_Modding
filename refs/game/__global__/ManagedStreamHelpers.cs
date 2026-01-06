internal static class ManagedStreamHelpers // TypeDefIndex: 11833
{
	// Methods

	// RVA: 0x2CBF110 Offset: 0x2CBDB10 VA: 0x182CBF110
	internal static void ValidateLoadFromStream(Stream stream) { }

	[RequiredByNativeCode]
	// RVA: 0x2CBEF20 Offset: 0x2CBD920 VA: 0x182CBEF20
	internal static void ManagedStreamRead(byte[] buffer, int offset, int count, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x2CBF020 Offset: 0x2CBDA20 VA: 0x182CBF020
	internal static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress) { }

	[RequiredByNativeCode]
	// RVA: 0x2CBEE50 Offset: 0x2CBD850 VA: 0x182CBEE50
	internal static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress) { }
}
