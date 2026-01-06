public class AsnEncodedData // TypeDefIndex: 9611
{
	// Fields
	internal Oid _oid; // 0x10
	internal byte[] _raw; // 0x18

	// Properties
	public Oid Oid { get; set; }
	public byte[] RawData { get; set; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x262B3F0 Offset: 0x2629DF0 VA: 0x18262B3F0
	public void .ctor(string oid, byte[] rawData) { }

	// RVA: 0x262B330 Offset: 0x2629D30 VA: 0x18262B330
	public void .ctor(Oid oid, byte[] rawData) { }

	// RVA: 0x262B4E0 Offset: 0x2629EE0 VA: 0x18262B4E0
	public void .ctor(AsnEncodedData asnEncodedData) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Oid get_Oid() { }

	// RVA: 0x262B5F0 Offset: 0x2629FF0 VA: 0x18262B5F0
	public void set_Oid(Oid value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public byte[] get_RawData() { }

	// RVA: 0x262B6A0 Offset: 0x262A0A0 VA: 0x18262B6A0
	public void set_RawData(byte[] value) { }

	// RVA: 0x262A5F0 Offset: 0x2628FF0 VA: 0x18262A5F0 Slot: 4
	public virtual void CopyFrom(AsnEncodedData asnEncodedData) { }

	// RVA: 0x262A900 Offset: 0x2629300 VA: 0x18262A900 Slot: 5
	public virtual string Format(bool multiLine) { }

	// RVA: 0x262B160 Offset: 0x2629B60 VA: 0x18262B160 Slot: 6
	internal virtual string ToString(bool multiLine) { }

	// RVA: 0x262A730 Offset: 0x2629130 VA: 0x18262A730
	internal string Default(bool multiLine) { }

	// RVA: 0x262A550 Offset: 0x2628F50 VA: 0x18262A550
	internal string BasicConstraintsExtension(bool multiLine) { }

	// RVA: 0x262A860 Offset: 0x2629260 VA: 0x18262A860
	internal string EnhancedKeyUsageExtension(bool multiLine) { }

	// RVA: 0x262A990 Offset: 0x2629390 VA: 0x18262A990
	internal string KeyUsageExtension(bool multiLine) { }

	// RVA: 0x262B0C0 Offset: 0x2629AC0 VA: 0x18262B0C0
	internal string SubjectKeyIdentifierExtension(bool multiLine) { }

	// RVA: 0x262ADE0 Offset: 0x26297E0 VA: 0x18262ADE0
	internal string SubjectAltName(bool multiLine) { }

	// RVA: 0x262AA30 Offset: 0x2629430 VA: 0x18262AA30
	internal string NetscapeCertType(bool multiLine) { }
}
