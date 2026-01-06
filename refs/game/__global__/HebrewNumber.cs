internal class HebrewNumber // TypeDefIndex: 4812
{
	// Fields
	private static readonly HebrewNumber.HebrewValue[] s_hebrewValues; // 0x0
	private static char s_maxHebrewNumberCh; // 0x8
	private static readonly HebrewNumber.HS[] s_numberPasingState; // 0x10

	// Methods

	// RVA: 0x1BAD310 Offset: 0x1BABD10 VA: 0x181BAD310
	internal static string ToString(int Number) { }

	// RVA: 0x1BAD160 Offset: 0x1BABB60 VA: 0x181BAD160
	internal static HebrewNumberParsingState ParseByChar(char ch, ref HebrewNumberParsingContext context) { }

	// RVA: 0x1BAD0A0 Offset: 0x1BABAA0 VA: 0x181BAD0A0
	internal static bool IsDigit(char ch) { }

	// RVA: 0x1BAD5C0 Offset: 0x1BABFC0 VA: 0x181BAD5C0
	private static void .cctor() { }
}
