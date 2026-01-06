internal class DomainNameHelper // TypeDefIndex: 9516
{
	// Methods

	// RVA: 0x2613DC0 Offset: 0x26127C0 VA: 0x182613DC0
	internal static string ParseCanonicalName(string str, int start, int end, ref bool loopback) { }

	// RVA: 0x2613C50 Offset: 0x2612650 VA: 0x182613C50
	internal static bool IsValid(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x2613A40 Offset: 0x2612440 VA: 0x182613A40
	internal static bool IsValidByIri(char* name, ushort pos, ref int returnedEnd, ref bool notCanonical, bool notImplicitFile) { }

	// RVA: 0x2613580 Offset: 0x2611F80 VA: 0x182613580
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x26137E0 Offset: 0x26121E0 VA: 0x1826137E0
	internal static string IdnEquivalent(char* hostname, int start, int end, ref bool allAscii, ref string bidiStrippedHost) { }

	// RVA: 0x2613990 Offset: 0x2612390 VA: 0x182613990
	private static bool IsIdnAce(string input, int index) { }

	// RVA: 0x2613A10 Offset: 0x2612410 VA: 0x182613A10
	private static bool IsIdnAce(char* input, int index) { }

	// RVA: 0x2613F40 Offset: 0x2612940 VA: 0x182613F40
	internal static string UnicodeEquivalent(string idnHost, char* hostname, int start, int end) { }

	// RVA: 0x2613FF0 Offset: 0x26129F0 VA: 0x182613FF0
	internal static string UnicodeEquivalent(char* hostname, int start, int end, ref bool allAscii, ref bool atLeastOneValidIdn) { }

	// RVA: 0x2613960 Offset: 0x2612360 VA: 0x182613960
	private static bool IsASCIILetterOrDigit(char character, ref bool notCanonical) { }

	// RVA: 0x2613C10 Offset: 0x2612610 VA: 0x182613C10
	private static bool IsValidDomainLabelCharacter(char character, ref bool notCanonical) { }
}
