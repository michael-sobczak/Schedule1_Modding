public class XmlNamespaceManager : IXmlNamespaceResolver, IEnumerable // TypeDefIndex: 8118
{
	// Fields
	private XmlNamespaceManager.NamespaceDeclaration[] nsdecls; // 0x10
	private int lastDecl; // 0x18
	private XmlNameTable nameTable; // 0x20
	private int scopeId; // 0x28
	private Dictionary<string, int> hashTable; // 0x30
	private bool useHashtable; // 0x38
	private string xml; // 0x40
	private string xmlNs; // 0x48

	// Properties
	public virtual XmlNameTable NameTable { get; }
	public virtual string DefaultNamespace { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	internal void .ctor() { }

	// RVA: 0x253C180 Offset: 0x253AB80 VA: 0x18253C180
	public void .ctor(XmlNameTable nameTable) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 8
	public virtual XmlNameTable get_NameTable() { }

	// RVA: 0x253C400 Offset: 0x253AE00 VA: 0x18253C400 Slot: 9
	public virtual string get_DefaultNamespace() { }

	// RVA: 0x127AC70 Offset: 0x1279670 VA: 0x18127AC70 Slot: 10
	public virtual void PushScope() { }

	// RVA: 0x253BEF0 Offset: 0x253A8F0 VA: 0x18253BEF0 Slot: 11
	public virtual bool PopScope() { }

	// RVA: 0x253B470 Offset: 0x2539E70 VA: 0x18253B470 Slot: 12
	public virtual void AddNamespace(string prefix, string uri) { }

	// RVA: 0x253BFE0 Offset: 0x253A9E0 VA: 0x18253BFE0 Slot: 13
	public virtual void RemoveNamespace(string prefix, string uri) { }

	// RVA: 0x253B8D0 Offset: 0x253A2D0 VA: 0x18253B8D0 Slot: 14
	public virtual IEnumerator GetEnumerator() { }

	// RVA: 0x253BA40 Offset: 0x253A440 VA: 0x18253BA40 Slot: 15
	public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope) { }

	// RVA: 0x253BDC0 Offset: 0x253A7C0 VA: 0x18253BDC0 Slot: 16
	public virtual string LookupNamespace(string prefix) { }

	// RVA: 0x253BBF0 Offset: 0x253A5F0 VA: 0x18253BBF0
	private int LookupNamespaceDecl(string prefix) { }

	// RVA: 0x253BE10 Offset: 0x253A810 VA: 0x18253BE10 Slot: 17
	public virtual string LookupPrefix(string uri) { }
}
