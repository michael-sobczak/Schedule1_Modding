private sealed class ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 4948
{
	// Fields
	private int <>1__state; // 0x0
	private KeyValuePair<TKey, TValue> <>2__current; // 0x0
	public ConcurrentDictionary<TKey, TValue> <>4__this; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue>[] <buckets>5__2; // 0x0
	private int <i>5__3; // 0x0
	private ConcurrentDictionary.Node<TKey, TValue> <current>5__4; // 0x0

	// Properties
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHidden]
	// RVA: -1 Offset: -1
	public void .ctor(int <>1__state) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x445F80 Offset: 0x444980 VA: 0x180445F80
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>..ctor
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>..ctor
	|
	|-RVA: 0xFD0750 Offset: 0xFCF150 VA: 0x180FD0750
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 5
	private void System.IDisposable.Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.IDisposable.Dispose
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.IDisposable.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	private bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE7A10 Offset: 0xFE6410 VA: 0x180FE7A10
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.MoveNext
	|
	|-RVA: 0xFE78B0 Offset: 0xFE62B0 VA: 0x180FE78B0
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.MoveNext
	|
	|-RVA: 0xFE7200 Offset: 0xFE5C00 VA: 0x180FE7200
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.MoveNext
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 4
	private KeyValuePair<TKey, TValue> System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x49D250 Offset: 0x49BC50 VA: 0x18049D250
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0x526100 Offset: 0x524B00 VA: 0x180526100
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	|
	|-RVA: 0xFE7B90 Offset: 0xFE6590 VA: 0x180FE7B90
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_Current
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFC9ED0 Offset: 0xFC88D0 VA: 0x180FC9ED0
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.IEnumerator.Reset
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.Reset
	*/

	[DebuggerHidden]
	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE7D20 Offset: 0xFE6720 VA: 0x180FE7D20
	|-ConcurrentDictionary.<GetEnumerator>d__35<StructMultiKey<object, object>, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFE7C40 Offset: 0xFE6640 VA: 0x180FE7C40
	|-ConcurrentDictionary.<GetEnumerator>d__35<object, object>.System.Collections.IEnumerator.get_Current
	|
	|-RVA: 0xFE7C70 Offset: 0xFE6670 VA: 0x180FE7C70
	|-ConcurrentDictionary.<GetEnumerator>d__35<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerator.get_Current
	*/
}
