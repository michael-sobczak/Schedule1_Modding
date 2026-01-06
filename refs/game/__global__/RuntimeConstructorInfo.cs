internal class RuntimeConstructorInfo : ConstructorInfo, ISerializable // TypeDefIndex: 4759
{
	// Fields
	internal IntPtr mhandle; // 0x10
	private string name; // 0x18
	private Type reftype; // 0x20

	// Properties
	public override Module Module { get; }
	internal BindingFlags BindingFlags { get; }
	private RuntimeType ReflectedTypeInternal { get; }
	public override RuntimeMethodHandle MethodHandle { get; }
	public override MethodAttributes Attributes { get; }
	public override CallingConventions CallingConvention { get; }
	public override bool ContainsGenericParameters { get; }
	public override Type ReflectedType { get; }
	public override Type DeclaringType { get; }
	public override string Name { get; }
	public override bool IsSecurityCritical { get; }
	public override int MetadataToken { get; }

	// Methods

	// RVA: 0x1B91FB0 Offset: 0x1B909B0 VA: 0x181B91FB0 Slot: 11
	public override Module get_Module() { }

	// RVA: 0x1B91FB0 Offset: 0x1B909B0 VA: 0x181B91FB0
	internal RuntimeModule GetRuntimeModule() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770
	internal BindingFlags get_BindingFlags() { }

	// RVA: 0x1B92640 Offset: 0x1B91040 VA: 0x181B92640
	private RuntimeType get_ReflectedTypeInternal() { }

	// RVA: 0x1B91DF0 Offset: 0x1B907F0 VA: 0x181B91DF0 Slot: 40
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B924A0 Offset: 0x1B90EA0 VA: 0x181B924A0
	internal string SerializationToString() { }

	// RVA: 0x1B92330 Offset: 0x1B90D30 VA: 0x181B92330
	internal void SerializationInvoke(object target, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1B91DC0 Offset: 0x1B907C0 VA: 0x181B91DC0 Slot: 18
	public override MethodImplAttributes GetMethodImplementationFlags() { }

	// RVA: 0x1B91FA0 Offset: 0x1B909A0 VA: 0x181B91FA0 Slot: 16
	public override ParameterInfo[] GetParameters() { }

	// RVA: 0x1B91FA0 Offset: 0x1B909A0 VA: 0x181B91FA0 Slot: 34
	internal override ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x1B91F70 Offset: 0x1B90970 VA: 0x181B91F70 Slot: 35
	internal override int GetParametersCount() { }

	// RVA: 0x1B92040 Offset: 0x1B90A40 VA: 0x181B92040
	internal object InternalInvoke(object obj, object[] parameters, out Exception exc) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1B92170 Offset: 0x1B90B70 VA: 0x181B92170 Slot: 31
	public override object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x1B91A90 Offset: 0x1B90490 VA: 0x181B91A90
	private object DoInvoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x1B92050 Offset: 0x1B90A50 VA: 0x181B92050
	public object InternalInvoke(object obj, object[] parameters, bool wrapExceptions) { }

	[DebuggerHidden]
	[DebuggerStepThrough]
	// RVA: 0x1B92140 Offset: 0x1B90B40 VA: 0x181B92140 Slot: 39
	public override object Invoke(BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 32
	public override RuntimeMethodHandle get_MethodHandle() { }

	// RVA: 0x1B92570 Offset: 0x1B90F70 VA: 0x181B92570 Slot: 17
	public override MethodAttributes get_Attributes() { }

	// RVA: 0x1B92580 Offset: 0x1B90F80 VA: 0x181B92580 Slot: 19
	public override CallingConventions get_CallingConvention() { }

	// RVA: 0x1B925B0 Offset: 0x1B90FB0 VA: 0x181B925B0 Slot: 29
	public override bool get_ContainsGenericParameters() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x1B925F0 Offset: 0x1B90FF0 VA: 0x181B925F0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0x1B92630 Offset: 0x1B91030 VA: 0x181B92630 Slot: 8
	public override string get_Name() { }

	// RVA: 0x1B922C0 Offset: 0x1B90CC0 VA: 0x181B922C0 Slot: 12
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x1B91CF0 Offset: 0x1B906F0 VA: 0x181B91CF0 Slot: 13
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x1B91D50 Offset: 0x1B90750 VA: 0x181B91D50 Slot: 14
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x1B924C0 Offset: 0x1B90EC0 VA: 0x181B924C0 Slot: 3
	public override string ToString() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50
	private static int get_core_clr_security_level() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 33
	public override bool get_IsSecurityCritical() { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x1B92620 Offset: 0x1B91020 VA: 0x181B92620
	internal static int get_metadata_token(RuntimeConstructorInfo method) { }

	// RVA: 0x1B92520 Offset: 0x1B90F20 VA: 0x181B92520
	public void .ctor() { }
}
