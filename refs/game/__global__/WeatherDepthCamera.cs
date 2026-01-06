public class WeatherDepthCamera : MonoBehaviour // TypeDefIndex: 491
{
	// Fields
	private Camera m_DepthCamera; // 0x20
	[Tooltip("Shader used to render out depth + normal texture. This should be the sky studio depth shader.")]
	public Shader depthShader; // 0x28
	[HideInInspector]
	public RenderTexture overheadDepthTexture; // 0x30
	[Tooltip("You can help increase performance by only rendering periodically some number of frames.")]
	[Range(1, 60)]
	public int renderFrameInterval; // 0x38
	[Tooltip("The resolution of the texture. Higher resolution uses more rendering time but makes more precise weather along edges.")]
	[Range(128, 8192)]
	public int textureResolution; // 0x3C

	// Methods

	// RVA: 0xA94340 Offset: 0xA92D40 VA: 0x180A94340
	private void Start() { }

	// RVA: 0xA943B0 Offset: 0xA92DB0 VA: 0x180A943B0
	private void Update() { }

	// RVA: 0xA94110 Offset: 0xA92B10 VA: 0x180A94110
	private void RenderOverheadCamera() { }

	// RVA: 0xA93F10 Offset: 0xA92910 VA: 0x180A93F10
	private void PrepareRenderTexture() { }

	// RVA: 0xA94410 Offset: 0xA92E10 VA: 0x180A94410
	public void .ctor() { }
}
