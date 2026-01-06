public abstract class GrowContainerBehaviour : Behaviour // TypeDefIndex: 1804
{
	// Fields
	[CompilerGenerated]
	private GrowContainer <_growContainer>k__BackingField; // 0x168
	[CompilerGenerated]
	private GrowContainerBehaviour.EState <_currentState>k__BackingField; // 0x170
	[CompilerGenerated]
	private Botanist <_botanist>k__BackingField; // 0x178
	private Coroutine _walkRoutine; // 0x180
	private Coroutine _grabRoutine; // 0x188
	private Coroutine _performActionRoutine; // 0x190
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.GrowContainerBehaviourAssembly-CSharp.dll_Excuted; // 0x198
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.GrowContainerBehaviourAssembly-CSharp.dll_Excuted; // 0x199

	// Properties
	protected GrowContainer _growContainer { get; set; }
	protected GrowContainerBehaviour.EState _currentState { get; set; }
	protected Botanist _botanist { get; set; }
	protected BotanistConfiguration _botanistConfiguration { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	protected GrowContainer get__growContainer() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set__growContainer(GrowContainer value) { }

	[CompilerGenerated]
	// RVA: 0x74C8E0 Offset: 0x74B2E0 VA: 0x18074C8E0
	protected GrowContainerBehaviour.EState get__currentState() { }

	[CompilerGenerated]
	// RVA: 0x74C910 Offset: 0x74B310 VA: 0x18074C910
	private void set__currentState(GrowContainerBehaviour.EState value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCC0 Offset: 0x6BE6C0 VA: 0x1806BFCC0
	protected Botanist get__botanist() { }

	[CompilerGenerated]
	// RVA: 0x74C8F0 Offset: 0x74B2F0 VA: 0x18074C8F0
	private void set__botanist(Botanist value) { }

	// RVA: 0x74C850 Offset: 0x74B250 VA: 0x18074C850
	protected BotanistConfiguration get__botanistConfiguration() { }

	// RVA: 0x74B290 Offset: 0x749C90 VA: 0x18074B290 Slot: 19
	public override void Awake() { }

	// RVA: 0x74B1C0 Offset: 0x749BC0 VA: 0x18074B1C0 Slot: 34
	public virtual void AssignAndEnable(GrowContainer growContainer) { }

	// RVA: 0x74B0E0 Offset: 0x749AE0 VA: 0x18074B0E0 Slot: 22
	public override void Activate() { }

	// RVA: 0x74C520 Offset: 0x74AF20 VA: 0x18074C520 Slot: 25
	public override void Resume() { }

	// RVA: 0x74C430 Offset: 0x74AE30 VA: 0x18074C430 Slot: 24
	public override void Pause() { }

	// RVA: 0x74B350 Offset: 0x749D50 VA: 0x18074B350 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x74B100 Offset: 0x749B00 VA: 0x18074B100 Slot: 35
	public virtual bool AreTaskConditionsMetForContainer(GrowContainer container) { }

	// RVA: 0x74B630 Offset: 0x74A030 VA: 0x18074B630
	public bool DoesBotanistHaveAccessToRequiredSupplies(GrowContainer container) { }

	// RVA: 0x74BD10 Offset: 0x74A710 VA: 0x18074BD10 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x74C130 Offset: 0x74AB30 VA: 0x18074C130 Slot: 36
	protected virtual void OnStartPerformAction() { }

	// RVA: 0x74C2F0 Offset: 0x74ACF0 VA: 0x18074C2F0 Slot: 37
	protected virtual void OnStopPerformAction() { }

	// RVA: 0x74B6C0 Offset: 0x74A0C0 VA: 0x18074B6C0 Slot: 38
	protected virtual Vector3 GetGrowContainerLookPoint() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 39
	protected virtual AvatarEquippable GetActionEquippable() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 40
	protected virtual TrashItem GetTrashPrefab(ItemInstance usedItem) { }

	// RVA: -1 Offset: -1 Slot: 41
	protected abstract void OnActionSuccess(ItemInstance usedItem);

	// RVA: -1 Offset: -1 Slot: 42
	protected abstract string GetAnimationBool();

	// RVA: -1 Offset: -1 Slot: 43
	protected abstract float GetActionDuration();

	// RVA: 0x74C6F0 Offset: 0x74B0F0 VA: 0x18074C6F0
	private void WalkTo(ITransitEntity entity) { }

	// RVA: 0x74B960 Offset: 0x74A360 VA: 0x18074B960
	private void GrabRequiredItemFromSupplies() { }

	// RVA: 0x74C450 Offset: 0x74AE50 VA: 0x18074C450
	private void PerformAction() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 44
	protected virtual bool CheckSuccess(ItemInstance usedItem) { }

	// RVA: 0x74C540 Offset: 0x74AF40 VA: 0x18074C540
	private void StopAllRoutines() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 45
	protected virtual string[] GetRequiredItemSuitableIDs(GrowContainer growContainer) { }

	// RVA: 0x74B680 Offset: 0x74A080 VA: 0x18074B680
	private bool DoesTaskRequireItem(GrowContainer growContainer, out string[] suitableItemIDs) { }

	// RVA: 0x74BB50 Offset: 0x74A550 VA: 0x18074BB50
	private bool IsRequiredItemInInventory(GrowContainer growContainer) { }

	// RVA: 0x74B370 Offset: 0x749D70 VA: 0x18074B370
	private bool DoSuppliesContainRequiredItem(GrowContainer growContainer) { }

	// RVA: 0x74B830 Offset: 0x74A230 VA: 0x18074B830
	private ItemSlot GetSuppliesSlotContainingRequiredItem(string[] suitableItemIDs) { }

	// RVA: 0x74B710 Offset: 0x74A110 VA: 0x18074B710
	protected ItemSlot GetItemSlotContainingRequiredItem(IItemSlotOwner itemSlotOwner, string[] suitableItemIDs) { }

	// RVA: 0x74BAC0 Offset: 0x74A4C0 VA: 0x18074BAC0
	private bool IsAtSupplies() { }

	// RVA: 0x74BA00 Offset: 0x74A400 VA: 0x18074BA00
	private bool IsAtGrowContainer() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	protected void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(GrowContainerBehaviour.<<GrabRequiredItemFromSupplies>g__Routine|36_0>d))]
	// RVA: 0x74C610 Offset: 0x74B010 VA: 0x18074C610
	private IEnumerator <GrabRequiredItemFromSupplies>g__Routine|36_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(GrowContainerBehaviour.<<PerformAction>g__Routine|37_0>d))]
	// RVA: 0x74C680 Offset: 0x74B080 VA: 0x18074C680
	private IEnumerator <PerformAction>g__Routine|37_0() { }

	// RVA: 0x74BCF0 Offset: 0x74A6F0 VA: 0x18074BCF0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x74BCD0 Offset: 0x74A6D0 VA: 0x18074BCD0 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x74B1F0 Offset: 0x749BF0 VA: 0x18074B1F0 Slot: 46
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.GrowContainerBehaviour_Assembly-CSharp.dll() { }
}
