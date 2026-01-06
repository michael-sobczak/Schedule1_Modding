public class FishySteamworks : Transport // TypeDefIndex: 521
{
	// Fields
	public ulong LocalUserSteamID; // 0x30
	[Tooltip("Address server should bind to.")]
	[SerializeField]
	private string _serverBindAddress; // 0x38
	[Tooltip("Port to use.")]
	[SerializeField]
	private ushort _port; // 0x40
	[Tooltip("Maximum number of players which may be connected at once.")]
	[Range(1, 65535)]
	[SerializeField]
	private ushort _maximumClients; // 0x42
	[Tooltip("True if using peer to peer socket.")]
	[SerializeField]
	private bool _peerToPeer; // 0x44
	[Tooltip("Address client should connect to.")]
	[SerializeField]
	private string _clientAddress; // 0x48
	private int[] _mtus; // 0x50
	private ClientSocket _client; // 0x58
	private ClientHostSocket _clientHost; // 0x60
	private ServerSocket _server; // 0x68
	private bool _shutdownCalled; // 0x70
	internal const int CLIENT_HOST_ID = 32767;
	[CompilerGenerated]
	private Action<ClientConnectionStateArgs> OnClientConnectionState; // 0x78
	[CompilerGenerated]
	private Action<ServerConnectionStateArgs> OnServerConnectionState; // 0x80
	[CompilerGenerated]
	private Action<RemoteConnectionStateArgs> OnRemoteConnectionState; // 0x88
	[CompilerGenerated]
	private Action<ClientReceivedDataArgs> OnClientReceivedData; // 0x90
	[CompilerGenerated]
	private Action<ServerReceivedDataArgs> OnServerReceivedData; // 0x98

	// Methods

	// RVA: 0xA81970 Offset: 0xA80370 VA: 0x180A81970 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xA81E00 Offset: 0xA80800 VA: 0x180A81E00 Slot: 4
	public override void Initialize(NetworkManager networkManager, int transportIndex) { }

	// RVA: 0xA82530 Offset: 0xA80F30 VA: 0x180A82530
	private void OnDestroy() { }

	// RVA: 0xA83100 Offset: 0xA81B00 VA: 0x180A83100
	private void Update() { }

	// RVA: 0xA818F0 Offset: 0xA802F0 VA: 0x180A818F0
	private void CreateChannelData() { }

	// RVA: 0xA81DC0 Offset: 0xA807C0 VA: 0x180A81DC0
	private bool InitializeRelayNetworkAccess() { }

	// RVA: 0xA822A0 Offset: 0xA80CA0 VA: 0x180A822A0
	public bool IsNetworkAccessAvailable() { }

	// RVA: 0xA819E0 Offset: 0xA803E0 VA: 0x180A819E0 Slot: 5
	public override string GetConnectionAddress(int connectionId) { }

	[CompilerGenerated]
	// RVA: 0xA831D0 Offset: 0xA81BD0 VA: 0x180A831D0 Slot: 6
	public override void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xA83580 Offset: 0xA81F80 VA: 0x180A83580 Slot: 7
	public override void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xA83400 Offset: 0xA81E00 VA: 0x180A83400 Slot: 8
	public override void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xA837B0 Offset: 0xA821B0 VA: 0x180A837B0 Slot: 9
	public override void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xA83340 Offset: 0xA81D40 VA: 0x180A83340 Slot: 10
	public override void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xA836F0 Offset: 0xA820F0 VA: 0x180A836F0 Slot: 11
	public override void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	// RVA: 0xA81B90 Offset: 0xA80590 VA: 0x180A81B90 Slot: 15
	public override LocalConnectionState GetConnectionState(bool server) { }

	// RVA: 0xA81B20 Offset: 0xA80520 VA: 0x180A81B20 Slot: 16
	public override RemoteConnectionState GetConnectionState(int connectionId) { }

	// RVA: 0xA81CB0 Offset: 0xA806B0 VA: 0x180A81CB0 Slot: 12
	public override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xA81D50 Offset: 0xA80750 VA: 0x180A81D50 Slot: 13
	public override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xA81D10 Offset: 0xA80710 VA: 0x180A81D10 Slot: 14
	public override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xA822C0 Offset: 0xA80CC0 VA: 0x180A822C0 Slot: 25
	public override void IterateIncoming(bool server) { }

	// RVA: 0xA824E0 Offset: 0xA80EE0 VA: 0x180A824E0 Slot: 26
	public override void IterateOutgoing(bool server) { }

	[CompilerGenerated]
	// RVA: 0xA83280 Offset: 0xA81C80 VA: 0x180A83280 Slot: 19
	public override void add_OnClientReceivedData(Action<ClientReceivedDataArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xA83630 Offset: 0xA82030 VA: 0x180A83630 Slot: 20
	public override void remove_OnClientReceivedData(Action<ClientReceivedDataArgs> value) { }

	// RVA: 0xA81CD0 Offset: 0xA806D0 VA: 0x180A81CD0 Slot: 21
	public override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs) { }

	[CompilerGenerated]
	// RVA: 0xA834C0 Offset: 0xA81EC0 VA: 0x180A834C0 Slot: 22
	public override void add_OnServerReceivedData(Action<ServerReceivedDataArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xA83870 Offset: 0xA82270 VA: 0x180A83870 Slot: 23
	public override void remove_OnServerReceivedData(Action<ServerReceivedDataArgs> value) { }

	// RVA: 0xA81D70 Offset: 0xA80770 VA: 0x180A81D70 Slot: 24
	public override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs) { }

	// RVA: 0xA82590 Offset: 0xA80F90 VA: 0x180A82590 Slot: 17
	public override void SendToServer(byte channelId, ArraySegment<byte> segment) { }

	// RVA: 0xA82550 Offset: 0xA80F50 VA: 0x180A82550 Slot: 18
	public override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId) { }

	// RVA: 0xA81C90 Offset: 0xA80690 VA: 0x180A81C90 Slot: 30
	public override int GetMaximumClients() { }

	// RVA: 0xA82890 Offset: 0xA81290 VA: 0x180A82890 Slot: 31
	public override void SetMaximumClients(int value) { }

	// RVA: 0x5A9D30 Offset: 0x5A8730 VA: 0x1805A9D30 Slot: 32
	public override void SetClientAddress(string address) { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0 Slot: 34
	public override void SetServerBindAddress(string address, IPAddressType addressType) { }

	// RVA: 0xA82900 Offset: 0xA81300 VA: 0x180A82900 Slot: 36
	public override void SetPort(ushort port) { }

	// RVA: 0xA82B30 Offset: 0xA81530 VA: 0x180A82B30 Slot: 38
	public override bool StartConnection(bool server) { }

	// RVA: 0xA82F20 Offset: 0xA81920 VA: 0x180A82F20 Slot: 39
	public override bool StopConnection(bool server) { }

	// RVA: 0xA82F90 Offset: 0xA81990 VA: 0x180A82F90 Slot: 40
	public override bool StopConnection(int connectionId, bool immediately) { }

	// RVA: 0xA82910 Offset: 0xA81310 VA: 0x180A82910 Slot: 41
	public override void Shutdown() { }

	// RVA: 0xA82B50 Offset: 0xA81550 VA: 0x180A82B50
	private bool StartServer() { }

	// RVA: 0xA830E0 Offset: 0xA81AE0 VA: 0x180A830E0
	private bool StopServer() { }

	// RVA: 0xA82960 Offset: 0xA81360 VA: 0x180A82960
	private bool StartClient(string address) { }

	// RVA: 0xA82EC0 Offset: 0xA818C0 VA: 0x180A82EC0
	private bool StopClient() { }

	// RVA: 0xA82D70 Offset: 0xA81770 VA: 0x180A82D70
	private bool StopClient(int connectionId, bool immediately) { }

	// RVA: 0xA81BC0 Offset: 0xA805C0 VA: 0x180A81BC0 Slot: 42
	public override int GetMTU(byte channel) { }

	// RVA: 0xA83150 Offset: 0xA81B50 VA: 0x180A83150
	public void .ctor() { }
}
