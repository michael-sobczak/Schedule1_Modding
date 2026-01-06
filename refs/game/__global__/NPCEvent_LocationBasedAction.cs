public class NPCEvent_LocationBasedAction : NPCEvent // TypeDefIndex: 1874
{
	// Fields
	public Transform Destination; // 0x158
	public bool FaceDestinationDir; // 0x160
	public float DestinationThreshold; // 0x164
	public bool WarpIfSkipped; // 0x168
	public bool IsActionStarted; // 0x169
	public UnityEvent onStartAction; // 0x170
	public UnityEvent onEndAction; // 0x178
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted; // 0x180
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationBasedActionAssembly-CSharp.dll_Excuted; // 0x181

	// Properties
	public string ActionName { get; }

	// Methods

	// RVA: 0x782F00 Offset: 0x781900 VA: 0x180782F00
	public string get_ActionName() { }

	// RVA: 0x781BD0 Offset: 0x7805D0 VA: 0x180781BD0 Slot: 36
	public override string GetName() { }

	// RVA: 0x7824B0 Offset: 0x780EB0 VA: 0x1807824B0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x782DE0 Offset: 0x7817E0 VA: 0x180782DE0 Slot: 22
	public override void Started() { }

	// RVA: 0x782250 Offset: 0x780C50 VA: 0x180782250 Slot: 31
	public override void OnActiveTick() { }

	// RVA: 0x782050 Offset: 0x780A50 VA: 0x180782050 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x781F40 Offset: 0x780940 VA: 0x180781F40 Slot: 24
	public override void JumpTo() { }

	// RVA: 0x781B90 Offset: 0x780590 VA: 0x180781B90 Slot: 25
	public override void End() { }

	// RVA: 0x781CF0 Offset: 0x7806F0 VA: 0x180781CF0 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x782500 Offset: 0x780F00 VA: 0x180782500 Slot: 27
	public override void Resume() { }

	// RVA: 0x782B00 Offset: 0x781500 VA: 0x180782B00 Slot: 29
	public override void Skipped() { }

	// RVA: 0x781D80 Offset: 0x780780 VA: 0x180781D80
	private bool IsAtDestination() { }

	// RVA: 0x782E70 Offset: 0x781870 VA: 0x180782E70 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x782B90 Offset: 0x781590 VA: 0x180782B90 Slot: 44
	protected virtual void StartAction(NetworkConnection conn) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x781A50 Offset: 0x780450 VA: 0x180781A50 Slot: 45
	protected virtual void EndAction() { }

	// RVA: 0x782ED0 Offset: 0x7818D0 VA: 0x180782ED0
	public void .ctor() { }

	// RVA: 0x782120 Offset: 0x780B20 VA: 0x180782120 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7820E0 Offset: 0x780AE0 VA: 0x1807820E0 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7828C0 Offset: 0x7812C0 VA: 0x1807828C0
	private void RpcWriter___Observers_StartAction_328543758(NetworkConnection conn) { }

	// RVA: 0x7825C0 Offset: 0x780FC0 VA: 0x1807825C0 Slot: 46
	protected virtual void RpcLogic___StartAction_328543758(NetworkConnection conn) { }

	// RVA: 0x782720 Offset: 0x781120 VA: 0x180782720
	private void RpcReader___Observers_StartAction_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7829D0 Offset: 0x7813D0 VA: 0x1807829D0
	private void RpcWriter___Target_StartAction_328543758(NetworkConnection conn) { }

	// RVA: 0x782760 Offset: 0x781160 VA: 0x180782760
	private void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x7827A0 Offset: 0x7811A0 VA: 0x1807827A0
	private void RpcWriter___Observers_EndAction_2166136261() { }

	// RVA: 0x782590 Offset: 0x780F90 VA: 0x180782590 Slot: 47
	protected virtual void RpcLogic___EndAction_2166136261() { }

	// RVA: 0x7826C0 Offset: 0x7810C0 VA: 0x1807826C0
	private void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77FCC0 Offset: 0x77E6C0 VA: 0x18077FCC0 Slot: 20
	public override void Awake() { }
}
