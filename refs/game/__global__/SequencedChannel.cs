internal sealed class SequencedChannel : BaseChannel // TypeDefIndex: 12425
{
	// Fields
	private int _localSequence; // 0x28
	private ushort _remoteSequence; // 0x2C
	private readonly bool _reliable; // 0x2E
	private NetPacket _lastPacket; // 0x30
	private readonly NetPacket _ackPacket; // 0x38
	private bool _mustSendAck; // 0x40
	private readonly byte _id; // 0x41
	private long _lastPacketSendTime; // 0x48

	// Methods

	// RVA: 0xD08D90 Offset: 0xD07790 VA: 0x180D08D90
	public void .ctor(NetPeer peer, bool reliable, byte id) { }

	// RVA: 0xD08920 Offset: 0xD07320 VA: 0x180D08920 Slot: 4
	protected override bool SendNextPackets() { }

	// RVA: 0xD08690 Offset: 0xD07090 VA: 0x180D08690 Slot: 5
	public override bool ProcessPacket(NetPacket packet) { }
}
