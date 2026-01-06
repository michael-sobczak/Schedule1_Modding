internal class SimplePool<T> // TypeDefIndex: 10445
{
	// Fields
	private readonly List<T> freeItemsBackfield; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(int preCreatedElementsCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C2840 Offset: 0x11C1240 VA: 0x1811C2840
	|-SimplePool<object>..ctor
	|
	|-RVA: 0x11C2990 Offset: 0x11C1390 VA: 0x1811C2990
	|-SimplePool<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public T GetItem() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C2630 Offset: 0x11C1030 VA: 0x1811C2630
	|-SimplePool<object>.GetItem
	|
	|-RVA: 0x11C2450 Offset: 0x11C0E50 VA: 0x1811C2450
	|-SimplePool<__Il2CppFullySharedGenericType>.GetItem
	*/

	// RVA: -1 Offset: -1
	public void ReleaseItem(T item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11C27C0 Offset: 0x11C11C0 VA: 0x1811C27C0
	|-SimplePool<object>.ReleaseItem
	|
	|-RVA: 0x11C26E0 Offset: 0x11C10E0 VA: 0x1811C26E0
	|-SimplePool<__Il2CppFullySharedGenericType>.ReleaseItem
	*/
}
