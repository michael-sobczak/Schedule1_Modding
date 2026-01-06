public sealed class X509KeyUsageExtension : X509Extension // TypeDefIndex: 9649
{
	// Fields
	internal const string oid = "2.5.29.15";
	internal const string friendlyName = "Key Usage";
	internal const X509KeyUsageFlags all = 33023;
	private X509KeyUsageFlags _keyUsages; // 0x28
	private AsnDecodeStatus _status; // 0x2C

	// Properties
	public X509KeyUsageFlags KeyUsages { get; }

	// Methods

	// RVA: 0x2659510 Offset: 0x2657F10 VA: 0x182659510
	public void .ctor() { }

	// RVA: 0x2659350 Offset: 0x2657D50 VA: 0x182659350
	public void .ctor(AsnEncodedData encodedKeyUsage, bool critical) { }

	// RVA: 0x2659430 Offset: 0x2657E30 VA: 0x182659430
	public void .ctor(X509KeyUsageFlags keyUsages, bool critical) { }

	// RVA: 0x26595A0 Offset: 0x2657FA0 VA: 0x1826595A0
	public X509KeyUsageFlags get_KeyUsages() { }

	// RVA: 0x2658980 Offset: 0x2657380 VA: 0x182658980 Slot: 4
	public override void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x2658E30 Offset: 0x2657830 VA: 0x182658E30
	internal X509KeyUsageFlags GetValidFlags(X509KeyUsageFlags flags) { }

	// RVA: 0x2658B60 Offset: 0x2657560 VA: 0x182658B60
	internal AsnDecodeStatus Decode(byte[] extension) { }

	// RVA: 0x2658CC0 Offset: 0x26576C0 VA: 0x182658CC0
	internal byte[] Encode() { }

	// RVA: 0x2658E40 Offset: 0x2657840 VA: 0x182658E40 Slot: 6
	internal override string ToString(bool multiLine) { }
}
