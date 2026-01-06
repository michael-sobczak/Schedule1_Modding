public class PanelSettings : ScriptableObject // TypeDefIndex: 6678
{
	// Fields
	private const int k_DefaultSortingOrder = 0;
	private const float k_DefaultScaleValue = 1;
	internal const string k_DefaultStyleSheetPath = "Packages/com.unity.ui/PackageResources/StyleSheets/Generated/Default.tss.asset";
	[SerializeField]
	private ThemeStyleSheet themeUss; // 0x18
	[SerializeField]
	private RenderTexture m_TargetTexture; // 0x20
	[SerializeField]
	private PanelScaleMode m_ScaleMode; // 0x28
	[SerializeField]
	private float m_ReferenceSpritePixelsPerUnit; // 0x2C
	[SerializeField]
	private float m_Scale; // 0x30
	private const float DefaultDpi = 96;
	[SerializeField]
	private float m_ReferenceDpi; // 0x34
	[SerializeField]
	private float m_FallbackDpi; // 0x38
	[SerializeField]
	private Vector2Int m_ReferenceResolution; // 0x3C
	[SerializeField]
	private PanelScreenMatchMode m_ScreenMatchMode; // 0x44
	[Range(0, 1)]
	[SerializeField]
	private float m_Match; // 0x48
	[SerializeField]
	private float m_SortingOrder; // 0x4C
	[SerializeField]
	private int m_TargetDisplay; // 0x50
	[SerializeField]
	private bool m_ClearDepthStencil; // 0x54
	[SerializeField]
	private bool m_ClearColor; // 0x55
	[SerializeField]
	private Color m_ColorClearValue; // 0x58
	private PanelSettings.RuntimePanelAccess m_PanelAccess; // 0x68
	internal UIDocumentList m_AttachedUIDocumentsList; // 0x70
	[HideInInspector]
	[SerializeField]
	private DynamicAtlasSettings m_DynamicAtlasSettings; // 0x78
	[SerializeField]
	[HideInInspector]
	private Shader m_AtlasBlitShader; // 0x80
	[SerializeField]
	[HideInInspector]
	private Shader m_RuntimeShader; // 0x88
	[HideInInspector]
	[SerializeField]
	private Shader m_RuntimeWorldShader; // 0x90
	[SerializeField]
	public PanelTextSettings textSettings; // 0x98
	private Rect m_TargetRect; // 0xA0
	private float m_ResolvedScale; // 0xB0
	private StyleSheet m_OldThemeUss; // 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private float <ScreenDPI>k__BackingField; // 0xC0
	private Func<Vector2, Vector2> m_AssignedScreenToPanel; // 0xC8

	// Properties
	public ThemeStyleSheet themeStyleSheet { get; set; }
	public RenderTexture targetTexture { get; set; }
	public PanelScaleMode scaleMode { get; set; }
	public float referenceSpritePixelsPerUnit { get; set; }
	public float scale { get; set; }
	public float referenceDpi { get; set; }
	public float fallbackDpi { get; set; }
	public Vector2Int referenceResolution { get; set; }
	public PanelScreenMatchMode screenMatchMode { get; set; }
	public float match { get; set; }
	public float sortingOrder { get; set; }
	public int targetDisplay { get; set; }
	public bool clearDepthStencil { get; set; }
	public float depthClearValue { get; }
	public bool clearColor { get; set; }
	public Color colorClearValue { get; set; }
	internal BaseRuntimePanel panel { get; }
	internal bool isInitialized { get; }
	internal VisualElement visualTree { get; }
	public DynamicAtlasSettings dynamicAtlasSettings { get; set; }
	private float ScreenDPI { get; set; }

	// Methods

	// RVA: 0x1670E50 Offset: 0x166F850 VA: 0x181670E50
	public ThemeStyleSheet get_themeStyleSheet() { }

	// RVA: 0x2EAEE10 Offset: 0x2EAD810 VA: 0x182EAEE10
	public void set_themeStyleSheet(ThemeStyleSheet value) { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public RenderTexture get_targetTexture() { }

	// RVA: 0x2EAEDB0 Offset: 0x2EAD7B0 VA: 0x182EAEDB0
	public void set_targetTexture(RenderTexture value) { }

	// RVA: 0x494430 Offset: 0x492E30 VA: 0x180494430
	public PanelScaleMode get_scaleMode() { }

	// RVA: 0x494480 Offset: 0x492E80 VA: 0x180494480
	public void set_scaleMode(PanelScaleMode value) { }

	// RVA: 0x2D2B1E0 Offset: 0x2D29BE0 VA: 0x182D2B1E0
	public float get_referenceSpritePixelsPerUnit() { }

	// RVA: 0x5A9D40 Offset: 0x5A8740 VA: 0x1805A9D40
	public void set_referenceSpritePixelsPerUnit(float value) { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_scale() { }

	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	public void set_scale(float value) { }

	// RVA: 0x497250 Offset: 0x495C50 VA: 0x180497250
	public float get_referenceDpi() { }

	// RVA: 0x2EAECE0 Offset: 0x2EAD6E0 VA: 0x182EAECE0
	public void set_referenceDpi(float value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_fallbackDpi() { }

	// RVA: 0x2EAECB0 Offset: 0x2EAD6B0 VA: 0x182EAECB0
	public void set_fallbackDpi(float value) { }

	// RVA: 0x2EAEC50 Offset: 0x2EAD650 VA: 0x182EAEC50
	public Vector2Int get_referenceResolution() { }

	// RVA: 0x2EAED10 Offset: 0x2EAD710 VA: 0x182EAED10
	public void set_referenceResolution(Vector2Int value) { }

	// RVA: 0x594500 Offset: 0x592F00 VA: 0x180594500
	public PanelScreenMatchMode get_screenMatchMode() { }

	// RVA: 0x1EEA950 Offset: 0x1EE9350 VA: 0x181EEA950
	public void set_screenMatchMode(PanelScreenMatchMode value) { }

	// RVA: 0x495E80 Offset: 0x494880 VA: 0x180495E80
	public float get_match() { }

	// RVA: 0x810830 Offset: 0x80F230 VA: 0x180810830
	public void set_match(float value) { }

	// RVA: 0x495F70 Offset: 0x494970 VA: 0x180495F70
	public float get_sortingOrder() { }

	// RVA: 0x2EAED20 Offset: 0x2EAD720 VA: 0x182EAED20
	public void set_sortingOrder(float value) { }

	// RVA: 0x2EAE110 Offset: 0x2EACB10 VA: 0x182EAE110
	internal void ApplySortingOrder() { }

	// RVA: 0x4B61B0 Offset: 0x4B4BB0 VA: 0x1804B61B0
	public int get_targetDisplay() { }

	// RVA: 0x2EAED70 Offset: 0x2EAD770 VA: 0x182EAED70
	public void set_targetDisplay(int value) { }

	// RVA: 0x4E2420 Offset: 0x4E0E20 VA: 0x1804E2420
	public bool get_clearDepthStencil() { }

	// RVA: 0x4E2920 Offset: 0x4E1320 VA: 0x1804E2920
	public void set_clearDepthStencil(bool value) { }

	// RVA: 0x2EAEC00 Offset: 0x2EAD600 VA: 0x182EAEC00
	public float get_depthClearValue() { }

	// RVA: 0x2519EA0 Offset: 0x25188A0 VA: 0x182519EA0
	public bool get_clearColor() { }

	// RVA: 0x2ADA790 Offset: 0x2AD9190 VA: 0x182ADA790
	public void set_clearColor(bool value) { }

	// RVA: 0x4F9F10 Offset: 0x4F8910 VA: 0x1804F9F10
	public Color get_colorClearValue() { }

	// RVA: 0x6D1920 Offset: 0x6D0320 VA: 0x1806D1920
	public void set_colorClearValue(Color value) { }

	// RVA: 0x2EAEC30 Offset: 0x2EAD630 VA: 0x182EAEC30
	internal BaseRuntimePanel get_panel() { }

	// RVA: 0x2EAEC10 Offset: 0x2EAD610 VA: 0x182EAEC10
	internal bool get_isInitialized() { }

	// RVA: 0x2EAEC60 Offset: 0x2EAD660 VA: 0x182EAEC60
	internal VisualElement get_visualTree() { }

	// RVA: 0x4CD210 Offset: 0x4CBC10 VA: 0x1804CD210
	public DynamicAtlasSettings get_dynamicAtlasSettings() { }

	// RVA: 0x5F4EC0 Offset: 0x5F38C0 VA: 0x1805F4EC0
	public void set_dynamicAtlasSettings(DynamicAtlasSettings value) { }

	// RVA: 0x2EAEAA0 Offset: 0x2EAD4A0 VA: 0x182EAEAA0
	private void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void Reset() { }

	// RVA: 0x2EAE840 Offset: 0x2EAD240 VA: 0x182EAE840
	private void OnEnable() { }

	// RVA: 0x2EAE510 Offset: 0x2EACF10 VA: 0x182EAE510
	private void OnDisable() { }

	// RVA: 0x2EAE510 Offset: 0x2EACF10 VA: 0x182EAE510
	internal void DisposePanel() { }

	[CompilerGenerated]
	// RVA: 0x8D1FF0 Offset: 0x8D09F0 VA: 0x1808D1FF0
	private float get_ScreenDPI() { }

	[CompilerGenerated]
	// RVA: 0x2EAECA0 Offset: 0x2EAD6A0 VA: 0x182EAECA0
	private void set_ScreenDPI(float value) { }

	// RVA: 0x2EAEA80 Offset: 0x2EAD480 VA: 0x182EAEA80
	internal void UpdateScreenDPI() { }

	// RVA: 0x2EAE150 Offset: 0x2EACB50 VA: 0x182EAE150
	private void ApplyThemeStyleSheet(VisualElement root) { }

	// RVA: 0x2EAE670 Offset: 0x2EAD070 VA: 0x182EAE670
	private void InitializeShaders() { }

	// RVA: 0x2EAD600 Offset: 0x2EAC000 VA: 0x182EAD600
	internal void ApplyPanelSettings() { }

	// RVA: 0x2EAEA30 Offset: 0x2EAD430 VA: 0x182EAEA30
	public void SetScreenToPanelSpaceFunction(Func<Vector2, Vector2> screentoPanelSpaceFunction) { }

	// RVA: 0x2EAE930 Offset: 0x2EAD330 VA: 0x182EAE930
	internal float ResolveScale(Rect targetRect, float screenDpi) { }

	// RVA: 0x2EAE530 Offset: 0x2EACF30 VA: 0x182EAE530
	internal Rect GetDisplayRect() { }

	// RVA: 0x2EAE2E0 Offset: 0x2EACCE0 VA: 0x182EAE2E0
	internal void AttachAndInsertUIDocumentToVisualTree(UIDocument uiDocument) { }

	// RVA: 0x2EAE400 Offset: 0x2EACE00 VA: 0x182EAE400
	internal void DetachUIDocument(UIDocument uiDocument) { }
}
