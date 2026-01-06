public class ItemInfoPanel : MonoBehaviour // TypeDefIndex: 3032
{
	// Fields
	public const float VERTICAL_THRESHOLD = 200;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[CompilerGenerated]
	private ItemInstance <CurrentItem>k__BackingField; // 0x28
	[Header("References")]
	public RectTransform Container; // 0x30
	public RectTransform ContentContainer; // 0x38
	public GameObject TopArrow; // 0x40
	public GameObject BottomArrow; // 0x48
	public Canvas Canvas; // 0x50
	[Header("Settings")]
	public Vector2 Offset; // 0x58
	[Header("Prefabs")]
	public ItemInfoContent DefaultContentPrefab; // 0x60
	private ItemInfoContent content; // 0x68

	// Properties
	public bool IsOpen { get; set; }
	public ItemInstance CurrentItem { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public ItemInstance get_CurrentItem() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_CurrentItem(ItemInstance value) { }

	// RVA: 0x996DC0 Offset: 0x9957C0 VA: 0x180996DC0
	private void Awake() { }

	// RVA: 0x996EA0 Offset: 0x9958A0 VA: 0x180996EA0
	public void Open(ItemInstance item, RectTransform rect) { }

	// RVA: 0x997250 Offset: 0x995C50 VA: 0x180997250
	public void Open(ItemDefinition def, RectTransform rect) { }

	// RVA: 0x996DD0 Offset: 0x9957D0 VA: 0x180996DD0
	public void Close() { }

	// RVA: 0x997580 Offset: 0x995F80 VA: 0x180997580
	public void .ctor() { }
}
