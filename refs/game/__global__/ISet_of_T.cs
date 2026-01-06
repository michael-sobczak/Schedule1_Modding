public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 9910
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Add(T item);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool IsSubsetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool IsSupersetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool IsProperSupersetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsProperSupersetOf
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool IsProperSubsetOf(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.IsProperSubsetOf
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Overlaps(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.Overlaps
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool SetEquals(IEnumerable<T> other);
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-ISet<__Il2CppFullySharedGenericType>.SetEquals
	*/
}
