public class VolumetricLightBeamHD : VolumetricLightBeamAbstractBase // TypeDefIndex: 278
{
	// Fields
	public const string ClassName = "VolumetricLightBeamHD";
	[SerializeField]
	private bool m_ColorFromLight; // 0x30
	[SerializeField]
	private ColorMode m_ColorMode; // 0x34
	[SerializeField]
	private Color m_ColorFlat; // 0x38
	[SerializeField]
	private Gradient m_ColorGradient; // 0x48
	[SerializeField]
	private BlendingMode m_BlendingMode; // 0x50
	[SerializeField]
	private float m_Intensity; // 0x54
	[SerializeField]
	private float m_IntensityMultiplier; // 0x58
	[SerializeField]
	private float m_HDRPExposureWeight; // 0x5C
	[SerializeField]
	private float m_SpotAngle; // 0x60
	[SerializeField]
	private float m_SpotAngleMultiplier; // 0x64
	[SerializeField]
	private float m_ConeRadiusStart; // 0x68
	[SerializeField]
	private bool m_Scalable; // 0x6C
	[SerializeField]
	private float m_FallOffStart; // 0x70
	[SerializeField]
	private float m_FallOffEnd; // 0x74
	[SerializeField]
	private float m_FallOffEndMultiplier; // 0x78
	[SerializeField]
	private AttenuationEquationHD m_AttenuationEquation; // 0x7C
	[SerializeField]
	private float m_SideSoftness; // 0x80
	[SerializeField]
	private int m_RaymarchingQualityID; // 0x84
	[SerializeField]
	private float m_JitteringFactor; // 0x88
	[SerializeField]
	private int m_JitteringFrameRate; // 0x8C
	[SerializeField]
	[MinMaxRange(0, 1)]
	private MinMaxRangeFloat m_JitteringLerpRange; // 0x90
	[SerializeField]
	private NoiseMode m_NoiseMode; // 0x98
	[SerializeField]
	private float m_NoiseIntensity; // 0x9C
	[SerializeField]
	private bool m_NoiseScaleUseGlobal; // 0xA0
	[SerializeField]
	private float m_NoiseScaleLocal; // 0xA4
	[SerializeField]
	private bool m_NoiseVelocityUseGlobal; // 0xA8
	[SerializeField]
	private Vector3 m_NoiseVelocityLocal; // 0xAC
	[CompilerGenerated]
	private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField; // 0xB8
	protected BeamGeometryHD m_BeamGeom; // 0xC0

	// Properties
	public bool colorFromLight { get; set; }
	public ColorMode colorMode { get; set; }
	public Color colorFlat { get; set; }
	public Gradient colorGradient { get; set; }
	private bool useColorFromAttachedLightSpot { get; }
	private bool useColorTemperatureFromAttachedLightSpot { get; }
	public float intensity { get; set; }
	public float intensityMultiplier { get; set; }
	public bool useIntensityFromAttachedLightSpot { get; }
	public float hdrpExposureWeight { get; set; }
	public BlendingMode blendingMode { get; set; }
	public float spotAngle { get; set; }
	public float spotAngleMultiplier { get; set; }
	public bool useSpotAngleFromAttachedLightSpot { get; }
	public float coneAngle { get; }
	public float coneRadiusStart { get; set; }
	public float coneRadiusEnd { get; set; }
	public float coneVolume { get; }
	public bool scalable { get; set; }
	public AttenuationEquationHD attenuationEquation { get; set; }
	public float fallOffStart { get; set; }
	public float fallOffEnd { get; set; }
	public float maxGeometryDistance { get; }
	public float fallOffEndMultiplier { get; set; }
	public bool useFallOffEndFromAttachedLightSpot { get; }
	public float sideSoftness { get; set; }
	public float jitteringFactor { get; set; }
	public int jitteringFrameRate { get; set; }
	public MinMaxRangeFloat jitteringLerpRange { get; set; }
	public NoiseMode noiseMode { get; set; }
	public bool isNoiseEnabled { get; }
	public float noiseIntensity { get; set; }
	public bool noiseScaleUseGlobal { get; set; }
	public float noiseScaleLocal { get; set; }
	public bool noiseVelocityUseGlobal { get; set; }
	public Vector3 noiseVelocityLocal { get; set; }
	public int raymarchingQualityID { get; set; }
	public int raymarchingQualityIndex { get; set; }
	public int blendingModeAsInt { get; }
	public Quaternion beamInternalLocalRotation { get; }
	public Vector3 beamLocalForward { get; }
	public Vector3 beamGlobalForward { get; }
	public uint _INTERNAL_InstancedMaterialGroupID { get; set; }

	// Methods

