public struct InputEventPtr : IEquatable<InputEventPtr> // TypeDefIndex: 7678
{
	// Fields
	private readonly InputEvent* m_EventPtr; // 0x0

	// Properties
	public bool valid { get; }
	public bool handled { get; set; }
	public int id { get; set; }
	public FourCC type { get; }
	public uint sizeInBytes { get; }
	public int deviceId { get; set; }
	public double time { get; set; }
	internal double internalTime { get; set; }
	public InputEvent* data { get; }
	internal FourCC stateFormat { get; }
	internal uint stateSizeInBytes { get; }
	internal uint stateOffset { get; }

	// Methods

	// RVA: 0xC7C0C0 Offset: 0xC7AAC0 VA: 0x180C7C0C0
	public void .ctor(InputEvent* eventPtr) { }

	// RVA: 0x10676B0 Offset: 0x10660B0 VA: 0x1810676B0
	public bool get_valid() { }

	// RVA: 0x2861040 Offset: 0x285FA40 VA: 0x182861040
	public bool get_handled() { }

	// RVA: 0x2861440 Offset: 0x285FE40 VA: 0x182861440
	public void set_handled(bool value) { }

	// RVA: 0x2861060 Offset: 0x285FA60 VA: 0x182861060
	public int get_id() { }

	// RVA: 0x28614C0 Offset: 0x285FEC0 VA: 0x1828614C0
	public void set_id(int value) { }

	// RVA: 0x28613C0 Offset: 0x285FDC0 VA: 0x1828613C0
	public FourCC get_type() { }

	// RVA: 0x28610A0 Offset: 0x285FAA0 VA: 0x1828610A0
	public uint get_sizeInBytes() { }

	// RVA: 0x2861020 Offset: 0x285FA20 VA: 0x182861020
	public int get_deviceId() { }

	// RVA: 0x28613D0 Offset: 0x285FDD0 VA: 0x1828613D0
	public void set_deviceId(int value) { }

	// RVA: 0x2861360 Offset: 0x285FD60 VA: 0x182861360
	public double get_time() { }

	// RVA: 0x28615B0 Offset: 0x285FFB0 VA: 0x1828615B0
	public void set_time(double value) { }

	// RVA: 0x2861080 Offset: 0x285FA80 VA: 0x182861080
	internal double get_internalTime() { }

	// RVA: 0x2861540 Offset: 0x285FF40 VA: 0x182861540
	internal void set_internalTime(double value) { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public InputEvent* get_data() { }

	// RVA: 0x28610C0 Offset: 0x285FAC0 VA: 0x1828610C0
	internal FourCC get_stateFormat() { }

	// RVA: 0x2861260 Offset: 0x285FC60 VA: 0x182861260
	internal uint get_stateSizeInBytes() { }

	// RVA: 0x2861190 Offset: 0x285FB90 VA: 0x182861190
	internal uint get_stateOffset() { }

	// RVA: -1 Offset: -1
	public bool IsA<TOtherEvent>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEDED10 Offset: 0xEDD710 VA: 0x180EDED10
	|-InputEventPtr.IsA<ActionEvent>
	|
	|-RVA: 0xEDED90 Offset: 0xEDD790 VA: 0x180EDED90
	|-InputEventPtr.IsA<DeltaStateEvent>
	|
	|-RVA: 0xEDEF40 Offset: 0xEDD940 VA: 0x180EDEF40
	|-InputEventPtr.IsA<StateEvent>
	|
	|-RVA: 0xEDEFC0 Offset: 0xEDD9C0 VA: 0x180EDEFC0
	|-InputEventPtr.IsA<TextEvent>
	|
	|-RVA: 0xEDEE10 Offset: 0xEDD810 VA: 0x180EDEE10
	|-InputEventPtr.IsA<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2860FA0 Offset: 0x285F9A0 VA: 0x182860FA0
	public InputEventPtr Next() { }

	// RVA: 0x2860FC0 Offset: 0x285F9C0 VA: 0x182860FC0 Slot: 3
	public override string ToString() { }

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public InputEvent* ToPointer() { }

	// RVA: 0x2860F50 Offset: 0x285F950 VA: 0x182860F50 Slot: 4
	public bool Equals(InputEventPtr other) { }

	// RVA: 0x2860E90 Offset: 0x285F890 VA: 0x182860E90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0xC7C1F0 Offset: 0xC7ABF0 VA: 0x180C7C1F0
	public static bool op_Equality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0xC7C200 Offset: 0xC7AC00 VA: 0x180C7C200
	public static bool op_Inequality(InputEventPtr left, InputEventPtr right) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static InputEventPtr op_Implicit(InputEvent* eventPtr) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static InputEventPtr From(InputEvent* eventPtr) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static InputEvent* op_Implicit(InputEventPtr eventPtr) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public static InputEvent* FromInputEventPtr(InputEventPtr eventPtr) { }
}
