public class ColorGradingLutPass : ScriptableRenderPass // TypeDefIndex: 9130
{
	// Fields
	private readonly Material m_LutBuilderLdr; // 0xE0
	private readonly Material m_LutBuilderHdr; // 0xE8
	internal readonly GraphicsFormat m_HdrLutFormat; // 0xF0
	internal readonly GraphicsFormat m_LdrLutFormat; // 0xF4
	private ColorGradingLutPass.PassData m_PassData; // 0xF8
	private RTHandle m_InternalLut; // 0x100
	private bool m_AllowColorGradingACESHDR; // 0x108

	// Methods

	// RVA: 0x2B5F420 Offset: 0x2B5DE20 VA: 0x182B5F420
	public void .ctor(RenderPassEvent evt, PostProcessData data) { }

	// RVA: 0x2B5F340 Offset: 0x2B5DD40 VA: 0x182B5F340
	public void Setup(in RTHandle internalLut) { }

	// RVA: 0x2B5D630 Offset: 0x2B5C030 VA: 0x182B5D630
	public void ConfigureDescriptor(in PostProcessingData postProcessingData, out RenderTextureDescriptor descriptor, out FilterMode filterMode) { }

	// RVA: 0x2B5ECB0 Offset: 0x2B5D6B0 VA: 0x182B5ECB0 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B5D6D0 Offset: 0x2B5C0D0 VA: 0x182B5D6D0
	private static void ExecutePass(ScriptableRenderContext context, ColorGradingLutPass.PassData passData, ref RenderingData renderingData, RTHandle internalLutTarget) { }

	// RVA: 0x2B5EE50 Offset: 0x2B5D850 VA: 0x182B5EE50
	internal void Render(RenderGraph renderGraph, out TextureHandle internalColorLut, ref RenderingData renderingData) { }

	// RVA: 0x2B5D5C0 Offset: 0x2B5BFC0 VA: 0x182B5D5C0
	public void Cleanup() { }

	[CompilerGenerated]
	// RVA: 0x2B5F360 Offset: 0x2B5DD60 VA: 0x182B5F360
	internal static Material <.ctor>g__Load|7_0(Shader shader) { }
}
