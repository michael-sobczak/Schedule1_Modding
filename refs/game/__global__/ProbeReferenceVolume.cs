public class ProbeReferenceVolume // TypeDefIndex: 13741
{
	// Fields
	private bool m_IsInitialized; // 0x10
	private bool m_SupportStreaming; // 0x11
	private ProbeReferenceVolume.RefVolTransform m_Transform; // 0x14
	private int m_MaxSubdivision; // 0x34
	private ProbeBrickPool m_Pool; // 0x38
	private ProbeBrickIndex m_Index; // 0x40
	private ProbeCellIndices m_CellIndices; // 0x48
	private ProbeBrickBlendingPool m_BlendingPool; // 0x50
	private List<ProbeBrickPool.BrickChunkAlloc> m_TmpSrcChunks; // 0x58
	private float[] m_PositionOffsets; // 0x60
	private Bounds m_CurrGlobalBounds; // 0x68
	internal Dictionary<int, ProbeReferenceVolume.CellInfo> cells; // 0x80
	private ObjectPool<ProbeReferenceVolume.CellInfo> m_CellInfoPool; // 0x88
	private ObjectPool<ProbeReferenceVolume.BlendingCellInfo> m_BlendingCellInfoPool; // 0x90
	private ProbeBrickPool.DataLocation m_TemporaryDataLocation; // 0x98
	private int m_TemporaryDataLocationMemCost; // 0xE8
	private int m_CurrentProbeVolumeChunkSizeInBricks; // 0xEC
	internal ProbeVolumeSceneData sceneData; // 0xF0
	private Vector3Int minLoadedCellPos; // 0xF8
	private Vector3Int maxLoadedCellPos; // 0x104
	public Action<ProbeReferenceVolume.ExtraDataActionInput> retrieveExtraDataAction; // 0x110
	public Action checksDuringBakeAction; // 0x118
	private bool m_BricksLoaded; // 0x120
	private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeLoaded; // 0x128
	private Dictionary<string, ProbeVolumeAsset> m_PendingAssetsToBeUnloaded; // 0x130
	private Dictionary<string, ProbeVolumeAsset> m_ActiveAssets; // 0x138
	private bool m_NeedLoadAsset; // 0x140
	private bool m_ProbeReferenceVolumeInit; // 0x141
	private bool m_EnabledBySRP; // 0x142
	private ProbeReferenceVolume.InitInfo m_PendingInitInfo; // 0x144
	private bool m_NeedsIndexRebuild; // 0x15C
	private bool m_HasChangedIndex; // 0x15D
	private int m_CBShaderID; // 0x160
	private int m_NumberOfCellsLoadedPerFrame; // 0x164
	private int m_NumberOfCellsBlendedPerFrame; // 0x168
	private float m_TurnoverRate; // 0x16C
	private ProbeVolumeTextureMemoryBudget m_MemoryBudget; // 0x170
	private ProbeVolumeBlendingTextureMemoryBudget m_BlendingMemoryBudget; // 0x174
	private ProbeVolumeSHBands m_SHBands; // 0x178
	private float m_ProbeVolumesWeight; // 0x17C
	internal bool clearAssetsOnVolumeClear; // 0x180
	internal static string defaultLightingScenario; // 0x0
	private static ProbeReferenceVolume _instance; // 0x8
	[CompilerGenerated]
	private List<ProbeVolumePerSceneData> <perSceneDataList>k__BackingField; // 0x188
	private const int kProbesPerBatch = 511;
	public static readonly string k_DebugPanelName; // 0x10
	[CompilerGenerated]
	private readonly ProbeVolumeDebug <probeVolumeDebug>k__BackingField; // 0x190
	[CompilerGenerated]
	private readonly Color[] <subdivisionDebugColors>k__BackingField; // 0x198
	private DebugUI.Widget[] m_DebugItems; // 0x1A0
	private Mesh m_DebugMesh; // 0x1A8
	private Material m_DebugMaterial; // 0x1B0
	private Mesh m_DebugOffsetMesh; // 0x1B8
	private Material m_DebugOffsetMaterial; // 0x1C0
	private Plane[] m_DebugFrustumPlanes; // 0x1C8
	private GUIContent[] m_DebugScenarioNames; // 0x1D0
	private int[] m_DebugScenarioValues; // 0x1D8
	private string m_DebugActiveSceneGUID; // 0x1E0
	private string m_DebugActiveScenario; // 0x1E8
	private DebugUI.EnumField m_DebugScenarioField; // 0x1F0
	internal ProbeVolumeBakingProcessSettings bakingProcessSettings; // 0x1F8
	internal Dictionary<Bounds, ProbeBrickIndex.Brick[]> realtimeSubdivisionInfo; // 0x228
	private bool m_MaxSubdivVisualizedIsMaxAvailable; // 0x230
	private DynamicArray<ProbeReferenceVolume.CellInfo> m_LoadedCells; // 0x238
	private DynamicArray<ProbeReferenceVolume.CellInfo> m_ToBeLoadedCells; // 0x240
	private DynamicArray<ProbeReferenceVolume.CellInfo> m_TempCellToLoadList; // 0x248
	private DynamicArray<ProbeReferenceVolume.CellInfo> m_TempCellToUnloadList; // 0x250
	private DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_LoadedBlendingCells; // 0x258
	private DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_ToBeLoadedBlendingCells; // 0x260
	private DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_TempBlendingCellToLoadList; // 0x268
	private DynamicArray<ProbeReferenceVolume.BlendingCellInfo> m_TempBlendingCellToUnloadList; // 0x270
	private Vector3 m_FrozenCameraPosition; // 0x278
	private bool m_HasRemainingCellsToBlend; // 0x284

	// Properties
	internal Bounds globalBounds { get; set; }
	public bool isInitialized { get; }
	internal bool enabledBySRP { get; }
	internal bool hasUnloadedCells { get; }
	internal bool enableScenarioBlending { get; }
	internal int numberOfCellsLoadedPerFrame { get; }
	public int numberOfCellsBlendedPerFrame { get; set; }
	public float turnoverRate { get; set; }
	public ProbeVolumeSHBands shBands { get; }
	public string lightingScenario { get; set; }
	public float scenarioBlendingFactor { get; set; }
	public ProbeVolumeTextureMemoryBudget memoryBudget { get; }
	public float probeVolumesWeight { get; set; }
	internal List<ProbeVolumePerSceneData> perSceneDataList { get; set; }
	public static ProbeReferenceVolume instance { get; }
	internal ProbeVolumeDebug probeVolumeDebug { get; }
	public Color[] subdivisionDebugColors { get; }

	// Methods

	// RVA: 0x2A129A0 Offset: 0x2A113A0 VA: 0x182A129A0
	internal Bounds get_globalBounds() { }

	// RVA: 0x2A12AB0 Offset: 0x2A114B0 VA: 0x182A12AB0
	internal void set_globalBounds(Bounds value) { }

	// RVA: 0x512C30 Offset: 0x511630 VA: 0x180512C30
	public bool get_isInitialized() { }

	// RVA: 0x512C80 Offset: 0x511680 VA: 0x180512C80
	internal bool get_enabledBySRP() { }

	// RVA: 0x2A129C0 Offset: 0x2A113C0 VA: 0x182A129C0
	internal bool get_hasUnloadedCells() { }

	// RVA: 0x2A128E0 Offset: 0x2A112E0 VA: 0x182A128E0
	internal bool get_enableScenarioBlending() { }

	// RVA: 0x71DB70 Offset: 0x71C570 VA: 0x18071DB70
	internal int get_numberOfCellsLoadedPerFrame() { }

	// RVA: 0x73B350 Offset: 0x739D50 VA: 0x18073B350
	public int get_numberOfCellsBlendedPerFrame() { }

	// RVA: 0x2A12B00 Offset: 0x2A11500 VA: 0x182A12B00
	public void set_numberOfCellsBlendedPerFrame(int value) { }

	// RVA: 0x653860 Offset: 0x652260 VA: 0x180653860
	public float get_turnoverRate() { }

	// RVA: 0x2A12B50 Offset: 0x2A11550 VA: 0x182A12B50
	public void set_turnoverRate(float value) { }

	// RVA: 0x7D55E0 Offset: 0x7D3FE0 VA: 0x1807D55E0
	public ProbeVolumeSHBands get_shBands() { }

	// RVA: 0x2A12A60 Offset: 0x2A11460 VA: 0x182A12A60
	public string get_lightingScenario() { }

	// RVA: 0x2A12AD0 Offset: 0x2A114D0 VA: 0x182A12AD0
	public void set_lightingScenario(string value) { }

	// RVA: 0x2A12A80 Offset: 0x2A11480 VA: 0x182A12A80
	public float get_scenarioBlendingFactor() { }

	// RVA: 0x2A12B20 Offset: 0x2A11520 VA: 0x182A12B20
	public void set_scenarioBlendingFactor(float value) { }

	// RVA: 0x2A071A0 Offset: 0x2A05BA0 VA: 0x182A071A0
	public void BlendLightingScenario(string otherScenario, float blendingFactor) { }

	// RVA: 0x74C8E0 Offset: 0x74B2E0 VA: 0x18074C8E0
	public ProbeVolumeTextureMemoryBudget get_memoryBudget() { }

	// RVA: 0x6F64E0 Offset: 0x6F4EE0 VA: 0x1806F64E0
	public float get_probeVolumesWeight() { }

	// RVA: 0x5990E0 Offset: 0x597AE0 VA: 0x1805990E0
	public void set_probeVolumesWeight(float value) { }

	[CompilerGenerated]
	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380
	internal List<ProbeVolumePerSceneData> get_perSceneDataList() { }

	[CompilerGenerated]
	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	private void set_perSceneDataList(List<ProbeVolumePerSceneData> value) { }

	// RVA: 0x2A0E540 Offset: 0x2A0CF40 VA: 0x182A0E540
	internal void RegisterPerSceneData(ProbeVolumePerSceneData data) { }

	// RVA: 0x2A0FEA0 Offset: 0x2A0E8A0 VA: 0x182A0FEA0
	internal void UnregisterPerSceneData(ProbeVolumePerSceneData data) { }

	// RVA: 0x2A12A10 Offset: 0x2A11410 VA: 0x182A12A10
	public static ProbeReferenceVolume get_instance() { }

	// RVA: 0x2A0A9E0 Offset: 0x2A093E0 VA: 0x182A0A9E0
	public void Initialize(in ProbeVolumeSystemParameters parameters) { }

	// RVA: 0x1E572F0 Offset: 0x1E55CF0 VA: 0x181E572F0
	public void SetEnableStateFromSRP(bool srpEnablesPV) { }

	// RVA: 0x2A09660 Offset: 0x2A08060 VA: 0x182A09660
	internal void ForceSHBand(ProbeVolumeSHBands shBands) { }

	// RVA: 0x2A076F0 Offset: 0x2A060F0 VA: 0x182A076F0
	public void Cleanup() { }

	// RVA: 0x2A0A340 Offset: 0x2A08D40 VA: 0x182A0A340
	public int GetVideoMemoryCost() { }

	// RVA: 0x2A0E710 Offset: 0x2A0D110 VA: 0x182A0E710
	private void RemoveCell(ProbeReferenceVolume.Cell cell) { }

	// RVA: 0x2A0FB10 Offset: 0x2A0E510 VA: 0x182A0FB10
	internal void UnloadCell(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x2A0F9E0 Offset: 0x2A0E3E0 VA: 0x182A0F9E0
	internal void UnloadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell) { }

	// RVA: 0x2A0F8F0 Offset: 0x2A0E2F0 VA: 0x182A0F8F0
	internal void UnloadAllCells() { }

	// RVA: 0x2A0F750 Offset: 0x2A0E150 VA: 0x182A0F750
	internal void UnloadAllBlendingCells() { }

	// RVA: 0x2A065F0 Offset: 0x2A04FF0 VA: 0x182A065F0
	private void AddCell(ProbeReferenceVolume.Cell cell, int assetInstanceID) { }

	// RVA: 0x2A0B150 Offset: 0x2A09B50 VA: 0x182A0B150
	internal bool LoadCell(ProbeReferenceVolume.CellInfo cellInfo, bool ignoreErrorLog = False) { }

	// RVA: 0x2A0AD80 Offset: 0x2A09780 VA: 0x182A0AD80
	internal void LoadAllCells() { }

	// RVA: 0x2A0BA20 Offset: 0x2A0A420 VA: 0x182A0BA20
	private void RecomputeMinMaxLoadedCellPos() { }

	// RVA: 0x2A07280 Offset: 0x2A05C80 VA: 0x182A07280
	private bool CheckCompatibilityWithCollection(ProbeVolumeAsset asset, Dictionary<string, ProbeVolumeAsset> collection) { }

	// RVA: 0x2A06830 Offset: 0x2A05230 VA: 0x182A06830
	internal void AddPendingAssetLoading(ProbeVolumeAsset asset) { }

	// RVA: 0x2A06FE0 Offset: 0x2A059E0 VA: 0x182A06FE0
	internal void AddPendingAssetRemoval(ProbeVolumeAsset asset) { }

	// RVA: 0x2A0EAC0 Offset: 0x2A0D4C0 VA: 0x182A0EAC0
	internal void RemovePendingAsset(ProbeVolumeAsset asset) { }

	// RVA: 0x2A0B5D0 Offset: 0x2A09FD0 VA: 0x182A0B5D0
	private void PerformPendingIndexChangeAndInit() { }

	// RVA: 0x2A0F160 Offset: 0x2A0DB60 VA: 0x182A0F160
	internal void SetMinBrickAndMaxSubdiv(float minBrickSize, int maxSubdiv) { }

	// RVA: 0x2A0AEF0 Offset: 0x2A098F0 VA: 0x182A0AEF0
	private void LoadAsset(ProbeVolumeAsset asset) { }

	// RVA: 0x2A0B630 Offset: 0x2A0A030 VA: 0x182A0B630
	private void PerformPendingLoading() { }

	// RVA: 0x2A0B450 Offset: 0x2A09E50 VA: 0x182A0B450
	private void PerformPendingDeletion() { }

	// RVA: 0x2A098F0 Offset: 0x2A082F0 VA: 0x182A098F0
	internal int GetNumberOfBricksAtSubdiv(Vector3Int position, int minSubdiv, out Vector3Int minValidLocalIdxAtMaxRes, out Vector3Int sizeOfValidIndicesAtMaxRes) { }

	// RVA: 0x2A096C0 Offset: 0x2A080C0 VA: 0x182A096C0
	private bool GetCellIndexUpdate(ProbeReferenceVolume.Cell cell, out ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	// RVA: 0x2A0B9B0 Offset: 0x2A0A3B0 VA: 0x182A0B9B0
	public void PerformPendingOperations() { }

	// RVA: 0x2A0A3C0 Offset: 0x2A08DC0 VA: 0x182A0A3C0
	private void InitProbeReferenceVolume(ProbeVolumeTextureMemoryBudget memoryBudget, ProbeVolumeBlendingTextureMemoryBudget blendingMemoryBudget, ProbeVolumeSHBands shBands) { }

	// RVA: 0x2A070D0 Offset: 0x2A05AD0 VA: 0x182A070D0
	private void AllocateTemporaryDataLocation() { }

	// RVA: 0x2A120A0 Offset: 0x2A10AA0 VA: 0x182A120A0
	private void .ctor() { }

	// RVA: 0x2A0A010 Offset: 0x2A08A10 VA: 0x182A0A010
	public ProbeReferenceVolume.RuntimeResources GetRuntimeResources() { }

	// RVA: 0x2A0F270 Offset: 0x2A0DC70 VA: 0x182A0F270
	internal void SetTRS(Vector3 position, Quaternion rotation, float minBrickSize) { }

	// RVA: 0x2A0F100 Offset: 0x2A0DB00 VA: 0x182A0F100
	internal void SetMaxSubdivision(int maxSubdivision) { }

	// RVA: 0x2A07250 Offset: 0x2A05C50 VA: 0x182A07250
	internal static int CellSize(int subdivisionLevel) { }

	// RVA: 0x2A071D0 Offset: 0x2A05BD0 VA: 0x182A071D0
	internal float BrickSize(int subdivisionLevel) { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	internal float MinBrickSize() { }

	// RVA: 0x2A0B420 Offset: 0x2A09E20 VA: 0x182A0B420
	internal float MaxBrickSize() { }

	// RVA: 0x4753E0 Offset: 0x473DE0 VA: 0x1804753E0
	internal ProbeReferenceVolume.RefVolTransform GetTransform() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	internal int GetMaxSubdivision() { }

	// RVA: 0x2A09890 Offset: 0x2A08290 VA: 0x182A09890
	internal int GetMaxSubdivision(float multiplier) { }

	// RVA: 0x2A09870 Offset: 0x2A08270 VA: 0x182A09870
	internal float GetDistanceBetweenProbes(int subdivisionLevel) { }

	// RVA: 0x2A0B430 Offset: 0x2A09E30 VA: 0x182A0B430
	internal float MinDistanceBetweenProbes() { }

	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	public bool DataHasBeenLoaded() { }

	// RVA: 0x2A078C0 Offset: 0x2A062C0 VA: 0x182A078C0
	internal void Clear() { }

	// RVA: 0x2A0A190 Offset: 0x2A08B90 VA: 0x182A0A190
	private List<ProbeBrickPool.BrickChunkAlloc> GetSourceLocations(int count, int chunkSize, ProbeBrickPool.DataLocation dataLoc) { }

	// RVA: 0x2A11860 Offset: 0x2A10260 VA: 0x182A11860
	private void UpdatePool(List<ProbeBrickPool.BrickChunkAlloc> chunkList, ProbeReferenceVolume.Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex, int poolIndex) { }

	// RVA: 0x2A115A0 Offset: 0x2A0FFA0 VA: 0x182A115A0
	private void UpdatePoolValidity(List<ProbeBrickPool.BrickChunkAlloc> chunkList, ProbeReferenceVolume.Cell.PerScenarioData data, NativeArray<byte> validityNeighMaskData, int chunkIndex) { }

	// RVA: 0x2A05B40 Offset: 0x2A04540 VA: 0x182A05B40
	private bool AddBlendingBricks(ProbeReferenceVolume.BlendingCellInfo blendingCell) { }

	// RVA: 0x2A06210 Offset: 0x2A04C10 VA: 0x182A06210
	private bool AddBricks(ProbeReferenceVolume.CellInfo cellInfo, ProbeBrickIndex.CellIndexUpdateInfo cellUpdateInfo, bool ignoreErrorLog) { }

	// RVA: 0x2A10810 Offset: 0x2A0F210 VA: 0x182A10810
	private void UpdateCellIndex(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x2A0E620 Offset: 0x2A0D020 VA: 0x182A0E620
	private void ReleaseBricks(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x2A11220 Offset: 0x2A0FC20 VA: 0x182A11220
	public void UpdateConstantBuffer(CommandBuffer cmd, ProbeVolumeShadingParameters parameters) { }

	// RVA: 0x2A07550 Offset: 0x2A05F50 VA: 0x182A07550
	private void CleanupLoadedData() { }

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	internal ProbeVolumeDebug get_probeVolumeDebug() { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public Color[] get_subdivisionDebugColors() { }

	// RVA: 0x2A0EDB0 Offset: 0x2A0D7B0 VA: 0x182A0EDB0
	public void RenderDebug(Camera camera) { }

	// RVA: 0x2A0A790 Offset: 0x2A09190 VA: 0x182A0A790
	private void InitializeDebug(in ProbeVolumeSystemParameters parameters) { }

	// RVA: 0x2A07450 Offset: 0x2A05E50 VA: 0x182A07450
	private void CleanupDebug() { }

	// RVA: -1 Offset: -1
	private void DebugCellIndexChanged<T>(DebugUI.Field<T> field, T value) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF27240 Offset: 0xF25C40 VA: 0x180F27240
	|-ProbeReferenceVolume.DebugCellIndexChanged<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2A0BCD0 Offset: 0x2A0A6D0 VA: 0x182A0BCD0
	private void RegisterDebug(ProbeVolumeSystemParameters parameters) { }

	// RVA: 0x2A0FD50 Offset: 0x2A0E750 VA: 0x182A0FD50
	private void UnregisterDebug(bool destroyPanel) { }

	// RVA: 0x2A0F290 Offset: 0x2A0DC90 VA: 0x182A0F290
	private bool ShouldCullCell(Vector3 cellPosition, Transform cameraTransform, Plane[] frustumPlanes) { }

	// RVA: 0x2A08A70 Offset: 0x2A07470 VA: 0x182A08A70
	private void DrawProbeDebug(Camera camera) { }

	// RVA: 0x2A0EE10 Offset: 0x2A0D810 VA: 0x182A0EE10
	internal void ResetDebugViewToMaxSubdiv() { }

	// RVA: 0x2A07870 Offset: 0x2A06270 VA: 0x182A07870
	private void ClearDebugData() { }

	// RVA: 0x2A07CE0 Offset: 0x2A066E0 VA: 0x182A07CE0
	private ProbeReferenceVolume.CellInstancedDebugProbes CreateInstancedProbes(ProbeReferenceVolume.CellInfo cellInfo) { }

	// RVA: 0x2A07870 Offset: 0x2A06270 VA: 0x182A07870
	private void OnClearLightingdata() { }

	// RVA: 0x2A0EEC0 Offset: 0x2A0D8C0 VA: 0x182A0EEC0
	internal void ScenarioBlendingChanged(bool scenarioChanged) { }

	// RVA: 0x2A0F250 Offset: 0x2A0DC50 VA: 0x182A0F250
	public void SetNumberOfCellsLoadedPerFrame(int numberOfCells) { }

	// RVA: 0x2A07A30 Offset: 0x2A06430 VA: 0x182A07A30
	private void ComputeCellCameraDistance(Vector3 cameraPosition, DynamicArray<ProbeReferenceVolume.CellInfo> cells) { }

	// RVA: 0x2A07BE0 Offset: 0x2A065E0 VA: 0x182A07BE0
	private void ComputeStreamingScoreForBlending(DynamicArray<ProbeReferenceVolume.BlendingCellInfo> cells, float worstScore) { }

	// RVA: 0x2A0F660 Offset: 0x2A0E060 VA: 0x182A0F660
	private bool TryLoadCell(ProbeReferenceVolume.CellInfo cellInfo, ref int shBudget, ref int indexBudget, DynamicArray<ProbeReferenceVolume.CellInfo> loadedCells) { }

	// RVA: 0x2A0FAA0 Offset: 0x2A0E4A0 VA: 0x182A0FAA0
	private void UnloadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell, DynamicArray<ProbeReferenceVolume.BlendingCellInfo> unloadedCells) { }

	// RVA: 0x2A0F5E0 Offset: 0x2A0DFE0 VA: 0x182A0F5E0
	private bool TryLoadBlendingCell(ProbeReferenceVolume.BlendingCellInfo blendingCell, DynamicArray<ProbeReferenceVolume.BlendingCellInfo> loadedCells) { }

	// RVA: 0x2A10950 Offset: 0x2A0F350 VA: 0x182A10950
	public void UpdateCellStreaming(CommandBuffer cmd, Camera camera) { }

	// RVA: 0x2A09510 Offset: 0x2A07F10 VA: 0x182A09510
	private int FindWorstBlendingCellToBeLoaded() { }

	// RVA: 0x2A0FF00 Offset: 0x2A0E900 VA: 0x182A0FF00
	private void UpdateBlendingCellStreaming(CommandBuffer cmd) { }

	// RVA: 0x2A11FB0 Offset: 0x2A109B0 VA: 0x182A11FB0
	private static void .cctor() { }
}
