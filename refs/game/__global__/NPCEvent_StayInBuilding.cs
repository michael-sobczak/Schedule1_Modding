public class NPCEvent_StayInBuilding : NPCEvent // TypeDefIndex: 1878
{
	// Fields
	public NPCEnterableBuilding Building; // 0x158
	[Header("Optionally specify door to use. Otherwise closest door will be used.")]
	public StaticDoor Door; // 0x160
	private bool IsEntering; // 0x168
	private Coroutine enterRoutine; // 0x170
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted; // 0x178
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_StayInBuildingAssembly-CSharp.dll_Excuted; // 0x179

	// Properties
	public string ActionName { get; }
	private bool InBuilding { get; }

	// Methods

	// RVA: 0x787590 Offset: 0x785F90 VA: 0x180787590
	public string get_ActionName() { }

	// RVA: 0x7875C0 Offset: 0x785FC0 VA: 0x1807875C0
	private bool get_InBuilding() { }

	// RVA: 0x77F5D0 Offset: 0x77DFD0 VA: 0x18077F5D0 Slot: 20
	public override void Awake() { }

	// RVA: 0x7867F0 Offset: 0x7851F0 VA: 0x1807867F0 Slot: 36
	public override string GetName() { }

	// RVA: 0x7873D0 Offset: 0x785DD0 VA: 0x1807873D0 Slot: 22
	public override void Started() { }

	// RVA: 0x786C20 Offset: 0x785620 VA: 0x180786C20 Slot: 31
	public override void OnActiveTick() { }

	// RVA: 0x786A50 Offset: 0x785450 VA: 0x180786A50 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x7869D0 Offset: 0x7853D0 VA: 0x1807869D0 Slot: 24
	public override void JumpTo() { }

	// RVA: 0x786290 Offset: 0x784C90 VA: 0x180786290 Slot: 25
	public override void End() { }

	// RVA: 0x786910 Offset: 0x785310 VA: 0x180786910 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x7873C0 Offset: 0x785DC0 VA: 0x1807873C0 Slot: 29
	public override void Skipped() { }

	// RVA: 0x7870E0 Offset: 0x785AE0 VA: 0x1807870E0 Slot: 27
	public override void Resume() { }

	// RVA: 0x787540 Offset: 0x785F40 VA: 0x180787540 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x786FC0 Offset: 0x7859C0 VA: 0x180786FC0
	private void PlayEnterAnimation() { }

	// RVA: 0x786260 Offset: 0x784C60 VA: 0x180786260
	private void CancelEnter() { }

	// RVA: 0x786350 Offset: 0x784D50 VA: 0x180786350 Slot: 44
	protected virtual void EnterBuilding(int doorIndex) { }

	// RVA: 0x786470 Offset: 0x784E70 VA: 0x180786470
	private void ExitBuilding() { }

	// RVA: 0x786690 Offset: 0x785090 VA: 0x180786690
	private Transform GetEntryPoint() { }

	// RVA: 0x7864D0 Offset: 0x784ED0 VA: 0x1807864D0
	private StaticDoor GetDoor(out int doorIndex) { }

	// RVA: 0x77FB70 Offset: 0x77E570 VA: 0x18077FB70
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(NPCEvent_StayInBuilding.<<PlayEnterAnimation>g__Enter|19_0>d))]
	// RVA: 0x7874D0 Offset: 0x785ED0 VA: 0x1807874D0
	private IEnumerator <PlayEnterAnimation>g__Enter|19_0() { }

	[CompilerGenerated]
	// RVA: 0x7874A0 Offset: 0x785EA0 VA: 0x1807874A0
	private bool <PlayEnterAnimation>b__19_1() { }

	// RVA: 0x786B70 Offset: 0x785570 VA: 0x180786B70 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x786B30 Offset: 0x785530 VA: 0x180786B30 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7872B0 Offset: 0x785CB0 VA: 0x1807872B0
	private void RpcWriter___Observers_PlayEnterAnimation_2166136261() { }

	// RVA: 0x787160 Offset: 0x785B60 VA: 0x180787160
	private void RpcLogic___PlayEnterAnimation_2166136261() { }

	// RVA: 0x787270 Offset: 0x785C70 VA: 0x180787270
	private void RpcReader___Observers_PlayEnterAnimation_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77E170 Offset: 0x77CB70 VA: 0x18077E170 Slot: 45
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCEvent_StayInBuilding_Assembly-CSharp.dll() { }
}
