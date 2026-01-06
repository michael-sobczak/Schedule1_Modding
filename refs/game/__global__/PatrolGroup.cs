public class PatrolGroup // TypeDefIndex: 1840
{
	// Fields
	public List<NPC> Members; // 0x10
	public FootPatrolRoute Route; // 0x18
	public int CurrentWaypoint; // 0x20

	// Methods

	// RVA: 0x76B240 Offset: 0x769C40 VA: 0x18076B240
	public void .ctor(FootPatrolRoute route) { }

	// RVA: 0x76AAD0 Offset: 0x7694D0 VA: 0x18076AAD0
	public Vector3 GetDestination(NPC member) { }

	// RVA: 0x76A860 Offset: 0x769260 VA: 0x18076A860
	public void DisbandGroup() { }

	// RVA: 0x76A820 Offset: 0x769220 VA: 0x18076A820
	public void AdvanceGroup() { }

	// RVA: 0x76ADB0 Offset: 0x7697B0 VA: 0x18076ADB0
	private Vector3 GetMemberOffset(NPC member) { }

	// RVA: 0x76AF80 Offset: 0x769980 VA: 0x18076AF80
	public bool IsGroupReadyToAdvance() { }

	// RVA: 0x76B0A0 Offset: 0x769AA0 VA: 0x18076B0A0
	public bool IsPaused() { }
}
