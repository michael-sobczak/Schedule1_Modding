public static class CoreUtils // TypeDefIndex: 13855
{
	// Fields
	public static readonly Vector3[] lookAtList; // 0x0
	public static readonly Vector3[] upVectorList; // 0x8
	private const string obsoletePriorityMessage = "Use CoreUtils.Priorities instead";
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int editMenuPriority1 = 320;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int editMenuPriority2 = 331;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int editMenuPriority3 = 342;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int editMenuPriority4 = 353;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int assetCreateMenuPriority1 = 230;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int assetCreateMenuPriority2 = 241;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int assetCreateMenuPriority3 = 300;
	[Obsolete("Use CoreUtils.Priorities instead", False)]
	public const int gameObjectMenuPriority = 10;
	private static Cubemap m_BlackCubeTexture; // 0x10
	private static Cubemap m_MagentaCubeTexture; // 0x18
	private static CubemapArray m_MagentaCubeTextureArray; // 0x20
	private static Cubemap m_WhiteCubeTexture; // 0x28
	private static RenderTexture m_EmptyUAV; // 0x30
	private static Texture3D m_BlackVolumeTexture; // 0x38
	private static IEnumerable<Type> m_AssemblyTypes; // 0x40

	// Properties
	public static Cubemap blackCubeTexture { get; }
	public static Cubemap magentaCubeTexture { get; }
	public static CubemapArray magentaCubeTextureArray { get; }
	public static Cubemap whiteCubeTexture { get; }
	public static RenderTexture emptyUAV { get; }
	public static Texture3D blackVolumeTexture { get; }

	// Methods

	// RVA: 0x2A3F570 Offset: 0x2A3DF70 VA: 0x182A3F570
	public static Cubemap get_blackCubeTexture() { }

	// RVA: 0x2A3FCE0 Offset: 0x2A3E6E0 VA: 0x182A3FCE0
	public static Cubemap get_magentaCubeTexture() { }

	// RVA: 0x2A3FAB0 Offset: 0x2A3E4B0 VA: 0x182A3FAB0
	public static CubemapArray get_magentaCubeTextureArray() { }

	// RVA: 0x2A3FED0 Offset: 0x2A3E8D0 VA: 0x182A3FED0
	public static Cubemap get_whiteCubeTexture() { }

	// RVA: 0x2A3F930 Offset: 0x2A3E330 VA: 0x182A3F930
	public static RenderTexture get_emptyUAV() { }

	// RVA: 0x2A3F760 Offset: 0x2A3E160 VA: 0x182A3F760
	public static Texture3D get_blackVolumeTexture() { }

	// RVA: 0x2A3A470 Offset: 0x2A38E70 VA: 0x182A3A470
	public static void ClearRenderTarget(CommandBuffer cmd, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2A3B390 Offset: 0x2A39D90 VA: 0x182A3B390
	private static int FixupDepthSlice(int depthSlice, RTHandle buffer) { }

	// RVA: 0x2A3B380 Offset: 0x2A39D80 VA: 0x182A3B380
	private static int FixupDepthSlice(int depthSlice, CubemapFace cubemapFace) { }

	// RVA: 0x2A3CF30 Offset: 0x2A3B930 VA: 0x182A3CF30
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3D1B0 Offset: 0x2A3BBB0 VA: 0x182A3D1B0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3ED50 Offset: 0x2A3D750 VA: 0x182A3ED50
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3D040 Offset: 0x2A3BA40 VA: 0x182A3D040
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3E2B0 Offset: 0x2A3CCB0 VA: 0x182A3E2B0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3CE50 Offset: 0x2A3B850 VA: 0x182A3CE50
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer) { }

	// RVA: 0x2A3CD30 Offset: 0x2A3B730 VA: 0x182A3CD30
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag = 0) { }

	// RVA: 0x2A3E400 Offset: 0x2A3CE00 VA: 0x182A3E400
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2A3EE80 Offset: 0x2A3D880 VA: 0x182A3EE80
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2A3D3E0 Offset: 0x2A3BDE0 VA: 0x182A3D3E0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3C780 Offset: 0x2A3B180 VA: 0x182A3C780
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3E950 Offset: 0x2A3D350 VA: 0x182A3E950
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag) { }

	// RVA: 0x2A3EC10 Offset: 0x2A3D610 VA: 0x182A3EC10
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2A3C5D0 Offset: 0x2A3AFD0 VA: 0x182A3C5D0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3E500 Offset: 0x2A3CF00 VA: 0x182A3E500
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3D2E0 Offset: 0x2A3BCE0 VA: 0x182A3D2E0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier buffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2A3D900 Offset: 0x2A3C300 VA: 0x182A3D900
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag) { }

	// RVA: 0x2A3F180 Offset: 0x2A3DB80 VA: 0x182A3F180
	private static void SetViewportAndClear(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2A3E770 Offset: 0x2A3D170 VA: 0x182A3E770
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3EF70 Offset: 0x2A3D970 VA: 0x182A3EF70
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, ClearFlag clearFlag = 0, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3D730 Offset: 0x2A3C130 VA: 0x182A3D730
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3C3F0 Offset: 0x2A3ADF0 VA: 0x182A3C3F0
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3DA70 Offset: 0x2A3C470 VA: 0x182A3DA70
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3CAC0 Offset: 0x2A3B4C0 VA: 0x182A3CAC0
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle buffer, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3DE40 Offset: 0x2A3C840 VA: 0x182A3DE40
	public static void SetRenderTarget(CommandBuffer cmd, RTHandle colorBuffer, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RTHandle depthBuffer, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction, ClearFlag clearFlag, Color clearColor, int miplevel = 0, CubemapFace cubemapFace = -1, int depthSlice = -1) { }

	// RVA: 0x2A3C920 Offset: 0x2A3B320 VA: 0x182A3C920
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer) { }

	// RVA: 0x2A3D4F0 Offset: 0x2A3BEF0 VA: 0x182A3D4F0
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag = 0) { }

	// RVA: 0x2A3EA60 Offset: 0x2A3D460 VA: 0x182A3EA60
	public static void SetRenderTarget(CommandBuffer cmd, RenderTargetIdentifier[] colorBuffers, RTHandle depthBuffer, ClearFlag clearFlag, Color clearColor) { }

	// RVA: 0x2A3F2A0 Offset: 0x2A3DCA0 VA: 0x182A3F2A0
	public static void SetViewport(CommandBuffer cmd, RTHandle target) { }

	// RVA: 0x2A3BA20 Offset: 0x2A3A420 VA: 0x182A3BA20
	public static string GetRenderTargetAutoName(int width, int height, int depth, RenderTextureFormat format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1) { }

	// RVA: 0x2A3B930 Offset: 0x2A3A330 VA: 0x182A3B930
	public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1) { }

	// RVA: 0x2A3B600 Offset: 0x2A3A000 VA: 0x182A3B600
	public static string GetRenderTargetAutoName(int width, int height, int depth, GraphicsFormat format, TextureDimension dim, string name, bool mips = False, bool enableMSAA = False, MSAASamples msaaSamples = 1, bool dynamicRes = False) { }

	// RVA: 0x2A3B700 Offset: 0x2A3A100 VA: 0x182A3B700
	private static string GetRenderTargetAutoName(int width, int height, int depth, string format, TextureDimension dim, string name, bool mips, bool enableMSAA, MSAASamples msaaSamples, bool dynamicRes) { }

	// RVA: 0x2A3BBF0 Offset: 0x2A3A5F0 VA: 0x182A3BBF0
	public static string GetTextureAutoName(int width, int height, TextureFormat format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x2A3BB10 Offset: 0x2A3A510 VA: 0x182A3BB10
	public static string GetTextureAutoName(int width, int height, GraphicsFormat format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x2A3BCD0 Offset: 0x2A3A6D0 VA: 0x182A3BCD0
	private static string GetTextureAutoName(int width, int height, string format, TextureDimension dim = 0, string name = "", bool mips = False, int depth = 0) { }

	// RVA: 0x2A3A200 Offset: 0x2A38C00 VA: 0x182A3A200
	public static void ClearCubemap(CommandBuffer cmd, RenderTexture renderTexture, Color clearColor, bool clearMips = False) { }

	// RVA: 0x2A3AF80 Offset: 0x2A39980 VA: 0x182A3AF80
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x2A3B050 Offset: 0x2A39A50 VA: 0x182A3B050
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x2A3B160 Offset: 0x2A39B60 VA: 0x182A3B160
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier colorBuffer, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x2A3ACC0 Offset: 0x2A396C0 VA: 0x182A3ACC0
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, RenderTargetIdentifier depthStencilBuffer, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x2A3ADE0 Offset: 0x2A397E0 VA: 0x182A3ADE0
	public static void DrawFullScreen(CommandBuffer commandBuffer, Material material, RenderTargetIdentifier[] colorBuffers, MaterialPropertyBlock properties, int shaderPassId = 0) { }

	// RVA: 0x2A3A550 Offset: 0x2A38F50 VA: 0x182A3A550
	public static Color ConvertSRGBToActiveColorSpace(Color color) { }

	// RVA: 0x2A3A4B0 Offset: 0x2A38EB0 VA: 0x182A3A4B0
	public static Color ConvertLinearToActiveColorSpace(Color color) { }

	// RVA: 0x2A3AA30 Offset: 0x2A39430 VA: 0x182A3AA30
	public static Material CreateEngineMaterial(string shaderPath) { }

	// RVA: 0x2A3AB50 Offset: 0x2A39550 VA: 0x182A3AB50
	public static Material CreateEngineMaterial(Shader shader) { }

	// RVA: -1 Offset: -1
	public static bool HasFlag<T>(T mask, T flag) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E1C0 Offset: 0xE6CBC0 VA: 0x180E6E1C0
	|-CoreUtils.HasFlag<__Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE4B9E0 Offset: 0xE4A3E0 VA: 0x180E4B9E0
	|-CoreUtils.Swap<object>
	|
	|-RVA: 0xE4B840 Offset: 0xE4A240 VA: 0x180E4B840
	|-CoreUtils.Swap<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2A3C3C0 Offset: 0x2A3ADC0 VA: 0x182A3C3C0
	public static void SetKeyword(CommandBuffer cmd, string keyword, bool state) { }

	// RVA: 0x7BC520 Offset: 0x7BAF20 VA: 0x1807BC520
	public static void SetKeyword(Material material, string keyword, bool state) { }

	// RVA: 0x2A3C390 Offset: 0x2A3AD90 VA: 0x182A3C390
	public static void SetKeyword(ComputeShader cs, string keyword, bool state) { }

	// RVA: 0x2A3AC40 Offset: 0x2A39640 VA: 0x182A3AC40
	public static void Destroy(Object obj) { }

	// RVA: 0x2A3B3E0 Offset: 0x2A39DE0 VA: 0x182A3B3E0
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	// RVA: -1 Offset: -1
	public static IEnumerable<Type> GetAllTypesDerivedFrom<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6DD70 Offset: 0xE6C770 VA: 0x180E6DD70
	|-CoreUtils.GetAllTypesDerivedFrom<object>
	|-CoreUtils.GetAllTypesDerivedFrom<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2A3C380 Offset: 0x2A3AD80 VA: 0x182A3C380
	public static void SafeRelease(GraphicsBuffer buffer) { }

	// RVA: 0x2A3C370 Offset: 0x2A3AD70 VA: 0x182A3C370
	public static void SafeRelease(ComputeBuffer buffer) { }

	// RVA: 0x2A3A5F0 Offset: 0x2A38FF0 VA: 0x182A3A5F0
	public static Mesh CreateCubeMesh(Vector3 min, Vector3 max) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public static bool ArePostProcessesEnabled(Camera camera) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public static bool AreAnimatedMaterialsEnabled(Camera camera) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool IsSceneLightingDisabled(Camera camera) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool IsLightOverlapDebugEnabled(Camera camera) { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0
	public static bool IsSceneViewFogEnabled(Camera camera) { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool IsSceneFilteringEnabled() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0
	public static bool IsSceneViewPrefabStageContextHidden() { }

	// RVA: 0x2A3B2A0 Offset: 0x2A39CA0 VA: 0x182A3B2A0
	public static void DrawRendererList(ScriptableRenderContext renderContext, CommandBuffer cmd, RendererList rendererList) { }

	// RVA: 0x2A3C1C0 Offset: 0x2A3ABC0 VA: 0x182A3C1C0
	public static int GetTextureHash(Texture texture) { }

	// RVA: 0x2A3C340 Offset: 0x2A3AD40 VA: 0x182A3C340
	public static int PreviousPowerOfTwo(int size) { }

	// RVA: -1 Offset: -1
	public static T GetLastEnumValue<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE6E040 Offset: 0xE6CA40 VA: 0x180E6E040
	|-CoreUtils.GetLastEnumValue<Int32Enum>
	|
	|-RVA: 0xE6DF20 Offset: 0xE6C920 VA: 0x180E6DF20
	|-CoreUtils.GetLastEnumValue<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0x2A3B5D0 Offset: 0x2A39FD0 VA: 0x182A3B5D0
	internal static string GetCorePath() { }

	// RVA: 0x2A3F340 Offset: 0x2A3DD40 VA: 0x182A3F340
	private static void .cctor() { }
}
