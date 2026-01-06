public sealed class SoapMethodAttribute : SoapAttribute // TypeDefIndex: 4357
{
	// Fields
	private string _responseElement; // 0x28
	private string _responseNamespace; // 0x30
	private string _returnElement; // 0x38
	private string _soapAction; // 0x40
	private bool _useAttribute; // 0x48
	private string _namespace; // 0x50

	// Properties
	public override bool UseAttribute { get; }
	public override string XmlNamespace { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0 Slot: 7
	public override bool get_UseAttribute() { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0 Slot: 8
	public override string get_XmlNamespace() { }

	// RVA: 0x1B41450 Offset: 0x1B3FE50 VA: 0x181B41450 Slot: 9
	internal override void SetReflectionObject(object reflectionObject) { }
}
