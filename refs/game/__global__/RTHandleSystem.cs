public class RTHandleSystem : IDisposable // TypeDefIndex: 13822
{
	// Fields
	private bool m_HardwareDynamicResRequested; // 0x10
	private HashSet<RTHandle> m_AutoSizedRTs; // 0x18
	private RTHandle[] m_AutoSizedRTsArray; // 0x20
	private HashSet<RTHandle> m_ResizeOnDemandRTs; // 0x28
	private RTHandleProperties m_RTHandleProperties; // 0x30
	private int m_MaxWidths; // 0x60
	private int m_MaxHeights; // 0x64

	// Properties
	public RTHandleProperties rtHandleProperties { get; }

	// Methods

	// RVA: 0x2A28E60 Offset: 0x2A27860 VA: 0x182A28E60
	public RTHandleProperties get_rtHandleProperties() { }

	// RVA: 0x2A28DA0 Offset: 0x2A277A0 VA: 0x182A28DA0
	public void .ctor() { }

	// RVA: 0x2A27CC0 Offset: 0x2A266C0 VA: 0x182A27CC0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2A280D0 Offset: 0x2A26AD0 VA: 0x182A280D0
	public void Initialize(int width, int height) { }

	[Obsolete("useLegacyDynamicResControl is deprecated. Please use SetHardwareDynamicResolutionState() instead.")]
	// RVA: 0x2A280A0 Offset: 0x2A26AA0 VA: 0x182A280A0
	public void Initialize(int width, int height, bool useLegacyDynamicResControl = False) { }

	// RVA: 0x2A28350 Offset: 0x2A26D50 VA: 0x182A28350
	public void Release(RTHandle rth) { }

	// RVA: 0x2A28450 Offset: 0x2A26E50 VA: 0x182A28450
	internal void Remove(RTHandle rth) { }

	// RVA: 0x2A284B0 Offset: 0x2A26EB0 VA: 0x182A284B0
	public void ResetReferenceSize(int width, int height) { }

	// RVA: 0x2A28C80 Offset: 0x2A27680 VA: 0x182A28C80
	public void SetReferenceSize(int width, int height) { }

	// RVA: 0x2A28A80 Offset: 0x2A27480 VA: 0x182A28A80
	public void SetReferenceSize(int width, int height, bool reset) { }

	// RVA: 0x2A275F0 Offset: 0x2A25FF0 VA: 0x182A275F0
	internal Vector2 CalculateRatioAgainstMaxSize(in Vector2Int viewportSize) { }

	// RVA: 0x2A288D0 Offset: 0x2A272D0 VA: 0x182A288D0
	public void SetHardwareDynamicResolutionState(bool enableHWDynamicRes) { }

	// RVA: 0x2A28CA0 Offset: 0x2A276A0 VA: 0x182A28CA0
	internal void SwitchResizeMode(RTHandle rth, RTHandleSystem.ResizeMode mode) { }

	// RVA: 0x2A27820 Offset: 0x2A26220 VA: 0x182A27820
	private void DemandResize(RTHandle rth) { }

	// RVA: 0x4E2410 Offset: 0x4E0E10 VA: 0x1804E2410
	public int GetMaxWidth() { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	public int GetMaxHeight() { }

	// RVA: 0x2A27AD0 Offset: 0x2A264D0 VA: 0x182A27AD0
	private void Dispose(bool disposing) { }

	// RVA: 0x2A284E0 Offset: 0x2A26EE0 VA: 0x182A284E0
	private void Resize(int width, int height, bool sizeChanged) { }

	// RVA: 0x2A272D0 Offset: 0x2A25CD0 VA: 0x182A272D0
	public RTHandle Alloc(int width, int height, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x2A268E0 Offset: 0x2A252E0 VA: 0x182A268E0
	public RTHandle Alloc(int width, int height, TextureWrapMode wrapModeU, TextureWrapMode wrapModeV, TextureWrapMode wrapModeW = 0, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x2A27430 Offset: 0x2A25E30 VA: 0x182A27430
	public RTHandle Alloc(Vector2 scaleFactor, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x2A27100 Offset: 0x2A25B00 VA: 0x182A27100
	public RTHandle Alloc(ScaleFunc scaleFunc, int slices = 1, DepthBits depthBufferBits = 0, GraphicsFormat colorFormat = 4, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, TextureDimension dimension = 2, bool enableRandomWrite = False, bool useMipMap = False, bool autoGenerateMips = True, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, MSAASamples msaaSamples = 1, bool bindTextureMS = False, bool useDynamicScale = False, RenderTextureMemoryless memoryless = 0, VRTextureUsage vrUsage = 0, string name = "") { }

	// RVA: 0x2A26220 Offset: 0x2A24C20 VA: 0x182A26220
	private RTHandle AllocAutoSizedRenderTexture(int width, int height, int slices, DepthBits depthBufferBits, GraphicsFormat colorFormat, FilterMode filterMode, TextureWrapMode wrapMode, TextureDimension dimension, bool enableRandomWrite, bool useMipMap, bool autoGenerateMips, bool isShadowMap, int anisoLevel, float mipMapBias, MSAASamples msaaSamples, bool bindTextureMS, bool useDynamicScale, RenderTextureMemoryless memoryless, VRTextureUsage vrUsage, string name) { }

	// RVA: 0x2A26820 Offset: 0x2A25220 VA: 0x182A26820
	public RTHandle Alloc(RenderTexture texture) { }

	// RVA: 0x2A26F10 Offset: 0x2A25910 VA: 0x182A26F10
	public RTHandle Alloc(Texture texture) { }

	// RVA: 0x2A26EA0 Offset: 0x2A258A0 VA: 0x182A26EA0
	public RTHandle Alloc(RenderTargetIdentifier texture) { }

	// RVA: 0x2A27020 Offset: 0x2A25A20 VA: 0x182A27020
	public RTHandle Alloc(RenderTargetIdentifier texture, string name) { }

	// RVA: 0x2A273D0 Offset: 0x2A25DD0 VA: 0x182A273D0
	private static RTHandle Alloc(RTHandle tex) { }

	// RVA: 0x2A27CD0 Offset: 0x2A266D0 VA: 0x182A27CD0
	internal string DumpRTInfo() { }
}
