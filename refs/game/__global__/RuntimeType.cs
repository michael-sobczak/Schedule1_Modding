internal class RuntimeType : TypeInfo, ISerializable, ICloneable // TypeDefIndex: 3821
{
	// Fields
	internal static readonly RuntimeType ValueType; // 0x0
	internal static readonly RuntimeType EnumType; // 0x8
	private static readonly RuntimeType ObjectType; // 0x10
	private static readonly RuntimeType StringType; // 0x18
	private static readonly RuntimeType DelegateType; // 0x20
	private static Type[] s_SICtorParamTypes; // 0x28
	internal static Func<Type, Type[], Type> MakeTypeBuilderInstantiation; // 0x30
	private const BindingFlags MemberBindingMask = 255;
	private const BindingFlags InvocationMask = 65280;
	private const BindingFlags BinderNonCreateInstance = 15616;
	private const BindingFlags BinderGetSetProperty = 12288;
	private const BindingFlags BinderSetInvokeProperty = 8448;
	private const BindingFlags BinderGetSetField = 3072;
	private const BindingFlags BinderSetInvokeField = 2304;
	private const BindingFlags BinderNonFieldGetSet = 16773888;
	private const BindingFlags ClassicBindingMask = 61696;
	private static RuntimeType s_typedRef; // 0x38
	private MonoTypeInfo type_info; // 0x18
	internal object GenericCache; // 0x20
	private RuntimeConstructorInfo m_serializationCtor; // 0x28
	private const int GenericParameterCountAny = -1;

	// Properties
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override Type BaseType { get; }
	public override Type UnderlyingSystemType { get; }
	public override bool IsEnum { get; }
	public override GenericParameterAttributes GenericParameterAttributes { get; }
	internal override bool IsSzArray { get; }
	public override bool IsGenericTypeDefinition { get; }
	public override bool IsGenericParameter { get; }
	public override int GenericParameterPosition { get; }
	public override bool IsGenericType { get; }
	public override bool IsConstructedGenericType { get; }
	public override MemberTypes MemberType { get; }
	public override Type ReflectedType { get; }
	public override int MetadataToken { get; }
	public override bool ContainsGenericParameters { get; }
	public override MethodBase DeclaringMethod { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override string FullName { get; }
	public override bool IsSZArray { get; }

	// Methods

	// RVA: 0x1CB1BB0 Offset: 0x1CB05B0 VA: 0x181CB1BB0
	internal static RuntimeType GetType(string typeName, bool throwOnError, bool ignoreCase, bool reflectionOnly, ref StackCrawlMark stackMark) { }

	// RVA: 0x1CB5660 Offset: 0x1CB4060 VA: 0x181CB5660
	private static void ThrowIfTypeNeverValidGenericArgument(RuntimeType type) { }

	// RVA: 0x1CB52E0 Offset: 0x1CB3CE0 VA: 0x181CB52E0
	internal static void SanityCheckGenericArguments(RuntimeType[] genericArguments, RuntimeType[] genericParamters) { }

	// RVA: 0x1CB5550 Offset: 0x1CB3F50 VA: 0x181CB5550
	private static void SplitName(string fullname, out string name, out string ns) { }

	// RVA: 0x1CABDB0 Offset: 0x1CAA7B0 VA: 0x181CABDB0
	internal static BindingFlags FilterPreCalculate(bool isPublic, bool isInherited, bool isStatic) { }

	// RVA: 0x1CABC60 Offset: 0x1CAA660 VA: 0x181CABC60
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, bool allowPrefixLookup, out bool prefixLookup, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1CABB50 Offset: 0x1CAA550 VA: 0x181CABB50
	private static void FilterHelper(BindingFlags bindingFlags, ref string name, out bool ignoreCase, out RuntimeType.MemberListType listType) { }

	// RVA: 0x1CAB9B0 Offset: 0x1CAA3B0 VA: 0x181CAB9B0
	private static bool FilterApplyPrefixLookup(MemberInfo memberInfo, string name, bool ignoreCase) { }

	// RVA: 0x1CAB3C0 Offset: 0x1CA9DC0 VA: 0x181CAB3C0
	private static bool FilterApplyBase(MemberInfo memberInfo, BindingFlags bindingFlags, bool isPublic, bool isNonProtectedInternal, bool isStatic, string name, bool prefixLookup) { }

	// RVA: 0x1CABA30 Offset: 0x1CAA430 VA: 0x181CABA30
	private static bool FilterApplyType(Type type, BindingFlags bindingFlags, string name, bool prefixLookup, string ns) { }

	// RVA: 0x1CAB900 Offset: 0x1CAA300 VA: 0x181CAB900
	private static bool FilterApplyMethodInfo(RuntimeMethodInfo method, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1CAB5D0 Offset: 0x1CA9FD0 VA: 0x181CAB5D0
	private static bool FilterApplyConstructorInfo(RuntimeConstructorInfo constructor, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1CAB680 Offset: 0x1CAA080 VA: 0x181CAB680
	private static bool FilterApplyMethodBase(MethodBase methodBase, BindingFlags methodFlags, BindingFlags bindingFlags, CallingConventions callConv, Type[] argumentTypes) { }

	// RVA: 0x1CB5F90 Offset: 0x1CB4990 VA: 0x181CB5F90
	internal void .ctor() { }

	// RVA: 0x1CAF7E0 Offset: 0x1CAE1E0 VA: 0x181CAF7E0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, int genericParamCount, bool allowPrefixLookup) { }

	// RVA: 0x1CAC2B0 Offset: 0x1CAACB0 VA: 0x181CAC2B0
	private RuntimeType.ListBuilder<ConstructorInfo> GetConstructorCandidates(string name, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1CB1300 Offset: 0x1CAFD00 VA: 0x181CB1300
	private RuntimeType.ListBuilder<PropertyInfo> GetPropertyCandidates(string name, BindingFlags bindingAttr, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1CAD740 Offset: 0x1CAC140 VA: 0x181CAD740
	private RuntimeType.ListBuilder<EventInfo> GetEventCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1CADF20 Offset: 0x1CAC920 VA: 0x181CADF20
	private RuntimeType.ListBuilder<FieldInfo> GetFieldCandidates(string name, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1CB0380 Offset: 0x1CAED80 VA: 0x181CB0380
	private RuntimeType.ListBuilder<Type> GetNestedTypeCandidates(string fullname, BindingFlags bindingAttr, bool allowPrefixLookup) { }

	// RVA: 0x1CB02D0 Offset: 0x1CAECD0 VA: 0x181CB02D0 Slot: 102
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	[ComVisible(True)]
	// RVA: 0x1CACB60 Offset: 0x1CAB560 VA: 0x181CACB60 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1CB1270 Offset: 0x1CAFC70 VA: 0x181CB1270 Slot: 112
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1CADE80 Offset: 0x1CAC880 VA: 0x181CADE80 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x1CAE8F0 Offset: 0x1CAD2F0 VA: 0x181CAE8F0 Slot: 89
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1CAF1D0 Offset: 0x1CADBD0 VA: 0x181CAF1D0 Slot: 93
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1CAC680 Offset: 0x1CAB080 VA: 0x181CAC680 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1CB15F0 Offset: 0x1CAFFF0 VA: 0x181CB15F0 Slot: 110
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1CAD9F0 Offset: 0x1CAC3F0 VA: 0x181CAD9F0 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1CAE1D0 Offset: 0x1CACBD0 VA: 0x181CAE1D0 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1CB0790 Offset: 0x1CAF190 VA: 0x181CB0790 Slot: 103
	public override Type GetNestedType(string fullname, BindingFlags bindingAttr) { }

	// RVA: 0x1CAED30 Offset: 0x1CAD730 VA: 0x181CAED30 Slot: 92
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x1CB18E0 Offset: 0x1CB02E0 VA: 0x181CB18E0 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x1CB18E0 Offset: 0x1CB02E0 VA: 0x181CB18E0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x1CB18D0 Offset: 0x1CB02D0 VA: 0x181CB18D0 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x1CB18D0 Offset: 0x1CB02D0 VA: 0x181CB18D0
	internal RuntimeAssembly GetRuntimeAssembly() { }

	// RVA: 0x1CB6580 Offset: 0x1CB4F80 VA: 0x181CB6580 Slot: 113
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1CB48C0 Offset: 0x1CB32C0 VA: 0x181CB48C0 Slot: 118
	public override bool IsInstanceOfType(object o) { }

	// RVA: 0x1CB3300 Offset: 0x1CB1D00 VA: 0x181CB3300 Slot: 22
	public override bool IsAssignableFrom(Type c) { }

	// RVA: 0x1CB4810 Offset: 0x1CB3210 VA: 0x181CB4810 Slot: 119
	public override bool IsEquivalentTo(Type other) { }

	// RVA: 0x1CB6000 Offset: 0x1CB4A00 VA: 0x181CB6000 Slot: 115
	public override Type get_BaseType() { }

	// RVA: 0x1CAC030 Offset: 0x1CAAA30 VA: 0x181CAC030
	private RuntimeType GetBaseType() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1CAC020 Offset: 0x1CAAA20 VA: 0x181CAC020 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1CB3400 Offset: 0x1CB1E00 VA: 0x181CB3400 Slot: 68
	protected override bool IsContextfulImpl() { }

	// RVA: 0x1CB33E0 Offset: 0x1CB1DE0 VA: 0x181CB33E0 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x1CB48E0 Offset: 0x1CB32E0 VA: 0x181CB48E0 Slot: 74
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1CB48D0 Offset: 0x1CB32D0 VA: 0x181CB48D0 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x1CB33F0 Offset: 0x1CB1DF0 VA: 0x181CB33F0 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1CB49F0 Offset: 0x1CB33F0 VA: 0x181CB49F0 Slot: 76
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x1CB6400 Offset: 0x1CB4E00 VA: 0x181CB6400 Slot: 70
	public override bool get_IsEnum() { }

	// RVA: 0x1CB1C30 Offset: 0x1CB0630 VA: 0x181CB1C30 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1CB6260 Offset: 0x1CB4C60 VA: 0x181CB6260 Slot: 52
	public override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1CB6500 Offset: 0x1CB4F00 VA: 0x181CB6500 Slot: 128
	internal override bool get_IsSzArray() { }

	// RVA: 0x1CB32F0 Offset: 0x1CB1CF0 VA: 0x181CB32F0 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x1CABF90 Offset: 0x1CAA990 VA: 0x181CABF90 Slot: 47
	public override int GetArrayRank() { }

	// RVA: 0x1CAD0F0 Offset: 0x1CABAF0 VA: 0x181CAD0F0 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x1CAD340 Offset: 0x1CABD40 VA: 0x181CAD340 Slot: 18
	public override string[] GetEnumNames() { }

	// RVA: 0x1CAD570 Offset: 0x1CABF70 VA: 0x181CAD570 Slot: 121
	public override Array GetEnumValues() { }

	// RVA: 0x1CAD4A0 Offset: 0x1CABEA0 VA: 0x181CAD4A0 Slot: 120
	public override Type GetEnumUnderlyingType() { }

	// RVA: 0x1CB4210 Offset: 0x1CB2C10 VA: 0x181CB4210 Slot: 16
	public override bool IsEnumDefined(object value) { }

	// RVA: 0x1CAD100 Offset: 0x1CABB00 VA: 0x181CAD100 Slot: 17
	public override string GetEnumName(object value) { }

	// RVA: 0x1CAE990 Offset: 0x1CAD390 VA: 0x181CAE990
	internal RuntimeType[] GetGenericArgumentsInternal() { }

	// RVA: 0x1CAEA10 Offset: 0x1CAD410 VA: 0x181CAEA10 Slot: 50
	public override Type[] GetGenericArguments() { }

	// RVA: 0x1CB4BE0 Offset: 0x1CB35E0 VA: 0x181CB4BE0 Slot: 125
	public override Type MakeGenericType(Type[] instantiation) { }

	// RVA: 0x1CB6480 Offset: 0x1CB4E80 VA: 0x181CB6480 Slot: 41
	public override bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1CB6470 Offset: 0x1CB4E70 VA: 0x181CB6470 Slot: 38
	public override bool get_IsGenericParameter() { }

	// RVA: 0x1CB6320 Offset: 0x1CB4D20 VA: 0x181CB6320 Slot: 51
	public override int get_GenericParameterPosition() { }

	// RVA: 0x1CAEBC0 Offset: 0x1CAD5C0 VA: 0x181CAEBC0 Slot: 48
	public override Type GetGenericTypeDefinition() { }

	// RVA: 0x1CB6490 Offset: 0x1CB4E90 VA: 0x181CB6490 Slot: 40
	public override bool get_IsGenericType() { }

	// RVA: 0x1CB63B0 Offset: 0x1CB4DB0 VA: 0x181CB63B0 Slot: 37
	public override bool get_IsConstructedGenericType() { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1CB1C40 Offset: 0x1CB0640 VA: 0x181CB1C40 Slot: 116
	public override object InvokeMember(string name, BindingFlags bindingFlags, Binder binder, object target, object[] providedArgs, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParams) { }

	// RVA: 0x1CAB3B0 Offset: 0x1CA9DB0 VA: 0x181CAB3B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(RuntimeType left, RuntimeType right) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(RuntimeType left, RuntimeType right) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 135
	public object Clone() { }

	// RVA: 0x1CB0F50 Offset: 0x1CAF950 VA: 0x181CB0F50 Slot: 134
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1CACC10 Offset: 0x1CAB610 VA: 0x181CACC10 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1CACCB0 Offset: 0x1CAB6B0 VA: 0x181CACCB0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1CB4070 Offset: 0x1CB2A70 VA: 0x181CB4070 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1CABDF0 Offset: 0x1CAA7F0 VA: 0x181CABDF0 Slot: 129
	internal override string FormatTypeName(bool serialization) { }

	// RVA: 0x1CB6510 Offset: 0x1CB4F10 VA: 0x181CB6510 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x4BC030 Offset: 0x4BAA30 VA: 0x1804BC030 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1CB6550 Offset: 0x1CB4F50 VA: 0x181CB6550 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1CAA2D0 Offset: 0x1CA8CD0 VA: 0x181CAA2D0
	private void CreateInstanceCheckThis() { }

	// RVA: 0x1CAA7F0 Offset: 0x1CA91F0 VA: 0x181CAA7F0
	internal object CreateInstanceImpl(BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes, ref StackCrawlMark stackMark) { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1CAA580 Offset: 0x1CA8F80 VA: 0x181CAA580
	internal object CreateInstanceDefaultCtor(bool publicOnly, bool skipCheckThis, bool fillCache, bool wrapExceptions, ref StackCrawlMark stackMark) { }

	// RVA: 0x1CACE50 Offset: 0x1CAB850 VA: 0x181CACE50
	internal RuntimeConstructorInfo GetDefaultConstructor() { }

	// RVA: 0x1CAD000 Offset: 0x1CABA00 VA: 0x181CAD000
	private string GetDefaultMemberName() { }

	// RVA: 0x1CB18F0 Offset: 0x1CB02F0 VA: 0x181CB18F0
	internal RuntimeConstructorInfo GetSerializationCtor() { }

	// RVA: 0x1CAB360 Offset: 0x1CA9D60 VA: 0x181CAB360
	internal object CreateInstanceSlow(bool publicOnly, bool wrapExceptions, bool skipCheckThis, bool fillCache) { }

	// RVA: 0x1CAB070 Offset: 0x1CA9A70 VA: 0x181CAB070
	private object CreateInstanceMono(bool nonPublic, bool wrapExceptions) { }

	// RVA: 0x1CAA0B0 Offset: 0x1CA8AB0 VA: 0x181CAA0B0
	internal object CheckValue(object value, Binder binder, CultureInfo culture, BindingFlags invokeAttr) { }

	// RVA: 0x1CB57D0 Offset: 0x1CB41D0 VA: 0x181CB57D0
	private object TryConvertToType(object value, ref bool failed) { }

	// RVA: 0x1CB3410 Offset: 0x1CB1E10 VA: 0x181CB3410
	private static object IsConvertibleToPrimitiveType(object value, Type targetType) { }

	// RVA: 0x1CAC240 Offset: 0x1CAAC40 VA: 0x181CAC240
	private string GetCachedName(TypeNameKind kind) { }

	// RVA: 0x1CB65B0 Offset: 0x1CB4FB0 VA: 0x181CB65B0
	private Type make_array_type(int rank) { }

	// RVA: 0x1CB4B00 Offset: 0x1CB3500 VA: 0x181CB4B00 Slot: 122
	public override Type MakeArrayType() { }

	// RVA: 0x1CB4B10 Offset: 0x1CB3510 VA: 0x181CB4B10 Slot: 123
	public override Type MakeArrayType(int rank) { }

	// RVA: 0x1CB65C0 Offset: 0x1CB4FC0 VA: 0x181CB65C0
	private Type make_byref_type() { }

	// RVA: 0x1CB4B70 Offset: 0x1CB3570 VA: 0x181CB4B70 Slot: 124
	public override Type MakeByRefType() { }

	// RVA: 0x1CB51F0 Offset: 0x1CB3BF0 VA: 0x181CB51F0
	private static Type MakePointerType(Type type) { }

	// RVA: 0x1CB5200 Offset: 0x1CB3C00 VA: 0x181CB5200 Slot: 126
	public override Type MakePointerType() { }

	// RVA: 0x1CB6010 Offset: 0x1CB4A10 VA: 0x181CB6010 Slot: 20
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x1CAEAA0 Offset: 0x1CAD4A0 VA: 0x181CAEAA0 Slot: 53
	public override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x1CAA6B0 Offset: 0x1CA90B0 VA: 0x181CAA6B0
	internal static object CreateInstanceForAnotherGenericParameter(Type genericType, RuntimeType genericArgument) { }

	// RVA: 0x1CB51E0 Offset: 0x1CB3BE0 VA: 0x181CB51E0
	private static Type MakeGenericType(Type gt, Type[] types) { }

	// RVA: 0x1CB02C0 Offset: 0x1CAECC0 VA: 0x181CB02C0
	internal IntPtr GetMethodsByName_native(IntPtr namePtr, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x1CB0020 Offset: 0x1CAEA20 VA: 0x181CB0020
	internal RuntimeMethodInfo[] GetMethodsByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x1CB1260 Offset: 0x1CAFC60 VA: 0x181CB1260
	private IntPtr GetPropertiesByName_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x1CACC00 Offset: 0x1CAB600 VA: 0x181CACC00
	private IntPtr GetConstructors_native(BindingFlags bindingAttr) { }

	// RVA: 0x1CAC930 Offset: 0x1CAB330 VA: 0x181CAC930
	private RuntimeConstructorInfo[] GetConstructors_internal(BindingFlags bindingAttr, RuntimeType reflectedType) { }

	// RVA: 0x1CB0FC0 Offset: 0x1CAF9C0 VA: 0x181CB0FC0
	private RuntimePropertyInfo[] GetPropertiesByName(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x1CB1B60 Offset: 0x1CB0560 VA: 0x181CB1B60 Slot: 114
	protected override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x1CB1B50 Offset: 0x1CB0550 VA: 0x181CB1B50
	private static TypeCode GetTypeCodeImplInternal(Type type) { }

	// RVA: 0x1CB57C0 Offset: 0x1CB41C0 VA: 0x181CB57C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	private bool IsGenericCOMObjectImpl() { }

	// RVA: 0x1CAB060 Offset: 0x1CA9A60 VA: 0x181CAB060
	private static object CreateInstanceInternal(Type type) { }

	// RVA: 0x1CB6130 Offset: 0x1CB4B30 VA: 0x181CB6130 Slot: 29
	public override MethodBase get_DeclaringMethod() { }

	// RVA: 0x1CB5FE0 Offset: 0x1CB49E0 VA: 0x181CB5FE0
	internal string getFullName(bool full_name, bool assembly_qualified) { }

	// RVA: 0x1CAEA00 Offset: 0x1CAD400 VA: 0x181CAEA00
	private Type[] GetGenericArgumentsInternal(bool runtimeArray) { }

	// RVA: 0x1CAEA60 Offset: 0x1CAD460 VA: 0x181CAEA60
	private GenericParameterAttributes GetGenericParameterAttributes() { }

	// RVA: 0x1CAEBB0 Offset: 0x1CAD5B0 VA: 0x181CAEBB0
	private int GetGenericParameterPosition() { }

	// RVA: 0x1CADF10 Offset: 0x1CAC910 VA: 0x181CADF10
	private IntPtr GetEvents_native(IntPtr name, RuntimeType.MemberListType listType) { }

	// RVA: 0x1CAE980 Offset: 0x1CAD380 VA: 0x181CAE980
	private IntPtr GetFields_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x1CAE650 Offset: 0x1CAD050 VA: 0x181CAE650
	private RuntimeFieldInfo[] GetFields_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x1CADC70 Offset: 0x1CAC670 VA: 0x181CADC70
	private RuntimeEventInfo[] GetEvents_internal(string name, BindingFlags bindingAttr, RuntimeType.MemberListType listType, RuntimeType reflectedType) { }

	// RVA: 0x1CAED20 Offset: 0x1CAD720 VA: 0x181CAED20 Slot: 117
	public override Type[] GetInterfaces() { }

	// RVA: 0x1CB0F40 Offset: 0x1CAF940 VA: 0x181CB0F40
	private IntPtr GetNestedTypes_native(IntPtr name, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x1CB0BF0 Offset: 0x1CAF5F0 VA: 0x181CB0BF0
	private RuntimeType[] GetNestedTypes_internal(string displayName, BindingFlags bindingAttr, RuntimeType.MemberListType listType) { }

	// RVA: 0x1CB5FF0 Offset: 0x1CB49F0 VA: 0x181CB5FF0 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x1CB6140 Offset: 0x1CB4B40 VA: 0x181CB6140 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1CB6560 Offset: 0x1CB4F60 VA: 0x181CB6560 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1CB6570 Offset: 0x1CB4F70 VA: 0x181CB6570 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x1CAEC50 Offset: 0x1CAD650 VA: 0x181CAEC50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1CB6150 Offset: 0x1CB4B50 VA: 0x181CB6150 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x1CB64A0 Offset: 0x1CB4EA0 VA: 0x181CB64A0 Slot: 42
	public override bool get_IsSZArray() { }

	[ComVisible(True)]
	// RVA: 0x1CB48F0 Offset: 0x1CB32F0 VA: 0x181CB48F0 Slot: 21
	public override bool IsSubclassOf(Type type) { }

	// RVA: 0x1CAFFD0 Offset: 0x1CAE9D0 VA: 0x181CAFFD0 Slot: 100
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1CAFB20 Offset: 0x1CAE520 VA: 0x181CAFB20
	private MethodInfo GetMethodImplCommon(string name, int genericParameterCount, BindingFlags bindingAttr, Binder binder, CallingConventions callConv, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1CAF4E0 Offset: 0x1CADEE0 VA: 0x181CAF4E0
	private RuntimeType.ListBuilder<MethodInfo> GetMethodCandidates(string name, int genericParameterCount, BindingFlags bindingAttr, CallingConventions callConv, Type[] types, bool allowPrefixLookup) { }

	// RVA: 0x1CB5A70 Offset: 0x1CB4470 VA: 0x181CB5A70
	private static void .cctor() { }
}
