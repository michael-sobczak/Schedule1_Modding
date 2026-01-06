internal sealed class Tokenizer // TypeDefIndex: 4164
{
	// Fields
	public int LineNo; // 0x10
	private int _inProcessingTag; // 0x14
	private byte[] _inBytes; // 0x18
	private char[] _inChars; // 0x20
	private string _inString; // 0x28
	private int _inIndex; // 0x30
	private int _inSize; // 0x34
	private int _inSavedCharacter; // 0x38
	private Tokenizer.TokenSource _inTokenSource; // 0x3C
	private Tokenizer.ITokenReader _inTokenReader; // 0x40
	private Tokenizer.StringMaker _maker; // 0x48
	private string[] _searchStrings; // 0x50
	private string[] _replaceStrings; // 0x58
	private int _inNestedIndex; // 0x60
	private int _inNestedSize; // 0x64
	private string _inNestedString; // 0x68

	// Methods

	// RVA: 0x1ADA960 Offset: 0x1AD9360 VA: 0x181ADA960
	internal void BasicInitialization() { }

	// RVA: 0x1ADB6C0 Offset: 0x1ADA0C0 VA: 0x181ADB6C0
	public void Recycle() { }

	// RVA: 0x1ADB710 Offset: 0x1ADA110 VA: 0x181ADB710
	internal void .ctor(string input) { }

	// RVA: 0x1ADA9E0 Offset: 0x1AD93E0 VA: 0x181ADA9E0
	internal void ChangeFormat(Encoding encoding) { }

	// RVA: 0x1ADACA0 Offset: 0x1AD96A0 VA: 0x181ADACA0
	internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet) { }

	// RVA: 0x1ADAC80 Offset: 0x1AD9680 VA: 0x181ADAC80
	private string GetStringToken() { }
}
