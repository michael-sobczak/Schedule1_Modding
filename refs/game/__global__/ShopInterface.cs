public class ShopInterface : MonoBehaviour, ISaveable // TypeDefIndex: 3013
{
	// Fields
	public static List<ShopInterface> AllShops; // 0x0
	public const int MAX_ITEM_QUANTITY = 999;
	[CompilerGenerated]
	private bool <IsOpen>k__BackingField; // 0x20
	[Header("Settings")]
	public string ShopName; // 0x28
	public string ShopCode; // 0x30
	public ShopInterface.EPaymentType PaymentType; // 0x38
	public bool ShowCurrencyHint; // 0x3C
	[Header("Listings")]
	public List<ShopListing> Listings; // 0x40
	[Header("References")]
	public Canvas Canvas; // 0x48
	public RectTransform Container; // 0x50
	public RectTransform ListingContainer; // 0x58
	public TextMeshProUGUI StoreNameLabel; // 0x60
	public Cart Cart; // 0x68
	public StorageEntity[] DeliveryBays; // 0x70
	public VehicleDetector LoadingBayDetector; // 0x78
	public ShopInterfaceDetailPanel DetailPanel; // 0x80
	public ScrollRect ListingScrollRect; // 0x88
	public ShopAmountSelector AmountSelector; // 0x90
	public DeliveryVehicle DeliveryVehicle; // 0x98
	[Header("Audio")]
	public AudioSourceController AddItemSound; // 0xA0
	public AudioSourceController RemoveItemSound; // 0xA8
	public AudioSourceController CheckoutSound; // 0xB0
	[Header("Prefabs")]
	public ListingUI ListingUIPrefab; // 0xB8
	public UnityEvent onOrderCompleted; // 0xC0
	[SerializeField]
	private List<CategoryButton> categoryButtons; // 0xC8
	private EShopCategory categoryFilter; // 0xD0
	private string searchTerm; // 0xD8
	private List<ListingUI> listingUI; // 0xE0
	private ListingUI selectedListing; // 0xE8
	private bool dropdownMouseUp; // 0xF0
	private ShopLoader loader; // 0xF8
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x100
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x108
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x110

	// Properties
	public bool IsOpen { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x4945E0 Offset: 0x492FE0 VA: 0x1804945E0
	public bool get_IsOpen() { }

	[CompilerGenerated]
	// RVA: 0x494600 Offset: 0x493000 VA: 0x180494600
	protected void set_IsOpen(bool value) { }

	// RVA: 0x9876D0 Offset: 0x9860D0 VA: 0x1809876D0 Slot: 4
	public string get_SaveFolderName() { }

	// RVA: 0x9876D0 Offset: 0x9860D0 VA: 0x1809876D0 Slot: 5
	public string get_SaveFileName() { }

	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170 Slot: 6
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 7
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250 Slot: 8
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20 Slot: 9
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260 Slot: 10
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0 Slot: 11
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x9876C0 Offset: 0x9860C0 VA: 0x1809876C0 Slot: 12
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x9876E0 Offset: 0x9860E0 VA: 0x1809876E0 Slot: 13
	public void set_HasChanged(bool value) { }

	// RVA: 0x982D70 Offset: 0x981770 VA: 0x180982D70 Slot: 27
	protected virtual void Awake() { }

	// RVA: 0x9868C0 Offset: 0x9852C0 VA: 0x1809868C0 Slot: 28
	protected virtual void Start() { }

	// RVA: 0x984470 Offset: 0x982E70 VA: 0x180984470 Slot: 29
	public virtual void InitializeSaveable() { }

	// RVA: 0x984910 Offset: 0x983310 VA: 0x180984910
	private void OnDestroy() { }

	// RVA: 0x984990 Offset: 0x983390 VA: 0x180984990
	private void OnValidate() { }

	// RVA: 0x987030 Offset: 0x985A30 VA: 0x180987030 Slot: 30
	protected virtual void Update() { }

	// RVA: 0x984810 Offset: 0x983210 VA: 0x180984810
	protected void OnDayPass() { }

	// RVA: 0x984ED0 Offset: 0x9838D0 VA: 0x180984ED0
	protected void OnWeekPass() { }

	[Button]
	// RVA: 0x985180 Offset: 0x983B80 VA: 0x180985180
	public void Open() { }

	// RVA: 0x985D80 Offset: 0x984780 VA: 0x180985D80 Slot: 31
	public virtual void SetIsOpen(bool isOpen) { }

	// RVA: 0x9843D0 Offset: 0x982DD0 VA: 0x1809843D0
	private void Hint() { }

	// RVA: 0x983950 Offset: 0x982350 VA: 0x180983950 Slot: 32
	protected virtual void Exit(ExitAction action) { }

	// RVA: 0x9832A0 Offset: 0x981CA0 VA: 0x1809832A0
	private void CreateListingUI(ShopListing listing) { }

	// RVA: 0x985BD0 Offset: 0x9845D0 VA: 0x180985BD0
	public void SelectCategory(EShopCategory category) { }

	// RVA: 0x984500 Offset: 0x982F00 VA: 0x180984500 Slot: 33
	public virtual void ListingClicked(ListingUI listingUI) { }

	// RVA: 0x9867D0 Offset: 0x9851D0 VA: 0x1809867D0
	private void ShowCartAnimation(ListingUI listing) { }

	// RVA: 0x9831B0 Offset: 0x981BB0 VA: 0x1809831B0
	public void CategorySelected(EShopCategory category) { }

	// RVA: 0x9852E0 Offset: 0x983CE0 VA: 0x1809852E0
	private void PullStockVariables() { }

	// RVA: 0x983730 Offset: 0x982130 VA: 0x180983730
	private void DeselectCurrentCategory() { }

	// RVA: 0x985520 Offset: 0x983F20 VA: 0x180985520
	private void RefreshShownItems() { }

	// RVA: 0x9859D0 Offset: 0x9843D0 VA: 0x1809859D0
	private void RefreshUnlockStatus() { }

	// RVA: 0x985AC0 Offset: 0x9844C0 VA: 0x180985AC0
	private void RestockAllListings() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool CanCartFitItem(ShopListing listing) { }

	// RVA: 0x9873A0 Offset: 0x985DA0 VA: 0x1809873A0
	public bool WillCartFit() { }

	// RVA: 0x9870D0 Offset: 0x985AD0 VA: 0x1809870D0
	public bool WillCartFit(List<ItemSlot> availableSlots) { }

	// RVA: 0x983FE0 Offset: 0x9829E0 VA: 0x180983FE0 Slot: 34
	public virtual bool HandoverItems() { }

	// RVA: 0x9839B0 Offset: 0x9823B0 VA: 0x1809839B0
	public List<ItemSlot> GetAvailableSlots() { }

	// RVA: 0x983C80 Offset: 0x982680 VA: 0x180983C80
	public LandVehicle GetLoadingBayVehicle() { }

	// RVA: 0x9851A0 Offset: 0x983BA0 VA: 0x1809851A0
	public void PlaceItemInDeliveryBay(ItemInstance item) { }

	// RVA: 0x985390 Offset: 0x983D90 VA: 0x180985390
	public void QuantitySelected(int amount) { }

	// RVA: 0x984FD0 Offset: 0x9839D0 VA: 0x180984FD0
	public void OpenAmountSelector(ListingUI listing) { }

	// RVA: 0x9837E0 Offset: 0x9821E0 VA: 0x1809837E0
	private void DropdownClicked(ListingUI listing) { }

	// RVA: 0x9838C0 Offset: 0x9822C0 VA: 0x1809838C0
	private void EntryHovered(ListingUI listing) { }

	// RVA: 0x9838F0 Offset: 0x9822F0 VA: 0x1809838F0
	private void EntryUnhovered() { }

	// RVA: 0x984600 Offset: 0x983000 VA: 0x180984600
	public void Load(ShopData data) { }

	// RVA: 0x986680 Offset: 0x985080 VA: 0x180986680
	public bool ShouldSave() { }

	// RVA: 0x983BA0 Offset: 0x9825A0 VA: 0x180983BA0
	public ShopListing GetListing(string itemID) { }

	// RVA: 0x983D50 Offset: 0x982750 VA: 0x180983D50 Slot: 35
	public virtual ShopData GetSaveData() { }

	// RVA: 0x983FA0 Offset: 0x9829A0 VA: 0x180983FA0 Slot: 15
	public string GetSaveString() { }

	// RVA: 0x987460 Offset: 0x985E60 VA: 0x180987460
	public void .ctor() { }

	// RVA: 0x9873D0 Offset: 0x985DD0 VA: 0x1809873D0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x987010 Offset: 0x985A10 VA: 0x180987010
	private bool <DeselectCurrentCategory>b__73_0(CategoryButton x) { }
}
