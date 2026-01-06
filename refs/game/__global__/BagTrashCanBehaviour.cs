public class BagTrashCanBehaviour : Behaviour // TypeDefIndex: 1789
{
	// Fields
	public const float ACTION_MAX_DISTANCE = 2;
	public const float BAG_TIME = 3;
	[CompilerGenerated]
	private TrashContainerItem <TargetTrashCan>k__BackingField; // 0x168
	private Coroutine actionCoroutine; // 0x170
	public UnityEvent onPerfomAction; // 0x178
	public UnityEvent onPerfomDone; // 0x180
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted; // 0x188
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BagTrashCanBehaviourAssembly-CSharp.dll_Excuted; // 0x189

	// Properties
	public TrashContainerItem TargetTrashCan { get; set; }
	private Cleaner Cleaner { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public TrashContainerItem get_TargetTrashCan() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set_TargetTrashCan(TrashContainerItem value) { }

	// RVA: 0x731520 Offset: 0x72FF20 VA: 0x180731520
	private Cleaner get_Cleaner() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void SetTargetTrashCan(TrashContainerItem trashCan) { }

	// RVA: 0x730410 Offset: 0x72EE10 VA: 0x180730410 Slot: 22
	public override void Activate() { }

	// RVA: 0x730FB0 Offset: 0x72F9B0 VA: 0x180730FB0 Slot: 25
	public override void Resume() { }

	// RVA: 0x731230 Offset: 0x72FC30 VA: 0x180731230
	private void StartAction() { }

	// RVA: 0x730E70 Offset: 0x72F870 VA: 0x180730E70 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x730630 Offset: 0x72F030 VA: 0x180730630 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x731310 Offset: 0x72FD10 VA: 0x180731310
	private void StopAllActions() { }

	// RVA: 0x730A20 Offset: 0x72F420 VA: 0x180730A20 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x730690 Offset: 0x72F090 VA: 0x180730690
	private void GoToTarget() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x730E90 Offset: 0x72F890 VA: 0x180730E90
	private void PerformAction() { }

	// RVA: 0x7307E0 Offset: 0x72F1E0 VA: 0x1807307E0
	private bool IsAtDestination() { }

	// RVA: 0x730430 Offset: 0x72EE30 VA: 0x180730430
	private bool AreActionConditionsMet(bool checkAccess) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(BagTrashCanBehaviour.<<PerformAction>g__Action|21_0>d))]
	[CompilerGenerated]
	// RVA: 0x7314A0 Offset: 0x72FEA0 VA: 0x1807314A0
	private IEnumerator <PerformAction>g__Action|21_0() { }

	// RVA: 0x730980 Offset: 0x72F380 VA: 0x180730980 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x730950 Offset: 0x72F350 VA: 0x180730950 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x731120 Offset: 0x72FB20 VA: 0x180731120
	private void RpcWriter___Observers_PerformAction_2166136261() { }

	// RVA: 0x730FD0 Offset: 0x72F9D0 VA: 0x180730FD0
	private void RpcLogic___PerformAction_2166136261() { }

	// RVA: 0x7310E0 Offset: 0x72FAE0 VA: 0x1807310E0
	private void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
