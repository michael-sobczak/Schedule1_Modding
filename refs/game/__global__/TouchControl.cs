public class TouchControl : InputControl<TouchState> // TypeDefIndex: 7783
{
	// Fields
	[CompilerGenerated]
	private TouchPressControl <press>k__BackingField; // 0x170
	[CompilerGenerated]
	private IntegerControl <displayIndex>k__BackingField; // 0x178
	[CompilerGenerated]
	private IntegerControl <touchId>k__BackingField; // 0x180
	[CompilerGenerated]
	private Vector2Control <position>k__BackingField; // 0x188
	[CompilerGenerated]
	private DeltaControl <delta>k__BackingField; // 0x190
	[CompilerGenerated]
	private AxisControl <pressure>k__BackingField; // 0x198
	[CompilerGenerated]
	private Vector2Control <radius>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private TouchPhaseControl <phase>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private ButtonControl <indirectTouch>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private ButtonControl <tap>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private IntegerControl <tapCount>k__BackingField; // 0x1C0
	[CompilerGenerated]
	private DoubleControl <startTime>k__BackingField; // 0x1C8
	[CompilerGenerated]
	private Vector2Control <startPosition>k__BackingField; // 0x1D0

	// Properties
	public TouchPressControl press { get; set; }
	public IntegerControl displayIndex { get; set; }
	public IntegerControl touchId { get; set; }
	public Vector2Control position { get; set; }
	public DeltaControl delta { get; set; }
	public AxisControl pressure { get; set; }
	public Vector2Control radius { get; set; }
	public TouchPhaseControl phase { get; set; }
	public ButtonControl indirectTouch { get; set; }
	public ButtonControl tap { get; set; }
	public IntegerControl tapCount { get; set; }
	public DoubleControl startTime { get; set; }
	public Vector2Control startPosition { get; set; }
	public bool isInProgress { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x73B360 Offset: 0x739D60 VA: 0x18073B360
	public TouchPressControl get_press() { }

	[CompilerGenerated]
	// RVA: 0x73B4B0 Offset: 0x739EB0 VA: 0x18073B4B0
	public void set_press(TouchPressControl value) { }

	[CompilerGenerated]
	// RVA: 0x6BFCC0 Offset: 0x6BE6C0 VA: 0x1806BFCC0
	public IntegerControl get_displayIndex() { }

	[CompilerGenerated]
	// RVA: 0x74C8F0 Offset: 0x74B2F0 VA: 0x18074C8F0
	public void set_displayIndex(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x73B370 Offset: 0x739D70 VA: 0x18073B370
	public IntegerControl get_touchId() { }

	[CompilerGenerated]
	// RVA: 0x73B4D0 Offset: 0x739ED0 VA: 0x18073B4D0
	public void set_touchId(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x73B380 Offset: 0x739D80 VA: 0x18073B380
	public Vector2Control get_position() { }

	[CompilerGenerated]
	// RVA: 0x73B4F0 Offset: 0x739EF0 VA: 0x18073B4F0
	public void set_position(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public DeltaControl get_delta() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	public void set_delta(DeltaControl value) { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public AxisControl get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	public void set_pressure(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public Vector2Control get_radius() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	public void set_radius(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public TouchPhaseControl get_phase() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	public void set_phase(TouchPhaseControl value) { }

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public ButtonControl get_indirectTouch() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	public void set_indirectTouch(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public ButtonControl get_tap() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	public void set_tap(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E980 Offset: 0x67D380 VA: 0x18067E980
	public IntegerControl get_tapCount() { }

	[CompilerGenerated]
	// RVA: 0x67EAE0 Offset: 0x67D4E0 VA: 0x18067EAE0
	public void set_tapCount(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x726430 Offset: 0x724E30 VA: 0x180726430
	public DoubleControl get_startTime() { }

	[CompilerGenerated]
	// RVA: 0x7264F0 Offset: 0x724EF0 VA: 0x1807264F0
	public void set_startTime(DoubleControl value) { }

	[CompilerGenerated]
	// RVA: 0x68E6E0 Offset: 0x68D0E0 VA: 0x18068E6E0
	public Vector2Control get_startPosition() { }

	[CompilerGenerated]
	// RVA: 0x68E700 Offset: 0x68D100 VA: 0x18068E700
	public void set_startPosition(Vector2Control value) { }

	// RVA: 0x278B320 Offset: 0x2789D20 VA: 0x18278B320
	public bool get_isInProgress() { }

	// RVA: 0x278B2B0 Offset: 0x2789CB0 VA: 0x18278B2B0
	public void .ctor() { }

	// RVA: 0x278AE20 Offset: 0x2789820 VA: 0x18278AE20 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x278B1A0 Offset: 0x2789BA0 VA: 0x18278B1A0 Slot: 17
	public override TouchState ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x278B230 Offset: 0x2789C30 VA: 0x18278B230 Slot: 18
	public override void WriteValueIntoState(TouchState value, void* statePtr) { }
}
