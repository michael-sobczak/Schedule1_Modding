internal struct Long1024 : IIndexable<long> // TypeDefIndex: 15742
{
	// Fields
	internal Long512 f0; // 0x0
	internal Long512 f1; // 0x1000

	// Properties
	public int Length { get; set; }

	// Methods

	// RVA: 0xF72A30 Offset: 0xF71430 VA: 0x180F72A30 Slot: 4
	public int get_Length() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 5
	public void set_Length(int value) { }

	// RVA: 0x2731260 Offset: 0x272FC60 VA: 0x182731260 Slot: 6
	public ref long ElementAt(int index) { }
}
