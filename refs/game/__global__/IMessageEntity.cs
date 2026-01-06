public interface IMessageEntity // TypeDefIndex: 1157
{
	// Properties
	public abstract MSGConversation MsgConversation { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract MSGConversation get_MsgConversation();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_MsgConversation(MSGConversation value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract void add_onResponseChosen(ResponseCallback value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract void remove_onResponseChosen(ResponseCallback value);
}
