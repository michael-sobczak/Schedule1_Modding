internal class TypeSpec // TypeDefIndex: 3891
{
	// Fields
	private TypeIdentifier name; // 0x10
	private string assembly_name; // 0x18
	private List<TypeIdentifier> nested; // 0x20
	private List<TypeSpec> generic_params; // 0x28
	private List<ModifierSpec> modifier_spec; // 0x30
	private bool is_byref; // 0x38
	private string display_fullname; // 0x40

	// Properties
	internal bool HasModifiers { get; }
	internal string DisplayFullName { get; }

	// Methods

	// RVA: 0x99F540 Offset: 0x99DF40 VA: 0x18099F540
	internal bool get_HasModifiers() { }

	// RVA: 0x1CE7630 Offset: 0x1CE6030 VA: 0x181CE7630
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x1CE7AB0 Offset: 0x1CE64B0 VA: 0x181CE7AB0
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x1CE97E0 Offset: 0x1CE81E0 VA: 0x181CE97E0
	internal string get_DisplayFullName() { }

	// RVA: 0x1CE8C30 Offset: 0x1CE7630 VA: 0x181CE8C30
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x1CE9700 Offset: 0x1CE8100 VA: 0x181CE9700
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x1CE8D20 Offset: 0x1CE7720 VA: 0x181CE8D20
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase, ref StackCrawlMark stackMark) { }

	// RVA: 0x1CE7450 Offset: 0x1CE5E50 VA: 0x181CE7450
	private void AddName(string type_name) { }

	// RVA: 0x1CE7350 Offset: 0x1CE5D50 VA: 0x181CE7350
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x1CE9660 Offset: 0x1CE8060 VA: 0x181CE9660
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x1CE75A0 Offset: 0x1CE5FA0 VA: 0x181CE75A0
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x1CE72D0 Offset: 0x1CE5CD0 VA: 0x181CE72D0
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x1CE7CB0 Offset: 0x1CE66B0 VA: 0x181CE7CB0
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
