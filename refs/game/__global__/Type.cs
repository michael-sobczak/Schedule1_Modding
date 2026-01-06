public abstract class Type : MemberInfo // TypeDefIndex: 3744
{
	// Fields
	private static Binder s_defaultBinder; // 0x0
	public static readonly char Delimiter; // 0x8
	public static readonly Type[] EmptyTypes; // 0x10
	public static readonly object Missing; // 0x18
	public static readonly MemberFilter FilterAttribute; // 0x20
	public static readonly MemberFilter FilterName; // 0x28
	public static readonly MemberFilter FilterNameIgnoreCase; // 0x30
	private const BindingFlags DefaultLookup = 28;
	internal RuntimeTypeHandle _impl; // 0x10
	internal const string DefaultTypeNameWhenMissingMetadata = "UnknownType";

	// Properties
	public virtual bool IsSerializable { get; }
	public virtual bool ContainsGenericParameters { get; }
	public bool IsVisible { get; }
	public override MemberTypes MemberType { get; }
	public abstract string Namespace { get; }
	public abstract string AssemblyQualifiedName { get; }
	public abstract string FullName { get; }
	public abstract Assembly Assembly { get; }
	public abstract Module Module { get; }
	public bool IsNested { get; }
	public override Type DeclaringType { get; }
	public virtual MethodBase DeclaringMethod { get; }
	public override Type ReflectedType { get; }
	public abstract Type UnderlyingSystemType { get; }
	public bool IsArray { get; }
	public bool IsByRef { get; }
	public bool IsPointer { get; }
	public virtual bool IsConstructedGenericType { get; }
	public virtual bool IsGenericParameter { get; }
	public virtual bool IsGenericMethodParameter { get; }
	public virtual bool IsGenericType { get; }
	public virtual bool IsGenericTypeDefinition { get; }
	public virtual bool IsSZArray { get; }
	public virtual bool IsVariableBoundArray { get; }
	public bool HasElementType { get; }
	public virtual Type[] GenericTypeArguments { get; }
	public virtual int GenericParameterPosition { get; }
	public virtual GenericParameterAttributes GenericParameterAttributes { get; }
	public TypeAttributes Attributes { get; }
	public bool IsAbstract { get; }
	public bool IsSealed { get; }
	public bool IsClass { get; }
	public bool IsNestedAssembly { get; }
	public bool IsNestedPublic { get; }
	public bool IsNotPublic { get; }
	public bool IsPublic { get; }
	public bool IsExplicitLayout { get; }
	public bool IsLayoutSequential { get; }
	public bool IsCOMObject { get; }
	public bool IsContextful { get; }
	public virtual bool IsCollectible { get; }
	public virtual bool IsEnum { get; }
	public bool IsMarshalByRef { get; }
	public bool IsPrimitive { get; }
	public bool IsValueType { get; }
	public virtual bool IsSignatureType { get; }
	public virtual RuntimeTypeHandle TypeHandle { get; }
	public abstract Type BaseType { get; }
	public static Binder DefaultBinder { get; }
	internal virtual bool IsSzArray { get; }
	public bool IsInterface { get; }
	internal string FullNameOrDefault { get; }
	internal string InternalNameIfAvailable { get; }
	internal string NameOrDefault { get; }

	// Methods

	// RVA: 0x1C8FAB0 Offset: 0x1C8E4B0 VA: 0x181C8FAB0 Slot: 16
	public virtual bool IsEnumDefined(object value) { }

	// RVA: 0x1C8DAF0 Offset: 0x1C8C4F0 VA: 0x181C8DAF0 Slot: 17
	public virtual string GetEnumName(object value) { }

	// RVA: 0x1C8DED0 Offset: 0x1C8C8D0 VA: 0x181C8DED0 Slot: 18
	public virtual string[] GetEnumNames() { }

	// RVA: 0x1C8DF80 Offset: 0x1C8C980 VA: 0x181C8DF80
	private Array GetEnumRawConstantValues() { }

	// RVA: 0x1C8D6A0 Offset: 0x1C8C0A0 VA: 0x181C8D6A0
	private void GetEnumData(out string[] enumNames, out Array enumValues) { }

	// RVA: 0x1C8C740 Offset: 0x1C8B140 VA: 0x181C8C740
	private static int BinarySearch(Array array, object value) { }

	// RVA: 0x1C90100 Offset: 0x1C8EB00 VA: 0x181C90100
	internal static bool IsIntegerType(Type t) { }

	// RVA: 0x1C914A0 Offset: 0x1C8FEA0 VA: 0x181C914A0 Slot: 19
	public virtual bool get_IsSerializable() { }

	// RVA: 0x1C90B50 Offset: 0x1C8F550 VA: 0x181C90B50 Slot: 20
	public virtual bool get_ContainsGenericParameters() { }

	// RVA: 0x1C8F230 Offset: 0x1C8DC30 VA: 0x181C8F230
	internal Type GetRootElementType() { }

	// RVA: 0x1C916F0 Offset: 0x1C900F0 VA: 0x181C916F0
	public bool get_IsVisible() { }

	[ComVisible(True)]
	// RVA: 0x1C90580 Offset: 0x1C8EF80 VA: 0x181C90580 Slot: 21
	public virtual bool IsSubclassOf(Type c) { }

	// RVA: 0x1C8F830 Offset: 0x1C8E230 VA: 0x181C8F830 Slot: 22
	public virtual bool IsAssignableFrom(Type c) { }

	// RVA: 0x1C8F6F0 Offset: 0x1C8E0F0 VA: 0x181C8F6F0
	internal bool ImplementInterface(Type ifaceType) { }

	// RVA: 0x1C8CA30 Offset: 0x1C8B430 VA: 0x181C8CA30
	private static bool FilterAttributeImpl(MemberInfo m, object filterCriteria) { }

	// RVA: 0x1C8CF90 Offset: 0x1C8B990 VA: 0x181C8CF90
	private static bool FilterNameImpl(MemberInfo m, object filterCriteria) { }

	// RVA: 0x1C8CDC0 Offset: 0x1C8B7C0 VA: 0x181C8CDC0
	private static bool FilterNameIgnoreCaseImpl(MemberInfo m, object filterCriteria) { }

	// RVA: 0xA955C0 Offset: 0xA93FC0 VA: 0x180A955C0
	protected void .ctor() { }

	// RVA: 0xF72870 Offset: 0xF71270 VA: 0x180F72870 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1C8F6B0 Offset: 0x1C8E0B0 VA: 0x181C8F6B0 Slot: 23
	public Type GetType() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract string get_Namespace();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract string get_AssemblyQualifiedName();

	// RVA: -1 Offset: -1 Slot: 26
	public abstract string get_FullName();

	// RVA: -1 Offset: -1 Slot: 27
	public abstract Assembly get_Assembly();

	// RVA: -1 Offset: -1 Slot: 28
	public abstract Module get_Module();

	// RVA: 0x1C91340 Offset: 0x1C8FD40 VA: 0x181C91340
	public bool get_IsNested() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 29
	public virtual MethodBase get_DeclaringMethod() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: -1 Offset: -1 Slot: 30
	public abstract Type get_UnderlyingSystemType();

	// RVA: 0x64BA60 Offset: 0x64A460 VA: 0x18064BA60 Slot: 31
	public bool get_IsArray() { }

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract bool IsArrayImpl();

	// RVA: 0x4E26E0 Offset: 0x4E10E0 VA: 0x1804E26E0 Slot: 33
	public bool get_IsByRef() { }

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract bool IsByRefImpl();

	// RVA: 0x1C913D0 Offset: 0x1C8FDD0 VA: 0x181C913D0 Slot: 35
	public bool get_IsPointer() { }

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract bool IsPointerImpl();

	// RVA: 0x1C91040 Offset: 0x1C8FA40 VA: 0x181C91040 Slot: 37
	public virtual bool get_IsConstructedGenericType() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 38
	public virtual bool get_IsGenericParameter() { }

	// RVA: 0x1C91170 Offset: 0x1C8FB70 VA: 0x181C91170 Slot: 39
	public virtual bool get_IsGenericMethodParameter() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 40
	public virtual bool get_IsGenericType() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 41
	public virtual bool get_IsGenericTypeDefinition() { }

	// RVA: 0x1C91440 Offset: 0x1C8FE40 VA: 0x181C91440 Slot: 42
	public virtual bool get_IsSZArray() { }

	// RVA: 0x1C916A0 Offset: 0x1C900A0 VA: 0x181C916A0 Slot: 43
	public virtual bool get_IsVariableBoundArray() { }

	// RVA: 0x1C90F50 Offset: 0x1C8F950 VA: 0x181C90F50 Slot: 44
	public bool get_HasElementType() { }

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract bool HasElementTypeImpl();

	// RVA: -1 Offset: -1 Slot: 46
	public abstract Type GetElementType();

	// RVA: 0x1C8D1B0 Offset: 0x1C8BBB0 VA: 0x181C8D1B0 Slot: 47
	public virtual int GetArrayRank() { }

	// RVA: 0x1C8E2E0 Offset: 0x1C8CCE0 VA: 0x181C8E2E0 Slot: 48
	public virtual Type GetGenericTypeDefinition() { }

	// RVA: 0x1C90EC0 Offset: 0x1C8F8C0 VA: 0x181C90EC0 Slot: 49
	public virtual Type[] get_GenericTypeArguments() { }

	// RVA: 0x1C8E1F0 Offset: 0x1C8CBF0 VA: 0x181C8E1F0 Slot: 50
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x1C90E70 Offset: 0x1C8F870 VA: 0x181C90E70 Slot: 51
	public virtual int get_GenericParameterPosition() { }

	// RVA: 0x1C90E30 Offset: 0x1C8F830 VA: 0x181C90E30 Slot: 52
	public virtual GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1C8E240 Offset: 0x1C8CC40 VA: 0x181C8E240 Slot: 53
	public virtual Type[] GetGenericParameterConstraints() { }

	// RVA: 0x1C90B30 Offset: 0x1C8F530 VA: 0x181C90B30 Slot: 54
	public TypeAttributes get_Attributes() { }

	// RVA: -1 Offset: -1 Slot: 55
	protected abstract TypeAttributes GetAttributeFlagsImpl();

	// RVA: 0x1C90FA0 Offset: 0x1C8F9A0 VA: 0x181C90FA0 Slot: 56
	public bool get_IsAbstract() { }

	// RVA: 0x1C91470 Offset: 0x1C8FE70 VA: 0x181C91470 Slot: 57
	public bool get_IsSealed() { }

	// RVA: 0x1C90FF0 Offset: 0x1C8F9F0 VA: 0x181C90FF0 Slot: 58
	public bool get_IsClass() { }

	// RVA: 0x1C912E0 Offset: 0x1C8FCE0 VA: 0x181C912E0 Slot: 59
	public bool get_IsNestedAssembly() { }

	// RVA: 0x1C91310 Offset: 0x1C8FD10 VA: 0x181C91310 Slot: 60
	public bool get_IsNestedPublic() { }

	// RVA: 0x1C913A0 Offset: 0x1C8FDA0 VA: 0x181C913A0 Slot: 61
	public bool get_IsNotPublic() { }

	// RVA: 0x1C91410 Offset: 0x1C8FE10 VA: 0x181C91410 Slot: 62
	public bool get_IsPublic() { }

	// RVA: 0x1C91140 Offset: 0x1C8FB40 VA: 0x181C91140 Slot: 63
	public bool get_IsExplicitLayout() { }

	// RVA: 0x1C91290 Offset: 0x1C8FC90 VA: 0x181C91290 Slot: 64
	public bool get_IsLayoutSequential() { }

	// RVA: 0x1C90FD0 Offset: 0x1C8F9D0 VA: 0x181C90FD0 Slot: 65
	public bool get_IsCOMObject() { }

	// RVA: -1 Offset: -1 Slot: 66
	protected abstract bool IsCOMObjectImpl();

	// RVA: 0x70EF30 Offset: 0x70D930 VA: 0x18070EF30 Slot: 67
	public bool get_IsContextful() { }

	// RVA: 0x1C8F9E0 Offset: 0x1C8E3E0 VA: 0x181C8F9E0 Slot: 68
	protected virtual bool IsContextfulImpl() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 69
	public virtual bool get_IsCollectible() { }

	// RVA: 0x1C91070 Offset: 0x1C8FA70 VA: 0x181C91070 Slot: 70
	public virtual bool get_IsEnum() { }

	// RVA: 0x1C912C0 Offset: 0x1C8FCC0 VA: 0x181C912C0 Slot: 71
	public bool get_IsMarshalByRef() { }

	// RVA: 0x1C90420 Offset: 0x1C8EE20 VA: 0x181C90420 Slot: 72
	protected virtual bool IsMarshalByRefImpl() { }

	// RVA: 0x1C913F0 Offset: 0x1C8FDF0 VA: 0x181C913F0 Slot: 73
	public bool get_IsPrimitive() { }

	// RVA: -1 Offset: -1 Slot: 74
	protected abstract bool IsPrimitiveImpl();

	// RVA: 0x1C91680 Offset: 0x1C90080 VA: 0x181C91680 Slot: 75
	public bool get_IsValueType() { }

	// RVA: 0x1C90640 Offset: 0x1C8F040 VA: 0x181C90640 Slot: 76
	protected virtual bool IsValueTypeImpl() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 77
	public virtual bool get_IsSignatureType() { }

	[ComVisible(True)]
	// RVA: 0x1C8D500 Offset: 0x1C8BF00 VA: 0x181C8D500 Slot: 78
	public ConstructorInfo GetConstructor(Type[] types) { }

	[ComVisible(True)]
	// RVA: 0x1C8D200 Offset: 0x1C8BC00 VA: 0x181C8D200 Slot: 79
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x1C8D380 Offset: 0x1C8BD80 VA: 0x181C8D380 Slot: 80
	public ConstructorInfo GetConstructor(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 81
	protected abstract ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	[ComVisible(True)]
	// RVA: 0x1C8D680 Offset: 0x1C8C080 VA: 0x181C8D680 Slot: 82
	public ConstructorInfo[] GetConstructors() { }

	[ComVisible(True)]
	// RVA: -1 Offset: -1 Slot: 83
	public abstract ConstructorInfo[] GetConstructors(BindingFlags bindingAttr);

	// RVA: 0x1C8E1B0 Offset: 0x1C8CBB0 VA: 0x181C8E1B0 Slot: 84
	public EventInfo GetEvent(string name) { }

	// RVA: -1 Offset: -1 Slot: 85
	public abstract EventInfo GetEvent(string name, BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 86
	public abstract EventInfo[] GetEvents(BindingFlags bindingAttr);

	// RVA: 0x1C8E1D0 Offset: 0x1C8CBD0 VA: 0x181C8E1D0 Slot: 87
	public FieldInfo GetField(string name) { }

	// RVA: -1 Offset: -1 Slot: 88
	public abstract FieldInfo GetField(string name, BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 89
	public abstract FieldInfo[] GetFields(BindingFlags bindingAttr);

	// RVA: 0x1C8E3C0 Offset: 0x1C8CDC0 VA: 0x181C8E3C0 Slot: 90
	public MemberInfo[] GetMember(string name) { }

	// RVA: 0x1C8E390 Offset: 0x1C8CD90 VA: 0x181C8E390 Slot: 91
	public virtual MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1C8E3E0 Offset: 0x1C8CDE0 VA: 0x181C8E3E0 Slot: 92
	public virtual MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: -1 Offset: -1 Slot: 93
	public abstract MemberInfo[] GetMembers(BindingFlags bindingAttr);

	// RVA: 0x1C8E600 Offset: 0x1C8D000 VA: 0x181C8E600 Slot: 94
	public MethodInfo GetMethod(string name) { }

	// RVA: 0x1C8E6A0 Offset: 0x1C8D0A0 VA: 0x181C8E6A0 Slot: 95
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1C8E730 Offset: 0x1C8D130 VA: 0x181C8E730 Slot: 96
	public MethodInfo GetMethod(string name, Type[] types) { }

	// RVA: 0x1C8E430 Offset: 0x1C8CE30 VA: 0x181C8E430 Slot: 97
	public MethodInfo GetMethod(string name, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1C8EAE0 Offset: 0x1C8D4E0 VA: 0x181C8EAE0 Slot: 98
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1C8E8F0 Offset: 0x1C8D2F0 VA: 0x181C8E8F0 Slot: 99
	public MethodInfo GetMethod(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 100
	protected abstract MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x1C8ECC0 Offset: 0x1C8D6C0 VA: 0x181C8ECC0 Slot: 101
	public MethodInfo[] GetMethods() { }

	// RVA: -1 Offset: -1 Slot: 102
	public abstract MethodInfo[] GetMethods(BindingFlags bindingAttr);

	// RVA: -1 Offset: -1 Slot: 103
	public abstract Type GetNestedType(string name, BindingFlags bindingAttr);

	// RVA: 0x1C8F050 Offset: 0x1C8DA50 VA: 0x181C8F050 Slot: 104
	public PropertyInfo GetProperty(string name) { }

	// RVA: 0x1C8EFC0 Offset: 0x1C8D9C0 VA: 0x181C8EFC0 Slot: 105
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1C8F0F0 Offset: 0x1C8DAF0 VA: 0x181C8F0F0 Slot: 106
	public PropertyInfo GetProperty(string name, Type returnType) { }

	// RVA: 0x1C8EDF0 Offset: 0x1C8D7F0 VA: 0x181C8EDF0 Slot: 107
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types) { }

	// RVA: 0x1C8ED00 Offset: 0x1C8D700 VA: 0x181C8ED00 Slot: 108
	public PropertyInfo GetProperty(string name, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1C8EED0 Offset: 0x1C8D8D0 VA: 0x181C8EED0 Slot: 109
	public PropertyInfo GetProperty(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 110
	protected abstract PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers);

	// RVA: 0x1C8ECE0 Offset: 0x1C8D6E0 VA: 0x181C8ECE0 Slot: 111
	public PropertyInfo[] GetProperties() { }

	// RVA: -1 Offset: -1 Slot: 112
	public abstract PropertyInfo[] GetProperties(BindingFlags bindingAttr);

	// RVA: 0x1C91940 Offset: 0x1C90340 VA: 0x181C91940 Slot: 113
	public virtual RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1C8F4A0 Offset: 0x1C8DEA0 VA: 0x181C8F4A0
	public static RuntimeTypeHandle GetTypeHandle(object o) { }

	// RVA: 0x1C8F3D0 Offset: 0x1C8DDD0 VA: 0x181C8F3D0
	public static TypeCode GetTypeCode(Type type) { }

	// RVA: 0x1C8F290 Offset: 0x1C8DC90 VA: 0x181C8F290 Slot: 114
	protected virtual TypeCode GetTypeCodeImpl() { }

	// RVA: -1 Offset: -1 Slot: 115
	public abstract Type get_BaseType();

	// RVA: -1 Offset: -1 Slot: 116
	public abstract object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters);

	// RVA: -1 Offset: -1 Slot: 117
	public abstract Type[] GetInterfaces();

	// RVA: 0x1C900C0 Offset: 0x1C8EAC0 VA: 0x181C900C0 Slot: 118
	public virtual bool IsInstanceOfType(object o) { }

	// RVA: 0x1C90060 Offset: 0x1C8EA60 VA: 0x181C90060 Slot: 119
	public virtual bool IsEquivalentTo(Type other) { }

	// RVA: 0x1C8DFB0 Offset: 0x1C8C9B0 VA: 0x181C8DFB0 Slot: 120
	public virtual Type GetEnumUnderlyingType() { }

	// RVA: 0x1C8E100 Offset: 0x1C8CB00 VA: 0x181C8E100 Slot: 121
	public virtual Array GetEnumValues() { }

	// RVA: 0x1C90710 Offset: 0x1C8F110 VA: 0x181C90710 Slot: 122
	public virtual Type MakeArrayType() { }

	// RVA: 0x1C90750 Offset: 0x1C8F150 VA: 0x181C90750 Slot: 123
	public virtual Type MakeArrayType(int rank) { }

	// RVA: 0x1C90790 Offset: 0x1C8F190 VA: 0x181C90790 Slot: 124
	public virtual Type MakeByRefType() { }

	// RVA: 0x1C90840 Offset: 0x1C8F240 VA: 0x181C90840 Slot: 125
	public virtual Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x1C90890 Offset: 0x1C8F290 VA: 0x181C90890 Slot: 126
	public virtual Type MakePointerType() { }

	// RVA: 0x1C907D0 Offset: 0x1C8F1D0 VA: 0x181C907D0
	public static Type MakeGenericSignatureType(Type genericTypeDefinition, Type[] typeArguments) { }

	// RVA: 0x1C908D0 Offset: 0x1C8F2D0 VA: 0x181C908D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1C8C990 Offset: 0x1C8B390 VA: 0x181C8C990 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1C8E330 Offset: 0x1C8CD30 VA: 0x181C8E330 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1C8C8F0 Offset: 0x1C8B2F0 VA: 0x181C8C8F0 Slot: 127
	public virtual bool Equals(Type o) { }

	// RVA: 0x1C90CC0 Offset: 0x1C8F6C0 VA: 0x181C90CC0
	public static Binder get_DefaultBinder() { }

	// RVA: 0x1C8F440 Offset: 0x1C8DE40 VA: 0x181C8F440
	public static Type GetTypeFromHandle(RuntimeTypeHandle handle) { }

	// RVA: 0x1C91980 Offset: 0x1C90380 VA: 0x181C91980
	private static Type internal_from_handle(IntPtr handle) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 128
	internal virtual bool get_IsSzArray() { }

	// RVA: 0x1C8D190 Offset: 0x1C8BB90 VA: 0x181C8D190
	internal string FormatTypeName() { }

	// RVA: 0x1C8D150 Offset: 0x1C8BB50 VA: 0x181C8D150 Slot: 129
	internal virtual string FormatTypeName(bool serialization) { }

	// RVA: 0x1C911C0 Offset: 0x1C8FBC0 VA: 0x181C911C0 Slot: 130
	public bool get_IsInterface() { }

	// RVA: 0x1C8F620 Offset: 0x1C8E020 VA: 0x181C8F620
	public static Type GetType(string typeName, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1C8F530 Offset: 0x1C8DF30 VA: 0x181C8F530
	public static Type GetType(string typeName, bool throwOnError) { }

	// RVA: 0x1C8F5B0 Offset: 0x1C8DFB0 VA: 0x181C8F5B0
	public static Type GetType(string typeName) { }

	// RVA: 0x1C8F6C0 Offset: 0x1C8E0C0 VA: 0x181C8F6C0
	public static Type GetType(string typeName, Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError) { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(Type left, Type right) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(Type left, Type right) { }

	// RVA: 0x1C90DA0 Offset: 0x1C8F7A0 VA: 0x181C90DA0
	internal string get_FullNameOrDefault() { }

	// RVA: 0x1C904F0 Offset: 0x1C8EEF0 VA: 0x181C904F0
	internal bool IsRuntimeImplemented() { }

	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30 Slot: 131
	internal virtual string InternalGetNameIfAvailable(ref Type rootCauseForFailure) { }

	// RVA: 0x1C90F70 Offset: 0x1C8F970 VA: 0x181C90F70
	internal string get_InternalNameIfAvailable() { }

	// RVA: 0x1C918E0 Offset: 0x1C902E0 VA: 0x181C918E0
	internal string get_NameOrDefault() { }

	// RVA: 0x1C90930 Offset: 0x1C8F330 VA: 0x181C90930
	private static void .cctor() { }
}
