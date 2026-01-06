public sealed class String : IComparable, IEnumerable, IEnumerable<char>, IComparable<string>, IEquatable<string>, IConvertible, ICloneable // TypeDefIndex: 3558
{
	// Fields
	private const int StackallocIntBufferSizeLimit = 128;
	private const int PROBABILISTICMAP_BLOCK_INDEX_MASK = 7;
	private const int PROBABILISTICMAP_BLOCK_INDEX_SHIFT = 3;
	private const int PROBABILISTICMAP_SIZE = 8;
	private int _stringLength; // 0x10
	private char _firstChar; // 0x14
	public static readonly string Empty; // 0x0

	// Properties
	public int Length { get; }
	public char Chars { get; }

	// Methods

	// RVA: 0x1AAAB20 Offset: 0x1AA9520 VA: 0x181AAAB20
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x1AA6CF0 Offset: 0x1AA56F0 VA: 0x181AA6CF0
	private static int CompareOrdinalHelper(string strA, int indexA, int countA, string strB, int indexB, int countB) { }

	// RVA: 0x1AA6B80 Offset: 0x1AA5580 VA: 0x181AA6B80
	private static int CompareOrdinalHelper(string strA, string strB) { }

	// RVA: 0x1AA7080 Offset: 0x1AA5A80 VA: 0x181AA7080
	public static int Compare(string strA, string strB) { }

	// RVA: 0x1AA77A0 Offset: 0x1AA61A0 VA: 0x181AA77A0
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x1AA7910 Offset: 0x1AA6310 VA: 0x181AA7910
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x1AA7D70 Offset: 0x1AA6770 VA: 0x181AA7D70
	public static int Compare(string strA, string strB, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x1AA7CB0 Offset: 0x1AA66B0 VA: 0x181AA7CB0
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x1AA7E30 Offset: 0x1AA6830 VA: 0x181AA7E30
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x1AA77B0 Offset: 0x1AA61B0 VA: 0x181AA77B0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase) { }

	// RVA: 0x1AA72C0 Offset: 0x1AA5CC0 VA: 0x181AA72C0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x1AA7040 Offset: 0x1AA5A40 VA: 0x181AA7040
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x1AA6D40 Offset: 0x1AA5740 VA: 0x181AA6D40
	internal static int CompareOrdinal(ReadOnlySpan<char> strA, ReadOnlySpan<char> strB) { }

	// RVA: 0x1AA6DE0 Offset: 0x1AA57E0 VA: 0x181AA6DE0
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x1AA7160 Offset: 0x1AA5B60 VA: 0x181AA7160 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1AA7080 Offset: 0x1AA5A80 VA: 0x181AA7080 Slot: 7
	public int CompareTo(string strB) { }

	// RVA: 0x1AAAA10 Offset: 0x1AA9410 VA: 0x181AAAA10
	public bool EndsWith(string value) { }

	// RVA: 0x1AAA6C0 Offset: 0x1AA90C0 VA: 0x181AAA6C0
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x1AAA660 Offset: 0x1AA9060 VA: 0x181AAA660
	public bool EndsWith(char value) { }

	// RVA: 0x1AAAB90 Offset: 0x1AA9590 VA: 0x181AAAB90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1AAB250 Offset: 0x1AA9C50 VA: 0x181AAB250 Slot: 8
	public bool Equals(string value) { }

	// RVA: 0x1AAAC20 Offset: 0x1AA9620 VA: 0x181AAAC20
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x1AAAB50 Offset: 0x1AA9550 VA: 0x181AAAB50
	public static bool Equals(string a, string b) { }

	// RVA: 0x1AAAF30 Offset: 0x1AA9930 VA: 0x181AAAF30
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x1AAAB50 Offset: 0x1AA9550 VA: 0x181AAAB50
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x1AB2D80 Offset: 0x1AB1780 VA: 0x181AB2D80
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x1AABF70 Offset: 0x1AAA970 VA: 0x181AABF70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1AABF70 Offset: 0x1AAA970 VA: 0x181AABF70
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x1AB1590 Offset: 0x1AAFF90 VA: 0x181AB1590
	public bool StartsWith(string value) { }

	// RVA: 0x1AB1220 Offset: 0x1AAFC20 VA: 0x181AB1220
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x1AA6B60 Offset: 0x1AA5560 VA: 0x181AA6B60
	internal static void CheckStringComparison(StringComparison comparisonType) { }

	// RVA: 0x1AAB290 Offset: 0x1AA9C90 VA: 0x181AAB290
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x1AA84F0 Offset: 0x1AA6EF0 VA: 0x181AA84F0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x1AA87C0 Offset: 0x1AA71C0 VA: 0x181AA87C0
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x1AA8A60 Offset: 0x1AA7460 VA: 0x181AA8A60
	public static string Concat(object[] args) { }

	// RVA: 0x1AA88C0 Offset: 0x1AA72C0 VA: 0x181AA88C0
	public static string Concat(string str0, string str1) { }

	// RVA: 0x1AA85A0 Offset: 0x1AA6FA0 VA: 0x181AA85A0
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x1AA7F90 Offset: 0x1AA6990 VA: 0x181AA7F90
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x1AA8220 Offset: 0x1AA6C20 VA: 0x181AA8220
	public static string Concat(string[] values) { }

	// RVA: 0x1AABB80 Offset: 0x1AAA580 VA: 0x181AABB80
	public static string Format(string format, object arg0) { }

	// RVA: 0x1AABE30 Offset: 0x1AAA830 VA: 0x181AABE30
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x1AABA40 Offset: 0x1AAA440 VA: 0x181AABA40
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1AAB8A0 Offset: 0x1AAA2A0 VA: 0x181AAB8A0
	public static string Format(string format, object[] args) { }

	// RVA: 0x1AAB440 Offset: 0x1AA9E40 VA: 0x181AAB440
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x1AAB740 Offset: 0x1AAA140 VA: 0x181AAB740
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x1AABCC0 Offset: 0x1AAA6C0 VA: 0x181AABCC0
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x1AAB590 Offset: 0x1AA9F90 VA: 0x181AAB590
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x1AAB320 Offset: 0x1AA9D20 VA: 0x181AAB320
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x1AACF10 Offset: 0x1AAB910 VA: 0x181AACF10
	public string Insert(int startIndex, string value) { }

	// RVA: 0x1AAD780 Offset: 0x1AAC180 VA: 0x181AAD780
	public static string Join(string separator, string[] value) { }

	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF561B0 Offset: 0xF54BB0 VA: 0x180F561B0
	|-String.Join<int>
	|
	|-RVA: 0xF56240 Offset: 0xF54C40 VA: 0x180F56240
	|-String.Join<object>
	|
	|-RVA: 0xF56120 Offset: 0xF54B20 VA: 0x180F56120
	|-String.Join<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1AAD860 Offset: 0x1AAC260 VA: 0x181AAD860
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x1AADC80 Offset: 0x1AAC680 VA: 0x181AADC80
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: -1 Offset: -1
	private static string JoinCore<T>(char* separator, int separatorLength, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF558B0 Offset: 0xF542B0 VA: 0x180F558B0
	|-String.JoinCore<int>
	|
	|-RVA: 0xF55CE0 Offset: 0xF546E0 VA: 0x180F55CE0
	|-String.JoinCore<object>
	|
	|-RVA: 0xF552A0 Offset: 0xF53CA0 VA: 0x180F552A0
	|-String.JoinCore<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1AAD270 Offset: 0x1AABC70 VA: 0x181AAD270
	private static string JoinCore(char* separator, int separatorLength, string[] value, int startIndex, int count) { }

	// RVA: 0x1AAF190 Offset: 0x1AADB90 VA: 0x181AAF190
	public string PadLeft(int totalWidth) { }

	// RVA: 0x1AAF290 Offset: 0x1AADC90 VA: 0x181AAF290
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x1AAF490 Offset: 0x1AADE90 VA: 0x181AAF490
	public string PadRight(int totalWidth) { }

	// RVA: 0x1AAF390 Offset: 0x1AADD90 VA: 0x181AAF390
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x1AAF590 Offset: 0x1AADF90 VA: 0x181AAF590
	public string Remove(int startIndex, int count) { }

	// RVA: 0x1AAF7B0 Offset: 0x1AAE1B0 VA: 0x181AAF7B0
	public string Remove(int startIndex) { }

	// RVA: 0x1AAFC60 Offset: 0x1AAE660 VA: 0x181AAFC60
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x1AAFD50 Offset: 0x1AAE750 VA: 0x181AAFD50
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x1AAF890 Offset: 0x1AAE290 VA: 0x181AAF890
	private string ReplaceHelper(int oldValueLength, string newValue, ReadOnlySpan<int> indices) { }

	// RVA: 0x1AB1150 Offset: 0x1AAFB50 VA: 0x181AB1150
	public string[] Split(char separator, StringSplitOptions options = 0) { }

	// RVA: 0x1AB0FC0 Offset: 0x1AAF9C0 VA: 0x181AB0FC0
	public string[] Split(char[] separator) { }

	// RVA: 0x1AB1040 Offset: 0x1AAFA40 VA: 0x181AB1040
	public string[] Split(char[] separator, int count) { }

	// RVA: 0x1AB10C0 Offset: 0x1AAFAC0 VA: 0x181AB10C0
	public string[] Split(char[] separator, StringSplitOptions options) { }

	// RVA: 0x1AB0020 Offset: 0x1AAEA20 VA: 0x181AB0020
	private string[] SplitInternal(ReadOnlySpan<char> separators, int count, StringSplitOptions options) { }

	// RVA: 0x1AB0F90 Offset: 0x1AAF990 VA: 0x181AB0F90
	public string[] Split(string[] separator, StringSplitOptions options) { }

	// RVA: 0x1AB0650 Offset: 0x1AAF050 VA: 0x181AB0650
	private string[] SplitInternal(string separator, string[] separators, int count, StringSplitOptions options) { }

	// RVA: 0x1AB0320 Offset: 0x1AAED20 VA: 0x181AB0320
	private string[] SplitInternal(string separator, int count, StringSplitOptions options) { }

	// RVA: 0x1AB0A70 Offset: 0x1AAF470 VA: 0x181AB0A70
	private string[] SplitKeepEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count) { }

	// RVA: 0x1AB0CA0 Offset: 0x1AAF6A0 VA: 0x181AB0CA0
	private string[] SplitOmitEmptyEntries(ReadOnlySpan<int> sepList, ReadOnlySpan<int> lengthList, int defaultLength, int count) { }

	// RVA: 0x1AAEE00 Offset: 0x1AAD800 VA: 0x181AAEE00
	private void MakeSeparatorList(ReadOnlySpan<char> separators, ref ValueListBuilder<int> sepListBuilder) { }

	// RVA: 0x1AAE9E0 Offset: 0x1AAD3E0 VA: 0x181AAE9E0
	private void MakeSeparatorList(string separator, ref ValueListBuilder<int> sepListBuilder) { }

	// RVA: 0x1AAEBD0 Offset: 0x1AAD5D0 VA: 0x181AAEBD0
	private void MakeSeparatorList(string[] separators, ref ValueListBuilder<int> sepListBuilder, ref ValueListBuilder<int> lengthListBuilder) { }

	// RVA: 0x1AB16A0 Offset: 0x1AB00A0 VA: 0x181AB16A0
	public string Substring(int startIndex) { }

	// RVA: 0x1AB16B0 Offset: 0x1AB00B0 VA: 0x181AB16B0
	public string Substring(int startIndex, int length) { }

	// RVA: 0x1AAD120 Offset: 0x1AABB20 VA: 0x181AAD120
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x1AB2250 Offset: 0x1AB0C50 VA: 0x181AB2250
	public string ToLower() { }

	// RVA: 0x1AB22E0 Offset: 0x1AB0CE0 VA: 0x181AB22E0
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x1AB21C0 Offset: 0x1AB0BC0 VA: 0x181AB21C0
	public string ToLowerInvariant() { }

	// RVA: 0x1AB2410 Offset: 0x1AB0E10 VA: 0x181AB2410
	public string ToUpper() { }

	// RVA: 0x1AB24A0 Offset: 0x1AB0EA0 VA: 0x181AB24A0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x1AB2380 Offset: 0x1AB0D80 VA: 0x181AB2380
	public string ToUpperInvariant() { }

	// RVA: 0x1AB29F0 Offset: 0x1AB13F0 VA: 0x181AB29F0
	public string Trim() { }

	// RVA: 0x1AB2A00 Offset: 0x1AB1400 VA: 0x181AB2A00
	public string Trim(char trimChar) { }

	// RVA: 0x1AB2990 Offset: 0x1AB1390 VA: 0x181AB2990
	public string Trim(char[] trimChars) { }

	// RVA: 0x1AB27F0 Offset: 0x1AB11F0 VA: 0x181AB27F0
	public string TrimStart() { }

	// RVA: 0x1AB2770 Offset: 0x1AB1170 VA: 0x181AB2770
	public string TrimStart(char trimChar) { }

	// RVA: 0x1AB27A0 Offset: 0x1AB11A0 VA: 0x181AB27A0
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x1AB2540 Offset: 0x1AB0F40 VA: 0x181AB2540
	public string TrimEnd() { }

	// RVA: 0x1AB25B0 Offset: 0x1AB0FB0 VA: 0x181AB25B0
	public string TrimEnd(char trimChar) { }

	// RVA: 0x1AB2550 Offset: 0x1AB0F50 VA: 0x181AB2550
	public string TrimEnd(char[] trimChars) { }

	// RVA: 0x1AB2800 Offset: 0x1AB1200 VA: 0x181AB2800
	private string TrimWhiteSpaceHelper(string.TrimType trimType) { }

	// RVA: 0x1AB25E0 Offset: 0x1AB0FE0 VA: 0x181AB25E0
	private string TrimHelper(char* trimChars, int trimCharsLength, string.TrimType trimType) { }

	// RVA: 0x1AA98D0 Offset: 0x1AA82D0 VA: 0x181AA98D0
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x1AA8D60 Offset: 0x1AA7760 VA: 0x181AA8D60
	public bool Contains(string value) { }

	// RVA: 0x1AA8F30 Offset: 0x1AA7930 VA: 0x181AA8F30
	public bool Contains(string value, StringComparison comparisonType) { }

	// RVA: 0x1AA8F60 Offset: 0x1AA7960 VA: 0x181AA8F60
	public bool Contains(char value) { }

	// RVA: 0x1AACD20 Offset: 0x1AAB720 VA: 0x181AACD20
	public int IndexOf(char value) { }

	// RVA: 0x1AAC870 Offset: 0x1AAB270 VA: 0x181AAC870
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x1AACD30 Offset: 0x1AAB730 VA: 0x181AACD30
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x1AAC370 Offset: 0x1AAAD70 VA: 0x181AAC370
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x1AABFD0 Offset: 0x1AAA9D0 VA: 0x181AABFD0
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x1AABFF0 Offset: 0x1AAA9F0 VA: 0x181AABFF0
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x1AAC3E0 Offset: 0x1AAADE0 VA: 0x181AAC3E0
	private int IndexOfAny(char value1, char value2, int startIndex, int count) { }

	// RVA: 0x1AAC390 Offset: 0x1AAAD90 VA: 0x181AAC390
	private int IndexOfAny(char value1, char value2, char value3, int startIndex, int count) { }

	// RVA: 0x1AAC450 Offset: 0x1AAAE50 VA: 0x181AAC450
	private int IndexOfCharArray(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x1AACE40 Offset: 0x1AAB840 VA: 0x181AACE40
	private static void InitializeProbabilisticMap(uint* charMap, ReadOnlySpan<char> anyOf) { }

	// RVA: 0x1AA6B10 Offset: 0x1AA5510 VA: 0x181AA6B10
	private static bool ArrayContains(char searchChar, char[] anyOf) { }

	// RVA: 0x1AAD190 Offset: 0x1AABB90 VA: 0x181AAD190
	private static bool IsCharBitSet(uint* charMap, byte value) { }

	// RVA: 0x1AB0000 Offset: 0x1AAEA00 VA: 0x181AB0000
	private static void SetCharBit(uint* charMap, byte value) { }

	// RVA: 0x1AACCE0 Offset: 0x1AAB6E0 VA: 0x181AACCE0
	public int IndexOf(string value) { }

	// RVA: 0x1AACD00 Offset: 0x1AAB700 VA: 0x181AACD00
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x1AAC8C0 Offset: 0x1AAB2C0 VA: 0x181AAC8C0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x1AAC890 Offset: 0x1AAB290 VA: 0x181AAC890
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x1AAC8F0 Offset: 0x1AAB2F0 VA: 0x181AAC8F0
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x1AAE870 Offset: 0x1AAD270 VA: 0x181AAE870
	public int LastIndexOf(char value) { }

	// RVA: 0x1AAE820 Offset: 0x1AAD220 VA: 0x181AAE820
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x1AAE8B0 Offset: 0x1AAD2B0 VA: 0x181AAE8B0
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x1AADD20 Offset: 0x1AAC720 VA: 0x181AADD20
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x1AADFD0 Offset: 0x1AAC9D0 VA: 0x181AADFD0
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x1AADD50 Offset: 0x1AAC750 VA: 0x181AADD50
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x1AADFF0 Offset: 0x1AAC9F0 VA: 0x181AADFF0
	private int LastIndexOfCharArray(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x1AAE880 Offset: 0x1AAD280 VA: 0x181AAE880
	public int LastIndexOf(string value) { }

	// RVA: 0x1AAE840 Offset: 0x1AAD240 VA: 0x181AAE840
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x1AAE3F0 Offset: 0x1AACDF0 VA: 0x181AAE3F0
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x1AB2A30 Offset: 0x1AB1430 VA: 0x181AB2A30
	public void .ctor(char[] value) { }

	// RVA: 0x1AA9E00 Offset: 0x1AA8800 VA: 0x181AA9E00
	private static string Ctor(char[] value) { }

	// RVA: 0x1AB2A30 Offset: 0x1AB1430 VA: 0x181AB2A30
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x1AAA420 Offset: 0x1AA8E20 VA: 0x181AAA420
	private static string Ctor(char[] value, int startIndex, int length) { }

	[CLSCompliant(False)]
	// RVA: 0x1AB2A30 Offset: 0x1AB1430 VA: 0x181AB2A30
	public void .ctor(char* value) { }

	// RVA: 0x1AA9BC0 Offset: 0x1AA85C0 VA: 0x181AA9BC0
	private static string Ctor(char* ptr) { }

	[CLSCompliant(False)]
	// RVA: 0x1AB2A30 Offset: 0x1AB1430 VA: 0x181AB2A30
	public void .ctor(char* value, int startIndex, int length) { }

	// RVA: 0x1AAA1F0 Offset: 0x1AA8BF0 VA: 0x181AAA1F0
	private static string Ctor(char* ptr, int startIndex, int length) { }

	[CLSCompliant(False)]
	// RVA: 0x1AB2A30 Offset: 0x1AB1430 VA: 0x181AB2A30
	public void .ctor(sbyte* value, int startIndex, int length) { }

	// RVA: 0x1AA9970 Offset: 0x1AA8370 VA: 0x181AA9970
	private static string Ctor(sbyte* value, int startIndex, int length) { }

	// RVA: 0x1AA92A0 Offset: 0x1AA7CA0 VA: 0x181AA92A0
	private static string CreateStringForSByteConstructor(byte* pb, int numBytes) { }

	[CLSCompliant(False)]
	// RVA: 0x1AB2A30 Offset: 0x1AB1430 VA: 0x181AB2A30
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x1AA9FB0 Offset: 0x1AA89B0 VA: 0x181AA9FB0
	private static string Ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x1AB2A30 Offset: 0x1AB1430 VA: 0x181AB2A30
	public void .ctor(char c, int count) { }

	// RVA: 0x1AA9EA0 Offset: 0x1AA88A0 VA: 0x181AA9EA0
	private static string Ctor(char c, int count) { }

	// RVA: 0x1AB2A40 Offset: 0x1AB1440 VA: 0x181AB2A40
	public void .ctor(ReadOnlySpan<char> value) { }

	// RVA: 0x1AA9D40 Offset: 0x1AA8740 VA: 0x181AA9D40
	private static string Ctor(ReadOnlySpan<char> value) { }

	// RVA: -1 Offset: -1
	public static string Create<TState>(int length, TState state, SpanAction<char, TState> action) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF54E40 Offset: 0xF53840 VA: 0x180F54E40
	|-String.Create<ValueTuple<object, int, int>>
	|
	|-RVA: 0xF54FB0 Offset: 0xF539B0 VA: 0x180F54FB0
	|-String.Create<ValueTuple<IntPtr, int, IntPtr, int, bool>>
	|
	|-RVA: 0xF55120 Offset: 0xF53B20 VA: 0x180F55120
	|-String.Create<ValueTuple<IntPtr, int, IntPtr, int, IntPtr, int, bool, ValueTuple<bool>>>
	|
	|-RVA: 0xF54C50 Offset: 0xF53650 VA: 0x180F54C50
	|-String.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x1AB2D00 Offset: 0x1AB1700 VA: 0x181AB2D00
	public static ReadOnlySpan<char> op_Implicit(string value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 26
	public object Clone() { }

	// RVA: 0x1AA91D0 Offset: 0x1AA7BD0 VA: 0x181AA91D0
	public static string Copy(string str) { }

	// RVA: 0x1AA8F80 Offset: 0x1AA7980 VA: 0x181AA8F80
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x1AB1F70 Offset: 0x1AB0970 VA: 0x181AB1F70
	public char[] ToCharArray() { }

	// RVA: 0x1AB2010 Offset: 0x1AB0A10 VA: 0x181AB2010
	public char[] ToCharArray(int startIndex, int length) { }

	[NonVersionable]
	// RVA: 0x1AAD1B0 Offset: 0x1AABBB0 VA: 0x181AAD1B0
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x1AAD1C0 Offset: 0x1AABBC0 VA: 0x181AAD1C0
	public static bool IsNullOrWhiteSpace(string value) { }

	// RVA: 0x1AABFC0 Offset: 0x1AAA9C0 VA: 0x181AABFC0
	internal ref char GetRawStringData() { }

	// RVA: 0x1AA9320 Offset: 0x1AA7D20 VA: 0x181AA9320
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x1AA9270 Offset: 0x1AA7C70 VA: 0x181AA9270
	internal static string CreateFromChar(char c) { }

	// RVA: 0xE5AAF0 Offset: 0xE594F0 VA: 0x180E5AAF0
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 3
	public override string ToString() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 24
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x1AB18E0 Offset: 0x1AB02E0 VA: 0x181AB18E0 Slot: 6
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x1AB1940 Offset: 0x1AB0340 VA: 0x181AB1940 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1AB2DD0 Offset: 0x1AB17D0 VA: 0x181AB2DD0
	internal static int wcslen(char* ptr) { }

	// RVA: 0x578D50 Offset: 0x577750 VA: 0x180578D50 Slot: 9
	public TypeCode GetTypeCode() { }

	// RVA: 0x1AB19A0 Offset: 0x1AB03A0 VA: 0x181AB19A0 Slot: 10
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x1AB1A60 Offset: 0x1AB0460 VA: 0x181AB1A60 Slot: 11
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1AB1D20 Offset: 0x1AB0720 VA: 0x181AB1D20 Slot: 12
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1AB1A00 Offset: 0x1AB0400 VA: 0x181AB1A00 Slot: 13
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1AB1C00 Offset: 0x1AB0600 VA: 0x181AB1C00 Slot: 14
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1AB1E50 Offset: 0x1AB0850 VA: 0x181AB1E50 Slot: 15
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1AB1C60 Offset: 0x1AB0660 VA: 0x181AB1C60 Slot: 16
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1AB1EB0 Offset: 0x1AB08B0 VA: 0x181AB1EB0 Slot: 17
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1AB1CC0 Offset: 0x1AB06C0 VA: 0x181AB1CC0 Slot: 18
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1AB1F10 Offset: 0x1AB0910 VA: 0x181AB1F10 Slot: 19
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1AB1D80 Offset: 0x1AB0780 VA: 0x181AB1D80 Slot: 20
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1AB1BA0 Offset: 0x1AB05A0 VA: 0x181AB1BA0 Slot: 21
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1AB1B20 Offset: 0x1AB0520 VA: 0x181AB1B20 Slot: 22
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1AB1AC0 Offset: 0x1AB04C0 VA: 0x181AB1AC0 Slot: 23
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1AB1DE0 Offset: 0x1AB07E0 VA: 0x181AB1DE0 Slot: 25
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x1AAF130 Offset: 0x1AADB30 VA: 0x181AAF130
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Length() { }

	// RVA: 0x1AAC780 Offset: 0x1AAB180 VA: 0x181AAC780
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x1AAC590 Offset: 0x1AAAF90 VA: 0x181AAC590
	internal int IndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	// RVA: 0x1AAE310 Offset: 0x1AACD10 VA: 0x181AAE310
	internal int LastIndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x1AAE130 Offset: 0x1AACB30 VA: 0x181AAE130
	internal int LastIndexOfUncheckedIgnoreCase(string value, int startIndex, int count) { }

	// RVA: 0x1AB11D0 Offset: 0x1AAFBD0 VA: 0x181AB11D0
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x1AAB280 Offset: 0x1AA9C80 VA: 0x181AAB280
	internal static string FastAllocateString(int length) { }

	// RVA: 0x1AAD110 Offset: 0x1AABB10 VA: 0x181AAD110
	private static string InternalIntern(string str) { }

	// RVA: 0x1AB2C10 Offset: 0x1AB1610 VA: 0x181AB2C10
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x1AB2C00 Offset: 0x1AB1600 VA: 0x181AB2C00
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x1AB2A80 Offset: 0x1AB1480 VA: 0x181AB2A80
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x1AB2A60 Offset: 0x1AB1460 VA: 0x181AB2A60
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x1AB2A70 Offset: 0x1AB1470 VA: 0x181AB2A70
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x186E7B0 Offset: 0x186D1B0 VA: 0x18186E7B0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0xC7BFF0 Offset: 0xC7A9F0 VA: 0x180C7BFF0
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x1AB2BC0 Offset: 0x1AB15C0 VA: 0x181AB2BC0
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x1AB2BD0 Offset: 0x1AB15D0 VA: 0x181AB2BD0
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x1AB2BE0 Offset: 0x1AB15E0 VA: 0x181AB2BE0
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x1AB2BF0 Offset: 0x1AB15F0 VA: 0x181AB2BF0
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x1AA97D0 Offset: 0x1AA81D0 VA: 0x181AA97D0
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x1AA94F0 Offset: 0x1AA7EF0 VA: 0x181AA94F0
	private string CreateString(char* value) { }

	// RVA: 0x1AA9660 Offset: 0x1AA8060 VA: 0x181AA9660
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x1AA97F0 Offset: 0x1AA81F0 VA: 0x181AA97F0
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x1AA9810 Offset: 0x1AA8210 VA: 0x181AA9810
	private string CreateString(char[] val) { }

	// RVA: 0x1AA96B0 Offset: 0x1AA80B0 VA: 0x181AA96B0
	private string CreateString(char c, int count) { }

	// RVA: 0x1AA9680 Offset: 0x1AA8080 VA: 0x181AA9680
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x1AA9410 Offset: 0x1AA7E10 VA: 0x181AA9410
	private string CreateString(ReadOnlySpan<char> value) { }

	[Intrinsic]
	// RVA: 0x1AB2B70 Offset: 0x1AB1570 VA: 0x181AB2B70
	public char get_Chars(int index) { }

	// RVA: 0x1AAD0A0 Offset: 0x1AABAA0 VA: 0x181AAD0A0
	public static string Intern(string str) { }
}
