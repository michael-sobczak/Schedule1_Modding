public class DisposeTrashBagBehaviour : Behaviour // TypeDefIndex: 1794
{
	// Fields
	public string TRASH_BAG_ASSET_PATH; // 0x168
	public const float GRAB_MAX_DISTANCE = 2;
	[CompilerGenerated]
	private TrashBag <TargetBag>k__BackingField; // 0x170
	private TrashContent heldTrash; // 0x178
	private Coroutine grabRoutine; // 0x180
	private Coroutine dropRoutine; // 0x188
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviourAssembly-CSharp.dll_Excuted; // 0x190
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.DisposeTrashBagBehaviourAssembly-CSharp.dll_Excuted; // 0x191

	// Properties
	public TrashBag TargetBag { get; set; }
	private Cleaner Cleaner { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public TrashBag get_TargetBag() { }

	[CompilerGenerated]
	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	private void set_TargetBag(TrashBag value) { }

	// RVA: 0x740280 Offset: 0x73EC80 VA: 0x180740280
	private Cleaner get_Cleaner() { }

	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	public void SetTargetBag(TrashBag bag) { }

	// RVA: 0x73ED60 Offset: 0x73D760 VA: 0x18073ED60 Slot: 22
	public override void Activate() { }

	// RVA: 0x73F9D0 Offset: 0x73E3D0 VA: 0x18073F9D0 Slot: 25
	public override void Resume() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void StartAction() { }

	// RVA: 0x73F9B0 Offset: 0x73E3B0 VA: 0x18073F9B0 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x73EF20 Offset: 0x73D920 VA: 0x18073EF20 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x73FEB0 Offset: 0x73E8B0 VA: 0x18073FEB0
	private void StopAllActions() { }

	// RVA: 0x73F610 Offset: 0x73E010 VA: 0x18073F610 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x73F060 Offset: 0x73DA60 VA: 0x18073F060
	private void GoToTarget() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x73F190 Offset: 0x73DB90 VA: 0x18073F190
	private void GrabTrash() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x73EF40 Offset: 0x73D940 VA: 0x18073EF40
	private void DropTrash() { }

	// RVA: 0x73F2B0 Offset: 0x73DCB0 VA: 0x18073F2B0
	private bool IsAtDestination() { }

	// RVA: 0x73ED70 Offset: 0x73D770 VA: 0x18073ED70
	private bool AreActionConditionsMet(bool checkAccess) { }

	// RVA: 0x740220 Offset: 0x73EC20 VA: 0x180740220
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(DisposeTrashBagBehaviour.<<GrabTrash>g__Action|21_0>d))]
	// RVA: 0x7401B0 Offset: 0x73EBB0 VA: 0x1807401B0
	private IEnumerator <GrabTrash>g__Action|21_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(DisposeTrashBagBehaviour.<<DropTrash>g__Action|22_0>d))]
	// RVA: 0x740140 Offset: 0x73EB40 VA: 0x180740140
	private IEnumerator <DropTrash>g__Action|22_0() { }

	// RVA: 0x73F530 Offset: 0x73DF30 VA: 0x18073F530 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x73F500 Offset: 0x73DF00 VA: 0x18073F500 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x73FDA0 Offset: 0x73E7A0 VA: 0x18073FDA0
	private void RpcWriter___Observers_GrabTrash_2166136261() { }

	// RVA: 0x73FAF0 Offset: 0x73E4F0 VA: 0x18073FAF0
	private void RpcLogic___GrabTrash_2166136261() { }

	// RVA: 0x73FC40 Offset: 0x73E640 VA: 0x18073FC40
	private void RpcReader___Observers_GrabTrash_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x73FC80 Offset: 0x73E680 VA: 0x18073FC80
	private void RpcWriter___Observers_DropTrash_2166136261() { }

	// RVA: 0x73F9E0 Offset: 0x73E3E0 VA: 0x18073F9E0
	private void RpcLogic___DropTrash_2166136261() { }

	// RVA: 0x73FC00 Offset: 0x73E600 VA: 0x18073FC00
	private void RpcReader___Observers_DropTrash_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
