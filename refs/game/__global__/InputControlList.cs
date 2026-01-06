private struct InputControlList.Enumerator<TControl> : IEnumerator<TControl>, IEnumerator, IDisposable // TypeDefIndex: 7354
{
	// Fields
	private readonly ulong* m_Indices; // 0x0
	private readonly int m_Count; // 0x0
	private int m_Current; // 0x0

	// Properties
	public TControl Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(InputControlList<TControl> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166B9D0 Offset: 0x166A3D0 VA: 0x18166B9D0
	|-InputControlList.Enumerator<object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1668960 Offset: 0x1667360 VA: 0x181668960
	|-InputControlList.Enumerator<object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663C00 Offset: 0x1662600 VA: 0x181663C00
	|-InputControlList.Enumerator<object>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public TControl get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166C260 Offset: 0x166AC60 VA: 0x18166C260
	|-InputControlList.Enumerator<object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166A770 Offset: 0x1669170 VA: 0x18166A770
	|-InputControlList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-InputControlList.Enumerator<object>.Dispose
	*/
}
