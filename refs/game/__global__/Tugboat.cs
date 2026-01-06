public class Tugboat : Transport // TypeDefIndex: 12547
{
	// Fields
	[Header("Channels")]
	[Tooltip("Maximum transmission unit for the unreliable channel.")]
	[Range(576, 1023)]
	[SerializeField]
	private int _unreliableMTU; // 0x30
	[Header("Server")]
	[Tooltip("IPv4 Address to bind server to.")]
	[SerializeField]
	private string _ipv4BindAddress; // 0x38
	[Tooltip("IPv6 Address to bind server to.")]
	[SerializeField]
	private string _ipv6BindAddress; // 0x40
	[Tooltip("Port to use.")]
	[SerializeField]
	private ushort _port; // 0x48
	[Range(1, 9999)]
	[SerializeField]
	[Tooltip("Maximum number of players which may be connected at once.")]
	private int _maximumClients; // 0x4C
	[Header("Client")]
	[Tooltip("Address to connect.")]
	[SerializeField]
	private string _clientAddress; // 0x50
	[SerializeField]
	[Header("Misc")]
	[Tooltip("How long in seconds until either the server or client socket must go without data before being timed out. Use 0f to disable timing out.")]
	[Range(0, 1800)]
	private ushort _timeout; // 0x58
	private PacketLayerBase _packetLayer; // 0x60
	private ServerSocket _server; // 0x68
	private ClientSocket _client; // 0x70
	private const ushort MAX_TIMEOUT_SECONDS = 1800;
	private const int MINIMUM_UDP_MTU = 576;
	private const int MAXIMUM_UDP_MTU = 1023;
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

	// RVA: 0xD1D460 Offset: 0xD1BE60 VA: 0x180D1D460 Slot: 4
	public override void Initialize(NetworkManager networkManager, int transportIndex) { }

	// RVA: 0xD1D590 Offset: 0xD1BF90 VA: 0x180D1D590
	protected void OnDestroy() { }

	// RVA: 0xD1D2A0 Offset: 0xD1BCA0 VA: 0x180D1D2A0 Slot: 5
	public override string GetConnectionAddress(int connectionId) { }

	[CompilerGenerated]
	// RVA: 0xD1E460 Offset: 0xD1CE60 VA: 0x180D1E460 Slot: 6
	public override void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD1E810 Offset: 0xD1D210 VA: 0x180D1E810 Slot: 7
	public override void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD1E690 Offset: 0xD1D090 VA: 0x180D1E690 Slot: 8
	public override void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD1EA40 Offset: 0xD1D440 VA: 0x180D1EA40 Slot: 9
	public override void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD1E5D0 Offset: 0xD1CFD0 VA: 0x180D1E5D0 Slot: 10
	public override void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD1E980 Offset: 0xD1D380 VA: 0x180D1E980 Slot: 11
	public override void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	// RVA: 0xD1D2C0 Offset: 0xD1BCC0 VA: 0x180D1D2C0 Slot: 15
	public override LocalConnectionState GetConnectionState(bool server) { }

	// RVA: 0xD1D2F0 Offset: 0xD1BCF0 VA: 0x180D1D2F0 Slot: 16
	public override RemoteConnectionState GetConnectionState(int connectionId) { }

	// RVA: 0xA81CB0 Offset: 0xA806B0 VA: 0x180A81CB0 Slot: 12
	public override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD1D420 Offset: 0xD1BE20 VA: 0x180D1D420 Slot: 13
	public override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xA81D10 Offset: 0xA80710 VA: 0x180A81D10 Slot: 14
	public override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD1DFC0 Offset: 0xD1C9C0 VA: 0x180D1DFC0
	private void TimeManager_OnUpdate() { }

	// RVA: 0xD1D510 Offset: 0xD1BF10 VA: 0x180D1D510 Slot: 25
	public override void IterateIncoming(bool server) { }

	// RVA: 0xD1D550 Offset: 0xD1BF50 VA: 0x180D1D550 Slot: 26
	public override void IterateOutgoing(bool server) { }

	[CompilerGenerated]
	// RVA: 0xD1E510 Offset: 0xD1CF10 VA: 0x180D1E510 Slot: 19
	public override void add_OnClientReceivedData(Action<ClientReceivedDataArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD1E8C0 Offset: 0xD1D2C0 VA: 0x180D1E8C0 Slot: 20
	public override void remove_OnClientReceivedData(Action<ClientReceivedDataArgs> value) { }

	// RVA: 0xA81CD0 Offset: 0xA806D0 VA: 0x180A81CD0 Slot: 21
	public override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs) { }

	[CompilerGenerated]
	// RVA: 0xD1E750 Offset: 0xD1D150 VA: 0x180D1E750 Slot: 22
	public override void add_OnServerReceivedData(Action<ServerReceivedDataArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD1EB00 Offset: 0xD1D500 VA: 0x180D1EB00 Slot: 23
	public override void remove_OnServerReceivedData(Action<ServerReceivedDataArgs> value) { }

	// RVA: 0xA81D70 Offset: 0xA80770 VA: 0x180A81D70 Slot: 24
	public override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs) { }

	// RVA: 0xD1D790 Offset: 0xD1C190 VA: 0x180D1D790 Slot: 17
	public override void SendToServer(byte channelId, ArraySegment<byte> segment) { }

	// RVA: 0xD1D710 Offset: 0xD1C110 VA: 0x180D1D710 Slot: 18
	public override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId) { }

	// RVA: 0xD1D8B0 Offset: 0xD1C2B0 VA: 0x180D1D8B0
	public void SetPacketLayer(PacketLayerBase packetLayer) { }

	// RVA: 0xD1D410 Offset: 0xD1BE10 VA: 0x180D1D410 Slot: 28
	public override float GetTimeout(bool asServer) { }

	// RVA: 0xD1DA40 Offset: 0xD1C440 VA: 0x180D1DA40 Slot: 29
	public override void SetTimeout(float value, bool asServer) { }

	// RVA: 0xD1D340 Offset: 0xD1BD40 VA: 0x180D1D340 Slot: 30
	public override int GetMaximumClients() { }

	// RVA: 0xD1D890 Offset: 0xD1C290 VA: 0x180D1D890 Slot: 31
	public override void SetMaximumClients(int value) { }

	// RVA: 0x4993D0 Offset: 0x497DD0 VA: 0x1804993D0 Slot: 32
	public override void SetClientAddress(string address) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 33
	public override string GetClientAddress() { }

	// RVA: 0xD1DA10 Offset: 0xD1C410 VA: 0x180D1DA10 Slot: 34
	public override void SetServerBindAddress(string address, IPAddressType addressType) { }

	// RVA: 0xD1D400 Offset: 0xD1BE00 VA: 0x180D1D400 Slot: 35
	public override string GetServerBindAddress(IPAddressType addressType) { }

	// RVA: 0xD1DA00 Offset: 0xD1C400 VA: 0x180D1DA00 Slot: 36
	public override void SetPort(ushort port) { }

	// RVA: 0xD1D360 Offset: 0xD1BD60 VA: 0x180D1D360 Slot: 37
	public override ushort GetPort() { }

	// RVA: 0xD1DB30 Offset: 0xD1C530 VA: 0x180D1DB30 Slot: 38
	public override bool StartConnection(bool server) { }

	// RVA: 0xD1DF30 Offset: 0xD1C930 VA: 0x180D1DF30 Slot: 39
	public override bool StopConnection(bool server) { }

	// RVA: 0xD1DF10 Offset: 0xD1C910 VA: 0x180D1DF10 Slot: 40
	public override bool StopConnection(int connectionId, bool immediately) { }

	// RVA: 0xD1DA50 Offset: 0xD1C450 VA: 0x180D1DA50 Slot: 41
	public override void Shutdown() { }

	// RVA: 0xD1DD30 Offset: 0xD1C730 VA: 0x180D1DD30
	private bool StartServer() { }

	// RVA: 0xD1DFA0 Offset: 0xD1C9A0 VA: 0x180D1DFA0
	private bool StopServer() { }

	// RVA: 0xD1DA90 Offset: 0xD1C490 VA: 0x180D1DA90
	private bool StartClient(string address) { }

	// RVA: 0xD1E010 Offset: 0xD1CA10 VA: 0x180D1E010
	private void UpdateTimeout() { }

	// RVA: 0xD1DEC0 Offset: 0xD1C8C0 VA: 0x180D1DEC0
	private bool StopClient() { }

	// RVA: 0xD1D670 Offset: 0xD1C070 VA: 0x180D1D670
	private void SanitizeChannel(ref byte channelId) { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90 Slot: 42
	public override int GetMTU(byte channel) { }

	// RVA: 0xD1E0A0 Offset: 0xD1CAA0 VA: 0x180D1E0A0
	public void .ctor() { }
}
