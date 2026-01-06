public struct InitiateUserAccountPairingCommand : IInputDeviceCommandInfo // TypeDefIndex: 7611
{
	// Fields
	internal const int kSize = 8;
	public InputDeviceCommand baseCommand; // 0x0

	// Properties
	public static FourCC Type { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x285FBB0 Offset: 0x285E5B0 VA: 0x18285FBB0
	public static FourCC get_Type() { }

	// RVA: 0x285FBF0 Offset: 0x285E5F0 VA: 0x18285FBF0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x285FB60 Offset: 0x285E560 VA: 0x18285FB60
	public static InitiateUserAccountPairingCommand Create() { }
}
