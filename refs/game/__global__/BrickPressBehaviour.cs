public class BrickPressBehaviour : Behaviour // TypeDefIndex: 1791
{
	// Fields
	public const float BASE_PACKAGING_TIME = 15;
	[CompilerGenerated]
	private BrickPress <Press>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <PackagingInProgress>k__BackingField; // 0x170
	private Coroutine packagingRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BrickPressBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public BrickPress Press { get; set; }
	public bool PackagingInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public BrickPress get_Press() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	protected void set_Press(BrickPress value) { }

	[CompilerGenerated]
	// RVA: 0x653820 Offset: 0x652220 VA: 0x180653820
	public bool get_PackagingInProgress() { }

	[CompilerGenerated]
	// RVA: 0x653A20 Offset: 0x652420 VA: 0x180653A20
	protected void set_PackagingInProgress(bool value) { }

	// RVA: 0x736050 Offset: 0x734A50 VA: 0x180736050 Slot: 22
	public override void Activate() { }

	// RVA: 0x7369C0 Offset: 0x7353C0 VA: 0x1807369C0 Slot: 25
	public override void Resume() { }

	// RVA: 0x736970 Offset: 0x735370 VA: 0x180736970 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x736190 Offset: 0x734B90 VA: 0x180736190 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7366A0 Offset: 0x7350A0 VA: 0x1807366A0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x736CB0 Offset: 0x7356B0 VA: 0x180736CB0
	private void StartPackaging() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void AssignStation(BrickPress press) { }

	// RVA: 0x736340 Offset: 0x734D40 VA: 0x180736340
	public bool IsAtStation() { }

	// RVA: 0x7362C0 Offset: 0x734CC0 VA: 0x1807362C0
	public void GoToStation() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x736070 Offset: 0x734A70 VA: 0x180736070
	public void BeginPackaging() { }

	// RVA: 0x736DF0 Offset: 0x7357F0 VA: 0x180736DF0
	private void StopPackaging() { }

	// RVA: 0x7363D0 Offset: 0x734DD0 VA: 0x1807363D0
	public bool IsStationReady(BrickPress press) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(BrickPressBehaviour.<<BeginPackaging>g__Package|20_0>d))]
	// RVA: 0x736E30 Offset: 0x735830 VA: 0x180736E30
	private IEnumerator <BeginPackaging>g__Package|20_0() { }

	// RVA: 0x736600 Offset: 0x735000 VA: 0x180736600 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7365D0 Offset: 0x734FD0 VA: 0x1807365D0 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x736BA0 Offset: 0x7355A0 VA: 0x180736BA0
	private void RpcWriter___Observers_BeginPackaging_2166136261() { }

	// RVA: 0x7369E0 Offset: 0x7353E0 VA: 0x1807369E0
	public void RpcLogic___BeginPackaging_2166136261() { }

	// RVA: 0x736B60 Offset: 0x735560 VA: 0x180736B60
	private void RpcReader___Observers_BeginPackaging_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
