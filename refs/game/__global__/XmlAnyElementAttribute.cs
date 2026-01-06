public class XmlAnyElementAttribute : Attribute // TypeDefIndex: 8162
{
	// Fields
	private string elementName; // 0x10
	private string ns; // 0x18
	private int order; // 0x20

	// Properties
	public string Name { get; }
	public string Namespace { get; }
	public int Order { get; }

	// Methods

	// RVA: 0x253EDA0 Offset: 0x253D7A0 VA: 0x18253EDA0
	public void .ctor() { }

	// RVA: 0x253EDB0 Offset: 0x253D7B0 VA: 0x18253EDB0
	public string get_Name() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_Namespace() { }

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_Order() { }

	// RVA: 0x253ED10 Offset: 0x253D710 VA: 0x18253ED10
	internal void AddKeyHash(StringBuilder sb) { }
}
