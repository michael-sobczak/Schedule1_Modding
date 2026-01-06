public interface IEditorPlayerConnection // TypeDefIndex: 12141
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Register(Guid messageId, UnityAction<MessageEventArgs> callback);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void RegisterConnection(UnityAction<int> callback);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void RegisterDisconnection(UnityAction<int> callback);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void Send(Guid messageId, byte[] data);
}
