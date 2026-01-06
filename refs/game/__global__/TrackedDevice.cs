public class TrackedDevice : InputDevice // TypeDefIndex: 7422
{
	// Fields
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; // 0x190
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; // 0x198
	[CompilerGenerated]
	private Vector3Control <devicePosition>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private QuaternionControl <deviceRotation>k__BackingField; // 0x1A8

	// Properties
	[InputControl(synthetic = True)]
	public IntegerControl trackingState { get; set; }
	[InputControl(synthetic = True)]
	public ButtonControl isTracked { get; set; }
	[InputControl(noisy = True, dontReset = True)]
	public Vector3Control devicePosition { get; set; }
	[InputControl(noisy = True, dontReset = True)]
	public QuaternionControl deviceRotation { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_trackingState(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	protected void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public Vector3Control get_devicePosition() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	protected void set_devicePosition(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public QuaternionControl get_deviceRotation() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	protected void set_deviceRotation(QuaternionControl value) { }

	// RVA: 0x281DB90 Offset: 0x281C590 VA: 0x18281DB90 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
