internal class ListMap : ObjectMap // TypeDefIndex: 8225
{
	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_ChoiceMember(string value) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x2565340 Offset: 0x2563D40 VA: 0x182565340
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x2565930 Offset: 0x2564330 VA: 0x182565930
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x2565B10 Offset: 0x2564510 VA: 0x182565B10
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x2565CF0 Offset: 0x25646F0 VA: 0x182565CF0
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x25651A0 Offset: 0x2563BA0 VA: 0x1825651A0 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
