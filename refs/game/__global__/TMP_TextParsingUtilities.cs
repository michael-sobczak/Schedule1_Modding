public class TMP_TextParsingUtilities // TypeDefIndex: 14996
{
	// Fields
	private static readonly TMP_TextParsingUtilities s_Instance; // 0x0
	private const string k_LookupStringL = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@abcdefghijklmnopqrstuvwxyz[-]^_`abcdefghijklmnopqrstuvwxyz{|}~-";
	private const string k_LookupStringU = "-------------------------------- !-#$%&-()*+,-./0123456789:;<=>?@ABCDEFGHIJKLMNOPQRSTUVWXYZ[-]^_`ABCDEFGHIJKLMNOPQRSTUVWXYZ{|}~-";

	// Properties
	public static TMP_TextParsingUtilities instance { get; }

	// Methods

	// RVA: 0x2C30A00 Offset: 0x2C2F400 VA: 0x182C30A00
	private static void .cctor() { }

	// RVA: 0x2C30A70 Offset: 0x2C2F470 VA: 0x182C30A70
	public static TMP_TextParsingUtilities get_instance() { }

	// RVA: 0x2C30110 Offset: 0x2C2EB10 VA: 0x182C30110
	public static int GetHashCode(string s) { }

	// RVA: 0x2C300B0 Offset: 0x2C2EAB0 VA: 0x182C300B0
	public static int GetHashCodeCaseSensitive(string s) { }

	// RVA: 0x2C30880 Offset: 0x2C2F280 VA: 0x182C30880
	public static char ToLowerASCIIFast(char c) { }

	// RVA: 0x2C309A0 Offset: 0x2C2F3A0 VA: 0x182C309A0
	public static char ToUpperASCIIFast(char c) { }

	// RVA: 0x2C30940 Offset: 0x2C2F340 VA: 0x182C30940
	public static uint ToUpperASCIIFast(uint c) { }

	// RVA: 0x2C308E0 Offset: 0x2C2F2E0 VA: 0x182C308E0
	public static uint ToLowerASCIIFast(uint c) { }

	// RVA: 0x2C30840 Offset: 0x2C2F240 VA: 0x182C30840
	public static bool IsHighSurrogate(uint c) { }

	// RVA: 0x2C30860 Offset: 0x2C2F260 VA: 0x182C30860
	public static bool IsLowSurrogate(uint c) { }

	// RVA: 0x2C300A0 Offset: 0x2C2EAA0 VA: 0x182C300A0
	internal static uint ConvertToUTF32(uint highSurrogate, uint lowSurrogate) { }

	// RVA: 0x2C303D0 Offset: 0x2C2EDD0 VA: 0x182C303D0
	internal static bool IsDiacriticalMark(uint c) { }

	// RVA: 0x2C301F0 Offset: 0x2C2EBF0 VA: 0x182C301F0
	internal static bool IsBaseGlyph(uint c) { }

	// RVA: 0x2C30420 Offset: 0x2C2EE20 VA: 0x182C30420
	internal static bool IsEmoji(uint c) { }

	// RVA: 0x2C307E0 Offset: 0x2C2F1E0 VA: 0x182C307E0
	internal static bool IsHangul(uint c) { }

	// RVA: 0x2C30300 Offset: 0x2C2ED00 VA: 0x182C30300
	internal static bool IsCJK(uint c) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
