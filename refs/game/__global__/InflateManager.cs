internal sealed class InflateManager // TypeDefIndex: 16659
{
	// Fields
	private const int PRESET_DICT = 32;
	private const int Z_DEFLATED = 8;
	private InflateManager.InflateManagerMode mode; // 0x10
	internal ZlibCodec _codec; // 0x18
	internal int method; // 0x20
	internal uint computedCheck; // 0x24
	internal uint expectedCheck; // 0x28
	internal int marker; // 0x2C
	private bool _handleRfc1950HeaderBytes; // 0x30
	internal int wbits; // 0x34
	internal InflateBlocks blocks; // 0x38
	private static readonly byte[] mark; // 0x0

	// Properties
	internal bool HandleRfc1950HeaderBytes { get; set; }

	// Methods

	// RVA: 0x1B457C0 Offset: 0x1B441C0 VA: 0x181B457C0
	public void .ctor() { }

	// RVA: 0x1E731F0 Offset: 0x1E71BF0 VA: 0x181E731F0
	public void .ctor(bool expectRfc1950HeaderBytes) { }

	// RVA: 0x1E73160 Offset: 0x1E71B60 VA: 0x181E73160
	private static void .cctor() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	internal bool get_HandleRfc1950HeaderBytes() { }

	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	internal void set_HandleRfc1950HeaderBytes(bool value) { }

	// RVA: 0x1E72CE0 Offset: 0x1E716E0 VA: 0x181E72CE0
	internal int Reset() { }

	// RVA: 0x1E721D0 Offset: 0x1E70BD0 VA: 0x181E721D0
	internal int End() { }

	// RVA: 0x1E72B40 Offset: 0x1E71540 VA: 0x181E72B40
	internal int Initialize(ZlibCodec codec, int w) { }

	// RVA: 0x1E72210 Offset: 0x1E70C10 VA: 0x181E72210
	internal int Inflate(FlushType flush) { }

	// RVA: 0x1E72D50 Offset: 0x1E71750 VA: 0x181E72D50
	internal int SetDictionary(byte[] dictionary) { }

	// RVA: 0x1E72EF0 Offset: 0x1E718F0 VA: 0x181E72EF0
	internal int Sync() { }

	// RVA: 0x1E72ED0 Offset: 0x1E718D0 VA: 0x181E72ED0
	internal int SyncPoint(ZlibCodec z) { }
}
