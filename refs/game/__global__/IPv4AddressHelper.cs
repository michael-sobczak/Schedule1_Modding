internal static class IPv4AddressHelper // TypeDefIndex: 9490
{
	// Methods

	// RVA: 0x25F8CC0 Offset: 0x25F76C0 VA: 0x1825F8CC0
	internal static int ParseHostNumber(ReadOnlySpan<char> str, int start, int end) { }

	// RVA: 0x25F87E0 Offset: 0x25F71E0 VA: 0x1825F87E0
	internal static bool IsValid(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile, bool unknownScheme) { }

	// RVA: 0x25F8C30 Offset: 0x25F7630 VA: 0x1825F8C30
	private static bool ParseCanonical(ReadOnlySpan<char> name, byte* numbers, int start, int end) { }

	// RVA: 0x25F86A0 Offset: 0x25F70A0 VA: 0x1825F86A0
	internal static bool IsValidCanonical(char* name, int start, ref int end, bool allowIPv6, bool notImplicitFile) { }

	// RVA: 0x25F8D90 Offset: 0x25F7790 VA: 0x1825F8D90
	internal static long ParseNonCanonical(char* name, int start, ref int end, bool notImplicitFile) { }

	// RVA: 0x25F8970 Offset: 0x25F7370 VA: 0x1825F8970
	internal static string ParseCanonicalName(string str, int start, int end, ref bool isLoopback) { }

	// RVA: 0x25F9030 Offset: 0x25F7A30 VA: 0x1825F9030
	private static bool Parse(string name, byte* numbers, int start, int end) { }
}
