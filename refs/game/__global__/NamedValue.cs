public struct NamedValue : IEquatable<NamedValue> // TypeDefIndex: 7825
{
	// Fields
	public const string Separator = ",";
	[CompilerGenerated]
	private string <name>k__BackingField; // 0x0
	[CompilerGenerated]
	private PrimitiveValue <value>k__BackingField; // 0x8

	// Properties
	public string name { get; set; }
	public PrimitiveValue value { get; set; }
	public TypeCode type { get; }

	// Methods

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public string get_name() { }

	[CompilerGenerated]
	// RVA: 0x48A530 Offset: 0x488F30 VA: 0x18048A530
	public void set_name(string value) { }

	[IsReadOnly]
	[CompilerGenerated]
	// RVA: 0x46EE40 Offset: 0x46D840 VA: 0x18046EE40
	public PrimitiveValue get_value() { }

	[CompilerGenerated]
	// RVA: 0x1C2E7D0 Offset: 0x1C2D1D0 VA: 0x181C2E7D0
	public void set_value(PrimitiveValue value) { }

	// RVA: 0x489DD0 Offset: 0x4887D0 VA: 0x180489DD0
	public TypeCode get_type() { }

	// RVA: 0x278F170 Offset: 0x278DB70 VA: 0x18278F170
	public NamedValue ConvertTo(TypeCode type) { }

	// RVA: -1 Offset: -1
	public static NamedValue From<TValue>(string name, TValue value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF084F0 Offset: 0xF06EF0 VA: 0x180F084F0
	|-NamedValue.From<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x278F920 Offset: 0x278E320 VA: 0x18278F920 Slot: 3
	public override string ToString() { }

	// RVA: 0x278F1E0 Offset: 0x278DBE0 VA: 0x18278F1E0 Slot: 4
	public bool Equals(NamedValue other) { }

	// RVA: 0x278F260 Offset: 0x278DC60 VA: 0x18278F260 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x278F350 Offset: 0x278DD50 VA: 0x18278F350 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x278F9A0 Offset: 0x278E3A0 VA: 0x18278F9A0
	public static bool op_Equality(NamedValue left, NamedValue right) { }

	// RVA: 0x278FA20 Offset: 0x278E420 VA: 0x18278FA20
	public static bool op_Inequality(NamedValue left, NamedValue right) { }

	// RVA: 0x278F3F0 Offset: 0x278DDF0 VA: 0x18278F3F0
	public static NamedValue[] ParseMultiple(string parameterString) { }

	// RVA: 0x278F8E0 Offset: 0x278E2E0 VA: 0x18278F8E0
	public static NamedValue Parse(string str) { }

	// RVA: 0x278F5F0 Offset: 0x278DFF0 VA: 0x18278F5F0
	private static NamedValue ParseParameter(string parameterString, ref int index) { }

	// RVA: 0x278EEC0 Offset: 0x278D8C0 VA: 0x18278EEC0
	public void ApplyToObject(object instance) { }

	// RVA: -1 Offset: -1
	public static void ApplyAllToObject<TParameterList>(object instance, TParameterList parameters) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF08310 Offset: 0xF06D10 VA: 0x180F08310
	|-NamedValue.ApplyAllToObject<ReadOnlyArray<NamedValue>>
	|
	|-RVA: 0xF080B0 Offset: 0xF06AB0 VA: 0x180F080B0
	|-NamedValue.ApplyAllToObject<__Il2CppFullySharedGenericType>
	*/
}
