public class CGMeshProperties // TypeDefIndex: 10626
{
	// Fields
	[SerializeField]
	private Mesh m_Mesh; // 0x10
	[SerializeField]
	private Material[] m_Material; // 0x18
	[VectorEx("", "")]
	[SerializeField]
	private Vector3 m_Translation; // 0x20
	[VectorEx("", "")]
	[SerializeField]
	private Vector3 m_Rotation; // 0x2C
	[SerializeField]
	[VectorEx("", "")]
	private Vector3 m_Scale; // 0x38

	// Properties
	public Mesh Mesh { get; set; }
	public Material[] Material { get; set; }
	public Vector3 Translation { get; set; }
	public Vector3 Rotation { get; set; }
	public Vector3 Scale { get; set; }
	public Matrix4x4 Matrix { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public Mesh get_Mesh() { }

	// RVA: 0x4DA120 Offset: 0x4D8B20 VA: 0x1804DA120
	public void set_Mesh(Mesh value) { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public Material[] get_Material() { }

	// RVA: 0x43EFE0 Offset: 0x43D9E0 VA: 0x18043EFE0
	public void set_Material(Material[] value) { }

	// RVA: 0x4DA100 Offset: 0x4D8B00 VA: 0x1804DA100
	public Vector3 get_Translation() { }

	// RVA: 0x4DA200 Offset: 0x4D8C00 VA: 0x1804DA200
	public void set_Translation(Vector3 value) { }

	// RVA: 0x4DA0C0 Offset: 0x4D8AC0 VA: 0x1804DA0C0
	public Vector3 get_Rotation() { }

	// RVA: 0x4DA1E0 Offset: 0x4D8BE0 VA: 0x1804DA1E0
	public void set_Rotation(Vector3 value) { }

	// RVA: 0x4DA0E0 Offset: 0x4D8AE0 VA: 0x1804DA0E0
	public Vector3 get_Scale() { }

	// RVA: 0x4DA1F0 Offset: 0x4D8BF0 VA: 0x1804DA1F0
	public void set_Scale(Vector3 value) { }

	// RVA: 0x4D9FC0 Offset: 0x4D89C0 VA: 0x1804D9FC0
	public Matrix4x4 get_Matrix() { }

	// RVA: 0x4D9E20 Offset: 0x4D8820 VA: 0x1804D9E20
	public void .ctor() { }

	// RVA: 0x4D9EB0 Offset: 0x4D88B0 VA: 0x1804D9EB0
	public void .ctor(Mesh mesh) { }

	[Conditional("UNITY_EDITOR")]
	// RVA: 0x4D9E10 Offset: 0x4D8810 VA: 0x1804D9E10
	public void OnValidate() { }
}
