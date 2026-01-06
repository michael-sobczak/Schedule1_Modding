public sealed class ZlibCodec // TypeDefIndex: 16676
{
	// Fields
	public byte[] InputBuffer; // 0x10
	public int NextIn; // 0x18
	public int AvailableBytesIn; // 0x1C
	public long TotalBytesIn; // 0x20
	public byte[] OutputBuffer; // 0x28
	public int NextOut; // 0x30
	public int AvailableBytesOut; // 0x34
	public long TotalBytesOut; // 0x38
	public string Message; // 0x40
	internal DeflateManager dstate; // 0x48
	internal InflateManager istate; // 0x50
	internal uint _Adler32; // 0x58
	public CompressionLevel CompressLevel; // 0x5C
	public int WindowBits; // 0x60
	public CompressionStrategy Strategy; // 0x64

	// Properties
	public int Adler32 { get; }

	// Methods

	// RVA: 0x1E797B0 Offset: 0x1E781B0 VA: 0x181E797B0
	public void .ctor() { }

	// RVA: 0x1E79670 Offset: 0x1E78070 VA: 0x181E79670
	public void .ctor(CompressionMode mode) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public int get_Adler32() { }

	// RVA: 0x1E791F0 Offset: 0x1E77BF0 VA: 0x181E791F0
	public int InitializeInflate() { }

	// RVA: 0x1E78F80 Offset: 0x1E77980 VA: 0x181E78F80
	public int InitializeInflate(bool expectRfc1950Header) { }

	// RVA: 0x1E79200 Offset: 0x1E77C00 VA: 0x181E79200
	public int InitializeInflate(int windowBits) { }

	// RVA: 0x1E78F90 Offset: 0x1E77990 VA: 0x181E78F90
	public int InitializeInflate(int windowBits, bool expectRfc1950Header) { }

	// RVA: 0x1E78E90 Offset: 0x1E77890 VA: 0x181E78E90
	public int Inflate(FlushType flush) { }

	// RVA: 0x1E78DE0 Offset: 0x1E777E0 VA: 0x181E78DE0
	public int EndInflate() { }

	// RVA: 0x1E79500 Offset: 0x1E77F00 VA: 0x181E79500
	public int SyncInflate() { }

	// RVA: 0x1E78F30 Offset: 0x1E77930 VA: 0x181E78F30
	public int InitializeDeflate() { }

	// RVA: 0x1E78F20 Offset: 0x1E77920 VA: 0x181E78F20
	public int InitializeDeflate(CompressionLevel level) { }

	// RVA: 0x1E78F40 Offset: 0x1E77940 VA: 0x181E78F40
	public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header) { }

	// RVA: 0x1E78F00 Offset: 0x1E77900 VA: 0x181E78F00
	public int InitializeDeflate(CompressionLevel level, int bits) { }

	// RVA: 0x1E78F60 Offset: 0x1E77960 VA: 0x181E78F60
	public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header) { }

	// RVA: 0x1E79570 Offset: 0x1E77F70 VA: 0x181E79570
	private int _InternalInitializeDeflate(bool wantRfc1950Header) { }

	// RVA: 0x1E78CF0 Offset: 0x1E776F0 VA: 0x181E78CF0
	public int Deflate(FlushType flush) { }

	// RVA: 0x1E78D60 Offset: 0x1E77760 VA: 0x181E78D60
	public int EndDeflate() { }

	// RVA: 0x1E79210 Offset: 0x1E77C10 VA: 0x181E79210
	public void ResetDeflate() { }

	// RVA: 0x1E79280 Offset: 0x1E77C80 VA: 0x181E79280
	public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy) { }

	// RVA: 0x1E792F0 Offset: 0x1E77CF0 VA: 0x181E792F0
	public int SetDictionary(byte[] dictionary) { }

	// RVA: 0x1E797D0 Offset: 0x1E781D0 VA: 0x181E797D0
	internal void flush_pending() { }

	// RVA: 0x1E79990 Offset: 0x1E78390 VA: 0x181E79990
	internal int read_buf(byte[] buf, int start, int size) { }
}
