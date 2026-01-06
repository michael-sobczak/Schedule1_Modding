public static class RenderingUtils // TypeDefIndex: 9004
{
	// Fields
	private static List<ShaderTagId> m_LegacyShaderPassNames; // 0x0
	private static AttachmentDescriptor s_EmptyAttachment; // 0x8
	private static Mesh s_FullscreenMesh; // 0x80
	private static Material s_ErrorMaterial; // 0x88
	private static Dictionary<RenderTextureFormat, bool> m_RenderTextureFormatSupport; // 0x90
	private static Dictionary<GraphicsFormat, Dictionary<FormatUsage, bool>> m_GraphicsFormatSupport; // 0x98

	// Properties
	internal static AttachmentDescriptor emptyAttachment { get; }
	[Obsolete("Use Blitter.BlitCameraTexture instead of CommandBuffer.DrawMesh(fullscreenMesh, ...)")]
	public static Mesh fullscreenMesh { get; }
	internal static bool useStructuredBuffer { get; }
	private static Material errorMaterial { get; }

	// Methods

	// RVA: 0x2B21BC0 Offset: 0x2B205C0 VA: 0x182B21BC0
	internal static AttachmentDescriptor get_emptyAttachment() { }

	// RVA: 0x2B21DB0 Offset: 0x2B207B0 VA: 0x182B21DB0
	public static Mesh get_fullscreenMesh() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	internal static bool get_useStructuredBuffer() { }

	// RVA: 0x2B21590 Offset: 0x2B1FF90 VA: 0x182B21590
	internal static bool SupportsLightLayers(GraphicsDeviceType type) { }

	// RVA: 0x2B21C60 Offset: 0x2B20660 VA: 0x182B21C60
	private static Material get_errorMaterial() { }

	// RVA: 0x2B20FB0 Offset: 0x2B1F9B0 VA: 0x182B20FB0
	public static void SetViewAndProjectionMatrices(CommandBuffer cmd, Matrix4x4 viewMatrix, Matrix4x4 projectionMatrix, bool setInverseMatrices) { }

	// RVA: 0x2B20CF0 Offset: 0x2B1F6F0 VA: 0x182B20CF0
	internal static void SetScaleBiasRt(CommandBuffer cmd, in RenderingData renderingData) { }

	// RVA: 0x2B1D6F0 Offset: 0x2B1C0F0 VA: 0x182B1D6F0
	internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0) { }

	// RVA: 0x2B1D8F0 Offset: 0x2B1C2F0 VA: 0x182B1D8F0
	internal static void Blit(CommandBuffer cmd, RTHandle source, Rect viewport, RTHandle destinationColor, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle destinationDepthStencil, RenderBufferLoadAction depthStencilLoadAction, RenderBufferStoreAction depthStencilStoreAction, ClearFlag clearFlag, Color clearColor, Material material, int passIndex = 0) { }

	// RVA: 0x2B1E390 Offset: 0x2B1CD90 VA: 0x182B1E390
	internal static void FinalBlit(CommandBuffer cmd, ref CameraData cameraData, RTHandle source, RTHandle destination, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, Material material, int passIndex) { }

	[Conditional("UNITY_EDITOR")]
	[Conditional("DEVELOPMENT_BUILD")]
	// RVA: 0x2B206E0 Offset: 0x2B1F0E0 VA: 0x182B206E0
	internal static void RenderObjectsWithError(ScriptableRenderContext context, ref CullingResults cullResults, Camera camera, FilteringSettings filterSettings, SortingCriteria sortFlags) { }

	// RVA: 0x2B1DB30 Offset: 0x2B1C530 VA: 0x182B1DB30
	internal static void ClearSystemInfoCache() { }

	// RVA: 0x2B215A0 Offset: 0x2B1FFA0 VA: 0x182B215A0
	public static bool SupportsRenderTextureFormat(RenderTextureFormat format) { }

	// RVA: 0x2B213A0 Offset: 0x2B1FDA0 VA: 0x182B213A0
	public static bool SupportsGraphicsFormat(GraphicsFormat format, FormatUsage usage) { }

	// RVA: 0x2B1EAE0 Offset: 0x2B1D4E0 VA: 0x182B1EAE0
	internal static int GetLastValidColorBufferIndex(RenderTargetIdentifier[] colorBuffers) { }

	[Obsolete("Use RTHandles for colorBuffers")]
	// RVA: 0x2B1ED10 Offset: 0x2B1D710 VA: 0x182B1ED10
	internal static uint GetValidColorBufferCount(RenderTargetIdentifier[] colorBuffers) { }

	// RVA: 0x2B1EC00 Offset: 0x2B1D600 VA: 0x182B1EC00
	internal static uint GetValidColorBufferCount(RTHandle[] colorBuffers) { }

	[Obsolete("Use RTHandles for colorBuffers")]
	// RVA: 0x2B1EEE0 Offset: 0x2B1D8E0 VA: 0x182B1EEE0
	internal static bool IsMRT(RenderTargetIdentifier[] colorBuffers) { }

	// RVA: 0x2B1F020 Offset: 0x2B1DA20 VA: 0x182B1F020
	internal static bool IsMRT(RTHandle[] colorBuffers) { }

	// RVA: 0x2B1DBE0 Offset: 0x2B1C5E0 VA: 0x182B1DBE0
	internal static bool Contains(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	// RVA: 0x2B1EE10 Offset: 0x2B1D810 VA: 0x182B1EE10
	internal static int IndexOf(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	// RVA: 0x2B1DCB0 Offset: 0x2B1C6B0 VA: 0x182B1DCB0
	internal static uint CountDistinct(RenderTargetIdentifier[] source, RenderTargetIdentifier value) { }

	// RVA: 0x2B1F170 Offset: 0x2B1DB70 VA: 0x182B1F170
	internal static int LastValid(RenderTargetIdentifier[] source) { }

	// RVA: 0xD4A560 Offset: 0xD48F60 VA: 0x180D4A560
	internal static bool Contains(ClearFlag a, ClearFlag b) { }

	// RVA: 0x2B20AE0 Offset: 0x2B1F4E0 VA: 0x182B20AE0
	internal static bool SequenceEqual(RenderTargetIdentifier[] left, RenderTargetIdentifier[] right) { }

	// RVA: 0x2B1F290 Offset: 0x2B1DC90 VA: 0x182B1F290
	internal static bool MultisampleDepthResolveSupported() { }

	// RVA: 0x2B1F310 Offset: 0x2B1DD10 VA: 0x182B1F310
	internal static bool RTHandleNeedsReAlloc(RTHandle handle, in TextureDesc descriptor, bool scaled) { }

	// RVA: 0x2B1E930 Offset: 0x2B1D330 VA: 0x182B1E930
	internal static RenderTargetIdentifier GetCameraTargetIdentifier(ref RenderingData renderingData) { }

	// RVA: 0x2B1FD00 Offset: 0x2B1E700 VA: 0x182B1FD00
	public static bool ReAllocateIfNeeded(ref RTHandle handle, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x2B201B0 Offset: 0x2B1EBB0 VA: 0x182B201B0
	public static bool ReAllocateIfNeeded(ref RTHandle handle, Vector2 scaleFactor, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x2B1F7B0 Offset: 0x2B1E1B0 VA: 0x182B1F7B0
	public static bool ReAllocateIfNeeded(ref RTHandle handle, ScaleFunc scaleFunc, in RenderTextureDescriptor descriptor, FilterMode filterMode = 0, TextureWrapMode wrapMode = 0, bool isShadowMap = False, int anisoLevel = 1, float mipMapBias = 0, string name = "") { }

	// RVA: 0x2B20BE0 Offset: 0x2B1F5E0 VA: 0x182B20BE0
	public static bool SetMaxRTHandlePoolCapacity(int capacity) { }

	// RVA: 0x2B1D620 Offset: 0x2B1C020 VA: 0x182B1D620
	internal static void AddStaleResourceToPoolOrRelease(TextureDesc desc, RTHandle handle) { }

	// RVA: 0x2B1E180 Offset: 0x2B1CB80 VA: 0x182B1E180
	public static DrawingSettings CreateDrawingSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	// RVA: 0x2B1DE20 Offset: 0x2B1C820 VA: 0x182B1DE20
	public static DrawingSettings CreateDrawingSettings(List<ShaderTagId> shaderTagIdList, ref RenderingData renderingData, SortingCriteria sortingCriteria) { }

	// RVA: 0x2B216A0 Offset: 0x2B200A0 VA: 0x182B216A0
	private static void .cctor() { }
}
