public abstract class BaseNumberConverter : TypeConverter // TypeDefIndex: 9685
{
	// Properties
	internal virtual bool AllowHex { get; }
	internal abstract Type TargetType { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	internal void .ctor() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 16
	internal virtual bool get_AllowHex() { }

	// RVA: -1 Offset: -1 Slot: 17
	internal abstract Type get_TargetType();

	// RVA: -1 Offset: -1 Slot: 18
	internal abstract object FromString(string value, int radix);

	// RVA: -1 Offset: -1 Slot: 19
	internal abstract object FromString(string value, NumberFormatInfo formatInfo);

	// RVA: -1 Offset: -1 Slot: 20
	internal abstract string ToString(object value, NumberFormatInfo formatInfo);

	// RVA: 0x2642730 Offset: 0x2641130 VA: 0x182642730 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2642820 Offset: 0x2641220 VA: 0x182642820 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2642BA0 Offset: 0x26415A0 VA: 0x182642BA0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x26427E0 Offset: 0x26411E0 VA: 0x1826427E0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }
}
