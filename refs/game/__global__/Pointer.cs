public class Pointer : InputDevice, IInputStateCallbackReceiver // TypeDefIndex: 7379
{
	// Fields
	[CompilerGenerated]
	private Vector2Control <position>k__BackingField; // 0x190
	[CompilerGenerated]
	private DeltaControl <delta>k__BackingField; // 0x198
	[CompilerGenerated]
	private Vector2Control <radius>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private AxisControl <pressure>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private ButtonControl <press>k__BackingField; // 0x1B0
	[CompilerGenerated]
	private IntegerControl <displayIndex>k__BackingField; // 0x1B8
	[CompilerGenerated]
	private static Pointer <current>k__BackingField; // 0x0

	// Properties
	public Vector2Control position { get; set; }
	public DeltaControl delta { get; set; }
	public Vector2Control radius { get; set; }
	public AxisControl pressure { get; set; }
	public ButtonControl press { get; set; }
	public IntegerControl displayIndex { get; set; }
	public static Pointer current { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public Vector2Control get_position() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_position(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public DeltaControl get_delta() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	protected void set_delta(DeltaControl value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public Vector2Control get_radius() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	protected void set_radius(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public AxisControl get_pressure() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	protected void set_pressure(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0xBF2630 Offset: 0xBF1030 VA: 0x180BF2630
	public ButtonControl get_press() { }

	[CompilerGenerated]
	// RVA: 0xBF26E0 Offset: 0xBF10E0 VA: 0x180BF26E0
	protected void set_press(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x67E970 Offset: 0x67D370 VA: 0x18067E970
	public IntegerControl get_displayIndex() { }

	[CompilerGenerated]
	// RVA: 0x67EAC0 Offset: 0x67D4C0 VA: 0x18067EAC0
	protected void set_displayIndex(IntegerControl value) { }

	[CompilerGenerated]
	// RVA: 0x27CC200 Offset: 0x27CAC00 VA: 0x1827CC200
	public static Pointer get_current() { }

	[CompilerGenerated]
	// RVA: 0x27CC240 Offset: 0x27CAC40 VA: 0x1827CC240
	internal static void set_current(Pointer value) { }

	// RVA: 0x27CC010 Offset: 0x27CAA10 VA: 0x1827CC010 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x27CC100 Offset: 0x27CAB00 VA: 0x1827CC100 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x27CBE50 Offset: 0x27CA850 VA: 0x1827CBE50 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x27CC070 Offset: 0x27CAA70 VA: 0x1827CC070
	protected void OnNextUpdate() { }

	// RVA: 0x27CC190 Offset: 0x27CAB90 VA: 0x1827CC190
	protected void OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x27CC1F0 Offset: 0x27CABF0 VA: 0x1827CC1F0 Slot: 22
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnNextUpdate() { }

	// RVA: 0x27CC190 Offset: 0x27CAB90 VA: 0x1827CC190 Slot: 23
	private void UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.OnStateEvent(InputEventPtr eventPtr) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 24
	private bool UnityEngine.InputSystem.LowLevel.IInputStateCallbackReceiver.GetStateOffsetForEvent(InputControl control, InputEventPtr eventPtr, ref uint offset) { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
