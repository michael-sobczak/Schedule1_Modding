internal class DecalForwardEmissivePass : ScriptableRenderPass // TypeDefIndex: 8830
{
	// Fields
	private FilteringSettings m_FilteringSettings; // 0xE0
	private ProfilingSampler m_ProfilingSampler; // 0xF8
	private List<ShaderTagId> m_ShaderTagIdList; // 0x100
	private DecalDrawFowardEmissiveSystem m_DrawSystem; // 0x108

	// Methods

	// RVA: 0x2ACA790 Offset: 0x2AC9190 VA: 0x182ACA790
	public void .ctor(DecalDrawFowardEmissiveSystem drawSystem) { }

	// RVA: 0x2ACA580 Offset: 0x2AC8F80 VA: 0x182ACA580 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }
}
