public class DeliveryApp : App<DeliveryApp> // TypeDefIndex: 2825
{
	// Fields
	private List<DeliveryShop> deliveryShops; // 0x68
	public DeliveryStatusDisplay StatusDisplayPrefab; // 0x70
	[Header("References")]
	public Animation OrderSubmittedAnim; // 0x78
	public AudioSourceController OrderSubmittedSound; // 0x80
	public RectTransform StatusDisplayContainer; // 0x88
	public RectTransform NoDeliveriesIndicator; // 0x90
	public ScrollRect MainScrollRect; // 0x98
	public LayoutGroup MainLayoutGroup; // 0xA0
	private List<DeliveryStatusDisplay> statusDisplays; // 0xA8
	private bool started; // 0xB0

	// Methods

	// RVA: 0x92AA50 Offset: 0x929450 VA: 0x18092AA50 Slot: 4
	protected override void Awake() { }

	// RVA: 0x92B960 Offset: 0x92A360 VA: 0x18092B960 Slot: 5
	protected override void Start() { }

	// RVA: 0x92BCF0 Offset: 0x92A6F0 VA: 0x18092BCF0 Slot: 8
	protected override void Update() { }

	// RVA: 0x92B4E0 Offset: 0x929EE0 VA: 0x18092B4E0 Slot: 11
	public override void SetOpen(bool open) { }

	// RVA: 0x92B0C0 Offset: 0x929AC0 VA: 0x18092B0C0
	private void OnMinPass() { }

	// RVA: 0x92B230 Offset: 0x929C30 VA: 0x18092B230
	public void RefreshContent(bool keepScrollPosition = True) { }

	// RVA: 0x92B1E0 Offset: 0x929BE0 VA: 0x18092B1E0
	public void PlayOrderSubmittedAnim() { }

	// RVA: 0x92AAE0 Offset: 0x9294E0 VA: 0x18092AAE0
	private void CreateDeliveryStatusDisplay(DeliveryInstance instance) { }

	// RVA: 0x92AD30 Offset: 0x929730 VA: 0x18092AD30
	private void DeliveryCompleted(DeliveryInstance instance) { }

	// RVA: 0x92B790 Offset: 0x92A190 VA: 0x18092B790
	private void SortStatusDisplays() { }

	// RVA: 0x92B470 Offset: 0x929E70 VA: 0x18092B470
	private void RefreshNoDeliveriesIndicator() { }

	// RVA: 0x92B320 Offset: 0x929D20 VA: 0x18092B320
	public static void RefreshLayoutGroupsImmediateAndRecursive(GameObject root) { }

	// RVA: 0x92AFE0 Offset: 0x9299E0 VA: 0x18092AFE0
	public DeliveryShop GetShop(ShopInterface matchingShop) { }

	// RVA: 0x92AF00 Offset: 0x929900 VA: 0x18092AF00
	public DeliveryShop GetShop(string shopName) { }

	// RVA: 0x92BD30 Offset: 0x92A730 VA: 0x18092BD30
	public void .ctor() { }
}
