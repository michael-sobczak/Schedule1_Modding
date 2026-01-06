public sealed class MethodBuilder : MethodInfo // TypeDefIndex: 4778
{
	// Properties
	public override MethodAttributes Attributes { get; }
	public override Type DeclaringType { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override string Name { get; }
	public override Type ReflectedType { get; }

	// Methods

	// RVA: 0x1B8D850 Offset: 0x1B8C250 VA: 0x181B8D850 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x1B8D890 Offset: 0x1B8C290 VA: 0x181B8D890 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1B8D8D0 Offset: 0x1B8C2D0 VA: 0x181B8D8D0 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x1B8D910 Offset: 0x1B8C310 VA: 0x181B8D910 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B8D950 Offset: 0x1B8C350 VA: 0x181B8D950 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B8D690 Offset: 0x1B8C090 VA: 0x181B8D690 Slot: 43
	public override MethodInfo GetBaseDefinition() { }

	// RVA: 0x1B8D6D0 Offset: 0x1B8C0D0 VA: 0x181B8D6D0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B8D710 Offset: 0x1B8C110 VA: 0x181B8D710 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B8D750 Offset: 0x1B8C150 VA: 0x181B8D750 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x1B8D790 Offset: 0x1B8C190 VA: 0x181B8D790 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x1B8D7D0 Offset: 0x1B8C1D0 VA: 0x181B8D7D0 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x1B8D810 Offset: 0x1B8C210 VA: 0x181B8D810 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }
}
