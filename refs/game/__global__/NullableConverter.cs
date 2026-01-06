public class NullableConverter : TypeConverter // TypeDefIndex: 9740
{
	// Fields
	[CompilerGenerated]
	private readonly Type <NullableType>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly Type <UnderlyingType>k__BackingField; // 0x18
	[CompilerGenerated]
	private readonly TypeConverter <UnderlyingTypeConverter>k__BackingField; // 0x20

	// Properties
	public Type NullableType { get; }
	public Type UnderlyingType { get; }
	public TypeConverter UnderlyingTypeConverter { get; }

	// Methods

	// RVA: 0x266C5A0 Offset: 0x266AFA0 VA: 0x18266C5A0
	public void .ctor(Type type) { }

	// RVA: 0x266BC40 Offset: 0x266A640 VA: 0x18266BC40 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x266BDC0 Offset: 0x266A7C0 VA: 0x18266BDC0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x266BD00 Offset: 0x266A700 VA: 0x18266BD00 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x266BF20 Offset: 0x266A920 VA: 0x18266BF20 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x266C120 Offset: 0x266AB20 VA: 0x18266C120 Slot: 8
	public override object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x266C160 Offset: 0x266AB60 VA: 0x18266C160 Slot: 9
	public override bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x266C1E0 Offset: 0x266ABE0 VA: 0x18266C1E0 Slot: 10
	public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x266C1A0 Offset: 0x266ABA0 VA: 0x18266C1A0 Slot: 11
	public override bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x266C2B0 Offset: 0x266ACB0 VA: 0x18266C2B0 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x266C230 Offset: 0x266AC30 VA: 0x18266C230 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x266C270 Offset: 0x266AC70 VA: 0x18266C270 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x266C550 Offset: 0x266AF50 VA: 0x18266C550 Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Type get_NullableType() { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Type get_UnderlyingType() { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public TypeConverter get_UnderlyingTypeConverter() { }
}
