public class NPCEvent_Sit : NPCEvent // TypeDefIndex: 1876
{
	// Fields
	public const float DESTINATION_THRESHOLD = 1.5;
	public AvatarSeatSet SeatSet; // 0x158
	public bool WarpIfSkipped; // 0x160
	private bool seated; // 0x161
	private AvatarSeat targetSeat; // 0x168
	public UnityEvent onSeated; // 0x170
	public UnityEvent onStandUp; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_SitAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public string ActionName { get; }

	// Methods

	// RVA: 0x786230 Offset: 0x784C30 VA: 0x180786230
	public string get_ActionName() { }

	// RVA: 0x7849B0 Offset: 0x7833B0 VA: 0x1807849B0 Slot: 36
	public override string GetName() { }

	// RVA: 0x7860B0 Offset: 0x784AB0 VA: 0x1807860B0 Slot: 22
	public override void Started() { }

	// RVA: 0x7855C0 Offset: 0x783FC0 VA: 0x1807855C0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x784EB0 Offset: 0x7838B0 VA: 0x180784EB0 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x7850B0 Offset: 0x783AB0 VA: 0x1807850B0 Slot: 31
	public override void OnActiveTick() { }

	// RVA: 0x784CB0 Offset: 0x7836B0 VA: 0x180784CB0 Slot: 24
	public override void JumpTo() { }

	// RVA: 0x784960 Offset: 0x783360 VA: 0x180784960 Slot: 25
	public override void End() { }

	// RVA: 0x784A60 Offset: 0x783460 VA: 0x180784A60 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x785680 Offset: 0x784080 VA: 0x180785680 Slot: 27
	public override void Resume() { }

	// RVA: 0x785D70 Offset: 0x784770 VA: 0x180785D70 Slot: 29
	public override void Skipped() { }

	// RVA: 0x784AF0 Offset: 0x7834F0 VA: 0x180784AF0
	private bool IsAtDestination() { }

	// RVA: 0x786180 Offset: 0x784B80 VA: 0x180786180 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x785E30 Offset: 0x784830 VA: 0x180785E30 Slot: 44
	protected virtual void StartAction(NetworkConnection conn, int seatIndex) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x784800 Offset: 0x783200 VA: 0x180784800 Slot: 45
	protected virtual void EndAction() { }

	// RVA: 0x77FB70 Offset: 0x77E570 VA: 0x18077FB70
	public void .ctor() { }

	// RVA: 0x784F80 Offset: 0x783980 VA: 0x180784F80 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7820E0 Offset: 0x780AE0 VA: 0x1807820E0 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x785AB0 Offset: 0x7844B0 VA: 0x180785AB0
	private void RpcWriter___Observers_StartAction_2681120339(NetworkConnection conn, int seatIndex) { }

	// RVA: 0x7857B0 Offset: 0x7841B0 VA: 0x1807857B0 Slot: 46
	protected virtual void RpcLogic___StartAction_2681120339(NetworkConnection conn, int seatIndex) { }

	// RVA: 0x7858B0 Offset: 0x7842B0 VA: 0x1807858B0
	private void RpcReader___Observers_StartAction_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x785C00 Offset: 0x784600 VA: 0x180785C00
	private void RpcWriter___Target_StartAction_2681120339(NetworkConnection conn, int seatIndex) { }

	// RVA: 0x785920 Offset: 0x784320 VA: 0x180785920
	private void RpcReader___Target_StartAction_2681120339(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x785990 Offset: 0x784390 VA: 0x180785990
	private void RpcWriter___Observers_EndAction_2166136261() { }

	// RVA: 0x785740 Offset: 0x784140 VA: 0x180785740 Slot: 47
	protected virtual void RpcLogic___EndAction_2166136261() { }

	// RVA: 0x785870 Offset: 0x784270 VA: 0x180785870
	private void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77FCC0 Offset: 0x77E6C0 VA: 0x18077FCC0 Slot: 20
	public override void Awake() { }
}
