public class XmlTextAttribute : Attribute // TypeDefIndex: 8209
{
	// Fields
	private string dataType; // 0x10
	private Type type; // 0x18

	// Properties
	public string DataType { get; }
	public Type Type { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x2572FD0 Offset: 0x25719D0 VA: 0x182572FD0
	public string get_DataType() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Type get_Type() { }

	// RVA: 0x2572F40 Offset: 0x2571940 VA: 0x182572F40
	internal void AddKeyHash(StringBuilder sb) { }
}
