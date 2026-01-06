public class MSGConversationData : SaveData // TypeDefIndex: 1055
{
	// Fields
	public int ConversationIndex; // 0x28
	public bool Read; // 0x2C
	public TextMessageData[] MessageHistory; // 0x30
	public TextResponseData[] ActiveResponses; // 0x38
	public bool IsHidden; // 0x40

	// Methods

	// RVA: 0x5E0A50 Offset: 0x5DF450 VA: 0x1805E0A50
	public void .ctor(int conversationIndex, bool read, TextMessageData[] messageHistory, TextResponseData[] activeResponses, bool isHidden) { }

	// RVA: 0x5E09C0 Offset: 0x5DF3C0 VA: 0x1805E09C0
	public void .ctor() { }
}
