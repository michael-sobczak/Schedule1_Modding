public class VolumetricLightBeamSD : VolumetricLightBeamAbstractBase // TypeDefIndex: 330
{
	// Fields
	public const string ClassName = "VolumetricLightBeamSD";
	public bool colorFromLight; // 0x30
	public ColorMode colorMode; // 0x34
	[FormerlySerializedAs("colorValue")]
	[ColorUsage(False, True)]
	public Color color; // 0x38
	public Gradient colorGradient; // 0x48
	public bool intensityFromLight; // 0x50
	public bool intensityModeAdvanced; // 0x51
	[Min(0)]
	[FormerlySerializedAs("alphaInside")]
	public float intensityInside; // 0x54
	[Min(0)]
	[FormerlySerializedAs("alphaOutside")]
	[FormerlySerializedAs("alpha")]
	public float intensityOutside; // 0x58
	[Min(0)]
	public float intensityMultiplier; // 0x5C
	[Range(0, 1)]
	public float hdrpExposureWeight; // 0x60
	public BlendingMode blendingMode; // 0x64
	[FormerlySerializedAs("angleFromLight")]
	public bool spotAngleFromLight; // 0x68
	[Range(0.1, 179.9)]
	public float spotAngle; // 0x6C
	[Min(0)]
	public float spotAngleMultiplier; // 0x70
	[FormerlySerializedAs("radiusStart")]
	public float coneRadiusStart; // 0x74
	public ShaderAccuracy shaderAccuracy; // 0x78
	public MeshType geomMeshType; // 0x7C
	[FormerlySerializedAs("geomSides")]
	public int geomCustomSides; // 0x80
	public int geomCustomSegments; // 0x84
	public Vector3 skewingLocalForwardDirection; // 0x88
	public Transform clippingPlaneTransform; // 0x98
	public bool geomCap; // 0xA0
	public AttenuationEquation attenuationEquation; // 0xA4
	[Range(0, 1)]
	public float attenuationCustomBlending; // 0xA8
	[FormerlySerializedAs("fadeStart")]
	public float fallOffStart; // 0xAC
	[FormerlySerializedAs("fadeEnd")]
	public float fallOffEnd; // 0xB0
	[FormerlySerializedAs("fadeEndFromLight")]
	public bool fallOffEndFromLight; // 0xB4
	[Min(0)]
	public float fallOffEndMultiplier; // 0xB8
	public float depthBlendDistance; // 0xBC
	public float cameraClippingDistance; // 0xC0
	[Range(0, 1)]
	public float glareFrontal; // 0xC4
	[Range(0, 1)]
	public float glareBehind; // 0xC8
	[FormerlySerializedAs("fresnelPowOutside")]
	public float fresnelPow; // 0xCC
	public NoiseMode noiseMode; // 0xD0
	[Range(0, 1)]
	public float noiseIntensity; // 0xD4
	public bool noiseScaleUseGlobal; // 0xD8
	[Range(0.01, 2)]
	public float noiseScaleLocal; // 0xDC
	public bool noiseVelocityUseGlobal; // 0xE0
	public Vector3 noiseVelocityLocal; // 0xE4
	public Dimensions dimensions; // 0xF0
	public Vector2 tiltFactor; // 0xF4
	private MaterialManager.SD.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode; // 0xFC
	private bool m_INTERNAL_DynamicOcclusionMode_Runtime; // 0x100
	[CompilerGenerated]
	private VolumetricLightBeamSD.OnWillCameraRenderCB onWillCameraRenderThisBeam; // 0x108
	private VolumetricLightBeamSD.OnBeamGeometryInitialized m_OnBeamGeometryInitialized; // 0x110
	[FormerlySerializedAs("trackChangesDuringPlaytime")]
	[SerializeField]
	private bool _TrackChangesDuringPlaytime; // 0x118
	[SerializeField]
	private int _SortingLayerID; // 0x11C
	[SerializeField]
	private int _SortingOrder; // 0x120
	[FormerlySerializedAs("fadeOutBegin")]
	[SerializeField]
	private float _FadeOutBegin; // 0x124
	[FormerlySerializedAs("fadeOutEnd")]
	[SerializeField]
	private float _FadeOutEnd; // 0x128
	[CompilerGenerated]
	private uint <_INTERNAL_InstancedMaterialGroupID>k__BackingField; // 0x12C
	private BeamGeometrySD m_BeamGeom; // 0x130
	private Coroutine m_CoPlaytimeUpdate; // 0x138

	// Properties
	public ColorMode usedColorMode { get; }
	private bool useColorFromAttachedLightSpot { get; }
	private bool useColorTemperatureFromAttachedLightSpot { get; }
	[Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
	public float alphaInside { get; set; }
	[Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
	public float alphaOutside { get; set; }
	public float intensityGlobal { get; set; }
	public bool useIntensityFromAttachedLightSpot { get; }
	public bool useSpotAngleFromAttachedLightSpot { get; }
	public float coneAngle { get; }
	public float coneRadiusEnd { get; set; }
	public float coneVolume { get; }
	public float coneApexOffsetZ { get; }
	public Vector3 coneApexPositionLocal { get; }
	public Vector3 coneApexPositionGlobal { get; }
	public int geomSides { get; set; }
	public int geomSegments { get; set; }
	public Vector3 skewingLocalForwardDirectionNormalized { get; }
	public bool canHaveMeshSkewing { get; }
	public bool hasMeshSkewing { get; }
	public Vector4 additionalClippingPlane { get; }
	public float attenuationLerpLinearQuad { get; }
	[Obsolete("Use 'fallOffStart' instead")]
	public float fadeStart { get; set; }
	[Obsolete("Use 'fallOffEnd' instead")]
	public float fadeEnd { get; set; }
	[Obsolete("Use 'fallOffEndFromLight' instead")]
	public bool fadeEndFromLight { get; set; }
	public bool useFallOffEndFromAttachedLightSpot { get; }
	public float maxGeometryDistance { get; }
	public bool isNoiseEnabled { get; }
	[Obsolete("Use 'noiseMode' instead")]
	public bool noiseEnabled { get; set; }
	public float fadeOutBegin { get; set; }
	public float fadeOutEnd { get; set; }
	public bool isFadeOutEnabled { get; }
	public bool isTilted { get; }
	public int sortingLayerID { get; set; }
	public string sortingLayerName { get; set; }
	public int sortingOrder { get; set; }
	public bool trackChangesDuringPlaytime { get; set; }
	public bool isCurrentlyTrackingChanges { get; }
	public int blendingModeAsInt { get; }
	public Quaternion beamInternalLocalRotation { get; }
	public Vector3 beamLocalForward { get; }
	public Vector3 beamGlobalForward { get; }
	public float raycastDistance { get; }
	public Vector3 raycastGlobalForward { get; }
	public Vector3 raycastGlobalUp { get; }
	public Vector3 raycastGlobalRight { get; }
	public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode { get; set; }
	public MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime { get; }
	public uint _INTERNAL_InstancedMaterialGroupID { get; set; }
	public string meshStats { get; }
	public int meshVerticesCount { get; }
	public int meshTrianglesCount { get; }

	// Methods

	// RVA: 0x6A5130 Offset: 0x6A3B30 VA: 0x1806A5130
	public ColorMode get_usedColorMode() { }

	// RVA: 0x7C2230 Offset: 0x7C0C30 VA: 0x1807C2230
	private bool get_useColorFromAttachedLightSpot() { }

	// RVA: 0x7C2290 Offset: 0x7C0C90 VA: 0x1807C2290
	private bool get_useColorTemperatureFromAttachedLightSpot() { }

	// RVA: 0x4B5420 Offset: 0x4B3E20 VA: 0x1804B5420
	public float get_alphaInside() { }

	// RVA: 0x66B050 Offset: 0x669A50 VA: 0x18066B050
	public void set_alphaInside(float value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_alphaOutside() { }

	// RVA: 0x66B040 Offset: 0x669A40 VA: 0x18066B040
	public void set_alphaOutside(float value) { }

	// RVA: 0x4B6210 Offset: 0x4B4C10 VA: 0x1804B6210
	public float get_intensityGlobal() { }

	// RVA: 0x7C27F0 Offset: 0x7C11F0 VA: 0x1807C27F0
	public void set_intensityGlobal(float value) { }

	// RVA: 0x7C23A0 Offset: 0x7C0DA0 VA: 0x1807C23A0
	public bool get_useIntensityFromAttachedLightSpot() { }

	// RVA: 0x7BFF50 Offset: 0x7BE950 VA: 0x1807BFF50
	public void GetInsideAndOutsideIntensity(out float inside, out float outside) { }

	// RVA: 0x7C2400 Offset: 0x7C0E00 VA: 0x1807C2400
	public bool get_useSpotAngleFromAttachedLightSpot() { }

	// RVA: 0x7C1460 Offset: 0x7BFE60 VA: 0x1807C1460
	public float get_coneAngle() { }

	// RVA: 0x7C1700 Offset: 0x7C0100 VA: 0x1807C1700
	public float get_coneRadiusEnd() { }

	// RVA: 0x7C2520 Offset: 0x7C0F20 VA: 0x1807C2520
	public void set_coneRadiusEnd(float value) { }

	// RVA: 0x7C1760 Offset: 0x7C0160 VA: 0x1807C1760
	public float get_coneVolume() { }

	// RVA: 0x7C1510 Offset: 0x7BFF10 VA: 0x1807C1510
	public float get_coneApexOffsetZ() { }

	// RVA: 0x7C16D0 Offset: 0x7C00D0 VA: 0x1807C16D0
	public Vector3 get_coneApexPositionLocal() { }

	// RVA: 0x7C15E0 Offset: 0x7BFFE0 VA: 0x1807C15E0
	public Vector3 get_coneApexPositionGlobal() { }

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 6
	public override bool IsScalable() { }

	// RVA: 0x7C1850 Offset: 0x7C0250 VA: 0x1807C1850
	public int get_geomSides() { }

	// RVA: 0x7C26F0 Offset: 0x7C10F0 VA: 0x1807C26F0
	public void set_geomSides(int value) { }

	// RVA: 0x7C1820 Offset: 0x7C0220 VA: 0x1807C1820
	public int get_geomSegments() { }

	// RVA: 0x7C25F0 Offset: 0x7C0FF0 VA: 0x1807C25F0
	public void set_geomSegments(int value) { }

	// RVA: 0x7C2080 Offset: 0x7C0A80 VA: 0x1807C2080
	public Vector3 get_skewingLocalForwardDirectionNormalized() { }

	// RVA: 0x7C1450 Offset: 0x7BFE50 VA: 0x1807C1450
	public bool get_canHaveMeshSkewing() { }

	// RVA: 0x7C1880 Offset: 0x7C0280 VA: 0x1807C1880
	public bool get_hasMeshSkewing() { }

	// RVA: 0x7C0F60 Offset: 0x7BF960 VA: 0x1807C0F60
	public Vector4 get_additionalClippingPlane() { }

	// RVA: 0x7C10D0 Offset: 0x7BFAD0 VA: 0x1807C10D0
	public float get_attenuationLerpLinearQuad() { }

	// RVA: 0x7C1810 Offset: 0x7C0210 VA: 0x1807C1810
	public float get_fadeStart() { }

	// RVA: 0x7C25E0 Offset: 0x7C0FE0 VA: 0x1807C25E0
	public void set_fadeStart(float value) { }

	// RVA: 0x7C1800 Offset: 0x7C0200 VA: 0x1807C1800
	public float get_fadeEnd() { }

	// RVA: 0x7C2590 Offset: 0x7C0F90 VA: 0x1807C2590
	public void set_fadeEnd(float value) { }

	// RVA: 0x7C17F0 Offset: 0x7C01F0 VA: 0x1807C17F0
	public bool get_fadeEndFromLight() { }

	// RVA: 0x7C2580 Offset: 0x7C0F80 VA: 0x1807C2580
	public void set_fadeEndFromLight(bool value) { }

	// RVA: 0x7C2330 Offset: 0x7C0D30 VA: 0x1807C2330
	public bool get_useFallOffEndFromAttachedLightSpot() { }

	// RVA: 0x7C1A30 Offset: 0x7C0430 VA: 0x1807C1A30
	public float get_maxGeometryDistance() { }

	// RVA: 0x7C19A0 Offset: 0x7C03A0 VA: 0x1807C19A0
	public bool get_isNoiseEnabled() { }

	// RVA: 0x7C19A0 Offset: 0x7C03A0 VA: 0x1807C19A0
	public bool get_noiseEnabled() { }

	// RVA: 0x7C2800 Offset: 0x7C1200 VA: 0x1807C2800
	public void set_noiseEnabled(bool value) { }

	// RVA: 0x512AC0 Offset: 0x5114C0 VA: 0x180512AC0
	public float get_fadeOutBegin() { }

	// RVA: 0x7C25A0 Offset: 0x7C0FA0 VA: 0x1807C25A0
	public void set_fadeOutBegin(float value) { }

	// RVA: 0x512C10 Offset: 0x511610 VA: 0x180512C10
	public float get_fadeOutEnd() { }

	// RVA: 0x7C25C0 Offset: 0x7C0FC0 VA: 0x1807C25C0
	public void set_fadeOutEnd(float value) { }

	// RVA: 0x7C1970 Offset: 0x7C0370 VA: 0x1807C1970
	public bool get_isFadeOutEnabled() { }

	// RVA: 0x7C19B0 Offset: 0x7C03B0 VA: 0x1807C19B0
	public bool get_isTilted() { }

	// RVA: 0x513340 Offset: 0x511D40 VA: 0x180513340
	public int get_sortingLayerID() { }

	// RVA: 0x7C2820 Offset: 0x7C1220 VA: 0x1807C2820
	public void set_sortingLayerID(int value) { }

	// RVA: 0x7C2220 Offset: 0x7C0C20 VA: 0x1807C2220
	public string get_sortingLayerName() { }

	// RVA: 0x7C28C0 Offset: 0x7C12C0 VA: 0x1807C28C0
	public void set_sortingLayerName(string value) { }

	// RVA: 0x5232D0 Offset: 0x521CD0 VA: 0x1805232D0
	public int get_sortingOrder() { }

	// RVA: 0x7C2970 Offset: 0x7C1370 VA: 0x1807C2970
	public void set_sortingOrder(int value) { }

	// RVA: 0x51D980 Offset: 0x51C380 VA: 0x18051D980
	public bool get_trackChangesDuringPlaytime() { }

	// RVA: 0x7C2A10 Offset: 0x7C1410 VA: 0x1807C2A10
	public void set_trackChangesDuringPlaytime(bool value) { }

	// RVA: 0x7C1960 Offset: 0x7C0360 VA: 0x1807C1960
	public bool get_isCurrentlyTrackingChanges() { }

	// RVA: 0x65D840 Offset: 0x65C240 VA: 0x18065D840 Slot: 4
	public override BeamGeometryAbstractBase GetBeamGeometry() { }

	// RVA: 0x7C0780 Offset: 0x7BF180 VA: 0x1807C0780 Slot: 5
	protected override void SetBeamGeometryNull() { }

	// RVA: 0x7C1380 Offset: 0x7BFD80 VA: 0x1807C1380
	public int get_blendingModeAsInt() { }

	// RVA: 0x7C11E0 Offset: 0x7BFBE0 VA: 0x1807C11E0
	public Quaternion get_beamInternalLocalRotation() { }

	// RVA: 0x7C12E0 Offset: 0x7BFCE0 VA: 0x1807C12E0
	public Vector3 get_beamLocalForward() { }

	// RVA: 0x7C1100 Offset: 0x7BFB00 VA: 0x1807C1100
	public Vector3 get_beamGlobalForward() { }

	// RVA: 0x7C02B0 Offset: 0x7BECB0 VA: 0x1807C02B0 Slot: 7
	public override Vector3 GetLossyScale() { }

	// RVA: 0x7C1E20 Offset: 0x7C0820 VA: 0x1807C1E20
	public float get_raycastDistance() { }

	// RVA: 0x7BFB30 Offset: 0x7BE530 VA: 0x1807BFB30
	private Vector3 ComputeRaycastGlobalVector(Vector3 localVec) { }

	// RVA: 0x7C1ED0 Offset: 0x7C08D0 VA: 0x1807C1ED0
	public Vector3 get_raycastGlobalForward() { }

	// RVA: 0x7C2000 Offset: 0x7C0A00 VA: 0x1807C2000
	public Vector3 get_raycastGlobalUp() { }

	// RVA: 0x7C1F80 Offset: 0x7C0980 VA: 0x1807C1F80
	public Vector3 get_raycastGlobalRight() { }

	// RVA: 0x7C0F20 Offset: 0x7BF920 VA: 0x1807C0F20
	public MaterialManager.SD.DynamicOcclusion get__INTERNAL_DynamicOcclusionMode() { }

	// RVA: 0x7C2510 Offset: 0x7C0F10 VA: 0x1807C2510
	public void set__INTERNAL_DynamicOcclusionMode(MaterialManager.SD.DynamicOcclusion value) { }

	// RVA: 0x7C0ED0 Offset: 0x7BF8D0 VA: 0x1807C0ED0
	public MaterialManager.SD.DynamicOcclusion get__INTERNAL_DynamicOcclusionMode_Runtime() { }

	// RVA: 0x7C0B10 Offset: 0x7BF510 VA: 0x1807C0B10
	public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb) { }

	[CompilerGenerated]
	// RVA: 0x7C0E20 Offset: 0x7BF820 VA: 0x1807C0E20
	public void add_onWillCameraRenderThisBeam(VolumetricLightBeamSD.OnWillCameraRenderCB value) { }

	[CompilerGenerated]
	// RVA: 0x7C2460 Offset: 0x7C0E60 VA: 0x1807C2460
	public void remove_onWillCameraRenderThisBeam(VolumetricLightBeamSD.OnWillCameraRenderCB value) { }

	// RVA: 0x7C0AE0 Offset: 0x7BF4E0 VA: 0x1807C0AE0
	public void _INTERNAL_OnWillCameraRenderThisBeam(Camera cam) { }

	// RVA: 0x7C0650 Offset: 0x7BF050 VA: 0x1807C0650
	public void RegisterOnBeamGeometryInitializedCallback(VolumetricLightBeamSD.OnBeamGeometryInitialized cb) { }

	// RVA: 0x7BF890 Offset: 0x7BE290 VA: 0x1807BF890
	private void CallOnBeamGeometryInitializedCallback() { }

	// RVA: 0x7C07A0 Offset: 0x7BF1A0 VA: 0x1807C07A0
	private void SetFadeOutValue(ref float propToChange, float value) { }

	// RVA: 0x7C05B0 Offset: 0x7BEFB0 VA: 0x1807C05B0
	private void OnFadeOutStateChanged() { }

	[CompilerGenerated]
	// RVA: 0x618100 Offset: 0x616B00 VA: 0x180618100
	public uint get__INTERNAL_InstancedMaterialGroupID() { }

	[CompilerGenerated]
	// RVA: 0x618180 Offset: 0x616B80 VA: 0x180618180
	protected void set__INTERNAL_InstancedMaterialGroupID(uint value) { }

	// RVA: 0x7C1A60 Offset: 0x7C0460 VA: 0x1807C1A60
	public string get_meshStats() { }

	// RVA: 0x7C1D60 Offset: 0x7C0760 VA: 0x1807C1D60
	public int get_meshVerticesCount() { }

	// RVA: 0x7C1C80 Offset: 0x7C0680 VA: 0x1807C1C80
	public int get_meshTrianglesCount() { }

	// RVA: 0x7C0230 Offset: 0x7BEC30 VA: 0x1807C0230
	public float GetInsideBeamFactor(Vector3 posWS) { }

	// RVA: 0x7BFF80 Offset: 0x7BE980 VA: 0x1807BFF80
	public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS) { }

	[Obsolete("Use 'GenerateGeometry()' instead")]
	// RVA: 0x7BFF30 Offset: 0x7BE930 VA: 0x1807BFF30
	public void Generate() { }

	// RVA: 0x7BFD60 Offset: 0x7BE760 VA: 0x1807BFD60 Slot: 8
	public virtual void GenerateGeometry() { }

	// RVA: 0x7C0A30 Offset: 0x7BF430 VA: 0x1807C0A30 Slot: 9
	public virtual void UpdateAfterManualPropertyChange() { }

	// RVA: 0x7C0970 Offset: 0x7BF370 VA: 0x1807C0970
	private void Start() { }

	// RVA: 0x7C0510 Offset: 0x7BEF10 VA: 0x1807C0510
	private void OnEnable() { }

	// RVA: 0x7C0440 Offset: 0x7BEE40 VA: 0x1807C0440
	private void OnDisable() { }

	// RVA: 0x7C0890 Offset: 0x7BF290 VA: 0x1807C0890
	private void StartPlaytimeUpdateIfNeeded() { }

	[IteratorStateMachine(typeof(VolumetricLightBeamSD.<CoPlaytimeUpdate>d__199))]
	// RVA: 0x7BFAC0 Offset: 0x7BE4C0 VA: 0x1807BFAC0
	private IEnumerator CoPlaytimeUpdate() { }

	// RVA: 0x7BF4B0 Offset: 0x7BDEB0 VA: 0x1807BF4B0
	private void AssignPropertiesFromAttachedSpotLight() { }

	// RVA: 0x7BF8E0 Offset: 0x7BE2E0 VA: 0x1807BF8E0
	private void ClampProperties() { }

	// RVA: 0x7C0AC0 Offset: 0x7BF4C0 VA: 0x1807C0AC0
	private void ValidateProperties() { }

	// RVA: 0x7C03A0 Offset: 0x7BEDA0 VA: 0x1807C03A0
	private void HandleBackwardCompatibility(int serializedVersion, int newVersion) { }

	// RVA: 0x7C0C40 Offset: 0x7BF640 VA: 0x1807C0C40
	public void .ctor() { }
}
