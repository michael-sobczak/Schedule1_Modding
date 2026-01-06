public class OrbitingBody : MonoBehaviour // TypeDefIndex: 397
{
	// Fields
	private Transform m_PositionTransform; // 0x20
	private RotateBody m_RotateBody; // 0x28
	private SpherePoint m_SpherePoint; // 0x30
	private Vector3 m_CachedWorldDirection; // 0x38
	private Light m_BodyLight; // 0x48

	// Properties
	public Transform positionTransform { get; }
	public RotateBody rotateBody { get; }
	public SpherePoint Point { get; set; }
	public Vector3 BodyGlobalDirection { get; }
	public Light BodyLight { get; }

	// Methods

	// RVA: 0x8D5F00 Offset: 0x8D4900 VA: 0x1808D5F00
	public Transform get_positionTransform() { }

	// RVA: 0x8D5FB0 Offset: 0x8D49B0 VA: 0x1808D5FB0
	public RotateBody get_rotateBody() { }

	// RVA: 0x4513A0 Offset: 0x44FDA0 VA: 0x1804513A0
	public SpherePoint get_Point() { }

	// RVA: 0x8D6150 Offset: 0x8D4B50 VA: 0x1808D6150
	public void set_Point(SpherePoint value) { }

	// RVA: 0x4DA0E0 Offset: 0x4D8AE0 VA: 0x1804DA0E0
	public Vector3 get_BodyGlobalDirection() { }

	// RVA: 0x8D5DD0 Offset: 0x8D47D0 VA: 0x1808D5DD0
	public Light get_BodyLight() { }

	// RVA: 0x8D5CF0 Offset: 0x8D46F0 VA: 0x1808D5CF0
	public void ResetOrbit() { }

	// RVA: 0x8D5BB0 Offset: 0x8D45B0 VA: 0x1808D5BB0
	public void LayoutOribit() { }

	// RVA: 0x8D5CE0 Offset: 0x8D46E0 VA: 0x1808D5CE0
	private void OnValidate() { }

	// RVA: 0x8D5D20 Offset: 0x8D4720 VA: 0x1808D5D20
	public void .ctor() { }
}
