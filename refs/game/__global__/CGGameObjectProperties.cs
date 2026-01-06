public class CGGameObjectProperties // TypeDefIndex: 10620
{
	// Fields
	[CanBeNull]
	[SerializeField]
	private GameObject m_Object; // 0x10
	[SerializeField]
	[VectorEx("", "")]
	private Vector3 m_Translation; // 0x18
	[VectorEx("", "")]
	[SerializeField]
	private Vector3 m_Rotation; // 0x24
	[VectorEx("", "")]
	[SerializeField]
	private Vector3 m_Scale; // 0x30

	// Properties
	[CanBeNull]
	public GameObject Object { get; set; }
	public Vector3 Translation { get; set; }
	public Vector3 Rotation { get; set; }
	public Vector3 Scale { get; set; }
	public Matrix4x4 Matrix { get; }

	// Methods

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public GameObject get_Object() { }

	// RVA: 0x49CBB0 Offset: 0x49B5B0 VA: 0x18049CBB0
	public void set_Object(GameObject value) { }

	// RVA: 0x4D8950 Offset: 0x4D7350 VA: 0x1804D8950
	public Vector3 get_Translation() { }

	// RVA: 0x4D8970 Offset: 0x4D7370 VA: 0x1804D8970
	public void set_Translation(Vector3 value) { }

	// RVA: 0x4D6370 Offset: 0x4D4D70 VA: 0x1804D6370
	public Vector3 get_Rotation() { }

	// RVA: 0x4D6620 Offset: 0x4D5020 VA: 0x1804D6620
	public void set_Rotation(Vector3 value) { }

	// RVA: 0x4D6350 Offset: 0x4D4D50 VA: 0x1804D6350
	public Vector3 get_Scale() { }

	// RVA: 0x4D6610 Offset: 0x4D5010 VA: 0x1804D6610
	public void set_Scale(Vector3 value) { }

	// RVA: 0x4D8850 Offset: 0x4D7250 VA: 0x1804D8850
	public Matrix4x4 get_Matrix() { }

	// RVA: 0x4D87F0 Offset: 0x4D71F0 VA: 0x1804D87F0
	public void .ctor() { }

	// RVA: 0x4D8780 Offset: 0x4D7180 VA: 0x1804D8780
	public void .ctor(GameObject gameObject) { }
}
