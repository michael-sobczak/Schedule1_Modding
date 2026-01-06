public abstract class MemberInfo : ICustomAttributeProvider // TypeDefIndex: 4706
{
	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual Module Module { get; }
	public virtual int MetadataToken { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract MemberTypes get_MemberType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_DeclaringType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Type get_ReflectedType();

	// RVA: 0x1B8C5F0 Offset: 0x1B8AFF0 VA: 0x181B8C5F0 Slot: 11
	public virtual Module get_Module() { }

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool IsDefined(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 14
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: 0x1B8C5B0 Offset: 0x1B8AFB0 VA: 0x181B8C5B0 Slot: 15
	public virtual int get_MetadataToken() { }

	// RVA: 0xC82B80 Offset: 0xC81580 VA: 0x180C82B80 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1ACA830 Offset: 0x1AC9230 VA: 0x181ACA830 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B8C6D0 Offset: 0x1B8B0D0 VA: 0x181B8C6D0
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x1B8CA60 Offset: 0x1B8B460 VA: 0x181B8CA60
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }
}
