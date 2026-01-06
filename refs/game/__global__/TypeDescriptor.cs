public sealed class TypeDescriptor // TypeDefIndex: 9813
{
	// Fields
	private static WeakHashtable _providerTable; // 0x0
	private static Hashtable _providerTypeTable; // 0x8
	private static Hashtable _defaultProviders; // 0x10
	private static WeakHashtable _associationTable; // 0x18
	private static int _metadataVersion; // 0x20
	private static int _collisionIndex; // 0x24
	private static BooleanSwitch TraceDescriptor; // 0x28
	private const int PIPELINE_ATTRIBUTES = 0;
	private const int PIPELINE_PROPERTIES = 1;
	private const int PIPELINE_EVENTS = 2;
	private static readonly Guid[] _pipelineInitializeKeys; // 0x30
	private static readonly Guid[] _pipelineMergeKeys; // 0x38
	private static readonly Guid[] _pipelineFilterKeys; // 0x40
	private static readonly Guid[] _pipelineAttributeFilterKeys; // 0x48
	private static object _internalSyncObject; // 0x50
	[CompilerGenerated]
	private static RefreshEventHandler Refreshed; // 0x58

	// Properties
	[Obsolete("This property has been deprecated.  Use a type description provider to supply type information for COM types instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
	public static IComNativeDescriptorHandler ComNativeDescriptorHandler { get; set; }
	[EditorBrowsable(2)]
	public static Type ComObjectType { get; }
	[EditorBrowsable(2)]
	public static Type InterfaceType { get; }
	internal static int MetadataVersion { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x2698240 Offset: 0x2696C40 VA: 0x182698240
	public static IComNativeDescriptorHandler get_ComNativeDescriptorHandler() { }

	// RVA: 0x2698580 Offset: 0x2696F80 VA: 0x182698580
	public static void set_ComNativeDescriptorHandler(IComNativeDescriptorHandler value) { }

	// RVA: 0x2698370 Offset: 0x2696D70 VA: 0x182698370
	public static Type get_ComObjectType() { }

	// RVA: 0x26983D0 Offset: 0x2696DD0 VA: 0x1826983D0
	public static Type get_InterfaceType() { }

	// RVA: 0x2698430 Offset: 0x2696E30 VA: 0x182698430
	internal static int get_MetadataVersion() { }

	[CompilerGenerated]
	// RVA: 0x2698140 Offset: 0x2696B40 VA: 0x182698140
	public static void add_Refreshed(RefreshEventHandler value) { }

	[CompilerGenerated]
	// RVA: 0x2698480 Offset: 0x2696E80 VA: 0x182698480
	public static void remove_Refreshed(RefreshEventHandler value) { }

	[EditorBrowsable(2)]
	// RVA: 0x268D280 Offset: 0x268BC80 VA: 0x18268D280
	public static TypeDescriptionProvider AddAttributes(Type type, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x268D4C0 Offset: 0x268BEC0 VA: 0x18268D4C0
	public static TypeDescriptionProvider AddAttributes(object instance, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x268D650 Offset: 0x268C050 VA: 0x18268D650
	public static void AddEditorTable(Type editorBaseType, Hashtable table) { }

	[EditorBrowsable(2)]
	// RVA: 0x268DBD0 Offset: 0x268C5D0 VA: 0x18268DBD0
	public static void AddProvider(TypeDescriptionProvider provider, Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x268D8E0 Offset: 0x268C2E0 VA: 0x18268D8E0
	public static void AddProvider(TypeDescriptionProvider provider, object instance) { }

	[EditorBrowsable(2)]
	// RVA: 0x268D7B0 Offset: 0x268C1B0 VA: 0x18268D7B0
	public static void AddProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x268D6B0 Offset: 0x268C0B0 VA: 0x18268D6B0
	public static void AddProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x268DE90 Offset: 0x268C890 VA: 0x18268DE90
	private static void CheckDefaultProvider(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x268E660 Offset: 0x268D060 VA: 0x18268E660
	public static void CreateAssociation(object primary, object secondary) { }

	// RVA: 0x268EDE0 Offset: 0x268D7E0 VA: 0x18268EDE0
	public static IDesigner CreateDesigner(IComponent component, Type designerBaseType) { }

	// RVA: 0x268F150 Offset: 0x268DB50 VA: 0x18268F150
	public static EventDescriptor CreateEvent(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x268F1E0 Offset: 0x268DBE0 VA: 0x18268F1E0
	public static EventDescriptor CreateEvent(Type componentType, EventDescriptor oldEventDescriptor, Attribute[] attributes) { }

	// RVA: 0x268F260 Offset: 0x268DC60 VA: 0x18268F260
	public static object CreateInstance(IServiceProvider provider, Type objectType, Type[] argTypes, object[] args) { }

	// RVA: 0x268F710 Offset: 0x268E110 VA: 0x18268F710
	public static PropertyDescriptor CreateProperty(Type componentType, string name, Type type, Attribute[] attributes) { }

	// RVA: 0x268F530 Offset: 0x268DF30 VA: 0x18268F530
	public static PropertyDescriptor CreateProperty(Type componentType, PropertyDescriptor oldPropertyDescriptor, Attribute[] attributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(Type type, AttributeCollection attributes, AttributeCollection debugAttributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(AttributeCollection attributes, AttributeCollection debugAttributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(AttributeCollection attributes, Type type) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(AttributeCollection attributes, object instance, bool noCustomTypeDesc) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(TypeConverter converter, Type type) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(TypeConverter converter, object instance, bool noCustomTypeDesc) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(EventDescriptorCollection events, Type type, Attribute[] attributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(EventDescriptorCollection events, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(PropertyDescriptorCollection properties, Type type, Attribute[] attributes) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private static void DebugValidate(PropertyDescriptorCollection properties, object instance, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x268F7A0 Offset: 0x268E1A0 VA: 0x18268F7A0
	private static ArrayList FilterMembers(IList members, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x268F9F0 Offset: 0x268E3F0 VA: 0x18268F9F0
	public static object GetAssociation(Type type, object primary) { }

	// RVA: 0x2690220 Offset: 0x268EC20 VA: 0x182690220
	public static AttributeCollection GetAttributes(Type componentType) { }

	// RVA: 0x26901D0 Offset: 0x268EBD0 VA: 0x1826901D0
	public static AttributeCollection GetAttributes(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x268FED0 Offset: 0x268E8D0 VA: 0x18268FED0
	public static AttributeCollection GetAttributes(object component, bool noCustomTypeDesc) { }

	// RVA: 0x2690310 Offset: 0x268ED10 VA: 0x182690310
	internal static IDictionary GetCache(object instance) { }

	// RVA: 0x2690450 Offset: 0x268EE50 VA: 0x182690450
	public static string GetClassName(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x26903C0 Offset: 0x268EDC0 VA: 0x1826903C0
	public static string GetClassName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x2690500 Offset: 0x268EF00 VA: 0x182690500
	public static string GetClassName(Type componentType) { }

	// RVA: 0x2690590 Offset: 0x268EF90 VA: 0x182690590
	public static string GetComponentName(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x2690640 Offset: 0x268F040 VA: 0x182690640
	public static string GetComponentName(object component, bool noCustomTypeDesc) { }

	// RVA: 0x26907F0 Offset: 0x268F1F0 VA: 0x1826907F0
	public static TypeConverter GetConverter(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x26906D0 Offset: 0x268F0D0 VA: 0x1826906D0
	public static TypeConverter GetConverter(object component, bool noCustomTypeDesc) { }

	// RVA: 0x2690760 Offset: 0x268F160 VA: 0x182690760
	public static TypeConverter GetConverter(Type type) { }

	// RVA: 0x268E530 Offset: 0x268CF30 VA: 0x18268E530
	private static object ConvertFromInvariantString(Type type, string stringValue) { }

	// RVA: 0x2690940 Offset: 0x268F340 VA: 0x182690940
	public static EventDescriptor GetDefaultEvent(Type componentType) { }

	// RVA: 0x2690A10 Offset: 0x268F410 VA: 0x182690A10
	public static EventDescriptor GetDefaultEvent(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x26908A0 Offset: 0x268F2A0 VA: 0x1826908A0
	public static EventDescriptor GetDefaultEvent(object component, bool noCustomTypeDesc) { }

	// RVA: 0x2690C30 Offset: 0x268F630 VA: 0x182690C30
	public static PropertyDescriptor GetDefaultProperty(Type componentType) { }

	// RVA: 0x2690AD0 Offset: 0x268F4D0 VA: 0x182690AD0
	public static PropertyDescriptor GetDefaultProperty(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x2690B90 Offset: 0x268F590 VA: 0x182690B90
	public static PropertyDescriptor GetDefaultProperty(object component, bool noCustomTypeDesc) { }

	// RVA: 0x2690F70 Offset: 0x268F970 VA: 0x182690F70
	internal static ICustomTypeDescriptor GetDescriptor(Type type, string typeName) { }

	// RVA: 0x2690D00 Offset: 0x268F700 VA: 0x182690D00
	internal static ICustomTypeDescriptor GetDescriptor(object component, bool noCustomTypeDesc) { }

	// RVA: 0x2691B90 Offset: 0x2690590 VA: 0x182691B90
	internal static ICustomTypeDescriptor GetExtendedDescriptor(object component) { }

	// RVA: 0x2691090 Offset: 0x268FA90 VA: 0x182691090
	public static object GetEditor(object component, Type editorBaseType) { }

	[EditorBrowsable(2)]
	// RVA: 0x26911D0 Offset: 0x268FBD0 VA: 0x1826911D0
	public static object GetEditor(object component, Type editorBaseType, bool noCustomTypeDesc) { }

	// RVA: 0x26912F0 Offset: 0x268FCF0 VA: 0x1826912F0
	public static object GetEditor(Type type, Type editorBaseType) { }

	// RVA: 0x2691780 Offset: 0x2690180 VA: 0x182691780
	public static EventDescriptorCollection GetEvents(Type componentType) { }

	// RVA: 0x2691920 Offset: 0x2690320 VA: 0x182691920
	public static EventDescriptorCollection GetEvents(Type componentType, Attribute[] attributes) { }

	// RVA: 0x2691870 Offset: 0x2690270 VA: 0x182691870
	public static EventDescriptorCollection GetEvents(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x2691B30 Offset: 0x2690530 VA: 0x182691B30
	public static EventDescriptorCollection GetEvents(object component, bool noCustomTypeDesc) { }

	// RVA: 0x26918C0 Offset: 0x26902C0 VA: 0x1826918C0
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x2691410 Offset: 0x268FE10 VA: 0x182691410
	public static EventDescriptorCollection GetEvents(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x2691C80 Offset: 0x2690680 VA: 0x182691C80
	private static string GetExtenderCollisionSuffix(MemberDescriptor member) { }

	// RVA: 0x2691EC0 Offset: 0x26908C0 VA: 0x182691EC0
	public static string GetFullComponentName(object component) { }

	// RVA: 0x2691FB0 Offset: 0x26909B0 VA: 0x182691FB0
	private static Type GetNodeForBaseType(Type searchType) { }

	// RVA: 0x2692520 Offset: 0x2690F20 VA: 0x182692520
	public static PropertyDescriptorCollection GetProperties(Type componentType) { }

	// RVA: 0x2692610 Offset: 0x2691010 VA: 0x182692610
	public static PropertyDescriptorCollection GetProperties(Type componentType, Attribute[] attributes) { }

	// RVA: 0x26929B0 Offset: 0x26913B0 VA: 0x1826929B0
	public static PropertyDescriptorCollection GetProperties(object component) { }

	[EditorBrowsable(2)]
	// RVA: 0x2692820 Offset: 0x2691220 VA: 0x182692820
	public static PropertyDescriptorCollection GetProperties(object component, bool noCustomTypeDesc) { }

	// RVA: 0x2692890 Offset: 0x2691290 VA: 0x182692890
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes) { }

	// RVA: 0x2692930 Offset: 0x2691330 VA: 0x182692930
	public static PropertyDescriptorCollection GetProperties(object component, Attribute[] attributes, bool noCustomTypeDesc) { }

	// RVA: 0x2692130 Offset: 0x2690B30 VA: 0x182692130
	private static PropertyDescriptorCollection GetPropertiesImpl(object component, Attribute[] attributes, bool noCustomTypeDesc, bool noAttributes) { }

	[EditorBrowsable(2)]
	// RVA: 0x2692B30 Offset: 0x2691530 VA: 0x182692B30
	public static TypeDescriptionProvider GetProvider(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x2692A90 Offset: 0x2691490 VA: 0x182692A90
	public static TypeDescriptionProvider GetProvider(object instance) { }

	// RVA: 0x2692A40 Offset: 0x2691440 VA: 0x182692A40
	internal static TypeDescriptionProvider GetProviderRecursive(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x2692CF0 Offset: 0x26916F0 VA: 0x182692CF0
	public static Type GetReflectionType(Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x2692C00 Offset: 0x2691600 VA: 0x182692C00
	public static Type GetReflectionType(object instance) { }

	// RVA: 0x2693030 Offset: 0x2691A30 VA: 0x182693030
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type) { }

	// RVA: 0x2693080 Offset: 0x2691A80 VA: 0x182693080
	private static TypeDescriptor.TypeDescriptionNode NodeFor(Type type, bool createDelegator) { }

	// RVA: 0x2692FE0 Offset: 0x26919E0 VA: 0x182692FE0
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance) { }

	// RVA: 0x2692E10 Offset: 0x2691810 VA: 0x182692E10
	private static TypeDescriptor.TypeDescriptionNode NodeFor(object instance, bool createDelegator) { }

	// RVA: 0x2693620 Offset: 0x2692020 VA: 0x182693620
	private static void NodeRemove(object key, TypeDescriptionProvider provider) { }

	// RVA: 0x2693A00 Offset: 0x2692400 VA: 0x182693A00
	private static ICollection PipelineAttributeFilter(int pipelineType, ICollection members, Attribute[] filter, object instance, IDictionary cache) { }

	// RVA: 0x2693E90 Offset: 0x2692890 VA: 0x182693E90
	private static ICollection PipelineFilter(int pipelineType, ICollection members, object instance, IDictionary cache) { }

	// RVA: 0x2694EF0 Offset: 0x26938F0 VA: 0x182694EF0
	private static ICollection PipelineInitialize(int pipelineType, ICollection members, IDictionary cache) { }

	// RVA: 0x26952C0 Offset: 0x2693CC0 VA: 0x1826952C0
	private static ICollection PipelineMerge(int pipelineType, ICollection primary, ICollection secondary, object instance, IDictionary cache) { }

	// RVA: 0x2695CD0 Offset: 0x26946D0 VA: 0x182695CD0
	private static void RaiseRefresh(object component) { }

	// RVA: 0x2695D80 Offset: 0x2694780 VA: 0x182695D80
	private static void RaiseRefresh(Type type) { }

	// RVA: 0x2696300 Offset: 0x2694D00 VA: 0x182696300
	public static void Refresh(object component) { }

	// RVA: 0x2696B40 Offset: 0x2695540 VA: 0x182696B40
	private static void Refresh(object component, bool refreshReflectionProvider) { }

	// RVA: 0x2695E30 Offset: 0x2694830 VA: 0x182695E30
	public static void Refresh(Type type) { }

	// RVA: 0x2696410 Offset: 0x2694E10 VA: 0x182696410
	public static void Refresh(Module module) { }

	// RVA: 0x2696350 Offset: 0x2694D50 VA: 0x182696350
	public static void Refresh(Assembly assembly) { }

	[EditorBrowsable(2)]
	// RVA: 0x26971D0 Offset: 0x2695BD0 VA: 0x1826971D0
	public static void RemoveAssociation(object primary, object secondary) { }

	[EditorBrowsable(2)]
	// RVA: 0x26974B0 Offset: 0x2695EB0 VA: 0x1826974B0
	public static void RemoveAssociations(object primary) { }

	[EditorBrowsable(2)]
	// RVA: 0x26979C0 Offset: 0x26963C0 VA: 0x1826979C0
	public static void RemoveProvider(TypeDescriptionProvider provider, Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x26978B0 Offset: 0x26962B0 VA: 0x1826978B0
	public static void RemoveProvider(TypeDescriptionProvider provider, object instance) { }

	[EditorBrowsable(2)]
	// RVA: 0x26976C0 Offset: 0x26960C0 VA: 0x1826976C0
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, Type type) { }

	[EditorBrowsable(2)]
	// RVA: 0x2697580 Offset: 0x2695F80 VA: 0x182697580
	public static void RemoveProviderTransparent(TypeDescriptionProvider provider, object instance) { }

	// RVA: 0x2697AF0 Offset: 0x26964F0 VA: 0x182697AF0
	private static bool ShouldHideMember(MemberDescriptor member, Attribute attribute) { }

	// RVA: 0x2697BB0 Offset: 0x26965B0 VA: 0x182697BB0
	public static void SortDescriptorArray(IList infos) { }

	[Conditional("DEBUG")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	internal static void Trace(string message, object[] args) { }

	// RVA: 0x2697C80 Offset: 0x2696680 VA: 0x182697C80
	private static void .cctor() { }
}
