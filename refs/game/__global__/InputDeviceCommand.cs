public struct InputDeviceCommand : IInputDeviceCommandInfo // TypeDefIndex: 7614
{
	// Fields
	internal const int kBaseCommandSize = 8;
	public const int BaseCommandSize = 8;
	public const long GenericFailure = -1;
	public const long GenericSuccess = 1;
	public FourCC type; // 0x0
	public int sizeInBytes; // 0x4

	// Properties
	public int payloadSizeInBytes { get; }
	public void* payloadPtr { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x285FE20 Offset: 0x285E820 VA: 0x18285FE20
	public int get_payloadSizeInBytes() { }

	// RVA: 0x285FE10 Offset: 0x285E810 VA: 0x18285FE10
	public void* get_payloadPtr() { }

	// RVA: 0x541AB0 Offset: 0x5404B0 VA: 0x180541AB0
	public void .ctor(FourCC type, int sizeInBytes = 8) { }

	// RVA: 0x285FD60 Offset: 0x285E760 VA: 0x18285FD60
	public static NativeArray<byte> AllocateNative(FourCC type, int payloadSize) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 4
	public FourCC get_typeStatic() { }
}
