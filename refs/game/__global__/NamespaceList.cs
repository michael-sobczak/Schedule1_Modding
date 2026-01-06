internal class NamespaceList // TypeDefIndex: 8364
{
	// Fields
	private NamespaceList.ListType type; // 0x10
	private Hashtable set; // 0x18
	private string targetNamespace; // 0x20

	// Properties
	public NamespaceList.ListType Type { get; }
	public string Excluded { get; }
	public ICollection Enumerate { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x23E41A0 Offset: 0x23E2BA0 VA: 0x1823E41A0
	public void .ctor(string namespaces, string targetNamespace) { }

	// RVA: 0x23E2F40 Offset: 0x23E1940 VA: 0x1823E2F40
	public NamespaceList Clone() { }

	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public NamespaceList.ListType get_Type() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Excluded() { }

	// RVA: 0x23E4410 Offset: 0x23E2E10 VA: 0x1823E4410
	public ICollection get_Enumerate() { }

	// RVA: 0x23E2E80 Offset: 0x23E1880 VA: 0x1823E2E80 Slot: 4
	public virtual bool Allows(string ns) { }

	// RVA: 0x23E2F10 Offset: 0x23E1910 VA: 0x1823E2F10
	public bool Allows(XmlQualifiedName qname) { }

	// RVA: 0x23E3960 Offset: 0x23E2360 VA: 0x1823E3960 Slot: 3
	public override string ToString() { }

	// RVA: 0x23E3670 Offset: 0x23E2070 VA: 0x1823E3670
	public static bool IsSubset(NamespaceList sub, NamespaceList super) { }

	// RVA: 0x23E3D40 Offset: 0x23E2740 VA: 0x1823E3D40
	public static NamespaceList Union(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x23E30B0 Offset: 0x23E1AB0 VA: 0x1823E30B0
	private NamespaceList CompareSetToOther(NamespaceList other) { }

	// RVA: 0x23E3220 Offset: 0x23E1C20 VA: 0x1823E3220
	public static NamespaceList Intersection(NamespaceList o1, NamespaceList o2, bool v1Compat) { }

	// RVA: 0x23E38F0 Offset: 0x23E22F0 VA: 0x1823E38F0
	private void RemoveNamespace(string tns) { }
}
