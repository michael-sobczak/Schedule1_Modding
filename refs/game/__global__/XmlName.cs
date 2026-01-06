internal class XmlName : IXmlSchemaInfo // TypeDefIndex: 8054
{
	// Fields
	private string prefix; // 0x10
	private string localName; // 0x18
	private string ns; // 0x20
	private string name; // 0x28
	private int hashCode; // 0x30
	internal XmlDocument ownerDoc; // 0x38
	internal XmlName next; // 0x40

	// Properties
	public string LocalName { get; }
	public string NamespaceURI { get; }
	public string Prefix { get; }
	public int HashCode { get; }
	public XmlDocument OwnerDocument { get; }
	public string Name { get; }
	public virtual XmlSchemaValidity Validity { get; }
	public virtual bool IsDefault { get; }
	public virtual bool IsNil { get; }
	public virtual XmlSchemaSimpleType MemberType { get; }
	public virtual XmlSchemaType SchemaType { get; }
	public virtual XmlSchemaElement SchemaElement { get; }
	public virtual XmlSchemaAttribute SchemaAttribute { get; }

	// Methods

	// RVA: 0x2515A10 Offset: 0x2514410 VA: 0x182515A10
	public static XmlName Create(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next, IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x2515B90 Offset: 0x2514590 VA: 0x182515B90
	internal void .ctor(string prefix, string localName, string ns, int hashCode, XmlDocument ownerDoc, XmlName next) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_LocalName() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_NamespaceURI() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public string get_Prefix() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_HashCode() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public XmlDocument get_OwnerDocument() { }

	// RVA: 0x2515C40 Offset: 0x2514640 VA: 0x182515C40
	public string get_Name() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 11
	public virtual XmlSchemaValidity get_Validity() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 12
	public virtual bool get_IsDefault() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 13
	public virtual bool get_IsNil() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 14
	public virtual XmlSchemaSimpleType get_MemberType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 15
	public virtual XmlSchemaType get_SchemaType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 16
	public virtual XmlSchemaElement get_SchemaElement() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 17
	public virtual XmlSchemaAttribute get_SchemaAttribute() { }

	// RVA: 0x4BE330 Offset: 0x4BCD30 VA: 0x1804BE330 Slot: 18
	public virtual bool Equals(IXmlSchemaInfo schemaInfo) { }

	// RVA: 0x2515B20 Offset: 0x2514520 VA: 0x182515B20
	public static int GetHashCode(string name) { }
}
