public class XmlComment : XmlCharacterData // TypeDefIndex: 8041
{
	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	internal override XPathNodeType XPNodeType { get; }

	// Methods

	// RVA: 0x24F0C90 Offset: 0x24EF690 VA: 0x1824F0C90
	protected internal void .ctor(string comment, XmlDocument doc) { }

	// RVA: 0x24F14E0 Offset: 0x24EFEE0 VA: 0x1824F14E0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x24F14E0 Offset: 0x24EFEE0 VA: 0x1824F14E0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x24F1420 Offset: 0x24EFE20 VA: 0x1824F1420 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x24F1490 Offset: 0x24EFE90 VA: 0x1824F1490 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 57
	internal override XPathNodeType get_XPNodeType() { }
}
