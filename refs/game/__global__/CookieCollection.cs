public class CookieCollection : ICollection, IEnumerable // TypeDefIndex: 10023
{
	// Fields
	internal int m_version; // 0x10
	private ArrayList m_list; // 0x18
	private DateTime m_TimeStamp; // 0x20
	private bool m_has_other_versions; // 0x28
	[OptionalField]
	private bool m_IsReadOnly; // 0x29

	// Properties
	public Cookie Item { get; }
	public int Count { get; }
	public bool IsSynchronized { get; }
	public object SyncRoot { get; }
	internal bool IsOtherVersionSeen { get; }

	// Methods

	// RVA: 0x26B78B0 Offset: 0x26B62B0 VA: 0x1826B78B0
	public void .ctor() { }

	// RVA: 0x26B7960 Offset: 0x26B6360 VA: 0x1826B7960
	public Cookie get_Item(int index) { }

	// RVA: 0x26B6DE0 Offset: 0x26B57E0 VA: 0x1826B6DE0
	public void Add(Cookie cookie) { }

	// RVA: 0x26B6EB0 Offset: 0x26B58B0 VA: 0x1826B6EB0
	public void Add(CookieCollection cookies) { }

	// RVA: 0x1AD6CE0 Offset: 0x1AD56E0 VA: 0x181AD6CE0 Slot: 5
	public int get_Count() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x2306C80 Offset: 0x2305680 VA: 0x182306C80 Slot: 4
	public void CopyTo(Array array, int index) { }

	// RVA: 0x26B77B0 Offset: 0x26B61B0 VA: 0x1826B77B0
	internal DateTime TimeStamp(CookieCollection.Stamp how) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	internal bool get_IsOtherVersionSeen() { }

	// RVA: 0x26B7440 Offset: 0x26B5E40 VA: 0x1826B7440
	internal int InternalAdd(Cookie cookie, bool isStrict) { }

	// RVA: 0x26B7220 Offset: 0x26B5C20 VA: 0x1826B7220
	internal int IndexOf(Cookie cookie) { }

	// RVA: 0x26B7780 Offset: 0x26B6180 VA: 0x1826B7780
	internal void RemoveAt(int idx) { }

	// RVA: 0x26B71C0 Offset: 0x26B5BC0 VA: 0x1826B71C0 Slot: 8
	public IEnumerator GetEnumerator() { }
}
