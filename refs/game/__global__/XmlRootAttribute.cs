public class XmlRootAttribute : Attribute // TypeDefIndex: 8186
{
	// Fields
	private string dataType; // 0x10
	private string elementName; // 0x18
	private bool isNullable; // 0x20
	private string ns; // 0x28

	// Properties
	public string DataType { get; set; }
	public string ElementName { get; set; }
	public bool IsNullable { get; set; }
	public string Namespace { get; set; }

	// Methods

	// RVA: 0x254B950 Offset: 0x254A350 VA: 0x18254B950
	public void .ctor() { }

	// RVA: 0x254B960 Offset: 0x254A360 VA: 0x18254B960
	public void .ctor(string elementName) { }

	// RVA: 0x254B9A0 Offset: 0x254A3A0 VA: 0x18254B9A0
	public string get_DataType() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_DataType(string value) { }

	// RVA: 0x254B9F0 Offset: 0x254A3F0 VA: 0x18254B9F0
	public string get_ElementName() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ElementName(string value) { }

	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsNullable() { }

	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	public void set_IsNullable(bool value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Namespace() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_Namespace(string value) { }

	// RVA: 0x254B890 Offset: 0x254A290 VA: 0x18254B890
	internal void AddKeyHash(StringBuilder sb) { }
}
