public class ProductManager : NetworkSingleton<ProductManager>, IBaseSaveable, ISaveable // TypeDefIndex: 2484
{
	// Fields
	public const int MIN_PRICE = 1;
	public const int MAX_PRICE = 999;
	public const int CONTRACT_RECEIPT_MAX_COUNT = 50;
	public const int STAGGERED_REPLICATIONS_PER_SECOND = 80;
	public Action<ProductDefinition> onProductDiscovered; // 0x120
	public static List<ProductDefinition> DiscoveredProducts; // 0x0
	public static List<ProductDefinition> ListedProducts; // 0x8
	public static List<ProductDefinition> FavouritedProducts; // 0x10
	[CompilerGenerated]
	private static bool <IsAcceptingOrders>k__BackingField; // 0x18
	public List<ProductDefinition> AllProducts; // 0x128
	public List<ProductDefinition> DefaultKnownProducts; // 0x130
	public List<PropertyItemDefinition> ValidMixIngredients; // 0x138
	public List<ContractReceipt> ContractReceipts; // 0x140
	public AnimationCurve SampleSuccessCurve; // 0x148
	public ProductDefinition[] ListForSaleOnStart; // 0x150
	[Header("Default Products")]
	public WeedDefinition DefaultWeed; // 0x158
	public CocaineDefinition DefaultCocaine; // 0x160
	public MethDefinition DefaultMeth; // 0x168
	public ShroomDefinition DefaultShroom; // 0x170
	[Header("Mix Maps")]
	public MixerMap WeedMixMap; // 0x178
	public MixerMap MethMixMap; // 0x180
	public MixerMap CokeMixMap; // 0x188
	public MixerMap ShroomMixMap; // 0x190
	private List<ProductDefinition> createdProducts; // 0x198
	[CompilerGenerated]
	private NewMixOperation <CurrentMixOperation>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private bool <IsMixComplete>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private float <TimeSinceProductListingChanged>k__BackingField; // 0x1AC
	public Action<NewMixOperation> onMixCompleted; // 0x1B0
	public Action<ProductDefinition> onNewProductCreated; // 0x1B8
	public Action<ProductDefinition> onProductListed; // 0x1C0
	public Action<ProductDefinition> onProductDelisted; // 0x1C8
	public Action<ProductDefinition> onProductFavourited; // 0x1D0
	public Action<ProductDefinition> onProductUnfavourited; // 0x1D8
	public Action<ContractReceipt> onContractReceiptRecorded; // 0x1E0
	public UnityEvent onFirstSampleRejection; // 0x1E8
	public UnityEvent onSecondUniqueProductCreated; // 0x1F0
	public List<string> ProductNames; // 0x1F8
	private List<StationRecipe> mixRecipes; // 0x200
	public Action<StationRecipe> onMixRecipeAdded; // 0x208
	private Dictionary<ProductDefinition, float> ProductPrices; // 0x210
	private ProductDefinition highestValueProduct; // 0x218
	private List<NetworkConnection> productDataSentTo; // 0x220
	public Action<NetworkConnection> onProductDataSentToConnection; // 0x228
	private ProductManagerLoader loader; // 0x230
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x238
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x240
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x248
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x24C
	private bool NetworkInitialize___EarlyScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted; // 0x250
	private bool NetworkInitialize__LateScheduleOne.Product.ProductManagerAssembly-CSharp.dll_Excuted; // 0x251

