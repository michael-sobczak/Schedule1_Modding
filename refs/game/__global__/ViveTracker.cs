public class ViveTracker : TrackedDevice // TypeDefIndex: 7239
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; // 0x1B8

	// Properties
	[InputControl(noisy = True)]
	public Vector3Control deviceVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAngularVelocity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	// RVA: 0x2762480 Offset: 0x2760E80 VA: 0x182762480 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x274A080 Offset: 0x2748A80 VA: 0x18274A080
	public void .ctor() { }
}
