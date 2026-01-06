public class SmokeBreakBehaviour : Behaviour // TypeDefIndex: 1861
{
	// Fields
	[Header("Components")]
	public SmokeCigarette SmokeCigarette; // 0x168
	[Header("Smoke Break Settings")]
	public Vector2Int MinMaxSmokeBreak; // 0x170
	public float maxDistanceToSmokeLocation; // 0x178
	[Header("Smoking Locations")]
	public List<Transform> SmokeBreakLocations; // 0x180
	[Header("Debug")]
	[SerializeField]
	private bool _debugMode; // 0x188
	[SerializeField]
	private int _ocationOverride; // 0x18C
	[SerializeField]
	private bool _showMaxDistance; // 0x190
	[SerializeField]
	private bool _showLocationGizmos; // 0x191
	[SerializeField]
	private bool _showLookAtGizmos; // 0x192
	private int _smokeBreakDuration; // 0x194
	private Transform _currentSmokeLocation; // 0x198
	private bool NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.SmokeBreakBehaviourAssembly-CSharp.dll_Excuted; // 0x1A0
	private bool NetworkInitialize__LateScheduleOne.NPCs.Behaviour.SmokeBreakBehaviourAssembly-CSharp.dll_Excuted; // 0x1A1

	// Methods

	// RVA: 0x772ED0 Offset: 0x7718D0 VA: 0x180772ED0 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0x772FA0 Offset: 0x7719A0 VA: 0x180772FA0
	private void SetupEvents() { }

	// RVA: 0x772CE0 Offset: 0x7716E0 VA: 0x180772CE0 Slot: 20
	public override void Enable() { }

	// RVA: 0x772310 Offset: 0x770D10 VA: 0x180772310 Slot: 22
	public override void Activate() { }

	// RVA: 0x772C10 Offset: 0x771610 VA: 0x180772C10 Slot: 23
	public override void Deactivate() { }

	// RVA: 0x7728F0 Offset: 0x7712F0 VA: 0x1807728F0
	private void BeginSmokeBreak() { }

	// RVA: 0x772DA0 Offset: 0x7717A0 VA: 0x180772DA0
	private void EndSmokeBreak() { }

	// RVA: 0x772BF0 Offset: 0x7715F0 VA: 0x180772BF0
	private void CheckSmokeBreakEnd() { }

	// RVA: 0x773360 Offset: 0x771D60 VA: 0x180773360
	private void UpdateSmokeBreakDuration(int amount) { }

	// RVA: 0x773390 Offset: 0x771D90 VA: 0x180773390 Slot: 30
	protected override void WalkCallback(NPCMovement.WalkResult result) { }

	// RVA: 0x772EF0 Offset: 0x7718F0 VA: 0x180772EF0
	private void OnTimeSkipped(int skippedTimeInMintues) { }

	// RVA: 0x772EA0 Offset: 0x7718A0 VA: 0x180772EA0
	private void OnHourPass() { }

	[Button]
	// RVA: 0x772AF0 Offset: 0x7714F0 VA: 0x180772AF0
	public void ChangeLocation() { }

	[Button]
	// RVA: 0x7722F0 Offset: 0x770CF0 VA: 0x1807722F0
	public void ActivateSmokeBreak() { }

	// RVA: 0x7733D0 Offset: 0x771DD0 VA: 0x1807733D0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x773210 Offset: 0x771C10 VA: 0x180773210
	private bool <Activate>b__14_0(Transform loc) { }

	// RVA: 0x772E80 Offset: 0x771880 VA: 0x180772E80 Slot: 31
	public override void NetworkInitialize___Early() { }

	// RVA: 0x772E60 Offset: 0x771860 VA: 0x180772E60 Slot: 32
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5980E0 Offset: 0x596AE0 VA: 0x1805980E0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x7305E0 Offset: 0x72EFE0 VA: 0x1807305E0 Slot: 19
	public override void Awake() { }
}
