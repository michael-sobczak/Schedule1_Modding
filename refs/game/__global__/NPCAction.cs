public abstract class NPCAction : NetworkBehaviour // TypeDefIndex: 1879
{
	// Fields
	public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;
	[CompilerGenerated]
	private bool <IsActive>k__BackingField; // 0x118
	[CompilerGenerated]
	private bool <HasStarted>k__BackingField; // 0x119
	[SerializeField]
	protected int priority; // 0x11C
	[Header("Timing Settings")]
	public int StartTime; // 0x120
	protected NPC npc; // 0x128
	protected NPCScheduleManager schedule; // 0x130
	public Action onEnded; // 0x138
	protected int consecutivePathingFailures; // 0x140
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted; // 0x144
	private bool NetworkInitialize__LateScheduleOne.NPCs.Schedules.NPCActionAssembly-CSharp.dll_Excuted; // 0x145

	// Properties
	protected string ActionName { get; }
	public bool IsEvent { get; }
	public bool IsSignal { get; }
	public bool IsActive { get; set; }
	public bool HasStarted { get; set; }
	public virtual int Priority { get; }
	protected NPCMovement movement { get; }

	// Methods

	// RVA: 0x77F2A0 Offset: 0x77DCA0 VA: 0x18077F2A0
	protected string get_ActionName() { }

	// RVA: 0x77F2D0 Offset: 0x77DCD0 VA: 0x18077F2D0
	public bool get_IsEvent() { }

	// RVA: 0x77F350 Offset: 0x77DD50 VA: 0x18077F350
	public bool get_IsSignal() { }

	[CompilerGenerated]
	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_IsActive() { }

	[CompilerGenerated]
	// RVA: 0x662310 Offset: 0x660D10 VA: 0x180662310
	protected void set_IsActive(bool value) { }

	[CompilerGenerated]
	// RVA: 0x732530 Offset: 0x730F30 VA: 0x180732530
	public bool get_HasStarted() { }

	[CompilerGenerated]
	// RVA: 0x732580 Offset: 0x730F80 VA: 0x180732580
	protected void set_HasStarted(bool value) { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340 Slot: 19
	public virtual int get_Priority() { }

	// RVA: 0x77F3D0 Offset: 0x77DDD0 VA: 0x18077F3D0
	protected NPCMovement get_movement() { }

	// RVA: 0x77E170 Offset: 0x77CB70 VA: 0x18077E170 Slot: 20
	public override void Awake() { }

	// RVA: 0x77E8C0 Offset: 0x77D2C0 VA: 0x18077E8C0 Slot: 16
	protected override void OnValidate() { }

	// RVA: 0x77E2D0 Offset: 0x77CCD0 VA: 0x18077E2D0
	private void GetReferences() { }

	// RVA: 0x77EF30 Offset: 0x77D930 VA: 0x18077EF30 Slot: 21
	protected virtual void Start() { }

	// RVA: 0x77E7A0 Offset: 0x77D1A0 VA: 0x18077E7A0
	private void OnDestroy() { }

	// RVA: 0x77F0D0 Offset: 0x77DAD0 VA: 0x18077F0D0 Slot: 22
	public virtual void Started() { }

	// RVA: 0x77E640 Offset: 0x77D040 VA: 0x18077E640 Slot: 23
	public virtual void LateStarted() { }

	// RVA: 0x77E560 Offset: 0x77CF60 VA: 0x18077E560 Slot: 24
	public virtual void JumpTo() { }

	// RVA: 0x77E1C0 Offset: 0x77CBC0 VA: 0x18077E1C0 Slot: 25
	public virtual void End() { }

	// RVA: 0x77E3C0 Offset: 0x77CDC0 VA: 0x18077E3C0 Slot: 26
	public virtual void Interrupt() { }

	// RVA: 0x77EAD0 Offset: 0x77D4D0 VA: 0x18077EAD0 Slot: 27
	public virtual void Resume() { }

	// RVA: 0x77E9A0 Offset: 0x77D3A0 VA: 0x18077E9A0 Slot: 28
	public virtual void ResumeFailed() { }

	// RVA: 0x77EE70 Offset: 0x77D870 VA: 0x18077EE70 Slot: 29
	public virtual void Skipped() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 30
	public virtual void ActiveUpdate() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 31
	public virtual void OnActiveTick() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 32
	public virtual void OnActiveMinPass() { }

	// RVA: 0x77E8E0 Offset: 0x77D2E0 VA: 0x18077E8E0 Slot: 33
	public virtual void PendingMinPassed() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 34
	public virtual void MinPassed() { }

	// RVA: 0x77EE40 Offset: 0x77D840 VA: 0x18077EE40 Slot: 35
	public virtual bool ShouldStart() { }

	// RVA: -1 Offset: -1 Slot: 36
	public abstract string GetName();

	// RVA: -1 Offset: -1 Slot: 37
	public abstract string GetTimeDescription();

	// RVA: -1 Offset: -1 Slot: 38
	public abstract int GetEndTime();

	// RVA: 0x77EC10 Offset: 0x77D610 VA: 0x18077EC10
	protected void SetDestination(Vector3 position, bool teleportIfFail = True) { }

	// RVA: 0x77F1B0 Offset: 0x77DBB0 VA: 0x18077F1B0 Slot: 39
	protected virtual void WalkCallback(NPCMovement.WalkResult result) { }

	// RVA: 0x618160 Offset: 0x616B60 VA: 0x180618160 Slot: 40
	public virtual void SetStartTime(int startTime) { }

	// RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	protected void .ctor() { }

	// RVA: 0x77E780 Offset: 0x77D180 VA: 0x18077E780 Slot: 41
	public override void NetworkInitialize___Early() { }

	// RVA: 0x77E760 Offset: 0x77D160 VA: 0x18077E760 Slot: 42
	public override void NetworkInitialize__Late() { }

	// RVA: 0x77E720 Offset: 0x77D120 VA: 0x18077E720 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x77E160 Offset: 0x77CB60 VA: 0x18077E160 Slot: 43
	protected virtual void Awake_UserLogic_ScheduleOne.NPCs.Schedules.NPCAction_Assembly-CSharp.dll() { }
}
