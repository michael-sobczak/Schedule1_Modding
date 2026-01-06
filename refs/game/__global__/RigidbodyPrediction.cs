public class RigidbodyPrediction : NetworkBehaviour // TypeDefIndex: 18092
{
	// Fields
	[SerializeField]
	private float _jumpForce; // 0x118
	[SerializeField]
	private float _moveRate; // 0x11C
	private Rigidbody _rigidbody; // 0x120
	private float _nextJumpTime; // 0x128
	private bool _jump; // 0x12C
	public NetworkObject BulletPrefab; // 0x130
	private bool _spawnBullet; // 0x138
	private bool _despawnBullet; // 0x139
	private NetworkObject _lastSpawnedBullet; // 0x140
	private ReplicateUserLogicDelegate<RigidbodyPrediction.MoveData> _replicateULDelegate___Move; // 0x148
	private ReconcileUserLogicDelegate<RigidbodyPrediction.ReconcileData> _reconcileULDelegate___Reconciliation; // 0x150
	private BasicQueue<RigidbodyPrediction.MoveData> _serverReplicates___Move; // 0x158
	private List<RigidbodyPrediction.MoveData> _clientReplicates___Move; // 0x160
	private RigidbodyPrediction.ReconcileData _reconcileData___Move; // 0x168
	private RigidbodyPrediction.MoveData[] Move___serverReplicateReadBuffer; // 0x1A0
	private bool NetworkInitialize___EarlyFishNet.Example.Prediction.Rigidbodies.RigidbodyPredictionFishNet.Demos.dll_Excuted; // 0x1A8
	private bool NetworkInitialize__LateFishNet.Example.Prediction.Rigidbodies.RigidbodyPredictionFishNet.Demos.dll_Excuted; // 0x1A9

	// Methods

	// RVA: 0xCEC4E0 Offset: 0xCEAEE0 VA: 0x180CEC4E0 Slot: 19
	public override void Awake() { }

	// RVA: 0xCECBB0 Offset: 0xCEB5B0 VA: 0x180CECBB0
	private void OnDestroy() { }

	// RVA: 0xCECCD0 Offset: 0xCEB6D0 VA: 0x180CECCD0 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0xCECD70 Offset: 0xCEB770 VA: 0x180CECD70 Slot: 12
	public override void OnStopClient() { }

	// RVA: 0xCED980 Offset: 0xCEC380 VA: 0x180CED980
	private void Update() { }

	// RVA: 0xCECE10 Offset: 0xCEB810 VA: 0x180CECE10
	private void PredictionManager_OnPreReplicateReplay(uint arg1, PhysicsScene arg2, PhysicsScene2D arg3) { }

	// RVA: 0xCED340 Offset: 0xCEBD40 VA: 0x180CED340
	private void TimeManager_OnTick() { }

	// RVA: 0xCED160 Offset: 0xCEBB60 VA: 0x180CED160
	private void TimeManager_OnPostTick() { }

	// RVA: 0xCEC620 Offset: 0xCEB020 VA: 0x180CEC620
	private void BuildMoveData(out RigidbodyPrediction.MoveData md) { }

	// RVA: 0xCED660 Offset: 0xCEC060 VA: 0x180CED660
	private void TrySpawnBullet() { }

	// RVA: 0xCED630 Offset: 0xCEC030 VA: 0x180CED630
	private void TryDespawnBullet() { }

	// RVA: 0xCEC330 Offset: 0xCEAD30 VA: 0x180CEC330
	private void AddGravity() { }

	[Replicate]
	// RVA: 0xCEC830 Offset: 0xCEB230 VA: 0x180CEC830
	private void Move(RigidbodyPrediction.MoveData md, bool asServer, Channel channel = 1, bool replaying = False) { }

	[Reconcile]
	// RVA: 0xCED020 Offset: 0xCEBA20 VA: 0x180CED020
	private void Reconciliation(RigidbodyPrediction.ReconcileData rd, bool asServer, Channel channel = 1) { }

	// RVA: 0xCEDAE0 Offset: 0xCEC4E0 VA: 0x180CEDAE0
	public void .ctor() { }

	// RVA: 0xCEC940 Offset: 0xCEB340 VA: 0x180CEC940 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0xCEC920 Offset: 0xCEB320 VA: 0x180CEC920 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xCEC780 Offset: 0xCEB180 VA: 0x180CEC780
	private void Move___UL(RigidbodyPrediction.MoveData md, bool asServer, Channel channel = 1, bool replaying = False) { }

	// RVA: 0xCECF40 Offset: 0xCEB940 VA: 0x180CECF40
	private void Reconciliation___UL(RigidbodyPrediction.ReconcileData rd, bool asServer, Channel channel = 1) { }

	// RVA: 0xCEC6F0 Offset: 0xCEB0F0 VA: 0x180CEC6F0 Slot: 17
	public override void ClearReplicateCache_Virtual(bool asServer) { }

	// RVA: 0xCECEB0 Offset: 0xCEB8B0 VA: 0x180CECEB0
	private void Reader_Replicate___Move(PooledReader PooledReader0, NetworkConnection NetworkConnection1, Channel Channel2) { }

	// RVA: 0xCECE40 Offset: 0xCEB840 VA: 0x180CECE40
	private void Reader_Reconcile___Reconciliation(PooledReader PooledReader0, Channel Channel1) { }

	// RVA: 0xCEC3D0 Offset: 0xCEADD0 VA: 0x180CEC3D0
	private void Awake_UserLogic_FishNet.Example.Prediction.Rigidbodies.RigidbodyPrediction_FishNet.Demos.dll() { }
}
