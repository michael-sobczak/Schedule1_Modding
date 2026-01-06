public class EnumConverter : TypeConverter // TypeDefIndex: 9786
{
	// Fields
	private TypeConverter.StandardValuesCollection values; // 0x10
	private Type type; // 0x18

	// Properties
	protected Type EnumType { get; }
	protected TypeConverter.StandardValuesCollection Values { get; set; }
	protected virtual IComparer Comparer { get; }

	// Methods

	// RVA: 0x20C7F90 Offset: 0x20C6990 VA: 0x1820C7F90
	public void .ctor(Type type) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	protected Type get_EnumType() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	protected TypeConverter.StandardValuesCollection get_Values() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	protected void set_Values(TypeConverter.StandardValuesCollection value) { }

	// RVA: 0x2664FD0 Offset: 0x26639D0 VA: 0x182664FD0 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x26650C0 Offset: 0x2663AC0 VA: 0x1826650C0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x26668C0 Offset: 0x26652C0 VA: 0x1826668C0 Slot: 16
	protected virtual IComparer get_Comparer() { }

	// RVA: 0x26651B0 Offset: 0x2663BB0 VA: 0x1826651B0 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2665630 Offset: 0x2664030 VA: 0x182665630 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2666470 Offset: 0x2664E70 VA: 0x182666470 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x26663D0 Offset: 0x2664DD0 VA: 0x1826663D0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x2666860 Offset: 0x2665260 VA: 0x182666860 Slot: 15
	public override bool IsValid(ITypeDescriptorContext context, object value) { }
}
