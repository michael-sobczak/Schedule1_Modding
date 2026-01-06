internal sealed class HuffmanTree // TypeDefIndex: 17646
{
	// Fields
	private readonly int _tableBits; // 0x10
	private readonly short[] _table; // 0x18
	private readonly short[] _left; // 0x20
	private readonly short[] _right; // 0x28
	private readonly byte[] _codeLengthArray; // 0x30
	private readonly int _tableMask; // 0x38
	[CompilerGenerated]
	private static readonly HuffmanTree <StaticLiteralLengthTree>k__BackingField; // 0x0
	[CompilerGenerated]
	private static readonly HuffmanTree <StaticDistanceTree>k__BackingField; // 0x8

	// Properties
	public static HuffmanTree StaticLiteralLengthTree { get; }
	public static HuffmanTree StaticDistanceTree { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x216ECB0 Offset: 0x216D6B0 VA: 0x18216ECB0
	public static HuffmanTree get_StaticLiteralLengthTree() { }

	[CompilerGenerated]
	// RVA: 0x216EC60 Offset: 0x216D660 VA: 0x18216EC60
	public static HuffmanTree get_StaticDistanceTree() { }

	// RVA: 0x216EB50 Offset: 0x216D550 VA: 0x18216EB50
	public void .ctor(byte[] codeLengths) { }

	// RVA: 0x216E890 Offset: 0x216D290 VA: 0x18216E890
	private static byte[] GetStaticLiteralTreeLength() { }

	// RVA: 0x216E830 Offset: 0x216D230 VA: 0x18216E830
	private static byte[] GetStaticDistanceTreeLength() { }

	// RVA: 0x216E1C0 Offset: 0x216CBC0 VA: 0x18216E1C0
	private uint[] CalculateHuffmanCode() { }

	// RVA: 0x216E3F0 Offset: 0x216CDF0 VA: 0x18216E3F0
	private void CreateTable() { }

	// RVA: 0x216E650 Offset: 0x216D050 VA: 0x18216E650
	public int GetNextSymbol(InputBuffer input) { }

	// RVA: 0x216E960 Offset: 0x216D360 VA: 0x18216E960
	private static void .cctor() { }
}
