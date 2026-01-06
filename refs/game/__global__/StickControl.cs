public class StickControl : Vector2Control // TypeDefIndex: 7782
{
	// Fields
	[CompilerGenerated]
	private ButtonControl <up>k__BackingField; // 0x120
	[CompilerGenerated]
	private ButtonControl <down>k__BackingField; // 0x128
	[CompilerGenerated]
	private ButtonControl <left>k__BackingField; // 0x130
	[CompilerGenerated]
	private ButtonControl <right>k__BackingField; // 0x138

	// Properties
	[InputControl(name = "y", minValue = -1, maxValue = 1, layout = "Axis", processors = "axisDeadzone")]
	[InputControl(name = "x", minValue = -1, maxValue = 1, layout = "Axis", processors = "axisDeadzone")]
	[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = True, displayName = "Up")]
	public ButtonControl up { get; set; }
	[InputControl(useStateFrom = "y", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = True, displayName = "Down")]
	public ButtonControl down { get; set; }
	[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=-1,clampMax=0,invert", synthetic = True, displayName = "Left")]
	public ButtonControl left { get; set; }
	[InputControl(useStateFrom = "x", processors = "axisDeadzone", parameters = "clamp=2,clampMin=0,clampMax=1", synthetic = True, displayName = "Right")]
	public ButtonControl right { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x5995E0 Offset: 0x597FE0 VA: 0x1805995E0
	public ButtonControl get_up() { }

	[CompilerGenerated]
	// RVA: 0x599640 Offset: 0x598040 VA: 0x180599640
	public void set_up(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public ButtonControl get_down() { }

	[CompilerGenerated]
	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	public void set_down(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840
	public ButtonControl get_left() { }

	[CompilerGenerated]
	// RVA: 0x65D8D0 Offset: 0x65C2D0 VA: 0x18065D8D0
	public void set_left(ButtonControl value) { }

	[CompilerGenerated]
	// RVA: 0x65D850 Offset: 0x65C250 VA: 0x18065D850
	public ButtonControl get_right() { }

	[CompilerGenerated]
	// RVA: 0x65D8F0 Offset: 0x65C2F0 VA: 0x18065D8F0
	public void set_right(ButtonControl value) { }

	// RVA: 0x278AA30 Offset: 0x2789430 VA: 0x18278AA30 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x2779A70 Offset: 0x2778470 VA: 0x182779A70
	public void .ctor() { }
}
