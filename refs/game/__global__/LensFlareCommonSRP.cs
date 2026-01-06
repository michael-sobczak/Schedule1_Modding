public sealed class LensFlareCommonSRP // TypeDefIndex: 13781
{
	// Fields
	private static LensFlareCommonSRP m_Instance; // 0x0
	private static readonly object m_Padlock; // 0x8
	private static List<LensFlareCommonSRP.LensFlareCompInfo> m_Data; // 0x10
	private static List<int> m_AvailableIndicies; // 0x18
	public static int maxLensFlareWithOcclusion; // 0x20
	public static int maxLensFlareWithOcclusionTemporalSample; // 0x24
	public static int mergeNeeded; // 0x28
	public static RTHandle occlusionRT; // 0x30
	private static int frameIdx; // 0x38
	private static readonly bool s_SupportsLensFlareTexFormat; // 0x3C

	// Properties
	public static LensFlareCommonSRP Instance { get; }
	private List<LensFlareCommonSRP.LensFlareCompInfo> Data { get; }

	// Methods

	// RVA: 0x43C6A0 Offset: 0x43B0A0 VA: 0x18043C6A0
	private void .ctor() { }

	// RVA: 0x2A1C710 Offset: 0x2A1B110 VA: 0x182A1C710
	public static bool IsOcclusionRTCompatible() { }

	// RVA: 0x2A1BFA0 Offset: 0x2A1A9A0 VA: 0x182A1BFA0
	public static void Initialize() { }

	// RVA: 0x2A187A0 Offset: 0x2A171A0 VA: 0x182A187A0
	public static void Dispose() { }

	// RVA: 0x2A1E370 Offset: 0x2A1CD70 VA: 0x182A1E370
	public static LensFlareCommonSRP get_Instance() { }

	// RVA: 0x2A1E320 Offset: 0x2A1CD20 VA: 0x182A1E320
	private List<LensFlareCommonSRP.LensFlareCompInfo> get_Data() { }

	// RVA: 0x2A1C550 Offset: 0x2A1AF50 VA: 0x182A1C550
	public bool IsEmpty() { }

	// RVA: 0x2A1BE60 Offset: 0x2A1A860 VA: 0x182A1BE60
	private int GetNextAvailableIndex() { }

	// RVA: 0x2A17140 Offset: 0x2A15B40 VA: 0x182A17140
	public void AddData(LensFlareComponentSRP newData) { }

	// RVA: 0x2A1C820 Offset: 0x2A1B220 VA: 0x182A1C820
	public void RemoveData(LensFlareComponentSRP data) { }

	// RVA: 0x718A60 Offset: 0x717460 VA: 0x180718A60
	public static float ShapeAttenuationPointLight() { }

	// RVA: 0x2A1D160 Offset: 0x2A1BB60 VA: 0x182A1D160
	public static float ShapeAttenuationDirLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x2A1D210 Offset: 0x2A1BC10 VA: 0x182A1D210
	public static float ShapeAttenuationSpotConeLight(Vector3 forward, Vector3 wo, float spotAngle, float innerSpotPercent01) { }

	// RVA: 0x2A1D1B0 Offset: 0x2A1BBB0 VA: 0x182A1D1B0
	public static float ShapeAttenuationSpotBoxLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x2A1D330 Offset: 0x2A1BD30 VA: 0x182A1D330
	public static float ShapeAttenuationSpotPyramidLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x2A1CD10 Offset: 0x2A1B710 VA: 0x182A1CD10
	public static float ShapeAttenuationAreaTubeLight(Vector3 lightPositionWS, Vector3 lightSide, float lightWidth, Camera cam) { }

	// RVA: 0x2A1CC80 Offset: 0x2A1B680 VA: 0x182A1CC80
	public static float ShapeAttenuationAreaRectangleLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x2A1CBF0 Offset: 0x2A1B5F0 VA: 0x182A1CBF0
	public static float ShapeAttenuationAreaDiscLight(Vector3 forward, Vector3 wo) { }

	// RVA: 0x2A1C5D0 Offset: 0x2A1AFD0 VA: 0x182A1C5D0
	private static bool IsLensFlareSRPHidden(Camera cam, LensFlareComponentSRP comp, LensFlareDataSRP data) { }

	// RVA: 0x2A1BB40 Offset: 0x2A1A540 VA: 0x182A1BB40
	public static Vector4 GetFlareData0(Vector2 screenPos, Vector2 translationScale, Vector2 rayOff0, Vector2 vLocalScreenRatio, float angleDeg, float position, float angularOffset, Vector2 positionOffset, bool autoRotate) { }

	// RVA: 0x2A1BDF0 Offset: 0x2A1A7F0 VA: 0x182A1BDF0
	private static Vector2 GetLensFlareRayOffset(Vector2 screenPos, float position, float globalCos0, float globalSin0) { }

	// RVA: 0x2A1DDF0 Offset: 0x2A1C7F0 VA: 0x182A1DDF0
	private static Vector3 WorldToViewport(Camera camera, bool isLocalLight, bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 positionWS) { }

	// RVA: 0x2A1DC60 Offset: 0x2A1C660 VA: 0x182A1DC60
	private static Vector3 WorldToViewportLocal(bool isCameraRelative, Matrix4x4 viewProjMatrix, Vector3 cameraPosWS, Vector3 positionWS) { }

	// RVA: 0x2A1DAA0 Offset: 0x2A1C4A0 VA: 0x182A1DAA0
	private static Vector3 WorldToViewportDistance(Camera cam, Vector3 positionWS) { }

	// RVA: 0x2A1C2D0 Offset: 0x2A1ACD0 VA: 0x182A1C2D0
	public static bool IsCloudLayerOpacityNeeded(Camera cam) { }

	// RVA: 0x2A1CA70 Offset: 0x2A1B470 VA: 0x182A1CA70
	private static void SetOcclusionPermutation(CommandBuffer cmd, bool useBackgroundCloudOcclusion, bool volumetricCloudOcclusion, bool hasCloudLayer, int _FlareCloudOpacity, int _FlareSunOcclusionTex, Texture cloudOpacityTexture, Texture sunOcclusionTexture) { }

	// RVA: 0x2A175D0 Offset: 0x2A15FD0 VA: 0x182A175D0
	public static void ComputeOcclusion(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, int _FlareOcclusionTex, int _FlareCloudOpacity, int _FlareOcclusionIndex, int _FlareTex, int _FlareColorValue, int _FlareSunOcclusionTex, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4) { }

	// RVA: 0x2A18900 Offset: 0x2A17300 VA: 0x182A18900
	public static void DoLensFlareDataDrivenCommon(Material lensFlareShader, Camera cam, float actualWidth, float actualHeight, bool usePanini, float paniniDistance, float paniniCropToFit, bool isCameraRelative, Vector3 cameraPositionWS, Matrix4x4 viewProjMatrix, CommandBuffer cmd, bool taaEnabled, bool hasCloudLayer, Texture cloudOpacityTexture, Texture sunOcclusionTexture, RenderTargetIdentifier colorBuffer, Func<Light, Camera, Vector3, float> GetLensFlareLightAttenuation, int _FlareOcclusionRemapTex, int _FlareOcclusionTex, int _FlareOcclusionIndex, int _FlareCloudOpacity, int _FlareSunOcclusionTex, int _FlareTex, int _FlareColorValue, int _FlareData0, int _FlareData1, int _FlareData2, int _FlareData3, int _FlareData4, bool debugView) { }

	// RVA: 0x2A1B8A0 Offset: 0x2A1A2A0 VA: 0x182A1B8A0
	private static Vector2 DoPaniniProjection(Vector2 screenPos, float actualWidth, float actualHeight, float fieldOfView, float paniniProjectionCropToFit, float paniniProjectionDistance) { }

	// RVA: 0x2A17580 Offset: 0x2A15F80 VA: 0x182A17580
	private static Vector2 CalcViewExtents(float actualWidth, float actualHeight, float fieldOfView) { }

	// RVA: 0x2A17460 Offset: 0x2A15E60 VA: 0x182A17460
	private static Vector2 CalcCropExtents(float actualWidth, float actualHeight, float fieldOfView, float d) { }

	// RVA: 0x2A1C790 Offset: 0x2A1B190 VA: 0x182A1C790
	private static Vector2 Panini_Generic_Inv(Vector2 projPos, float d) { }

	// RVA: 0x2A1E110 Offset: 0x2A1CB10 VA: 0x182A1E110
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2A1DA20 Offset: 0x2A1C420 VA: 0x182A1DA20
	internal static float <ShapeAttenuationAreaTubeLight>g__Fpo|28_0(float d, float l) { }

	[CompilerGenerated]
	// RVA: 0x2A1DA80 Offset: 0x2A1C480 VA: 0x182A1DA80
	internal static float <ShapeAttenuationAreaTubeLight>g__Fwt|28_1(float d, float l) { }

	[CompilerGenerated]
	// RVA: 0x2A1D5E0 Offset: 0x2A1BFE0 VA: 0x182A1D5E0
	internal static float <ShapeAttenuationAreaTubeLight>g__DiffLineIntegral|28_2(Vector3 p1, Vector3 p2) { }

	[CompilerGenerated]
	// RVA: 0x2A1D3E0 Offset: 0x2A1BDE0 VA: 0x182A1D3E0
	internal static Vector2 <DoLensFlareDataDrivenCommon>g__ComputeLocalSize|40_0(Vector2 rayOff, Vector2 rayOff0, Vector2 curSize, AnimationCurve distortionCurve, ref LensFlareCommonSRP.<>c__DisplayClass40_0 , ref LensFlareCommonSRP.<>c__DisplayClass40_1 , ref LensFlareCommonSRP.<>c__DisplayClass40_2 ) { }

	[CompilerGenerated]
	// RVA: 0x2A1D5D0 Offset: 0x2A1BFD0 VA: 0x182A1D5D0
	internal static float <DoLensFlareDataDrivenCommon>g__RandomRange|40_1(float min, float max) { }
}
