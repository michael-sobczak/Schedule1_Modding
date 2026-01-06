internal sealed class DepthOfFieldRenderer : PostProcessEffectRenderer<DepthOfField> // TypeDefIndex: 16976
{
	// Fields
	private const int k_NumEyes = 2;
	private const int k_NumCoCHistoryTextures = 2;
	private readonly RenderTexture[][] m_CoCHistoryTextures; // 0x20
	private int[] m_HistoryPingPong; // 0x28
	private const float k_FilmHeight = 0.024;

	// Methods

	// RVA: 0x299DA90 Offset: 0x299C490 VA: 0x18299DA90
	public void .ctor() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x299DA00 Offset: 0x299C400 VA: 0x18299DA00
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

	// RVA: 0x299C960 Offset: 0x299B360 VA: 0x18299C960
	private float CalculateMaxCoCRadius(int screenHeight) { }

	// RVA: 0x299C9E0 Offset: 0x299B3E0 VA: 0x18299C9E0
	private RenderTexture CheckHistory(int eye, int id, PostProcessRenderContext context, RenderTextureFormat format) { }

	// RVA: 0x299CD60 Offset: 0x299B760 VA: 0x18299CD60 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x299CC30 Offset: 0x299B630 VA: 0x18299CC30 Slot: 7
	public override void Release() { }
}
