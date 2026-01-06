public class PlayerLoop // TypeDefIndex: 11993
{
	// Methods

	// RVA: 0x2CE57D0 Offset: 0x2CE41D0 VA: 0x182CE57D0
	public static PlayerLoopSystem GetCurrentPlayerLoop() { }

	// RVA: 0x2CE5E80 Offset: 0x2CE4880 VA: 0x182CE5E80
	public static void SetPlayerLoop(PlayerLoopSystem loop) { }

	// RVA: 0x2CE5B30 Offset: 0x2CE4530 VA: 0x182CE5B30
	private static int PlayerLoopSystemToInternal(PlayerLoopSystem sys, ref List<PlayerLoopSystemInternal> internalSys) { }

	// RVA: 0x2CE5850 Offset: 0x2CE4250 VA: 0x182CE5850
	private static PlayerLoopSystem InternalToPlayerLoopSystem(PlayerLoopSystemInternal[] internalSys, ref int offset) { }

	[NativeMethod(IsFreeFunction = True)]
	// RVA: 0x2CE57A0 Offset: 0x2CE41A0 VA: 0x182CE57A0
	private static PlayerLoopSystemInternal[] GetCurrentPlayerLoopInternal() { }

	[NativeMethod(IsFreeFunction = True)]
	// RVA: 0x2CE5E40 Offset: 0x2CE4840 VA: 0x182CE5E40
	private static void SetPlayerLoopInternal(PlayerLoopSystemInternal[] loop) { }
}
