public class StartLabOvenBehaviour : Behaviour // TypeDefIndex: 1826
{
	// Fields
	public const float POUR_TIME = 5;
	[CompilerGenerated]
	private LabOven <targetOven>k__BackingField; // 0x168
	private Chemist chemist; // 0x170
	private Coroutine cookRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartLabOvenBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartLabOvenBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public LabOven targetOven { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public LabOven get_targetOven() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set_targetOven(LabOven value) { }

	// RVA: 0x7563D0 Offset: 0x754DD0 VA: 0x1807563D0 Slot: 19
	public override void Awake() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void SetTargetOven(LabOven oven) { }

	// RVA: 0x756620 Offset: 0x755020 VA: 0x180756620 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x756A20 Offset: 0x755420 VA: 0x180756A20 Slot: 28
	public override void OnActiveTick() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x757030 Offset: 0x755A30 VA: 0x180757030
	private void StartCook() { }

	// RVA: 0x7564E0 Offset: 0x754EE0 VA: 0x1807564E0
	private bool CanCookStart() { }

	// RVA: 0x757150 Offset: 0x755B50 VA: 0x180757150
	private void StopCook() { }

	// RVA: 0x7566E0 Offset: 0x7550E0 VA: 0x1807566E0
	private Vector3 GetStationAccessPoint() { }

	// RVA: 0x7567E0 Offset: 0x7551E0 VA: 0x1807567E0
	private bool IsAtStation() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(StartLabOvenBehaviour.<<StartCook>g__CookRoutine|11_0>d))]
	// RVA: 0x757210 Offset: 0x755C10 VA: 0x180757210
	private IEnumerator <StartCook>g__CookRoutine|11_0() { }

	// RVA: 0x756990 Offset: 0x755390 VA: 0x180756990 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x756F20 Offset: 0x755920 VA: 0x180756F20
	private void RpcWriter___Observers_StartCook_2166136261() { }

	// RVA: 0x756E00 Offset: 0x755800 VA: 0x180756E00
	private void RpcLogic___StartCook_2166136261() { }

	// RVA: 0x756EE0 Offset: 0x7558E0 VA: 0x180756EE0
	private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7562E0 Offset: 0x754CE0 VA: 0x1807562E0 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartLabOvenBehaviour_Assembly-CSharp.dll() { }
}
