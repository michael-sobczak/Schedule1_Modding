internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 15072
{
	// Fields
	private IEnumerable<TSource> source; // 0x0
	private Func<TSource, TKey> keySelector; // 0x0
	private Func<TSource, TElement> elementSelector; // 0x0
	private IEqualityComparer<TKey> comparer; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181B410 Offset: 0x1819E10 VA: 0x18181B410
	|-GroupedEnumerable<object, int, object>..ctor
	|-GroupedEnumerable<object, object, object>..ctor
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181B1F0 Offset: 0x1819BF0 VA: 0x18181B1F0
	|-GroupedEnumerable<object, int, object>.GetEnumerator
	|
	|-RVA: 0x181B2B0 Offset: 0x1819CB0 VA: 0x18181B2B0
	|-GroupedEnumerable<object, object, object>.GetEnumerator
	|
	|-RVA: 0x181B250 Offset: 0x1819C50 VA: 0x18181B250
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x181B3A0 Offset: 0x1819DA0 VA: 0x18181B3A0
	|-GroupedEnumerable<object, int, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x181B330 Offset: 0x1819D30 VA: 0x18181B330
	|-GroupedEnumerable<object, object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x181B310 Offset: 0x1819D10 VA: 0x18181B310
	|-GroupedEnumerable<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
