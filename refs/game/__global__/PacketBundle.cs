internal class PacketBundle // TypeDefIndex: 12827
{
	// Fields
	private List<ByteBuffer> _buffers; // 0x10
	private int _bufferIndex; // 0x18
	private int _maximumTransportUnit; // 0x1C
	private int _reserve; // 0x20
	private NetworkManager _networkManager; // 0x28
	private PacketBundle _sendLastBundle; // 0x30
	private bool _isSendLastBundle; // 0x38

	// Properties
	internal bool HasData { get; }
	public int WrittenBuffers { get; }

	// Methods

	// RVA: 0xD9F660 Offset: 0xD9E060 VA: 0x180D9F660
	internal bool get_HasData() { }

	// RVA: 0xD9F6E0 Offset: 0xD9E0E0 VA: 0x180D9F6E0
	public int get_WrittenBuffers() { }

	// RVA: 0xD9F4C0 Offset: 0xD9DEC0 VA: 0x180D9F4C0
	internal void .ctor(NetworkManager manager, int mtu, int reserve = 0, DataOrderType orderType = 0) { }

	// RVA: 0xD9ED20 Offset: 0xD9D720 VA: 0x180D9ED20
	public void Dispose() { }

	// RVA: 0xD9EBE0 Offset: 0xD9D5E0 VA: 0x180D9EBE0
	private ByteBuffer AddBuffer() { }

	// RVA: 0xD9F0A0 Offset: 0xD9DAA0 VA: 0x180D9F0A0
	internal void Reset(bool resetSendLast) { }

	// RVA: 0xD9F160 Offset: 0xD9DB60 VA: 0x180D9F160
	internal void Write(ArraySegment<byte> segment, bool forceNewBuffer = False, DataOrderType orderType = 0) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	internal PacketBundle GetSendLastBundle() { }

	// RVA: 0xD9EE30 Offset: 0xD9D830 VA: 0x180D9EE30
	internal bool GetBuffer(int index, out ByteBuffer bb) { }

	// RVA: 0xD9EFF0 Offset: 0xD9D9F0 VA: 0x180D9EFF0
	internal static bool GetPacketBundle(int channel, List<PacketBundle> bundles, out PacketBundle mtuBuffer) { }
}
