public sealed class NetworkAnimator : NetworkBehaviour // TypeDefIndex: 12718
{
	// Fields
	[SerializeField]
	[HideInInspector]
	internal List<string> IgnoredParameters; // 0x118
	[Tooltip("The animator component to synchronize.")]
	[SerializeField]
	private Animator _animator; // 0x120
	[Tooltip("True to smooth float value changes for spectators.")]
	[SerializeField]
	private bool _smoothFloats; // 0x128
	[Tooltip("How many ticks to interpolate.")]
	[Range(1, 250)]
	[SerializeField]
	private ushort _interpolation; // 0x12A
	[Tooltip("True if using client authoritative animations.")]
	[SerializeField]
	private bool _clientAuthoritative; // 0x12C
	[Tooltip("True to synchronize server results back to owner. Typically used when you are changing animations on the server and are relying on the server response to update the clients animations.")]
	[SerializeField]
	private bool _sendToOwner; // 0x12D
	private List<NetworkAnimator.ParameterDetail> _parameterDetails; // 0x130
	private List<int> _ints; // 0x138
	private List<float> _floats; // 0x140
	private List<bool> _bools; // 0x148
	private float[] _layerWeights; // 0x150
	private float _speed; // 0x158
	private List<NetworkAnimator.TriggerUpdate> _triggerUpdates; // 0x160
	private List<byte[]> _toClientsBuffer; // 0x168
	private Dictionary<int, NetworkAnimator.SmoothedFloat> _smoothedFloats; // 0x170
	private Dictionary<int, NetworkAnimator.StateChange> _unsynchronizedLayerStates; // 0x178
	private Animator _lastAnimator; // 0x180
	private RuntimeAnimatorController _lastController; // 0x188
	private PooledWriter _writer; // 0x190
	private NetworkAnimator.ClientAuthoritativeUpdate _clientAuthoritativeUpdates; // 0x198
	private bool _forceAllOnTimed; // 0x1A0
	private Queue<NetworkAnimator.ReceivedServerData> _fromServerBuffer; // 0x1A8
	private uint _startTick; // 0x1B0
	private bool _subscribedToTicks; // 0x1B4
	private const byte LAYER_WEIGHT = 240;
	private const byte SPEED = 241;
	private const byte STATE = 242;
	private const byte CROSSFADE = 243;
	private bool NetworkInitialize___EarlyFishNet.Component.Animating.NetworkAnimatorFishNet.Runtime.dll_Excuted; // 0x1B5
	private bool NetworkInitialize__LateFishNet.Component.Animating.NetworkAnimatorFishNet.Runtime.dll_Excuted; // 0x1B6

	// Properties
	public Animator Animator { get; }
	public bool ClientAuthoritative { get; }
	private bool _isAnimatorEnabled { get; }
	private bool _canSmoothFloats { get; }

	// Methods

	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public Animator get_Animator() { }

	// RVA: 0x51ADF0 Offset: 0x5197F0 VA: 0x18051ADF0
	public bool get_ClientAuthoritative() { }

	// RVA: 0xD60020 Offset: 0xD5EA20 VA: 0x180D60020
	private bool get__isAnimatorEnabled() { }

	// RVA: 0xD5FFD0 Offset: 0xD5E9D0 VA: 0x180D5FFD0
	private bool get__canSmoothFloats() { }

	// RVA: 0xD5C910 Offset: 0xD5B310 VA: 0x180D5C910 Slot: 19
	public override void Awake() { }

	// RVA: 0xD5DB80 Offset: 0xD5C580 VA: 0x180D5DB80
	private void OnDestroy() { }

	[APIExclude]
	// RVA: 0xD5DB90 Offset: 0xD5C590 VA: 0x180D5DB90 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0xD5DC00 Offset: 0xD5C600 VA: 0x180D5DC00 Slot: 4
	public override void OnStartNetwork() { }

	[APIExclude]
	// RVA: 0xD5DC10 Offset: 0xD5C610 VA: 0x180D5DC10 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xD5DEB0 Offset: 0xD5C8B0 VA: 0x180D5DEB0 Slot: 5
	public override void OnStopNetwork() { }

