public struct GetHapticCapabilitiesCommand : IInputDeviceCommandInfo // TypeDefIndex: 7482
{
	// Fields
	private const int kSize = 28;
	private InputDeviceCommand baseCommand; // 0x0
	public uint numChannels; // 0x8
	public bool supportsImpulse; // 0xC
	public bool supportsBuffer; // 0xD
	public uint frequencyHz; // 0x10
	public uint maxBufferSize; // 0x14
	public uint optimalBufferSize; // 0x18

	// Properties
	private static FourCC Type { get; }
	public FourCC typeStatic { get; }
	public HapticCapabilities capabilities { get; }

	// Methods

	// RVA: 0x2820030 Offset: 0x281EA30 VA: 0x182820030
	private static FourCC get_Type() { }

	// RVA: 0x28200A0 Offset: 0x281EAA0 VA: 0x1828200A0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2820070 Offset: 0x281EA70 VA: 0x182820070
	public HapticCapabilities get_capabilities() { }

	// RVA: 0x281FFB0 Offset: 0x281E9B0 VA: 0x18281FFB0
	public static GetHapticCapabilitiesCommand Create() { }
}
