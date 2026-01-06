public class PredictedObject : NetworkBehaviour // TypeDefIndex: 12682
{
	// Fields
	[Tooltip("True if this object implements replicate and reconcile methods.")]
	[SerializeField]
	private bool _implementsPredictionMethods; // 0x118
	[Tooltip("Transform which holds the graphical features of this object. This transform will be smoothed when desynchronizations occur.")]
	[SerializeField]
	private Transform _graphicalObject; // 0x120
	[SerializeField]
	[Tooltip("True to enable teleport threshhold.")]
	private bool _enableTeleport; // 0x128
	[Range(0, 200)]
	[SerializeField]
	[Tooltip("How far the transform must travel in a single update to cause a teleport rather than smoothing. Using 0f will teleport every update.")]
	private float _teleportThreshold; // 0x12C
	[Tooltip("True to smooth position on owner objects.")]
	[SerializeField]
	private bool _ownerSmoothPosition; // 0x130
	[SerializeField]
	[Tooltip("True to smooth rotation on owner objects.")]
	private bool _ownerSmoothRotation; // 0x131
	[Tooltip("How far in the past to keep the graphical object when owner. Using a value of 0 will disable interpolation.")]
	[Range(0, 255)]
	[SerializeField]
	private byte _ownerInterpolation; // 0x132
	[Tooltip("Type of prediction movement which is being used.")]
	[SerializeField]
	private PredictedObject.PredictionType _predictionType; // 0x133
	[Tooltip("Rigidbody to predict.")]
	[SerializeField]
	private Rigidbody _rigidbody; // 0x138
	[Tooltip("Rigidbody2D to predict.")]
	[SerializeField]
	private Rigidbody2D _rigidbody2d; // 0x140
	[Tooltip("True to smooth position on spectated objects.")]
	[SerializeField]
	private bool _spectatorSmoothPosition; // 0x148
	[Tooltip("True to smooth rotation on spectated objects.")]
	[SerializeField]
	private bool _spectatorSmoothRotation; // 0x149
	[SerializeField]
	[Tooltip("How to favor smoothing for predicted objects.")]
	private PredictedObject.SpectatorSmoothingType _spectatorSmoothingType; // 0x14C
	[Tooltip("Custom settings for smoothing data.")]
	[SerializeField]
	private PredictedObject.SmoothingData _customSmoothingData; // 0x150
	[SerializeField]
	private PredictedObject.SmoothingData _preconfiguredSmoothingDataPreview; // 0x15C
	[Tooltip("Multiplier applied to difference in velocity between ticks. Positive values will result in more velocity while lowers will result in less. A value of 1f will prevent any velocity from being lost between ticks, unless indicated by the server.")]
	[SerializeField]
	[Range(-10, 10)]
	private float _maintainedVelocity; // 0x168
	[SerializeField]
	[Tooltip("How often to resend current values regardless if the state has changed. Using this value will consume more bandwidth but may be preferred if you want to force synchronization the object move on the client but not on the server.")]
	private PredictedObject.ResendType _resendType; // 0x16C
	[Tooltip("How often in ticks to resend values.")]
	[SerializeField]
	private ushort _resendInterval; // 0x16E
	[Tooltip("NetworkTransform to configure.")]
	[SerializeField]
	private NetworkTransform _networkTransform; // 0x170
	private bool _clientSubscribed; // 0x178
	private bool _registered; // 0x179
	private Vector3 _graphicalInstantiatedOffsetPosition; // 0x17C
	private Quaternion _graphicalInstantiatedOffsetRotation; // 0x188
	private uint _localTick; // 0x198
	private PredictedObjectSpectatorSmoother _spectatorSmoother; // 0x1A0
	private PredictedObjectOwnerSmoother _ownerSmoother; // 0x1A8
	private RigidbodyPauser _rigidbodyPauser; // 0x1B0
	private uint _nextIntervalResend; // 0x1B8
	private ushort _resendsRemaining; // 0x1BC
	private bool _previouslyChanged; // 0x1BE
	private Animator[] _graphicalAnimators; // 0x1C0
	private bool _animatorsInitialized; // 0x1C8
	private uint _lastStateLocalTick; // 0x1CC
	private long _currentSpectatorInterpolation; // 0x1D0
	private uint _targetSpectatorInterpolation; // 0x1D8
	private uint _targetCollisionSpectatorInterpolation; // 0x1DC
	private byte _interpolationDecreaseStep; // 0x1E0
	private byte _interpolationIncreaseStep; // 0x1E1
	private uint _collisionStayedTick; // 0x1E4
	private HashSet<GameObject> _localClientCollidedObjects; // 0x1E8
	private bool _spectatorPaused; // 0x1F0
	private static PredictedObject.SmoothingData _accurateSmoothingData; // 0x0
	private static PredictedObject.SmoothingData _mixedSmoothingData; // 0xC
	private static PredictedObject.SmoothingData _gradualSmoothingData; // 0x18
	private uint _igtt; // 0x1F4
	private RingBuffer<RigidbodyState> _rigidbodyStates; // 0x1F8
	private Vector3 _lastVelocity; // 0x200
	private Vector3 _lastAngularVelocity; // 0x20C
	private Nullable<float> _velocityBaseline; // 0x218
	private Nullable<float> _angularVelocityBaseline; // 0x220
	private PhysicsScene _physicsScene; // 0x228
	private RingBuffer<Rigidbody2DState> _rigidbody2dStates; // 0x230
	private Vector3 _lastVelocity2D; // 0x238
	private float _lastAngularVelocity2D; // 0x244
	private Nullable<float> _velocityBaseline2D; // 0x248
	private Nullable<float> _angularVelocityBaseline2D; // 0x250
	private PhysicsScene2D _physicsScene2D; // 0x258
	private int _preReplicateReplayCacheIndex; // 0x25C
	private uint _lastPingUpdateTick; // 0x260
	private long _lastPing; // 0x268
	private bool NetworkInitialize___EarlyFishNet.Component.Prediction.PredictedObjectFishNet.Runtime.dll_Excuted; // 0x270
	private bool NetworkInitialize__LateFishNet.Component.Prediction.PredictedObjectFishNet.Runtime.dll_Excuted; // 0x271

	// Properties
	public bool IsRigidbodyPrediction { get; }

	// Methods

	// RVA: 0xD539D0 Offset: 0xD523D0 VA: 0x180D539D0
	public bool get_IsRigidbodyPrediction() { }

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public Transform GetGraphicalObject() { }

	// RVA: 0xD526D0 Offset: 0xD510D0 VA: 0x180D526D0
	public void SetGraphicalObject(Transform value) { }

	[Obsolete("No longer used. This setting has been replaced by Smoothing Type.")]
	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public bool GetSmoothTicks() { }

	[Obsolete("No longer used. This setting has been replaced by Smoothing Type.")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SetSmoothTicks(bool value) { }

	[Obsolete("No longer used. This setting has been replaced by Smoothing Type.")]
	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public byte GetInterpolation(bool asOwner) { }

	[Obsolete("No longer used. This setting has been replaced by Smoothing Type.")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void SetInterpolation(byte value, bool asOwner) { }

	// RVA: 0xD52830 Offset: 0xD51230 VA: 0x180D52830
	public void SetSpectatorSmoothingType(PredictedObject.SpectatorSmoothingType value) { }

	// RVA: 0xD4E1C0 Offset: 0xD4CBC0 VA: 0x180D4E1C0 Slot: 19
	public override void Awake() { }

	// RVA: 0xD4F5D0 Offset: 0xD4DFD0 VA: 0x180D4F5D0 Slot: 4
	public override void OnStartNetwork() { }

	// RVA: 0xD4F460 Offset: 0xD4DE60 VA: 0x180D4F460 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xD4F500 Offset: 0xD4DF00 VA: 0x180D4F500 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0xD4F3C0 Offset: 0xD4DDC0 VA: 0x180D4F3C0 Slot: 13
	public override void OnOwnershipClient(NetworkConnection prevOwner) { }

	// RVA: 0xD4F7C0 Offset: 0xD4E1C0 VA: 0x180D4F7C0 Slot: 5
	public override void OnStopNetwork() { }

	// RVA: 0xD53490 Offset: 0xD51E90 VA: 0x180D53490
	private void UpdateRigidbodiesCount(bool add) { }

	// RVA: 0xD4E180 Offset: 0xD4CB80 VA: 0x180D4E180
	private void SetInstantiatedOffsetValues() { }

	// RVA: 0xD52D10 Offset: 0xD51710 VA: 0x180D52D10
	private void TimeManager_OnUpdate() { }

	// RVA: 0xD52BB0 Offset: 0xD515B0 VA: 0x180D52BB0
	private void TimeManager_OnPreTick() { }

	// RVA: 0xD529A0 Offset: 0xD513A0 VA: 0x180D529A0
	protected void TimeManager_OnPostTick() { }

	// RVA: 0xD4E2B0 Offset: 0xD4CCB0 VA: 0x180D4E2B0
	private void ChangeSubscriptions(bool subscribe) { }

	// RVA: 0xD50810 Offset: 0xD4F210 VA: 0x180D50810
	private void TimeManager_OnRoundTripTimeUpdated(long obj) { }

	// RVA: 0xD4FF60 Offset: 0xD4E960 VA: 0x180D4FF60
	private void PredictionManager_OnPreServerReconcile(NetworkBehaviour obj) { }

	// RVA: 0xD4FED0 Offset: 0xD4E8D0 VA: 0x180D4FED0 Slot: 20
	protected virtual void PredictionManager_OnPreReplicateReplay(uint tick, PhysicsScene ps, PhysicsScene2D ps2d) { }

	// RVA: 0xD4FE00 Offset: 0xD4E800 VA: 0x180D4FE00
	private void PredictionManager_OnPostReplicateReplay(uint tick, PhysicsScene ps, PhysicsScene2D ps2d) { }

	// RVA: 0xD4FEC0 Offset: 0xD4E8C0 VA: 0x180D4FEC0
	private void PredictionManager_OnPreReconcile(NetworkBehaviour nb) { }

	// RVA: 0xD4FDD0 Offset: 0xD4E7D0 VA: 0x180D4FDD0
	private void PredictionManager_OnPostReconcile(NetworkBehaviour nb) { }

	// RVA: 0xD4EC10 Offset: 0xD4D610 VA: 0x180D4EC10
	private void InitializeSmoother(bool ownerSmoother) { }

	// RVA: 0xD4E9F0 Offset: 0xD4D3F0 VA: 0x180D4E9F0
	private void ConfigureRigidbodies() { }

	// RVA: 0xD4E9C0 Offset: 0xD4D3C0 VA: 0x180D4E9C0
	private void ConfigureNetworkTransform() { }

	// RVA: 0xD4EFA0 Offset: 0xD4D9A0 VA: 0x180D4EFA0
	internal bool IsPredictingOwner() { }

	// RVA: 0xD53980 Offset: 0xD52380 VA: 0x180D53980
	private bool _isPredictingOwner(NetworkConnection c) { }

	// RVA: 0xD509B0 Offset: 0xD4F3B0 VA: 0x180D509B0
	private void Rigidbodies_OnSpawnServer(NetworkConnection c) { }

	// RVA: 0xD50A50 Offset: 0xD4F450 VA: 0x180D50A50
	private void Rigidbodies_OnStartClient() { }

	// RVA: 0xD503A0 Offset: 0xD4EDA0 VA: 0x180D503A0
	private void Rigidbodies_OnOwnershipClient(NetworkConnection prevOwner) { }

	// RVA: 0xD50F50 Offset: 0xD4F950 VA: 0x180D50F50
	private void Rigidbodies_TimeManager_OnPostTick() { }

	// RVA: 0xD52F60 Offset: 0xD51960 VA: 0x180D52F60
	private void TrySetCollisionExited(bool is2d) { }

	// RVA: 0xD512F0 Offset: 0xD4FCF0 VA: 0x180D512F0
	private void Rigidbodies_TimeManager_OnPreReconcile(NetworkBehaviour nb) { }

	// RVA: 0xD4FDD0 Offset: 0xD4E7D0 VA: 0x180D4FDD0
	private void Rigidbodies_TimeManager_OnPostReconcile(NetworkBehaviour nb) { }

	// RVA: 0xD50D90 Offset: 0xD4F790 VA: 0x180D50D90
	private void Rigidbodies_PredictionManager_OnPreReplicateReplay(uint tick, PhysicsScene ps, PhysicsScene2D ps2d) { }

	// RVA: 0xD50B10 Offset: 0xD4F510 VA: 0x180D50B10
	private void Rigidbodies_PredictionManager_OnPostReplicateReplay(uint tick, PhysicsScene ps, PhysicsScene2D ps2d) { }

	// RVA: 0xD527A0 Offset: 0xD511A0 VA: 0x180D527A0
	public void SetPauseSpectatorCorrections_Experimental(bool pause) { }

	// RVA: 0xD50810 Offset: 0xD4F210 VA: 0x180D50810
	private void Rigidbodies_OnRoundTripTimeUpdated(long ping) { }

	// RVA: 0xD528B0 Offset: 0xD512B0 VA: 0x180D528B0
	private void SetTargetSmoothing(long ping, bool setImmediately) { }

	// RVA: 0xD4E820 Offset: 0xD4D220 VA: 0x180D4E820
	private bool CollidingWithLocalClient() { }

	// RVA: 0xD53600 Offset: 0xD52000 VA: 0x180D53600
	private void UpdateSpectatorSmoothing() { }

	// RVA: 0xD4E860 Offset: 0xD4D260 VA: 0x180D4E860
	private bool CollisionEnteredLocalClientObject(GameObject go) { }

	// RVA: 0xD52330 Offset: 0xD50D30 VA: 0x180D52330
	private void SendRigidbodyState(NetworkBehaviour nb) { }

	// RVA: 0xD52DB0 Offset: 0xD517B0 VA: 0x180D52DB0
	private void TrySendRigidbodyState(NetworkBehaviour nb, uint tick) { }

	// RVA: 0xD4EB20 Offset: 0xD4D520 VA: 0x180D4EB20
	private int GetCachedStateIndex(uint tick, bool is2d) { }

	// RVA: 0xD4F9E0 Offset: 0xD4E3E0 VA: 0x180D4F9E0
	protected bool PredictVector3Velocity(ref Nullable<float> velocityBaseline, ref Vector3 lastVelocity, Vector3 velocity, out Vector3 result) { }

	// RVA: 0xD4F870 Offset: 0xD4E270 VA: 0x180D4F870
	private bool PredictFloatVelocity(ref Nullable<float> velocityBaseline, ref float lastVelocity, float velocity, out float result) { }

	// RVA: 0xD4E230 Offset: 0xD4CC30 VA: 0x180D4E230
	private bool CanPredict() { }

	// RVA: 0xD4F1C0 Offset: 0xD4DBC0 VA: 0x180D4F1C0
	private void OnCollisionEnter(Collision collision) { }

	// RVA: 0xD4F320 Offset: 0xD4DD20 VA: 0x180D4F320
	private void OnCollisionStay(Collision collision) { }

	// RVA: 0xD501D0 Offset: 0xD4EBD0 VA: 0x180D501D0
	private void ResetRigidbodyToData(RigidbodyState state) { }

	// RVA: 0xD42D90 Offset: 0xD41790 VA: 0x180D42D90
	private void PredictVelocity(PhysicsScene ps) { }

	// RVA: 0xD523E0 Offset: 0xD50DE0 VA: 0x180D523E0
	private void SendRigidbodyState(uint reconcileTick, NetworkConnection conn, bool applyImmediately) { }

	[TargetRpc(ValidateTarget = False)]
	// RVA: 0xD51F10 Offset: 0xD50910 VA: 0x180D51F10
	private void TargetSendRigidbodyState(NetworkConnection c, RigidbodyState state, bool applyImmediately, Channel channel = 1) { }

	// RVA: 0xD4F100 Offset: 0xD4DB00 VA: 0x180D4F100
	private void OnCollisionEnter2D(Collision2D collision) { }

	// RVA: 0xD4F280 Offset: 0xD4DC80 VA: 0x180D4F280
	private void OnCollisionStay2D(Collision2D collision) { }

	// RVA: 0xD4E8E0 Offset: 0xD4D2E0 VA: 0x180D4E8E0
	private void CollisionEntered(GameObject go) { }

	// RVA: 0xD4E960 Offset: 0xD4D360 VA: 0x180D4E960
	private void CollisionExited() { }

	// RVA: 0xD50010 Offset: 0xD4EA10 VA: 0x180D50010
	private void ResetRigidbody2DToData(Rigidbody2DState state) { }

	// RVA: 0xD42F60 Offset: 0xD41960 VA: 0x180D42F60
	private void PredictVelocity(PhysicsScene2D ps) { }

	// RVA: 0xD520B0 Offset: 0xD50AB0 VA: 0x180D520B0
	private void SendRigidbody2DState(uint reconcileTick, NetworkConnection conn, bool applyImmediately) { }

	[TargetRpc(ValidateTarget = False)]
	// RVA: 0xD51D80 Offset: 0xD50780 VA: 0x180D51D80
	private void TargetSendRigidbody2DState(NetworkConnection c, Rigidbody2DState state, bool applyImmediately, Channel channel = 1) { }

	// RVA: 0xD4E290 Offset: 0xD4CC90 VA: 0x180D4E290
	private bool CanProcessReceivedState(uint stateTick) { }

	// RVA: 0xD53780 Offset: 0xD52180 VA: 0x180D53780
	public void .ctor() { }

	// RVA: 0xD536C0 Offset: 0xD520C0 VA: 0x180D536C0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xD52FE0 Offset: 0xD519E0 VA: 0x180D52FE0
	private void <InitializeSmoother>g__ResetGraphicalTransform|57_0() { }

	[CompilerGenerated]
	// RVA: 0xD53230 Offset: 0xD51C30 VA: 0x180D53230
	private void <SetTargetSmoothing>g__SetValues|92_0(ref PredictedObject.<>c__DisplayClass92_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD53480 Offset: 0xD51E80 VA: 0x180D53480
	private void <TrySendRigidbodyState>g__UpdateNextIntervalResend|98_0(ref PredictedObject.<>c__DisplayClass98_0 ) { }

	// RVA: 0xD4F030 Offset: 0xD4DA30 VA: 0x180D4F030 Slot: 21
	public override void NetworkInitialize___Early() { }

	// RVA: 0xD4F010 Offset: 0xD4DA10 VA: 0x180D4F010 Slot: 22
	public override void NetworkInitialize__Late() { }

	// RVA: 0xD4EFD0 Offset: 0xD4D9D0 VA: 0x180D4EFD0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xD51F10 Offset: 0xD50910 VA: 0x180D51F10
	private void RpcWriter___Target_TargetSendRigidbodyState_1016043495(NetworkConnection c, RigidbodyState state, bool applyImmediately, Channel channel = 1) { }

	// RVA: 0xD51740 Offset: 0xD50140 VA: 0x180D51740
	private void RpcLogic___TargetSendRigidbodyState_1016043495(NetworkConnection c, RigidbodyState state, bool applyImmediately, Channel channel = 1) { }

	// RVA: 0xD51B40 Offset: 0xD50540 VA: 0x180D51B40
	private void RpcReader___Target_TargetSendRigidbodyState_1016043495(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xD51D80 Offset: 0xD50780 VA: 0x180D51D80
	private void RpcWriter___Target_TargetSendRigidbody2DState_700510009(NetworkConnection c, Rigidbody2DState state, bool applyImmediately, Channel channel = 1) { }

	// RVA: 0xD51580 Offset: 0xD4FF80 VA: 0x180D51580
	private void RpcLogic___TargetSendRigidbody2DState_700510009(NetworkConnection c, Rigidbody2DState state, bool applyImmediately, Channel channel = 1) { }

	// RVA: 0xD51930 Offset: 0xD50330 VA: 0x180D51930
	private void RpcReader___Target_TargetSendRigidbody2DState_700510009(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xD4E180 Offset: 0xD4CB80 VA: 0x180D4E180
	private void Awake_UserLogic_FishNet.Component.Prediction.PredictedObject_FishNet.Runtime.dll() { }
}
