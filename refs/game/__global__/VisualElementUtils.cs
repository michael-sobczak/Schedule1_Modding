internal static class VisualElementUtils // TypeDefIndex: 7048
{
	// Fields
	private static readonly HashSet<string> s_usedNames; // 0x0
	private static readonly Type s_FoldoutType; // 0x8
	private static readonly string s_InspectorElementUssClassName; // 0x10

	// Methods

	// RVA: 0x2E0EC20 Offset: 0x2E0D620 VA: 0x182E0EC20
	public static string GetUniqueName(string nameBase) { }

	[Extension]
	// RVA: 0x2E0EB30 Offset: 0x2E0D530 VA: 0x182E0EB30
	internal static int GetFoldoutDepth(VisualElement element) { }

	[Extension]
	// RVA: 0x2E0EA00 Offset: 0x2E0D400 VA: 0x182E0EA00
	internal static void AssignInspectorStyleIfNecessary(VisualElement element, string classNameToEnable) { }

	// RVA: 0x2E0ED30 Offset: 0x2E0D730 VA: 0x182E0ED30
	private static void .cctor() { }
}
