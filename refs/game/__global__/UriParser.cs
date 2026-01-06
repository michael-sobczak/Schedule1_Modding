public abstract class UriParser // TypeDefIndex: 9515
{
	// Fields
	private const UriSyntaxFlags SchemeOnlyFlags = 16;
	private static readonly Dictionary<string, UriParser> m_Table; // 0x0
	private static Dictionary<string, UriParser> m_TempTable; // 0x8
	private UriSyntaxFlags m_Flags; // 0x10
	private UriSyntaxFlags m_UpdatableFlags; // 0x14
	private bool m_UpdatableFlagsUsed; // 0x18
	private const UriSyntaxFlags c_UpdatableFlags = 33554432;
	private int m_Port; // 0x1C
	private string m_Scheme; // 0x20
	internal const int NoDefaultPort = -1;
	private const int c_InitialTableSize = 25;
	internal static UriParser HttpUri; // 0x10
	internal static UriParser HttpsUri; // 0x18
	internal static UriParser WsUri; // 0x20
	internal static UriParser WssUri; // 0x28
	internal static UriParser FtpUri; // 0x30
	internal static UriParser FileUri; // 0x38
	internal static UriParser GopherUri; // 0x40
	internal static UriParser NntpUri; // 0x48
	internal static UriParser NewsUri; // 0x50
	internal static UriParser MailToUri; // 0x58
	internal static UriParser UuidUri; // 0x60
	internal static UriParser TelnetUri; // 0x68
	internal static UriParser LdapUri; // 0x70
	internal static UriParser NetTcpUri; // 0x78
	internal static UriParser NetPipeUri; // 0x80
	internal static UriParser VsMacrosUri; // 0x88
	private static readonly UriParser.UriQuirksVersion s_QuirksVersion; // 0x90
	private const int c_MaxCapacity = 512;
	private const UriSyntaxFlags UnknownV1SyntaxFlags = 351342590;
	private static readonly UriSyntaxFlags HttpSyntaxFlags; // 0x94
	private const UriSyntaxFlags FtpSyntaxFlags = 367005533;
	private static readonly UriSyntaxFlags FileSyntaxFlags; // 0x98
	private const UriSyntaxFlags VsmacrosSyntaxFlags = 399519697;
	private const UriSyntaxFlags GopherSyntaxFlags = 337645405;
	private const UriSyntaxFlags NewsSyntaxFlags = 268435536;
	private const UriSyntaxFlags NntpSyntaxFlags = 337645405;
	private const UriSyntaxFlags TelnetSyntaxFlags = 337645405;
	private const UriSyntaxFlags LdapSyntaxFlags = 337645565;
	private const UriSyntaxFlags MailtoSyntaxFlags = 335564796;
	private const UriSyntaxFlags NetPipeSyntaxFlags = 400559729;
	private const UriSyntaxFlags NetTcpSyntaxFlags = 400559737;

	// Properties
	internal string SchemeName { get; }
	internal int DefaultPort { get; }
	internal static bool ShouldUseLegacyV2Quirks { get; }
	internal UriSyntaxFlags Flags { get; }
	internal bool IsSimple { get; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal string get_SchemeName() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	internal int get_DefaultPort() { }

	// RVA: 0x260FE80 Offset: 0x260E880 VA: 0x18260FE80
	protected void .ctor() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 4
	protected virtual UriParser OnNewUri() { }

	// RVA: 0x260EC90 Offset: 0x260D690 VA: 0x18260EC90 Slot: 5
	protected virtual void InitializeAndValidate(Uri uri, out UriFormatException parsingError) { }

	// RVA: 0x260EF30 Offset: 0x260D930 VA: 0x18260EF30 Slot: 6
	protected virtual string Resolve(Uri baseUri, Uri relativeUri, out UriFormatException parsingError) { }

	// RVA: 0x260EE10 Offset: 0x260D810 VA: 0x18260EE10 Slot: 7
	protected virtual bool IsBaseOf(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x260E8D0 Offset: 0x260D2D0 VA: 0x18260E8D0 Slot: 8
	protected virtual string GetComponents(Uri uri, UriComponents components, UriFormat format) { }

	// RVA: 0x260EEB0 Offset: 0x260D8B0 VA: 0x18260EEB0 Slot: 9
	protected virtual bool IsWellFormedOriginalString(Uri uri) { }

	// RVA: 0x260FEF0 Offset: 0x260E8F0 VA: 0x18260FEF0
	internal static bool get_ShouldUseLegacyV2Quirks() { }

	// RVA: 0x260F150 Offset: 0x260DB50 VA: 0x18260F150
	private static void .cctor() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal UriSyntaxFlags get_Flags() { }

	// RVA: 0x260EED0 Offset: 0x260D8D0 VA: 0x18260EED0
	internal bool NotAny(UriSyntaxFlags flags) { }

	// RVA: 0x260EC30 Offset: 0x260D630 VA: 0x18260EC30
	internal bool InFact(UriSyntaxFlags flags) { }

	// RVA: 0x260EDB0 Offset: 0x260D7B0 VA: 0x18260EDB0
	internal bool IsAllSet(UriSyntaxFlags flags) { }

	// RVA: 0x260EE40 Offset: 0x260D840 VA: 0x18260EE40
	private bool IsFullMatch(UriSyntaxFlags flags, UriSyntaxFlags expected) { }

	// RVA: 0x260FE20 Offset: 0x260E820 VA: 0x18260FE20
	internal void .ctor(UriSyntaxFlags flags) { }

	// RVA: 0x260E590 Offset: 0x260CF90 VA: 0x18260E590
	internal static UriParser FindOrFetchAsUnknownV1Syntax(string lwrCaseScheme) { }

	// RVA: 0x260EB50 Offset: 0x260D550 VA: 0x18260EB50
	internal static UriParser GetSyntax(string lwrCaseScheme) { }

	// RVA: 0x260FEE0 Offset: 0x260E8E0 VA: 0x18260FEE0
	internal bool get_IsSimple() { }

	// RVA: 0x260ED10 Offset: 0x260D710 VA: 0x18260ED10
	internal UriParser InternalOnNewUri() { }

	// RVA: 0x260ED90 Offset: 0x260D790 VA: 0x18260ED90
	internal void InternalValidate(Uri thisUri, out UriFormatException parsingError) { }

	// RVA: 0x260ED70 Offset: 0x260D770 VA: 0x18260ED70
	internal string InternalResolve(Uri thisBaseUri, Uri uriLink, out UriFormatException parsingError) { }

	// RVA: 0x260ECF0 Offset: 0x260D6F0 VA: 0x18260ECF0
	internal bool InternalIsBaseOf(Uri thisBaseUri, Uri uriLink) { }

	// RVA: 0x260ECD0 Offset: 0x260D6D0 VA: 0x18260ECD0
	internal string InternalGetComponents(Uri thisUri, UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x2250F40 Offset: 0x224F940 VA: 0x182250F40
	internal bool InternalIsWellFormedOriginalString(Uri thisUri) { }
}
