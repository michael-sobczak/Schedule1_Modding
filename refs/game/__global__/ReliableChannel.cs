internal sealed class ReliableChannel : BaseChannel // TypeDefIndex: 12424
{
	// Fields
	private readonly NetPacket _outgoingAcks; // 0x28
	private readonly ReliableChannel.PendingPacket[] _pendingPackets; // 0x30
	private readonly NetPacket[] _receivedPackets; // 0x38
	private readonly bool[] _earlyReceived; // 0x40
	private int _localSeqence; // 0x48
	private int _remoteSequence; // 0x4C
	private int _localWindowStart; // 0x50
	private int _remoteWindowStart; // 0x54
	private bool _mustSendAcks; // 0x58
	private readonly DeliveryMethod _deliveryMethod; // 0x59
	private readonly bool _ordered; // 0x5A
	private readonly int _windowSize; // 0x5C
	private const int BitsInByte = 8;
	private readonly byte _id; // 0x60

	// Methods

	// RVA: 0xD084D0 Offset: 0xD06ED0 VA: 0x180D084D0
	public void .ctor(NetPeer peer, bool ordered, byte id) { }

	// RVA: 0xD076B0 Offset: 0xD060B0 VA: 0x180D076B0
	private void ProcessAck(NetPacket packet) { }

	// RVA: 0xD08010 Offset: 0xD06A10 VA: 0x180D08010 Slot: 4
	protected override bool SendNextPackets() { }

	// RVA: 0xD07A30 Offset: 0xD06430 VA: 0x180D07A30 Slot: 5
	public override bool ProcessPacket(NetPacket packet) { }
}
