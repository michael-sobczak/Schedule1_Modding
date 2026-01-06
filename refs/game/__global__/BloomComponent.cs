public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel> // TypeDefIndex: 116
{
	// Fields
	private const int k_MaxPyramidBlurLevel = 16;
	private readonly RenderTexture[] m_BlurBuffer1; // 0x20
	private readonly RenderTexture[] m_BlurBuffer2; // 0x28

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x56CDB0 Offset: 0x56B7B0 VA: 0x18056CDB0 Slot: 5
	public override bool get_active() { }

	// RVA: 0x56C160 Offset: 0x56AB60 VA: 0x18056C160
	public void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure) { }

	// RVA: 0x56CD20 Offset: 0x56B720 VA: 0x18056CD20
	public void .ctor() { }
}
