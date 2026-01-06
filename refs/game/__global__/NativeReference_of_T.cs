public struct NativeReference<T> : INativeDisposable, IDisposable, IEquatable<NativeReference<T>> // TypeDefIndex: 15885
{
	// Fields
	[NativeDisableUnsafePtrRestriction]
	internal void* m_Data; // 0x0
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel; // 0x0

	// Properties
	public T Value { get; set; }
	public bool IsCreated { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = 1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10915C0 Offset: 0x108FFC0 VA: 0x1810915C0
	|-NativeReference<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(T value, AllocatorManager.AllocatorHandle allocator) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10916B0 Offset: 0x10900B0 VA: 0x1810916B0
	|-NativeReference<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void Allocate(AllocatorManager.AllocatorHandle allocator, out NativeReference<T> reference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090BD0 Offset: 0x108F5D0 VA: 0x181090BD0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.Allocate
	*/

	// RVA: -1 Offset: -1
	public T get_Value() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10917F0 Offset: 0x10901F0 VA: 0x1810917F0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.get_Value
	*/

	// RVA: -1 Offset: -1
	public void set_Value(T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10919B0 Offset: 0x10903B0 VA: 0x1810919B0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.set_Value
	*/

	// RVA: -1 Offset: -1
	public bool get_IsCreated() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.get_IsCreated
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090FB0 Offset: 0x108F9B0 VA: 0x181090FB0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 4
	public JobHandle Dispose(JobHandle inputDeps) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090ED0 Offset: 0x108F8D0 VA: 0x181090ED0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.Dispose
	*/

	// RVA: -1 Offset: -1
	public void CopyFrom(NativeReference<T> reference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090D20 Offset: 0x108F720 VA: 0x181090D20
	|-NativeReference<__Il2CppFullySharedGenericStructType>.CopyFrom
	*/

	// RVA: -1 Offset: -1
	public void CopyTo(NativeReference<T> reference) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090DB0 Offset: 0x108F7B0 VA: 0x181090DB0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.CopyTo
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 6
	public bool Equals(NativeReference<T> other) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090FF0 Offset: 0x108F9F0 VA: 0x181090FF0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.Equals
	*/

	[NotBurstCompatible]
	// RVA: -1 Offset: -1 Slot: 0
	public override bool Equals(object obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1091290 Offset: 0x108FC90 VA: 0x181091290
	|-NativeReference<__Il2CppFullySharedGenericStructType>.Equals
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public override int GetHashCode() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10913D0 Offset: 0x108FDD0 VA: 0x1810913D0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.GetHashCode
	*/

	// RVA: -1 Offset: -1
	public static bool op_Equality(NativeReference<T> left, NativeReference<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1091890 Offset: 0x1090290 VA: 0x181091890
	|-NativeReference<__Il2CppFullySharedGenericStructType>.op_Equality
	*/

	// RVA: -1 Offset: -1
	public static bool op_Inequality(NativeReference<T> left, NativeReference<T> right) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1091920 Offset: 0x1090320 VA: 0x181091920
	|-NativeReference<__Il2CppFullySharedGenericStructType>.op_Inequality
	*/

	// RVA: -1 Offset: -1
	public static void Copy(NativeReference<T> dst, NativeReference<T> src) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090E40 Offset: 0x108F840 VA: 0x181090E40
	|-NativeReference<__Il2CppFullySharedGenericStructType>.Copy
	*/

	// RVA: -1 Offset: -1
	public NativeReference.ReadOnly<T> AsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1088270 Offset: 0x1086C70 VA: 0x181088270
	|-NativeReference<__Il2CppFullySharedGenericStructType>.AsReadOnly
	*/

	[Conditional("ENABLE_UNITY_COLLECTIONS_CHECKS")]
	// RVA: -1 Offset: -1
	private void CheckNotDisposed() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1090CC0 Offset: 0x108F6C0 VA: 0x181090CC0
	|-NativeReference<__Il2CppFullySharedGenericStructType>.CheckNotDisposed
	*/
}
