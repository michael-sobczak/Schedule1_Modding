public struct SendHapticImpulseCommand : IInputDeviceCommandInfo // TypeDefIndex: 7485
{
	// Fields
	private const int kSize = 20;
	private InputDeviceCommand baseCommand; // 0x0
	private int channel; // 0x8
	private float amplitude; // 0xC
	private float duration; // 0x10

	// Properties
	private static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2834C20 Offset: 0x2833620 VA: 0x182834C20
	private static FourCC get_Type() { }

	// RVA: 0x2834C60 Offset: 0x2833660 VA: 0x182834C60 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2834B70 Offset: 0x2833570 VA: 0x182834B70
	public static SendHapticImpulseCommand Create(int motorChannel, float motorAmplitude, float motorDuration) { }
}
