public class PlayerConnection : ScriptableObject, IEditorPlayerConnection // TypeDefIndex: 12145
{
	// Fields
	internal static IPlayerEditorConnectionNative connectionNative; // 0x0
	[SerializeField]
	private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents; // 0x18
	[SerializeField]
	private List<int> m_connectedPlayers; // 0x20
	private bool m_IsInitilized; // 0x28
	private static PlayerConnection s_Instance; // 0x8

	// Properties
	public static PlayerConnection instance { get; }
	public bool isConnected { get; }

	// Methods

	// RVA: 0x2CE4D20 Offset: 0x2CE3720 VA: 0x182CE4D20
	public static PlayerConnection get_instance() { }

	// RVA: 0x2CE4E30 Offset: 0x2CE3830 VA: 0x182CE4E30
	public bool get_isConnected() { }

	// RVA: 0x2CE3BE0 Offset: 0x2CE25E0 VA: 0x182CE3BE0
	private static PlayerConnection CreateInstance() { }

	// RVA: 0x2CE3F80 Offset: 0x2CE2980 VA: 0x182CE3F80
	public void OnEnable() { }

	// RVA: 0x2CE3DC0 Offset: 0x2CE27C0 VA: 0x182CE3DC0
	private IPlayerEditorConnectionNative GetConnectionNativeApi() { }

	// RVA: 0x2CE41A0 Offset: 0x2CE2BA0 VA: 0x182CE41A0 Slot: 4
	public void Register(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x2CE48A0 Offset: 0x2CE32A0 VA: 0x182CE48A0 Slot: 8
	public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback) { }

	// RVA: 0x2CE3FE0 Offset: 0x2CE29E0 VA: 0x182CE3FE0 Slot: 5
	public void RegisterConnection(UnityAction<int> callback) { }

	// RVA: 0x2CE4140 Offset: 0x2CE2B40 VA: 0x182CE4140 Slot: 6
	public void RegisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x2CE47E0 Offset: 0x2CE31E0 VA: 0x182CE47E0 Slot: 9
	public void UnregisterConnection(UnityAction<int> callback) { }

	// RVA: 0x2CE4840 Offset: 0x2CE3240 VA: 0x182CE4840 Slot: 10
	public void UnregisterDisconnection(UnityAction<int> callback) { }

	// RVA: 0x2CE4440 Offset: 0x2CE2E40 VA: 0x182CE4440 Slot: 7
	public void Send(Guid messageId, byte[] data) { }

	// RVA: 0x2CE4610 Offset: 0x2CE3010 VA: 0x182CE4610 Slot: 11
	public bool TrySend(Guid messageId, byte[] data) { }

	// RVA: 0x2CE3840 Offset: 0x2CE2240 VA: 0x182CE3840
	public bool BlockUntilRecvMsg(Guid messageId, int timeout) { }

	// RVA: 0x2CE3C90 Offset: 0x2CE2690 VA: 0x182CE3C90 Slot: 12
	public void DisconnectAll() { }

	[RequiredByNativeCode]
	// RVA: 0x2CE3E30 Offset: 0x2CE2830 VA: 0x182CE3E30
	private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId) { }

	[RequiredByNativeCode]
	// RVA: 0x2CE3B10 Offset: 0x2CE2510 VA: 0x182CE3B10
	private static void ConnectedCallbackInternal(int playerId) { }

	[RequiredByNativeCode]
	// RVA: 0x2CE3D30 Offset: 0x2CE2730 VA: 0x182CE3D30
	private static void DisconnectedCallback(int playerId) { }

	// RVA: 0x2CE4B70 Offset: 0x2CE3570 VA: 0x182CE4B70
	public void .ctor() { }
}
