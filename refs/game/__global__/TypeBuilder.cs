public sealed class TypeBuilder : TypeInfo // TypeDefIndex: 4783
{
	// Fields
	public const int UnspecifiedTypeSize = 0;

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

	// RVA: 0x1B9BFD0 Offset: 0x1B9A9D0 VA: 0x181B9BFD0 Slot: 27
	public override Assembly get_Assembly() { }

	// RVA: 0x1B9BF90 Offset: 0x1B9A990 VA: 0x181B9BF90 Slot: 25
	public override string get_AssemblyQualifiedName() { }

	// RVA: 0x1B9C010 Offset: 0x1B9AA10 VA: 0x181B9C010 Slot: 115
	public override Type get_BaseType() { }

	// RVA: 0x1B9C050 Offset: 0x1B9AA50 VA: 0x181B9C050 Slot: 26
	public override string get_FullName() { }

	// RVA: 0x1B9C090 Offset: 0x1B9AA90 VA: 0x181B9C090 Slot: 28
	public override Module get_Module() { }

	// RVA: 0x1B9C0D0 Offset: 0x1B9AAD0 VA: 0x181B9C0D0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B9C110 Offset: 0x1B9AB10 VA: 0x181B9C110 Slot: 24
	public override string get_Namespace() { }

	// RVA: 0x1B9C150 Offset: 0x1B9AB50 VA: 0x181B9C150 Slot: 30
	public override Type get_UnderlyingSystemType() { }

	// RVA: 0x1B9B950 Offset: 0x1B9A350 VA: 0x181B9B950 Slot: 55
	protected override TypeAttributes GetAttributeFlagsImpl() { }

	// RVA: 0x1B9B990 Offset: 0x1B9A390 VA: 0x181B9B990 Slot: 81
	protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	[ComVisible(True)]
	// RVA: 0x1B9B9D0 Offset: 0x1B9A3D0 VA: 0x181B9B9D0 Slot: 83
	public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr) { }

	// RVA: 0x1B9BA10 Offset: 0x1B9A410 VA: 0x181B9BA10 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B9BA50 Offset: 0x1B9A450 VA: 0x181B9BA50 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B9BA90 Offset: 0x1B9A490 VA: 0x181B9BA90 Slot: 46
	public override Type GetElementType() { }

	// RVA: 0x1B9BAD0 Offset: 0x1B9A4D0 VA: 0x181B9BAD0 Slot: 85
	public override EventInfo GetEvent(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9BB10 Offset: 0x1B9A510 VA: 0x181B9BB10 Slot: 86
	public override EventInfo[] GetEvents(BindingFlags bindingAttr) { }

	// RVA: 0x1B9BB50 Offset: 0x1B9A550 VA: 0x181B9BB50 Slot: 88
	public override FieldInfo GetField(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9BB90 Offset: 0x1B9A590 VA: 0x181B9BB90 Slot: 89
	public override FieldInfo[] GetFields(BindingFlags bindingAttr) { }

	// RVA: 0x1B9BBD0 Offset: 0x1B9A5D0 VA: 0x181B9BBD0 Slot: 117
	public override Type[] GetInterfaces() { }

	// RVA: 0x1B9BC10 Offset: 0x1B9A610 VA: 0x181B9BC10 Slot: 93
	public override MemberInfo[] GetMembers(BindingFlags bindingAttr) { }

	// RVA: 0x1B9BC50 Offset: 0x1B9A650 VA: 0x181B9BC50 Slot: 100
	protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B9BC90 Offset: 0x1B9A690 VA: 0x181B9BC90 Slot: 102
	public override MethodInfo[] GetMethods(BindingFlags bindingAttr) { }

	// RVA: 0x1B9BCD0 Offset: 0x1B9A6D0 VA: 0x181B9BCD0 Slot: 103
	public override Type GetNestedType(string name, BindingFlags bindingAttr) { }

	// RVA: 0x1B9BD10 Offset: 0x1B9A710 VA: 0x181B9BD10 Slot: 112
	public override PropertyInfo[] GetProperties(BindingFlags bindingAttr) { }

	// RVA: 0x1B9BD50 Offset: 0x1B9A750 VA: 0x181B9BD50 Slot: 110
	protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: 0x1B9BD90 Offset: 0x1B9A790 VA: 0x181B9BD90 Slot: 45
	protected override bool HasElementTypeImpl() { }

	// RVA: 0x1B9BDD0 Offset: 0x1B9A7D0 VA: 0x181B9BDD0 Slot: 116
	public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters) { }

	// RVA: 0x1B9BE10 Offset: 0x1B9A810 VA: 0x181B9BE10 Slot: 32
	protected override bool IsArrayImpl() { }

	// RVA: 0x1B9BE50 Offset: 0x1B9A850 VA: 0x181B9BE50 Slot: 34
	protected override bool IsByRefImpl() { }

	// RVA: 0x1B9BE90 Offset: 0x1B9A890 VA: 0x181B9BE90 Slot: 66
	protected override bool IsCOMObjectImpl() { }

	// RVA: 0x1B9BED0 Offset: 0x1B9A8D0 VA: 0x181B9BED0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B9BF10 Offset: 0x1B9A910 VA: 0x181B9BF10 Slot: 36
	protected override bool IsPointerImpl() { }

	// RVA: 0x1B9BF50 Offset: 0x1B9A950 VA: 0x181B9BF50 Slot: 74
	protected override bool IsPrimitiveImpl() { }
}
