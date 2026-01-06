public class LUTBlending : MonoBehaviour // TypeDefIndex: 507
{
	// Fields
	public Texture2D LUT1; // 0x20
	public Texture2D LUT2; // 0x28
	[Range(0, 1)]
	public float LUT1Intensity; // 0x30
	[Range(0, 1)]
	public float LUT2Intensity; // 0x34
	[Range(0, 1)]
	public float phase; // 0x38
	public Shader lerpShader; // 0x40
	private float oldPhase; // 0x48
	private RenderTexture rt; // 0x50
	private Material lerpMat; // 0x58

	// Methods

	// RVA: 0xA87140 Offset: 0xA85B40 VA: 0x180A87140
	private void OnEnable() { }

	// RVA: 0xA871D0 Offset: 0xA85BD0 VA: 0x180A871D0
	private void OnValidate() { }

	// RVA: 0xA87150 Offset: 0xA85B50 VA: 0x180A87150
	private void OnDestroy() { }

	// RVA: 0xA87140 Offset: 0xA85B40 VA: 0x180A87140
	private void LateUpdate() { }

	// RVA: 0xA871E0 Offset: 0xA85BE0 VA: 0x180A871E0
	private void UpdateBeautifyLUT() { }

	// RVA: 0xA875E0 Offset: 0xA85FE0 VA: 0x180A875E0
	public void .ctor() { }
}
