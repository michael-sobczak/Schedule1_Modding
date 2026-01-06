public struct ContactPairHeader // TypeDefIndex: 18486
{
	// Fields
	internal readonly int m_BodyID; // 0x0
	internal readonly int m_OtherBodyID; // 0x4
	internal readonly IntPtr m_StartPtr; // 0x8
	internal readonly uint m_NbPairs; // 0x10
	internal readonly CollisionPairHeaderFlags m_Flags; // 0x14
	internal readonly Vector3 m_RelativeVelocity; // 0x18

	// Properties
	public Component Body { get; }
	public Component OtherBody { get; }
	internal bool HasRemovedBody { get; }

	// Methods

	// RVA: 0x2D336E0 Offset: 0x2D320E0 VA: 0x182D336E0
	public Component get_Body() { }

	// RVA: 0x2D33770 Offset: 0x2D32170 VA: 0x182D33770
	public Component get_OtherBody() { }

	// RVA: 0x2D33750 Offset: 0x2D32150 VA: 0x182D33750
	internal bool get_HasRemovedBody() { }

	// RVA: 0x2D336D0 Offset: 0x2D320D0 VA: 0x182D336D0
	public ref ContactPair GetContactPair(int index) { }

	// RVA: 0x2D33650 Offset: 0x2D32050 VA: 0x182D33650
	internal ContactPair* GetContactPair_Internal(int index) { }
}
