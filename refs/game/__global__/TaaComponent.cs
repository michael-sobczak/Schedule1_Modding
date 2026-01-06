public sealed class TaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel> // TypeDefIndex: 147
{
	// Fields
	private const string k_ShaderString = "Hidden/Post FX/Temporal Anti-aliasing";
	private const int k_SampleCount = 8;
	private readonly RenderBuffer[] m_MRT; // 0x20
	private int m_SampleIndex; // 0x28
	private bool m_ResetHistory; // 0x2C
	private RenderTexture m_HistoryTexture; // 0x30
	[CompilerGenerated]
	private Vector2 <jitterVector>k__BackingField; // 0x38

	// Properties
	public override bool active { get; }
	public Vector2 jitterVector { get; set; }

	// Methods

	// RVA: 0x57CC50 Offset: 0x57B650 VA: 0x18057CC50 Slot: 5
	public override bool get_active() { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60 Slot: 4
	public override DepthTextureMode GetCameraFlags() { }

	[CompilerGenerated]
	// RVA: 0x57CCD0 Offset: 0x57B6D0 VA: 0x18057CCD0
	public Vector2 get_jitterVector() { }

	[CompilerGenerated]
	// RVA: 0x57CCF0 Offset: 0x57B6F0 VA: 0x18057CCF0
	private void set_jitterVector(Vector2 value) { }

	// RVA: 0x57C830 Offset: 0x57B230 VA: 0x18057C830
	public void ResetHistory() { }

	// RVA: 0x57C840 Offset: 0x57B240 VA: 0x18057C840
	public void SetProjectionMatrix(Func<Vector2, Matrix4x4> jitteredFunc) { }

	// RVA: 0x57C330 Offset: 0x57AD30 VA: 0x18057C330
	public void Render(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x57BB70 Offset: 0x57A570 VA: 0x18057BB70
	private float GetHaltonValue(int index, int radix) { }

	// RVA: 0x57BA90 Offset: 0x57A490 VA: 0x18057BA90
	private Vector2 GenerateRandomOffset() { }

	// RVA: 0x57BD90 Offset: 0x57A790 VA: 0x18057BD90
	private Matrix4x4 GetPerspectiveProjectionMatrix(Vector2 offset) { }

	// RVA: 0x57BBD0 Offset: 0x57A5D0 VA: 0x18057BBD0
	private Matrix4x4 GetOrthographicProjectionMatrix(Vector2 offset) { }

	// RVA: 0x57C2A0 Offset: 0x57ACA0 VA: 0x18057C2A0 Slot: 7
	public override void OnDisable() { }

	// RVA: 0x57CBE0 Offset: 0x57B5E0 VA: 0x18057CBE0
	public void .ctor() { }
}
