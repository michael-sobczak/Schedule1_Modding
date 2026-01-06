public class SingleConverter : BaseNumberConverter // TypeDefIndex: 9752
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x2677720 Offset: 0x2676120 VA: 0x182677720 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x26775D0 Offset: 0x2675FD0 VA: 0x1826775D0 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x2677560 Offset: 0x2675F60 VA: 0x182677560 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x2677680 Offset: 0x2676080 VA: 0x182677680 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x57CD00 Offset: 0x57B700 VA: 0x18057CD00
	public void .ctor() { }
}
