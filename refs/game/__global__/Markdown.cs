public static class Markdown // TypeDefIndex: 17997
{
	// Fields
	private const string _H1 = "# ";
	private const string _H2 = "## ";
	private const string _H3 = "### ";
	private const string _H4 = "#### ";
	private const string _H5 = "##### ";
	private const string _H6 = "###### ";
	private const string _EM = "*";
	private const string _STRONG = "**";
	private const string _STRIKE = "~~";
	private const string _UL = "- ";
	private const string _OL = ". ";
	private const string _LINK_INLINE_PRE = "[";
	private const string _LINK_INLINE_MID = "](";
	private const string _LINK_INLINE_END = ")";
	private const string _IMG_INLINE_PRE = "![";
	private const string _IMG_INLINE_MID = "](";
	private const string _IMG_INLINE_END = ")";
	private const string _CODE_INLINE = "`";
	private const string _CODE_BLOCK = "```";
	private const string _QUOTE = "> ";
	private const string _HR = "---";
	private const string _ENDL = "\n";
	private const string _LB = "\n\n";
	public const string HR = "---";
	public const string LINE_BREAK = "\n\n";

	// Methods

	// RVA: 0x43FA50 Offset: 0x43E450 VA: 0x18043FA50
	public static string Header(string text, Markdown.HeaderLevel level = 0) { }

	// RVA: 0x43F750 Offset: 0x43E150 VA: 0x18043F750
	public static string H1(string text) { }

	// RVA: 0x43F7D0 Offset: 0x43E1D0 VA: 0x18043F7D0
	public static string H2(string text) { }

	// RVA: 0x43F850 Offset: 0x43E250 VA: 0x18043F850
	public static string H3(string text) { }

	// RVA: 0x43F8D0 Offset: 0x43E2D0 VA: 0x18043F8D0
	public static string H4(string text) { }

	// RVA: 0x43F950 Offset: 0x43E350 VA: 0x18043F950
	public static string H5(string text) { }

	// RVA: 0x43F9D0 Offset: 0x43E3D0 VA: 0x18043F9D0
	public static string H6(string text) { }

	// RVA: 0x43F710 Offset: 0x43E110 VA: 0x18043F710
	public static string Em(string text) { }

	// RVA: 0x440040 Offset: 0x43EA40 VA: 0x180440040
	public static string Strong(string text) { }

	// RVA: 0x440000 Offset: 0x43EA00 VA: 0x180440000
	public static string Strike(string text) { }

	// RVA: 0x440080 Offset: 0x43EA80 VA: 0x180440080
	public static string UnorderedList(string[] items) { }

	// RVA: 0x43FE80 Offset: 0x43E880 VA: 0x18043FE80
	public static string OrderedList(string[] items) { }

	// RVA: 0x43FC40 Offset: 0x43E640 VA: 0x18043FC40
	public static string Hyperlink(string text, string url) { }

	// RVA: 0x43FD60 Offset: 0x43E760 VA: 0x18043FD60
	public static string Image(string url, string alt = "") { }

	// RVA: 0x43F6D0 Offset: 0x43E0D0 VA: 0x18043F6D0
	public static string Code(string text) { }

	// RVA: 0x43F5B0 Offset: 0x43DFB0 VA: 0x18043F5B0
	public static string CodeBlock(string text, string language = "") { }

	// RVA: 0x43F570 Offset: 0x43DF70 VA: 0x18043F570
	public static string Blockquote(string text) { }
}
