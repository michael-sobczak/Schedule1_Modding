public class PlayerCrimeData : NetworkBehaviour // TypeDefIndex: 1342
{
	// Fields
	public const float SEARCH_TIME_INVESTIGATING = 60;
	public const float SEARCH_TIME_ARRESTING = 25;
	public const float SEARCH_TIME_NONLETHAL = 30;
	public const float SEARCH_TIME_LETHAL = 40;
	public const float ESCALATION_TIME_ARRESTING = 25;
	public const float ESCALATION_TIME_NONLETHAL = 120;
	public const float SHOT_COOLDOWN_MIN = 2;
	public const float SHOT_COOLDOWN_MAX = 8;
	public const float VEHICLE_COLLISION_LIFETIME = 30;
	public const float VEHICLE_COLLISION_LIMIT = 3;
	public PoliceOfficer NearestOfficer; // 0x118
	public Player Player; // 0x120
	public AudioSourceController onPursuitEscapedSound; // 0x128
	[CompilerGenerated]
	[SyncVar(SendRate = 0.5, WritePermissions = 1)]
	public PlayerCrimeData.EPursuitLevel <CurrentPursuitLevel>k__BackingField; // 0x130
	[CompilerGenerated]
	[SyncVar(SendRate = 0.5, WritePermissions = 1)]
	public Vector3 <LastKnownPosition>k__BackingField; // 0x134
	public List<PoliceOfficer> Pursuers; // 0x140
	[CompilerGenerated]
	private float <CurrentArrestProgress>k__BackingField; // 0x148
	[CompilerGenerated]
	private float <CurrentBodySearchProgress>k__BackingField; // 0x14C
	[CompilerGenerated]
	private int <MinsSinceLastArrested>k__BackingField; // 0x150
	public float TimeSincePursuitStart; // 0x154
	public float CurrentPursuitLevelDuration; // 0x158
	public float TimeSinceSighted; // 0x15C
	public Dictionary<Crime, int> Crimes; // 0x160
	public bool BodySearchPending; // 0x168
	[CompilerGenerated]
	private float <TimeSinceLastBodySearch>k__BackingField; // 0x16C
	[CompilerGenerated]
	private bool <EvadedArrest>k__BackingField; // 0x170
	protected List<PlayerCrimeData.VehicleCollisionInstance> Collisions; // 0x178
	private MusicTrack _lightCombatTrack; // 0x180
	private MusicTrack _heavyCombatTrack; // 0x188
	private float outOfSightTimeToDipMusic; // 0x190
	private float minMusicVolume; // 0x194
	private float musicChangeRate_Down; // 0x198
	private float musicChangeRate_Up; // 0x19C
	public SyncVar<PlayerCrimeData.EPursuitLevel> syncVar___<CurrentPursuitLevel>k__BackingField; // 0x1A0
	public SyncVar<Vector3> syncVar___<LastKnownPosition>k__BackingField; // 0x1A8
	private bool NetworkInitialize___EarlyScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted; // 0x1B0
	private bool NetworkInitialize__LateScheduleOne.PlayerScripts.PlayerCrimeDataAssembly-CSharp.dll_Excuted; // 0x1B1

	// Properties
	public PlayerCrimeData.EPursuitLevel CurrentPursuitLevel { get; set; }
	public Vector3 LastKnownPosition { get; set; }
	public float CurrentArrestProgress { get; set; }
	public float CurrentBodySearchProgress { get; set; }
	public int MinsSinceLastArrested { get; set; }
	public float TimeSinceLastBodySearch { get; set; }
	public bool EvadedArrest { get; set; }
	public PlayerCrimeData.EPursuitLevel SyncAccessor_<CurrentPursuitLevel>k__BackingField { get; set; }
	public Vector3 SyncAccessor_<LastKnownPosition>k__BackingField { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public PlayerCrimeData.EPursuitLevel get_CurrentPursuitLevel() { }

	[CompilerGenerated]
	[ServerRpc(RunLocally = True)]
	// RVA: 0x653890 Offset: 0x652290 VA: 0x180653890
	protected void set_CurrentPursuitLevel(PlayerCrimeData.EPursuitLevel value) { }

	[CompilerGenerated]
	// RVA: 0x653830 Offset: 0x652230 VA: 0x180653830
	public Vector3 get_LastKnownPosition() { }

	[CompilerGenerated]
	[ServerRpc(RunLocally = True)]
	// RVA: 0x653A30 Offset: 0x652430 VA: 0x180653A30
	protected void set_LastKnownPosition(Vector3 value) { }

	[CompilerGenerated]
	// RVA: 0x513070 Offset: 0x511A70 VA: 0x180513070
	public float get_CurrentArrestProgress() { }

	[CompilerGenerated]
	// RVA: 0x653870 Offset: 0x652270 VA: 0x180653870
	protected void set_CurrentArrestProgress(float value) { }

	[CompilerGenerated]
	// RVA: 0x653810 Offset: 0x652210 VA: 0x180653810
	public float get_CurrentBodySearchProgress() { }

	[CompilerGenerated]
	// RVA: 0x653880 Offset: 0x652280 VA: 0x180653880
	protected void set_CurrentBodySearchProgress(float value) { }

	[CompilerGenerated]
	// RVA: 0x653850 Offset: 0x652250 VA: 0x180653850
	public int get_MinsSinceLastArrested() { }

	[CompilerGenerated]
	// RVA: 0x653B00 Offset: 0x652500 VA: 0x180653B00
	public void set_MinsSinceLastArrested(int value) { }

	[CompilerGenerated]
	// RVA: 0x653860 Offset: 0x652260 VA: 0x180653860
	public float get_TimeSinceLastBodySearch() { }

	[CompilerGenerated]
	// RVA: 0x653B10 Offset: 0x652510 VA: 0x180653B10
	public void set_TimeSinceLastBodySearch(float value) { }

	[CompilerGenerated]
	// RVA: 0x653820 Offset: 0x652220 VA: 0x180653820
	public bool get_EvadedArrest() { }

	[CompilerGenerated]
	// RVA: 0x653A20 Offset: 0x652420 VA: 0x180653A20
	protected void set_EvadedArrest(bool value) { }

	// RVA: 0x6501C0 Offset: 0x64EBC0 VA: 0x1806501C0 Slot: 19
	public override void Awake() { }

	// RVA: 0x652630 Offset: 0x651030 VA: 0x180652630
	private void Start() { }

	// RVA: 0x6512B0 Offset: 0x64FCB0 VA: 0x1806512B0
	private void OnDestroy() { }

	// RVA: 0x652EF0 Offset: 0x6518F0 VA: 0x180652EF0 Slot: 20
	protected virtual void Update() { }

	// RVA: 0x650F20 Offset: 0x64F920 VA: 0x180650F20
	private void MinPass() { }

	// RVA: 0x650CB0 Offset: 0x64F6B0 VA: 0x180650CB0 Slot: 21
	protected virtual void LateUpdate() { }

	// RVA: 0x6522F0 Offset: 0x650CF0 VA: 0x1806522F0
	public void SetPursuitLevel(PlayerCrimeData.EPursuitLevel level) { }

	// RVA: 0x6503F0 Offset: 0x64EDF0 VA: 0x1806503F0
	public void Escalate() { }

	// RVA: 0x650390 Offset: 0x64ED90 VA: 0x180650390
	public void Deescalate() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x6516D0 Offset: 0x6500D0 VA: 0x1806516D0
	public void RecordLastKnownPosition(bool resetTimeSinceSighted) { }

	// RVA: 0x652260 Offset: 0x650C60 VA: 0x180652260
	public void SetArrestProgress(float progress) { }

	// RVA: 0x651910 Offset: 0x650310 VA: 0x180651910
	public void ResetBodysearchCooldown() { }

	// RVA: 0x6522B0 Offset: 0x650CB0 VA: 0x1806522B0
	public void SetBodySearchProgress(float progress) { }

	// RVA: 0x651420 Offset: 0x64FE20 VA: 0x180651420
	private void OnDie() { }

	// RVA: 0x64FB60 Offset: 0x64E560 VA: 0x18064FB60
	public void AddCrime(Crime crime, int quantity = 1) { }

	// RVA: 0x650340 Offset: 0x64ED40 VA: 0x180650340
	public void ClearCrimes() { }

	// RVA: 0x650BA0 Offset: 0x64F5A0 VA: 0x180650BA0
	public bool IsCrimeOnRecord(Type crime) { }

	// RVA: 0x6522E0 Offset: 0x650CE0 VA: 0x1806522E0
	public void SetEvaded() { }

	// RVA: 0x651470 Offset: 0x64FE70 VA: 0x180651470
	private void OnSleepStart() { }

	// RVA: 0x652C20 Offset: 0x651620 VA: 0x180652C20
	private void UpdateEscalation() { }

	// RVA: 0x652D60 Offset: 0x651760 VA: 0x180652D60
	private void UpdateTimeout() { }

	// RVA: 0x652C70 Offset: 0x651670 VA: 0x180652C70
	private void UpdateMusic() { }

	// RVA: 0x6529C0 Offset: 0x6513C0 VA: 0x1806529C0
	private void TimeoutPursuit() { }

	// RVA: 0x6506B0 Offset: 0x64F0B0 VA: 0x1806506B0
	public float GetSearchTime() { }

	// RVA: 0x650700 Offset: 0x64F100 VA: 0x180650700
	public float GetShotAccuracyMultiplier() { }

	// RVA: 0x651810 Offset: 0x650210 VA: 0x180651810
	public void RecordVehicleCollision(NPC victim) { }

	// RVA: 0x650210 Offset: 0x64EC10 VA: 0x180650210
	private void CheckNearestOfficer() { }

	// RVA: 0x653670 Offset: 0x652070 VA: 0x180653670
	public void .ctor() { }

	[CompilerGenerated]
	// RVA: 0x652AD0 Offset: 0x6514D0 VA: 0x180652AD0
	private void <Awake>b__56_0() { }

	[CompilerGenerated]
	// RVA: 0x652AE0 Offset: 0x6514E0 VA: 0x180652AE0
	private float <CheckNearestOfficer>b__82_0(PoliceOfficer x) { }

	// RVA: 0x650FA0 Offset: 0x64F9A0 VA: 0x180650FA0 Slot: 22
	public override void NetworkInitialize___Early() { }

	// RVA: 0x650F30 Offset: 0x64F930 VA: 0x180650F30 Slot: 23
	public override void NetworkInitialize__Late() { }

	// RVA: 0x59EFB0 Offset: 0x59D9B0 VA: 0x18059EFB0 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x651EC0 Offset: 0x6508C0 VA: 0x180651EC0
	private void RpcWriter___Server_set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value) { }

	// RVA: 0x651A40 Offset: 0x650440 VA: 0x180651A40
	protected void RpcLogic___set_CurrentPursuitLevel_2979171596(PlayerCrimeData.EPursuitLevel value) { }

	// RVA: 0x651C00 Offset: 0x650600 VA: 0x180651C00
	private void RpcReader___Server_set_CurrentPursuitLevel_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x652070 Offset: 0x650A70 VA: 0x180652070
	private void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value) { }

	// RVA: 0x651AD0 Offset: 0x6504D0 VA: 0x180651AD0
	protected void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value) { }

	// RVA: 0x651C80 Offset: 0x650680 VA: 0x180651C80
	private void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x651D80 Offset: 0x650780 VA: 0x180651D80
	private void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted) { }

	// RVA: 0x651920 Offset: 0x650320 VA: 0x180651920
	public void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted) { }

	// RVA: 0x651B80 Offset: 0x650580 VA: 0x180651B80
	private void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x523410 Offset: 0x521E10 VA: 0x180523410
	public PlayerCrimeData.EPursuitLevel sync___get_value_<CurrentPursuitLevel>k__BackingField() { }

	// RVA: 0x653B20 Offset: 0x652520 VA: 0x180653B20
	public void sync___set_value_<CurrentPursuitLevel>k__BackingField(PlayerCrimeData.EPursuitLevel value, bool asServer) { }

	// RVA: 0x6514E0 Offset: 0x64FEE0 VA: 0x1806514E0 Slot: 24
	public override bool ReadSyncVar___ScheduleOne.PlayerScripts.PlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2) { }

	// RVA: 0x653830 Offset: 0x652230 VA: 0x180653830
	public Vector3 sync___get_value_<LastKnownPosition>k__BackingField() { }

	// RVA: 0x653BD0 Offset: 0x6525D0 VA: 0x180653BD0
	public void sync___set_value_<LastKnownPosition>k__BackingField(Vector3 value, bool asServer) { }

	// RVA: 0x64FD90 Offset: 0x64E790 VA: 0x18064FD90
	private void Awake_UserLogic_ScheduleOne.PlayerScripts.PlayerCrimeData_Assembly-CSharp.dll() { }
}
