public class PackagingStationBehaviour : Behaviour // TypeDefIndex: 1815
{
	// Fields
	public const float BASE_PACKAGING_TIME = 5;
	[CompilerGenerated]
	private PackagingStation <Station>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <PackagingInProgress>k__BackingField; // 0x170
	private Coroutine packagingRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PackagingStationBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PackagingStationBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public PackagingStation Station { get; set; }
	public bool PackagingInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public PackagingStation get_Station() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	protected void set_Station(PackagingStation value) { }

	[CompilerGenerated]
	// RVA: 0x653820 Offset: 0x652220 VA: 0x180653820
	public bool get_PackagingInProgress() { }

	[CompilerGenerated]
	// RVA: 0x653A20 Offset: 0x652420 VA: 0x180653A20
	protected void set_PackagingInProgress(bool value) { }

	// RVA: 0x750950 Offset: 0x74F350 VA: 0x180750950 Slot: 22
	public override void Activate() { }

	// RVA: 0x7511B0 Offset: 0x74FBB0 VA: 0x1807511B0 Slot: 25
	public override void Resume() { }

	// RVA: 0x751180 Offset: 0x74FB80 VA: 0x180751180 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x750A90 Offset: 0x74F490 VA: 0x180750A90 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x750EC0 Offset: 0x74F8C0 VA: 0x180750EC0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x751490 Offset: 0x74FE90 VA: 0x180751490
	private void StartPackaging() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void AssignStation(PackagingStation station) { }

	// RVA: 0x750C20 Offset: 0x74F620 VA: 0x180750C20
	public bool IsAtStation() { }

	// RVA: 0x750BA0 Offset: 0x74F5A0 VA: 0x180750BA0
	public void GoToStation() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x750970 Offset: 0x74F370 VA: 0x180750970
	public void BeginPackaging() { }

	// RVA: 0x751590 Offset: 0x74FF90 VA: 0x180751590
	private void StopPackaging() { }

	// RVA: 0x750CB0 Offset: 0x74F6B0 VA: 0x180750CB0
	public bool IsStationReady(PackagingStation station) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(PackagingStationBehaviour.<<BeginPackaging>g__Package|20_0>d))]
	[CompilerGenerated]
	// RVA: 0x7516F0 Offset: 0x7500F0 VA: 0x1807516F0
	private IEnumerator <BeginPackaging>g__Package|20_0() { }

	// RVA: 0x750E30 Offset: 0x74F830 VA: 0x180750E30 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x751380 Offset: 0x74FD80 VA: 0x180751380
	private void RpcWriter___Observers_BeginPackaging_2166136261() { }

	// RVA: 0x7511D0 Offset: 0x74FBD0 VA: 0x1807511D0
	public void RpcLogic___BeginPackaging_2166136261() { }

	// RVA: 0x751340 Offset: 0x74FD40 VA: 0x180751340
	private void RpcReader___Observers_BeginPackaging_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
