public struct FixedArray3<T> : IEnumerable, IEnumerable<T> // TypeDefIndex: 18675
{
	// Fields
	public T _0; // 0x0
	public T _1; // 0x0
	public T _2; // 0x0

	// Properties
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C74B0 Offset: 0x17C5EB0 VA: 0x1817C74B0
	|-FixedArray3<object>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C74F0 Offset: 0x17C5EF0 VA: 0x1817C74F0
	|-FixedArray3<object>.get_Item
	*/

	// RVA: -1 Offset: -1
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7560 Offset: 0x17C5F60 VA: 0x1817C7560
	|-FixedArray3<object>.set_Item
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7200 Offset: 0x17C5C00 VA: 0x1817C7200
	|-FixedArray3<object>.Contains
	*/

	// RVA: -1 Offset: -1
	public int IndexOf(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7430 Offset: 0x17C5E30 VA: 0x1817C7430
	|-FixedArray3<object>.IndexOf
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7050 Offset: 0x17C5A50 VA: 0x1817C7050
	|-FixedArray3<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public void Clear(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C70D0 Offset: 0x17C5AD0 VA: 0x1817C70D0
	|-FixedArray3<object>.Clear
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	private IEnumerable<T> Enumerate() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7280 Offset: 0x17C5C80 VA: 0x1817C7280
	|-FixedArray3<object>.Enumerate
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x17C7340 Offset: 0x17C5D40 VA: 0x1817C7340
	|-FixedArray3<object>.GetEnumerator
	*/
}
