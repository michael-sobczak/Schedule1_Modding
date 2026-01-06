public class ArrayList : IList, ICollection, IEnumerable, ICloneable // TypeDefIndex: 4930
{
	// Fields
	private object[] _items; // 0x10
	private int _size; // 0x18
	private int _version; // 0x1C
	private object _syncRoot; // 0x20

	// Properties
	public virtual int Capacity { set; }
	public virtual int Count { get; }
	public virtual bool IsFixedSize { get; }
	public virtual bool IsReadOnly { get; }
	public virtual bool IsSynchronized { get; }
	public virtual object SyncRoot { get; }
	public virtual object Item { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor(bool trash) { }

	// RVA: 0x1BF3F30 Offset: 0x1BF2930 VA: 0x181BF3F30
	public void .ctor() { }

	// RVA: 0x1BF3F80 Offset: 0x1BF2980 VA: 0x181BF3F80
	public void .ctor(int capacity) { }

	// RVA: 0x1BF4080 Offset: 0x1BF2A80 VA: 0x181BF4080
	public void .ctor(ICollection c) { }

	// RVA: 0x1BF42F0 Offset: 0x1BF2CF0 VA: 0x181BF42F0 Slot: 21
	public virtual void set_Capacity(int value) { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90 Slot: 22
	public virtual int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 23
	public virtual bool get_IsFixedSize() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 24
	public virtual bool get_IsReadOnly() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 25
	public virtual bool get_IsSynchronized() { }

	// RVA: 0x1BF4280 Offset: 0x1BF2C80 VA: 0x181BF4280 Slot: 26
	public virtual object get_SyncRoot() { }

	// RVA: 0x1BF41D0 Offset: 0x1BF2BD0 VA: 0x181BF41D0 Slot: 27
	public virtual object get_Item(int index) { }

	// RVA: 0x1BF4420 Offset: 0x1BF2E20 VA: 0x181BF4420 Slot: 28
	public virtual void set_Item(int index, object value) { }

	// RVA: 0x1BF29F0 Offset: 0x1BF13F0 VA: 0x181BF29F0
	public static ArrayList Adapter(IList list) { }

	// RVA: 0x1BF2AC0 Offset: 0x1BF14C0 VA: 0x181BF2AC0 Slot: 29
	public virtual int Add(object value) { }

	// RVA: 0x1BF2AA0 Offset: 0x1BF14A0 VA: 0x181BF2AA0 Slot: 30
	public virtual void AddRange(ICollection c) { }

	// RVA: 0x1BF2BC0 Offset: 0x1BF15C0 VA: 0x181BF2BC0 Slot: 31
	public virtual int BinarySearch(int index, int count, object value, IComparer comparer) { }

	// RVA: 0x1BF2D00 Offset: 0x1BF1700 VA: 0x181BF2D00 Slot: 32
	public virtual int BinarySearch(object value) { }

	// RVA: 0x105A5F0 Offset: 0x1058FF0 VA: 0x18105A5F0 Slot: 33
	public virtual void Clear() { }

	// RVA: 0x1BF2D60 Offset: 0x1BF1760 VA: 0x181BF2D60 Slot: 34
	public virtual object Clone() { }

	// RVA: 0x1BF2ED0 Offset: 0x1BF18D0 VA: 0x181BF2ED0 Slot: 35
	public virtual bool Contains(object item) { }

	// RVA: 0x1BF31A0 Offset: 0x1BF1BA0 VA: 0x181BF31A0 Slot: 36
	public virtual void CopyTo(Array array) { }

	// RVA: 0x1BF30E0 Offset: 0x1BF1AE0 VA: 0x181BF30E0 Slot: 37
	public virtual void CopyTo(Array array, int arrayIndex) { }

	// RVA: 0x1BF2FB0 Offset: 0x1BF19B0 VA: 0x181BF2FB0 Slot: 38
	public virtual void CopyTo(int index, Array array, int arrayIndex, int count) { }

	// RVA: 0x1BF31C0 Offset: 0x1BF1BC0 VA: 0x181BF31C0
	private void EnsureCapacity(int min) { }

	// RVA: 0x1BF3220 Offset: 0x1BF1C20 VA: 0x181BF3220 Slot: 39
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x1BF3360 Offset: 0x1BF1D60 VA: 0x181BF3360 Slot: 40
	public virtual int IndexOf(object value) { }

	// RVA: 0x1BF3570 Offset: 0x1BF1F70 VA: 0x181BF3570 Slot: 41
	public virtual void Insert(int index, object value) { }

	// RVA: 0x1BF3390 Offset: 0x1BF1D90 VA: 0x181BF3390 Slot: 42
	public virtual void InsertRange(int index, ICollection c) { }

	// RVA: 0x1BF36D0 Offset: 0x1BF20D0 VA: 0x181BF36D0
	public static ArrayList ReadOnly(ArrayList list) { }

	// RVA: 0x1BF3A40 Offset: 0x1BF2440 VA: 0x181BF3A40 Slot: 43
	public virtual void Remove(object obj) { }

	// RVA: 0x1BF3780 Offset: 0x1BF2180 VA: 0x181BF3780 Slot: 44
	public virtual void RemoveAt(int index) { }

	// RVA: 0x1BF3860 Offset: 0x1BF2260 VA: 0x181BF3860 Slot: 45
	public virtual void RemoveRange(int index, int count) { }

	// RVA: 0x1BF3C40 Offset: 0x1BF2640 VA: 0x181BF3C40 Slot: 46
	public virtual void Sort() { }

	// RVA: 0x1BF3A90 Offset: 0x1BF2490 VA: 0x181BF3A90 Slot: 47
	public virtual void Sort(IComparer comparer) { }

	// RVA: 0x1BF3AF0 Offset: 0x1BF24F0 VA: 0x181BF3AF0 Slot: 48
	public virtual void Sort(int index, int count, IComparer comparer) { }

	// RVA: 0x1BF3CE0 Offset: 0x1BF26E0 VA: 0x181BF3CE0
	public static ArrayList Synchronized(ArrayList list) { }

	// RVA: 0x1BF3DC0 Offset: 0x1BF27C0 VA: 0x181BF3DC0 Slot: 49
	public virtual object[] ToArray() { }

	// RVA: 0x1BF3E50 Offset: 0x1BF2850 VA: 0x181BF3E50 Slot: 50
	public virtual Array ToArray(Type type) { }
}
