internal class CookieTokenizer // TypeDefIndex: 10018
{
	// Fields
	private bool m_eofCookie; // 0x10
	private int m_index; // 0x14
	private int m_length; // 0x18
	private string m_name; // 0x20
	private bool m_quoted; // 0x28
	private int m_start; // 0x2C
	private CookieToken m_token; // 0x30
	private int m_tokenLength; // 0x34
	private string m_tokenStream; // 0x38
	private string m_value; // 0x40
	private static CookieTokenizer.RecognizedAttribute[] RecognizedAttributes; // 0x0
	private static CookieTokenizer.RecognizedAttribute[] RecognizedServerAttributes; // 0x8

	// Properties
	internal bool EndOfCookie { get; set; }
	internal bool Eof { get; }
	internal string Name { get; set; }
	internal bool Quoted { get; set; }
	internal CookieToken Token { get; set; }
	internal string Value { get; set; }

	// Methods

	// RVA: 0x26B9520 Offset: 0x26B7F20 VA: 0x1826B9520
	internal void .ctor(string tokenStream) { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	internal bool get_EndOfCookie() { }

	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	internal void set_EndOfCookie(bool value) { }

	// RVA: 0x26B9570 Offset: 0x26B7F70 VA: 0x1826B9570
	internal bool get_Eof() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal string get_Name() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_Name(string value) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	internal bool get_Quoted() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	internal void set_Quoted(bool value) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	internal CookieToken get_Token() { }

	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060
	internal void set_Token(CookieToken value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	internal string get_Value() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	internal void set_Value(string value) { }

	// RVA: 0x26B8730 Offset: 0x26B7130 VA: 0x1826B8730
	internal string Extract() { }

	// RVA: 0x26B87B0 Offset: 0x26B71B0 VA: 0x1826B87B0
	internal CookieToken FindNext(bool ignoreComma, bool ignoreEquals) { }

	// RVA: 0x26B8A20 Offset: 0x26B7420 VA: 0x1826B8A20
	internal CookieToken Next(bool first, bool parseResponseCookies) { }

	// RVA: 0x26B8CF0 Offset: 0x26B76F0 VA: 0x1826B8CF0
	internal void Reset() { }

	// RVA: 0x26B8D70 Offset: 0x26B7770 VA: 0x1826B8D70
	internal CookieToken TokenFromName(bool parseResponseCookies) { }

	// RVA: 0x26B8F70 Offset: 0x26B7970 VA: 0x1826B8F70
	private static void .cctor() { }
}
