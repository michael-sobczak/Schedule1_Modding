public class ItemSlotFilterButton : MonoBehaviour // TypeDefIndex: 3033
{
	// Fields
	[CompilerGenerated]
	private ItemSlot <AssignedSlot>k__BackingField; // 0x20
	public ItemSlotUI ItemSlotUI; // 0x28
	public Button Button; // 0x30
	public Image IconImage; // 0x38
	public Image SpotImage; // 0x40
	public Image[] FilterItemImages; // 0x48
	public TextMeshProUGUI FilterMoreItemsLabel; // 0x50

	// Properties
	public ItemSlot AssignedSlot { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ItemSlot get_AssignedSlot() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_AssignedSlot(ItemSlot value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x99C5D0 Offset: 0x99AFD0 VA: 0x18099C5D0
	public void AssignSlot(ItemSlot slot) { }

	// RVA: 0x99D110 Offset: 0x99BB10 VA: 0x18099D110
	public void UnassignSlot() { }

	// RVA: 0x99CC10 Offset: 0x99B610 VA: 0x18099CC10
	public void Clicked() { }

	// RVA: 0x99CD00 Offset: 0x99B700 VA: 0x18099CD00
	private void RefreshAppearance() { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
