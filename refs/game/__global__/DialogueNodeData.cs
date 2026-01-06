public class DialogueNodeData // TypeDefIndex: 1620
{
	// Fields
	public string Guid; // 0x10
	public string DialogueText; // 0x18
	public string DialogueNodeLabel; // 0x20
	public Vector2 Position; // 0x28
	public DialogueChoiceData[] choices; // 0x30
	public EVOLineType VoiceLine; // 0x38

	// Methods

	// RVA: 0x702360 Offset: 0x700D60 VA: 0x180702360
	public DialogueNodeData GetCopy() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
