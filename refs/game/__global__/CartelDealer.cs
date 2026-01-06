public class CartelDealer : Dealer // TypeDefIndex: 2079
{
	// Fields
	public const float DEALER_DEFEATED_INFLUENCE_CHANGE = -0.1;
	public const int PRODUCT_COUNT_MIN = 2;
	public const int PRODUCT_COUNT_MAX = 4;
	public const int PRODUCT_QUANTITY_MIN = 1;
	public const int PRODUCT_QUANTITY_MAX = 10;
	[CompilerGenerated]
	private bool <IsAcceptingDeals>k__BackingField; // 0x3F0
	[Header("Cartel Dealer Inventory Settings")]
	public ProductDefinition[] RandomProducts; // 0x3F8
	public EQuality ProductQuality; // 0x400
	public PackagingDefinition DefaultPackaging; // 0x408
	private CartelGoonAppearance appearance; // 0x410
	private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelDealerAssembly-CSharp.dll_Excuted; // 0x418
	private bool NetworkInitialize__LateScheduleOne.Cartel.CartelDealerAssembly-CSharp.dll_Excuted; // 0x419

	// Properties
	public bool IsAcceptingDeals { get; set; }
	private GoonPool GoonPool { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x803DE0 Offset: 0x8027E0 VA: 0x180803DE0
	public bool get_IsAcceptingDeals() { }

	[CompilerGenerated]
	// RVA: 0x803DF0 Offset: 0x8027F0 VA: 0x180803DF0
	private void set_IsAcceptingDeals(bool value) { }

	// RVA: 0x803D60 Offset: 0x802760 VA: 0x180803D60
	private GoonPool get_GoonPool() { }

	// RVA: 0x803C60 Offset: 0x802660 VA: 0x180803C60 Slot: 71
	protected override void Start() { }

	// RVA: 0x803200 Offset: 0x801C00 VA: 0x180803200 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x803320 Offset: 0x801D20 VA: 0x180803320
	public void RandomizeInventory() { }

	// RVA: 0x803280 Offset: 0x801C80 VA: 0x180803280
	public void RandomizeAppearance() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x802C50 Offset: 0x801650 VA: 0x180802C50
	private void ConfigureGoonSettings(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed) { }

	// RVA: 0x803AD0 Offset: 0x8024D0 VA: 0x180803AD0
	public void SetIsAcceptingDeals(bool accepting) { }

	// RVA: 0x802C20 Offset: 0x801620 VA: 0x180802C20
	public bool CanCurrentlyAcceptDeal() { }

	// RVA: 0x802F00 Offset: 0x801900 VA: 0x180802F00
	private void DiedOrKnockedOut() { }

	// RVA: 0x803D10 Offset: 0x802710 VA: 0x180803D10
	public void .ctor() { }

	// RVA: 0x803120 Offset: 0x801B20 VA: 0x180803120 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x803100 Offset: 0x801B00 VA: 0x180803100 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x803800 Offset: 0x802200 VA: 0x180803800
	private void RpcWriter___Observers_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed) { }

	// RVA: 0x8034B0 Offset: 0x801EB0 VA: 0x1808034B0
	private void RpcLogic___ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed) { }

	// RVA: 0x8036F0 Offset: 0x8020F0 VA: 0x1808036F0
	private void RpcReader___Observers_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x803970 Offset: 0x802370 VA: 0x180803970
	private void RpcWriter___Target_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed) { }

	// RVA: 0x803780 Offset: 0x802180 VA: 0x180803780
	private void RpcReader___Target_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x719FD0 Offset: 0x7189D0 VA: 0x180719FD0 Slot: 65
	public override void Awake() { }
}
