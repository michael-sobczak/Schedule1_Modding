public class EmptyTrashGrabberBehaviour : Behaviour // TypeDefIndex: 1796
{
	// Fields
	public const float ACTION_MAX_DISTANCE = 2;
	public const string EQUIPPABLE_ASSET_PATH = "Tools/TrashGrabber/Bin_AvatarEquippable";
	[CompilerGenerated]
	private TrashContainerItem <TargetTrashCan>k__BackingField; // 0x168
	private Coroutine actionCoroutine; // 0x170
	public UnityEvent onPerfomAction; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.EmptyTrashGrabberBehaviourAssembly-CSharp.dll_Excuted; // 0x181

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

	// RVA: 0x748860 Offset: 0x747260 VA: 0x180748860
	private Cleaner get_Cleaner() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void SetTargetTrashCan(TrashContainerItem trashCan) { }

	// RVA: 0x747910 Offset: 0x746310 VA: 0x180747910 Slot: 22
	public override void Activate() { }

	// RVA: 0x748360 Offset: 0x746D60 VA: 0x180748360 Slot: 25
	public override void Resume() { }

	// RVA: 0x7485E0 Offset: 0x746FE0 VA: 0x1807485E0
	private void StartAction() { }

	// RVA: 0x748220 Offset: 0x746C20 VA: 0x180748220 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x747AA0 Offset: 0x7464A0 VA: 0x180747AA0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7486E0 Offset: 0x7470E0 VA: 0x1807486E0
	private void StopAllActions() { }

	// RVA: 0x747E00 Offset: 0x746800 VA: 0x180747E00 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x747AC0 Offset: 0x7464C0 VA: 0x180747AC0
	private void GoToTarget() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x748240 Offset: 0x746C40 VA: 0x180748240
	private void PerformAction() { }

	// RVA: 0x747BF0 Offset: 0x7465F0 VA: 0x180747BF0
	private bool IsAtDestination() { }

	// RVA: 0x747930 Offset: 0x746330 VA: 0x180747930
	private bool AreActionConditionsMet(bool checkAccess) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(EmptyTrashGrabberBehaviour.<<PerformAction>g__Action|20_0>d))]
	[CompilerGenerated]
	// RVA: 0x7487F0 Offset: 0x7471F0 VA: 0x1807487F0
	private IEnumerator <PerformAction>g__Action|20_0() { }

	// RVA: 0x747D70 Offset: 0x746770 VA: 0x180747D70 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7484D0 Offset: 0x746ED0 VA: 0x1807484D0
	private void RpcWriter___Observers_PerformAction_2166136261() { }

	// RVA: 0x748380 Offset: 0x746D80 VA: 0x180748380
	private void RpcLogic___PerformAction_2166136261() { }

	// RVA: 0x748490 Offset: 0x746E90 VA: 0x180748490
	private void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
