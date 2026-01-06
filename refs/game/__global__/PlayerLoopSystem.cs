public struct PlayerLoopSystem // TypeDefIndex: 11992
{
	// Fields
	public Type type; // 0x0
	public PlayerLoopSystem[] subSystemList; // 0x8
	public PlayerLoopSystem.UpdateFunction updateDelegate; // 0x10
	public IntPtr updateFunction; // 0x18
	public IntPtr loopConditionFunction; // 0x20

	// Methods

	// RVA: 0x2CE5770 Offset: 0x2CE4170 VA: 0x182CE5770 Slot: 3
	public override string ToString() { }
}
