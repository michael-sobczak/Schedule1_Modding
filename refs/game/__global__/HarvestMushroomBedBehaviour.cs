public class HarvestMushroomBedBehaviour : GrowContainerBehaviour // TypeDefIndex: 1805
{
	// Fields
	public AvatarEquippable TrimmersEquippable; // 0x1A0
	private MushroomBed _bed; // 0x1A8
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviourAssembly-CSharp.dll_Excuted; // 0x1B0
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviourAssembly-CSharp.dll_Excuted; // 0x1B1

	// Methods

	// RVA: 0x72F4D0 Offset: 0x72DED0 VA: 0x18072F4D0 Slot: 19
	public override void Awake() { }

	// RVA: 0x74CAD0 Offset: 0x74B4D0 VA: 0x18074CAD0 Slot: 34
	public override void AssignAndEnable(GrowContainer growContainer) { }

	// RVA: 0x74CC90 Offset: 0x74B690 VA: 0x18074CC90 Slot: 43
	protected override float GetActionDuration() { }

	// RVA: 0x74CCC0 Offset: 0x74B6C0 VA: 0x18074CCC0 Slot: 42
	protected override string GetAnimationBool() { }

	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0 Slot: 39
	protected override AvatarEquippable GetActionEquippable() { }

	// RVA: 0x74D060 Offset: 0x74BA60 VA: 0x18074D060 Slot: 41
	protected override void OnActionSuccess(ItemInstance usedItem) { }

	// RVA: 0x74CE50 Offset: 0x74B850 VA: 0x18074CE50
	private int GetQuantityToHarvest() { }

	// RVA: 0x74C920 Offset: 0x74B320 VA: 0x18074C920 Slot: 35
	public override bool AreTaskConditionsMetForContainer(GrowContainer container) { }

	// RVA: 0x74CBD0 Offset: 0x74B5D0 VA: 0x18074CBD0 Slot: 44
	protected override bool CheckSuccess(ItemInstance usedItem) { }

	// RVA: 0x74CC30 Offset: 0x74B630 VA: 0x18074CC30
	public bool DoesMushroomBedHaveValidDestination(MushroomBed bed) { }

	// RVA: 0x74CCF0 Offset: 0x74B6F0 VA: 0x18074CCF0
	private int GetDestinationCapacityForItem(MushroomBed bed, ItemInstance item) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	// RVA: 0x74D030 Offset: 0x74BA30 VA: 0x18074D030 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x74D000 Offset: 0x74BA00 VA: 0x18074D000 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x74CBC0 Offset: 0x74B5C0 VA: 0x18074CBC0 Slot: 47
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.HarvestMushroomBedBehaviour_Assembly-CSharp.dll() { }
}
