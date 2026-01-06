internal class RTF // TypeDefIndex: 5212
{
	// Fields
	private TokenClass rtf_class; // 0x10
	private Major major; // 0x14
	private Minor minor; // 0x18
	private int param; // 0x1C
	private string encoded_text; // 0x20
	private Encoding encoding; // 0x28
	private int encoding_code_page; // 0x30
	private StringBuilder text_buffer; // 0x38
	private Picture picture; // 0x40
	private int line_num; // 0x48
	private int line_pos; // 0x4C
	private char pushed_char; // 0x50
	private TokenClass pushed_class; // 0x54
	private Major pushed_major; // 0x58
	private Minor pushed_minor; // 0x5C
	private int pushed_param; // 0x60
	private char prev_char; // 0x64
	private bool bump_line; // 0x66
	private Font font_list; // 0x68
	private Charset cur_charset; // 0x70
	private Stack charset_stack; // 0x78
	private Style styles; // 0x80
	private Color colors; // 0x88
	private Font fonts; // 0x90
	private StreamReader source; // 0x98
	private static Hashtable key_table; // 0x0
	private static KeyStruct[] Keys; // 0x8
	private DestinationCallback destination_callbacks; // 0xA0
	private ClassCallback class_callbacks; // 0xA8

	// Properties
	public TokenClass TokenClass { get; }
	public Major Major { get; }
	public Minor Minor { get; }
	public int Param { get; }
	public string Text { get; }
	public string EncodedText { get; }
	public Picture Picture { get; set; }
	public Color Colors { get; set; }
	public Style Styles { get; set; }
	public Font Fonts { get; set; }
	public ClassCallback ClassCallback { get; }
	public int LineNumber { get; }
	public int LinePos { get; }

	// Methods

	// RVA: 0x21D5610 Offset: 0x21D4010 VA: 0x1821D5610
	public void .ctor(Stream stream) { }

	// RVA: 0x21D5450 Offset: 0x21D3E50 VA: 0x1821D5450
	private static void .cctor() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public TokenClass get_TokenClass() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public Major get_Major() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public Minor get_Minor() { }

	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_Param() { }

	// RVA: 0x21D5A10 Offset: 0x21D4410 VA: 0x1821D5A10
	public string get_Text() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_EncodedText() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public Picture get_Picture() { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void set_Picture(Picture value) { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	public Color get_Colors() { }

	// RVA: 0x589030 Offset: 0x587A30 VA: 0x180589030
	public void set_Colors(Color value) { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	public Style get_Styles() { }

	// RVA: 0x6EA770 Offset: 0x6E9170 VA: 0x1806EA770
	public void set_Styles(Style value) { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	public Font get_Fonts() { }

	// RVA: 0x614510 Offset: 0x612F10 VA: 0x180614510
	public void set_Fonts(Font value) { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	public ClassCallback get_ClassCallback() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_LineNumber() { }

	// RVA: 0x4D60C0 Offset: 0x4D4AC0 VA: 0x1804D60C0
	public int get_LinePos() { }

	// RVA: 0x21D3170 Offset: 0x21D1B70 VA: 0x1821D3170
	public void DefaultFont(string name) { }

	// RVA: 0x21D3300 Offset: 0x21D1D00 VA: 0x1821D3300
	private char GetChar() { }

	// RVA: 0x21D3200 Offset: 0x21D1C00 VA: 0x1821D3200
	private char GetChar(bool skipCrLf) { }

	// RVA: 0x21D5110 Offset: 0x21D3B10 VA: 0x1821D5110
	public void Read() { }

	// RVA: 0x21D51B0 Offset: 0x21D3BB0 VA: 0x1821D51B0
	public void RouteToken() { }

	// RVA: 0x21D5310 Offset: 0x21D3D10 VA: 0x1821D5310
	public void SkipGroup() { }

	// RVA: 0x21D3820 Offset: 0x21D2220 VA: 0x1821D3820
	public TokenClass GetToken() { }

	// RVA: 0x21D3310 Offset: 0x21D1D10 VA: 0x1821D3310
	private void GetToken2() { }

	// RVA: 0x21D5240 Offset: 0x21D3C40 VA: 0x1821D5240
	public void SetToken(TokenClass cl, Major maj, Minor min, int par, string text) { }

	// RVA: 0x21D5370 Offset: 0x21D3D70 VA: 0x1821D5370
	public void UngetToken() { }

	// RVA: 0x21D3C60 Offset: 0x21D2660 VA: 0x1821D3C60
	public void Lookup(string token) { }

	// RVA: 0x21D3150 Offset: 0x21D1B50 VA: 0x1821D3150
	public bool CheckCM(TokenClass rtf_class, Major major) { }

	// RVA: 0x21D3130 Offset: 0x21D1B30 VA: 0x1821D3130
	public bool CheckCMM(TokenClass rtf_class, Major major, Minor minor) { }

	// RVA: 0x21D3160 Offset: 0x21D1B60 VA: 0x1821D3160
	public bool CheckMM(Major major, Minor minor) { }

	// RVA: 0x21D3BB0 Offset: 0x21D25B0 VA: 0x1821D3BB0
	private void HandleOptDest(RTF rtf) { }

	// RVA: 0x21D3F40 Offset: 0x21D2940 VA: 0x1821D3F40
	private void ReadFontTbl(RTF rtf) { }

	// RVA: 0x21D3D80 Offset: 0x21D2780 VA: 0x1821D3D80
	private void ReadColorTbl(RTF rtf) { }

	// RVA: 0x21D4B60 Offset: 0x21D3560 VA: 0x1821D4B60
	private void ReadStyleSheet(RTF rtf) { }

	// RVA: 0x21D4470 Offset: 0x21D2E70 VA: 0x1821D4470
	private void ReadInfoGroup(RTF rtf) { }

	// RVA: 0x21D44E0 Offset: 0x21D2EE0 VA: 0x1821D44E0
	private void ReadPictGroup(RTF rtf) { }

	// RVA: 0x21D4470 Offset: 0x21D2E70 VA: 0x1821D4470
	private void ReadObjGroup(RTF rtf) { }
}
