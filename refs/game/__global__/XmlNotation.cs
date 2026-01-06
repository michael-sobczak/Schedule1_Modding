public class XmlNotation : XmlNode // TypeDefIndex: 8066
{
	// Fields
	private string publicId; // 0x18
	private string systemId; // 0x20
	private string name; // 0x28

	// Properties
	public override string Name { get; }
	public override string LocalName { get; }
	public override XmlNodeType NodeType { get; }
	public override bool IsReadOnly { get; }
	public override string InnerXml { set; }

	// Methods

	// RVA: 0x251FB90 Offset: 0x251E590 VA: 0x18251FB90
	internal void .ctor(string name, string publicId, string systemId, XmlDocument doc) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 38
	public override string get_LocalName() { }

	// RVA: 0x8793B0 Offset: 0x877DB0 VA: 0x1808793B0 Slot: 11
	public override XmlNodeType get_NodeType() { }

	// RVA: 0x251FB30 Offset: 0x251E530 VA: 0x18251FB30 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 39
	public override bool get_IsReadOnly() { }

	// RVA: 0x251FCB0 Offset: 0x251E6B0 VA: 0x18251FCB0 Slot: 42
	public override void set_InnerXml(string value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 46
	public override void WriteContentTo(XmlWriter w) { }
}
