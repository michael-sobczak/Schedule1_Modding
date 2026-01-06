internal class PriorityQueue<TValue> // TypeDefIndex: 10798
{
	// Fields
	private PriorityHeap.LessOrEqual<TValue> _leq; // 0x0
	private PriorityHeap<TValue> _heap; // 0x0
	private TValue[] _keys; // 0x0
	private int[] _order; // 0x0
	private int _size; // 0x0
	private int _max; // 0x0
	private bool _initialized; // 0x0

	// Properties
	public bool Empty { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102780 Offset: 0x1101180 VA: 0x181102780
	|-PriorityQueue<object>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialSize, PriorityHeap.LessOrEqual<TValue> leq) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102680 Offset: 0x1101080 VA: 0x181102680
	|-PriorityQueue<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Swap(ref int a, ref int b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102570 Offset: 0x1100F70 VA: 0x181102570
	|-PriorityQueue<object>.Swap
	*/

	// RVA: -1 Offset: -1
	public void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1101430 Offset: 0x10FFE30 VA: 0x181101430
	|-PriorityQueue<object>.Init
	*/

	// RVA: -1 Offset: -1
	public PQHandle Insert(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11021D0 Offset: 0x1100BD0 VA: 0x1811021D0
	|-PriorityQueue<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public TValue ExtractMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11012B0 Offset: 0x10FFCB0 VA: 0x1811012B0
	|-PriorityQueue<object>.ExtractMin
	*/

	// RVA: -1 Offset: -1
	public TValue Minimum() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1102370 Offset: 0x1100D70 VA: 0x181102370
	|-PriorityQueue<object>.Minimum
	*/

	// RVA: -1 Offset: -1
	public void Remove(PQHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11024B0 Offset: 0x1100EB0 VA: 0x1811024B0
	|-PriorityQueue<object>.Remove
	*/
}
