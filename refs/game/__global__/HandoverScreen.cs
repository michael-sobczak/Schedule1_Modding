public class HandoverScreen : Singleton<HandoverScreen> // TypeDefIndex: 2959
{
	// Fields
	public const int CUSTOMER_SLOT_COUNT = 4;
	public const float VEHICLE_MAX_DIST = 20;
	[CompilerGenerated]
	private Contract <CurrentContract>k__BackingField; // 0x28
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x30
	[CompilerGenerated]
	private bool <TutorialOpen>k__BackingField; // 0x31
	[CompilerGenerated]
	private HandoverScreen.EMode <Mode>k__BackingField; // 0x34
	[CompilerGenerated]
	private Customer <CurrentCustomer>k__BackingField; // 0x38
	[Header("Settings")]
	public Gradient SuccessColorMap; // 0x40
	[Header("References")]
	public Canvas Canvas; // 0x48
	public GameObject Container; // 0x50
	public CanvasGroup CanvasGroup; // 0x58
	public TextMeshProUGUI DescriptionLabel; // 0x60
	public TextMeshProUGUI CustomerSubtitle; // 0x68
	public TextMeshProUGUI FavouriteDrugLabel; // 0x70
	public TextMeshProUGUI FavouritePropertiesLabel; // 0x78
	public TextMeshProUGUI[] PropertiesEntries; // 0x80
	public RectTransform[] ExpectationEntries; // 0x88
	public GameObject NoVehicle; // 0x90
	public RectTransform VehicleSlotContainer; // 0x98
	public RectTransform CustomerSlotContainer; // 0xA0
	public TextMeshProUGUI VehicleSubtitle; // 0xA8
	public TextMeshProUGUI SuccessLabel; // 0xB0
	public TextMeshProUGUI ErrorLabel; // 0xB8
	public TextMeshProUGUI WarningLabel; // 0xC0
	public Button DoneButton; // 0xC8
	public RectTransform VehicleContainer; // 0xD0
	public TextMeshProUGUI TitleLabel; // 0xD8
	public HandoverScreenPriceSelector PriceSelector; // 0xE0
	public TextMeshProUGUI FairPriceLabel; // 0xE8
	public Animation TutorialAnimation; // 0xF0
	public RectTransform TutorialContainer; // 0xF8
	public HandoverScreenDetailPanel DetailPanel; // 0x100
	public Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> onHandoverComplete; // 0x108
	public Func<List<ItemInstance>, float, float> SuccessChanceMethod; // 0x110
	private ItemSlotUI[] VehicleSlotUIs; // 0x118
	private ItemSlotUI[] CustomerSlotUIs; // 0x120
	private ItemSlot[] CustomerSlots; // 0x128
	private Dictionary<ItemInstance, HandoverScreen.EItemSource> OriginalItemLocations; // 0x130
	private bool ignoreCustomerChangedEvents; // 0x138
	private bool requireFullChanceOfSuccess; // 0x139

	// Properties
	public Contract CurrentContract { get; set; }
	public bool IsOpen { get; set; }
	public bool TutorialOpen { get; set; }
	public HandoverScreen.EMode Mode { get; set; }
	public Customer CurrentCustomer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public Contract get_CurrentContract() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_CurrentContract(Contract value) { }

	[CompilerGenerated]
	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x4CEB50 Offset: 0x4CD550 VA: 0x1804CEB50
	protected void set_IsOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CD9C0 Offset: 0x4CC3C0 VA: 0x1804CD9C0
	public bool get_TutorialOpen() { }

	[CompilerGenerated]
	// RVA: 0x50AAE0 Offset: 0x5094E0 VA: 0x18050AAE0
	private void set_TutorialOpen(bool value) { }

	[CompilerGenerated]
	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public HandoverScreen.EMode get_Mode() { }

	[CompilerGenerated]
	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	protected void set_Mode(HandoverScreen.EMode value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Customer get_CurrentCustomer() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_CurrentCustomer(Customer value) { }

	// RVA: 0x95CF00 Offset: 0x95B900 VA: 0x18095CF00 Slot: 4
	protected override void Start() { }

	// RVA: 0x95DDF0 Offset: 0x95C7F0 VA: 0x18095DDF0
	private void Update() { }

	// RVA: 0x95B230 Offset: 0x959C30 VA: 0x18095B230
	private void OpenTutorial() { }

	// RVA: 0x959CD0 Offset: 0x9586D0 VA: 0x180959CD0
	public void CloseTutorial() { }

	[Button]
	// RVA: 0x95D540 Offset: 0x95BF40 VA: 0x18095D540
	public void TestOpen() { }

	// RVA: 0x95B2A0 Offset: 0x959CA0 VA: 0x18095B2A0 Slot: 7
	public virtual void Open(Contract contract, Customer customer, HandoverScreen.EMode mode, Action<HandoverScreen.EHandoverOutcome, List<ItemInstance>, float> callback, Func<List<ItemInstance>, float, float> successChanceMethod, bool _requireFullChanceOfSuccess = False) { }

	// RVA: 0x959D30 Offset: 0x958730 VA: 0x180959D30 Slot: 8
	public virtual void Close(HandoverScreen.EHandoverOutcome outcome) { }

	// RVA: 0x95A490 Offset: 0x958E90 VA: 0x18095A490
	public void DonePressed() { }

	// RVA: 0x95CCE0 Offset: 0x95B6E0 VA: 0x18095CCE0
	private void RecordOriginalLocations() { }

	// RVA: 0x95A4B0 Offset: 0x958EB0 VA: 0x18095A4B0
	private void Exit(ExitAction action) { }

	// RVA: 0x959BB0 Offset: 0x9585B0 VA: 0x180959BB0
	public void ClearCustomerSlots(bool returnToOriginals) { }

	// RVA: 0x95A2A0 Offset: 0x958CA0 VA: 0x18095A2A0
	private void CustomerItemsChanged() { }

	// RVA: 0x95D990 Offset: 0x95C390 VA: 0x18095D990
	private void UpdateDoneButton() { }

	// RVA: 0x95DAC0 Offset: 0x95C4C0 VA: 0x18095DAC0
	private void UpdateSuccessChance() { }

	// RVA: 0x95AB80 Offset: 0x959580 VA: 0x18095AB80
	private bool GetError(out string err) { }

	// RVA: 0x95AF10 Offset: 0x959910 VA: 0x18095AF10
	private bool GetWarning(out string warning) { }

	// RVA: 0x95A9B0 Offset: 0x9593B0 VA: 0x18095A9B0
	private List<ItemInstance> GetCustomerItems(bool onlyPackagedProduct = True) { }

	// RVA: 0x95A730 Offset: 0x959130 VA: 0x18095A730
	private float GetCustomerItemsValue() { }

	// RVA: 0x95A560 Offset: 0x958F60 VA: 0x18095A560
	private int GetCustomerItemsCount(bool onlyPackagedProduct = True) { }

	// RVA: 0x95DF30 Offset: 0x95C930 VA: 0x18095DF30
	public void .ctor() { }
}
