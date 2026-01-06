public class PursuitBehaviour : CombatBehaviour // TypeDefIndex: 1852
{
	// Fields
	public const float ARREST_RANGE = 2.75;
	public const float ARREST_TIME = 1.75;
	public const float EXTRA_VISIBILITY_TIME = 2;
	public const float MOVE_SPEED_INVESTIGATING = 0.35;
	public const float MOVE_SPEED_ARRESTING = 0.65;
	public const float MOVE_SPEED_CHASE = 0.9;
	public const float ARREST_MAX_DISTANCE = 15;
	public const int LEAVE_ARREST_CIRCLE_LIMIT = 3;
	[CompilerGenerated]
	private Player <TargetPlayer>k__BackingField; // 0x228
	[Header("Settings")]
	public float ArrestCircle_MaxVisibleDistance; // 0x230
	public float ArrestCircle_MaxOpacity; // 0x234
	[Header("Weapons")]
	public AvatarWeapon Weapon_Baton; // 0x238
	public AvatarWeapon Weapon_Taser; // 0x240
	public AvatarWeapon Weapon_Gun; // 0x248
	protected bool arrestingEnabled; // 0x250
	protected float currentPursuitLevelDuration; // 0x254
	protected float timeWithinArrestRange; // 0x258
	protected float distanceOnPursuitStart; // 0x25C
	private PoliceOfficer officer; // 0x260
	private bool targetWasDrivingOnPursuitStart; // 0x268
	private bool wasInArrestCircleLastFrame; // 0x269
	private int leaveArrestCircleCount; // 0x26C
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted; // 0x270
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.PursuitBehaviourAssembly-CSharp.dll_Excuted; // 0x271

	// Properties
	public Player TargetPlayer { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0
	public Player get_TargetPlayer() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0
	protected void set_TargetPlayer(Player value) { }

	// RVA: 0x76B540 Offset: 0x769F40 VA: 0x18076B540 Slot: 19
	public override void Awake() { }

	// RVA: 0x76BDA0 Offset: 0x76A7A0 VA: 0x18076BDA0
	private void OnDestroy() { }

	// RVA: 0x76BFC0 Offset: 0x76A9C0 VA: 0x18076BFC0 Slot: 34
	protected override void SetTarget(NetworkObject target) { }

	// RVA: 0x76B2F0 Offset: 0x769CF0 VA: 0x18076B2F0 Slot: 22
	public override void Activate() { }

	// RVA: 0x76BF00 Offset: 0x76A900 VA: 0x18076BF00 Slot: 25
	public override void Resume() { }

	// RVA: 0x76B960 Offset: 0x76A360 VA: 0x18076B960 Slot: 21
	public override void Disable() { }

	// RVA: 0x76B590 Offset: 0x769F90 VA: 0x18076B590 Slot: 26
	public override void BehaviourUpdate() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x76BAF0 Offset: 0x76A4F0 VA: 0x18076BAF0 Slot: 45
	protected override bool IsTargetValid() { }

	// RVA: 0x76CCD0 Offset: 0x76B6D0 VA: 0x18076CCD0 Slot: 49
	protected virtual void UpdateInvestigatingBehaviour() { }

	// RVA: 0x76C2D0 Offset: 0x76ACD0 VA: 0x18076C2D0 Slot: 50
	protected virtual void UpdateArrestBehaviour() { }

	// RVA: 0x76CEA0 Offset: 0x76B8A0 VA: 0x18076CEA0 Slot: 51
	protected virtual void UpdateNonLethalBehaviour() { }

	// RVA: 0x76CDC0 Offset: 0x76B7C0 VA: 0x18076CDC0 Slot: 52
	protected virtual void UpdateLethalBehaviour() { }

	// RVA: 0x76BBD0 Offset: 0x76A5D0 VA: 0x18076BBD0 Slot: 39
	protected override void OnCurrentWeaponChanged(AvatarWeapon weapon) { }

	// RVA: 0x76BAE0 Offset: 0x76A4E0 VA: 0x18076BAE0 Slot: 42
	protected override float GetIdealRangedWeaponDistance() { }

	// RVA: 0x76CA30 Offset: 0x76B430 VA: 0x18076CA30
	private void UpdateArrest(float tick) { }

	// RVA: 0x76B6F0 Offset: 0x76A0F0 VA: 0x18076B6F0
	private void ClearSpeedControls() { }

	// RVA: 0x76B990 Offset: 0x76A390 VA: 0x18076B990 Slot: 36
	protected override void EndCombat() { }

	// RVA: 0x76C690 Offset: 0x76B090 VA: 0x18076C690 Slot: 53
	protected virtual void UpdateArrestCircle() { }

	// RVA: 0x76BEF0 Offset: 0x76A8F0 VA: 0x18076BEF0
	public void ResetArrestProgress() { }

	// RVA: 0x76BF50 Offset: 0x76A950 VA: 0x18076BF50
	private void SetArrestCircleAlpha(float alpha) { }

	// RVA: 0x76BF80 Offset: 0x76A980 VA: 0x18076BF80
	private void SetArrestCircleColor(Color col) { }

	// RVA: 0x76BEE0 Offset: 0x76A8E0 VA: 0x18076BEE0
	private void OnThirdPartyVisionEvent(VisionEventReceipt receipt) { }

	// RVA: 0x76C260 Offset: 0x76AC60 VA: 0x18076C260 Slot: 43
	protected override void TargetSpotted() { }

	// RVA: 0x76CF80 Offset: 0x76B980 VA: 0x18076CF80
	public void .ctor() { }

	// RVA: 0x76BBB0 Offset: 0x76A5B0 VA: 0x18076BBB0 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x76BB90 Offset: 0x76A590 VA: 0x18076BB90 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x76B340 Offset: 0x769D40 VA: 0x18076B340 Slot: 54
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.PursuitBehaviour_Assembly-CSharp.dll() { }
}
