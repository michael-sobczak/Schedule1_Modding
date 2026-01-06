public class ListingUI : MonoBehaviour // TypeDefIndex: 3001
{
	// Fields
	public static Color32 PriceLabelColor_Normal; // 0x0
	public static Color32 PriceLabelColor_NoStock; // 0x4
	[CompilerGenerated]
	private ShopListing <Listing>k__BackingField; // 0x20
	[Header("Colors")]
	public Color32 StockLabelDefault; // 0x28
	public Color32 StockLabelNone; // 0x2C
	[Header("References")]
	public Image Icon; // 0x30
	public TextMeshProUGUI NameLabel; // 0x38
	public TextMeshProUGUI PriceLabel; // 0x40
	public TextMeshProUGUI StockLabel; // 0x48
	public GameObject LockedContainer; // 0x50
	public Button BuyButton; // 0x58
	public Button DropdownButton; // 0x60
	public EventTrigger Trigger; // 0x68
	public RectTransform DetailPanelAnchor; // 0x70
	public RectTransform DropdownAnchor; // 0x78
	public RectTransform TopDropdownAnchor; // 0x80
	public Action hoverStart; // 0x88
	public Action hoverEnd; // 0x90
	public Action onClicked; // 0x98
	public Action onDropdownClicked; // 0xA0

	// Properties
	public ShopListing Listing { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ShopListing get_Listing() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_Listing(ShopListing value) { }

	// RVA: 0x9811C0 Offset: 0x97FBC0 VA: 0x1809811C0 Slot: 4
	public virtual void Initialize(ShopListing listing) { }

	// RVA: 0x981110 Offset: 0x97FB10 VA: 0x180981110 Slot: 5
	public virtual RectTransform GetIconCopy(RectTransform parent) { }

	// RVA: 0x981750 Offset: 0x980150 VA: 0x180981750
	public void Update() { }

	// RVA: 0x9810B0 Offset: 0x97FAB0 VA: 0x1809810B0
	private void Clicked() { }

	// RVA: 0x9810E0 Offset: 0x97FAE0 VA: 0x1809810E0
	private void DropdownClicked() { }

	// RVA: 0x8E72E0 Offset: 0x8E5CE0 VA: 0x1808E72E0
	private void HoverStart() { }

	// RVA: 0x8E7310 Offset: 0x8E5D10 VA: 0x1808E7310
	private void HoverEnd() { }

	// RVA: 0x9816C0 Offset: 0x9800C0 VA: 0x1809816C0
	private void StockChanged() { }

	// RVA: 0x981820 Offset: 0x980220 VA: 0x180981820
	private void UpdatePrice() { }

	// RVA: 0x981980 Offset: 0x980380 VA: 0x180981980
	private void UpdateStock() { }

	// RVA: 0x981750 Offset: 0x980150 VA: 0x180981750
	private void UpdateButtons() { }

	// RVA: 0x981070 Offset: 0x97FA70 VA: 0x180981070
	public bool CanAddToCart() { }

	// RVA: 0x9817C0 Offset: 0x9801C0 VA: 0x1809817C0
	public void UpdateLockStatus() { }

	// RVA: 0x981C50 Offset: 0x980650 VA: 0x180981C50
	public void .ctor() { }

	// RVA: 0x981BF0 Offset: 0x9805F0 VA: 0x180981BF0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x8E72E0 Offset: 0x8E5CE0 VA: 0x1808E72E0
	private void <Initialize>b__23_0(BaseEventData <p0>) { }

	[CompilerGenerated]
	// RVA: 0x8E7310 Offset: 0x8E5D10 VA: 0x1808E7310
	private void <Initialize>b__23_1(BaseEventData <p0>) { }
}
