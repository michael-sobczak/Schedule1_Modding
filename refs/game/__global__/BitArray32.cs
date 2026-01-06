public struct BitArray32 : IBitArray // TypeDefIndex: 13840
{
	// Fields
	[SerializeField]
	private uint data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	private string humanizedVersion { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0xF72870 Offset: 0xF71270 VA: 0x180F72870 Slot: 4
	public uint get_capacity() { }

	// RVA: 0xD92CF0 Offset: 0xD916F0 VA: 0x180D92CF0 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x2A328F0 Offset: 0x2A312F0 VA: 0x182A328F0 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x2A32A40 Offset: 0x2A31440 VA: 0x182A32A40
	private string get_humanizedVersion() { }

	// RVA: 0x2A32900 Offset: 0x2A31300 VA: 0x182A32900 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x2A328D0 Offset: 0x2A312D0 VA: 0x182A328D0 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x2A32AA0 Offset: 0x2A314A0 VA: 0x182A32AA0 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void .ctor(uint initValue) { }

	// RVA: 0x2A32830 Offset: 0x2A31230 VA: 0x182A32830
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x2A32640 Offset: 0x2A31040 VA: 0x182A32640 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x2A32710 Offset: 0x2A31110 VA: 0x182A32710 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x2A326C0 Offset: 0x2A310C0 VA: 0x182A326C0 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0xB0B4D0 Offset: 0xB09ED0 VA: 0x180B0B4D0
	public static BitArray32 op_OnesComplement(BitArray32 a) { }

	// RVA: 0xB0B4B0 Offset: 0xB09EB0 VA: 0x180B0B4B0
	public static BitArray32 op_BitwiseOr(BitArray32 a, BitArray32 b) { }

	// RVA: 0xB0B4A0 Offset: 0xB09EA0 VA: 0x180B0B4A0
	public static BitArray32 op_BitwiseAnd(BitArray32 a, BitArray32 b) { }

	// RVA: 0xC7B900 Offset: 0xC7A300 VA: 0x180C7B900
	public static bool op_Equality(BitArray32 a, BitArray32 b) { }

	// RVA: 0xCB1130 Offset: 0xCAFB30 VA: 0x180CB1130
	public static bool op_Inequality(BitArray32 a, BitArray32 b) { }

	// RVA: 0x2A32790 Offset: 0x2A31190 VA: 0x182A32790 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A32810 Offset: 0x2A31210 VA: 0x182A32810 Slot: 2
	public override int GetHashCode() { }
}
