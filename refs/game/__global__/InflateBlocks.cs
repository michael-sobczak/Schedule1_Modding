internal sealed class InflateBlocks // TypeDefIndex: 16655
{
	// Fields
	private const int MANY = 1440;
	internal static readonly int[] border; // 0x0
	private InflateBlocks.InflateBlockMode mode; // 0x10
	internal int left; // 0x14
	internal int table; // 0x18
	internal int index; // 0x1C
	internal int[] blens; // 0x20
	internal int[] bb; // 0x28
	internal int[] tb; // 0x30
	internal InflateCodes codes; // 0x38
	internal int last; // 0x40
	internal ZlibCodec _codec; // 0x48
	internal int bitk; // 0x50
	internal int bitb; // 0x54
	internal int[] hufts; // 0x58
	internal byte[] window; // 0x60
	internal int end; // 0x68
	internal int readAt; // 0x6C
	internal int writeAt; // 0x70
	internal object checkfn; // 0x78
	internal uint check; // 0x80
	internal InfTree inftree; // 0x88

	// Methods

	// RVA: 0x1E6CD60 Offset: 0x1E6B760 VA: 0x181E6CD60
	internal void .ctor(ZlibCodec codec, object checkfn, int w) { }

	// RVA: 0x1E6CCD0 Offset: 0x1E6B6D0 VA: 0x181E6CCD0
	private static void .cctor() { }

	// RVA: 0x1E6CBC0 Offset: 0x1E6B5C0 VA: 0x181E6CBC0
	internal uint Reset() { }

	// RVA: 0x1E6B650 Offset: 0x1E6A050 VA: 0x181E6B650
	internal int Process(int r) { }

	// RVA: 0x1E6B610 Offset: 0x1E6A010 VA: 0x181E6B610
	internal void Free() { }

	// RVA: 0x1E6CC70 Offset: 0x1E6B670 VA: 0x181E6CC70
	internal void SetDictionary(byte[] d, int start, int n) { }

	// RVA: 0x1E6CCC0 Offset: 0x1E6B6C0 VA: 0x181E6CCC0
	internal int SyncPoint() { }

	// RVA: 0x1E6B460 Offset: 0x1E69E60 VA: 0x181E6B460
	internal int Flush(int r) { }
}
