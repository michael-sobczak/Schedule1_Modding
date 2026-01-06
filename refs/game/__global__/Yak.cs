public class Yak : Transport // TypeDefIndex: 12555
{
	// Fields
	private ClientSocket _client; // 0x30
	private ServerSocket _server; // 0x38
	internal const int CLIENT_HOST_ID = 32767;
	private const int MTU = 5000;
	[CompilerGenerated]
	private Action<ClientConnectionStateArgs> OnClientConnectionState; // 0x40
	[CompilerGenerated]
	private Action<ServerConnectionStateArgs> OnServerConnectionState; // 0x48
	[CompilerGenerated]
	private Action<RemoteConnectionStateArgs> OnRemoteConnectionState; // 0x50
	[CompilerGenerated]
	private Action<ClientReceivedDataArgs> OnClientReceivedData; // 0x58
	[CompilerGenerated]
	private Action<ServerReceivedDataArgs> OnServerReceivedData; // 0x60

	// Methods

	// RVA: 0xD3EF20 Offset: 0xD3D920 VA: 0x180D3EF20 Slot: 4
	public override void Initialize(NetworkManager networkManager, int transportIndex) { }

	// RVA: 0xA82530 Offset: 0xA80F30 VA: 0x180A82530
	private void OnDestroy() { }

	// RVA: 0xD3ED40 Offset: 0xD3D740 VA: 0x180D3ED40 Slot: 5
	public override string GetConnectionAddress(int connectionId) { }

	[CompilerGenerated]
	// RVA: 0xD3FDA0 Offset: 0xD3E7A0 VA: 0x180D3FDA0 Slot: 6
	public override void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD40110 Offset: 0xD3EB10 VA: 0x180D40110 Slot: 7
	public override void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD3FFB0 Offset: 0xD3E9B0 VA: 0x180D3FFB0 Slot: 8
	public override void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD40320 Offset: 0xD3ED20 VA: 0x180D40320 Slot: 9
	public override void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD3FF00 Offset: 0xD3E900 VA: 0x180D3FF00 Slot: 10
	public override void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD40270 Offset: 0xD3EC70 VA: 0x180D40270 Slot: 11
	public override void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	// RVA: 0xD3ED80 Offset: 0xD3D780 VA: 0x180D3ED80 Slot: 15
	public override LocalConnectionState GetConnectionState(bool server) { }

	// RVA: 0xD3EDB0 Offset: 0xD3D7B0 VA: 0x180D3EDB0 Slot: 16
	public override RemoteConnectionState GetConnectionState(int connectionId) { }

	// RVA: 0xD3EE10 Offset: 0xD3D810 VA: 0x180D3EE10 Slot: 12
	public override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD3EEB0 Offset: 0xD3D8B0 VA: 0x180D3EEB0 Slot: 13
	public override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD3EE70 Offset: 0xD3D870 VA: 0x180D3EE70 Slot: 14
	public override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD3F0D0 Offset: 0xD3DAD0 VA: 0x180D3F0D0 Slot: 25
	public override void IterateIncoming(bool server) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 26
	public override void IterateOutgoing(bool server) { }

	[CompilerGenerated]
	// RVA: 0xD3FE50 Offset: 0xD3E850 VA: 0x180D3FE50 Slot: 19
	public override void add_OnClientReceivedData(Action<ClientReceivedDataArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD401C0 Offset: 0xD3EBC0 VA: 0x180D401C0 Slot: 20
	public override void remove_OnClientReceivedData(Action<ClientReceivedDataArgs> value) { }

	// RVA: 0xD3EE30 Offset: 0xD3D830 VA: 0x180D3EE30 Slot: 21
	public override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs) { }

	[CompilerGenerated]
	// RVA: 0xD40060 Offset: 0xD3EA60 VA: 0x180D40060 Slot: 22
	public override void add_OnServerReceivedData(Action<ServerReceivedDataArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD403D0 Offset: 0xD3EDD0 VA: 0x180D403D0 Slot: 23
	public override void remove_OnServerReceivedData(Action<ServerReceivedDataArgs> value) { }

	// RVA: 0xD3EED0 Offset: 0xD3D8D0 VA: 0x180D3EED0 Slot: 24
	public override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs) { }

	// RVA: 0xD3F5F0 Offset: 0xD3DFF0 VA: 0x180D3F5F0 Slot: 17
	public override void SendToServer(byte channelId, ArraySegment<byte> segment) { }

	// RVA: 0xD3F410 Offset: 0xD3DE10 VA: 0x180D3F410 Slot: 18
	public override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 27
	public override bool IsLocalTransport(int connectionId) { }

	// RVA: 0xD3EE00 Offset: 0xD3D800 VA: 0x180D3EE00 Slot: 30
	public override int GetMaximumClients() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 31
	public override void SetMaximumClients(int value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 32
	public override void SetClientAddress(string address) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 34
	public override void SetServerBindAddress(string address, IPAddressType addressType) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 36
	public override void SetPort(ushort port) { }

	// RVA: 0xD3F8F0 Offset: 0xD3E2F0 VA: 0x180D3F8F0 Slot: 38
	public override bool StartConnection(bool server) { }

	// RVA: 0xD3FC50 Offset: 0xD3E650 VA: 0x180D3FC50 Slot: 39
	public override bool StopConnection(bool server) { }

	// RVA: 0xD3FBC0 Offset: 0xD3E5C0 VA: 0x180D3FBC0 Slot: 40
	public override bool StopConnection(int connectionId, bool immediately) { }

	// RVA: 0xD1DA50 Offset: 0xD1C450 VA: 0x180D1DA50 Slot: 41
	public override void Shutdown() { }

	// RVA: 0xD3FA90 Offset: 0xD3E490 VA: 0x180D3FA90
	private bool StartServer() { }

	// RVA: 0xD3FD20 Offset: 0xD3E720 VA: 0x180D3FD20
	private bool StopServer() { }

	// RVA: 0xD3F7E0 Offset: 0xD3E1E0 VA: 0x180D3F7E0
	private bool StartClient() { }

	// RVA: 0xD3FB30 Offset: 0xD3E530 VA: 0x180D3FB30
	private bool StopClient() { }

	// RVA: 0xD3FBC0 Offset: 0xD3E5C0 VA: 0x180D3FBC0
	private bool StopClient(int connectionId, bool immediately) { }

	// RVA: 0xD3EDF0 Offset: 0xD3D7F0 VA: 0x180D3EDF0 Slot: 42
	public override int GetMTU(byte channel) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }
}
