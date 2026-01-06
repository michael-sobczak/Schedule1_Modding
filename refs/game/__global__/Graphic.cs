public abstract class Graphic : UIBehaviour, ICanvasElement // TypeDefIndex: 16395
{
	// Fields
	protected static Material s_DefaultUI; // 0x0
	protected static Texture2D s_WhiteTexture; // 0x8
	[SerializeField]
	[FormerlySerializedAs("m_Mat")]
	protected Material m_Material; // 0x20
	[SerializeField]
	private Color m_Color; // 0x28
	protected bool m_SkipLayoutUpdate; // 0x38
	protected bool m_SkipMaterialUpdate; // 0x39
	[SerializeField]
	private bool m_RaycastTarget; // 0x3A
	private bool m_RaycastTargetCache; // 0x3B
	[SerializeField]
	private Vector4 m_RaycastPadding; // 0x3C
	private RectTransform m_RectTransform; // 0x50
	private CanvasRenderer m_CanvasRenderer; // 0x58
	private Canvas m_Canvas; // 0x60
	private bool m_VertsDirty; // 0x68
	private bool m_MaterialDirty; // 0x69
	protected UnityAction m_OnDirtyLayoutCallback; // 0x70
	protected UnityAction m_OnDirtyVertsCallback; // 0x78
	protected UnityAction m_OnDirtyMaterialCallback; // 0x80
	protected static Mesh s_Mesh; // 0x10
	private static readonly VertexHelper s_VertexHelper; // 0x18
	protected Mesh m_CachedMesh; // 0x88
	protected Vector2[] m_CachedUvs; // 0x90
	private readonly TweenRunner<ColorTween> m_ColorTweenRunner; // 0x98
	[CompilerGenerated]
	private bool <useLegacyMeshGeneration>k__BackingField; // 0xA0

	// Properties
	public static Material defaultGraphicMaterial { get; }
	public virtual Color color { get; set; }
	public virtual bool raycastTarget { get; set; }
	public Vector4 raycastPadding { get; set; }
	protected bool useLegacyMeshGeneration { get; set; }
	public int depth { get; }
	public RectTransform rectTransform { get; }
	public Canvas canvas { get; }
	public CanvasRenderer canvasRenderer { get; }
	public virtual Material defaultMaterial { get; }
	public virtual Material material { get; set; }
	public virtual Material materialForRendering { get; }
	public virtual Texture mainTexture { get; }
	protected static Mesh workerMesh { get; }

	// Methods

	// RVA: 0x2D9F450 Offset: 0x2D9DE50 VA: 0x182D9F450
	public static Material get_defaultGraphicMaterial() { }

	// RVA: 0x4D8510 Offset: 0x4D6F10 VA: 0x1804D8510 Slot: 22
	public virtual Color get_color() { }

	// RVA: 0x2D9FB10 Offset: 0x2D9E510 VA: 0x182D9FB10 Slot: 23
	public virtual void set_color(Color value) { }

	// RVA: 0x1B24E10 Offset: 0x1B23810 VA: 0x181B24E10 Slot: 24
	public virtual bool get_raycastTarget() { }

	// RVA: 0x2D9FC10 Offset: 0x2D9E610 VA: 0x182D9FC10 Slot: 25
	public virtual void set_raycastTarget(bool value) { }

	// RVA: 0x2D9F950 Offset: 0x2D9E350 VA: 0x182D9F950
	public Vector4 get_raycastPadding() { }

	// RVA: 0x2D9FC00 Offset: 0x2D9E600 VA: 0x182D9FC00
	public void set_raycastPadding(Vector4 value) { }

	[CompilerGenerated]
	// RVA: 0x6A52A0 Offset: 0x6A3CA0 VA: 0x1806A52A0
	protected bool get_useLegacyMeshGeneration() { }

	[CompilerGenerated]
	// RVA: 0xAE7D60 Offset: 0xAE6760 VA: 0x180AE7D60
	protected void set_useLegacyMeshGeneration(bool value) { }

	// RVA: 0x2D9F270 Offset: 0x2D9DC70 VA: 0x182D9F270
	protected void .ctor() { }

	// RVA: 0x2D9EAD0 Offset: 0x2D9D4D0 VA: 0x182D9EAD0 Slot: 26
	public virtual void SetAllDirty() { }

	// RVA: 0x2D9EB40 Offset: 0x2D9D540 VA: 0x182D9EB40 Slot: 27
	public virtual void SetLayoutDirty() { }

	// RVA: 0x2D9EDE0 Offset: 0x2D9D7E0 VA: 0x182D9EDE0 Slot: 28
	public virtual void SetVerticesDirty() { }

	// RVA: 0x2D9EC20 Offset: 0x2D9D620 VA: 0x182D9EC20 Slot: 29
	public virtual void SetMaterialDirty() { }

	// RVA: 0x2D9ED00 Offset: 0x2D9D700 VA: 0x182D9ED00
	public void SetRaycastDirty() { }

	// RVA: 0x2D9E160 Offset: 0x2D9CB60 VA: 0x182D9E160 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2D9D6B0 Offset: 0x2D9C0B0 VA: 0x182D9D6B0 Slot: 11
	protected override void OnBeforeTransformParentChanged() { }

	// RVA: 0x2D9E250 Offset: 0x2D9CC50 VA: 0x182D9E250 Slot: 12
	protected override void OnTransformParentChanged() { }

	// RVA: 0x2D9F670 Offset: 0x2D9E070 VA: 0x182D9F670
	public int get_depth() { }

	// RVA: 0x2D9F960 Offset: 0x2D9E360 VA: 0x182D9F960 Slot: 30
	public RectTransform get_rectTransform() { }

	// RVA: 0x2D9F3E0 Offset: 0x2D9DDE0 VA: 0x182D9F3E0
	public Canvas get_canvas() { }

	// RVA: 0x2D9C500 Offset: 0x2D9AF00 VA: 0x182D9C500
	private void CacheCanvas() { }

	// RVA: 0x2D9F340 Offset: 0x2D9DD40 VA: 0x182D9F340
	public CanvasRenderer get_canvasRenderer() { }

	// RVA: 0x2D9F550 Offset: 0x2D9DF50 VA: 0x182D9F550 Slot: 31
	public virtual Material get_defaultMaterial() { }

	// RVA: 0x2D9F8C0 Offset: 0x2D9E2C0 VA: 0x182D9F8C0 Slot: 32
	public virtual Material get_material() { }

	// RVA: 0x2D9FB60 Offset: 0x2D9E560 VA: 0x182D9FB60 Slot: 33
	public virtual void set_material(Material value) { }

	// RVA: 0x2D9F6F0 Offset: 0x2D9E0F0 VA: 0x182D9F6F0 Slot: 34
	public virtual Material get_materialForRendering() { }

	// RVA: 0x2D9F6A0 Offset: 0x2D9E0A0 VA: 0x182D9F6A0 Slot: 35
	public virtual Texture get_mainTexture() { }

	// RVA: 0x2D9DD20 Offset: 0x2D9C720 VA: 0x182D9DD20 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2D9DB60 Offset: 0x2D9C560 VA: 0x182D9DB60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2D9DA00 Offset: 0x2D9C400 VA: 0x182D9DA00 Slot: 8
	protected override void OnDestroy() { }

	// RVA: 0x2D9D7D0 Offset: 0x2D9C1D0 VA: 0x182D9D7D0 Slot: 15
	protected override void OnCanvasHierarchyChanged() { }

	// RVA: 0x2D9D930 Offset: 0x2D9C330 VA: 0x182D9D930 Slot: 36
	public virtual void OnCullingChanged() { }

	// RVA: 0x2D9E800 Offset: 0x2D9D200 VA: 0x182D9E800 Slot: 37
	public virtual void Rebuild(CanvasUpdate update) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 38
	public virtual void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 39
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2D9F0D0 Offset: 0x2D9DAD0 VA: 0x182D9F0D0 Slot: 40
	protected virtual void UpdateMaterial() { }

	// RVA: 0x2D9F0B0 Offset: 0x2D9DAB0 VA: 0x182D9F0B0 Slot: 41
	protected virtual void UpdateGeometry() { }

	// RVA: 0x2D9CF80 Offset: 0x2D9B980 VA: 0x182D9CF80
	private void DoMeshGeneration() { }

	// RVA: 0x2D9CA90 Offset: 0x2D9B490 VA: 0x182D9CA90
	private void DoLegacyMeshGeneration() { }

	// RVA: 0x2D9F9C0 Offset: 0x2D9E3C0 VA: 0x182D9F9C0
	protected static Mesh get_workerMesh() { }

	[EditorBrowsable(1)]
	[Obsolete("Use OnPopulateMesh instead.", True)]
	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 42
	protected virtual void OnFillVBO(List<UIVertex> vbo) { }

	[Obsolete("Use OnPopulateMesh(VertexHelper vh) instead.", False)]
	// RVA: 0x2D9DEB0 Offset: 0x2D9C8B0 VA: 0x182D9DEB0 Slot: 43
	protected virtual void OnPopulateMesh(Mesh m) { }

	// RVA: 0x2D9DF50 Offset: 0x2D9C950 VA: 0x182D9DF50 Slot: 44
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	// RVA: 0xB29900 Offset: 0xB28300 VA: 0x180B29900 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 45
	public virtual void SetNativeSize() { }

	// RVA: 0x2D9E4A0 Offset: 0x2D9CEA0 VA: 0x182D9E4A0 Slot: 46
	public virtual bool Raycast(Vector2 sp, Camera eventCamera) { }

	// RVA: 0x2D9E310 Offset: 0x2D9CD10 VA: 0x182D9E310
	public Vector2 PixelAdjustPoint(Vector2 point) { }

	// RVA: 0x2D9D4C0 Offset: 0x2D9BEC0 VA: 0x182D9D4C0
	public Rect GetPixelAdjustedRect() { }

	// RVA: 0x2D9CA50 Offset: 0x2D9B450 VA: 0x182D9CA50 Slot: 47
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha) { }

	// RVA: 0x2D9C770 Offset: 0x2D9B170 VA: 0x182D9C770 Slot: 48
	public virtual void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha, bool useRGB) { }

	// RVA: 0x2D9C680 Offset: 0x2D9B080 VA: 0x182D9C680
	private static Color CreateColorFromAlpha(float alpha) { }

	// RVA: 0x2D9C6A0 Offset: 0x2D9B0A0 VA: 0x182D9C6A0 Slot: 49
	public virtual void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale) { }

	// RVA: 0x2D9E8E0 Offset: 0x2D9D2E0 VA: 0x182D9E8E0
	public void RegisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x2D9EEC0 Offset: 0x2D9D8C0 VA: 0x182D9EEC0
	public void UnregisterDirtyLayoutCallback(UnityAction action) { }

	// RVA: 0x2D9EA30 Offset: 0x2D9D430 VA: 0x182D9EA30
	public void RegisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x2D9F010 Offset: 0x2D9DA10 VA: 0x182D9F010
	public void UnregisterDirtyVerticesCallback(UnityAction action) { }

	// RVA: 0x2D9E980 Offset: 0x2D9D380 VA: 0x182D9E980
	public void RegisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x2D9EF60 Offset: 0x2D9D960 VA: 0x182D9EF60
	public void UnregisterDirtyMaterialCallback(UnityAction action) { }

	// RVA: 0x2D9F1A0 Offset: 0x2D9DBA0 VA: 0x182D9F1A0
	private static void .cctor() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 18
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}
