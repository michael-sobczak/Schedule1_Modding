public class EventDescriptorCollection : ICollection, IEnumerable, IList // TypeDefIndex: 9715
{
	// Fields
	private EventDescriptor[] _events; // 0x10
	private string[] _namedSort; // 0x18
	private readonly IComparer _comparer; // 0x20
	private bool _eventsOwned; // 0x28
	private bool _needSort; // 0x29
	private readonly bool _readOnly; // 0x2A
	public static readonly EventDescriptorCollection Empty; // 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; // 0x2C

	// Properties
	public int Count { get; set; }
	public virtual EventDescriptor Item { get; }
	public virtual EventDescriptor Item { get; }
	private bool System.Collections.ICollection.IsSynchronized { get; }
	private object System.Collections.ICollection.SyncRoot { get; }
	private int System.Collections.ICollection.Count { get; }
	private object System.Collections.IList.Item { get; set; }
	private bool System.Collections.IList.IsReadOnly { get; }
	private bool System.Collections.IList.IsFixedSize { get; }

	// Methods

	// RVA: 0x2667E30 Offset: 0x2666830 VA: 0x182667E30
	public void .ctor(EventDescriptor[] events) { }

	// RVA: 0x2667EC0 Offset: 0x26668C0 VA: 0x182667EC0
	public void .ctor(EventDescriptor[] events, bool readOnly) { }

	[CompilerGenerated]
	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public int get_Count() { }

	[CompilerGenerated]
	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	private void set_Count(int value) { }

	// RVA: 0x2667F80 Offset: 0x2666980 VA: 0x182667F80 Slot: 20
	public virtual EventDescriptor get_Item(int index) { }

	// RVA: 0x2667F60 Offset: 0x2666960 VA: 0x182667F60 Slot: 21
	public virtual EventDescriptor get_Item(string name) { }

	// RVA: 0x2666910 Offset: 0x2665310 VA: 0x182666910
	public int Add(EventDescriptor value) { }

	// RVA: 0x2666A00 Offset: 0x2665400 VA: 0x182666A00
	public void Clear() { }

	// RVA: 0x2666A60 Offset: 0x2665460 VA: 0x182666A60
	public bool Contains(EventDescriptor value) { }

	// RVA: 0x26675A0 Offset: 0x2665FA0 VA: 0x1826675A0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x2666AC0 Offset: 0x26654C0 VA: 0x182666AC0
	private void EnsureEventsOwned() { }

	// RVA: 0x2666B70 Offset: 0x2665570 VA: 0x182666B70
	private void EnsureSize(int sizeNeeded) { }

	// RVA: 0x2666C90 Offset: 0x2665690 VA: 0x182666C90 Slot: 22
	public virtual EventDescriptor Find(string name, bool ignoreCase) { }

	// RVA: 0x2666E80 Offset: 0x2665880 VA: 0x182666E80
	public int IndexOf(EventDescriptor value) { }

	// RVA: 0x2666EE0 Offset: 0x26658E0 VA: 0x182666EE0
	public void Insert(int index, EventDescriptor value) { }

	// RVA: 0x26674F0 Offset: 0x2665EF0 VA: 0x1826674F0
	public void Remove(EventDescriptor value) { }

	// RVA: 0x2667430 Offset: 0x2665E30 VA: 0x182667430
	public void RemoveAt(int index) { }

	// RVA: 0x2666DD0 Offset: 0x26657D0 VA: 0x182666DD0
	public IEnumerator GetEnumerator() { }

	// RVA: 0x2667070 Offset: 0x2665A70 VA: 0x182667070
	protected void InternalSort(string[] names) { }

	// RVA: 0x2666FF0 Offset: 0x26659F0 VA: 0x182666FF0
	protected void InternalSort(IComparer sorter) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	private bool System.Collections.ICollection.get_IsSynchronized() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	private object System.Collections.ICollection.get_SyncRoot() { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590 Slot: 5
	private int System.Collections.ICollection.get_Count() { }

	// RVA: 0x26675F0 Offset: 0x2665FF0 VA: 0x1826675F0 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0xD53E50 Offset: 0xD52850 VA: 0x180D53E50 Slot: 9
	private object System.Collections.IList.get_Item(int index) { }

	// RVA: 0x2667BD0 Offset: 0x26665D0 VA: 0x182667BD0 Slot: 10
	private void System.Collections.IList.set_Item(int index, object value) { }

	// RVA: 0x26676A0 Offset: 0x26660A0 VA: 0x1826676A0 Slot: 11
	private int System.Collections.IList.Add(object value) { }

	// RVA: 0x26677F0 Offset: 0x26661F0 VA: 0x1826677F0 Slot: 12
	private bool System.Collections.IList.Contains(object value) { }

	// RVA: 0x2666A00 Offset: 0x2665400 VA: 0x182666A00 Slot: 13
	private void System.Collections.IList.Clear() { }

	// RVA: 0x26678A0 Offset: 0x26662A0 VA: 0x1826678A0 Slot: 16
	private int System.Collections.IList.IndexOf(object value) { }

	// RVA: 0x2667950 Offset: 0x2666350 VA: 0x182667950 Slot: 17
	private void System.Collections.IList.Insert(int index, object value) { }

	// RVA: 0x2667AD0 Offset: 0x26664D0 VA: 0x182667AD0 Slot: 18
	private void System.Collections.IList.Remove(object value) { }

	// RVA: 0x2667AC0 Offset: 0x26664C0 VA: 0x182667AC0 Slot: 19
	private void System.Collections.IList.RemoveAt(int index) { }

	// RVA: 0x844440 Offset: 0x842E40 VA: 0x180844440 Slot: 14
	private bool System.Collections.IList.get_IsReadOnly() { }

	// RVA: 0x844440 Offset: 0x842E40 VA: 0x180844440 Slot: 15
	private bool System.Collections.IList.get_IsFixedSize() { }

	// RVA: 0x2667D80 Offset: 0x2666780 VA: 0x182667D80
	private static void .cctor() { }
}
