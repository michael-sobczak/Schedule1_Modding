internal class JPropertyKeyedCollection : Collection<JToken> // TypeDefIndex: 11339
{
	// Fields
	private static readonly IEqualityComparer<string> Comparer; // 0x0
	[Nullable(new[] { 2, 1, 1 })]
	private Dictionary<string, JToken> _dictionary; // 0x18

	// Properties
	public JToken Item { get; }
	public ICollection<string> Keys { get; }
	public ICollection<JToken> Values { get; }

	// Methods

	// RVA: 0x1DBD460 Offset: 0x1DBBE60 VA: 0x181DBD460
	public void .ctor() { }

	// RVA: 0x1DBC340 Offset: 0x1DBAD40 VA: 0x181DBC340
	private void AddKey(string key, JToken item) { }

	// RVA: 0x1DBC3B0 Offset: 0x1DBADB0 VA: 0x181DBC3B0
	protected void ChangeItemKey(JToken item, string newKey) { }

	// RVA: 0x1DBC5F0 Offset: 0x1DBAFF0 VA: 0x181DBC5F0 Slot: 35
	protected override void ClearItems() { }

	// RVA: 0x1DBCAB0 Offset: 0x1DBB4B0 VA: 0x181DBCAB0
	public bool Contains(string key) { }

	// RVA: 0x1DBC9E0 Offset: 0x1DBB3E0 VA: 0x181DBC9E0
	private bool ContainsItem(JToken item) { }

	// RVA: 0x1DBCB60 Offset: 0x1DBB560 VA: 0x181DBCB60
	private void EnsureDictionary() { }

	// RVA: 0x1DBCC20 Offset: 0x1DBB620 VA: 0x181DBCC20
	private string GetKeyForItem(JToken item) { }

	// RVA: 0x1DBCD30 Offset: 0x1DBB730 VA: 0x181DBCD30 Slot: 36
	protected override void InsertItem(int index, JToken item) { }

	// RVA: 0x1DBCFB0 Offset: 0x1DBB9B0 VA: 0x181DBCFB0
	public bool Remove(string key) { }

	// RVA: 0x1DBCE40 Offset: 0x1DBB840 VA: 0x181DBCE40 Slot: 37
	protected override void RemoveItem(int index) { }

	// RVA: 0x1DBCF60 Offset: 0x1DBB960 VA: 0x181DBCF60
	private void RemoveKey(string key) { }

	// RVA: 0x1DBD090 Offset: 0x1DBBA90 VA: 0x181DBD090 Slot: 38
	protected override void SetItem(int index, JToken item) { }

	// RVA: 0x1DBD4E0 Offset: 0x1DBBEE0 VA: 0x181DBD4E0
	public JToken get_Item(string key) { }

	// RVA: 0x1DBD320 Offset: 0x1DBBD20 VA: 0x181DBD320
	public bool TryGetValue(string key, out JToken value) { }

	// RVA: 0x1DBD5D0 Offset: 0x1DBBFD0 VA: 0x181DBD5D0
	public ICollection<string> get_Keys() { }

	// RVA: 0x1DBD620 Offset: 0x1DBC020 VA: 0x181DBD620
	public ICollection<JToken> get_Values() { }

	// RVA: 0x1DBCC90 Offset: 0x1DBB690 VA: 0x181DBCC90
	public int IndexOfReference(JToken t) { }

	// RVA: 0x1DBC650 Offset: 0x1DBB050 VA: 0x181DBC650
	public bool Compare(JPropertyKeyedCollection other) { }

	// RVA: 0x1DBD3B0 Offset: 0x1DBBDB0 VA: 0x181DBD3B0
	private static void .cctor() { }
}
