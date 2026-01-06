internal sealed class ColumnTypeConverter : TypeConverter // TypeDefIndex: 12877
{
	// Fields
	private static readonly Type[] s_types; // 0x0
	private TypeConverter.StandardValuesCollection _values; // 0x10

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	// RVA: 0x20643D0 Offset: 0x2062DD0 VA: 0x1820643D0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x20646A0 Offset: 0x20630A0 VA: 0x1820646A0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2064320 Offset: 0x2062D20 VA: 0x182064320 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2064480 Offset: 0x2062E80 VA: 0x182064480 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2064C10 Offset: 0x2063610 VA: 0x182064C10 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x2064D50 Offset: 0x2063750 VA: 0x182064D50
	private static void .cctor() { }
}
