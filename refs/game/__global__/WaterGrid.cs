public class WaterGrid : MonoBehaviour // TypeDefIndex: 18268
{
	// Fields
	[Tooltip("Material used on the tile meshes")]
	public Material material; // 0x20
	[Tooltip("When not in play-mode, the water will follow the scene-view camera position.")]
	public bool followSceneCamera; // 0x28
	[Tooltip("If enabled, the object with the "MainCamera" tag will be assigned as the follow target when entering play mode")]
	public bool autoAssignCamera; // 0x29
	[Tooltip("The grid will follow this Transform's position on the XZ axis. Ideally set to the camera's transform.")]
	public Transform followTarget; // 0x30
	[Tooltip("Scale of the entire grid in the length and width")]
	public float scale; // 0x38
	[Tooltip("Distance between vertices, rather higher than lower")]
	[Range(0.15, 10)]
	public float vertexDistance; // 0x3C
	[Min(0)]
	public int rowsColumns; // 0x40
	[HideInInspector]
	public int m_rowsColumns; // 0x44
	[SerializeField]
	[HideInInspector]
	private Mesh mesh; // 0x48
	[HideInInspector]
	[SerializeField]
	private List<WaterObject> objects; // 0x50
	private float tileSize; // 0x58
	private WaterObject m_waterObject; // 0x60
	private Transform actualFollowTarget; // 0x68
	private Vector3 targetPosition; // 0x70

	// Methods

	// RVA: 0x1F70570 Offset: 0x1F6EF70 VA: 0x181F70570
	private void Reset() { }

	// RVA: 0x1F70610 Offset: 0x1F6F010 VA: 0x181F70610
	private void Start() { }

	// RVA: 0x1F6FC60 Offset: 0x1F6E660 VA: 0x181F6FC60
	private void OnEnable() { }

	// RVA: 0x1F706B0 Offset: 0x1F6F0B0 VA: 0x181F706B0
	private void Update() { }

	// RVA: 0x1F70000 Offset: 0x1F6EA00 VA: 0x181F70000
	public void Recreate() { }

	// RVA: 0x1F6FB60 Offset: 0x1F6E560 VA: 0x181F6FB60
	private void CalculateTileSize() { }

	// RVA: 0x1F6FE70 Offset: 0x1F6E870 VA: 0x181F6FE70
	private void RecreateMesh() { }

	// RVA: 0x1F6FCE0 Offset: 0x1F6E6E0 VA: 0x181F6FCE0
	private void ReassignMesh() { }

	// RVA: 0x1F6FBE0 Offset: 0x1F6E5E0 VA: 0x181F6FBE0
	private Vector3 GridLocalCenterPosition(int x, int z) { }

	// RVA: 0x1F70580 Offset: 0x1F6EF80 VA: 0x181F70580
	public static Vector3 SnapToGrid(Vector3 position, float cellSize) { }

	// RVA: 0x1F63C60 Offset: 0x1F62660 VA: 0x181F63C60
	private static float SnapToGrid(float position, float cellSize) { }

	// RVA: 0x1F70860 Offset: 0x1F6F260 VA: 0x181F70860
	public void .ctor() { }
}