	// Properties
	public static bool MethDiscovered { get; }
	public static bool CocaineDiscovered { get; }
	public static bool ShroomsDiscovered { get; }
	public static bool IsAcceptingOrders { get; set; }
	public NewMixOperation CurrentMixOperation { get; set; }
	public bool IsMixingInProgress { get; }
	public bool IsMixComplete { get; set; }
	public float TimeSinceProductListingChanged { get; set; }
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }

	// Methods

	// RVA: 0x8A7570 Offset: 0x8A5F70 VA: 0x1808A7570
	public static bool get_MethDiscovered() { }

	// RVA: 0x8A73A0 Offset: 0x8A5DA0 VA: 0x1808A73A0
	public static bool get_CocaineDiscovered() { }

	// RVA: 0x8A7710 Offset: 0x8A6110 VA: 0x1808A7710
	public static bool get_ShroomsDiscovered() { }

	[CompilerGenerated]
	// RVA: 0x8A74E0 Offset: 0x8A5EE0 VA: 0x1808A74E0
	public static bool get_IsAcceptingOrders() { }

	[CompilerGenerated]
	// RVA: 0x8A7870 Offset: 0x8A6270 VA: 0x1808A7870
	private static void set_IsAcceptingOrders(bool value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public NewMixOperation get_CurrentMixOperation() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	private void set_CurrentMixOperation(NewMixOperation value) { }

	// RVA: 0x8A7540 Offset: 0x8A5F40 VA: 0x1808A7540
	public bool get_IsMixingInProgress() { }

	[CompilerGenerated]
	// RVA: 0x8A7530 Offset: 0x8A5F30 VA: 0x1808A7530
	public bool get_IsMixComplete() { }

	[CompilerGenerated]
	// RVA: 0x8A78D0 Offset: 0x8A62D0 VA: 0x1808A78D0
	private void set_IsMixComplete(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8A7850 Offset: 0x8A6250 VA: 0x1808A7850
	public float get_TimeSinceProductListingChanged() { }

	[CompilerGenerated]
	// RVA: 0x8A7900 Offset: 0x8A6300 VA: 0x1808A7900
	private void set_TimeSinceProductListingChanged(float value) { }

	// RVA: 0x89ABF0 Offset: 0x8995F0 VA: 0x18089ABF0
	public bool HasSentProductDataToConnection(NetworkConnection conn) { }

	// RVA: 0x8A76E0 Offset: 0x8A60E0 VA: 0x1808A76E0 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x8A76B0 Offset: 0x8A60B0 VA: 0x1808A76B0 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x8A7560 Offset: 0x8A5F60 VA: 0x1808A7560 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x8A78E0 Offset: 0x8A62E0 VA: 0x1808A78E0 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x860C80 Offset: 0x85F680 VA: 0x180860C80 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x640EC0 Offset: 0x63F8C0 VA: 0x180640EC0 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x8A7860 Offset: 0x8A6260 VA: 0x1808A7860 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x8A7550 Offset: 0x8A5F50 VA: 0x1808A7550 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x896660 Offset: 0x895060 VA: 0x180896660 Slot: 20
	public override void Awake() { }

	// RVA: 0x8A64C0 Offset: 0x8A4EC0 VA: 0x1808A64C0 Slot: 19
	protected override void Start() { }

	// RVA: 0x89C8A0 Offset: 0x89B2A0 VA: 0x18089C8A0 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0x89C880 Offset: 0x89B280 VA: 0x18089C880 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0x8A6EC0 Offset: 0x8A58C0 VA: 0x1808A6EC0
	private void Update() { }

	// RVA: 0x896A20 Offset: 0x895420 VA: 0x180896A20
	private void Clean() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x8A3EC0 Offset: 0x8A28C0 VA: 0x1808A3EC0
	public void SetMethDiscovered() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x8A3DB0 Offset: 0x8A27B0 VA: 0x1808A3DB0
	public void SetCocaineDiscovered() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x8A4290 Offset: 0x8A2C90 VA: 0x1808A4290
	public void SetShroomsDiscovered() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x89CAA0 Offset: 0x89B4A0 VA: 0x18089CAA0
	public void RecordContractReceipt(ContractReceipt receipt) { }

	// RVA: 0x898A60 Offset: 0x897460 VA: 0x180898A60
	public List<ContractReceipt> GetContractReceipts(EMapRegion region, List<EContractParty> dealCompleterTypes, int maxMinsAgo) { }

	// RVA: 0x89AC50 Offset: 0x899650 VA: 0x18089AC50 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x898F50 Offset: 0x897950 VA: 0x180898F50
	public MixerMap GetMixerMap(EDrugType type) { }

	// RVA: 0x89BBD0 Offset: 0x89A5D0 VA: 0x18089BBD0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x89B9C0 Offset: 0x89A3C0 VA: 0x18089B9C0
	private void OnMinPass() { }

	// RVA: 0x89BB80 Offset: 0x89A580 VA: 0x18089BB80
	private void OnNewDay() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x8A6360 Offset: 0x8A4D60 VA: 0x1808A6360
	public void SetProductListed(string productID, bool listed) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8A60C0 Offset: 0x8A4AC0 VA: 0x1808A60C0
	public void SetProductListed(NetworkConnection conn, string productID, bool listed) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x8A5F60 Offset: 0x8A4960 VA: 0x1808A5F60
	public void SetProductFavourited(string productID, bool listed) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8A5CC0 Offset: 0x8A46C0 VA: 0x1808A5CC0
	public void SetProductFavourited(NetworkConnection conn, string productID, bool fav) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x898200 Offset: 0x896C00 VA: 0x180898200
	public void DiscoverProduct(string productID) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x8A5A20 Offset: 0x8A4420 VA: 0x1808A5A20
	public void SetProductDiscovered(NetworkConnection conn, string productID, bool autoList) { }

	// RVA: 0x8A5540 Offset: 0x8A3F40 VA: 0x1808A5540
	public void SetIsAcceptingOrder(bool accepting) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x897D10 Offset: 0x896710 VA: 0x180897D10
	public void CreateWeed_Server(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x897ED0 Offset: 0x8968D0 VA: 0x180897ED0
	private void CreateWeed(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x896B70 Offset: 0x895570 VA: 0x180896B70
	public void CreateCocaine_Server(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x896D30 Offset: 0x895730 VA: 0x180896D30
	private void CreateCocaine(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x897060 Offset: 0x895A60 VA: 0x180897060
	public void CreateMeth_Server(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x897220 Offset: 0x895C20 VA: 0x180897220
	private void CreateMeth(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x897B50 Offset: 0x896550 VA: 0x180897B50
	public void CreateShroom_Server(string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x897820 Offset: 0x896220 VA: 0x180897820
	private void CreateShroom_Client(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance) { }

	// RVA: 0x89CBE0 Offset: 0x89B5E0 VA: 0x18089CBE0
	private void RefreshHighestValueProduct() { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x8A5260 Offset: 0x8A3C60 VA: 0x1808A5260
	public void SendMixRecipe(string product, string mixer, string output) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x897550 Offset: 0x895F50 VA: 0x180897550
	public void CreateMixRecipe(NetworkConnection conn, string product, string mixer, string output) { }

	// RVA: 0x899210 Offset: 0x897C10 VA: 0x180899210
	public StationRecipe GetRecipe(string product, string mixer) { }

	// RVA: 0x899310 Offset: 0x897D10 VA: 0x180899310
	public StationRecipe GetRecipe(List<Effect> productProperties, Effect mixerProperty) { }

	// RVA: 0x898D20 Offset: 0x897720 VA: 0x180898D20
	public ProductDefinition GetKnownProduct(EDrugType type, List<Effect> properties) { }

	// RVA: 0x899070 Offset: 0x897A70 VA: 0x180899070
	public float GetPrice(ProductDefinition product) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x8A53E0 Offset: 0x8A3DE0 VA: 0x1808A53E0
	public void SendPrice(string productID, float value) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8A5770 Offset: 0x8A4170 VA: 0x1808A5770
	public void SetPrice(NetworkConnection conn, string productID, float value) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x8A5110 Offset: 0x8A3B10 VA: 0x1808A5110
	public void SendMixOperation(NewMixOperation operation, bool complete) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8A55D0 Offset: 0x8A3FD0 VA: 0x1808A55D0
	private void SetMixOperation(NewMixOperation operation, bool complete) { }

	// RVA: 0x8984F0 Offset: 0x896EF0 VA: 0x1808984F0
	public string FinishAndNameMix(string productID, string ingredientID, string mixName) { }

	// RVA: 0x89AD20 Offset: 0x899720 VA: 0x18089AD20
	public static string MakeIDFileSafe(string id) { }

	// RVA: 0x89ACE0 Offset: 0x8996E0 VA: 0x18089ACE0
	public static bool IsMixNameValid(string mixName) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x898340 Offset: 0x896D40 VA: 0x180898340
	private void FinishAndNameMix(string productID, string ingredientID, string mixName, string mixID) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x8A3820 Offset: 0x8A2220 VA: 0x1808A3820
	private void SendFinishAndNameMix(string productID, string ingredientID, string mixName, string mixID) { }

	// RVA: 0x8966E0 Offset: 0x8950E0 VA: 0x1808966E0
	public static float CalculateProductValue(ProductDefinition product, float baseValue) { }

	// RVA: 0x8968A0 Offset: 0x8952A0 VA: 0x1808968A0
	public static float CalculateProductValue(float baseValue, List<Effect> properties) { }

	// RVA: 0x899780 Offset: 0x898180 VA: 0x180899780 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x8A7030 Offset: 0x8A5A30 VA: 0x1808A7030
	public void .ctor() { }

	// RVA: 0x8A6F00 Offset: 0x8A5900 VA: 0x1808A6F00
	private static void .cctor() { }

	// RVA: 0x89B020 Offset: 0x899A20 VA: 0x18089B020 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x89AFD0 Offset: 0x8999D0 VA: 0x18089AFD0 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x8A3EC0 Offset: 0x8A28C0 VA: 0x1808A3EC0
	private void RpcWriter___Server_SetMethDiscovered_2166136261() { }

	// RVA: 0x89F7F0 Offset: 0x89E1F0 VA: 0x18089F7F0
	public void RpcLogic___SetMethDiscovered_2166136261() { }

	// RVA: 0x8A1680 Offset: 0x8A0080 VA: 0x1808A1680
	private void RpcReader___Server_SetMethDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A3DB0 Offset: 0x8A27B0 VA: 0x1808A3DB0
	private void RpcWriter___Server_SetCocaineDiscovered_2166136261() { }

	// RVA: 0x89F7A0 Offset: 0x89E1A0 VA: 0x18089F7A0
	public void RpcLogic___SetCocaineDiscovered_2166136261() { }

	// RVA: 0x8A1620 Offset: 0x8A0020 VA: 0x1808A1620
	private void RpcReader___Server_SetCocaineDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A4290 Offset: 0x8A2C90 VA: 0x1808A4290
	private void RpcWriter___Server_SetShroomsDiscovered_2166136261() { }

	// RVA: 0x8A06B0 Offset: 0x89F0B0 VA: 0x1808A06B0
	public void RpcLogic___SetShroomsDiscovered_2166136261() { }

	// RVA: 0x8A1860 Offset: 0x8A0260 VA: 0x1808A1860
	private void RpcReader___Server_SetShroomsDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A2880 Offset: 0x8A1280 VA: 0x1808A2880
	private void RpcWriter___Observers_RecordContractReceipt_1401448548(ContractReceipt receipt) { }

	// RVA: 0x89F550 Offset: 0x89DF50 VA: 0x18089F550
	public void RpcLogic___RecordContractReceipt_1401448548(ContractReceipt receipt) { }

	// RVA: 0x8A0BA0 Offset: 0x89F5A0 VA: 0x1808A0BA0
	private void RpcReader___Observers_RecordContractReceipt_1401448548(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A4130 Offset: 0x8A2B30 VA: 0x1808A4130
	private void RpcWriter___Server_SetProductListed_310431262(string productID, bool listed) { }

	// RVA: 0x8A0070 Offset: 0x89EA70 VA: 0x1808A0070
	public void RpcLogic___SetProductListed_310431262(string productID, bool listed) { }

	// RVA: 0x8A17A0 Offset: 0x8A01A0 VA: 0x1808A17A0
	private void RpcReader___Server_SetProductListed_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A2F80 Offset: 0x8A1980 VA: 0x1808A2F80
	private void RpcWriter___Observers_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed) { }

	// RVA: 0x8A0090 Offset: 0x89EA90 VA: 0x1808A0090
	public void RpcLogic___SetProductListed_619441887(NetworkConnection conn, string productID, bool listed) { }

	// RVA: 0x8A0E90 Offset: 0x89F890 VA: 0x1808A0E90
	private void RpcReader___Observers_SetProductListed_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A4FB0 Offset: 0x8A39B0 VA: 0x1808A4FB0
	private void RpcWriter___Target_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed) { }

	// RVA: 0x8A1E60 Offset: 0x8A0860 VA: 0x1808A1E60
	private void RpcReader___Target_SetProductListed_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A3FD0 Offset: 0x8A29D0 VA: 0x1808A3FD0
	private void RpcWriter___Server_SetProductFavourited_310431262(string productID, bool listed) { }

	// RVA: 0x89FCA0 Offset: 0x89E6A0 VA: 0x18089FCA0
	public void RpcLogic___SetProductFavourited_310431262(string productID, bool listed) { }

	// RVA: 0x8A16E0 Offset: 0x8A00E0 VA: 0x1808A16E0
	private void RpcReader___Server_SetProductFavourited_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A2E10 Offset: 0x8A1810 VA: 0x1808A2E10
	private void RpcWriter___Observers_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav) { }

	// RVA: 0x89FCC0 Offset: 0x89E6C0 VA: 0x18089FCC0
	public void RpcLogic___SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav) { }

	// RVA: 0x8A0DE0 Offset: 0x89F7E0 VA: 0x1808A0DE0
	private void RpcReader___Observers_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A4E50 Offset: 0x8A3850 VA: 0x1808A4E50
	private void RpcWriter___Target_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav) { }

	// RVA: 0x8A1DC0 Offset: 0x8A07C0 VA: 0x1808A1DC0
	private void RpcReader___Target_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A36F0 Offset: 0x8A20F0 VA: 0x1808A36F0
	private void RpcWriter___Server_DiscoverProduct_3615296227(string productID) { }

	// RVA: 0x89EEB0 Offset: 0x89D8B0 VA: 0x18089EEB0
	public void RpcLogic___DiscoverProduct_3615296227(string productID) { }

	// RVA: 0x8A12C0 Offset: 0x89FCC0 VA: 0x1808A12C0
	private void RpcReader___Server_DiscoverProduct_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A2CA0 Offset: 0x8A16A0 VA: 0x1808A2CA0
	private void RpcWriter___Observers_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList) { }

	// RVA: 0x89FA40 Offset: 0x89E440 VA: 0x18089FA40
	public void RpcLogic___SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList) { }

	// RVA: 0x8A0D30 Offset: 0x89F730 VA: 0x1808A0D30
	private void RpcReader___Observers_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A4CF0 Offset: 0x8A36F0 VA: 0x1808A4CF0
	private void RpcWriter___Target_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList) { }

	// RVA: 0x8A1D20 Offset: 0x8A0720 VA: 0x1808A1D20
	private void RpcReader___Target_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A3570 Offset: 0x8A1F70 VA: 0x1808A3570
	private void RpcWriter___Server_CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance) { }

	// RVA: 0x89EE70 Offset: 0x89D870 VA: 0x18089EE70
	public void RpcLogic___CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance) { }

	// RVA: 0x8A11E0 Offset: 0x89FBE0 VA: 0x1808A11E0
	private void RpcReader___Server_CreateWeed_Server_2331775230(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A49F0 Offset: 0x8A33F0 VA: 0x1808A49F0
	private void RpcWriter___Target_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance) { }

	// RVA: 0x89EA10 Offset: 0x89D410 VA: 0x18089EA10
	private void RpcLogic___CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance) { }

	// RVA: 0x8A1BD0 Offset: 0x8A05D0 VA: 0x1808A1BD0
	private void RpcReader___Target_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A2560 Offset: 0x8A0F60 VA: 0x1808A2560
	private void RpcWriter___Observers_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance) { }

	// RVA: 0x8A0A10 Offset: 0x89F410 VA: 0x1808A0A10
	private void RpcReader___Observers_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A30F0 Offset: 0x8A1AF0 VA: 0x1808A30F0
	private void RpcWriter___Server_CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance) { }

	// RVA: 0x89D440 Offset: 0x89BE40 VA: 0x18089D440
	public void RpcLogic___CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance) { }

	// RVA: 0x8A0F40 Offset: 0x89F940 VA: 0x1808A0F40
	private void RpcReader___Server_CreateCocaine_Server_891166717(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A43A0 Offset: 0x8A2DA0 VA: 0x1808A43A0
	private void RpcWriter___Target_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance) { }

	// RVA: 0x89CEA0 Offset: 0x89B8A0 VA: 0x18089CEA0
	private void RpcLogic___CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance) { }

	// RVA: 0x8A18C0 Offset: 0x8A02C0 VA: 0x1808A18C0
	private void RpcReader___Target_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A1F00 Offset: 0x8A0900 VA: 0x1808A1F00
	private void RpcWriter___Observers_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance) { }

	// RVA: 0x8A0700 Offset: 0x89F100 VA: 0x1808A0700
	private void RpcReader___Observers_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A3270 Offset: 0x8A1C70 VA: 0x1808A3270
	private void RpcWriter___Server_CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance) { }

	// RVA: 0x89DA20 Offset: 0x89C420 VA: 0x18089DA20
	public void RpcLogic___CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance) { }

	// RVA: 0x8A1020 Offset: 0x89FA20 VA: 0x1808A1020
	private void RpcReader___Server_CreateMeth_Server_4251728555(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A4540 Offset: 0x8A2F40 VA: 0x1808A4540
	private void RpcWriter___Target_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance) { }

	// RVA: 0x89D480 Offset: 0x89BE80 VA: 0x18089D480
	private void RpcLogic___CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance) { }

	// RVA: 0x8A1990 Offset: 0x8A0390 VA: 0x1808A1990
	private void RpcReader___Target_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A20A0 Offset: 0x8A0AA0 VA: 0x1808A20A0
	private void RpcWriter___Observers_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance) { }

	// RVA: 0x8A07D0 Offset: 0x89F1D0 VA: 0x1808A07D0
	private void RpcReader___Observers_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A33F0 Offset: 0x8A1DF0 VA: 0x1808A33F0
	private void RpcWriter___Server_CreateShroom_Server_2261384965(string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance) { }

	// RVA: 0x89E9D0 Offset: 0x89D3D0 VA: 0x18089E9D0
	public void RpcLogic___CreateShroom_Server_2261384965(string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance) { }

	// RVA: 0x8A1100 Offset: 0x89FB00 VA: 0x1808A1100
	private void RpcReader___Server_CreateShroom_Server_2261384965(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A4850 Offset: 0x8A3250 VA: 0x1808A4850
	private void RpcWriter___Target_CreateShroom_Client_812995776(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance) { }

	// RVA: 0x89E510 Offset: 0x89CF10 VA: 0x18089E510
	private void RpcLogic___CreateShroom_Client_812995776(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance) { }

	// RVA: 0x8A1B00 Offset: 0x8A0500 VA: 0x1808A1B00
	private void RpcReader___Target_CreateShroom_Client_812995776(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A23C0 Offset: 0x8A0DC0 VA: 0x1808A23C0
	private void RpcWriter___Observers_CreateShroom_Client_812995776(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, ShroomAppearanceSettings appearance) { }

	// RVA: 0x8A0940 Offset: 0x89F340 VA: 0x1808A0940
	private void RpcReader___Observers_CreateShroom_Client_812995776(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A3AF0 Offset: 0x8A24F0 VA: 0x1808A3AF0
	private void RpcWriter___Server_SendMixRecipe_852232071(string product, string mixer, string output) { }

	// RVA: 0x89F750 Offset: 0x89E150 VA: 0x18089F750
	public void RpcLogic___SendMixRecipe_852232071(string product, string mixer, string output) { }

	// RVA: 0x8A14C0 Offset: 0x89FEC0 VA: 0x1808A14C0
	private void RpcReader___Server_SendMixRecipe_852232071(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A46E0 Offset: 0x8A30E0 VA: 0x1808A46E0
	private void RpcWriter___Target_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output) { }

	// RVA: 0x89DA60 Offset: 0x89C460 VA: 0x18089DA60
	public void RpcLogic___CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output) { }

	// RVA: 0x8A1A60 Offset: 0x8A0460 VA: 0x1808A1A60
	private void RpcReader___Target_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A2240 Offset: 0x8A0C40 VA: 0x1808A2240
	private void RpcWriter___Observers_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output) { }

	// RVA: 0x8A08A0 Offset: 0x89F2A0 VA: 0x1808A08A0
	private void RpcReader___Observers_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A3C50 Offset: 0x8A2650 VA: 0x1808A3C50
	private void RpcWriter___Server_SendPrice_606697822(string productID, float value) { }

	// RVA: 0x89F780 Offset: 0x89E180 VA: 0x18089F780
	public void RpcLogic___SendPrice_606697822(string productID, float value) { }

	// RVA: 0x8A1580 Offset: 0x89FF80 VA: 0x1808A1580
	private void RpcReader___Server_SendPrice_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A2B30 Offset: 0x8A1530 VA: 0x1808A2B30
	private void RpcWriter___Observers_SetPrice_4077118173(NetworkConnection conn, string productID, float value) { }

	// RVA: 0x89F8B0 Offset: 0x89E2B0 VA: 0x18089F8B0
	public void RpcLogic___SetPrice_4077118173(NetworkConnection conn, string productID, float value) { }

	// RVA: 0x8A0CA0 Offset: 0x89F6A0 VA: 0x1808A0CA0
	private void RpcReader___Observers_SetPrice_4077118173(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A4B90 Offset: 0x8A3590 VA: 0x1808A4B90
	private void RpcWriter___Target_SetPrice_4077118173(NetworkConnection conn, string productID, float value) { }

	// RVA: 0x8A1CA0 Offset: 0x8A06A0 VA: 0x1808A1CA0
	private void RpcReader___Target_SetPrice_4077118173(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A3990 Offset: 0x8A2390 VA: 0x1808A3990
	private void RpcWriter___Server_SendMixOperation_3670976965(NewMixOperation operation, bool complete) { }

	// RVA: 0x89F740 Offset: 0x89E140 VA: 0x18089F740
	public void RpcLogic___SendMixOperation_3670976965(NewMixOperation operation, bool complete) { }

	// RVA: 0x8A1410 Offset: 0x89FE10 VA: 0x1808A1410
	private void RpcReader___Server_SendMixOperation_3670976965(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8A29C0 Offset: 0x8A13C0 VA: 0x1808A29C0
	private void RpcWriter___Observers_SetMixOperation_3670976965(NewMixOperation operation, bool complete) { }

	// RVA: 0x89F840 Offset: 0x89E240 VA: 0x18089F840
	private void RpcLogic___SetMixOperation_3670976965(NewMixOperation operation, bool complete) { }

	// RVA: 0x8A0C00 Offset: 0x89F600 VA: 0x1808A0C00
	private void RpcReader___Observers_SetMixOperation_3670976965(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A2700 Offset: 0x8A1100 VA: 0x1808A2700
	private void RpcWriter___Observers_FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID) { }

	// RVA: 0x89EED0 Offset: 0x89D8D0 VA: 0x18089EED0
	private void RpcLogic___FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID) { }

	// RVA: 0x8A0AE0 Offset: 0x89F4E0 VA: 0x1808A0AE0
	private void RpcReader___Observers_FinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8A3820 Offset: 0x8A2220 VA: 0x1808A3820
	private void RpcWriter___Server_SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID) { }

	// RVA: 0x89F6D0 Offset: 0x89E0D0 VA: 0x18089F6D0
	private void RpcLogic___SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID) { }

	// RVA: 0x8A1340 Offset: 0x89FD40 VA: 0x1808A1340
	private void RpcReader___Server_SendFinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x896610 Offset: 0x895010 VA: 0x180896610 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Product.ProductManager_Assembly-CSharp.dll() { }
}
