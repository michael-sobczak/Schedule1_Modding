public class Bed : NetworkBehaviour // TypeDefIndex: 3219
{
	// Fields
	public const int MIN_SLEEP_TIME = 1800;
	public const float SLEEP_TIME_SCALE = 1;
	[SerializeField]
	[Header("References")]
	protected InteractableObject intObj; // 0x118
	public EmployeeHome EmployeeStationThing; // 0x120
	public MeshRenderer BlanketMesh; // 0x128
	[Header("Materials")]
	public Material DefaultBlanket; // 0x130
	public Material BotanistBlanket; // 0x138
	public Material ChemistBlanket; // 0x140
	public Material PackagerBlanket; // 0x148
	public Material CleanerBlanket; // 0x150
	private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted; // 0x158
	private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted; // 0x159

	// Properties
	public Employee AssignedEmployee { get; }

	// Methods

	// RVA: 0x9C38D0 Offset: 0x9C22D0 VA: 0x1809C38D0
	public Employee get_AssignedEmployee() { }

	// RVA: 0x9C2F80 Offset: 0x9C1980 VA: 0x1809C2F80 Slot: 19
	public override void Awake() { }

	// RVA: 0x9C35E0 Offset: 0x9C1FE0 VA: 0x1809C35E0
	public void Hovered() { }

	// RVA: 0x9C37C0 Offset: 0x9C21C0 VA: 0x1809C37C0
	public void Interacted() { }

	// RVA: 0x9C30C0 Offset: 0x9C1AC0 VA: 0x1809C30C0
	private bool CanSleep(out string noSleepReason) { }

	// RVA: 0x9C2E70 Offset: 0x9C1870 VA: 0x1809C2E70
	public void UpdateMaterial() { }

	// RVA: 0x5FED30 Offset: 0x5FD730 VA: 0x1805FED30
	public void .ctor() { }

	// RVA: 0x9C38B0 Offset: 0x9C22B0 VA: 0x1809C38B0 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0x9C3890 Offset: 0x9C2290 VA: 0x1809C3890 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x9C2E70 Offset: 0x9C1870 VA: 0x1809C2E70
	private void Awake_UserLogic_ScheduleOne.ObjectScripts.Bed_Assembly-CSharp.dll() { }
}
