public class QuestEntry : MonoBehaviour // TypeDefIndex: 694
{
	// Fields
	[CompilerGenerated]
	private Quest <ParentQuest>k__BackingField; // 0x20
	[Header("Naming")]
	[SerializeField]
	protected string EntryTitle; // 0x28
	[SerializeField]
	protected EQuestState state; // 0x30
	[Header("Settings")]
	public bool AutoComplete; // 0x34
	public Conditions AutoCompleteConditions; // 0x38
	public bool CompleteParentQuest; // 0x40
	public string EntryAddedIn; // 0x48
	[Header("PoI Settings")]
	public bool AutoCreatePoI; // 0x50
	public Transform PoILocation; // 0x58
	public bool AutoUpdatePoILocation; // 0x60
	public POI PoI; // 0x68
	public UnityEvent onStart; // 0x70
	public UnityEvent onEnd; // 0x78
	public UnityEvent onComplete; // 0x80
	public UnityEvent onInitialComplete; // 0x88
	private CompassManager.Element compassElement; // 0x90
	private QuestEntryHUDUI entryUI; // 0x98
	private RectTransform PoIIcon; // 0xA0

	// Properties
	[CodegenExclude]
	public Quest ParentQuest { get; set; }
	[CodegenExclude]
	public string Title { get; }
	[CodegenExclude]
	public EQuestState State { get; }
	public int QuestEntryIndex { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public Quest get_ParentQuest() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_ParentQuest(Quest value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public string get_Title() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public EQuestState get_State() { }

	// RVA: 0xAD9690 Offset: 0xAD8090 VA: 0x180AD9690
	public int get_QuestEntryIndex() { }

	// RVA: 0xAD7860 Offset: 0xAD6260 VA: 0x180AD7860 Slot: 4
	protected virtual void Awake() { }

	// RVA: 0xAD8B10 Offset: 0xAD7510 VA: 0x180AD8B10 Slot: 5
	protected virtual void Start() { }

	// RVA: 0xAD83D0 Offset: 0xAD6DD0 VA: 0x180AD83D0
	private void OnValidate() { }

	// RVA: 0xAD82F0 Offset: 0xAD6CF0 VA: 0x180AD82F0 Slot: 6
	public virtual void MinPass() { }

	// RVA: 0xAD84C0 Offset: 0xAD6EC0 VA: 0x180AD84C0
	public void SetData(QuestEntryData data) { }

	// RVA: 0xAD7AB0 Offset: 0xAD64B0 VA: 0x180AD7AB0
	public void Begin() { }

	// RVA: 0xAD7AD0 Offset: 0xAD64D0 VA: 0x180AD7AD0
	public void Complete() { }

	// RVA: 0xAD84A0 Offset: 0xAD6EA0 VA: 0x180AD84A0
	public void SetActive(bool network = True) { }

	// RVA: 0xAD86B0 Offset: 0xAD70B0 VA: 0x180AD86B0 Slot: 7
	public virtual void SetState(EQuestState newState, bool network = True) { }

	// RVA: 0xAD8AE0 Offset: 0xAD74E0 VA: 0x180AD8AE0 Slot: 8
	protected virtual bool ShouldShowPoI() { }

	// RVA: 0xAD9490 Offset: 0xAD7E90 VA: 0x180AD9490 Slot: 9
	protected virtual void UpdatePoI() { }

	// RVA: 0xAD85C0 Offset: 0xAD6FC0 VA: 0x180AD85C0
	public void SetPoILocation(Vector3 location) { }

	// RVA: 0xAD7E20 Offset: 0xAD6820 VA: 0x180AD7E20
	public void CreatePoI() { }

	// RVA: 0xAD8170 Offset: 0xAD6B70 VA: 0x180AD8170
	public void DestroyPoI() { }

	// RVA: 0xAD7AF0 Offset: 0xAD64F0 VA: 0x180AD7AF0
	public void CreateCompassElement() { }

	// RVA: 0xAD9160 Offset: 0xAD7B60 VA: 0x180AD9160
	public void UpdateCompassElement() { }

	// RVA: 0xAD8280 Offset: 0xAD6C80 VA: 0x180AD8280
	public QuestEntryData GetSaveData() { }

	// RVA: 0xAD9250 Offset: 0xAD7C50 VA: 0x180AD9250
	private void UpdateName() { }

	// RVA: 0xAD8220 Offset: 0xAD6C20 VA: 0x180AD8220
	private void EvaluateConditions() { }

	// RVA: 0xAD8520 Offset: 0xAD6F20 VA: 0x180AD8520
	public void SetEntryTitle(string newTitle) { }

	// RVA: 0xAD7C20 Offset: 0xAD6620 VA: 0x180AD7C20 Slot: 10
	protected virtual void CreateEntryUI() { }

	// RVA: 0xAD9220 Offset: 0xAD7C20 VA: 0x180AD9220 Slot: 11
	public virtual void UpdateEntryUI() { }

	// RVA: 0xAD9540 Offset: 0xAD7F40 VA: 0x180AD9540
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xAD8170 Offset: 0xAD6B70 VA: 0x180AD8170
	private void <Awake>b__27_0(EQuestState <p0>) { }

	[CompilerGenerated]
	// RVA: 0x4BC030 Offset: 0x4BAA30 VA: 0x1804BC030
	private void <Awake>b__27_1(bool b) { }

	[CompilerGenerated]
	// RVA: 0xAD8F40 Offset: 0xAD7940 VA: 0x180AD8F40
	private void <CreatePoI>g__CreateUI|39_0() { }
}
