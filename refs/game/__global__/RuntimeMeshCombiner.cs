public class RuntimeMeshCombiner : MonoBehaviour // TypeDefIndex: 10372
{
	// Fields
	private int MAX_VERTICES_FOR_16BITS_MESH; // 0x20
	private Vector3 originalPosition; // 0x24
	private Vector3 originalEulerAngles; // 0x30
	private Vector3 originalScale; // 0x3C
	private List<RuntimeMeshCombiner.OriginalGameObjectWithMesh> originalGameObjectsWithMeshToRestore; // 0x48
	private bool targetMeshesMerged; // 0x50
	[HideInInspector]
	public RuntimeMeshCombiner.AfterMerge afterMerge; // 0x54
	[HideInInspector]
	public bool addMeshColliderAfter; // 0x58
	[HideInInspector]
	public RuntimeMeshCombiner.CombineOnStart combineMeshesAtStartUp; // 0x5C
	[HideInInspector]
	public bool combineInChildren; // 0x60
	[HideInInspector]
	public bool combineInactives; // 0x61
	[HideInInspector]
	public bool recalculateNormals; // 0x62
	[HideInInspector]
	public bool recalculateTangents; // 0x63
	[HideInInspector]
	public bool optimizeResultingMesh; // 0x64
	[HideInInspector]
	public List<GameObject> targetMeshes; // 0x68
	[HideInInspector]
	public bool showDebugLogs; // 0x70
	[HideInInspector]
	public bool garbageCollectorAfterUndo; // 0x71
	public UnityEvent onDoneMerge; // 0x78
	public UnityEvent onDoneUnmerge; // 0x80

	// Methods

	// RVA: 0x499B50 Offset: 0x498550 VA: 0x180499B50
	private void Awake() { }

	// RVA: 0x49C3A0 Offset: 0x49ADA0 VA: 0x18049C3A0
	private void Start() { }

	// RVA: 0x49B450 Offset: 0x499E50 VA: 0x18049B450
	private RuntimeMeshCombiner.GameObjectWithMesh[] GetValidatedTargetGameObjects() { }

	// RVA: 0x499C20 Offset: 0x498620 VA: 0x180499C20
	public bool CombineMeshes() { }

	// RVA: 0x49C470 Offset: 0x49AE70 VA: 0x18049C470
	public bool UndoMerge() { }

	// RVA: 0x49CAE0 Offset: 0x49B4E0 VA: 0x18049CAE0
	public bool isTargetMeshesMerged() { }

	// RVA: 0x49C960 Offset: 0x49B360 VA: 0x18049C960
	public void .ctor() { }
}
