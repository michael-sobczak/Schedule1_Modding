public class XmlElementAttribute : Attribute // TypeDefIndex: 8172
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private XmlSchemaForm form; // 0x20
	private string ns; // 0x28
	private bool isNullable; // 0x30
	private Type type; // 0x38
	private int order; // 0x40

	// Properties
	public string DataType { get; }
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public string Namespace { get; }
	public bool IsNullable { get; }
	public int Order { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0x25439D0 Offset: 0x25423D0 VA: 0x1825439D0
	public void .ctor(string elementName) { }

	// RVA: 0x2543970 Offset: 0x2542370 VA: 0x182543970
	public void .ctor(string elementName, Type type) { }

	// RVA: 0x2543A10 Offset: 0x2542410 VA: 0x182543A10
	public string get_DataType() { }

	// RVA: 0x2543A60 Offset: 0x2542460 VA: 0x182543A60
	public string get_ElementName() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public XmlSchemaForm get_Form() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Namespace() { }

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsNullable() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public int get_Order() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Type get_Type() { }

	// RVA: 0x2543810 Offset: 0x2542210 VA: 0x182543810
	internal void AddKeyHash(StringBuilder sb) { }
}
