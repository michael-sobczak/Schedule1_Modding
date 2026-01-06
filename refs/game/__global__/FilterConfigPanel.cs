public class FilterConfigPanel : MonoBehaviour // TypeDefIndex: 3028
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemSlot <OpenSlot>k__BackingField; // 0x28
	public GameObject ItemEntryPrefab; // 0x30
	public GameObject CategoryPrefab; // 0x38
	public GameObject SearchItemPrefab; // 0x40
	[Header("References")]
	public RectTransform Rect; // 0x48
	public GameObject Container; // 0x50
	public Button TypeButton_None; // 0x58
	public Button TypeButton_Whitelist; // 0x60
	public Button TypeButton_Blacklist; // 0x68
	public TextMeshProUGUI TypeLabel; // 0x70
	public TextMeshProUGUI ListLabel; // 0x78
	public RectTransform ListContainer; // 0x80
	public GameObject ListBlocker; // 0x88
	public Button[] QualityButtons; // 0x90
	public ScrollRect ListScrollRect; // 0x98
	public RectTransform Dropdown; // 0xA0
	public Button CopyButton; // 0xA8
	public Button PasteButton; // 0xB0
	public Button ApplyToSiblingsButton; // 0xB8
	public Button ClearButton; // 0xC0
	[Header("Search")]
	public RectTransform SearchContainer; // 0xC8
	public TMP_InputField SearchInput; // 0xD0
	public RectTransform CategoryContainer; // 0xD8
	private bool mouseUp; // 0xE0
	private List<FilterConfigPanel.SearchCategory> searchCategories; // 0xE8
	private List<RectTransform> itemEntries; // 0xF0
	private static SlotFilter copiedFilter; // 0x0

	// Properties
	public bool IsOpen { get; set; }
	public ItemSlot OpenSlot { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ItemSlot get_OpenSlot() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_OpenSlot(ItemSlot value) { }

	// RVA: 0x97D870 Offset: 0x97C270 VA: 0x18097D870
	private void Awake() { }

	// RVA: 0x97FAE0 Offset: 0x97E4E0 VA: 0x18097FAE0
	private void Start() { }

	// RVA: 0x97DE30 Offset: 0x97C830 VA: 0x18097DE30
	private void Exit(ExitAction exit) { }

	// RVA: 0x980250 Offset: 0x97EC50 VA: 0x180980250
	private void Update() { }

	// RVA: 0x97E930 Offset: 0x97D330 VA: 0x18097E930
	public void Open(ItemSlotUI ui) { }

	// RVA: 0x97DAC0 Offset: 0x97C4C0 VA: 0x18097DAC0
	public void Close() { }

	// RVA: 0x97FBD0 Offset: 0x97E5D0 VA: 0x18097FBD0
	private void UpdateSearch() { }

	// RVA: 0x97DED0 Offset: 0x97C8D0 VA: 0x18097DED0
	public void FilterModeSelected(int filterType) { }

	// RVA: 0x97DED0 Offset: 0x97C8D0 VA: 0x18097DED0
	public void FilterModeSelected(SlotFilter.EType filterType) { }

	// RVA: 0x97EEE0 Offset: 0x97D8E0 VA: 0x18097EEE0
	public void QualitySelected(int quality) { }

	// RVA: 0x97EEE0 Offset: 0x97D8E0 VA: 0x18097EEE0
	public void QualitySelected(EQuality quality) { }

	// RVA: 0x97D540 Offset: 0x97BF40 VA: 0x18097D540
	public void AddClicked() { }

	// RVA: 0x97DD30 Offset: 0x97C730 VA: 0x18097DD30
	public void CopyClicked() { }

	// RVA: 0x97EE50 Offset: 0x97D850 VA: 0x18097EE50
	public void PasteClicked() { }

	// RVA: 0x97D6C0 Offset: 0x97C0C0 VA: 0x18097D6C0
	public void ApplyToSiblingsClicked() { }

	// RVA: 0x97D990 Offset: 0x97C390 VA: 0x18097D990
	public void ClearClicked() { }

	// RVA: 0x97FAF0 Offset: 0x97E4F0 VA: 0x18097FAF0
	public void ToggleDropdown() { }

	// RVA: 0x97E6E0 Offset: 0x97D0E0 VA: 0x18097E6E0
	public void OpenDropdown() { }

	// RVA: 0x97DA40 Offset: 0x97C440 VA: 0x18097DA40
	public void CloseDropdown() { }

	// RVA: 0x97E5E0 Offset: 0x97CFE0 VA: 0x18097E5E0
	private void ItemClicked(string itemID) { }

	// RVA: 0x97D610 Offset: 0x97C010 VA: 0x18097D610
	private void AddItem(string itemID) { }

	// RVA: 0x97FA40 Offset: 0x97E440 VA: 0x18097FA40
	private void RemoveItem(string itemID) { }

	// RVA: 0x97F000 Offset: 0x97DA00 VA: 0x18097F000
	private void RefreshDisplay() { }

	// RVA: 0x97E3F0 Offset: 0x97CDF0 VA: 0x18097E3F0
	private bool IsMouseOverPanel() { }

	// RVA: 0x97E510 Offset: 0x97CF10 VA: 0x18097E510
	private bool IsMouseOverSearch() { }

	// RVA: 0x97E320 Offset: 0x97CD20 VA: 0x18097E320
	private bool IsMouseOverDropdown() { }

	// RVA: 0x97DF10 Offset: 0x97C910 VA: 0x18097DF10
	private FilterConfigPanel.SearchCategory GetSearchCategory(EItemCategory category) { }

	// RVA: 0x97E860 Offset: 0x97D260 VA: 0x18097E860
	private void OpenSearch() { }

	// RVA: 0x97DA80 Offset: 0x97C480 VA: 0x18097DA80
	private void CloseSearch() { }

	// RVA: 0x97FAD0 Offset: 0x97E4D0 VA: 0x18097FAD0
	private void SearchChanged(string search) { }

	// RVA: 0x97F910 Offset: 0x97E310 VA: 0x18097F910
	private void RefreshSearchResults() { }

	// RVA: 0x980640 Offset: 0x97F040 VA: 0x180980640
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(FilterConfigPanel.<<Open>g__Open|39_0>d))]
	// RVA: 0x97FB60 Offset: 0x97E560 VA: 0x18097FB60
	private IEnumerator <Open>g__Open|39_0() { }
}
