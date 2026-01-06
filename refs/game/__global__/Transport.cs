public abstract class Transport : MonoBehaviour // TypeDefIndex: 12544
{
	// Fields
	[CompilerGenerated]
	private NetworkManager <NetworkManager>k__BackingField; // 0x20
	[CompilerGenerated]
	private int <Index>k__BackingField; // 0x28

	// Properties
	public NetworkManager NetworkManager { get; set; }
	public int Index { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public NetworkManager get_NetworkManager() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_NetworkManager(NetworkManager value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_Index() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void set_Index(int value) { }

	// RVA: 0xD1D1A0 Offset: 0xD1BBA0 VA: 0x180D1D1A0 Slot: 4
	public virtual void Initialize(NetworkManager networkManager, int transportIndex) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract string GetConnectionAddress(int connectionId);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 6
	public abstract void add_OnClientConnectionState(Action<ClientConnectionStateArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 7
	public abstract void remove_OnClientConnectionState(Action<ClientConnectionStateArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 8
	public abstract void add_OnServerConnectionState(Action<ServerConnectionStateArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 9
	public abstract void remove_OnServerConnectionState(Action<ServerConnectionStateArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 10
	public abstract void add_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 11
	public abstract void remove_OnRemoteConnectionState(Action<RemoteConnectionStateArgs> value);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract void HandleClientConnectionState(ClientConnectionStateArgs connectionStateArgs);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract void HandleServerConnectionState(ServerConnectionStateArgs connectionStateArgs);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract void HandleRemoteConnectionState(RemoteConnectionStateArgs connectionStateArgs);

	// RVA: -1 Offset: -1 Slot: 15
	public abstract LocalConnectionState GetConnectionState(bool server);

	// RVA: -1 Offset: -1 Slot: 16
	public abstract RemoteConnectionState GetConnectionState(int connectionId);

	// RVA: -1 Offset: -1 Slot: 17
	public abstract void SendToServer(byte channelId, ArraySegment<byte> segment);

	// RVA: -1 Offset: -1 Slot: 18
	public abstract void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 19
	public abstract void add_OnClientReceivedData(Action<ClientReceivedDataArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 20
	public abstract void remove_OnClientReceivedData(Action<ClientReceivedDataArgs> value);

	// RVA: -1 Offset: -1 Slot: 21
	public abstract void HandleClientReceivedDataArgs(ClientReceivedDataArgs receivedDataArgs);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 22
	public abstract void add_OnServerReceivedData(Action<ServerReceivedDataArgs> value);

	[CompilerGenerated]
	// RVA: -1 Offset: -1 Slot: 23
	public abstract void remove_OnServerReceivedData(Action<ServerReceivedDataArgs> value);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void HandleServerReceivedDataArgs(ServerReceivedDataArgs receivedDataArgs);

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void IterateIncoming(bool server);

	// RVA: -1 Offset: -1 Slot: 26
	public abstract void IterateOutgoing(bool server);

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 27
	public virtual bool IsLocalTransport(int connectionid) { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 28
	public virtual float GetTimeout(bool asServer) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 29
	public virtual void SetTimeout(float value, bool asServer) { }

	// RVA: 0xD1D080 Offset: 0xD1BA80 VA: 0x180D1D080 Slot: 30
	public virtual int GetMaximumClients() { }

	// RVA: 0xD1D1D0 Offset: 0xD1BBD0 VA: 0x180D1D1D0 Slot: 31
	public virtual void SetMaximumClients(int value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 32
	public virtual void SetClientAddress(string address) { }

	// RVA: 0xD1D040 Offset: 0xD1BA40 VA: 0x180D1D040 Slot: 33
	public virtual string GetClientAddress() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 34
	public virtual void SetServerBindAddress(string address, IPAddressType addressType) { }

	// RVA: 0xD1D150 Offset: 0xD1BB50 VA: 0x180D1D150 Slot: 35
	public virtual string GetServerBindAddress(IPAddressType addressType) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 36
	public virtual void SetPort(ushort port) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 37
	public virtual ushort GetPort() { }

	// RVA: -1 Offset: -1 Slot: 38
	public abstract bool StartConnection(bool server);

	// RVA: -1 Offset: -1 Slot: 39
	public abstract bool StopConnection(bool server);

	// RVA: -1 Offset: -1 Slot: 40
	public abstract bool StopConnection(int connectionId, bool immediately);

	// RVA: -1 Offset: -1 Slot: 41
	public abstract void Shutdown();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract int GetMTU(byte channel);

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
