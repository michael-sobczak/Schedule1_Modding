public class OculusRemote : InputDevice // TypeDefIndex: 7245
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <back>k__BackingField; // 0x190
	[CompilerGenerated]
	private ButtonControl <start>k__BackingField; // 0x198
	[CompilerGenerated]
	private Vector2Control <touchpad>k__BackingField; // 0x1A0

	// Properties
	[InputControl]
	public ButtonControl back { get; set; }
	[InputControl]
	public ButtonControl start { get; set; }
	[InputControl]
	public Vector2Control touchpad { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x726290 Offset: 0x724C90 VA: 0x180726290
	public ButtonControl get_back() { }

	[CompilerGenerated]
	// RVA: 0x726490 Offset: 0x724E90 VA: 0x180726490
	protected void set_back(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x1E43DE0 Offset: 0x1E427E0 VA: 0x181E43DE0
	public ButtonControl get_start() { }

	[CompilerGenerated]
	// RVA: 0x1E44940 Offset: 0x1E43340 VA: 0x181E44940
	protected void set_start(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x74CCB0 Offset: 0x74B6B0 VA: 0x18074CCB0
	public Vector2Control get_touchpad() { }

	[CompilerGenerated]
	// RVA: 0x76A800 Offset: 0x769200 VA: 0x18076A800
	protected void set_touchpad(Vector2Control value) { }

	// RVA: 0x275AA40 Offset: 0x2759440 VA: 0x18275AA40 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x275AB30 Offset: 0x2759530 VA: 0x18275AB30
	public void .ctor() { }
}
