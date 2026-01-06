internal class Page : IDisposable // TypeDefIndex: 7091
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <disposed>k__BackingField; // 0x10
	public Page.DataSet<Vertex> vertices; // 0x18
	public Page.DataSet<ushort> indices; // 0x20
	public Page next; // 0x28
	public int framesEmpty; // 0x30

	// Properties
	protected bool disposed { get; set; }
	public bool isEmpty { get; }

	// Methods

	// RVA: 0x2DFE270 Offset: 0x2DFCC70 VA: 0x182DFE270
	public void .ctor(uint vertexMaxCount, uint indexMaxCount, uint maxQueuedFrameCount, bool mockPage) { }

	[CompilerGenerated]
	// RVA: 0x498A40 Offset: 0x497440 VA: 0x180498A40
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x498A80 Offset: 0x497480 VA: 0x180498A80
	private void set_disposed(bool value) { }

	// RVA: 0x2DFE200 Offset: 0x2DFCC00 VA: 0x182DFE200 Slot: 4
	public void Dispose() { }

	// RVA: 0x2DFE170 Offset: 0x2DFCB70 VA: 0x182DFE170 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2DFE3D0 Offset: 0x2DFCDD0 VA: 0x182DFE3D0
	public bool get_isEmpty() { }
}
