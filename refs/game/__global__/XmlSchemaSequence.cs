public class XmlSchemaSequence : XmlSchemaGroupBase // TypeDefIndex: 8477
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x2456B40 Offset: 0x2455540 VA: 0x182456B40 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x2456AD0 Offset: 0x24554D0 VA: 0x182456AD0
	public void .ctor() { }
}
