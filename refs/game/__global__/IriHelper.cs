internal static class IriHelper // TypeDefIndex: 9497
{
	// Methods

	// RVA: 0x25FAE60 Offset: 0x25F9860 VA: 0x1825FAE60
	internal static bool CheckIriUnicodeRange(char unicode, bool isQuery) { }

	// RVA: 0x25FA8E0 Offset: 0x25F92E0 VA: 0x1825FA8E0
	internal static bool CheckIriUnicodeRange(char highSurr, char lowSurr, ref bool surrogatePair, bool isQuery) { }

	// RVA: 0x25FAEC0 Offset: 0x25F98C0 VA: 0x1825FAEC0
	internal static bool CheckIsReserved(char ch, UriComponents component) { }

	// RVA: 0x25FAFD0 Offset: 0x25F99D0 VA: 0x1825FAFD0
	internal static string EscapeUnescapeIri(char* pInput, int start, int end, UriComponents component) { }
}
