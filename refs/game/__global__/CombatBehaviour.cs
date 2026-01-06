public class CombatBehaviour : Behaviour // TypeDefIndex: 1998
{
	// Fields
	public const float RECENT_VISIBILITY_THRESHOLD = 3.5;
	public const float REPOSITION_TIME = 4;
	public const float SEARCH_RADIUS_MIN = 25;
	public const float SEARCH_RADIUS_MAX = 60;
	public const float SEARCH_SPEED = 0.4;
	public const float CONSECUTIVE_MISS_ACCURACY_BOOST = 0.1;
	public const float REACHED_DESTINATION_DISTANCE = 2;
	[CompilerGenerated]
	private ICombatTargetable <Target>k__BackingField; // 0x168
	[CompilerGenerated]
	private bool <IsSearching>k__BackingField; // 0x170
	[CompilerGenerated]
	private float <TimeSinceTargetReacquired>k__BackingField; // 0x174
	public bool DEBUG; // 0x178
	[Header("General Setttings")]
	public float GiveUpRange; // 0x17C
	public int GiveUpAfterSuccessfulHits; // 0x180
	public bool PlayAngryVO; // 0x184
	[Range(0, 1)]
	[Header("Movement settings")]
	public float DefaultMovementSpeed; // 0x188
	[Header("Weapon settings")]
	public AvatarWeapon DefaultWeapon; // 0x190
	public AvatarMeleeWeapon VirtualPunchWeapon; // 0x198
	[Header("Search settings")]
	public float DefaultSearchTime; // 0x1A0
	[Header("References")]
	public SmoothedVelocityCalculator TargetVelocityTracker; // 0x1A8
	[Header("Debug settings")]
	public bool CombatOnStart; // 0x1B0
	public NetworkObject DebugTarget; // 0x1B8
	[CompilerGenerated]
	private bool <IsTargetRecentlyVisible>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private bool <IsTargetImmediatelyVisible>k__BackingField; // 0x1C1
	protected float timeSinceLastSighting; // 0x1C4
	protected Vector3 lastKnownTargetPosition; // 0x1C8
	private float timeSinceLastReposition; // 0x1D4
	private float timeWithinAttackRange; // 0x1D8
	private bool visionEventReceived; // 0x1DC
	protected AvatarWeapon currentWeapon; // 0x1E0
	protected int successfulHits; // 0x1E8
	protected int consecutiveMissedShots; // 0x1EC
	protected Coroutine rangedWeaponRoutine; // 0x1F0
	protected Coroutine searchRoutine; // 0x1F8
	protected Vector3 currentSearchDestination; // 0x200
	protected bool hasSearchDestination; // 0x20C
	private float nextAngryVO; // 0x210
	public Action onSuccessfulHit; // 0x218
	private bool NetworkInitialize___EarlyScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted; // 0x220
	private bool NetworkInitialize__LateScheduleOne.Combat.CombatBehaviourAssembly-CSharp.dll_Excuted; // 0x221

	// Properties
	public ICombatTargetable Target { get; set; }
	public bool IsSearching { get; set; }
	public float TimeSinceTargetReacquired { get; set; }
	public bool IsTargetRecentlyVisible { get; set; }
	public bool IsTargetImmediatelyVisible { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public ICombatTargetable get_Target() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	protected void set_Target(ICombatTargetable value) { }

	[CompilerGenerated]
	// RVA: 0x653820 Offset: 0x652220 VA: 0x180653820
	public bool get_IsSearching() { }

	[CompilerGenerated]
	// RVA: 0x653A20 Offset: 0x652420 VA: 0x180653A20
	protected void set_IsSearching(bool value) { }

	[CompilerGenerated]
	// RVA: 0x796420 Offset: 0x794E20 VA: 0x180796420
	public float get_TimeSinceTargetReacquired() { }

	[CompilerGenerated]
	// RVA: 0x796450 Offset: 0x794E50 VA: 0x180796450
	protected void set_TimeSinceTargetReacquired(float value) { }

	[CompilerGenerated]
	// RVA: 0x796410 Offset: 0x794E10 VA: 0x180796410
	public bool get_IsTargetRecentlyVisible() { }

	[CompilerGenerated]
	// RVA: 0x796440 Offset: 0x794E40 VA: 0x180796440
	private void set_IsTargetRecentlyVisible(bool value) { }

	[CompilerGenerated]
	// RVA: 0x796400 Offset: 0x794E00 VA: 0x180796400
	public bool get_IsTargetImmediatelyVisible() { }

	[CompilerGenerated]
	// RVA: 0x796430 Offset: 0x794E30 VA: 0x180796430
	private void set_IsTargetImmediatelyVisible(bool value) { }

	// RVA: 0x7907D0 Offset: 0x78F1D0 VA: 0x1807907D0 Slot: 19
	public override void Awake() { }

	// RVA: 0x795F00 Offset: 0x794900 VA: 0x180795F00
	private void Start() { }

	// RVA: 0x793100 Offset: 0x791B00 VA: 0x180793100 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x794810 Offset: 0x793210 VA: 0x180794810
	public void SetTargetAndEnable_Server(NetworkObject target) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x794950 Offset: 0x793350 VA: 0x180794950
	protected void SetTarget_Client(NetworkConnection conn, NetworkObject target) { }

	// RVA: 0x794BC0 Offset: 0x7935C0 VA: 0x180794BC0 Slot: 34
	protected virtual void SetTarget(NetworkObject target) { }

	// RVA: 0x7904B0 Offset: 0x78EEB0 VA: 0x1807904B0 Slot: 22
	public override void Activate() { }

	// RVA: 0x7935F0 Offset: 0x791FF0 VA: 0x1807935F0 Slot: 25
	public override void Resume() { }

	// RVA: 0x793180 Offset: 0x791B80 VA: 0x180793180 Slot: 24
	public override void Pause() { }

	// RVA: 0x7917B0 Offset: 0x7901B0 VA: 0x1807917B0 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7917E0 Offset: 0x7901E0 VA: 0x1807917E0 Slot: 21
	public override void Disable() { }

	// RVA: 0x7959D0 Offset: 0x7943D0 VA: 0x1807959D0 Slot: 35
	protected virtual void StartCombat() { }

	// RVA: 0x791810 Offset: 0x790210 VA: 0x180791810 Slot: 36
	protected virtual void EndCombat() { }

	// RVA: 0x790930 Offset: 0x78F330 VA: 0x180790930 Slot: 26
	public override void BehaviourUpdate() { }

	// RVA: 0x7962D0 Offset: 0x794CD0 VA: 0x1807962D0
	protected void UpdateTimeout() { }

	// RVA: 0x796200 Offset: 0x794C00 VA: 0x180796200 Slot: 37
	protected virtual void UpdateLookAt() { }

	// RVA: 0x794750 Offset: 0x793150 VA: 0x180794750
	protected void SetMovementSpeed(float speed, string label = "combat", int priority = 5) { }

	// RVA: 0x791A70 Offset: 0x790470 VA: 0x180791A70
	private void EnsureRangedWeaponRoutineIsRunning() { }

	// RVA: 0x792040 Offset: 0x790A40 VA: 0x180792040
	protected Vector3 GetPredictedFutureTargetPosition(float lead_Min = 0, float lead_Max = 2) { }

	// RVA: 0x794650 Offset: 0x793050 VA: 0x180794650 Slot: 29
	protected override void SetDestination(Vector3 position, bool teleportIfFail = True, float successThreshold = 1) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x794E40 Offset: 0x793840 VA: 0x180794E40 Slot: 38
	protected virtual void SetWeapon(string weaponPath) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 39
	protected virtual void OnCurrentWeaponChanged(AvatarWeapon weapon) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x791690 Offset: 0x790090 VA: 0x180791690
	protected void ClearWeapon() { }

	// RVA: 0x7932E0 Offset: 0x791CE0 VA: 0x1807932E0 Slot: 40
	protected virtual bool ReadyToAttack(bool checkTarget = True) { }

	// RVA: 0x792660 Offset: 0x791060 VA: 0x180792660
	private bool IsCurrentWeaponMelee() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x790570 Offset: 0x78EF70 VA: 0x180790570 Slot: 41
	protected virtual void Attack() { }

	// RVA: 0x796000 Offset: 0x794A00 VA: 0x180796000
	protected void SucessfulHit() { }

	[IteratorStateMachine(typeof(CombatBehaviour.<RangedWeaponRoutine>d__79))]
	// RVA: 0x793270 Offset: 0x791C70 VA: 0x180793270
	private IEnumerator RangedWeaponRoutine() { }

	[IteratorStateMachine(typeof(CombatBehaviour.<RepositionToRangedWeaponRange>d__80))]
	// RVA: 0x793400 Offset: 0x791E00 VA: 0x180793400
	private IEnumerator RepositionToRangedWeaponRange() { }

	// RVA: 0x791B10 Offset: 0x790510 VA: 0x180791B10 Slot: 42
	protected virtual float GetIdealRangedWeaponDistance() { }

	// RVA: 0x794F80 Offset: 0x793980 VA: 0x180794F80
	private bool Shoot() { }

	// RVA: 0x794CE0 Offset: 0x7936E0 VA: 0x180794CE0
	private void SetWeaponRaised(bool raised) { }

	// RVA: 0x791450 Offset: 0x78FE50 VA: 0x180791450
	protected void CheckTargetVisibility() { }

	// RVA: 0x792CF0 Offset: 0x7916F0 VA: 0x180792CF0
	public void MarkPlayerVisible() { }

	// RVA: 0x776150 Offset: 0x774B50 VA: 0x180776150
	protected bool IsTargetVisibleThisFrame() { }

	// RVA: 0x7931B0 Offset: 0x791BB0 VA: 0x1807931B0
	protected void ProcessVisionEvent(VisionEventReceipt visionEventReceipt) { }

	// RVA: 0x796060 Offset: 0x794A60 VA: 0x180796060 Slot: 43
	protected virtual void TargetSpotted() { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x792FF0 Offset: 0x7919F0 VA: 0x180792FF0
	public void NotifyServerTargetSeen() { }

	// RVA: 0x792650 Offset: 0x791050 VA: 0x180792650 Slot: 44
	protected virtual float GetSearchTime() { }

	// RVA: 0x795DB0 Offset: 0x7947B0 VA: 0x180795DB0
	private void StartSearching() { }

	// RVA: 0x795F50 Offset: 0x794950 VA: 0x180795F50
	private void StopSearching() { }

	[IteratorStateMachine(typeof(CombatBehaviour.<SearchRoutine>d__93))]
	// RVA: 0x7945E0 Offset: 0x792FE0 VA: 0x1807945E0
	private IEnumerator SearchRoutine() { }

	// RVA: 0x791C70 Offset: 0x790670 VA: 0x180791C70
	private Vector3 GetNextSearchLocation() { }

	// RVA: 0x792A60 Offset: 0x791460 VA: 0x180792A60 Slot: 45
	protected virtual bool IsTargetValid() { }

	// RVA: 0x793470 Offset: 0x791E70 VA: 0x180793470
	private void RepositionToTargetMeleeRange(Vector3 origin) { }

	// RVA: 0x7921E0 Offset: 0x790BE0 VA: 0x1807921E0
	private bool GetRandomReachablePointNear(Vector3 originPoint, float randomRadius, out Vector3 randomPoint, float minDistance = 0) { }

	// RVA: 0x791BE0 Offset: 0x7905E0 VA: 0x180791BE0
	protected float GetMinTargetDistance() { }

	// RVA: 0x791B50 Offset: 0x790550 VA: 0x180791B50
	protected float GetMaxTargetDistance() { }

	// RVA: 0x792730 Offset: 0x791130 VA: 0x180792730
	protected bool IsTargetInRange(Vector3 origin) { }

	// RVA: 0x796330 Offset: 0x794D30 VA: 0x180796330
	public void .ctor() { }

	// RVA: 0x792DB0 Offset: 0x7917B0 VA: 0x180792DB0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x792D90 Offset: 0x791790 VA: 0x180792D90 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x794350 Offset: 0x792D50 VA: 0x180794350
	private void RpcWriter___Server_SetTargetAndEnable_Server_3323014238(NetworkObject target) { }

	// RVA: 0x7938A0 Offset: 0x7922A0 VA: 0x1807938A0
	public void RpcLogic___SetTargetAndEnable_Server_3323014238(NetworkObject target) { }

	// RVA: 0x793D70 Offset: 0x792770 VA: 0x180793D70
	private void RpcReader___Server_SetTargetAndEnable_Server_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x7940C0 Offset: 0x792AC0 VA: 0x1807940C0
	private void RpcWriter___Observers_SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target) { }

	// RVA: 0x7938D0 Offset: 0x7922D0 VA: 0x1807938D0
	protected void RpcLogic___SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target) { }

	// RVA: 0x793C60 Offset: 0x792660 VA: 0x180793C60
	private void RpcReader___Observers_SetTarget_Client_1824087381(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x794480 Offset: 0x792E80 VA: 0x180794480
	private void RpcWriter___Target_SetTarget_Client_1824087381(NetworkConnection conn, NetworkObject target) { }

	// RVA: 0x793E00 Offset: 0x792800 VA: 0x180793E00
	private void RpcReader___Target_SetTarget_Client_1824087381(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x794210 Offset: 0x792C10 VA: 0x180794210
	private void RpcWriter___Observers_SetWeapon_3615296227(string weaponPath) { }

	// RVA: 0x7938F0 Offset: 0x7922F0 VA: 0x1807938F0 Slot: 46
	protected virtual void RpcLogic___SetWeapon_3615296227(string weaponPath) { }

	// RVA: 0x793CE0 Offset: 0x7926E0 VA: 0x180793CE0
	private void RpcReader___Observers_SetWeapon_3615296227(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x793FA0 Offset: 0x7929A0 VA: 0x180793FA0
	private void RpcWriter___Observers_ClearWeapon_2166136261() { }

	// RVA: 0x7936E0 Offset: 0x7920E0 VA: 0x1807936E0
	protected void RpcLogic___ClearWeapon_2166136261() { }

	// RVA: 0x793C20 Offset: 0x792620 VA: 0x180793C20
	private void RpcReader___Observers_ClearWeapon_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x793E80 Offset: 0x792880 VA: 0x180793E80
	private void RpcWriter___Observers_Attack_2166136261() { }

	// RVA: 0x793620 Offset: 0x792020 VA: 0x180793620 Slot: 47
	protected virtual void RpcLogic___Attack_2166136261() { }

	// RVA: 0x793BE0 Offset: 0x7925E0 VA: 0x180793BE0
	private void RpcReader___Observers_Attack_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x792FF0 Offset: 0x7919F0 VA: 0x180792FF0
	private void RpcWriter___Server_NotifyServerTargetSeen_2166136261() { }

	// RVA: 0x793880 Offset: 0x792280 VA: 0x180793880
	public void RpcLogic___NotifyServerTargetSeen_2166136261() { }

	// RVA: 0x793D40 Offset: 0x792740 VA: 0x180793D40
	private void RpcReader___Server_NotifyServerTargetSeen_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x790690 Offset: 0x78F090 VA: 0x180790690 Slot: 48
	protected override void Awake_UserLogic_ScheduleOne.Combat.CombatBehaviour_Assembly-CSharp.dll() { }
}
