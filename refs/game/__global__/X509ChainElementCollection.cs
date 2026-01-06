public sealed class X509ChainElementCollection : ICollection, IEnumerable // TypeDefIndex: 9638
{
	// Fields
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public bool IsSynchronized { get; }
	public X509ChainElement Item { get; }
	public object SyncRoot { get; }

	// Methods

	// RVA: 0x2651210 Offset: 0x264FC10 VA: 0x182651210
	internal void .ctor() { }

	// RVA: 0x1BF73E0 Offset: 0x1BF5DE0 VA: 0x181BF73E0 Slot: 5
	public int get_Count() { }

	// RVA: 0x1BF6BC0 Offset: 0x1BF55C0 VA: 0x181BF6BC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x2651280 Offset: 0x264FC80 VA: 0x182651280
	public X509ChainElement get_Item(int index) { }

	// RVA: 0x1BF6BF0 Offset: 0x1BF55F0 VA: 0x181BF6BF0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x1BF6B90 Offset: 0x1BF5590 VA: 0x181BF6B90 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x26510D0 Offset: 0x264FAD0 VA: 0x1826510D0
	public X509ChainElementEnumerator GetEnumerator() { }

	// RVA: 0x2651170 Offset: 0x264FB70 VA: 0x182651170 Slot: 8
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2650EC0 Offset: 0x264F8C0 VA: 0x182650EC0
	internal void Add(X509Certificate2 certificate) { }

	// RVA: 0x20C7760 Offset: 0x20C6160 VA: 0x1820C7760
	internal void Clear() { }

	// RVA: 0x2650F90 Offset: 0x264F990 VA: 0x182650F90
	internal bool Contains(X509Certificate2 certificate) { }
}
