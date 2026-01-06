public class XText : XNode // TypeDefIndex: 18642
{
	// Fields
	internal string text; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x23C4060 Offset: 0x23C2A60 VA: 0x1823C4060
	public void .ctor(string value) { }

	// RVA: 0x23C40E0 Offset: 0x23C2AE0 VA: 0x1823C40E0
	public void .ctor(XText other) { }

	// RVA: 0x583670 Offset: 0x582070 VA: 0x180583670 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Value() { }

	// RVA: 0x23CBDD0 Offset: 0x23CA7D0 VA: 0x1823CBDD0
	public void set_Value(string value) { }

	// RVA: 0x23CBCE0 Offset: 0x23CA6E0 VA: 0x1823CBCE0 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x23CBC00 Offset: 0x23CA600 VA: 0x1823CBC00 Slot: 9
	internal override void AppendText(StringBuilder sb) { }

	// RVA: 0x23CBC30 Offset: 0x23CA630 VA: 0x1823CBC30 Slot: 10
	internal override XNode CloneNode() { }
}
