internal enum TextEditOp // TypeDefIndex: 17621
{
	// Fields
	public int value__; // 0x0
	public const TextEditOp MoveLeft = 0;
	public const TextEditOp MoveRight = 1;
	public const TextEditOp MoveUp = 2;
	public const TextEditOp MoveDown = 3;
	public const TextEditOp MoveLineStart = 4;
	public const TextEditOp MoveLineEnd = 5;
	public const TextEditOp MoveTextStart = 6;
	public const TextEditOp MoveTextEnd = 7;
	public const TextEditOp MovePageUp = 8;
	public const TextEditOp MovePageDown = 9;
	public const TextEditOp MoveGraphicalLineStart = 10;
	public const TextEditOp MoveGraphicalLineEnd = 11;
	public const TextEditOp MoveWordLeft = 12;
	public const TextEditOp MoveWordRight = 13;
	public const TextEditOp MoveParagraphForward = 14;
	public const TextEditOp MoveParagraphBackward = 15;
	public const TextEditOp MoveToStartOfNextWord = 16;
	public const TextEditOp MoveToEndOfPreviousWord = 17;
	public const TextEditOp Delete = 18;
	public const TextEditOp Backspace = 19;
	public const TextEditOp DeleteWordBack = 20;
	public const TextEditOp DeleteWordForward = 21;
	public const TextEditOp DeleteLineBack = 22;
	public const TextEditOp Cut = 23;
	public const TextEditOp Paste = 24;
	public const TextEditOp ScrollStart = 25;
	public const TextEditOp ScrollEnd = 26;
	public const TextEditOp ScrollPageUp = 27;
	public const TextEditOp ScrollPageDown = 28;
}
