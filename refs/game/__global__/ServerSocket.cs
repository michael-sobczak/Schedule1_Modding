public class ServerSocket : CommonSocket // TypeDefIndex: 12556
{
	// Fields
	private Queue<LocalPacket> _incoming; // 0x20
	private ClientSocket _client; // 0x28

	// Methods

	// RVA: 0xD3AFD0 Offset: 0xD399D0 VA: 0x180D3AFD0
	internal RemoteConnectionState GetConnectionState(int connectionId) { }

	// RVA: 0xD3B000 Offset: 0xD39A00 VA: 0x180D3B000 Slot: 5
	internal override void Initialize(Transport t, CommonSocket socket) { }

	// RVA: 0xD3B630 Offset: 0xD3A030 VA: 0x180D3B630
	internal bool StartConnection() { }

	// RVA: 0xD3B570 Offset: 0xD39F70 VA: 0x180D3B570 Slot: 4
	protected override void SetLocalConnectionState(LocalConnectionState connectionState, bool server) { }

	// RVA: 0xD3B680 Offset: 0xD3A080 VA: 0x180D3B680
	internal bool StopConnection() { }

	// RVA: 0xD3B6F0 Offset: 0xD3A0F0 VA: 0x180D3B6F0
	internal bool StopConnection(int connectionId) { }

	// RVA: 0xD3B0E0 Offset: 0xD39AE0 VA: 0x180D3B0E0
	internal void IterateIncoming() { }

	// RVA: 0xD3B3B0 Offset: 0xD39DB0 VA: 0x180D3B3B0
	internal void SendToClient(byte channelId, ArraySegment<byte> segment, int connectionId) { }

	// RVA: 0xD3B290 Offset: 0xD39C90 VA: 0x180D3B290
	internal void OnLocalClientConnectionState(LocalConnectionState state) { }

	// RVA: 0xD3B340 Offset: 0xD39D40 VA: 0x180D3B340
	internal void ReceivedFromLocalClient(LocalPacket packet) { }

	// RVA: 0xD3B780 Offset: 0xD3A180 VA: 0x180D3B780
	public void .ctor() { }
}
