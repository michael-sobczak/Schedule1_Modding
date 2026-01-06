internal class Lexer // TypeDefIndex: 17741
{
	// Fields
	private static readonly bool[] token_chars; // 0x0
	private static readonly int last_token_char; // 0x8
	private static readonly string[] dt_formats; // 0x10
	private readonly string s; // 0x10
	private int pos; // 0x18

	// Properties
	public int Position { get; set; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	public void .ctor(string stream) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_Position() { }

	// RVA: 0x49D810 Offset: 0x49C210 VA: 0x18049D810
	public void set_Position(int value) { }

	// RVA: 0x218AF00 Offset: 0x2189900 VA: 0x18218AF00
	public string GetStringValue(Token token) { }

	// RVA: 0x218AE80 Offset: 0x2189880 VA: 0x18218AE80
	public string GetStringValue(Token start, Token end) { }

	// RVA: 0x218ADD0 Offset: 0x21897D0 VA: 0x18218ADD0
	public string GetQuotedStringValue(Token start) { }

	// RVA: 0x218AE50 Offset: 0x2189850 VA: 0x18218AE50
	public string GetRemainingStringValue(int position) { }

	// RVA: 0x218AF70 Offset: 0x2189970 VA: 0x18218AF70
	public bool IsStarStringValue(Token token) { }

	// RVA: 0x218BA20 Offset: 0x218A420 VA: 0x18218BA20
	public bool TryGetNumericValue(Token token, out int value) { }

	// RVA: 0x218BB10 Offset: 0x218A510 VA: 0x18218BB10
	public bool TryGetNumericValue(Token token, out long value) { }

	// RVA: 0x218BC00 Offset: 0x218A600 VA: 0x18218BC00
	public Nullable<TimeSpan> TryGetTimeSpanValue(Token token) { }

	// RVA: 0x218B700 Offset: 0x218A100 VA: 0x18218B700
	public bool TryGetDateValue(Token token, out DateTimeOffset value) { }

	// RVA: 0x218B840 Offset: 0x218A240 VA: 0x18218B840
	public static bool TryGetDateValue(string text, out DateTimeOffset value) { }

	// RVA: 0x218B930 Offset: 0x218A330 VA: 0x18218B930
	public bool TryGetDoubleValue(Token token, out double value) { }

	// RVA: 0x218B0B0 Offset: 0x2189AB0 VA: 0x18218B0B0
	public static bool IsValidToken(string input) { }

	// RVA: 0x218B010 Offset: 0x2189A10 VA: 0x18218B010
	public static bool IsValidCharacter(char input) { }

	// RVA: 0x218ADC0 Offset: 0x21897C0 VA: 0x18218ADC0
	public void EatChar() { }

	// RVA: 0x218B1E0 Offset: 0x2189BE0 VA: 0x18218B1E0
	public int PeekChar() { }

	// RVA: 0x218B220 Offset: 0x2189C20 VA: 0x18218B220
	public bool ScanCommentOptional(out string value, out Token readToken) { }

	// RVA: 0x218B380 Offset: 0x2189D80 VA: 0x18218B380
	public Token Scan(bool recognizeDash = False) { }

	// RVA: 0x218BD80 Offset: 0x218A780 VA: 0x18218BD80
	private static void .cctor() { }
}
