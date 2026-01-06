public class OpenVRHMD : XRHMD // TypeDefIndex: 7235
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <deviceVelocity>k__BackingField; // 0x1E0
	[CompilerGenerated]
	private Vector3Control <deviceAngularVelocity>k__BackingField; // 0x1E8
	[CompilerGenerated]
	private Vector3Control <leftEyeVelocity>k__BackingField; // 0x1F0
	[CompilerGenerated]
	private Vector3Control <leftEyeAngularVelocity>k__BackingField; // 0x1F8
	[CompilerGenerated]
	private Vector3Control <rightEyeVelocity>k__BackingField; // 0x200
	[CompilerGenerated]
	private Vector3Control <rightEyeAngularVelocity>k__BackingField; // 0x208
	[CompilerGenerated]
	private Vector3Control <centerEyeVelocity>k__BackingField; // 0x210
	[CompilerGenerated]
	private Vector3Control <centerEyeAngularVelocity>k__BackingField; // 0x218

	// Properties
	[InputControl(noisy = True)]
	public Vector3Control deviceVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control deviceAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control leftEyeVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control leftEyeAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control rightEyeVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control rightEyeAngularVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control centerEyeVelocity { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control centerEyeAngularVelocity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x688E20 Offset: 0x687820 VA: 0x180688E20
	public Vector3Control get_deviceVelocity() { }

	[CompilerGenerated]
	// RVA: 0x718BD0 Offset: 0x7175D0 VA: 0x180718BD0
	protected void set_deviceVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCE0 Offset: 0x6BE6E0 VA: 0x1806BFCE0
	public Vector3Control get_deviceAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6BFF10 Offset: 0x6BE910 VA: 0x1806BFF10
	protected void set_deviceAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCF0 Offset: 0x6BE6F0 VA: 0x1806BFCF0
	public Vector3Control get_leftEyeVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6BFF30 Offset: 0x6BE930 VA: 0x1806BFF30
	protected void set_leftEyeVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6410E0 Offset: 0x63FAE0 VA: 0x1806410E0
	public Vector3Control get_leftEyeAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x27498C0 Offset: 0x27482C0 VA: 0x1827498C0
	protected void set_leftEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x2031380 Offset: 0x202FD80 VA: 0x182031380
	public Vector3Control get_rightEyeVelocity() { }

	[CompilerGenerated]
	// RVA: 0x27498A0 Offset: 0x27482A0 VA: 0x1827498A0
	protected void set_rightEyeVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6410C0 Offset: 0x63FAC0 VA: 0x1806410C0
	public Vector3Control get_rightEyeAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6864B0 Offset: 0x684EB0 VA: 0x1806864B0
	protected void set_rightEyeAngularVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640D80 Offset: 0x63F780 VA: 0x180640D80
	public Vector3Control get_centerEyeVelocity() { }

	[CompilerGenerated]
	// RVA: 0x9CAFC0 Offset: 0x9C99C0 VA: 0x1809CAFC0
	protected void set_centerEyeVelocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x640D70 Offset: 0x63F770 VA: 0x180640D70
	public Vector3Control get_centerEyeAngularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x6413A0 Offset: 0x63FDA0 VA: 0x1806413A0
	protected void set_centerEyeAngularVelocity(Vector3Control value) { }

	// RVA: 0x275B2E0 Offset: 0x2759CE0 VA: 0x18275B2E0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2749890 Offset: 0x2748290 VA: 0x182749890
	public void .ctor() { }
}
