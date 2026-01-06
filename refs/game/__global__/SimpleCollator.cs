internal class SimpleCollator : ISimpleCollator // TypeDefIndex: 3506
{
	// Fields
	private static SimpleCollator invariant; // 0x0
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C

	// Methods

	// RVA: 0x1A94600 Offset: 0x1A93000 VA: 0x181A94600
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x1A943D0 Offset: 0x1A92DD0 VA: 0x181A943D0
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1A90FF0 Offset: 0x1A8F9F0 VA: 0x181A90FF0
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x1A8EEE0 Offset: 0x1A8D8E0 VA: 0x181A8EEE0
	private byte Category(int cp) { }

	// RVA: 0x1A93130 Offset: 0x1A91B30 VA: 0x181A93130
	private byte Level1(int cp) { }

	// RVA: 0x1A931D0 Offset: 0x1A91BD0 VA: 0x181A931D0
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x1A922C0 Offset: 0x1A90CC0 VA: 0x181A922C0
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x1A90E50 Offset: 0x1A8F850 VA: 0x181A90E50
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x1A90D10 Offset: 0x1A8F710 VA: 0x181A90D10
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x1A91800 Offset: 0x1A90200 VA: 0x181A91800
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x1A915F0 Offset: 0x1A8FFF0 VA: 0x181A915F0
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x1A90A60 Offset: 0x1A8F460 VA: 0x181A90A60
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x1A90F30 Offset: 0x1A8F930 VA: 0x181A90F30
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x1A94540 Offset: 0x1A92F40 VA: 0x181A94540
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x1A90850 Offset: 0x1A8F250 VA: 0x181A90850
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x1A92340 Offset: 0x1A90D40 VA: 0x181A92340
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x1A92590 Offset: 0x1A90F90 VA: 0x181A92590
	private bool IsSafe(int i) { }

	// RVA: 0x1A91500 Offset: 0x1A8FF00 VA: 0x181A91500 Slot: 4
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x1A91090 Offset: 0x1A8FA90 VA: 0x181A91090
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x1A91190 Offset: 0x1A8FB90 VA: 0x181A91190
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x1A90230 Offset: 0x1A8EC30 VA: 0x181A90230
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x1A90780 Offset: 0x1A8F180 VA: 0x181A90780
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x1A94530 Offset: 0x1A92F30 VA: 0x181A94530 Slot: 5
	private int System.Globalization.ISimpleCollator.Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x1A90130 Offset: 0x1A8EB30 VA: 0x181A90130
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x1A8EF80 Offset: 0x1A8D980 VA: 0x181A8EF80
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x1A8EFC0 Offset: 0x1A8D9C0 VA: 0x181A8EFC0
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A8EFA0 Offset: 0x1A8D9A0 VA: 0x181A8EFA0
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x1A92450 Offset: 0x1A90E50 VA: 0x181A92450 Slot: 6
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x1A92490 Offset: 0x1A90E90 VA: 0x181A92490
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1A923D0 Offset: 0x1A90DD0 VA: 0x181A923D0
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A926C0 Offset: 0x1A910C0 VA: 0x181A926C0 Slot: 7
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x1A92600 Offset: 0x1A91000 VA: 0x181A92600
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1A94290 Offset: 0x1A92C90 VA: 0x181A94290
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x1A91FF0 Offset: 0x1A909F0 VA: 0x181A91FF0 Slot: 8
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1A918E0 Offset: 0x1A902E0 VA: 0x181A918E0
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x1A919A0 Offset: 0x1A903A0 VA: 0x181A919A0
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x1A91A20 Offset: 0x1A90420 VA: 0x181A91A20
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A91AE0 Offset: 0x1A904E0 VA: 0x181A91AE0
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A92F80 Offset: 0x1A91980 VA: 0x181A92F80 Slot: 9
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1A92780 Offset: 0x1A91180 VA: 0x181A92780
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x1A928D0 Offset: 0x1A912D0 VA: 0x181A928D0
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A929A0 Offset: 0x1A913A0 VA: 0x181A929A0
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A93EE0 Offset: 0x1A928E0 VA: 0x181A93EE0
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A93B10 Offset: 0x1A92510 VA: 0x181A93B10
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A940C0 Offset: 0x1A92AC0 VA: 0x181A940C0
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x1A93930 Offset: 0x1A92330 VA: 0x181A93930
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A93360 Offset: 0x1A91D60 VA: 0x181A93360
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1A94560 Offset: 0x1A92F60 VA: 0x181A94560
	private static void .cctor() { }
}
