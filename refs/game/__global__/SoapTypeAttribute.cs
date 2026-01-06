public sealed class SoapTypeAttribute : SoapAttribute // TypeDefIndex: 4359
{
	// Fields
	private bool _useAttribute; // 0x28
	private string _xmlElementName; // 0x30
	private string _xmlNamespace; // 0x38
	private string _xmlTypeName; // 0x40
	private string _xmlTypeNamespace; // 0x48
	private bool _isType; // 0x50
	private bool _isElement; // 0x51

	// Properties
	public override bool UseAttribute { get; }
	public string XmlElementName { get; }
	public override string XmlNamespace { get; }
	public string XmlTypeName { get; }
	public string XmlTypeNamespace { get; }
	internal bool IsInteropXmlElement { get; }
	internal bool IsInteropXmlType { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public string get_XmlElementName() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public string get_XmlTypeName() { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public string get_XmlTypeNamespace() { }

	// RVA: 0x50A750 Offset: 0x509150 VA: 0x18050A750
	internal bool get_IsInteropXmlElement() { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	internal bool get_IsInteropXmlType() { }

	// RVA: 0x1B41650 Offset: 0x1B40050 VA: 0x181B41650 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}
