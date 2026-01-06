public class SewerGoblin : NPC // TypeDefIndex: 1756
{
	// Fields
	public const int COOLDOWN_HOURS_BETWEEN_DEPLOYS = 12;
	public const float HOURLY_DEPLOY_CHANCE = 0.1;
	public const float NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT = 0.5;
	public const float RETREAT_CHANCE_AFTER_HIT = 0.3;
	public const int MAX_CANCELLED_RETRIEVE_ATTEMPTS = 3;
	[CompilerGenerated]
	private Player <TargetPlayer>k__BackingField; // 0x2F0
	[CompilerGenerated]
	private SewerGoblin.ESewerGoblinState <CurrentState>k__BackingField; // 0x2F8
	[CompilerGenerated]
	private int <HoursSinceLastDeploy>k__BackingField; // 0x2FC
	[Header("References")]
	public NPCEnterableBuilding SewerHidingBuilding; // 0x300
	public NPCEvent_StayInBuilding StayInBuildingEvent; // 0x308
	public ItemDefinition PacifyItem; // 0x310
	public SewerGoblinRetrieveBehaviour RetrieveBehaviour; // 0x318
	public AudioSourceController ExitSound; // 0x320
	[HideInInspector]
	public int cancelledRetrieveAttempts; // 0x328
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.CharacterClasses.SewerGoblinAssembly-CSharp.dll_Excuted; // 0x32C
	private bool NetworkInitialize__LateScheduleOne.NPCs.CharacterClasses.SewerGoblinAssembly-CSharp.dll_Excuted; // 0x32D

	// Properties
	public Player TargetPlayer { get; set; }
	public SewerGoblin.ESewerGoblinState CurrentState { get; set; }
	public int HoursSinceLastDeploy { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x640F40 Offset: 0x63F940 VA: 0x180640F40
	public Player get_TargetPlayer() { }

	[CompilerGenerated]
	// RVA: 0x641630 Offset: 0x640030 VA: 0x180641630
	private void set_TargetPlayer(Player value) { }

	[CompilerGenerated]
	// RVA: 0x7447D0 Offset: 0x7431D0 VA: 0x1807447D0
	public SewerGoblin.ESewerGoblinState get_CurrentState() { }

	[CompilerGenerated]
	// RVA: 0x7447F0 Offset: 0x7431F0 VA: 0x1807447F0
	private void set_CurrentState(SewerGoblin.ESewerGoblinState value) { }

	[CompilerGenerated]
	// RVA: 0x7447E0 Offset: 0x7431E0 VA: 0x1807447E0
	public int get_HoursSinceLastDeploy() { }

	[CompilerGenerated]
	// RVA: 0x744800 Offset: 0x743200 VA: 0x180744800
	public void set_HoursSinceLastDeploy(int value) { }

	// RVA: 0x7432A0 Offset: 0x741CA0 VA: 0x1807432A0 Slot: 65
	public override void Awake() { }

	// RVA: 0x743FF0 Offset: 0x7429F0 VA: 0x180743FF0 Slot: 71
	protected override void Start() { }

	// RVA: 0x7444D0 Offset: 0x742ED0 VA: 0x1807444D0
	private void Update() { }

	// RVA: 0x743A60 Offset: 0x742460 VA: 0x180743A60
	private void OnMinPass() { }

	// RVA: 0x743A30 Offset: 0x742430 VA: 0x180743A30
	private void OnHourPass() { }

	// RVA: 0x7435D0 Offset: 0x741FD0 VA: 0x1807435D0
	public void DeployToPlayer(Player player) { }

	// RVA: 0x742EA0 Offset: 0x7418A0 VA: 0x180742EA0
	private void AttackTarget() { }

	// RVA: 0x743D40 Offset: 0x742740 VA: 0x180743D40
	public void Retreat() { }

	// RVA: 0x743850 Offset: 0x742250 VA: 0x180743850 Slot: 87
	protected override void EnterBuilding(string buildingGUID, int doorIndex) { }

	// RVA: 0x7438A0 Offset: 0x7422A0 VA: 0x1807438A0 Slot: 88
	protected override void ExitBuilding(NPCEnterableBuilding building) { }

	// RVA: 0x743570 Offset: 0x741F70 VA: 0x180743570
	public void DeployToLocalPlayer() { }

	// RVA: 0x743CB0 Offset: 0x7426B0 VA: 0x180743CB0
	private void OnSuccesfulCombatHit() { }

	// RVA: 0x7433B0 Offset: 0x741DB0 VA: 0x1807433B0
	private bool CanBeginRetieve() { }

	// RVA: 0x7432F0 Offset: 0x741CF0 VA: 0x1807432F0
	private void BeginRetrieve() { }

	// RVA: 0x743C10 Offset: 0x742610 VA: 0x180743C10
	private void OnRetrieveCancel() { }

	// RVA: 0x743CA0 Offset: 0x7426A0 VA: 0x180743CA0
	private void OnRetrieveSuccess() { }

	// RVA: 0x743930 Offset: 0x742330 VA: 0x180743930
	public bool IsPlayerValidTarget(Player player) { }

	// RVA: 0x7438E0 Offset: 0x7422E0 VA: 0x1807438E0
	public bool IsPlayerHoldingPacifyItem(Player player) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 82
	public override void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force) { }

	// RVA: 0x743D10 Offset: 0x742710 VA: 0x180743D10
	private void OnTakeDamage(float damageAmount) { }

	// RVA: 0x701620 Offset: 0x700020 VA: 0x180701620
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x744380 Offset: 0x742D80 VA: 0x180744380
	private bool <OnMinPass>b__27_0(Player player) { }

	[CompilerGenerated]
	// RVA: 0x744390 Offset: 0x742D90 VA: 0x180744390
	private float <Retreat>b__31_0(StaticDoor door) { }

	// RVA: 0x743A10 Offset: 0x742410 VA: 0x180743A10 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x7439F0 Offset: 0x7423F0 VA: 0x1807439F0 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x742F10 Offset: 0x741910 VA: 0x180742F10 Slot: 111
	protected override void Awake_UserLogic_ScheduleOne.NPCs.CharacterClasses.SewerGoblin_Assembly-CSharp.dll() { }
}
