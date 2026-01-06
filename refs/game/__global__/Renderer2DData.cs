public class Renderer2DData : ScriptableRendererData // TypeDefIndex: 8725
{
	// Fields
	[SerializeField]
	private TransparencySortMode m_TransparencySortMode; // 0x40
	[SerializeField]
	private Vector3 m_TransparencySortAxis; // 0x44
	[SerializeField]
	private float m_HDREmulationScale; // 0x50
	[SerializeField]
	[Range(0.01, 1)]
	private float m_LightRenderTextureScale; // 0x54
	[SerializeField]
	[FormerlySerializedAs("m_LightOperations")]
	private Light2DBlendStyle[] m_LightBlendStyles; // 0x58
	[SerializeField]
	private bool m_UseDepthStencilBuffer; // 0x60
	[SerializeField]
	private bool m_UseCameraSortingLayersTexture; // 0x61
	[SerializeField]
	private int m_CameraSortingLayersTextureBound; // 0x64
	[SerializeField]
	private Downsampling m_CameraSortingLayerDownsamplingMethod; // 0x68
	[SerializeField]
	private uint m_MaxLightRenderTextureCount; // 0x6C
	[SerializeField]
	private uint m_MaxShadowRenderTextureCount; // 0x70
	[SerializeField]
	[Reload("Shaders/2D/Light2D-Shape.shader", 1)]
	private Shader m_ShapeLightShader; // 0x78
	[SerializeField]
	[Reload("Shaders/2D/Light2D-Shape-Volumetric.shader", 1)]
	private Shader m_ShapeLightVolumeShader; // 0x80
	[SerializeField]
	[Reload("Shaders/2D/Light2D-Point.shader", 1)]
	private Shader m_PointLightShader; // 0x88
	[SerializeField]
	[Reload("Shaders/2D/Light2D-Point-Volumetric.shader", 1)]
	private Shader m_PointLightVolumeShader; // 0x90
	[SerializeField]
	[Reload("Shaders/Utils/CoreBlit.shader", 1)]
	private Shader m_CoreBlitShader; // 0x98
	[SerializeField]
	[Reload("Shaders/Utils/BlitHDROverlay.shader", 1)]
	private Shader m_BlitHDROverlay; // 0xA0
	[Reload("Shaders/Utils/CoreBlitColorAndDepth.shader", 1)]
	[SerializeField]
	private Shader m_CoreBlitColorAndDepthPS; // 0xA8
	[Reload("Shaders/Utils/Sampling.shader", 1)]
	[SerializeField]
	private Shader m_SamplingShader; // 0xB0
	[Reload("Shaders/2D/Shadow2D-Projected.shader", 1)]
	[SerializeField]
	private Shader m_ProjectedShadowShader; // 0xB8
	[SerializeField]
	[Reload("Shaders/2D/Shadow2D-Shadow-Sprite.shader", 1)]
	private Shader m_SpriteShadowShader; // 0xC0
	[SerializeField]
	[Reload("Shaders/2D/Shadow2D-Unshadow-Sprite.shader", 1)]
	private Shader m_SpriteUnshadowShader; // 0xC8
	[SerializeField]
	[Reload("Shaders/2D/Shadow2D-Unshadow-Geometry.shader", 1)]
	private Shader m_GeometryUnshadowShader; // 0xD0
	[SerializeField]
	[Reload("Shaders/Utils/FallbackError.shader", 1)]
	private Shader m_FallbackErrorShader; // 0xD8
	[SerializeField]
	private PostProcessData m_PostProcessData; // 0xE0
	[SerializeField]
	[HideInInspector]
	[Reload("Runtime/2D/Data/Textures/FalloffLookupTexture.png", 1)]
	private Texture2D m_FallOffLookup; // 0xE8
	[CompilerGenerated]
	private readonly Dictionary<uint, Material> <lightMaterials>k__BackingField; // 0xF0
	[CompilerGenerated]
	private Material[] <spriteSelfShadowMaterial>k__BackingField; // 0xF8
	[CompilerGenerated]
	private Material[] <spriteUnshadowMaterial>k__BackingField; // 0x100
	[CompilerGenerated]
	private Material[] <geometryUnshadowMaterial>k__BackingField; // 0x108
	[CompilerGenerated]
	private Material[] <projectedShadowMaterial>k__BackingField; // 0x110
	[CompilerGenerated]
	private Material[] <stencilOnlyShadowMaterial>k__BackingField; // 0x118
	[CompilerGenerated]
	private bool <isNormalsRenderTargetValid>k__BackingField; // 0x120
	[CompilerGenerated]
	private float <normalsRenderTargetScale>k__BackingField; // 0x124
	internal RTHandle normalsRenderTarget; // 0x128
	internal int normalsRenderTargetId; // 0x130
	internal RTHandle shadowsRenderTarget; // 0x138
	internal int shadowsRenderTargetId; // 0x140
	internal RTHandle cameraSortingLayerRenderTarget; // 0x148
	internal int cameraSortingLayerRenderTargetId; // 0x150
	[CompilerGenerated]
	private ILight2DCullResult <lightCullResult>k__BackingField; // 0x158

	// Properties
	public float hdrEmulationScale { get; }
	internal float lightRenderTextureScale { get; }
	public Light2DBlendStyle[] lightBlendStyles { get; }
	internal bool useDepthStencilBuffer { get; }
	internal Texture2D fallOffLookup { get; }
	internal Shader shapeLightShader { get; }
	internal Shader shapeLightVolumeShader { get; }
	internal Shader pointLightShader { get; }
	internal Shader pointLightVolumeShader { get; }
	internal Shader blitShader { get; }
	internal Shader blitHDROverlay { get; }
	internal Shader coreBlitPS { get; }
	internal Shader coreBlitColorAndDepthPS { get; }
	internal Shader samplingShader { get; }
	internal PostProcessData postProcessData { get; set; }
	internal Shader spriteShadowShader { get; }
	internal Shader spriteUnshadowShader { get; }
	internal Shader geometryUnshadowShader { get; }
	internal Shader projectedShadowShader { get; }
	internal TransparencySortMode transparencySortMode { get; }
	internal Vector3 transparencySortAxis { get; }
	internal uint lightRenderTextureMemoryBudget { get; }
	internal uint shadowRenderTextureMemoryBudget { get; }
	internal bool useCameraSortingLayerTexture { get; }
	internal int cameraSortingLayerTextureBound { get; }
	internal Downsampling cameraSortingLayerDownsamplingMethod { get; }
	internal Dictionary<uint, Material> lightMaterials { get; }
	internal Material[] spriteSelfShadowMaterial { get; set; }
	internal Material[] spriteUnshadowMaterial { get; set; }
	internal Material[] geometryUnshadowMaterial { get; set; }
	internal Material[] projectedShadowMaterial { get; set; }
	internal Material[] stencilOnlyShadowMaterial { get; set; }
	internal bool isNormalsRenderTargetValid { get; set; }
	internal float normalsRenderTargetScale { get; set; }
	internal ILight2DCullResult lightCullResult { get; set; }

	// Methods

	// RVA: 0x4C3B50 Offset: 0x4C2550 VA: 0x1804C3B50
	public float get_hdrEmulationScale() { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	internal float get_lightRenderTextureScale() { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public Light2DBlendStyle[] get_lightBlendStyles() { }

	// RVA: 0x4C1D90 Offset: 0x4C0790 VA: 0x1804C1D90
	internal bool get_useDepthStencilBuffer() { }

	// RVA: 0x4E8CB0 Offset: 0x4E76B0 VA: 0x1804E8CB0
	internal Texture2D get_fallOffLookup() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	internal Shader get_shapeLightShader() { }

	// RVA: 0x4E2400 Offset: 0x4E0E00 VA: 0x1804E2400
	internal Shader get_shapeLightVolumeShader() { }

	// RVA: 0x4CD080 Offset: 0x4CBA80 VA: 0x1804CD080
	internal Shader get_pointLightShader() { }

	// RVA: 0x614480 Offset: 0x612E80 VA: 0x180614480
	internal Shader get_pointLightVolumeShader() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal Shader get_blitShader() { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	internal Shader get_blitHDROverlay() { }

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal Shader get_coreBlitPS() { }

	// RVA: 0x4B61A0 Offset: 0x4B4BA0 VA: 0x1804B61A0
	internal Shader get_coreBlitColorAndDepthPS() { }

	// RVA: 0x4B6150 Offset: 0x4B4B50 VA: 0x1804B6150
	internal Shader get_samplingShader() { }

	// RVA: 0x4E8CA0 Offset: 0x4E76A0 VA: 0x1804E8CA0
	internal PostProcessData get_postProcessData() { }

	// RVA: 0x4E8E40 Offset: 0x4E7840 VA: 0x1804E8E40
	internal void set_postProcessData(PostProcessData value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140
	internal Shader get_spriteShadowShader() { }

	// RVA: 0x4B6170 Offset: 0x4B4B70 VA: 0x1804B6170
	internal Shader get_spriteUnshadowShader() { }

	// RVA: 0x4B6180 Offset: 0x4B4B80 VA: 0x1804B6180
	internal Shader get_geometryUnshadowShader() { }

	// RVA: 0x4B6160 Offset: 0x4B4B60 VA: 0x1804B6160
	internal Shader get_projectedShadowShader() { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	internal TransparencySortMode get_transparencySortMode() { }

	// RVA: 0x4CD310 Offset: 0x4CBD10 VA: 0x1804CD310
	internal Vector3 get_transparencySortAxis() { }

	// RVA: 0xA9F7F0 Offset: 0xA9E1F0 VA: 0x180A9F7F0
	internal uint get_lightRenderTextureMemoryBudget() { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	internal uint get_shadowRenderTextureMemoryBudget() { }

	// RVA: 0x848340 Offset: 0x846D40 VA: 0x180848340
	internal bool get_useCameraSortingLayerTexture() { }

	// RVA: 0x4B5430 Offset: 0x4B3E30 VA: 0x1804B5430
	internal int get_cameraSortingLayerTextureBound() { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	internal Downsampling get_cameraSortingLayerDownsamplingMethod() { }

	// RVA: 0x2ACC480 Offset: 0x2ACAE80 VA: 0x182ACC480 Slot: 4
	protected override ScriptableRenderer Create() { }

	// RVA: 0x2ACC4E0 Offset: 0x2ACAEE0 VA: 0x182ACC4E0
	internal void Dispose() { }

	// RVA: 0x2ACC6D0 Offset: 0x2ACB0D0 VA: 0x182ACC6D0 Slot: 6
	protected override void OnEnable() { }

	[CompilerGenerated]
	// RVA: 0x5162A0 Offset: 0x514CA0 VA: 0x1805162A0
	internal Dictionary<uint, Material> get_lightMaterials() { }

	[CompilerGenerated]
	// RVA: 0x605170 Offset: 0x603B70 VA: 0x180605170
	internal Material[] get_spriteSelfShadowMaterial() { }

	[CompilerGenerated]
	// RVA: 0x605220 Offset: 0x603C20 VA: 0x180605220
	internal void set_spriteSelfShadowMaterial(Material[] value) { }

	[CompilerGenerated]
	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	internal Material[] get_spriteUnshadowMaterial() { }

	[CompilerGenerated]
	// RVA: 0x51DD20 Offset: 0x51C720 VA: 0x18051DD20
	internal void set_spriteUnshadowMaterial(Material[] value) { }

	[CompilerGenerated]
	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	internal Material[] get_geometryUnshadowMaterial() { }

	[CompilerGenerated]
	// RVA: 0x505FC0 Offset: 0x5049C0 VA: 0x180505FC0
	internal void set_geometryUnshadowMaterial(Material[] value) { }

	[CompilerGenerated]
	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	internal Material[] get_projectedShadowMaterial() { }

	[CompilerGenerated]
	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	internal void set_projectedShadowMaterial(Material[] value) { }

	[CompilerGenerated]
	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	internal Material[] get_stencilOnlyShadowMaterial() { }

	[CompilerGenerated]
	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	internal void set_stencilOnlyShadowMaterial(Material[] value) { }

	[CompilerGenerated]
	// RVA: 0x513170 Offset: 0x511B70 VA: 0x180513170
	internal bool get_isNormalsRenderTargetValid() { }

	[CompilerGenerated]
	// RVA: 0x5EB2E0 Offset: 0x5E9CE0 VA: 0x1805EB2E0
	internal void set_isNormalsRenderTargetValid(bool value) { }

	[CompilerGenerated]
	// RVA: 0x512AC0 Offset: 0x5114C0 VA: 0x180512AC0
	internal float get_normalsRenderTargetScale() { }

	[CompilerGenerated]
	// RVA: 0x2ACCB90 Offset: 0x2ACB590 VA: 0x182ACCB90
	internal void set_normalsRenderTargetScale(float value) { }

	[CompilerGenerated]
	// RVA: 0x618020 Offset: 0x616A20 VA: 0x180618020
	internal ILight2DCullResult get_lightCullResult() { }

	[CompilerGenerated]
	// RVA: 0x618120 Offset: 0x616B20 VA: 0x180618120
	internal void set_lightCullResult(ILight2DCullResult value) { }

	// RVA: 0x2ACCAB0 Offset: 0x2ACB4B0 VA: 0x182ACCAB0
	public void .ctor() { }
}
