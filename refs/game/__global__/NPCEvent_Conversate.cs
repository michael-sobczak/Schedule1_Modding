public class NPCEvent_Conversate : NPCEvent // TypeDefIndex: 1873
{
	// Fields
	private EVOLineType[] ConversationLines; // 0x158
	private string[] AnimationTriggers; // 0x160
	public const float DESTINATION_THRESHOLD = 1;
	public const float TIME_BEFORE_WAIT_START = 3;
	public ConversationLocation Location; // 0x168
	private bool IsConversating; // 0x170
	private Coroutine conversateRoutine; // 0x178
	private bool IsWaiting; // 0x180
	public UnityEvent OnWaitStart; // 0x188
	public UnityEvent OnWaitEnd; // 0x190
	private float timeAtDestination; // 0x198
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted; // 0x19C
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCEvent_ConversateAssembly-CSharp.dll_Excuted; // 0x19D

	// Properties
	public string ActionName { get; }
	private Transform StandPoint { get; }

	// Methods

	// RVA: 0x781820 Offset: 0x780220 VA: 0x180781820
	public string get_ActionName() { }

	// RVA: 0x781850 Offset: 0x780250 VA: 0x180781850
	private Transform get_StandPoint() { }

	// RVA: 0x7801C0 Offset: 0x77EBC0 VA: 0x1807801C0 Slot: 36
	public override string GetName() { }

	// RVA: 0x781440 Offset: 0x77FE40 VA: 0x180781440 Slot: 21
	protected override void Start() { }

	// RVA: 0x781500 Offset: 0x77FF00 VA: 0x180781500 Slot: 22
	public override void Started() { }

	// RVA: 0x77FB90 Offset: 0x77E590 VA: 0x18077FB90 Slot: 30
	public override void ActiveUpdate() { }

	// RVA: 0x780700 Offset: 0x77F100 VA: 0x180780700 Slot: 34
	public override void MinPassed() { }

	// RVA: 0x780670 Offset: 0x77F070 VA: 0x180780670 Slot: 23
	public override void LateStarted() { }

	// RVA: 0x780510 Offset: 0x77EF10 VA: 0x180780510 Slot: 24
	public override void JumpTo() { }

	// RVA: 0x780140 Offset: 0x77EB40 VA: 0x180780140 Slot: 25
	public override void End() { }

	// RVA: 0x7802F0 Offset: 0x77ECF0 VA: 0x1807802F0 Slot: 26
	public override void Interrupt() { }

	// RVA: 0x7809A0 Offset: 0x77F3A0 VA: 0x1807809A0 Slot: 27
	public override void Resume() { }

	// RVA: 0x7803C0 Offset: 0x77EDC0 VA: 0x1807803C0
	private bool IsAtDestination() { }

	// RVA: 0x77FD60 Offset: 0x77E760 VA: 0x18077FD60
	private bool CanConversationStart() { }

	// RVA: 0x781600 Offset: 0x780000 VA: 0x180781600 Slot: 39
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x781300 Offset: 0x77FD00 VA: 0x180781300 Slot: 44
	protected virtual void StartWait() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x780000 Offset: 0x77EA00 VA: 0x180780000 Slot: 45
	protected virtual void EndWait() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x7811E0 Offset: 0x77FBE0 VA: 0x1807811E0 Slot: 46
	protected virtual void StartConversate() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x77FEB0 Offset: 0x77E8B0 VA: 0x18077FEB0 Slot: 47
	protected virtual void EndConversate() { }

	// RVA: 0x7816A0 Offset: 0x7800A0 VA: 0x1807816A0
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(NPCEvent_Conversate.<<StartConversate>g__Routine|30_0>d))]
	// RVA: 0x781590 Offset: 0x77FF90 VA: 0x180781590
	private IEnumerator <StartConversate>g__Routine|30_0() { }

	// RVA: 0x780820 Offset: 0x77F220 VA: 0x180780820 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7807E0 Offset: 0x77F1E0 VA: 0x1807807E0 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7810D0 Offset: 0x77FAD0 VA: 0x1807810D0
	private void RpcWriter___Observers_StartWait_2166136261() { }

	// RVA: 0x780BD0 Offset: 0x77F5D0 VA: 0x180780BD0 Slot: 48
	protected virtual void RpcLogic___StartWait_2166136261() { }

	// RVA: 0x780D10 Offset: 0x77F710 VA: 0x180780D10
	private void RpcReader___Observers_StartWait_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x780E90 Offset: 0x77F890 VA: 0x180780E90
	private void RpcWriter___Observers_EndWait_2166136261() { }

	// RVA: 0x780A70 Offset: 0x77F470 VA: 0x180780A70 Slot: 49
	protected virtual void RpcLogic___EndWait_2166136261() { }

	// RVA: 0x780C70 Offset: 0x77F670 VA: 0x180780C70
	private void RpcReader___Observers_EndWait_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x780FB0 Offset: 0x77F9B0 VA: 0x180780FB0
	private void RpcWriter___Observers_StartConversate_2166136261() { }

	// RVA: 0x780AA0 Offset: 0x77F4A0 VA: 0x180780AA0 Slot: 50
	protected virtual void RpcLogic___StartConversate_2166136261() { }

	// RVA: 0x780CD0 Offset: 0x77F6D0 VA: 0x180780CD0
	private void RpcReader___Observers_StartConversate_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x780D70 Offset: 0x77F770 VA: 0x180780D70
	private void RpcWriter___Observers_EndConversate_2166136261() { }

	// RVA: 0x780A30 Offset: 0x77F430 VA: 0x180780A30 Slot: 51
	protected virtual void RpcLogic___EndConversate_2166136261() { }

	// RVA: 0x780C00 Offset: 0x77F600 VA: 0x180780C00
	private void RpcReader___Observers_EndConversate_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x77FCC0 Offset: 0x77E6C0 VA: 0x18077FCC0 Slot: 20
	public override void Awake() { }
}
