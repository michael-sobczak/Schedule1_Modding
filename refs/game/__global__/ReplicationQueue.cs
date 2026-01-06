public class ReplicationQueue : NetworkSingleton<ReplicationQueue> // TypeDefIndex: 1153
{
	// Fields
	public const int RATE_LIMIT_BYTES_PER_SECOND = 51200;
	public const int MAX_REPLICATION_DURATION = 45;
	[CompilerGenerated]
	private bool <ReplicationDoneForLocalPlayer>k__BackingField; // 0x120
	[CompilerGenerated]
	private string <CurrentReplicationTask>k__BackingField; // 0x128
	private Dictionary<NetworkConnection, List<ReplicationQueue.ReplicationRequest>> requestsByConnection; // 0x130
	private List<ReplicationQueue.ReplicationRequest> queue; // 0x138
	private int currentByteBudget; // 0x140
	private float timeOnLastReplicationTaskRPC; // 0x144
	private float timeOnReplicationStart; // 0x148
	private bool NetworkInitialize___EarlyScheduleOne.Networking.ReplicationQueueAssembly-CSharp.dll_Excuted; // 0x14C
	private bool NetworkInitialize__LateScheduleOne.Networking.ReplicationQueueAssembly-CSharp.dll_Excuted; // 0x14D

	// Properties
	public bool ReplicationDoneForLocalPlayer { get; set; }
	public bool LocalPlayerReplicationTimedOut { get; }
	public string CurrentReplicationTask { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool get_ReplicationDoneForLocalPlayer() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	private void set_ReplicationDoneForLocalPlayer(bool value) { }

	// RVA: 0x5EB280 Offset: 0x5E9C80 VA: 0x1805EB280
	public bool get_LocalPlayerReplicationTimedOut() { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public string get_CurrentReplicationTask() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	private void set_CurrentReplicationTask(string value) { }

	// RVA: 0x5EA570 Offset: 0x5E8F70 VA: 0x1805EA570
	public static void Enqueue(string taskName, NetworkConnection target, Action<NetworkConnection> callback, int approximateSizeBytes = 32) { }

	// RVA: 0x5EA630 Offset: 0x5E9030 VA: 0x1805EA630
	public static float GetReplicationDuration(int approximateSizeBytes) { }

	// RVA: 0x5EAB10 Offset: 0x5E9510 VA: 0x1805EAB10 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0x5EAAE0 Offset: 0x5E94E0 VA: 0x1805EAAE0 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0x5EA9D0 Offset: 0x5E93D0 VA: 0x1805EA9D0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[TargetRpc]
	// RVA: 0x5EAC00 Offset: 0x5E9600 VA: 0x1805EAC00
	private void SetReplicationDone(NetworkConnection conn) { }

	[TargetRpc]
	// RVA: 0x5EAD30 Offset: 0x5E9730 VA: 0x1805EAD30
	private void SetReplicationTask(NetworkConnection conn, string task) { }

	// RVA: 0x5EA310 Offset: 0x5E8D10 VA: 0x1805EA310
	private void Enqueue_(string taskName, NetworkConnection target, Action<NetworkConnection> callback, int approximateSizeBytes = 32) { }

	// RVA: 0x5EAE90 Offset: 0x5E9890 VA: 0x1805EAE90
	private void Update() { }

	// RVA: 0x5EA840 Offset: 0x5E9240 VA: 0x1805EA840
	private void NotifyActiveReplicationTask(ReplicationQueue.ReplicationRequest request) { }

	// RVA: 0x5EA640 Offset: 0x5E9040 VA: 0x1805EA640
	public List<ReplicationQueue.ReplicationRequest> GetRequestsForConnection(NetworkConnection conn) { }

	// RVA: 0x5EB160 Offset: 0x5E9B60 VA: 0x1805EB160
	public void .ctor() { }

	// RVA: 0x5EA750 Offset: 0x5E9150 VA: 0x1805EA750 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x5EA700 Offset: 0x5E9100 VA: 0x1805EA700 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5EAC00 Offset: 0x5E9600 VA: 0x1805EAC00
	private void RpcWriter___Target_SetReplicationDone_328543758(NetworkConnection conn) { }

	// RVA: 0x5EAB30 Offset: 0x5E9530 VA: 0x1805EAB30
	private void RpcLogic___SetReplicationDone_328543758(NetworkConnection conn) { }

	// RVA: 0x5EAB60 Offset: 0x5E9560 VA: 0x1805EAB60
	private void RpcReader___Target_SetReplicationDone_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5EAD30 Offset: 0x5E9730 VA: 0x1805EAD30
	private void RpcWriter___Target_SetReplicationTask_2971853958(NetworkConnection conn, string task) { }

	// RVA: 0x5EAB40 Offset: 0x5E9540 VA: 0x1805EAB40
	private void RpcLogic___SetReplicationTask_2971853958(NetworkConnection conn, string task) { }

	// RVA: 0x5EAB90 Offset: 0x5E9590 VA: 0x1805EAB90
	private void RpcReader___Target_SetReplicationTask_2971853958(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5EA2A0 Offset: 0x5E8CA0 VA: 0x1805EA2A0 Slot: 20
	public override void Awake() { }
}
