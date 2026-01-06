internal class DebugActionState // TypeDefIndex: 13636
{
	// Fields
	private DebugActionState.DebugActionKeyType m_Type; // 0x10
	private InputAction inputAction; // 0x18
	private bool[] m_TriggerPressedUp; // 0x20
	private float m_Timer; // 0x28
	[CompilerGenerated]
	private bool <runningAction>k__BackingField; // 0x2C
	[CompilerGenerated]
	private float <actionState>k__BackingField; // 0x30

	// Properties
	internal bool runningAction { get; set; }
	internal float actionState { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1ECD6B0 Offset: 0x1ECC0B0 VA: 0x181ECD6B0
	internal bool get_runningAction() { }

	[CompilerGenerated]
	// RVA: 0x1ECD6C0 Offset: 0x1ECC0C0 VA: 0x181ECD6C0
	private void set_runningAction(bool value) { }

	[CompilerGenerated]
	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	internal float get_actionState() { }

	[CompilerGenerated]
	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	private void set_actionState(float value) { }

	// RVA: 0x29E7A80 Offset: 0x29E6480 VA: 0x1829E7A80
	private void Trigger(int triggerCount, float state) { }

	// RVA: 0x29E7970 Offset: 0x29E6370 VA: 0x1829E7970
	public void TriggerWithButton(InputAction action, float state) { }

	// RVA: 0x29E7950 Offset: 0x29E6350 VA: 0x1829E7950
	private void Reset() { }

	// RVA: 0x29E7B40 Offset: 0x29E6540 VA: 0x1829E7B40
	public void Update(DebugActionDesc desc) { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
