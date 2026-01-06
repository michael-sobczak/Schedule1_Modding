public struct StylePropertyName : IEquatable<StylePropertyName> // TypeDefIndex: 6880
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly StylePropertyId <id>k__BackingField; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly string <name>k__BackingField; // 0x8

	// Properties
	internal StylePropertyId id { get; }
	private string name { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	internal StylePropertyId get_id() { }

	[CompilerGenerated]
	[IsReadOnly]
	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	private string get_name() { }

	// RVA: 0x2F03230 Offset: 0x2F01C30 VA: 0x182F03230
	internal static StylePropertyId StylePropertyIdFromString(string name) { }

	// RVA: 0x2F033A0 Offset: 0x2F01DA0 VA: 0x182F033A0
	internal void .ctor(StylePropertyId stylePropertyId) { }

	// RVA: 0x2F032D0 Offset: 0x2F01CD0 VA: 0x182F032D0
	public void .ctor(string name) { }

	// RVA: 0x2F03220 Offset: 0x2F01C20 VA: 0x182F03220
	public static bool op_Equality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x2F034A0 Offset: 0x2F01EA0 VA: 0x182F034A0
	public static bool op_Inequality(StylePropertyName lhs, StylePropertyName rhs) { }

	// RVA: 0x2F03460 Offset: 0x2F01E60 VA: 0x182F03460
	public static StylePropertyName op_Implicit(string name) { }

	// RVA: 0x2C62C50 Offset: 0x2C61650 VA: 0x182C62C50 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2F03190 Offset: 0x2F01B90 VA: 0x182F03190 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x2F03220 Offset: 0x2F01C20 VA: 0x182F03220 Slot: 4
	public bool Equals(StylePropertyName other) { }

	// RVA: 0x1CD2DF0 Offset: 0x1CD17F0 VA: 0x181CD2DF0 Slot: 3
	public override string ToString() { }
}
