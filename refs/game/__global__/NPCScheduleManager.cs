public class NPCScheduleManager : MonoBehaviour // TypeDefIndex: 1667
{
	// Fields
	private static readonly NPCActionOrderByDescending orderByDescending; // 0x0
	[CompilerGenerated]
	private bool <ScheduleEnabled>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <CurfewModeEnabled>k__BackingField; // 0x21
	public bool DEBUG_MODE; // 0x22
	[CompilerGenerated]
	private NPCAction <ActiveAction>k__BackingField; // 0x28
	[CompilerGenerated]
	private List<NPCAction> <PendingActions>k__BackingField; // 0x30
	[CompilerGenerated]
	private NPC <Npc>k__BackingField; // 0x38
	[Header("References")]
	public GameObject[] EnabledDuringCurfew; // 0x40
	public GameObject[] EnabledDuringNoCurfew; // 0x48
	public List<NPCAction> ActionList; // 0x50
	[CompilerGenerated]
	private List<NPCAction> <ActionsAwaitingStart>k__BackingField; // 0x58
	protected int lastProcessedTime; // 0x60

	// Properties
	public bool ScheduleEnabled { get; set; }
	public bool CurfewModeEnabled { get; set; }
	public NPCAction ActiveAction { get; set; }
	public List<NPCAction> PendingActions { get; set; }
	public NPC Npc { get; set; }
	protected List<NPCAction> ActionsAwaitingStart { get; set; }
	protected TimeManager Time { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_ScheduleEnabled() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_ScheduleEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x563D50 Offset: 0x562750 VA: 0x180563D50
	public bool get_CurfewModeEnabled() { }

	[CompilerGenerated]
	// RVA: 0x563DA0 Offset: 0x5627A0 VA: 0x180563DA0
	protected void set_CurfewModeEnabled(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public NPCAction get_ActiveAction() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	public void set_ActiveAction(NPCAction value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public List<NPCAction> get_PendingActions() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	public void set_PendingActions(List<NPCAction> value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public NPC get_Npc() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	protected void set_Npc(NPC value) { }

	[CompilerGenerated]
	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	protected List<NPCAction> get_ActionsAwaitingStart() { }

	[CompilerGenerated]
	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	protected void set_ActionsAwaitingStart(List<NPCAction> value) { }

	// RVA: 0x72C260 Offset: 0x72AC60 VA: 0x18072C260
	protected TimeManager get_Time() { }

	// RVA: 0x729690 Offset: 0x728090 VA: 0x180729690 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0x72B9B0 Offset: 0x72A3B0 VA: 0x18072B9B0 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x72AA50 Offset: 0x729450 VA: 0x18072AA50
	private void LocalPlayerSpawned() { }

	// RVA: 0x72B5C0 Offset: 0x729FC0 VA: 0x18072B5C0
	private void OnValidate() { }

	// RVA: 0x72C080 Offset: 0x72AA80 VA: 0x18072C080 Slot: 6
	protected virtual void Update() { }

	// RVA: 0x729900 Offset: 0x728300 VA: 0x180729900
	public void EnableSchedule() { }

	// RVA: 0x729710 Offset: 0x728110 VA: 0x180729710
	public void DisableSchedule() { }

	[Button]
	// RVA: 0x72A6D0 Offset: 0x7290D0 VA: 0x18072A6D0
	public void InitializeActions() { }

	// RVA: 0x72AA80 Offset: 0x729480 VA: 0x18072AA80 Slot: 7
	protected virtual void OnMinPass() { }

	// RVA: 0x72AB90 Offset: 0x729590 VA: 0x18072AB90 Slot: 8
	protected virtual void OnTick() { }

	// RVA: 0x72A1B0 Offset: 0x728BB0 VA: 0x18072A1B0
	private List<NPCAction> GetActionsOccurringAt(int time) { }

	// RVA: 0x72A440 Offset: 0x728E40 VA: 0x18072A440
	private List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart) { }

	// RVA: 0x72B7E0 Offset: 0x72A1E0 VA: 0x18072B7E0
	private void StartAction(NPCAction action) { }

	// RVA: 0x729940 Offset: 0x728340 VA: 0x180729940
	private void EnforceState() { }

	// RVA: 0x7299D0 Offset: 0x7283D0 VA: 0x1807299D0
	public void EnforceState(bool initial = False) { }

	// RVA: 0x729700 Offset: 0x728100 VA: 0x180729700 Slot: 9
	protected virtual void CurfewEnabled() { }

	// RVA: 0x7296F0 Offset: 0x7280F0 VA: 0x1807296F0 Slot: 10
	protected virtual void CurfewDisabled() { }

	// RVA: 0x72B600 Offset: 0x72A000 VA: 0x18072B600
	public void SetCurfewModeEnabled(bool enabled) { }

	// RVA: 0x72C180 Offset: 0x72AB80 VA: 0x18072C180
	public void .ctor() { }

	// RVA: 0x72C100 Offset: 0x72AB00 VA: 0x18072C100
	private static void .cctor() { }
}
