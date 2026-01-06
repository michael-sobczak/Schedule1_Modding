internal sealed class TokenizerStream // TypeDefIndex: 4167
{
	// Fields
	private int m_countTokens; // 0x10
	private TokenizerShortBlock m_headTokens; // 0x18
	private TokenizerShortBlock m_lastTokens; // 0x20
	private TokenizerShortBlock m_currentTokens; // 0x28
	private int m_indexTokens; // 0x30
	private TokenizerStringBlock m_headStrings; // 0x38
	private TokenizerStringBlock m_currentStrings; // 0x40
	private int m_indexStrings; // 0x48

	// Methods

	// RVA: 0x1ADA7A0 Offset: 0x1AD91A0 VA: 0x181ADA7A0
	internal void .ctor() { }

	// RVA: 0x1ADA3B0 Offset: 0x1AD8DB0 VA: 0x181ADA3B0
	internal void AddToken(short token) { }

	// RVA: 0x1ADA270 Offset: 0x1AD8C70 VA: 0x181ADA270
	internal void AddString(string str) { }

	// RVA: 0x1ADA6A0 Offset: 0x1AD90A0 VA: 0x181ADA6A0
	internal void Reset() { }

	// RVA: 0x1ADA4F0 Offset: 0x1AD8EF0 VA: 0x181ADA4F0
	internal short GetNextFullToken() { }

	// RVA: 0x1ADA600 Offset: 0x1AD9000 VA: 0x181ADA600
	internal short GetNextToken() { }

	// RVA: 0x1ADA580 Offset: 0x1AD8F80 VA: 0x181ADA580
	internal string GetNextString() { }

	// RVA: 0x1ADA790 Offset: 0x1AD9190 VA: 0x181ADA790
	internal void ThrowAwayNextString() { }

	// RVA: 0x1ADA700 Offset: 0x1AD9100 VA: 0x181ADA700
	internal void TagLastToken(short tag) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	internal int GetTokenCount() { }

	// RVA: 0x1ADA620 Offset: 0x1AD9020 VA: 0x181ADA620
	internal void GoToPosition(int position) { }
}
