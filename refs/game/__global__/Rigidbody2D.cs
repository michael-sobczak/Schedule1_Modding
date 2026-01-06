public sealed class Rigidbody2D : Component // TypeDefIndex: 18834
{
	// Properties
	public Vector2 position { get; }
	public float rotation { get; }
	public Vector2 velocity { get; set; }
	public float angularVelocity { get; set; }
	public float mass { get; }
	public RigidbodyType2D bodyType { get; set; }
	public bool isKinematic { get; set; }
	public RigidbodyConstraints2D constraints { get; }
	public bool simulated { get; set; }
	public RigidbodyInterpolation2D interpolation { set; }
	public CollisionDetectionMode2D collisionDetectionMode { set; }

	// Methods

	// RVA: 0x2D31A10 Offset: 0x2D30410 VA: 0x182D31A10
	public Vector2 get_position() { }

	// RVA: 0x2D31A60 Offset: 0x2D30460 VA: 0x182D31A60
	public float get_rotation() { }

	// RVA: 0x2D31710 Offset: 0x2D30110 VA: 0x182D31710
	public void MovePosition(Vector2 position) { }

	// RVA: 0x2D31750 Offset: 0x2D30150 VA: 0x182D31750
	public void MoveRotation(float angle) { }

	[NativeMethod("MoveRotation")]
	// RVA: 0x2D31750 Offset: 0x2D30150 VA: 0x182D31750
	private void MoveRotation_Angle(float angle) { }

	// RVA: 0x2D31840 Offset: 0x2D30240 VA: 0x182D31840
	public void MoveRotation(Quaternion rotation) { }

	[NativeMethod("MoveRotation")]
	// RVA: 0x2D317F0 Offset: 0x2D301F0 VA: 0x182D317F0
	private void MoveRotation_Quaternion(Quaternion rotation) { }

	// RVA: 0x2D31B30 Offset: 0x2D30530 VA: 0x182D31B30
	public Vector2 get_velocity() { }

	// RVA: 0x2D31D80 Offset: 0x2D30780 VA: 0x182D31D80
	public void set_velocity(Vector2 value) { }

	// RVA: 0x2D31880 Offset: 0x2D30280 VA: 0x182D31880
	public float get_angularVelocity() { }

	// RVA: 0x2D31B80 Offset: 0x2D30580 VA: 0x182D31B80
	public void set_angularVelocity(float value) { }

	// RVA: 0x2D31980 Offset: 0x2D30380 VA: 0x182D31980
	public float get_mass() { }

	// RVA: 0x2D318C0 Offset: 0x2D302C0 VA: 0x182D318C0
	public RigidbodyType2D get_bodyType() { }

	[NativeMethod("SetBodyType_Binding")]
	// RVA: 0x2D31BD0 Offset: 0x2D305D0 VA: 0x182D31BD0
	public void set_bodyType(RigidbodyType2D value) { }

	// RVA: 0x2D31940 Offset: 0x2D30340 VA: 0x182D31940
	public bool get_isKinematic() { }

	// RVA: 0x2D31C90 Offset: 0x2D30690 VA: 0x182D31C90
	public void set_isKinematic(bool value) { }

	// RVA: 0x2D31900 Offset: 0x2D30300 VA: 0x182D31900
	public RigidbodyConstraints2D get_constraints() { }

	// RVA: 0x2D31AA0 Offset: 0x2D304A0 VA: 0x182D31AA0
	public bool get_simulated() { }

	[NativeMethod("SetSimulated_Binding")]
	// RVA: 0x2D31CE0 Offset: 0x2D306E0 VA: 0x182D31CE0
	public void set_simulated(bool value) { }

	// RVA: 0x2D31C50 Offset: 0x2D30650 VA: 0x182D31C50
	public void set_interpolation(RigidbodyInterpolation2D value) { }

	// RVA: 0x2D31C10 Offset: 0x2D30610 VA: 0x182D31C10
	public void set_collisionDetectionMode(CollisionDetectionMode2D value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D319C0 Offset: 0x2D303C0 VA: 0x182D319C0
	private void get_position_Injected(out Vector2 ret) { }

	// RVA: 0x2D316C0 Offset: 0x2D300C0 VA: 0x182D316C0
	private void MovePosition_Injected(ref Vector2 position) { }

	// RVA: 0x2D317A0 Offset: 0x2D301A0 VA: 0x182D317A0
	private void MoveRotation_Quaternion_Injected(ref Quaternion rotation) { }

	// RVA: 0x2D31AE0 Offset: 0x2D304E0 VA: 0x182D31AE0
	private void get_velocity_Injected(out Vector2 ret) { }

	// RVA: 0x2D31D30 Offset: 0x2D30730 VA: 0x182D31D30
	private void set_velocity_Injected(ref Vector2 value) { }
}
