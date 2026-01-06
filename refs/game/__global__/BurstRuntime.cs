public static class BurstRuntime // TypeDefIndex: 16299
{
	// Methods

	// RVA: -1 Offset: -1
	public static int GetHashCode32<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B0D0 Offset: 0xE59AD0 VA: 0x180E5B0D0
	|-BurstRuntime.GetHashCode32<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x26DAED0 Offset: 0x26D98D0 VA: 0x1826DAED0
	public static int GetHashCode32(Type type) { }

	// RVA: -1 Offset: -1
	public static long GetHashCode64<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE5B150 Offset: 0xE59B50 VA: 0x180E5B150
	|-BurstRuntime.GetHashCode64<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x26DAF60 Offset: 0x26D9960 VA: 0x1826DAF60
	public static long GetHashCode64(Type type) { }

	// RVA: 0x26DB050 Offset: 0x26D9A50 VA: 0x1826DB050
	internal static int HashStringWithFNV1A32(string text) { }

	// RVA: 0x26DB0C0 Offset: 0x26D9AC0 VA: 0x1826DB0C0
	internal static long HashStringWithFNV1A64(string text) { }

	// RVA: 0x26DB2B0 Offset: 0x26D9CB0 VA: 0x1826DB2B0
	public static bool LoadAdditionalLibrary(string pathToLibBurstGenerated) { }

	// RVA: 0x26DB150 Offset: 0x26D9B50 VA: 0x1826DB150
	internal static bool LoadAdditionalLibraryInternal(string pathToLibBurstGenerated) { }

	[Preserve]
	// RVA: 0x26DB5A0 Offset: 0x26D9FA0 VA: 0x1826DB5A0
	internal static void RuntimeLog(byte* message, int logType, byte* fileName, int lineNumber) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void Initialize() { }

	[Preserve]
	// RVA: 0x26DB4C0 Offset: 0x26D9EC0 VA: 0x1826DB4C0
	internal static void PreventRequiredAttributeStrip() { }

	[Preserve]
	// RVA: 0x26DB490 Offset: 0x26D9E90 VA: 0x1826DB490
	internal static void Log(byte* message, int logType, byte* fileName, int lineNumber) { }

	// RVA: 0x26DB000 Offset: 0x26D9A00 VA: 0x1826DB000
	public static byte* GetUTF8LiteralPointer(string str, out int byteCount) { }
}
