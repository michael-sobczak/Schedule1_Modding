internal sealed class DelegatingTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 9706
{
	// Fields
	private readonly Type _type; // 0x20

	// Properties
	internal TypeDescriptionProvider Provider { get; }

	// Methods

	// RVA: 0xBA33B0 Offset: 0xBA1DB0 VA: 0x180BA33B0
	internal void .ctor(Type type) { }

	// RVA: 0x26642A0 Offset: 0x2662CA0 VA: 0x1826642A0
	internal TypeDescriptionProvider get_Provider() { }

	// RVA: 0x2663ED0 Offset: 0x26628D0 VA: 0x182663ED0 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x2663F80 Offset: 0x2662980 VA: 0x182663F80 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x2664100 Offset: 0x2662B00 VA: 0x182664100 Slot: 8
	public override string GetFullComponentName(object component) { }

	// RVA: 0x2664000 Offset: 0x2662A00 VA: 0x182664000 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x2664080 Offset: 0x2662A80 VA: 0x182664080 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x2664180 Offset: 0x2662B80 VA: 0x182664180 Slot: 9
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x2664210 Offset: 0x2662C10 VA: 0x182664210 Slot: 10
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}
