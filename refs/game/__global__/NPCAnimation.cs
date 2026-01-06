public class NPCAnimation : NetworkBehaviour // TypeDefIndex: 1636
{
	// Fields
	public bool DEBUG; // 0x118
	protected NPC npc; // 0x120
	[Header("Settings")]
	public AnimationCurve WalkMapCurve; // 0x128
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted; // 0x130
	private bool NetworkInitialize__LateScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted; // 0x131

	// Methods

	// RVA: 0x7024F0 Offset: 0x700EF0 VA: 0x1807024F0 Slot: 19
	public override void Awake() { }

	// RVA: 0x702570 Offset: 0x700F70 VA: 0x180702570 Slot: 20
	protected virtual void LateUpdate() { }

	// RVA: 0x702800 Offset: 0x701200 VA: 0x180702800 Slot: 21
	protected virtual void UpdateMovementAnimation() { }

	// RVA: 0x7026A0 Offset: 0x7010A0 VA: 0x1807026A0 Slot: 22
	public virtual void SetRagdollActive(bool active) { }

	// RVA: 0x702750 Offset: 0x701150 VA: 0x180702750
	public void StandupStart() { }

	// RVA: 0x7026E0 Offset: 0x7010E0 VA: 0x1807026E0
	public void StandupDone() { }

	// RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	public void .ctor() { }

	// RVA: 0x702680 Offset: 0x701080 VA: 0x180702680 Slot: 23
	public override void NetworkInitialize___Early() { }

	// RVA: 0x702660 Offset: 0x701060 VA: 0x180702660 Slot: 24
	public override void NetworkInitialize__Late() { }

	// RVA: 0x66D1D0 Offset: 0x66BBD0 VA: 0x18066D1D0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7024A0 Offset: 0x700EA0 VA: 0x1807024A0
	private void Awake_UserLogic_ScheduleOne.NPCs.NPCAnimation_Assembly-CSharp.dll() { }
}
