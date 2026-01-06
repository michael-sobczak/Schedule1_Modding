internal sealed class ColorGradingRenderer : PostProcessEffectRenderer<ColorGrading> // TypeDefIndex: 16971
{
	// Fields
	private Texture2D m_GradingCurves; // 0x20
	private readonly Color[] m_Pixels; // 0x28
	private RenderTexture m_InternalLdrLut; // 0x30
	private RenderTexture m_InternalLogLut; // 0x38
	private const int k_Lut2DSize = 32;
	private const int k_Lut3DSize = 33;
	private readonly HableCurve m_HableCurve; // 0x40

	// Methods

	// RVA: 0x299B690 Offset: 0x299A090 VA: 0x18299B690 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2998810 Offset: 0x2997210 VA: 0x182998810
	private void RenderExternalPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x2999A40 Offset: 0x2998440 VA: 0x182999A40
	private void RenderHDRPipeline3D(PostProcessRenderContext context) { }

	// RVA: 0x2998A90 Offset: 0x2997490 VA: 0x182998A90
	private void RenderHDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x299A980 Offset: 0x2999380 VA: 0x18299A980
	private void RenderLDRPipeline2D(PostProcessRenderContext context) { }

	// RVA: 0x2997E10 Offset: 0x2996810 VA: 0x182997E10
	private void CheckInternalLogLut() { }

	// RVA: 0x2997FF0 Offset: 0x29969F0 VA: 0x182997FF0
	private void CheckInternalStripLut() { }

	// RVA: 0x29981D0 Offset: 0x2996BD0 VA: 0x1829981D0
	private Texture2D GetCurveTexture(bool hdr) { }

	// RVA: 0x2998710 Offset: 0x2997110 VA: 0x182998710
	private static bool IsRenderTextureFormatSupportedForLinearFiltering(RenderTextureFormat format) { }

	// RVA: 0x2998640 Offset: 0x2997040 VA: 0x182998640
	private static RenderTextureFormat GetLutFormat() { }

	// RVA: 0x29981A0 Offset: 0x2996BA0 VA: 0x1829981A0
	private static TextureFormat GetCurveFormat() { }

	// RVA: 0x2998770 Offset: 0x2997170 VA: 0x182998770 Slot: 7
	public override void Release() { }

	// RVA: 0x299B800 Offset: 0x299A200 VA: 0x18299B800
	public void .ctor() { }
}
