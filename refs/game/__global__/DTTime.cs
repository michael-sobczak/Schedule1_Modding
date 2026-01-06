public static class DTTime // TypeDefIndex: 10404
{
	// Fields
	[UsedImplicitly]
	[Obsolete("Will get removed since it is not used by Curvy, and needs maintenance to be compatible with Unity's Enter Play Mode Settings")]
	private static float _EditorDeltaTime; // 0x0
	[UsedImplicitly]
	[Obsolete("Will get removed since it is not used by Curvy, and needs maintenance to be compatible with Unity's Enter Play Mode Settings")]
	private static float _EditorLastTime; // 0x4

	// Properties
	public static double TimeSinceStartup { get; }
	[UsedImplicitly]
	[Obsolete("Seems to me that this is not working properly. Probably because InitializeEditorTime and UpdateEditorTime are never called. Fix this before using it")]
	public static float deltaTime { get; }

	// Methods

	// RVA: 0x48F040 Offset: 0x48DA40 VA: 0x18048F040
	public static double get_TimeSinceStartup() { }

	// RVA: 0x48F050 Offset: 0x48DA50 VA: 0x18048F050
	public static float get_deltaTime() { }

	[UsedImplicitly]
	[Obsolete("Will get removed since it is not used by Curvy, and needs maintenance to be compatible with Unity's Enter Play Mode Settings")]
	// RVA: 0x48EF80 Offset: 0x48D980 VA: 0x18048EF80
	public static void InitializeEditorTime() { }

	[UsedImplicitly]
	[Obsolete("Will get removed since it is not used by Curvy, and needs maintenance to be compatible with Unity's Enter Play Mode Settings")]
	// RVA: 0x48EFE0 Offset: 0x48D9E0 VA: 0x18048EFE0
	public static void UpdateEditorTime() { }
}
