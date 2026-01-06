public class PropertyDescriptorCollection : ICollection, IEnumerable, IList, IDictionary // TypeDefIndex: 9743
{
	// Fields
	public static readonly PropertyDescriptorCollection Empty; // 0x0
	private IDictionary _cachedFoundProperties; // 0x10
	private bool _cachedIgnoreCase; // 0x18
	private PropertyDescriptor[] _properties; // 0x20
	private readonly string[] _namedSort; // 0x28
	private readonly IComparer _comparer; // 0x30
	private bool _propsOwned; // 0x38
	private bool _needSort; // 0x39
	private bool _readOnly; // 0x3A
	private readonly object _internalSyncObject; // 0x40
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x48

	// Properties
	public int Count { get; set; }
	public virtual PropertyDescriptor Item { get; }
	public virtual PropertyDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private bool System.Collections.IDictionary.IsFixedSize { get; }
	private bool System.Collections.IDictionary.IsReadOnly { get; }
	private object System.Collections.IDictionary.Item { get; set; }
	private ICollection System.Collections.IDictionary.Keys { get; }
	private ICollection System.Collections.IDictionary.Values { get; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }
	private object System.Collections.IList.Item { get; set; }

	// Methods

	// RVA: 0x266EBC0 Offset: 0x266D5C0 VA: 0x18266EBC0
	public void .ctor(PropertyDescriptor[] properties) { }

	// RVA: 0x266EC90 Offset: 0x266D690 VA: 0x18266EC90
	public void .ctor(PropertyDescriptor[] properties, bool readOnly) { }

	// RVA: 0x266EA80 Offset: 0x266D480 VA: 0x18266EA80
	private void .ctor(PropertyDescriptor[] properties, int propCount, string[] namedSort, IComparer comparer) { }

	[CompilerGenerated]
	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	private void set_Count(int value) { }

	// RVA: 0x266ED70 Offset: 0x266D770 VA: 0x18266ED70 Slot: 31
	public virtual PropertyDescriptor get_Item(int index) { }

	// RVA: 0x266EDF0 Offset: 0x266D7F0 VA: 0x18266EDF0 Slot: 32
	public virtual PropertyDescriptor get_Item(string name) { }

	// RVA: 0x266C830 Offset: 0x266B230 VA: 0x18266C830
	public int Add(PropertyDescriptor value) { }

	// RVA: 0x266C920 Offset: 0x266B320 VA: 0x18266C920
	public void Clear() { }

	// RVA: 0x266C990 Offset: 0x266B390 VA: 0x18266C990
	public bool Contains(PropertyDescriptor value) { }

	// RVA: 0x266C9F0 Offset: 0x266B3F0 VA: 0x18266C9F0 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x266CA40 Offset: 0x266B440 VA: 0x18266CA40
	private void EnsurePropsOwned() { }

	// RVA: 0x266CAF0 Offset: 0x266B4F0 VA: 0x18266CAF0
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x266CC10 Offset: 0x266B610 VA: 0x18266CC10 Slot: 33
	public virtual PropertyDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x266D120 Offset: 0x266BB20 VA: 0x18266D120
	public int IndexOf(PropertyDescriptor value) { }

	// RVA: 0x266D180 Offset: 0x266BB80 VA: 0x18266D180
	public void Insert(int index, PropertyDescriptor value) { }

	// RVA: 0x266D790 Offset: 0x266C190 VA: 0x18266D790
	public void Remove(PropertyDescriptor value) { }

	// RVA: 0x266D6D0 Offset: 0x266C0D0 VA: 0x18266D6D0
	public void RemoveAt(int index) { }

	// RVA: 0x266D840 Offset: 0x266C240 VA: 0x18266D840 Slot: 34
	public virtual PropertyDescriptorCollection Sort(string[] names) { }

	// RVA: 0x266D310 Offset: 0x266BD10 VA: 0x18266D310
	protected void InternalSort(string[] names) { }

	// RVA: 0x266D290 Offset: 0x266BC90 VA: 0x18266D290
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x266D070 Offset: 0x266BA70 VA: 0x18266D070 Slot: 35
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x266C920 Offset: 0x266B320 VA: 0x18266C920 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x266C920 Offset: 0x266B320 VA: 0x18266C920 Slot: 26
	private void System.Collections.IDictionary.Clear() { }

	// RVA: 0x266E2C0 Offset: 0x266CCC0 VA: 0x18266E2C0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x266E630 Offset: 0x266D030 VA: 0x18266E630 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x266D9B0 Offset: 0x266C3B0 VA: 0x18266D9B0 Slot: 25
	private void System.Collections.IDictionary.Add(object key, object value) { }

	// RVA: 0x266DA70 Offset: 0x266C470 VA: 0x18266DA70 Slot: 24
	private bool System.Collections.IDictionary.Contains(object key) { }

	// RVA: 0x266DB10 Offset: 0x266C510 VA: 0x18266DB10 Slot: 29
	private IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator() { }

	// RVA: 0x1B24E10 Offset: 0x1B23810 VA: 0x181B24E10 Slot: 28
	private bool System.Collections.IDictionary.get_IsFixedSize() { }

	// RVA: 0x1B24E10 Offset: 0x1B23810 VA: 0x181B24E10 Slot: 27
	private bool System.Collections.IDictionary.get_IsReadOnly() { }

	// RVA: 0x266DC30 Offset: 0x266C630 VA: 0x18266DC30 Slot: 20
	private object System.Collections.IDictionary.get_Item(object key) { }

	// RVA: 0x266DE60 Offset: 0x266C860 VA: 0x18266DE60 Slot: 21
	private void System.Collections.IDictionary.set_Item(object key, object value) { }

	// RVA: 0x266DCC0 Offset: 0x266C6C0 VA: 0x18266DCC0 Slot: 22
	private ICollection System.Collections.IDictionary.get_Keys() { }

	// RVA: 0x266DD90 Offset: 0x266C790 VA: 0x18266DD90 Slot: 23
	private ICollection System.Collections.IDictionary.get_Values() { }

	// RVA: 0x266DB80 Offset: 0x266C580 VA: 0x18266DB80 Slot: 30
	private void System.Collections.IDictionary.Remove(object key) { }

	// RVA: 0x266E2E0 Offset: 0x266CCE0 VA: 0x18266E2E0 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x266E360 Offset: 0x266CD60 VA: 0x18266E360 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x266E410 Offset: 0x266CE10 VA: 0x18266E410 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x266E4C0 Offset: 0x266CEC0 VA: 0x18266E4C0 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x1B24E10 Offset: 0x1B23810 VA: 0x181B24E10 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x1B24E10 Offset: 0x1B23810 VA: 0x181B24E10 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x266E640 Offset: 0x266D040 VA: 0x18266E640 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x266E740 Offset: 0x266D140 VA: 0x18266E740 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x266E760 Offset: 0x266D160 VA: 0x18266E760 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x266E990 Offset: 0x266D390 VA: 0x18266E990
	private static void .cctor() { }
}
