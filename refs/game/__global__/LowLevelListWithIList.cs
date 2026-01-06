private struct LowLevelListWithIList.Enumerator<T> : IEnumerator<T>, IDisposable, IEnumerator // TypeDefIndex: 5004
{
	// Fields
	private LowLevelListWithIList<T> _list; // 0x0
	private int _index; // 0x0
	private int _version; // 0x0
	private T _current; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(LowLevelListWithIList<T> list) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x16664A0 Offset: 0x1664EA0 VA: 0x1816664A0
	|-LowLevelListWithIList.Enumerator<object>..ctor
	|
	|-RVA: 0x1679C90 Offset: 0x1678690 VA: 0x181679C90
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-LowLevelListWithIList.Enumerator<object>.Dispose
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1669260 Offset: 0x1667C60 VA: 0x181669260
	|-LowLevelListWithIList.Enumerator<object>.MoveNext
	|
	|-RVA: 0x1672D00 Offset: 0x1671700 VA: 0x181672D00
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.MoveNext
	*/

	// RVA: -1 Offset: -1
	private bool MoveNextRare() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1667860 Offset: 0x1666260 VA: 0x181667860
	|-LowLevelListWithIList.Enumerator<object>.MoveNextRare
	|
	|-RVA: 0x16720F0 Offset: 0x1670AF0 VA: 0x1816720F0
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.MoveNextRare
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	|-LowLevelListWithIList.Enumerator<object>.get_Current
	|
	|-RVA: 0x167AD60 Offset: 0x1679760 VA: 0x18167AD60
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x166AC50 Offset: 0x1669650 VA: 0x18166AC50
	|-LowLevelListWithIList.Enumerator<object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1678790 Offset: 0x1677190 VA: 0x181678790
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1669570 Offset: 0x1667F70 VA: 0x181669570
	|-LowLevelListWithIList.Enumerator<object>.System.Collections.IEnumerator.Reset
	|
	|-RVA: 0x1676520 Offset: 0x1674F20 VA: 0x181676520
	|-LowLevelListWithIList.Enumerator<__Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/
}
