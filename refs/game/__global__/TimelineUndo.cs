internal static class TimelineUndo // TypeDefIndex: 17467
{
	// Properties
	internal static bool undoEnabled { get; }

	// Methods

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	internal static bool get_undoEnabled() { }

	// RVA: 0x2C61AE0 Offset: 0x2C604E0 VA: 0x182C61AE0
	public static void PushDestroyUndo(TimelineAsset timeline, Object thingToDirty, Object objectToDestroy) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void PushUndo(Object[] thingsToDirty, string operation) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void PushUndo(Object thingToDirty, string operation) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public static void RegisterCreatedObjectUndo(Object thingCreated, string operation) { }

	// RVA: 0x2C61B60 Offset: 0x2C60560 VA: 0x182C61B60
	internal static string UndoName(string name) { }
}
