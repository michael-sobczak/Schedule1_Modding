public class ShroomColony : NetworkBehaviour // TypeDefIndex: 2379
{
	// Fields
	public const float MaxTemperatureForGrowth = 15;
	private const float MinSoilMoistureForGrowth = 0.0001;
	private const float RandomRotationRange = 15;
	private const float RandomVerticalShift = 0.02;
	[SerializeField]
	[CompilerGenerated]
	private int <BaseShroomYield>k__BackingField; // 0x118
	[SerializeField]
	private ShroomSpawnDefinition _spawnDefinition; // 0x120
	[SerializeField]
	private int _growTime; // 0x128
	[SerializeField]
	private Transform[] _shroomAlignments; // 0x130
	[SerializeField]
	private GrowingMushroom[] _growingShroomPrefabs; // 0x138
	[SerializeField]
	private AudioSourceController _snipSound; // 0x140
	[SerializeField]
	private ParticleSystem _fullyGrownParticles; // 0x148
	[CompilerGenerated]
	private float <GrowthProgress>k__BackingField; // 0x150
	[CompilerGenerated]
	private float <NormalizedQuality>k__BackingField; // 0x154
	public Action onFullyHarvested; // 0x158
	private List<GrowingMushroom> _growingShrooms; // 0x160
	private Dictionary<GrowingMushroom, int> _growingShroomPositions; // 0x168
	private List<int> _takenAlignmentIndices; // 0x170
	private MushroomBed _parentBed; // 0x178
	private bool _shroomsInitiallySpawned; // 0x180
	private bool NetworkInitialize___EarlyScheduleOne.Growing.ShroomColonyAssembly-CSharp.dll_Excuted; // 0x181
	private bool NetworkInitialize__LateScheduleOne.Growing.ShroomColonyAssembly-CSharp.dll_Excuted; // 0x182

	// Properties
	public int BaseShroomYield { get; set; }
	public float GrowthProgress { get; set; }
	public bool IsFullyGrown { get; }
	public bool IsTooHotToGrow { get; }
	public int GrownMushroomCount { get; }
	public AudioSourceController SnipSound { get; }
	public float NormalizedQuality { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5232B0 Offset: 0x521CB0 VA: 0x1805232B0
	public int get_BaseShroomYield() { }

	[CompilerGenerated]
	// RVA: 0x7EDA60 Offset: 0x7EC460 VA: 0x1807EDA60
	private void set_BaseShroomYield(int value) { }

	[CompilerGenerated]
	// RVA: 0x513120 Offset: 0x511B20 VA: 0x180513120
	public float get_GrowthProgress() { }

	[CompilerGenerated]
	// RVA: 0x70E9B0 Offset: 0x70D3B0 VA: 0x18070E9B0
	private void set_GrowthProgress(float value) { }

	// RVA: 0x86C5D0 Offset: 0x86AFD0 VA: 0x18086C5D0
	public bool get_IsFullyGrown() { }

	// RVA: 0x86C5F0 Offset: 0x86AFF0 VA: 0x18086C5F0
	public bool get_IsTooHotToGrow() { }

	// RVA: 0x86C590 Offset: 0x86AF90 VA: 0x18086C590
	public int get_GrownMushroomCount() { }

	// RVA: 0x67E910 Offset: 0x67D310 VA: 0x18067E910
	public AudioSourceController get_SnipSound() { }

	[CompilerGenerated]
	// RVA: 0x86C680 Offset: 0x86B080 VA: 0x18086C680
	public float get_NormalizedQuality() { }

	[CompilerGenerated]
	// RVA: 0x86C690 Offset: 0x86B090 VA: 0x18086C690
	private void set_NormalizedQuality(float value) { }

	// RVA: 0x86A2E0 Offset: 0x868CE0 VA: 0x18086A2E0 Slot: 9
	public override void OnSpawnServer(NetworkConnection connection) { }

	// RVA: 0x86A5C0 Offset: 0x868FC0 VA: 0x18086A5C0 Slot: 11
	public override void OnStartClient() { }

	// RVA: 0x869FB0 Offset: 0x8689B0 VA: 0x180869FB0
	private void OnDestroy() { }

	// RVA: 0x86A1E0 Offset: 0x868BE0 VA: 0x18086A1E0
	private void OnMinPass() { }

	// RVA: 0x86A880 Offset: 0x869280 VA: 0x18086A880
	private void OnTimeSkipped(int mins) { }

	// RVA: 0x86BF20 Offset: 0x86A920 VA: 0x18086BF20
	public void SetColonyVisible(bool visible) { }

	// RVA: 0x869870 Offset: 0x868270 VA: 0x180869870
	private float GetCurrentGrowthRate() { }

	// RVA: 0x869830 Offset: 0x868230 VA: 0x180869830
	private void ChangeGrowthPercentage(float change) { }

	[ServerRpc(RequireOwnership = False)]
	// RVA: 0x86BB30 Offset: 0x86A530 VA: 0x18086BB30
	public void SetFullyGrown() { }

	[TargetRpc]
	[ObserversRpc(RunLocally = True)]
	// RVA: 0x86BF70 Offset: 0x86A970 VA: 0x18086BF70
	private void SetGrowthPercentage_Local(NetworkConnection conn, float percent) { }

	// RVA: 0x86C1E0 Offset: 0x86ABE0 VA: 0x18086C1E0
	private void SetGrowthPercentage(float percent) { }

	// RVA: 0x869840 Offset: 0x868240 VA: 0x180869840
	private void ChangeQuality(float change) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x8690F0 Offset: 0x867AF0 VA: 0x1808690F0
	public void AddShroomAtPosition_Server(int alignmentIndex) { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x868FA0 Offset: 0x8679A0 VA: 0x180868FA0
	private void AddShroomAtPosition_Local(int alignmentIndex) { }

	// RVA: 0x869230 Offset: 0x867C30 VA: 0x180869230
	private void AddShroomAtPosition(int alignmentIndex) { }

	[ServerRpc(RequireOwnership = False, RunLocally = True)]
	// RVA: 0x86AB40 Offset: 0x869540 VA: 0x18086AB40
	public void RemoveShroom_Server(int alignmentIndex) { }

	// RVA: 0x86A940 Offset: 0x869340 VA: 0x18086A940
	public void RemoveRandomShroom() { }

	[ObserversRpc(RunLocally = True)]
	// RVA: 0x86A9F0 Offset: 0x8693F0 VA: 0x18086A9F0
	private void RemoveShoom_Client(int alignmentIndex) { }

	// RVA: 0x86AE40 Offset: 0x869840 VA: 0x18086AE40
	private void RemoveShroom(int alignmentIndex) { }

	// RVA: 0x86AC80 Offset: 0x869680 VA: 0x18086AC80
	private void RemoveShroom(GrowingMushroom shroom) { }

	// RVA: 0x86BF50 Offset: 0x86A950 VA: 0x18086BF50
	public void SetFullyHarvested() { }

	// RVA: 0x8699E0 Offset: 0x8683E0 VA: 0x1808699E0
	private int GetRandomAvailableAlignmentIndex() { }

	// RVA: 0x8698D0 Offset: 0x8682D0 VA: 0x1808698D0
	public ShroomInstance GetHarvestedShroom(int quantity = 1) { }

	// RVA: 0x869710 Offset: 0x868110 VA: 0x180869710
	public void AdditiveApplied(AdditiveDefinition additive, bool isInitialApplication) { }

	[TargetRpc]
	// RVA: 0x86BC40 Offset: 0x86A640 VA: 0x18086BC40
	public void SetColonyState(NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality) { }

	// RVA: 0x869B60 Offset: 0x868560 VA: 0x180869B60
	public ShroomColonyData GetSaveData() { }

	// RVA: 0x869C80 Offset: 0x868680 VA: 0x180869C80
	public void Load(ShroomColonyData data) { }

	// RVA: 0x86C450 Offset: 0x86AE50 VA: 0x18086C450
	public void .ctor() { }

	// RVA: 0x869D40 Offset: 0x868740 VA: 0x180869D40 Slot: 19
	public override void NetworkInitialize___Early() { }

	// RVA: 0x869D20 Offset: 0x868720 VA: 0x180869D20 Slot: 20
	public override void NetworkInitialize__Late() { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 14
	public override void NetworkInitializeIfDisabled() { }

	// RVA: 0x86BB30 Offset: 0x86A530 VA: 0x18086BB30
	private void RpcWriter___Server_SetFullyGrown_2166136261() { }

	// RVA: 0x86B0C0 Offset: 0x869AC0 VA: 0x18086B0C0
	public void RpcLogic___SetFullyGrown_2166136261() { }

	// RVA: 0x86B340 Offset: 0x869D40 VA: 0x18086B340
	private void RpcReader___Server_SetFullyGrown_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x86B760 Offset: 0x86A160 VA: 0x18086B760
	private void RpcWriter___Observers_SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent) { }

	// RVA: 0x86B0E0 Offset: 0x869AE0 VA: 0x18086B0E0
	private void RpcLogic___SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent) { }

	// RVA: 0x86B1D0 Offset: 0x869BD0 VA: 0x18086B1D0
	private void RpcReader___Observers_SetGrowthPercentage_Local_530160725(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x86BDC0 Offset: 0x86A7C0 VA: 0x18086BDC0
	private void RpcWriter___Target_SetGrowthPercentage_Local_530160725(NetworkConnection conn, float percent) { }

	// RVA: 0x86B460 Offset: 0x869E60 VA: 0x18086B460
	private void RpcReader___Target_SetGrowthPercentage_Local_530160725(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x86B8B0 Offset: 0x86A2B0 VA: 0x18086B8B0
	private void RpcWriter___Server_AddShroomAtPosition_Server_3316948804(int alignmentIndex) { }

	// RVA: 0x86B000 Offset: 0x869A00 VA: 0x18086B000
	public void RpcLogic___AddShroomAtPosition_Server_3316948804(int alignmentIndex) { }

	// RVA: 0x86B240 Offset: 0x869C40 VA: 0x18086B240
	private void RpcReader___Server_AddShroomAtPosition_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x86B4C0 Offset: 0x869EC0 VA: 0x18086B4C0
	private void RpcWriter___Observers_AddShroomAtPosition_Local_3316948804(int alignmentIndex) { }

	// RVA: 0x86AFF0 Offset: 0x8699F0 VA: 0x18086AFF0
	private void RpcLogic___AddShroomAtPosition_Local_3316948804(int alignmentIndex) { }

	// RVA: 0x86B0F0 Offset: 0x869AF0 VA: 0x18086B0F0
	private void RpcReader___Observers_AddShroomAtPosition_Local_3316948804(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x86B9F0 Offset: 0x86A3F0 VA: 0x18086B9F0
	private void RpcWriter___Server_RemoveShroom_Server_3316948804(int alignmentIndex) { }

	// RVA: 0x86A9F0 Offset: 0x8693F0 VA: 0x18086A9F0
	public void RpcLogic___RemoveShroom_Server_3316948804(int alignmentIndex) { }

	// RVA: 0x86B2C0 Offset: 0x869CC0 VA: 0x18086B2C0
	private void RpcReader___Server_RemoveShroom_Server_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn) { }

	// RVA: 0x86B610 Offset: 0x86A010 VA: 0x18086B610
	private void RpcWriter___Observers_RemoveShoom_Client_3316948804(int alignmentIndex) { }

	// RVA: 0x86B010 Offset: 0x869A10 VA: 0x18086B010
	private void RpcLogic___RemoveShoom_Client_3316948804(int alignmentIndex) { }

	// RVA: 0x86B160 Offset: 0x869B60 VA: 0x18086B160
	private void RpcReader___Observers_RemoveShoom_Client_3316948804(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x86BC40 Offset: 0x86A640 VA: 0x18086BC40
	private void RpcWriter___Target_SetColonyState_4288818029(NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality) { }

	// RVA: 0x86B020 Offset: 0x869A20 VA: 0x18086B020
	public void RpcLogic___SetColonyState_4288818029(NetworkConnection conn, int[] _activeMushroomIndices, float growthProgress, float quality) { }

	// RVA: 0x86B380 Offset: 0x869D80 VA: 0x18086B380
	private void RpcReader___Target_SetColonyState_4288818029(PooledReader PooledReader0, Channel channel) { }

	// RVA: 0x5F9760 Offset: 0x5F8160 VA: 0x1805F9760 Slot: 21
	public override void Awake() { }
}
