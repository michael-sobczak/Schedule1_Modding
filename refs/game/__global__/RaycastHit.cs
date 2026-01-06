public struct RaycastHit // TypeDefIndex: 18468
{
	// Fields
	[NativeName("point")]
	internal Vector3 m_Point; // 0x0
	[NativeName("normal")]
	internal Vector3 m_Normal; // 0xC
	[NativeName("faceID")]
	internal uint m_FaceID; // 0x18
	[NativeName("distance")]
	internal float m_Distance; // 0x1C
	[NativeName("uv")]
	internal Vector2 m_UV; // 0x20
	[NativeName("collider")]
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public float distance { get; set; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }

	// Methods

	// RVA: 0x2D3AFE0 Offset: 0x2D399E0 VA: 0x182D3AFE0
	public Collider get_collider() { }

	// RVA: 0x2C63CF0 Offset: 0x2C626F0 VA: 0x182C63CF0
	public Vector3 get_point() { }

	// RVA: 0x281FE90 Offset: 0x281E890 VA: 0x18281FE90
	public void set_point(Vector3 value) { }

	// RVA: 0x2C80B20 Offset: 0x2C7F520 VA: 0x182C80B20
	public Vector3 get_normal() { }

	// RVA: 0x2C63D20 Offset: 0x2C62720 VA: 0x182C63D20
	public void set_normal(Vector3 value) { }

	// RVA: 0x2D2B190 Offset: 0x2D29B90 VA: 0x182D2B190
	public float get_distance() { }

	// RVA: 0x49D820 Offset: 0x49C220 VA: 0x18049D820
	public void set_distance(float value) { }

	// RVA: 0x2D3B130 Offset: 0x2D39B30 VA: 0x182D3B130
	public Transform get_transform() { }

	// RVA: 0x2D3B080 Offset: 0x2D39A80 VA: 0x182D3B080
	public Rigidbody get_rigidbody() { }
}
