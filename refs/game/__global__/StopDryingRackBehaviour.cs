public class StopDryingRackBehaviour : Behaviour // TypeDefIndex: 1830
{
	// Fields
	public const float TIME_PER_ITEM = 1;
	[CompilerGenerated]
	private DryingRack <Rack>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <WorkInProgress>k__BackingField; // 0x170
	private Coroutine workRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StopDryingRackBehaviourAssembly-CSharp.dll_Excuted; // 0x181

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

	// RVA: 0x758360 Offset: 0x756D60 VA: 0x180758360 Slot: 22
	public override void Activate() { }

	// RVA: 0x758FC0 Offset: 0x7579C0 VA: 0x180758FC0 Slot: 25
	public override void Resume() { }

	// RVA: 0x736970 Offset: 0x735370 VA: 0x180736970 Slot: 24
	public override void Pause() { }

	// RVA: 0x730650 Offset: 0x72F050 VA: 0x180730650 Slot: 21
	public override void Disable() { }

	// RVA: 0x758640 Offset: 0x757040 VA: 0x180758640 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x758C80 Offset: 0x757680 VA: 0x180758C80 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x7592A0 Offset: 0x757CA0 VA: 0x1807592A0
	private void StartWork() { }

	// RVA: 0x758380 Offset: 0x756D80 VA: 0x180758380
	public void AssignRack(DryingRack rack) { }

	// RVA: 0x758830 Offset: 0x757230 VA: 0x180758830
	public bool IsAtStation() { }

	// RVA: 0x758760 Offset: 0x757160 VA: 0x180758760
	public void GoToStation() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x758520 Offset: 0x756F20 VA: 0x180758520
	public void BeginAction() { }

	// RVA: 0x736DF0 Offset: 0x7357F0 VA: 0x180736DF0
	private void StopCauldron() { }

	// RVA: 0x758910 Offset: 0x757310 VA: 0x180758910
	public bool IsRackReady(DryingRack rack) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(StopDryingRackBehaviour.<<BeginAction>g__Package|20_0>d))]
	// RVA: 0x7593F0 Offset: 0x757DF0 VA: 0x1807593F0
	private IEnumerator <BeginAction>g__Package|20_0() { }

	[CompilerGenerated]
	// RVA: 0x7593A0 Offset: 0x757DA0 VA: 0x1807593A0
	private bool <BeginAction>b__20_1(DryingOperation x) { }

	// RVA: 0x758BF0 Offset: 0x7575F0 VA: 0x180758BF0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x759190 Offset: 0x757B90 VA: 0x180759190
	private void RpcWriter___Observers_BeginAction_2166136261() { }

	// RVA: 0x758FE0 Offset: 0x7579E0 VA: 0x180758FE0
	public void RpcLogic___BeginAction_2166136261() { }

	// RVA: 0x759150 Offset: 0x757B50 VA: 0x180759150
	private void RpcReader___Observers_BeginAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
