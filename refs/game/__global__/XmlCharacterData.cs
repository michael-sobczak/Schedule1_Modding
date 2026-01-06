public abstract class XmlCharacterData : XmlLinkedNode // TypeDefIndex: 8038
{
	// Fields
	private string data; // 0x20

	// Properties
	public override string Value { get; set; }
	public override string InnerText { get; set; }
	public virtual string Data { get; set; }

	// Methods

	// RVA: 0x24F0C90 Offset: 0x24EF690 VA: 0x1824F0C90
	protected internal void .ctor(string data, XmlDocument doc) { }

	// RVA: 0x24F0F50 Offset: 0x24EF950 VA: 0x1824F0F50 Slot: 9
	public override string get_Value() { }

	// RVA: 0x24F1050 Offset: 0x24EFA50 VA: 0x1824F1050 Slot: 10
	public override void set_Value(string value) { }

	// RVA: 0x4BC030 Offset: 0x4BAA30 VA: 0x1804BC030 Slot: 40
	public override string get_InnerText() { }

	// RVA: 0x2250F60 Offset: 0x224F960 VA: 0x182250F60 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x24F0F00 Offset: 0x24EF900 VA: 0x1824F0F00 Slot: 61
	public virtual string get_Data() { }

	// RVA: 0x24F0F70 Offset: 0x24EF970 VA: 0x1824F0F70 Slot: 62
	public virtual void set_Data(string value) { }

	// RVA: 0x24F0DF0 Offset: 0x24EF7F0 VA: 0x1824F0DF0
	internal bool CheckOnData(string data) { }

	// RVA: 0x24F0E20 Offset: 0x24EF820 VA: 0x1824F0E20
	internal bool DecideXPNodeTypeForTextNodes(XmlNode node, ref XPathNodeType xnt) { }
}
