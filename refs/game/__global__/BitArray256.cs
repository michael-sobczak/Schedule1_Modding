public struct BitArray256 : IBitArray // TypeDefIndex: 13843
{
	// Fields
	[SerializeField]
	private ulong data1; // 0x0
	[SerializeField]
	private ulong data2; // 0x8
	[SerializeField]
	private ulong data3; // 0x10
	[SerializeField]
	private ulong data4; // 0x18

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0xF72A00 Offset: 0xF71400 VA: 0x180F72A00 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x2A32130 Offset: 0x2A30B30 VA: 0x182A32130 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x2A32150 Offset: 0x2A30B50 VA: 0x182A32150 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x2A32170 Offset: 0x2A30B70 VA: 0x182A32170 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x2A320E0 Offset: 0x2A30AE0 VA: 0x182A320E0 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x2A325B0 Offset: 0x2A30FB0 VA: 0x182A325B0 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0xC411A0 Offset: 0xC3FBA0 VA: 0x180C411A0
	public void .ctor(ulong initValue1, ulong initValue2, ulong initValue3, ulong initValue4) { }

	// RVA: 0x2A31FE0 Offset: 0x2A309E0 VA: 0x182A31FE0
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x2A32580 Offset: 0x2A30F80 VA: 0x182A32580
	public static BitArray256 op_OnesComplement(BitArray256 a) { }

	// RVA: 0x2A324C0 Offset: 0x2A30EC0 VA: 0x182A324C0
	public static BitArray256 op_BitwiseOr(BitArray256 a, BitArray256 b) { }

	// RVA: 0x2A32480 Offset: 0x2A30E80 VA: 0x182A32480
	public static BitArray256 op_BitwiseAnd(BitArray256 a, BitArray256 b) { }

	// RVA: 0x2A31B40 Offset: 0x2A30540 VA: 0x182A31B40 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x2A31D00 Offset: 0x2A30700 VA: 0x182A31D00 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x2A31C60 Offset: 0x2A30660 VA: 0x182A31C60 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x2A32500 Offset: 0x2A30F00 VA: 0x182A32500
	public static bool op_Equality(BitArray256 a, BitArray256 b) { }

	// RVA: 0x2A32540 Offset: 0x2A30F40 VA: 0x182A32540
	public static bool op_Inequality(BitArray256 a, BitArray256 b) { }

	// RVA: 0x2A31E20 Offset: 0x2A30820 VA: 0x182A31E20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A31F60 Offset: 0x2A30960 VA: 0x182A31F60 Slot: 2
	public override int GetHashCode() { }
}
