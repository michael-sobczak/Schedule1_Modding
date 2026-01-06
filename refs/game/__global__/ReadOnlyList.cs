internal sealed class ReadOnlyList : IList, ICollection, IEnumerable // TypeDefIndex: 9865
{
	// Fields
	private readonly IList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsReadOnly { get; }
	public bool IsFixedSize { get; }
	public bool IsSynchronized { get; }
	public object Item { get; set; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(IList list) { }

	// RVA: 0x26B45F0 Offset: 0x26B2FF0 VA: 0x1826B45F0 Slot: 16
	public int get_Count() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 9
	public bool get_IsReadOnly() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 10
	public bool get_IsFixedSize() { }

	// RVA: 0x26B4640 Offset: 0x26B3040 VA: 0x1826B4640 Slot: 18
	public bool get_IsSynchronized() { }

	// RVA: 0x26B4690 Offset: 0x26B3090 VA: 0x1826B4690 Slot: 4
	public object get_Item(int index) { }

	// RVA: 0x26B4790 Offset: 0x26B3190 VA: 0x1826B4790 Slot: 5
	public void set_Item(int index, object value) { }

	// RVA: 0x26B4740 Offset: 0x26B3140 VA: 0x1826B4740 Slot: 17
	public object get_SyncRoot() { }

	// RVA: 0x26B4270 Offset: 0x26B2C70 VA: 0x1826B4270 Slot: 6
	public int Add(object value) { }

	// RVA: 0x26B42C0 Offset: 0x26B2CC0 VA: 0x1826B42C0 Slot: 8
	public void Clear() { }

	// RVA: 0x26B4310 Offset: 0x26B2D10 VA: 0x1826B4310 Slot: 7
	public bool Contains(object value) { }

	// RVA: 0x26B43E0 Offset: 0x26B2DE0 VA: 0x1826B43E0 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x26B4450 Offset: 0x26B2E50 VA: 0x1826B4450 Slot: 19
	public IEnumerator GetEnumerator() { }

	// RVA: 0x26B44A0 Offset: 0x26B2EA0 VA: 0x1826B44A0 Slot: 11
	public int IndexOf(object value) { }

	// RVA: 0x26B4500 Offset: 0x26B2F00 VA: 0x1826B4500 Slot: 12
	public void Insert(int index, object value) { }

	// RVA: 0x26B45A0 Offset: 0x26B2FA0 VA: 0x1826B45A0 Slot: 13
	public void Remove(object value) { }

	// RVA: 0x26B4550 Offset: 0x26B2F50 VA: 0x1826B4550 Slot: 14
	public void RemoveAt(int index) { }
}
