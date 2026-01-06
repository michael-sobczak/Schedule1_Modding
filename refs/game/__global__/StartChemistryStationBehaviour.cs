public class StartChemistryStationBehaviour : Behaviour // TypeDefIndex: 1822
{
	// Fields
	public const float PLACE_INGREDIENTS_TIME = 8;
	public const float STIR_TIME = 6;
	public const float BURNER_TIME = 6;
	[CompilerGenerated]
	private ChemistryStation <targetStation>k__BackingField; // 0x168
	private Chemist chemist; // 0x170
	private Coroutine cookRoutine; // 0x178
	private Beaker beaker; // 0x180
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted; // 0x188
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviourAssembly-CSharp.dll_Excuted; // 0x189

	// Properties
	public ChemistryStation targetStation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public ChemistryStation get_targetStation() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set_targetStation(ChemistryStation value) { }

	// RVA: 0x753CD0 Offset: 0x7526D0 VA: 0x180753CD0 Slot: 19
	public override void Awake() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void SetTargetStation(ChemistryStation station) { }

	// RVA: 0x754070 Offset: 0x752A70 VA: 0x180754070 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7549A0 Offset: 0x7533A0 VA: 0x1807549A0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x753DE0 Offset: 0x7527E0 VA: 0x180753DE0 Slot: 26
	public override void BehaviourUpdate() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x755050 Offset: 0x753A50 VA: 0x180755050
	private void StartCook() { }

	// RVA: 0x754F40 Offset: 0x753940 VA: 0x180754F40
	private void SetupBeaker() { }

	// RVA: 0x7541A0 Offset: 0x752BA0 VA: 0x1807541A0
	private void FillBeaker(StationRecipe recipe, Beaker beaker) { }

	// RVA: 0x753E90 Offset: 0x752890 VA: 0x180753E90
	private bool CanCookStart() { }

	// RVA: 0x755170 Offset: 0x753B70 VA: 0x180755170
	private void StopCook() { }

	// RVA: 0x754660 Offset: 0x753060 VA: 0x180754660
	private Vector3 GetStationAccessPoint() { }

	// RVA: 0x754760 Offset: 0x753160 VA: 0x180754760
	private bool IsAtStation() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(StartChemistryStationBehaviour.<<StartCook>g__CookRoutine|15_0>d))]
	// RVA: 0x755220 Offset: 0x753C20 VA: 0x180755220
	private IEnumerator <StartCook>g__CookRoutine|15_0() { }

	// RVA: 0x754910 Offset: 0x753310 VA: 0x180754910 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x748B90 Offset: 0x747590 VA: 0x180748B90 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x754E30 Offset: 0x753830 VA: 0x180754E30
	private void RpcWriter___Observers_StartCook_2166136261() { }

	// RVA: 0x754D10 Offset: 0x753710 VA: 0x180754D10
	private void RpcLogic___StartCook_2166136261() { }

	// RVA: 0x754DF0 Offset: 0x7537F0 VA: 0x180754DF0
	private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x753BE0 Offset: 0x7525E0 VA: 0x180753BE0 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartChemistryStationBehaviour_Assembly-CSharp.dll() { }
}
