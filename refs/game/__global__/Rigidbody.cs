public class Rigidbody : Component // TypeDefIndex: 18469
{
	// Properties
	public Vector3 velocity { get; set; }
	public Vector3 angularVelocity { get; set; }
	public float drag { get; set; }
	public float angularDrag { get; set; }
	public float mass { get; set; }
	public bool useGravity { set; }
	public bool isKinematic { get; set; }
	public bool freezeRotation { set; }
	public RigidbodyConstraints constraints { get; set; }
	public CollisionDetectionMode collisionDetectionMode { set; }
	public Vector3 centerOfMass { get; set; }
	public Vector3 worldCenterOfMass { get; }
	public bool automaticInertiaTensor { set; }
	public bool detectCollisions { set; }
	public Vector3 position { get; set; }
	public Quaternion rotation { get; set; }
	public RigidbodyInterpolation interpolation { get; set; }
	public float sleepThreshold { set; }
	public float maxAngularVelocity { get; set; }

	// Methods

	// RVA: 0x2D3BD10 Offset: 0x2D3A710 VA: 0x182D3BD10
	public Vector3 get_velocity() { }

	// RVA: 0x2D3C4B0 Offset: 0x2D3AEB0 VA: 0x182D3C4B0
	public void set_velocity(Vector3 value) { }

	// RVA: 0x2D3B910 Offset: 0x2D3A310 VA: 0x182D3B910
	public Vector3 get_angularVelocity() { }

	// RVA: 0x2D3BEA0 Offset: 0x2D3A8A0 VA: 0x182D3BEA0
	public void set_angularVelocity(Vector3 value) { }

	// RVA: 0x2D3BA40 Offset: 0x2D3A440 VA: 0x182D3BA40
	public float get_drag() { }

	// RVA: 0x2D3C0B0 Offset: 0x2D3AAB0 VA: 0x182D3C0B0
	public void set_drag(float value) { }

	// RVA: 0x2D3B880 Offset: 0x2D3A280 VA: 0x182D3B880
	public float get_angularDrag() { }

	// RVA: 0x2D3BE00 Offset: 0x2D3A800 VA: 0x182D3BE00
	public void set_angularDrag(float value) { }

	// RVA: 0x2D3BB00 Offset: 0x2D3A500 VA: 0x182D3BB00
	public float get_mass() { }

	// RVA: 0x2D3C1E0 Offset: 0x2D3ABE0 VA: 0x182D3C1E0
	public void set_mass(float value) { }

	// RVA: 0x2D3C410 Offset: 0x2D3AE10 VA: 0x182D3C410
	public void set_useGravity(bool value) { }

	// RVA: 0x2D3BAC0 Offset: 0x2D3A4C0 VA: 0x182D3BAC0
	public bool get_isKinematic() { }

	// RVA: 0x2D3C190 Offset: 0x2D3AB90 VA: 0x182D3C190
	public void set_isKinematic(bool value) { }

	// RVA: 0x2D3C100 Offset: 0x2D3AB00 VA: 0x182D3C100
	public void set_freezeRotation(bool value) { }

	// RVA: 0x2D3BA00 Offset: 0x2D3A400 VA: 0x182D3BA00
	public RigidbodyConstraints get_constraints() { }

	// RVA: 0x2D3C020 Offset: 0x2D3AA20 VA: 0x182D3C020
	public void set_constraints(RigidbodyConstraints value) { }

	// RVA: 0x2D3BFE0 Offset: 0x2D3A9E0 VA: 0x182D3BFE0
	public void set_collisionDetectionMode(CollisionDetectionMode value) { }

	// RVA: 0x2D3B9B0 Offset: 0x2D3A3B0 VA: 0x182D3B9B0
	public Vector3 get_centerOfMass() { }

	// RVA: 0x2D3BF90 Offset: 0x2D3A990 VA: 0x182D3BF90
	public void set_centerOfMass(Vector3 value) { }

	// RVA: 0x2D3BDB0 Offset: 0x2D3A7B0 VA: 0x182D3BDB0
	public Vector3 get_worldCenterOfMass() { }

	// RVA: 0x2D3BEF0 Offset: 0x2D3A8F0 VA: 0x182D3BEF0
	public void set_automaticInertiaTensor(bool value) { }

	// RVA: 0x2D3C060 Offset: 0x2D3AA60 VA: 0x182D3C060
	public void set_detectCollisions(bool value) { }

	// RVA: 0x2D3BBD0 Offset: 0x2D3A5D0 VA: 0x182D3BBD0
	public Vector3 get_position() { }

	// RVA: 0x2D3C2D0 Offset: 0x2D3ACD0 VA: 0x182D3C2D0
	public void set_position(Vector3 value) { }

	// RVA: 0x2D3BC70 Offset: 0x2D3A670 VA: 0x182D3BC70
	public Quaternion get_rotation() { }

	// RVA: 0x2D3C370 Offset: 0x2D3AD70 VA: 0x182D3C370
	public void set_rotation(Quaternion value) { }

	// RVA: 0x2D3BA80 Offset: 0x2D3A480 VA: 0x182D3BA80
	public RigidbodyInterpolation get_interpolation() { }

	// RVA: 0x2D3C150 Offset: 0x2D3AB50 VA: 0x182D3C150
	public void set_interpolation(RigidbodyInterpolation value) { }

	// RVA: 0x2D3C3C0 Offset: 0x2D3ADC0 VA: 0x182D3C3C0
	public void set_sleepThreshold(float value) { }

	// RVA: 0x2D3BB40 Offset: 0x2D3A540 VA: 0x182D3BB40
	public float get_maxAngularVelocity() { }

	// RVA: 0x2D3C230 Offset: 0x2D3AC30 VA: 0x182D3C230
	public void set_maxAngularVelocity(float value) { }

	// RVA: 0x2D3B750 Offset: 0x2D3A150 VA: 0x182D3B750
	public void MovePosition(Vector3 position) { }

	// RVA: 0x2D3B7F0 Offset: 0x2D3A1F0 VA: 0x182D3B7F0
	public void MoveRotation(Quaternion rot) { }

	// RVA: 0x2D3B840 Offset: 0x2D3A240 VA: 0x182D3B840
	public void WakeUp() { }

	// RVA: 0x2D3B6A0 Offset: 0x2D3A0A0 VA: 0x182D3B6A0
	public Vector3 GetPointVelocity(Vector3 worldPoint) { }

	// RVA: 0x2D3B3A0 Offset: 0x2D39DA0 VA: 0x182D3B3A0
	public void AddForce(Vector3 force, ForceMode mode) { }

	[ExcludeFromDocs]
	// RVA: 0x2D3B350 Offset: 0x2D39D50 VA: 0x182D3B350
	public void AddForce(Vector3 force) { }

	// RVA: 0x2D3B460 Offset: 0x2D39E60 VA: 0x182D3B460
	public void AddRelativeForce(Vector3 force, ForceMode mode) { }

	// RVA: 0x2D3B5E0 Offset: 0x2D39FE0 VA: 0x182D3B5E0
	public void AddTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x2D3B520 Offset: 0x2D39F20 VA: 0x182D3B520
	public void AddRelativeTorque(Vector3 torque, ForceMode mode) { }

	// RVA: 0x2D3B280 Offset: 0x2D39C80 VA: 0x182D3B280
	public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D3BCC0 Offset: 0x2D3A6C0 VA: 0x182D3BCC0
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x2D3C460 Offset: 0x2D3AE60 VA: 0x182D3C460
	private void set_velocity_Injected(ref Vector3 value) { }

	// RVA: 0x2D3B8C0 Offset: 0x2D3A2C0 VA: 0x182D3B8C0
	private void get_angularVelocity_Injected(out Vector3 ret) { }

	// RVA: 0x2D3BE50 Offset: 0x2D3A850 VA: 0x182D3BE50
	private void set_angularVelocity_Injected(ref Vector3 value) { }

	// RVA: 0x2D3B960 Offset: 0x2D3A360 VA: 0x182D3B960
	private void get_centerOfMass_Injected(out Vector3 ret) { }

	// RVA: 0x2D3BF40 Offset: 0x2D3A940 VA: 0x182D3BF40
	private void set_centerOfMass_Injected(ref Vector3 value) { }

	// RVA: 0x2D3BD60 Offset: 0x2D3A760 VA: 0x182D3BD60
	private void get_worldCenterOfMass_Injected(out Vector3 ret) { }

	// RVA: 0x2D3BB80 Offset: 0x2D3A580 VA: 0x182D3BB80
	private void get_position_Injected(out Vector3 ret) { }

	// RVA: 0x2D3C280 Offset: 0x2D3AC80 VA: 0x182D3C280
	private void set_position_Injected(ref Vector3 value) { }

	// RVA: 0x2D3BC20 Offset: 0x2D3A620 VA: 0x182D3BC20
	private void get_rotation_Injected(out Quaternion ret) { }

	// RVA: 0x2D3C320 Offset: 0x2D3AD20 VA: 0x182D3C320
	private void set_rotation_Injected(ref Quaternion value) { }

	// RVA: 0x2D3B700 Offset: 0x2D3A100 VA: 0x182D3B700
	private void MovePosition_Injected(ref Vector3 position) { }

	// RVA: 0x2D3B7A0 Offset: 0x2D3A1A0 VA: 0x182D3B7A0
	private void MoveRotation_Injected(ref Quaternion rot) { }

	// RVA: 0x2D3B640 Offset: 0x2D3A040 VA: 0x182D3B640
	private void GetPointVelocity_Injected(ref Vector3 worldPoint, out Vector3 ret) { }

	// RVA: 0x2D3B2F0 Offset: 0x2D39CF0 VA: 0x182D3B2F0
	private void AddForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x2D3B400 Offset: 0x2D39E00 VA: 0x182D3B400
	private void AddRelativeForce_Injected(ref Vector3 force, ForceMode mode) { }

	// RVA: 0x2D3B580 Offset: 0x2D39F80 VA: 0x182D3B580
	private void AddTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x2D3B4C0 Offset: 0x2D39EC0 VA: 0x182D3B4C0
	private void AddRelativeTorque_Injected(ref Vector3 torque, ForceMode mode) { }

	// RVA: 0x2D3B210 Offset: 0x2D39C10 VA: 0x182D3B210
	private void AddForceAtPosition_Injected(ref Vector3 force, ref Vector3 position, ForceMode mode) { }
}
