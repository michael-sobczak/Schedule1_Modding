public struct TextureDesc // TypeDefIndex: 13549
{
	// Fields
	public TextureSizeMode sizeMode; // 0x0
	public int width; // 0x4
	public int height; // 0x8
	public int slices; // 0xC
	public Vector2 scale; // 0x10
	public ScaleFunc func; // 0x18
	public DepthBits depthBufferBits; // 0x20
	public GraphicsFormat colorFormat; // 0x24
	public FilterMode filterMode; // 0x28
	public TextureWrapMode wrapMode; // 0x2C
	public TextureDimension dimension; // 0x30
	public bool enableRandomWrite; // 0x34
	public bool useMipMap; // 0x35
	public bool autoGenerateMips; // 0x36
	public bool isShadowMap; // 0x37
	public int anisoLevel; // 0x38
	public float mipMapBias; // 0x3C
	public MSAASamples msaaSamples; // 0x40
	public bool bindTextureMS; // 0x44
	public bool useDynamicScale; // 0x45
	public RenderTextureMemoryless memoryless; // 0x48
	public VRTextureUsage vrUsage; // 0x4C
	public string name; // 0x50
	public FastMemoryDesc fastMemoryDesc; // 0x58
	public bool fallBackToBlackTexture; // 0x64
	public bool disableFallBackToImportedTexture; // 0x65
	public bool clearBuffer; // 0x66
	public Color clearColor; // 0x68

	// Methods

	// RVA: 0x29F76B0 Offset: 0x29F60B0 VA: 0x1829F76B0
	private void InitDefaultValues(bool dynamicResolution, bool xrReady) { }

	// RVA: 0x29F78D0 Offset: 0x29F62D0 VA: 0x1829F78D0
	public void .ctor(int width, int height, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x29F7870 Offset: 0x29F6270 VA: 0x1829F7870
	public void .ctor(Vector2 scale, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x29F7790 Offset: 0x29F6190 VA: 0x1829F7790
	public void .ctor(ScaleFunc func, bool dynamicResolution = False, bool xrReady = False) { }

	// RVA: 0x29F7820 Offset: 0x29F6220 VA: 0x1829F7820
	public void .ctor(TextureDesc input) { }

	// RVA: 0x29F74C0 Offset: 0x29F5EC0 VA: 0x1829F74C0 Slot: 2
	public override int GetHashCode() { }
}
