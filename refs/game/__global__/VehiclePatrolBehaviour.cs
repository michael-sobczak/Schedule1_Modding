public class VehiclePatrolBehaviour : Behaviour // TypeDefIndex: 1864
{
	// Fields
	public const float MAX_CONSECUTIVE_PATHING_FAILURES = 5;
	public const float PROGRESSION_THRESHOLD = 10;
	public int CurrentWaypoint; // 0x168
	[Header("Settings")]
	public VehiclePatrolRoute Route; // 0x170
	public LandVehicle Vehicle; // 0x178
	private bool aggressiveDrivingEnabled; // 0x180
	private int consecutivePathingFailures; // 0x184
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted; // 0x188
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviourAssembly-CSharp.dll_Excuted; // 0x189

	// Properties
	private bool isDriving { get; }
	private VehicleAgent Agent { get; }

	// Methods

	// RVA: 0x774E40 Offset: 0x773840 VA: 0x180774E40
	private bool get_isDriving() { }

	// RVA: 0x774E10 Offset: 0x773810 VA: 0x180774E10
	private VehicleAgent get_Agent() { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }

	// RVA: 0x774330 Offset: 0x772D30 VA: 0x180774330 Slot: 22
	public override void Activate() { }

	// RVA: 0x774C00 Offset: 0x773600 VA: 0x180774C00 Slot: 25
	public override void Resume() { }

	// RVA: 0x774AA0 Offset: 0x7734A0 VA: 0x180774AA0 Slot: 24
	public override void Pause() { }

	// RVA: 0x774350 Offset: 0x772D50 VA: 0x180774350 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	public void SetRoute(VehiclePatrolRoute route) { }

	// RVA: 0x774C20 Offset: 0x773620 VA: 0x180774C20
	private void StartPatrol() { }

	// RVA: 0x7747B0 Offset: 0x7731B0 VA: 0x1807747B0 Slot: 28
	public override void OnActiveTick() { }

	// RVA: 0x7744B0 Offset: 0x772EB0 VA: 0x1807744B0
	private void DriveTo(Vector3 location) { }

	// RVA: 0x774730 Offset: 0x773130 VA: 0x180774730
	private void NavigationCallback(VehicleAgent.ENavigationResult status) { }

	// RVA: 0x7745D0 Offset: 0x772FD0 VA: 0x1807745D0
	private bool IsAsCloseAsPossible(Vector3 pos, out Vector3 closestPosition) { }

	// RVA: 0x774E00 Offset: 0x773800 VA: 0x180774E00
	public void .ctor() { }

	// RVA: 0x774790 Offset: 0x773190 VA: 0x180774790 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x748B90 Offset: 0x747590 VA: 0x180748B90 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x770780 Offset: 0x76F180 VA: 0x180770780 Slot: 34
	protected override void Awake_UserLogic_ScheduleOne.NPCs.Behaviour.VehiclePatrolBehaviour_Assembly-CSharp.dll() { }
}
