public class PickUpTrashBehaviour : Behaviour // TypeDefIndex: 1817
{
	// Fields
	public const float ACTION_MAX_DISTANCE = 2;
	public const string EQUIPPABLE_ASSET_PATH = "Tools/TrashGrabber/TrashGrabber_AvatarEquippable";
	[CompilerGenerated]
	private TrashItem <TargetTrash>k__BackingField; // 0x168
	private Coroutine actionCoroutine; // 0x170
	public UnityEvent onPerfomAction; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PickUpTrashBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public TrashItem TargetTrash { get; set; }
	private Cleaner Cleaner { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public TrashItem get_TargetTrash() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set_TargetTrash(TrashItem value) { }

	// RVA: 0x7525D0 Offset: 0x750FD0 VA: 0x1807525D0
	private Cleaner get_Cleaner() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void SetTargetTrash(TrashItem trash) { }

	// RVA: 0x751760 Offset: 0x750160 VA: 0x180751760 Slot: 22
	public override void Activate() { }

	// RVA: 0x752070 Offset: 0x750A70 VA: 0x180752070 Slot: 25
	public override void Resume() { }

	// RVA: 0x752350 Offset: 0x750D50 VA: 0x180752350
	private void StartAction() { }

	// RVA: 0x751F30 Offset: 0x750930 VA: 0x180751F30 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x7518B0 Offset: 0x7502B0 VA: 0x1807518B0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x752450 Offset: 0x750E50 VA: 0x180752450
	private void StopAllActions() { }

	// RVA: 0x751A70 Offset: 0x750470 VA: 0x180751A70 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x7518D0 Offset: 0x7502D0 VA: 0x1807518D0
	private void GoToTarget() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x751F50 Offset: 0x750950 VA: 0x180751F50
	private void PerformAction() { }

	// RVA: 0x747BF0 Offset: 0x7465F0 VA: 0x180747BF0
	private bool IsAtDestination() { }

	// RVA: 0x751780 Offset: 0x750180 VA: 0x180751780
	private bool AreActionConditionsMet(bool checkAccess) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(PickUpTrashBehaviour.<<PerformAction>g__Action|20_0>d))]
	[CompilerGenerated]
	// RVA: 0x752560 Offset: 0x750F60 VA: 0x180752560
	private IEnumerator <PerformAction>g__Action|20_0() { }

	// RVA: 0x7519E0 Offset: 0x7503E0 VA: 0x1807519E0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x752240 Offset: 0x750C40 VA: 0x180752240
	private void RpcWriter___Observers_PerformAction_2166136261() { }

	// RVA: 0x752090 Offset: 0x750A90 VA: 0x180752090
	private void RpcLogic___PerformAction_2166136261() { }

	// RVA: 0x752200 Offset: 0x750C00 VA: 0x180752200
	private void RpcReader___Observers_PerformAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
