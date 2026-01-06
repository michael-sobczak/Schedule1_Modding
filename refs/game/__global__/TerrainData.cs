public sealed class TerrainData : Object // TypeDefIndex: 19000
{
	// Fields
	internal static readonly int k_MaximumResolution; // 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; // 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; // 0x8
	internal static readonly int k_MaximumDetailPatchCount; // 0xC
	internal static readonly int k_MinimumAlphamapResolution; // 0x10
	internal static readonly int k_MaximumAlphamapResolution; // 0x14
	internal static readonly int k_MinimumBaseMapResolution; // 0x18
	internal static readonly int k_MaximumBaseMapResolution; // 0x1C

	// Properties
	public int heightmapResolution { get; }
	private int internalHeightmapResolution { get; }
	public Vector3 heightmapScale { get; }
	public Vector3 size { get; }
	public TreeInstance[] treeInstances { get; }
	public TreePrototype[] treePrototypes { get; }
	internal Terrain[] users { get; }

	// Methods

	[StaticAccessor("TerrainDataScriptingInterface", 2)]
	[ThreadSafe]
	// RVA: 0x2D44B70 Offset: 0x2D43570 VA: 0x182D44B70
	private static int GetBoundaryValue(TerrainData.BoundaryValueType type) { }

	// RVA: 0x2D44FB0 Offset: 0x2D439B0 VA: 0x182D44FB0
	public void .ctor() { }

	[FreeFunction("TerrainDataScriptingInterface::Create")]
	// RVA: 0x2D44CF0 Offset: 0x2D436F0 VA: 0x182D44CF0
	private static void Internal_Create(TerrainData terrainData) { }

	// RVA: 0x2D45040 Offset: 0x2D43A40 VA: 0x182D45040
	public int get_heightmapResolution() { }

	[NativeName("GetHeightmap().GetResolution")]
	// RVA: 0x2D45040 Offset: 0x2D43A40 VA: 0x182D45040
	private int get_internalHeightmapResolution() { }

	[NativeName("GetHeightmap().GetScale")]
	// RVA: 0x2D450D0 Offset: 0x2D43AD0 VA: 0x182D450D0
	public Vector3 get_heightmapScale() { }

	[NativeName("GetHeightmap().GetSize")]
	// RVA: 0x2D45170 Offset: 0x2D43B70 VA: 0x182D45170
	public Vector3 get_size() { }

	// RVA: 0x2D44BB0 Offset: 0x2D435B0 VA: 0x182D44BB0
	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunction("TerrainDataScriptingInterface::GetHeights", HasExplicitThis = True)]
	// RVA: 0x2D44D30 Offset: 0x2D43730 VA: 0x182D44D30
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	// RVA: 0x2D44D90 Offset: 0x2D43790 VA: 0x182D44D90
	public TreeInstance[] get_treeInstances() { }

	[NativeName("GetTreeDatabase().GetInstances")]
	// RVA: 0x2D44D90 Offset: 0x2D43790 VA: 0x182D44D90
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunction("TerrainDataScriptingInterface::GetTreePrototypes", HasExplicitThis = True)]
	// RVA: 0x2D451C0 Offset: 0x2D43BC0 VA: 0x182D451C0
	public TreePrototype[] get_treePrototypes() { }

	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	// RVA: 0x2D44B30 Offset: 0x2D43530 VA: 0x182D44B30
	internal float GetAlphamapResolutionInternal() { }

	// RVA: 0x2D45200 Offset: 0x2D43C00 VA: 0x182D45200
	internal Terrain[] get_users() { }

	// RVA: 0x2D44DD0 Offset: 0x2D437D0 VA: 0x182D44DD0
	private static void .cctor() { }

	// RVA: 0x2D45080 Offset: 0x2D43A80 VA: 0x182D45080
	private void get_heightmapScale_Injected(out Vector3 ret) { }

	// RVA: 0x2D45120 Offset: 0x2D43B20 VA: 0x182D45120
	private void get_size_Injected(out Vector3 ret) { }
}
