internal sealed class GrainRenderer : PostProcessEffectRenderer<Grain> // TypeDefIndex: 16981
{
	// Fields
	private RenderTexture m_GrainLookupRT; // 0x20
	private const int k_SampleCount = 1024;
	private int m_SampleIndex; // 0x28

	// Methods

	// RVA: 0x299E670 Offset: 0x299D070 VA: 0x18299E670 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x299E5B0 Offset: 0x299CFB0 VA: 0x18299E5B0
	private RenderTextureFormat GetLookupFormat() { }

	// RVA: 0x299E600 Offset: 0x299D000 VA: 0x18299E600 Slot: 7
	public override void Release() { }

	// RVA: 0x299ED90 Offset: 0x299D790 VA: 0x18299ED90
	public void .ctor() { }
}
