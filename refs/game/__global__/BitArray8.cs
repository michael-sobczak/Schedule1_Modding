public struct BitArray8 : IBitArray // TypeDefIndex: 13838
{
	// Fields
	[SerializeField]
	private byte data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x20CC900 Offset: 0x20CB300 VA: 0x1820CC900 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x2A33200 Offset: 0x2A31C00 VA: 0x182A33200 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x2A33210 Offset: 0x2A31C10 VA: 0x182A33210 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x2A331E0 Offset: 0x2A31BE0 VA: 0x182A331E0 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x2A33340 Offset: 0x2A31D40 VA: 0x182A33340 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x131D950 Offset: 0x131C350 VA: 0x18131D950
	public void .ctor(byte initValue) { }

	// RVA: 0x2A33140 Offset: 0x2A31B40 VA: 0x182A33140
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x2A33330 Offset: 0x2A31D30 VA: 0x182A33330
	public static BitArray8 op_OnesComplement(BitArray8 a) { }

	// RVA: 0x2A33300 Offset: 0x2A31D00 VA: 0x182A33300
	public static BitArray8 op_BitwiseOr(BitArray8 a, BitArray8 b) { }

	// RVA: 0x2A332F0 Offset: 0x2A31CF0 VA: 0x182A332F0
	public static BitArray8 op_BitwiseAnd(BitArray8 a, BitArray8 b) { }

	// RVA: 0x2A32F30 Offset: 0x2A31930 VA: 0x182A32F30 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x2A33010 Offset: 0x2A31A10 VA: 0x182A33010 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x2A32FC0 Offset: 0x2A319C0 VA: 0x182A32FC0 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0x2A33310 Offset: 0x2A31D10 VA: 0x182A33310
	public static bool op_Equality(BitArray8 a, BitArray8 b) { }

	// RVA: 0x2A33320 Offset: 0x2A31D20 VA: 0x182A33320
	public static bool op_Inequality(BitArray8 a, BitArray8 b) { }

	// RVA: 0x2A33090 Offset: 0x2A31A90 VA: 0x182A33090 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A33120 Offset: 0x2A31B20 VA: 0x182A33120 Slot: 2
	public override int GetHashCode() { }
}
