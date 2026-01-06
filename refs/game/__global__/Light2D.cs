public sealed class Light2D : Light2DBase, ISerializationCallbackReceiver // TypeDefIndex: 8694
{
	// Fields
	private const Light2D.ComponentVersions k_CurrentComponentVersion = 1;
	[SerializeField]
	private Light2D.ComponentVersions m_ComponentVersion; // 0x20
	[NotKeyable]
	[SerializeField]
	private Light2D.LightType m_LightType; // 0x24
	[SerializeField]
	[FormerlySerializedAs("m_LightOperationIndex")]
	private int m_BlendStyleIndex; // 0x28
	[SerializeField]
	private float m_FalloffIntensity; // 0x2C
	[ColorUsage(True)]
	[SerializeField]
	private Color m_Color; // 0x30
	[SerializeField]
	private float m_Intensity; // 0x40
	[FormerlySerializedAs("m_LightVolumeOpacity")]
	[SerializeField]
	private float m_LightVolumeIntensity; // 0x44
	[SerializeField]
	private bool m_LightVolumeIntensityEnabled; // 0x48
	[SerializeField]
	private int[] m_ApplyToSortingLayers; // 0x50
	[Reload("Textures/2D/Sparkle.png", 1)]
	[SerializeField]
	private Sprite m_LightCookieSprite; // 0x58
	[FormerlySerializedAs("m_LightCookieSprite")]
	[SerializeField]
	private Sprite m_DeprecatedPointLightCookieSprite; // 0x60
	[SerializeField]
	private int m_LightOrder; // 0x68
	[SerializeField]
	private bool m_AlphaBlendOnOverlap; // 0x6C
	[SerializeField]
	private Light2D.OverlapOperation m_OverlapOperation; // 0x70
	[SerializeField]
	[FormerlySerializedAs("m_PointLightDistance")]
	private float m_NormalMapDistance; // 0x74
	[SerializeField]
	[FormerlySerializedAs("m_PointLightQuality")]
	[NotKeyable]
	private Light2D.NormalMapQuality m_NormalMapQuality; // 0x78
	[SerializeField]
	private bool m_UseNormalMap; // 0x7C
	[SerializeField]
	private bool m_ShadowIntensityEnabled; // 0x7D
	[Range(0, 1)]
	[SerializeField]
	private float m_ShadowIntensity; // 0x80
	[SerializeField]
	private bool m_ShadowVolumeIntensityEnabled; // 0x84
	[Range(0, 1)]
	[SerializeField]
	private float m_ShadowVolumeIntensity; // 0x88
	private Mesh m_Mesh; // 0x90
	private LightUtility.LightMeshVertex[] m_Vertices; // 0x98
	private ushort[] m_Triangles; // 0xA0
	private int m_PreviousLightCookieSprite; // 0xA8
	internal Vector3 m_CachedPosition; // 0xAC
	[SerializeField]
	private Bounds m_LocalBounds; // 0xB8
	[CompilerGenerated]
	private BoundingSphere <boundingSphere>k__BackingField; // 0xD0
	internal bool forceUpdate; // 0xE0
	[SerializeField]
	private float m_PointLightInnerAngle; // 0xE4
	[SerializeField]
	private float m_PointLightOuterAngle; // 0xE8
	[SerializeField]
	private float m_PointLightInnerRadius; // 0xEC
	[SerializeField]
	private float m_PointLightOuterRadius; // 0xF0
	[SerializeField]
	private int m_ShapeLightParametricSides; // 0xF4
	[SerializeField]
	private float m_ShapeLightParametricAngleOffset; // 0xF8
	[SerializeField]
	private float m_ShapeLightParametricRadius; // 0xFC
	[SerializeField]
	private float m_ShapeLightFalloffSize; // 0x100
	[SerializeField]
	private Vector2 m_ShapeLightFalloffOffset; // 0x104
	[SerializeField]
	private Vector3[] m_ShapePath; // 0x110
	private float m_PreviousShapeLightFalloffSize; // 0x118
	private int m_PreviousShapeLightParametricSides; // 0x11C
	private float m_PreviousShapeLightParametricAngleOffset; // 0x120
	private float m_PreviousShapeLightParametricRadius; // 0x124
	private int m_PreviousShapePathHash; // 0x128
	private Light2D.LightType m_PreviousLightType; // 0x12C

	// Properties
	internal LightUtility.LightMeshVertex[] vertices { get; set; }
	internal ushort[] indices { get; set; }
	internal int[] affectedSortingLayers { get; }
	private int lightCookieSpriteInstanceID { get; }
	internal BoundingSphere boundingSphere { get; set; }
	internal Mesh lightMesh { get; }
	internal bool hasCachedMesh { get; }
	public Light2D.LightType lightType { get; set; }
	public int blendStyleIndex { get; set; }
	public float shadowIntensity { get; set; }
	public bool shadowsEnabled { get; set; }
	public float shadowVolumeIntensity { get; set; }
	public bool volumetricShadowsEnabled { get; set; }
	public Color color { get; set; }
	public float intensity { get; set; }
	[Obsolete]
	public float volumeOpacity { get; }
	public float volumeIntensity { get; set; }
	public bool volumeIntensityEnabled { get; set; }
	public Sprite lightCookieSprite { get; set; }
	public float falloffIntensity { get; set; }
	[Obsolete]
	public bool alphaBlendOnOverlap { get; }
	public Light2D.OverlapOperation overlapOperation { get; set; }
	public int lightOrder { get; set; }
	public float normalMapDistance { get; }
	public Light2D.NormalMapQuality normalMapQuality { get; }
	public bool renderVolumetricShadows { get; }
	public float pointLightInnerAngle { get; set; }
	public float pointLightOuterAngle { get; set; }
	public float pointLightInnerRadius { get; set; }
	public float pointLightOuterRadius { get; set; }
	[Obsolete("pointLightDistance has been changed to normalMapDistance", True)]
	public float pointLightDistance { get; }
	[Obsolete("pointLightQuality has been changed to normalMapQuality", True)]
	public Light2D.NormalMapQuality pointLightQuality { get; }
	internal bool isPointLight { get; }
	public int shapeLightParametricSides { get; }
	public float shapeLightParametricAngleOffset { get; }
	public float shapeLightParametricRadius { get; set; }
	public float shapeLightFalloffSize { get; set; }
	public Vector3[] shapePath { get; set; }

	// Methods

	// RVA: 0xAA7250 Offset: 0xAA5C50 VA: 0x180AA7250
	internal LightUtility.LightMeshVertex[] get_vertices() { }

	// RVA: 0xAA72B0 Offset: 0xAA5CB0 VA: 0x180AA72B0
	internal void set_vertices(LightUtility.LightMeshVertex[] value) { }

	// RVA: 0x4B6190 Offset: 0x4B4B90 VA: 0x1804B6190
	internal ushort[] get_indices() { }

	// RVA: 0x4B6D00 Offset: 0x4B5700 VA: 0x1804B6D00
	internal void set_indices(ushort[] value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	internal int[] get_affectedSortingLayers() { }

	// RVA: 0x2A7E530 Offset: 0x2A7CF30 VA: 0x182A7E530
	private int get_lightCookieSpriteInstanceID() { }

	[CompilerGenerated]
	// RVA: 0x8D2100 Offset: 0x8D0B00 VA: 0x1808D2100
	internal BoundingSphere get_boundingSphere() { }

	[CompilerGenerated]
	// RVA: 0x1EFFB50 Offset: 0x1EFE550 VA: 0x181EFFB50
	private void set_boundingSphere(BoundingSphere value) { }

	// RVA: 0x2A7E560 Offset: 0x2A7CF60 VA: 0x182A7E560
	internal Mesh get_lightMesh() { }

	// RVA: 0x2A7E4E0 Offset: 0x2A7CEE0 VA: 0x182A7E4E0
	internal bool get_hasCachedMesh() { }

	// RVA: 0x49CD40 Offset: 0x49B740 VA: 0x18049CD40
	public Light2D.LightType get_lightType() { }

	// RVA: 0x2A7E680 Offset: 0x2A7D080 VA: 0x182A7E680
	public void set_lightType(Light2D.LightType value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public int get_blendStyleIndex() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_blendStyleIndex(int value) { }

	// RVA: 0x6A5300 Offset: 0x6A3D00 VA: 0x1806A5300
	public float get_shadowIntensity() { }

	// RVA: 0x2A7E700 Offset: 0x2A7D100 VA: 0x182A7E700
	public void set_shadowIntensity(float value) { }

	// RVA: 0x2A7E630 Offset: 0x2A7D030 VA: 0x182A7E630
	public bool get_shadowsEnabled() { }

	// RVA: 0x2A7E760 Offset: 0x2A7D160 VA: 0x182A7E760
	public void set_shadowsEnabled(bool value) { }

	// RVA: 0x6A5250 Offset: 0x6A3C50 VA: 0x1806A5250
	public float get_shadowVolumeIntensity() { }

	// RVA: 0x2A7E730 Offset: 0x2A7D130 VA: 0x182A7E730
	public void set_shadowVolumeIntensity(float value) { }

	// RVA: 0x4CD060 Offset: 0x4CBA60 VA: 0x1804CD060
	public bool get_volumetricShadowsEnabled() { }

	// RVA: 0x4CED80 Offset: 0x4CD780 VA: 0x1804CED80
	public void set_volumetricShadowsEnabled(bool value) { }

	// RVA: 0x6FC320 Offset: 0x6FAD20 VA: 0x1806FC320
	public Color get_color() { }

	// RVA: 0x6FC3B0 Offset: 0x6FADB0 VA: 0x1806FC3B0
	public void set_color(Color value) { }

	// RVA: 0x495F60 Offset: 0x494960 VA: 0x180495F60
	public float get_intensity() { }

	// RVA: 0x49D330 Offset: 0x49BD30 VA: 0x18049D330
	public void set_intensity(float value) { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_volumeOpacity() { }

	// RVA: 0x49D270 Offset: 0x49BC70 VA: 0x18049D270
	public float get_volumeIntensity() { }

	// RVA: 0x49D340 Offset: 0x49BD40 VA: 0x18049D340
	public void set_volumeIntensity(float value) { }

	// RVA: 0x4D60D0 Offset: 0x4D4AD0 VA: 0x1804D60D0
	public bool get_volumeIntensityEnabled() { }

	// RVA: 0x4D6480 Offset: 0x4D4E80 VA: 0x1804D6480
	public void set_volumeIntensityEnabled(bool value) { }

	// RVA: 0x2A7E550 Offset: 0x2A7CF50 VA: 0x182A7E550
	public Sprite get_lightCookieSprite() { }

	// RVA: 0x4993E0 Offset: 0x497DE0 VA: 0x1804993E0
	public void set_lightCookieSprite(Sprite value) { }

	// RVA: 0x4971C0 Offset: 0x495BC0 VA: 0x1804971C0
	public float get_falloffIntensity() { }

	// RVA: 0x2A7E650 Offset: 0x2A7D050 VA: 0x182A7E650
	public void set_falloffIntensity(float value) { }

	// RVA: 0x2A7E4D0 Offset: 0x2A7CED0 VA: 0x182A7E4D0
	public bool get_alphaBlendOnOverlap() { }

	// RVA: 0x501290 Offset: 0x4FFC90 VA: 0x180501290
	public Light2D.OverlapOperation get_overlapOperation() { }

	// RVA: 0xA9F800 Offset: 0xA9E200 VA: 0x180A9F800
	public void set_overlapOperation(Light2D.OverlapOperation value) { }

	// RVA: 0x54CEB0 Offset: 0x54B8B0 VA: 0x18054CEB0
	public int get_lightOrder() { }

	// RVA: 0x54CF80 Offset: 0x54B980 VA: 0x18054CF80
	public void set_lightOrder(int value) { }

	// RVA: 0x4CD180 Offset: 0x4CBB80 VA: 0x1804CD180
	public float get_normalMapDistance() { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public Light2D.NormalMapQuality get_normalMapQuality() { }

	// RVA: 0x2A7E610 Offset: 0x2A7D010 VA: 0x182A7E610
	public bool get_renderVolumetricShadows() { }

	// RVA: 0x2A7D810 Offset: 0x2A7C210 VA: 0x182A7D810
	internal void MarkForUpdate() { }

	// RVA: 0x2A7D600 Offset: 0x2A7C000 VA: 0x182A7D600
	internal void CacheValues() { }

	// RVA: 0x2A7D650 Offset: 0x2A7C050 VA: 0x182A7D650
	internal int GetTopMostLitLayer() { }

	// RVA: 0x2A7E220 Offset: 0x2A7CC20 VA: 0x182A7E220
	internal Bounds UpdateSpriteMesh() { }

	// RVA: 0x2A7DE80 Offset: 0x2A7C880 VA: 0x182A7DE80
	internal void UpdateMesh(bool forceUpdate = False) { }

	// RVA: 0x2A7DAE0 Offset: 0x2A7C4E0 VA: 0x182A7DAE0
	internal void UpdateBoundingSphere() { }

	// RVA: 0x2A7D780 Offset: 0x2A7C180 VA: 0x182A7D780
	internal bool IsLitLayer(int layer) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Awake() { }

	// RVA: 0x2A7D980 Offset: 0x2A7C380 VA: 0x182A7D980
	private void OnEnable() { }

	// RVA: 0x2A7D8A0 Offset: 0x2A7C2A0 VA: 0x182A7D8A0
	private void OnDisable() { }

	// RVA: 0x2A7D7D0 Offset: 0x2A7C1D0 VA: 0x182A7D7D0
	private void LateUpdate() { }

	// RVA: 0x2A7D890 Offset: 0x2A7C290 VA: 0x182A7D890 Slot: 4
	public void OnBeforeSerialize() { }

	// RVA: 0x2A7D820 Offset: 0x2A7C220 VA: 0x182A7D820 Slot: 5
	public void OnAfterDeserialize() { }

	// RVA: 0x510800 Offset: 0x50F200 VA: 0x180510800
	public float get_pointLightInnerAngle() { }

	// RVA: 0x2A7E6F0 Offset: 0x2A7D0F0 VA: 0x182A7E6F0
	public void set_pointLightInnerAngle(float value) { }

	// RVA: 0x8D2110 Offset: 0x8D0B10 VA: 0x1808D2110
	public float get_pointLightOuterAngle() { }

	// RVA: 0x10F99D0 Offset: 0x10F83D0 VA: 0x1810F99D0
	public void set_pointLightOuterAngle(float value) { }

	// RVA: 0x51D960 Offset: 0x51C360 VA: 0x18051D960
	public float get_pointLightInnerRadius() { }

	// RVA: 0xA63CD0 Offset: 0xA626D0 VA: 0x180A63CD0
	public void set_pointLightInnerRadius(float value) { }

	// RVA: 0xABF1D0 Offset: 0xABDBD0 VA: 0x180ABF1D0
	public float get_pointLightOuterRadius() { }

	// RVA: 0x10F9A10 Offset: 0x10F8410 VA: 0x1810F9A10
	public void set_pointLightOuterRadius(float value) { }

	// RVA: 0x4CD180 Offset: 0x4CBB80 VA: 0x1804CD180
	public float get_pointLightDistance() { }

	// RVA: 0x553640 Offset: 0x552040 VA: 0x180553640
	public Light2D.NormalMapQuality get_pointLightQuality() { }

	// RVA: 0x2A7E520 Offset: 0x2A7CF20 VA: 0x182A7E520
	internal bool get_isPointLight() { }

	// RVA: 0xD9E760 Offset: 0xD9D160 VA: 0x180D9E760
	public int get_shapeLightParametricSides() { }

	// RVA: 0x2A7E640 Offset: 0x2A7D040 VA: 0x182A7E640
	public float get_shapeLightParametricAngleOffset() { }

	// RVA: 0x4CD090 Offset: 0x4CBA90 VA: 0x1804CD090
	public float get_shapeLightParametricRadius() { }

	// RVA: 0x4CEE40 Offset: 0x4CD840 VA: 0x1804CEE40
	internal void set_shapeLightParametricRadius(float value) { }

	// RVA: 0x4CD8A0 Offset: 0x4CC2A0 VA: 0x1804CD8A0
	public float get_shapeLightFalloffSize() { }

	// RVA: 0x2A7E770 Offset: 0x2A7D170 VA: 0x182A7E770
	public void set_shapeLightFalloffSize(float value) { }

	// RVA: 0x5231F0 Offset: 0x521BF0 VA: 0x1805231F0
	public Vector3[] get_shapePath() { }

	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	internal void set_shapePath(Vector3[] value) { }

	// RVA: 0x8937F0 Offset: 0x8921F0 VA: 0x1808937F0
	public void SetShapePath(Vector3[] path) { }

	// RVA: 0x2A7E350 Offset: 0x2A7CD50 VA: 0x182A7E350
	public void .ctor() { }
}
