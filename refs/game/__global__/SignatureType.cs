internal abstract class SignatureType : Type // TypeDefIndex: 4728
{
	// Properties
	public sealed override bool IsSignatureType { get; }
	public abstract override bool IsSZArray { get; }
	public abstract override bool IsVariableBoundArray { get; }
	public sealed override bool IsGenericType { get; }
	public abstract override bool IsGenericTypeDefinition { get; }
	public abstract override bool IsConstructedGenericType { get; }
	public abstract override bool IsGenericParameter { get; }
	public abstract override bool IsGenericMethodParameter { get; }
	public abstract override bool ContainsGenericParameters { get; }
	public sealed override MemberTypes MemberType { get; }
	public abstract override Type[] GenericTypeArguments { get; }
	public abstract override int GenericParameterPosition { get; }
	internal abstract SignatureType ElementType { get; }
	public sealed override Type UnderlyingSystemType { get; }
	public abstract override string Name { get; }
	public abstract override string Namespace { get; }
	public sealed override string FullName { get; }
	public sealed override string AssemblyQualifiedName { get; }
	public sealed override Assembly Assembly { get; }
	public sealed override Module Module { get; }
	public sealed override Type ReflectedType { get; }
	public sealed override Type BaseType { get; }
	public sealed override int MetadataToken { get; }
	public sealed override Type DeclaringType { get; }
	public sealed override MethodBase DeclaringMethod { get; }
	public sealed override GenericParameterAttributes GenericParameterAttributes { get; }
	public sealed override bool IsEnum { get; }
	public sealed override bool IsSerializable { get; }
	public sealed override RuntimeTypeHandle TypeHandle { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 77
	public sealed override bool get_IsSignatureType() { }

	// RVA: -1 Offset: -1 Slot: 45
	protected abstract override bool HasElementTypeImpl();

	// RVA: -1 Offset: -1 Slot: 32
	protected abstract override bool IsArrayImpl();

	// RVA: -1 Offset: -1 Slot: 42
	public abstract override bool get_IsSZArray();

	// RVA: -1 Offset: -1 Slot: 43
	public abstract override bool get_IsVariableBoundArray();

	// RVA: -1 Offset: -1 Slot: 34
	protected abstract override bool IsByRefImpl();

	// RVA: -1 Offset: -1 Slot: 36
	protected abstract override bool IsPointerImpl();

	// RVA: 0x1B9B2A0 Offset: 0x1B99CA0 VA: 0x181B9B2A0 Slot: 40
	public sealed override bool get_IsGenericType() { }

	// RVA: -1 Offset: -1 Slot: 41
	public abstract override bool get_IsGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract override bool get_IsConstructedGenericType();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract override bool get_IsGenericParameter();

	// RVA: -1 Offset: -1 Slot: 39
	public abstract override bool get_IsGenericMethodParameter();

	// RVA: -1 Offset: -1 Slot: 20
	public abstract override bool get_ContainsGenericParameters();

	// RVA: 0xF72870 Offset: 0xF71270 VA: 0x180F72870 Slot: 7
	public sealed override MemberTypes get_MemberType() { }

	// RVA: 0x1B9ADC0 Offset: 0x1B997C0 VA: 0x181B9ADC0 Slot: 122
	public sealed override Type MakeArrayType() { }

	// RVA: 0x1B9AE30 Offset: 0x1B99830 VA: 0x181B9AE30 Slot: 123
	public sealed override Type MakeArrayType(int rank) { }

	// RVA: 0x1B9AEE0 Offset: 0x1B998E0 VA: 0x181B9AEE0 Slot: 124
	public sealed override Type MakeByRefType() { }

	// RVA: 0x1B9AFD0 Offset: 0x1B999D0 VA: 0x181B9AFD0 Slot: 126
	public sealed override Type MakePointerType() { }

	// RVA: 0x1B9AF80 Offset: 0x1B99980 VA: 0x181B9AF80 Slot: 125
	public sealed override Type MakeGenericType(Type[] typeArguments) { }

	// RVA: 0x1B9A3F0 Offset: 0x1B98DF0 VA: 0x181B9A3F0 Slot: 46
	public sealed override Type GetElementType() { }

	// RVA: -1 Offset: -1 Slot: 47
	public abstract override int GetArrayRank();

	// RVA: -1 Offset: -1 Slot: 48
	public abstract override Type GetGenericTypeDefinition();

	// RVA: -1 Offset: -1 Slot: 49
	public abstract override Type[] get_GenericTypeArguments();

	// RVA: -1 Offset: -1 Slot: 50
	public abstract override Type[] GetGenericArguments();

	// RVA: -1 Offset: -1 Slot: 51
	public abstract override int get_GenericParameterPosition();

	// RVA: -1 Offset: -1 Slot: 132
	internal abstract SignatureType get_ElementType();

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0 Slot: 30
	public sealed override Type get_UnderlyingSystemType() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract override string get_Name();

	// RVA: -1 Offset: -1 Slot: 24
	public abstract override string get_Namespace();

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 26
	public sealed override string get_FullName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 25
	public sealed override string get_AssemblyQualifiedName() { }

	// RVA: -1 Offset: -1 Slot: 3
	public abstract override string ToString();

	// RVA: 0x1B9B0C0 Offset: 0x1B99AC0 VA: 0x181B9B0C0 Slot: 27
	public sealed override Assembly get_Assembly() { }

	// RVA: 0x1B9B390 Offset: 0x1B99D90 VA: 0x181B9B390 Slot: 28
	public sealed override Module get_Module() { }

	// RVA: 0x1B9B3E0 Offset: 0x1B99DE0 VA: 0x181B9B3E0 Slot: 10
	public sealed override Type get_ReflectedType() { }

	// RVA: 0x1B9B110 Offset: 0x1B99B10 VA: 0x181B9B110 Slot: 115
	public sealed override Type get_BaseType() { }

	// RVA: 0x1B9A6E0 Offset: 0x1B990E0 VA: 0x181B9A6E0 Slot: 117
	public sealed override Type[] GetInterfaces() { }

	// RVA: 0x1B9AA50 Offset: 0x1B99450 VA: 0x181B9AA50 Slot: 22
	public sealed override bool IsAssignableFrom(Type c) { }

	// RVA: 0x1B9B340 Offset: 0x1B99D40 VA: 0x181B9B340 Slot: 15
	public sealed override int get_MetadataToken() { }

	// RVA: 0x1B9B1B0 Offset: 0x1B99BB0 VA: 0x181B9B1B0 Slot: 9
	public sealed override Type get_DeclaringType() { }

	// RVA: 0x1B9B160 Offset: 0x1B99B60 VA: 0x181B9B160 Slot: 29
	public sealed override MethodBase get_DeclaringMethod() { }

	// RVA: 0x1B9A690 Offset: 0x1B99090 VA: 0x181B9A690 Slot: 53
	public sealed override Type[] GetGenericParameterConstraints() { }

	// RVA: 0x1B9B200 Offset: 0x1B99C00 VA: 0x181B9B200 Slot: 52
	public sealed override GenericParameterAttributes get_GenericParameterAttributes() { }

	// RVA: 0x1B9AB90 Offset: 0x1B99590 VA: 0x181B9AB90 Slot: 16
	public sealed override bool IsEnumDefined(object value) { }

	// RVA: 0x1B9A410 Offset: 0x1B98E10 VA: 0x181B9A410 Slot: 17
	public sealed override string GetEnumName(object value) { }

	// RVA: 0x1B9A460 Offset: 0x1B98E60 VA: 0x181B9A460 Slot: 18
	public sealed override string[] GetEnumNames() { }

	// RVA: 0x1B9A4B0 Offset: 0x1B98EB0 VA: 0x181B9A4B0 Slot: 120
	public sealed override Type GetEnumUnderlyingType() { }

	// RVA: 0x1B9A500 Offset: 0x1B98F00 VA: 0x181B9A500 Slot: 121
	public sealed override Array GetEnumValues() { }

	// RVA: 0x1B9A9B0 Offset: 0x1B993B0 VA: 0x181B9A9B0 Slot: 114
	protected sealed override TypeCode GetTypeCodeImpl() { }

	// RVA: 0x1B9A260 Offset: 0x1B98C60 VA: 0x181B9A260 Slot: 55
	protected sealed override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1B9A300 Offset: 0x1B98D00 VA: 0x181B9A300 Slot: 83
	public sealed override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1B9A550 Offset: 0x1B98F50 VA: 0x181B9A550 Slot: 85
	public sealed override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9A5A0 Offset: 0x1B98FA0 VA: 0x181B9A5A0 Slot: 86
	public sealed override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x1B9A5F0 Offset: 0x1B98FF0 VA: 0x181B9A5F0 Slot: 88
	public sealed override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9A640 Offset: 0x1B99040 VA: 0x181B9A640 Slot: 89
	public sealed override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1B9A7D0 Offset: 0x1B991D0 VA: 0x181B9A7D0 Slot: 93
	public sealed override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1B9A870 Offset: 0x1B99270 VA: 0x181B9A870 Slot: 102
	public sealed override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x1B9A8C0 Offset: 0x1B992C0 VA: 0x181B9A8C0 Slot: 103
	public sealed override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9A910 Offset: 0x1B99310 VA: 0x181B9A910 Slot: 112
	public sealed override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1B9AA00 Offset: 0x1B99400 VA: 0x181B9AA00 Slot: 116
	public sealed override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x1B9A820 Offset: 0x1B99220 VA: 0x181B9A820 Slot: 100
	protected sealed override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B9A960 Offset: 0x1B99360 VA: 0x181B9A960 Slot: 110
	protected sealed override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B9A780 Offset: 0x1B99180 VA: 0x181B9A780 Slot: 91
	public sealed override MemberInfo[] GetMember(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9A730 Offset: 0x1B99130 VA: 0x181B9A730 Slot: 92
	public sealed override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x1B9A350 Offset: 0x1B98D50 VA: 0x181B9A350 Slot: 13
	public sealed override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B9A3A0 Offset: 0x1B98DA0 VA: 0x181B9A3A0 Slot: 14
	public sealed override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B9AB40 Offset: 0x1B99540 VA: 0x181B9AB40 Slot: 12
	public sealed override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B9A2B0 Offset: 0x1B98CB0 VA: 0x181B9A2B0 Slot: 81
	protected sealed override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B9AAA0 Offset: 0x1B994A0 VA: 0x181B9AAA0 Slot: 66
	protected sealed override bool IsCOMObjectImpl() { }

	// RVA: 0x1B9ACD0 Offset: 0x1B996D0 VA: 0x181B9ACD0 Slot: 74
	protected sealed override bool IsPrimitiveImpl() { }

	// RVA: 0x1B9AAF0 Offset: 0x1B994F0 VA: 0x181B9AAF0 Slot: 68
	protected sealed override bool IsContextfulImpl() { }

	// RVA: 0x1B9B250 Offset: 0x1B99C50 VA: 0x181B9B250 Slot: 70
	public sealed override bool get_IsEnum() { }

	// RVA: 0x1B9ABE0 Offset: 0x1B995E0 VA: 0x181B9ABE0 Slot: 119
	public sealed override bool IsEquivalentTo(Type other) { }

	// RVA: 0x1B9AC30 Offset: 0x1B99630 VA: 0x181B9AC30 Slot: 118
	public sealed override bool IsInstanceOfType(object o) { }

	// RVA: 0x1B9AC80 Offset: 0x1B99680 VA: 0x181B9AC80 Slot: 72
	protected sealed override bool IsMarshalByRefImpl() { }

	// RVA: 0x1B9B2F0 Offset: 0x1B99CF0 VA: 0x181B9B2F0 Slot: 19
	public sealed override bool get_IsSerializable() { }

	// RVA: 0x1B9AD20 Offset: 0x1B99720 VA: 0x181B9AD20 Slot: 21
	public sealed override bool IsSubclassOf(Type c) { }

	// RVA: 0x1B9AD70 Offset: 0x1B99770 VA: 0x181B9AD70 Slot: 76
	protected sealed override bool IsValueTypeImpl() { }

	// RVA: 0x1B9B430 Offset: 0x1B99E30 VA: 0x181B9B430 Slot: 113
	public sealed override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1B9B070 Offset: 0x1B99A70 VA: 0x181B9B070
	protected void .ctor() { }
}
