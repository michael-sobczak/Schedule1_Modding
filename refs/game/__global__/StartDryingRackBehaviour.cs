public class StartDryingRackBehaviour : Behaviour // TypeDefIndex: 1824
{
	// Fields
	public const float TIME_PER_ITEM = 1;
	[CompilerGenerated]
	private DryingRack <Rack>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <WorkInProgress>k__BackingField; // 0x170
	private Coroutine workRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartDryingRackBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public DryingRack Rack { get; set; }
	public bool WorkInProgress { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public DryingRack get_Rack() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	protected void set_Rack(DryingRack value) { }

	[CompilerGenerated]
	// RVA: 0x653820 Offset: 0x652220 VA: 0x180653820
	public bool get_WorkInProgress() { }

	[CompilerGenerated]
	// RVA: 0x653A20 Offset: 0x652420 VA: 0x180653A20
	protected void set_WorkInProgress(bool value) { }

	// RVA: 0x755290 Offset: 0x753C90 VA: 0x180755290 Slot: 22
	public override void Activate() { }

	// RVA: 0x755E90 Offset: 0x754890 VA: 0x180755E90 Slot: 25
	public override void Resume() { }

	// RVA: 0x755D70 Offset: 0x754770 VA: 0x180755D70 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x755500 Offset: 0x753F00 VA: 0x180755500 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x755A30 Offset: 0x754430 VA: 0x180755A30 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x756170 Offset: 0x754B70 VA: 0x180756170
	private void StartWork() { }

	// RVA: 0x7552B0 Offset: 0x753CB0 VA: 0x1807552B0
	public void AssignRack(DryingRack rack) { }

	// RVA: 0x7556F0 Offset: 0x7540F0 VA: 0x1807556F0
	public bool IsAtStation() { }

	// RVA: 0x755620 Offset: 0x754020 VA: 0x180755620
	public void GoToStation() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7553E0 Offset: 0x753DE0 VA: 0x1807553E0
	public void BeginAction() { }

	// RVA: 0x736DF0 Offset: 0x7357F0 VA: 0x180736DF0
	private void StopCauldron() { }

	// RVA: 0x7557D0 Offset: 0x7541D0 VA: 0x1807557D0
	public bool IsRackReady(DryingRack rack) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(StartDryingRackBehaviour.<<BeginAction>g__Package|20_0>d))]
	// RVA: 0x756270 Offset: 0x754C70 VA: 0x180756270
	private IEnumerator <BeginAction>g__Package|20_0() { }

	// RVA: 0x7559A0 Offset: 0x7543A0 VA: 0x1807559A0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x756060 Offset: 0x754A60 VA: 0x180756060
	private void RpcWriter___Observers_BeginAction_2166136261() { }

	// RVA: 0x755EB0 Offset: 0x7548B0 VA: 0x180755EB0
	public void RpcLogic___BeginAction_2166136261() { }

	// RVA: 0x756020 Offset: 0x754A20 VA: 0x180756020
	private void RpcReader___Observers_BeginAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
