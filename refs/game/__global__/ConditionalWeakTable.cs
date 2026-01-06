private sealed class ConditionalWeakTable.Enumerator<TKey, TValue> : IEnumerator<KeyValuePair<TKey, TValue>>, IDisposable, IEnumerator // TypeDefIndex: 4646
{
	// Fields
	private ConditionalWeakTable<TKey, TValue> _table; // 0x0
	private int _currentIndex; // 0x0
	private KeyValuePair<TKey, TValue> _current; // 0x0

	// Properties
	public KeyValuePair<TKey, TValue> Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(ConditionalWeakTable<TKey, TValue> table) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1696E80 Offset: 0x1695880 VA: 0x181696E80
	|-ConditionalWeakTable.Enumerator<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1690890 Offset: 0x168F290 VA: 0x181690890
	|-ConditionalWeakTable.Enumerator<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void Dispose() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1690800 Offset: 0x168F200 VA: 0x181690800
	|-ConditionalWeakTable.Enumerator<object, object>.Dispose
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public bool MoveNext() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1690EF0 Offset: 0x168F8F0 VA: 0x181690EF0
	|-ConditionalWeakTable.Enumerator<object, object>.MoveNext
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public KeyValuePair<TKey, TValue> get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1697060 Offset: 0x1695A60 VA: 0x181697060
	|-ConditionalWeakTable.Enumerator<object, object>.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1694390 Offset: 0x1692D90 VA: 0x181694390
	|-ConditionalWeakTable.Enumerator<object, object>.System.Collections.IEnumerator.get_Current
	*/

	// RVA: -1 Offset: -1 Slot: 8
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	|-ConditionalWeakTable.Enumerator<object, object>.Reset
	*/
}
