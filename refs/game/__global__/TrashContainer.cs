public class TrashContainer : NetworkBehaviour // TypeDefIndex: 2238
{
	// Fields
	[CompilerGenerated]
	private TrashContent <Content>k__BackingField; // 0x118
	[Range(1, 50)]
	[Header("Settings")]
	public int TrashCapacity; // 0x120
	[Header("Settings")]
	public Transform TrashBagDropLocation; // 0x128
	public UnityEvent<string> onTrashAdded; // 0x130
	public UnityEvent onTrashLevelChanged; // 0x138
	private bool NetworkInitialize___EarlyScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted; // 0x140
	private bool NetworkInitialize__LateScheduleOne.Trash.TrashContainerAssembly-CSharp.dll_Excuted; // 0x141

	// Properties
	public TrashContent Content { get; set; }
	public int TrashLevel { get; }
	public float NormalizedTrashLevel { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public TrashContent get_Content() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	protected void set_Content(TrashContent value) { }

	// RVA: 0x84AAB0 Offset: 0x8494B0 VA: 0x18084AAB0
	public int get_TrashLevel() { }

	// RVA: 0x84AA70 Offset: 0x849470 VA: 0x18084AA70
	public float get_NormalizedTrashLevel() { }

	// RVA: 0x848B00 Offset: 0x847500 VA: 0x180848B00 Slot: 19
	public virtual void AddTrash(TrashItem item) { }

	// RVA: 0x849930 Offset: 0x848330 VA: 0x180849930 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x84A660 Offset: 0x849060 VA: 0x18084A660
	private void SendTrash(string trashID, int quantity) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x848D90 Offset: 0x847790 VA: 0x180848D90
	private void AddTrash(NetworkConnection conn, string trashID, int quantity) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x84A550 Offset: 0x848F50 VA: 0x18084A550
	private void SendClear() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8494C0 Offset: 0x847EC0 VA: 0x1808494C0
	private void Clear() { }

	[TargetRpc]
	// RVA: 0x8495E0 Offset: 0x847FE0 VA: 0x1808495E0
	private void LoadContent(NetworkConnection conn, TrashContentData data) { }

	// RVA: 0x84A7D0 Offset: 0x8491D0 VA: 0x18084A7D0
	public void TriggerEnter(Collider other) { }

	// RVA: 0x849490 Offset: 0x847E90 VA: 0x180849490
	public bool CanBeBagged() { }

	// RVA: 0x849050 Offset: 0x847A50 VA: 0x180849050
	public void BagTrash() { }

	// RVA: 0x84A9F0 Offset: 0x8493F0 VA: 0x18084A9F0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x84A8A0 Offset: 0x8492A0 VA: 0x18084A8A0
	private void <OnSpawnServer>g__Replicate|13_0(NetworkConnection conn) { }

	// RVA: 0x849740 Offset: 0x848140 VA: 0x180849740 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7C9EA0 Offset: 0x7C88A0 VA: 0x1807C9EA0 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x84A270 Offset: 0x848C70 VA: 0x18084A270
	private void RpcWriter___Server_SendTrash_3643459082(string trashID, int quantity) { }

	// RVA: 0x849BD0 Offset: 0x8485D0 VA: 0x180849BD0
	private void RpcLogic___SendTrash_3643459082(string trashID, int quantity) { }

	// RVA: 0x849D10 Offset: 0x848710 VA: 0x180849D10
	private void RpcReader___Server_SendTrash_3643459082(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x849EC0 Offset: 0x8488C0 VA: 0x180849EC0
	private void RpcWriter___Observers_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity) { }

	// RVA: 0x849A50 Offset: 0x848450 VA: 0x180849A50
	private void RpcLogic___AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity) { }

	// RVA: 0x849BF0 Offset: 0x8485F0 VA: 0x180849BF0
	private void RpcReader___Observers_AddTrash_3905681115(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x84A3E0 Offset: 0x848DE0 VA: 0x18084A3E0
	private void RpcWriter___Target_AddTrash_3905681115(NetworkConnection conn, string trashID, int quantity) { }

	// RVA: 0x849DB0 Offset: 0x8487B0 VA: 0x180849DB0
	private void RpcReader___Target_AddTrash_3905681115(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x84A160 Offset: 0x848B60 VA: 0x18084A160
	private void RpcWriter___Server_SendClear_2166136261() { }

	// RVA: 0x8494C0 Offset: 0x847EC0 VA: 0x1808494C0
	private void RpcLogic___SendClear_2166136261() { }

	// RVA: 0x849CC0 Offset: 0x8486C0 VA: 0x180849CC0
	private void RpcReader___Server_SendClear_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x84A040 Offset: 0x848A40 VA: 0x18084A040
	private void RpcWriter___Observers_Clear_2166136261() { }

	// RVA: 0x849AF0 Offset: 0x8484F0 VA: 0x180849AF0
	private void RpcLogic___Clear_2166136261() { }

	// RVA: 0x849C80 Offset: 0x848680 VA: 0x180849C80
	private void RpcReader___Observers_Clear_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8495E0 Offset: 0x847FE0 VA: 0x1808495E0
	private void RpcWriter___Target_LoadContent_189522235(NetworkConnection conn, TrashContentData data) { }

	// RVA: 0x849B80 Offset: 0x848580 VA: 0x180849B80
	private void RpcLogic___LoadContent_189522235(NetworkConnection conn, TrashContentData data) { }

	// RVA: 0x849E40 Offset: 0x848840 VA: 0x180849E40
	private void RpcReader___Target_LoadContent_189522235(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 22
	public override void Awake() { }
}
