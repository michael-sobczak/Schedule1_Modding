public class XmlArrayAttribute : Attribute // TypeDefIndex: 8164
{
	// Fields
	private string elementName; // 0x10
	private XmlSchemaForm form; // 0x18
	private bool isNullable; // 0x1C
	private string ns; // 0x20
	private int order; // 0x28

	// Properties
	public string ElementName { get; }
	public XmlSchemaForm Form { get; }
	public bool IsNullable { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x253F3A0 Offset: 0x253DDA0 VA: 0x18253F3A0
	public string get_ElementName() { }

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public XmlSchemaForm get_Form() { }

	// RVA: 0x4975B0 Offset: 0x495FB0 VA: 0x1804975B0
	public bool get_IsNullable() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Namespace() { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_Order() { }

	// RVA: 0x253F270 Offset: 0x253DC70 VA: 0x18253F270
	internal void AddKeyHash(StringBuilder sb) { }
}
