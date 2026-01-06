internal static class RuntimeMarshal // TypeDefIndex: 3469
{
	// Methods

	// RVA: 0x1A8E1B0 Offset: 0x1A8CBB0 VA: 0x181A8E1B0
	internal static string PtrToUtf8String(IntPtr ptr) { }

	// RVA: 0x1A8E180 Offset: 0x1A8CB80 VA: 0x181A8E180
	internal static SafeStringMarshal MarshalString(string str) { }

	// RVA: 0x1A8E0F0 Offset: 0x1A8CAF0 VA: 0x181A8E0F0
	private static int DecodeBlobSize(IntPtr in_ptr, out IntPtr out_ptr) { }

	// RVA: 0x1A8DFF0 Offset: 0x1A8C9F0 VA: 0x181A8DFF0
	internal static byte[] DecodeBlobArray(IntPtr ptr) { }

	// RVA: 0x1A8DFC0 Offset: 0x1A8C9C0 VA: 0x181A8DFC0
	internal static int AsciHexDigitValue(int c) { }

	// RVA: 0x1A8E170 Offset: 0x1A8CB70 VA: 0x181A8E170
	internal static void FreeAssemblyName(ref MonoAssemblyName name, bool freeStruct) { }
}
