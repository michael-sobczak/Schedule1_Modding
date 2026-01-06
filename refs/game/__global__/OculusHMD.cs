public class OculusHMD : XRHMD // TypeDefIndex: 7242
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <userPresence>k__BackingField; // 0x1E0
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private Vector3Control <deviceAcceleration>k__BackingField; // 0x1F0
	[CompilerGenerated]
	private Vector3Control <deviceAngularAcceleration>k__BackingField; // 0x1F8
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularVelocity>k__BackingField; // 0x200
	[CompilerGenerated]
	private Vector3Control <leftEyeAcceleration>k__BackingField; // 0x208
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularAcceleration>k__BackingField; // 0x210
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularVelocity>k__BackingField; // 0x218
	[CompilerGenerated]
	private Vector3Control <rightEyeAcceleration>k__BackingField; // 0x220
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularAcceleration>k__BackingField; // 0x228
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularVelocity>k__BackingField; // 0x230
	[CompilerGenerated]
	private Vector3Control <centerEyeAcceleration>k__BackingField; // 0x238
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularAcceleration>k__BackingField; // 0x240

	// Properties
	[InputControl]
	[InputControl(name = "trackingState", layout = "Integer", aliases = new[] { "devicetrackingstate" })]
	[InputControl(name = "isTracked", layout = "Button", aliases = new[] { "deviceistracked" })]
	public ButtonControl userPresence { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAcceleration { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAngularAcceleration { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control leftEyeAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control leftEyeAcceleration { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control leftEyeAngularAcceleration { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control rightEyeAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control rightEyeAcceleration { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control rightEyeAngularAcceleration { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control centerEyeAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control centerEyeAcceleration { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control centerEyeAngularAcceleration { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public ButtonControl get_userPresence() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_userPresence(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public Vector3Control get_deviceAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30
	protected void set_deviceAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6410E0 Offset: 0x63FAE0 VA: 0x1806410E0
	public Vector3Control get_deviceAngularAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x27498C0 Offset: 0x27482C0 VA: 0x1827498C0
	protected void set_deviceAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	public Vector3Control get_leftEyeAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x27498A0 Offset: 0x27482A0 VA: 0x1827498A0
	protected void set_leftEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6410C0 Offset: 0x63FAC0 VA: 0x1806410C0
	public Vector3Control get_leftEyeAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x6864B0 Offset: 0x684EB0 VA: 0x1806864B0
	protected void set_leftEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public Vector3Control get_leftEyeAngularAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	protected void set_leftEyeAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public Vector3Control get_rightEyeAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	protected void set_rightEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x9CAEF0 Offset: 0x9C98F0 VA: 0x1809CAEF0
	public Vector3Control get_rightEyeAcceleration() { }

	[CompilerGenerated]
	// RVA: 0xA2FF00 Offset: 0xA2E900 VA: 0x180A2FF00
	protected void set_rightEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x76CFB0 Offset: 0x76B9B0 VA: 0x18076CFB0
	public Vector3Control get_rightEyeAngularAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x76CFC0 Offset: 0x76B9C0 VA: 0x18076CFC0
	protected void set_rightEyeAngularAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640F00 Offset: 0x63F900 VA: 0x180640F00
	public Vector3Control get_centerEyeAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6415D0 Offset: 0x63FFD0 VA: 0x1806415D0
	protected void set_centerEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x8A7560 Offset: 0x8A5F60 VA: 0x1808A7560
	public Vector3Control get_centerEyeAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x8A78E0 Offset: 0x8A62E0 VA: 0x1808A78E0
	protected void set_centerEyeAcceleration(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640C70 Offset: 0x63F670 VA: 0x180640C70
	public Vector3Control get_centerEyeAngularAcceleration() { }

	[CompilerGenerated]
	// RVA: 0x860C80 Offset: 0x85F680 VA: 0x180860C80
	protected void set_centerEyeAngularAcceleration(Vector3Control value) { }

	// RVA: 0x275A720 Offset: 0x2759120 VA: 0x18275A720 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
