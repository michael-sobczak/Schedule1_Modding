public class HarvestPotBehaviour : GrowContainerBehaviour // TypeDefIndex: 1806
{
	// Fields
	public AvatarEquippable TrimmersEquippable; // 0x1A0
	private Pot _pot; // 0x1A8
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HarvestPotBehaviourAssembly-CSharp.dll_Excuted; // 0x1B0
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HarvestPotBehaviourAssembly-CSharp.dll_Excuted; // 0x1B1

	// Methods

	// RVA: 0x72F4D0 Offset: 0x72DED0 VA: 0x18072F4D0 Slot: 19
	public override void Awake() { }

	// RVA: 0x74D4A0 Offset: 0x74BEA0 VA: 0x18074D4A0 Slot: 34
	public override void AssignAndEnable(GrowContainer growContainer) { }

	// RVA: 0x74D660 Offset: 0x74C060 VA: 0x18074D660 Slot: 43
	protected override float GetActionDuration() { }

	// RVA: 0x74D680 Offset: 0x74C080 VA: 0x18074D680 Slot: 42
	protected override string GetAnimationBool() { }

	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0 Slot: 39
	protected override AvatarEquippable GetActionEquippable() { }

	// RVA: 0x74D9E0 Offset: 0x74C3E0 VA: 0x18074D9E0 Slot: 41
	protected override void OnActionSuccess(ItemInstance usedItem) { }

	// RVA: 0x74D810 Offset: 0x74C210 VA: 0x18074D810
	private int GetQuantityToHarvest() { }

	// RVA: 0x74D2E0 Offset: 0x74BCE0 VA: 0x18074D2E0 Slot: 35
	public override bool AreTaskConditionsMetForContainer(GrowContainer container) { }

	// RVA: 0x74D590 Offset: 0x74BF90 VA: 0x18074D590 Slot: 44
	protected override bool CheckSuccess(ItemInstance usedItem) { }

	// RVA: 0x74D600 Offset: 0x74C000 VA: 0x18074D600
	public bool DoesPotHaveValidDestination(Pot pot) { }

	// RVA: 0x74D6B0 Offset: 0x74C0B0 VA: 0x18074D6B0
	private int GetDestinationCapacityForItem(Pot pot, ItemInstance item) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	// RVA: 0x74D030 Offset: 0x74BA30 VA: 0x18074D030 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x74D000 Offset: 0x74BA00 VA: 0x18074D000 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x74CBC0 Offset: 0x74B5C0 VA: 0x18074CBC0 Slot: 47
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.HarvestPotBehaviour_Assembly-CSharp.dll() { }
}
