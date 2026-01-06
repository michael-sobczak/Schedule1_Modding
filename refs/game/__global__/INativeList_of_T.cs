public interface INativeList<T> : IIndexable<T> // TypeDefIndex: 15852
{
	// Properties
	public abstract int Capacity { get; set; }
	public abstract bool IsEmpty { get; }
	public abstract T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Capacity();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INativeList<byte>.get_Capacity
	|-INativeList<__Il2CppFullySharedGenericStructType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Capacity(int value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INativeList<__Il2CppFullySharedGenericStructType>.set_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool get_IsEmpty();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INativeList<__Il2CppFullySharedGenericStructType>.get_IsEmpty
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract T get_Item(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INativeList<byte>.get_Item
	|-INativeList<__Il2CppFullySharedGenericStructType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void set_Item(int index, T value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INativeList<__Il2CppFullySharedGenericStructType>.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Clear();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-INativeList<__Il2CppFullySharedGenericStructType>.Clear
	*/
}
