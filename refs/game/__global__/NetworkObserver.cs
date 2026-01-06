public sealed class NetworkObserver : MonoBehaviour // TypeDefIndex: 12560
{
	// Fields
	[Tooltip("How ObserverManager conditions are used.")]
	[SerializeField]
	private NetworkObserver.ConditionOverrideType _overrideType; // 0x20
	[SerializeField]
	[Tooltip("True to update visibility for clientHost based on if they are an observer or not.")]
	[FormerlySerializedAs("_setHostVisibility")]
	private bool _updateHostVisibility; // 0x24
	[SerializeField]
	[Tooltip("Conditions connections must met to be added as an observer. Multiple conditions may be used.")]
	internal List<ObserverCondition> _observerConditions; // 0x28
	private List<ObserverCondition> _timedConditions; // 0x30
	private HashSet<NetworkConnection> _nonTimedMet; // 0x38
	private NetworkObject _networkObject; // 0x40
	private bool _registeredAsTimed; // 0x48
	private bool _initializedPreviously; // 0x49
	private bool _lastParentVisible; // 0x4A
	private ServerManager _serverManager; // 0x50
	private bool _hasNormalConditions; // 0x58

	// Properties
	public NetworkObserver.ConditionOverrideType OverrideType { get; set; }
	public bool UpdateHostVisibility { get; set; }
	public IReadOnlyList<ObserverCondition> ObserverConditions { get; }
	[APIExclude]
	internal List<ObserverCondition> ObserverConditionsInternal { get; set; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public NetworkObserver.ConditionOverrideType get_OverrideType() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	internal void set_OverrideType(NetworkObserver.ConditionOverrideType value) { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_UpdateHostVisibility() { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	private void set_UpdateHostVisibility(bool value) { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public IReadOnlyList<ObserverCondition> get_ObserverConditions() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	internal List<ObserverCondition> get_ObserverConditionsInternal() { }

	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	internal void set_ObserverConditionsInternal(List<ObserverCondition> value) { }

	// RVA: 0xD39B10 Offset: 0xD38510 VA: 0x180D39B10
	internal void Deinitialize(bool destroyed) { }

	// RVA: 0xD39EA0 Offset: 0xD388A0 VA: 0x180D39EA0
	internal void Initialize(NetworkObject networkObject) { }

	// RVA: -1 Offset: -1
	public ObserverCondition GetObserverCondition<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF16BF0 Offset: 0xF155F0 VA: 0x180F16BF0
	|-NetworkObserver.GetObserverCondition<object>
	*/

	// RVA: 0xD3A3A0 Offset: 0xD38DA0 VA: 0x180D3A3A0
	internal ObserverStateChange RebuildObservers(NetworkConnection connection, bool timedOnly) { }

	// RVA: 0xD3A6B0 Offset: 0xD390B0 VA: 0x180D3A6B0
	private void RegisterTimedConditions() { }

	// RVA: 0xD3A800 Offset: 0xD39200 VA: 0x180D3A800
	private void UnregisterTimedConditions() { }

	// RVA: 0xD3A760 Offset: 0xD39160 VA: 0x180D3A760
	private ObserverStateChange ReturnFailedCondition(bool currentlyAdded) { }

	// RVA: 0xD3A770 Offset: 0xD39170 VA: 0x180D3A770
	private ObserverStateChange ReturnPassedConditions(bool currentlyAdded) { }

	// RVA: 0xD3A780 Offset: 0xD39180 VA: 0x180D3A780
	private void ServerManager_OnRemoteConnectionState(NetworkConnection conn, RemoteConnectionStateArgs arg2) { }

	// RVA: 0xD3A7F0 Offset: 0xD391F0 VA: 0x180D3A7F0
	public void SetUpdateHostVisibility(bool value) { }

	// RVA: 0xD3A8B0 Offset: 0xD392B0 VA: 0x180D3A8B0
	public void .ctor() { }
}
