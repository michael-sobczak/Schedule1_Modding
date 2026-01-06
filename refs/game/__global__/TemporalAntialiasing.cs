public sealed class TemporalAntialiasing // TypeDefIndex: 17004
{
	// Fields
	[Range(0.1, 1)]
	[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
	public float jitterSpread; // 0x10
	[Range(0, 3)]
	[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
	public float sharpness; // 0x14
	[Range(0, 0.99)]
	[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
	public float stationaryBlending; // 0x18
	[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
	[Range(0, 0.99)]
	public float motionBlending; // 0x1C
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc; // 0x20
	[CompilerGenerated]
	private Vector2 <jitter>k__BackingField; // 0x28
	private readonly RenderTargetIdentifier[] m_Mrt; // 0x30
	private bool m_ResetHistory; // 0x38
	private const int k_SampleCount = 8;
	[CompilerGenerated]
	private int <sampleIndex>k__BackingField; // 0x3C
	private const int k_NumEyes = 2;
	private const int k_NumHistoryTextures = 2;
	private readonly RenderTexture[][] m_HistoryTextures; // 0x40
	private readonly int[] m_HistoryPingPong; // 0x48

	// Properties
	public Vector2 jitter { get; set; }
	public int sampleIndex { get; set; }

	// Methods

	[CompilerGenerated]
	// RVA: 0xC241F0 Offset: 0xC22BF0 VA: 0x180C241F0
	public Vector2 get_jitter() { }

	[CompilerGenerated]
	// RVA: 0x5E0880 Offset: 0x5DF280 VA: 0x1805E0880
	private void set_jitter(Vector2 value) { }

	[CompilerGenerated]
	// RVA: 0xC21BD0 Offset: 0xC205D0 VA: 0x180C21BD0
	public int get_sampleIndex() { }

	[CompilerGenerated]
	// RVA: 0xC21CD0 Offset: 0xC206D0 VA: 0x180C21CD0
	private void set_sampleIndex(int value) { }

	// RVA: 0x29A8B60 Offset: 0x29A7560 VA: 0x1829A8B60
	public bool IsSupported() { }

	// RVA: 0x578D60 Offset: 0x577760 VA: 0x180578D60
	internal DepthTextureMode GetCameraFlags() { }

	// RVA: 0x867D60 Offset: 0x866760 VA: 0x180867D60
	internal void ResetHistory() { }

	// RVA: 0x29A88B0 Offset: 0x29A72B0 VA: 0x1829A88B0
	private Vector2 GenerateRandomOffset() { }

	// RVA: 0x29A8950 Offset: 0x29A7350 VA: 0x1829A8950
	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	// RVA: 0x29A8320 Offset: 0x29A6D20 VA: 0x1829A8320
	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	// RVA: 0x29A8580 Offset: 0x29A6F80 VA: 0x1829A8580
	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	// RVA: 0x29A87D0 Offset: 0x29A71D0 VA: 0x1829A87D0
	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	// RVA: 0x29A7DB0 Offset: 0x29A67B0 VA: 0x1829A7DB0
	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	// RVA: 0x29A8D20 Offset: 0x29A7720 VA: 0x1829A8D20
	internal void Render(PostProcessRenderContext context) { }

	// RVA: 0x29A8BA0 Offset: 0x29A75A0 VA: 0x1829A8BA0
	internal void Release() { }

	// RVA: 0x29A91A0 Offset: 0x29A7BA0 VA: 0x1829A91A0
	public void .ctor() { }
}
