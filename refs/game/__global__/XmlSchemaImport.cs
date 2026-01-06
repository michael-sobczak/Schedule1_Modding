public class XmlSchemaImport : XmlSchemaExternal // TypeDefIndex: 8460
{
	// Fields
	private string ns; // 0x68
	private XmlSchemaAnnotation annotation; // 0x70

	// Properties
	[Xml("namespace", DataType = "anyURI")]
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x244BD20 Offset: 0x244A720 VA: 0x18244BD20
	public void .ctor() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public string get_Namespace() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_Namespace(string value) { }

	// RVA: 0x5F4EE0 Offset: 0x5F38E0 VA: 0x1805F4EE0 Slot: 10
	internal override void AddAnnotation(XmlSchemaAnnotation annotation) { }
}
