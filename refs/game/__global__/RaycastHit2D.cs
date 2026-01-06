public struct RaycastHit2D // TypeDefIndex: 18833
{
	// Fields
	[NativeName("centroid")]
	private Vector2 m_Centroid; // 0x0
	[NativeName("point")]
	private Vector2 m_Point; // 0x8
	[NativeName("normal")]
	private Vector2 m_Normal; // 0x10
	[NativeName("distance")]
	private float m_Distance; // 0x18
	[NativeName("fraction")]
	private float m_Fraction; // 0x1C
	[NativeName("collider")]
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0x2C9B610 Offset: 0x2C9A010 VA: 0x182C9B610
	public Vector2 get_point() { }

	// RVA: 0x2D31640 Offset: 0x2D30040 VA: 0x182D31640
	public Vector2 get_normal() { }

	// RVA: 0x2C90230 Offset: 0x2C8EC30 VA: 0x182C90230
	public float get_distance() { }

	// RVA: 0x2D315A0 Offset: 0x2D2FFA0 VA: 0x182D315A0
	public Collider2D get_collider() { }

	// RVA: 0x2D31660 Offset: 0x2D30060 VA: 0x182D31660
	public static bool op_Implicit(RaycastHit2D hit) { }
}
