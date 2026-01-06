internal class SymbolsDictionary // TypeDefIndex: 8254
{
	// Fields
	private int last; // 0x10
	private Hashtable names; // 0x18
	private Hashtable wildcards; // 0x20
	private ArrayList particles; // 0x28
	private object particleLast; // 0x30
	private bool isUpaEnforced; // 0x38

	// Properties
	public int Count { get; }
	public bool IsUpaEnforced { get; set; }
	public int Item { get; }

	// Methods

	// RVA: 0x256C010 Offset: 0x256AA10 VA: 0x18256C010
	public void .ctor() { }

	// RVA: 0x256C0B0 Offset: 0x256AAB0 VA: 0x18256C0B0
	public int get_Count() { }

	// RVA: 0x8D2170 Offset: 0x8D0B70 VA: 0x1808D2170
	public bool get_IsUpaEnforced() { }

	// RVA: 0x91C530 Offset: 0x91AF30 VA: 0x18091C530
	public void set_IsUpaEnforced(bool value) { }

	// RVA: 0x256AF80 Offset: 0x2569980 VA: 0x18256AF80
	public int AddName(XmlQualifiedName name, object particle) { }

	// RVA: 0x256B0D0 Offset: 0x2569AD0 VA: 0x18256B0D0
	public void AddNamespaceList(NamespaceList list, object particle, bool allowLocal) { }

	// RVA: 0x256B360 Offset: 0x2569D60 VA: 0x18256B360
	private void AddWildcard(string wildcard, object particle) { }

	// RVA: 0x256B520 Offset: 0x2569F20 VA: 0x18256B520
	public ICollection GetNamespaceListSymbols(NamespaceList list) { }

	// RVA: 0x256C0C0 Offset: 0x256AAC0 VA: 0x18256C0C0
	public int get_Item(XmlQualifiedName name) { }

	// RVA: 0x256B4E0 Offset: 0x2569EE0 VA: 0x18256B4E0
	public bool Exists(XmlQualifiedName name) { }

	// RVA: 0x256BB80 Offset: 0x256A580 VA: 0x18256BB80
	public object GetParticle(int symbol) { }

	// RVA: 0x256BBC0 Offset: 0x256A5C0 VA: 0x18256BBC0
	public string NameOf(int symbol) { }
}
