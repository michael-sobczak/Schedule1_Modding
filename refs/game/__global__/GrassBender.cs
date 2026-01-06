public class GrassBender : MonoBehaviour // TypeDefIndex: 18842
{
	// Fields
	[Tooltip("Higher layers are always drawn over lower layers. Use this to override other benders on a lower layer.")]
	[Range(0, 4)]
	public int sortingLayer; // 0x20
	public Renderer renderer; // 0x28
	[Range(-1, 1)]
	public float heightOffset; // 0x30
	[Range(0, 3)]
	[FormerlySerializedAs("strength")]
	public float flattenStrength; // 0x34
	[Range(0, 3)]
	public float pushStrength; // 0x38
	[Range(0, 3)]
	public float scaleMultiplier; // 0x3C
	[Tooltip("When enabled, overlapping benders of the same type will blend together")]
	public bool alphaBlending; // 0x40
	public MeshFilter meshFilter; // 0x48
	public TrailRenderer trailRenderer; // 0x50
	[Tooltip("Jitter the position of the trail, to force the mesh to constantly update")]
	public bool forceUpdating; // 0x58
	public LineRenderer lineRenderer; // 0x60
	private MaterialPropertyBlock _props; // 0x68
	private Material material; // 0x70
	[SerializeField]
	private Shader bendingShader; // 0x78
	private readonly int paramsID; // 0x80
	private readonly int _SrcFactor; // 0x84
	private readonly int _DstFactor; // 0x88
	private Vector3 targetPosition; // 0x8C
	private static Vector3 TrailRotation; // 0x0
	private const string TRAIL_KEYWORD = "_TRAIL";
	public const string MESH_SHADER_OPAQUE_NAME = "Hidden/Nature/Grass Bend Mesh";
	private static Material _TrailMaterial; // 0x10
	private static Material _MeshMaterial; // 0x18

	// Properties
	public MaterialPropertyBlock props { get; }
	private static Material TrailMaterial { get; }
	private static Material MeshMaterial { get; }

	// Methods

	// RVA: 0x1F60020 Offset: 0x1F5EA20 VA: 0x181F60020
	public MaterialPropertyBlock get_props() { }

	// RVA: 0x1F5F470 Offset: 0x1F5DE70 VA: 0x181F5F470
	private void Reset() { }

	// RVA: 0x1F5F330 Offset: 0x1F5DD30 VA: 0x181F5F330
	public void OnEnable() { }

	// RVA: 0x1F5F4C0 Offset: 0x1F5DEC0 VA: 0x181F5F4C0
	private void SetupMaterial() { }

	// RVA: 0x1F5F690 Offset: 0x1F5E090 VA: 0x181F5F690
	public void UpdateProperties() { }

	// RVA: 0x1F5EDA0 Offset: 0x1F5D7A0 VA: 0x181F5EDA0
	public void GetRenderer() { }

	// RVA: 0x1F5EFF0 Offset: 0x1F5D9F0 VA: 0x181F5EFF0
	private void OnDisable() { }

	// RVA: 0x1F5F8A0 Offset: 0x1F5E2A0 VA: 0x181F5F8A0
	private void Update() { }

	// RVA: 0x1F5E920 Offset: 0x1F5D320 VA: 0x181F5E920
	public static Material GetMaterial(Type type) { }

	// RVA: 0x1F5FE40 Offset: 0x1F5E840 VA: 0x181F5FE40
	private static Material get_TrailMaterial() { }

	// RVA: 0x1F5FC60 Offset: 0x1F5E660 VA: 0x181F5FC60
	private static Material get_MeshMaterial() { }

	// RVA: 0x1F5F070 Offset: 0x1F5DA70 VA: 0x181F5F070
	private void OnDrawGizmosSelected() { }

	// RVA: 0x1F5FBC0 Offset: 0x1F5E5C0 VA: 0x181F5FBC0
	public void .ctor() { }

	// RVA: 0x1F5FB70 Offset: 0x1F5E570 VA: 0x181F5FB70
	private static void .cctor() { }
}
