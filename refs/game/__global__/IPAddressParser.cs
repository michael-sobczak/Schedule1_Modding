internal class IPAddressParser // TypeDefIndex: 9935
{
	// Methods

	// RVA: 0x26A8740 Offset: 0x26A7140 VA: 0x1826A8740
	internal static IPAddress Parse(ReadOnlySpan<char> ipSpan, bool tryParse) { }

	// RVA: 0x26A7F50 Offset: 0x26A6950 VA: 0x1826A7F50
	internal static string IPv4AddressToString(uint address) { }

	// RVA: 0x26A7FB0 Offset: 0x26A69B0 VA: 0x1826A7FB0
	internal static void IPv4AddressToString(uint address, StringBuilder destination) { }

	// RVA: 0x26A7D00 Offset: 0x26A6700 VA: 0x1826A7D00
	private static int IPv4AddressToStringHelper(uint address, char* addressString) { }

	// RVA: 0x26A84D0 Offset: 0x26A6ED0 VA: 0x1826A84D0
	internal static string IPv6AddressToString(ushort[] address, uint scopeId) { }

	// RVA: 0x26A8020 Offset: 0x26A6A20 VA: 0x1826A8020
	internal static StringBuilder IPv6AddressToStringHelper(ushort[] address, uint scopeId) { }

	// RVA: 0x26A7C40 Offset: 0x26A6640 VA: 0x1826A7C40
	private static void FormatIPv4AddressNumber(int number, char* addressString, ref int offset) { }

	// RVA: 0x26A84F0 Offset: 0x26A6EF0 VA: 0x1826A84F0
	public static bool Ipv4StringToAddress(ReadOnlySpan<char> ipSpan, out long address) { }

	// RVA: 0x26A85D0 Offset: 0x26A6FD0 VA: 0x1826A85D0
	public static bool Ipv6StringToAddress(ReadOnlySpan<char> ipSpan, ushort* numbers, int numbersLength, out uint scope) { }

	// RVA: 0x26A7A10 Offset: 0x26A6410 VA: 0x1826A7A10
	private static void AppendSections(ushort[] address, int fromInclusive, int toExclusive, StringBuilder buffer) { }

	// RVA: 0x26A7960 Offset: 0x26A6360 VA: 0x1826A7960
	private static void AppendHex(ushort value, StringBuilder buffer) { }

	// RVA: 0x26A7BF0 Offset: 0x26A65F0 VA: 0x1826A7BF0
	private static uint ExtractIPv4Address(ushort[] address) { }

	// RVA: 0x1C0AE20 Offset: 0x1C09820 VA: 0x181C0AE20
	private static ushort Reverse(ushort number) { }
}
