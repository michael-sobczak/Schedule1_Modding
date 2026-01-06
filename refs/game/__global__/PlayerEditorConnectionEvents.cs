internal class PlayerEditorConnectionEvents // TypeDefIndex: 12152
{
	// Fields
	[SerializeField]
	public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers; // 0x10
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent; // 0x18
	[SerializeField]
	public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent; // 0x20

	// Methods

	// RVA: 0x2CE5140 Offset: 0x2CE3B40 VA: 0x182CE5140
	public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId) { }

	// RVA: 0x2CE4ED0 Offset: 0x2CE38D0 VA: 0x182CE4ED0
	public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId) { }

	// RVA: 0x2CE5510 Offset: 0x2CE3F10 VA: 0x182CE5510
	public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x2CE5650 Offset: 0x2CE4050 VA: 0x182CE5650
	public void .ctor() { }
}
