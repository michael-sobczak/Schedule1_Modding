public class SyncIDictionary<TKey, TValue> : SyncBase, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>> // TypeDefIndex: 12629
{
	// Fields
	[CompilerGenerated]
	private SyncIDictionary.SyncDictionaryChanged<TKey, TValue> OnChange; // 0x0
	public readonly IDictionary<TKey, TValue> Collection; // 0x0
	public readonly IDictionary<TKey, TValue> ClientHostCollection; // 0x0
	private IDictionary<TKey, TValue> _initialValues; // 0x0
	private readonly List<SyncIDictionary.ChangeData<TKey, TValue>> _changed; // 0x0
	private readonly List<SyncIDictionary.CachedOnChange<TKey, TValue>> _serverOnChanges; // 0x0
	private readonly List<SyncIDictionary.CachedOnChange<TKey, TValue>> _clientOnChanges; // 0x0
	private bool _valuesChanged; // 0x0
	private bool _sendAll; // 0x0

	// Properties
	[APIExclude]
	public bool IsReadOnly { get; }
	public int Count { get; }
	public ICollection<TKey> Keys { get; }
	[APIExclude]
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Keys { get; }
	public ICollection<TValue> Values { get; }
	[APIExclude]
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.Values { get; }
	public TValue Item { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 31
	public bool get_IsReadOnly() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_IsReadOnly
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void add_OnChange(SyncIDictionary.SyncDictionaryChanged<TKey, TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3940 Offset: 0x11F2340 VA: 0x1811F3940
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.add_OnChange
	*/

	[CompilerGenerated]
	// RVA: -1 Offset: -1
	public void remove_OnChange(SyncIDictionary.SyncDictionaryChanged<TKey, TValue> value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3A60 Offset: 0x11F2460 VA: 0x1811F3A60
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.remove_OnChange
	*/

	// RVA: -1 Offset: -1 Slot: 44
	public int get_Count() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3A10 Offset: 0x11F2410 VA: 0x1811F3A10
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Count
	*/

	// RVA: -1 Offset: -1 Slot: 24
	public ICollection<TKey> get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F7720 Offset: 0x11F6120 VA: 0x1811F7720
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 42
	private IEnumerable<TKey> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F7720 Offset: 0x11F6120 VA: 0x1811F7720
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Keys
	*/

	// RVA: -1 Offset: -1 Slot: 25
	public ICollection<TValue> get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F7770 Offset: 0x11F6170 VA: 0x1811F7770
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Values
	*/

	// RVA: -1 Offset: -1 Slot: 43
	private IEnumerable<TValue> System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F7770 Offset: 0x11F6170 VA: 0x1811F7770
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.Generic.IReadOnlyDictionary<TKey,TValue>.get_Values
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	public void .ctor(IDictionary<TKey, TValue> objects) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F84B0 Offset: 0x11F6EB0 VA: 0x1811F84B0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>..ctor
	*/

	// RVA: -1 Offset: -1
	public Dictionary<TKey, TValue> GetCollection(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F5640 Offset: 0x11F4040 VA: 0x1811F5640
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetCollection
	*/

	// RVA: -1 Offset: -1 Slot: 12
	protected override void Registered() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F69E0 Offset: 0x11F53E0 VA: 0x1811F69E0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Registered
	*/

	[APIExclude]
	// RVA: -1 Offset: -1
	private void AddOperation(SyncDictionaryOperation operation, TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3B30 Offset: 0x11F2530 VA: 0x1811F3B30
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.AddOperation
	*/

	// RVA: -1 Offset: -1 Slot: 13
	public override void OnStartCallback(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F5CE0 Offset: 0x11F46E0 VA: 0x1811F5CE0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.OnStartCallback
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 15
	public override void WriteDelta(PooledWriter writer, bool resetSyncTick = True) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F78C0 Offset: 0x11F62C0 VA: 0x1811F78C0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WriteDelta
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 17
	public override void WriteFull(PooledWriter writer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F7F50 Offset: 0x11F6950 VA: 0x1811F7F50
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.WriteFull
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 19
	public override void Read(PooledReader reader, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F6230 Offset: 0x11F4C30 VA: 0x1811F6230
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Read
	*/

	// RVA: -1 Offset: -1
	private void InvokeOnChange(SyncDictionaryOperation operation, TKey key, TValue value, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F5750 Offset: 0x11F4150 VA: 0x1811F5750
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.InvokeOnChange
	*/

	[APIExclude]
	// RVA: -1 Offset: -1 Slot: 21
	public override void ResetState() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F7130 Offset: 0x11F5B30 VA: 0x1811F7130
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ResetState
	*/

	// RVA: -1 Offset: -1 Slot: 32
	public void Add(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F43A0 Offset: 0x11F2DA0 VA: 0x1811F43A0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 27
	public void Add(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F3F30 Offset: 0x11F2930 VA: 0x1811F3F30
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1
	private void Add(TKey key, TValue value, bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F40D0 Offset: 0x11F2AD0 VA: 0x1811F40D0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Add
	*/

	// RVA: -1 Offset: -1 Slot: 33
	public void Clear() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F4760 Offset: 0x11F3160 VA: 0x1811F4760
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1
	private void Clear(bool asServer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F4520 Offset: 0x11F2F20 VA: 0x1811F4520
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Clear
	*/

	// RVA: -1 Offset: -1 Slot: 39
	public bool ContainsKey(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F4780 Offset: 0x11F3180 VA: 0x1811F4780
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.ContainsKey
	*/

	// RVA: -1 Offset: -1 Slot: 34
	public bool Contains(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F4880 Offset: 0x11F3280 VA: 0x1811F4880
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Contains
	*/

	// RVA: -1 Offset: -1 Slot: 35
	public void CopyTo(KeyValuePair<TKey, TValue>[] array, int offset) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F4AD0 Offset: 0x11F34D0 VA: 0x1811F4AD0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.CopyTo
	*/

	// RVA: -1 Offset: -1 Slot: 28
	public bool Remove(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F6EC0 Offset: 0x11F58C0 VA: 0x1811F6EC0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 36
	public bool Remove(KeyValuePair<TKey, TValue> item) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F6DE0 Offset: 0x11F57E0 VA: 0x1811F6DE0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Remove
	*/

	// RVA: -1 Offset: -1 Slot: 40
	public bool TryGetValue(TKey key, out TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F77C0 Offset: 0x11F61C0 VA: 0x1811F77C0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.TryGetValue
	*/

	// RVA: -1 Offset: -1 Slot: 41
	public TValue get_Item(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F8A70 Offset: 0x11F7470 VA: 0x1811F8A70
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.get_Item
	*/

	// RVA: -1 Offset: -1 Slot: 23
	public void set_Item(TKey key, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F8C30 Offset: 0x11F7630 VA: 0x1811F8C30
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.set_Item
	*/

	// RVA: -1 Offset: -1
	public void DirtyAll() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F4EC0 Offset: 0x11F38C0 VA: 0x1811F4EC0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.DirtyAll
	*/

	// RVA: -1 Offset: -1
	public void Dirty(TKey key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F53C0 Offset: 0x11F3DC0 VA: 0x1811F53C0
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dirty
	*/

	// RVA: -1 Offset: -1
	public bool Dirty(TValue value, EqualityComparer<TValue> comparer) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F4F10 Offset: 0x11F3910 VA: 0x1811F4F10
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.Dirty
	*/

	// RVA: -1 Offset: -1 Slot: 37
	public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F5700 Offset: 0x11F4100 VA: 0x1811F5700
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.GetEnumerator
	*/

	// RVA: -1 Offset: -1 Slot: 38
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x11F5700 Offset: 0x11F4100 VA: 0x1811F5700
	|-SyncIDictionary<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>.System.Collections.IEnumerable.GetEnumerator
	*/
}
