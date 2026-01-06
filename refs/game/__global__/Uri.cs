public class Uri : ISerializable // TypeDefIndex: 9503
{
	// Fields
	public static readonly string UriSchemeFile; // 0x0
	public static readonly string UriSchemeFtp; // 0x8
	public static readonly string UriSchemeGopher; // 0x10
	public static readonly string UriSchemeHttp; // 0x18
	public static readonly string UriSchemeHttps; // 0x20
	internal static readonly string UriSchemeWs; // 0x28
	internal static readonly string UriSchemeWss; // 0x30
	public static readonly string UriSchemeMailto; // 0x38
	public static readonly string UriSchemeNews; // 0x40
	public static readonly string UriSchemeNntp; // 0x48
	public static readonly string UriSchemeNetTcp; // 0x50
	public static readonly string UriSchemeNetPipe; // 0x58
	public static readonly string SchemeDelimiter; // 0x60
	private const int c_Max16BitUtf8SequenceLength = 12;
	internal const int c_MaxUriBufferSize = 65520;
	private const int c_MaxUriSchemeName = 1024;
	private string m_String; // 0x10
	private string m_originalUnicodeString; // 0x18
	private UriParser m_Syntax; // 0x20
	private string m_DnsSafeHost; // 0x28
	private Uri.Flags m_Flags; // 0x30
	private Uri.UriInfo m_Info; // 0x38
	private bool m_iriParsing; // 0x40
	private static bool s_ConfigInitialized; // 0x68
	private static bool s_ConfigInitializing; // 0x69
	private static UriIdnScope s_IdnScope; // 0x6C
	private static bool s_IriParsing; // 0x70
	private static bool useDotNetRelativeOrAbsolute; // 0x71
	private const UriKind DotNetRelativeOrAbsolute = 300;
	internal static readonly bool IsWindowsFileSystem; // 0x72
	private static object s_initLock; // 0x78
	private const UriFormat V1ToStringUnescape = 32767;
	internal const char c_DummyChar = '\xffff';
	internal const char c_EOL = '\xfffe';
	internal static readonly char[] HexLowerChars; // 0x80
	private static readonly char[] _WSchars; // 0x88

	// Properties
	private bool IsImplicitFile { get; }
	private bool IsUncOrDosPath { get; }
	private bool IsDosPath { get; }
	private bool IsUncPath { get; }
	private Uri.Flags HostType { get; }
	private UriParser Syntax { get; }
	private bool IsNotAbsoluteUri { get; }
	private bool AllowIdn { get; }
	internal bool UserDrivenParsing { get; }
	private ushort SecuredPathIndex { get; }
	public string AbsolutePath { get; }
	private string PrivateAbsolutePath { get; }
	public string AbsoluteUri { get; }
	public string LocalPath { get; }
	public string Authority { get; }
	public UriHostNameType HostNameType { get; }
	public bool IsDefaultPort { get; }
	public bool IsFile { get; }
	public bool IsLoopback { get; }
	public string PathAndQuery { get; }
	public string[] Segments { get; }
	public bool IsUnc { get; }
	public string Host { get; }
	private static object InitializeLock { get; }
	public int Port { get; }
	public string Query { get; }
	public string Fragment { get; }
	public string Scheme { get; }
	private bool OriginalStringSwitched { get; }
	public string OriginalString { get; }
	public string DnsSafeHost { get; }
	public bool IsAbsoluteUri { get; }
	public bool UserEscaped { get; }
	public string UserInfo { get; }
	internal bool HasAuthority { get; }

	// Methods

	// RVA: 0x25A6A10 Offset: 0x25A5410 VA: 0x1825A6A10
	private bool get_IsImplicitFile() { }

	// RVA: 0x25A6AF0 Offset: 0x25A54F0 VA: 0x1825A6AF0
	private bool get_IsUncOrDosPath() { }

	// RVA: 0x25A6930 Offset: 0x25A5330 VA: 0x1825A6930
	private bool get_IsDosPath() { }

	// RVA: 0x25A6B00 Offset: 0x25A5500 VA: 0x1825A6B00
	private bool get_IsUncPath() { }

	// RVA: 0x25A66A0 Offset: 0x25A50A0 VA: 0x1825A66A0
	private Uri.Flags get_HostType() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	private UriParser get_Syntax() { }

	// RVA: 0x25A6AE0 Offset: 0x25A54E0 VA: 0x1825A6AE0
	private bool get_IsNotAbsoluteUri() { }

	// RVA: 0x25A0870 Offset: 0x259F270 VA: 0x1825A0870
	internal static bool IriParsingStatic(UriParser syntax) { }

	// RVA: 0x25A5F60 Offset: 0x25A4960 VA: 0x1825A5F60
	private bool get_AllowIdn() { }

	// RVA: 0x2596C50 Offset: 0x2595650 VA: 0x182596C50
	private bool AllowIdnStatic(UriParser syntax, Uri.Flags flags) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private bool IsIntranet(string schemeHost) { }

	// RVA: 0x25A7410 Offset: 0x25A5E10 VA: 0x1825A7410
	internal bool get_UserDrivenParsing() { }

	// RVA: 0x25A4340 Offset: 0x25A2D40 VA: 0x1825A4340
	private void SetUserDrivenParsing() { }

	// RVA: 0x25A7190 Offset: 0x25A5B90 VA: 0x1825A7190
	private ushort get_SecuredPathIndex() { }

	// RVA: 0x25A0F70 Offset: 0x259F970 VA: 0x1825A0F70
	private bool NotAny(Uri.Flags flags) { }

	// RVA: 0x259F490 Offset: 0x259DE90 VA: 0x18259F490
	private bool InFact(Uri.Flags flags) { }

	// RVA: 0x25A4390 Offset: 0x25A2D90 VA: 0x1825A4390
	private static bool StaticNotAny(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x25A4360 Offset: 0x25A2D60 VA: 0x1825A4360
	private static bool StaticInFact(Uri.Flags allFlags, Uri.Flags checkFlags) { }

	// RVA: 0x259BBB0 Offset: 0x259A5B0 VA: 0x18259BBB0
	private Uri.UriInfo EnsureUriInfo() { }

	// RVA: 0x259BB90 Offset: 0x259A590 VA: 0x18259BB90
	private void EnsureParseRemaining() { }

	// RVA: 0x259BB20 Offset: 0x259A520 VA: 0x18259BB20
	private void EnsureHostString(bool allowDnsOptimization) { }

	// RVA: 0x25A5850 Offset: 0x25A4250 VA: 0x1825A5850
	public void .ctor(string uriString) { }

	// RVA: 0x25A5540 Offset: 0x25A3F40 VA: 0x1825A5540
	public void .ctor(string uriString, UriKind uriKind) { }

	// RVA: 0x25A59E0 Offset: 0x25A43E0 VA: 0x1825A59E0
	public void .ctor(Uri baseUri, string relativeUri) { }

	// RVA: 0x259B7D0 Offset: 0x259A1D0 VA: 0x18259B7D0
	private void CreateUri(Uri baseUri, string relativeUri, bool dontEscape) { }

	// RVA: 0x25A55E0 Offset: 0x25A3FE0 VA: 0x1825A55E0
	public void .ctor(Uri baseUri, Uri relativeUri) { }

	// RVA: 0x259CD50 Offset: 0x259B750 VA: 0x18259CD50
	private static ParsingError GetCombinedString(Uri baseUri, string relativeStr, bool dontEscape, ref string result) { }

	// RVA: 0x259D580 Offset: 0x259BF80 VA: 0x18259D580
	private static UriFormatException GetException(ParsingError err) { }

	// RVA: 0x25A5AD0 Offset: 0x25A44D0 VA: 0x1825A5AD0
	protected void .ctor(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x259E5F0 Offset: 0x259CFF0 VA: 0x18259E5F0 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x259E5F0 Offset: 0x259CFF0 VA: 0x18259E5F0
	protected void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext) { }

	// RVA: 0x25A5D40 Offset: 0x25A4740 VA: 0x1825A5D40
	public string get_AbsolutePath() { }

	// RVA: 0x25A6EC0 Offset: 0x25A58C0 VA: 0x1825A6EC0
	private string get_PrivateAbsolutePath() { }

	// RVA: 0x25A5E10 Offset: 0x25A4810 VA: 0x1825A5E10
	public string get_AbsoluteUri() { }

	// RVA: 0x25A6BA0 Offset: 0x25A55A0 VA: 0x1825A6BA0
	public string get_LocalPath() { }

	// RVA: 0x25A6050 Offset: 0x25A4A50 VA: 0x1825A6050
	public string get_Authority() { }

	// RVA: 0x25A6550 Offset: 0x25A4F50 VA: 0x1825A6550
	public UriHostNameType get_HostNameType() { }

	// RVA: 0x25A6830 Offset: 0x25A5230 VA: 0x1825A6830
	public bool get_IsDefaultPort() { }

	// RVA: 0x25A6940 Offset: 0x25A5340 VA: 0x1825A6940
	public bool get_IsFile() { }

	// RVA: 0x25A6A20 Offset: 0x25A5420 VA: 0x1825A6A20
	public bool get_IsLoopback() { }

	// RVA: 0x25A6CE0 Offset: 0x25A56E0 VA: 0x1825A6CE0
	public string get_PathAndQuery() { }

	// RVA: 0x25A71F0 Offset: 0x25A5BF0 VA: 0x1825A71F0
	public string[] get_Segments() { }

	// RVA: 0x25A6B10 Offset: 0x25A5510 VA: 0x1825A6B10
	public bool get_IsUnc() { }

	// RVA: 0x25A66B0 Offset: 0x25A50B0 VA: 0x1825A66B0
	public string get_Host() { }

	// RVA: 0x25A4370 Offset: 0x25A2D70 VA: 0x1825A4370
	private static bool StaticIsFile(UriParser syntax) { }

	// RVA: 0x25A6740 Offset: 0x25A5140 VA: 0x1825A6740
	private static object get_InitializeLock() { }

	// RVA: 0x259F4A0 Offset: 0x259DEA0 VA: 0x18259F4A0
	private static void InitializeUriConfig() { }

	// RVA: 0x259DD90 Offset: 0x259C790 VA: 0x18259DD90
	private string GetLocalPath() { }

	// RVA: 0x25A6DB0 Offset: 0x25A57B0 VA: 0x1825A6DB0
	public int get_Port() { }

	// RVA: 0x25A6FB0 Offset: 0x25A59B0 VA: 0x1825A6FB0
	public string get_Query() { }

	// RVA: 0x25A63F0 Offset: 0x25A4DF0 VA: 0x1825A63F0
	public string get_Fragment() { }

	// RVA: 0x25A7100 Offset: 0x25A5B00 VA: 0x1825A7100
	public string get_Scheme() { }

	// RVA: 0x25A6C20 Offset: 0x25A5620 VA: 0x1825A6C20
	private bool get_OriginalStringSwitched() { }

	// RVA: 0x25A6C80 Offset: 0x25A5680 VA: 0x1825A6C80
	public string get_OriginalString() { }

	// RVA: 0x25A60E0 Offset: 0x25A4AE0 VA: 0x1825A60E0
	public string get_DnsSafeHost() { }

	// RVA: 0x6208C0 Offset: 0x61F2C0 VA: 0x1806208C0
	public bool get_IsAbsoluteUri() { }

	// RVA: 0x25A7420 Offset: 0x25A5E20 VA: 0x1825A7420
	public bool get_UserEscaped() { }

	// RVA: 0x25A7430 Offset: 0x25A5E30 VA: 0x1825A7430
	public string get_UserInfo() { }

	// RVA: 0x25A0D20 Offset: 0x259F720 VA: 0x1825A0D20
	internal static bool IsGenDelim(char ch) { }

	// RVA: 0x2599400 Offset: 0x2597E00 VA: 0x182599400
	public static bool CheckSchemeName(string schemeName) { }

	// RVA: 0x25A0D50 Offset: 0x259F750 VA: 0x1825A0D50
	public static bool IsHexDigit(char character) { }

	// RVA: 0x259C4F0 Offset: 0x259AEF0 VA: 0x18259C4F0
	public static int FromHex(char digit) { }

	// RVA: 0x259D730 Offset: 0x259C130 VA: 0x18259D730 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x25A4520 Offset: 0x25A2F20 VA: 0x1825A4520 Slot: 3
	public override string ToString() { }

	// RVA: 0x25A74C0 Offset: 0x25A5EC0 VA: 0x1825A74C0
	public static bool op_Equality(Uri uri1, Uri uri2) { }

	// RVA: 0x25A7500 Offset: 0x25A5F00 VA: 0x1825A7500
	public static bool op_Inequality(Uri uri1, Uri uri2) { }

	// RVA: 0x259BBF0 Offset: 0x259A5F0 VA: 0x18259BBF0 Slot: 0
	public override bool Equals(object comparand) { }

	// RVA: 0x2598A80 Offset: 0x2597480 VA: 0x182598A80
	private static bool CheckForColonInFirstPathSegment(string uriString) { }

	// RVA: 0x25A0230 Offset: 0x259EC30 VA: 0x1825A0230
	internal static string InternalEscapeString(string rawString) { }

	// RVA: 0x25A2250 Offset: 0x25A0C50 VA: 0x1825A2250
	private static ParsingError ParseScheme(string uriString, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x25A0F80 Offset: 0x259F980 VA: 0x1825A0F80
	internal UriFormatException ParseMinimal() { }

	// RVA: 0x25A2460 Offset: 0x25A0E60 VA: 0x1825A2460
	private ParsingError PrivateParseMinimal() { }

	// RVA: 0x25A2340 Offset: 0x25A0D40 VA: 0x1825A2340
	private void PrivateParseMinimalIri(string newHost, ushort idx) { }

	// RVA: 0x259B230 Offset: 0x2599C30 VA: 0x18259B230
	private void CreateUriInfo(Uri.Flags cF) { }

	// RVA: 0x259AA30 Offset: 0x2599430 VA: 0x18259AA30
	private void CreateHostString() { }

	// RVA: 0x259A820 Offset: 0x2599220 VA: 0x18259A820
	private static string CreateHostStringHelper(string str, ushort idx, ushort end, ref Uri.Flags flags, ref string scopeId) { }

	// RVA: 0x259D8E0 Offset: 0x259C2E0 VA: 0x18259D8E0
	private void GetHostViaCustomSyntax() { }

	// RVA: 0x259E6E0 Offset: 0x259D0E0 VA: 0x18259E6E0
	internal string GetParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x259D490 Offset: 0x259BE90 VA: 0x18259D490
	private string GetEscapedParts(UriComponents uriParts) { }

	// RVA: 0x259EAD0 Offset: 0x259D4D0 VA: 0x18259EAD0
	private string GetUnescapedParts(UriComponents uriParts, UriFormat formatAs) { }

	// RVA: 0x25A2BD0 Offset: 0x25A15D0 VA: 0x1825A2BD0
	private string ReCreateParts(UriComponents parts, ushort nonCanonical, UriFormat formatAs) { }

	// RVA: 0x259EBA0 Offset: 0x259D5A0 VA: 0x18259EBA0
	private string GetUriPartsFromUserString(UriComponents uriParts) { }

	// RVA: 0x25A1000 Offset: 0x259FA00 VA: 0x1825A1000
	private void ParseRemaining() { }

	// RVA: 0x25A1D90 Offset: 0x25A0790 VA: 0x1825A1D90
	private static ushort ParseSchemeCheckImplicitFile(char* uriString, ushort length, ref ParsingError err, ref Uri.Flags flags, ref UriParser syntax) { }

	// RVA: 0x2598EE0 Offset: 0x25978E0 VA: 0x182598EE0
	private static bool CheckKnownSchemes(long* lptr, ushort nChars, ref UriParser syntax) { }

	// RVA: 0x2599570 Offset: 0x2597F70 VA: 0x182599570
	private static ParsingError CheckSchemeSyntax(char* ptr, ushort length, ref UriParser syntax) { }

	// RVA: 0x2597650 Offset: 0x2596050 VA: 0x182597650
	private ushort CheckAuthorityHelper(char* pString, ushort idx, ushort length, ref ParsingError err, ref Uri.Flags flags, UriParser syntax, ref string newHost) { }

	// RVA: 0x2597100 Offset: 0x2595B00 VA: 0x182597100
	private void CheckAuthorityHelperHandleDnsIri(char* pString, ushort start, int end, int startInput, bool iriParsing, bool hasUnicode, UriParser syntax, string userInfoString, ref Uri.Flags flags, ref bool justNormalized, ref string newHost, ref ParsingError err) { }

	// RVA: 0x2596E00 Offset: 0x2595800 VA: 0x182596E00
	private void CheckAuthorityHelperHandleAnyHostIri(char* pString, int startInput, int end, bool iriParsing, bool hasUnicode, UriParser syntax, ref Uri.Flags flags, ref string newHost, ref ParsingError err) { }

	// RVA: 0x259C440 Offset: 0x259AE40 VA: 0x18259C440
	private void FindEndOfComponent(string input, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x259C3A0 Offset: 0x259ADA0 VA: 0x18259C3A0
	private void FindEndOfComponent(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x2598680 Offset: 0x2597080 VA: 0x182598680
	private Uri.Check CheckCanonical(char* str, ref ushort idx, ushort end, char delim) { }

	// RVA: 0x259C590 Offset: 0x259AF90 VA: 0x18259C590
	private char[] GetCanonicalPath(char[] dest, ref int pos, UriFormat formatAs) { }

	// RVA: 0x25A4D70 Offset: 0x25A3770 VA: 0x1825A4D70
	private static void UnescapeOnly(char* pch, int start, ref int end, char ch1, char ch2, char ch3) { }

	// RVA: 0x259A080 Offset: 0x2598A80 VA: 0x18259A080
	private static char[] Compress(char[] dest, ushort start, ref int destLength, UriParser syntax) { }

	// RVA: 0x2596D50 Offset: 0x2595750 VA: 0x182596D50
	internal static int CalculateCaseInsensitiveHashCode(string text) { }

	// RVA: 0x2599690 Offset: 0x2598090 VA: 0x182599690
	private static string CombineUri(Uri basePart, string relativePart, UriFormat uriFormat) { }

	// RVA: 0x25A6540 Offset: 0x25A4F40 VA: 0x1825A6540
	internal bool get_HasAuthority() { }

	// RVA: 0x25A0D80 Offset: 0x259F780 VA: 0x1825A0D80
	private static bool IsLWS(char ch) { }

	// RVA: 0x25A0990 Offset: 0x259F390 VA: 0x1825A0990
	private static bool IsAsciiLetter(char character) { }

	// RVA: 0x25A0910 Offset: 0x259F310 VA: 0x1825A0910
	internal static bool IsAsciiLetterOrDigit(char character) { }

	// RVA: 0x25A0CE0 Offset: 0x259F6E0 VA: 0x1825A0CE0
	internal static bool IsBidiControlCharacter(char ch) { }

	// RVA: 0x25A43A0 Offset: 0x25A2DA0 VA: 0x1825A43A0
	internal static string StripBidiControlCharacter(char* strToClean, int start, int length) { }

	// RVA: 0x259B050 Offset: 0x2599A50 VA: 0x18259B050
	private void CreateThis(string uri, bool dontEscape, UriKind uriKind) { }

	// RVA: 0x259F700 Offset: 0x259E100 VA: 0x18259F700
	private void InitializeUri(ParsingError err, UriKind uriKind, out UriFormatException e) { }

	// RVA: 0x2598B30 Offset: 0x2597530 VA: 0x182598B30
	private bool CheckForConfigLoad(string data) { }

	// RVA: 0x2598D90 Offset: 0x2597790 VA: 0x182598D90
	private bool CheckForUnicode(string data) { }

	// RVA: 0x2598BF0 Offset: 0x25975F0 VA: 0x182598BF0
	private bool CheckForEscapedUnreserved(string data) { }

	// RVA: 0x25A4640 Offset: 0x25A3040 VA: 0x1825A4640
	public static bool TryCreate(string uriString, UriKind uriKind, out Uri result) { }

	// RVA: 0x25A4720 Offset: 0x25A3120 VA: 0x1825A4720
	public static bool TryCreate(Uri baseUri, string relativeUri, out Uri result) { }

	// RVA: 0x25A4A10 Offset: 0x25A3410 VA: 0x1825A4A10
	public static bool TryCreate(Uri baseUri, Uri relativeUri, out Uri result) { }

	// RVA: 0x259D290 Offset: 0x259BC90 VA: 0x18259D290
	public string GetComponents(UriComponents components, UriFormat format) { }

	// RVA: 0x25A0DB0 Offset: 0x259F7B0 VA: 0x1825A0DB0
	public bool IsWellFormedOriginalString() { }

	// RVA: 0x25A0E00 Offset: 0x259F800 VA: 0x1825A0E00
	public static bool IsWellFormedUriString(string uriString, UriKind uriKind) { }

	// RVA: 0x25A0320 Offset: 0x259ED20 VA: 0x1825A0320
	internal bool InternalIsWellFormedOriginalString() { }

	// RVA: 0x25A4BC0 Offset: 0x25A35C0 VA: 0x1825A4BC0
	public static string UnescapeDataString(string stringToUnescape) { }

	// RVA: 0x259C340 Offset: 0x259AD40 VA: 0x18259C340
	internal string EscapeUnescapeIri(string input, int start, int end, UriComponents component) { }

	// RVA: 0x25A5980 Offset: 0x25A4380 VA: 0x1825A5980
	private void .ctor(Uri.Flags flags, UriParser uriParser, string uri) { }

	// RVA: 0x259A540 Offset: 0x2598F40 VA: 0x18259A540
	internal static Uri CreateHelper(string uriString, bool dontEscape, UriKind uriKind, ref UriFormatException e) { }

	// RVA: 0x25A3DF0 Offset: 0x25A27F0 VA: 0x1825A3DF0
	internal static Uri ResolveHelper(Uri baseUri, Uri relativeUri, ref string newUriString, ref bool userEscaped, out UriFormatException e) { }

	// RVA: 0x259E6F0 Offset: 0x259D0F0 VA: 0x18259E6F0
	private string GetRelativeSerializationString(UriFormat format) { }

	// RVA: 0x259CF70 Offset: 0x259B970 VA: 0x18259CF70
	internal string GetComponentsHelper(UriComponents uriComponents, UriFormat uriFormat) { }

	// RVA: 0x25A0C10 Offset: 0x259F610 VA: 0x1825A0C10
	public bool IsBaseOf(Uri uri) { }

	// RVA: 0x25A09B0 Offset: 0x259F3B0 VA: 0x1825A09B0
	internal bool IsBaseOfHelper(Uri uriLink) { }

	// RVA: 0x259AEA0 Offset: 0x25998A0 VA: 0x18259AEA0
	private void CreateThisFromUri(Uri otherUri) { }

	// RVA: 0x25A4F70 Offset: 0x25A3970 VA: 0x1825A4F70
	private static void .cctor() { }
}
