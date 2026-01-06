public struct DualSenseHIDInputReport : IInputStateTypeInfo // TypeDefIndex: 7590
{
	// Fields
	public static FourCC Format; // 0x0
	[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
	public byte leftStickX; // 0x0
	public byte leftStickY; // 0x1
	[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1,invert=false")]
	[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0,normalizeMax=1,normalizeZero=0.5")]
	public byte rightStickX; // 0x2
	public byte rightStickY; // 0x3
	[InputControl(name = "leftTrigger", format = "BYTE")]
	public byte leftTrigger; // 0x4
	[InputControl(name = "rightTrigger", format = "BYTE")]
	public byte rightTrigger; // 0x5
	[InputControl(name = "dpad/up", format = "BIT", layout = "DiscreteButton", parameters = "minValue=7,maxValue=1,nullValue=8,wrapAtValue=7", bit = 0, sizeInBits = 4)]
	[InputControl(name = "buttonNorth", displayName = "Triangle", bit = 7)]
	[InputControl(name = "buttonEast", displayName = "Circle", bit = 6)]
	[InputControl(name = "buttonSouth", displayName = "Cross", bit = 5)]
	[InputControl(name = "buttonWest", displayName = "Square", bit = 4)]
	[InputControl(name = "dpad", format = "BIT", layout = "Dpad", sizeInBits = 4, defaultState = 8)]
	[InputControl(name = "dpad/left", format = "BIT", layout = "DiscreteButton", parameters = "minValue=5, maxValue=7", bit = 0, sizeInBits = 4)]
	[InputControl(name = "dpad/down", format = "BIT", layout = "DiscreteButton", parameters = "minValue=3,maxValue=5", bit = 0, sizeInBits = 4)]
	[InputControl(name = "dpad/right", format = "BIT", layout = "DiscreteButton", parameters = "minValue=1,maxValue=3", bit = 0, sizeInBits = 4)]
	public byte buttons0; // 0x6
	[InputControl(name = "start", displayName = "Options", bit = 5)]
	[InputControl(name = "leftStickPress", bit = 6)]
	[InputControl(name = "rightStickPress", bit = 7)]
	[InputControl(name = "leftTriggerButton", layout = "Button", bit = 2)]
	[InputControl(name = "rightShoulder", bit = 1)]
	[InputControl(name = "leftShoulder", bit = 0)]
	[InputControl(name = "rightTriggerButton", layout = "Button", bit = 3)]
	[InputControl(name = "select", displayName = "Share", bit = 4)]
	public byte buttons1; // 0x7
	[InputControl(name = "systemButton", layout = "Button", displayName = "System", bit = 0)]
	[InputControl(name = "touchpadButton", layout = "Button", displayName = "Touchpad Press", bit = 1)]
	[InputControl(name = "micButton", layout = "Button", displayName = "Mic Mute", bit = 2)]
	public byte buttons2; // 0x8

	// Properties
	public FourCC format { get; }

	// Methods

	// RVA: 0x2855FD0 Offset: 0x28549D0 VA: 0x182855FD0 Slot: 4
	public FourCC get_format() { }

	// RVA: 0x2855F60 Offset: 0x2854960 VA: 0x182855F60
	private static void .cctor() { }
}
