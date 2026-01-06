public struct UnsafeParallelHashSet<T> : INativeDisposable, IDisposable, IEnumerable<T>, IEnumerable // TypeDefIndex: 15993
{
	// Fields
	internal UnsafeParallelHashMap<T, bool> m_Data; // 0x0

	// Properties
	public bool IsEmpty { get; }
	public int Capacity { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int capacity, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D8060 Offset: 0x12D6A60 VA: 0x1812D8060
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool get_IsEmpty() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086D20 Offset: 0x1085720 VA: 0x181086D20
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1
	public int Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086930 Offset: 0x1085330 VA: 0x181086930
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086CB0 Offset: 0x10856B0 VA: 0x181086CB0
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1
	public void set_Capacity(int value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086D90 Offset: 0x1085790 VA: 0x181086D90
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10854E0 Offset: 0x1083EE0 VA: 0x1810854E0
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085EC0 Offset: 0x10848C0 VA: 0x181085EC0
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10869A0 Offset: 0x10853A0 VA: 0x1810869A0
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085380 Offset: 0x1083D80 VA: 0x181085380
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.Clear
	*/

	// RVA: -1 Offset: -1
	public bool Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10866A0 Offset: 0x10850A0 VA: 0x1810866A0
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086A50 Offset: 0x1085450 VA: 0x181086A50
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086840 Offset: 0x1085240 VA: 0x181086840
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.Contains
	*/

	// RVA: -1 Offset: -1
	public NativeArray<T> ToNativeArray(AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1086B40 Offset: 0x1085540 VA: 0x181086B40
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.ToNativeArray
	*/

	// RVA: -1 Offset: -1
	public UnsafeParallelHashSet.ParallelWriter<T> AsParallelWriter() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x12D7FC0 Offset: 0x12D69C0 VA: 0x1812D7FC0
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.AsParallelWriter
	*/

	// RVA: -1 Offset: -1
	public UnsafeParallelHashSet.Enumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1085670 Offset: 0x1084070 VA: 0x181085670
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.System.Collections.Generic.IEnumerable<T>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-UnsafeParallelHashSet<__Il2CppFullySharedGenericStructType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
