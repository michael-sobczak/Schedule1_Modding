public class Painter2D : IDisposable // TypeDefIndex: 6754
{
	// Fields
	private MeshGenerationContext m_Ctx; // 0x10
	internal DetachedAllocator m_DetachedAllocator; // 0x18
	internal SafeHandleAccess m_Handle; // 0x20
	private bool m_Disposed; // 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private static bool <isPainterActive>k__BackingField; // 0x0
	private static float s_MaxArcRadius; // 0x4
	private static readonly ProfilerMarker s_StrokeMarker; // 0x8
	private static readonly ProfilerMarker s_FillMarker; // 0x10

	// Properties
	internal static bool isPainterActive { set; }

	// Methods

	// RVA: 0x2EDD5E0 Offset: 0x2EDBFE0 VA: 0x182EDD5E0
	internal void .ctor(MeshGenerationContext ctx) { }

	// RVA: 0x2EDD680 Offset: 0x2EDC080 VA: 0x182EDD680
	public void .ctor() { }

	// RVA: 0x2EDD4C0 Offset: 0x2EDBEC0 VA: 0x182EDD4C0
	internal void Reset() { }

	// RVA: 0x2EDD420 Offset: 0x2EDBE20 VA: 0x182EDD420 Slot: 4
	public void Dispose() { }

	// RVA: 0x2EDD3C0 Offset: 0x2EDBDC0 VA: 0x182EDD3C0
	private void Dispose(bool disposing) { }

	[CompilerGenerated]
	// RVA: 0x2EDD7B0 Offset: 0x2EDC1B0 VA: 0x182EDD7B0
	internal static void set_isPainterActive(bool value) { }

	// RVA: 0x2EDD530 Offset: 0x2EDBF30 VA: 0x182EDD530
	private static void .cctor() { }
}
