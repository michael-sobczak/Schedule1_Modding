public class CharacterController : Collider // TypeDefIndex: 18471
{
	// Properties
	public Vector3 velocity { get; }
	public bool isGrounded { get; }
	public CollisionFlags collisionFlags { get; }
	public float radius { get; }
	public float height { get; set; }
	public Vector3 center { set; }
	public float slopeLimit { get; set; }
	public float stepOffset { get; }
	public bool detectCollisions { set; }

	// Methods

	// RVA: 0x2D32460 Offset: 0x2D30E60 VA: 0x182D32460
	public bool SimpleMove(Vector3 speed) { }

	// RVA: 0x2D323C0 Offset: 0x2D30DC0 VA: 0x182D323C0
	public CollisionFlags Move(Vector3 motion) { }

	// RVA: 0x2D32680 Offset: 0x2D31080 VA: 0x182D32680
	public Vector3 get_velocity() { }

	[NativeName("IsGrounded")]
	// RVA: 0x2D32530 Offset: 0x2D30F30 VA: 0x182D32530
	public bool get_isGrounded() { }

	// RVA: 0x2D324B0 Offset: 0x2D30EB0 VA: 0x182D324B0
	public CollisionFlags get_collisionFlags() { }

	// RVA: 0x2D32570 Offset: 0x2D30F70 VA: 0x182D32570
	public float get_radius() { }

	// RVA: 0x2D324F0 Offset: 0x2D30EF0 VA: 0x182D324F0
	public float get_height() { }

	// RVA: 0x2D327C0 Offset: 0x2D311C0 VA: 0x182D327C0
	public void set_height(float value) { }

	// RVA: 0x2D32720 Offset: 0x2D31120 VA: 0x182D32720
	public void set_center(Vector3 value) { }

	// RVA: 0x2D325B0 Offset: 0x2D30FB0 VA: 0x182D325B0
	public float get_slopeLimit() { }

	// RVA: 0x2D32810 Offset: 0x2D31210 VA: 0x182D32810
	public void set_slopeLimit(float value) { }

	// RVA: 0x2D325F0 Offset: 0x2D30FF0 VA: 0x182D325F0
	public float get_stepOffset() { }

	// RVA: 0x2D32770 Offset: 0x2D31170 VA: 0x182D32770
	public void set_detectCollisions(bool value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D32410 Offset: 0x2D30E10 VA: 0x182D32410
	private bool SimpleMove_Injected(ref Vector3 speed) { }

	// RVA: 0x2D32370 Offset: 0x2D30D70 VA: 0x182D32370
	private CollisionFlags Move_Injected(ref Vector3 motion) { }

	// RVA: 0x2D32630 Offset: 0x2D31030 VA: 0x182D32630
	private void get_velocity_Injected(out Vector3 ret) { }

	// RVA: 0x2D326D0 Offset: 0x2D310D0 VA: 0x182D326D0
	private void set_center_Injected(ref Vector3 value) { }
}
