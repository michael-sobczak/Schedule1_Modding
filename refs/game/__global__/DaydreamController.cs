public class DaydreamController : XRController // TypeDefIndex: 7249
{
	// Fields
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private ButtonControl <volumeUp>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private ButtonControl <recentered>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private ButtonControl <volumeDown>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private ButtonControl <recentering>k__BackingField; // 0x1D0
	[CompilerGenerated]
	private ButtonControl <app>k__BackingField; // 0x1D8
	[CompilerGenerated]
	private ButtonControl <home>k__BackingField; // 0x1E0
	[CompilerGenerated]
	private ButtonControl <touchpadClicked>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private ButtonControl <touchpadTouched>k__BackingField; // 0x1F0
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; // 0x1F8
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; // 0x200

	// Properties
	[InputControl]
	public Vector2Control touchpad { get; set; }
	[InputControl]
	public ButtonControl volumeUp { get; set; }
	[InputControl]
	public ButtonControl recentered { get; set; }
	[InputControl]
	public ButtonControl volumeDown { get; set; }
	[InputControl]
	public ButtonControl recentering { get; set; }
	[InputControl]
	public ButtonControl app { get; set; }
	[InputControl]
	public ButtonControl home { get; set; }
	[InputControl]
	public ButtonControl touchpadClicked { get; set; }
	[InputControl]
	public ButtonControl touchpadTouched { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAcceleration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_touchpad(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public ButtonControl get_volumeUp() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_volumeUp(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public ButtonControl get_recentered() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_recentered(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public ButtonControl get_volumeDown() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_volumeDown(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public ButtonControl get_recentering() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_recentering(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public ButtonControl get_app() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_app(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public ButtonControl get_home() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_home(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0
	public ButtonControl get_touchpadClicked() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10
	protected void set_touchpadClicked(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public ButtonControl get_touchpadTouched() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30
	protected void set_touchpadTouched(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6410E0 Offset: 0x63FAE0 VA: 0x1806410E0
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	// RVA: 0x27498C0 Offset: 0x27482C0 VA: 0x1827498C0
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x27498A0 Offset: 0x27482A0 VA: 0x1827498A0
	protected void set_deviceAcceleration(Vector3Control value) { }

	// RVA: 0x27495D0 Offset: 0x2747FD0 VA: 0x1827495D0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
