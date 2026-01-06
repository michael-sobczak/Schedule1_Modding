public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel> // TypeDefIndex: 126
{
	// Fields
	private const string k_ShaderString = "Hidden/Post FX/Depth Of Field";
	private RenderTexture m_CoCHistory; // 0x20
	private const float k_FilmHeight = 0.024;

	// Properties
	public override bool active { get; }

	// Methods

	// RVA: 0x571690 Offset: 0x570090 VA: 0x180571690 Slot: 5
	public override bool get_active() { }

	// RVA: 0x570B50 Offset: 0x56F550 VA: 0x180570B50 Slot: 4
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x570950 Offset: 0x56F350 VA: 0x180570950
	private float CalculateFocalLength() { }

	// RVA: 0x5709F0 Offset: 0x56F3F0 VA: 0x1805709F0
	private float CalculateMaxCoCRadius(int screenHeight) { }

	// RVA: 0x570A70 Offset: 0x56F470 VA: 0x180570A70
	private bool CheckHistory(int width, int height) { }

	// RVA: 0x571600 Offset: 0x570000 VA: 0x180571600
	private RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary) { }

	// RVA: 0x570BE0 Offset: 0x56F5E0 VA: 0x180570BE0
	public void Prepare(RenderTexture source, Material uberMaterial, bool antialiasCoC, Vector2 taaJitter, float taaBlending) { }

	// RVA: 0x570B60 Offset: 0x56F560 VA: 0x180570B60 Slot: 7
	public override void OnDisable() { }

	// RVA: 0x571650 Offset: 0x570050 VA: 0x180571650
	public void .ctor() { }
}
