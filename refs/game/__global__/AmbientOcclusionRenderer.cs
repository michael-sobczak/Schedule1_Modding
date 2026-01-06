internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion> // TypeDefIndex: 16954
{
	// Fields
	private IAmbientOcclusionMethod[] m_Methods; // 0x20

	// Methods

	// RVA: 0x29948A0 Offset: 0x29932A0 VA: 0x1829948A0 Slot: 4
	public override void Init() { }

	// RVA: 0x2994B30 Offset: 0x2993530 VA: 0x182994B30
	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x2994840 Offset: 0x2993240 VA: 0x182994840
	public IAmbientOcclusionMethod Get() { }

	// RVA: 0x2994650 Offset: 0x2993050 VA: 0x182994650 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x2994BC0 Offset: 0x29935C0 VA: 0x182994BC0 Slot: 7
	public override void Release() { }

	// RVA: 0x29947D0 Offset: 0x29931D0 VA: 0x1829947D0
	public ScalableAO GetScalableAO() { }

	// RVA: 0x2994760 Offset: 0x2993160 VA: 0x182994760
	public MultiScaleVO GetMultiScaleVO() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x2994CE0 Offset: 0x29936E0 VA: 0x182994CE0
	public void .ctor() { }
}
