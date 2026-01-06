public class XmlArrayItemAttribute : Attribute // TypeDefIndex: 8165
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private bool isNullableSpecified; // 0x31
	private int nestingLevel; // 0x34
	private Type type; // 0x38

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	internal bool IsNullableSpecified { get; }
	public Type Type { get; }
	public int NestingLevel { get; }

	// Methods

	// RVA: 0x253F570 Offset: 0x253DF70 VA: 0x18253F570
	public string get_DataType() { }

	// RVA: 0x253F5C0 Offset: 0x253DFC0 VA: 0x18253F5C0
	public string get_ElementName() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public XmlSchemaForm get_Form() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Namespace() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsNullable() { }

	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	internal bool get_IsNullableSpecified() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Type get_Type() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public int get_NestingLevel() { }

	// RVA: 0x253F3F0 Offset: 0x253DDF0 VA: 0x18253F3F0
	internal void AddKeyHash(StringBuilder sb) { }
}
