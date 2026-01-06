internal static class IPv6AddressHelper // TypeDefIndex: 9491
{
	// Methods

	// RVA: 0x25F90C0 Offset: 0x25F7AC0 VA: 0x1825F90C0
	internal static ValueTuple<int, int> FindCompressionRange(ReadOnlySpan<ushort> numbers) { }

	// RVA: 0x25FA5A0 Offset: 0x25F8FA0 VA: 0x1825FA5A0
	internal static bool ShouldHaveIpv4Embedded(ReadOnlySpan<ushort> numbers) { }

	// RVA: 0x25F9530 Offset: 0x25F7F30 VA: 0x1825F9530
	internal static bool IsValidStrict(char* name, int start, ref int end) { }

	// RVA: 0x25FA110 Offset: 0x25F8B10 VA: 0x1825FA110
	internal static void Parse(ReadOnlySpan<char> address, ushort* numbers, int start, ref string scopeId) { }

	// RVA: 0x25F98B0 Offset: 0x25F82B0 VA: 0x1825F98B0
	internal static string ParseCanonicalName(string str, int start, ref bool isLoopback, ref string scopeId) { }

	// RVA: 0x25F9450 Offset: 0x25F7E50 VA: 0x1825F9450
	private static bool IsLoopback(ReadOnlySpan<ushort> numbers) { }

	// RVA: 0x25F9190 Offset: 0x25F7B90 VA: 0x1825F9190
	private static bool InternalIsValid(char* name, int start, ref int end, bool validateStrictAddress) { }

	// RVA: 0x25F9890 Offset: 0x25F8290 VA: 0x1825F9890
	internal static bool IsValid(char* name, int start, ref int end) { }
}
