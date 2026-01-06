public class TypeDelegator : TypeInfo // TypeDefIndex: 4734
{
	// Fields
	protected Type typeImpl; // 0x18

	// Properties
	public override int MetadataToken { get; }
	public override Module Module { get; }
	public override Assembly Assembly { get; }
	public override RuntimeTypeHandle TypeHandle { get; }
	public override string Name { get; }
	public override string FullName { get; }
	public override string Namespace { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override bool IsSZArray { get; }
	public override bool IsGenericMethodParameter { get; }
	public override bool IsConstructedGenericType { get; }
	public override bool IsCollectible { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x1B9C700 Offset: 0x1B9B100 VA: 0x181B9C700
	public void .ctor(Type delegatingType) { }

	// RVA: 0x1B9C910 Offset: 0x1B9B310 VA: 0x181B9C910 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1B9C5D0 Offset: 0x1B9AFD0 VA: 0x181B9C5D0 Slot: 116
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x1B9C940 Offset: 0x1B9B340 VA: 0x181B9C940 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x1B9C7F0 Offset: 0x1B9B1F0 VA: 0x181B9C7F0 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x1B9C970 Offset: 0x1B9B370 VA: 0x181B9C970 Slot: 113
	public override RuntimeTypeHandle get_TypeHandle() { }

	// RVA: 0x1B99510 Offset: 0x1B97F10 VA: 0x181B99510 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B9C850 Offset: 0x1B9B250 VA: 0x181B9C850 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x1B99540 Offset: 0x1B97F40 VA: 0x181B99540 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x1AD6D10 Offset: 0x1AD5710 VA: 0x181AD6D10 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x1B9C820 Offset: 0x1B9B220 VA: 0x181B9C820 Slot: 115
	public override Type get_BaseType() { }

	// RVA: 0x1B9C1B0 Offset: 0x1B9ABB0 VA: 0x181B9C1B0 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x1B9C1E0 Offset: 0x1B9ABE0 VA: 0x181B9C1E0 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1B9C3F0 Offset: 0x1B9ADF0 VA: 0x181B9C3F0 Slot: 100
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B9C430 Offset: 0x1B9AE30 VA: 0x181B9C430 Slot: 102
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x1B9C300 Offset: 0x1B9AD00 VA: 0x181B9C300 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9C330 Offset: 0x1B9AD30 VA: 0x181B9C330 Slot: 89
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1B9C360 Offset: 0x1B9AD60 VA: 0x181B9C360 Slot: 117
	public override Type[] GetInterfaces() { }

	// RVA: 0x1B9C2A0 Offset: 0x1B9ACA0 VA: 0x181B9C2A0 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9C4C0 Offset: 0x1B9AEC0 VA: 0x181B9C4C0 Slot: 110
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B9C490 Offset: 0x1B9AE90 VA: 0x181B9C490 Slot: 112
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1B9C2D0 Offset: 0x1B9ACD0 VA: 0x181B9C2D0 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x1B9C460 Offset: 0x1B9AE60 VA: 0x181B9C460 Slot: 103
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9C390 Offset: 0x1B9AD90 VA: 0x181B9C390 Slot: 92
	public override MemberInfo[] GetMember(string name, MemberTypes type, BindingFlags bindingAttr) { }

	// RVA: 0x1B9C3C0 Offset: 0x1B9ADC0 VA: 0x181B9C3C0 Slot: 93
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1B9C190 Offset: 0x1B9AB90 VA: 0x181B9C190 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1B9C8E0 Offset: 0x1B9B2E0 VA: 0x181B9C8E0 Slot: 42
	public override bool get_IsSZArray() { }

	// RVA: 0x1B9C610 Offset: 0x1B9B010 VA: 0x181B9C610 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x1B9C6C0 Offset: 0x1B9B0C0 VA: 0x181B9C6C0 Slot: 74
	protected override bool IsPrimitiveImpl() { }

	// RVA: 0x1B9C630 Offset: 0x1B9B030 VA: 0x181B9C630 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x1AD6150 Offset: 0x1AD4B50 VA: 0x181AD6150 Slot: 39
	public override bool get_IsGenericMethodParameter() { }

	// RVA: 0x1B9C6A0 Offset: 0x1B9B0A0 VA: 0x181B9C6A0 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x1B9C6E0 Offset: 0x1B9B0E0 VA: 0x181B9C6E0 Slot: 76
	protected override bool IsValueTypeImpl() { }

	// RVA: 0x1B9C650 Offset: 0x1B9B050 VA: 0x181B9C650 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1B9C8B0 Offset: 0x1B9B2B0 VA: 0x181B9C8B0 Slot: 37
	public override bool get_IsConstructedGenericType() { }

	// RVA: 0x1B9C880 Offset: 0x1B9B280 VA: 0x181B9C880 Slot: 69
	public override bool get_IsCollectible() { }

	// RVA: 0x1B9C270 Offset: 0x1B9AC70 VA: 0x181B9C270 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x1B9C5B0 Offset: 0x1B9AFB0 VA: 0x181B9C5B0 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1B9C9A0 Offset: 0x1B9B3A0 VA: 0x181B9C9A0 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1B9C240 Offset: 0x1B9AC40 VA: 0x181B9C240 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B9C210 Offset: 0x1B9AC10 VA: 0x181B9C210 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B9C670 Offset: 0x1B9B070 VA: 0x181B9C670 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}
