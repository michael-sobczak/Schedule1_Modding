public class DoubleConverter : BaseNumberConverter // TypeDefIndex: 9711
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x2664C20 Offset: 0x2663620 VA: 0x182664C20 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x2664A60 Offset: 0x2663460 VA: 0x182664A60 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x2664B10 Offset: 0x2663510 VA: 0x182664B10 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x2664B80 Offset: 0x2663580 VA: 0x182664B80 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x57CD00 Offset: 0x57B700 VA: 0x18057CD00
	public void .ctor() { }
}
