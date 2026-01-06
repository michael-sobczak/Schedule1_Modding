public class PoseControl : InputControl<PoseState> // TypeDefIndex: 7458
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <isTracked>k__BackingField; // 0x178
	[CompilerGenerated]
	private IntegerControl <trackingState>k__BackingField; // 0x180
	[CompilerGenerated]
	private Vector3Control <position>k__BackingField; // 0x188
	[CompilerGenerated]
	private QuaternionControl <rotation>k__BackingField; // 0x190
	[CompilerGenerated]
	private Vector3Control <velocity>k__BackingField; // 0x198
	[CompilerGenerated]
	private Vector3Control <angularVelocity>k__BackingField; // 0x1A0

	// Properties
	public ButtonControl isTracked { get; set; }
	public IntegerControl trackingState { get; set; }
	public Vector3Control position { get; set; }
	public QuaternionControl rotation { get; set; }
	public Vector3Control velocity { get; set; }
	public Vector3Control angularVelocity { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x6BFCC0 Offset: 0x6BE6C0 VA: 0x1806BFCC0
	public ButtonControl get_isTracked() { }

	[CompilerGenerated]
	// RVA: 0x74C8F0 Offset: 0x74B2F0 VA: 0x18074C8F0
	public void set_isTracked(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x73B370 Offset: 0x739D70 VA: 0x18073B370
	public IntegerControl get_trackingState() { }

	[CompilerGenerated]
	// RVA: 0x73B4D0 Offset: 0x739ED0 VA: 0x18073B4D0
	public void set_trackingState(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380
	public Vector3Control get_position() { }

	[CompilerGenerated]
	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	public void set_position(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public QuaternionControl get_rotation() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	public void set_rotation(QuaternionControl value) { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public Vector3Control get_velocity() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	public void set_velocity(Vector3Control value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public Vector3Control get_angularVelocity() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	public void set_angularVelocity(Vector3Control value) { }

	// RVA: 0x2834770 Offset: 0x2833170 VA: 0x182834770
	public void .ctor() { }

	// RVA: 0x2834180 Offset: 0x2832B80 VA: 0x182834180 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2834340 Offset: 0x2832D40 VA: 0x182834340 Slot: 17
	public override PoseState ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x2834550 Offset: 0x2832F50 VA: 0x182834550 Slot: 18
	public override void WriteValueIntoState(PoseState value, void* statePtr) { }

	// RVA: 0x2833F00 Offset: 0x2832900 VA: 0x182833F00 Slot: 15
	protected override FourCC CalculateOptimizedControlDataType() { }
}
