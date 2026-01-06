internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections> // TypeDefIndex: 16999
{
	// Fields
	private RenderTexture m_Resolve; // 0x20
	private RenderTexture m_History; // 0x28
	private int[] m_MipIDs; // 0x30
	private readonly ScreenSpaceReflectionsRenderer.QualityPreset[] m_Presets; // 0x38

	// Methods

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x29A5A70 Offset: 0x29A4470 VA: 0x1829A5A70
	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap) { }

	// RVA: 0x29A5D10 Offset: 0x29A4710 VA: 0x1829A5D10 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x29A5C80 Offset: 0x29A4680 VA: 0x1829A5C80 Slot: 7
	public override void Release() { }

	// RVA: 0x29A70B0 Offset: 0x29A5AB0 VA: 0x1829A70B0
	public void .ctor() { }
}
