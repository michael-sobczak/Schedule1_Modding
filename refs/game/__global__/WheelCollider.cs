public class WheelCollider : Collider // TypeDefIndex: 19202
{
	// Properties
	public float radius { get; }
	public float suspensionDistance { get; }
	public JointSpring suspensionSpring { get; }
	public WheelFrictionCurve forwardFriction { get; set; }
	public WheelFrictionCurve sidewaysFriction { get; set; }
	public float motorTorque { set; }
	public float brakeTorque { set; }
	public float steerAngle { get; set; }

	// Methods

	// RVA: 0x2F5DB80 Offset: 0x2F5C580 VA: 0x182F5DB80
	public float get_radius() { }

	// RVA: 0x2F5DCA0 Offset: 0x2F5C6A0 VA: 0x182F5DCA0
	public float get_suspensionDistance() { }

	// RVA: 0x2F5DD30 Offset: 0x2F5C730 VA: 0x182F5DD30
	public JointSpring get_suspensionSpring() { }

	// RVA: 0x2F5DB30 Offset: 0x2F5C530 VA: 0x182F5DB30
	public WheelFrictionCurve get_forwardFriction() { }

	// RVA: 0x2F5DE20 Offset: 0x2F5C820 VA: 0x182F5DE20
	public void set_forwardFriction(WheelFrictionCurve value) { }

	// RVA: 0x2F5DC10 Offset: 0x2F5C610 VA: 0x182F5DC10
	public WheelFrictionCurve get_sidewaysFriction() { }

	// RVA: 0x2F5DF10 Offset: 0x2F5C910 VA: 0x182F5DF10
	public void set_sidewaysFriction(WheelFrictionCurve value) { }

	// RVA: 0x2F5DE70 Offset: 0x2F5C870 VA: 0x182F5DE70
	public void set_motorTorque(float value) { }

	// RVA: 0x2F5DD80 Offset: 0x2F5C780 VA: 0x182F5DD80
	public void set_brakeTorque(float value) { }

	// RVA: 0x2F5DC60 Offset: 0x2F5C660 VA: 0x182F5DC60
	public float get_steerAngle() { }

	// RVA: 0x2F5DF60 Offset: 0x2F5C960 VA: 0x182F5DF60
	public void set_steerAngle(float value) { }

	// RVA: 0x2F5D9C0 Offset: 0x2F5C3C0 VA: 0x182F5D9C0
	public void ConfigureVehicleSubsteps(float speedThreshold, int stepsBelowThreshold, int stepsAboveThreshold) { }

	// RVA: 0x2F5DA80 Offset: 0x2F5C480 VA: 0x182F5DA80
	public void GetWorldPose(out Vector3 pos, out Quaternion quat) { }

	// RVA: 0x2F5DA30 Offset: 0x2F5C430 VA: 0x182F5DA30
	public bool GetGroundHit(out WheelHit hit) { }

	// RVA: 0x44B2F0 Offset: 0x449CF0 VA: 0x18044B2F0
	public void .ctor() { }

	// RVA: 0x2F5DCE0 Offset: 0x2F5C6E0 VA: 0x182F5DCE0
	private void get_suspensionSpring_Injected(out JointSpring ret) { }

	// RVA: 0x2F5DAE0 Offset: 0x2F5C4E0 VA: 0x182F5DAE0
	private void get_forwardFriction_Injected(out WheelFrictionCurve ret) { }

	// RVA: 0x2F5DDD0 Offset: 0x2F5C7D0 VA: 0x182F5DDD0
	private void set_forwardFriction_Injected(ref WheelFrictionCurve value) { }

	// RVA: 0x2F5DBC0 Offset: 0x2F5C5C0 VA: 0x182F5DBC0
	private void get_sidewaysFriction_Injected(out WheelFrictionCurve ret) { }

	// RVA: 0x2F5DEC0 Offset: 0x2F5C8C0 VA: 0x182F5DEC0
	private void set_sidewaysFriction_Injected(ref WheelFrictionCurve value) { }
}
