internal static class MiscellaneousUtils // TypeDefIndex: 11186
{
	// Methods

	[NullableContext(2)]
	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void Assert(bool condition, string message) { }

	[NullableContext(2)]
	// RVA: 0x1D6C9C0 Offset: 0x1D6B3C0 VA: 0x181D6C9C0
	public static bool ValueEquals(object objA, object objB) { }

	// RVA: 0x1D6C590 Offset: 0x1D6AF90 VA: 0x181D6C590
	public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message) { }

	// RVA: 0x1D6C920 Offset: 0x1D6B320 VA: 0x181D6C920
	public static string ToString(object value) { }

	// RVA: 0x1D6C4F0 Offset: 0x1D6AEF0 VA: 0x181D6C4F0
	public static int ByteArrayCompare(byte[] a1, byte[] a2) { }

	// RVA: 0x1D6C720 Offset: 0x1D6B120 VA: 0x181D6C720
	public static string GetPrefix(string qualifiedName) { }

	// RVA: 0x1D6C670 Offset: 0x1D6B070 VA: 0x181D6C670
	public static string GetLocalName(string qualifiedName) { }

	// RVA: 0x1D6C7D0 Offset: 0x1D6B1D0 VA: 0x181D6C7D0
	public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName) { }

	// RVA: 0x1D6C890 Offset: 0x1D6B290 VA: 0x181D6C890
	internal static RegexOptions GetRegexOptions(string optionsText) { }
}
