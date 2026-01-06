public sealed class DynamicMethod : MethodInfo // TypeDefIndex: 4771
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x1B88830 Offset: 0x1B87230 VA: 0x181B88830 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x1B88870 Offset: 0x1B87270 VA: 0x181B88870 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1B888F0 Offset: 0x1B872F0 VA: 0x181B888F0 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B88770 Offset: 0x1B87170 VA: 0x181B88770 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x1B888B0 Offset: 0x1B872B0 VA: 0x181B888B0 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x1B88930 Offset: 0x1B87330 VA: 0x181B88930 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B886F0 Offset: 0x1B870F0 VA: 0x181B886F0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B886B0 Offset: 0x1B870B0 VA: 0x181B886B0 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B88730 Offset: 0x1B87130 VA: 0x181B88730 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x1B88670 Offset: 0x1B87070 VA: 0x181B88670 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x1B887B0 Offset: 0x1B871B0 VA: 0x181B887B0 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x1B887F0 Offset: 0x1B871F0 VA: 0x181B887F0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}
