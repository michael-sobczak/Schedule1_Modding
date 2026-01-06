internal abstract class BaseChannel // TypeDefIndex: 12358
{
	// Fields
	protected readonly NetPeer Peer; // 0x10
	protected readonly ConcurrentQueue<NetPacket> OutgoingQueue; // 0x18
	private int _isAddedToPeerChannelSendQueue; // 0x20

	// Properties
	public int PacketsInQueue { get; }

	// Methods

	// RVA: 0xCF0E50 Offset: 0xCEF850 VA: 0x180CF0E50
	public int get_PacketsInQueue() { }

	// RVA: 0xCF0DC0 Offset: 0xCEF7C0 VA: 0x180CF0DC0
	protected void .ctor(NetPeer peer) { }

	// RVA: 0xCF0D20 Offset: 0xCEF720 VA: 0x180CF0D20
	public void AddToQueue(NetPacket packet) { }

	// RVA: 0xCF0CA0 Offset: 0xCEF6A0 VA: 0x180CF0CA0
	protected void AddToPeerChannelSendQueue() { }

	// RVA: 0xCF0D80 Offset: 0xCEF780 VA: 0x180CF0D80
	public bool SendAndCheckQueue() { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract bool SendNextPackets();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool ProcessPacket(NetPacket packet);
}
