public abstract class MethodInfo : MethodBase // TypeDefIndex: 4711
{
	// Properties
	public override MemberTypes MemberType { get; }
	public virtual ParameterInfo ReturnParameter { get; }
	public virtual Type ReturnType { get; }
	internal virtual int GenericParameterCount { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x6AA790 Offset: 0x6A9190 VA: 0x1806AA790 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: 0x1B8DB50 Offset: 0x1B8C550 VA: 0x181B8DB50 Slot: 39
	public virtual ParameterInfo get_ReturnParameter() { }

	// RVA: 0x1B8DB80 Offset: 0x1B8C580 VA: 0x181B8DB80 Slot: 40
	public virtual Type get_ReturnType() { }

	// RVA: 0x1B8DA30 Offset: 0x1B8C430 VA: 0x181B8DA30 Slot: 28
	public override Type[] GetGenericArguments() { }

	// RVA: 0x1B8DA80 Offset: 0x1B8C480 VA: 0x181B8DA80 Slot: 41
	public virtual MethodInfo GetGenericMethodDefinition() { }

	// RVA: 0x1B8DAD0 Offset: 0x1B8C4D0 VA: 0x181B8DAD0 Slot: 42
	public virtual MethodInfo MakeGenericMethod(Type[] typeArguments) { }

	// RVA: -1 Offset: -1 Slot: 43
	public abstract MethodInfo GetBaseDefinition();

	// RVA: 0x1B8D990 Offset: 0x1B8C390 VA: 0x181B8D990 Slot: 44
	public virtual Delegate CreateDelegate(Type delegateType) { }

	// RVA: 0x1B8D9E0 Offset: 0x1B8C3E0 VA: 0x181B8D9E0 Slot: 45
	public virtual Delegate CreateDelegate(Type delegateType, object target) { }

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B85710 Offset: 0x1B84110 VA: 0x181B85710
	public static bool op_Equality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x1B893D0 Offset: 0x1B87DD0 VA: 0x181B893D0
	public static bool op_Inequality(MethodInfo left, MethodInfo right) { }

	// RVA: 0x1B8DB20 Offset: 0x1B8C520 VA: 0x181B8DB20 Slot: 46
	internal virtual int get_GenericParameterCount() { }
}
