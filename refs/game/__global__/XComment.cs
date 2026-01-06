public class XComment : XNode // TypeDefIndex: 18614
{
	// Fields
	internal string value; // 0x28

	// Properties
	public override XmlNodeType NodeType { get; }
	public string Value { get; set; }

	// Methods

	// RVA: 0x23C4310 Offset: 0x23C2D10 VA: 0x1823C4310
	public void .ctor(string value) { }

	// RVA: 0x23C4290 Offset: 0x23C2C90 VA: 0x1823C4290
	public void .ctor(XComment other) { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 7
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Value() { }

	// RVA: 0x23C4390 Offset: 0x23C2D90 VA: 0x1823C4390
	public void set_Value(string value) { }

	// RVA: 0x23C4210 Offset: 0x23C2C10 VA: 0x1823C4210 Slot: 8
	public override void WriteTo(XmlWriter writer) { }

	// RVA: 0x23C4160 Offset: 0x23C2B60 VA: 0x1823C4160 Slot: 10
	internal override XNode CloneNode() { }
}
