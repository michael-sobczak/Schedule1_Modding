public struct InputEventBuffer : IEnumerable<InputEventPtr>, IEnumerable, IDisposable, ICloneable // TypeDefIndex: 7674
{
	// Fields
	public const long BufferSizeUnknown = -1;
	private NativeArray<byte> m_Buffer; // 0x0
	private long m_SizeInBytes; // 0x10
	private int m_EventCount; // 0x18
	private bool m_WeOwnTheBuffer; // 0x1C

	// Properties
	public int eventCount { get; }
	public long sizeInBytes { get; }
	public long capacityInBytes { get; }
	public NativeArray<byte> data { get; }
	public InputEventPtr bufferPtr { get; }

	// Methods

	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_eventCount() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public long get_sizeInBytes() { }

	// RVA: 0x2860990 Offset: 0x285F390 VA: 0x182860990
	public long get_capacityInBytes() { }

	// RVA: 0x4944C0 Offset: 0x492EC0 VA: 0x1804944C0
	public NativeArray<byte> get_data() { }

	// RVA: 0x2860940 Offset: 0x285F340 VA: 0x182860940
	public InputEventPtr get_bufferPtr() { }

	// RVA: 0x2860630 Offset: 0x285F030 VA: 0x182860630
	public void .ctor(InputEvent* eventPtr, int eventCount, int sizeInBytes = -1, int capacityInBytes = -1) { }

	// RVA: 0x2860810 Offset: 0x285F210 VA: 0x182860810
	public void .ctor(NativeArray<byte> buffer, int eventCount, int sizeInBytes = -1, bool transferNativeArrayOwnership = False) { }

	// RVA: 0x2860290 Offset: 0x285EC90 VA: 0x182860290
	public void AppendEvent(InputEvent* eventPtr, int capacityIncrementInBytes = 2048, Allocator allocator = 4) { }

	// RVA: 0x285FFB0 Offset: 0x285E9B0 VA: 0x18285FFB0
	public InputEvent* AllocateEvent(int sizeInBytes, int capacityIncrementInBytes = 2048, Allocator allocator = 4) { }

	// RVA: 0x28603F0 Offset: 0x285EDF0 VA: 0x1828603F0
	public bool Contains(InputEvent* eventPtr) { }

	// RVA: 0x28605A0 Offset: 0x285EFA0 VA: 0x1828605A0
	public void Reset() { }

	// RVA: 0x285FF00 Offset: 0x285E900 VA: 0x18285FF00
	internal void AdvanceToNextEvent(ref InputEvent* currentReadPos, ref InputEvent* currentWritePos, ref int numEventsRetainedInBuffer, ref int numRemainingEvents, bool leaveEventInBuffer) { }

	// RVA: 0x28604C0 Offset: 0x285EEC0 VA: 0x1828604C0 Slot: 4
	public IEnumerator<InputEventPtr> GetEnumerator() { }

	// RVA: 0x28605C0 Offset: 0x285EFC0 VA: 0x1828605C0 Slot: 5
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x2860470 Offset: 0x285EE70 VA: 0x182860470 Slot: 6
	public void Dispose() { }

	// RVA: 0x2860320 Offset: 0x285ED20 VA: 0x182860320
	public InputEventBuffer Clone() { }

	// RVA: 0x28605D0 Offset: 0x285EFD0 VA: 0x1828605D0 Slot: 7
	private object System.ICloneable.Clone() { }
}
