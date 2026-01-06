public class Cart : MonoBehaviour // TypeDefIndex: 2994
{
	// Fields
	[Header("References")]
	public ShopInterface Shop; // 0x20
	public Image CartIcon; // 0x28
	public TextMeshProUGUI ViewCartText; // 0x30
	public RectTransform CartEntryContainer; // 0x38
	public TextMeshProUGUI ProblemText; // 0x40
	public TextMeshProUGUI WarningText; // 0x48
	public Button BuyButton; // 0x50
	public RectTransform CartContainer; // 0x58
	public Image CartArea; // 0x60
	public TextMeshProUGUI TotalText; // 0x68
	public Toggle LoadVehicleToggle; // 0x70
	[Header("Prefabs")]
	public CartEntry EntryPrefab; // 0x78
	public Dictionary<ShopListing, int> cartDictionary; // 0x80
	private Coroutine cartIconBop; // 0x88
	private List<CartEntry> cartEntries; // 0x90

	// Methods

	// RVA: 0x975E90 Offset: 0x974890 VA: 0x180975E90 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x976AF0 Offset: 0x9754F0 VA: 0x180976AF0 Slot: 5
	protected virtual void Update() { }

	// RVA: 0x974750 Offset: 0x973150 VA: 0x180974750
	public void AddItem(ShopListing listing, int quantity) { }

	// RVA: 0x975CD0 Offset: 0x9746D0 VA: 0x180975CD0
	public void RemoveItem(ShopListing listing, int quantity) { }

	// RVA: 0x975320 Offset: 0x973D20 VA: 0x180975320
	public void ClearCart() { }

	// RVA: 0x9754D0 Offset: 0x973ED0 VA: 0x1809754D0
	public int GetCartCount(ShopListing listing) { }

	// RVA: 0x9749E0 Offset: 0x9733E0 VA: 0x1809749E0
	public void BopCartIcon() { }

	// RVA: 0x975200 Offset: 0x973C00 VA: 0x180975200
	public bool CanPlayerAffordCart() { }

	// RVA: 0x974A80 Offset: 0x973480 VA: 0x180974A80
	public void Buy() { }

	// RVA: 0x975FB0 Offset: 0x9749B0 VA: 0x180975FB0
	private void UpdateEntries() { }

	// RVA: 0x976640 Offset: 0x975040 VA: 0x180976640
	private void UpdateTotal() { }

	// RVA: 0x9764E0 Offset: 0x974EE0 VA: 0x1809764E0
	private void UpdateProblem() { }

	// RVA: 0x974F70 Offset: 0x973970 VA: 0x180974F70
	private bool CanCheckout(out string reason) { }

	// RVA: 0x975A20 Offset: 0x974420 VA: 0x180975A20
	private bool GetWarning(out string warning) { }

	// RVA: 0x976850 Offset: 0x975250 VA: 0x180976850
	private void UpdateViewCartText() { }

	// RVA: 0x976440 Offset: 0x974E40 VA: 0x180976440
	private void UpdateLoadVehicleToggle() { }

	// RVA: 0x975640 Offset: 0x974040 VA: 0x180975640
	private int GetItemSum() { }

	// RVA: 0x975750 Offset: 0x974150 VA: 0x180975750
	private float GetPriceSum() { }

	// RVA: 0x975560 Offset: 0x973F60 VA: 0x180975560
	private CartEntry GetEntry(ShopListing listing) { }

	// RVA: 0x975C30 Offset: 0x974630 VA: 0x180975C30
	private bool IsMouseOverMenuArea() { }

	// RVA: 0x9758A0 Offset: 0x9742A0 VA: 0x1809758A0
	public int GetTotalSlotRequirement() { }

	// RVA: 0x976BD0 Offset: 0x9755D0 VA: 0x180976BD0
	public void .ctor() { }

	[IteratorStateMachine(typeof(Cart.<<BopCartIcon>g__Routine|21_0>d))]
	[CompilerGenerated]
	// RVA: 0x975F40 Offset: 0x974940 VA: 0x180975F40
	private IEnumerator <BopCartIcon>g__Routine|21_0() { }
}
