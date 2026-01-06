public struct InputEvent // TypeDefIndex: 7672
{
	// Fields
	private const uint kHandledMask = 2147483648;
	private const uint kIdMask = 2147483647;
	internal const int kBaseEventSize = 20;
	public const int InvalidEventId = 0;
	internal const int kAlignment = 4;
	private NativeInputEvent m_Event; // 0x0

	// Properties
	public FourCC type { get; set; }
	public uint sizeInBytes { get; set; }
	public int eventId { get; set; }
	public int deviceId { get; set; }
	public double time { get; set; }
	internal double internalTime { get; set; }
	public bool handled { get; set; }

	// Methods

	// RVA: 0x4C2CC0 Offset: 0x4C16C0 VA: 0x1804C2CC0
	public FourCC get_type() { }

	// RVA: 0x5276C0 Offset: 0x5260C0 VA: 0x1805276C0
	public void set_type(FourCC value) { }

	// RVA: 0x18CCEC0 Offset: 0x18CB8C0 VA: 0x1818CCEC0
	public uint get_sizeInBytes() { }

	// RVA: 0x2864A60 Offset: 0x2863460 VA: 0x182864A60
	public void set_sizeInBytes(uint value) { }

	// RVA: 0x28649C0 Offset: 0x28633C0 VA: 0x1828649C0
	public int get_eventId() { }

	// RVA: 0x2864A30 Offset: 0x2863430 VA: 0x182864A30
	public void set_eventId(int value) { }

	// RVA: 0x28649B0 Offset: 0x28633B0 VA: 0x1828649B0
	public int get_deviceId() { }

	// RVA: 0x2864A20 Offset: 0x2863420 VA: 0x182864A20
	public void set_deviceId(int value) { }

	// RVA: 0x28649D0 Offset: 0x28633D0 VA: 0x1828649D0
	public double get_time() { }

	// RVA: 0x2864B10 Offset: 0x2863510 VA: 0x182864B10
	public void set_time(double value) { }

	// RVA: 0x109F850 Offset: 0x109E250 VA: 0x18109F850
	internal double get_internalTime() { }

	// RVA: 0x27763E0 Offset: 0x2774DE0 VA: 0x1827763E0
	internal void set_internalTime(double value) { }

	// RVA: 0x28648F0 Offset: 0x28632F0 VA: 0x1828648F0
	public void .ctor(FourCC type, int sizeInBytes, int deviceId, double time = -1) { }

	// RVA: 0x285DAF0 Offset: 0x285C4F0 VA: 0x18285DAF0
	public bool get_handled() { }

	// RVA: 0x2864A40 Offset: 0x2863440 VA: 0x182864A40
	public void set_handled(bool value) { }

	// RVA: 0x2864620 Offset: 0x2863020 VA: 0x182864620 Slot: 3
	public override string ToString() { }

	// RVA: 0x2864600 Offset: 0x2863000 VA: 0x182864600
	internal static InputEvent* GetNextInMemory(InputEvent* currentPtr) { }

	// RVA: 0x28644A0 Offset: 0x2862EA0 VA: 0x1828644A0
	internal static InputEvent* GetNextInMemoryChecked(InputEvent* currentPtr, ref InputEventBuffer buffer) { }

	// RVA: 0x2864450 Offset: 0x2862E50 VA: 0x182864450
	public static bool Equals(InputEvent* first, InputEvent* second) { }
}
