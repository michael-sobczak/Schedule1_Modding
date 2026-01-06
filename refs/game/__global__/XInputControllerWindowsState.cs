internal struct XInputControllerWindowsState : IInputStateTypeInfo // TypeDefIndex: 7495
{
	// Fields
	[InputControl(name = "buttonEast", bit = 13, displayName = "B")]
	[InputControl(name = "buttonSouth", bit = 12, displayName = "A")]
	[InputControl(name = "rightShoulder", bit = 9)]
	[InputControl(name = "leftShoulder", bit = 8)]
	[InputControl(name = "rightStickPress", bit = 7)]
	[InputControl(name = "leftStickPress", bit = 6)]
	[InputControl(name = "dpad/up", bit = 0)]
	[InputControl(name = "dpad/down", bit = 1)]
	[InputControl(name = "dpad", layout = "Dpad", sizeInBits = 4, bit = 0)]
	[InputControl(name = "buttonWest", bit = 14, displayName = "X")]
	[InputControl(name = "select", bit = 5, displayName = "Select")]
	[InputControl(name = "start", bit = 4, displayName = "Start")]
	[InputControl(name = "dpad/right", bit = 3)]
	[InputControl(name = "dpad/left", bit = 2)]
	[InputControl(name = "buttonNorth", bit = 15, displayName = "Y")]
	public ushort buttons; // 0x0
	[InputControl(name = "leftTrigger", format = "BYTE")]
	public byte leftTrigger; // 0x2
	[InputControl(name = "rightTrigger", format = "BYTE")]
	public byte rightTrigger; // 0x3
	[InputControl(name = "leftStick/down", offset = 2, format = "SHRT")]
	[InputControl(name = "leftStick/up", offset = 2, format = "SHRT")]
	[InputControl(name = "leftStick/y", offset = 2, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "leftStick/right", offset = 0, format = "SHRT")]
	[InputControl(name = "leftStick/left", offset = 0, format = "SHRT")]
	[InputControl(name = "leftStick/x", offset = 0, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2S")]
	public short leftStickX; // 0x4
	public short leftStickY; // 0x6
	[InputControl(name = "rightStick/x", offset = 0, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "rightStick/left", offset = 0, format = "SHRT")]
	[InputControl(name = "rightStick/right", offset = 0, format = "SHRT")]
	[InputControl(name = "rightStick/y", offset = 2, format = "SHRT", parameters = "clamp=false,invert=false,normalize=false")]
	[InputControl(name = "rightStick/down", offset = 2, format = "SHRT")]
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2S")]
	[InputControl(name = "rightStick/up", offset = 2, format = "SHRT")]
	public short rightStickX; // 0x8
	public short rightStickY; // 0xA

	// Properties
	public FourCC format { get; }

	// Methods

	// RVA: 0x283AFF0 Offset: 0x28399F0 VA: 0x18283AFF0 Slot: 4
	public FourCC get_format() { }

	// RVA: 0x283AFC0 Offset: 0x28399C0 VA: 0x18283AFC0
	public XInputControllerWindowsState WithButton(XInputControllerWindowsState.Button button) { }
}
