internal struct ActionEvent : IInputEventTypeInfo // TypeDefIndex: 7661
{
	// Fields
	public InputEvent baseEvent; // 0x0
	private ushort m_ControlIndex; // 0x14
	private ushort m_BindingIndex; // 0x16
	private ushort m_InteractionIndex; // 0x18
	private byte m_StateIndex; // 0x1A
	private byte m_Phase; // 0x1B
	private double m_StartTime; // 0x1C
	[FixedBuffer(typeof(byte), 1)]
	public ActionEvent.<m_ValueData>e__FixedBuffer m_ValueData; // 0x24

	// Properties
	public static FourCC Type { get; }
	public double startTime { get; set; }
	public InputActionPhase phase { get; set; }
	public byte* valueData { get; }
	public int valueSizeInBytes { get; }
	public int stateIndex { get; set; }
	public int controlIndex { get; set; }
	public int bindingIndex { get; set; }
	public int interactionIndex { get; set; }
	public FourCC typeStatic { get; }

	// Methods

	// RVA: 0x2853C50 Offset: 0x2852650 VA: 0x182853C50
	public static FourCC get_Type() { }

	// RVA: 0x27A6B60 Offset: 0x27A5560 VA: 0x1827A6B60
	public double get_startTime() { }

	// RVA: 0x2853EA0 Offset: 0x28528A0 VA: 0x182853EA0
	public void set_startTime(double value) { }

	// RVA: 0x2853CC0 Offset: 0x28526C0 VA: 0x182853CC0
	public InputActionPhase get_phase() { }

	// RVA: 0x2853E90 Offset: 0x2852890 VA: 0x182853E90
	public void set_phase(InputActionPhase value) { }

	// RVA: 0x2853D10 Offset: 0x2852710 VA: 0x182853D10
	public byte* get_valueData() { }

	// RVA: 0x2853D20 Offset: 0x2852720 VA: 0x182853D20
	public int get_valueSizeInBytes() { }

	// RVA: 0x1DFCED0 Offset: 0x1DFB8D0 VA: 0x181DFCED0
	public int get_stateIndex() { }

	// RVA: 0x2853EB0 Offset: 0x28528B0 VA: 0x182853EB0
	public void set_stateIndex(int value) { }

	// RVA: 0xFF2530 Offset: 0xFF0F30 VA: 0x180FF2530
	public int get_controlIndex() { }

	// RVA: 0x2853DA0 Offset: 0x28527A0 VA: 0x182853DA0
	public void set_controlIndex(int value) { }

	// RVA: 0x2853C90 Offset: 0x2852690 VA: 0x182853C90
	public int get_bindingIndex() { }

	// RVA: 0x2853D30 Offset: 0x2852730 VA: 0x182853D30
	public void set_bindingIndex(int value) { }

	// RVA: 0x2853CA0 Offset: 0x28526A0 VA: 0x182853CA0
	public int get_interactionIndex() { }

	// RVA: 0x2853E10 Offset: 0x2852810 VA: 0x182853E10
	public void set_interactionIndex(int value) { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public InputEventPtr ToEventPtr() { }

	// RVA: 0x2853CD0 Offset: 0x28526D0 VA: 0x182853CD0 Slot: 4
	public FourCC get_typeStatic() { }

	// RVA: 0x2853C40 Offset: 0x2852640 VA: 0x182853C40
	public static int GetEventSizeWithValueSize(int valueSizeInBytes) { }

	// RVA: 0x2853B10 Offset: 0x2852510 VA: 0x182853B10
	public static ActionEvent* From(InputEventPtr ptr) { }
}
