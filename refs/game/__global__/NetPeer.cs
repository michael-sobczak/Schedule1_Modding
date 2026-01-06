public class NetPeer // TypeDefIndex: 12418
{
	// Fields
	private int _rtt; // 0x10
	private int _avgRtt; // 0x14
	private int _rttCount; // 0x18
	private double _resendDelay; // 0x20
	private int _pingSendTimer; // 0x28
	private int _rttResetTimer; // 0x2C
	private readonly Stopwatch _pingTimer; // 0x30
	private int _timeSinceLastPacket; // 0x38
	private long _remoteDelta; // 0x40
	private readonly object _shutdownLock; // 0x48
	internal NetPeer NextPeer; // 0x50
	internal NetPeer PrevPeer; // 0x58
	private readonly Queue<NetPacket> _unreliableChannel; // 0x60
	private readonly ConcurrentQueue<BaseChannel> _channelSendQueue; // 0x68
	private readonly BaseChannel[] _channels; // 0x70
	private int _mtu; // 0x78
	private int _mtuIdx; // 0x7C
	private bool _finishMtu; // 0x80
	private int _mtuCheckTimer; // 0x84
	private int _mtuCheckAttempts; // 0x88
	private const int MtuCheckDelay = 1000;
	private const int MaxMtuCheckAttempts = 4;
	private readonly object _mtuMutex; // 0x90
	private int _fragmentId; // 0x98
	private readonly Dictionary<ushort, NetPeer.IncomingFragments> _holdedFragments; // 0xA0
	private readonly Dictionary<ushort, ushort> _deliveredFragments; // 0xA8
	private readonly NetPacket _mergeData; // 0xB0
	private int _mergePos; // 0xB8
	private int _mergeCount; // 0xBC
	private IPEndPoint _remoteEndPoint; // 0xC0
	private int _connectAttempts; // 0xC8
	private int _connectTimer; // 0xCC
	private long _connectTime; // 0xD0
	private byte _connectNum; // 0xD8
	private ConnectionState _connectionState; // 0xD9
	private NetPacket _shutdownPacket; // 0xE0
	private const int ShutdownDelay = 300;
	private int _shutdownTimer; // 0xE8
	private readonly NetPacket _pingPacket; // 0xF0
	private readonly NetPacket _pongPacket; // 0xF8
	private readonly NetPacket _connectRequestPacket; // 0x100
	private readonly NetPacket _connectAcceptPacket; // 0x108
	public readonly NetManager NetManager; // 0x110
	public readonly int Id; // 0x118
	[CompilerGenerated]
	private int <RemoteId>k__BackingField; // 0x11C
	public object Tag; // 0x120
	public readonly NetStatistics Statistics; // 0x128

	// Properties
	internal byte ConnectionNum { get; set; }
	public IPEndPoint EndPoint { get; }
	public ConnectionState ConnectionState { get; }
	internal long ConnectTime { get; }
	public int RemoteId { get; set; }
	public int Ping { get; }
	public int RoundTripTime { get; }
	public int Mtu { get; }
	public long RemoteTimeDelta { get; }
	public DateTime RemoteUtcTime { get; }
	public int TimeSinceLastPacket { get; }
	internal double ResendDelay { get; }

	// Methods

	// RVA: 0x4B5E70 Offset: 0x4B4870 VA: 0x1804B5E70
	internal byte get_ConnectionNum() { }

	// RVA: 0xD056D0 Offset: 0xD040D0 VA: 0x180D056D0
	private void set_ConnectionNum(byte value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	public IPEndPoint get_EndPoint() { }

	// RVA: 0x518800 Offset: 0x517200 VA: 0x180518800
	public ConnectionState get_ConnectionState() { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	internal long get_ConnectTime() { }

	[CompilerGenerated]
	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340
	public int get_RemoteId() { }

	[CompilerGenerated]
	// RVA: 0x9C2380 Offset: 0x9C0D80 VA: 0x1809C2380
	private void set_RemoteId(int value) { }

	// RVA: 0xD05630 Offset: 0xD04030 VA: 0x180D05630
	public int get_Ping() { }

	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_RoundTripTime() { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public int get_Mtu() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public long get_RemoteTimeDelta() { }

	// RVA: 0xD05640 Offset: 0xD04040 VA: 0x180D05640
	public DateTime get_RemoteUtcTime() { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public int get_TimeSinceLastPacket() { }

	// RVA: 0xD056C0 Offset: 0xD040C0 VA: 0x180D056C0
	internal double get_ResendDelay() { }

	// RVA: 0xD05050 Offset: 0xD03A50 VA: 0x180D05050
	internal void .ctor(NetManager netManager, IPEndPoint remoteEndPoint, int id) { }

	// RVA: 0xD022D0 Offset: 0xD00CD0 VA: 0x180D022D0
	internal void InitiateEndPointChange() { }

	// RVA: 0xD020E0 Offset: 0xD00AE0 VA: 0x180D020E0
	internal void FinishEndPointChange(IPEndPoint newEndPoint) { }

	// RVA: 0xD034A0 Offset: 0xD01EA0 VA: 0x180D034A0
	internal void ResetMtu() { }

	// RVA: 0xD041B0 Offset: 0xD02BB0 VA: 0x180D041B0
	private void SetMtu(int mtuIdx) { }

	// RVA: 0xD02360 Offset: 0xD00D60 VA: 0x180D02360
	private void OverrideMtu(int mtuValue) { }

	// RVA: 0xD021E0 Offset: 0xD00BE0 VA: 0x180D021E0
	public int GetPacketsCountInReliableQueue(byte channelNumber, bool ordered) { }

	// RVA: 0xD01D60 Offset: 0xD00760 VA: 0x180D01D60
	public PooledPacket CreatePacketFromPool(DeliveryMethod deliveryMethod, byte channelNumber) { }

	// RVA: 0xD03600 Offset: 0xD02000 VA: 0x180D03600
	public void SendPooledPacket(PooledPacket packet, int userDataSize) { }

	// RVA: 0xD01BD0 Offset: 0xD005D0 VA: 0x180D01BD0
	private BaseChannel CreateChannel(byte idx) { }

	// RVA: 0xD054A0 Offset: 0xD03EA0 VA: 0x180D054A0
	internal void .ctor(NetManager netManager, IPEndPoint remoteEndPoint, int id, byte connectNum, NetDataWriter connectData) { }

	// RVA: 0xD04E70 Offset: 0xD03870 VA: 0x180D04E70
	internal void .ctor(NetManager netManager, ConnectionRequest request, int id) { }

	// RVA: 0xD03450 Offset: 0xD01E50 VA: 0x180D03450
	internal void Reject(NetConnectRequestPacket requestData, byte[] data, int start, int length) { }

	// RVA: 0xD02370 Offset: 0xD00D70 VA: 0x180D02370
	internal bool ProcessConnectAccept(NetConnectAcceptPacket packet) { }

	// RVA: 0xD02110 Offset: 0xD00B10 VA: 0x180D02110
	public int GetMaxSinglePacketSize(DeliveryMethod options) { }

	// RVA: 0xD03A70 Offset: 0xD02470 VA: 0x180D03A70
	public void SendWithDeliveryEvent(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod, object userData) { }

	// RVA: 0xD03940 Offset: 0xD02340 VA: 0x180D03940
	public void SendWithDeliveryEvent(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData) { }

	// RVA: 0xD039D0 Offset: 0xD023D0 VA: 0x180D039D0
	public void SendWithDeliveryEvent(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod, object userData) { }

	// RVA: 0xD04080 Offset: 0xD02A80 VA: 0x180D04080
	public void Send(byte[] data, DeliveryMethod deliveryMethod) { }

	// RVA: 0xD04140 Offset: 0xD02B40 VA: 0x180D04140
	public void Send(NetDataWriter dataWriter, DeliveryMethod deliveryMethod) { }

	// RVA: 0xD04050 Offset: 0xD02A50 VA: 0x180D04050
	public void Send(byte[] data, int start, int length, DeliveryMethod options) { }

	// RVA: 0xD04100 Offset: 0xD02B00 VA: 0x180D04100
	public void Send(byte[] data, byte channelNumber, DeliveryMethod deliveryMethod) { }

	// RVA: 0xD040C0 Offset: 0xD02AC0 VA: 0x180D040C0
	public void Send(NetDataWriter dataWriter, byte channelNumber, DeliveryMethod deliveryMethod) { }

	// RVA: 0xD04180 Offset: 0xD02B80 VA: 0x180D04180
	public void Send(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod) { }

	// RVA: 0xD03B10 Offset: 0xD02510 VA: 0x180D03B10
	private void Send_Internal(byte[] data, int start, int length, byte channelNumber, DeliveryMethod deliveryMethod, object userData) { }

	// RVA: 0xD02020 Offset: 0xD00A20 VA: 0x180D02020
	public void Disconnect(byte[] data) { }

	// RVA: 0xD01EB0 Offset: 0xD008B0 VA: 0x180D01EB0
	public void Disconnect(NetDataWriter writer) { }

	// RVA: 0xD01E70 Offset: 0xD00870 VA: 0x180D01E70
	public void Disconnect(byte[] data, int start, int count) { }

	// RVA: 0xD01F70 Offset: 0xD00970 VA: 0x180D01F70
	public void Disconnect() { }

	// RVA: 0xD02590 Offset: 0xD00F90 VA: 0x180D02590
	internal DisconnectResult ProcessDisconnect(NetPacket packet) { }

	// RVA: 0xD01B70 Offset: 0xD00570 VA: 0x180D01B70
	internal void AddToReliableChannelSendQueue(BaseChannel channel) { }

	// RVA: 0xD04260 Offset: 0xD02C60 VA: 0x180D04260
	internal ShutdownResult Shutdown(byte[] data, int start, int length, bool force) { }

	// RVA: 0xD048E0 Offset: 0xD032E0 VA: 0x180D048E0
	private void UpdateRoundTripTime(int roundTripTime) { }

	// RVA: 0xD012C0 Offset: 0xCFFCC0 VA: 0x180D012C0
	internal void AddReliablePacket(DeliveryMethod method, NetPacket p) { }

	// RVA: 0xD02630 Offset: 0xD01030 VA: 0x180D02630
	private void ProcessMtuPacket(NetPacket packet) { }

	// RVA: 0xD04560 Offset: 0xD02F60 VA: 0x180D04560
	private void UpdateMtuLogic(int deltaTime) { }

	// RVA: 0xD023F0 Offset: 0xD00DF0 VA: 0x180D023F0
	internal ConnectRequestResult ProcessConnectRequest(NetConnectRequestPacket connRequest) { }

	// RVA: 0xD02B50 Offset: 0xD01550 VA: 0x180D02B50
	internal void ProcessPacket(NetPacket packet) { }

	// RVA: 0xD03500 Offset: 0xD01F00 VA: 0x180D03500
	private void SendMerged() { }

	// RVA: 0xD03790 Offset: 0xD02190 VA: 0x180D03790
	internal void SendUserData(NetPacket packet) { }

	// RVA: 0xD04920 Offset: 0xD03320 VA: 0x180D04920
	internal void Update(int deltaTime) { }

	// RVA: 0xD031F0 Offset: 0xD01BF0 VA: 0x180D031F0
	internal void RecycleAndDeliver(NetPacket packet) { }
}
