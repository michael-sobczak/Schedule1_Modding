public class GearVRTrackedController : XRController // TypeDefIndex: 7247
{
	// Fields
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private ButtonControl <back>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private ButtonControl <touchpadClicked>k__BackingField; // 0x1D0
	[CompilerGenerated]
	private ButtonControl <touchpadTouched>k__BackingField; // 0x1D8
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; // 0x1E0
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; // 0x1F0

	// Properties
	[InputControl]
	public Vector2Control touchpad { get; set; }
	[InputControl]
	public AxisControl trigger { get; set; }
	[InputControl]
	public ButtonControl back { get; set; }
	[InputControl]
	public ButtonControl triggerPressed { get; set; }
	[InputControl]
	public ButtonControl touchpadClicked { get; set; }
	[InputControl]
	public ButtonControl touchpadTouched { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAcceleration { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAngularAcceleration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_touchpad(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public ButtonControl get_back() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_back(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_triggerPressed(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public ButtonControl get_touchpadClicked() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_touchpadClicked(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public ButtonControl get_touchpadTouched() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_touchpadTouched(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10
	protected void set_deviceAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public Vector3Control get_deviceAngularAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30
	protected void set_deviceAngularAcceleration(Vector3Control value) { }

	// RVA: 0x2749C30 Offset: 0x2748630 VA: 0x182749C30 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
