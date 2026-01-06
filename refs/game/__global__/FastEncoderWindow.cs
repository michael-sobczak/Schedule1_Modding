internal sealed class FastEncoderWindow // TypeDefIndex: 17643
{
	// Fields
	private byte[] _window; // 0x10
	private int _bufPos; // 0x18
	private int _bufEnd; // 0x1C
	private ushort[] _prev; // 0x20
	private ushort[] _lookup; // 0x28

	// Properties
	public int BytesAvailable { get; }
	public DeflateInput UnprocessedInput { get; }
	public int FreeWindowSpace { get; }

	// Methods

	// RVA: 0xCF7290 Offset: 0xCF5C90 VA: 0x180CF7290
	public int get_BytesAvailable() { }

	// RVA: 0x216D5D0 Offset: 0x216BFD0 VA: 0x18216D5D0
	public DeflateInput get_UnprocessedInput() { }

	// RVA: 0x216CD30 Offset: 0x216B730 VA: 0x18216CD30
	public void FlushWindow() { }

	// RVA: 0x216CD30 Offset: 0x216B730 VA: 0x18216CD30
	private void ResetWindow() { }

	// RVA: 0x216D5C0 Offset: 0x216BFC0 VA: 0x18216D5C0
	public int get_FreeWindowSpace() { }

	// RVA: 0x216CB70 Offset: 0x216B570 VA: 0x18216CB70
	public void CopyBytes(byte[] inputBuffer, int startIndex, int count) { }

	// RVA: 0x216D4D0 Offset: 0x216BED0 VA: 0x18216D4D0
	public void MoveWindows() { }

	// RVA: 0x216D360 Offset: 0x216BD60 VA: 0x18216D360
	private uint HashValue(uint hash, byte b) { }

	// RVA: 0x216D370 Offset: 0x216BD70 VA: 0x18216D370
	private uint InsertString(ref uint hash) { }

	// RVA: 0x216D410 Offset: 0x216BE10 VA: 0x18216D410
	private void InsertStrings(ref uint hash, int matchLen) { }

	// RVA: 0x216CDE0 Offset: 0x216B7E0 VA: 0x18216CDE0
	internal bool GetNextSymbolOrMatch(Match match) { }

	// RVA: 0x216CBC0 Offset: 0x216B5C0 VA: 0x18216CBC0
	private int FindMatch(int search, out int matchPos, int searchDepth, int niceLength) { }
}
