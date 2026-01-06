public sealed class NetworkTransform : NetworkBehaviour // TypeDefIndex: 12710
{
	// Fields
	[CompilerGenerated]
	private NetworkTransform.DataReceivedChanged OnDataReceived; // 0x118
	[CompilerGenerated]
	private Action<NetworkTransform.GoalData> OnNextGoal; // 0x120
	[CompilerGenerated]
	private Action OnInterpolationComplete; // 0x128
	[CompilerGenerated]
	private bool <TakenOwnership>k__BackingField; // 0x130
	[Tooltip("Attached movement component to automatically configure.")]
	[SerializeField]
	private NetworkTransform.ComponentConfigurationType _componentConfiguration; // 0x134
	[SerializeField]
	[Tooltip("True to synchronize when this transform changes parent.")]
	private bool _synchronizeParent; // 0x138
	[Tooltip("How much to compress each transform property.")]
	[SerializeField]
	private TransformPackingData _packing; // 0x140
	[Range(1, 250)]
	[SerializeField]
	[Tooltip("How many ticks to interpolate.")]
	private ushort _interpolation; // 0x148
	[SerializeField]
	[Range(0, 1024)]
	[Tooltip("How many ticks to extrapolate.")]
	private ushort _extrapolation; // 0x14A
	[SerializeField]
	[Tooltip("True to enable teleport threshhold.")]
	private bool _enableTeleport; // 0x14C
	[Range(0, 3.4028235E+38)]
	[Tooltip("How far the transform must travel in a single update to cause a teleport rather than smoothing. Using 0f will teleport every update.")]
	[SerializeField]
	private float _teleportThreshold; // 0x150
	[SerializeField]
	[Tooltip("True to increase the teleport threshhold based on LOD of the object.")]
	private bool _scaleThreshold; // 0x154
	[Tooltip("True if owner controls how the object is synchronized.")]
	[SerializeField]
	private bool _clientAuthoritative; // 0x155
	[Tooltip("True to synchronize movements on server to owner when not using client authoritative movement.")]
	[SerializeField]
	private bool _sendToOwner; // 0x156
	[SerializeField]
	[FormerlySerializedAs("_useNetworkLod")]
	[Tooltip("True to use Network Level of Detail when the feature is enabled.")]
	private bool _enableNetworkLod; // 0x157
	[SerializeField]
	[Range(1, 255)]
	[Tooltip("How often in ticks to synchronize. This is default to 1 but can be set longer to send less often. This value may also be changed at runtime. Enabling Network level of detail for this NetworkTransform disables manual control of this feature as it will be handled internally.")]
	private byte _interval; // 0x158
	[Tooltip("True to synchronize position. Even while checked only changed values are sent.")]
	[SerializeField]
	private bool _synchronizePosition; // 0x159
	[SerializeField]
	[Tooltip("Axes to snap on position.")]
	private NetworkTransform.SnappedAxes _positionSnapping; // 0x15A
	[Tooltip("True to synchronize rotation. Even while checked only changed values are sent.")]
	[SerializeField]
	private bool _synchronizeRotation; // 0x15D
	[Tooltip("Axes to snap on rotation.")]
	[SerializeField]
	private NetworkTransform.SnappedAxes _rotationSnapping; // 0x15E
	[Tooltip("True to synchronize scale. Even while checked only changed values are sent.")]
	[SerializeField]
	private bool _synchronizeScale; // 0x161
	[SerializeField]
	[Tooltip("Axes to snap on scale.")]
	private NetworkTransform.SnappedAxes _scaleSnapping; // 0x162
	private TransformPackingData _unpacked; // 0x168
	private bool _lastReceiveReliable; // 0x170
	private NetworkBehaviour _parentBehaviour; // 0x178
	private Transform _parentTransform; // 0x180
	private List<NetworkTransform.ChangedDelta> _serverChangedSinceReliable; // 0x188
	private NetworkTransform.ChangedDelta _clientChangedSinceReliable; // 0x190
	private uint _lastObserversRpcTick; // 0x194
	private uint _lastServerRpcTick; // 0x198
	private NetworkTransform.ReceivedClientData _authoritativeClientData; // 0x1A0
	private bool _subscribedToTicks; // 0x1B8
	private NetworkTransform.TransformData _lastReceivedServerTransformData; // 0x1C0
	private NetworkTransform.TransformData _lastReceivedClientTransformData; // 0x1C8
	private NetworkTransform.RateData _lastCalculatedRateData; // 0x1D0
	private Queue<NetworkTransform.GoalData> _goalDataQueue; // 0x1D8
	private NetworkTransform.GoalData _currentGoalData; // 0x1E0
	private bool _changedSinceStart; // 0x1E8
	private short _intervalsRemaining; // 0x1EA
	private List<NetworkTransform.TransformData> _lastSentTransformDatas; // 0x1F0
	private List<PooledWriter> _toClientChangedWriters; // 0x1F8
	private uint _forceSendTick; // 0x200
	public const ushort MAX_INTERPOLATION = 250;
	private bool NetworkInitialize___EarlyFishNet.Component.Transforming.NetworkTransformFishNet.Runtime.dll_Excuted; // 0x204
	private bool NetworkInitialize__LateFishNet.Component.Transforming.NetworkTransformFishNet.Runtime.dll_Excuted; // 0x205

	// Properties
	public bool TakenOwnership { get; set; }
	private NetworkTransform.ChangedDelta _fullChanged { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xD4ABD0 Offset: 0xD495D0 VA: 0x180D4ABD0
	public void add_OnDataReceived(NetworkTransform.DataReceivedChanged value) { }

	[CompilerGenerated]
	// RVA: 0xD4ADF0 Offset: 0xD497F0 VA: 0x180D4ADF0
	public void remove_OnDataReceived(NetworkTransform.DataReceivedChanged value) { }

	[CompilerGenerated]
	// RVA: 0xD4AD30 Offset: 0xD49730 VA: 0x180D4AD30
	public void add_OnNextGoal(Action<NetworkTransform.GoalData> value) { }

	[CompilerGenerated]
	// RVA: 0xD4AF50 Offset: 0xD49950 VA: 0x180D4AF50
	public void remove_OnNextGoal(Action<NetworkTransform.GoalData> value) { }

	[CompilerGenerated]
	// RVA: 0xD4AC80 Offset: 0xD49680 VA: 0x180D4AC80
	public void add_OnInterpolationComplete(Action value) { }

	[CompilerGenerated]
	// RVA: 0xD4AEA0 Offset: 0xD498A0 VA: 0x180D4AEA0
	public void remove_OnInterpolationComplete(Action value) { }

	[CompilerGenerated]
	// RVA: 0xABD6C0 Offset: 0xABC0C0 VA: 0x180ABD6C0
	public bool get_TakenOwnership() { }

	[CompilerGenerated]
	// RVA: 0xABD820 Offset: 0xABC220 VA: 0x180ABD820
	private void set_TakenOwnership(bool value) { }

	// RVA: 0xD45550 Offset: 0xD43F50 VA: 0x180D45550
	public bool GetSendToOwner() { }

	// RVA: 0xD49C70 Offset: 0xD48670 VA: 0x180D49C70
	public void SetSendToOwner(bool value) { }

	// RVA: 0xD49DD0 Offset: 0xD487D0 VA: 0x180D49DD0
	public void SetSynchronizePosition(bool value) { }

	// RVA: 0xD49C10 Offset: 0xD48610 VA: 0x180D49C10
	public void SetPositionSnapping(NetworkTransform.SnappedAxes axes) { }

	// RVA: 0xD49DE0 Offset: 0xD487E0 VA: 0x180D49DE0
	public void SetSynchronizeRotation(bool value) { }

	// RVA: 0xD49C30 Offset: 0xD48630 VA: 0x180D49C30
	public void SetRotationSnapping(NetworkTransform.SnappedAxes axes) { }

	// RVA: 0xD49DF0 Offset: 0xD487F0 VA: 0x180D49DF0
	public void SetSynchronizeScale(bool value) { }

	// RVA: 0xD49C50 Offset: 0xD48650 VA: 0x180D49C50
	public void SetScaleSnapping(NetworkTransform.SnappedAxes axes) { }

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490
	private NetworkTransform.ChangedDelta get__fullChanged() { }

	// RVA: 0xD43DA0 Offset: 0xD427A0 VA: 0x180D43DA0 Slot: 19
	public override void Awake() { }

	// RVA: 0xD46800 Offset: 0xD45200 VA: 0x180D46800
	private void OnDestroy() { }

	// RVA: 0xD46AA0 Offset: 0xD454A0 VA: 0x180D46AA0 Slot: 4
	public override void OnStartNetwork() { }

	// RVA: 0xD46AE0 Offset: 0xD454E0 VA: 0x180D46AE0 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xD46890 Offset: 0xD45290 VA: 0x180D46890 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xD46A10 Offset: 0xD45410 VA: 0x180D46A10 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0xD46880 Offset: 0xD45280 VA: 0x180D46880 Slot: 8
	public override void OnOwnershipServer(NetworkConnection prevOwner) { }

	// RVA: 0xD46810 Offset: 0xD45210 VA: 0x180D46810 Slot: 13
	public override void OnOwnershipClient(NetworkConnection prevOwner) { }

	// RVA: 0xD46B80 Offset: 0xD45580 VA: 0x180D46B80 Slot: 5
	public override void OnStopNetwork() { }

	// RVA: 0xD46B90 Offset: 0xD45590 VA: 0x180D46B90
	private void ResetState(bool destroyed) { }

	// RVA: 0xD4AA20 Offset: 0xD49420 VA: 0x180D4AA20
	private void Update() { }

	// RVA: 0xD43730 Offset: 0xD42130 VA: 0x180D43730
	private void AddCollections(bool asServer) { }

	// RVA: 0xD44060 Offset: 0xD42A60 VA: 0x180D44060
	private void ConfigureComponents() { }

	// RVA: 0xD4A380 Offset: 0xD48D80 VA: 0x180D4A380
	private void TimeManager_OnPostTick() { }

	// RVA: 0xD43EA0 Offset: 0xD428A0 VA: 0x180D43EA0
	private void ChangeTickSubscription(bool subscribe) { }

	// RVA: 0xD43E20 Offset: 0xD42820 VA: 0x180D43E20
	private bool CanControl() { }

	[ObserversRpc(BufferLast = True, ExcludeServer = True)]
	// RVA: 0xD46560 Offset: 0xD44F60 VA: 0x180D46560
	private void ObserversSetSendToOwner(bool value) { }

	// RVA: 0xD452F0 Offset: 0xD43CF0 VA: 0x180D452F0
	public void ForceSend(uint ticks) { }

	// RVA: 0xD451C0 Offset: 0xD43BC0 VA: 0x180D451C0
	public void ForceSend() { }

	// RVA: 0xD49890 Offset: 0xD48290 VA: 0x180D49890
	public void SetInterval(byte value) { }

	// RVA: 0xD47200 Offset: 0xD45C00 VA: 0x180D47200
	private void SetIntervalInternal(byte value) { }

	[ServerRpc(RunLocally = True)]
	// RVA: 0xD49430 Offset: 0xD47E30 VA: 0x180D49430
	private void ServerSetInterval(byte value) { }

	[ObserversRpc(BufferLast = True, RunLocally = True)]
	// RVA: 0xD46420 Offset: 0xD44E20 VA: 0x180D46420
	private void ObserversSetInterval(byte value) { }

	// RVA: 0xD49680 Offset: 0xD48080 VA: 0x180D49680
	private void SetDefaultGoalData() { }

	// RVA: 0xD45AF0 Offset: 0xD444F0 VA: 0x180D45AF0
	private void LogInvalidParent() { }

	// RVA: 0xD48EE0 Offset: 0xD478E0 VA: 0x180D48EE0
	private void SerializeChanged(NetworkTransform.ChangedDelta changed, PooledWriter writer, byte lodIndex) { }

	// RVA: 0xD44A90 Offset: 0xD43490 VA: 0x180D44A90
	private void DeserializePacket(ArraySegment<byte> data, NetworkTransform.TransformData prevTransformData, NetworkTransform.TransformData nextTransformData, ref NetworkTransform.ChangedFull changedFull, out byte lodIndex) { }

	// RVA: 0xD4A6B0 Offset: 0xD490B0 VA: 0x180D4A6B0
	private void UpdateParentBehaviour() { }

	// RVA: 0xD49A70 Offset: 0xD48470 VA: 0x180D49A70
	private void SetParent(NetworkBehaviour parent, NetworkTransform.RateData rd) { }

	// RVA: 0xD45C00 Offset: 0xD44600 VA: 0x180D45C00
	private void MoveToTarget(float deltaOverride = -1) { }

	// RVA: 0xD48690 Offset: 0xD47090 VA: 0x180D48690
	private void SendToClients(byte lodIndex) { }

	// RVA: 0xD48C80 Offset: 0xD47680 VA: 0x180D48C80
	private void SendToServer(NetworkTransform.TransformData lastSentTransformData) { }

	// RVA: 0xD457A0 Offset: 0xD441A0 VA: 0x180D457A0
	private bool HasChanged(NetworkTransform.TransformData td) { }

	// RVA: 0xD45970 Offset: 0xD44370 VA: 0x180D45970
	private bool HasChanged(NetworkTransform.TransformData a, NetworkTransform.TransformData b) { }

	// RVA: 0xD455F0 Offset: 0xD43FF0 VA: 0x180D455F0
	private bool HasChanged(NetworkTransform.TransformData a, NetworkTransform.TransformData b, ref NetworkTransform.ChangedFull changedFull) { }

	// RVA: 0xD45350 Offset: 0xD43D50 VA: 0x180D45350
	private NetworkTransform.ChangedDelta GetChanged(NetworkTransform.TransformData transformData) { }

	// RVA: 0xD453A0 Offset: 0xD43DA0 VA: 0x180D453A0
	private NetworkTransform.ChangedDelta GetChanged(ref Vector3 lastPosition, ref Quaternion lastRotation, ref Vector3 lastScale, NetworkBehaviour lastParentBehaviour) { }

	// RVA: 0xD4A040 Offset: 0xD48A40 VA: 0x180D4A040
	private void SnapProperties(NetworkTransform.TransformData transformData, bool force = False) { }

	// RVA: 0xD49850 Offset: 0xD48250 VA: 0x180D49850
	private void SetInstantRates(NetworkTransform.RateData rd, uint tickDifference, float timeRemaining) { }

	// RVA: 0xD41310 Offset: 0xD3FD10 VA: 0x180D41310
	private void SetCalculatedRates(byte lodIndex, NetworkTransform.TransformData prevTd, NetworkTransform.RateData prevRd, NetworkTransform.GoalData nextGd, NetworkTransform.ChangedFull changedFull, bool hasChanged, Channel channel, bool asServer) { }

	// RVA: 0xD45560 Offset: 0xD43F60 VA: 0x180D45560
	private uint GetTickDifference(NetworkTransform.TransformData prevTd, NetworkTransform.GoalData nextGd, uint minimum, bool asServer, out float timePassed) { }

	// RVA: 0xD49830 Offset: 0xD48230 VA: 0x180D49830
	private void SetExtrapolation(NetworkTransform.TransformData prev, NetworkTransform.TransformData next, Channel channel) { }

	[TargetRpc(ValidateTarget = False)]
	// RVA: 0xD48530 Offset: 0xD46F30 VA: 0x180D48530
	private void TargetUpdateTransform(NetworkConnection conn, ArraySegment<byte> data, Channel channel) { }

	[ObserversRpc]
	// RVA: 0xD467E0 Offset: 0xD451E0 VA: 0x180D467E0
	private void ObserversUpdateClientAuthoritativeTransform(ArraySegment<byte> data, Channel channel) { }

	[ServerRpc]
	// RVA: 0xD495D0 Offset: 0xD47FD0 VA: 0x180D495D0
	private void ServerUpdateTransform(ArraySegment<byte> data, Channel channel) { }

	// RVA: 0xD444B0 Offset: 0xD42EB0 VA: 0x180D444B0
	private void DataReceived(ArraySegment<byte> data, Channel channel, bool asServer) { }

	// RVA: 0xD495F0 Offset: 0xD47FF0 VA: 0x180D495F0
	private void SetCurrentGoalData(NetworkTransform.GoalData data) { }

	// RVA: 0xD43FF0 Offset: 0xD429F0 VA: 0x180D43FF0
	public void ClearGoalData() { }

	// RVA: 0xD4A9B0 Offset: 0xD493B0 VA: 0x180D4A9B0
	private void UpdateTransformData(ArraySegment<byte> packetData, NetworkTransform.TransformData prevTransformData, NetworkTransform.TransformData nextTransformData, ref NetworkTransform.ChangedFull changedFull, out byte lodIndex) { }

	// RVA: 0xD44260 Offset: 0xD42C60 VA: 0x180D44260
	internal void ConfigureForCSP() { }

	// RVA: 0xD49E40 Offset: 0xD48840 VA: 0x180D49E40
	public void SetSynchronizedProperties(SynchronizedProperty value) { }

	[ServerRpc]
	// RVA: 0xD481A0 Offset: 0xD46BA0 VA: 0x180D481A0
	private void ServerSetSynchronizedProperties(SynchronizedProperty value) { }

	[ObserversRpc(BufferLast = True)]
	// RVA: 0xD466A0 Offset: 0xD450A0 VA: 0x180D466A0
	private void ObserversSetSynchronizedProperties(SynchronizedProperty value) { }

	// RVA: 0xD49E00 Offset: 0xD48800 VA: 0x180D49E00
	private void SetSynchronizedPropertiesInternal(SynchronizedProperty value) { }

	// RVA: 0xD4AA30 Offset: 0xD49430 VA: 0x180D4AA30
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD4A4F0 Offset: 0xD48EF0 VA: 0x180D4A4F0
	private bool <ConfigureComponents>g__CanMakeKinematic|85_0() { }

	[CompilerGenerated]
	// RVA: 0xD4A5A0 Offset: 0xD48FA0 VA: 0x180D4A5A0
	internal static void <SetDefaultGoalData>g__SetLastReceived|96_0(NetworkTransform.TransformData td, ref NetworkTransform.<>c__DisplayClass96_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD4A560 Offset: 0xD48F60 VA: 0x180D4A560
	internal static bool <SerializeChanged>g__ChangedContains|98_0(NetworkTransform.ChangedDelta whole, NetworkTransform.ChangedDelta part) { }

	[CompilerGenerated]
	// RVA: 0xD4A530 Offset: 0xD48F30 VA: 0x180D4A530
	internal static void <DeserializePacket>g__Unnest|99_0(ref NetworkTransform.<>c__DisplayClass99_0 ) { }

	[CompilerGenerated]
	// RVA: 0xD25F30 Offset: 0xD24930 VA: 0x180D25F30
	internal static bool <DeserializePacket>g__UpdateFlagAContains|99_1(NetworkTransform.UpdateFlagA whole, NetworkTransform.UpdateFlagA part) { }

	[CompilerGenerated]
	// RVA: 0xD25F30 Offset: 0xD24930 VA: 0x180D25F30
	internal static bool <DeserializePacket>g__UpdateFlagBContains|99_2(NetworkTransform.UpdateFlagB whole, NetworkTransform.UpdateFlagB part) { }

	[CompilerGenerated]
	// RVA: 0xD4A560 Offset: 0xD48F60 VA: 0x180D4A560
	internal static bool <SetCalculatedRates>g__ChangedFullContains|112_0(NetworkTransform.ChangedFull whole, NetworkTransform.ChangedFull part) { }

	[CompilerGenerated]
	// RVA: 0xD4A570 Offset: 0xD48F70 VA: 0x180D4A570
	internal static bool <SetCalculatedRates>g__LowDistance|112_1(float dist, bool rotation) { }

	[CompilerGenerated]
	// RVA: 0xD25F30 Offset: 0xD24930 VA: 0x180D25F30
	internal static bool <SetSynchronizedPropertiesInternal>g__SynchronizedPropertyContains|126_0(SynchronizedProperty whole, SynchronizedProperty part) { }

	// RVA: 0xD461B0 Offset: 0xD44BB0 VA: 0x180D461B0 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0xD46190 Offset: 0xD44B90 VA: 0x180D46190 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0xD46160 Offset: 0xD44B60 VA: 0x180D46160 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xD46560 Offset: 0xD44F60 VA: 0x180D46560
	private void RpcWriter___Observers_ObserversSetSendToOwner_1140765316(bool value) { }

	// RVA: 0xD47220 Offset: 0xD45C20 VA: 0x180D47220
	private void RpcLogic___ObserversSetSendToOwner_1140765316(bool value) { }

	// RVA: 0xD47790 Offset: 0xD46190 VA: 0x180D47790
	private void RpcReader___Observers_ObserversSetSendToOwner_1140765316(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xD47FF0 Offset: 0xD469F0 VA: 0x180D47FF0
	private void RpcWriter___Server_ServerSetInterval_1246646286(byte value) { }

	// RVA: 0xD47350 Offset: 0xD45D50 VA: 0x180D47350
	private void RpcLogic___ServerSetInterval_1246646286(byte value) { }

	// RVA: 0xD47930 Offset: 0xD46330 VA: 0x180D47930
	private void RpcReader___Server_ServerSetInterval_1246646286(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xD47D40 Offset: 0xD46740 VA: 0x180D47D40
	private void RpcWriter___Observers_ObserversSetInterval_1246646286(byte value) { }

	// RVA: 0xD47200 Offset: 0xD45C00 VA: 0x180D47200
	private void RpcLogic___ObserversSetInterval_1246646286(byte value) { }

	// RVA: 0xD47730 Offset: 0xD46130 VA: 0x180D47730
	private void RpcReader___Observers_ObserversSetInterval_1246646286(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xD48530 Offset: 0xD46F30 VA: 0x180D48530
	private void RpcWriter___Target_TargetUpdateTransform_748863190(NetworkConnection conn, ArraySegment<byte> data, Channel channel) { }

	// RVA: 0xD47690 Offset: 0xD46090 VA: 0x180D47690
	private void RpcLogic___TargetUpdateTransform_748863190(NetworkConnection conn, ArraySegment<byte> data, Channel channel) { }

	// RVA: 0xD47C80 Offset: 0xD46680 VA: 0x180D47C80
	private void RpcReader___Target_TargetUpdateTransform_748863190(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xD47E80 Offset: 0xD46880 VA: 0x180D47E80
	private void RpcWriter___Observers_ObserversUpdateClientAuthoritativeTransform_2713644489(ArraySegment<byte> data, Channel channel) { }

	// RVA: 0xD47290 Offset: 0xD45C90 VA: 0x180D47290
	private void RpcLogic___ObserversUpdateClientAuthoritativeTransform_2713644489(ArraySegment<byte> data, Channel channel) { }

	// RVA: 0xD47850 Offset: 0xD46250 VA: 0x180D47850
	private void RpcReader___Observers_ObserversUpdateClientAuthoritativeTransform_2713644489(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xD48350 Offset: 0xD46D50 VA: 0x180D48350
	private void RpcWriter___Server_ServerUpdateTransform_2713644489(ArraySegment<byte> data, Channel channel) { }

	// RVA: 0xD47540 Offset: 0xD45F40 VA: 0x180D47540
	private void RpcLogic___ServerUpdateTransform_2713644489(ArraySegment<byte> data, Channel channel) { }

	// RVA: 0xD47B00 Offset: 0xD46500 VA: 0x180D47B00
	private void RpcReader___Server_ServerUpdateTransform_2713644489(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xD481A0 Offset: 0xD46BA0 VA: 0x180D481A0
	private void RpcWriter___Server_ServerSetSynchronizedProperties_535967898(SynchronizedProperty value) { }

	// RVA: 0xD47430 Offset: 0xD45E30 VA: 0x180D47430
	private void RpcLogic___ServerSetSynchronizedProperties_535967898(SynchronizedProperty value) { }

	// RVA: 0xD479B0 Offset: 0xD463B0 VA: 0x180D479B0
	private void RpcReader___Server_ServerSetSynchronizedProperties_535967898(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xD466A0 Offset: 0xD450A0 VA: 0x180D466A0
	private void RpcWriter___Observers_ObserversSetSynchronizedProperties_535967898(SynchronizedProperty value) { }

	// RVA: 0xD47230 Offset: 0xD45C30 VA: 0x180D47230
	private void RpcLogic___ObserversSetSynchronizedProperties_535967898(SynchronizedProperty value) { }

	// RVA: 0xD477D0 Offset: 0xD461D0 VA: 0x180D477D0
	private void RpcReader___Observers_ObserversSetSynchronizedProperties_535967898(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xD43D30 Offset: 0xD42730 VA: 0x180D43D30
	private void Awake_UserLogic_FishNet.Component.Transforming.NetworkTransform_FishNet.Runtime.dll() { }
}
