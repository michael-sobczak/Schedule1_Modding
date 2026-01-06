public class DeliveryShop : MonoBehaviour // TypeDefIndex: 2826
{
	// Fields
	public const int DELIVERY_VEHICLE_SLOT_CAPACITY = 16;
	public const int DELIVERY_TIME_MIN = 60;
	public const int DELIVERY_TIME_MAX = 360;
	public const int DELIVERY_TIME_ITEM_COUNT_DIVISOR = 160;
	[CompilerGenerated]
	private ShopInterface <MatchingShop>k__BackingField; // 0x20
	[CompilerGenerated]
	private bool <IsExpanded>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsAvailable>k__BackingField; // 0x29
	[Header("References")]
	public Image HeaderImage; // 0x30
	public Button HeaderButton; // 0x38
	public RectTransform ContentsContainer; // 0x40
	public RectTransform ListingContainer; // 0x48
	public Text DeliveryFeeLabel; // 0x50
	public Text ItemTotalLabel; // 0x58
	public Text OrderTotalLabel; // 0x60
	public Button OrderButton; // 0x68
	public Text OrderButtonNote; // 0x70
	public Dropdown DestinationDropdown; // 0x78
	public Dropdown LoadingDockDropdown; // 0x80
	[Header("Settings")]
	public string MatchingShopInterfaceName; // 0x88
	public float DeliveryFee; // 0x90
	public bool AvailableByDefault; // 0x94
	public ListingEntry ListingEntryPrefab; // 0x98
	public Sprite HeaderImage_Hidden; // 0xA0
	public Sprite HeaderImage_Expanded; // 0xA8
	public RectTransform HeaderArrow; // 0xB0
	private List<ListingEntry> listingEntries; // 0xB8
	private Property destinationProperty; // 0xC0
	private int loadingDockIndex; // 0xC8

	// Properties
	public ShopInterface MatchingShop { get; set; }
	public bool IsExpanded { get; set; }
	public bool IsAvailable { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ShopInterface get_MatchingShop() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_MatchingShop(ShopInterface value) { }

	[CompilerGenerated]
	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_IsExpanded() { }

	[CompilerGenerated]
	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	private void set_IsExpanded(bool value) { }

	[CompilerGenerated]
	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_IsAvailable() { }

	[CompilerGenerated]
	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	private void set_IsAvailable(bool value) { }

	// RVA: 0x9489F0 Offset: 0x9473F0 VA: 0x1809489F0
	private void Start() { }

	// RVA: 0x946F10 Offset: 0x945910 VA: 0x180946F10
	private void FixedUpdate() { }

	// RVA: 0x9488A0 Offset: 0x9472A0 VA: 0x1809488A0
	public void SetIsExpanded(bool expanded) { }

	// RVA: 0x9487F0 Offset: 0x9471F0 VA: 0x1809487F0
	public void SetIsAvailable() { }

	// RVA: 0x9473E0 Offset: 0x945DE0 VA: 0x1809473E0
	public void OrderPressed() { }

	// RVA: 0x948600 Offset: 0x947000 VA: 0x180948600
	public void RefreshShop() { }

	// RVA: 0x948650 Offset: 0x947050 VA: 0x180948650
	public void ResetCart() { }

	// RVA: 0x9479E0 Offset: 0x9463E0 VA: 0x1809479E0
	private void RefreshCart() { }

	// RVA: 0x948560 Offset: 0x946F60 VA: 0x180948560
	private void RefreshOrderButton() { }

	// RVA: 0x946B20 Offset: 0x945520 VA: 0x180946B20
	public bool CanOrder(out string reason) { }

	// RVA: 0x947300 Offset: 0x945D00 VA: 0x180947300
	public bool HasActiveDelivery() { }

	// RVA: 0x9490F0 Offset: 0x947AF0 VA: 0x1809490F0
	public bool WillCartFitInVehicle() { }

	// RVA: 0x947A80 Offset: 0x946480 VA: 0x180947A80
	public void RefreshDestinationUI() { }

	// RVA: 0x946E20 Offset: 0x945820 VA: 0x180946E20
	private void DestinationDropdownSelected(int index) { }

	// RVA: 0x947260 Offset: 0x945C60 VA: 0x180947260
	private List<Property> GetPotentialDestinations() { }

	// RVA: 0x948290 Offset: 0x946C90 VA: 0x180948290
	public void RefreshLoadingDockUI() { }

	// RVA: 0x4F2500 Offset: 0x4F0F00 VA: 0x1804F2500
	private void LoadingDockDropdownSelected(int index) { }

	// RVA: 0x946FB0 Offset: 0x9459B0 VA: 0x180946FB0
	private float GetCartCost() { }

	// RVA: 0x947240 Offset: 0x945C40 VA: 0x180947240
	private float GetOrderTotal() { }

	// RVA: 0x947120 Offset: 0x945B20 VA: 0x180947120
	private int GetOrderItemCount() { }

	// RVA: 0x947FF0 Offset: 0x9469F0 VA: 0x180947FF0
	private void RefreshEntryOrder() { }

	// RVA: 0x947E50 Offset: 0x946850 VA: 0x180947E50
	private void RefreshEntriesLocked() { }

	// RVA: 0x949260 Offset: 0x947C60 VA: 0x180949260
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8E0ED0 Offset: 0x8DF8D0 VA: 0x1808E0ED0
	private bool <Start>b__37_0(ShopInterface x) { }

	[CompilerGenerated]
	// RVA: 0x9490E0 Offset: 0x947AE0 VA: 0x1809490E0
	private void <Start>b__37_1() { }
}
