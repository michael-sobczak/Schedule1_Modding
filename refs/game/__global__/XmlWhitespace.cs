public class XmlWhitespace : XmlCharacterData // TypeDefIndex: 8071
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	public override string Value { get; set; }
	internal override XPathNodeType XPNodeType { get; }
	internal override bool IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0x2520730 Offset: 0x251F130 VA: 0x182520730
	protected internal void .ctor(string strData, XmlDocument doc) { }

	// RVA: 0x25207E0 Offset: 0x251F1E0 VA: 0x1825207E0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x25207E0 Offset: 0x251F1E0 VA: 0x1825207E0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x572F50 Offset: 0x571950 VA: 0x180572F50 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x2520160 Offset: 0x251EB60 VA: 0x182520160 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x24F0F50 Offset: 0x24EF950 VA: 0x1824F0F50 Slot: 9
	public override string get_Value() { }

	// RVA: 0x2520840 Offset: 0x251F240 VA: 0x182520840 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x2520670 Offset: 0x251F070 VA: 0x182520670 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x25206E0 Offset: 0x251F0E0 VA: 0x1825206E0 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x2520810 Offset: 0x251F210 VA: 0x182520810 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 59
	internal override bool get_IsText() { }

	// RVA: 0x24F0DA0 Offset: 0x24EF7A0 VA: 0x1824F0DA0 Slot: 60
	public override XmlNode get_PreviousText() { }
}
