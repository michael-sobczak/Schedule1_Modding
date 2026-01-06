internal class MessageDictionary : IDictionary, ICollection, IEnumerable // TypeDefIndex: 4394
{
	// Fields
	private IDictionary _internalProperties; // 0x10
	protected IMethodMessage _message; // 0x18
	private string[] _methodKeys; // 0x20
	private bool _ownProperties; // 0x28

	// Properties
	internal IDictionary InternalDictionary { get; }
	public string[] MethodKeys { set; }
	public bool IsFixedSize { get; }
	public bool IsReadOnly { get; }
	public object Item { get; set; }
	public ICollection Keys { get; }
	public ICollection Values { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x7E2C80 Offset: 0x7E1680 VA: 0x1807E2C80
	public void .ctor(IMethodMessage message) { }

	// RVA: 0x1B33D70 Offset: 0x1B32770 VA: 0x181B33D70
	internal bool HasUserData() { }

	// RVA: 0x1B34430 Offset: 0x1B32E30 VA: 0x181B34430
	internal IDictionary get_InternalDictionary() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_MethodKeys(string[] value) { }

	// RVA: 0x1B336D0 Offset: 0x1B320D0 VA: 0x181B336D0 Slot: 20
	protected virtual IDictionary AllocInternalProperties() { }

	// RVA: 0x1B33960 Offset: 0x1B32360 VA: 0x181B33960
	public IDictionary GetInternalProperties() { }

	// RVA: 0x1B33E50 Offset: 0x1B32850 VA: 0x181B33E50
	private bool IsOverridenKey(string key) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	public bool get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x1B344E0 Offset: 0x1B32EE0 VA: 0x181B344E0 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x1B33570 Offset: 0x1B31F70 VA: 0x181B33570 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x1B339B0 Offset: 0x1B323B0 VA: 0x181B339B0 Slot: 21
	protected virtual object GetMethodProperty(string key) { }

	// RVA: 0x1B34030 Offset: 0x1B32A30 VA: 0x181B34030 Slot: 22
	protected virtual void SetMethodProperty(string key, object value) { }

	// RVA: 0x1B34610 Offset: 0x1B33010 VA: 0x181B34610 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x1B349F0 Offset: 0x1B333F0 VA: 0x181B349F0 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x1B33570 Offset: 0x1B31F70 VA: 0x181B33570 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x1B33720 Offset: 0x1B32120 VA: 0x181B33720 Slot: 10
	public void Clear() { }

	// RVA: 0x1B33770 Offset: 0x1B32170 VA: 0x181B33770 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x1B33ED0 Offset: 0x1B328D0 VA: 0x181B33ED0 Slot: 14
	public void Remove(object key) { }

	// RVA: 0x1B343C0 Offset: 0x1B32DC0 VA: 0x181B343C0 Slot: 16
	public int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x1B33880 Offset: 0x1B32280 VA: 0x181B33880 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x1B34360 Offset: 0x1B32D60 VA: 0x181B34360 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x1B33900 Offset: 0x1B32300 VA: 0x181B33900 Slot: 13
	public IDictionaryEnumerator GetEnumerator() { }
}
