public class StartMixingStationBehaviour : Behaviour // TypeDefIndex: 1828
{
	// Fields
	public const float INSERT_INGREDIENT_BASE_TIME = 1;
	[CompilerGenerated]
	private MixingStation <targetStation>k__BackingField; // 0x168
	private Chemist chemist; // 0x170
	private Coroutine startRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.StartMixingStationBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public MixingStation targetStation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public MixingStation get_targetStation() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	private void set_targetStation(MixingStation value) { }

	// RVA: 0x757370 Offset: 0x755D70 VA: 0x180757370 Slot: 19
	public override void Awake() { }

	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	public void AssignStation(MixingStation station) { }

	// RVA: 0x757640 Offset: 0x756040 VA: 0x180757640 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x757E20 Offset: 0x756820 VA: 0x180757E20 Slot: 24
	public override void Pause() { }

	// RVA: 0x757A40 Offset: 0x756440 VA: 0x180757A40 Slot: 28
	public override void OnActiveTick() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7580E0 Offset: 0x756AE0 VA: 0x1807580E0
	private void StartCook() { }

	// RVA: 0x757480 Offset: 0x755E80 VA: 0x180757480
	private bool CanCookStart() { }

	// RVA: 0x758200 Offset: 0x756C00 VA: 0x180758200
	private void StopCook() { }

	// RVA: 0x757700 Offset: 0x756100 VA: 0x180757700
	private Vector3 GetStationAccessPoint() { }

	// RVA: 0x757800 Offset: 0x756200 VA: 0x180757800
	private bool IsAtStation() { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(StartMixingStationBehaviour.<<StartCook>g__CookRoutine|12_0>d))]
	[CompilerGenerated]
	// RVA: 0x7582F0 Offset: 0x756CF0 VA: 0x1807582F0
	private IEnumerator <StartCook>g__CookRoutine|12_0() { }

	// RVA: 0x7579B0 Offset: 0x7563B0 VA: 0x1807579B0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x757FD0 Offset: 0x7569D0 VA: 0x180757FD0
	private void RpcWriter___Observers_StartCook_2166136261() { }

	// RVA: 0x757EB0 Offset: 0x7568B0 VA: 0x180757EB0
	private void RpcLogic___StartCook_2166136261() { }

	// RVA: 0x757F90 Offset: 0x756990 VA: 0x180757F90
	private void RpcReader___Observers_StartCook_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x757280 Offset: 0x755C80 VA: 0x180757280 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.StartMixingStationBehaviour_Assembly-CSharp.dll() { }
}
