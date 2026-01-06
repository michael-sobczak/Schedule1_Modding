public class CultureInfoConverter : TypeConverter // TypeDefIndex: 9699
{
	// Fields
	private TypeConverter.StandardValuesCollection _values; // 0x10
	private const string DefaultInvariantCultureString = "(Default)";

	// Properties
	private string DefaultCultureString { get; }

	// Methods

	// RVA: 0x2645E30 Offset: 0x2644830 VA: 0x182645E30
	private string get_DefaultCultureString() { }

	// RVA: 0xFD29F0 Offset: 0xFD13F0 VA: 0x180FD29F0 Slot: 16
	protected virtual string GetCultureName(CultureInfo culture) { }

	// RVA: 0x2644F10 Offset: 0x2643910 VA: 0x182644F10 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x2644FC0 Offset: 0x26439C0 VA: 0x182644FC0 Slot: 5
	public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x2645070 Offset: 0x2643A70 VA: 0x182645070 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x2645750 Offset: 0x2644150 VA: 0x182645750 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2645C30 Offset: 0x2644630 VA: 0x182645C30 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }
}
