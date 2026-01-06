public sealed class ExtenderProvidedPropertyAttribute : Attribute // TypeDefIndex: 9718
{
	// Fields
	[CompilerGenerated]
	private PropertyDescriptor <ExtenderProperty>k__BackingField; // 0x10
	[CompilerGenerated]
	private IExtenderProvider <Provider>k__BackingField; // 0x18
	[CompilerGenerated]
	private Type <ReceiverType>k__BackingField; // 0x20

	// Properties
	public PropertyDescriptor ExtenderProperty { get; set; }
	public IExtenderProvider Provider { get; set; }
	public Type ReceiverType { get; set; }

	// Methods

	// RVA: 0x2668960 Offset: 0x2667360 VA: 0x182668960
	internal static ExtenderProvidedPropertyAttribute Create(PropertyDescriptor extenderProperty, Type receiverType, IExtenderProvider provider) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public PropertyDescriptor get_ExtenderProperty() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_ExtenderProperty(PropertyDescriptor value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public IExtenderProvider get_Provider() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_Provider(IExtenderProvider value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Type get_ReceiverType() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ReceiverType(Type value) { }

	// RVA: 0x2668A10 Offset: 0x2667410 VA: 0x182668A10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x263FCC0 Offset: 0x263E6C0 VA: 0x18263FCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2668B10 Offset: 0x2667510 VA: 0x182668B10 Slot: 6
	public override bool IsDefaultAttribute() { }
}
