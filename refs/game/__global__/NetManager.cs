public class NetManager : IEnumerable<NetPeer>, IEnumerable // TypeDefIndex: 12410
{
	// Fields
	private Thread _logicThread; // 0x10
	private bool _manualMode; // 0x18
	private readonly AutoResetEvent _updateTriggerEvent; // 0x20
	private Queue<NetEvent> _netEventsProduceQueue; // 0x28
	private Queue<NetEvent> _netEventsConsumeQueue; // 0x30
	private NetEvent _netEventPoolHead; // 0x38
	private readonly INetEventListener _netEventListener; // 0x40
	private readonly IDeliveryEventListener _deliveryEventListener; // 0x48
	private readonly INtpEventListener _ntpEventListener; // 0x50
	private readonly IPeerAddressChangedListener _peerAddressChangedListener; // 0x58
	private readonly Dictionary<IPEndPoint, NetPeer> _peersDict; // 0x60
	private readonly Dictionary<IPEndPoint, ConnectionRequest> _requestsDict; // 0x68
	private readonly Dictionary<IPEndPoint, NtpRequest> _ntpRequests; // 0x70
	private readonly ReaderWriterLockSlim _peersLock; // 0x78
	private NetPeer _headPeer; // 0x80
	private int _connectedPeersCount; // 0x88
	private readonly List<NetPeer> _connectedPeerListCache; // 0x90
	private NetPeer[] _peersArray; // 0x98
	private readonly PacketLayerBase _extraPacketLayer; // 0xA0
	private int _lastPeerId; // 0xA8
	private ConcurrentQueue<int> _peerIds; // 0xB0
	private byte _channelsCount; // 0xB8
	private readonly object _eventLock; // 0xC0
	public bool UnconnectedMessagesEnabled; // 0xC8
	public bool NatPunchEnabled; // 0xC9
	public int UpdateTime; // 0xCC
	public int PingInterval; // 0xD0
	public int DisconnectTimeout; // 0xD4
	public bool SimulatePacketLoss; // 0xD8
	public bool SimulateLatency; // 0xD9
	public int SimulationPacketLossChance; // 0xDC
	public int SimulationMinLatency; // 0xE0
	public int SimulationMaxLatency; // 0xE4
	public bool UnsyncedEvents; // 0xE8
	public bool UnsyncedReceiveEvent; // 0xE9
	public bool UnsyncedDeliveryEvent; // 0xEA
	public bool BroadcastReceiveEnabled; // 0xEB
	public int ReconnectDelay; // 0xEC
	public int MaxConnectAttempts; // 0xF0
	public bool ReuseAddress; // 0xF4
	public readonly NetStatistics Statistics; // 0xF8
	public bool EnableStatistics; // 0x100
	public readonly NatPunchModule NatPunchModule; // 0x108
	[CompilerGenerated]
	private bool <IsRunning>k__BackingField; // 0x110
	[CompilerGenerated]
	private int <LocalPort>k__BackingField; // 0x114
	public bool AutoRecycle; // 0x118
	public IPv6Mode IPv6Mode; // 0x11C
	public int MtuOverride; // 0x120
	public bool UseSafeMtu; // 0x124
	public bool UseNativeSockets; // 0x125
	public bool DisconnectOnUnreachable; // 0x126
	public bool AllowPeerAddressChange; // 0x127
	[CompilerGenerated]
	private bool <IsClient>k__BackingField; // 0x128
	private NetPacket _poolHead; // 0x130
	private int _poolCount; // 0x138
	private readonly object _poolLock; // 0x140
	public int PacketPoolSize; // 0x148
	private const int ReceivePollingTime = 500000;
	private Socket _udpSocketv4; // 0x150
	private Socket _udpSocketv6; // 0x158
	private Thread _threadv4; // 0x160
	private Thread _threadv6; // 0x168
	private IPEndPoint _bufferEndPointv4; // 0x170
	private IPEndPoint _bufferEndPointv6; // 0x178
	[ThreadStatic]
	private static byte[] _sendToBuffer; // 0x80000000
	[ThreadStatic]
	private static byte[] _endPointBuffer; // 0x80000008
	private readonly Dictionary<NativeAddr, IPEndPoint> _nativeAddrMap; // 0x180
	private const int SioUdpConnreset = -1744830452;
	private static readonly IPAddress MulticastAddressV6; // 0x0
	public static readonly bool IPv6Support; // 0x8
	public int MaxPacketsReceivePerUpdate; // 0x188

	// Properties
	public bool IsRunning { get; set; }
	public int LocalPort { get; set; }
	public NetPeer FirstPeer { get; }
	public byte ChannelsCount { get; set; }
	public List<NetPeer> ConnectedPeerList { get; }
	public int ConnectedPeersCount { get; }
	public int ExtraPacketSizeForLayer { get; }
	public bool IsClient { get; set; }
	public int PoolCount { get; }
	public short Ttl { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x9876C0 Offset: 0x9860C0 VA: 0x1809876C0
	public bool get_IsRunning() { }

	[CompilerGenerated]
	// RVA: 0x9876E0 Offset: 0x9860E0 VA: 0x1809876E0
	private void set_IsRunning(bool value) { }

	[CompilerGenerated]
	// RVA: 0x51DB70 Offset: 0x51C570 VA: 0x18051DB70
	public int get_LocalPort() { }

	[CompilerGenerated]
	// RVA: 0xD00680 Offset: 0xCFF080 VA: 0x180D00680
	private void set_LocalPort(int value) { }

	// RVA: 0xD005C0 Offset: 0xCFEFC0 VA: 0x180D005C0
	public NetPeer get_FirstPeer() { }

	// RVA: 0x4E8DE0 Offset: 0x4E77E0 VA: 0x1804E8DE0
	public byte get_ChannelsCount() { }

	// RVA: 0xD00610 Offset: 0xCFF010 VA: 0x180D00610
	public void set_ChannelsCount(byte value) { }

	// RVA: 0xD00490 Offset: 0xCFEE90 VA: 0x180D00490
	public List<NetPeer> get_ConnectedPeerList() { }

	// RVA: 0xCF9890 Offset: 0xCF8290 VA: 0x180CF9890
	public NetPeer GetPeerById(int id) { }

	// RVA: 0xCFF8F0 Offset: 0xCFE2F0 VA: 0x180CFF8F0
	public bool TryGetPeerById(int id, out NetPeer peer) { }

	// RVA: 0xD00580 Offset: 0xCFEF80 VA: 0x180D00580
	public int get_ConnectedPeersCount() { }

	// RVA: 0xD005A0 Offset: 0xCFEFA0 VA: 0x180D005A0
	public int get_ExtraPacketSizeForLayer() { }

	// RVA: 0xCFF950 Offset: 0xCFE350 VA: 0x180CFF950
	private bool TryGetPeer(IPEndPoint endPoint, out NetPeer peer) { }

	// RVA: 0xCF7870 Offset: 0xCF6270 VA: 0x180CF7870
	private void AddPeer(NetPeer peer) { }

	// RVA: 0xCFD090 Offset: 0xCFBA90 VA: 0x180CFD090
	private void RemovePeer(NetPeer peer) { }

	// RVA: 0xCFCE30 Offset: 0xCFB830 VA: 0x180CFCE30
	private void RemovePeer_Internal(NetPeer peer) { }

	// RVA: 0xCFFEE0 Offset: 0xCFE8E0 VA: 0x180CFFEE0
	public void .ctor(INetEventListener listener, PacketLayerBase extraPacketLayer) { }

	// RVA: 0xCF87D0 Offset: 0xCF71D0 VA: 0x180CF87D0
	internal void ConnectionLatencyUpdated(NetPeer fromPeer, int latency) { }

	// RVA: 0xCF9D20 Offset: 0xCF8720 VA: 0x180CF9D20
	internal void MessageDelivered(NetPeer fromPeer, object userData) { }

	// RVA: 0xCF9310 Offset: 0xCF7D10 VA: 0x180CF9310
	internal void DisconnectPeerForce(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, NetPacket eventData) { }

	// RVA: 0xCF96D0 Offset: 0xCF80D0 VA: 0x180CF96D0
	private void DisconnectPeer(NetPeer peer, DisconnectReason reason, SocketError socketErrorCode, bool force, byte[] data, int start, int count, NetPacket eventData) { }

	// RVA: 0xCF8820 Offset: 0xCF7220 VA: 0x180CF8820
	private void CreateEvent(NetEvent.EType type, NetPeer peer, IPEndPoint remoteEndPoint, SocketError errorCode = 0, int latency = 0, DisconnectReason disconnectReason = 0, ConnectionRequest connectionRequest, DeliveryMethod deliveryMethod = 4, byte channelNumber = 0, NetPacket readerSource, object userData) { }

	// RVA: 0xCFBE30 Offset: 0xCFA830 VA: 0x180CFBE30
	private void ProcessEvent(NetEvent evt) { }

	// RVA: 0xCFCC40 Offset: 0xCFB640 VA: 0x180CFCC40
	internal void RecycleEvent(NetEvent evt) { }

	// RVA: 0xCFFAC0 Offset: 0xCFE4C0 VA: 0x180CFFAC0
	private void UpdateLogic() { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void ProcessDelayedPackets() { }

	// RVA: 0xCFC5B0 Offset: 0xCFAFB0 VA: 0x180CFC5B0
	private void ProcessNtpRequests(int elapsedMilliseconds) { }

	// RVA: 0xCF9C90 Offset: 0xCF8690 VA: 0x180CF9C90
	public void ManualUpdate(int elapsedMilliseconds) { }

	// RVA: 0xCFA0F0 Offset: 0xCF8AF0 VA: 0x180CFA0F0
	internal NetPeer OnConnectionSolved(ConnectionRequest request, byte[] rejectData, int start, int length) { }

	// RVA: 0xCF9810 Offset: 0xCF8210 VA: 0x180CF9810
	private int GetNextPeerId() { }

	// RVA: 0xCFB950 Offset: 0xCFA350 VA: 0x180CFB950
	private void ProcessConnectRequest(IPEndPoint remoteEndPoint, NetPeer netPeer, NetConnectRequestPacket connRequest) { }

	// RVA: 0xCFA590 Offset: 0xCF8F90 VA: 0x180CFA590
	private void OnMessageReceived(NetPacket packet, IPEndPoint remoteEndPoint) { }

	// RVA: 0xCF8D90 Offset: 0xCF7790 VA: 0x180CF8D90
	internal void CreateReceiveEvent(NetPacket packet, DeliveryMethod method, byte channelNumber, int headerSize, NetPeer fromPeer) { }

	// RVA: 0xCFE670 Offset: 0xCFD070 VA: 0x180CFE670
	public void SendToAll(NetDataWriter writer, DeliveryMethod options) { }

	// RVA: 0xCFE2D0 Offset: 0xCFCCD0 VA: 0x180CFE2D0
	public void SendToAll(byte[] data, DeliveryMethod options) { }

	// RVA: 0xCFE6F0 Offset: 0xCFD0F0 VA: 0x180CFE6F0
	public void SendToAll(byte[] data, int start, int length, DeliveryMethod options) { }

	// RVA: 0xCFE290 Offset: 0xCFCC90 VA: 0x180CFE290
	public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options) { }

	// RVA: 0xCFE630 Offset: 0xCFD030 VA: 0x180CFE630
	public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options) { }

	// RVA: 0xCFE3E0 Offset: 0xCFCDE0 VA: 0x180CFE3E0
	public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options) { }

	// RVA: 0xCFE6B0 Offset: 0xCFD0B0 VA: 0x180CFE6B0
	public void SendToAll(NetDataWriter writer, DeliveryMethod options, NetPeer excludePeer) { }

	// RVA: 0xCFE310 Offset: 0xCFCD10 VA: 0x180CFE310
	public void SendToAll(byte[] data, DeliveryMethod options, NetPeer excludePeer) { }

	// RVA: 0xCFE720 Offset: 0xCFD120 VA: 0x180CFE720
	public void SendToAll(byte[] data, int start, int length, DeliveryMethod options, NetPeer excludePeer) { }

	// RVA: 0xCFE390 Offset: 0xCFCD90 VA: 0x180CFE390
	public void SendToAll(NetDataWriter writer, byte channelNumber, DeliveryMethod options, NetPeer excludePeer) { }

	// RVA: 0xCFE350 Offset: 0xCFCD50 VA: 0x180CFE350
	public void SendToAll(byte[] data, byte channelNumber, DeliveryMethod options, NetPeer excludePeer) { }

	// RVA: 0xCFE500 Offset: 0xCFCF00 VA: 0x180CFE500
	public void SendToAll(byte[] data, int start, int length, byte channelNumber, DeliveryMethod options, NetPeer excludePeer) { }

	// RVA: 0xCFF410 Offset: 0xCFDE10 VA: 0x180CFF410
	public bool Start() { }

	// RVA: 0xCFF350 Offset: 0xCFDD50 VA: 0x180CFF350
	public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port) { }

	// RVA: 0xCFF370 Offset: 0xCFDD70 VA: 0x180CFF370
	public bool Start(string addressIPv4, string addressIPv6, int port) { }

	// RVA: 0xCFF2D0 Offset: 0xCFDCD0 VA: 0x180CFF2D0
	public bool Start(int port) { }

	// RVA: 0xCFEAB0 Offset: 0xCFD4B0 VA: 0x180CFEAB0
	public bool StartInManualMode(IPAddress addressIPv4, IPAddress addressIPv6, int port) { }

	// RVA: 0xCFEA10 Offset: 0xCFD410 VA: 0x180CFEA10
	public bool StartInManualMode(string addressIPv4, string addressIPv6, int port) { }

	// RVA: 0xCFEAD0 Offset: 0xCFD4D0 VA: 0x180CFEAD0
	public bool StartInManualMode(int port) { }

	// RVA: 0xCFE750 Offset: 0xCFD150 VA: 0x180CFE750
	public bool SendUnconnectedMessage(byte[] message, IPEndPoint remoteEndPoint) { }

	// RVA: 0xCFE8F0 Offset: 0xCFD2F0 VA: 0x180CFE8F0
	public bool SendUnconnectedMessage(NetDataWriter writer, string address, int port) { }

	// RVA: 0xCFE7E0 Offset: 0xCFD1E0 VA: 0x180CFE7E0
	public bool SendUnconnectedMessage(NetDataWriter writer, IPEndPoint remoteEndPoint) { }

	// RVA: 0xCFE870 Offset: 0xCFD270 VA: 0x180CFE870
	public bool SendUnconnectedMessage(byte[] message, int start, int length, IPEndPoint remoteEndPoint) { }

	// RVA: 0xCFF8D0 Offset: 0xCFE2D0 VA: 0x180CFF8D0
	public void TriggerUpdate() { }

	// RVA: 0xCFB190 Offset: 0xCF9B90 VA: 0x180CFB190
	public void PollEvents() { }

	// RVA: 0xCF82E0 Offset: 0xCF6CE0 VA: 0x180CF82E0
	public NetPeer Connect(string address, int port, string key) { }

	// RVA: 0xCF8200 Offset: 0xCF6C00 VA: 0x180CF8200
	public NetPeer Connect(string address, int port, NetDataWriter connectionData) { }

	// RVA: 0xCF8750 Offset: 0xCF7150 VA: 0x180CF8750
	public NetPeer Connect(IPEndPoint target, string key) { }

	[CompilerGenerated]
	// RVA: 0x67E960 Offset: 0x67D360 VA: 0x18067E960
	public bool get_IsClient() { }

	[CompilerGenerated]
	// RVA: 0x67EAB0 Offset: 0x67D4B0 VA: 0x18067EAB0
	private void set_IsClient(bool value) { }

	// RVA: 0xCF8370 Offset: 0xCF6D70 VA: 0x180CF8370
	public NetPeer Connect(IPEndPoint target, NetDataWriter connectionData) { }

	// RVA: 0xCFF490 Offset: 0xCFDE90 VA: 0x180CFF490
	public void Stop() { }

	// RVA: 0xCFF4A0 Offset: 0xCFDEA0 VA: 0x180CFF4A0
	public void Stop(bool sendDisconnectMessages) { }

	// RVA: 0xCF98D0 Offset: 0xCF82D0 VA: 0x180CF98D0
	public int GetPeersCount(ConnectionState peerState) { }

	// RVA: 0xCF9960 Offset: 0xCF8360 VA: 0x180CF9960
	public void GetPeersNonAlloc(List<NetPeer> peers, ConnectionState peerState) { }

	// RVA: 0xCF9160 Offset: 0xCF7B60 VA: 0x180CF9160
	public void DisconnectAll() { }

	// RVA: 0xCF9040 Offset: 0xCF7A40 VA: 0x180CF9040
	public void DisconnectAll(byte[] data, int start, int count) { }

	// RVA: 0xCF9260 Offset: 0xCF7C60 VA: 0x180CF9260
	public void DisconnectPeerForce(NetPeer peer) { }

	// RVA: 0xCF94A0 Offset: 0xCF7EA0 VA: 0x180CF94A0
	public void DisconnectPeer(NetPeer peer) { }

	// RVA: 0xCF9610 Offset: 0xCF8010 VA: 0x180CF9610
	public void DisconnectPeer(NetPeer peer, byte[] data) { }

	// RVA: 0xCF93E0 Offset: 0xCF7DE0 VA: 0x180CF93E0
	public void DisconnectPeer(NetPeer peer, NetDataWriter writer) { }

	// RVA: 0xCF9550 Offset: 0xCF7F50 VA: 0x180CF9550
	public void DisconnectPeer(NetPeer peer, byte[] data, int start, int count) { }

	// RVA: 0xCF8D00 Offset: 0xCF7700 VA: 0x180CF8D00
	public void CreateNtpRequest(IPEndPoint endPoint) { }

	// RVA: 0xCF8B60 Offset: 0xCF7560 VA: 0x180CF8B60
	public void CreateNtpRequest(string ntpServerAddress, int port) { }

	// RVA: 0xCF8C30 Offset: 0xCF7630 VA: 0x180CF8C30
	public void CreateNtpRequest(string ntpServerAddress) { }

	// RVA: 0xCF97C0 Offset: 0xCF81C0 VA: 0x180CF97C0
	public NetManager.NetPeerEnumerator GetEnumerator() { }

	// RVA: 0xCFF7B0 Offset: 0xCFE1B0 VA: 0x180CFF7B0 Slot: 4
	private IEnumerator<NetPeer> System.Collections.Generic.IEnumerable<LiteNetLib.NetPeer>.GetEnumerator() { }

	// RVA: 0xCFF840 Offset: 0xCFE240 VA: 0x180CFF840 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x858810 Offset: 0x857210 VA: 0x180858810
	public int get_PoolCount() { }

	// RVA: 0xCFB4E0 Offset: 0xCF9EE0 VA: 0x180CFB4E0
	private NetPacket PoolGetWithData(PacketProperty property, byte[] data, int start, int length) { }

	// RVA: 0xCFB610 Offset: 0xCFA010 VA: 0x180CFB610
	private NetPacket PoolGetWithProperty(PacketProperty property, int size) { }

	// RVA: 0xCFB700 Offset: 0xCFA100 VA: 0x180CFB700
	private NetPacket PoolGetWithProperty(PacketProperty property) { }

	// RVA: 0xCFB330 Offset: 0xCF9D30 VA: 0x180CFB330
	internal NetPacket PoolGetPacket(int size) { }

	// RVA: 0xCFB7E0 Offset: 0xCFA1E0 VA: 0x180CFB7E0
	internal void PoolRecycle(NetPacket packet) { }

	// RVA: 0xCFE9D0 Offset: 0xCFD3D0 VA: 0x180CFE9D0
	public bool SocketActive(bool ipv4) { }

	// RVA: 0xD005E0 Offset: 0xCFEFE0 VA: 0x180D005E0
	public short get_Ttl() { }

	// RVA: 0xD00690 Offset: 0xCFF090 VA: 0x180D00690
	internal void set_Ttl(short value) { }

	// RVA: 0xCFFE20 Offset: 0xCFE820 VA: 0x180CFFE20
	private static void .cctor() { }

	// RVA: 0x9876C0 Offset: 0x9860C0 VA: 0x1809876C0
	private bool IsActive() { }

	// RVA: 0xCFCD40 Offset: 0xCFB740 VA: 0x180CFCD40
	private void RegisterEndPoint(IPEndPoint ep) { }

	// RVA: 0xCFF9E0 Offset: 0xCFE3E0 VA: 0x180CFF9E0
	private void UnregisterEndPoint(IPEndPoint ep) { }

	// RVA: 0xCFBC80 Offset: 0xCFA680 VA: 0x180CFBC80
	private bool ProcessError(SocketException ex) { }

	// RVA: 0xCF9A50 Offset: 0xCF8450 VA: 0x180CF9A50
	private void ManualReceive(Socket socket, EndPoint bufferEndPoint) { }

	// RVA: 0xCF9D70 Offset: 0xCF8770 VA: 0x180CF9D70
	private void NativeReceiveLogic(object state) { }

	// RVA: 0xCFC8D0 Offset: 0xCFB2D0 VA: 0x180CFC8D0
	private void ReceiveLogic(object state) { }

	// RVA: 0xCFEB50 Offset: 0xCFD550 VA: 0x180CFEB50
	public bool Start(IPAddress addressIPv4, IPAddress addressIPv6, int port, bool manualMode) { }

	// RVA: 0xCF7B30 Offset: 0xCF6530 VA: 0x180CF7B30
	private bool BindSocket(Socket socket, IPEndPoint ep) { }

	// RVA: 0xCFD5A0 Offset: 0xCFBFA0 VA: 0x180CFD5A0
	internal int SendRawAndRecycle(NetPacket packet, IPEndPoint remoteEndPoint) { }

	// RVA: 0xCFD600 Offset: 0xCFC000 VA: 0x180CFD600
	internal int SendRaw(NetPacket packet, IPEndPoint remoteEndPoint) { }

	// RVA: 0xCFD640 Offset: 0xCFC040 VA: 0x180CFD640
	internal int SendRaw(byte[] message, int start, int length, IPEndPoint remoteEndPoint) { }

	// RVA: 0xCFD560 Offset: 0xCFBF60 VA: 0x180CFD560
	public bool SendBroadcast(NetDataWriter writer, int port) { }

	// RVA: 0xCFD0E0 Offset: 0xCFBAE0 VA: 0x180CFD0E0
	public bool SendBroadcast(byte[] data, int port) { }

	// RVA: 0xCFD110 Offset: 0xCFBB10 VA: 0x180CFD110
	public bool SendBroadcast(byte[] data, int start, int length, int port) { }

	// RVA: 0xCF80D0 Offset: 0xCF6AD0 VA: 0x180CF80D0
	internal void CloseSocket(bool suspend) { }
}
