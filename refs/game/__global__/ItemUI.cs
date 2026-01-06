public class ItemUI : MonoBehaviour // TypeDefIndex: 3034
{
	// Fields
	protected ItemInstance itemInstance; // 0x20
	[Header("References")]
	public RectTransform Rect; // 0x28
	public Image IconImg; // 0x30
	public TextMeshProUGUI QuantityLabel; // 0x38
	protected int DisplayedQuantity; // 0x40
	protected bool Destroyed; // 0x44

	// Methods

	// RVA: 0x9A3930 Offset: 0x9A2330 VA: 0x1809A3930 Slot: 4
	public virtual void Setup(ItemInstance item) { }

	// RVA: 0x9A3580 Offset: 0x9A1F80 VA: 0x1809A3580 Slot: 5
	public virtual void Destroy() { }

	// RVA: 0x9A36D0 Offset: 0x9A20D0 VA: 0x1809A36D0 Slot: 6
	public virtual RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1) { }

	// RVA: 0x9A38F0 Offset: 0x9A22F0 VA: 0x1809A38F0 Slot: 7
	public virtual void SetVisible(bool vis) { }

	// RVA: 0x9A3B40 Offset: 0x9A2540 VA: 0x1809A3B40 Slot: 8
	public virtual void UpdateUI() { }

	// RVA: 0x9A3830 Offset: 0x9A2230 VA: 0x1809A3830 Slot: 9
	public virtual void SetDisplayedQuantity(int quantity) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
