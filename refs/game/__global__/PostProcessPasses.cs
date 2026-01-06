internal struct PostProcessPasses : IDisposable // TypeDefIndex: 8969
{
	// Fields
	private ColorGradingLutPass m_ColorGradingLutPass; // 0x0
	private PostProcessPass m_PostProcessPass; // 0x8
	private PostProcessPass m_FinalPostProcessPass; // 0x10
	internal RTHandle m_AfterPostProcessColor; // 0x18
	internal RTHandle m_ColorGradingLut; // 0x20
	private PostProcessData m_RendererPostProcessData; // 0x28
	private PostProcessData m_CurrentPostProcessData; // 0x30
	private Material m_BlitMaterial; // 0x38

	// Properties
	public ColorGradingLutPass colorGradingLutPass { get; }
	public PostProcessPass postProcessPass { get; }
	public PostProcessPass finalPostProcessPass { get; }
	public RTHandle afterPostProcessColor { get; }
	public RTHandle colorGradingLut { get; }
	public bool isCreated { get; }

	// Methods

	// RVA: 0x43C7F0 Offset: 0x43B1F0 VA: 0x18043C7F0
	public ColorGradingLutPass get_colorGradingLutPass() { }

	// RVA: 0x43C7B0 Offset: 0x43B1B0 VA: 0x18043C7B0
	public PostProcessPass get_postProcessPass() { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0
	public PostProcessPass get_finalPostProcessPass() { }

	// RVA: 0x43EFB0 Offset: 0x43D9B0 VA: 0x18043EFB0
	public RTHandle get_afterPostProcessColor() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public RTHandle get_colorGradingLut() { }

	// RVA: 0x2B17740 Offset: 0x2B16140 VA: 0x182B17740
	public bool get_isCreated() { }

	// RVA: 0x2B17680 Offset: 0x2B16080 VA: 0x182B17680
	public void .ctor(PostProcessData rendererPostProcessData, ref PostProcessParams postProcessParams) { }

	// RVA: 0x2B173E0 Offset: 0x2B15DE0 VA: 0x182B173E0
	public void Recreate(PostProcessData data, ref PostProcessParams ppParams) { }

	// RVA: 0x2B17370 Offset: 0x2B15D70 VA: 0x182B17370 Slot: 4
	public void Dispose() { }

	// RVA: 0x2B17620 Offset: 0x2B16020 VA: 0x182B17620
	internal void ReleaseRenderTargets() { }
}
