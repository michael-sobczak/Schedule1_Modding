internal struct TouchscreenState : IInputStateTypeInfo // TypeDefIndex: 7659
{
	// Fields
	public const int MaxTouches = 10;
	[InputControl(name = "press", useStateFrom = "primaryTouch/phase", layout = "TouchPress", synthetic = True, usages = new[] {  })]
	[InputControl(name = "displayIndex", useStateFrom = "primaryTouch/displayIndex", format = "BYTE")]
	[InputControl(name = "radius", useStateFrom = "primaryTouch/radius")]
	[FixedBuffer(typeof(byte), 56)]
	[InputControl(name = "primaryTouch", displayName = "Primary Touch", layout = "Touch", synthetic = True)]
	[InputControl(name = "primaryTouch/tap", usage = "PrimaryAction")]
	[InputControl(name = "delta", useStateFrom = "primaryTouch/delta", layout = "Delta")]
	[InputControl(name = "position", useStateFrom = "primaryTouch/position")]
	[InputControl(name = "pressure", useStateFrom = "primaryTouch/pressure")]
	public TouchscreenState.<primaryTouchData>e__FixedBuffer primaryTouchData; // 0x0
	internal const int kTouchDataOffset = 56;
	[FixedBuffer(typeof(byte), 560)]
	[InputControl(layout = "Touch", name = "touch", displayName = "Touch", arraySize = 10)]
	public TouchscreenState.<touchData>e__FixedBuffer touchData; // 0x38

	// Properties
	public static FourCC Format { get; }
	public TouchState* primaryTouch { get; }
	public TouchState* touches { get; }
	public FourCC format { get; }

	// Methods

	// RVA: 0x2869F70 Offset: 0x2868970 VA: 0x182869F70
	public static FourCC get_Format() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public TouchState* get_primaryTouch() { }

	// RVA: 0x2869FF0 Offset: 0x28689F0 VA: 0x182869FF0
	public TouchState* get_touches() { }

	// RVA: 0x2869FB0 Offset: 0x28689B0 VA: 0x182869FB0 Slot: 4
	public FourCC get_format() { }
}
