public static class RTHandles // TypeDefIndex: 13818
{
	// Fields
	private static RTHandleSystem s_DefaultInstance; // 0x0

	// Properties
	public static int maxWidth { get; }
	public static int maxHeight { get; }
	public static RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x2A2AE30 Offset: 0x2A29830 VA: 0x182A2AE30
	public static int get_maxWidth() { }

	// RVA: 0x2A2ADD0 Offset: 0x2A297D0 VA: 0x182A2ADD0
	public static int get_maxHeight() { }

	// RVA: 0x2A2AE90 Offset: 0x2A29890 VA: 0x182A2AE90
	public static RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x2A29CD0 Offset: 0x2A286D0 VA: 0x182A29CD0
	public static RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x2A2A590 Offset: 0x2A28F90 VA: 0x182A2A590
	public static RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x2A29A30 Offset: 0x2A28430 VA: 0x182A29A30
	public static RTHandle Alloc(in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x2A2A090 Offset: 0x2A28A90 VA: 0x182A2A090
	public static RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x2A29630 Offset: 0x2A28030 VA: 0x182A29630
	public static RTHandle Alloc(Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x2A29E60 Offset: 0x2A28860 VA: 0x182A29E60
	public static RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x2A2A210 Offset: 0x2A28C10 VA: 0x182A2A210
	public static RTHandle Alloc(ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x2A298D0 Offset: 0x2A282D0 VA: 0x182A298D0
	public static RTHandle Alloc(Texture tex) { }

	// RVA: 0x2A2A730 Offset: 0x2A29130 VA: 0x182A2A730
	public static RTHandle Alloc(RenderTexture tex) { }

	// RVA: 0x2A29FD0 Offset: 0x2A289D0 VA: 0x182A29FD0
	public static RTHandle Alloc(RenderTargetIdentifier tex) { }

	// RVA: 0x2A2A4F0 Offset: 0x2A28EF0 VA: 0x182A2A4F0
	public static RTHandle Alloc(RenderTargetIdentifier tex, string name) { }

	// RVA: 0x2A2A490 Offset: 0x2A28E90 VA: 0x182A2A490
	private static RTHandle Alloc(RTHandle tex) { }

	// RVA: 0x2A2A8C0 Offset: 0x2A292C0 VA: 0x182A2A8C0
	public static void Initialize(int width, int height) { }

	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
	// RVA: 0x2A2A940 Offset: 0x2A29340 VA: 0x182A2A940
	public static void Initialize(int width, int height, bool useLegacyDynamicResControl = False) { }

	// RVA: 0x2A2A9E0 Offset: 0x2A293E0 VA: 0x182A2A9E0
	public static void Release(RTHandle rth) { }

	// RVA: 0x2A2AAE0 Offset: 0x2A294E0 VA: 0x182A2AAE0
	public static void SetHardwareDynamicResolutionState(bool hwDynamicResRequested) { }

	// RVA: 0x2A2ACD0 Offset: 0x2A296D0 VA: 0x182A2ACD0
	public static void SetReferenceSize(int width, int height) { }

	// RVA: 0x2A2AA50 Offset: 0x2A29450 VA: 0x182A2AA50
	public static void ResetReferenceSize(int width, int height) { }

	// RVA: 0x2A2A830 Offset: 0x2A29230 VA: 0x182A2A830
	public static Vector2 CalculateRatioAgainstMaxSize(int width, int height) { }

	// RVA: 0x2A2AD50 Offset: 0x2A29750 VA: 0x182A2AD50
	private static void .cctor() { }
}
