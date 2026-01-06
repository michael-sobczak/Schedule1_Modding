internal struct NamespaceResolver // TypeDefIndex: 18630
{
	// Fields
	private int _scope; // 0x0
	private NamespaceResolver.NamespaceDeclaration _declaration; // 0x8
	private NamespaceResolver.NamespaceDeclaration _rover; // 0x10

	// Methods

	// RVA: 0x23C2B60 Offset: 0x23C1560 VA: 0x1823C2B60
	public void PushScope() { }

	// RVA: 0x23C2AC0 Offset: 0x23C14C0 VA: 0x1823C2AC0
	public void PopScope() { }

	// RVA: 0x23C28C0 Offset: 0x23C12C0 VA: 0x1823C28C0
	public void Add(string prefix, XNamespace ns) { }

	// RVA: 0x23C27C0 Offset: 0x23C11C0 VA: 0x1823C27C0
	public void AddFirst(string prefix, XNamespace ns) { }

	// RVA: 0x23C29B0 Offset: 0x23C13B0 VA: 0x1823C29B0
	public string GetPrefixOfNamespace(XNamespace ns, bool allowDefaultNamespace) { }
}
