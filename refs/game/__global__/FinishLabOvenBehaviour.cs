public class FinishLabOvenBehaviour : Behaviour // TypeDefIndex: 1798
{
	// Fields
	public const float HARVEST_TIME = 10;
	[CompilerGenerated]
	private LabOven <targetOven>k__BackingField; // 0x168
	private Chemist chemist; // 0x170
	private Coroutine actionRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public LabOven targetOven { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public LabOven get_targetOven() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set_targetOven(LabOven value) { }

	// RVA: 0x74A1B0 Offset: 0x748BB0 VA: 0x18074A1B0 Slot: 19
	public override void Awake() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void SetTargetOven(LabOven oven) { }

	// RVA: 0x74A420 Offset: 0x748E20 VA: 0x18074A420 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x74A850 Offset: 0x749250 VA: 0x18074A850 Slot: 28
	public override void OnActiveTick() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x74AE60 Offset: 0x749860 VA: 0x18074AE60
	private void StartAction() { }

	// RVA: 0x74A2C0 Offset: 0x748CC0 VA: 0x18074A2C0
	private bool CanActionStart() { }

	// RVA: 0x74AF80 Offset: 0x749980 VA: 0x18074AF80
	private void StopAction() { }

	// RVA: 0x74A510 Offset: 0x748F10 VA: 0x18074A510
	private Vector3 GetStationAccessPoint() { }

	// RVA: 0x74A610 Offset: 0x749010 VA: 0x18074A610
	private bool IsAtStation() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(FinishLabOvenBehaviour.<<StartAction>g__ActionRoutine|11_0>d))]
	[CompilerGenerated]
	// RVA: 0x74B070 Offset: 0x749A70 VA: 0x18074B070
	private IEnumerator <StartAction>g__ActionRoutine|11_0() { }

	// RVA: 0x74A7C0 Offset: 0x7491C0 VA: 0x18074A7C0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x74AD50 Offset: 0x749750 VA: 0x18074AD50
	private void RpcWriter___Observers_StartAction_2166136261() { }

	// RVA: 0x74AC30 Offset: 0x749630 VA: 0x18074AC30
	private void RpcLogic___StartAction_2166136261() { }

	// RVA: 0x74AD10 Offset: 0x749710 VA: 0x18074AD10
	private void RpcReader___Observers_StartAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x74A0C0 Offset: 0x748AC0 VA: 0x18074A0C0 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.FinishLabOvenBehaviour_Assembly-CSharp.dll() { }
}
