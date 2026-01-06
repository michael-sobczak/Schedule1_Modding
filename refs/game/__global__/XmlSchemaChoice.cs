public class XmlSchemaChoice : XmlSchemaGroupBase // TypeDefIndex: 8417
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	[XmlElement("group", typeof(XmlSchemaGroupRef))]
	[XmlElement("choice", typeof(XmlSchemaChoice))]
	[XmlElement("any", typeof(XmlSchemaAny))]
	[XmlElement("sequence", typeof(XmlSchemaSequence))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x2445B30 Offset: 0x2444530 VA: 0x182445B30 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x2445A90 Offset: 0x2444490 VA: 0x182445A90
	public void .ctor() { }
}
