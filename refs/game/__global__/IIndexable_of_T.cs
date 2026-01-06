public interface IIndexable<T> // TypeDefIndex: 15851
{
	// Properties
	public abstract int Length { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract int get_Length();
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IIndexable<byte>.get_Length
	|-IIndexable<long>.get_Length
	|-IIndexable<__Il2CppFullySharedGenericStructType>.get_Length
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void set_Length(int value);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IIndexable<byte>.set_Length
	|-IIndexable<__Il2CppFullySharedGenericStructType>.set_Length
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract ref T ElementAt(int index);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-IIndexable<long>.ElementAt
	|-IIndexable<__Il2CppFullySharedGenericStructType>.ElementAt
	*/
}
