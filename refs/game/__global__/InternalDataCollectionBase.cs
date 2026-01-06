public class InternalDataCollectionBase : ICollection, IEnumerable // TypeDefIndex: 12876
{
	// Fields
	internal static readonly CollectionChangeEventArgs s_refreshEventArgs; // 0x0

	// Properties
	[Browsable(False)]
	public virtual int Count { get; }
	[Browsable(False)]
	public bool IsSynchronized { get; }
	[Browsable(False)]
	public object SyncRoot { get; }
	protected virtual ArrayList List { get; }

	// Methods

	// RVA: 0x207E3E0 Offset: 0x207CDE0 VA: 0x18207E3E0 Slot: 9
	public virtual int get_Count() { }

	// RVA: 0x207E1C0 Offset: 0x207CBC0 VA: 0x18207E1C0 Slot: 10
	public virtual void CopyTo(Array ar, int index) { }

	// RVA: 0x207E220 Offset: 0x207CC20 VA: 0x18207E220 Slot: 11
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_IsSynchronized() { }

	// RVA: 0x207E260 Offset: 0x207CC60 VA: 0x18207E260
	internal int NamesEqual(string s1, string s2, bool fCaseSensitive, CultureInfo locale) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	protected virtual ArrayList get_List() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x207E360 Offset: 0x207CD60 VA: 0x18207E360
	private static void .cctor() { }
}
