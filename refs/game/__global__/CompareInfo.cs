public class CompareInfo : IDeserializationCallback // TypeDefIndex: 4792
{
	// Fields
	private const CompareOptions ValidIndexMaskOffFlags = -32;
	private const CompareOptions ValidCompareMaskOffFlags = -536870944;
	private const CompareOptions ValidHashCodeOfStringMaskOffFlags = -32;
	private const CompareOptions ValidSortkeyCtorMaskOffFlags = -536870944;
	internal static readonly CompareInfo Invariant; // 0x0
	[OptionalField(VersionAdded = 2)]
	private string m_name; // 0x10
	private string _sortName; // 0x18
	[OptionalField(VersionAdded = 3)]
	private SortVersion m_SortVersion; // 0x20
	private int culture; // 0x28
	private ISimpleCollator collator; // 0x30
	private static Dictionary<string, ISimpleCollator> collators; // 0x8
	private static bool managedCollation; // 0x10
	private static bool managedCollationChecked; // 0x11

	// Properties
	public virtual string Name { get; }
	private static bool UseManagedCollation { get; }

	// Methods

	// RVA: 0x1B838F0 Offset: 0x1B822F0 VA: 0x181B838F0
	internal static int InvariantIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1B839D0 Offset: 0x1B823D0 VA: 0x181B839D0
	internal static int InvariantLastIndexOf(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1B83510 Offset: 0x1B81F10 VA: 0x181B83510
	private static int InvariantFindString(char* source, int sourceCount, char* value, int valueCount, bool ignoreCase, bool start) { }

	// RVA: 0x1B83AC0 Offset: 0x1B824C0 VA: 0x181B83AC0
	private static char InvariantToUpper(char c) { }

	// RVA: 0x1B83250 Offset: 0x1B81C50 VA: 0x181B83250
	private SortKey InvariantCreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x1B84960 Offset: 0x1B83360 VA: 0x181B84960
	internal void .ctor(CultureInfo culture) { }

	// RVA: 0x1B822A0 Offset: 0x1B80CA0 VA: 0x181B822A0
	public static CompareInfo GetCompareInfo(string name) { }

	[OnDeserializing]
	// RVA: 0xAFE5A0 Offset: 0xAFCFA0 VA: 0x180AFE5A0
	private void OnDeserializing(StreamingContext ctx) { }

	// RVA: 0x1B84660 Offset: 0x1B83060 VA: 0x181B84660 Slot: 4
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[OnDeserialized]
	// RVA: 0x1B84660 Offset: 0x1B83060 VA: 0x181B84660
	private void OnDeserialized(StreamingContext ctx) { }

	// RVA: 0x1B845A0 Offset: 0x1B82FA0 VA: 0x181B845A0
	private void OnDeserialized() { }

	[OnSerializing]
	// RVA: 0x1B84670 Offset: 0x1B83070 VA: 0x181B84670
	private void OnSerializing(StreamingContext ctx) { }

	// RVA: 0x1B849B0 Offset: 0x1B833B0 VA: 0x181B849B0 Slot: 5
	public virtual string get_Name() { }

	// RVA: 0x1B81550 Offset: 0x1B7FF50 VA: 0x181B81550 Slot: 6
	public virtual int Compare(string string1, string string2) { }

	// RVA: 0x1B80D40 Offset: 0x1B7F740 VA: 0x181B80D40 Slot: 7
	public virtual int Compare(string string1, string string2, CompareOptions options) { }

	// RVA: 0x1B81580 Offset: 0x1B7FF80 VA: 0x181B81580
	internal int Compare(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x1B80330 Offset: 0x1B7ED30 VA: 0x181B80330
	internal int CompareOptionIgnoreCase(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2) { }

	// RVA: 0x1B80FE0 Offset: 0x1B7F9E0 VA: 0x181B80FE0 Slot: 8
	public virtual int Compare(string string1, int offset1, int length1, string string2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x1B80880 Offset: 0x1B7F280 VA: 0x181B80880
	internal static int CompareOrdinalIgnoreCase(string strA, int indexA, int lengthA, string strB, int indexB, int lengthB) { }

	// RVA: 0x1B80560 Offset: 0x1B7EF60 VA: 0x181B80560
	internal static int CompareOrdinalIgnoreCase(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	// RVA: 0x1B83AE0 Offset: 0x1B824E0 VA: 0x181B83AE0 Slot: 9
	public virtual bool IsPrefix(string source, string prefix, CompareOptions options) { }

	// RVA: 0x1B83D70 Offset: 0x1B82770 VA: 0x181B83D70 Slot: 10
	public virtual bool IsSuffix(string source, string suffix, CompareOptions options) { }

	// RVA: 0x1B81E60 Offset: 0x1B80860 VA: 0x181B81E60
	internal bool IsSuffix(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x1B82E20 Offset: 0x1B81820 VA: 0x181B82E20 Slot: 11
	public virtual int IndexOf(string source, string value, CompareOptions options) { }

	// RVA: 0x1B82EB0 Offset: 0x1B818B0 VA: 0x181B82EB0 Slot: 12
	public virtual int IndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x1B82C60 Offset: 0x1B81660 VA: 0x181B82C60
	internal int IndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1B84100 Offset: 0x1B82B00 VA: 0x181B84100 Slot: 13
	public virtual int LastIndexOf(string source, string value, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x1B83FC0 Offset: 0x1B829C0 VA: 0x181B83FC0
	internal int LastIndexOfOrdinal(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1B82AD0 Offset: 0x1B814D0 VA: 0x181B82AD0 Slot: 14
	public virtual SortKey GetSortKey(string source, CompareOptions options) { }

	// RVA: 0x1B81EE0 Offset: 0x1B808E0 VA: 0x181B81EE0 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1B826B0 Offset: 0x1B810B0 VA: 0x181B826B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B826F0 Offset: 0x1B810F0 VA: 0x181B826F0
	internal static int GetIgnoreCaseHash(string source) { }

	// RVA: 0x1B823A0 Offset: 0x1B80DA0 VA: 0x181B823A0
	internal int GetHashCodeOfString(string source, CompareOptions options) { }

	// RVA: 0x1B825A0 Offset: 0x1B80FA0 VA: 0x181B825A0 Slot: 15
	public virtual int GetHashCode(string source, CompareOptions options) { }

	// RVA: 0x1B84830 Offset: 0x1B83230 VA: 0x181B84830 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B84A30 Offset: 0x1B83430 VA: 0x181B84A30
	private static bool get_UseManagedCollation() { }

	// RVA: 0x1B81FA0 Offset: 0x1B809A0 VA: 0x181B81FA0
	private ISimpleCollator GetCollator() { }

	// RVA: 0x1B819E0 Offset: 0x1B803E0 VA: 0x181B819E0
	private SortKey CreateSortKeyCore(string source, CompareOptions options) { }

	// RVA: 0x1B850E0 Offset: 0x1B83AE0 VA: 0x181B850E0
	private int internal_index_switch(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x1B84D60 Offset: 0x1B83760 VA: 0x181B84D60
	private int internal_compare_switch(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x1B84C70 Offset: 0x1B83670 VA: 0x181B84C70
	private int internal_compare_managed(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x1B85030 Offset: 0x1B83A30 VA: 0x181B85030
	private int internal_index_managed(string s1, int sindex, int count, string s2, CompareOptions opt, bool first) { }

	// RVA: 0x1B84BB0 Offset: 0x1B835B0 VA: 0x181B84BB0
	private static int internal_compare_icall(char* str1, int length1, char* str2, int length2, CompareOptions options) { }

	// RVA: 0x1B84BC0 Offset: 0x1B835C0 VA: 0x181B84BC0
	private static int internal_compare(string str1, int offset1, int length1, string str2, int offset2, int length2, CompareOptions options) { }

	// RVA: 0x1B84F60 Offset: 0x1B83960 VA: 0x181B84F60
	private static int internal_index_icall(char* source, int sindex, int count, char* value, int value_length, bool first) { }

	// RVA: 0x1B84F70 Offset: 0x1B83970 VA: 0x181B84F70
	private static int internal_index(string source, int sindex, int count, string value, bool first) { }

	// RVA: 0x1B83220 Offset: 0x1B81C20 VA: 0x181B83220
	private void InitSort(CultureInfo culture) { }

	// RVA: 0x1B80A30 Offset: 0x1B7F430 VA: 0x181B80A30
	private static int CompareStringOrdinalIgnoreCase(char* pString1, int length1, char* pString2, int length2) { }

	// RVA: 0x1B82C20 Offset: 0x1B81620 VA: 0x181B82C20
	internal static int IndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1B83F80 Offset: 0x1B82980 VA: 0x181B83F80
	internal static int LastIndexOfOrdinalCore(string source, string value, int startIndex, int count, bool ignoreCase) { }

	// RVA: 0x1B83F40 Offset: 0x1B82940 VA: 0x181B83F40
	private int LastIndexOfCore(string source, string target, int startIndex, int count, CompareOptions options) { }

	// RVA: 0x1B82BA0 Offset: 0x1B815A0 VA: 0x181B82BA0
	private int IndexOfCore(string source, string target, int startIndex, int count, CompareOptions options, int* matchLengthPtr) { }

	// RVA: 0x1B80CC0 Offset: 0x1B7F6C0 VA: 0x181B80CC0
	private int CompareString(ReadOnlySpan<char> string1, string string2, CompareOptions options) { }

	// RVA: 0x1B80BA0 Offset: 0x1B7F5A0 VA: 0x181B80BA0
	private int CompareString(ReadOnlySpan<char> string1, ReadOnlySpan<char> string2, CompareOptions options) { }

	// RVA: 0x1B81B30 Offset: 0x1B80530 VA: 0x181B81B30
	private SortKey CreateSortKey(string source, CompareOptions options) { }

	// RVA: 0x1B84710 Offset: 0x1B83110 VA: 0x181B84710
	private bool StartsWith(string source, string prefix, CompareOptions options) { }

	// RVA: 0x1B81D40 Offset: 0x1B80740 VA: 0x181B81D40
	private bool EndsWith(string source, string suffix, CompareOptions options) { }

	// RVA: 0x1B81E60 Offset: 0x1B80860 VA: 0x181B81E60
	private bool EndsWith(ReadOnlySpan<char> source, ReadOnlySpan<char> suffix, CompareOptions options) { }

	// RVA: 0x1B82360 Offset: 0x1B80D60 VA: 0x181B82360
	internal int GetHashCodeOfStringCore(string source, CompareOptions options) { }

	// RVA: 0x1B84890 Offset: 0x1B83290 VA: 0x181B84890
	private static void .cctor() { }

	// RVA: 0x1B84930 Offset: 0x1B83330 VA: 0x181B84930
	internal void .ctor() { }
}
