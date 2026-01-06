public class ClientSocket : CommonSocket // TypeDefIndex: 12557
{
	// Fields
	private ServerSocket _server; // 0x20
	private Queue<LocalPacket> _incoming; // 0x28

	// Methods

	// RVA: 0xD260B0 Offset: 0xD24AB0 VA: 0x180D260B0 Slot: 5
	internal override void Initialize(Transport t, CommonSocket socket) { }

	// RVA: 0xD266F0 Offset: 0xD250F0 VA: 0x180D266F0
	internal bool StartConnection() { }

	// RVA: 0xD26610 Offset: 0xD25010 VA: 0x180D26610 Slot: 4
	protected override void SetLocalConnectionState(LocalConnectionState connectionState, bool server) { }

	// RVA: 0xD267B0 Offset: 0xD251B0 VA: 0x180D267B0
	internal bool StopConnection() { }

	// RVA: 0xD26190 Offset: 0xD24B90 VA: 0x180D26190
	internal void IterateIncoming() { }

	// RVA: 0xD263D0 Offset: 0xD24DD0 VA: 0x180D263D0
	internal void ReceivedFromLocalServer(LocalPacket packet) { }

	// RVA: 0xD26430 Offset: 0xD24E30 VA: 0x180D26430
	internal void SendToServer(byte channelId, ArraySegment<byte> segment) { }

	// RVA: 0xD26360 Offset: 0xD24D60 VA: 0x180D26360
	internal void OnLocalServerConnectionState(LocalConnectionState state) { }

	// RVA: 0xD26820 Offset: 0xD25220 VA: 0x180D26820
	public void .ctor() { }
}