	// RVA: 0xD5F6B0 Offset: 0xD5E0B0 VA: 0x180D5F6B0
	private void TimeManager_OnPreTick() { }

	// RVA: 0xD5F600 Offset: 0xD5E000 VA: 0x180D5F600
	private void TimeManager_OnPostTick() { }

	// RVA: 0xD5FC10 Offset: 0xD5E610 VA: 0x180D5FC10
	private void Update() { }

	// RVA: 0xD5D470 Offset: 0xD5BE70 VA: 0x180D5D470
	private void InitializeOnce() { }

	// RVA: 0xD5C940 Offset: 0xD5B340 VA: 0x180D5C940
	private void ChangeTickSubscription(bool subscribe) { }

	// RVA: 0xD5F040 Offset: 0xD5DA40 VA: 0x180D5F040
	public void SetAnimator(Animator animator) { }

	// RVA: 0xD5F0F0 Offset: 0xD5DAF0 VA: 0x180D5F0F0
	public void SetController(RuntimeAnimatorController controller) { }

	// RVA: 0xD5CE20 Offset: 0xD5B820 VA: 0x180D5CE20
	private void CheckSendToServer() { }

	// RVA: 0xD5CB40 Offset: 0xD5B540 VA: 0x180D5CB40
	private void CheckSendToClients() { }

	// RVA: 0xD5F230 Offset: 0xD5DC30 VA: 0x180D5F230
	private void SmoothFloats() { }

	// RVA: 0xD5B160 Offset: 0xD59B60 VA: 0x180D5B160
	private bool AnimatorUpdated(out ArraySegment<byte> updatedBytes, bool forceAll = False) { }

	// RVA: 0xD5BF70 Offset: 0xD5A970 VA: 0x180D5BF70
	private void ApplyParametersUpdated(ref ArraySegment<byte> updatedParameters) { }

	// RVA: 0xD5E720 Offset: 0xD5D120 VA: 0x180D5E720
	private bool ReturnCurrentLayerState(out int stateHash, out float normalizedTime, int layerIndex) { }

