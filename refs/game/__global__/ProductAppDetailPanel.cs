public class ProductAppDetailPanel : MonoBehaviour // TypeDefIndex: 2809
{
	// Fields
	[CompilerGenerated]
	private ProductDefinition <ActiveProduct>k__BackingField; // 0x20
	public Color AddictionColor_Min; // 0x28
	public Color AddictionColor_Max; // 0x38
	[Header("References")]
	public GameObject NothingSelected; // 0x48
	public GameObject Container; // 0x50
	public Text NameLabel; // 0x58
	public InputField ValueLabel; // 0x60
	public Text SuggestedPriceLabel; // 0x68
	public Toggle ListedForSale; // 0x70
	public Text DescLabel; // 0x78
	public Text[] PropertyLabels; // 0x80
	public RectTransform Listed; // 0x88
	public RectTransform Delisted; // 0x90
	public RectTransform NotDiscovered; // 0x98
	public RectTransform RecipesLabel; // 0xA0
	public RectTransform[] RecipeEntries; // 0xA8
	public VerticalLayoutGroup LayoutGroup; // 0xB0
	public Scrollbar AddictionSlider; // 0xB8
	public Text AddictionLabel; // 0xC0
	public ScrollRect ScrollRect; // 0xC8

	// Properties
	public ProductDefinition ActiveProduct { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public ProductDefinition get_ActiveProduct() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_ActiveProduct(ProductDefinition value) { }

	// RVA: 0x9362A0 Offset: 0x934CA0 VA: 0x1809362A0
	public void Awake() { }

	// RVA: 0x9366F0 Offset: 0x9350F0 VA: 0x1809366F0
	public void SetActiveProduct(ProductDefinition productDefinition) { }

	// RVA: 0x9379B0 Offset: 0x9363B0 VA: 0x1809379B0
	private void Update() { }

	// RVA: 0x937850 Offset: 0x936250 VA: 0x180937850
	private void UpdateListed() { }

	// RVA: 0x9378F0 Offset: 0x9362F0 VA: 0x1809378F0
	private void UpdatePrice() { }

	// RVA: 0x9363C0 Offset: 0x934DC0 VA: 0x1809363C0
	private void ListingToggled() { }

	// RVA: 0x936530 Offset: 0x934F30 VA: 0x180936530
	private void PriceSubmitted(string value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x9363C0 Offset: 0x934DC0 VA: 0x1809363C0
	private void <Awake>b__23_0(bool value) { }

	[CompilerGenerated]
	// RVA: 0x937840 Offset: 0x936240 VA: 0x180937840
	private void <Awake>b__23_1(string value) { }
}
