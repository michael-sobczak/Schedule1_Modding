public class LatencySimulator // TypeDefIndex: 12731
{
	// Fields
	[Header("Settings")]
	[Tooltip("True if latency simulator is enabled.")]
	[SerializeField]
	private bool _enabled; // 0x10
	[Tooltip("True to add latency on clientHost as well.")]
	[SerializeField]
	private bool _simulateHost; // 0x11
	[Range(0, 60000)]
	[Tooltip("Milliseconds to add between packets. When acting as host this value will be doubled. Added latency will be a minimum of tick rate.")]
	[SerializeField]
	private long _latency; // 0x18
	[SerializeField]
	[Range(0, 1)]
	[Tooltip("Percentage of unreliable packets which should arrive out of order.")]
	[Header("Unreliable")]
	private double _outOfOrder; // 0x20
	[Tooltip("Percentage of packets which should drop.")]
	[Range(0, 1)]
	[SerializeField]
	private double _packetLoss; // 0x28
	private Transport _transport; // 0x30
	private List<LatencySimulator.Message> _toServerReliable; // 0x38
	private List<LatencySimulator.Message> _toServerUnreliable; // 0x40
	private List<LatencySimulator.Message> _toClientReliable; // 0x48
	private List<LatencySimulator.Message> _toClientUnreliable; // 0x50
	private NetworkManager _networkManager; // 0x58
	private readonly Random _random; // 0x60

	// Properties
	internal bool CanSimulate { get; }

	// Methods

	// RVA: 0xD5AFD0 Offset: 0xD599D0 VA: 0x180D5AFD0
	internal bool get_CanSimulate() { }

	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool GetEnabled() { }

	// RVA: 0xD5A910 Offset: 0xD59310 VA: 0x180D5A910
	public void SetEnabled(bool value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public long GetLatency() { }

	// RVA: 0xCC4EC0 Offset: 0xCC38C0 VA: 0x180CC4EC0
	public void SetLatency(long value) { }

	// RVA: 0xD056C0 Offset: 0xD040C0 VA: 0x180D056C0
	public double GetOutOfOrder() { }

	// RVA: 0xD5A920 Offset: 0xD59320 VA: 0x180D5A920
	public void SetOutOfOrder(double value) { }

	// RVA: 0xD5A3A0 Offset: 0xD58DA0 VA: 0x180D5A3A0
	public double GetPacketLost() { }

	// RVA: 0xD5A930 Offset: 0xD59330 VA: 0x180D5A930
	public void SetPacketLoss(double value) { }

	// RVA: 0xD5A3B0 Offset: 0xD58DB0 VA: 0x180D5A3B0
	public void Initialize(NetworkManager manager, Transport transport) { }

	// RVA: 0xD5A7B0 Offset: 0xD591B0 VA: 0x180D5A7B0
	public void Reset() { }

	// RVA: 0xD5A570 Offset: 0xD58F70 VA: 0x180D5A570
	public void RemovePendingForConnection(int connectionId) { }

	// RVA: 0xD5A380 Offset: 0xD58D80 VA: 0x180D5A380
	private float GetLatencyAsFloat() { }

	// RVA: 0xD59F80 Offset: 0xD58980 VA: 0x180D59F80
	public void AddOutgoing(byte channelId, ArraySegment<byte> segment, bool toServer = True, int connectionId = -1) { }

	// RVA: 0xD5A3F0 Offset: 0xD58DF0 VA: 0x180D5A3F0
	public void IterateOutgoing(bool toServer) { }

	// RVA: 0xD5A320 Offset: 0xD58D20 VA: 0x180D5A320
	private bool DropPacket() { }

	// RVA: 0xD5A510 Offset: 0xD58F10 VA: 0x180D5A510
	private bool OutOfOrderPacket(Channel c) { }

	// RVA: 0xD5AE90 Offset: 0xD59890 VA: 0x180D5AE90
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD5AC90 Offset: 0xD59690 VA: 0x180D5AC90
	private void <Reset>g__IterateAndStore|24_0(List<LatencySimulator.Message> messages) { }

	[CompilerGenerated]
	// RVA: 0xD5ABE0 Offset: 0xD595E0 VA: 0x180D5ABE0
	internal static void <RemovePendingForConnection>g__RemoveFromCollection|25_0(List<LatencySimulator.Message> c, ref LatencySimulator.<>c__DisplayClass25_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD5A940 Offset: 0xD59340 VA: 0x180D5A940
	private void <IterateOutgoing>g__IterateCollection|28_0(List<LatencySimulator.Message> collection, Channel channel, ref LatencySimulator.<>c__DisplayClass28_0 ) { }
}
