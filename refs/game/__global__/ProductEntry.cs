public class ProductEntry : MonoBehaviour // TypeDefIndex: 2520
{
	// Fields
	[CompilerGenerated]
	private ProductDefinition <Definition>k__BackingField; // 0x20
	public Color SelectedColor; // 0x28
	public Color DeselectedColor; // 0x38
	public Color FavouritedColor; // 0x48
	public Color UnfavouritedColor; // 0x58
	[Header("References")]
	public Button Button; // 0x68
	public Image Frame; // 0x70
	public Image Icon; // 0x78
	public RectTransform Tick; // 0x80
	public RectTransform Cross; // 0x88
	public EventTrigger Trigger; // 0x90
	public Button FavouriteButton; // 0x98
	public Image FavouriteIcon; // 0xA0
	public UnityEvent onHovered; // 0xA8
	private bool destroyed; // 0xB0

	// Properties
	public ProductDefinition Definition { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ProductDefinition get_Definition() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_Definition(ProductDefinition value) { }

	// RVA: 0x8B74D0 Offset: 0x8B5ED0 VA: 0x1808B74D0
	public void Initialize(ProductDefinition definition) { }

	// RVA: 0x8B7320 Offset: 0x8B5D20 VA: 0x1808B7320
	public void Destroy() { }

	// RVA: 0x8B7C80 Offset: 0x8B6680 VA: 0x1808B7C80
	private void OnDestroy() { }

	// RVA: 0x8B7290 Offset: 0x8B5C90 VA: 0x1808B7290
	private void Clicked() { }

	// RVA: 0x8B73A0 Offset: 0x8B5DA0 VA: 0x1808B73A0
	private void FavouriteClicked() { }

	// RVA: 0x8B8280 Offset: 0x8B6C80 VA: 0x1808B8280
	private void ProductListedOrDelisted(ProductDefinition def) { }

	// RVA: 0x8B8620 Offset: 0x8B7020 VA: 0x1808B8620
	public void UpdateListed() { }

	// RVA: 0x8B8200 Offset: 0x8B6C00 VA: 0x1808B8200
	private void ProductFavouritedOrUnFavourited(ProductDefinition def) { }

	// RVA: 0x8B84E0 Offset: 0x8B6EE0 VA: 0x1808B84E0
	public void UpdateFavourited() { }

	// RVA: 0x8B8330 Offset: 0x8B6D30 VA: 0x1808B8330
	public void UpdateDiscovered(ProductDefinition def) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x8B8300 Offset: 0x8B6D00 VA: 0x1808B8300
	private void <Initialize>b__18_0(BaseEventData data) { }
}
