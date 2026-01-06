public class OculusTouchController : XRControllerWithRumble // TypeDefIndex: 7243
{
	// Fields
	[CompilerGenerated]
	private Vector2Control <thumbstick>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private ButtonControl <primaryButton>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private ButtonControl <secondaryButton>k__BackingField; // 0x1D0
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; // 0x1D8
	[CompilerGenerated]
	private ButtonControl <start>k__BackingField; // 0x1E0
	[CompilerGenerated]
	private ButtonControl <thumbstickClicked>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private ButtonControl <primaryTouched>k__BackingField; // 0x1F0
	[CompilerGenerated]
	private ButtonControl <secondaryTouched>k__BackingField; // 0x1F8
	[CompilerGenerated]
	private AxisControl <triggerTouched>k__BackingField; // 0x200
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; // 0x208
	[CompilerGenerated]
	private ButtonControl <thumbstickTouched>k__BackingField; // 0x210
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; // 0x218
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; // 0x220
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; // 0x228
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; // 0x230

	// Properties
	[InputControl(aliases = new[] { "Primary2DAxis", "Joystick" })]
	public Vector2Control thumbstick { get; set; }
	[InputControl]
	public AxisControl trigger { get; set; }
	[InputControl]
	public AxisControl grip { get; set; }
	[InputControl(aliases = new[] { "A", "X", "Alternate" })]
	public ButtonControl primaryButton { get; set; }
	[InputControl(aliases = new[] { "B", "Y", "Primary" })]
	public ButtonControl secondaryButton { get; set; }
	[InputControl(aliases = new[] { "GripButton" })]
	public ButtonControl gripPressed { get; set; }
	[InputControl]
	public ButtonControl start { get; set; }
	[InputControl(aliases = new[] { "JoystickOrPadPressed", "thumbstickClick" })]
	public ButtonControl thumbstickClicked { get; set; }
	[InputControl(aliases = new[] { "ATouched", "XTouched", "ATouch", "XTouch" })]
	public ButtonControl primaryTouched { get; set; }
	[InputControl(aliases = new[] { "BTouched", "YTouched", "BTouch", "YTouch" })]
	public ButtonControl secondaryTouched { get; set; }
	[InputControl(aliases = new[] { "indexTouch", "indexNearTouched" })]
	public AxisControl triggerTouched { get; set; }
	[InputControl(aliases = new[] { "indexButton", "indexTouched" })]
	public ButtonControl triggerPressed { get; set; }
	[InputControl(name = "trackingState", layout = "Integer", aliases = new[] { "controllerTrackingState" })]
	[InputControl(name = "isTracked", layout = "Button", aliases = new[] { "ControllerIsTracked" })]
	[InputControl(aliases = new[] { "JoystickOrPadTouched", "thumbstickTouch" })]
	[InputControl(name = "deviceRotation", layout = "Quaternion", aliases = new[] { "controllerRotation" })]
	[InputControl(name = "devicePosition", layout = "Vector3", aliases = new[] { "controllerPosition" })]
	public ButtonControl thumbstickTouched { get; set; }
	[InputControl(noisy = True, aliases = new[] { "controllerVelocity" })]
	public Vector3Control deviceVelocity { get; set; }
	[InputControl(noisy = True, aliases = new[] { "controllerAngularVelocity" })]
	public Vector3Control deviceAngularVelocity { get; set; }
	[InputControl(noisy = True, aliases = new[] { "controllerAcceleration" })]
	public Vector3Control deviceAcceleration { get; set; }
	[InputControl(noisy = True, aliases = new[] { "controllerAngularAcceleration" })]
	public Vector3Control deviceAngularAcceleration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public Vector2Control get_thumbstick() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_thumbstick(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public AxisControl get_grip() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_grip(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public ButtonControl get_primaryButton() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_primaryButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public ButtonControl get_secondaryButton() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_secondaryButton(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public ButtonControl get_start() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_start(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0
	public ButtonControl get_thumbstickClicked() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10
	protected void set_thumbstickClicked(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public ButtonControl get_primaryTouched() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30
	protected void set_primaryTouched(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6410E0 Offset: 0x63FAE0 VA: 0x1806410E0
	public ButtonControl get_secondaryTouched() { }

	[CompilerGenerated]
	// RVA: 0x27498C0 Offset: 0x27482C0 VA: 0x1827498C0
	protected void set_secondaryTouched(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	public AxisControl get_triggerTouched() { }

	[CompilerGenerated]
	// RVA: 0x27498A0 Offset: 0x27482A0 VA: 0x1827498A0
	protected void set_triggerTouched(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x6410C0 Offset: 0x63FAC0 VA: 0x1806410C0
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	// RVA: 0x6864B0 Offset: 0x684EB0 VA: 0x1806864B0
	protected void set_triggerPressed(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public ButtonControl get_thumbstickTouched() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	protected void set_thumbstickTouched(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0xA2FF00 Offset: 0xA2E900 VA: 0x180A2FF00
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0
	protected void set_deviceAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00
	public Vector3Control get_deviceAngularAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x6415D0 Offset: 0x63FFD0 VA: 0x1806415D0
	protected void set_deviceAngularAcceleration(Vector3Control value) { }

	// RVA: 0x275AB40 Offset: 0x2759540 VA: 0x18275AB40 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
