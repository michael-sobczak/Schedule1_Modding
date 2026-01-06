internal struct DualShock3HIDInputReport : IInputStateTypeInfo // TypeDefIndex: 7597
{
	// Fields
	private ushort padding1; // 0x0
	[InputControl(name = "dpad/left", bit = 7)]
	[InputControl(name = "select", displayName = "Share", bit = 0)]
	[InputControl(name = "leftStickPress", bit = 1)]
	[InputControl(name = "rightStickPress", bit = 2)]
	[InputControl(name = "start", displayName = "Options", bit = 3)]
	[InputControl(name = "dpad", format = "BIT", layout = "Dpad", bit = 4, sizeInBits = 4)]
	[InputControl(name = "dpad/up", bit = 4)]
	[InputControl(name = "dpad/right", bit = 5)]
	[InputControl(name = "dpad/down", bit = 6)]
	public byte buttons1; // 0x2
	[InputControl(name = "rightShoulder", bit = 3)]
	[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 4)]
	[InputControl(name = "buttonEast", displayName = "Circle", bit = 5)]
	[InputControl(name = "leftTriggerButton", layout = "Button", bit = 0, synthetic = True)]
	[InputControl(name = "leftShoulder", bit = 2)]
	[InputControl(name = "rightTriggerButton", layout = "Button", bit = 1, synthetic = True)]
	[InputControl(name = "buttonWest", displayName = "Square", bit = 7)]
	[InputControl(name = "buttonSouth", displayName = "Cross", bit = 6)]
	public byte buttons2; // 0x3
	[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1)]
	[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0)]
	public byte buttons3; // 0x4
	private byte padding2; // 0x5
	[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
	[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	public byte leftStickX; // 0x6
	public byte leftStickY; // 0x7
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
	[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	public byte rightStickX; // 0x8
	public byte rightStickY; // 0x9
	[FixedBuffer(typeof(byte), 8)]
	private DualShock3HIDInputReport.<padding3>e__FixedBuffer padding3; // 0xA
	[InputControl(name = "leftTrigger", format = "BYTE")]
	public byte leftTrigger; // 0x12
	[InputControl(name = "rightTrigger", format = "BYTE")]
	public byte rightTrigger; // 0x13

	// Properties
	public FourCC format { get; }

	// Methods

	// RVA: 0x28562B0 Offset: 0x2854CB0 VA: 0x1828562B0 Slot: 4
	public FourCC get_format() { }
}
