internal class UIRAtlasAllocator : IDisposable // TypeDefIndex: 6743
{
	// Fields
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <maxAtlasSize>k__BackingField; // 0x10
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly int <maxImageWidth>k__BackingField; // 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly int <maxImageHeight>k__BackingField; // 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <virtualWidth>k__BackingField; // 0x1C
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <virtualHeight>k__BackingField; // 0x20
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <physicalWidth>k__BackingField; // 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private int <physicalHeight>k__BackingField; // 0x28
	private UIRAtlasAllocator.AreaNode m_FirstUnpartitionedArea; // 0x30
	private UIRAtlasAllocator.Row[] m_OpenRows; // 0x38
	private int m_1SidePadding; // 0x40
	private int m_2SidePadding; // 0x44
	private static ProfilerMarker s_MarkerTryAllocate; // 0x0
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <disposed>k__BackingField; // 0x48

	// Properties
	public int maxAtlasSize { get; }
	public int maxImageWidth { get; }
	public int maxImageHeight { get; }
	public int virtualWidth { get; set; }
	public int virtualHeight { get; set; }
	public int physicalWidth { get; set; }
	public int physicalHeight { get; set; }
	protected bool disposed { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0x43C220 Offset: 0x43AC20 VA: 0x18043C220
	public int get_maxAtlasSize() { }

	[CompilerGenerated]
	// RVA: 0x498A70 Offset: 0x497470 VA: 0x180498A70
	public int get_maxImageWidth() { }

	[CompilerGenerated]
	// RVA: 0x456E90 Offset: 0x455890 VA: 0x180456E90
	public int get_maxImageHeight() { }

	[CompilerGenerated]
	// RVA: 0x4A1F70 Offset: 0x4A0970 VA: 0x1804A1F70
	public int get_virtualWidth() { }

	[CompilerGenerated]
	// RVA: 0x4A1F80 Offset: 0x4A0980 VA: 0x1804A1F80
	private void set_virtualWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	public int get_virtualHeight() { }

	[CompilerGenerated]
	// RVA: 0x494490 Offset: 0x492E90 VA: 0x180494490
	private void set_virtualHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public int get_physicalWidth() { }

	[CompilerGenerated]
	// RVA: 0x49CD60 Offset: 0x49B760 VA: 0x18049CD60
	private void set_physicalWidth(int value) { }

	[CompilerGenerated]
	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_physicalHeight() { }

	[CompilerGenerated]
	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	private void set_physicalHeight(int value) { }

	[CompilerGenerated]
	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	protected bool get_disposed() { }

	[CompilerGenerated]
	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	private void set_disposed(bool value) { }

	// RVA: 0x2EE3B70 Offset: 0x2EE2570 VA: 0x182EE3B70 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EE3A20 Offset: 0x2EE2420 VA: 0x182EE3A20 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x2EE3BE0 Offset: 0x2EE25E0 VA: 0x182EE3BE0
	private static int GetLog2OfNextPower(int n) { }

	// RVA: 0x2EE42D0 Offset: 0x2EE2CD0 VA: 0x182EE42D0
	public void .ctor(int initialAtlasSize, int maxAtlasSize, int sidePadding = 1) { }

	// RVA: 0x2EE3C50 Offset: 0x2EE2650 VA: 0x182EE3C50
	public bool TryAllocate(int width, int height, out RectInt location) { }

	// RVA: 0x2EE4000 Offset: 0x2EE2A00 VA: 0x182EE4000
	private bool TryPartitionArea(UIRAtlasAllocator.AreaNode areaNode, int rowIndex, int rowHeight, int minWidth) { }

	// RVA: 0x2EE3940 Offset: 0x2EE2340 VA: 0x182EE3940
	private void BuildAreas() { }

	// RVA: 0x2EE4270 Offset: 0x2EE2C70 VA: 0x182EE4270
	private static void .cctor() { }
}
