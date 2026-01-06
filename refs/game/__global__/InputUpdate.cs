internal static class InputUpdate // TypeDefIndex: 7698
{
	// Fields
	public static uint s_UpdateStepCount; // 0x0
	public static InputUpdateType s_LatestUpdateType; // 0x4
	public static InputUpdate.UpdateStepCount s_PlayerUpdateStepCount; // 0x8

	// Methods

	// RVA: 0x287AE00 Offset: 0x2879800 VA: 0x18287AE00
	internal static void OnBeforeUpdate(InputUpdateType type) { }

	// RVA: 0x287AE70 Offset: 0x2879870 VA: 0x18287AE70
	internal static void OnUpdate(InputUpdateType type) { }

	// RVA: 0x287AF90 Offset: 0x2879990 VA: 0x18287AF90
	public static InputUpdate.SerializedState Save() { }

	// RVA: 0x287AEF0 Offset: 0x28798F0 VA: 0x18287AEF0
	public static void Restore(InputUpdate.SerializedState state) { }

	[Extension]
	// RVA: 0x287ADD0 Offset: 0x28797D0 VA: 0x18287ADD0
	public static InputUpdateType GetUpdateTypeForPlayer(InputUpdateType mask) { }

	[Extension]
	// RVA: 0x287ADF0 Offset: 0x28797F0 VA: 0x18287ADF0
	public static bool IsPlayerUpdate(InputUpdateType updateType) { }
}
