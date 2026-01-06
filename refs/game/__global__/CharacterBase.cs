public abstract class CharacterBase : MonoBehaviour // TypeDefIndex: 14299
{
	// Fields
	[Tooltip("If specified, will use the direction from the character to this Transform as the gravity vector instead of Physics.gravity. Physics.gravity.magnitude will be used as the magnitude of the gravity vector.")]
	[Header("Base Parameters")]
	public Transform gravityTarget; // 0x20
	[Tooltip("Multiplies gravity applied to the character even if 'Individual Gravity' is unchecked.")]
	public float gravityMultiplier; // 0x28
	public float airborneThreshold; // 0x2C
	public float slopeStartAngle; // 0x30
	public float slopeEndAngle; // 0x34
	public float spherecastRadius; // 0x38
	public LayerMask groundLayers; // 0x3C
	private PhysicMaterial zeroFrictionMaterial; // 0x40
	private PhysicMaterial highFrictionMaterial; // 0x48
	protected Rigidbody r; // 0x50
	protected const float half = 0.5;
	protected float originalHeight; // 0x58
	protected Vector3 originalCenter; // 0x5C
	protected CapsuleCollider capsule; // 0x68

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Move(Vector3 deltaPosition, Quaternion deltaRotation);

	// RVA: 0x1F51940 Offset: 0x1F50340 VA: 0x181F51940
	protected Vector3 GetGravity() { }

	// RVA: 0x1F524C0 Offset: 0x1F50EC0 VA: 0x181F524C0 Slot: 5
	protected virtual void Start() { }

	// RVA: 0x1F51BA0 Offset: 0x1F505A0 VA: 0x181F51BA0 Slot: 6
	protected virtual RaycastHit GetSpherecastHit() { }

	// RVA: 0x1F50490 Offset: 0x1F4EE90 VA: 0x181F50490
	public float GetAngleFromForward(Vector3 worldDirection) { }

	// RVA: 0x1F51EE0 Offset: 0x1F508E0 VA: 0x181F51EE0
	protected void RigidbodyRotateAround(Vector3 point, Vector3 axis, float angle) { }

	// RVA: 0x1F521C0 Offset: 0x1F50BC0 VA: 0x181F521C0
	protected void ScaleCapsule(float mlp) { }

	// RVA: 0x1F51EB0 Offset: 0x1F508B0 VA: 0x181F51EB0
	protected void HighFriction() { }

	// RVA: 0x1F52700 Offset: 0x1F51100 VA: 0x181F52700
	protected void ZeroFriction() { }

	// RVA: 0x1F51B10 Offset: 0x1F50510 VA: 0x181F51B10
	protected float GetSlopeDamper(Vector3 velocity, Vector3 groundNormal) { }

	// RVA: 0x1F52730 Offset: 0x1F51130 VA: 0x181F52730
	protected void .ctor() { }
}
