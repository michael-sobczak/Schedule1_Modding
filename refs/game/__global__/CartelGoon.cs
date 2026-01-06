public class CartelGoon : NPC // TypeDefIndex: 2085
{
	// Fields
	[CompilerGenerated]
	private bool <IsGoonSpawned>k__BackingField; // 0x2F0
	private List<CartelGoon> goonMates; // 0x2F8
	private CartelGoonAppearance appearance; // 0x300
	public Action onDespawn; // 0x308
	private bool NetworkInitialize___EarlyScheduleOne.Cartel.CartelGoonAssembly-CSharp.dll_Excuted; // 0x310
	private bool NetworkInitialize__LateScheduleOne.Cartel.CartelGoonAssembly-CSharp.dll_Excuted; // 0x311

	// Properties
	public bool IsGoonSpawned { get; set; }
	public GoonPool GoonPool { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6DFA70 Offset: 0x6DE470 VA: 0x1806DFA70
	public bool get_IsGoonSpawned() { }

	[CompilerGenerated]
	// RVA: 0x6DFB90 Offset: 0x6DE590 VA: 0x1806DFB90
	private void set_IsGoonSpawned(bool value) { }

	// RVA: 0x805C70 Offset: 0x804670 VA: 0x180805C70
	public GoonPool get_GoonPool() { }

	// RVA: 0x805B40 Offset: 0x804540 VA: 0x180805B40 Slot: 71
	protected override void Start() { }

	// RVA: 0x8049D0 Offset: 0x8033D0 VA: 0x1808049D0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x805930 Offset: 0x804330 VA: 0x180805930
	public void Spawn(GoonPool pool, Vector3 spawnPoint) { }

	[ObserversRpc(RunLocally = True)]
	[TargetRpc]
	// RVA: 0x8056E0 Offset: 0x8040E0 VA: 0x1808056E0
	private void Spawn_Client(NetworkConnection conn) { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x8041D0 Offset: 0x802BD0 VA: 0x1808041D0
	private void ConfigureGoonSettings(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed) { }

	// RVA: 0x8045A0 Offset: 0x802FA0 VA: 0x1808045A0
	public void Despawn() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x804480 Offset: 0x802E80 VA: 0x180804480
	private void Despawn_Client() { }

	// RVA: 0x803F80 Offset: 0x802980 VA: 0x180803F80
	public void AttackEntity(ICombatTargetable target, bool includeGoonMates = True) { }

	// RVA: 0x803E70 Offset: 0x802870 VA: 0x180803E70
	public void AddGoonMate(CartelGoon goonMate) { }

	// RVA: 0x804A60 Offset: 0x803460 VA: 0x180804A60
	public void RemoveGoonMate(CartelGoon goonMate) { }

	// RVA: 0x8047C0 Offset: 0x8031C0 VA: 0x1808047C0
	public bool IsMatesWith(CartelGoon otherGoon) { }

	// RVA: 0x805BF0 Offset: 0x8045F0 VA: 0x180805BF0
	public void .ctor() { }

	// RVA: 0x804820 Offset: 0x803220 VA: 0x180804820 Slot: 102
	public override void NetworkInitialize___Early() { }

	// RVA: 0x71BB20 Offset: 0x71A520 VA: 0x18071BB20 Slot: 103
	public override void NetworkInitialize__Late() { }

	// RVA: 0x677A30 Offset: 0x676430 VA: 0x180677A30 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x805330 Offset: 0x803D30 VA: 0x180805330
	private void RpcWriter___Observers_Spawn_Client_328543758(NetworkConnection conn) { }

	// RVA: 0x804E40 Offset: 0x803840 VA: 0x180804E40
	private void RpcLogic___Spawn_Client_328543758(NetworkConnection conn) { }

	// RVA: 0x804FA0 Offset: 0x8039A0 VA: 0x180804FA0
	private void RpcReader___Observers_Spawn_Client_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8055B0 Offset: 0x803FB0 VA: 0x1808055B0
	private void RpcWriter___Target_Spawn_Client_328543758(NetworkConnection conn) { }

	// RVA: 0x805060 Offset: 0x803A60 VA: 0x180805060
	private void RpcReader___Target_Spawn_Client_328543758(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x8050A0 Offset: 0x803AA0 VA: 0x1808050A0
	private void RpcWriter___Observers_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed) { }

	// RVA: 0x804B70 Offset: 0x803570 VA: 0x180804B70
	private void RpcLogic___ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed) { }

	// RVA: 0x804ED0 Offset: 0x8038D0 VA: 0x180804ED0
	private void RpcReader___Observers_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x805450 Offset: 0x803E50 VA: 0x180805450
	private void RpcWriter___Target_ConfigureGoonSettings_3427656873(NetworkConnection conn, CartelGoonAppearance appearance, float moveSpeed) { }

	// RVA: 0x804FE0 Offset: 0x8039E0 VA: 0x180804FE0
	private void RpcReader___Target_ConfigureGoonSettings_3427656873(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x805210 Offset: 0x803C10 VA: 0x180805210
	private void RpcWriter___Observers_Despawn_Client_2166136261() { }

	// RVA: 0x804DB0 Offset: 0x8037B0 VA: 0x180804DB0
	private void RpcLogic___Despawn_Client_2166136261() { }

	// RVA: 0x804F60 Offset: 0x803960 VA: 0x180804F60
	private void RpcReader___Observers_Despawn_Client_2166136261(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x6C3D30 Offset: 0x6C2730 VA: 0x1806C3D30 Slot: 65
	public override void Awake() { }
}
