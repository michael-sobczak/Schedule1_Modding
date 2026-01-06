public class CharacterCustomizationOption : MonoBehaviour // TypeDefIndex: 2969
{
	// Fields
	public string Name; // 0x20
	public string Label; // 0x28
	public float Price; // 0x30
	public bool RequireLevel; // 0x34
	public FullRank RequiredLevel; // 0x38
	[Header("References")]
	public TextMeshProUGUI NameLabel; // 0x40
	public TextMeshProUGUI PriceLabel; // 0x48
	public TextMeshProUGUI LevelLabel; // 0x50
	public RectTransform LockDisplay; // 0x58
	public Button MainButton; // 0x60
	public Button BuyButton; // 0x68
	public RectTransform SelectionIndicator; // 0x70
	[Header("Events")]
	public UnityEvent onSelect; // 0x78
	public UnityEvent onDeselect; // 0x80
	public UnityEvent onPurchase; // 0x88
	[CompilerGenerated]
	private bool <purchased>k__BackingField; // 0x90
	private bool selected; // 0x91

	// Properties
	public bool purchased { get; set; }
	private bool purchaseable { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x979B00 Offset: 0x978500 VA: 0x180979B00
	public bool get_purchased() { }

	[CompilerGenerated]
	// RVA: 0x979B10 Offset: 0x978510 VA: 0x180979B10
	private void set_purchased(bool value) { }

	// RVA: 0x979A60 Offset: 0x978460 VA: 0x180979A60
	private bool get_purchaseable() { }

	// RVA: 0x978FC0 Offset: 0x9779C0 VA: 0x180978FC0
	private void Awake() { }

	// RVA: 0x6D1330 Offset: 0x6CFD30 VA: 0x1806D1330
	private void OnValidate() { }

	// RVA: 0x979190 Offset: 0x977B90 VA: 0x180979190
	private void FixedUpdate() { }

	// RVA: 0x9796F0 Offset: 0x9780F0 VA: 0x1809796F0
	private void Start() { }

	// RVA: 0x9793D0 Offset: 0x977DD0 VA: 0x1809793D0
	private void Selected() { }

	// RVA: 0x979280 Offset: 0x977C80 VA: 0x180979280
	private void Purchased() { }

	// RVA: 0x979700 Offset: 0x978100 VA: 0x180979700
	private void UpdatePriceColor() { }

	// RVA: 0x979480 Offset: 0x977E80 VA: 0x180979480
	public void SetSelected(bool _selected) { }

	// RVA: 0x9793E0 Offset: 0x977DE0 VA: 0x1809793E0
	public void SetPurchased(bool _purchased) { }

	// RVA: 0x9798D0 Offset: 0x9782D0 VA: 0x1809798D0
	private void UpdateUI() { }

	// RVA: 0x979240 Offset: 0x977C40 VA: 0x180979240
	public void ParentCategoryClosed() { }

	// RVA: 0x979670 Offset: 0x978070 VA: 0x180979670
	public void SiblingOptionSelected(CharacterCustomizationOption option) { }

	// RVA: 0x979590 Offset: 0x977F90 VA: 0x180979590
	public void SiblingOptionPurchased(CharacterCustomizationOption option) { }

	// RVA: 0x9799C0 Offset: 0x9783C0 VA: 0x1809799C0
	public void .ctor() { }
}
