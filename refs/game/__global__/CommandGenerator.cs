internal static class CommandGenerator // TypeDefIndex: 7150
{
	// Fields
	private static readonly ProfilerMarker k_GenerateEntries; // 0x0
	private static readonly ProfilerMarker k_ConvertEntriesToCommandsMarker; // 0x8
	private static readonly ProfilerMarker k_GenerateClosingCommandsMarker; // 0x10
	private static readonly ProfilerMarker k_NudgeVerticesMarker; // 0x18
	private static readonly ProfilerMarker k_UpdateOpacityIdMarker; // 0x20
	private static readonly ProfilerMarker k_ComputeTransformMatrixMarker; // 0x28
	private static Material s_blitMaterial_LinearToGamma; // 0x30
	private static Material s_blitMaterial_GammaToLinear; // 0x38
	private static Material s_blitMaterial_NoChange; // 0x40
	private static Shader s_blitShader; // 0x48

	// Methods

	// RVA: 0x2E14700 Offset: 0x2E13100 VA: 0x182E14700
	private static void GetVerticesTransformInfo(VisualElement ve, out Matrix4x4 transform) { }

	// RVA: 0x2E139C0 Offset: 0x2E123C0 VA: 0x182E139C0
	internal static void ComputeTransformMatrix(VisualElement ve, VisualElement ancestor, out Matrix4x4 result) { }

	[Extension]
	// RVA: 0x2E14F20 Offset: 0x2E13920 VA: 0x182E14F20
	private static bool IsParentOrAncestorOf(VisualElement ve, VisualElement child) { }

	// RVA: 0x2E15500 Offset: 0x2E13F00 VA: 0x182E15500
	public static UIRStylePainter.ClosingInfo PaintElement(RenderChain renderChain, VisualElement ve, ref ChainBuilderStats stats) { }

	// RVA: 0x2E14E30 Offset: 0x2E13830 VA: 0x182E14E30
	private static void InvokeGenerateVisualContent(VisualElement ve, MeshGenerationContext ctx) { }

	// RVA: 0x2E13B60 Offset: 0x2E12560 VA: 0x182E13B60
	private static Material CreateBlitShader(float colorConversion) { }

	// RVA: 0x2E143D0 Offset: 0x2E12DD0 VA: 0x182E143D0
	private static Material GetBlitMaterial(VisualElement.RenderTargetMode mode) { }

	// RVA: 0x2E13630 Offset: 0x2E12030 VA: 0x182E13630
	public static void ClosePaintElement(VisualElement ve, UIRStylePainter.ClosingInfo closingInfo, RenderChain renderChain, ref ChainBuilderStats stats) { }

	// RVA: 0x2E176C0 Offset: 0x2E160C0 VA: 0x182E176C0
	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex> verts, out NativeSlice<ushort> indices, out ushort indexOffset, ref ChainBuilderStats stats) { }

	// RVA: 0x2E17600 Offset: 0x2E16000 VA: 0x182E17600
	public static void UpdateOpacityId(VisualElement ve, RenderChain renderChain) { }

	// RVA: 0x2E13D90 Offset: 0x2E12790 VA: 0x182E13D90
	private static void DoUpdateOpacityId(VisualElement ve, RenderChain renderChain, MeshHandle mesh) { }

	// RVA: 0x2E14FC0 Offset: 0x2E139C0 VA: 0x182E14FC0
	public static bool NudgeVerticesToNewSpace(VisualElement ve, RenderChain renderChain, UIRenderDevice device) { }

	// RVA: 0x2E17170 Offset: 0x2E15B70 VA: 0x182E17170
	private static void PrepareNudgeVertices(VisualElement ve, UIRenderDevice device, MeshHandle mesh, out IntPtr src, out IntPtr dst, out int count) { }

	// RVA: 0x2E14CE0 Offset: 0x2E136E0 VA: 0x182E14CE0
	private static RenderChainCommand InjectMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x2E14A50 Offset: 0x2E13450 VA: 0x182E14A50
	private static RenderChainCommand InjectClosingMeshDrawCommand(RenderChain renderChain, VisualElement ve, ref RenderChainCommand cmdPrev, ref RenderChainCommand cmdNext, MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture, int stencilRef) { }

	// RVA: 0x2E14130 Offset: 0x2E12B30 VA: 0x182E14130
	private static void FindCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	// RVA: 0x2E13F00 Offset: 0x2E12900 VA: 0x182E13F00
	private static void FindClosingCommandInsertionPoint(VisualElement ve, out RenderChainCommand prev, out RenderChainCommand next) { }

	// RVA: 0x2E14BA0 Offset: 0x2E135A0 VA: 0x182E14BA0
	private static void InjectCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) { }

	// RVA: 0x2E148E0 Offset: 0x2E132E0 VA: 0x182E148E0
	private static void InjectClosingCommandInBetween(RenderChain renderChain, RenderChainCommand cmd, ref RenderChainCommand prev, ref RenderChainCommand next) { }

	// RVA: 0x2E172C0 Offset: 0x2E15CC0 VA: 0x182E172C0
	public static void ResetCommands(RenderChain renderChain, VisualElement ve) { }

	// RVA: 0x2E177E0 Offset: 0x2E161E0 VA: 0x182E177E0
	private static void .cctor() { }
}
