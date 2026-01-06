internal struct JoystickState : IInputStateTypeInfo // TypeDefIndex: 7643
{
	// Fields
	[InputControl(name = "trigger", displayName = "Trigger", layout = "Button", usages = new[] { "PrimaryTrigger", "PrimaryAction", "Submit" }, bit = 4)]
	public int buttons; // 0x0
	[InputControl(displayName = "Stick", layout = "Stick", usage = "Primary2DMotion", processors = "stickDeadzone")]
	public Vector2 stick; // 0x4

	// Properties
	public static FourCC kFormat { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2864BA0 Offset: 0x28635A0 VA: 0x182864BA0
	public static FourCC get_kFormat() { }

	// RVA: 0x2864B60 Offset: 0x2863560 VA: 0x182864B60 Slot: 4
	public FourCC get_format() { }
}
