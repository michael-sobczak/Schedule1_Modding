internal class IndexedSet<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable // TypeDefIndex: 16502
{
	// Fields
	private readonly List<T> m_List; // 0x0
	private Dictionary<T, int> m_Dictionary; // 0x0
	private int m_EnabledObjectCount; // 0x0

	// Properties
	public int Count { get; }
	public int Capacity { get; }
	public bool IsReadOnly { get; }
	public T Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 11
	public void Add(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1853DF0 Offset: 0x18527F0 VA: 0x181853DF0
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x1853CF0 Offset: 0x18526F0 VA: 0x181853CF0
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public void Add(T item, bool isActive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1853E10 Offset: 0x1852810 VA: 0x181853E10
	|-IndexedSet<object>.Add
	|
	|-RVA: 0x1853AA0 Offset: 0x18524A0 VA: 0x181853AA0
	|-IndexedSet<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	public bool AddUnique(T item, bool isActive = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1853980 Offset: 0x1852380 VA: 0x181853980
	|-IndexedSet<object>.AddUnique
	|
	|-RVA: 0x1853740 Offset: 0x1852140 VA: 0x181853740
	|-IndexedSet<__Il2CppFullySharedGenericType>.AddUnique
	*/

	// RVA: -1 Offset: -1
	public bool EnableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18544E0 Offset: 0x1852EE0 VA: 0x1818544E0
	|-IndexedSet<object>.EnableItem
	|
	|-RVA: 0x1854390 Offset: 0x1852D90 VA: 0x181854390
	|-IndexedSet<__Il2CppFullySharedGenericType>.EnableItem
	*/

	// RVA: -1 Offset: -1
	public bool DisableItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1854190 Offset: 0x1852B90 VA: 0x181854190
	|-IndexedSet<object>.DisableItem
	|
	|-RVA: 0x1854230 Offset: 0x1852C30 VA: 0x181854230
	|-IndexedSet<__Il2CppFullySharedGenericType>.DisableItem
	*/

	// RVA: -1 Offset: -1 Slot: 15
	public bool Remove(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1854F60 Offset: 0x1853960 VA: 0x181854F60
	|-IndexedSet<object>.Remove
	|
	|-RVA: 0x1854E20 Offset: 0x1853820 VA: 0x181854E20
	|-IndexedSet<__Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 16
	public IEnumerator<T> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10859A0 Offset: 0x10843A0 VA: 0x1810859A0
	|-IndexedSet<object>.GetEnumerator
	|-IndexedSet<__Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18558C0 Offset: 0x18542C0 VA: 0x1818558C0
	|-IndexedSet<object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0xFF41E0 Offset: 0xFF2BE0 VA: 0x180FF41E0
	|-IndexedSet<__Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 12
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1853F90 Offset: 0x1852990 VA: 0x181853F90
	|-IndexedSet<object>.Clear
	|
	|-RVA: 0x1853F20 Offset: 0x1852920 VA: 0x181853F20
	|-IndexedSet<__Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public bool Contains(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1854010 Offset: 0x1852A10 VA: 0x181854010
	|-IndexedSet<object>.Contains
	|
	|-RVA: 0x1854040 Offset: 0x1852A40 VA: 0x181854040
	|-IndexedSet<__Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 14
	public void CopyTo(T[] array, int arrayIndex) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1854130 Offset: 0x1852B30 VA: 0x181854130
	|-IndexedSet<object>.CopyTo
	|
	|-RVA: 0x1854160 Offset: 0x1852B60 VA: 0x181854160
	|-IndexedSet<__Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 9
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	|-IndexedSet<object>.get_Count
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	public int get_Capacity() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xC4AA50 Offset: 0xC49450 VA: 0x180C4AA50
	|-IndexedSet<object>.get_Capacity
	|
	|-RVA: 0x1855AB0 Offset: 0x18544B0 VA: 0x181855AB0
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Capacity
	*/

	// RVA: -1 Offset: -1 Slot: 10
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-IndexedSet<object>.get_IsReadOnly
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public int IndexOf(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1854680 Offset: 0x1853080 VA: 0x181854680
	|-IndexedSet<object>.IndexOf
	|
	|-RVA: 0x1854570 Offset: 0x1852F70 VA: 0x181854570
	|-IndexedSet<__Il2CppFullySharedGenericType>.IndexOf
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public void Insert(int index, T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18546D0 Offset: 0x18530D0 VA: 0x1818546D0
	|-IndexedSet<object>.Insert
	|-IndexedSet<__Il2CppFullySharedGenericType>.Insert
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void RemoveAt(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1854CD0 Offset: 0x18536D0 VA: 0x181854CD0
	|-IndexedSet<object>.RemoveAt
	|
	|-RVA: 0x1854A40 Offset: 0x1853440 VA: 0x181854A40
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAt
	*/

	// RVA: -1 Offset: -1
	private void Swap(int index1, int index2) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18552D0 Offset: 0x1853CD0 VA: 0x1818552D0
	|-IndexedSet<object>.Swap
	|
	|-RVA: 0x1855410 Offset: 0x1853E10 VA: 0x181855410
	|-IndexedSet<__Il2CppFullySharedGenericType>.Swap
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public T get_Item(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1855BF0 Offset: 0x18545F0 VA: 0x181855BF0
	|-IndexedSet<object>.get_Item
	|
	|-RVA: 0x1855AE0 Offset: 0x18544E0 VA: 0x181855AE0
	|-IndexedSet<__Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(int index, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1855C60 Offset: 0x1854660 VA: 0x181855C60
	|-IndexedSet<object>.set_Item
	|
	|-RVA: 0x1855D30 Offset: 0x1854730 VA: 0x181855D30
	|-IndexedSet<__Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void RemoveAll(Predicate<T> match) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1854720 Offset: 0x1853120 VA: 0x181854720
	|-IndexedSet<object>.RemoveAll
	|
	|-RVA: 0x18547F0 Offset: 0x18531F0 VA: 0x1818547F0
	|-IndexedSet<__Il2CppFullySharedGenericType>.RemoveAll
	*/

	// RVA: -1 Offset: -1
	public void Sort(Comparison<T> sortLayoutFunction) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1855210 Offset: 0x1853C10 VA: 0x181855210
	|-IndexedSet<object>.Sort
	|
	|-RVA: 0x1854FE0 Offset: 0x18539E0 VA: 0x181854FE0
	|-IndexedSet<__Il2CppFullySharedGenericType>.Sort
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x18559D0 Offset: 0x18543D0 VA: 0x1818559D0
	|-IndexedSet<object>..ctor
	|
	|-RVA: 0x18558F0 Offset: 0x18542F0 VA: 0x1818558F0
	|-IndexedSet<__Il2CppFullySharedGenericType>..ctor
	*/
}
