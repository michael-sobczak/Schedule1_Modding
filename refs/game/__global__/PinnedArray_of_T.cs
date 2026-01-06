internal struct PinnedArray<T> : IDisposable // TypeDefIndex: 8904
{
	// Fields
	public T[] managedArray; // 0x0
	public GCHandle handle; // 0x0
	public NativeArray<T> nativeArray; // 0x0

	// Properties
	public int length { get; }

	// Methods

	// RVA: -1 Offset: -1
	public int get_length() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F5FE0 Offset: 0x10F49E0 VA: 0x1810F5FE0
	|-PinnedArray<__Il2CppFullySharedGenericStructType>.get_length
	*/

	// RVA: -1 Offset: -1
	public void .ctor(int length) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F5EC0 Offset: 0x10F48C0 VA: 0x1810F5EC0
	|-PinnedArray<__Il2CppFullySharedGenericStructType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10F5E90 Offset: 0x10F4890 VA: 0x1810F5E90
	|-PinnedArray<__Il2CppFullySharedGenericStructType>.Dispose
	*/
}
