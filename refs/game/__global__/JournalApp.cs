public class JournalApp : App<JournalApp> // TypeDefIndex: 2785
{
	// Fields
	[Header("References")]
	public RectTransform EntryContainer; // 0x68
	public Text NoTasksLabel; // 0x70
	public Text NoDetailsLabel; // 0x78
	public RectTransform DetailsPanelContainer; // 0x80
	[Header("Entry prefabs")]
	public GameObject GenericEntry; // 0x88
	[Header("Details panel prefabs")]
	public GameObject GenericDetailsPanel; // 0x90
	[Header("Quest Entry prefab")]
	public GameObject GenericQuestEntry; // 0x98
	[Header("HUD entry prefabs")]
	public QuestHUDUI QuestHUDUIPrefab; // 0xA0
	public QuestEntryHUDUI QuestEntryHUDUIPrefab; // 0xA8
	protected Quest currentDetailsPanelQuest; // 0xB0
	protected RectTransform currentDetailsPanel; // 0xB8

	// Methods

	// RVA: 0x92DE00 Offset: 0x92C800 VA: 0x18092DE00 Slot: 4
	protected override void Awake() { }

	// RVA: 0x92E2F0 Offset: 0x92CCF0 VA: 0x18092E2F0 Slot: 5
	protected override void Start() { }

	// RVA: 0x92E220 Offset: 0x92CC20 VA: 0x18092E220 Slot: 11
	public override void SetOpen(bool open) { }

	// RVA: 0x92E410 Offset: 0x92CE10 VA: 0x18092E410 Slot: 8
	protected override void Update() { }

	// RVA: 0x92DFB0 Offset: 0x92C9B0 VA: 0x18092DFB0
	private void RefreshDetailsPanel() { }

	// RVA: 0x92DE70 Offset: 0x92C870 VA: 0x18092DE70 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x92DE40 Offset: 0x92C840 VA: 0x18092DE40 Slot: 12
	protected virtual void MinPass() { }

	// RVA: 0x92E530 Offset: 0x92CF30 VA: 0x18092E530
	public void .ctor() { }
}
