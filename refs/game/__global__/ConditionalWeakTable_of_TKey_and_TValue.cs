public sealed class ConditionalWeakTable<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable // TypeDefIndex: 4647
{
	// Fields
	private const int INITIAL_SIZE = 13;
	private const float LOAD_FACTOR = 0.7;
	private const float COMPACT_FACTOR = 0.5;
	private const float EXPAND_FACTOR = 1.1;
	private Ephemeron[] data; // 0x0
	private object _lock; // 0x0
	private int size; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D89C0 Offset: 0x14D73C0 VA: 0x1814D89C0
	|-ConditionalWeakTable<object, object>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 1
	protected override void Finalize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D7A30 Offset: 0x14D6430 VA: 0x1814D7A30
	|-ConditionalWeakTable<object, object>.Finalize
	*/

	// RVA: -1 Offset: -1
	private void RehashWithoutResize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D7C70 Offset: 0x14D6670 VA: 0x1814D7C70
	|-ConditionalWeakTable<object, object>.RehashWithoutResize
	*/

	// RVA: -1 Offset: -1
	private void RecomputeSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D7C00 Offset: 0x14D6600 VA: 0x1814D7C00
	|-ConditionalWeakTable<object, object>.RecomputeSize
	*/

	// RVA: -1 Offset: -1
	private void Rehash() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D7F40 Offset: 0x14D6940 VA: 0x1814D7F40
	|-ConditionalWeakTable<object, object>.Rehash
	*/

	// RVA: -1 Offset: -1
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D76E0 Offset: 0x14D60E0 VA: 0x1814D76E0
	|-ConditionalWeakTable<object, object>.Add
	*/

	// RVA: -1 Offset: -1
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D82E0 Offset: 0x14D6CE0 VA: 0x1814D82E0
	|-ConditionalWeakTable<object, object>.Remove
	*/

	// RVA: -1 Offset: -1
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D8720 Offset: 0x14D7120 VA: 0x1814D8720
	|-ConditionalWeakTable<object, object>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	public TValue GetValue(TKey key, ConditionalWeakTable.CreateValueCallback<TKey, TValue> createValueCallback) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D7A80 Offset: 0x14D6480 VA: 0x1814D7A80
	|-ConditionalWeakTable<object, object>.GetValue
	*/

	// RVA: -1 Offset: -1 Slot: 4
	private IEnumerator<KeyValuePair<TKey, TValue>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14D8590 Offset: 0x14D6F90 VA: 0x1814D8590
	|-ConditionalWeakTable<object, object>.System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<TKey,TValue>>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1294BE0 Offset: 0x12935E0 VA: 0x181294BE0
	|-ConditionalWeakTable<object, object>.System.Collections.IEnumerable.GetEnumerator
	*/
}
