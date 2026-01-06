public abstract class FieldInfo : MemberInfo // TypeDefIndex: 4698
{
	// Properties
	public override MemberTypes MemberType { get; }
	public abstract FieldAttributes Attributes { get; }
	public abstract Type FieldType { get; }
	public bool IsInitOnly { get; }
	public bool IsLiteral { get; }
	public bool IsNotSerialized { get; }
	public bool IsStatic { get; }
	public bool IsPrivate { get; }
	public bool IsPublic { get; }
	public abstract RuntimeFieldHandle FieldHandle { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: 0x6CD160 Offset: 0x6CBB60 VA: 0x1806CD160 Slot: 7
	public override MemberTypes get_MemberType() { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract FieldAttributes get_Attributes();

	// RVA: -1 Offset: -1 Slot: 17
	public abstract Type get_FieldType();

	// RVA: 0x1B8A390 Offset: 0x1B88D90 VA: 0x181B8A390 Slot: 18
	public bool get_IsInitOnly() { }

	// RVA: 0x1B8A3C0 Offset: 0x1B88DC0 VA: 0x181B8A3C0 Slot: 19
	public bool get_IsLiteral() { }

	// RVA: 0x1B8A3F0 Offset: 0x1B88DF0 VA: 0x181B8A3F0 Slot: 20
	public bool get_IsNotSerialized() { }

	// RVA: 0x1B8A480 Offset: 0x1B88E80 VA: 0x181B8A480 Slot: 21
	public bool get_IsStatic() { }

	// RVA: 0x1B8A420 Offset: 0x1B88E20 VA: 0x181B8A420 Slot: 22
	public bool get_IsPrivate() { }

	// RVA: 0x1B8A450 Offset: 0x1B88E50 VA: 0x181B8A450 Slot: 23
	public bool get_IsPublic() { }

	// RVA: -1 Offset: -1 Slot: 24
	public abstract RuntimeFieldHandle get_FieldHandle();

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B85710 Offset: 0x1B84110 VA: 0x181B85710
	public static bool op_Equality(FieldInfo left, FieldInfo right) { }

	// RVA: 0x1B893D0 Offset: 0x1B87DD0 VA: 0x181B893D0
	public static bool op_Inequality(FieldInfo left, FieldInfo right) { }

	// RVA: -1 Offset: -1 Slot: 25
	public abstract object GetValue(object obj);

	[DebuggerStepThrough]
	[DebuggerHidden]
	// RVA: 0x1B8A2F0 Offset: 0x1B88CF0 VA: 0x181B8A2F0 Slot: 26
	public void SetValue(object obj, object value) { }

	// RVA: -1 Offset: -1 Slot: 27
	public abstract void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture);

	[CLSCompliant(False)]
	// RVA: 0x1B8A2A0 Offset: 0x1B88CA0 VA: 0x181B8A2A0 Slot: 28
	public virtual void SetValueDirect(TypedReference obj, object value) { }

	// RVA: 0x1B8A250 Offset: 0x1B88C50 VA: 0x181B8A250 Slot: 29
	public virtual object GetRawConstantValue() { }

	// RVA: 0x1B8A4B0 Offset: 0x1B88EB0 VA: 0x181B8A4B0
	private static FieldInfo internal_from_handle_type(IntPtr field_handle, IntPtr type_handle) { }

	// RVA: 0x1B89780 Offset: 0x1B88180 VA: 0x181B89780
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle) { }

	[ComVisible(False)]
	// RVA: 0x1B897F0 Offset: 0x1B881F0 VA: 0x181B897F0
	public static FieldInfo GetFieldFromHandle(RuntimeFieldHandle handle, RuntimeTypeHandle declaringType) { }

	// RVA: 0x1B898C0 Offset: 0x1B882C0 VA: 0x181B898C0 Slot: 30
	internal virtual int GetFieldOffset() { }

	// RVA: 0x1B1FC20 Offset: 0x1B1E620 VA: 0x181B1FC20
	private MarshalAsAttribute get_marshal_info() { }

	// RVA: 0x1B89FC0 Offset: 0x1B889C0 VA: 0x181B89FC0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x1B89910 Offset: 0x1B88310 VA: 0x181B89910
	internal CustomAttributeData[] GetPseudoCustomAttributesData() { }
}
