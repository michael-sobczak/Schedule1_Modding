public struct ContactPair // TypeDefIndex: 18487
{
	// Fields
	private const uint c_InvalidFaceIndex = 4294967295;
	internal readonly int m_ColliderID; // 0x0
	internal readonly int m_OtherColliderID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPoints; // 0x10
	internal readonly CollisionPairFlags m_Flags; // 0x14
	internal readonly CollisionPairEventFlags m_Events; // 0x16
	internal readonly Vector3 m_ImpulseSum; // 0x18

	// Properties
	public Collider Collider { get; }
	public Collider OtherCollider { get; }
	public bool IsCollisionEnter { get; }
	public bool IsCollisionExit { get; }
	public bool IsCollisionStay { get; }
	internal bool HasRemovedCollider { get; }

	// Methods

	// RVA: 0x2D33840 Offset: 0x2D32240 VA: 0x182D33840
	public Collider get_Collider() { }

	// RVA: 0x2D338F0 Offset: 0x2D322F0 VA: 0x182D338F0
	public Collider get_OtherCollider() { }

	// RVA: 0x2D338C0 Offset: 0x2D322C0 VA: 0x182D338C0
	public bool get_IsCollisionEnter() { }

	// RVA: 0x2D338D0 Offset: 0x2D322D0 VA: 0x182D338D0
	public bool get_IsCollisionExit() { }

	// RVA: 0x2D338E0 Offset: 0x2D322E0 VA: 0x182D338E0
	public bool get_IsCollisionStay() { }

	// RVA: 0x2D33750 Offset: 0x2D32150 VA: 0x182D33750
	internal bool get_HasRemovedCollider() { }

	// RVA: 0x2D337E0 Offset: 0x2D321E0 VA: 0x182D337E0
	internal int ExtractContactsArray(ContactPoint[] managedContainer, bool flipped) { }

	// RVA: 0x2D337E0 Offset: 0x2D321E0 VA: 0x182D337E0
	private static int ExtractContactsArray_Injected(ref ContactPair _unity_self, ContactPoint[] managedContainer, bool flipped) { }
}
