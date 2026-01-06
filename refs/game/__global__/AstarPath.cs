public class AstarPath : VersionedMonoBehaviour // TypeDefIndex: 13092
{
	// Fields
	public static readonly Version Version; // 0x0
	public static readonly AstarPath.AstarDistribution Distribution; // 0x8
	public static readonly string Branch; // 0x10
	[FormerlySerializedAs("astarData")]
	public AstarData data; // 0x28
	public static AstarPath active; // 0x18
	public bool showNavGraphs; // 0x30
	public bool showUnwalkableNodes; // 0x31
	public GraphDebugMode debugMode; // 0x34
	public float debugFloor; // 0x38
	public float debugRoof; // 0x3C
	public bool manualDebugFloorRoof; // 0x40
	public bool showSearchTree; // 0x41
	public float unwalkableNodeDebugSize; // 0x44
	public PathLog logPathResults; // 0x48
	public float maxNearestNodeDistance; // 0x4C
	public bool scanOnStartup; // 0x50
	public bool fullGetNearestSearch; // 0x51
	[Obsolete("This setting is discouraged, and it will be removed in a future update")]
	public bool prioritizeGraphs; // 0x52
	[Obsolete("This setting is discouraged, and it will be removed in a future update")]
	public float prioritizeGraphsLimit; // 0x54
	public AstarColor colorSettings; // 0x58
	[SerializeField]
	protected string[] tagNames; // 0x60
	public Heuristic heuristic; // 0x68
	public float heuristicScale; // 0x6C
	public ThreadCount threadCount; // 0x70
	public float maxFrameTime; // 0x74
	public bool batchGraphUpdates; // 0x78
	public float graphUpdateBatchingInterval; // 0x7C
	[CompilerGenerated]
	private float <lastScanTime>k__BackingField; // 0x80
	public PathHandler debugPathData; // 0x88
	public ushort debugPathID; // 0x90
	private string inGameDebugPath; // 0x98
	private bool isScanningBacking; // 0xA0
	public static Action OnAwakeSettings; // 0x20
	public static OnGraphDelegate OnGraphPreScan; // 0x28
	public static OnGraphDelegate OnGraphPostScan; // 0x30
	public static OnPathDelegate OnPathPreSearch; // 0x38
	public static OnPathDelegate OnPathPostSearch; // 0x40
	public static OnScanDelegate OnPreScan; // 0x48
	public static OnScanDelegate OnPostScan; // 0x50
	public static OnScanDelegate OnLatePostScan; // 0x58
	public static OnScanDelegate OnGraphsUpdated; // 0x60
	public static Action On65KOverflow; // 0x68
	[Obsolete]
	public Action OnGraphsWillBeUpdated; // 0xA8
	[Obsolete]
	public Action OnGraphsWillBeUpdated2; // 0xB0
	private readonly GraphUpdateProcessor graphUpdates; // 0xB8
	internal readonly HierarchicalGraph hierarchicalGraph; // 0xC0
	public readonly NavmeshUpdates navmeshUpdates; // 0xC8
	private readonly WorkItemProcessor workItems; // 0xD0
	private PathProcessor pathProcessor; // 0xD8
	private bool graphUpdateRoutineRunning; // 0xE0
	private bool graphUpdatesWorkItemAdded; // 0xE1
	private float lastGraphUpdate; // 0xE4
	private PathProcessor.GraphUpdateLock workItemLock; // 0xE8
	internal readonly PathReturnQueue pathReturnQueue; // 0xF8
	public EuclideanEmbedding euclideanEmbedding; // 0x100
	public bool showGraphs; // 0x108
	private ushort nextFreePathID; // 0x10A
	private RetainedGizmos gizmos; // 0x110
	private static int waitForPathDepth; // 0x70
	private static readonly NNConstraint NNConstraintNone; // 0x78

	// Properties
	[Obsolete]
	public Type[] graphTypes { get; }
	[Obsolete("The 'astarData' field has been renamed to 'data'")]
	public AstarData astarData { get; }
	public NavGraph[] graphs { get; }
	public float maxNearestNodeDistanceSqr { get; }
	[Obsolete("This field has been renamed to 'batchGraphUpdates'")]
	public bool limitGraphUpdates { get; set; }
	[Obsolete("This field has been renamed to 'graphUpdateBatchingInterval'")]
	public float maxGraphUpdateFreq { get; set; }
	public float lastScanTime { get; set; }
	public bool isScanning { get; set; }
	public int NumParallelThreads { get; }
	public bool IsUsingMultithreading { get; }
	[Obsolete("Fixed grammar, use IsAnyGraphUpdateQueued instead")]
	public bool IsAnyGraphUpdatesQueued { get; }
	public bool IsAnyGraphUpdateQueued { get; }
	public bool IsAnyGraphUpdateInProgress { get; }
	public bool IsAnyWorkItemInProgress { get; }
	internal bool IsInsideWorkItem { get; }

	// Methods

	// RVA: 0x530380 Offset: 0x52ED80 VA: 0x180530380
	public Type[] get_graphTypes() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public AstarData get_astarData() { }

	// RVA: 0xAF5A60 Offset: 0xAF4460 VA: 0x180AF5A60
	public NavGraph[] get_graphs() { }

	// RVA: 0xAF5AE0 Offset: 0xAF44E0 VA: 0x180AF5AE0
	public float get_maxNearestNodeDistanceSqr() { }

	// RVA: 0x4E23F0 Offset: 0x4E0DF0 VA: 0x1804E23F0
	public bool get_limitGraphUpdates() { }

	// RVA: 0x4E28E0 Offset: 0x4E12E0 VA: 0x1804E28E0
	public void set_limitGraphUpdates(bool value) { }

	// RVA: 0x80E390 Offset: 0x80CD90 VA: 0x18080E390
	public float get_maxGraphUpdateFreq() { }

	// RVA: 0x80E3A0 Offset: 0x80CDA0 VA: 0x18080E3A0
	public void set_maxGraphUpdateFreq(float value) { }

	[CompilerGenerated]
	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	public float get_lastScanTime() { }

	[CompilerGenerated]
	// RVA: 0xA546B0 Offset: 0xA530B0 VA: 0x180A546B0
	private void set_lastScanTime(float value) { }

	// RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0
	public bool get_isScanning() { }

	// RVA: 0xAE7D60 Offset: 0xAE6760 VA: 0x180AE7D60
	private void set_isScanning(bool value) { }

	// RVA: 0xAF5A30 Offset: 0xAF4430 VA: 0x180AF5A30
	public int get_NumParallelThreads() { }

	// RVA: 0xAF5A00 Offset: 0xAF4400 VA: 0x180AF5A00
	public bool get_IsUsingMultithreading() { }

	// RVA: 0xAF5990 Offset: 0xAF4390 VA: 0x180AF5990
	public bool get_IsAnyGraphUpdatesQueued() { }

	// RVA: 0xAF5990 Offset: 0xAF4390 VA: 0x180AF5990
	public bool get_IsAnyGraphUpdateQueued() { }

	// RVA: 0xAF5970 Offset: 0xAF4370 VA: 0x180AF5970
	public bool get_IsAnyGraphUpdateInProgress() { }

	// RVA: 0xAF59C0 Offset: 0xAF43C0 VA: 0x180AF59C0
	public bool get_IsAnyWorkItemInProgress() { }

	// RVA: 0xAF59E0 Offset: 0xAF43E0 VA: 0x180AF59E0
	internal bool get_IsInsideWorkItem() { }

	// RVA: 0xAF5670 Offset: 0xAF4070 VA: 0x180AF5670
	private void .ctor() { }

	// RVA: 0xAF2CC0 Offset: 0xAF16C0 VA: 0x180AF2CC0
	public string[] GetTagNames() { }

	// RVA: 0xAF1D70 Offset: 0xAF0770 VA: 0x180AF1D70
	public static void FindAstarPath() { }

	// RVA: 0xAF1FC0 Offset: 0xAF09C0 VA: 0x180AF1FC0
	public static string[] FindTagNames() { }

	// RVA: 0xAF2BE0 Offset: 0xAF15E0 VA: 0x180AF2BE0
	internal ushort GetNextPathID() { }

	// RVA: 0xAF3F40 Offset: 0xAF2940 VA: 0x180AF3F40
	private void RecalculateDebugLimits() { }

	// RVA: 0xAF3880 Offset: 0xAF2280 VA: 0x180AF3880
	private void OnDrawGizmos() { }

	// RVA: 0xAF3BA0 Offset: 0xAF25A0 VA: 0x180AF3BA0
	private void OnGUI() { }

	// RVA: 0xAF3240 Offset: 0xAF1C40 VA: 0x180AF3240
	private void LogPathResults(Path path) { }

	// RVA: 0xAF52C0 Offset: 0xAF3CC0 VA: 0x180AF52C0
	private void Update() { }

	// RVA: 0xAF3CB0 Offset: 0xAF26B0 VA: 0x180AF3CB0
	private void PerformBlockingActions(bool force = False) { }

	[Obsolete("This method has been moved. Use the method on the context object that can be sent with work item delegates instead")]
	// RVA: 0xAF3EF0 Offset: 0xAF28F0 VA: 0x180AF3EF0
	public void QueueWorkItemFloodFill() { }

	[Obsolete("This method has been moved. Use the method on the context object that can be sent with work item delegates instead")]
	// RVA: 0xAF1D20 Offset: 0xAF0720 VA: 0x180AF1D20
	public void EnsureValidFloodFill() { }

	// RVA: 0xAF0D80 Offset: 0xAEF780 VA: 0x180AF0D80
	public void AddWorkItem(Action callback) { }

	// RVA: 0xAF0CD0 Offset: 0xAEF6D0 VA: 0x180AF0CD0
	public void AddWorkItem(Action<IWorkItemContext> callback) { }

	// RVA: 0xAF0E30 Offset: 0xAEF830 VA: 0x180AF0E30
	public void AddWorkItem(AstarWorkItem item) { }

	// RVA: 0xAF3D50 Offset: 0xAF2750 VA: 0x180AF3D50
	public void QueueGraphUpdates() { }

	[IteratorStateMachine(typeof(AstarPath.<DelayedGraphUpdate>d__110))]
	// RVA: 0xAF1C80 Offset: 0xAF0680 VA: 0x180AF1C80
	private IEnumerator DelayedGraphUpdate() { }

	// RVA: 0xAF5090 Offset: 0xAF3A90 VA: 0x180AF5090
	public void UpdateGraphs(Bounds bounds, float delay) { }

	// RVA: 0xAF4FF0 Offset: 0xAF39F0 VA: 0x180AF4FF0
	public void UpdateGraphs(GraphUpdateObject ob, float delay) { }

	[IteratorStateMachine(typeof(AstarPath.<UpdateGraphsInternal>d__113))]
	// RVA: 0xAF4ED0 Offset: 0xAF38D0 VA: 0x180AF4ED0
	private IEnumerator UpdateGraphsInternal(GraphUpdateObject ob, float delay) { }

	// RVA: 0xAF4F70 Offset: 0xAF3970 VA: 0x180AF4F70
	public void UpdateGraphs(Bounds bounds) { }

	// RVA: 0xAF5180 Offset: 0xAF3B80 VA: 0x180AF5180
	public void UpdateGraphs(GraphUpdateObject ob) { }

	// RVA: 0xAF2250 Offset: 0xAF0C50 VA: 0x180AF2250
	public void FlushGraphUpdates() { }

	// RVA: 0xAF2320 Offset: 0xAF0D20 VA: 0x180AF2320
	public void FlushWorkItems() { }

	[Obsolete("Use FlushWorkItems() instead")]
	// RVA: 0xAF22B0 Offset: 0xAF0CB0 VA: 0x180AF22B0
	public void FlushWorkItems(bool unblockOnComplete, bool block) { }

	[Obsolete("Use FlushWorkItems instead")]
	// RVA: 0xAF22A0 Offset: 0xAF0CA0 VA: 0x180AF22A0
	public void FlushThreadSafeCallbacks() { }

	// RVA: 0xAF1A00 Offset: 0xAF0400 VA: 0x180AF1A00
	public static int CalculateThreadCount(ThreadCount count) { }

	// RVA: 0xAF0EC0 Offset: 0xAEF8C0 VA: 0x180AF0EC0 Slot: 7
	protected override void Awake() { }

	// RVA: 0xAF2E70 Offset: 0xAF1870 VA: 0x180AF2E70
	private void InitializePathProcessor() { }

	// RVA: 0xAF5370 Offset: 0xAF3D70 VA: 0x180AF5370
	internal void VerifyIntegrity() { }

	// RVA: 0xAF1B70 Offset: 0xAF0570 VA: 0x180AF1B70
	public void ConfigureReferencesInternal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void InitializeProfiler() { }

	// RVA: 0xAF2DF0 Offset: 0xAF17F0 VA: 0x180AF2DF0
	private void InitializeAstarData() { }

	// RVA: 0xAF3850 Offset: 0xAF2250 VA: 0x180AF3850
	private void OnDisable() { }

	// RVA: 0xAF33A0 Offset: 0xAF1DA0 VA: 0x180AF33A0
	private void OnDestroy() { }

	[Obsolete("Not meaningful anymore. The HierarchicalGraph takes care of things automatically behind the scenes")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void FloodFill(GraphNode seed) { }

	[Obsolete("Not meaningful anymore. The HierarchicalGraph takes care of things automatically behind the scenes")]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void FloodFill(GraphNode seed, uint area) { }

	[ContextMenu("Flood Fill Graphs")]
	[Obsolete("Avoid using. This will force a full recalculation of the connected components. In most cases the HierarchicalGraph class takes care of things automatically behind the scenes now.")]
	// RVA: 0xAF2210 Offset: 0xAF0C10 VA: 0x180AF2210
	public void FloodFill() { }

	// RVA: 0xAF2BB0 Offset: 0xAF15B0 VA: 0x180AF2BB0
	internal int GetNewNodeIndex() { }

	// RVA: 0xAF2E40 Offset: 0xAF1840 VA: 0x180AF2E40
	internal void InitializeNode(GraphNode node) { }

	// RVA: 0xAF1CF0 Offset: 0xAF06F0 VA: 0x180AF1CF0
	internal void DestroyNode(GraphNode node) { }

	[Obsolete("Use PausePathfinding instead. Make sure to call Release on the returned lock.", True)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	public void BlockUntilPathQueueBlocked() { }

	// RVA: 0xAF3C70 Offset: 0xAF2670 VA: 0x180AF3C70
	public PathProcessor.GraphUpdateLock PausePathfinding() { }

	// RVA: 0xAF3C30 Offset: 0xAF2630 VA: 0x180AF3C30
	private PathProcessor.GraphUpdateLock PausePathfindingSoon() { }

	// RVA: 0xAF4700 Offset: 0xAF3100 VA: 0x180AF4700
	public void Scan(NavGraph graphToScan) { }

	// RVA: 0xAF4510 Offset: 0xAF2F10 VA: 0x180AF4510
	public void Scan(NavGraph[] graphsToScan) { }

	// RVA: 0xAF43A0 Offset: 0xAF2DA0 VA: 0x180AF43A0
	public IEnumerable<Progress> ScanAsync(NavGraph graphToScan) { }

	[IteratorStateMachine(typeof(AstarPath.<ScanAsync>d__141))]
	// RVA: 0xAF4310 Offset: 0xAF2D10 VA: 0x180AF4310
	public IEnumerable<Progress> ScanAsync(NavGraph[] graphsToScan) { }

	[IteratorStateMachine(typeof(AstarPath.<ScanGraph>d__142))]
	// RVA: 0xAF4490 Offset: 0xAF2E90 VA: 0x180AF4490
	private IEnumerable<Progress> ScanGraph(NavGraph graph) { }

	[Obsolete("This method has been renamed to BlockUntilCalculated")]
	// RVA: 0xAF54F0 Offset: 0xAF3EF0 VA: 0x180AF54F0
	public static void WaitForPath(Path path) { }

	// RVA: 0xAF13B0 Offset: 0xAEFDB0 VA: 0x180AF13B0
	public static void BlockUntilCalculated(Path path) { }

	[Obsolete("Use AddWorkItem(System.Action) instead. Note the slight change in behavior (mentioned in the documentation).")]
	// RVA: 0xAF4210 Offset: 0xAF2C10 VA: 0x180AF4210
	public static void RegisterSafeUpdate(Action callback) { }

	// RVA: 0xAF47F0 Offset: 0xAF31F0 VA: 0x180AF47F0
	public static void StartPath(Path path, bool pushToFront = False) { }

	// RVA: 0xAF2850 Offset: 0xAF1250 VA: 0x180AF2850
	public NNInfo GetNearest(Vector3 position) { }

	// RVA: 0xAF2B60 Offset: 0xAF1560 VA: 0x180AF2B60
	public NNInfo GetNearest(Vector3 position, NNConstraint constraint) { }

	// RVA: 0xAF23A0 Offset: 0xAF0DA0 VA: 0x180AF23A0
	public NNInfo GetNearest(Vector3 position, NNConstraint constraint, GraphNode hint) { }

	// RVA: 0xAF2910 Offset: 0xAF1310 VA: 0x180AF2910
	public GraphNode GetNearest(Ray ray) { }

	// RVA: 0xAF5540 Offset: 0xAF3F40 VA: 0x180AF5540
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0xAF4E30 Offset: 0xAF3830 VA: 0x180AF4E30
	private void <.ctor>b__92_0() { }

	[CompilerGenerated]
	// RVA: 0xAF4C40 Offset: 0xAF3640 VA: 0x180AF4C40
	private void <InitializePathProcessor>b__122_1(Path path) { }

	[CompilerGenerated]
	// RVA: 0xAF4E00 Offset: 0xAF3800 VA: 0x180AF4E00
	private void <InitializePathProcessor>b__122_2() { }
}
