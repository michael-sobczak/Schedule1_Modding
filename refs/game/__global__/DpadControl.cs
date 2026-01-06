public class DpadControl : Vector2Control // TypeDefIndex: 7778
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
	[InputControl(bit = 0, displayName = "Up")]
	[InputControl(name = "y", layout = "DpadAxis", useStateFrom = "up", synthetic = True)]
	[InputControl(name = "x", layout = "DpadAxis", useStateFrom = "right", synthetic = True)]
	public ButtonControl up { get; set; }
	[InputControl(bit = 1, displayName = "Down")]
	public ButtonControl down { get; set; }
	[InputControl(bit = 2, displayName = "Left")]
	public ButtonControl left { get; set; }
	[InputControl(bit = 3, displayName = "Right")]
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

	// RVA: 0x277A740 Offset: 0x2779140 VA: 0x18277A740
	public void .ctor() { }

	// RVA: 0x277A0C0 Offset: 0x2778AC0 VA: 0x18277A0C0 Slot: 13
	protected override void FinishSetup() { }

	// RVA: 0x277A280 Offset: 0x2778C80 VA: 0x18277A280 Slot: 17
	public override Vector2 ReadUnprocessedValueFromState(void* statePtr) { }

	// RVA: 0x277A560 Offset: 0x2778F60 VA: 0x18277A560 Slot: 18
	public override void WriteValueIntoState(Vector2 value, void* statePtr) { }

	// RVA: 0x277A200 Offset: 0x2778C00 VA: 0x18277A200
	public static Vector2 MakeDpadVector(bool up, bool down, bool left, bool right, bool normalize = True) { }

	// RVA: 0x277A1E0 Offset: 0x2778BE0 VA: 0x18277A1E0
	public static Vector2 MakeDpadVector(float up, float down, float left, float right) { }
}
