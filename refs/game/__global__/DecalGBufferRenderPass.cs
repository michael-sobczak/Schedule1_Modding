internal class DecalGBufferRenderPass : ScriptableRenderPass // TypeDefIndex: 8858
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0xE0
	private ProfilingSampler m_ProfilingSampler; // 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; // 0x100
	private DecalDrawGBufferSystem m_DrawSystem; // 0x108
	private DecalScreenSpaceSettings m_Settings; // 0x110
	private DeferredLights m_DeferredLights; // 0x118
	private RTHandle[] m_GbufferAttachments; // 0x120
	private bool m_DecalLayers; // 0x128

	// Methods

	// RVA: 0x2AE6430 Offset: 0x2AE4E30 VA: 0x182AE6430
	public void .ctor(DecalScreenSpaceSettings settings, DecalDrawGBufferSystem drawSystem, bool decalLayers) { }

	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	internal void Setup(DeferredLights deferredLights) { }

	// RVA: 0x2AE5900 Offset: 0x2AE4300 VA: 0x182AE5900 Slot: 6
	public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor) { }

	// RVA: 0x2AE5FA0 Offset: 0x2AE49A0 VA: 0x182AE5FA0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AE6310 Offset: 0x2AE4D10 VA: 0x182AE6310 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}
