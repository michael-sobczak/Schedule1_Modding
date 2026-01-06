public class CinemachineCollisionImpulseSource : CinemachineImpulseSource // TypeDefIndex: 16201
{
	// Fields
	[Tooltip("Only collisions with objects on these layers will generate Impulse events")]
	[Header("Trigger Object Filter")]
	public LayerMask m_LayerMask; // 0x38
	[TagField]
	[Tooltip("No Impulse evemts will be generated for collisions with objects having these tags")]
	public string m_IgnoreTag; // 0x40
	[Header("How To Generate The Impulse")]
	[Tooltip("If checked, signal direction will be affected by the direction of impact")]
	public bool m_UseImpactDirection; // 0x48
	[Tooltip("If checked, signal amplitude will be multiplied by the mass of the impacting object")]
	public bool m_ScaleImpactWithMass; // 0x49
	[Tooltip("If checked, signal amplitude will be multiplied by the speed of the impacting object")]
	public bool m_ScaleImpactWithSpeed; // 0x4A
	private Rigidbody mRigidBody; // 0x50
	private Rigidbody2D mRigidBody2D; // 0x58

	// Methods

	// RVA: 0xC28D50 Offset: 0xC27750 VA: 0x180C28D50
	private void Start() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnEnable() { }

	// RVA: 0xC28BF0 Offset: 0xC275F0 VA: 0x180C28BF0
	private void OnCollisionEnter(Collision c) { }

	// RVA: 0xC28CE0 Offset: 0xC276E0 VA: 0x180C28CE0
	private void OnTriggerEnter(Collider c) { }

	// RVA: 0xC288E0 Offset: 0xC272E0 VA: 0x180C288E0
	private float GetMassAndVelocity(Collider other, ref Vector3 vel) { }

	// RVA: 0xC283F0 Offset: 0xC26DF0 VA: 0x180C283F0
	private void GenerateImpactEvent(Collider other, Vector3 vel) { }

	// RVA: 0xC28B70 Offset: 0xC27570 VA: 0x180C28B70
	private void OnCollisionEnter2D(Collision2D c) { }

	// RVA: 0xC28C70 Offset: 0xC27670 VA: 0x180C28C70
	private void OnTriggerEnter2D(Collider2D c) { }

	// RVA: 0xC28680 Offset: 0xC27080 VA: 0x180C28680
	private float GetMassAndVelocity2D(Collider2D other2d, ref Vector3 vel) { }

	// RVA: 0xC28160 Offset: 0xC26B60 VA: 0x180C28160
	private void GenerateImpactEvent2D(Collider2D other2d, Vector3 vel) { }

	// RVA: 0xC28DD0 Offset: 0xC277D0 VA: 0x180C28DD0
	public void .ctor() { }
}
