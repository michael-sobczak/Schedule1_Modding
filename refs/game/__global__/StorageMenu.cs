public class StorageMenu : Singleton<StorageMenu> // TypeDefIndex: 2705
{
	// Fields
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x28
	[CompilerGenerated]
	private StorageEntity <OpenedStorageEntity>k__BackingField; // 0x30
	[Header("References")]
	public Canvas Canvas; // 0x38
	public RectTransform Container; // 0x40
	public TextMeshProUGUI TitleLabel; // 0x48
	public TextMeshProUGUI SubtitleLabel; // 0x50
	public RectTransform SlotContainer; // 0x58
	public ItemSlotUI[] SlotsUIs; // 0x60
	public GridLayoutGroup SlotGridLayout; // 0x68
	public RectTransform CloseButton; // 0x70
	public UnityEvent onClosed; // 0x78

	// Properties
	public bool IsOpen { get; set; }
	public StorageEntity OpenedStorageEntity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	protected void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public StorageEntity get_OpenedStorageEntity() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_OpenedStorageEntity(StorageEntity value) { }

	// RVA: 0x918C40 Offset: 0x917640 VA: 0x180918C40 Slot: 5
	protected override void Awake() { }

	// RVA: 0x919B50 Offset: 0x918550 VA: 0x180919B50 Slot: 4
	protected override void Start() { }

	// RVA: 0x9192D0 Offset: 0x917CD0 VA: 0x1809192D0 Slot: 7
	public virtual void Open(IItemSlotOwner owner, string title, string subtitle) { }

	// RVA: 0x919AE0 Offset: 0x9184E0 VA: 0x180919AE0 Slot: 8
	public virtual void Open(StorageEntity entity) { }

	// RVA: 0x919360 Offset: 0x917D60 VA: 0x180919360
	private void Open(string title, string subtitle, IItemSlotOwner owner) { }

	// RVA: 0x919170 Offset: 0x917B70 VA: 0x180919170
	public void Close() { }

	// RVA: 0x918D30 Offset: 0x917730 VA: 0x180918D30 Slot: 9
	public virtual void CloseMenu() { }

	// RVA: 0x919210 Offset: 0x917C10 VA: 0x180919210
	private void Exit(ExitAction action) { }

	// RVA: 0x919C20 Offset: 0x918620 VA: 0x180919C20
	public void .ctor() { }
}
