internal sealed class RegexCharClass // TypeDefIndex: 9559
{
	// Fields
	private static readonly string s_internalRegexIgnoreCase; // 0x0
	private static readonly string s_space; // 0x8
	private static readonly string s_notSpace; // 0x10
	private static readonly string s_word; // 0x18
	private static readonly string s_notWord; // 0x20
	public static readonly string SpaceClass; // 0x28
	public static readonly string NotSpaceClass; // 0x30
	public static readonly string WordClass; // 0x38
	public static readonly string NotWordClass; // 0x40
	public static readonly string DigitClass; // 0x48
	public static readonly string NotDigitClass; // 0x50
	private static readonly Dictionary<string, string> s_definedCategories; // 0x58
	private static readonly string[][] s_propTable; // 0x60
	private static readonly RegexCharClass.LowerCaseMapping[] s_lcTable; // 0x68
	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28

	// Properties
	public bool CanMerge { get; }
	public bool Negate { set; }

	// Methods

	// RVA: 0x2620DE0 Offset: 0x261F7E0 VA: 0x182620DE0
	public void .ctor() { }

	// RVA: 0x2620EA0 Offset: 0x261F8A0 VA: 0x182620EA0
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x2620F20 Offset: 0x261F920 VA: 0x182620F20
	public bool get_CanMerge() { }

	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	public void set_Negate(bool value) { }

	// RVA: 0x26192D0 Offset: 0x2617CD0 VA: 0x1826192D0
	public void AddChar(char c) { }

	// RVA: 0x26190B0 Offset: 0x2617AB0 VA: 0x1826190B0
	public void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x2619850 Offset: 0x2618250 VA: 0x182619850
	private void AddSet(string set) { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x2619740 Offset: 0x2618140 VA: 0x182619740
	public void AddRange(char first, char last) { }

	// RVA: 0x2618E00 Offset: 0x2617800 VA: 0x182618E00
	public void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x2619090 Offset: 0x2617A90 VA: 0x182619090
	private void AddCategory(string category) { }

	// RVA: 0x26195F0 Offset: 0x2617FF0 VA: 0x1826195F0
	public void AddLowercase(CultureInfo culture) { }

	// RVA: 0x2619390 Offset: 0x2617D90 VA: 0x182619390
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x2619BB0 Offset: 0x26185B0 VA: 0x182619BB0
	public void AddWord(bool ecma, bool negate) { }

	// RVA: 0x2619A80 Offset: 0x2618480 VA: 0x182619A80
	public void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x26192E0 Offset: 0x2617CE0 VA: 0x1826192E0
	public void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x261B120 Offset: 0x2619B20 VA: 0x18261B120
	public static char SingletonChar(string set) { }

	// RVA: 0x261A6C0 Offset: 0x26190C0 VA: 0x18261A6C0
	public static bool IsMergeable(string charClass) { }

	// RVA: 0x261A5E0 Offset: 0x2618FE0 VA: 0x18261A5E0
	public static bool IsEmpty(string charClass) { }

	// RVA: 0x261A900 Offset: 0x2619300 VA: 0x18261A900
	public static bool IsSingleton(string set) { }

	// RVA: 0x261A7C0 Offset: 0x26191C0 VA: 0x18261A7C0
	public static bool IsSingletonInverse(string set) { }

	// RVA: 0x261AA40 Offset: 0x2619440 VA: 0x18261AA40
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x261A790 Offset: 0x2619190 VA: 0x18261A790
	private static bool IsNegated(string set) { }

	// RVA: 0x261A540 Offset: 0x2618F40 VA: 0x18261A540
	public static bool IsECMAWordChar(char ch) { }

	// RVA: 0x261AAA0 Offset: 0x26194A0 VA: 0x18261AAA0
	public static bool IsWordChar(char ch) { }

	// RVA: 0x261A480 Offset: 0x2618E80 VA: 0x18261A480
	public static bool CharInClass(char ch, string set) { }

	// RVA: 0x261A350 Offset: 0x2618D50 VA: 0x18261A350
	private static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x261A150 Offset: 0x2618B50 VA: 0x18261A150
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x2619FE0 Offset: 0x26189E0 VA: 0x182619FE0
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x2619F10 Offset: 0x2618910 VA: 0x182619F10
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x261AB70 Offset: 0x2619570 VA: 0x18261AB70
	private static string NegateCategory(string category) { }

	// RVA: 0x261AE40 Offset: 0x2619840 VA: 0x18261AE40
	public static RegexCharClass Parse(string charClass) { }

	// RVA: 0x261AC00 Offset: 0x2619600 VA: 0x18261AC00
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x261AE90 Offset: 0x2619890 VA: 0x18261AE90
	private int RangeCount() { }

	// RVA: 0x261B140 Offset: 0x2619B40 VA: 0x18261B140
	public string ToStringClass() { }

	// RVA: 0x261A4E0 Offset: 0x2618EE0 VA: 0x18261A4E0
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x2619CE0 Offset: 0x26186E0 VA: 0x182619CE0
	private void Canonicalize() { }

	// RVA: 0x261AED0 Offset: 0x26198D0 VA: 0x18261AED0
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

	// RVA: 0x261B2F0 Offset: 0x2619CF0 VA: 0x18261B2F0
	private static void .cctor() { }
}
