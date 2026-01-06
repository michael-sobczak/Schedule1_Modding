internal class StyleSyntaxTokenizer // TypeDefIndex: 7195
{
	// Fields
	private List<StyleSyntaxToken> m_Tokens; // 0x10
	private int m_CurrentTokenIndex; // 0x18

	// Properties
	public StyleSyntaxToken current { get; }

	// Methods

	// RVA: 0x2E54BD0 Offset: 0x2E535D0 VA: 0x182E54BD0
	public StyleSyntaxToken get_current() { }

	// RVA: 0x2E53F30 Offset: 0x2E52930 VA: 0x182E53F30
	public StyleSyntaxToken MoveNext() { }

	// RVA: 0x2E54000 Offset: 0x2E52A00 VA: 0x182E54000
	public StyleSyntaxToken PeekNext() { }

	// RVA: 0x2E540C0 Offset: 0x2E52AC0 VA: 0x182E540C0
	public void Tokenize(string syntax) { }

	// RVA: 0x2E53D80 Offset: 0x2E52780 VA: 0x182E53D80
	private static bool IsNextCharacter(string s, int index, char c) { }

	// RVA: 0x2E53DD0 Offset: 0x2E527D0 VA: 0x182E53DD0
	private static bool IsNextLetterOrDash(string s, int index) { }

	// RVA: 0x2E53EA0 Offset: 0x2E528A0 VA: 0x182E53EA0
	private static bool IsNextNumber(string s, int index) { }

	// RVA: 0x2E53D20 Offset: 0x2E52720 VA: 0x182E53D20
	private static int GlobCharacter(string s, int index, char c) { }

	// RVA: 0x2E54B50 Offset: 0x2E53550 VA: 0x182E54B50
	public void .ctor() { }
}
