public class StartCauldronBehaviour : Behaviour // TypeDefIndex: 1820
{
	// Fields
	public const float START_CAULDRON_TIME = 15;
	[CompilerGenerated]
	private Cauldron <Station>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <WorkInProgress>k__BackingField; // 0x170
	private Coroutine workRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartCauldronBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public Cauldron Station { get; set; }
	public bool WorkInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public Cauldron get_Station() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	protected void set_Station(Cauldron value) { }

	[CompilerGenerated]
	// RVA: 0x653820 Offset: 0x652220 VA: 0x180653820
	public bool get_WorkInProgress() { }

	[CompilerGenerated]
	// RVA: 0x653A20 Offset: 0x652420 VA: 0x180653A20
	protected void set_WorkInProgress(bool value) { }

	// RVA: 0x752B70 Offset: 0x751570 VA: 0x180752B70 Slot: 22
	public override void Activate() { }

	// RVA: 0x753680 Offset: 0x752080 VA: 0x180753680 Slot: 25
	public override void Resume() { }

	// RVA: 0x753570 Offset: 0x751F70 VA: 0x180753570 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x752E50 Offset: 0x751850 VA: 0x180752E50 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7532B0 Offset: 0x751CB0 VA: 0x1807532B0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x753960 Offset: 0x752360 VA: 0x180753960
	private void StartWork() { }

	// RVA: 0x752B90 Offset: 0x751590 VA: 0x180752B90
	public void AssignStation(Cauldron station) { }

	// RVA: 0x752FE0 Offset: 0x7519E0 VA: 0x180752FE0
	public bool IsAtStation() { }

	// RVA: 0x752F60 Offset: 0x751960 VA: 0x180752F60
	public void GoToStation() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x752D30 Offset: 0x751730 VA: 0x180752D30
	public void BeginCauldron() { }

	// RVA: 0x753A60 Offset: 0x752460 VA: 0x180753A60
	private void StopCauldron() { }

	// RVA: 0x753070 Offset: 0x751A70 VA: 0x180753070
	public bool IsStationReady(Cauldron station) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(StartCauldronBehaviour.<<BeginCauldron>g__Package|20_0>d))]
	[CompilerGenerated]
	// RVA: 0x753B70 Offset: 0x752570 VA: 0x180753B70
	private IEnumerator <BeginCauldron>g__Package|20_0() { }

	// RVA: 0x753220 Offset: 0x751C20 VA: 0x180753220 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x753850 Offset: 0x752250 VA: 0x180753850
	private void RpcWriter___Observers_BeginCauldron_2166136261() { }

	// RVA: 0x7536A0 Offset: 0x7520A0 VA: 0x1807536A0
	public void RpcLogic___BeginCauldron_2166136261() { }

	// RVA: 0x753810 Offset: 0x752210 VA: 0x180753810
	private void RpcReader___Observers_BeginCauldron_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
