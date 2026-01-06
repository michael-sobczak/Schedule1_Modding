public class TrashManager : NetworkSingleton<TrashManager>, IBaseSaveable, ISaveable // TypeDefIndex: 2253
{
	// Fields
	public const int TRASH_ITEM_LIMIT = 2000;
	public const int TRASH_REPLICATIONS_PER_SECOND = 100;
	public TrashItem[] TrashPrefabs; // 0x120
	public TrashItem TrashBagPrefab; // 0x128
	public TrashManager.TrashItemData[] GenerateableTrashItems; // 0x130
	private List<TrashItem> trashItems; // 0x138
	public float TrashForceMultiplier; // 0x140
	private TrashLoader loader; // 0x148
	[CompilerGenerated]
	private List<string> <LocalExtraFiles>k__BackingField; // 0x150
	[CompilerGenerated]
	private List<string> <LocalExtraFolders>k__BackingField; // 0x158
	[CompilerGenerated]
	private bool <HasChanged>k__BackingField; // 0x160
	[CompilerGenerated]
	private readonly int <LoadOrder>k__BackingField; // 0x164
	private List<string> writtenItemFiles; // 0x168
	private bool NetworkInitialize___EarlyScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted; // 0x170
	private bool NetworkInitialize__LateScheduleOne.Trash.TrashManagerAssembly-CSharp.dll_Excuted; // 0x171

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

	// RVA: 0x8543A0 Offset: 0x852DA0 VA: 0x1808543A0 Slot: 26
	public string get_SaveFolderName() { }

	// RVA: 0x854370 Offset: 0x852D70 VA: 0x180854370 Slot: 27
	public string get_SaveFileName() { }

	// RVA: 0x71DB80 Offset: 0x71C580 VA: 0x18071DB80 Slot: 28
	public Loader get_Loader() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 29
	public bool get_ShouldSaveUnderFolder() { }

	[CompilerGenerated]
	// RVA: 0x618010 Offset: 0x616A10 VA: 0x180618010 Slot: 30
	public List<string> get_LocalExtraFiles() { }

	[CompilerGenerated]
	// RVA: 0x71DC00 Offset: 0x71C600 VA: 0x18071DC00 Slot: 31
	public void set_LocalExtraFiles(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020 Slot: 32
	public List<string> get_LocalExtraFolders() { }

	[CompilerGenerated]
	// RVA: 0x618120 Offset: 0x616B20 VA: 0x180618120 Slot: 33
	public void set_LocalExtraFolders(List<string> value) { }

	[CompilerGenerated]
	// RVA: 0x71DB60 Offset: 0x71C560 VA: 0x18071DB60 Slot: 34
	public bool get_HasChanged() { }

	[CompilerGenerated]
	// RVA: 0x71DBF0 Offset: 0x71C5F0 VA: 0x18071DBF0 Slot: 35
	public void set_HasChanged(bool value) { }

	[CompilerGenerated]
	// RVA: 0x71DB70 Offset: 0x71C570 VA: 0x18071DB70 Slot: 25
	public int get_LoadOrder() { }

	// RVA: 0x854190 Offset: 0x852B90 VA: 0x180854190 Slot: 19
	protected override void Start() { }

	// RVA: 0x850100 Offset: 0x84EB00 VA: 0x180850100 Slot: 49
	public virtual void InitializeSaveable() { }

	// RVA: 0x8504F0 Offset: 0x84EEF0 VA: 0x1808504F0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x8506D0 Offset: 0x84F0D0 VA: 0x1808506D0
	public void ReplicateTransformData(TrashItem trash) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x853FF0 Offset: 0x8529F0 VA: 0x180853FF0
	private void SendTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender) { }

	[ObserversRpc]
	// RVA: 0x850660 Offset: 0x84F060 VA: 0x180850660
	private void ReceiveTransformData(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender) { }

	// RVA: 0x84F460 Offset: 0x84DE60 VA: 0x18084F460
	public TrashItem CreateTrashItem(string id, Vector3 posiiton, Quaternion rotation, Vector3 initialVelocity, string guid = "", bool startKinematic = False) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x854100 Offset: 0x852B00 VA: 0x180854100
	private void SendTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	[TargetRpc]
	[ObserversRpc]
	// RVA: 0x84F640 Offset: 0x84E040 VA: 0x18084F640
	private void CreateTrashItem(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x84EDE0 Offset: 0x84D7E0 VA: 0x18084EDE0
	private TrashItem CreateAndReturnTrashItem(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, string guid, bool startKinematic) { }

	// RVA: 0x84F260 Offset: 0x84DC60 VA: 0x18084F260
	public TrashItem CreateTrashBag(string id, Vector3 posiiton, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, string guid = "", bool startKinematic = False) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x854060 Offset: 0x852A60 VA: 0x180854060
	private void SendTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	[TargetRpc]
	[ObserversRpc]
	// RVA: 0x84F130 Offset: 0x84DB30 VA: 0x18084F130
	private void CreateTrashBag(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x84EA90 Offset: 0x84D490 VA: 0x18084EA90
	private TrashItem CreateAndReturnTrashBag(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, string guid, bool startKinematic) { }

	// RVA: 0x84F750 Offset: 0x84E150 VA: 0x18084F750
	public void DestroyAllTrash() { }

	// RVA: 0x84F830 Offset: 0x84E230 VA: 0x18084F830
	public void DestroyTrash(TrashItem trash) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x853EC0 Offset: 0x8528C0 VA: 0x180853EC0
	private void SendDestroyTrash(string guid) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x84F990 Offset: 0x84E390 VA: 0x18084F990
	private void DestroyTrash(string guid) { }

	// RVA: 0x850020 Offset: 0x84EA20 VA: 0x180850020
	public TrashItem GetTrashPrefab(string id) { }

	// RVA: 0x84FAD0 Offset: 0x84E4D0 VA: 0x18084FAD0
	public TrashItem GetRandomGeneratableTrashPrefab() { }

	// RVA: 0x84FC70 Offset: 0x84E670 VA: 0x18084FC70 Slot: 50
	public virtual string GetSaveString() { }

	// RVA: 0x8541E0 Offset: 0x852BE0 VA: 0x1808541E0
	public void .ctor() { }

	// RVA: 0x8501E0 Offset: 0x84EBE0 VA: 0x1808501E0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x850190 Offset: 0x84EB90 VA: 0x180850190 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x852EB0 Offset: 0x8518B0 VA: 0x180852EB0
	private void RpcWriter___Server_SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender) { }

	// RVA: 0x850660 Offset: 0x84F060 VA: 0x180850660
	private void RpcLogic___SendTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender) { }

	// RVA: 0x851790 Offset: 0x850190 VA: 0x180851790
	private void RpcReader___Server_SendTransformData_2990100769(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x852A70 Offset: 0x851470 VA: 0x180852A70
	private void RpcWriter___Observers_ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender) { }

	// RVA: 0x850BC0 Offset: 0x84F5C0 VA: 0x180850BC0
	private void RpcLogic___ReceiveTransformData_2990100769(string guid, Vector3 position, Quaternion rotation, Vector3 velocity, NetworkConnection sender) { }

	// RVA: 0x8514B0 Offset: 0x84FEB0 VA: 0x1808514B0
	private void RpcReader___Observers_ReceiveTransformData_2990100769(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8534D0 Offset: 0x851ED0 VA: 0x1808534D0
	private void RpcWriter___Server_SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x850EC0 Offset: 0x84F8C0 VA: 0x180850EC0
	private void RpcLogic___SendTrashItem_478112418(string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x851BB0 Offset: 0x8505B0 VA: 0x180851BB0
	private void RpcReader___Server_SendTrashItem_478112418(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x8525D0 Offset: 0x850FD0 VA: 0x1808525D0
	private void RpcWriter___Observers_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x850970 Offset: 0x84F370 VA: 0x180850970
	private void RpcLogic___CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x851250 Offset: 0x84FC50 VA: 0x180851250
	private void RpcReader___Observers_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x853B60 Offset: 0x852560 VA: 0x180853B60
	private void RpcWriter___Target_CreateTrashItem_2385526393(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x852050 Offset: 0x850A50 VA: 0x180852050
	private void RpcReader___Target_CreateTrashItem_2385526393(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8531A0 Offset: 0x851BA0 VA: 0x1808531A0
	private void RpcWriter___Server_SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x850D50 Offset: 0x84F750 VA: 0x180850D50
	private void RpcLogic___SendTrashBag_3965031115(string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x851930 Offset: 0x850330 VA: 0x180851930
	private void RpcReader___Server_SendTrashBag_3965031115(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x852260 Offset: 0x850C60 VA: 0x180852260
	private void RpcWriter___Observers_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x850890 Offset: 0x84F290 VA: 0x180850890
	private void RpcLogic___CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x851020 Offset: 0x84FA20 VA: 0x180851020
	private void RpcReader___Observers_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8537F0 Offset: 0x8521F0 VA: 0x1808537F0
	private void RpcWriter___Target_CreateTrashBag_680856992(NetworkConnection conn, string id, Vector3 position, Quaternion rotation, TrashContentData content, Vector3 initialVelocity, NetworkConnection sender, string guid, bool startKinematic = False) { }

	// RVA: 0x851E10 Offset: 0x850810 VA: 0x180851E10
	private void RpcReader___Target_CreateTrashBag_680856992(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x852D80 Offset: 0x851780 VA: 0x180852D80
	private void RpcWriter___Server_SendDestroyTrash_3615296227(string guid) { }

	// RVA: 0x84F990 Offset: 0x84E390 VA: 0x18084F990
	private void RpcLogic___SendDestroyTrash_3615296227(string guid) { }

	// RVA: 0x851720 Offset: 0x850120 VA: 0x180851720
	private void RpcReader___Server_SendDestroyTrash_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x852930 Offset: 0x851330 VA: 0x180852930
	private void RpcWriter___Observers_DestroyTrash_3615296227(string guid) { }

	// RVA: 0x850A40 Offset: 0x84F440 VA: 0x180850A40
	private void RpcLogic___DestroyTrash_3615296227(string guid) { }

	// RVA: 0x851450 Offset: 0x84FE50 VA: 0x180851450
	private void RpcReader___Observers_DestroyTrash_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x84EA20 Offset: 0x84D420 VA: 0x18084EA20 Slot: 20
	public override void Awake() { }
}
