public struct BitArray16 : IBitArray // TypeDefIndex: 13839
{
	// Fields
	[SerializeField]
	private ushort data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0xF6D420 Offset: 0xF6BE20 VA: 0x180F6D420 Slot: 4
	public uint get_capacity() { }

	// RVA: 0x27202C0 Offset: 0x271ECC0 VA: 0x1827202C0 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x2A319A0 Offset: 0x2A303A0 VA: 0x182A319A0 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x2A319B0 Offset: 0x2A303B0 VA: 0x182A319B0 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x2A31980 Offset: 0x2A30380 VA: 0x182A31980 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x2A31B20 Offset: 0x2A30520 VA: 0x182A31B20 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0xC81A60 Offset: 0xC80460 VA: 0x180C81A60
	public void .ctor(ushort initValue) { }

	// RVA: 0x2A318E0 Offset: 0x2A302E0 VA: 0x182A318E0
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x2A31B10 Offset: 0x2A30510 VA: 0x182A31B10
	public static BitArray16 op_OnesComplement(BitArray16 a) { }

	// RVA: 0x2A31B00 Offset: 0x2A30500 VA: 0x182A31B00
	public static BitArray16 op_BitwiseOr(BitArray16 a, BitArray16 b) { }

	// RVA: 0x2A31AF0 Offset: 0x2A304F0 VA: 0x182A31AF0
	public static BitArray16 op_BitwiseAnd(BitArray16 a, BitArray16 b) { }

	// RVA: 0x2A316D0 Offset: 0x2A300D0 VA: 0x182A316D0 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x2A317B0 Offset: 0x2A301B0 VA: 0x182A317B0 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x2A31760 Offset: 0x2A30160 VA: 0x182A31760 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0xC81A70 Offset: 0xC80470 VA: 0x180C81A70
	public static bool op_Equality(BitArray16 a, BitArray16 b) { }

	// RVA: 0x2953250 Offset: 0x2951C50 VA: 0x182953250
	public static bool op_Inequality(BitArray16 a, BitArray16 b) { }

	// RVA: 0x2A31830 Offset: 0x2A30230 VA: 0x182A31830 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A318C0 Offset: 0x2A302C0 VA: 0x182A318C0 Slot: 2
	public override int GetHashCode() { }
}
