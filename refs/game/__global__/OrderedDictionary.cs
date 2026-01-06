public class OrderedDictionary : IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback // TypeDefIndex: 9857
{
	// Fields
	private ArrayList _objectsArray; // 0x10
	private Hashtable _objectsTable; // 0x18
	private int _initialCapacity; // 0x20
	private IEqualityComparer _comparer; // 0x28
	private bool _readOnly; // 0x30
	private object _syncRoot; // 0x38
	private SerializationInfo _siInfo; // 0x40

	// Properties
	public int Count { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	public bool IsReadOnly { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	public ICollection Keys { get; }
	private ArrayList objectsArray { get; }
	private Hashtable objectsTable { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	public object Item { get; set; }
	public ICollection Values { get; }

	// Methods

	// RVA: 0x26B3BB0 Offset: 0x26B25B0 VA: 0x1826B3BB0
	public void .ctor() { }

	// RVA: 0x26B3B70 Offset: 0x26B2570 VA: 0x1826B3B70
	public void .ctor(int capacity) { }

	// RVA: 0x26B3BE0 Offset: 0x26B25E0 VA: 0x1826B3BE0
	public void .ctor(int capacity, IEqualityComparer comparer) { }

	// RVA: 0x1821C20 Offset: 0x1820620 VA: 0x181821C20
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x26B3C20 Offset: 0x26B2620 VA: 0x1826B3C20 Slot: 16
	public int get_Count() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810 Slot: 12
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810 Slot: 11
	public bool get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 18
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x26B3CA0 Offset: 0x26B26A0 VA: 0x1826B3CA0 Slot: 6
	public ICollection get_Keys() { }

	// RVA: 0x26B3DA0 Offset: 0x26B27A0 VA: 0x1826B3DA0
	private ArrayList get_objectsArray() { }

	// RVA: 0x26B3E20 Offset: 0x26B2820 VA: 0x1826B3E20
	private Hashtable get_objectsTable() { }

	// RVA: 0x26B3A60 Offset: 0x26B2460 VA: 0x1826B3A60 Slot: 17
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x26B3C60 Offset: 0x26B2660 VA: 0x1826B3C60 Slot: 4
	public object get_Item(object key) { }

	// RVA: 0x26B3EB0 Offset: 0x26B28B0 VA: 0x1826B3EB0 Slot: 5
	public void set_Item(object key, object value) { }

	// RVA: 0x26B3D20 Offset: 0x26B2720 VA: 0x1826B3D20 Slot: 7
	public ICollection get_Values() { }

	// RVA: 0x26B2F10 Offset: 0x26B1910 VA: 0x1826B2F10 Slot: 9
	public void Add(object key, object value) { }

	// RVA: 0x26B3040 Offset: 0x26B1A40 VA: 0x1826B3040 Slot: 10
	public void Clear() { }

	// RVA: 0x26B30F0 Offset: 0x26B1AF0 VA: 0x1826B30F0 Slot: 8
	public bool Contains(object key) { }

	// RVA: 0x26B3130 Offset: 0x26B1B30 VA: 0x1826B3130 Slot: 15
	public void CopyTo(Array array, int index) { }

	// RVA: 0x26B3400 Offset: 0x26B1E00 VA: 0x1826B3400
	private int IndexOfKey(object key) { }

	// RVA: 0x26B3920 Offset: 0x26B2320 VA: 0x1826B3920 Slot: 14
	public void Remove(object key) { }

	// RVA: 0x26B3180 Offset: 0x26B1B80 VA: 0x1826B3180 Slot: 22
	public virtual IDictionaryEnumerator GetEnumerator() { }

	// RVA: 0x26B3AD0 Offset: 0x26B24D0 VA: 0x1826B3AD0 Slot: 19
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x26B3220 Offset: 0x26B1C20 VA: 0x1826B3220 Slot: 23
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xB1E150 Offset: 0xB1CB50 VA: 0x180B1E150 Slot: 21
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	// RVA: 0x26B3570 Offset: 0x26B1F70 VA: 0x1826B3570 Slot: 24
	protected virtual void OnDeserialization(object sender) { }
}
