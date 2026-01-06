public class XRHMD : TrackedDevice // TypeDefIndex: 7459
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <leftEyePosition>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private QuaternionControl <leftEyeRotation>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private Vector3Control <rightEyePosition>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private QuaternionControl <rightEyeRotation>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private Vector3Control <centerEyePosition>k__BackingField; // 0x1D0
	[CompilerGenerated]
	private QuaternionControl <centerEyeRotation>k__BackingField; // 0x1D8

	// Properties
	[InputControl(noisy = True)]
	public Vector3Control leftEyePosition { get; set; }
	[InputControl(noisy = True)]
	public QuaternionControl leftEyeRotation { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control rightEyePosition { get; set; }
	[InputControl(noisy = True)]
	public QuaternionControl rightEyeRotation { get; set; }
	[InputControl(noisy = True)]
	public Vector3Control centerEyePosition { get; set; }
	[InputControl(noisy = True)]
	public QuaternionControl centerEyeRotation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public Vector3Control get_leftEyePosition() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_leftEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public QuaternionControl get_leftEyeRotation() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_leftEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public Vector3Control get_rightEyePosition() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	protected void set_rightEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public QuaternionControl get_rightEyeRotation() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	protected void set_rightEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public Vector3Control get_centerEyePosition() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	protected void set_centerEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x6855A0 Offset: 0x683FA0 VA: 0x1806855A0
	public QuaternionControl get_centerEyeRotation() { }

	[CompilerGenerated]
	// RVA: 0x6855B0 Offset: 0x683FB0 VA: 0x1806855B0
	protected void set_centerEyeRotation(QuaternionControl value) { }

	// RVA: 0x283B660 Offset: 0x283A060 VA: 0x18283B660 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x274A080 Offset: 0x2748A80 VA: 0x18274A080
	public void .ctor() { }
}
