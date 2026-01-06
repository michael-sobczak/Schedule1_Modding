public struct StateEvent : IInputEventTypeInfo // TypeDefIndex: 7688
{
	// Fields
	public const int Type = 1398030676;
	internal const int kStateDataSizeToSubtract = 1;
	public InputEvent baseEvent; // 0x0
	public FourCC stateFormat; // 0x14
	[FixedBuffer(typeof(byte), 1)]
	internal StateEvent.<stateData>e__FixedBuffer stateData; // 0x18

	// Properties
	public uint stateSizeInBytes { get; }
	public void* state { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2880110 Offset: 0x287EB10 VA: 0x182880110
	public uint get_stateSizeInBytes() { }

	// RVA: 0x2880130 Offset: 0x287EB30 VA: 0x182880130
	public void* get_state() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x2880140 Offset: 0x287EB40 VA: 0x182880140 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: -1 Offset: -1
	public TState GetState<TState>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF525D0 Offset: 0xF50FD0 VA: 0x180F525D0
	|-StateEvent.GetState<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static TState GetState<TState>(InputEventPtr ptr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF528B0 Offset: 0xF512B0 VA: 0x180F528B0
	|-StateEvent.GetState<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: -1 Offset: -1
	public static int GetEventSizeWithPayload<TState>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF525B0 Offset: 0xF50FB0 VA: 0x180F525B0
	|-StateEvent.GetEventSizeWithPayload<TouchState>
	|
	|-RVA: 0xF52580 Offset: 0xF50F80 VA: 0x180F52580
	|-StateEvent.GetEventSizeWithPayload<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x287FFD0 Offset: 0x287E9D0 VA: 0x18287FFD0
	public static StateEvent* From(InputEventPtr ptr) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	internal static StateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x287FFA0 Offset: 0x287E9A0 VA: 0x18287FFA0
	public static NativeArray<byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = 2) { }

	// RVA: 0x287FC50 Offset: 0x287E650 VA: 0x18287FC50
	public static NativeArray<byte> FromDefaultStateFor(InputDevice device, out InputEventPtr eventPtr, Allocator allocator = 2) { }

	// RVA: 0x287FC80 Offset: 0x287E680 VA: 0x18287FC80
	private static NativeArray<byte> From(InputDevice device, out InputEventPtr eventPtr, Allocator allocator, bool useDefaultState) { }
}
