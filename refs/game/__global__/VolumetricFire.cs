public class VolumetricFire : MonoBehaviour // TypeDefIndex: 101
{
	// Fields
	private Mesh mesh; // 0x20
	private Material material; // 0x28
	[Range(1, 20)]
	[Tooltip("Controls the number of additional meshes to render in front of and behind the original mesh")]
	[SerializeField]
	private int thickness; // 0x30
	[Tooltip("Controls the total distance between the frontmost mesh and the backmost mesh")]
	[Range(0.01, 1)]
	[SerializeField]
	private float spread; // 0x34
	[SerializeField]
	private bool billboard; // 0x38
	private MaterialPropertyBlock materialPropertyBlock; // 0x40
	private int internalCount; // 0x48
	private float randomStatic; // 0x4C
	private Collider boundaryCollider; // 0x50

	// Methods

	// RVA: 0x57FB40 Offset: 0x57E540 VA: 0x18057FB40
	private void Start() { }

	// RVA: 0x57F850 Offset: 0x57E250 VA: 0x18057F850
	private void OnEnable() { }

	// RVA: 0x57F7C0 Offset: 0x57E1C0 VA: 0x18057F7C0
	private void OnDisable() { }

	// RVA: 0x57F780 Offset: 0x57E180 VA: 0x18057F780
	private static bool IsVisible(Camera camera, Bounds bounds) { }

	// RVA: 0x57F8E0 Offset: 0x57E2E0 VA: 0x18057F8E0
	private void RenderFlames(ScriptableRenderContext context, Camera camera) { }

	// RVA: 0x57FA90 Offset: 0x57E490 VA: 0x18057FA90
	private void SetupMaterialPropertyBlock(float item) { }

	// RVA: 0x57F170 Offset: 0x57DB70 VA: 0x18057F170
	private void CreateItem(float spacing, float item, Camera camera) { }

	// RVA: 0x57FC70 Offset: 0x57E670 VA: 0x18057FC70
	public void .ctor() { }
}
