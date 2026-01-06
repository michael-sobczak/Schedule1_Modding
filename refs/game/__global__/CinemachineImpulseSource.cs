public class CinemachineImpulseSource : MonoBehaviour // TypeDefIndex: 16219
{
	// Fields
	public CinemachineImpulseDefinition m_ImpulseDefinition; // 0x20
	[Tooltip("The default direction and force of the Impulse Signal in the absense of any specified overrides.  Overrides can be specified by calling the appropriate GenerateImpulse method in the API.")]
	[Header("Default Invocation")]
	public Vector3 m_DefaultVelocity; // 0x28

	// Methods

	// RVA: 0xC2BBE0 Offset: 0xC2A5E0 VA: 0x180C2BBE0
	private void OnValidate() { }

	// RVA: 0xC2BCE0 Offset: 0xC2A6E0 VA: 0x180C2BCE0
	private void Reset() { }

	// RVA: 0xC2B9D0 Offset: 0xC2A3D0 VA: 0x180C2B9D0
	public void GenerateImpulseAtPositionWithVelocity(Vector3 position, Vector3 velocity) { }

	// RVA: 0xC2BAD0 Offset: 0xC2A4D0 VA: 0x180C2BAD0
	public void GenerateImpulseWithVelocity(Vector3 velocity) { }

	// RVA: 0xC2BA20 Offset: 0xC2A420 VA: 0x180C2BA20
	public void GenerateImpulseWithForce(float force) { }

	// RVA: 0xC2BB50 Offset: 0xC2A550 VA: 0x180C2BB50
	public void GenerateImpulse() { }

	// RVA: 0xC2B9D0 Offset: 0xC2A3D0 VA: 0x180C2B9D0
	public void GenerateImpulseAt(Vector3 position, Vector3 velocity) { }

	// RVA: 0xC2BAD0 Offset: 0xC2A4D0 VA: 0x180C2BAD0
	public void GenerateImpulse(Vector3 velocity) { }

	// RVA: 0xC2BA20 Offset: 0xC2A420 VA: 0x180C2BA20
	public void GenerateImpulse(float force) { }

	// RVA: 0xC2BDF0 Offset: 0xC2A7F0 VA: 0x180C2BDF0
	public void .ctor() { }
}
