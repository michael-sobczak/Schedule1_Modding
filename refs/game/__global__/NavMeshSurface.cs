public class NavMeshSurface : MonoBehaviour // TypeDefIndex: 18988
{
	// Fields
	[SerializeField]
	private int m_AgentTypeID; // 0x20
	[SerializeField]
	private CollectObjects m_CollectObjects; // 0x24
	[SerializeField]
	private Vector3 m_Size; // 0x28
	[SerializeField]
	private Vector3 m_Center; // 0x34
	[SerializeField]
	private LayerMask m_LayerMask; // 0x40
	[SerializeField]
	private NavMeshCollectGeometry m_UseGeometry; // 0x44
	[SerializeField]
	private int m_DefaultArea; // 0x48
	[SerializeField]
	private bool m_GenerateLinks; // 0x4C
	[SerializeField]
	private bool m_IgnoreNavMeshAgent; // 0x4D
	[SerializeField]
	private bool m_IgnoreNavMeshObstacle; // 0x4E
	[SerializeField]
	private bool m_OverrideTileSize; // 0x4F
	[SerializeField]
	private int m_TileSize; // 0x50
	[SerializeField]
	private bool m_OverrideVoxelSize; // 0x54
	[SerializeField]
	private float m_VoxelSize; // 0x58
	[SerializeField]
	private float m_MinRegionArea; // 0x5C
	[FormerlySerializedAs("m_BakedNavMeshData")]
	[SerializeField]
	private NavMeshData m_NavMeshData; // 0x60
	[SerializeField]
	private bool m_BuildHeightMesh; // 0x68
	private NavMeshDataInstance m_NavMeshDataInstance; // 0x6C
	private Vector3 m_LastPosition; // 0x70
	private Quaternion m_LastRotation; // 0x7C
	private static readonly List<NavMeshSurface> s_NavMeshSurfaces; // 0x0

	// Properties
	public int agentTypeID { get; set; }
	public CollectObjects collectObjects { get; set; }
	public Vector3 size { get; set; }
	public Vector3 center { get; set; }
	public LayerMask layerMask { get; set; }
	public NavMeshCollectGeometry useGeometry { get; set; }
	public int defaultArea { get; set; }
	public bool ignoreNavMeshAgent { get; set; }
	public bool ignoreNavMeshObstacle { get; set; }
	public bool overrideTileSize { get; set; }
	public int tileSize { get; set; }
	public bool overrideVoxelSize { get; set; }
	public float voxelSize { get; set; }
	public float minRegionArea { get; set; }
	public bool buildHeightMesh { get; set; }
	public NavMeshData navMeshData { get; set; }
	internal NavMeshDataInstance navMeshDataInstance { get; }
	public static List<NavMeshSurface> activeSurfaces { get; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_agentTypeID() { }

	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	public void set_agentTypeID(int value) { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public CollectObjects get_collectObjects() { }

	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	public void set_collectObjects(CollectObjects value) { }

	// RVA: 0x5871F0 Offset: 0x585BF0 VA: 0x1805871F0
	public Vector3 get_size() { }

	// RVA: 0x587100 Offset: 0x585B00 VA: 0x180587100
	public void set_size(Vector3 value) { }

	// RVA: 0x26D5E20 Offset: 0x26D4820 VA: 0x1826D5E20
	public Vector3 get_center() { }

	// RVA: 0x26D5E60 Offset: 0x26D4860 VA: 0x1826D5E60
	public void set_center(Vector3 value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public LayerMask get_layerMask() { }

	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	public void set_layerMask(LayerMask value) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public NavMeshCollectGeometry get_useGeometry() { }

	// RVA: 0x1EEA950 Offset: 0x1EE9350 VA: 0x181EEA950
	public void set_useGeometry(NavMeshCollectGeometry value) { }

	// RVA: 0x4B61C0 Offset: 0x4B4BC0 VA: 0x1804B61C0
	public int get_defaultArea() { }

	// RVA: 0x4E28C0 Offset: 0x4E12C0 VA: 0x1804E28C0
	public void set_defaultArea(int value) { }

	// RVA: 0x4B5410 Offset: 0x4B3E10 VA: 0x1804B5410
	public bool get_ignoreNavMeshAgent() { }

	// RVA: 0x26D5E70 Offset: 0x26D4870 VA: 0x1826D5E70
	public void set_ignoreNavMeshAgent(bool value) { }

	// RVA: 0x26D5E40 Offset: 0x26D4840 VA: 0x1826D5E40
	public bool get_ignoreNavMeshObstacle() { }

	// RVA: 0x26D5E80 Offset: 0x26D4880 VA: 0x1826D5E80
	public void set_ignoreNavMeshObstacle(bool value) { }

	// RVA: 0x26D5E50 Offset: 0x26D4850 VA: 0x1826D5E50
	public bool get_overrideTileSize() { }

	// RVA: 0x26D5E90 Offset: 0x26D4890 VA: 0x1826D5E90
	public void set_overrideTileSize(bool value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_tileSize() { }

	// RVA: 0x4E28A0 Offset: 0x4E12A0 VA: 0x1804E28A0
	public void set_tileSize(int value) { }

	// RVA: 0x4E2420 Offset: 0x4E0E20 VA: 0x1804E2420
	public bool get_overrideVoxelSize() { }

	// RVA: 0x4E2920 Offset: 0x4E1320 VA: 0x1804E2920
	public void set_overrideVoxelSize(bool value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_voxelSize() { }

	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	public void set_voxelSize(float value) { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_minRegionArea() { }

	// RVA: 0xD3E1E0 Offset: 0xD3CBE0 VA: 0x180D3E1E0
	public void set_minRegionArea(float value) { }

	// RVA: 0xCE3DC0 Offset: 0xCE27C0 VA: 0x180CE3DC0
	public bool get_buildHeightMesh() { }

	// RVA: 0xCE3E20 Offset: 0xCE2820 VA: 0x180CE3E20
	public void set_buildHeightMesh(bool value) { }

	// RVA: 0x4C4BF0 Offset: 0x4C35F0 VA: 0x1804C4BF0
	public NavMeshData get_navMeshData() { }

	// RVA: 0x5F4ED0 Offset: 0x5F38D0 VA: 0x1805F4ED0
	public void set_navMeshData(NavMeshData value) { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	internal NavMeshDataInstance get_navMeshDataInstance() { }

	// RVA: 0x26D5DD0 Offset: 0x26D47D0 VA: 0x1826D5DD0
	public static List<NavMeshSurface> get_activeSurfaces() { }

	// RVA: 0x26D4B50 Offset: 0x26D3550 VA: 0x1826D4B50
	private Bounds GetInflatedBounds() { }

	// RVA: 0x26D52B0 Offset: 0x26D3CB0 VA: 0x1826D52B0
	private void OnEnable() { }

	// RVA: 0x26D50C0 Offset: 0x26D3AC0 VA: 0x1826D50C0
	private void OnDisable() { }

	// RVA: 0x26D2B50 Offset: 0x26D1550 VA: 0x1826D2B50
	public void AddData() { }

	// RVA: 0x26D5580 Offset: 0x26D3F80 VA: 0x1826D5580
	public void RemoveData() { }

	// RVA: 0x26D49E0 Offset: 0x26D33E0 VA: 0x1826D49E0
	public NavMeshBuildSettings GetBuildSettings() { }

	// RVA: 0x26D3370 Offset: 0x26D1D70 VA: 0x1826D3370
	public void BuildNavMesh() { }

	// RVA: 0x26D5AD0 Offset: 0x26D44D0 VA: 0x1826D5AD0
	public AsyncOperation UpdateNavMesh(NavMeshData data) { }

	// RVA: 0x26D5310 Offset: 0x26D3D10 VA: 0x1826D5310
	private static void Register(NavMeshSurface surface) { }

	// RVA: 0x26D55A0 Offset: 0x26D3FA0 VA: 0x1826D55A0
	private static void Unregister(NavMeshSurface surface) { }

	// RVA: 0x26D5750 Offset: 0x26D4150 VA: 0x1826D5750
	private static void UpdateActive() { }

	// RVA: 0x26D2CC0 Offset: 0x26D16C0 VA: 0x1826D2CC0
	private void AppendModifierVolumes(ref List<NavMeshBuildSource> sources) { }

	// RVA: 0x26D3FC0 Offset: 0x26D29C0 VA: 0x1826D3FC0
	private List<NavMeshBuildSource> CollectSources() { }

	// RVA: 0xC4D8C0 Offset: 0xC4C2C0 VA: 0x180C4D8C0
	private static Vector3 Abs(Vector3 v) { }

	// RVA: 0x26D4C60 Offset: 0x26D3660 VA: 0x1826D4C60
	private static Bounds GetWorldBounds(Matrix4x4 mat, Bounds bounds) { }

	// RVA: 0x26D3650 Offset: 0x26D2050 VA: 0x1826D3650
	private Bounds CalculateWorldBounds(List<NavMeshBuildSource> sources) { }

	// RVA: 0x26D4F80 Offset: 0x26D3980 VA: 0x1826D4F80
	private bool HasTransformChanged() { }

	// RVA: 0x26D5990 Offset: 0x26D4390 VA: 0x1826D5990
	private void UpdateDataIfTransformChanged() { }

	// RVA: 0x26D5CF0 Offset: 0x26D46F0 VA: 0x1826D5CF0
	public void .ctor() { }

	// RVA: 0x26D5C60 Offset: 0x26D4660 VA: 0x1826D5C60
	private static void .cctor() { }
}
