public sealed class NetStatistics // TypeDefIndex: 12419
{
	// Fields
	private long _packetsSent; // 0x10
	private long _packetsReceived; // 0x18
	private long _bytesSent; // 0x20
	private long _bytesReceived; // 0x28
	private long _packetLoss; // 0x30

	// Properties
	public long PacketsSent { get; }
	public long PacketsReceived { get; }
	public long BytesSent { get; }
	public long BytesReceived { get; }
	public long PacketLoss { get; }
	public long PacketLossPercent { get; }

	// Methods

	// RVA: 0xD05C00 Offset: 0xD04600 VA: 0x180D05C00
	public long get_PacketsSent() { }

	// RVA: 0xD05BF0 Offset: 0xD045F0 VA: 0x180D05BF0
	public long get_PacketsReceived() { }

	// RVA: 0xD05B80 Offset: 0xD04580 VA: 0x180D05B80
	public long get_BytesSent() { }

	// RVA: 0xD05B70 Offset: 0xD04570 VA: 0x180D05B70
	public long get_BytesReceived() { }

	// RVA: 0xD05BE0 Offset: 0xD045E0 VA: 0x180D05BE0
	public long get_PacketLoss() { }

	// RVA: 0xD05B90 Offset: 0xD04590 VA: 0x180D05B90
	public long get_PacketLossPercent() { }

	// RVA: 0xD057E0 Offset: 0xD041E0 VA: 0x180D057E0
	public void Reset() { }

	// RVA: 0xD057D0 Offset: 0xD041D0 VA: 0x180D057D0
	public void IncrementPacketsSent() { }

	// RVA: 0xD057C0 Offset: 0xD041C0 VA: 0x180D057C0
	public void IncrementPacketsReceived() { }

	// RVA: 0xD05790 Offset: 0xD04190 VA: 0x180D05790
	public void AddBytesSent(long bytesSent) { }

	// RVA: 0xD05780 Offset: 0xD04180 VA: 0x180D05780
	public void AddBytesReceived(long bytesReceived) { }

	// RVA: 0xD057B0 Offset: 0xD041B0 VA: 0x180D057B0
	public void IncrementPacketLoss() { }

	// RVA: 0xD057A0 Offset: 0xD041A0 VA: 0x180D057A0
	public void AddPacketLoss(long packetLoss) { }

	// RVA: 0xD05840 Offset: 0xD04240 VA: 0x180D05840 Slot: 3
	public override string ToString() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
