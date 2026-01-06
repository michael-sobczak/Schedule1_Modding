public class DealerManagementApp : App<DealerManagementApp> // TypeDefIndex: 2831
{
	// Fields
	[CompilerGenerated]
	private Dealer <SelectedDealer>k__BackingField; // 0x68
	[Header("References")]
	public Text NoDealersLabel; // 0x70
	public RectTransform Content; // 0x78
	public CustomerSelector CustomerSelector; // 0x80
	[Header("Selector")]
	public Image SelectorImage; // 0x88
	public Text SelectorTitle; // 0x90
	public Button BackButton; // 0x98
	public Button NextButton; // 0xA0
	[Header("Basic Info")]
	public Text CashLabel; // 0xA8
	public Text CutLabel; // 0xB0
	public Text HomeLabel; // 0xB8
	[Header("Inventory")]
	public RectTransform[] InventoryEntries; // 0xC0
	[Header("Customers")]
	public Text CustomerTitleLabel; // 0xC8
	public RectTransform[] CustomerEntries; // 0xD0
	public Button AssignCustomerButton; // 0xD8
	private List<Dealer> dealers; // 0xE0

	// Properties
	public Dealer SelectedDealer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public Dealer get_SelectedDealer() { }

	[CompilerGenerated]
	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	private void set_SelectedDealer(Dealer value) { }

	// RVA: 0x945380 Offset: 0x943D80 VA: 0x180945380 Slot: 4
	protected override void Awake() { }

	// RVA: 0x9469A0 Offset: 0x9453A0 VA: 0x1809469A0 Slot: 5
	protected override void Start() { }

	// RVA: 0x945880 Offset: 0x944280 VA: 0x180945880 Slot: 7
	protected override void OnDestroy() { }

	// RVA: 0x946860 Offset: 0x945260 VA: 0x180946860 Slot: 11
	public override void SetOpen(bool open) { }

	// RVA: 0x945A30 Offset: 0x944430 VA: 0x180945A30
	public void SetDisplayedDealer(Dealer dealer) { }

	// RVA: 0x945140 Offset: 0x943B40 VA: 0x180945140
	private void AddDealer(Dealer dealer) { }

	// RVA: 0x945070 Offset: 0x943A70 VA: 0x180945070
	private void AddCustomer(Customer customer) { }

	// RVA: 0x9459E0 Offset: 0x9443E0 VA: 0x1809459E0
	private void RemoveCustomer(Customer customer) { }

	// RVA: 0x945740 Offset: 0x944140 VA: 0x180945740
	private void BackPressed() { }

	// RVA: 0x9457D0 Offset: 0x9441D0 VA: 0x1809457D0
	private void NextPressed() { }

	// RVA: 0x945350 Offset: 0x943D50 VA: 0x180945350
	public void AssignCustomer() { }

	// RVA: 0x946A70 Offset: 0x945470 VA: 0x180946A70
	public void .ctor() { }
}
