public struct UQueryState.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 6943
{
	// Fields
	private List<VisualElement> iterationList; // 0x0
	private int currentIndex; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(UQueryState<T> queryState) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166BFE0 Offset: 0x166A9E0 VA: 0x18166BFE0
	|-UQueryState.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166C680 Offset: 0x166B080 VA: 0x18166C680
	|-UQueryState.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166B4F0 Offset: 0x1669EF0 VA: 0x18166B4F0
	|-UQueryState.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1668DA0 Offset: 0x16677A0 VA: 0x181668DA0
	|-UQueryState.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16694D0 Offset: 0x1667ED0 VA: 0x1816694D0
	|-UQueryState.Enumerator<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16675D0 Offset: 0x1665FD0 VA: 0x1816675D0
	|-UQueryState.Enumerator<object>.Dispose
	*/
}
