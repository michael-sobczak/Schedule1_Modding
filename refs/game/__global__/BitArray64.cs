public struct BitArray64 : IBitArray // TypeDefIndex: 13841
{
	// Fields
	[SerializeField]
	private ulong data; // 0x0

	// Properties
	public uint capacity { get; }
	public bool allFalse { get; }
	public bool allTrue { get; }
	public string humanizedData { get; }
	public bool Item { get; set; }

	// Methods

	// RVA: 0xF728B0 Offset: 0xF712B0 VA: 0x180F728B0 Slot: 4
	public uint get_capacity() { }

	// RVA: 0xC246A0 Offset: 0xC230A0 VA: 0x180C246A0 Slot: 5
	public bool get_allFalse() { }

	// RVA: 0x2A32D90 Offset: 0x2A31790 VA: 0x182A32D90 Slot: 6
	public bool get_allTrue() { }

	// RVA: 0x2A32DA0 Offset: 0x2A317A0 VA: 0x182A32DA0 Slot: 9
	public string get_humanizedData() { }

	// RVA: 0x2A32D70 Offset: 0x2A31770 VA: 0x182A32D70 Slot: 7
	public bool get_Item(uint index) { }

	// RVA: 0x2A32F10 Offset: 0x2A31910 VA: 0x182A32F10 Slot: 8
	public void set_Item(uint index, bool value) { }

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(ulong initValue) { }

	// RVA: 0x2A32CD0 Offset: 0x2A316D0 VA: 0x182A32CD0
	public void .ctor(IEnumerable<uint> bitIndexTrue) { }

	// RVA: 0x2A32F00 Offset: 0x2A31900 VA: 0x182A32F00
	public static BitArray64 op_OnesComplement(BitArray64 a) { }

	// RVA: 0x2A32EF0 Offset: 0x2A318F0 VA: 0x182A32EF0
	public static BitArray64 op_BitwiseOr(BitArray64 a, BitArray64 b) { }

	// RVA: 0x2A32EE0 Offset: 0x2A318E0 VA: 0x182A32EE0
	public static BitArray64 op_BitwiseAnd(BitArray64 a, BitArray64 b) { }

	// RVA: 0x2A32AC0 Offset: 0x2A314C0 VA: 0x182A32AC0 Slot: 10
	public IBitArray BitAnd(IBitArray other) { }

	// RVA: 0x2A32BA0 Offset: 0x2A315A0 VA: 0x182A32BA0 Slot: 11
	public IBitArray BitOr(IBitArray other) { }

	// RVA: 0x2A32B50 Offset: 0x2A31550 VA: 0x182A32B50 Slot: 12
	public IBitArray BitNot() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(BitArray64 a, BitArray64 b) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(BitArray64 a, BitArray64 b) { }

	// RVA: 0x2A32C20 Offset: 0x2A31620 VA: 0x182A32C20 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x2A32CB0 Offset: 0x2A316B0 VA: 0x182A32CB0 Slot: 2
	public override int GetHashCode() { }
}
