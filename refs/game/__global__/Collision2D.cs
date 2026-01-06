public class Collision2D // TypeDefIndex: 18831
{
	// Fields
	internal int m_Collider; // 0x10
	internal int m_OtherCollider; // 0x14
	internal int m_Rigidbody; // 0x18
	internal int m_OtherRigidbody; // 0x1C
	internal Vector2 m_RelativeVelocity; // 0x20
	internal int m_Enabled; // 0x28
	internal int m_ContactCount; // 0x2C
	internal ContactPoint2D[] m_ReusedContacts; // 0x30
	internal ContactPoint2D[] m_LegacyContacts; // 0x38

	// Properties
	public Collider2D collider { get; }
	public Rigidbody2D rigidbody { get; }
	public GameObject gameObject { get; }
	public Vector2 relativeVelocity { get; }

	// Methods

	// RVA: 0x2D2DC00 Offset: 0x2D2C600 VA: 0x182D2DC00
	public Collider2D get_collider() { }

	// RVA: 0x2D2DDD0 Offset: 0x2D2C7D0 VA: 0x182D2DDD0
	public Rigidbody2D get_rigidbody() { }

	// RVA: 0x2D2DCA0 Offset: 0x2D2C6A0 VA: 0x182D2DCA0
	public GameObject get_gameObject() { }

	// RVA: 0x2D2DDB0 Offset: 0x2D2C7B0 VA: 0x182D2DDB0
	public Vector2 get_relativeVelocity() { }
}
