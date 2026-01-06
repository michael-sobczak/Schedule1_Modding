public struct MouseState : IInputStateTypeInfo // TypeDefIndex: 7646
{
	// Fields
	[InputControl(usage = "Point", dontReset = True)]
	public Vector2 position; // 0x0
	[InputControl(usage = "Secondary2DMotion", layout = "Delta")]
	public Vector2 delta; // 0x8
	[InputControl(displayName = "Scroll", layout = "Delta")]
	[InputControl(name = "scroll/x", aliases = new[] { "horizontal" }, usage = "ScrollHorizontal", displayName = "Left/Right")]
	[InputControl(name = "scroll/y", aliases = new[] { "vertical" }, usage = "ScrollVertical", displayName = "Up/Down", shortDisplayName = "Wheel")]
	public Vector2 scroll; // 0x10
	[InputControl(name = "radius", layout = "Vector2", usage = "Radius", offset = 4294967294, format = "VEC2", sizeInBits = 64)]
	[InputControl(name = "pointerId", layout = "Digital", format = "BIT", sizeInBits = 1, offset = 4294967294)]
	[InputControl(name = "pressure", layout = "Axis", usage = "Pressure", offset = 4294967294, format = "FLT", sizeInBits = 32)]
	[InputControl(name = "forwardButton", layout = "Button", bit = 3, usage = "Forward", displayName = "Forward")]
	[InputControl(name = "middleButton", layout = "Button", bit = 2, displayName = "Middle Button", shortDisplayName = "MMB")]
	[InputControl(name = "rightButton", layout = "Button", bit = 1, usage = "SecondaryAction", displayName = "Right Button", shortDisplayName = "RMB")]
	[InputControl(name = "backButton", layout = "Button", bit = 4, usage = "Back", displayName = "Back")]
	[InputControl(name = "press", useStateFrom = "leftButton", synthetic = True, usages = new[] {  })]
	[InputControl(name = "leftButton", layout = "Button", bit = 0, usage = "PrimaryAction", displayName = "Left Button", shortDisplayName = "LMB")]
	public ushort buttons; // 0x18
	[InputControl(name = "displayIndex", layout = "Integer", displayName = "Display Index")]
	public ushort displayIndex; // 0x1A
	[InputControl(name = "clickCount", layout = "Integer", displayName = "Click Count", synthetic = True)]
	public ushort clickCount; // 0x1C

	// Properties
	public static FourCC Format { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2864F20 Offset: 0x2863920 VA: 0x182864F20
	public static FourCC get_Format() { }

	// RVA: 0x2864EC0 Offset: 0x28638C0 VA: 0x182864EC0
	public MouseState WithButton(MouseButton button, bool state = True) { }

	// RVA: 0x2864F60 Offset: 0x2863960 VA: 0x182864F60 Slot: 4
	public FourCC get_format() { }
}
