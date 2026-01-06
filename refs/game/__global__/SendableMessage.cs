public class SendableMessage // TypeDefIndex: 1177
{
	// Fields
	public string Text; // 0x10
	public SendableMessage.BoolCheck ShouldShowCheck; // 0x18
	public SendableMessage.ValidityCheck IsValidCheck; // 0x20
	public Action onSelected; // 0x28
	public Action onSent; // 0x30
	private MSGConversation conversation; // 0x38
	public bool disableDefaultSendBehaviour; // 0x40
	private List<int> sentIDs; // 0x48

	// Methods

	// RVA: 0x609120 Offset: 0x607B20 VA: 0x180609120
	public void .ctor(string text, MSGConversation conversation) { }

	// RVA: 0x609100 Offset: 0x607B00 VA: 0x180609100 Slot: 4
	public virtual bool ShouldShow() { }

	// RVA: 0x608DE0 Offset: 0x6077E0 VA: 0x180608DE0 Slot: 5
	public virtual bool IsValid(out string invalidReason) { }

	// RVA: 0x608E70 Offset: 0x607870 VA: 0x180608E70 Slot: 6
	public virtual void Send(bool network, int id = -1) { }
}
