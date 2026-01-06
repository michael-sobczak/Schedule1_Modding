public struct UnsafeHashSet.Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable // TypeDefIndex: 15953
{
	// Fields
	internal UnsafeParallelHashMapDataEnumerator m_Enumerator; // 0x0

	// Properties
	public T Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-UnsafeHashSet.Enumerator<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1672BD0 Offset: 0x16715D0 VA: 0x181672BD0
	|-UnsafeHashSet.Enumerator<__Il2CppFullySharedGenericStructType>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1676020 Offset: 0x1674A20 VA: 0x181676020
	|-UnsafeHashSet.Enumerator<__Il2CppFullySharedGenericStructType>.Reset
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x167AE40 Offset: 0x1679840 VA: 0x18167AE40
	|-UnsafeHashSet.Enumerator<__Il2CppFullySharedGenericStructType>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1677E90 Offset: 0x1676890 VA: 0x181677E90
	|-UnsafeHashSet.Enumerator<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerator.get_Current
	*/
}
