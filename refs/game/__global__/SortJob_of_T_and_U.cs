public struct SortJob<T, U> // TypeDefIndex: 15894
{
	// Fields
	public T* Data; // 0x0
	public U Comp; // 0x0
	public int Length; // 0x0

	// Methods

	[NotBurstCompatible]
	// RVA: -1 Offset: -1
	public JobHandle Schedule(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C34A0 Offset: 0x11C1EA0 VA: 0x1811C34A0
	|-SortJob<__Il2CppFullySharedGenericStructType, __Il2CppFullySharedGenericType>.Schedule
	*/
}
