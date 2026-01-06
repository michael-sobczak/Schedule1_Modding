internal sealed class AutoExposureRenderer : PostProcessEffectRenderer<AutoExposure> // TypeDefIndex: 16958
{
	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumAutoExposureTextures = 2;
	private readonly RenderTexture[][] m_AutoExposurePool; // 0x20
	private int[] m_AutoExposurePingPong; // 0x28
	private RenderTexture m_CurrentAutoExposure; // 0x30

	// Methods

	// RVA: 0x2995F80 Offset: 0x2994980 VA: 0x182995F80
	public void .ctor() { }

	// RVA: 0x2995400 Offset: 0x2993E00 VA: 0x182995400
	private void CheckTexture(int eye, int id) { }

	// RVA: 0x29956D0 Offset: 0x29940D0 VA: 0x1829956D0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x29955F0 Offset: 0x2993FF0 VA: 0x1829955F0 Slot: 7
	public override void Release() { }
}
