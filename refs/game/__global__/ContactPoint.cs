public struct ContactPoint // TypeDefIndex: 18482
{
	// Fields
	internal Vector3 m_Point; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal Vector3 m_Impulse; // 0x18
	internal int m_ThisColliderInstanceID; // 0x24
	internal int m_OtherColliderInstanceID; // 0x28
	internal float m_Separation; // 0x2C

	// Properties
	public Vector3 point { get; }
	public Collider thisCollider { get; }

	// Methods

	// RVA: 0x2C63CF0 Offset: 0x2C626F0 VA: 0x182C63CF0
	public Vector3 get_point() { }

	// RVA: 0x2D33970 Offset: 0x2D32370 VA: 0x182D33970
	public Collider get_thisCollider() { }
}
