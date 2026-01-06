public abstract class TypeListConverter : TypeConverter // TypeDefIndex: 9761
{
	// Fields
	private readonly Type[] _types; // 0x10
	private TypeConverter.StandardValuesCollection _values; // 0x18

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	protected void .ctor(Type[] types) { }

	// RVA: 0x2679070 Offset: 0x2677A70 VA: 0x182679070 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2679120 Offset: 0x2677B20 VA: 0x182679120 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x26791D0 Offset: 0x2677BD0 VA: 0x1826791D0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2679300 Offset: 0x2677D00 VA: 0x182679300 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x26794A0 Offset: 0x2677EA0 VA: 0x1826794A0 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }
}
