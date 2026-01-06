public class Lookup<TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable // TypeDefIndex: 15069
{
	// Fields
	private IEqualityComparer<TKey> comparer; // 0x0
	private Lookup.Grouping<TKey, TElement>[] groupings; // 0x0
	private Lookup.Grouping<TKey, TElement> lastGrouping; // 0x0
	private int count; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	internal static Lookup<TKey, TElement> Create<TSource>(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xDC87D0 Offset: 0xDC71D0 VA: 0x180DC87D0
	|-Lookup<int, object>.Create<object>
	|
	|-RVA: 0xDC84C0 Offset: 0xDC6EC0 VA: 0x180DC84C0
	|-Lookup<object, object>.Create<object>
	|
	|-RVA: 0xDC7E50 Offset: 0xDC6850 VA: 0x180DC7E50
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Create<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	private void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1057FF0 Offset: 0x10569F0 VA: 0x181057FF0
	|-Lookup<int, object>..ctor
	|
	|-RVA: 0x1058220 Offset: 0x1056C20 VA: 0x181058220
	|-Lookup<object, object>..ctor
	|
	|-RVA: 0x1058180 Offset: 0x1056B80 VA: 0x181058180
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[IteratorStateMachine(typeof(Lookup.<GetEnumerator>d__12<TKey, TElement>))]
	// RVA: -1 Offset: -1 Slot: 4
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x10568F0 Offset: 0x10552F0 VA: 0x1810568F0
	|-Lookup<int, object>.GetEnumerator
	|-Lookup<object, object>.GetEnumerator
	|
	|-RVA: 0x1056980 Offset: 0x1055380 VA: 0x181056980
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1057F50 Offset: 0x1056950 VA: 0x181057F50
	|-Lookup<int, object>.System.Collections.IEnumerable.GetEnumerator
	|-Lookup<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x1057F30 Offset: 0x1056930 VA: 0x181057F30
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	internal int InternalGetHashCode(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1057970 Offset: 0x1056370 VA: 0x181057970
	|-Lookup<int, object>.InternalGetHashCode
	|
	|-RVA: 0x10579D0 Offset: 0x10563D0 VA: 0x1810579D0
	|-Lookup<object, object>.InternalGetHashCode
	|
	|-RVA: 0x1057820 Offset: 0x1056220 VA: 0x181057820
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InternalGetHashCode
	*/

	// RVA: -1 Offset: -1
	internal Lookup.Grouping<TKey, TElement> GetGrouping(TKey key, bool create) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1057420 Offset: 0x1055E20 VA: 0x181057420
	|-Lookup<int, object>.GetGrouping
	|
	|-RVA: 0x1056FA0 Offset: 0x10559A0 VA: 0x181056FA0
	|-Lookup<object, object>.GetGrouping
	|
	|-RVA: 0x1056A10 Offset: 0x1055410 VA: 0x181056A10
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetGrouping
	*/

	// RVA: -1 Offset: -1
	private void Resize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1057C90 Offset: 0x1056690 VA: 0x181057C90
	|-Lookup<int, object>.Resize
	|
	|-RVA: 0x1057DE0 Offset: 0x10567E0 VA: 0x181057DE0
	|-Lookup<object, object>.Resize
	|
	|-RVA: 0x1057AA0 Offset: 0x10564A0 VA: 0x181057AA0
	|-Lookup<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Resize
	*/
}
