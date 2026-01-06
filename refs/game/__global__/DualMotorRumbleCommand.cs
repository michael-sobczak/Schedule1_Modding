internal struct DualMotorRumbleCommand : IInputDeviceCommandInfo // TypeDefIndex: 7636
{
	// Fields
	internal const int kSize = 16;
	public InputDeviceCommand baseCommand; // 0x0
	public float lowFrequencyMotorSpeed; // 0x8
	public float highFrequencyMotorSpeed; // 0xC

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2854980 Offset: 0x2853380 VA: 0x182854980
	public static FourCC get_Type() { }

	// RVA: 0x28549C0 Offset: 0x28533C0 VA: 0x1828549C0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x28548F0 Offset: 0x28532F0 VA: 0x1828548F0
	public static DualMotorRumbleCommand Create(float lowFrequency, float highFrequency) { }
}
