public class UniversalAdditionalLightData : MonoBehaviour, ISerializationCallbackReceiver, IAdditionalData // TypeDefIndex: 9047
{
	// Fields
	[SerializeField]
	private int m_Version; // 0x20
	[Tooltip("Controls if light Shadow Bias parameters use pipeline settings.")]
	[SerializeField]
	private bool m_UsePipelineSettings; // 0x24
	public static readonly int AdditionalLightsShadowResolutionTierCustom; // 0x0
	public static readonly int AdditionalLightsShadowResolutionTierLow; // 0x4
	public static readonly int AdditionalLightsShadowResolutionTierMedium; // 0x8
	public static readonly int AdditionalLightsShadowResolutionTierHigh; // 0xC
	public static readonly int AdditionalLightsShadowDefaultResolutionTier; // 0x10
	public static readonly int AdditionalLightsShadowDefaultCustomResolution; // 0x14
	private Light m_Light; // 0x28
	public static readonly int AdditionalLightsShadowMinimumResolution; // 0x18
	[Tooltip("Controls if light shadow resolution uses pipeline settings.")]
	[SerializeField]
	private int m_AdditionalLightsShadowResolutionTier; // 0x30
	[SerializeField]
	[Obsolete("This is obsolete, please use m_RenderingLayerMask instead.", False)]
	private LightLayerEnum m_LightLayerMask; // 0x34
	[SerializeField]
	private uint m_RenderingLayers; // 0x38
	[SerializeField]
	private bool m_CustomShadowLayers; // 0x3C
	[SerializeField]
	private LightLayerEnum m_ShadowLayerMask; // 0x40
	[SerializeField]
	private uint m_ShadowRenderingLayers; // 0x44
	[SerializeField]
	private Vector2 m_LightCookieSize; // 0x48
	[SerializeField]
	private Vector2 m_LightCookieOffset; // 0x50
	[SerializeField]
	private SoftShadowQuality m_SoftShadowQuality; // 0x58

	// Properties
	internal int version { get; }
	public bool usePipelineSettings { get; set; }
	internal Light light { get; }
	public int additionalLightsShadowResolutionTier { get; }
	[Obsolete("This is obsolete, please use renderingLayerMask instead.", False)]
	public LightLayerEnum lightLayerMask { get; set; }
	public uint renderingLayers { get; set; }
	public bool customShadowLayers { get; set; }
	[Obsolete("This is obsolete, please use shadowRenderingLayerMask instead.", False)]
	public LightLayerEnum shadowLayerMask { get; set; }
	public uint shadowRenderingLayers { get; set; }
	[Tooltip("Controls the size of the cookie mask currently assigned to the light.")]
	public Vector2 lightCookieSize { get; set; }
	[Tooltip("Controls the offset of the cookie mask currently assigned to the light.")]
	public Vector2 lightCookieOffset { get; set; }
	[Tooltip("Controls the filtering quality of soft shadows. Higher quality has lower performance.")]
	public SoftShadowQuality softShadowQuality { get; set; }

	// Methods

	// RVA: 0x494440 Offset: 0x492E40 VA: 0x180494440
	internal int get_version() { }

	// RVA: 0x563D90 Offset: 0x562790 VA: 0x180563D90
	public bool get_usePipelineSettings() { }

	// RVA: 0x563E00 Offset: 0x562800 VA: 0x180563E00
	public void set_usePipelineSettings(bool value) { }

	// RVA: 0x2B37A80 Offset: 0x2B36480 VA: 0x182B37A80
	internal Light get_light() { }

	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90
	public int get_additionalLightsShadowResolutionTier() { }

	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00
	public LightLayerEnum get_lightLayerMask() { }

	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40
	public void set_lightLayerMask(LightLayerEnum value) { }

	// RVA: 0x495F50 Offset: 0x494950 VA: 0x180495F50
	public uint get_renderingLayers() { }

	// RVA: 0x2B37B10 Offset: 0x2B36510 VA: 0x182B37B10
	public void set_renderingLayers(uint value) { }

	// RVA: 0x495E90 Offset: 0x494890 VA: 0x180495E90
	public bool get_customShadowLayers() { }

	// RVA: 0x2B37B00 Offset: 0x2B36500 VA: 0x182B37B00
	public void set_customShadowLayers(bool value) { }

	// RVA: 0x4B5E40 Offset: 0x4B4840 VA: 0x1804B5E40
	public LightLayerEnum get_shadowLayerMask() { }

	// RVA: 0x4E28B0 Offset: 0x4E12B0 VA: 0x1804E28B0
	public void set_shadowLayerMask(LightLayerEnum value) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public uint get_shadowRenderingLayers() { }

	// RVA: 0x2B37B20 Offset: 0x2B36520 VA: 0x182B37B20
	public void set_shadowRenderingLayers(uint value) { }

	// RVA: 0x2ACB810 Offset: 0x2ACA210 VA: 0x182ACB810
	public Vector2 get_lightCookieSize() { }

	// RVA: 0xCC6410 Offset: 0xCC4E10 VA: 0x180CC6410
	public void set_lightCookieSize(Vector2 value) { }

	// RVA: 0x2B37A60 Offset: 0x2B36460 VA: 0x182B37A60
	public Vector2 get_lightCookieOffset() { }

	// RVA: 0xCC6420 Offset: 0xCC4E20 VA: 0x180CC6420
	public void set_lightCookieOffset(Vector2 value) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public SoftShadowQuality get_softShadowQuality() { }

	// RVA: 0x4E2910 Offset: 0x4E1310 VA: 0x1804E2910
	public void set_softShadowQuality(SoftShadowQuality value) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2B37730 Offset: 0x2B36130 VA: 0x182B37730 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x2B377F0 Offset: 0x2B361F0 VA: 0x182B377F0
	private void SyncLightAndShadowLayers() { }

	// RVA: 0x2B37950 Offset: 0x2B36350 VA: 0x182B37950
	public void .ctor() { }

	// RVA: 0x2B37890 Offset: 0x2B36290 VA: 0x182B37890
	private static void .cctor() { }
}
