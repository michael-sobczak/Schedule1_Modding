public class XmlAttributeAttribute : Attribute // TypeDefIndex: 8167
{
	// Fields
	private string attributeName; // 0x10
	private string dataType; // 0x18
	private Type type; // 0x20
	private XmlSchemaForm form; // 0x28
	private string ns; // 0x30

	// Properties
	public string AttributeName { get; }
	public string DataType { get; set; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(string attributeName) { }

	// RVA: 0x253FB20 Offset: 0x253E520 VA: 0x18253FB20
	public string get_AttributeName() { }

	// RVA: 0x253FB70 Offset: 0x253E570 VA: 0x18253FB70
	public string get_DataType() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_DataType(string value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public XmlSchemaForm get_Form() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Namespace() { }

	// RVA: 0x253F9E0 Offset: 0x253E3E0 VA: 0x18253F9E0
	internal void AddKeyHash(StringBuilder sb) { }
}
