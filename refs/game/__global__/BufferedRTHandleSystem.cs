public class BufferedRTHandleSystem : IDisposable // TypeDefIndex: 13810
{
	// Fields
	private Dictionary<int, RTHandle[]> m_RTHandles; // 0x10
	private RTHandleSystem m_RTHandleSystem; // 0x18
	private bool m_DisposedValue; // 0x20

	// Properties
	public int maxWidth { get; }
	public int maxHeight { get; }
	public RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x2A166D0 Offset: 0x2A150D0 VA: 0x182A166D0
	public int get_maxWidth() { }

	// RVA: 0x2A166B0 Offset: 0x2A150B0 VA: 0x182A166B0
	public int get_maxHeight() { }

	// RVA: 0x2A166F0 Offset: 0x2A150F0 VA: 0x182A166F0
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x2A15DE0 Offset: 0x2A147E0 VA: 0x182A15DE0
	public RTHandle GetFrameRT(int bufferId, int frameIndex) { }

	// RVA: 0x2A15AB0 Offset: 0x2A144B0 VA: 0x182A15AB0
	public void AllocBuffer(int bufferId, Func<RTHandleSystem, int, RTHandle> allocator, int bufferCount) { }

	// RVA: 0x2A160F0 Offset: 0x2A14AF0 VA: 0x182A160F0
	public void ReleaseBuffer(int bufferId) { }

	// RVA: 0x2A16200 Offset: 0x2A14C00 VA: 0x182A16200
	public void SwapAndSetReferenceSize(int width, int height) { }

	// RVA: 0x2A161D0 Offset: 0x2A14BD0 VA: 0x182A161D0
	public void ResetReferenceSize(int width, int height) { }

	// RVA: 0x2A15E90 Offset: 0x2A14890 VA: 0x182A15E90
	public int GetNumFramesAllocated(int bufferId) { }

	// RVA: 0x2A15D00 Offset: 0x2A14700 VA: 0x182A15D00
	public Vector2 CalculateRatioAgainstMaxSize(int width, int height) { }

	// RVA: 0x2A16260 Offset: 0x2A14C60 VA: 0x182A16260
	private void Swap() { }

	// RVA: 0x2A15D40 Offset: 0x2A14740 VA: 0x182A15D40
	private void Dispose(bool disposing) { }

	// RVA: 0x2A15D90 Offset: 0x2A14790 VA: 0x182A15D90 Slot: 4
	public void Dispose() { }

	// RVA: 0x2A15F20 Offset: 0x2A14920 VA: 0x182A15F20
	public void ReleaseAll() { }

	// RVA: 0x2A16600 Offset: 0x2A15000 VA: 0x182A16600
	public void .ctor() { }
}
