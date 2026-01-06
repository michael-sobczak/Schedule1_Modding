public class MeshGenerationContext // TypeDefIndex: 6753
{
	// Fields
	private Painter2D m_Painter2D; // 0x10
	private static readonly ProfilerMarker s_AllocateMarker; // 0x0
	private static readonly ProfilerMarker s_DrawVectorImageMarker; // 0x8
	internal IStylePainter painter; // 0x18

	// Properties
	public Painter2D painter2D { get; }
	internal bool hasPainter2D { get; }

	// Methods

	// RVA: 0x2EDCFA0 Offset: 0x2EDB9A0 VA: 0x182EDCFA0
	public Painter2D get_painter2D() { }

	// RVA: 0x82C1F0 Offset: 0x82ABF0 VA: 0x18082C1F0
	internal bool get_hasPainter2D() { }

	// RVA: 0x7E2C80 Offset: 0x7E1680 VA: 0x1807E2C80
	internal void .ctor(IStylePainter painter) { }

	// RVA: 0x2EDCF00 Offset: 0x2EDB900 VA: 0x182EDCF00
	private static void .cctor() { }
}
