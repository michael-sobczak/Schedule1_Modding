public class CounterOfferProductSelector : MonoBehaviour // TypeDefIndex: 2789
{
	// Fields
	public const int ENTRIES_PER_PAGE = 25;
	public RectTransform Container; // 0x20
	public InputField SearchBar; // 0x28
	public RectTransform ProductContainer; // 0x30
	public Text PageLabel; // 0x38
	public GameObject ProductEntryPrefab; // 0x40
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x48
	public Action<ProductDefinition> onProductPreviewed; // 0x50
	public Action<ProductDefinition> onProductSelected; // 0x58
	private List<RectTransform> productEntries; // 0x60
	private Dictionary<ProductDefinition, RectTransform> productEntriesDict; // 0x68
	private string searchTerm; // 0x70
	private int pageIndex; // 0x78
	private int pageCount; // 0x7C
	private List<ProductDefinition> results; // 0x80
	private ProductDefinition lastPreviewedResult; // 0x88

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_IsOpen(bool value) { }

	// RVA: 0x927220 Offset: 0x925C20 VA: 0x180927220
	public void Awake() { }

	// RVA: 0x9281F0 Offset: 0x926BF0 VA: 0x1809281F0
	public void Open() { }

	// RVA: 0x9272E0 Offset: 0x925CE0 VA: 0x1809272E0
	public void Close() { }

	// RVA: 0x928CA0 Offset: 0x9276A0 VA: 0x180928CA0
	private void Update() { }

	// RVA: 0x928B80 Offset: 0x927580 VA: 0x180928B80
	public void SetSearchTerm(string search) { }

	// RVA: 0x928430 Offset: 0x926E30 VA: 0x180928430
	private void RebuildResultsList() { }

	// RVA: 0x927820 Offset: 0x926220 VA: 0x180927820
	private List<ProductDefinition> GetMatchingProducts(string searchTerm) { }

	// RVA: 0x9276A0 Offset: 0x9260A0 VA: 0x1809276A0
	private void EnsureAllEntriesExist() { }

	// RVA: 0x927320 Offset: 0x925D20 VA: 0x180927320
	private void CreateProductEntry(ProductDefinition product) { }

	// RVA: 0x9272D0 Offset: 0x925CD0 VA: 0x1809272D0
	public void ChangePage(int change) { }

	// RVA: 0x928690 Offset: 0x927090 VA: 0x180928690
	private void SetPage(int page) { }

	// RVA: 0x928380 Offset: 0x926D80 VA: 0x180928380
	private void ProductHovered(ProductDefinition def) { }

	// RVA: 0x9283D0 Offset: 0x926DD0 VA: 0x1809283D0
	private void ProductSelected(ProductDefinition def) { }

	// RVA: 0x928060 Offset: 0x926A60 VA: 0x180928060
	public bool IsMouseOverSelector() { }

	// RVA: 0x928D50 Offset: 0x927750 VA: 0x180928D50
	public void .ctor() { }
}
