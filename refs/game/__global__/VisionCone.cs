public class VisionCone : NetworkBehaviour // TypeDefIndex: 835
{
	// Fields
	public const float VISION_UPDATE_INTERVAL = 0.1;
	public const float MinVisionDelta = 0.075;
	public static float UniversalAttentivenessScale; // 0x0
	public static float UniversalMemoryScale; // 0x4
	public const float HorizontalFOV = 135;
	public const float VerticalFOV = 100;
	public const float Range = 25;
	public const float MinorWidth = 3;
	public const float MinorHeight = 1.5;
	public bool DEBUG; // 0x118
	public Transform VisionOrigin; // 0x120
	[Header("Vision Settings")]
	public AnimationCurve VisionFalloff; // 0x128
	public LayerMask VisibilityBlockingLayers; // 0x130
	[Range(0, 2)]
	public float RangeMultiplier; // 0x134
	[Header("Interest settings")]
	[FormerlySerializedAs("StatesOfInterest")]
	public List<VisionCone.StateContainer> DefaultStatesOfInterest; // 0x138
	[Header("Notice Settings")]
	public float Attentiveness; // 0x140
	public float Memory; // 0x144
	[Header("Sound Settings")]
	public bool UseTremoloSound; // 0x148
	[Header("Worldspace Icons")]
	public bool WorldspaceIconsEnabled; // 0x149
	public WorldspacePopup QuestionMarkPopup; // 0x150
	public WorldspacePopup ExclamationPointPopup; // 0x158
	public AudioSourceController ExclamationSound; // 0x160
	public VisionCone.EventStateChange onVisionEventStarted; // 0x168
	public VisionCone.EventStateChange onVisionEventHalf; // 0x170
	public VisionCone.EventStateChange onVisionEventFull; // 0x178
	public VisionCone.EventStateChange onVisionEventExpired; // 0x180
	protected List<ISightable> sightablesOfInterest; // 0x188
	protected Dictionary<ISightable, VisionCone.SightableData> sightableDatas; // 0x190
	protected Dictionary<ISightable, Dictionary<EVisualState, VisionCone.StateContainer>> stateSettings; // 0x198
	protected List<VisionEvent> activeVisionEvents; // 0x1A0
	protected List<VisionEvent> cachedVisionEvents; // 0x1A8
	protected NPC npc; // 0x1B0
	protected bool noticeGeneralCrime; // 0x1B8
	protected List<ISightable> sightablesSeenThisFrame; // 0x1C0
	protected List<ISightable> toRemove; // 0x1C8
	private bool NetworkInitialize___EarlyScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted; // 0x1D0
	private bool NetworkInitialize__LateScheduleOne.Vision.VisionConeAssembly-CSharp.dll_Excuted; // 0x1D1

	// Properties
	protected float effectiveRange { get; }

	// Methods

	// RVA: 0x5BBB80 Offset: 0x5BA580 VA: 0x1805BBB80
	protected float get_effectiveRange() { }

	// RVA: 0x5B67E0 Offset: 0x5B51E0 VA: 0x1805B67E0 Slot: 19
	public override void Awake() { }

	// RVA: 0x5B9100 Offset: 0x5B7B00 VA: 0x1805B9100
	private void PlayerSpawned(Player plr) { }

	// RVA: 0x5B90A0 Offset: 0x5B7AA0 VA: 0x1805B90A0
	private void OnEnable() { }

	// RVA: 0x5B9040 Offset: 0x5B7A40 VA: 0x1805B9040
	private void OnDisable() { }

	// RVA: 0x5BB860 Offset: 0x5BA260 VA: 0x1805BB860 Slot: 20
	protected virtual void VisionUpdate() { }

	// RVA: 0x5BA2B0 Offset: 0x5B8CB0 VA: 0x1805BA2B0 Slot: 21
	protected virtual void UpdateEvents(float tickTime) { }

	// RVA: 0x5BAD80 Offset: 0x5B9780 VA: 0x1805BAD80 Slot: 22
	protected virtual void UpdateVision(float tickTime) { }

	// RVA: 0x5B6CA0 Offset: 0x5B56A0 VA: 0x1805B6CA0 Slot: 23
	public virtual void EventReachedZero(VisionEvent _event) { }

	// RVA: 0x5B6BD0 Offset: 0x5B55D0 VA: 0x1805B6BD0 Slot: 24
	public virtual void EventHalfNoticed(VisionEvent _event) { }

	// RVA: 0x5B69E0 Offset: 0x5B53E0 VA: 0x1805B69E0 Slot: 25
	public virtual void EventFullyNoticed(VisionEvent _event) { }

	[ServerRpc(RunLocally = True, RequireOwnership = False)]
	// RVA: 0x5B9F20 Offset: 0x5B8920 VA: 0x1805B9F20
	public void SendEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level) { }

	[ObserversRpc(RunLocally = True, ExcludeOwner = True)]
	// RVA: 0x5B9870 Offset: 0x5B8270 VA: 0x1805B9870 Slot: 26
	public virtual void ReceiveEventReceipt(VisionEventReceipt receipt, VisionCone.EEventLevel level) { }

	// RVA: 0x5B6390 Offset: 0x5B4D90 VA: 0x1805B6390
	public void AddSightableOfInterest(ISightable s) { }

	// RVA: 0x5B99D0 Offset: 0x5B83D0 VA: 0x1805B99D0
	public void RemoveSightableOfInterest(ISightable s) { }

	// RVA: 0x5BA150 Offset: 0x5B8B50 VA: 0x1805BA150
	public void SetSightableStateEnabled(ISightable sightable, EVisualState state, bool enabled) { }

	[Button]
	// RVA: 0x5B9360 Offset: 0x5B7D60 VA: 0x1805B9360
	public void PrintSightableStates() { }

	// RVA: 0x5B85A0 Offset: 0x5B6FA0 VA: 0x1805B85A0 Slot: 27
	public virtual bool IsPointWithinSight(Vector3 point, bool ignoreLoS = False, LandVehicle vehicleToIgnore) { }

	// RVA: 0x5B6DA0 Offset: 0x5B57A0 VA: 0x1805B6DA0
	public VisionEvent GetEvent(ISightable target, EntityVisualState state) { }

	// RVA: 0x5B8420 Offset: 0x5B6E20 VA: 0x1805B8420
	public bool IsPlayerVisible(Player player) { }

	// RVA: 0x5B8420 Offset: 0x5B6E20 VA: 0x1805B8420
	public bool WasSightableVisibleThisFrame(ISightable sightable) { }

	// RVA: 0x5B8D50 Offset: 0x5B7750 VA: 0x1805B8D50
	public bool IsTargetVisible(ISightable target) { }

	// RVA: 0x5B8330 Offset: 0x5B6D30 VA: 0x1805B8330
	public float GetPlayerVisibility(Player player) { }

	// RVA: 0x5B84D0 Offset: 0x5B6ED0 VA: 0x1805B84D0
	public bool IsPlayerVisible(Player player, out VisionCone.SightableData data) { }

	// RVA: 0x5BA080 Offset: 0x5B8A80 VA: 0x1805BA080 Slot: 28
	public virtual void SetNoticePlayerCrimes(Player player, bool active) { }

	// RVA: 0x5B9030 Offset: 0x5B7A30 VA: 0x1805B9030
	private void OnDie() { }

	// RVA: 0x5B6830 Offset: 0x5B5230 VA: 0x1805B6830
	public void ClearEvents() { }

	// RVA: 0x5B7AA0 Offset: 0x5B64A0 VA: 0x1805B7AA0
	private Vector3[] GetFrustumVertices() { }

	// RVA: 0x5B6EA0 Offset: 0x5B58A0 VA: 0x1805B6EA0
	private Plane[] GetFrustumPlanes() { }

	// RVA: 0x5BB910 Offset: 0x5BA310 VA: 0x1805BB910
	public void .ctor() { }

	// RVA: 0x5BB8C0 Offset: 0x5BA2C0 VA: 0x1805BB8C0
	private static void .cctor() { }

	// RVA: 0x5B8F50 Offset: 0x5B7950 VA: 0x1805B8F50 Slot: 29
	public override void NetworkInitialize___Early() { }

	// RVA: 0x5B8F30 Offset: 0x5B7930 VA: 0x1805B8F30 Slot: 30
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5B8EF0 Offset: 0x5B78F0 VA: 0x1805B8EF0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5B9DC0 Offset: 0x5B87C0 VA: 0x1805B9DC0
	private void RpcWriter___Server_SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level) { }

	// RVA: 0x5B9B30 Offset: 0x5B8530 VA: 0x1805B9B30
	public void RpcLogic___SendEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level) { }

	// RVA: 0x5B9BC0 Offset: 0x5B85C0 VA: 0x1805B9BC0
	private void RpcReader___Server_SendEventReceipt_3486014028(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5B9C50 Offset: 0x5B8650 VA: 0x1805B9C50
	private void RpcWriter___Observers_ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level) { }

	// RVA: 0x5B9A90 Offset: 0x5B8490 VA: 0x1805B9A90 Slot: 31
	public virtual void RpcLogic___ReceiveEventReceipt_3486014028(VisionEventReceipt receipt, VisionCone.EEventLevel level) { }

	// RVA: 0x5B9B50 Offset: 0x5B8550 VA: 0x1805B9B50
	private void RpcReader___Observers_ReceiveEventReceipt_3486014028(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5B6420 Offset: 0x5B4E20 VA: 0x1805B6420 Slot: 32
	protected virtual void Awake_UserLogic_ScheduleOne.Vision.VisionCone_Assembly-CSharp.dll() { }
}
