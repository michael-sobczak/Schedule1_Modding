public class XmlSerializerNamespaces // TypeDefIndex: 8141
{
	// Fields
	private Hashtable namespaces; // 0x10

	// Properties
	public int Count { get; }
	internal ArrayList NamespaceList { get; }
	internal Hashtable Namespaces { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }

	// RVA: 0x253DB30 Offset: 0x253C530 VA: 0x18253DB30
	public void Add(string prefix, string ns) { }

	// RVA: 0x253DA80 Offset: 0x253C480 VA: 0x18253DA80
	internal void AddInternal(string prefix, string ns) { }

	// RVA: 0x253DC50 Offset: 0x253C650 VA: 0x18253DC50
	public XmlQualifiedName[] ToArray() { }

	// RVA: 0x253DD50 Offset: 0x253C750 VA: 0x18253DD50
	public int get_Count() { }

	// RVA: 0x253DDE0 Offset: 0x253C7E0 VA: 0x18253DDE0
	internal ArrayList get_NamespaceList() { }

	// RVA: 0x253E1F0 Offset: 0x253CBF0 VA: 0x18253E1F0
	internal Hashtable get_Namespaces() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	internal void set_Namespaces(Hashtable value) { }
}
