internal class DecalScreenSpaceRenderPass : ScriptableRenderPass // TypeDefIndex: 8860
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0xE0
	private ProfilingSampler m_ProfilingSampler; // 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; // 0x100
	private DecalDrawScreenSpaceSystem m_DrawSystem; // 0x108
	private DecalScreenSpaceSettings m_Settings; // 0x110
	private bool m_DecalLayers; // 0x118

	// Methods

	// RVA: 0x2AE6CA0 Offset: 0x2AE56A0 VA: 0x182AE6CA0
	public void .ctor(DecalScreenSpaceSettings settings, DecalDrawScreenSpaceSystem drawSystem, bool decalLayers) { }

	// RVA: 0x2AE6790 Offset: 0x2AE5190 VA: 0x182AE6790 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2AE6B80 Offset: 0x2AE5580 VA: 0x182AE6B80 Slot: 7
	public override void OnCameraCleanup(CommandBuffer cmd) { }
}
