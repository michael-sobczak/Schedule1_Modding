public class Joystick : InputDevice // TypeDefIndex: 7372
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <trigger>k__BackingField; // 0x190
	[CompilerGenerated]
	private StickControl <stick>k__BackingField; // 0x198
	[CompilerGenerated]
	private AxisControl <twist>k__BackingField; // 0x1A0
	[CompilerGenerated]
	private Vector2Control <hatswitch>k__BackingField; // 0x1A8
	[CompilerGenerated]
	private static Joystick <current>k__BackingField; // 0x0
	private static int s_JoystickCount; // 0x8
	private static Joystick[] s_Joysticks; // 0x10

	// Properties
	public ButtonControl trigger { get; set; }
	public StickControl stick { get; set; }
	public AxisControl twist { get; set; }
	public Vector2Control hatswitch { get; set; }
	public static Joystick current { get; set; }
	public static ReadOnlyArray<Joystick> all { get; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public ButtonControl get_trigger() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_trigger(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public StickControl get_stick() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	protected void set_stick(StickControl value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public AxisControl get_twist() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	protected void set_twist(AxisControl value) { }

	[CompilerGenerated]
	// RVA: 0x76A7D0 Offset: 0x7691D0 VA: 0x18076A7D0
	public Vector2Control get_hatswitch() { }

	[CompilerGenerated]
	// RVA: 0x76A7E0 Offset: 0x7691E0 VA: 0x18076A7E0
	protected void set_hatswitch(Vector2Control value) { }

	[CompilerGenerated]
	// RVA: 0x27C8680 Offset: 0x27C7080 VA: 0x1827C8680
	public static Joystick get_current() { }

	[CompilerGenerated]
	// RVA: 0x27C86C0 Offset: 0x27C70C0 VA: 0x1827C86C0
	private static void set_current(Joystick value) { }

	// RVA: 0x27C8610 Offset: 0x27C7010 VA: 0x1827C8610
	public static ReadOnlyArray<Joystick> get_all() { }

	// RVA: 0x27C82E0 Offset: 0x27C6CE0 VA: 0x1827C82E0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x27C8420 Offset: 0x27C6E20 VA: 0x1827C8420 Slot: 17
	public override void MakeCurrent() { }

	// RVA: 0x27C8480 Offset: 0x27C6E80 VA: 0x1827C8480 Slot: 18
	protected override void OnAdded() { }

	// RVA: 0x27C84F0 Offset: 0x27C6EF0 VA: 0x1827C84F0 Slot: 19
	protected override void OnRemoved() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
