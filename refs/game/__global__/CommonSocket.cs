public abstract class CommonSocket // TypeDefIndex: 12553
{
	// Fields
	private LocalConnectionState _connectionState; // 0x10
	protected Transport Transport; // 0x18

	// Methods

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	internal LocalConnectionState GetLocalConnectionState() { }

	// RVA: 0xA7E840 Offset: 0xA7D240 VA: 0x180A7E840 Slot: 4
	protected virtual void SetLocalConnectionState(LocalConnectionState connectionState, bool server) { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0 Slot: 5
	internal virtual void Initialize(Transport t, CommonSocket socket) { }

	// RVA: 0xD26AA0 Offset: 0xD254A0 VA: 0x180D26AA0
	internal void ClearQueue(ref Queue<LocalPacket> queue) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }
}
