public class SewerMushrooms : NetworkBehaviour // TypeDefIndex: 3367
{
	// Fields
	[Header("Mushroom Spawning")]
	public ItemPickup MushroomObjectPrefab; // 0x118
	public SewerMushrooms.SewerMushroomSpawnSettings MushroomSpawnSettings; // 0x120
	public List<Transform> MushroomAreas; // 0x128
	public List<Transform> MushroomLocations; // 0x130
	[Header("Development & Debugging")]
	[SerializeField]
	private bool _debugMode; // 0x138
	[SyncObject]
	private readonly SyncList<int> _activeMushroomLocationIndices; // 0x140
	private Dictionary<int, ItemPickup> _spawnedMushroomItems; // 0x148
	private List<int> _availableMushroomSpawnLocationIndices; // 0x150
	private List<int> _mushroomSpawnLocationAmountPerArea; // 0x158
	private int _lastMushroomSpanwnLocationIndex; // 0x160
	private bool NetworkInitialize___EarlyScheduleOne.Map.SewerMushroomsAssembly-CSharp.dll_Excuted; // 0x164
	private bool NetworkInitialize__LateScheduleOne.Map.SewerMushroomsAssembly-CSharp.dll_Excuted; // 0x165

	// Methods

	// RVA: 0xA5A700 Offset: 0xA59100 VA: 0x180A5A700 Slot: 19
	public override void Awake() { }

	// RVA: 0xA5B4E0 Offset: 0xA59EE0 VA: 0x180A5B4E0 Slot: 6
	public override void OnStartServer() { }

	// RVA: 0xA5BC80 Offset: 0xA5A680 VA: 0x180A5BC80
	private void SetupEvents() { }

	// RVA: 0xA5B1C0 Offset: 0xA59BC0 VA: 0x180A5B1C0
	private void MushroomIndicesChanged(SyncListOperation op, int index, int oldItem, int newItem, bool asServer) { }

	// RVA: 0xA5BDD0 Offset: 0xA5A7D0 VA: 0x180A5BDD0
	private void SpawnMushroom(int locationIndex) { }

	// RVA: 0xA5A920 Offset: 0xA59320 VA: 0x180A5A920
	private void DespawnMushroom(int locationIndex) { }

	[ServerRpc]
	// RVA: 0xA5BC70 Offset: 0xA5A670 VA: 0x180A5BC70
	private void SetMushroomSpawnLocationAvailable(int locationIndex) { }

	// RVA: 0xA5B640 Offset: 0xA5A040 VA: 0x180A5B640
	private void RegenerateMushrooms() { }

	// RVA: 0xA5AD70 Offset: 0xA59770 VA: 0x180A5AD70
	public void Load(SewerData sewerData) { }

	// RVA: 0xA5AA10 Offset: 0xA59410 VA: 0x180A5AA10
	public List<int> GetActiveMushroomLocationIndices() { }

	// RVA: 0xA5AB50 Offset: 0xA59550 VA: 0x180A5AB50
	private int GetNextSpawnLocation() { }

	// RVA: 0xA5A550 Offset: 0xA58F50 VA: 0x180A5A550
	private bool AreLocationsInSameArea(int locationIndexA, int locationIndexB) { }

	// RVA: 0xA5A890 Offset: 0xA59290 VA: 0x180A5A890
	private bool CanSpawnMushroom() { }

	// RVA: 0xA5AA80 Offset: 0xA59480 VA: 0x180A5AA80
	private int GetLocationIndex(int index) { }

	// RVA: 0xA5C1C0 Offset: 0xA5ABC0 VA: 0x180A5C1C0
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0xA5C160 Offset: 0xA5AB60 VA: 0x180A5C160
	private void <Load>b__19_0(int x) { }

	// RVA: 0xA5B410 Offset: 0xA59E10 VA: 0x180A5B410 Slot: 20
	public override void NetworkInitialize___Early() { }

	// RVA: 0xA5B3C0 Offset: 0xA59DC0 VA: 0x180A5B3C0 Slot: 21
	public override void NetworkInitialize__Late() { }

	// RVA: 0x662830 Offset: 0x661230 VA: 0x180662830 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0xA5BAB0 Offset: 0xA5A4B0 VA: 0x180A5BAB0
	private void RpcWriter___Server_SetMushroomSpawnLocationAvailable_3316948804(int locationIndex) { }

	// RVA: 0xA5B7E0 Offset: 0xA5A1E0 VA: 0x180A5B7E0
	private void RpcLogic___SetMushroomSpawnLocationAvailable_3316948804(int locationIndex) { }

	// RVA: 0xA5B910 Offset: 0xA5A310 VA: 0x180A5B910
	private void RpcReader___Server_SetMushroomSpawnLocationAvailable_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0xA5A5A0 Offset: 0xA58FA0 VA: 0x180A5A5A0
	private void Awake_UserLogic_ScheduleOne.Map.SewerMushrooms_Assembly-CSharp.dll() { }
}
