public class HololensHand : XRController // TypeDefIndex: 7251
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private ButtonControl <airTap>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private AxisControl <sourceLossRisk>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private Vector3Control <sourceLossMitigationDirection>k__BackingField; // 0x1C8

	// Properties
	[InputControl(noisy = True, aliases = new[] { "gripVelocity" })]
	public Vector3Control deviceVelocity { get; set; }
	[InputControl(aliases = new[] { "triggerbutton" })]
	public ButtonControl airTap { get; set; }
	[InputControl(noisy = True)]
	public AxisControl sourceLossRisk { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control sourceLossMitigationDirection { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public ButtonControl get_airTap() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_airTap(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public AxisControl get_sourceLossRisk() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_sourceLossRisk(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public Vector3Control get_sourceLossMitigationDirection() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_sourceLossMitigationDirection(Vector3Control value) { }

	// RVA: 0x274A090 Offset: 0x2748A90 VA: 0x18274A090 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
