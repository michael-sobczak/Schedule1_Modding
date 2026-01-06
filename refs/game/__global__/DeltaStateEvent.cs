public struct DeltaStateEvent : IInputEventTypeInfo // TypeDefIndex: 7663
{
	// Fields
	public const int Type = 1145852993;
	public InputEvent baseEvent; // 0x0
	public FourCC stateFormat; // 0x14
	public uint stateOffset; // 0x18
	[FixedBuffer(typeof(byte), 1)]
	internal DeltaStateEvent.<stateData>e__FixedBuffer stateData; // 0x1C

	// Properties
	public uint deltaStateSizeInBytes { get; }
	public void* deltaState { get; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2854420 Offset: 0x2852E20 VA: 0x182854420
	public uint get_deltaStateSizeInBytes() { }

	// RVA: 0x2854430 Offset: 0x2852E30 VA: 0x182854430
	public void* get_deltaState() { }

	// RVA: 0x2854440 Offset: 0x2852E40 VA: 0x182854440 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x28542F0 Offset: 0x2852CF0 VA: 0x1828542F0
	public static DeltaStateEvent* From(InputEventPtr ptr) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	internal static DeltaStateEvent* FromUnchecked(InputEventPtr ptr) { }

	// RVA: 0x2853FA0 Offset: 0x28529A0 VA: 0x182853FA0
	public static NativeArray<byte> From(InputControl control, out InputEventPtr eventPtr, Allocator allocator = 2) { }
}
