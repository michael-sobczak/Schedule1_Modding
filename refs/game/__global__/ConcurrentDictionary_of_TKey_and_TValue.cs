public class ConcurrentDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 4949
{
	// Fields
	private ConcurrentDictionary.Tables<TKey, TValue> _tables; // 0x0
	private IEqualityComparer<TKey> _comparer; // 0x0
	private readonly bool _growLockArray; // 0x0
	private int _budget; // 0x0
	private KeyValuePair<TKey, TValue>[] _serializationArray; // 0x0
	private int _serializationConcurrencyLevel; // 0x0
	private int _serializationCapacity; // 0x0
	private static readonly bool s_isValueWriteAtomic; // 0x0

	// Properties
	public TValue Item { get; set; }
	public int Count { get; }
	public ICollection<TKey> Keys { get; }
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public ICollection<TValue> Values { get; }
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.IsReadOnly { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private static int DefaultConcurrencyLevel { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static bool IsValueWriteAtomic() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BDA20 Offset: 0x14BC420 VA: 0x1814BDA20
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.IsValueWriteAtomic
	|
	|-RVA: 0x14BDC40 Offset: 0x14BC640 VA: 0x1814BDC40
	|-ConcurrentDictionary<object, object>.IsValueWriteAtomic
	|
	|-RVA: 0x14BDB30 Offset: 0x14BC530 VA: 0x1814BDB30
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.IsValueWriteAtomic
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C8500 Offset: 0x14C6F00 VA: 0x1814C8500
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14C7C50 Offset: 0x14C6650 VA: 0x1814C7C50
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x14C8460 Offset: 0x14C6E60 VA: 0x1814C8460
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public void .ctor(IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C89A0 Offset: 0x14C73A0 VA: 0x1814C89A0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14C7DB0 Offset: 0x14C67B0 VA: 0x1814C7DB0
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x14C7D10 Offset: 0x14C6710 VA: 0x1814C7D10
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	private void InitializeFromCollection(IEnumerable<KeyValuePair<TKey, TValue>> collection) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BD6F0 Offset: 0x14BC0F0 VA: 0x1814BD6F0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.InitializeFromCollection
	|
	|-RVA: 0x14BCD90 Offset: 0x14BB790 VA: 0x1814BCD90
	|-ConcurrentDictionary<object, object>.InitializeFromCollection
	|
	|-RVA: 0x14BD0D0 Offset: 0x14BBAD0 VA: 0x1814BD0D0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InitializeFromCollection
	*/

	// RVA: -1 Offset: -1
	internal void .ctor(int concurrencyLevel, int capacity, bool growLockArray, IEqualityComparer<TKey> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C85C0 Offset: 0x14C6FC0 VA: 0x1814C85C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..ctor
	|
	|-RVA: 0x14C8170 Offset: 0x14C6B70 VA: 0x1814C8170
	|-ConcurrentDictionary<object, object>..ctor
	|
	|-RVA: 0x14C7E70 Offset: 0x14C6870 VA: 0x1814C7E70
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public bool TryAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C5420 Offset: 0x14C3E20 VA: 0x1814C5420
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAdd
	|
	|-RVA: 0x14C5570 Offset: 0x14C3F70 VA: 0x1814C5570
	|-ConcurrentDictionary<object, object>.TryAdd
	|
	|-RVA: 0x14C5670 Offset: 0x14C4070 VA: 0x1814C5670
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAdd
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B77E0 Offset: 0x14B61E0 VA: 0x1814B77E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ContainsKey
	|
	|-RVA: 0x14B79E0 Offset: 0x14B63E0 VA: 0x1814B79E0
	|-ConcurrentDictionary<object, object>.ContainsKey
	|
	|-RVA: 0x14B7820 Offset: 0x14B6220 VA: 0x1814B7820
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1
	public bool TryRemove(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C7630 Offset: 0x14C6030 VA: 0x1814C7630
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemove
	|
	|-RVA: 0x14C75B0 Offset: 0x14C5FB0 VA: 0x1814C75B0
	|-ConcurrentDictionary<object, object>.TryRemove
	|
	|-RVA: 0x14C7670 Offset: 0x14C6070 VA: 0x1814C7670
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemove
	*/

	// RVA: -1 Offset: -1
	private bool TryRemoveInternal(TKey key, out TValue value, bool matchValue, TValue oldValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C64F0 Offset: 0x14C4EF0 VA: 0x1814C64F0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryRemoveInternal
	|
	|-RVA: 0x14C7190 Offset: 0x14C5B90 VA: 0x1814C7190
	|-ConcurrentDictionary<object, object>.TryRemoveInternal
	|
	|-RVA: 0x14C6A10 Offset: 0x14C5410 VA: 0x1814C6A10
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryRemoveInternal
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C6070 Offset: 0x14C4A70 VA: 0x1814C6070
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValue
	|
	|-RVA: 0x14C63F0 Offset: 0x14C4DF0 VA: 0x1814C63F0
	|-ConcurrentDictionary<object, object>.TryGetValue
	|
	|-RVA: 0x14C61A0 Offset: 0x14C4BA0 VA: 0x1814C61A0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1
	private bool TryGetValueInternal(TKey key, int hashcode, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C59B0 Offset: 0x14C43B0 VA: 0x1814C59B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryGetValueInternal
	|
	|-RVA: 0x14C5B90 Offset: 0x14C4590 VA: 0x1814C5B90
	|-ConcurrentDictionary<object, object>.TryGetValueInternal
	|
	|-RVA: 0x14C5CE0 Offset: 0x14C46E0 VA: 0x1814C5CE0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValueInternal
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B7510 Offset: 0x14B5F10 VA: 0x1814B7510
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.Clear
	|
	|-RVA: 0x14B6F70 Offset: 0x14B5970 VA: 0x1814B6F70
	|-ConcurrentDictionary<object, object>.Clear
	|
	|-RVA: 0x14B7240 Offset: 0x14B5C40 VA: 0x1814B7240
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 17
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BECA0 Offset: 0x14BD6A0 VA: 0x1814BECA0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x14BEF50 Offset: 0x14BD950 VA: 0x1814BEF50
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	|
	|-RVA: 0x14BF200 Offset: 0x14BDC00 VA: 0x1814BF200
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.CopyTo
	*/

	// RVA: -1 Offset: -1
	public KeyValuePair<TKey, TValue>[] ToArray() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C3540 Offset: 0x14C1F40 VA: 0x1814C3540
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ToArray
	|
	|-RVA: 0x14C3250 Offset: 0x14C1C50 VA: 0x1814C3250
	|-ConcurrentDictionary<object, object>.ToArray
	|
	|-RVA: 0x14C3830 Offset: 0x14C2230 VA: 0x1814C3830
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ToArray
	*/

	// RVA: -1 Offset: -1
	private void CopyToPairs(KeyValuePair<TKey, TValue>[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B8AF0 Offset: 0x14B74F0 VA: 0x1814B8AF0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToPairs
	|
	|-RVA: 0x14B8C70 Offset: 0x14B7670 VA: 0x1814B8C70
	|-ConcurrentDictionary<object, object>.CopyToPairs
	|
	|-RVA: 0x14B8750 Offset: 0x14B7150 VA: 0x1814B8750
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToPairs
	*/

	// RVA: -1 Offset: -1
	private void CopyToEntries(DictionaryEntry[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B7AE0 Offset: 0x14B64E0 VA: 0x1814B7AE0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToEntries
	|
	|-RVA: 0x14B7C50 Offset: 0x14B6650 VA: 0x1814B7C50
	|-ConcurrentDictionary<object, object>.CopyToEntries
	|
	|-RVA: 0x14B7D70 Offset: 0x14B6770 VA: 0x1814B7D70
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToEntries
	*/

	// RVA: -1 Offset: -1
	private void CopyToObjects(object[] array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B8580 Offset: 0x14B6F80 VA: 0x1814B8580
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.CopyToObjects
	|
	|-RVA: 0x14B8010 Offset: 0x14B6A10 VA: 0x1814B8010
	|-ConcurrentDictionary<object, object>.CopyToObjects
	|
	|-RVA: 0x14B81C0 Offset: 0x14B6BC0 VA: 0x1814B81C0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyToObjects
	*/

	[IteratorStateMachine(typeof(ConcurrentDictionary.<GetEnumerator>d__35<TKey, TValue>))]
	// RVA: -1 Offset: -1 Slot: 19
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B8F20 Offset: 0x14B7920 VA: 0x1814B8F20
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetEnumerator
	|
	|-RVA: 0x14B8E90 Offset: 0x14B7890 VA: 0x1814B8E90
	|-ConcurrentDictionary<object, object>.GetEnumerator
	|
	|-RVA: 0x14B8FB0 Offset: 0x14B79B0 VA: 0x1814B8FB0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1
	private bool TryAddInternal(TKey key, int hashcode, TValue value, bool updateIfExists, bool acquireLock, out TValue resultingValue) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C4170 Offset: 0x14C2B70 VA: 0x1814C4170
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.TryAddInternal
	|
	|-RVA: 0x14C3AF0 Offset: 0x14C24F0 VA: 0x1814C3AF0
	|-ConcurrentDictionary<object, object>.TryAddInternal
	|
	|-RVA: 0x14C4880 Offset: 0x14C3280 VA: 0x1814C4880
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryAddInternal
	*/

	// RVA: -1 Offset: -1 Slot: 38
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C8E00 Offset: 0x14C7800 VA: 0x1814C8E00
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Item
	|
	|-RVA: 0x14C8ED0 Offset: 0x14C78D0 VA: 0x1814C8ED0
	|-ConcurrentDictionary<object, object>.get_Item
	|
	|-RVA: 0x14C9020 Offset: 0x14C7A20 VA: 0x1814C9020
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C9230 Offset: 0x14C7C30 VA: 0x1814C9230
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.set_Item
	|
	|-RVA: 0x14C9380 Offset: 0x14C7D80 VA: 0x1814C9380
	|-ConcurrentDictionary<object, object>.set_Item
	|
	|-RVA: 0x14C9480 Offset: 0x14C7E80 VA: 0x1814C9480
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNotFoundException(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C3180 Offset: 0x14C1B80 VA: 0x1814C3180
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<object, object>.ThrowKeyNotFoundException
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNotFoundException
	*/

	// RVA: -1 Offset: -1
	private static void ThrowKeyNullException() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C3200 Offset: 0x14C1C00 VA: 0x1814C3200
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ThrowKeyNullException
	|-ConcurrentDictionary<object, object>.ThrowKeyNullException
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ThrowKeyNullException
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C8B50 Offset: 0x14C7550 VA: 0x1814C8B50
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Count
	|
	|-RVA: 0x14C8A60 Offset: 0x14C7460 VA: 0x1814C8A60
	|-ConcurrentDictionary<object, object>.get_Count
	|
	|-RVA: 0x14C8C40 Offset: 0x14C7640 VA: 0x1814C8C40
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1
	private int GetCountInternal() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B8DE0 Offset: 0x14B77E0 VA: 0x1814B8DE0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetCountInternal
	|-ConcurrentDictionary<object, object>.GetCountInternal
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCountInternal
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, Func<TKey, TValue> valueFactory) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B9B40 Offset: 0x14B8540 VA: 0x1814B9B40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0x14BA7C0 Offset: 0x14B91C0 VA: 0x1814BA7C0
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0x14B9EC0 Offset: 0x14B88C0 VA: 0x1814B9EC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1
	public TValue GetOrAdd(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B9D30 Offset: 0x14B8730 VA: 0x1814B9D30
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetOrAdd
	|
	|-RVA: 0x14B9A00 Offset: 0x14B8400 VA: 0x1814B9A00
	|-ConcurrentDictionary<object, object>.GetOrAdd
	|
	|-RVA: 0x14BA390 Offset: 0x14B8D90 VA: 0x1814BA390
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetOrAdd
	*/

	// RVA: -1 Offset: -1 Slot: 9
	private void System.Collections.Generic.IDictionary<TKey,TValue>.Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF9C0 Offset: 0x14BE3C0 VA: 0x1814BF9C0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x14BFB60 Offset: 0x14BE560 VA: 0x1814BFB60
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	|
	|-RVA: 0x14BF800 Offset: 0x14BE200 VA: 0x1814BF800
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 10
	private bool System.Collections.Generic.IDictionary<TKey,TValue>.Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFEA0 Offset: 0x14BE8A0 VA: 0x1814BFEA0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x14BFCC0 Offset: 0x14BE6C0 VA: 0x1814BFCC0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	|
	|-RVA: 0x14BFD60 Offset: 0x14BE760 VA: 0x1814BFD60
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IDictionary<TKey,TValue>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFF40 Offset: 0x14BE940 VA: 0x1814BFF40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Keys
	|
	|-RVA: 0x14BFF00 Offset: 0x14BE900 VA: 0x1814BFF00
	|-ConcurrentDictionary<object, object>.get_Keys
	|
	|-RVA: 0x14BFF20 Offset: 0x14BE920 VA: 0x1814BFF20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 39
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFF40 Offset: 0x14BE940 VA: 0x1814BFF40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x14BFF00 Offset: 0x14BE900 VA: 0x1814BFF00
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	|
	|-RVA: 0x14BFF20 Offset: 0x14BE920 VA: 0x1814BFF20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFF60 Offset: 0x14BE960 VA: 0x1814BFF60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_Values
	|
	|-RVA: 0x14BFFA0 Offset: 0x14BE9A0 VA: 0x1814BFFA0
	|-ConcurrentDictionary<object, object>.get_Values
	|
	|-RVA: 0x14BFF80 Offset: 0x14BE980 VA: 0x1814BFF80
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 40
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFF60 Offset: 0x14BE960 VA: 0x1814BFF60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x14BFFA0 Offset: 0x14BE9A0 VA: 0x1814BFFA0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	|
	|-RVA: 0x14BFF80 Offset: 0x14BE980 VA: 0x1814BFF80
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 14
	private void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BE590 Offset: 0x14BCF90 VA: 0x1814BE590
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x14BE670 Offset: 0x14BD070 VA: 0x1814BE670
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	|
	|-RVA: 0x14BE6E0 Offset: 0x14BD0E0 VA: 0x1814BE6E0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 16
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BEC00 Offset: 0x14BD600 VA: 0x1814BEC00
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x14BEAB0 Offset: 0x14BD4B0 VA: 0x1814BEAB0
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	|
	|-RVA: 0x14BE870 Offset: 0x14BD270 VA: 0x1814BE870
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 13
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 18
	private bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BF4B0 Offset: 0x14BDEB0 VA: 0x1814BF4B0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x14BF500 Offset: 0x14BDF00 VA: 0x1814BF500
	|-ConcurrentDictionary<object, object>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	|
	|-RVA: 0x14BF5B0 Offset: 0x14BDFB0 VA: 0x1814BF5B0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<TKey,TValue>>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 20
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C3040 Offset: 0x14C1A40 VA: 0x1814C3040
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14C30E0 Offset: 0x14C1AE0 VA: 0x1814C30E0
	|-ConcurrentDictionary<object, object>.System.Collections.IEnumerable.GetEnumerator
	|
	|-RVA: 0x14C3020 Offset: 0x14C1A20 VA: 0x1814C3020
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 26
	private void System.Collections.IDictionary.Add(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1440 Offset: 0x14BFE40 VA: 0x1814C1440
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x14C16D0 Offset: 0x14C00D0 VA: 0x1814C16D0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Add
	|
	|-RVA: 0x14C1150 Offset: 0x14BFB50 VA: 0x1814C1150
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Add
	*/

	// RVA: -1 Offset: -1 Slot: 25
	private bool System.Collections.IDictionary.Contains(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1BF0 Offset: 0x14C05F0 VA: 0x1814C1BF0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x14C18F0 Offset: 0x14C02F0 VA: 0x1814C18F0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Contains
	|
	|-RVA: 0x14C1A70 Offset: 0x14C0470 VA: 0x1814C1A70
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 30
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1E20 Offset: 0x14C0820 VA: 0x1814C1E20
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x14C1DA0 Offset: 0x14C07A0 VA: 0x1814C1DA0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.GetEnumerator
	|
	|-RVA: 0x14C1D20 Offset: 0x14C0720 VA: 0x1814C1D20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 29
	private bool System.Collections.IDictionary.get_IsFixedSize() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsFixedSize
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsFixedSize
	*/

	// RVA: -1 Offset: -1 Slot: 28
	private bool System.Collections.IDictionary.get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_IsReadOnly
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_IsReadOnly
	*/

	// RVA: -1 Offset: -1 Slot: 23
	private ICollection System.Collections.IDictionary.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFF40 Offset: 0x14BE940 VA: 0x1814BFF40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x14BFF00 Offset: 0x14BE900 VA: 0x1814BFF00
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Keys
	|
	|-RVA: 0x14BFF20 Offset: 0x14BE920 VA: 0x1814BFF20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 31
	private void System.Collections.IDictionary.Remove(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1FD0 Offset: 0x14C09D0 VA: 0x1814C1FD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x14C1EA0 Offset: 0x14C08A0 VA: 0x1814C1EA0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.Remove
	|
	|-RVA: 0x14C2110 Offset: 0x14C0B10 VA: 0x1814C2110
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 24
	private ICollection System.Collections.IDictionary.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BFF60 Offset: 0x14BE960 VA: 0x1814BFF60
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x14BFFA0 Offset: 0x14BE9A0 VA: 0x1814BFFA0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Values
	|
	|-RVA: 0x14BFF80 Offset: 0x14BE980 VA: 0x1814BFF80
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 21
	private object System.Collections.IDictionary.get_Item(object key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C22D0 Offset: 0x14C0CD0 VA: 0x1814C22D0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x14C2600 Offset: 0x14C1000 VA: 0x1814C2600
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.get_Item
	|
	|-RVA: 0x14C23F0 Offset: 0x14C0DF0 VA: 0x1814C23F0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 22
	private void System.Collections.IDictionary.set_Item(object key, object value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C2780 Offset: 0x14C1180 VA: 0x1814C2780
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x14C2AC0 Offset: 0x14C14C0 VA: 0x1814C2AC0
	|-ConcurrentDictionary<object, object>.System.Collections.IDictionary.set_Item
	|
	|-RVA: 0x14C2D60 Offset: 0x14C1760 VA: 0x1814C2D60
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IDictionary.set_Item
	*/

	// RVA: -1 Offset: -1 Slot: 32
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C0440 Offset: 0x14BEE40 VA: 0x1814C0440
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14C0AE0 Offset: 0x14BF4E0 VA: 0x1814C0AE0
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.CopyTo
	|
	|-RVA: 0x14BFFC0 Offset: 0x14BE9C0 VA: 0x1814BFFC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 35
	private bool System.Collections.ICollection.get_IsSynchronized() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_IsSynchronized
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_IsSynchronized
	*/

	// RVA: -1 Offset: -1 Slot: 34
	private object System.Collections.ICollection.get_SyncRoot() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C1100 Offset: 0x14BFB00 VA: 0x1814C1100
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<object, object>.System.Collections.ICollection.get_SyncRoot
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.ICollection.get_SyncRoot
	*/

	// RVA: -1 Offset: -1
	private void GrowTable(ConcurrentDictionary.Tables<TKey, TValue> tables) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BB2E0 Offset: 0x14B9CE0 VA: 0x1814BB2E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GrowTable
	|
	|-RVA: 0x14BBB30 Offset: 0x14BA530 VA: 0x1814BBB30
	|-ConcurrentDictionary<object, object>.GrowTable
	|
	|-RVA: 0x14BC370 Offset: 0x14BAD70 VA: 0x1814BC370
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GrowTable
	*/

	// RVA: -1 Offset: -1
	private static int GetBucket(int hashcode, int bucketCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B8DD0 Offset: 0x14B77D0 VA: 0x1814B8DD0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucket
	|-ConcurrentDictionary<object, object>.GetBucket
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucket
	*/

	// RVA: -1 Offset: -1
	private static void GetBucketAndLockNo(int hashcode, out int bucketNo, out int lockNo, int bucketCount, int lockCount) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B8DB0 Offset: 0x14B77B0 VA: 0x1814B8DB0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetBucketAndLockNo
	|-ConcurrentDictionary<object, object>.GetBucketAndLockNo
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetBucketAndLockNo
	*/

	// RVA: -1 Offset: -1
	private static int get_DefaultConcurrencyLevel() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C8D40 Offset: 0x14C7740 VA: 0x1814C8D40
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0x14C8D80 Offset: 0x14C7780 VA: 0x1814C8D80
	|-ConcurrentDictionary<object, object>.get_DefaultConcurrencyLevel
	|
	|-RVA: 0x14C8DC0 Offset: 0x14C77C0 VA: 0x1814C8DC0
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_DefaultConcurrencyLevel
	*/

	// RVA: -1 Offset: -1
	private void AcquireAllLocks(ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B6B90 Offset: 0x14B5590 VA: 0x1814B6B90
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireAllLocks
	|
	|-RVA: 0x14B6D00 Offset: 0x14B5700 VA: 0x1814B6D00
	|-ConcurrentDictionary<object, object>.AcquireAllLocks
	|
	|-RVA: 0x14B6A20 Offset: 0x14B5420 VA: 0x1814B6A20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireAllLocks
	*/

	// RVA: -1 Offset: -1
	private void AcquireLocks(int fromInclusive, int toExclusive, ref int locksAcquired) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B6E70 Offset: 0x14B5870 VA: 0x1814B6E70
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.AcquireLocks
	|-ConcurrentDictionary<object, object>.AcquireLocks
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AcquireLocks
	*/

	// RVA: -1 Offset: -1
	private void ReleaseLocks(int fromInclusive, int toExclusive) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BE500 Offset: 0x14BCF00 VA: 0x1814BE500
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.ReleaseLocks
	|-ConcurrentDictionary<object, object>.ReleaseLocks
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ReleaseLocks
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TKey> GetKeys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14B9720 Offset: 0x14B8120 VA: 0x1814B9720
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetKeys
	|
	|-RVA: 0x14B9450 Offset: 0x14B7E50 VA: 0x1814B9450
	|-ConcurrentDictionary<object, object>.GetKeys
	|
	|-RVA: 0x14B9080 Offset: 0x14B7A80 VA: 0x1814B9080
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetKeys
	*/

	// RVA: -1 Offset: -1
	private ReadOnlyCollection<TValue> GetValues() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BB010 Offset: 0x14B9A10 VA: 0x1814BB010
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.GetValues
	|
	|-RVA: 0x14BA950 Offset: 0x14B9350 VA: 0x1814BA950
	|-ConcurrentDictionary<object, object>.GetValues
	|
	|-RVA: 0x14BAC20 Offset: 0x14B9620 VA: 0x1814BAC20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetValues
	*/

	[OnSerializing]
	// RVA: -1 Offset: -1
	private void OnSerializing(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BE3E0 Offset: 0x14BCDE0 VA: 0x1814BE3E0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerializing
	|
	|-RVA: 0x14BE350 Offset: 0x14BCD50 VA: 0x1814BE350
	|-ConcurrentDictionary<object, object>.OnSerializing
	|
	|-RVA: 0x14BE470 Offset: 0x14BCE70 VA: 0x1814BE470
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerializing
	*/

	[OnSerialized]
	// RVA: -1 Offset: -1
	private void OnSerialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xCF1FE0 Offset: 0xCF09E0 VA: 0x180CF1FE0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnSerialized
	|-ConcurrentDictionary<object, object>.OnSerialized
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnSerialized
	*/

	[OnDeserialized]
	// RVA: -1 Offset: -1
	private void OnDeserialized(StreamingContext context) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14BE150 Offset: 0x14BCB50 VA: 0x1814BE150
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>.OnDeserialized
	|
	|-RVA: 0x14BDD50 Offset: 0x14BC750 VA: 0x1814BDD50
	|-ConcurrentDictionary<object, object>.OnDeserialized
	|
	|-RVA: 0x14BDF50 Offset: 0x14BC950 VA: 0x1814BDF50
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnDeserialized
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14C7AE0 Offset: 0x14C64E0 VA: 0x1814C7AE0
	|-ConcurrentDictionary<StructMultiKey<object, object>, object>..cctor
	|
	|-RVA: 0x14C78B0 Offset: 0x14C62B0 VA: 0x1814C78B0
	|-ConcurrentDictionary<object, object>..cctor
	|
	|-RVA: 0x14C7A20 Offset: 0x14C6420 VA: 0x1814C7A20
	|-ConcurrentDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..cctor
	*/
}
