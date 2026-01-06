public class XmlSchemaSimpleTypeList : XmlSchemaSimpleTypeContent // TypeDefIndex: 8484
{
	// Fields
	private XmlQualifiedName itemTypeName; // 0x50
	private XmlSchemaSimpleType itemType; // 0x58
	private XmlSchemaSimpleType baseItemType; // 0x60

	// Properties
	[Xml("itemType")]
	public XmlQualifiedName ItemTypeName { get; set; }
	[XmlElement("simpleType", typeof(XmlSchemaSimpleType))]
	public XmlSchemaSimpleType ItemType { get; set; }
	[XmlIgnore]
	public XmlSchemaSimpleType BaseItemType { get; set; }

	// Methods

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public XmlQualifiedName get_ItemTypeName() { }

	// RVA: 0x245EED0 Offset: 0x245D8D0 VA: 0x18245EED0
	public void set_ItemTypeName(XmlQualifiedName value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public XmlSchemaSimpleType get_ItemType() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_ItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlSchemaSimpleType get_BaseItemType() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_BaseItemType(XmlSchemaSimpleType value) { }

	// RVA: 0x245ED30 Offset: 0x245D730 VA: 0x18245ED30 Slot: 13
	internal override XmlSchemaObject Clone() { }

	// RVA: 0x245EE60 Offset: 0x245D860 VA: 0x18245EE60
	public void .ctor() { }
}
