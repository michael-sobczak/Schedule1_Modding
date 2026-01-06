public class EntityVisibility : NetworkBehaviour // TypeDefIndex: 823
{
	// Fields
	public const float MAX_VISIBLITY = 100;
	public List<VisibilityAttribute> ActiveAttributes; // 0x118
	[CompilerGenerated]
	private List<EntityVisualState> <VisualStates>k__BackingField; // 0x120
	[Header("Settings")]
	public LayerMask VisibilityCheckMask; // 0x128
	[Header("References")]
	public Transform CentralVisibilityPoint; // 0x130
	public List<Transform> VisibilityPoints; // 0x138
	private VisibilityAttribute environmentalVisibility; // 0x140
	private Dictionary<string, Coroutine> removalRoutinesDict; // 0x148
	private Dictionary<string, float> maxPointsChangesByUniquenessCode; // 0x150
	private List<RaycastHit> hits; // 0x158
	private bool NetworkInitialize___EarlyScheduleOne.Vision.EntityVisibilityAssembly-CSharp.dll_Excuted; // 0x160
	private bool NetworkInitialize__LateScheduleOne.Vision.EntityVisibilityAssembly-CSharp.dll_Excuted; // 0x161

	// Properties
	public virtual float CurrentVisibility { get; }
	public virtual float Suspiciousness { get; }
	public List<EntityVisualState> VisualStates { get; set; }
	public Vector3 CenterPoint { get; }

	// Methods

	// RVA: 0x5A1580 Offset: 0x59FF80 VA: 0x1805A1580 Slot: 19
	public virtual float get_CurrentVisibility() { }

	// RVA: 0x5A1590 Offset: 0x59FF90 VA: 0x1805A1590 Slot: 20
	public virtual float get_Suspiciousness() { }

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public List<EntityVisualState> get_VisualStates() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	protected void set_VisualStates(List<EntityVisualState> value) { }

	// RVA: 0x5A1460 Offset: 0x59FE60 VA: 0x1805A1460
	public Vector3 get_CenterPoint() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 21
	public override void Awake() { }

	// RVA: 0x5A0750 Offset: 0x59F150 VA: 0x1805A0750 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0x59FF50 Offset: 0x59E950 VA: 0x18059FF50
	private float CalculateVisibility() { }

	// RVA: 0x5A04A0 Offset: 0x59EEA0 VA: 0x1805A04A0
	public VisibilityAttribute GetAttribute(string name) { }

	// RVA: 0x5A1210 Offset: 0x59FC10 VA: 0x1805A1210
	private void UpdateEnvironmentalVisibilityAttribute() { }

	// RVA: 0x59EFF0 Offset: 0x59D9F0 VA: 0x18059EFF0
	public float CalculateExposureToPoint(Vector3 point, float checkRange = 50, NPC checkingNPC) { }

	[ServerRpc(RunLocally = True)]
	// RVA: 0x59EF50 Offset: 0x59D950 VA: 0x18059EF50
	public void ApplyState(string label, EVisualState state, float autoRemoveAfter = 0) { }

	[ServerRpc(RunLocally = True)]
	// RVA: 0x5A0800 Offset: 0x59F200 VA: 0x1805A0800
	public void RemoveState(string label, float delay = 0) { }

	// RVA: 0x5A0580 Offset: 0x59EF80 VA: 0x1805A0580
	public EntityVisualState GetState(string label) { }

	// RVA: 0x5A0390 Offset: 0x59ED90 VA: 0x1805A0390
	public void ClearStates() { }

	// RVA: 0x5A12B0 Offset: 0x59FCB0 VA: 0x1805A12B0
	public void .ctor() { }

	// RVA: 0x5A0680 Offset: 0x59F080 VA: 0x1805A0680 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x5A0660 Offset: 0x59F060 VA: 0x1805A0660 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x5A0E50 Offset: 0x59F850 VA: 0x1805A0E50
	private void RpcWriter___Server_ApplyState_2910447583(string label, EVisualState state, float autoRemoveAfter = 0) { }

	// RVA: 0x5A0840 Offset: 0x59F240 VA: 0x1805A0840
	public void RpcLogic___ApplyState_2910447583(string label, EVisualState state, float autoRemoveAfter = 0) { }

	// RVA: 0x5A0CE0 Offset: 0x59F6E0 VA: 0x1805A0CE0
	private void RpcReader___Server_ApplyState_2910447583(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x5A1020 Offset: 0x59FA20 VA: 0x1805A1020
	private void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0) { }

	// RVA: 0x5A0A90 Offset: 0x59F490 VA: 0x1805A0A90
	public void RpcLogic___RemoveState_606697822(string label, float delay = 0) { }

	// RVA: 0x5A0DB0 Offset: 0x59F7B0 VA: 0x1805A0DB0
	private void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 24
	protected virtual void Awake_UserLogic_ScheduleOne.Vision.EntityVisibility_Assembly-CSharp.dll() { }
}
