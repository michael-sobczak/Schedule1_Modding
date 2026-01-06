public abstract class BeamGeometryAbstractBase : MonoBehaviour // TypeDefIndex: 226
{
	// Fields
	[CompilerGenerated]
	private MeshRenderer <meshRenderer>k__BackingField; // 0x20
	[CompilerGenerated]
	private MeshFilter <meshFilter>k__BackingField; // 0x28
	[CompilerGenerated]
	private Mesh <coneMesh>k__BackingField; // 0x30
	protected Matrix4x4 m_ColorGradientMatrix; // 0x38
	protected Material m_CustomMaterial; // 0x78

	// Properties
	public MeshRenderer meshRenderer { get; set; }
	public MeshFilter meshFilter { get; set; }
	public Mesh coneMesh { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public MeshRenderer get_meshRenderer() { }

	[CompilerGenerated]
	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	protected void set_meshRenderer(MeshRenderer value) { }

	[CompilerGenerated]
	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0
	public MeshFilter get_meshFilter() { }

	[CompilerGenerated]
	// RVA: 0x4513F0 Offset: 0x44FDF0 VA: 0x1804513F0
	protected void set_meshFilter(MeshFilter value) { }

	[CompilerGenerated]
	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public Mesh get_coneMesh() { }

	[CompilerGenerated]
	// RVA: 0x4513D0 Offset: 0x44FDD0 VA: 0x1804513D0
	protected void set_coneMesh(Mesh value) { }

	// RVA: -1 Offset: -1 Slot: 4
	protected abstract VolumetricLightBeamAbstractBase GetMaster();

	// RVA: 0x692880 Offset: 0x691280 VA: 0x180692880
	private void Start() { }

	// RVA: 0x692960 Offset: 0x691360 VA: 0x180692960
	private void OnDestroy() { }

	// RVA: 0x692880 Offset: 0x691280 VA: 0x180692880
	private void DestroyInvalidOwner() { }

	// RVA: 0x6927F0 Offset: 0x6911F0 VA: 0x1806927F0
	public static void DestroyBeamGeometryGameObject(BeamGeometryAbstractBase beamGeom) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }
}
