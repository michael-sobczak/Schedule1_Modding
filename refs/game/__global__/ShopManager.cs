public class ShopManager : NetworkSingleton<ShopManager>, IBaseSaveable, ISaveable // TypeDefIndex: 2991
{
	// Fields
	private ShopManagerLoader loader; // 0x120
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x128
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x130
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x138
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x13C
	private bool NetworkInitialize___EarlyScheduleOne.UI.Shop.ShopManagerAssembly-CSharp.dll_Excuted; // 0x140
	private bool NetworkInitialize__LateScheduleOne.UI.Shop.ShopManagerAssembly-CSharp.dll_Excuted; // 0x141

	// Properties
	public string SaveFolderName { get; }
	public string SaveFileName { get; }
	public Loader Loader { get; }
	public bool ShouldSaveUnderFolder { get; }
	public List<string> LocalExtraFiles { get; set; }
	public List<string> LocalExtraFolders { get; set; }
	public bool HasChanged { get; set; }
	public int LoadOrder { get; }

	// Methods

	// RVA: 0x989740 Offset: 0x988140 VA: 0x180989740 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x989710 Offset: 0x988110 VA: 0x180989710 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x512C90 Offset: 0x511690 VA: 0x180512C90 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x6BFF00 Offset: 0x6BE900 VA: 0x1806BFF00 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x6BFD80 Offset: 0x6BE780 VA: 0x1806BFD80 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x9895B0 Offset: 0x987FB0 VA: 0x1809895B0 Slot: 19
	protected override void Start() { }

	// RVA: 0x9886E0 Offset: 0x9870E0 VA: 0x1809886E0 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x988450 Offset: 0x986E50 VA: 0x180988450 Slot: 50
	public virtual string GetSaveString() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x988FE0 Offset: 0x9879E0 VA: 0x180988FE0
	public void SendStock(string shopCode, string itemID, int stock) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x9892D0 Offset: 0x987CD0 VA: 0x1809892D0
	public void SetStock(NetworkConnection conn, string shopCode, string itemID, int stock) { }

	// RVA: 0x989600 Offset: 0x988000 VA: 0x180989600
	public void .ctor() { }

	// RVA: 0x9887C0 Offset: 0x9871C0 VA: 0x1809887C0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x988770 Offset: 0x987170 VA: 0x180988770 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x988FE0 Offset: 0x9879E0 VA: 0x180988FE0
	private void RpcWriter___Server_SendStock_15643032(string shopCode, string itemID, int stock) { }

	// RVA: 0x988900 Offset: 0x987300 VA: 0x180988900
	public void RpcLogic___SendStock_15643032(string shopCode, string itemID, int stock) { }

	// RVA: 0x988D00 Offset: 0x987700 VA: 0x180988D00
	private void RpcReader___Server_SendStock_15643032(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x988E50 Offset: 0x987850 VA: 0x180988E50
	private void RpcWriter___Observers_SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock) { }

	// RVA: 0x988930 Offset: 0x987330 VA: 0x180988930
	public void RpcLogic___SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock) { }

	// RVA: 0x988C50 Offset: 0x987650 VA: 0x180988C50
	private void RpcReader___Observers_SetStock_3509965635(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x989150 Offset: 0x987B50 VA: 0x180989150
	private void RpcWriter___Target_SetStock_3509965635(NetworkConnection conn, string shopCode, string itemID, int stock) { }

	// RVA: 0x988DA0 Offset: 0x9877A0 VA: 0x180988DA0
	private void RpcReader___Target_SetStock_3509965635(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x9883E0 Offset: 0x986DE0 VA: 0x1809883E0 Slot: 20
	public override void Awake() { }
}
