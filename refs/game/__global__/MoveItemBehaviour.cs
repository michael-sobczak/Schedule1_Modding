public class MoveItemBehaviour : Behaviour // TypeDefIndex: 1813
{
	// Fields
	[CompilerGenerated]
	private bool <Initialized>k__BackingField; // 0x168
	private TransitRoute assignedRoute; // 0x170
	private ItemInstance itemToRetrieveTemplate; // 0x178
	private int grabbedAmount; // 0x180
	private int maxMoveAmount; // 0x184
	private MoveItemBehaviour.EState currentState; // 0x188
	private Coroutine walkToSourceRoutine; // 0x190
	private Coroutine grabRoutine; // 0x198
	private Coroutine walkToDestinationRoutine; // 0x1A0
	private Coroutine placingRoutine; // 0x1A8
	private bool skipPickup; // 0x1B0
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted; // 0x1B1
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.MoveItemBehaviourAssembly-CSharp.dll_Excuted; // 0x1B2

	// Properties
	public bool Initialized { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x617FF0 Offset: 0x6169F0 VA: 0x180617FF0
	public bool get_Initialized() { }

	[CompilerGenerated]
	// RVA: 0x618110 Offset: 0x616B10 VA: 0x180618110
	protected void set_Initialized(bool value) { }

	// RVA: 0x74E650 Offset: 0x74D050 VA: 0x18074E650
	public void Initialize(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1, bool _skipPickup = False) { }

	// RVA: 0x74FCF0 Offset: 0x74E6F0 VA: 0x18074FCF0
	public void Resume(TransitRoute route, ItemInstance _itemToRetrieveTemplate, int _maxMoveAmount = -1) { }

	// RVA: 0x74DD80 Offset: 0x74C780 VA: 0x18074DD80 Slot: 22
	public override void Activate() { }

	// RVA: 0x74FBB0 Offset: 0x74E5B0 VA: 0x18074FBB0 Slot: 24
	public override void Pause() { }

	// RVA: 0x74FCD0 Offset: 0x74E6D0 VA: 0x18074FCD0 Slot: 25
	public override void Resume() { }

	// RVA: 0x74DED0 Offset: 0x74C8D0 VA: 0x18074DED0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x74FD50 Offset: 0x74E750 VA: 0x18074FD50
	private void StartTransit() { }

	// RVA: 0x74EE20 Offset: 0x74D820 VA: 0x18074EE20
	private bool IsNpcInventoryItemValid(ItemInstance item) { }

	// RVA: 0x74DFF0 Offset: 0x74C9F0 VA: 0x18074DFF0
	private void EndTransit() { }

	// RVA: 0x74F540 Offset: 0x74DF40 VA: 0x18074F540 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x750700 Offset: 0x74F100 VA: 0x180750700
	public void WalkToSource() { }

	// RVA: 0x74E550 Offset: 0x74CF50 VA: 0x18074E550
	public void GrabItem() { }

	// RVA: 0x750020 Offset: 0x74EA20 VA: 0x180750020
	private void TakeItem() { }

	// RVA: 0x750530 Offset: 0x74EF30 VA: 0x180750530
	public void WalkToDestination() { }

	// RVA: 0x74FBD0 Offset: 0x74E5D0 VA: 0x18074FBD0
	public void PlaceItem() { }

	// RVA: 0x74E100 Offset: 0x74CB00 VA: 0x18074E100
	private int GetAmountToGrab() { }

	// RVA: 0x74FF90 Offset: 0x74E990 VA: 0x18074FF90
	private void StopCurrentActivity() { }

	// RVA: 0x74EEB0 Offset: 0x74D8B0 VA: 0x18074EEB0
	public bool IsTransitRouteValid(TransitRoute route, string itemID, out string invalidReason) { }

	// RVA: 0x74F130 Offset: 0x74DB30 VA: 0x18074F130
	public bool IsTransitRouteValid(TransitRoute route, ItemInstance templateItem, out string invalidReason) { }

	// RVA: 0x74F110 Offset: 0x74DB10 VA: 0x18074F110
	public bool IsTransitRouteValid(TransitRoute route, string itemID) { }

	// RVA: 0x74EC90 Offset: 0x74D690 VA: 0x18074EC90
	public bool IsDestinationValid(TransitRoute route, ItemInstance item) { }

	// RVA: 0x74DE10 Offset: 0x74C810 VA: 0x18074DE10
	public bool CanGetToSource(TransitRoute route) { }

	// RVA: 0x74E4D0 Offset: 0x74CED0 VA: 0x18074E4D0
	private Transform GetSourceAccessPoint(TransitRoute route) { }

	// RVA: 0x74EC00 Offset: 0x74D600 VA: 0x18074EC00
	private bool IsAtSource() { }

	// RVA: 0x74DDA0 Offset: 0x74C7A0 VA: 0x18074DDA0
	public bool CanGetToDestination(TransitRoute route) { }

	// RVA: 0x74E200 Offset: 0x74CC00 VA: 0x18074E200
	private Transform GetDestinationAccessPoint(TransitRoute route) { }

	// RVA: 0x74E910 Offset: 0x74D310 VA: 0x18074E910
	private bool IsAtDestination() { }

	// RVA: 0x74E2D0 Offset: 0x74CCD0 VA: 0x18074E2D0
	public MoveItemData GetSaveData() { }

	// RVA: 0x74F2A0 Offset: 0x74DCA0 VA: 0x18074F2A0
	public void Load(MoveItemData moveItemData) { }

	// RVA: 0x750930 Offset: 0x74F330 VA: 0x180750930
	public void .ctor() { }

	[IteratorStateMachine(typeof(MoveItemBehaviour.<<WalkToSource>g__Routine|26_0>d))]
	[CompilerGenerated]
	// RVA: 0x7504C0 Offset: 0x74EEC0 VA: 0x1807504C0
	private IEnumerator <WalkToSource>g__Routine|26_0() { }

	[CompilerGenerated]
	// RVA: 0x750420 Offset: 0x74EE20 VA: 0x180750420
	private bool <WalkToSource>b__26_1() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(MoveItemBehaviour.<<GrabItem>g__Routine|27_0>d))]
	// RVA: 0x750340 Offset: 0x74ED40 VA: 0x180750340
	private IEnumerator <GrabItem>g__Routine|27_0() { }

	[IteratorStateMachine(typeof(MoveItemBehaviour.<<WalkToDestination>g__Routine|29_0>d))]
	[CompilerGenerated]
	// RVA: 0x750450 Offset: 0x74EE50 VA: 0x180750450
	private IEnumerator <WalkToDestination>g__Routine|29_0() { }

	[CompilerGenerated]
	// RVA: 0x750420 Offset: 0x74EE20 VA: 0x180750420
	private bool <WalkToDestination>b__29_1() { }

	[IteratorStateMachine(typeof(MoveItemBehaviour.<<PlaceItem>g__Routine|30_0>d))]
	[CompilerGenerated]
	// RVA: 0x7503B0 Offset: 0x74EDB0 VA: 0x1807503B0
	private IEnumerator <PlaceItem>g__Routine|30_0() { }

	// RVA: 0x74F520 Offset: 0x74DF20 VA: 0x18074F520 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x74F500 Offset: 0x74DF00 VA: 0x18074F500 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
