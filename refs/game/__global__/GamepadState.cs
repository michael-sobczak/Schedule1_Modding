public struct GamepadState : IInputStateTypeInfo // TypeDefIndex: 7634
{
	// Fields
	internal const string ButtonSouthShortDisplayName = "A";
	internal const string ButtonNorthShortDisplayName = "Y";
	internal const string ButtonWestShortDisplayName = "X";
	internal const string ButtonEastShortDisplayName = "B";
	[InputControl(name = "dpad", layout = "Dpad", usage = "Hatswitch", displayName = "D-Pad", format = "BIT", sizeInBits = 4, bit = 0)]
	[InputControl(name = "buttonSouth", layout = "Button", bit = 6, usages = new[] { "PrimaryAction", "Submit" }, aliases = new[] { "a", "cross" }, displayName = "Button South", shortDisplayName = "A")]
	[InputControl(name = "buttonWest", layout = "Button", bit = 7, usage = "SecondaryAction", aliases = new[] { "x", "square" }, displayName = "Button West", shortDisplayName = "X")]
	[InputControl(name = "buttonNorth", layout = "Button", bit = 4, aliases = new[] { "y", "triangle" }, displayName = "Button North", shortDisplayName = "Y")]
	[InputControl(name = "buttonEast", layout = "Button", bit = 5, usages = new[] { "Back", "Cancel" }, aliases = new[] { "b", "circle" }, displayName = "Button East", shortDisplayName = "B")]
	[InputControl(name = "rightStickPress", layout = "Button", bit = 9, displayName = "Right Stick Press")]
	[InputControl(name = "leftShoulder", layout = "Button", bit = 10, displayName = "Left Shoulder", shortDisplayName = "LB")]
	[InputControl(name = "rightShoulder", layout = "Button", bit = 11, displayName = "Right Shoulder", shortDisplayName = "RB")]
	[InputControl(name = "start", layout = "Button", bit = 12, usage = "Menu", displayName = "Start")]
	[InputControl(name = "select", layout = "Button", bit = 13, displayName = "Select")]
	[InputControl(name = "leftStickPress", layout = "Button", bit = 8, displayName = "Left Stick Press")]
	public uint buttons; // 0x0
	[InputControl(layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone", displayName = "Left Stick", shortDisplayName = "LS")]
	public Vector2 leftStick; // 0x4
	[InputControl(layout = "Stick", usage = "Secondary2DMotion", processors = "stickDeadzone", displayName = "Right Stick", shortDisplayName = "RS")]
	public Vector2 rightStick; // 0xC
	[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Left Trigger", shortDisplayName = "LT")]
	public float leftTrigger; // 0x14
	[InputControl(layout = "Button", format = "FLT", usage = "SecondaryTrigger", displayName = "Right Trigger", shortDisplayName = "RT")]
	public float rightTrigger; // 0x18

	// Properties
	public static FourCC Format { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x285AC30 Offset: 0x2859630 VA: 0x18285AC30
	public static FourCC get_Format() { }

	// RVA: 0x285AC70 Offset: 0x2859670 VA: 0x18285AC70 Slot: 4
	public FourCC get_format() { }

	// RVA: 0x285AB80 Offset: 0x2859580 VA: 0x18285AB80
	public void .ctor(GamepadButton[] buttons) { }

	// RVA: 0x285AB30 Offset: 0x2859530 VA: 0x18285AB30
	public GamepadState WithButton(GamepadButton button, bool value = True) { }
}
