public struct GetCurrentHapticStateCommand : IInputDeviceCommandInfo // TypeDefIndex: 7480
{
	// Fields
	private const int kSize = 16;
	private InputDeviceCommand baseCommand; // 0x0
	public uint samplesQueued; // 0x8
	public uint samplesAvailable; // 0xC

	// Properties
	private static FourCC Type { get; }
	public FourCC typeStatic { get; }
	public HapticState currentState { get; }

	// Methods

	// RVA: 0x281FF30 Offset: 0x281E930 VA: 0x18281FF30
	private static FourCC get_Type() { }

	// RVA: 0x281FF70 Offset: 0x281E970 VA: 0x18281FF70 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x214D4E0 Offset: 0x214BEE0 VA: 0x18214D4E0
	public HapticState get_currentState() { }

	// RVA: 0x281FEB0 Offset: 0x281E8B0 VA: 0x18281FEB0
	public static GetCurrentHapticStateCommand Create() { }
}
