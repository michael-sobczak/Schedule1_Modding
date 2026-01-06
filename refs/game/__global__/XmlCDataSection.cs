public class XmlCDataSection : XmlCharacterData // TypeDefIndex: 8037
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override XmlNode ParentNode { get; }
	internal override XPathNodeType XPNodeType { get; }
	internal override bool IsText { get; }
	public override XmlNode PreviousText { get; }

	// Methods

	// RVA: 0x24F0C90 Offset: 0x24EF690 VA: 0x1824F0C90
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x24F0CD0 Offset: 0x24EF6D0 VA: 0x1824F0CD0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x24F0CD0 Offset: 0x24EF6D0 VA: 0x1824F0CD0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x24F0D00 Offset: 0x24EF700 VA: 0x1824F0D00 Slot: 12
	public override XmlNode get_ParentNode() { }

	// RVA: 0x24F0BD0 Offset: 0x24EF5D0 VA: 0x1824F0BD0 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x24F0C40 Offset: 0x24EF640 VA: 0x1824F0C40 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 59
	internal override bool get_IsText() { }

	// RVA: 0x24F0DA0 Offset: 0x24EF7A0 VA: 0x1824F0DA0 Slot: 60
	public override XmlNode get_PreviousText() { }
}
