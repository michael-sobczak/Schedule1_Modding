public struct UnsafeList.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 15968
{
	// Fields
	internal T* m_Ptr; // 0x0
	internal int m_Length; // 0x0
	internal int m_Index; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-UnsafeList.Enumerator<byte>.Dispose
	|-UnsafeList.Enumerator<int>.Dispose
	|-UnsafeList.Enumerator<IntPtr>.Dispose
	|-UnsafeList.Enumerator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1662B70 Offset: 0x1661570 VA: 0x181662B70
	|-UnsafeList.Enumerator<byte>.MoveNext
	|-UnsafeList.Enumerator<int>.MoveNext
	|-UnsafeList.Enumerator<IntPtr>.MoveNext
	|-UnsafeList.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1663C00 Offset: 0x1662600 VA: 0x181663C00
	|-UnsafeList.Enumerator<byte>.Reset
	|-UnsafeList.Enumerator<int>.Reset
	|-UnsafeList.Enumerator<IntPtr>.Reset
	|-UnsafeList.Enumerator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1667500 Offset: 0x1665F00 VA: 0x181667500
	|-UnsafeList.Enumerator<byte>.get_Current
	|
	|-RVA: 0x166C840 Offset: 0x166B240 VA: 0x18166C840
	|-UnsafeList.Enumerator<int>.get_Current
	|
	|-RVA: 0x166C620 Offset: 0x166B020 VA: 0x18166C620
	|-UnsafeList.Enumerator<IntPtr>.get_Current
	|
	|-RVA: 0x167AF30 Offset: 0x1679930 VA: 0x18167AF30
	|-UnsafeList.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1665E60 Offset: 0x1664860 VA: 0x181665E60
	|-UnsafeList.Enumerator<byte>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166A630 Offset: 0x1669030 VA: 0x18166A630
	|-UnsafeList.Enumerator<int>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x166B2C0 Offset: 0x1669CC0 VA: 0x18166B2C0
	|-UnsafeList.Enumerator<IntPtr>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0x1677E90 Offset: 0x1676890 VA: 0x181677E90
	|-UnsafeList.Enumerator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}
