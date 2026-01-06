public class DeliveryManager : NetworkSingleton<DeliveryManager>, IBaseSaveable, ISaveable // TypeDefIndex: 1974
{
	// Fields
	public List<DeliveryInstance> Deliveries; // 0x120
	public UnityEvent<DeliveryInstance> onDeliveryCreated; // 0x128
	public UnityEvent<DeliveryInstance> onDeliveryCompleted; // 0x130
	private DeliveriesLoader loader; // 0x138
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x140
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x148
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x150
	private List<string> writtenVehicles; // 0x158
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x160
	private Dictionary<DeliveryInstance, int> minsSinceVehicleEmpty; // 0x168
	private bool NetworkInitialize___EarlyScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted; // 0x170
	private bool NetworkInitialize__LateScheduleOne.Delivery.DeliveryManagerAssembly-CSharp.dll_Excuted; // 0x171

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

	// RVA: 0x79A8F0 Offset: 0x7992F0 VA: 0x18079A8F0 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x79A8C0 Offset: 0x7992C0 VA: 0x18079A8C0 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x6FB0A0 Offset: 0x6F9AA0 VA: 0x1806FB0A0 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x79A930 Offset: 0x799330 VA: 0x18079A930 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x79A8A0 Offset: 0x7992A0 VA: 0x18079A8A0 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x79A920 Offset: 0x799320 VA: 0x18079A920 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x79A8B0 Offset: 0x7992B0 VA: 0x18079A8B0 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x798AC0 Offset: 0x7974C0 VA: 0x180798AC0 Slot: 20
	public override void Awake() { }

	// RVA: 0x79A5B0 Offset: 0x798FB0 VA: 0x18079A5B0 Slot: 19
	protected override void Start() { }

	// RVA: 0x7991A0 Offset: 0x797BA0 VA: 0x1807991A0 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x799830 Offset: 0x798230 VA: 0x180799830 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x7994D0 Offset: 0x797ED0 VA: 0x1807994D0
	private void OnMinPass() { }

	// RVA: 0x799230 Offset: 0x797C30 VA: 0x180799230
	public bool IsLoadingBayFree(Property destination, int loadingDockIndex) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x79A1C0 Offset: 0x798BC0 VA: 0x18079A1C0
	public void SendDelivery(DeliveryInstance delivery) { }

	[TargetRpc]
	[ObserversRpc]
	// RVA: 0x7999B0 Offset: 0x7983B0 VA: 0x1807999B0
	private void ReceiveDelivery(NetworkConnection conn, DeliveryInstance delivery) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x79A450 Offset: 0x798E50 VA: 0x18079A450
	private void SetDeliveryState(string deliveryID, EDeliveryStatus status) { }

	// RVA: 0x798C20 Offset: 0x797620 VA: 0x180798C20
	private DeliveryInstance GetDelivery(string deliveryID) { }

	// RVA: 0x798D00 Offset: 0x797700 VA: 0x180798D00
	public DeliveryInstance GetDelivery(Property destination) { }

	// RVA: 0x798B40 Offset: 0x797540 VA: 0x180798B40
	public DeliveryInstance GetActiveShopDelivery(DeliveryShop shop) { }

	// RVA: 0x799090 Offset: 0x797A90 VA: 0x180799090
	public ShopInterface GetShopInterface(string shopName) { }

	// RVA: 0x798DE0 Offset: 0x7977E0 VA: 0x180798DE0 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x79A6D0 Offset: 0x7990D0 VA: 0x18079A6D0
	public void .ctor() { }

	// RVA: 0x799350 Offset: 0x797D50 VA: 0x180799350 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x799300 Offset: 0x797D00 VA: 0x180799300 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x79A1C0 Offset: 0x798BC0 VA: 0x18079A1C0
	private void RpcWriter___Server_SendDelivery_2813439055(DeliveryInstance delivery) { }

	// RVA: 0x799CC0 Offset: 0x7986C0 VA: 0x180799CC0
	public void RpcLogic___SendDelivery_2813439055(DeliveryInstance delivery) { }

	// RVA: 0x799E60 Offset: 0x798860 VA: 0x180799E60
	private void RpcReader___Server_SendDelivery_2813439055(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x799F10 Offset: 0x798910 VA: 0x180799F10
	private void RpcWriter___Observers_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery) { }

	// RVA: 0x799BB0 Offset: 0x7985B0 VA: 0x180799BB0
	private void RpcLogic___ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery) { }

	// RVA: 0x799D90 Offset: 0x798790 VA: 0x180799D90
	private void RpcReader___Observers_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x79A2F0 Offset: 0x798CF0 VA: 0x18079A2F0
	private void RpcWriter___Target_ReceiveDelivery_2795369214(NetworkConnection conn, DeliveryInstance delivery) { }

	// RVA: 0x799EB0 Offset: 0x7988B0 VA: 0x180799EB0
	private void RpcReader___Target_ReceiveDelivery_2795369214(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x79A050 Offset: 0x798A50 VA: 0x18079A050
	private void RpcWriter___Observers_SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status) { }

	// RVA: 0x799CD0 Offset: 0x7986D0 VA: 0x180799CD0
	private void RpcLogic___SetDeliveryState_316609003(string deliveryID, EDeliveryStatus status) { }

	// RVA: 0x799DE0 Offset: 0x7987E0 VA: 0x180799DE0
	private void RpcReader___Observers_SetDeliveryState_316609003(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x798A70 Offset: 0x797470 VA: 0x180798A70 Slot: 51
	protected override void Awake_UserLogic_ScheduleOne.Delivery.DeliveryManager_Assembly-CSharp.dll() { }
}
