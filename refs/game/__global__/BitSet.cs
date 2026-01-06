internal sealed class BitSet // TypeDefIndex: 8242
{
	// Fields
	private int count; // 0x10
	private uint[] bits; // 0x18

	// Properties
	public int Count { get; }
	public bool Item { get; }
	public bool IsEmpty { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x255FDE0 Offset: 0x255E7E0 VA: 0x18255FDE0
	public void .ctor(int count) { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_Count() { }

	// RVA: 0x255FAF0 Offset: 0x255E4F0 VA: 0x18255FAF0
	public bool get_Item(int index) { }

	// RVA: 0x255F740 Offset: 0x255E140 VA: 0x18255F740
	public void Clear() { }

	// RVA: 0x255FD60 Offset: 0x255E760 VA: 0x18255FD60
	public void Set(int index) { }

	// RVA: 0x255FAF0 Offset: 0x255E4F0 VA: 0x18255FAF0
	public bool Get(int index) { }

	// RVA: 0x255FC20 Offset: 0x255E620 VA: 0x18255FC20
	public int NextSet(int startFrom) { }

	// RVA: 0x255F660 Offset: 0x255E060 VA: 0x18255F660
	public void And(BitSet other) { }

	// RVA: 0x255FCC0 Offset: 0x255E6C0 VA: 0x18255FCC0
	public void Or(BitSet other) { }

	// RVA: 0x255FAB0 Offset: 0x255E4B0 VA: 0x18255FAB0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x255F920 Offset: 0x255E320 VA: 0x18255F920 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x255F7A0 Offset: 0x255E1A0 VA: 0x18255F7A0
	public BitSet Clone() { }

	// RVA: 0x255FE50 Offset: 0x255E850 VA: 0x18255FE50
	public bool get_IsEmpty() { }

	// RVA: 0x255FB40 Offset: 0x255E540 VA: 0x18255FB40
	public bool Intersects(BitSet other) { }

	// RVA: 0x255FDD0 Offset: 0x255E7D0 VA: 0x18255FDD0
	private int Subscript(int bitIndex) { }

	// RVA: 0x255F890 Offset: 0x255E290 VA: 0x18255F890
	private void EnsureLength(int nRequiredLength) { }
}