	// RVA: 0x498810 Offset: 0x497210 VA: 0x180498810
	public bool get_colorFromLight() { }

	// RVA: 0x6A56A0 Offset: 0x6A40A0 VA: 0x1806A56A0
	public void set_colorFromLight(bool value) { }

	// RVA: 0x6A5130 Offset: 0x6A3B30 VA: 0x1806A5130
	public ColorMode get_colorMode() { }

	// RVA: 0x6A5700 Offset: 0x6A4100 VA: 0x1806A5700
	public void set_colorMode(ColorMode value) { }

	// RVA: 0x4F9F20 Offset: 0x4F8920 VA: 0x1804F9F20
	public Color get_colorFlat() { }

	// RVA: 0x6A55F0 Offset: 0x6A3FF0 VA: 0x1806A55F0
	public void set_colorFlat(Color value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Gradient get_colorGradient() { }

	// RVA: 0x6A56B0 Offset: 0x6A40B0 VA: 0x1806A56B0
	public void set_colorGradient(Gradient value) { }

	// RVA: 0x6A5310 Offset: 0x6A3D10 VA: 0x1806A5310
	private bool get_useColorFromAttachedLightSpot() { }

	// RVA: 0x6A5370 Offset: 0x6A3D70 VA: 0x1806A5370
	private bool get_useColorTemperatureFromAttachedLightSpot() { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_intensity() { }

	// RVA: 0x6A58F0 Offset: 0x6A42F0 VA: 0x1806A58F0
	public void set_intensity(float value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_intensityMultiplier() { }

	// RVA: 0x6A58D0 Offset: 0x6A42D0 VA: 0x1806A58D0
	public void set_intensityMultiplier(float value) { }

	// RVA: 0x6A5480 Offset: 0x6A3E80 VA: 0x1806A5480
	public bool get_useIntensityFromAttachedLightSpot() { }

	// RVA: 0x4B5C00 Offset: 0x4B4600 VA: 0x1804B5C00
	public float get_hdrpExposureWeight() { }

	// RVA: 0x6A5890 Offset: 0x6A4290 VA: 0x1806A5890
	public void set_hdrpExposureWeight(float value) { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public BlendingMode get_blendingMode() { }

	// RVA: 0x6A55B0 Offset: 0x6A3FB0 VA: 0x1806A55B0
	public void set_blendingMode(BlendingMode value) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_spotAngle() { }

	// RVA: 0x6A5DB0 Offset: 0x6A47B0 VA: 0x1806A5DB0
	public void set_spotAngle(float value) { }

	// RVA: 0x4CD1A0 Offset: 0x4CBBA0 VA: 0x1804CD1A0
	public float get_spotAngleMultiplier() { }

	// RVA: 0x6A5D90 Offset: 0x6A4790 VA: 0x1806A5D90
	public void set_spotAngleMultiplier(float value) { }

	// RVA: 0x6A54F0 Offset: 0x6A3EF0 VA: 0x1806A54F0
	public bool get_useSpotAngleFromAttachedLightSpot() { }

	// RVA: 0x6A5170 Offset: 0x6A3B70 VA: 0x1806A5170
	public float get_coneAngle() { }

	// RVA: 0x4CD9E0 Offset: 0x4CC3E0 VA: 0x1804CD9E0
	public float get_coneRadiusStart() { }

	// RVA: 0x6A57A0 Offset: 0x6A41A0 VA: 0x1806A57A0
	public void set_coneRadiusStart(float value) { }

	// RVA: 0x6A51B0 Offset: 0x6A3BB0 VA: 0x1806A51B0
	public float get_coneRadiusEnd() { }

	// RVA: 0x6A5740 Offset: 0x6A4140 VA: 0x1806A5740
	public void set_coneRadiusEnd(float value) { }

	// RVA: 0x6A51D0 Offset: 0x6A3BD0 VA: 0x1806A51D0
	public float get_coneVolume() { }

	// RVA: 0x6A4580 Offset: 0x6A2F80 VA: 0x1806A4580
	public float GetConeApexOffsetZ(bool counterApplyScaleForUnscalableBeam) { }

	// RVA: 0x614490 Offset: 0x612E90 VA: 0x180614490
	public bool get_scalable() { }

	// RVA: 0x6A5D20 Offset: 0x6A4720 VA: 0x1806A5D20
	public void set_scalable(bool value) { }

	// RVA: 0x614490 Offset: 0x612E90 VA: 0x180614490 Slot: 6
	public override bool IsScalable() { }

	// RVA: 0x6A4D90 Offset: 0x6A3790 VA: 0x1806A4D90
	public AttenuationEquationHD get_attenuationEquation() { }

	// RVA: 0x6A5570 Offset: 0x6A3F70 VA: 0x1806A5570
	public void set_attenuationEquation(AttenuationEquationHD value) { }

	// RVA: 0x4CD9D0 Offset: 0x4CC3D0 VA: 0x1804CD9D0
	public float get_fallOffStart() { }

	// RVA: 0x6A5850 Offset: 0x6A4250 VA: 0x1806A5850
	public void set_fallOffStart(float value) { }

	// RVA: 0x4CD180 Offset: 0x4CBB80 VA: 0x1804CD180
	public float get_fallOffEnd() { }

	// RVA: 0x6A5800 Offset: 0x6A4200 VA: 0x1806A5800
	public void set_fallOffEnd(float value) { }

	// RVA: 0x4CD180 Offset: 0x4CBB80 VA: 0x1804CD180
	public float get_maxGeometryDistance() { }

	// RVA: 0x6A5230 Offset: 0x6A3C30 VA: 0x1806A5230
	public float get_fallOffEndMultiplier() { }

	// RVA: 0x6A57E0 Offset: 0x6A41E0 VA: 0x1806A57E0
	public void set_fallOffEndMultiplier(float value) { }

	// RVA: 0x6A5410 Offset: 0x6A3E10 VA: 0x1806A5410
	public bool get_useFallOffEndFromAttachedLightSpot() { }

	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	public float get_sideSoftness() { }

	// RVA: 0x6A5D40 Offset: 0x6A4740 VA: 0x1806A5D40
	public void set_sideSoftness(float value) { }

	// RVA: 0x6A5250 Offset: 0x6A3C50 VA: 0x1806A5250
	public float get_jitteringFactor() { }

	// RVA: 0x6A5940 Offset: 0x6A4340 VA: 0x1806A5940
	public void set_jitteringFactor(float value) { }

	// RVA: 0x4B5AB0 Offset: 0x4B44B0 VA: 0x1804B5AB0
	public int get_jitteringFrameRate() { }

	// RVA: 0x6A5990 Offset: 0x6A4390 VA: 0x1806A5990
	public void set_jitteringFrameRate(int value) { }

	// RVA: 0x6A5260 Offset: 0x6A3C60 VA: 0x1806A5260
	public MinMaxRangeFloat get_jitteringLerpRange() { }

	// RVA: 0x6A59D0 Offset: 0x6A43D0 VA: 0x1806A59D0
	public void set_jitteringLerpRange(MinMaxRangeFloat value) { }

	// RVA: 0x4B62D0 Offset: 0x4B4CD0 VA: 0x1804B62D0
	public NoiseMode get_noiseMode() { }

	// RVA: 0x6A5A90 Offset: 0x6A4490 VA: 0x1806A5A90
	public void set_noiseMode(NoiseMode value) { }

	// RVA: 0x6A5240 Offset: 0x6A3C40 VA: 0x1806A5240
	public bool get_isNoiseEnabled() { }

	// RVA: 0x6A5280 Offset: 0x6A3C80 VA: 0x1806A5280
	public float get_noiseIntensity() { }

	// RVA: 0x6A5A40 Offset: 0x6A4440 VA: 0x1806A5A40
	public void set_noiseIntensity(float value) { }

	// RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0
	public bool get_noiseScaleUseGlobal() { }

	// RVA: 0x6A5B20 Offset: 0x6A4520 VA: 0x1806A5B20
	public void set_noiseScaleUseGlobal(bool value) { }

	// RVA: 0x6A5290 Offset: 0x6A3C90 VA: 0x1806A5290
	public float get_noiseScaleLocal() { }

	// RVA: 0x6A5AD0 Offset: 0x6A44D0 VA: 0x1806A5AD0
	public void set_noiseScaleLocal(float value) { }

	// RVA: 0x4D63F0 Offset: 0x4D4DF0 VA: 0x1804D63F0
	public bool get_noiseVelocityUseGlobal() { }

	// RVA: 0x6A5C00 Offset: 0x6A4600 VA: 0x1806A5C00
	public void set_noiseVelocityUseGlobal(bool value) { }

	// RVA: 0x4D62F0 Offset: 0x4D4CF0 VA: 0x1804D62F0
	public Vector3 get_noiseVelocityLocal() { }

	// RVA: 0x6A5B60 Offset: 0x6A4560 VA: 0x1806A5B60
	public void set_noiseVelocityLocal(Vector3 value) { }

	// RVA: 0x6A52B0 Offset: 0x6A3CB0 VA: 0x1806A52B0
	public int get_raymarchingQualityID() { }

	// RVA: 0x6A5C40 Offset: 0x6A4640 VA: 0x1806A5C40
	public void set_raymarchingQualityID(int value) { }

	// RVA: 0x6A52C0 Offset: 0x6A3CC0 VA: 0x1806A52C0
	public int get_raymarchingQualityIndex() { }

	// RVA: 0x6A5C80 Offset: 0x6A4680 VA: 0x1806A5C80
	public void set_raymarchingQualityIndex(int value) { }

	// RVA: 0x4B6140 Offset: 0x4B4B40 VA: 0x1804B6140 Slot: 4
	public override BeamGeometryAbstractBase GetBeamGeometry() { }

	// RVA: 0x6A4AE0 Offset: 0x6A34E0 VA: 0x1806A4AE0 Slot: 5
	protected override void SetBeamGeometryNull() { }

	// RVA: 0x6A5060 Offset: 0x6A3A60 VA: 0x1806A5060
	public int get_blendingModeAsInt() { }

	// RVA: 0x6A4E90 Offset: 0x6A3890 VA: 0x1806A4E90
	public Quaternion get_beamInternalLocalRotation() { }

	// RVA: 0x6A4FB0 Offset: 0x6A39B0 VA: 0x1806A4FB0
	public Vector3 get_beamLocalForward() { }

	// RVA: 0x6A4DA0 Offset: 0x6A37A0 VA: 0x1806A4DA0
	public Vector3 get_beamGlobalForward() { }

	// RVA: 0x6A4890 Offset: 0x6A3290 VA: 0x1806A4890 Slot: 7
	public override Vector3 GetLossyScale() { }

	// RVA: 0x6A4500 Offset: 0x6A2F00 VA: 0x1806A4500
	public VolumetricCookieHD GetAdditionalComponentCookie() { }

	// RVA: 0x6A4540 Offset: 0x6A2F40 VA: 0x1806A4540
	public VolumetricShadowHD GetAdditionalComponentShadow() { }

	// RVA: 0x6A4B00 Offset: 0x6A3500 VA: 0x1806A4B00
	public void SetPropertyDirty(DirtyProps flags) { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 8
	public virtual Dimensions GetDimensions() { }

	// RVA: 0x492FC0 Offset: 0x4919C0 VA: 0x180492FC0 Slot: 9
	public virtual bool DoesSupportSorting2D() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 10
	public virtual int GetSortingLayerID() { }

	// RVA: 0x492770 Offset: 0x491170 VA: 0x180492770 Slot: 11
	public virtual int GetSortingOrder() { }

	[CompilerGenerated]
	// RVA: 0x6A4D80 Offset: 0x6A3780 VA: 0x1806A4D80
	public uint get__INTERNAL_InstancedMaterialGroupID() { }

	[CompilerGenerated]
	// RVA: 0x6A5560 Offset: 0x6A3F60 VA: 0x1806A5560
	protected void set__INTERNAL_InstancedMaterialGroupID(uint value) { }

	// RVA: 0x6A4810 Offset: 0x6A3210 VA: 0x1806A4810
	public float GetInsideBeamFactor(Vector3 posWS) { }

	// RVA: 0x6A4630 Offset: 0x6A3030 VA: 0x1806A4630
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS) { }

	// RVA: 0x6A40A0 Offset: 0x6A2AA0 VA: 0x1806A40A0 Slot: 12
	public virtual void GenerateGeometry() { }

	// RVA: 0x6A4C20 Offset: 0x6A3620 VA: 0x1806A4C20 Slot: 13
	public virtual void UpdateAfterManualPropertyChange() { }

	// RVA: 0x6A4BF0 Offset: 0x6A35F0 VA: 0x1806A4BF0
	private void Start() { }

	// RVA: 0x6A4A60 Offset: 0x6A3460 VA: 0x1806A4A60
	private void OnEnable() { }

	// RVA: 0x6A49E0 Offset: 0x6A33E0 VA: 0x1806A49E0
	private void OnDisable() { }

	// RVA: 0x6A49B0 Offset: 0x6A33B0 VA: 0x1806A49B0
	private void OnDidApplyAnimationProperties() { }

	// RVA: 0x6A3AE0 Offset: 0x6A24E0 VA: 0x1806A3AE0
	public void AssignPropertiesFromAttachedSpotLight() { }

	// RVA: 0x6A3F80 Offset: 0x6A2980 VA: 0x1806A3F80
	private void ClampProperties() { }

	// RVA: 0x6A4C50 Offset: 0x6A3650 VA: 0x1806A4C50
	private void ValidateProperties() { }

	// RVA: 0x6A4990 Offset: 0x6A3390 VA: 0x1806A4990
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	// RVA: 0x6A37C0 Offset: 0x6A21C0 VA: 0x1806A37C0
	public void .ctor() { }
}
