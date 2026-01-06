public class QuestHUDUI : MonoBehaviour // TypeDefIndex: 2697
{
	// Fields
	public string CriticalTimeColor; // 0x20
	[CompilerGenerated]
	private Quest <Quest>k__BackingField; // 0x28
	[Header("References")]
	public RectTransform EntryContainer; // 0x30
	public TextMeshProUGUI MainLabel; // 0x38
	public VerticalLayoutGroup hudUILayout; // 0x40
	public Animation Animation; // 0x48
	public RectTransform Shade; // 0x50
	public Action onUpdateUI; // 0x58

	// Properties
	public Quest Quest { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Quest get_Quest() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_Quest(Quest value) { }

	// RVA: 0x9155E0 Offset: 0x913FE0 VA: 0x1809155E0
	public void Initialize(Quest quest) { }

	// RVA: 0x9150C0 Offset: 0x913AC0 VA: 0x1809150C0
	public void Destroy() { }

	// RVA: 0x915B90 Offset: 0x914590 VA: 0x180915B90
	public void UpdateUI() { }

	// RVA: 0x915A90 Offset: 0x914490 VA: 0x180915A90
	public void UpdateMainLabel() { }

	// RVA: 0x915B30 Offset: 0x914530 VA: 0x180915B30
	public void UpdateShade() { }

	// RVA: 0x914F30 Offset: 0x913930 VA: 0x180914F30
	public void BopIcon() { }

	// RVA: 0x915450 Offset: 0x913E50 VA: 0x180915450
	private void FadeIn() { }

	// RVA: 0x915330 Offset: 0x913D30 VA: 0x180915330
	private void EntryEnded(EQuestState endState) { }

	// RVA: 0x9154D0 Offset: 0x913ED0 VA: 0x1809154D0
	private void FadeOut() { }

	// RVA: 0x914FB0 Offset: 0x9139B0 VA: 0x180914FB0
	private void Complete() { }

	// RVA: 0x915E50 Offset: 0x914850 VA: 0x180915E50
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(QuestHUDUI.<<UpdateUI>g__DelayFix|13_0>d))]
	// RVA: 0x915A20 Offset: 0x914420 VA: 0x180915A20
	private IEnumerator <UpdateUI>g__DelayFix|13_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(QuestHUDUI.<<FadeOut>g__Routine|19_0>d))]
	// RVA: 0x9159B0 Offset: 0x9143B0 VA: 0x1809159B0
	private IEnumerator <FadeOut>g__Routine|19_0() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(QuestHUDUI.<<Complete>g__Routine|20_0>d))]
	// RVA: 0x915940 Offset: 0x914340 VA: 0x180915940
	private IEnumerator <Complete>g__Routine|20_0() { }
}
