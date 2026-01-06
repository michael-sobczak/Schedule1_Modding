public class ItemSetterScreen : Singleton<ItemSetterScreen> // TypeDefIndex: 1251
{
	// Fields
	[CompilerGenerated]
	private ItemList <Option>k__BackingField; // 0x28
	[Header("Prefabs")]
	public GameObject ListEntryPrefab; // 0x30
	[Header("References")]
	public RectTransform EntryContainer; // 0x38
	public TextMeshProUGUI TitleLabel; // 0x40
	private RectTransform allEntry; // 0x48
	private RectTransform noneEntry; // 0x50
	private List<ItemSetterScreen.Pair> pairs; // 0x58

	// Properties
	public ItemList Option { get; set; }
	public bool IsOpen { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ItemList get_Option() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_Option(ItemList value) { }

	// RVA: 0x5E0740 Offset: 0x5DF140 VA: 0x1805E0740
	public bool get_IsOpen() { }

	// RVA: 0x611F50 Offset: 0x610950 VA: 0x180611F50 Slot: 5
	protected override void Awake() { }

	// RVA: 0x612A10 Offset: 0x611410 VA: 0x180612A10 Slot: 7
	public virtual void Open(ItemList option) { }

	// RVA: 0x612920 Offset: 0x611320 VA: 0x180612920
	private void Exit(ExitAction action) { }

	// RVA: 0x612130 Offset: 0x610B30 VA: 0x180612130 Slot: 8
	public virtual void Close() { }

	// RVA: 0x612250 Offset: 0x610C50 VA: 0x180612250
	private RectTransform CreateEntry(Sprite icon, string label, Action onClick, string prefabID = "", bool createPair = False) { }

	// RVA: 0x611F20 Offset: 0x610920 VA: 0x180611F20
	private void AllClicked() { }

	// RVA: 0x612980 Offset: 0x611380 VA: 0x180612980
	private void NoneClicked() { }

	// RVA: 0x6127C0 Offset: 0x6111C0 VA: 0x1806127C0
	private void EntryClicked(string prefabID) { }

	// RVA: 0x612BB0 Offset: 0x6115B0 VA: 0x180612BB0
	private void RefreshTicks() { }

	// RVA: 0x613060 Offset: 0x611A60 VA: 0x180613060
	private void SetEntryTicked(RectTransform entry, bool ticked) { }

	// RVA: 0x612180 Offset: 0x610B80 VA: 0x180612180
	private void CreateEntries() { }

	// RVA: 0x612610 Offset: 0x611010 VA: 0x180612610
	private void DestroyEntries() { }

	// RVA: 0x6130E0 Offset: 0x611AE0 VA: 0x1806130E0
	public void .ctor() { }
}
