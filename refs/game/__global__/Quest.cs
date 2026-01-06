public class Quest : MonoBehaviour, IGUIDRegisterable, ISaveable // TypeDefIndex: 693
{
	// Fields
	public const int MAX_HUD_ENTRY_LABELS = 10;
	public const int CriticalExpiryThreshold = 120;
	public static List<Quest> Quests; // 0x0
	public static Quest HoveredQuest; // 0x8
	public static List<Quest> ActiveQuests; // 0x10
	[CompilerGenerated]
	private EQuestState <State>k__BackingField; // 0x20
	[CompilerGenerated]
	private Guid <GUID>k__BackingField; // 0x24
	[CompilerGenerated]
	private bool <IsTracked>k__BackingField; // 0x34
	[SerializeField]
	[Header("Basic Settings")]
	protected string title; // 0x38
	public string Subtitle; // 0x40
	public Action onSubtitleChanged; // 0x48
	[TextArea(3, 10)]
	public string Description; // 0x50
	public string StaticGUID; // 0x58
	public bool TrackOnBegin; // 0x60
	public EExpiryVisibility ExpiryVisibility; // 0x64
	public bool AutoCompleteOnAllEntriesComplete; // 0x68
	public bool PlayQuestCompleteSound; // 0x69
	public int CompletionXP; // 0x6C
	[CompilerGenerated]
	private bool <Expires>k__BackingField; // 0x70
	[CompilerGenerated]
	private GameDateTime <Expiry>k__BackingField; // 0x74
	[Header("Entries")]
	public bool AutoStartFirstEntry; // 0x7C
	public List<QuestEntry> Entries; // 0x80
	[Header("UI")]
	public RectTransform IconPrefab; // 0x88
	[Header("PoI Settings")]
	public GameObject PoIPrefab; // 0x90
	[Header("Events")]
	public UnityEvent onQuestBegin; // 0x98
	public UnityEvent<EQuestState> onQuestEnd; // 0xA0
	public UnityEvent onActiveState; // 0xA8
	public UnityEvent<bool> onTrackChange; // 0xB0
	public UnityEvent onComplete; // 0xB8
	public UnityEvent onInitialComplete; // 0xC0
	[Header("Reminders")]
	public bool ShouldSendExpiryReminder; // 0xC8
	public bool ShouldSendExpiredNotification; // 0xC9
	protected RectTransform journalEntry; // 0xD0
	protected RectTransform entryTitleRect; // 0xD8
	protected RectTransform trackedRect; // 0xE0
	protected Text entryTimeLabel; // 0xE8
	protected Image criticalTimeBackground; // 0xF0
	protected RectTransform detailPanel; // 0xF8
	[CompilerGenerated]
	private QuestHUDUI <hudUI>k__BackingField; // 0x100
	public Action onHudUICreated; // 0x108
	private bool expiryReminderSent; // 0x110
	private CompassManager.Element compassElement; // 0x118
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x120
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x128
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x130
	protected bool autoInitialize; // 0x131

	// Properties
	public EQuestState State { get; set; }
	public Guid GUID { get; set; }
	public bool IsTracked { get; set; }
	public int ActiveEntryCount { get; }
	public string Title { get; }
	public bool Expires { get; set; }
	public GameDateTime Expiry { get; set; }
	public bool hudUIExists { get; }
	public QuestHUDUI hudUI { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFolders { get; set; }
	public List<string> LocalExtraFiles { get; set; }
	public bool HasChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public EQuestState get_State() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	protected void set_State(EQuestState value) { }

	[CompilerGenerated]
	// RVA: 0x83F4E0 Offset: 0x83DEE0 VA: 0x18083F4E0 Slot: 4
	public Guid get_GUID() { }

	[CompilerGenerated]
	// RVA: 0x8735A0 Offset: 0x871FA0 VA: 0x1808735A0
	protected void set_GUID(Guid value) { }

	[CompilerGenerated]
	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	public bool get_IsTracked() { }

	[CompilerGenerated]
	// RVA: 0x66B030 Offset: 0x669A30 VA: 0x18066B030
	protected void set_IsTracked(bool value) { }

	// RVA: 0xABD590 Offset: 0xABBF90 VA: 0x180ABD590
	public int get_ActiveEntryCount() { }

	// RVA: 0x67AAA0 Offset: 0x6794A0 VA: 0x18067AAA0
	public string get_Title() { }

	[CompilerGenerated]
	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	public bool get_Expires() { }

	[CompilerGenerated]
	// RVA: 0x83DBC0 Offset: 0x83C5C0 VA: 0x18083DBC0
	protected void set_Expires(bool value) { }

	[CompilerGenerated]
	// RVA: 0xABD6B0 Offset: 0xABC0B0 VA: 0x180ABD6B0
	public GameDateTime get_Expiry() { }

	[CompilerGenerated]
	// RVA: 0xABD810 Offset: 0xABC210 VA: 0x180ABD810
	protected void set_Expiry(GameDateTime value) { }

	// RVA: 0xABD7B0 Offset: 0xABC1B0 VA: 0x180ABD7B0
	public bool get_hudUIExists() { }

	[CompilerGenerated]
	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public QuestHUDUI get_hudUI() { }

	[CompilerGenerated]
	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	private void set_hudUI(QuestHUDUI value) { }

	// RVA: 0xABD740 Offset: 0xABC140 VA: 0x180ABD740 Slot: 7
	public string get_SaveFolderName() { }

	// RVA: 0xABD6D0 Offset: 0xABC0D0 VA: 0x180ABD6D0 Slot: 8
	public string get_SaveFileName() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 9
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 10
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0 Slot: 13
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640 Slot: 14
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0 Slot: 11
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0 Slot: 12
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0xABD6C0 Offset: 0xABC0C0 VA: 0x180ABD6C0 Slot: 15
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0xABD820 Offset: 0xABC220 VA: 0x180ABD820 Slot: 16
	public void set_HasChanged(bool value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 30
	protected virtual void Awake() { }

	// RVA: 0xABCB80 Offset: 0xABB580 VA: 0x180ABCB80 Slot: 31
	protected virtual void Start() { }

	// RVA: 0xABAF50 Offset: 0xAB9950 VA: 0x180ABAF50 Slot: 32
	public virtual void InitializeQuest(string title, string description, QuestEntryData[] entries, string guid) { }

	// RVA: 0xABB450 Offset: 0xAB9E50 VA: 0x180ABB450 Slot: 33
	public virtual void InitializeSaveable() { }

	// RVA: 0xAB9950 Offset: 0xAB8350 VA: 0x180AB9950
	public void ConfigureExpiry(bool expires, GameDateTime expiry) { }

	// RVA: 0xAB9330 Offset: 0xAB7D30 VA: 0x180AB9330 Slot: 34
	public virtual void Begin(bool network = True) { }

	// RVA: 0xAB9730 Offset: 0xAB8130 VA: 0x180AB9730 Slot: 35
	public virtual void Complete(bool network = True) { }

	// RVA: 0xABA860 Offset: 0xAB9260 VA: 0x180ABA860 Slot: 36
	public virtual void Fail(bool network = True) { }

	// RVA: 0xABA770 Offset: 0xAB9170 VA: 0x180ABA770 Slot: 37
	public virtual void Expire(bool network = True) { }

	// RVA: 0xAB9520 Offset: 0xAB7F20 VA: 0x180AB9520 Slot: 38
	public virtual void Cancel(bool network = True) { }

	// RVA: 0xABA4A0 Offset: 0xAB8EA0 VA: 0x180ABA4A0 Slot: 39
	public virtual void End() { }

	// RVA: 0xABC020 Offset: 0xABAA20 VA: 0x180ABC020 Slot: 40
	public virtual void SetQuestState(EQuestState state, bool network = True) { }

	// RVA: 0xABCB70 Offset: 0xABB570 VA: 0x180ABCB70 Slot: 41
	protected virtual bool ShouldShowJournalEntry() { }

	// RVA: 0xABBE80 Offset: 0xABA880 VA: 0x180ABBE80 Slot: 42
	public virtual void SetQuestEntryState(int entryIndex, EQuestState state, bool network = True) { }

	// RVA: 0xABB7E0 Offset: 0xABA1E0 VA: 0x180ABB7E0 Slot: 43
	protected virtual void MinPass() { }

	// RVA: 0xAB96C0 Offset: 0xAB80C0 VA: 0x180AB96C0 Slot: 44
	protected virtual void CheckExpiry() { }

	// RVA: 0xAB9610 Offset: 0xAB8010 VA: 0x180AB9610
	private void CheckAutoComplete() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 45
	protected virtual bool CanExpire() { }

	// RVA: 0xABBA60 Offset: 0xABA460 VA: 0x180ABBA60 Slot: 46
	protected virtual void SendExpiryReminder() { }

	// RVA: 0xABB940 Offset: 0xABA340 VA: 0x180ABB940 Slot: 47
	protected virtual void SendExpiredNotification() { }

	// RVA: 0xABBB80 Offset: 0xABA580 VA: 0x180ABBB80 Slot: 6
	public void SetGUID(Guid guid) { }

	// RVA: 0x4D36A0 Offset: 0x4D20A0 VA: 0x1804D36A0
	public void SetSubtitle(string subtitle) { }

	// RVA: 0xABBBE0 Offset: 0xABA5E0 VA: 0x180ABBBE0 Slot: 48
	public virtual void SetIsTracked(bool tracked) { }

	// RVA: 0xABC4D0 Offset: 0xABAED0 VA: 0x180ABC4D0 Slot: 49
	public virtual void SetupJournalEntry() { }

	// RVA: 0xABA3E0 Offset: 0xAB8DE0 VA: 0x180ABA3E0
	private void DestroyJournalEntry() { }

	// RVA: 0xABB4E0 Offset: 0xAB9EE0 VA: 0x180ABB4E0
	private void JournalEntryClicked() { }

	// RVA: 0xABB500 Offset: 0xAB9F00 VA: 0x180ABB500
	private void JournalEntryHoverStart() { }

	// RVA: 0xABAAC0 Offset: 0xAB94C0 VA: 0x180ABAAC0
	public int GetMinsUntilExpiry() { }

	// RVA: 0xABA950 Offset: 0xAB9350 VA: 0x180ABA950
	public string GetExpiryText() { }

	// RVA: 0xABC2A0 Offset: 0xABACA0 VA: 0x180ABC2A0 Slot: 50
	public virtual QuestHUDUI SetupHUDUI() { }

	// RVA: 0xABD2D0 Offset: 0xABBCD0 VA: 0x180ABD2D0
	public void UpdateHUDUI() { }

	// RVA: 0xABA3C0 Offset: 0xAB8DC0 VA: 0x180ABA3C0
	public void DestroyHUDUI() { }

	// RVA: 0xAB94A0 Offset: 0xAB7EA0 VA: 0x180AB94A0
	public void BopHUDUI() { }

	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0 Slot: 51
	public virtual string GetQuestTitle() { }

	// RVA: 0xABAA00 Offset: 0xAB9400 VA: 0x180ABAA00
	public QuestEntry GetFirstActiveEntry() { }

	// RVA: 0xAB9960 Offset: 0xAB8360 VA: 0x180AB9960 Slot: 52
	public virtual RectTransform CreateDetailDisplay(RectTransform parent) { }

	// RVA: 0xABA300 Offset: 0xAB8D00 VA: 0x180ABA300
	public void DestroyDetailDisplay() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 53
	public virtual bool ShouldSave() { }

	// RVA: 0xABAC80 Offset: 0xAB9680 VA: 0x180ABAC80 Slot: 54
	public virtual SaveData GetSaveData() { }

	// RVA: 0xABAF10 Offset: 0xAB9910 VA: 0x180ABAF10 Slot: 18
	public string GetSaveString() { }

	// RVA: 0xABB570 Offset: 0xAB9F70 VA: 0x180ABB570 Slot: 55
	public virtual void Load(QuestData data) { }

	// RVA: 0xABAB70 Offset: 0xAB9570 VA: 0x180ABAB70
	public static Quest GetQuest(string questName) { }

	// RVA: 0xABD3F0 Offset: 0xABBDF0 VA: 0x180ABD3F0
	public void .ctor() { }

	// RVA: 0xABD2F0 Offset: 0xABBCF0 VA: 0x180ABD2F0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xABD060 Offset: 0xABBA60 VA: 0x180ABD060
	private void <Start>g__Initialize|88_0() { }

	[CompilerGenerated]
	// RVA: 0xABCFF0 Offset: 0xABB9F0 VA: 0x180ABCFF0
	private void <SetupJournalEntry>b__110_0(BaseEventData data) { }

	[CompilerGenerated]
	// RVA: 0xABCE10 Offset: 0xABB810 VA: 0x180ABCE10
	private void <CreateDetailDisplay>g__ShowOnMap|122_0() { }
}
