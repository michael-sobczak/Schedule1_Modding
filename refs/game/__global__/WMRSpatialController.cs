public class WMRSpatialController : XRControllerWithRumble // TypeDefIndex: 7252
{
	// Fields
	[CompilerGenerated]
	private Vector2Control <joystick>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private AxisControl <grip>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private ButtonControl <gripPressed>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private ButtonControl <menu>k__BackingField; // 0x1D0
	[CompilerGenerated]
	private AxisControl <trigger>k__BackingField; // 0x1D8
	[CompilerGenerated]
	private ButtonControl <triggerPressed>k__BackingField; // 0x1E0
	[CompilerGenerated]
	private ButtonControl <joystickClicked>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private ButtonControl <touchpadClicked>k__BackingField; // 0x1F0
	[CompilerGenerated]
	private ButtonControl <touchpadTouched>k__BackingField; // 0x1F8
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; // 0x200
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; // 0x208
	[CompilerGenerated]
	private AxisControl <batteryLevel>k__BackingField; // 0x210
	[CompilerGenerated]
	private AxisControl <sourceLossRisk>k__BackingField; // 0x218
	[CompilerGenerated]
	private Vector3Control <sourceLossMitigationDirection>k__BackingField; // 0x220
	[CompilerGenerated]
	private Vector3Control <pointerPosition>k__BackingField; // 0x228
	[CompilerGenerated]
	private QuaternionControl <pointerRotation>k__BackingField; // 0x230

	// Properties
	[InputControl(aliases = new[] { "Primary2DAxis", "thumbstickaxes" })]
	public Vector2Control joystick { get; set; }
	[InputControl(aliases = new[] { "Secondary2DAxis", "touchpadaxes" })]
	public Vector2Control touchpad { get; set; }
	[InputControl(aliases = new[] { "gripaxis" })]
	public AxisControl grip { get; set; }
	[InputControl(aliases = new[] { "gripbutton" })]
	public ButtonControl gripPressed { get; set; }
	[InputControl(aliases = new[] { "Primary", "menubutton" })]
	public ButtonControl menu { get; set; }
	[InputControl(aliases = new[] { "triggeraxis" })]
	public AxisControl trigger { get; set; }
	[InputControl(aliases = new[] { "triggerbutton" })]
	public ButtonControl triggerPressed { get; set; }
	[InputControl(aliases = new[] { "thumbstickpressed" })]
	public ButtonControl joystickClicked { get; set; }
	[InputControl(aliases = new[] { "joystickorpadpressed", "touchpadpressed" })]
	public ButtonControl touchpadClicked { get; set; }
	[InputControl(aliases = new[] { "joystickorpadtouched", "touchpadtouched" })]
	public ButtonControl touchpadTouched { get; set; }
	[InputControl(noisy = True, aliases = new[] { "gripVelocity" })]
	public Vector3Control deviceVelocity { get; set; }
	[InputControl(noisy = True, aliases = new[] { "gripAngularVelocity" })]
	public Vector3Control deviceAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public AxisControl batteryLevel { get; set; }
	[InputControl(noisy = True)]
	public AxisControl sourceLossRisk { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control sourceLossMitigationDirection { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control pointerPosition { get; set; }
	[InputControl(noisy = True, aliases = new[] { "PointerOrientation" })]
	public QuaternionControl pointerRotation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public Vector2Control get_joystick() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_joystick(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_touchpad(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public AxisControl get_grip() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_grip(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public ButtonControl get_gripPressed() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_gripPressed(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public ButtonControl get_menu() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_menu(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public AxisControl get_trigger() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_trigger(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public ButtonControl get_triggerPressed() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_triggerPressed(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0
	public ButtonControl get_joystickClicked() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10
	protected void set_joystickClicked(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public ButtonControl get_touchpadClicked() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30
	protected void set_touchpadClicked(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6410E0 Offset: 0x63FAE0 VA: 0x1806410E0
	public ButtonControl get_touchpadTouched() { }

	[CompilerGenerated]
	// RVA: 0x27498C0 Offset: 0x27482C0 VA: 0x1827498C0
	protected void set_touchpadTouched(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	// RVA: 0x27498A0 Offset: 0x27482A0 VA: 0x1827498A0
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6410C0 Offset: 0x63FAC0 VA: 0x1806410C0
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6864B0 Offset: 0x684EB0 VA: 0x1806864B0
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public AxisControl get_batteryLevel() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	protected void set_batteryLevel(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public AxisControl get_sourceLossRisk() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	protected void set_sourceLossRisk(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public Vector3Control get_sourceLossMitigationDirection() { }

	[CompilerGenerated]
	// RVA: 0xA2FF00 Offset: 0xA2E900 VA: 0x180A2FF00
	protected void set_sourceLossMitigationDirection(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0
	public Vector3Control get_pointerPosition() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0
	protected void set_pointerPosition(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00
	public QuaternionControl get_pointerRotation() { }

	[CompilerGenerated]
	// RVA: 0x6415D0 Offset: 0x63FFD0 VA: 0x1806415D0
	protected void set_pointerRotation(QuaternionControl value) { }

	// RVA: 0x2762830 Offset: 0x2761230 VA: 0x182762830 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
