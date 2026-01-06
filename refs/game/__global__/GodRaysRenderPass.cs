public class GodRaysRenderPass : ScriptableRenderPass // TypeDefIndex: 18731
{
	// Fields
	private const string _profilerTag = "GodRaysRenderPass";
	private static readonly int _GodRaysTexture; // 0x0
	private static readonly int _CorgiGrabpass; // 0x4
	private static readonly int _CopyBlitTex; // 0x8
	private static readonly int _TempBlurTex; // 0xC
	private static readonly int _BlurInputTex; // 0x10
	private static readonly int _CorgiDepthGrabpassFullRes; // 0x14
	private static readonly int _CorgiDepthGrabpassNonFullRes; // 0x18
	private static readonly int _CorgiInverseProjection; // 0x1C
	private static readonly int _CorgiCameraToWorld; // 0x20
	private static readonly int _CorgiInverseProjectionArray; // 0x24
	private static readonly int _GodRaysParams; // 0x28
	private static readonly int _MainLightScattering; // 0x2C
	private static readonly int _AdditionalLightScattering; // 0x30
	private static readonly int _Jitter; // 0x34
	private static readonly int _MaxDistance; // 0x38
	private static readonly int _MainLightIntensity; // 0x3C
	private static readonly int _AdditionalLightIntensity; // 0x40
	private static readonly int _TintColor; // 0x44
	private static readonly int _CorgiVisibleLightCount; // 0x48
	private static readonly int _CorgiVisibleLightData; // 0x4C
	private static readonly int _CorgiLightIndexToShadowIndex; // 0x50
	private static readonly int _CorgiGodraysIntensityCurveTexture; // 0x54
	private GodRaysRenderFeature.GodRaysSettings _settings; // 0xE0
	private ScriptableRenderer _renderer; // 0xE8
	private Matrix4x4[] _InverseProjectionArray; // 0xF0
	private MaterialPropertyBlock _propertyBlock; // 0xF8
	private Texture2D _intensityCurveTexture; // 0x100
	private PropertyInfo _cacheRenderFeaturesPropertyInfo; // 0x108
	private static GraphicsBuffer _additionalLightsBuffer; // 0x58
	private static GraphicsBuffer _lightsToShadowIndexBuffer; // 0x60
	private const int MaxLightCount = 256;
	private MixedLightingSetup m_MixedLightingSetup; // 0x110
	private int _temporal_pass_index; // 0x114
	private bool _curveTextureForceRefreshTrigger; // 0x118
	private static Mesh s_FullscreenMesh; // 0x68

	// Properties
	public static Mesh fullscreenMesh { get; }

	// Methods

	// RVA: 0xCC3140 Offset: 0xCC1B40 VA: 0x180CC3140
	public void Setup(GodRaysRenderFeature.GodRaysSettings settings, ScriptableRenderer renderer, ref RenderingData renderingData) { }

	// RVA: 0xCC2FD0 Offset: 0xCC19D0 VA: 0x180CC2FD0
	public void Initialize() { }

	// RVA: 0xCBFBC0 Offset: 0xCBE5C0 VA: 0x180CBFBC0
	public void Dispose() { }

	// RVA: 0xCBFB20 Offset: 0xCBE520 VA: 0x180CBFB20
	private void DisposeCurveTexture() { }

	// RVA: 0xCC2D80 Offset: 0xCC1780 VA: 0x180CC2D80
	private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive) { }

	// RVA: 0xCC3240 Offset: 0xCC1C40 VA: 0x180CC3240
	public static uint ToValidRenderingLayers(uint renderingLayers) { }

	// RVA: -1 Offset: -1
	public static ref T UnsafeElementAtMutable<T>(NativeArray<T> array, int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEBD700 Offset: 0xEBC100 VA: 0x180EBD700
	|-GodRaysRenderPass.UnsafeElementAtMutable<VisibleLight>
	|
	|-RVA: 0xEBD690 Offset: 0xEBC090 VA: 0x180EBD690
	|-GodRaysRenderPass.UnsafeElementAtMutable<__Il2CppFullySharedGenericStructType>
	*/

	// RVA: 0xCC36C0 Offset: 0xCC20C0 VA: 0x180CC36C0
	public static Mesh get_fullscreenMesh() { }

	// RVA: 0xCBFE80 Offset: 0xCBE880 VA: 0x180CBFE80 Slot: 9
	public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0xCC3250 Offset: 0xCC1C50 VA: 0x180CC3250
	public void TriggerRefreshCurveTexture() { }

	// RVA: 0xCBFCB0 Offset: 0xCBE6B0 VA: 0x180CBFCB0
	private void EnsureCurveTexture() { }

	// RVA: 0xCC3640 Offset: 0xCC2040 VA: 0x180CC3640
	public void .ctor() { }

	// RVA: 0xCC3260 Offset: 0xCC1C60 VA: 0x180CC3260
	private static void .cctor() { }
}
