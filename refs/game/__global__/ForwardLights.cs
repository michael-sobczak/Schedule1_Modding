public class ForwardLights // TypeDefIndex: 9125
{
	// Fields
	private int m_AdditionalLightsBufferId; // 0x10
	private int m_AdditionalLightsIndicesId; // 0x14
	private const string k_SetupLightConstants = "Setup Light Constants";
	private static readonly ProfilingSampler m_ProfilingSampler; // 0x0
	private static readonly ProfilingSampler m_ProfilingSamplerFPSetup; // 0x8
	private static readonly ProfilingSampler m_ProfilingSamplerFPComplete; // 0x10
	private static readonly ProfilingSampler m_ProfilingSamplerFPUpload; // 0x18
	private MixedLightingSetup m_MixedLightingSetup; // 0x18
	private Vector4[] m_AdditionalLightPositions; // 0x20
	private Vector4[] m_AdditionalLightColors; // 0x28
	private Vector4[] m_AdditionalLightAttenuations; // 0x30
	private Vector4[] m_AdditionalLightSpotDirections; // 0x38
	private Vector4[] m_AdditionalLightOcclusionProbeChannels; // 0x40
	private float[] m_AdditionalLightsLayerMasks; // 0x48
	private bool m_UseStructuredBuffer; // 0x50
	private bool m_UseForwardPlus; // 0x51
	private int m_DirectionalLightCount; // 0x54
	private int m_ActualTileWidth; // 0x58
	private int2 m_TileResolution; // 0x5C
	private JobHandle m_CullingHandle; // 0x68
	private NativeArray<uint> m_ZBins; // 0x78
	private GraphicsBuffer m_ZBinsBuffer; // 0x88
	private NativeArray<uint> m_TileMasks; // 0x90
	private GraphicsBuffer m_TileMasksBuffer; // 0xA0
	private LightCookieManager m_LightCookieManager; // 0xA8
	private ReflectionProbeManager m_ReflectionProbeManager; // 0xB0
	private int m_WordsPerTile; // 0x130
	private float m_ZBinScale; // 0x134
	private float m_ZBinOffset; // 0x138
	private int m_LightCount; // 0x13C
	private int m_BinCount; // 0x140

	// Properties
	internal ReflectionProbeManager reflectionProbeManager { get; }

	// Methods

	// RVA: 0x2B6B650 Offset: 0x2B6A050 VA: 0x182B6B650
	public void .ctor() { }

	// RVA: 0x2B6B7A0 Offset: 0x2B6A1A0 VA: 0x182B6B7A0
	internal void .ctor(ForwardLights.InitParams initParams) { }

	// RVA: 0x2B67D10 Offset: 0x2B66710 VA: 0x182B67D10
	private void CreateForwardPlusBuffers() { }

	// RVA: 0x2B6BC00 Offset: 0x2B6A600 VA: 0x182B6BC00
	internal ReflectionProbeManager get_reflectionProbeManager() { }

	// RVA: 0x2B67C10 Offset: 0x2B66610 VA: 0x182B67C10
	private static int AlignByteCount(int count, int align) { }

	// RVA: 0x2B67F10 Offset: 0x2B66910 VA: 0x182B67F10
	private void GetViewParams(Camera camera, float4x4 viewToClip, out float viewPlaneBot, out float viewPlaneTop, out float4 viewToViewportScaleBias) { }

	// RVA: 0x2B68300 Offset: 0x2B66D00 VA: 0x182B68300
	internal void PreSetup(ref RenderingData renderingData) { }

	// RVA: 0x2B6AA20 Offset: 0x2B69420 VA: 0x182B6AA20
	public void Setup(ScriptableRenderContext context, ref RenderingData renderingData) { }

	// RVA: 0x2B67C30 Offset: 0x2B66630 VA: 0x182B67C30
	internal void Cleanup() { }

	// RVA: 0x2B680F0 Offset: 0x2B66AF0 VA: 0x182B680F0
	private void InitializeLightConstants(NativeArray<VisibleLight> lights, int lightIndex, out Vector4 lightPos, out Vector4 lightColor, out Vector4 lightAttenuation, out Vector4 lightSpotDir, out Vector4 lightOcclusionProbeChannel, out uint lightLayerMask, out bool isSubtractive) { }

	// RVA: 0x2B6A9D0 Offset: 0x2B693D0 VA: 0x182B6A9D0
	private void SetupShaderLightConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B6A520 Offset: 0x2B68F20 VA: 0x182B6A520
	private void SetupMainLightConstants(CommandBuffer cmd, ref LightData lightData) { }

	// RVA: 0x2B69EE0 Offset: 0x2B688E0 VA: 0x182B69EE0
	private void SetupAdditionalLightConstants(CommandBuffer cmd, ref RenderingData renderingData) { }

	// RVA: 0x2B6A810 Offset: 0x2B69210 VA: 0x182B6A810
	private int SetupPerObjectLightIndices(CullingResults cullResults, ref LightData lightData) { }

	// RVA: 0x2B6B4B0 Offset: 0x2B69EB0 VA: 0x182B6B4B0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2B6B3B0 Offset: 0x2B69DB0 VA: 0x182B6B3B0
	internal static bool <PreSetup>g__IsProbeGreater|40_0(VisibleReflectionProbe probe, VisibleReflectionProbe otherProbe) { }
}