	[Obsolete("This does not function anymore. Data is always sent on tick now.")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void ForceSend() { }

	// RVA: 0xD5F010 Offset: 0xD5DA10 VA: 0x180D5F010
	public void SendAll() { }

	// RVA: 0xD5E450 Offset: 0xD5CE50 VA: 0x180D5E450
	public void Play(string name) { }

	// RVA: 0xD5E2D0 Offset: 0xD5CCD0 VA: 0x180D5E2D0
	public void Play(int hash) { }

	// RVA: 0xD5E560 Offset: 0xD5CF60 VA: 0x180D5E560
	public void Play(string name, int layer) { }

	// RVA: 0xD5E4F0 Offset: 0xD5CEF0 VA: 0x180D5E4F0
	public void Play(int hash, int layer) { }

	// RVA: 0xD5E510 Offset: 0xD5CF10 VA: 0x180D5E510
	public void Play(string name, int layer, float normalizedTime) { }

	// RVA: 0xD5E5B0 Offset: 0xD5CFB0 VA: 0x180D5E5B0
	public void Play(int hash, int layer, float normalizedTime) { }

	// RVA: 0xD5E0A0 Offset: 0xD5CAA0 VA: 0x180D5E0A0
	public void PlayInFixedTime(string name, float fixedTime) { }

	// RVA: 0xD5DF10 Offset: 0xD5C910 VA: 0x180D5DF10
	public void PlayInFixedTime(int hash, float fixedTime) { }

	// RVA: 0xD5E280 Offset: 0xD5CC80 VA: 0x180D5E280
	public void PlayInFixedTime(string name, int layer, float fixedTime) { }

	// RVA: 0xD5E150 Offset: 0xD5CB50 VA: 0x180D5E150
	public void PlayInFixedTime(int hash, int layer, float fixedTime) { }

	// RVA: 0xD5D190 Offset: 0xD5BB90 VA: 0x180D5D190
	public void CrossFade(string stateName, float normalizedTransitionDuration, int layer, float normalizedTimeOffset = -∞, float normalizedTransitionTime = 0) { }

	// RVA: 0xD5D300 Offset: 0xD5BD00 VA: 0x180D5D300
	public void CrossFade(int hash, float normalizedTransitionDuration, int layer, float normalizedTimeOffset = 0, float normalizedTransitionTime = 0) { }

	// RVA: 0xD5CEB0 Offset: 0xD5B8B0 VA: 0x180D5CEB0
	public void CrossFadeInFixedTime(string stateName, float fixedTransitionDuration, int layer, float fixedTimeOffset = 0, float normalizedTransitionTime = 0) { }

	// RVA: 0xD5D020 Offset: 0xD5BA20 VA: 0x180D5D020
	public void CrossFadeInFixedTime(int hash, float fixedTransitionDuration, int layer, float fixedTimeOffset = 0, float normalizedTransitionTime = 0) { }

	// RVA: 0xD5F1A0 Offset: 0xD5DBA0 VA: 0x180D5F1A0
	public void SetTrigger(int hash) { }

	// RVA: 0xD5F1E0 Offset: 0xD5DBE0 VA: 0x180D5F1E0
	public void SetTrigger(string name) { }

	// RVA: 0xD5E710 Offset: 0xD5D110 VA: 0x180D5E710
	public void ResetTrigger(int hash) { }

	// RVA: 0xD5E6E0 Offset: 0xD5D0E0 VA: 0x180D5E6E0
	public void ResetTrigger(string name) { }

	// RVA: 0xD5F9E0 Offset: 0xD5E3E0 VA: 0x180D5F9E0
	private void UpdateTrigger(int hash, bool set) { }

	[TargetRpc(ValidateTarget = False)]
	// RVA: 0xD5EEB0 Offset: 0xD5D8B0 VA: 0x180D5EEB0
	private void TargetAnimatorUpdated(NetworkConnection connection, ArraySegment<byte> data) { }

	[ServerRpc]
	// RVA: 0xD5F020 Offset: 0xD5DA20 VA: 0x180D5F020
	private void ServerAnimatorUpdated(ArraySegment<byte> data) { }

	// RVA: 0xD5FC50 Offset: 0xD5E650 VA: 0x180D5FC50
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xD5F860 Offset: 0xD5E260 VA: 0x180D5F860
	private void <CheckSendToClients>g__SendSegment|56_0(ArraySegment<byte> data) { }

	// RVA: 0xD5DAA0 Offset: 0xD5C4A0 VA: 0x180D5DAA0 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0xD5DA80 Offset: 0xD5C480 VA: 0x180D5DA80 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0xD5DA50 Offset: 0xD5C450 VA: 0x180D5DA50 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xD5EEB0 Offset: 0xD5D8B0 VA: 0x180D5EEB0
	private void RpcWriter___Target_TargetAnimatorUpdated_2304494427(NetworkConnection connection, ArraySegment<byte> data) { }

	// RVA: 0xD5EA00 Offset: 0xD5D400 VA: 0x180D5EA00
	private void RpcLogic___TargetAnimatorUpdated_2304494427(NetworkConnection connection, ArraySegment<byte> data) { }

	// RVA: 0xD5EB80 Offset: 0xD5D580 VA: 0x180D5EB80
	private void RpcReader___Target_TargetAnimatorUpdated_2304494427(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0xD5ECB0 Offset: 0xD5D6B0 VA: 0x180D5ECB0
	private void RpcWriter___Server_ServerAnimatorUpdated_415360332(ArraySegment<byte> data) { }

	// RVA: 0xD5E7E0 Offset: 0xD5D1E0 VA: 0x180D5E7E0
	private void RpcLogic___ServerAnimatorUpdated_415360332(ArraySegment<byte> data) { }

	// RVA: 0xD5EB10 Offset: 0xD5D510 VA: 0x180D5EB10
	private void RpcReader___Server_ServerAnimatorUpdated_415360332(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xD5C900 Offset: 0xD5B300 VA: 0x180D5C900
	private void Awake_UserLogic_FishNet.Component.Animating.NetworkAnimator_FishNet.Runtime.dll() { }
}
