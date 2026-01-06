internal class RenderChainCommand : LinkedPoolItem<RenderChainCommand> // TypeDefIndex: 7096
{
	// Fields
	internal VisualElement owner; // 0x18
	internal RenderChainCommand prev; // 0x20
	internal RenderChainCommand next; // 0x28
	internal bool closing; // 0x30
	internal CommandType type; // 0x34
	internal State state; // 0x38
	internal MeshHandle mesh; // 0x50
	internal int indexOffset; // 0x58
	internal int indexCount; // 0x5C
	internal Action callback; // 0x60
	private static readonly int k_ID_MainTex; // 0x0
	private static ProfilerMarker s_ImmediateOverheadMarker; // 0x8

	// Methods

	// RVA: 0x2DFF960 Offset: 0x2DFE360 VA: 0x182DFF960
	internal void Reset() { }

	// RVA: 0x2DFE850 Offset: 0x2DFD250 VA: 0x182DFE850
	internal void ExecuteNonDrawMesh(DrawParams drawParams, float pixelsPerPoint, ref Exception immediateException) { }

	// RVA: 0x2DFE5A0 Offset: 0x2DFCFA0 VA: 0x182DFE5A0
	private void Blit(Texture source, RenderTexture destination, float depth) { }

	// RVA: 0x2DFE710 Offset: 0x2DFD110 VA: 0x182DFE710
	private static Rect CombineScissorRects(Rect r0, Rect r1) { }

	// RVA: 0x2DFF830 Offset: 0x2DFE230 VA: 0x182DFF830
	private static RectInt RectPointsToPixelsAndFlipYAxis(Rect rect, float pixelsPerPoint) { }

	// RVA: 0x2DFFA70 Offset: 0x2DFE470 VA: 0x182DFFA70
	public void .ctor() { }

	// RVA: 0x2DFF9E0 Offset: 0x2DFE3E0 VA: 0x182DFF9E0
	private static void .cctor() { }
}
