public class CounterofferInterface : MonoBehaviour // TypeDefIndex: 2786
{
	// Fields
	public const int COUNTEROFFER_SUCCESS_XP = 5;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	public const int MinQuantity = 1;
	public int MaxQuantity; // 0x24
	public const float MinPrice = 1;
	public const float MaxPrice = 9999;
	public float IconAlignment; // 0x28
	public GameObject ProductEntryPrefab; // 0x30
	[Header("References")]
	public GameObject Container; // 0x38
	public Text TitleLabel; // 0x40
	public Button ConfirmButton; // 0x48
	public Image ProductIcon; // 0x50
	public Text ProductLabel; // 0x58
	public RectTransform ProductLabelRect; // 0x60
	public InputField PriceInput; // 0x68
	public Text FairPriceLabel; // 0x70
	public CounterOfferProductSelector ProductSelector; // 0x78
	private Action<ProductDefinition, int, float> orderConfirmedCallback; // 0x80
	private ProductDefinition selectedProduct; // 0x88
	private int quantity; // 0x90
	private float price; // 0x94
	private Dictionary<ProductDefinition, RectTransform> productEntries; // 0x98
	private bool mouseUp; // 0xA0
	private MSGConversation conversation; // 0xA8

	// Properties
	public bool IsOpen { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	private void set_IsOpen(bool value) { }

	// RVA: 0x928E90 Offset: 0x927890 VA: 0x180928E90
	private void Awake() { }

	// RVA: 0x929990 Offset: 0x928390 VA: 0x180929990
	private void Start() { }

	// RVA: 0x929C00 Offset: 0x928600 VA: 0x180929C00
	private void Update() { }

	// RVA: 0x9294F0 Offset: 0x927EF0 VA: 0x1809294F0
	public void Open(ProductDefinition product, int quantity, float price, MSGConversation _conversation, Action<ProductDefinition, int, float> _orderConfirmedCallback) { }

	// RVA: 0x929130 Offset: 0x927B30 VA: 0x180929130
	public void Close() { }

	// RVA: 0x9292F0 Offset: 0x927CF0 VA: 0x1809292F0
	public void Exit(ExitAction action) { }

	// RVA: 0x929800 Offset: 0x928200 VA: 0x180929800
	public void Send() { }

	// RVA: 0x929A30 Offset: 0x928430 VA: 0x180929A30
	private void UpdateFairPrice() { }

	// RVA: 0x9298F0 Offset: 0x9282F0 VA: 0x1809298F0
	private void SetProduct(ProductDefinition newProduct) { }

	// RVA: 0x9292A0 Offset: 0x927CA0 VA: 0x1809292A0
	private void DisplayProduct(ProductDefinition tempProduct) { }

	// RVA: 0x9290D0 Offset: 0x927AD0 VA: 0x1809290D0
	public void ChangeQuantity(int change) { }

	// RVA: 0x929AD0 Offset: 0x9284D0 VA: 0x180929AD0
	private void UpdatePriceQuantityLabel(string productName) { }

	// RVA: 0x929060 Offset: 0x927A60 VA: 0x180929060
	public void ChangePrice(float change) { }

	// RVA: 0x929750 Offset: 0x928150 VA: 0x180929750
	public void PriceSubmitted(string value) { }

	// RVA: 0x929340 Offset: 0x927D40 VA: 0x180929340
	public void OpenProductSelector() { }

	// RVA: 0x929E70 Offset: 0x928870 VA: 0x180929E70
	public void .ctor() { }
}
