internal sealed class ReflectTypeDescriptionProvider : TypeDescriptionProvider // TypeDefIndex: 9793
{
	// Fields
	private Hashtable _typeData; // 0x20
	private static Type[] _typeConstructor; // 0x0
	private static Hashtable _editorTables; // 0x8
	private static Hashtable _intrinsicTypeConverters; // 0x10
	private static object _intrinsicReferenceKey; // 0x18
	private static object _intrinsicNullableKey; // 0x20
	private static object _dictionaryKey; // 0x28
	private static Hashtable _propertyCache; // 0x30
	private static Hashtable _eventCache; // 0x38
	private static Hashtable _attributeCache; // 0x40
	private static Hashtable _extendedPropertyCache; // 0x48
	private static readonly Guid _extenderProviderKey; // 0x50
	private static readonly Guid _extenderPropertiesKey; // 0x60
	private static readonly Guid _extenderProviderPropertiesKey; // 0x70
	private static readonly Type[] _skipInterfaceAttributeList; // 0x80
	private static object _internalSyncObject; // 0x88

	// Properties
	private static Hashtable IntrinsicTypeConverters { get; }

	// Methods

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	internal void .ctor() { }

	// RVA: 0x26868B0 Offset: 0x26852B0 VA: 0x1826868B0
	private static Hashtable get_IntrinsicTypeConverters() { }

	// RVA: 0x2680A30 Offset: 0x267F430 VA: 0x182680A30
	internal static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	// RVA: 0x2680E00 Offset: 0x267F800 VA: 0x182680E00 Slot: 4
	public override object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x2680CF0 Offset: 0x267F6F0 VA: 0x182680CF0
	private static object CreateInstance(Type objectType, Type callingType) { }

	// RVA: 0x2681020 Offset: 0x267FA20 VA: 0x182681020
	internal AttributeCollection GetAttributes(Type type) { }

	// RVA: 0x2681050 Offset: 0x267FA50 VA: 0x182681050 Slot: 5
	public override IDictionary GetCache(object instance) { }

	// RVA: 0x2681250 Offset: 0x267FC50 VA: 0x182681250
	internal string GetClassName(Type type) { }

	// RVA: 0x2681290 Offset: 0x267FC90 VA: 0x182681290
	internal string GetComponentName(Type type, object instance) { }

	// RVA: 0x2681360 Offset: 0x267FD60 VA: 0x182681360
	internal TypeConverter GetConverter(Type type, object instance) { }

	// RVA: 0x26813A0 Offset: 0x267FDA0 VA: 0x1826813A0
	internal EventDescriptor GetDefaultEvent(Type type, object instance) { }

	// RVA: 0x26813E0 Offset: 0x267FDE0 VA: 0x1826813E0
	internal PropertyDescriptor GetDefaultProperty(Type type, object instance) { }

	// RVA: 0x2681910 Offset: 0x2680310 VA: 0x182681910
	internal object GetEditor(Type type, object instance, Type editorBaseType) { }

	// RVA: 0x2681420 Offset: 0x267FE20 VA: 0x182681420
	private static Hashtable GetEditorTable(Type editorBaseType) { }

	// RVA: 0x2681960 Offset: 0x2680360 VA: 0x182681960
	internal EventDescriptorCollection GetEvents(Type type) { }

	// RVA: 0x2681990 Offset: 0x2680390 VA: 0x182681990
	internal AttributeCollection GetExtendedAttributes(object instance) { }

	// RVA: 0x26819E0 Offset: 0x26803E0 VA: 0x1826819E0
	internal string GetExtendedClassName(object instance) { }

	// RVA: 0x2681A40 Offset: 0x2680440 VA: 0x182681A40
	internal string GetExtendedComponentName(object instance) { }

	// RVA: 0x2681A80 Offset: 0x2680480 VA: 0x182681A80
	internal TypeConverter GetExtendedConverter(object instance) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal EventDescriptor GetExtendedDefaultEvent(object instance) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal PropertyDescriptor GetExtendedDefaultProperty(object instance) { }

