internal static class FixedBufferExtensions // TypeDefIndex: 3764
{
	// Methods

	[Extension]
	// RVA: 0x1C80330 Offset: 0x1C7ED30 VA: 0x181C80330
	internal static string GetStringFromFixedBuffer(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x1C802D0 Offset: 0x1C7ECD0 VA: 0x181C802D0
	internal static int GetFixedBufferStringLength(ReadOnlySpan<char> span) { }

	[Extension]
	// RVA: 0x1C80200 Offset: 0x1C7EC00 VA: 0x181C80200
	internal static bool FixedBufferEqualsString(ReadOnlySpan<char> span, string value) { }
}
