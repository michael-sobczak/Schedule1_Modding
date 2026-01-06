public class NPCEvent_LocationDialogue : NPCEvent // TypeDefIndex: 1875
{
	// Fields
	public Transform Destination; // 0x158
	public bool FaceDestinationDir; // 0x160
	public float DestinationThreshold; // 0x164
	public bool WarpIfSkipped; // 0x168
	[Header("Dialogue Settings")]
	public int GreetingOverrideToEnable; // 0x16C
	public int ChoiceToEnable; // 0x170
	public DialogueContainer DialogueOverride; // 0x178
	protected bool IsActionStarted; // 0x180
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted; // 0x181
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_LocationDialogueAssembly-CSharp.dll_Excuted; // 0x182

	// Properties
	public string ActionName { get; }

	// Methods

	// RVA: 0x7846B0 Offset: 0x7830B0 VA: 0x1807846B0
	public string get_ActionName() { }

	// RVA: 0x783090 Offset: 0x781A90 VA: 0x180783090 Slot: 36
	public override string GetName() { }

	// RVA: 0x783A90 Offset: 0x782490 VA: 0x180783A90 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x7845F0 Offset: 0x782FF0 VA: 0x1807845F0 Slot: 22
	public override void Started() { }

	// RVA: 0x783710 Offset: 0x782110 VA: 0x180783710 Slot: 31
	public override void OnActiveTick() { }

	// RVA: 0x783510 Offset: 0x781F10 VA: 0x180783510 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x783400 Offset: 0x781E00 VA: 0x180783400 Slot: 24
	public override void JumpTo() { }

	// RVA: 0x783050 Offset: 0x781A50 VA: 0x180783050 Slot: 25
	public override void End() { }

	// RVA: 0x7831B0 Offset: 0x781BB0 VA: 0x1807831B0 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x783AE0 Offset: 0x7824E0 VA: 0x180783AE0 Slot: 27
	public override void Resume() { }

	// RVA: 0x782B00 Offset: 0x781500 VA: 0x180782B00 Slot: 29
	public override void Skipped() { }

	// RVA: 0x783240 Offset: 0x781C40 VA: 0x180783240
	private bool IsAtDestination() { }

	// RVA: 0x782E70 Offset: 0x781870 VA: 0x180782E70 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x7843A0 Offset: 0x782DA0 VA: 0x1807843A0 Slot: 44
	protected virtual void StartAction(NetworkConnection conn) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x782F30 Offset: 0x781930 VA: 0x180782F30 Slot: 45
	protected virtual void EndAction() { }

	// RVA: 0x784680 Offset: 0x783080 VA: 0x180784680
	public void .ctor() { }

	// RVA: 0x7835E0 Offset: 0x781FE0 VA: 0x1807835E0 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7835A0 Offset: 0x781FA0 VA: 0x1807835A0 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x784160 Offset: 0x782B60 VA: 0x180784160
	private void RpcWriter___Observers_StartAction_328543758(NetworkConnection conn) { }

	// RVA: 0x783CF0 Offset: 0x7826F0 VA: 0x180783CF0 Slot: 46
	protected virtual void RpcLogic___StartAction_328543758(NetworkConnection conn) { }

	// RVA: 0x783FC0 Offset: 0x7829C0 VA: 0x180783FC0
	private void RpcReader___Observers_StartAction_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x784270 Offset: 0x782C70 VA: 0x180784270
	private void RpcWriter___Target_StartAction_328543758(NetworkConnection conn) { }

	// RVA: 0x784000 Offset: 0x782A00 VA: 0x180784000
	private void RpcReader___Target_StartAction_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x784040 Offset: 0x782A40 VA: 0x180784040
	private void RpcWriter___Observers_EndAction_2166136261() { }

	// RVA: 0x783B70 Offset: 0x782570 VA: 0x180783B70 Slot: 47
	protected virtual void RpcLogic___EndAction_2166136261() { }

	// RVA: 0x783F80 Offset: 0x782980 VA: 0x180783F80
	private void RpcReader___Observers_EndAction_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77FCC0 Offset: 0x77E6C0 VA: 0x18077FCC0 Slot: 20
	public override void Awake() { }
}
