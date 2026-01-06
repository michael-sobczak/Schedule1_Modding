internal static class MailBnfHelper // TypeDefIndex: 10215
{
	// Fields
	internal static readonly bool[] Atext; // 0x0
	internal static readonly bool[] Qtext; // 0x8
	internal static readonly bool[] Dtext; // 0x10
	internal static readonly bool[] Ftext; // 0x18
	internal static readonly bool[] Ttext; // 0x20
	internal static readonly bool[] Ctext; // 0x28
	internal static readonly int Ascii7bitMaxValue; // 0x30
	internal static readonly char Quote; // 0x34
	internal static readonly char Space; // 0x36
	internal static readonly char Tab; // 0x38
	internal static readonly char CR; // 0x3A
	internal static readonly char LF; // 0x3C
	internal static readonly char StartComment; // 0x3E
	internal static readonly char EndComment; // 0x40
	internal static readonly char Backslash; // 0x42
	internal static readonly char At; // 0x44
	internal static readonly char EndAngleBracket; // 0x46
	internal static readonly char StartAngleBracket; // 0x48
	internal static readonly char StartSquareBracket; // 0x4A
	internal static readonly char EndSquareBracket; // 0x4C
	internal static readonly char Comma; // 0x4E
	internal static readonly char Dot; // 0x50
	private static readonly char[] s_colonSeparator; // 0x58
	private static string[] s_months; // 0x60

	// Methods

	// RVA: 0x25DCCF0 Offset: 0x25DB6F0 VA: 0x1825DCCF0
	private static bool[] CreateCharactersAllowedInAtoms() { }

	// RVA: 0x25DD130 Offset: 0x25DBB30 VA: 0x1825DD130
	private static bool[] CreateCharactersAllowedInQuotedStrings() { }

	// RVA: 0x25DCFB0 Offset: 0x25DB9B0 VA: 0x1825DCFB0
	private static bool[] CreateCharactersAllowedInDomainLiterals() { }

	// RVA: 0x25DD0A0 Offset: 0x25DBAA0 VA: 0x1825DD0A0
	private static bool[] CreateCharactersAllowedInHeaderNames() { }

	// RVA: 0x25DD220 Offset: 0x25DBC20 VA: 0x1825DD220
	private static bool[] CreateCharactersAllowedInTokens() { }

	// RVA: 0x25DCEA0 Offset: 0x25DB8A0 VA: 0x1825DCEA0
	private static bool[] CreateCharactersAllowedInComments() { }

	// RVA: 0x25DD340 Offset: 0x25DBD40 VA: 0x1825DD340
	internal static bool IsAllowedWhiteSpace(char c) { }

	// RVA: 0x25DD410 Offset: 0x25DBE10 VA: 0x1825DD410
	private static void .cctor() { }
}
