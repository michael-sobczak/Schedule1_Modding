public class ReferenceConverter : TypeConverter // TypeDefIndex: 9746
{
	// Fields
	private static readonly string s_none; // 0x0
	private Type _type; // 0x10

	// Methods

	// RVA: 0x492FD0 Offset: 0x4919D0 VA: 0x180492FD0
	public void .ctor(Type type) { }

	// RVA: 0x266FD70 Offset: 0x266E770 VA: 0x18266FD70 Slot: 4
	public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType) { }

	// RVA: 0x266FE20 Offset: 0x266E820 VA: 0x18266FE20 Slot: 6
	public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value) { }

	// RVA: 0x26700B0 Offset: 0x266EAB0 VA: 0x1826700B0 Slot: 7
	public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType) { }

	// RVA: 0x2670440 Offset: 0x266EE40 VA: 0x182670440 Slot: 12
	public override TypeConverter.StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 13
	public override bool GetStandardValuesExclusive(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 14
	public override bool GetStandardValuesSupported(ITypeDescriptorContext context) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 16
	protected virtual bool IsValueAllowed(ITypeDescriptorContext context, object value) { }

	// RVA: 0x26709C0 Offset: 0x266F3C0 VA: 0x1826709C0
	private static void .cctor() { }
}
