internal sealed class SchemaNotation // TypeDefIndex: 8385
{
	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal string SystemLiteral { get; set; }
	internal string Pubid { get; set; }

	// Methods

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	internal string get_SystemLiteral() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	internal string get_Pubid() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_Pubid(string value) { }
}
