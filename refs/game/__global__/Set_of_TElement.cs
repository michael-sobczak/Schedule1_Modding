internal class Set<TElement> // TypeDefIndex: 15071
{
	// Fields
	private int[] buckets; // 0x0
	private Set.Slot<TElement>[] slots; // 0x0
	private int count; // 0x0
	private int freeList; // 0x0
	private IEqualityComparer<TElement> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TElement> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BE210 Offset: 0x11BCC10 VA: 0x1811BE210
	|-Set<char>..ctor
	|
	|-RVA: 0x11BE3F0 Offset: 0x11BCDF0 VA: 0x1811BE3F0
	|-Set<int>..ctor
	|
	|-RVA: 0x11BE5D0 Offset: 0x11BCFD0 VA: 0x1811BE5D0
	|-Set<object>..ctor
	|
	|-RVA: 0x11BE7B0 Offset: 0x11BD1B0 VA: 0x1811BE7B0
	|-Set<__Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool Add(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BC330 Offset: 0x11BAD30 VA: 0x1811BC330
	|-Set<char>.Add
	|
	|-RVA: 0x11BC300 Offset: 0x11BAD00 VA: 0x1811BC300
	|-Set<int>.Add
	|
	|-RVA: 0x11BC360 Offset: 0x11BAD60 VA: 0x1811BC360
	|-Set<object>.Add
	|
	|-RVA: 0x11BC390 Offset: 0x11BAD90 VA: 0x1811BC390
	|-Set<__Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private bool Find(TElement value, bool add) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BD2A0 Offset: 0x11BBCA0 VA: 0x1811BD2A0
	|-Set<char>.Find
	|
	|-RVA: 0x11BC910 Offset: 0x11BB310 VA: 0x1811BC910
	|-Set<int>.Find
	|
	|-RVA: 0x11BC490 Offset: 0x11BAE90 VA: 0x1811BC490
	|-Set<object>.Find
	|
	|-RVA: 0x11BCD60 Offset: 0x11BB760 VA: 0x1811BCD60
	|-Set<__Il2CppFullySharedGenericType>.Find
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BE090 Offset: 0x11BCA90 VA: 0x1811BE090
	|-Set<char>.Resize
	|
	|-RVA: 0x11BDF10 Offset: 0x11BC910 VA: 0x1811BDF10
	|-Set<int>.Resize
	|
	|-RVA: 0x11BDD90 Offset: 0x11BC790 VA: 0x1811BDD90
	|-Set<object>.Resize
	|
	|-RVA: 0x11BDB40 Offset: 0x11BC540 VA: 0x1811BDB40
	|-Set<__Il2CppFullySharedGenericType>.Resize
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TElement value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11BDA70 Offset: 0x11BC470 VA: 0x1811BDA70
	|-Set<char>.InternalGetHashCode
	|
	|-RVA: 0x11BD9A0 Offset: 0x11BC3A0 VA: 0x1811BD9A0
	|-Set<int>.InternalGetHashCode
	|
	|-RVA: 0x11BD8D0 Offset: 0x11BC2D0 VA: 0x1811BD8D0
	|-Set<object>.InternalGetHashCode
	|
	|-RVA: 0x11BD700 Offset: 0x11BC100 VA: 0x1811BD700
	|-Set<__Il2CppFullySharedGenericType>.InternalGetHashCode
	*/
}
