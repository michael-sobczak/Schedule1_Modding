public sealed class EyeAdaptationComponent : PostProcessingComponentRenderTexture<EyeAdaptationModel> // TypeDefIndex: 130
{
	// Fields
	private ComputeShader m_EyeCompute; // 0x20
	private ComputeBuffer m_HistogramBuffer; // 0x28
	private readonly RenderTexture[] m_AutoExposurePool; // 0x30
	private int m_AutoExposurePingPing; // 0x38
	private RenderTexture m_CurrentAutoExposure; // 0x40
	private RenderTexture m_DebugHistogram; // 0x48
	private static uint[] s_EmptyHistogramBuffer; // 0x0
	private bool m_FirstFrame; // 0x50
	private const int k_HistogramBins = 64;
	private const int k_HistogramThreadX = 16;
	private const int k_HistogramThreadY = 16;

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x572EE0 Offset: 0x5718E0 VA: 0x180572EE0 Slot: 5
	public override bool get_active() { }

	// RVA: 0x508680 Offset: 0x507080 VA: 0x180508680
	public void ResetHistory() { }

	// RVA: 0x508680 Offset: 0x507080 VA: 0x180508680 Slot: 6
	public override void OnEnable() { }

	// RVA: 0x571EC0 Offset: 0x5708C0 VA: 0x180571EC0 Slot: 7
	public override void OnDisable() { }

	// RVA: 0x571DA0 Offset: 0x5707A0 VA: 0x180571DA0
	private Vector4 GetHistogramScaleOffsetRes() { }

	// RVA: 0x572140 Offset: 0x570B40 VA: 0x180572140
	public Texture Prepare(RenderTexture source, Material uberMaterial) { }

	// RVA: 0x571FC0 Offset: 0x5709C0 VA: 0x180571FC0
	public void OnGUI() { }

	// RVA: 0x572E70 Offset: 0x571870 VA: 0x180572E70
	public void .ctor() { }
}
