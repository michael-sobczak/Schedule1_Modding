public class SmartMeshData // TypeDefIndex: 65
{
	// Fields
	[CompilerGenerated]
	private Mesh <mesh>k__BackingField; // 0x10
	[CompilerGenerated]
	private Matrix4x4 <transform>k__BackingField; // 0x18
	private Material[] _materials; // 0x58

	// Properties
	public Mesh mesh { get; set; }
	public Matrix4x4 transform { get; set; }
	public IList<Material> materials { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Mesh get_mesh() { }

	[CompilerGenerated]
	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	private void set_mesh(Mesh value) { }

	[CompilerGenerated]
	// RVA: 0x5660E0 Offset: 0x564AE0 VA: 0x1805660E0
	public Matrix4x4 get_transform() { }

	[CompilerGenerated]
	// RVA: 0x566110 Offset: 0x564B10 VA: 0x180566110
	private void set_transform(Matrix4x4 value) { }

	// RVA: 0x566070 Offset: 0x564A70 VA: 0x180566070
	public IList<Material> get_materials() { }

	// RVA: 0x565AB0 Offset: 0x5644B0 VA: 0x180565AB0
	public void .ctor(Mesh inMesh, Material[] inMaterials, Matrix4x4 inTransform) { }

	// RVA: 0x565CC0 Offset: 0x5646C0 VA: 0x180565CC0
	public void .ctor(Mesh inputMesh, Material[] inputMaterials) { }

	// RVA: 0x565E60 Offset: 0x564860 VA: 0x180565E60
	public void .ctor(Mesh inputMesh, Material[] inputMaterials, Vector3 position) { }

	// RVA: 0x565D60 Offset: 0x564760 VA: 0x180565D60
	public void .ctor(Mesh inputMesh, Material[] inputMaterials, Vector3 position, Quaternion rotation) { }

	// RVA: 0x565F90 Offset: 0x564990 VA: 0x180565F90
	public void .ctor(Mesh inputMesh, Material[] inputMaterials, Vector3 position, Quaternion rotation, Vector3 scale) { }
}
