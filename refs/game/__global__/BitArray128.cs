public struct BitArray128 : IBitArray // TypeDefIndex: 13842
{
	// Fields
	[SerializeField]
	private ulong data1; // 0x0
	[SerializeField]
	private ulong data2; // 0x8

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0xF728A0 Offset: 0xF712A0 VA: 0x180F728A0 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x2A31450 Offset: 0x2A2FE50 VA: 0x182A31450 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x2A31470 Offset: 0x2A2FE70 VA: 0x182A31470 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x2A31490 Offset: 0x2A2FE90 VA: 0x182A31490 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x2A31420 Offset: 0x2A2FE20 VA: 0x182A31420 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x2A31690 Offset: 0x2A30090 VA: 0x182A31690 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0xC41170 Offset: 0xC3FB70 VA: 0x180C41170
	public void .ctor(ulong initValue1, ulong initValue2) { }

	// RVA: 0x2A31360 Offset: 0x2A2FD60 VA: 0x182A31360
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x2A31670 Offset: 0x2A30070 VA: 0x182A31670
	public static BitArray128 op_OnesComplement(BitArray128 a) { }

	// RVA: 0x2714C30 Offset: 0x2713630 VA: 0x182714C30
	public static BitArray128 op_BitwiseOr(BitArray128 a, BitArray128 b) { }

	// RVA: 0x2712EB0 Offset: 0x27118B0 VA: 0x182712EB0
	public static BitArray128 op_BitwiseAnd(BitArray128 a, BitArray128 b) { }

	// RVA: 0x2A31080 Offset: 0x2A2FA80 VA: 0x182A31080 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x2A311A0 Offset: 0x2A2FBA0 VA: 0x182A311A0 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x2A31140 Offset: 0x2A2FB40 VA: 0x182A31140 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0xBBEA90 Offset: 0xBBD490 VA: 0x180BBEA90
	public static bool op_Equality(BitArray128 a, BitArray128 b) { }

	// RVA: 0xBBEAB0 Offset: 0xBBD4B0 VA: 0x180BBEAB0
	public static bool op_Inequality(BitArray128 a, BitArray128 b) { }

	// RVA: 0x2A31260 Offset: 0x2A2FC60 VA: 0x182A31260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A31320 Offset: 0x2A2FD20 VA: 0x182A31320 Slot: 2
	public override int GetHashCode() { }
}
