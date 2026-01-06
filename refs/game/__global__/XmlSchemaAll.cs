public class XmlSchemaAll : XmlSchemaGroupBase // TypeDefIndex: 8408
{
	// Fields
	private XmlSchemaObjectCollection items; // 0x78

	// Properties
	[XmlElement("element", typeof(XmlSchemaElement))]
	public override XmlSchemaObjectCollection Items { get; }
	internal override bool IsEmpty { get; }

	// Methods

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210 Slot: 16
	public override XmlSchemaObjectCollection get_Items() { }

	// RVA: 0x2444940 Offset: 0x2443340 VA: 0x182444940 Slot: 14
	internal override bool get_IsEmpty() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0 Slot: 17
	internal override void SetItems(XmlSchemaObjectCollection newItems) { }

	// RVA: 0x24448A0 Offset: 0x24432A0 VA: 0x1824448A0
	public void .ctor() { }
}
