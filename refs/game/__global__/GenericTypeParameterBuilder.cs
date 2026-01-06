public sealed class GenericTypeParameterBuilder : TypeInfo // TypeDefIndex: 4775
{
	// Properties
	public override Assembly Assembly { get; }
	public override string AssemblyQualifiedName { get; }
	public override Type BaseType { get; }
	public override string FullName { get; }
	public override Module Module { get; }
	public override string Name { get; }
	public override string Namespace { get; }
	public override Type UnderlyingSystemType { get; }

	// Methods

	// RVA: 0x1B8AB40 Offset: 0x1B89540 VA: 0x181B8AB40 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x1B8AB00 Offset: 0x1B89500 VA: 0x181B8AB00 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x1B8AB80 Offset: 0x1B89580 VA: 0x181B8AB80 Slot: 115
	public override Type get_BaseType() { }

	// RVA: 0x1B8ABC0 Offset: 0x1B895C0 VA: 0x181B8ABC0 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x1B8AC00 Offset: 0x1B89600 VA: 0x181B8AC00 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x1B8AC40 Offset: 0x1B89640 VA: 0x181B8AC40 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B8AC80 Offset: 0x1B89680 VA: 0x181B8AC80 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x1B8ACC0 Offset: 0x1B896C0 VA: 0x181B8ACC0 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1B8A4C0 Offset: 0x1B88EC0 VA: 0x181B8A4C0 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1B8A500 Offset: 0x1B88F00 VA: 0x181B8A500 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x1B8A540 Offset: 0x1B88F40 VA: 0x181B8A540 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1B8A5C0 Offset: 0x1B88FC0 VA: 0x181B8A5C0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B8A580 Offset: 0x1B88F80 VA: 0x181B8A580 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B8A600 Offset: 0x1B89000 VA: 0x181B8A600 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x1B8A640 Offset: 0x1B89040 VA: 0x181B8A640 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B8A680 Offset: 0x1B89080 VA: 0x181B8A680 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x1B8A6C0 Offset: 0x1B890C0 VA: 0x181B8A6C0 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B8A700 Offset: 0x1B89100 VA: 0x181B8A700 Slot: 89
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1B8A740 Offset: 0x1B89140 VA: 0x181B8A740 Slot: 117
	public override Type[] GetInterfaces() { }

	// RVA: 0x1B8A780 Offset: 0x1B89180 VA: 0x181B8A780 Slot: 93
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1B8A7C0 Offset: 0x1B891C0 VA: 0x181B8A7C0 Slot: 100
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B8A800 Offset: 0x1B89200 VA: 0x181B8A800 Slot: 102
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x1B8A840 Offset: 0x1B89240 VA: 0x181B8A840 Slot: 103
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B8A880 Offset: 0x1B89280 VA: 0x181B8A880 Slot: 112
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1B8A8C0 Offset: 0x1B892C0 VA: 0x181B8A8C0 Slot: 110
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B8A900 Offset: 0x1B89300 VA: 0x181B8A900 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1B8A940 Offset: 0x1B89340 VA: 0x181B8A940 Slot: 116
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x1B8A980 Offset: 0x1B89380 VA: 0x181B8A980 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x1B8A9C0 Offset: 0x1B893C0 VA: 0x181B8A9C0 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x1B8AA00 Offset: 0x1B89400 VA: 0x181B8AA00 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1B8AA40 Offset: 0x1B89440 VA: 0x181B8AA40 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B8AA80 Offset: 0x1B89480 VA: 0x181B8AA80 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x1B8AAC0 Offset: 0x1B894C0 VA: 0x181B8AAC0 Slot: 74
	protected override bool IsPrimitiveImpl() { }
}
