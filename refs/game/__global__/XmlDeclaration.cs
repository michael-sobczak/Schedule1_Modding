public class XmlDeclaration : XmlLinkedNode // TypeDefIndex: 8042
{
	// Fields
	private string version; // 0x20
	private string encoding; // 0x28
	private string standalone; // 0x30

	// Properties
	public string Version { get; set; }
	public string Encoding { get; set; }
	public string Standalone { get; set; }
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }

	// Methods

	// RVA: 0x24F1660 Offset: 0x24F0060 VA: 0x1824F1660
	protected internal void .ctor(string version, string encoding, string standalone, XmlDocument doc) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public string get_Version() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	internal void set_Version(string value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Encoding() { }

	// RVA: 0x24F1A50 Offset: 0x24F0450 VA: 0x1824F1A50
	public void set_Encoding(string value) { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_Standalone() { }

	// RVA: 0x24F1DE0 Offset: 0x24F07E0 VA: 0x1824F1DE0
	public void set_Standalone(string value) { }

	// RVA: 0x1C043E0 Offset: 0x1C02DE0 VA: 0x181C043E0 Slot: 9
	public override string get_Value() { }

	// RVA: 0x11DC8F0 Offset: 0x11DB2F0 VA: 0x1811DC8F0 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x24F18C0 Offset: 0x24F02C0 VA: 0x1824F18C0 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x24F1AC0 Offset: 0x24F04C0 VA: 0x1824F1AC0 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x24F1A20 Offset: 0x24F0420 VA: 0x1824F1A20 Slot: 8
	public override string get_Name() { }

	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x1DF3BD0 Offset: 0x1DF25D0 VA: 0x181DF3BD0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x24F1510 Offset: 0x24EFF10 VA: 0x1824F1510 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x24F15E0 Offset: 0x24EFFE0 VA: 0x1824F15E0 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x24F1570 Offset: 0x24EFF70 VA: 0x1824F1570
	private bool IsValidXmlVersion(string ver) { }
}
