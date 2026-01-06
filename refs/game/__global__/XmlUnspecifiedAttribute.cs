internal class XmlUnspecifiedAttribute : XmlAttribute // TypeDefIndex: 8070
{
	// Fields
	private bool fSpecified; // 0x28

	// Properties
	public override bool Specified { get; }
	public override string InnerText { set; }

	// Methods

	// RVA: 0x2520640 Offset: 0x251F040 VA: 0x182520640
	protected internal void .ctor(string prefix, string localName, string namespaceURI, XmlDocument doc) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120 Slot: 61
	public override bool get_Specified() { }

	// RVA: 0x2520480 Offset: 0x251EE80 VA: 0x182520480 Slot: 33
	public override XmlNode CloneNode(bool deep) { }

	// RVA: 0x2520650 Offset: 0x251F050 VA: 0x182520650 Slot: 41
	public override void set_InnerText(string value) { }

	// RVA: 0x25205F0 Offset: 0x251EFF0 VA: 0x1825205F0 Slot: 23
	public override XmlNode InsertBefore(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x25205D0 Offset: 0x251EFD0 VA: 0x1825205D0 Slot: 24
	public override XmlNode InsertAfter(XmlNode newChild, XmlNode refChild) { }

	// RVA: 0x2520610 Offset: 0x251F010 VA: 0x182520610 Slot: 25
	public override XmlNode RemoveChild(XmlNode oldChild) { }

	// RVA: 0x2520460 Offset: 0x251EE60 VA: 0x182520460 Slot: 27
	public override XmlNode AppendChild(XmlNode newChild) { }

	// RVA: 0x2520630 Offset: 0x251F030 VA: 0x182520630 Slot: 45
	public override void WriteTo(XmlWriter w) { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	internal void SetSpecified(bool f) { }
}
