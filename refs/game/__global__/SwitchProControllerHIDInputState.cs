internal struct SwitchProControllerHIDInputState : IInputStateTypeInfo // TypeDefIndex: 7540
{
	// Fields
	public static FourCC Format; // 0x0
	[InputControl(name = "leftStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85,invert=false")]
	[InputControl(name = "leftStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "leftStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
	[InputControl(name = "leftStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
	[InputControl(name = "leftStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85")]
	[InputControl(name = "leftStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
	public byte leftStickX; // 0x0
	public byte leftStickY; // 0x1
	[InputControl(name = "rightStick/y", offset = 1, format = "BYTE", parameters = "invert,normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
	[InputControl(name = "rightStick/right", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=1")]
	[InputControl(name = "rightStick/left", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/x", offset = 0, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5")]
	[InputControl(name = "rightStick", layout = "Stick", format = "VC2B")]
	[InputControl(name = "rightStick/up", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.15,clampMax=0.5,invert")]
	[InputControl(name = "rightStick/down", offset = 1, format = "BYTE", parameters = "normalize,normalizeMin=0.15,normalizeMax=0.85,normalizeZero=0.5,clamp=1,clampMin=0.5,clampMax=0.85,invert=false")]
	public byte rightStickX; // 0x2
	public byte rightStickY; // 0x3
	[InputControl(name = "dpad/down", bit = 2)]
	[InputControl(name = "buttonSouth", displayName = "B", shortDisplayName = "B", bit = 6, usages = new[] { "Back", "Cancel" })]
	[InputControl(name = "rightStickPress", displayName = "Right Stick", bit = 11)]
	[InputControl(name = "leftShoulder", displayName = "L", shortDisplayName = "L", bit = 8)]
	[InputControl(name = "leftTrigger", displayName = "ZL", shortDisplayName = "ZL", format = "BIT", bit = 12)]
	[InputControl(name = "buttonEast", displayName = "A", shortDisplayName = "A", bit = 7, usages = new[] { "PrimaryAction", "Submit" })]
	[InputControl(name = "leftStickPress", displayName = "Left Stick", bit = 10)]
	[InputControl(name = "rightTrigger", displayName = "ZR", shortDisplayName = "ZR", format = "BIT", bit = 13)]
	[InputControl(name = "start", displayName = "Plus", bit = 14, usage = "Menu")]
	[InputControl(name = "select", displayName = "Minus", bit = 15)]
	[InputControl(name = "rightShoulder", displayName = "R", shortDisplayName = "R", bit = 9)]
	[InputControl(name = "buttonNorth", displayName = "X", shortDisplayName = "X", bit = 5)]
	[InputControl(name = "buttonWest", displayName = "Y", shortDisplayName = "Y", bit = 4, usage = "SecondaryAction")]
	[InputControl(name = "dpad/left", bit = 3)]
	[InputControl(name = "dpad/right", bit = 1)]
	[InputControl(name = "dpad/up", bit = 0)]
	[InputControl(name = "dpad", format = "BIT", bit = 0, sizeInBits = 4)]
	public ushort buttons1; // 0x4
	[InputControl(name = "capture", layout = "Button", displayName = "Capture", bit = 0)]
	[InputControl(name = "home", layout = "Button", displayName = "Home", bit = 1)]
	public byte buttons2; // 0x6

	// Properties
	public FourCC format { get; }

	// Methods

	// RVA: 0x284F0B0 Offset: 0x284DAB0 VA: 0x18284F0B0 Slot: 4
	public FourCC get_format() { }

	// RVA: 0x284EF60 Offset: 0x284D960 VA: 0x18284EF60
	public SwitchProControllerHIDInputState WithButton(SwitchProControllerHIDInputState.Button button, bool value = True) { }

	// RVA: 0x284EEF0 Offset: 0x284D8F0 VA: 0x18284EEF0
	public void Set(SwitchProControllerHIDInputState.Button button, bool state) { }

	// RVA: 0x284EDF0 Offset: 0x284D7F0 VA: 0x18284EDF0
	public void Press(SwitchProControllerHIDInputState.Button button) { }

	// RVA: 0x284EE70 Offset: 0x284D870 VA: 0x18284EE70
	public void Release(SwitchProControllerHIDInputState.Button button) { }

	// RVA: 0x284F040 Offset: 0x284DA40 VA: 0x18284F040
	private static void .cctor() { }
}
