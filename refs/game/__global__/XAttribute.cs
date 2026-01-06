public class XAttribute : XObject // TypeDefIndex: 18612
{
	// Fields
	internal XAttribute next; // 0x20
	internal XName name; // 0x28
	internal string value; // 0x30

	// Properties
	public bool IsNamespaceDeclaration { get; }
	public XName Name { get; }
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x23C3BC0 Offset: 0x23C25C0 VA: 0x1823C3BC0
	public void .ctor(XName name, object value) { }

	// RVA: 0x23C3CD0 Offset: 0x23C26D0 VA: 0x1823C3CD0
	public void .ctor(XAttribute other) { }

	// RVA: 0x23C3D70 Offset: 0x23C2770 VA: 0x1823C3D70
	public bool get_IsNamespaceDeclaration() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public XName get_Name() { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Value() { }

	// RVA: 0x23C3E00 Offset: 0x23C2800 VA: 0x1823C3E00
	public void set_Value(string value) { }

	// RVA: 0x23C3480 Offset: 0x23C1E80 VA: 0x1823C3480 Slot: 3
	public override string ToString() { }

	// RVA: 0x23C3340 Offset: 0x23C1D40 VA: 0x1823C3340
	internal string GetPrefixOfNamespace(XNamespace ns) { }

	// RVA: 0x23C3810 Offset: 0x23C2210 VA: 0x1823C3810
	private static void ValidateAttribute(XName name, string value) { }
}
