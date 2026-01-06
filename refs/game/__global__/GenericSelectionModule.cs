public class GenericSelectionModule : Singleton<GenericSelectionModule> // TypeDefIndex: 2611
{
	// Fields
	[CompilerGenerated]
	private bool <isOpen>k__BackingField; // 0x28
	[Header("References")]
	public Canvas canvas; // 0x30
	public TextMeshProUGUI TitleText; // 0x38
	public RectTransform OptionContainer; // 0x40
	public Button CloseButton; // 0x48
	[Header("Prefabs")]
	public GameObject ListOptionPrefab; // 0x50
	[HideInInspector]
	public bool OptionChosen; // 0x58
	[CompilerGenerated]
	private int <ChosenOptionIndex>k__BackingField; // 0x5C

	// Properties
	public bool isOpen { get; set; }
	[HideInInspector]
	public int ChosenOptionIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_isOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_isOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public int get_ChosenOptionIndex() { }

	[CompilerGenerated]
	// RVA: 0x8E6930 Offset: 0x8E5330 VA: 0x1808E6930
	protected void set_ChosenOptionIndex(int value) { }

	// RVA: 0x8E6300 Offset: 0x8E4D00 VA: 0x1808E6300 Slot: 5
	protected override void Awake() { }

	// RVA: 0x8E6840 Offset: 0x8E5240 VA: 0x1808E6840 Slot: 4
	protected override void Start() { }

	// RVA: 0x8E64A0 Offset: 0x8E4EA0 VA: 0x1808E64A0
	private void Exit(ExitAction action) { }

	// RVA: 0x8E6550 Offset: 0x8E4F50 VA: 0x1808E6550
	public void Open(string title, List<string> options) { }

	// RVA: 0x8E6460 Offset: 0x8E4E60 VA: 0x1808E6460
	public void Close() { }

	// RVA: 0x8E6360 Offset: 0x8E4D60 VA: 0x1808E6360
	public void Cancel() { }

	// RVA: 0x8E63A0 Offset: 0x8E4DA0 VA: 0x1808E63A0
	private void ClearOptions() { }

	// RVA: 0x8E6510 Offset: 0x8E4F10 VA: 0x1808E6510
	private void ListOptionClicked(int index) { }

	// RVA: 0x8E68F0 Offset: 0x8E52F0 VA: 0x1808E68F0
	public void .ctor() { }
}
