public class Multipass : Transport // TypeDefIndex: 12552
{
	// Fields
	[Tooltip("While true server actions such as starting or stopping the server will run on all transport.")]
	public bool GlobalServerActions; // 0x30
	private Transport _clientTransport; // 0x38
	[Tooltip("Transports to use.")]
	[SerializeField]
	private List<Transport> _transports; // 0x40
	private Dictionary<int, Multipass.TransportIdData> _multipassToTransport; // 0x48
	private List<Dictionary<int, int>> _transportToMultipass; // 0x50
	private Queue<int> _availableIds; // 0x58
	internal const int CLIENT_HOST_ID = 32767;
	[CompilerGenerated]
	private Action<ClientConnectionStateArgs> OnClientConnectionState; // 0x60
	[CompilerGenerated]
	private Action<ServerConnectionStateArgs> OnServerConnectionState; // 0x68
	[CompilerGenerated]
	private Action<RemoteConnectionStateArgs> OnRemoteConnectionState; // 0x70
	[CompilerGenerated]
	private Action<ClientReceivedDataArgs> OnClientReceivedData; // 0x78
	[CompilerGenerated]
	private Action<ServerReceivedDataArgs> OnServerReceivedData; // 0x80

	// Properties
	[HideInInspector]
	public Transport ClientTransport { get; set; }
	public IList<Transport> Transports { get; }

	// Methods

	// RVA: 0xD129E0 Offset: 0xD113E0 VA: 0x180D129E0
	public Transport get_ClientTransport() { }

	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_ClientTransport(Transport value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public IList<Transport> get_Transports() { }

	// RVA: 0xD10050 Offset: 0xD0EA50 VA: 0x180D10050 Slot: 4
	public override void Initialize(NetworkManager networkManager, int transportIndex) { }

	// RVA: 0xD10CF0 Offset: 0xD0F6F0 VA: 0x180D10CF0
	private void OnDestroy() { }

	// RVA: 0xD12170 Offset: 0xD10B70 VA: 0x180D12170
	private void TryResetClientIds(bool force) { }

	// RVA: 0xD0FD00 Offset: 0xD0E700 VA: 0x180D0FD00
	private bool GetMultipassId(int transportIndex, int transportId, out int multipassId) { }

	// RVA: 0xD0FE20 Offset: 0xD0E820 VA: 0x180D0FE20
	private bool GetTransportIdData(int multipassId, out Multipass.TransportIdData data) { }

	// RVA: 0xD0F660 Offset: 0xD0E060 VA: 0x180D0F660 Slot: 5
	public override string GetConnectionAddress(int connectionId) { }

	[CompilerGenerated]
	// RVA: 0xD12660 Offset: 0xD11060 VA: 0x180D12660 Slot: 6
	public override void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD12B30 Offset: 0xD11530 VA: 0x180D12B30 Slot: 7
	public override void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD12870 Offset: 0xD11270 VA: 0x180D12870 Slot: 8
	public override void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD12D40 Offset: 0xD11740 VA: 0x180D12D40 Slot: 9
	public override void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD127C0 Offset: 0xD111C0 VA: 0x180D127C0 Slot: 10
	public override void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD12C90 Offset: 0xD11690 VA: 0x180D12C90 Slot: 11
	public override void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value) { }

	// RVA: 0xD0F7D0 Offset: 0xD0E1D0 VA: 0x180D0F7D0 Slot: 15
	public override LocalConnectionState GetConnectionState(bool server) { }

	// RVA: 0xD0F720 Offset: 0xD0E120 VA: 0x180D0F720
	public LocalConnectionState GetConnectionState(bool server, int index) { }

	// RVA: 0xD0F8E0 Offset: 0xD0E2E0 VA: 0x180D0F8E0 Slot: 16
	public override RemoteConnectionState GetConnectionState(int connectionId) { }

	// RVA: 0xD0F990 Offset: 0xD0E390 VA: 0x180D0F990
	public RemoteConnectionState GetConnectionState(int connectionId, int index) { }

