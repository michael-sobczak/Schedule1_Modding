public class DecimalConverter : BaseNumberConverter // TypeDefIndex: 9702
{
	// Properties
	internal override bool AllowHex { get; }
	internal override Type TargetType { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 16
	internal override bool get_AllowHex() { }

	// RVA: 0x2663BB0 Offset: 0x26625B0 VA: 0x182663BB0 Slot: 17
	internal override Type get_TargetType() { }

	// RVA: 0x26635B0 Offset: 0x2661FB0 VA: 0x1826635B0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x2663660 Offset: 0x2662060 VA: 0x182663660 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2663A50 Offset: 0x2662450 VA: 0x182663A50 Slot: 18
	internal override object FromString(string value, int radix) { }

	// RVA: 0x26639C0 Offset: 0x26623C0 VA: 0x1826639C0 Slot: 19
	internal override object FromString(string value, NumberFormatInfo formatInfo) { }

	// RVA: 0x2663B00 Offset: 0x2662500 VA: 0x182663B00 Slot: 20
	internal override string ToString(object value, NumberFormatInfo formatInfo) { }

	// RVA: 0x57CD00 Offset: 0x57B700 VA: 0x18057CD00
	public void .ctor() { }
}
