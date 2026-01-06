internal struct InputEventStream // TypeDefIndex: 7679
{
	// Fields
	private InputEventBuffer m_NativeBuffer; // 0x0
	private InputEvent* m_CurrentNativeEventReadPtr; // 0x20
	private InputEvent* m_CurrentNativeEventWritePtr; // 0x28
	private int m_RemainingNativeEventCount; // 0x30
	private readonly int m_MaxAppendedEvents; // 0x34
	private InputEventBuffer m_AppendBuffer; // 0x38
	private InputEvent* m_CurrentAppendEventReadPtr; // 0x58
	private InputEvent* m_CurrentAppendEventWritePtr; // 0x60
	private int m_RemainingAppendEventCount; // 0x68
	private int m_NumEventsRetainedInBuffer; // 0x6C
	private bool m_IsOpen; // 0x70

	// Properties
	public bool isOpen { get; }
	public int remainingEventCount { get; }
	public int numEventsRetainedInBuffer { get; }
	public InputEvent* currentEventPtr { get; }
	public uint numBytesRetainedInBuffer { get; }

	// Methods

	// RVA: 0x83DB90 Offset: 0x83C590 VA: 0x18083DB90
	public bool get_isOpen() { }

	// RVA: 0x2861CB0 Offset: 0x28606B0 VA: 0x182861CB0
	public int get_remainingEventCount() { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	public int get_numEventsRetainedInBuffer() { }

	// RVA: 0x2861C30 Offset: 0x2860630 VA: 0x182861C30
	public InputEvent* get_currentEventPtr() { }

	// RVA: 0x2861C50 Offset: 0x2860650 VA: 0x182861C50
	public uint get_numBytesRetainedInBuffer() { }

	// RVA: 0x2861B90 Offset: 0x2860590 VA: 0x182861B90
	public void .ctor(ref InputEventBuffer eventBuffer, int maxAppendedEvents) { }

	// RVA: 0x2861790 Offset: 0x2860190 VA: 0x182861790
	public void Close(ref InputEventBuffer eventBuffer) { }

	// RVA: 0x28616F0 Offset: 0x28600F0 VA: 0x1828616F0
	public void CleanUpAfterException() { }

	// RVA: 0x2861940 Offset: 0x2860340 VA: 0x182861940
	public void Write(InputEvent* eventPtr) { }

	// RVA: 0x2861650 Offset: 0x2860050 VA: 0x182861650
	public InputEvent* Advance(bool leaveEventInBuffer) { }

	// RVA: 0x2861900 Offset: 0x2860300 VA: 0x182861900
	public InputEvent* Peek() { }
}
