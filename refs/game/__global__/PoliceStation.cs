public class PoliceStation : NPCEnterableBuilding // TypeDefIndex: 3374
{
	// Fields
	public static List<PoliceStation> PoliceStations; // 0x0
	public int VehicleLimit; // 0x50
	[Header("References")]
	public Transform SpawnPoint; // 0x58
	public Transform[] VehicleSpawnPoints; // 0x60
	public Transform[] PossessedVehicleSpawnPoints; // 0x68
	[Header("Prefabs")]
	public LandVehicle[] PoliceVehiclePrefabs; // 0x70
	public List<PoliceOfficer> OfficerPool; // 0x78
	[CompilerGenerated]
	private float <TimeSinceLastDispatch>k__BackingField; // 0x80
	[SerializeField]
	private List<LandVehicle> deployedVehicles; // 0x88

	// Properties
	public float TimeSinceLastDispatch { get; set; }
	private int deployedVehicleCount { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	public float get_TimeSinceLastDispatch() { }

	[CompilerGenerated]
	// RVA: 0xA546B0 Offset: 0xA530B0 VA: 0x180A546B0
	private void set_TimeSinceLastDispatch(float value) { }

	// RVA: 0xA54580 Offset: 0xA52F80 VA: 0x180A54580
	private int get_deployedVehicleCount() { }

	// RVA: 0xA53260 Offset: 0xA51C60 VA: 0x180A53260 Slot: 7
	protected override void Awake() { }

	// RVA: 0xA540F0 Offset: 0xA52AF0 VA: 0x180A540F0
	private void OnDestroy() { }

	// RVA: 0xA543E0 Offset: 0xA52DE0 VA: 0x180A543E0
	private void Update() { }

	// RVA: 0xA533C0 Offset: 0xA51DC0 VA: 0x180A533C0
	private void CleanVehicleList() { }

	// RVA: 0xA53860 Offset: 0xA52260 VA: 0x180A53860
	public void Dispatch(int requestedOfficerCount, Player targetPlayer, PoliceStation.EDispatchType type = 0, bool beginAsSighted = False) { }

	// RVA: 0xA541C0 Offset: 0xA52BC0 VA: 0x180A541C0
	public PoliceOfficer PullOfficer() { }

	// RVA: 0xA534C0 Offset: 0xA51EC0 VA: 0x180A534C0
	public LandVehicle CreateVehicle() { }

	// RVA: 0xA53EF0 Offset: 0xA528F0 VA: 0x180A53EF0 Slot: 8
	public override void NPCEnteredBuilding(NPC npc) { }

	// RVA: 0xA54030 Offset: 0xA52A30 VA: 0x180A54030 Slot: 9
	public override void NPCExitedBuilding(NPC npc) { }

	// RVA: 0xA53E70 Offset: 0xA52870 VA: 0x180A53E70
	public static PoliceStation GetClosestPoliceStation(Vector3 point) { }

	// RVA: 0xA544B0 Offset: 0xA52EB0 VA: 0x180A544B0
	public void .ctor() { }

	// RVA: 0xA54420 Offset: 0xA52E20 VA: 0x180A54420
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xA54280 Offset: 0xA52C80 VA: 0x180A54280
	internal static bool <CreateVehicle>g__IsSpawnPointAvailable|21_0(Transform spawnPoint) { }
}
