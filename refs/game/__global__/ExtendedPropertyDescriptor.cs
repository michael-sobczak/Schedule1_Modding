internal sealed class ExtendedPropertyDescriptor : PropertyDescriptor // TypeDefIndex: 9717
{
	// Fields
	private readonly ReflectPropertyDescriptor _extenderInfo; // 0x88
	private readonly IExtenderProvider _provider; // 0x90

	// Properties
	public override Type ComponentType { get; }
	public override bool IsReadOnly { get; }
	public override Type PropertyType { get; }
	public override string DisplayName { get; }

	// Methods

	// RVA: 0x26682E0 Offset: 0x2666CE0 VA: 0x1826682E0
	public void .ctor(ReflectPropertyDescriptor extenderInfo, Type receiverType, IExtenderProvider provider, Attribute[] attributes) { }

	// RVA: 0x2668190 Offset: 0x2666B90 VA: 0x182668190
	public void .ctor(PropertyDescriptor extender, Attribute[] attributes) { }

	// RVA: 0x2668080 Offset: 0x2666A80 VA: 0x182668080 Slot: 17
	public override bool CanResetValue(object comp) { }

	// RVA: 0x2668580 Offset: 0x2666F80 VA: 0x182668580 Slot: 13
	public override Type get_ComponentType() { }

	// RVA: 0x2668830 Offset: 0x2667230 VA: 0x182668830 Slot: 15
	public override bool get_IsReadOnly() { }

	// RVA: 0x2668930 Offset: 0x2667330 VA: 0x182668930 Slot: 16
	public override Type get_PropertyType() { }

	// RVA: 0x26685B0 Offset: 0x2666FB0 VA: 0x1826685B0 Slot: 9
	public override string get_DisplayName() { }

	// RVA: 0x26680B0 Offset: 0x2666AB0 VA: 0x1826680B0 Slot: 18
	public override object GetValue(object comp) { }

	// RVA: 0x26680E0 Offset: 0x2666AE0 VA: 0x1826680E0 Slot: 20
	public override void ResetValue(object comp) { }

	// RVA: 0x2668120 Offset: 0x2666B20 VA: 0x182668120 Slot: 21
	public override void SetValue(object component, object value) { }

	// RVA: 0x2668160 Offset: 0x2666B60 VA: 0x182668160 Slot: 22
	public override bool ShouldSerializeValue(object comp) { }
}
