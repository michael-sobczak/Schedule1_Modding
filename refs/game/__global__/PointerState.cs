internal struct PointerState : IInputStateTypeInfo // TypeDefIndex: 7649
{
	// Fields
	private uint pointerId; // 0x0
	[InputControl(layout = "Vector2", displayName = "Position", usage = "Point", dontReset = True)]
	public Vector2 position; // 0x4
	[InputControl(layout = "Delta", displayName = "Delta", usage = "Secondary2DMotion")]
	public Vector2 delta; // 0xC
	[InputControl(layout = "Analog", displayName = "Pressure", usage = "Pressure", defaultState = 1)]
	public float pressure; // 0x14
	[InputControl(layout = "Vector2", displayName = "Radius", usage = "Radius")]
	public Vector2 radius; // 0x18
	[InputControl(name = "press", displayName = "Press", layout = "Button", format = "BIT", bit = 0)]
	public ushort buttons; // 0x20
	[InputControl(name = "displayIndex", layout = "Integer", displayName = "Display Index")]
	public ushort displayIndex; // 0x22

	// Properties
	public static FourCC kFormat { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2865250 Offset: 0x2863C50 VA: 0x182865250
	public static FourCC get_kFormat() { }

	// RVA: 0x2865210 Offset: 0x2863C10 VA: 0x182865210 Slot: 4
	public FourCC get_format() { }
}
