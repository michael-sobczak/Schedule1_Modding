public class AstarData // TypeDefIndex: 13148
{
	// Fields
	[CompilerGenerated]
	private NavMeshGraph <navmesh>k__BackingField; // 0x10
	[CompilerGenerated]
	private GridGraph <gridGraph>k__BackingField; // 0x18
	[CompilerGenerated]
	private LayerGridGraph <layerGridGraph>k__BackingField; // 0x20
	[CompilerGenerated]
	private PointGraph <pointGraph>k__BackingField; // 0x28
	[CompilerGenerated]
	private RecastGraph <recastGraph>k__BackingField; // 0x30
	[CompilerGenerated]
	private Type[] <graphTypes>k__BackingField; // 0x38
	public NavGraph[] graphs; // 0x40
	[SerializeField]
	private string dataString; // 0x48
	[FormerlySerializedAs("data")]
	[SerializeField]
	private byte[] upgradeData; // 0x50
	public TextAsset file_cachedStartup; // 0x58
	public byte[] data_cachedStartup; // 0x60
	[SerializeField]
	public bool cacheStartup; // 0x68
	private List<bool> graphStructureLocked; // 0x70

	// Properties
	public static AstarPath active { get; }
	public NavMeshGraph navmesh { get; set; }
	public GridGraph gridGraph { get; set; }
	public LayerGridGraph layerGridGraph { get; set; }
	public PointGraph pointGraph { get; set; }
	public RecastGraph recastGraph { get; set; }
	public Type[] graphTypes { get; set; }
	private byte[] data { get; set; }

	// Methods

	// RVA: 0xB06550 Offset: 0xB04F50 VA: 0x180B06550
	public static AstarPath get_active() { }

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public NavMeshGraph get_navmesh() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_navmesh(NavMeshGraph value) { }

	[CompilerGenerated]
	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public GridGraph get_gridGraph() { }

	[CompilerGenerated]
	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	private void set_gridGraph(GridGraph value) { }

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public LayerGridGraph get_layerGridGraph() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	private void set_layerGridGraph(LayerGridGraph value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public PointGraph get_pointGraph() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	private void set_pointGraph(PointGraph value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public RecastGraph get_recastGraph() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	private void set_recastGraph(RecastGraph value) { }

	[CompilerGenerated]
	// RVA: 0x4513B0 Offset: 0x44FDB0 VA: 0x1804513B0
	public Type[] get_graphTypes() { }

	[CompilerGenerated]
	// RVA: 0x4513E0 Offset: 0x44FDE0 VA: 0x1804513E0
	private void set_graphTypes(Type[] value) { }

	// RVA: 0xB065A0 Offset: 0xB04FA0 VA: 0x180B065A0
	private byte[] get_data() { }

	// RVA: 0xB06070 Offset: 0xB04A70 VA: 0x180B06070
	private void set_data(byte[] value) { }

	// RVA: 0xB05500 Offset: 0xB03F00 VA: 0x180B05500
	public byte[] GetData() { }

	// RVA: 0xB06070 Offset: 0xB04A70 VA: 0x180B06070
	public void SetData(byte[] data) { }

	// RVA: 0xB04100 Offset: 0xB02B00 VA: 0x180B04100
	public void Awake() { }

	// RVA: 0xB05AE0 Offset: 0xB044E0 VA: 0x180B05AE0
	internal void LockGraphStructure(bool allowAddingGraphs = False) { }

	// RVA: 0xB060F0 Offset: 0xB04AF0 VA: 0x180B060F0
	internal void UnlockGraphStructure() { }

	// RVA: 0xB03E60 Offset: 0xB02860 VA: 0x180B03E60
	private PathProcessor.GraphUpdateLock AssertSafe(bool onlyAddingGraph = False) { }

	// RVA: 0xB057E0 Offset: 0xB041E0 VA: 0x180B057E0
	public void GetNodes(Action<GraphNode> callback) { }

	// RVA: 0xB06190 Offset: 0xB04B90 VA: 0x180B06190
	public void UpdateShortcuts() { }

	// RVA: 0xB05980 Offset: 0xB04380 VA: 0x180B05980
	public void LoadFromCache() { }

	// RVA: 0xB05DD0 Offset: 0xB047D0 VA: 0x180B05DD0
	public byte[] SerializeGraphs() { }

	// RVA: 0xB05C90 Offset: 0xB04690 VA: 0x180B05C90
	public byte[] SerializeGraphs(SerializeSettings settings) { }

	// RVA: 0xB05F20 Offset: 0xB04920 VA: 0x180B05F20
	public byte[] SerializeGraphs(SerializeSettings settings, out uint checksum) { }

	// RVA: 0xB04DC0 Offset: 0xB037C0 VA: 0x180B04DC0
	public void DeserializeGraphs() { }

	// RVA: 0xB04340 Offset: 0xB02D40 VA: 0x180B04340
	private void ClearGraphs() { }

	// RVA: 0xB05B80 Offset: 0xB04580 VA: 0x180B05B80
	public void OnDestroy() { }

	// RVA: 0xB04E40 Offset: 0xB03840 VA: 0x180B04E40
	public void DeserializeGraphs(byte[] bytes) { }

	// RVA: 0xB046E0 Offset: 0xB030E0 VA: 0x180B046E0
	public void DeserializeGraphsAdditive(byte[] bytes) { }

	// RVA: 0xB049B0 Offset: 0xB033B0 VA: 0x180B049B0
	private void DeserializeGraphsPartAdditive(AstarSerializer sr) { }

	// RVA: 0xB05000 Offset: 0xB03A00 VA: 0x180B05000
	public void FindGraphTypes() { }

	[Obsolete("If really necessary. Use System.Type.GetType instead.")]
	// RVA: 0xB05610 Offset: 0xB04010 VA: 0x180B05610
	public Type GetGraphType(string type) { }

	[Obsolete("Use CreateGraph(System.Type) instead")]
	// RVA: 0xB04460 Offset: 0xB02E60 VA: 0x180B04460
	public NavGraph CreateGraph(string type) { }

	// RVA: 0xB04600 Offset: 0xB03000 VA: 0x180B04600
	internal NavGraph CreateGraph(Type type) { }

	[Obsolete("Use AddGraph(System.Type) instead")]
	// RVA: 0xB03A90 Offset: 0xB02490 VA: 0x180B03A90
	public NavGraph AddGraph(string type) { }

	// RVA: 0xB03C10 Offset: 0xB02610 VA: 0x180B03C10
	public NavGraph AddGraph(Type type) { }

	// RVA: 0xB03760 Offset: 0xB02160 VA: 0x180B03760
	private void AddGraph(NavGraph graph) { }

	// RVA: 0xB05B90 Offset: 0xB04590 VA: 0x180B05B90
	public bool RemoveGraph(NavGraph graph) { }

	// RVA: 0xB056E0 Offset: 0xB040E0 VA: 0x180B056E0
	public static NavGraph GetGraph(GraphNode node) { }

	// RVA: 0xB053B0 Offset: 0xB03DB0 VA: 0x180B053B0
	public NavGraph FindGraph(Func<NavGraph, bool> predicate) { }

	// RVA: 0xB04EB0 Offset: 0xB038B0 VA: 0x180B04EB0
	public NavGraph FindGraphOfType(Type type) { }

	// RVA: 0xB05260 Offset: 0xB03C60 VA: 0x180B05260
	public NavGraph FindGraphWhichInheritsFrom(Type type) { }

	[IteratorStateMachine(typeof(AstarData.<FindGraphsOfType>d__66))]
	// RVA: 0xB05470 Offset: 0xB03E70 VA: 0x180B05470
	public IEnumerable FindGraphsOfType(Type type) { }

	[IteratorStateMachine(typeof(AstarData.<GetUpdateableGraphs>d__67))]
	// RVA: 0xB05900 Offset: 0xB04300 VA: 0x180B05900
	public IEnumerable GetUpdateableGraphs() { }

	[IteratorStateMachine(typeof(AstarData.<GetRaycastableGraphs>d__68))]
	[Obsolete("Obsolete because it is not used by the package internally and the use cases are few. Iterate through the graphs array instead.")]
	// RVA: 0xB05880 Offset: 0xB04280 VA: 0x180B05880
	public IEnumerable GetRaycastableGraphs() { }

	// RVA: 0xB05510 Offset: 0xB03F10 VA: 0x180B05510
	public int GetGraphIndex(NavGraph graph) { }

	// RVA: 0xB064A0 Offset: 0xB04EA0 VA: 0x180B064A0
	public void .ctor() { }
}
