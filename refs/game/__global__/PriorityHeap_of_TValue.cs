internal class PriorityHeap<TValue> // TypeDefIndex: 10796
{
	// Fields
	private readonly PriorityHeap.LessOrEqual<TValue> _leq; // 0x0
	private int[] _nodes; // 0x0
	private PriorityHeap.HandleElem<TValue>[] _handles; // 0x0
	private int _size; // 0x0
	private int _max; // 0x0
	private int _freeList; // 0x0
	private bool _initialized; // 0x0

	// Properties
	public bool Empty { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_Empty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11012A0 Offset: 0x10FFCA0 VA: 0x1811012A0
	|-PriorityHeap<object>.get_Empty
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int initialSize, PriorityHeap.LessOrEqual<TValue> leq) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1100F80 Offset: 0x10FF980 VA: 0x181100F80
	|-PriorityHeap<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private void FloatDown(int curr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11004D0 Offset: 0x10FEED0 VA: 0x1811004D0
	|-PriorityHeap<object>.FloatDown
	*/

	// RVA: -1 Offset: -1
	private void FloatUp(int curr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11006E0 Offset: 0x10FF0E0 VA: 0x1811006E0
	|-PriorityHeap<object>.FloatUp
	*/

	// RVA: -1 Offset: -1
	public void Init() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1100840 Offset: 0x10FF240 VA: 0x181100840
	|-PriorityHeap<object>.Init
	*/

	// RVA: -1 Offset: -1
	public PQHandle Insert(TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11008B0 Offset: 0x10FF2B0 VA: 0x1811008B0
	|-PriorityHeap<object>.Insert
	*/

	// RVA: -1 Offset: -1
	public TValue ExtractMin() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1100390 Offset: 0x10FED90 VA: 0x181100390
	|-PriorityHeap<object>.ExtractMin
	*/

	// RVA: -1 Offset: -1
	public TValue Minimum() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1100D30 Offset: 0x10FF730 VA: 0x181100D30
	|-PriorityHeap<object>.Minimum
	*/

	// RVA: -1 Offset: -1
	public void Remove(PQHandle handle) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1100D80 Offset: 0x10FF780 VA: 0x181100D80
	|-PriorityHeap<object>.Remove
	*/
}