	// RVA: 0xD109B0 Offset: 0xD0F3B0 VA: 0x180D109B0
	private void Multipass_OnClientConnectionState(ClientConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD10C00 Offset: 0xD0F600 VA: 0x180D10C00
	private void Multipass_OnServerConnectionState(ServerConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD10A10 Offset: 0xD0F410 VA: 0x180D10A10
	private void Multipass_OnRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD10750 Offset: 0xD0F150 VA: 0x180D10750 Slot: 25
	public override void IterateIncoming(bool server) { }

	// RVA: 0xD10880 Offset: 0xD0F280 VA: 0x180D10880 Slot: 26
	public override void IterateOutgoing(bool server) { }

	[CompilerGenerated]
	// RVA: 0xD12710 Offset: 0xD11110 VA: 0x180D12710 Slot: 19
	public override void add_OnClientReceivedData(Action<ClientReceivedDataArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD12BE0 Offset: 0xD115E0 VA: 0x180D12BE0 Slot: 20
	public override void remove_OnClientReceivedData(Action<ClientReceivedDataArgs> value) { }

	// RVA: 0xD109D0 Offset: 0xD0F3D0 VA: 0x180D109D0
	private void Multipass_OnClientReceivedData(ClientReceivedDataArgs receivedDataArgs) { }

	[CompilerGenerated]
	// RVA: 0xD12920 Offset: 0xD11320 VA: 0x180D12920 Slot: 22
	public override void add_OnServerReceivedData(Action<ServerReceivedDataArgs> value) { }

	[CompilerGenerated]
	// RVA: 0xD12DF0 Offset: 0xD117F0 VA: 0x180D12DF0 Slot: 23
	public override void remove_OnServerReceivedData(Action<ServerReceivedDataArgs> value) { }

	// RVA: 0xD10C40 Offset: 0xD0F640 VA: 0x180D10C40
	private void Multipass_OnServerReceivedData(ServerReceivedDataArgs receivedDataArgs) { }

	// RVA: 0xD10ED0 Offset: 0xD0F8D0 VA: 0x180D10ED0 Slot: 17
	public override void SendToServer(byte channelId, ArraySegment<byte> segment) { }

	// RVA: 0xD10E00 Offset: 0xD0F800 VA: 0x180D10E00 Slot: 18
	public override void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId) { }

	// RVA: 0xD12480 Offset: 0xD10E80 VA: 0x180D12480
	private bool UseGlobalServerActionsWithError(string methodText) { }

	// RVA: 0xD105D0 Offset: 0xD0EFD0 VA: 0x180D105D0
	private bool IsClientTransportSetWithError(string methodText) { }

	// RVA: 0xD0F5D0 Offset: 0xD0DFD0 VA: 0x180D0F5D0
	private void CreateAvailableIds() { }

	// RVA: -1 Offset: -1
	public void SetClientTransport<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07D90 Offset: 0xF06790 VA: 0x180F07D90
	|-Multipass.SetClientTransport<object>
	|-Multipass.SetClientTransport<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD110B0 Offset: 0xD0FAB0 VA: 0x180D110B0
	public void SetClientTransport(Type type) { }

	// RVA: 0xD11240 Offset: 0xD0FC40 VA: 0x180D11240
	public void SetClientTransport(Transport transport) { }

	// RVA: 0xD111C0 Offset: 0xD0FBC0 VA: 0x180D111C0
	public void SetClientTransport(int index) { }

	// RVA: 0xD0FEF0 Offset: 0xD0E8F0 VA: 0x180D0FEF0
	public Transport GetTransport(int index) { }

	// RVA: -1 Offset: -1
	public T GetTransport<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF07BB0 Offset: 0xF065B0 VA: 0x180F07BB0
	|-Multipass.GetTransport<object>
	|
	|-RVA: 0xF078F0 Offset: 0xF062F0 VA: 0x180F078F0
	|-Multipass.GetTransport<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0xD106B0 Offset: 0xD0F0B0 VA: 0x180D106B0 Slot: 27
	public override bool IsLocalTransport(int connectionid) { }

	// RVA: 0xD0FC10 Offset: 0xD0E610 VA: 0x180D0FC10 Slot: 30
	public override int GetMaximumClients() { }

	// RVA: 0xD0FC60 Offset: 0xD0E660 VA: 0x180D0FC60
	public int GetMaximumClients(int transportIndex) { }

	// RVA: 0xD113E0 Offset: 0xD0FDE0 VA: 0x180D113E0 Slot: 31
	public override void SetMaximumClients(int value) { }

	// RVA: 0xD11340 Offset: 0xD0FD40 VA: 0x180D11340
	public void SetMaximumClients(int value, int transportIndex) { }

	// RVA: 0xD10F90 Offset: 0xD0F990 VA: 0x180D10F90 Slot: 32
	public override void SetClientAddress(string address) { }

	// RVA: 0xD11580 Offset: 0xD0FF80 VA: 0x180D11580 Slot: 34
	public override void SetServerBindAddress(string address, IPAddressType addressType) { }

	// RVA: 0xD115D0 Offset: 0xD0FFD0 VA: 0x180D115D0
	public void SetServerBindAddress(string address, IPAddressType addressType, int index) { }

	// RVA: 0xD114D0 Offset: 0xD0FED0 VA: 0x180D114D0 Slot: 36
	public override void SetPort(ushort port) { }

	// RVA: 0xD11430 Offset: 0xD0FE30 VA: 0x180D11430
	public void SetPort(ushort port, int index) { }

	// RVA: 0xD117F0 Offset: 0xD101F0 VA: 0x180D117F0 Slot: 38
	public override bool StartConnection(bool server) { }

	// RVA: 0xD119E0 Offset: 0xD103E0 VA: 0x180D119E0
	public bool StartConnection(bool server, int index) { }

	// RVA: 0xD11CA0 Offset: 0xD106A0 VA: 0x180D11CA0 Slot: 39
	public override bool StopConnection(bool server) { }

	// RVA: 0xD11E90 Offset: 0xD10890 VA: 0x180D11E90
	public bool StopConnection(bool server, int index) { }

	// RVA: 0xD11BA0 Offset: 0xD105A0 VA: 0x180D11BA0 Slot: 40
	public override bool StopConnection(int connectionId, bool immediately) { }

	// RVA: 0xD11FB0 Offset: 0xD109B0 VA: 0x180D11FB0
	public bool StopServerConnection(bool sendDisconnectMessage, int transportIndex) { }

	// RVA: 0xD11680 Offset: 0xD10080 VA: 0x180D11680 Slot: 41
	public override void Shutdown() { }

	// RVA: 0xD11B00 Offset: 0xD10500 VA: 0x180D11B00
	private bool StartServer(int index) { }

	// RVA: 0xD120D0 Offset: 0xD10AD0 VA: 0x180D120D0
	private bool StopServer(int index) { }

	// RVA: 0xD117B0 Offset: 0xD101B0 VA: 0x180D117B0
	private bool StartClient() { }

	// RVA: 0xD11C60 Offset: 0xD10660 VA: 0x180D11C60
	private bool StopClient() { }

	// RVA: 0xD11BA0 Offset: 0xD105A0 VA: 0x180D11BA0
	private bool StopClient(int connectionId, bool immediately) { }

	// RVA: 0xD0FAF0 Offset: 0xD0E4F0 VA: 0x180D0FAF0 Slot: 42
	public override int GetMTU(byte channel) { }

	// RVA: 0xD0FA40 Offset: 0xD0E440 VA: 0x180D0FA40
	public int GetMTU(byte channel, int index) { }

	// RVA: 0xD0FF70 Offset: 0xD0E970 VA: 0x180D0FF70
	private bool IndexInRange(int index, bool error) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 13
	public override void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 14
	public override void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 21
	public override void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 24
	public override void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 12
	public override void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs) { }

	// RVA: 0xD12510 Offset: 0xD10F10 VA: 0x180D12510
	public void .ctor() { }
}
