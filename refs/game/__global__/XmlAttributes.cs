public class XmlAttributes // TypeDefIndex: 8169
{
	// Fields
	private XmlAnyAttributeAttribute xmlAnyAttribute; // 0x10
	private XmlAnyElementAttributes xmlAnyElements; // 0x18
	private XmlArrayAttribute xmlArray; // 0x20
	private XmlArrayItemAttributes xmlArrayItems; // 0x28
	private XmlAttributeAttribute xmlAttribute; // 0x30
	private XmlChoiceIdentifierAttribute xmlChoiceIdentifier; // 0x38
	private object xmlDefaultValue; // 0x40
	private XmlElementAttributes xmlElements; // 0x48
	private XmlEnumAttribute xmlEnum; // 0x50
	private bool xmlIgnore; // 0x58
	private bool xmlns; // 0x59
	private XmlRootAttribute xmlRoot; // 0x60
	private XmlTextAttribute xmlText; // 0x68
	private XmlTypeAttribute xmlType; // 0x70

	// Properties
	public XmlAnyAttributeAttribute XmlAnyAttribute { get; }
	public XmlAnyElementAttributes XmlAnyElements { get; }
	public XmlArrayAttribute XmlArray { get; }
	public XmlArrayItemAttributes XmlArrayItems { get; }
	public XmlAttributeAttribute XmlAttribute { get; }
	public XmlChoiceIdentifierAttribute XmlChoiceIdentifier { get; }
	public object XmlDefaultValue { get; }
	public XmlElementAttributes XmlElements { get; }
	public bool XmlIgnore { get; }
	public bool Xmlns { get; }
	public XmlRootAttribute XmlRoot { get; }
	public XmlTextAttribute XmlText { get; }
	public XmlTypeAttribute XmlType { get; }
	internal Nullable<int> Order { get; }
	internal int SortableOrder { get; }

	// Methods

	// RVA: 0x2540910 Offset: 0x253F310 VA: 0x182540910
	public void .ctor() { }

	// RVA: 0x2540A30 Offset: 0x253F430 VA: 0x182540A30
	public void .ctor(ICustomAttributeProvider provider) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public XmlAnyAttributeAttribute get_XmlAnyAttribute() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public XmlAnyElementAttributes get_XmlAnyElements() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public XmlArrayAttribute get_XmlArray() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public XmlArrayItemAttributes get_XmlArrayItems() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public XmlAttributeAttribute get_XmlAttribute() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public XmlChoiceIdentifierAttribute get_XmlChoiceIdentifier() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public object get_XmlDefaultValue() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public XmlElementAttributes get_XmlElements() { }

	// RVA: 0x4D61A0 Offset: 0x4D4BA0 VA: 0x1804D61A0
	public bool get_XmlIgnore() { }

	// RVA: 0x79D110 Offset: 0x79BB10 VA: 0x18079D110
	public bool get_Xmlns() { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public XmlRootAttribute get_XmlRoot() { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public XmlTextAttribute get_XmlText() { }

	// RVA: 0x4663C0 Offset: 0x464DC0 VA: 0x1804663C0
	public XmlTypeAttribute get_XmlType() { }

	// RVA: 0x2540200 Offset: 0x253EC00 VA: 0x182540200
	internal void AddKeyHash(StringBuilder sb) { }

	// RVA: 0x2541670 Offset: 0x2540070 VA: 0x182541670
	internal Nullable<int> get_Order() { }

	// RVA: 0x2541730 Offset: 0x2540130 VA: 0x182541730
	internal int get_SortableOrder() { }
}
