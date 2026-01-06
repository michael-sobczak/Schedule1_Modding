internal static class MatchTargetFieldConstants // TypeDefIndex: 17367
{
	// Fields
	public static MatchTargetFields All; // 0x0
	public static MatchTargetFields None; // 0x4
	public static MatchTargetFields Position; // 0x8
	public static MatchTargetFields Rotation; // 0xC

	// Methods

	[Extension]
	// RVA: 0x2C49120 Offset: 0x2C47B20 VA: 0x182C49120
	public static bool HasAny(MatchTargetFields me, MatchTargetFields fields) { }

	[Extension]
	// RVA: 0x2C49190 Offset: 0x2C47B90 VA: 0x182C49190
	public static MatchTargetFields Toggle(MatchTargetFields me, MatchTargetFields flag) { }

	// RVA: 0x2C491A0 Offset: 0x2C47BA0 VA: 0x182C491A0
	private static void .cctor() { }
}
