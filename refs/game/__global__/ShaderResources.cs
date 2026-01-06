public class ShaderResources // TypeDefIndex: 18246
{
	// Fields
	private const int _perlinNoiseResolution = 2048;
	private const float _perlinNoiseScale = 256;
	private const float _perlinNoiseWhiteBalance = 1.2;
	[SerializeField]
	private Texture2D _perlinNoise; // 0x10

	// Properties
	public Texture2D PerlinNoise { get; }

	// Methods

	// RVA: 0x2F69590 Offset: 0x2F67F90 VA: 0x182F69590
	public Texture2D get_PerlinNoise() { }

	// RVA: 0x2F69510 Offset: 0x2F67F10 VA: 0x182F69510
	public void SetFloatingOrigin(double x, double z) { }

	// RVA: 0x2F69440 Offset: 0x2F67E40 VA: 0x182F69440
	internal void Initialize() { }

	// RVA: 0x2F690D0 Offset: 0x2F67AD0 VA: 0x182F690D0
	internal void Destroy() { }

	// RVA: 0x2F69160 Offset: 0x2F67B60 VA: 0x182F69160
	private Texture2D GeneratePerlinNoiseTexture() { }

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	public void .ctor() { }
}
