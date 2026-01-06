internal static class StyleCache // TypeDefIndex: 7054
{
	// Fields
	private static Dictionary<long, ComputedStyle> s_ComputedStyleCache; // 0x0
	private static Dictionary<int, StyleVariableContext> s_StyleVariableContextCache; // 0x8
	private static Dictionary<int, ComputedTransitionProperty[]> s_ComputedTransitionsCache; // 0x10

	// Methods

	// RVA: 0x2E04D40 Offset: 0x2E03740 VA: 0x182E04D40
	public static bool TryGetValue(long hash, out ComputedStyle data) { }

	// RVA: 0x2E04A30 Offset: 0x2E03430 VA: 0x182E04A30
	public static void SetValue(long hash, ref ComputedStyle data) { }

	// RVA: 0x2E04C20 Offset: 0x2E03620 VA: 0x182E04C20
	public static bool TryGetValue(int hash, out StyleVariableContext data) { }

	// RVA: 0x2E04B00 Offset: 0x2E03500 VA: 0x182E04B00
	public static void SetValue(int hash, StyleVariableContext data) { }

	// RVA: 0x2E04CB0 Offset: 0x2E036B0 VA: 0x182E04CB0
	public static bool TryGetValue(int hash, out ComputedTransitionProperty[] data) { }

	// RVA: 0x2E04B90 Offset: 0x2E03590 VA: 0x182E04B90
	public static void SetValue(int hash, ComputedTransitionProperty[] data) { }

	// RVA: 0x2E04DD0 Offset: 0x2E037D0 VA: 0x182E04DD0
	private static void .cctor() { }
}
