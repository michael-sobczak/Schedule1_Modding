public abstract class MethodBase : MemberInfo // TypeDefIndex: 4709
{
	// Properties
	public abstract MethodAttributes Attributes { get; }
	public virtual CallingConventions CallingConvention { get; }
	public bool IsAbstract { get; }
	public bool IsConstructor { get; }
	public bool IsSpecialName { get; }
	public bool IsStatic { get; }
	public bool IsVirtual { get; }
	public bool IsPublic { get; }
	public virtual bool IsGenericMethod { get; }
	public virtual bool IsGenericMethodDefinition { get; }
	public virtual bool ContainsGenericParameters { get; }
	public abstract RuntimeMethodHandle MethodHandle { get; }
	public virtual bool IsSecurityCritical { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract ParameterInfo[] GetParameters();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract MethodAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 18
	public abstract MethodImplAttributes GetMethodImplementationFlags();

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 19
	public virtual CallingConventions get_CallingConvention() { }

	// RVA: 0x1B8D240 Offset: 0x1B8BC40 VA: 0x181B8D240 Slot: 20
	public bool get_IsAbstract() { }

	// RVA: 0x1B8D270 Offset: 0x1B8BC70 VA: 0x181B8D270 Slot: 21
	public bool get_IsConstructor() { }

	// RVA: 0x1B8D370 Offset: 0x1B8BD70 VA: 0x181B8D370 Slot: 22
	public bool get_IsSpecialName() { }

	// RVA: 0x1B8D3A0 Offset: 0x1B8BDA0 VA: 0x181B8D3A0 Slot: 23
	public bool get_IsStatic() { }

	// RVA: 0x1B8D3D0 Offset: 0x1B8BDD0 VA: 0x181B8D3D0 Slot: 24
	public bool get_IsVirtual() { }

	// RVA: 0x1B8D310 Offset: 0x1B8BD10 VA: 0x181B8D310 Slot: 25
	public bool get_IsPublic() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 26
	public virtual bool get_IsGenericMethod() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 27
	public virtual bool get_IsGenericMethodDefinition() { }

	// RVA: 0x1B8CDC0 Offset: 0x1B8B7C0 VA: 0x181B8CDC0 Slot: 28
	public virtual Type[] GetGenericArguments() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public virtual bool get_ContainsGenericParameters() { }

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1B8D200 Offset: 0x1B8BC00 VA: 0x181B8D200 Slot: 30
	public object Invoke(object obj, object[] parameters) { }

	// RVA: -1 Offset: -1 Slot: 31
	public abstract object Invoke(object obj, BindingFlags invokeAttr, Binder binder, object[] parameters, CultureInfo culture);

	// RVA: -1 Offset: -1 Slot: 32
	public abstract RuntimeMethodHandle get_MethodHandle();

	// RVA: 0x1B8D340 Offset: 0x1B8BD40 VA: 0x181B8D340 Slot: 33
	public virtual bool get_IsSecurityCritical() { }

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B8D400 Offset: 0x1B8BE00 VA: 0x181B8D400
	public static bool op_Equality(MethodBase left, MethodBase right) { }

	// RVA: 0x1B8D670 Offset: 0x1B8C070 VA: 0x181B8D670
	public static bool op_Inequality(MethodBase left, MethodBase right) { }

	// RVA: 0x1B8D1E0 Offset: 0x1B8BBE0 VA: 0x181B8D1E0 Slot: 34
	internal virtual ParameterInfo[] GetParametersInternal() { }

	// RVA: 0x1B8D1B0 Offset: 0x1B8BBB0 VA: 0x181B8D1B0 Slot: 35
	internal virtual int GetParametersCount() { }

	// RVA: 0x1B8CC80 Offset: 0x1B8B680 VA: 0x181B8CC80 Slot: 36
	internal virtual string FormatNameAndSig(bool serialization) { }

	// RVA: 0x1B8D070 Offset: 0x1B8BA70 VA: 0x181B8D070 Slot: 37
	internal virtual Type[] GetParameterTypes() { }

	// RVA: 0x1B8D1E0 Offset: 0x1B8BBE0 VA: 0x181B8D1E0 Slot: 38
	internal virtual ParameterInfo[] GetParametersNoCopy() { }

	// RVA: 0x1B8CE10 Offset: 0x1B8B810 VA: 0x181B8CE10
	public static MethodBase GetMethodFromHandle(RuntimeMethodHandle handle) { }

	// RVA: 0x1B8CA80 Offset: 0x1B8B480 VA: 0x181B8CA80
	internal static string ConstructParameters(Type[] parameterTypes, CallingConventions callingConvention, bool serialization) { }
}
