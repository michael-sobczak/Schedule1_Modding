internal class MSCompatUnicodeTable // TypeDefIndex: 3499
{
	// Fields
	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x1A8BE70 Offset: 0x1A8A870 VA: 0x181A8BE70
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x1A8AF30 Offset: 0x1A89930 VA: 0x181A8AF30
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x1A8C540 Offset: 0x1A8AF40 VA: 0x181A8C540
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1A8B600 Offset: 0x1A8A000 VA: 0x181A8B600
	public static byte Category(int cp) { }

	// RVA: 0x1A8C330 Offset: 0x1A8AD30 VA: 0x181A8C330
	public static byte Level1(int cp) { }

	// RVA: 0x1A8C3E0 Offset: 0x1A8ADE0 VA: 0x181A8C3E0
	public static byte Level2(int cp) { }

	// RVA: 0x1A8C490 Offset: 0x1A8AE90 VA: 0x181A8C490
	public static byte Level3(int cp) { }

	// RVA: 0x1A8C090 Offset: 0x1A8AA90 VA: 0x181A8C090
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x1A8C040 Offset: 0x1A8AA40 VA: 0x181A8C040
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x1A8C810 Offset: 0x1A8B210 VA: 0x181A8C810
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x1A8C830 Offset: 0x1A8B230 VA: 0x181A8C830
	public static int ToWidthCompat(int i) { }

	// RVA: 0x1A8BF90 Offset: 0x1A8A990 VA: 0x181A8BF90
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x1A8C000 Offset: 0x1A8AA00 VA: 0x181A8C000
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x1A8C020 Offset: 0x1A8AA20 VA: 0x181A8C020
	public static bool IsHiragana(char c) { }

	// RVA: 0x1A8C1C0 Offset: 0x1A8ABC0 VA: 0x181A8C1C0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x1A8CFF0 Offset: 0x1A8B9F0 VA: 0x181A8CFF0
	public static bool get_IsReady() { }

	// RVA: 0x1A8BDB0 Offset: 0x1A8A7B0 VA: 0x181A8BDB0
	private static IntPtr GetResource(string name) { }

	// RVA: 0x1A8C9B0 Offset: 0x1A8B3B0 VA: 0x181A8C9B0
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x1A8C9F0 Offset: 0x1A8B3F0 VA: 0x181A8C9F0
	private static void .cctor() { }

	// RVA: 0x1A8BC40 Offset: 0x1A8A640 VA: 0x181A8BC40
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1A8B6B0 Offset: 0x1A8A0B0 VA: 0x181A8B6B0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }
}
