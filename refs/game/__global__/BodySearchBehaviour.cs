public class BodySearchBehaviour : Behaviour // TypeDefIndex: 1772
{
	// Fields
	public const EStealthLevel MAX_STEALTH_LEVEL = 0;
	public const float BODY_SEARCH_RANGE = 2;
	public const float MAX_SEARCH_TIME = 15;
	public const float MAX_TIME_OUTSIDE_RANGE = 4;
	public const float RANGE_TO_ESCALATE = 15;
	public const float MOVE_SPEED = 0.15;
	public const float BODY_SEARCH_COOLDOWN = 30;
	[CompilerGenerated]
	private Player <TargetPlayer>k__BackingField; // 0x168
	[Header("Settings")]
	public float ArrestCircle_MaxVisibleDistance; // 0x170
	public float ArrestCircle_MaxOpacity; // 0x174
	public bool ShowPostSearchDialogue; // 0x178
	[Header("Item of interest settings")]
	public EStealthLevel MaxStealthLevel; // 0x17C
	private PoliceOfficer officer; // 0x180
	private float targetDistanceOnStart; // 0x188
	private float searchTime; // 0x18C
	private bool hasBeenInRange; // 0x190
	private float timeOutsideRange; // 0x194
	private float timeWithinSearchRange; // 0x198
	private float timeSinceCantReach; // 0x19C
	[Header("Events")]
	public UnityEvent onSearchComplete_Clear; // 0x1A0
	public UnityEvent onSearchComplete_ItemsFound; // 0x1A8
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted; // 0x1B0
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.BodySearchBehaviourAssembly-CSharp.dll_Excuted; // 0x1B1

	// Properties
	public static float BODY_SEARCH_TIME { get; }
	public Player TargetPlayer { get; set; }
	private DialogueDatabase dialogueDatabase { get; }

	// Methods

	// RVA: 0x735F80 Offset: 0x734980 VA: 0x180735F80
	public static float get_BODY_SEARCH_TIME() { }

	[CompilerGenerated]
	// RVA: 0x599610 Offset: 0x598010 VA: 0x180599610
	public Player get_TargetPlayer() { }

	[CompilerGenerated]
	// RVA: 0x70A660 Offset: 0x709060 VA: 0x18070A660
	protected void set_TargetPlayer(Player value) { }

	// RVA: 0x736020 Offset: 0x734A20 VA: 0x180736020
	private DialogueDatabase get_dialogueDatabase() { }

	// RVA: 0x733160 Offset: 0x731B60 VA: 0x180733160 Slot: 19
	public override void Awake() { }

	// RVA: 0x732CF0 Offset: 0x7316F0 VA: 0x180732CF0 Slot: 22
	public override void Activate() { }

	// RVA: 0x734590 Offset: 0x732F90 VA: 0x180734590 Slot: 25
	public override void Resume() { }

	// RVA: 0x733A50 Offset: 0x732450 VA: 0x180733A50 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7344D0 Offset: 0x732ED0 VA: 0x1807344D0 Slot: 24
	public override void Pause() { }

	// RVA: 0x733280 Offset: 0x731C80 VA: 0x180733280 Slot: 26
	public override void BehaviourUpdate() { }

	// RVA: 0x735BB0 Offset: 0x7345B0 VA: 0x180735BB0
	private void UpdateSearch() { }

	// RVA: 0x7357D0 Offset: 0x7341D0 VA: 0x1807357D0 Slot: 34
	protected virtual void UpdateMovement() { }

	// RVA: 0x734C50 Offset: 0x733650 VA: 0x180734C50
	private void SearchClean() { }

	// RVA: 0x734DF0 Offset: 0x7337F0 VA: 0x180734DF0
	private void SearchFail() { }

	// RVA: 0x7353C0 Offset: 0x733DC0 VA: 0x1807353C0
	private void UpdateEscalation() { }

	// RVA: 0x7356D0 Offset: 0x7340D0 VA: 0x1807356D0 Slot: 35
	protected virtual void UpdateLookAt() { }

	// RVA: 0x735000 Offset: 0x733A00 VA: 0x180735000 Slot: 36
	protected virtual void UpdateCircle() { }

	// RVA: 0x734F90 Offset: 0x733990 VA: 0x180734F90
	private void SetArrestCircleAlpha(float alpha) { }

	// RVA: 0x734FC0 Offset: 0x7339C0 VA: 0x180734FC0
	private void SetArrestCircleColor(Color col) { }

	// RVA: 0x734040 Offset: 0x732A40 VA: 0x180734040
	private Vector3 GetNewDestination() { }

	// RVA: 0x733460 Offset: 0x731E60 VA: 0x180733460
	private void ClearSpeedControls() { }

	// RVA: 0x734280 Offset: 0x732C80 VA: 0x180734280
	private bool IsTargetValid(Player player) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x733020 Offset: 0x731A20 VA: 0x180733020 Slot: 37
	public virtual void AssignTarget(NetworkConnection conn, NetworkObject target) { }

	// RVA: 0x733B80 Offset: 0x732580 VA: 0x180733B80 Slot: 38
	public virtual bool DoesPlayerContainItemsOfInterest() { }

	// RVA: 0x733520 Offset: 0x731F20 VA: 0x180733520 Slot: 39
	public virtual void ConcludeSearch(bool clear) { }

	// RVA: 0x733E30 Offset: 0x732830 VA: 0x180733E30 Slot: 40
	public virtual void Escalate() { }

	// RVA: 0x734400 Offset: 0x732E00 VA: 0x180734400 Slot: 41
	public virtual void NoItemsOfInterestFound() { }

	// RVA: 0x735F50 Offset: 0x734950 VA: 0x180735F50
	public void .ctor() { }

	// RVA: 0x734360 Offset: 0x732D60 VA: 0x180734360 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x734330 Offset: 0x732D30 VA: 0x180734330 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7349E0 Offset: 0x7333E0 VA: 0x1807349E0
	private void RpcWriter___Observers_AssignTarget_1824087381(NetworkConnection conn, NetworkObject target) { }

	// RVA: 0x734760 Offset: 0x733160 VA: 0x180734760 Slot: 42
	public virtual void RpcLogic___AssignTarget_1824087381(NetworkConnection conn, NetworkObject target) { }

	// RVA: 0x734950 Offset: 0x733350 VA: 0x180734950
	private void RpcReader___Observers_AssignTarget_1824087381(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x733060 Offset: 0x731A60 VA: 0x180733060 Slot: 43
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.BodySearchBehaviour_Assembly-CSharp.dll() { }
}
