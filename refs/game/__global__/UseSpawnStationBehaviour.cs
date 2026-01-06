public class UseSpawnStationBehaviour : Behaviour // TypeDefIndex: 1832
{
	// Fields
	private const float TaskDuration = 6;
	private const float ProximityThreshold = 0.6;
	private const string AnimationBoolName = "UsePackagingStation";
	[CompilerGenerated]
	private MushroomSpawnStation <Station>k__BackingField; // 0x168
	private bool _currentlyUsingStation; // 0x170
	private Coroutine _workRoutine; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UseSpawnStationBehaviourAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UseSpawnStationBehaviourAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public MushroomSpawnStation Station { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public MushroomSpawnStation get_Station() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	protected void set_Station(MushroomSpawnStation value) { }

	// RVA: 0x75EDB0 Offset: 0x75D7B0 VA: 0x18075EDB0
	public void AssignStation(MushroomSpawnStation station) { }

	// RVA: 0x73ED60 Offset: 0x73D760 VA: 0x18073ED60 Slot: 22
	public override void Activate() { }

	// RVA: 0x75EFE0 Offset: 0x75D9E0 VA: 0x18075EFE0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x73F9D0 Offset: 0x73E3D0 VA: 0x18073F9D0 Slot: 25
	public override void Resume() { }

	// RVA: 0x75F6D0 Offset: 0x75E0D0 VA: 0x18075F6D0 Slot: 24
	public override void Pause() { }

	// RVA: 0x75F390 Offset: 0x75DD90 VA: 0x18075F390 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x75F100 Offset: 0x75DB00 VA: 0x18075F100
	public bool IsAtStation() { }

	// RVA: 0x75F030 Offset: 0x75DA30 VA: 0x18075F030
	public void GoToStation() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x75EEC0 Offset: 0x75D8C0 VA: 0x18075EEC0
	public void BeginWork() { }

	// RVA: 0x75F950 Offset: 0x75E350 VA: 0x18075F950
	private void StopWork() { }

	// RVA: 0x75F1E0 Offset: 0x75DBE0 VA: 0x18075F1E0
	public bool IsStationReady(MushroomSpawnStation station) { }

	// RVA: 0x731510 Offset: 0x72FF10 VA: 0x180731510
	public void .ctor() { }

	[IteratorStateMachine(typeof(UseSpawnStationBehaviour.<<BeginWork>g__Package|17_0>d))]
	[CompilerGenerated]
	// RVA: 0x75FA90 Offset: 0x75E490 VA: 0x18075FA90
	private IEnumerator <BeginWork>g__Package|17_0() { }

	// RVA: 0x75F300 Offset: 0x75DD00 VA: 0x18075F300 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x747D50 Offset: 0x746750 VA: 0x180747D50 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x75F840 Offset: 0x75E240 VA: 0x18075F840
	private void RpcWriter___Observers_BeginWork_2166136261() { }

	// RVA: 0x75F700 Offset: 0x75E100 VA: 0x18075F700
	public void RpcLogic___BeginWork_2166136261() { }

	// RVA: 0x75F800 Offset: 0x75E200 VA: 0x18075F800
	private void RpcReader___Observers_BeginWork_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
