public class TypeConverter // TypeDefIndex: 9798
{
	// Fields
	private const string s_UseCompatibleTypeConverterBehavior = "UseCompatibleTypeConverterBehavior";
	private static bool useCompatibleTypeConversion; // 0x0

	// Properties
	private static bool UseCompatibleTypeConversion { get; }

	// Methods

	// RVA: 0x268CB20 Offset: 0x268B520 VA: 0x18268CB20
	private static bool get_UseCompatibleTypeConversion() { }

	// RVA: 0x268BA20 Offset: 0x268A420 VA: 0x18268BA20
	public bool CanConvertFrom(Type sourceType) { }

	// RVA: 0x268B9A0 Offset: 0x268A3A0 VA: 0x18268B9A0 Slot: 4
	public virtual bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x268BA40 Offset: 0x268A440 VA: 0x18268BA40
	public bool CanConvertTo(Type destinationType) { }

	// RVA: 0x268BA60 Offset: 0x268A460 VA: 0x18268BA60 Slot: 5
	public virtual bool CanConvertTo(ITypeDescriptorContext context, Type destinationType) { }

	// RVA: 0x268BCB0 Offset: 0x268A6B0 VA: 0x18268BCB0
	public object ConvertFrom(object value) { }

	// RVA: 0x268BD30 Offset: 0x268A730 VA: 0x18268BD30 Slot: 6
	public virtual object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x268BAE0 Offset: 0x268A4E0 VA: 0x18268BAE0
	public object ConvertFromInvariantString(string text) { }

	// RVA: 0x268BB60 Offset: 0x268A560 VA: 0x18268BB60
	public object ConvertFromInvariantString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x268BC80 Offset: 0x268A680 VA: 0x18268BC80
	public object ConvertFromString(string text) { }

	// RVA: 0x268BBF0 Offset: 0x268A5F0 VA: 0x18268BBF0
	public object ConvertFromString(ITypeDescriptorContext context, string text) { }

	// RVA: 0x260ED70 Offset: 0x260D770 VA: 0x18260ED70
	public object ConvertFromString(ITypeDescriptorContext context, CultureInfo culture, string text) { }

	// RVA: 0x268C190 Offset: 0x268AB90 VA: 0x18268C190
	public object ConvertTo(object value, Type destinationType) { }

	// RVA: 0x268C1C0 Offset: 0x268ABC0 VA: 0x18268C1C0 Slot: 7
	public virtual object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x268BDA0 Offset: 0x268A7A0 VA: 0x18268BDA0
	public string ConvertToInvariantString(object value) { }

	// RVA: 0x268BE10 Offset: 0x268A810 VA: 0x18268BE10
	public string ConvertToInvariantString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x268BE90 Offset: 0x268A890 VA: 0x18268BE90
	public string ConvertToString(object value) { }

	// RVA: 0x268C080 Offset: 0x268AA80 VA: 0x18268C080
	public string ConvertToString(ITypeDescriptorContext context, object value) { }

	// RVA: 0x268BF90 Offset: 0x268A990 VA: 0x18268BF90
	public string ConvertToString(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x268C400 Offset: 0x268AE00 VA: 0x18268C400
	public object CreateInstance(IDictionary propertyValues) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	public virtual object CreateInstance(ITypeDescriptorContext context, IDictionary propertyValues) { }

	// RVA: 0x268C420 Offset: 0x268AE20 VA: 0x18268C420
	protected Exception GetConvertFromException(object value) { }

	// RVA: 0x268C570 Offset: 0x268AF70 VA: 0x18268C570
	protected Exception GetConvertToException(object value, Type destinationType) { }

	// RVA: 0x268C700 Offset: 0x268B100 VA: 0x18268C700
	public bool GetCreateInstanceSupported() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public virtual bool GetCreateInstanceSupported(ITypeDescriptorContext context) { }

	// RVA: 0x268C740 Offset: 0x268B140 VA: 0x18268C740
	public PropertyDescriptorCollection GetProperties(object value) { }

	// RVA: 0x268C850 Offset: 0x268B250 VA: 0x18268C850
	public PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public virtual PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes) { }

	// RVA: 0x268C720 Offset: 0x268B120 VA: 0x18268C720
	public bool GetPropertiesSupported() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 11
	public virtual bool GetPropertiesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x268C990 Offset: 0x268B390 VA: 0x18268C990
	public ICollection GetStandardValues() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 12
	public virtual TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x1DBFC60 Offset: 0x1DBE660 VA: 0x181DBFC60
	public bool GetStandardValuesExclusive() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 13
	public virtual bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x268C970 Offset: 0x268B370 VA: 0x18268C970
	public bool GetStandardValuesSupported() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 14
	public virtual bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x268C9B0 Offset: 0x268B3B0 VA: 0x18268C9B0
	public bool IsValid(object value) { }

	// RVA: 0x268C9D0 Offset: 0x268B3D0 VA: 0x18268C9D0 Slot: 15
	public virtual bool IsValid(ITypeDescriptorContext context, object value) { }

	// RVA: 0x268CAE0 Offset: 0x268B4E0 VA: 0x18268CAE0
	protected PropertyDescriptorCollection SortProperties(PropertyDescriptorCollection props, string[] names) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
