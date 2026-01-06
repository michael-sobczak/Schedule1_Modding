public static class RuntimeUtilities // TypeDefIndex: 17073
{
	// Fields
	private static Texture2D m_WhiteTexture; // 0x0
	private static Texture3D m_WhiteTexture3D; // 0x8
	private static Texture2D m_BlackTexture; // 0x10
	private static Texture3D m_BlackTexture3D; // 0x18
	private static Texture2D m_TransparentTexture; // 0x20
	private static Texture3D m_TransparentTexture3D; // 0x28
	private static Dictionary<int, Texture2D> m_LutStrips; // 0x30
	private static PostProcessResources s_Resources; // 0x38
	private static Mesh s_FullscreenTriangle; // 0x40
	private static Material s_CopyStdMaterial; // 0x48
	private static Material s_CopyStdFromDoubleWideMaterial; // 0x50
	private static Material s_CopyMaterial; // 0x58
	private static Material s_CopyFromTexArrayMaterial; // 0x60
	private static PropertySheet s_CopySheet; // 0x68
	private static PropertySheet s_CopyFromTexArraySheet; // 0x70
	private static IEnumerable<Type> m_AssemblyTypes; // 0x78

	// Properties
	public static Texture2D whiteTexture { get; }
	public static Texture3D whiteTexture3D { get; }
	public static Texture2D blackTexture { get; }
	public static Texture3D blackTexture3D { get; }
	public static Texture2D transparentTexture { get; }
	public static Texture3D transparentTexture3D { get; }
	public static Mesh fullscreenTriangle { get; }
	public static Material copyStdMaterial { get; }
	public static Material copyStdFromDoubleWideMaterial { get; }
	public static Material copyMaterial { get; }
	public static Material copyFromTexArrayMaterial { get; }
	public static PropertySheet copySheet { get; }
	public static PropertySheet copyFromTexArraySheet { get; }
	public static bool scriptableRenderPipelineActive { get; }
	public static bool supportsDeferredShading { get; }
	public static bool supportsDepthNormals { get; }
	public static bool isSinglePassStereoEnabled { get; }
	public static bool isVREnabled { get; }
	public static bool isAndroidOpenGL { get; }
	public static bool isWebNonWebGPU { get; }
	public static RenderTextureFormat defaultHDRRenderTextureFormat { get; }
	public static bool isLinearColorSpace { get; }

	// Methods

	// RVA: 0x29BFA20 Offset: 0x29BE420 VA: 0x1829BFA20
	public static Texture2D get_whiteTexture() { }

	// RVA: 0x29BF830 Offset: 0x29BE230 VA: 0x1829BF830
	public static Texture3D get_whiteTexture3D() { }

	// RVA: 0x29BE1B0 Offset: 0x29BCBB0 VA: 0x1829BE1B0
	public static Texture2D get_blackTexture() { }

	// RVA: 0x29BDFC0 Offset: 0x29BC9C0 VA: 0x1829BDFC0
	public static Texture3D get_blackTexture3D() { }

	// RVA: 0x29BF670 Offset: 0x29BE070 VA: 0x1829BF670
	public static Texture2D get_transparentTexture() { }

	// RVA: 0x29BF490 Offset: 0x29BDE90 VA: 0x1829BF490
	public static Texture3D get_transparentTexture3D() { }

	// RVA: 0x29BD660 Offset: 0x29BC060 VA: 0x1829BD660
	public static Texture2D GetLutStrip(int size) { }

	// RVA: 0x29BEDC0 Offset: 0x29BD7C0 VA: 0x1829BEDC0
	public static Mesh get_fullscreenTriangle() { }

	// RVA: 0x29BEC10 Offset: 0x29BD610 VA: 0x1829BEC10
	public static Material get_copyStdMaterial() { }

	// RVA: 0x29BEA60 Offset: 0x29BD460 VA: 0x1829BEA60
	public static Material get_copyStdFromDoubleWideMaterial() { }

	// RVA: 0x29BE7A0 Offset: 0x29BD1A0 VA: 0x1829BE7A0
	public static Material get_copyMaterial() { }

	// RVA: 0x29BE370 Offset: 0x29BCD70 VA: 0x1829BE370
	public static Material get_copyFromTexArrayMaterial() { }

	// RVA: 0x29BE950 Offset: 0x29BD350 VA: 0x1829BE950
	public static PropertySheet get_copySheet() { }

	// RVA: 0x29BE520 Offset: 0x29BCF20 VA: 0x1829BE520
	public static PropertySheet get_copyFromTexArraySheet() { }

	// RVA: 0x29BFC60 Offset: 0x29BE660 VA: 0x1829BFC60
	internal static bool isValidResources() { }

	// RVA: 0x29BDD50 Offset: 0x29BC750 VA: 0x1829BDD50
	internal static void UpdateResources(PostProcessResources resources) { }

	[Extension]
	// RVA: 0x29BDD00 Offset: 0x29BC700 VA: 0x1829BDD00
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction) { }

	[Extension]
	// RVA: 0x29BDC10 Offset: 0x29BC610 VA: 0x1829BDC10
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier rt, RenderBufferLoadAction loadAction, RenderBufferStoreAction storeAction, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Extension]
	// RVA: 0x29BDC70 Offset: 0x29BC670 VA: 0x1829BDC70
	public static void SetRenderTargetWithLoadStoreAction(CommandBuffer cmd, RenderTargetIdentifier color, RenderBufferLoadAction colorLoadAction, RenderBufferStoreAction colorStoreAction, RenderTargetIdentifier depth, RenderBufferLoadAction depthLoadAction, RenderBufferStoreAction depthStoreAction) { }

	[Extension]
	// RVA: 0x29BC610 Offset: 0x29BB010 VA: 0x1829BC610
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, bool clear = False, Nullable<Rect> viewport, bool preserveDepth = False) { }

	[Extension]
	// RVA: 0x29BBD20 Offset: 0x29BA720 VA: 0x1829BBD20
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, RenderBufferLoadAction loadAction, Nullable<Rect> viewport, bool preserveDepth = False) { }

	[Extension]
	// RVA: 0x29BC2B0 Offset: 0x29BACB0 VA: 0x1829BC2B0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport, bool preserveDepth = False) { }

	[Extension]
	// RVA: 0x29BB510 Offset: 0x29B9F10 VA: 0x1829BB510
	public static void BlitFullscreenTriangleFromDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material material, int pass, int eye) { }

	[Extension]
	// RVA: 0x29BB8F0 Offset: 0x29BA2F0 VA: 0x1829BB8F0
	public static void BlitFullscreenTriangleToDoubleWide(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, int eye) { }

	[Extension]
	// RVA: 0x29BB6D0 Offset: 0x29BA0D0 VA: 0x1829BB6D0
	public static void BlitFullscreenTriangleFromTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[Extension]
	// RVA: 0x29BBB10 Offset: 0x29BA510 VA: 0x1829BBB10
	public static void BlitFullscreenTriangleToTexArray(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, PropertySheet propertySheet, int pass, bool clear = False, int depthSlice = -1) { }

	[Extension]
	// RVA: 0x29BBFC0 Offset: 0x29BA9C0 VA: 0x1829BBFC0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[Extension]
	// RVA: 0x29BC3E0 Offset: 0x29BADE0 VA: 0x1829BC3E0
	public static void BlitFullscreenTriangle(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier[] destinations, RenderTargetIdentifier depth, PropertySheet propertySheet, int pass, bool clear = False, Nullable<Rect> viewport) { }

	[Extension]
	// RVA: 0x29BC9C0 Offset: 0x29BB3C0 VA: 0x1829BC9C0
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	[Extension]
	// RVA: 0x29BC8D0 Offset: 0x29BB2D0 VA: 0x1829BC8D0
	public static void BuiltinBlit(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination, Material mat, int pass = 0) { }

	// RVA: 0x29BCA90 Offset: 0x29BB490 VA: 0x1829BCA90
	public static void CopyTexture(CommandBuffer cmd, RenderTargetIdentifier source, RenderTargetIdentifier destination) { }

	// RVA: 0x29BF2E0 Offset: 0x29BDCE0 VA: 0x1829BF2E0
	public static bool get_scriptableRenderPipelineActive() { }

	// RVA: 0x29BF340 Offset: 0x29BDD40 VA: 0x1829BF340
	public static bool get_supportsDeferredShading() { }

	// RVA: 0x29BF3E0 Offset: 0x29BDDE0 VA: 0x1829BF3E0
	public static bool get_supportsDepthNormals() { }

	// RVA: 0x29BF250 Offset: 0x29BDC50 VA: 0x1829BF250
	public static bool get_isSinglePassStereoEnabled() { }

	// RVA: 0x29BF280 Offset: 0x29BDC80 VA: 0x1829BF280
	public static bool get_isVREnabled() { }

	// RVA: 0x29BF1F0 Offset: 0x29BDBF0 VA: 0x1829BF1F0
	public static bool get_isAndroidOpenGL() { }

	// RVA: 0x29BF290 Offset: 0x29BDC90 VA: 0x1829BF290
	public static bool get_isWebNonWebGPU() { }

	// RVA: 0x57A490 Offset: 0x578E90 VA: 0x18057A490
	public static RenderTextureFormat get_defaultHDRRenderTextureFormat() { }

	// RVA: 0x29BFC40 Offset: 0x29BE640 VA: 0x1829BFC40
	public static bool isFloatingPointFormat(RenderTextureFormat format) { }

	// RVA: 0x29BFBE0 Offset: 0x29BE5E0 VA: 0x1829BFBE0
	internal static bool hasAlpha(RenderTextureFormat format) { }

	// RVA: 0x29BCF20 Offset: 0x29BB920 VA: 0x1829BCF20
	public static void Destroy(Object obj) { }

	// RVA: 0x699ED0 Offset: 0x6988D0 VA: 0x180699ED0
	public static bool get_isLinearColorSpace() { }

	// RVA: 0x29BDAE0 Offset: 0x29BC4E0 VA: 0x1829BDAE0
	public static bool IsResolvedDepthAvailable(Camera camera) { }

	// RVA: 0x29BCC00 Offset: 0x29BB600 VA: 0x1829BCC00
	public static void DestroyProfile(PostProcessProfile profile, bool destroyEffects) { }

	// RVA: 0x29BCE40 Offset: 0x29BB840 VA: 0x1829BCE40
	public static void DestroyVolume(PostProcessVolume volume, bool destroyProfile, bool destroyGameObject = False) { }

	// RVA: 0x29BDA70 Offset: 0x29BC470 VA: 0x1829BDA70
	public static bool IsPostProcessingActive(PostProcessLayer layer) { }

	// RVA: 0x29BDB50 Offset: 0x29BC550 VA: 0x1829BDB50
	public static bool IsTemporalAntialiasingActive(PostProcessLayer layer) { }

	// RVA: 0x29BD9C0 Offset: 0x29BC3C0 VA: 0x1829BD9C0
	public static bool IsDynamicResolutionEnabled(Camera camera) { }

	[IteratorStateMachine(typeof(RuntimeUtilities.<GetAllSceneObjects>d__86<T>))]
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetAllSceneObjects<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF49730 Offset: 0xF48130 VA: 0x180F49730
	|-RuntimeUtilities.GetAllSceneObjects<object>
	*/

	// RVA: -1 Offset: -1
	public static void CreateIfNull<T>(ref T obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF496E0 Offset: 0xF480E0 VA: 0x180F496E0
	|-RuntimeUtilities.CreateIfNull<object>
	*/

	// RVA: 0x29BCFA0 Offset: 0x29BB9A0 VA: 0x1829BCFA0
	public static float Exp2(float x) { }

	// RVA: 0x29BD4C0 Offset: 0x29BBEC0 VA: 0x1829BD4C0
	public static Matrix4x4 GetJitteredPerspectiveProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x29BD350 Offset: 0x29BBD50 VA: 0x1829BD350
	public static Matrix4x4 GetJitteredOrthographicProjectionMatrix(Camera camera, Vector2 offset) { }

	// RVA: 0x29BCFB0 Offset: 0x29BB9B0 VA: 0x1829BCFB0
	public static Matrix4x4 GenerateJitteredProjectionMatrixFromOriginal(PostProcessRenderContext context, Matrix4x4 origProj, Vector2 jitter) { }

	// RVA: 0x29BD160 Offset: 0x29BBB60 VA: 0x1829BD160
	public static IEnumerable<Type> GetAllAssemblyTypes() { }

	// RVA: -1 Offset: -1
	public static IEnumerable<Type> GetAllTypesDerivedFrom<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF49790 Offset: 0xF48190 VA: 0x180F49790
	|-RuntimeUtilities.GetAllTypesDerivedFrom<object>
	|-RuntimeUtilities.GetAllTypesDerivedFrom<__Il2CppFullySharedGenericType>
	*/

	[Extension]
	// RVA: -1 Offset: -1
	public static T GetAttribute<T>(Type type) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF49940 Offset: 0xF48340 VA: 0x180F49940
	|-RuntimeUtilities.GetAttribute<object>
	*/

	// RVA: -1 Offset: -1
	public static Attribute[] GetMemberAttributes<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF49D60 Offset: 0xF48760 VA: 0x180F49D60
	|-RuntimeUtilities.GetMemberAttributes<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: -1 Offset: -1
	public static string GetFieldPath<TType, TValue>(Expression<Func<TType, TValue>> expr) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF49A30 Offset: 0xF48430 VA: 0x180F49A30
	|-RuntimeUtilities.GetFieldPath<__Il2CppFullySharedGenericType, __Il2CppFullySharedGenericType>
	*/

	// RVA: 0x29BDF30 Offset: 0x29BC930 VA: 0x1829BDF30
	private static void .cctor() { }
}
