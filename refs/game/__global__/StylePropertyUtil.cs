internal static class StylePropertyUtil // TypeDefIndex: 7163
{
	// Fields
	internal static readonly Dictionary<string, StylePropertyId> s_NameToId; // 0x0
	internal static readonly Dictionary<StylePropertyId, string> s_IdToName; // 0x8
	internal static readonly HashSet<StylePropertyId> s_AnimatableProperties; // 0x10
	internal static readonly Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties; // 0x18

	// Methods

	// RVA: 0x2E3BA40 Offset: 0x2E3A440 VA: 0x182E3BA40
	public static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue) { }

	// RVA: 0x2E3B8E0 Offset: 0x2E3A2E0 VA: 0x182E3B8E0
	public static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id) { }

	// RVA: 0x2E3B860 Offset: 0x2E3A260 VA: 0x182E3B860
	public static bool IsAnimatable(StylePropertyId id) { }

	// RVA: 0x2E3CA40 Offset: 0x2E3B440 VA: 0x182E3CA40
	private static void .cctor() { }
}
