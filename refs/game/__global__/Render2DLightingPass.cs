internal class Render2DLightingPass : ScriptableRenderPass, IRenderPass2D // TypeDefIndex: 8711
{
	// Fields
	private static readonly int k_HDREmulationScaleID; // 0x0
	private static readonly int k_InverseHDREmulationScaleID; // 0x4
	private static readonly int k_UseSceneLightingID; // 0x8
	private static readonly int k_RendererColorID; // 0xC
	private static readonly int[] k_ShapeLightTextureIDs; // 0x10
	private static readonly ShaderTagId k_CombinedRenderingPassName; // 0x18
	private static readonly ShaderTagId k_NormalsRenderingPassName; // 0x1C
	private static readonly ShaderTagId k_LegacyPassName; // 0x20
	private static readonly List<ShaderTagId> k_ShaderTags; // 0x28
	private static readonly ProfilingSampler m_ProfilingDrawLights; // 0x30
	private static readonly ProfilingSampler m_ProfilingDrawLightTextures; // 0x38
	private static readonly ProfilingSampler m_ProfilingDrawRenderers; // 0x40
	private static readonly ProfilingSampler m_ProfilingDrawLayerBatch; // 0x48
	private static readonly ProfilingSampler m_ProfilingSamplerUnlit; // 0x50
	private Material m_BlitMaterial; // 0xE0
	private Material m_SamplingMaterial; // 0xE8
	private readonly Renderer2DData m_Renderer2DData; // 0xF0
	private bool m_NeedsDepth; // 0xF8
	private short m_CameraSortingLayerBoundsIndex; // 0xFA

	// Properties
	private Renderer2DData UnityEngine.Rendering.Universal.IRenderPass2D.rendererData { get; }

	// Methods

	// RVA: 0x2A86380 Offset: 0x2A84D80 VA: 0x182A86380
	public void .ctor(Renderer2DData rendererData, Material blitMaterial, Material samplingMaterial) { }

	// RVA: 0x1A3AEE0 Offset: 0x1A398E0 VA: 0x181A3AEE0
	internal void Setup(bool useDepth) { }

	// RVA: 0x2A85AE0 Offset: 0x2A844E0 VA: 0x182A85AE0
	private void GetTransparencySortingMode(Camera camera, ref SortingSettings sortingSettings) { }

	// RVA: 0x2A825B0 Offset: 0x2A80FB0 VA: 0x182A825B0
	private void CopyCameraSortingLayerRenderTexture(ScriptableRenderContext context, RenderingData renderingData, RenderBufferStoreAction mainTargetStoreAction) { }

	// RVA: 0x2A85A00 Offset: 0x2A84400 VA: 0x182A85A00
	private short GetCameraSortingLayerBoundsIndex() { }

	// RVA: 0x2A82AA0 Offset: 0x2A814A0 VA: 0x182A82AA0
	private void DetermineWhenToResolve(int startIndex, int batchesDrawn, int batchCount, LayerBatch[] layerBatches, out int resolveDuringBatch, out bool resolveIsAfterCopy) { }

	// RVA: 0x2A85BA0 Offset: 0x2A845A0 VA: 0x182A85BA0
	private void Render(ScriptableRenderContext context, CommandBuffer cmd, ref RenderingData renderingData, ref FilteringSettings filterSettings, DrawingSettings drawSettings) { }

	// RVA: 0x2A82D30 Offset: 0x2A81730 VA: 0x182A82D30
	private int DrawLayerBatches(LayerBatch[] layerBatches, int batchCount, int startIndex, CommandBuffer cmd, ScriptableRenderContext context, ref RenderingData renderingData, ref FilteringSettings filterSettings, ref DrawingSettings normalsDrawSettings, ref DrawingSettings drawSettings, ref RenderTextureDescriptor desc) { }

	// RVA: 0x2A844C0 Offset: 0x2A82EC0 VA: 0x182A844C0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0 Slot: 11
	private Renderer2DData UnityEngine.Rendering.Universal.IRenderPass2D.get_rendererData() { }

	// RVA: 0x2A85DF0 Offset: 0x2A847F0 VA: 0x182A85DF0
	private static void .cctor() { }
}
