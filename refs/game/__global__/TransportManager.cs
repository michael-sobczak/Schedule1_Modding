public sealed class TransportManager : MonoBehaviour // TypeDefIndex: 12738
{
	// Fields
	[CompilerGenerated]
	private Action OnIterateOutgoingStart; // 0x20
	[CompilerGenerated]
	private Action OnIterateOutgoingEnd; // 0x28
	[CompilerGenerated]
	private Action<bool> OnIterateIncomingStart; // 0x30
	[CompilerGenerated]
	private Action<bool> OnIterateIncomingEnd; // 0x38
	[Tooltip("The current Transport being used.")]
	public Transport Transport; // 0x40
	[Tooltip("Layer used to modify data before it is sent or received.")]
	[SerializeField]
	private IntermediateLayer _intermediateLayer; // 0x48
	[SerializeField]
	[Tooltip("Latency simulation settings.")]
	private LatencySimulator _latencySimulator; // 0x50
	private List<NetworkConnection> _dirtyToClients; // 0x58
	private List<PacketBundle> _toServerBundles; // 0x60
	private NetworkManager _networkManager; // 0x68
	private List<TransportManager.DisconnectingClient> _disconnectingClients; // 0x70
	private int[] _lowestMtu; // 0x78
	private HashSet<NetworkConnection> _networkConnectionHashSet; // 0x80
	public const byte PACKET_ID_BYTES = 2;
	public const byte OBJECT_ID_BYTES = 2;
	public const byte COMPONENT_INDEX_BYTES = 1;
	public const byte TICK_BYTES = 4;
	private const byte SPLIT_COUNT_BYTES = 4;
	public const byte SPLIT_INDICATOR_SIZE = 6;
	public const byte CHANNEL_COUNT = 2;

	// Properties
	public bool HasIntermediateLayer { get; }
	public LatencySimulator LatencySimulator { get; }

	// Methods

	// RVA: 0xD73AF0 Offset: 0xD724F0 VA: 0x180D73AF0
	public bool get_HasIntermediateLayer() { }

	[CompilerGenerated]
	// RVA: 0xD73A50 Offset: 0xD72450 VA: 0x180D73A50
	internal void add_OnIterateOutgoingStart(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD73DB0 Offset: 0xD727B0 VA: 0x180D73DB0
	internal void remove_OnIterateOutgoingStart(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD739B0 Offset: 0xD723B0 VA: 0x180D739B0
	internal void add_OnIterateOutgoingEnd(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD73D10 Offset: 0xD72710 VA: 0x180D73D10
	internal void remove_OnIterateOutgoingEnd(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD73900 Offset: 0xD72300 VA: 0x180D73900
	internal void add_OnIterateIncomingStart(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD73C60 Offset: 0xD72660 VA: 0x180D73C60
	internal void remove_OnIterateIncomingStart(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD73850 Offset: 0xD72250 VA: 0x180D73850
	internal void add_OnIterateIncomingEnd(Action<bool> value) { }

	[CompilerGenerated]
	// RVA: 0xD73BB0 Offset: 0xD725B0 VA: 0x180D73BB0
	internal void remove_OnIterateIncomingEnd(Action<bool> value) { }

	// RVA: 0xD73B40 Offset: 0xD72540 VA: 0x180D73B40
	public LatencySimulator get_LatencySimulator() { }

	// RVA: 0xD70E00 Offset: 0xD6F800 VA: 0x180D70E00
	internal void InitializeOnce_Internal(NetworkManager manager) { }

	// RVA: 0xD73080 Offset: 0xD71A80 VA: 0x180D73080
	internal void ServerDirty(NetworkConnection conn) { }

	// RVA: 0xD710F0 Offset: 0xD6FAF0 VA: 0x180D710F0
	private void InitializeToServerBundles() { }

	// RVA: 0xD70800 Offset: 0xD6F200 VA: 0x180D70800
	public int GetLowestMTU(byte channel) { }

	// RVA: 0xD70CB0 Offset: 0xD6F6B0 VA: 0x180D70CB0
	public int GetMTU(byte channel) { }

	// RVA: 0xD70B20 Offset: 0xD6F520 VA: 0x180D70B20
	public int GetMTU(int transportIndex, byte channel) { }

	// RVA: -1 Offset: -1
	public int GetMTU<T>(byte channel) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61CA0 Offset: 0xF606A0 VA: 0x180F61CA0
	|-TransportManager.GetMTU<object>
	*/

	// RVA: 0xD71C50 Offset: 0xD70650 VA: 0x180D71C50
	internal ArraySegment<byte> ProcessIntermediateIncoming(ArraySegment<byte> src, bool fromServer) { }

	// RVA: 0xD71CB0 Offset: 0xD706B0 VA: 0x180D71CB0
	private ArraySegment<byte> ProcessIntermediateOutgoing(ArraySegment<byte> src, bool toServer) { }

	// RVA: 0xD721B0 Offset: 0xD70BB0 VA: 0x180D721B0
	internal void SendToClient(byte channelId, ArraySegment<byte> segment, NetworkConnection connection, bool splitLargeMessages = True, DataOrderType orderType = 0) { }

	// RVA: 0xD720F0 Offset: 0xD70AF0 VA: 0x180D720F0
	private void SendToClient(byte channelId, ArraySegment<byte> segment, NetworkConnection connection, int requiredSplitMessages, int maxSplitMessageSize, DataOrderType orderType = 0) { }

	// RVA: 0xD72A80 Offset: 0xD71480 VA: 0x180D72A80
	internal void SendToClients(byte channelId, ArraySegment<byte> segment, HashSet<NetworkConnection> observers, NetworkConnection excludedConnection, bool splitLargeMessages = True, DataOrderType orderType = 0) { }

	// RVA: 0xD72560 Offset: 0xD70F60 VA: 0x180D72560
	internal void SendToClients(byte channelId, ArraySegment<byte> segment, HashSet<NetworkConnection> observers, HashSet<NetworkConnection> excludedConnections, bool splitLargeMessages = True, DataOrderType orderType = 0) { }

	// RVA: 0xD726D0 Offset: 0xD710D0 VA: 0x180D726D0
	private void SendToClients(byte channelId, ArraySegment<byte> segment, HashSet<NetworkConnection> observers, HashSet<NetworkConnection> excludedConnections, int requiredSplitMessages, int maxSplitMessageSize, DataOrderType orderType = 0) { }

	// RVA: 0xD72C70 Offset: 0xD71670 VA: 0x180D72C70
	internal void SendToClients(byte channelId, ArraySegment<byte> segment, bool splitLargeMessages = True) { }

	// RVA: 0xD72350 Offset: 0xD70D50 VA: 0x180D72350
	private void SendToClients_Internal(byte channelId, ArraySegment<byte> segment, int requiredSplitMessages, int maxSplitMessageSize) { }

	// RVA: 0xD72DB0 Offset: 0xD717B0 VA: 0x180D72DB0
	internal void SendToServer(byte channelId, ArraySegment<byte> segment, bool splitLargeMessages = True, DataOrderType orderType = 0) { }

	// RVA: 0xD72F80 Offset: 0xD71980 VA: 0x180D72F80
	private void SendToServer(byte channelId, ArraySegment<byte> segment, int requiredSplitMessages, int maxSplitMessageSize, DataOrderType orderType) { }

	// RVA: 0xD73130 Offset: 0xD71B30 VA: 0x180D73130
	private void SetSplitValues(byte channelId, ArraySegment<byte> segment, bool split, out int requiredSplitMessages, out int maxSplitMessageSize) { }

	// RVA: 0xD70770 Offset: 0xD6F170 VA: 0x180D70770
	internal void CheckSetReliableChannel(int dataLength, ref Channel channel) { }

	// RVA: 0xD70CF0 Offset: 0xD6F6F0 VA: 0x180D70CF0
	private int GetRequiredMessageCount(byte channelId, int segmentSize, out int maxMessageSize) { }

	// RVA: 0xD732A0 Offset: 0xD71CA0 VA: 0x180D732A0
	private bool SplitRequired(byte channelId, int segmentSize, out int requiredMessages, out int maxMessageSize) { }

	// RVA: 0xD71D10 Offset: 0xD70710 VA: 0x180D71D10
	private void SendSplitData(NetworkConnection conn, ref ArraySegment<byte> segment, int requiredMessages, int maxMessageSize, DataOrderType orderType) { }

	// RVA: 0xD712C0 Offset: 0xD6FCC0 VA: 0x180D712C0
	internal void IterateIncoming(bool server) { }

	// RVA: 0xD71340 Offset: 0xD6FD40 VA: 0x180D71340
	internal void IterateOutgoing(bool toServer) { }

	// RVA: 0xD71220 Offset: 0xD6FC20 VA: 0x180D71220
	public bool IsLocalTransport(int connectionId) { }

	// RVA: 0xD70D70 Offset: 0xD6F770 VA: 0x180D70D70
	public Transport GetTransport(int index) { }

	// RVA: -1 Offset: -1
	public T GetTransport<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF61D70 Offset: 0xF60770 VA: 0x180F61D70
	|-TransportManager.GetTransport<object>
	*/

	// RVA: 0xD736C0 Offset: 0xD720C0 VA: 0x180D736C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD733B0 Offset: 0xD71DB0 VA: 0x180D733B0
	private void <IterateOutgoing>g__ProcessPacketBundle|57_0(PacketBundle ppb, bool isLast = False, ref TransportManager.<>c__DisplayClass57_0 , ref TransportManager.<>c__DisplayClass57_1 , ref TransportManager.<>c__DisplayClass57_2 ) { }

	[CompilerGenerated]
	// RVA: 0xD73550 Offset: 0xD71F50 VA: 0x180D73550
	private void <IterateOutgoing>g__ProcessPacketBundle|57_1(PacketBundle ppb, ref TransportManager.<>c__DisplayClass57_0 , ref TransportManager.<>c__DisplayClass57_3 ) { }
}
