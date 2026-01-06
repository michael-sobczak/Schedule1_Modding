internal static class ValidateNames // TypeDefIndex: 8090
{
	// Fields
	private static XmlCharType xmlCharType; // 0x0

	// Methods

	// RVA: 0x252B7E0 Offset: 0x252A1E0 VA: 0x18252B7E0
	internal static int ParseNmtoken(string s, int offset) { }

	// RVA: 0x252B710 Offset: 0x252A110 VA: 0x18252B710
	internal static int ParseNmtokenNoNamespaces(string s, int offset) { }

	// RVA: 0x252B5C0 Offset: 0x2529FC0 VA: 0x18252B5C0
	internal static int ParseNameNoNamespaces(string s, int offset) { }

	// RVA: 0x252B3E0 Offset: 0x2529DE0 VA: 0x18252B3E0
	internal static bool IsNameNoNamespaces(string s) { }

	// RVA: 0x252B4A0 Offset: 0x2529EA0 VA: 0x18252B4A0
	internal static int ParseNCName(string s, int offset) { }

	// RVA: 0x252B450 Offset: 0x2529E50 VA: 0x18252B450
	internal static int ParseNCName(string s) { }

	// RVA: 0x252BA50 Offset: 0x252A450 VA: 0x18252BA50
	internal static int ParseQName(string s, int offset, out int colonOffset) { }

	// RVA: 0x252B8A0 Offset: 0x252A2A0 VA: 0x18252B8A0
	internal static void ParseQNameThrow(string s, out string prefix, out string localName) { }

	// RVA: 0x252BCA0 Offset: 0x252A6A0 VA: 0x18252BCA0
	internal static void ThrowInvalidName(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x252B160 Offset: 0x2529B60 VA: 0x18252B160
	internal static Exception GetInvalidNameException(string s, int offsetStartChar, int offsetBadChar) { }

	// RVA: 0x252BB30 Offset: 0x252A530 VA: 0x18252BB30
	internal static void SplitQName(string name, out string prefix, out string lname) { }

	// RVA: 0x252BE90 Offset: 0x252A890 VA: 0x18252BE90
	private static void .cctor() { }
}
