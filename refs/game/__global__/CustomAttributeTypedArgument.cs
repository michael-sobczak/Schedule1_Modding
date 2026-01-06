public struct CustomAttributeTypedArgument // TypeDefIndex: 4738
{
	// Fields
	[CompilerGenerated]
	private readonly Type <ArgumentType>k__BackingField; // 0x0
	[CompilerGenerated]
	private readonly object <Value>k__BackingField; // 0x8

	// Properties
	public Type ArgumentType { get; }
	public object Value { get; }

	// Methods

	// RVA: 0x1B884B0 Offset: 0x1B86EB0 VA: 0x181B884B0
	public void .ctor(object value) { }

	// RVA: 0x1B881C0 Offset: 0x1B86BC0 VA: 0x181B881C0
	public void .ctor(Type argumentType, object value) { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public Type get_ArgumentType() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public object get_Value() { }

	// RVA: 0x1B87A10 Offset: 0x1B86410 VA: 0x181B87A10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1B87A70 Offset: 0x1B86470 VA: 0x181B87A70 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1B88550 Offset: 0x1B86F50 VA: 0x181B88550
	public static bool op_Equality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x1B885E0 Offset: 0x1B86FE0 VA: 0x181B885E0
	public static bool op_Inequality(CustomAttributeTypedArgument left, CustomAttributeTypedArgument right) { }

	// RVA: 0x1B881B0 Offset: 0x1B86BB0 VA: 0x181B881B0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1B87AC0 Offset: 0x1B864C0 VA: 0x181B87AC0
	internal string ToString(bool typed) { }

	// RVA: 0x1B87960 Offset: 0x1B86360 VA: 0x181B87960
	private static object CanonicalizeValue(object value) { }
}
