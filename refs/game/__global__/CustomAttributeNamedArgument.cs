public struct CustomAttributeNamedArgument // TypeDefIndex: 4737
{
	// Fields
	[CompilerGenerated]
	private readonly CustomAttributeTypedArgument <TypedValue>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly bool <IsField>k__BackingField; // 0x10
	[CompilerGenerated]
	private readonly string <MemberName>k__BackingField; // 0x18
	private readonly Type _attributeType; // 0x20
	private MemberInfo _lazyMemberInfo; // 0x28

	// Properties
	public CustomAttributeTypedArgument TypedValue { get; }
	public bool IsField { get; }
	public string MemberName { get; }
	public MemberInfo MemberInfo { get; }

	// Methods

	// RVA: 0x1B871B0 Offset: 0x1B85BB0 VA: 0x181B871B0
	internal void .ctor(Type attributeType, string memberName, bool isField, CustomAttributeTypedArgument typedValue) { }

	// RVA: 0x1B87220 Offset: 0x1B85C20 VA: 0x181B87220
	public void .ctor(MemberInfo memberInfo, object value) { }

	// RVA: 0x1B87500 Offset: 0x1B85F00 VA: 0x181B87500
	public void .ctor(MemberInfo memberInfo, CustomAttributeTypedArgument typedArgument) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	public CustomAttributeTypedArgument get_TypedValue() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	public bool get_IsField() { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public string get_MemberName() { }

	// RVA: 0x1B876A0 Offset: 0x1B860A0 VA: 0x181B876A0
	public MemberInfo get_MemberInfo() { }

	// RVA: 0x1B86DD0 Offset: 0x1B857D0 VA: 0x181B86DD0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B86E40 Offset: 0x1B85840 VA: 0x181B86E40 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B877E0 Offset: 0x1B861E0 VA: 0x181B877E0
	public static bool op_Equality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x1B878A0 Offset: 0x1B862A0 VA: 0x181B878A0
	public static bool op_Inequality(CustomAttributeNamedArgument left, CustomAttributeNamedArgument right) { }

	// RVA: 0x1B86EA0 Offset: 0x1B858A0 VA: 0x181B86EA0 Slot: 3
	public override string ToString() { }
}
