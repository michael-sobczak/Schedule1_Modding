public class ConfigurableJoint : Joint // TypeDefIndex: 18481
{
	// Properties
	public ConfigurableJointMotion zMotion { set; }
	public ConfigurableJointMotion angularXMotion { set; }
	public ConfigurableJointMotion angularYMotion { set; }
	public ConfigurableJointMotion angularZMotion { set; }
	public SoftJointLimit angularZLimit { get; set; }
	public Vector3 targetPosition { set; }

	// Methods

	// RVA: 0x2D33570 Offset: 0x2D31F70 VA: 0x182D33570
	public void set_zMotion(ConfigurableJointMotion value) { }

	// RVA: 0x2D33370 Offset: 0x2D31D70 VA: 0x182D33370
	public void set_angularXMotion(ConfigurableJointMotion value) { }

	// RVA: 0x2D333B0 Offset: 0x2D31DB0 VA: 0x182D333B0
	public void set_angularYMotion(ConfigurableJointMotion value) { }

	// RVA: 0x2D33490 Offset: 0x2D31E90 VA: 0x182D33490
	public void set_angularZMotion(ConfigurableJointMotion value) { }

	// RVA: 0x2D33320 Offset: 0x2D31D20 VA: 0x182D33320
	public SoftJointLimit get_angularZLimit() { }

	// RVA: 0x2D33440 Offset: 0x2D31E40 VA: 0x182D33440
	public void set_angularZLimit(SoftJointLimit value) { }

	// RVA: 0x2D33520 Offset: 0x2D31F20 VA: 0x182D33520
	public void set_targetPosition(Vector3 value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }

	// RVA: 0x2D332D0 Offset: 0x2D31CD0 VA: 0x182D332D0
	private void get_angularZLimit_Injected(out SoftJointLimit ret) { }

	// RVA: 0x2D333F0 Offset: 0x2D31DF0 VA: 0x182D333F0
	private void set_angularZLimit_Injected(ref SoftJointLimit value) { }

	// RVA: 0x2D334D0 Offset: 0x2D31ED0 VA: 0x182D334D0
	private void set_targetPosition_Injected(ref Vector3 value) { }
}
