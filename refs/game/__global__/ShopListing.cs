public class ShopListing // TypeDefIndex: 3019
{
	// Fields
	public string name; // 0x10
	public StorableItemDefinition Item; // 0x18
	[SerializeField]
	[Header("Pricing")]
	protected bool OverridePrice; // 0x20
	[SerializeField]
	protected float OverriddenPrice; // 0x24
	[Header("Stock")]
	public bool LimitedStock; // 0x28
	public int DefaultStock; // 0x2C
	public ShopListing.ERestockRate RestockRate; // 0x30
	public bool TieStockToNumberVariable; // 0x34
	public string StockVariableName; // 0x38
	[Header("Purchase Tracking")]
	public bool TrackPurchases; // 0x40
	public string PurchasedQuantityVariableName; // 0x48
	[Header("Settings")]
	public bool EnforceMinimumGameCreationVersion; // 0x50
	public float MinimumGameCreationVersion; // 0x54
	public bool CanBeDelivered; // 0x58
	[Header("Color")]
	public bool UseIconTint; // 0x59
	public Color IconTint; // 0x5C
	[Header("Visibility")]
	public bool ConditionalVisibility; // 0x6C
	public string ConditionalVisibilityVariableName; // 0x70
	[CompilerGenerated]
	private ShopInterface <Shop>k__BackingField; // 0x78
	[CompilerGenerated]
	private int <CurrentStock>k__BackingField; // 0x80
	[CompilerGenerated]
	private int <QuantityInCart>k__BackingField; // 0x84
	public Action onStockChanged; // 0x88
	private NumberVariable stockVariable; // 0x90
	private NumberVariable purchasedQuantityVariable; // 0x98
	private BoolVariable conditionalVisibilityVariable; // 0xA0

	// Properties
	public bool IsInStock { get; }
	public float Price { get; }
	public bool IsUnlimitedStock { get; }
	public ShopInterface Shop { get; set; }
	public int CurrentStock { get; set; }
	public int QuantityInCart { get; set; }
	public int CurrentStockMinusCart { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool get_IsInStock() { }

	// RVA: 0x9883A0 Offset: 0x986DA0 VA: 0x1809883A0
	public float get_Price() { }

	// RVA: 0x988390 Offset: 0x986D90 VA: 0x180988390
	public bool get_IsUnlimitedStock() { }

	[CompilerGenerated]
	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public ShopInterface get_Shop() { }

	[CompilerGenerated]
	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	private void set_Shop(ShopInterface value) { }

	[CompilerGenerated]
	// RVA: 0x4D6280 Offset: 0x4D4C80 VA: 0x1804D6280
	public int get_CurrentStock() { }

	[CompilerGenerated]
	// RVA: 0x4D6540 Offset: 0x4D4F40 VA: 0x1804D6540
	protected void set_CurrentStock(int value) { }

	[CompilerGenerated]
	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0
	public int get_QuantityInCart() { }

	[CompilerGenerated]
	// RVA: 0x9883D0 Offset: 0x986DD0 VA: 0x1809883D0
	private void set_QuantityInCart(int value) { }

	// RVA: 0x988380 Offset: 0x986D80 VA: 0x180988380
	public int get_CurrentStockMinusCart() { }

	// RVA: 0x987850 Offset: 0x986250 VA: 0x180987850
	public void Initialize(ShopInterface shop) { }

	// RVA: 0x987F00 Offset: 0x986900 VA: 0x180987F00
	public void Restock(bool network) { }

	// RVA: 0x987E50 Offset: 0x986850 VA: 0x180987E50
	public void RemoveStock(int quantity) { }

	// RVA: 0x987F40 Offset: 0x986940 VA: 0x180987F40
	public void SetStock(int quantity, bool network = True) { }

	// RVA: 0x987D80 Offset: 0x986780 VA: 0x180987D80
	public void PullStockFromVariable() { }

	// RVA: 0x9882B0 Offset: 0x986CB0 VA: 0x1809882B0
	private void StockVariableChanged(float newValue) { }

	// RVA: 0x9881F0 Offset: 0x986BF0 VA: 0x1809881F0 Slot: 4
	public virtual bool ShouldShow() { }

	// RVA: 0x9876F0 Offset: 0x9860F0 VA: 0x1809876F0 Slot: 5
	public virtual bool DoesListingMatchCategoryFilter(EShopCategory category) { }

	// RVA: 0x9877F0 Offset: 0x9861F0 VA: 0x1809877F0 Slot: 6
	public virtual bool DoesListingMatchSearchTerm(string searchTerm) { }

	// RVA: 0x987F10 Offset: 0x986910 VA: 0x180987F10
	public void SetQuantityInCart(int quantity) { }

	// RVA: 0x97B910 Offset: 0x97A310 VA: 0x18097B910
	public void .ctor() { }
}