	// RVA: 0x2681AE0 Offset: 0x26804E0 VA: 0x182681AE0
	internal object GetExtendedEditor(object instance, Type editorBaseType) { }

	// RVA: 0x2681B50 Offset: 0x2680550 VA: 0x182681B50
	internal EventDescriptorCollection GetExtendedEvents(object instance) { }

	// RVA: 0x2681BA0 Offset: 0x26805A0 VA: 0x182681BA0
	internal PropertyDescriptorCollection GetExtendedProperties(object instance) { }

	// RVA: 0x2682120 Offset: 0x2680B20 VA: 0x182682120 Slot: 7
	protected internal override IExtenderProvider[] GetExtenderProviders(object instance) { }

	// RVA: 0x2682440 Offset: 0x2680E40 VA: 0x182682440
	private static IExtenderProvider[] GetExtenders(ICollection components, object instance, IDictionary cache) { }

	// RVA: 0x26820B0 Offset: 0x2680AB0 VA: 0x1826820B0
	internal object GetExtendedPropertyOwner(object instance, PropertyDescriptor pd) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 6
	public override ICustomTypeDescriptor GetExtendedTypeDescriptor(object instance) { }

	// RVA: 0x2682D60 Offset: 0x2681760 VA: 0x182682D60 Slot: 8
	public override string GetFullComponentName(object component) { }

	// RVA: 0x2682EA0 Offset: 0x26818A0 VA: 0x182682EA0
	internal Type[] GetPopulatedTypes(Module module) { }

	// RVA: 0x2683310 Offset: 0x2681D10 VA: 0x182683310
	internal PropertyDescriptorCollection GetProperties(Type type) { }

	// RVA: 0x2683340 Offset: 0x2681D40 VA: 0x182683340
	internal object GetPropertyOwner(Type type, object instance, PropertyDescriptor pd) { }

	// RVA: 0x499060 Offset: 0x497A60 VA: 0x180499060 Slot: 9
	public override Type GetReflectionType(Type objectType, object instance) { }

	// RVA: 0x26833A0 Offset: 0x2681DA0 VA: 0x1826833A0
	private ReflectTypeDescriptionProvider.ReflectedTypeData GetTypeData(Type type, bool createIfNeeded) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public override ICustomTypeDescriptor GetTypeDescriptor(Type objectType, object instance) { }

	// RVA: 0x2683640 Offset: 0x2682040 VA: 0x182683640
	private static Type GetTypeFromName(string typeName) { }

	// RVA: 0x2683730 Offset: 0x2682130 VA: 0x182683730
	internal bool IsPopulated(Type type) { }

	// RVA: 0x2683780 Offset: 0x2682180 VA: 0x182683780
	private static Attribute[] ReflectGetAttributes(Type type) { }

	// RVA: 0x2683C50 Offset: 0x2682650 VA: 0x182683C50
	internal static Attribute[] ReflectGetAttributes(MemberInfo member) { }

	// RVA: 0x2684120 Offset: 0x2682B20 VA: 0x182684120
	private static EventDescriptor[] ReflectGetEvents(Type type) { }

	// RVA: 0x2684830 Offset: 0x2683230 VA: 0x182684830
	private static PropertyDescriptor[] ReflectGetExtendedProperties(IExtenderProvider provider) { }

	// RVA: 0x2685570 Offset: 0x2683F70 VA: 0x182685570
	private static PropertyDescriptor[] ReflectGetProperties(Type type) { }

	// RVA: 0x2685C00 Offset: 0x2684600 VA: 0x182685C00
	internal void Refresh(Type type) { }

	// RVA: 0x2685C90 Offset: 0x2684690 VA: 0x182685C90
	private static object SearchIntrinsicTable(Hashtable table, Type callingType) { }

	// RVA: 0x2686490 Offset: 0x2684E90 VA: 0x182686490
	private static void .cctor() { }
}
