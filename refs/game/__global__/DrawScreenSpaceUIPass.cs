internal class DrawScreenSpaceUIPass : ScriptableRenderPass // TypeDefIndex: 8941
{
	// Fields
	private DrawScreenSpaceUIPass.PassData m_PassData; // 0xE0
	private RTHandle m_ColorTarget; // 0xE8
	private RTHandle m_DepthTarget; // 0xF0
	private bool m_RenderOffscreen; // 0xF8

	// Methods

	// RVA: 0x2B00190 Offset: 0x2AFEB90 VA: 0x182B00190
	public void .ctor(RenderPassEvent evt, bool renderOffscreen) { }

	// RVA: 0x2AFF220 Offset: 0x2AFDC20 VA: 0x182AFF220
	public static void ConfigureColorDescriptor(ref RenderTextureDescriptor descriptor, int cameraWidth, int cameraHeight) { }

	// RVA: 0x2AFF270 Offset: 0x2AFDC70 VA: 0x182AFF270
	public static void ConfigureDepthDescriptor(ref RenderTextureDescriptor descriptor, int depthBufferBits, int cameraWidth, int cameraHeight) { }

	// RVA: 0x2AFF300 Offset: 0x2AFDD00 VA: 0x182AFF300
	private static void ExecutePass(ScriptableRenderContext context, DrawScreenSpaceUIPass.PassData passData) { }

	// RVA: 0x2AFF2C0 Offset: 0x2AFDCC0 VA: 0x182AFF2C0
	public void Dispose() { }

	// RVA: 0x2AFFF50 Offset: 0x2AFE950 VA: 0x182AFFF50
	public void Setup(ref CameraData cameraData, int depthBufferBits) { }

	// RVA: 0x2AFF390 Offset: 0x2AFDD90 VA: 0x182AFF390 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AFF7E0 Offset: 0x2AFE1E0 VA: 0x182AFF7E0
	internal void RenderOffscreen(RenderGraph renderGraph, int depthBufferBits, out TextureHandle output, ref RenderingData renderingData) { }

	// RVA: 0x2AFFCE0 Offset: 0x2AFE6E0 VA: 0x182AFFCE0
	internal void RenderOverlay(RenderGraph renderGraph, in TextureHandle colorBuffer, in TextureHandle depthBuffer, ref RenderingData renderingData) { }
}
