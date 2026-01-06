internal sealed class InflaterManaged // TypeDefIndex: 17647
{
	// Fields
	private static readonly byte[] s_extraLengthBits; // 0x0
	private static readonly int[] s_lengthBase; // 0x8
	private static readonly int[] s_distanceBasePosition; // 0x10
	private static readonly byte[] s_codeOrder; // 0x18
	private static readonly byte[] s_staticDistanceTreeTable; // 0x20
	private readonly OutputWindow _output; // 0x10
	private readonly InputBuffer _input; // 0x18
	private HuffmanTree _literalLengthTree; // 0x20
	private HuffmanTree _distanceTree; // 0x28
	private InflaterState _state; // 0x30
	private bool _hasFormatReader; // 0x34
	private int _bfinal; // 0x38
	private BlockType _blockType; // 0x3C
	private readonly byte[] _blockLengthBuffer; // 0x40
	private int _blockLength; // 0x48
	private int _length; // 0x4C
	private int _distanceCode; // 0x50
	private int _extraBits; // 0x54
	private int _loopCounter; // 0x58
	private int _literalLengthCodeCount; // 0x5C
	private int _distanceCodeCount; // 0x60
	private int _codeLengthCodeCount; // 0x64
	private int _codeArraySize; // 0x68
	private int _lengthCode; // 0x6C
	private readonly byte[] _codeList; // 0x70
	private readonly byte[] _codeLengthTreeCodeLength; // 0x78
	private readonly bool _deflate64; // 0x80
	private HuffmanTree _codeLengthTree; // 0x88
	private IFileFormatReader _formatReader; // 0x90

	// Methods

	// RVA: 0x2170400 Offset: 0x216EE00 VA: 0x182170400
	internal void .ctor(IFileFormatReader reader, bool deflate64) { }

	// RVA: 0x2170180 Offset: 0x216EB80 VA: 0x182170180
	private void Reset() { }

	// RVA: 0x21701A0 Offset: 0x216EBA0 VA: 0x1821701A0
	public void SetInput(byte[] inputBytes, int offset, int length) { }

	// RVA: 0x216FF40 Offset: 0x216E940 VA: 0x18216FF40
	public bool Finished() { }

	// RVA: 0x216FF60 Offset: 0x216E960 VA: 0x18216FF60
	public int Inflate(byte[] bytes, int offset, int length) { }

	// RVA: 0x216FBC0 Offset: 0x216E5C0 VA: 0x18216FBC0
	private bool Decode() { }

	// RVA: 0x216F930 Offset: 0x216E330 VA: 0x18216F930
	private bool DecodeUncompressedBlock(out bool end_of_block) { }

	// RVA: 0x216ED00 Offset: 0x216D700 VA: 0x18216ED00
	private bool DecodeBlock(out bool end_of_block_code_seen) { }

	// RVA: 0x216F190 Offset: 0x216DB90 VA: 0x18216F190
	private bool DecodeDynamicBlockHeader() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void Dispose() { }

	// RVA: 0x21701F0 Offset: 0x216EBF0 VA: 0x1821701F0
	private static void .cctor() { }
}
