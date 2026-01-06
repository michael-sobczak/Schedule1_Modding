public struct PenState : IInputStateTypeInfo // TypeDefIndex: 7648
{
	// Fields
	[InputControl(usage = "Point", dontReset = True)]
	public Vector2 position; // 0x0
	[InputControl(usage = "Secondary2DMotion", layout = "Delta")]
	public Vector2 delta; // 0x8
	[InputControl(layout = "Vector2", displayName = "Tilt", usage = "Tilt")]
	public Vector2 tilt; // 0x10
	[InputControl(layout = "Analog", usage = "Pressure", defaultState = 0)]
	public float pressure; // 0x18
	[InputControl(layout = "Axis", displayName = "Twist", usage = "Twist")]
	public float twist; // 0x1C
	[InputControl(name = "press", useStateFrom = "tip", synthetic = True, usages = new[] {  })]
	[InputControl(name = "barrel3", displayName = "Barrel Button #3", layout = "Button", bit = 5, alias = "barrelThird")]
	[InputControl(name = "barrel4", displayName = "Barrel Button #4", layout = "Button", bit = 6, alias = "barrelFourth")]
	[InputControl(name = "radius", layout = "Vector2", format = "VEC2", sizeInBits = 64, usage = "Radius", offset = 4294967294)]
	[InputControl(name = "pointerId", layout = "Digital", format = "UINT", sizeInBits = 32, offset = 4294967294)]
	[InputControl(name = "tip", displayName = "Tip", layout = "Button", bit = 0, usage = "PrimaryAction")]
	[InputControl(name = "barrel2", displayName = "Barrel Button #2", layout = "Button", bit = 3, alias = "barrelSecond")]
	[InputControl(name = "barrel1", displayName = "Barrel Button #1", layout = "Button", bit = 2, alias = "barrelFirst", usage = "SecondaryAction")]
	[InputControl(name = "inRange", displayName = "In Range?", layout = "Button", bit = 4, synthetic = True)]
	[InputControl(name = "eraser", displayName = "Eraser", layout = "Button", bit = 1)]
	public ushort buttons; // 0x20
	[InputControl(name = "displayIndex", displayName = "Display Index", layout = "Integer")]
	private ushort displayIndex; // 0x22

	// Properties
	public static FourCC Format { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2865190 Offset: 0x2863B90 VA: 0x182865190
	public static FourCC get_Format() { }

	// RVA: 0x2865140 Offset: 0x2863B40 VA: 0x182865140
	public PenState WithButton(PenButton button, bool state = True) { }

	// RVA: 0x28651D0 Offset: 0x2863BD0 VA: 0x1828651D0 Slot: 4
	public FourCC get_format() { }
}
