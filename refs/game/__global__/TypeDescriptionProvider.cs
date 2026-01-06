public abstract class TypeDescriptionProvider // TypeDefIndex: 9759
{
	// Fields
	private readonly TypeDescriptionProvider _parent; // 0x10
	private TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor; // 0x18

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x470220 Offset: 0x46EC20 VA: 0x180470220
	protected void .ctor(TypeDescriptionProvider parent) { }

	// RVA: 0x2678A80 Offset: 0x2677480 VA: 0x182678A80 Slot: 4
	public virtual object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x2678BA0 Offset: 0x26775A0 VA: 0x182678BA0 Slot: 5
	public virtual IDictionary GetCache(object instance) { }

	// RVA: 0x2678BC0 Offset: 0x26775C0 VA: 0x182678BC0 Slot: 6
	public virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x2678C70 Offset: 0x2677670 VA: 0x182678C70 Slot: 7
	protected internal virtual IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x2678D40 Offset: 0x2677740 VA: 0x182678D40 Slot: 8
	public virtual string GetFullComponentName(object component) { }

	// RVA: 0x1A809B0 Offset: 0x1A7F3B0 VA: 0x181A809B0
	public Type GetReflectionType(Type objectType) { }

	// RVA: 0x2678E70 Offset: 0x2677870 VA: 0x182678E70
	public Type GetReflectionType(object instance) { }

	// RVA: 0x2678E40 Offset: 0x2677840 VA: 0x182678E40 Slot: 9
	public virtual Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x2679050 Offset: 0x2677A50 VA: 0x182679050
	public ICustomTypeDescriptor GetTypeDescriptor(Type objectType) { }

	// RVA: 0x2678FC0 Offset: 0x26779C0 VA: 0x182678FC0
	public ICustomTypeDescriptor GetTypeDescriptor(object instance) { }

	// RVA: 0x2678F00 Offset: 0x2677900 VA: 0x182678F00 Slot: 10
	public virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }
}
