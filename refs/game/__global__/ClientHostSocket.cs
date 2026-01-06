public class ClientHostSocket : CommonSocket // TypeDefIndex: 524
{
	// Fields
	private ServerSocket _server; // 0x30
	private Queue<LocalPacket> _incoming; // 0x38

	// Methods

	// RVA: 0xA7CA90 Offset: 0xA7B490 VA: 0x180A7CA90
	internal void CheckSetStarted() { }

	// RVA: 0xA7CF30 Offset: 0xA7B930 VA: 0x180A7CF30
	internal bool StartConnection(ServerSocket serverSocket) { }

	// RVA: 0xA7CED0 Offset: 0xA7B8D0 VA: 0x180A7CED0 Slot: 4
	protected override void SetLocalConnectionState(LocalConnectionState connectionState, bool server) { }

	// RVA: 0xA7CFA0 Offset: 0xA7B9A0 VA: 0x180A7CFA0
	internal bool StopConnection() { }

	// RVA: 0xA7CAD0 Offset: 0xA7B4D0 VA: 0x180A7CAD0
	internal void IterateIncoming() { }

	// RVA: 0xA7CCA0 Offset: 0xA7B6A0 VA: 0x180A7CCA0
	internal void ReceivedFromLocalServer(LocalPacket packet) { }

	// RVA: 0xA7CD00 Offset: 0xA7B700 VA: 0x180A7CD00
	internal void SendToServer(byte channelId, ArraySegment<byte> segment) { }

	// RVA: 0xA7D0B0 Offset: 0xA7BAB0 VA: 0x180A7D0B0
	public void .ctor() { }
}
