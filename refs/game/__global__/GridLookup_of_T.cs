public class GridLookup<T> // TypeDefIndex: 13397
{
	// Fields
	private Int2 size; // 0x0
	private GridLookup.Item<T>[] cells; // 0x0
	private GridLookup.Root<T> all; // 0x0
	private Dictionary<T, GridLookup.Root<T>> rootLookup; // 0x0
	private Stack<GridLookup.Item<T>> itemPool; // 0x0

	// Properties
	public GridLookup.Root<T> AllItems { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Int2 size) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181AF70 Offset: 0x1819970 VA: 0x18181AF70
	|-GridLookup<object>..ctor
	*/

	// RVA: -1 Offset: -1
	public GridLookup.Root<T> get_AllItems() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181B1D0 Offset: 0x1819BD0 VA: 0x18181B1D0
	|-GridLookup<object>.get_AllItems
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A890 Offset: 0x1819290 VA: 0x18181A890
	|-GridLookup<object>.Clear
	*/

	// RVA: -1 Offset: -1
	public GridLookup.Root<T> GetRoot(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A940 Offset: 0x1819340 VA: 0x18181A940
	|-GridLookup<object>.GetRoot
	*/

	// RVA: -1 Offset: -1
	public GridLookup.Root<T> Add(T item, IntRect bounds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A730 Offset: 0x1819130 VA: 0x18181A730
	|-GridLookup<object>.Add
	*/

	// RVA: -1 Offset: -1
	public void Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181AE30 Offset: 0x1819830 VA: 0x18181AE30
	|-GridLookup<object>.Remove
	*/

	// RVA: -1 Offset: -1
	public void Move(T item, IntRect bounds) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181A980 Offset: 0x1819380 VA: 0x18181A980
	|-GridLookup<object>.Move
	*/

	// RVA: -1 Offset: -1
	public List<U> QueryRect<U>(IntRect r) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC5D20 Offset: 0xDC4720 VA: 0x180DC5D20
	|-GridLookup<object>.QueryRect<object>
	*/
}
