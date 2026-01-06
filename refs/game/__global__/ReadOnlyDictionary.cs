public sealed class ReadOnlyDictionary.ValueCollection<TKey, TValue> : ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IReadOnlyCollection<TValue> // TypeDefIndex: 4957
{
	// Fields
	private readonly ICollection<TValue> _collection; // 0x0
	private object _syncRoot; // 0x0

	// Properties
	public int Count { get; }
	private bool System.Collections.Generic.ICollection<TValue>.IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }

	// Methods

	// RVA: -1 Offset: -1
	internal void .ctor(ICollection<TValue> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13146B0 Offset: 0x13130B0 VA: 0x1813146B0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private void System.Collections.Generic.ICollection<TValue>.Add(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B3F0 Offset: 0x1199DF0 VA: 0x18119B3F0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private void System.Collections.Generic.ICollection<TValue>.Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B440 Offset: 0x1199E40 VA: 0x18119B440
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 8
	private bool System.Collections.Generic.ICollection<TValue>.Contains(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1306570 Offset: 0x1304F70 VA: 0x181306570
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public void CopyTo(TValue[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1305BA0 Offset: 0x13045A0 VA: 0x181305BA0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 17
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1314820 Offset: 0x1313220 VA: 0x181314820
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private bool System.Collections.Generic.ICollection<TValue>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.ICollection<TValue>.Remove(TValue item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x119B3F0 Offset: 0x1199DF0 VA: 0x18119B3F0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public IEnumerator<TValue> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1305F70 Offset: 0x1304970 VA: 0x181305F70
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1314660 Offset: 0x1313060 VA: 0x181314660
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x130F000 Offset: 0x130DA00 VA: 0x18130F000
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 15
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13137C0 Offset: 0x13121C0 VA: 0x1813137C0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	internal void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x13147B0 Offset: 0x13131B0 VA: 0x1813147B0
	|-ReadOnlyDictionary.ValueCollection<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/
}
