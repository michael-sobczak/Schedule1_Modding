internal struct InclusiveRange // TypeDefIndex: 9026
{
	// Fields
	public short start; // 0x0
	public short end; // 0x2

	// Properties
	public bool isEmpty { get; }
	public static InclusiveRange empty { get; }

	// Methods

	// RVA: 0x294DDF0 Offset: 0x294C7F0 VA: 0x18294DDF0
	public void .ctor(short startEnd) { }

	// RVA: 0x691550 Offset: 0x68FF50 VA: 0x180691550
	public void .ctor(short start, short end) { }

	// RVA: 0x2B166B0 Offset: 0x2B150B0 VA: 0x182B166B0
	public void Expand(short index) { }

	// RVA: 0x2B16610 Offset: 0x2B15010 VA: 0x182B16610
	public void Clamp(short min, short max) { }

	// RVA: 0x2B16850 Offset: 0x2B15250 VA: 0x182B16850
	public bool get_isEmpty() { }

	// RVA: 0x2B166A0 Offset: 0x2B150A0 VA: 0x182B166A0
	public bool Contains(short index) { }

	// RVA: 0x2B16730 Offset: 0x2B15130 VA: 0x182B16730
	public static InclusiveRange Merge(InclusiveRange a, InclusiveRange b) { }

	// RVA: 0x2B16840 Offset: 0x2B15240 VA: 0x182B16840
	public static InclusiveRange get_empty() { }

	// RVA: 0x2B167B0 Offset: 0x2B151B0 VA: 0x182B167B0 Slot: 3
	public override string ToString() { }
}
