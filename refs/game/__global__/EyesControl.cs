public class EyesControl : InputControl<Eyes> // TypeDefIndex: 7476
{
	// Fields
	[CompilerGenerated]
	private Vector3Control <leftEyePosition>k__BackingField; // 0x198
	[CompilerGenerated]
	private QuaternionControl <leftEyeRotation>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private Vector3Control <rightEyePosition>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private QuaternionControl <rightEyeRotation>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private Vector3Control <fixationPoint>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private AxisControl <leftEyeOpenAmount>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private AxisControl <rightEyeOpenAmount>k__BackingField; // 0x1C8

	// Properties
	[InputControl(offset = 0, displayName = "LeftEyePosition")]
	public Vector3Control leftEyePosition { get; set; }
	[InputControl(offset = 12, displayName = "LeftEyeRotation")]
	public QuaternionControl leftEyeRotation { get; set; }
	[InputControl(offset = 28, displayName = "RightEyePosition")]
	public Vector3Control rightEyePosition { get; set; }
	[InputControl(offset = 40, displayName = "RightEyeRotation")]
	public QuaternionControl rightEyeRotation { get; set; }
	[InputControl(offset = 56, displayName = "FixationPoint")]
	public Vector3Control fixationPoint { get; set; }
	[InputControl(offset = 68, displayName = "LeftEyeOpenAmount")]
	public AxisControl leftEyeOpenAmount { get; set; }
	[InputControl(offset = 72, displayName = "RightEyeOpenAmount")]
	public AxisControl rightEyeOpenAmount { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public Vector3Control get_leftEyePosition() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	public void set_leftEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public QuaternionControl get_leftEyeRotation() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	public void set_leftEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public Vector3Control get_rightEyePosition() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	public void set_rightEyePosition(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public QuaternionControl get_rightEyeRotation() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	public void set_rightEyeRotation(QuaternionControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public Vector3Control get_fixationPoint() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	public void set_fixationPoint(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public AxisControl get_leftEyeOpenAmount() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	public void set_leftEyeOpenAmount(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public AxisControl get_rightEyeOpenAmount() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	public void set_rightEyeOpenAmount(AxisControl value) { }

	// RVA: 0x281F8F0 Offset: 0x281E2F0 VA: 0x18281F8F0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x281FAE0 Offset: 0x281E4E0 VA: 0x18281FAE0 Slot: 17
	public override Eyes ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x281FCA0 Offset: 0x281E6A0 VA: 0x18281FCA0 Slot: 18
	public override void WriteValueIntoState(Eyes value, void* statePtr) { }

	// RVA: 0x281FE40 Offset: 0x281E840 VA: 0x18281FE40
	public void .ctor() { }
}
