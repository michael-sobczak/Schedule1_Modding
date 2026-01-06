public class ProductManagerApp : App<ProductManagerApp> // TypeDefIndex: 2817
{
	// Fields
	[Header("References")]
	public ProductManagerApp.ProductTypeContainer FavouritesContainer; // 0x68
	public List<ProductManagerApp.ProductTypeContainer> ProductTypeContainers; // 0x70
	public ProductAppDetailPanel DetailPanel; // 0x78
	public RectTransform SelectionIndicator; // 0x80
	public GameObject EntryPrefab; // 0x88
	private List<ProductEntry> favouriteEntries; // 0x90
	private List<ProductEntry> entries; // 0x98
	private ProductEntry selectedEntry; // 0xA0

	// Methods

	// RVA: 0x937A50 Offset: 0x936450 VA: 0x180937A50 Slot: 4
	protected override void Awake() { }

	// RVA: 0x938830 Offset: 0x937230 VA: 0x180938830 Slot: 5
	protected override void Start() { }

	// RVA: 0x937FF0 Offset: 0x9369F0 VA: 0x180937FF0
	private void LateUpdate() { }

	// RVA: 0x937AB0 Offset: 0x9364B0 VA: 0x180937AB0 Slot: 12
	public virtual void CreateEntry(ProductDefinition definition) { }

	// RVA: 0x9380D0 Offset: 0x936AD0 VA: 0x1809380D0
	private void ProductFavourited(ProductDefinition product) { }

	// RVA: 0x9380E0 Offset: 0x936AE0 VA: 0x1809380E0
	private void ProductUnfavourited(ProductDefinition product) { }

	// RVA: 0x937D40 Offset: 0x936740 VA: 0x180937D40
	private void CreateFavouriteEntry(ProductDefinition definition) { }

	// RVA: 0x9380F0 Offset: 0x936AF0 VA: 0x1809380F0
	private void RemoveFavouriteEntry(ProductDefinition definition) { }

	// RVA: 0x937F70 Offset: 0x936970 VA: 0x180937F70
	private void DelayedRebuildLayout() { }

	// RVA: 0x938320 Offset: 0x936D20 VA: 0x180938320
	public void SelectProduct(ProductEntry entry) { }

	// RVA: 0x9383F0 Offset: 0x936DF0 VA: 0x1809383F0 Slot: 11
	public override void SetOpen(bool open) { }

	// RVA: 0x938E20 Offset: 0x937820 VA: 0x180938E20
	public void .ctor() { }

	[CompilerGenerated]
	[IteratorStateMachine(typeof(ProductManagerApp.<<DelayedRebuildLayout>g__Delay|17_0>d))]
	// RVA: 0x938DB0 Offset: 0x9377B0 VA: 0x180938DB0
	private IEnumerator <DelayedRebuildLayout>g__Delay|17_0() { }
}
