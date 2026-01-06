internal struct XmlCharType // TypeDefIndex: 8091
{
	// Fields
	private static object s_Lock; // 0x0
	private static byte[] s_CharProperties; // 0x8
	internal byte[] charProperties; // 0x0

	// Properties
	private static object StaticLock { get; }
	public static XmlCharType Instance { get; }

	// Methods

	// RVA: 0x2531180 Offset: 0x252FB80 VA: 0x182531180
	private static object get_StaticLock() { }

	// RVA: 0x2530420 Offset: 0x252EE20 VA: 0x182530420
	private static void InitInstance() { }

	// RVA: 0x2530FF0 Offset: 0x252F9F0 VA: 0x182530FF0
	private static void SetProperties(byte[] chProps, string ranges, byte value) { }

	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	private void .ctor(byte[] charProperties) { }

	// RVA: 0x2531100 Offset: 0x252FB00 VA: 0x182531100
	public static XmlCharType get_Instance() { }

	// RVA: 0x2530FB0 Offset: 0x252F9B0 VA: 0x182530FB0
	public bool IsWhiteSpace(char ch) { }

	// RVA: 0x2530AD0 Offset: 0x252F4D0 VA: 0x182530AD0
	public bool IsNCNameSingleChar(char ch) { }

	// RVA: 0x2530F20 Offset: 0x252F920 VA: 0x182530F20
	public bool IsStartNCNameSingleChar(char ch) { }

	// RVA: 0x2530B50 Offset: 0x252F550 VA: 0x182530B50
	public bool IsNameSingleChar(char ch) { }

	// RVA: 0x25309F0 Offset: 0x252F3F0 VA: 0x1825309F0
	public bool IsCharData(char ch) { }

	// RVA: 0x2530DF0 Offset: 0x252F7F0 VA: 0x182530DF0
	public bool IsPubidChar(char ch) { }

	// RVA: 0x2530F70 Offset: 0x252F970 VA: 0x182530F70
	internal bool IsTextChar(char ch) { }

	// RVA: 0x2530A40 Offset: 0x252F440 VA: 0x182530A40
	public bool IsLetter(char ch) { }

	// RVA: 0x2530A90 Offset: 0x252F490 VA: 0x182530A90
	public bool IsNCNameCharXml4e(char ch) { }

	// RVA: 0x2530EE0 Offset: 0x252F8E0 VA: 0x182530EE0
	public bool IsStartNCNameCharXml4e(char ch) { }

	// RVA: 0x2530B10 Offset: 0x252F510 VA: 0x182530B10
	public bool IsNameCharXml4e(char ch) { }

	// RVA: 0x1C502A0 Offset: 0x1C4ECA0 VA: 0x181C502A0
	public static bool IsDigit(char ch) { }

	// RVA: 0x2530A30 Offset: 0x252F430 VA: 0x182530A30
	internal static bool IsHighSurrogate(int ch) { }

	// RVA: 0x2530A80 Offset: 0x252F480 VA: 0x182530A80
	internal static bool IsLowSurrogate(int ch) { }

	// RVA: 0x2530F60 Offset: 0x252F960 VA: 0x182530F60
	internal static bool IsSurrogate(int ch) { }

	// RVA: 0x2530400 Offset: 0x252EE00 VA: 0x182530400
	internal static int CombineSurrogateChar(int lowChar, int highChar) { }

	// RVA: 0x25310C0 Offset: 0x252FAC0 VA: 0x1825310C0
	internal static void SplitSurrogateChar(int combinedChar, out char lowChar, out char highChar) { }

	// RVA: 0x2530D60 Offset: 0x252F760 VA: 0x182530D60
	internal bool IsOnlyWhitespace(string str) { }

	// RVA: 0x2530CE0 Offset: 0x252F6E0 VA: 0x182530CE0
	internal int IsOnlyWhitespaceWithPos(string str) { }

	// RVA: 0x2530B90 Offset: 0x252F590 VA: 0x182530B90
	internal int IsOnlyCharData(string str) { }

	// RVA: 0x2530C60 Offset: 0x252F660 VA: 0x182530C60
	internal static bool IsOnlyDigits(string str, int startPos, int len) { }

	// RVA: 0x2530E70 Offset: 0x252F870 VA: 0x182530E70
	internal int IsPublicId(string str) { }

	// RVA: 0x1AC9D20 Offset: 0x1AC8720 VA: 0x181AC9D20
	private static bool InRange(int value, int start, int end) { }
}
