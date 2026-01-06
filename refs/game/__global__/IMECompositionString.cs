public struct IMECompositionString : IEnumerable<char>, IEnumerable // TypeDefIndex: 7671
{
	// Fields
	private int size; // 0x0
	[FixedBuffer(typeof(char), 64)]
	private IMECompositionString.<buffer>e__FixedBuffer buffer; // 0x4

	// Properties
	public int Count { get; }
	public char Item { get; }

	// Methods

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public int get_Count() { }

	// RVA: 0x285FAF0 Offset: 0x285E4F0 VA: 0x18285FAF0
	public char get_Item(int index) { }

	// RVA: 0x285FA60 Offset: 0x285E460 VA: 0x18285FA60
	public void .ctor(string characters) { }

	// RVA: 0x285FA30 Offset: 0x285E430 VA: 0x18285FA30 Slot: 3
	public override string ToString() { }

	// RVA: 0x285F950 Offset: 0x285E350 VA: 0x18285F950 Slot: 4
	public IEnumerator<char> GetEnumerator() { }

	// RVA: 0x285FA20 Offset: 0x285E420 VA: 0x18285FA20 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
}
