public class VisualElement : Focusable, IResolvedStyle, IStylePropertyAnimations, ITransform, ITransitionAnimations, IExperimentalFeatures, IVisualElementScheduler // TypeDefIndex: 6795
{
	// Fields
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount>k__BackingField; // 0x30
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount>k__BackingField; // 0x34
	private static uint s_NextId; // 0x0
	private static List<string> s_EmptyClassList; // 0x8
	internal static readonly PropertyName userDataPropertyKey; // 0x10
	public static readonly string disabledUssClassName; // 0x18
	private string m_Name; // 0x38
	private List<string> m_ClassList; // 0x40
	private List<KeyValuePair<PropertyName, object>> m_PropertyBag; // 0x48
	internal VisualElementFlags m_Flags; // 0x50
	private string m_ViewDataKey; // 0x58
	private RenderHints m_RenderHints; // 0x60
	internal Rect lastLayout; // 0x64
	internal Rect lastPseudoPadding; // 0x74
	internal RenderChainVEData renderChainData; // 0x88
	private Rect m_Layout; // 0x1D0
	private Rect m_BoundingBox; // 0x1E0
	private const VisualElementFlags worldBoundingBoxDirtyDependencies = 25;
	private Rect m_WorldBoundingBox; // 0x1F0
	private const VisualElementFlags worldTransformInverseDirtyDependencies = 3;
	private Matrix4x4 m_WorldTransformCache; // 0x200
	private Matrix4x4 m_WorldTransformInverseCache; // 0x240
	private Rect m_WorldClip; // 0x280
	private Rect m_WorldClipMinusGroup; // 0x290
	private bool m_WorldClipIsInfinite; // 0x2A0
	internal static readonly Rect s_InfiniteRect; // 0x20
	internal PseudoStates triggerPseudoMask; // 0x2A4
	internal PseudoStates dependencyPseudoMask; // 0x2A8
	private PseudoStates m_PseudoStates; // 0x2AC
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private int <containedPointerIds>k__BackingField; // 0x2B0
	private PickingMode m_PickingMode; // 0x2B4
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private YogaNode <yogaNode>k__BackingField; // 0x2B8
	internal ComputedStyle m_Style; // 0x2C0
	internal StyleVariableContext variableContext; // 0x318
	internal int inheritedStylesHash; // 0x320
	internal readonly uint controlid; // 0x324
	internal int imguiContainerDescendantCount; // 0x328
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <enabledSelf>k__BackingField; // 0x32C
	private LanguageDirection m_LanguageDirection; // 0x330
	private LanguageDirection m_LocalLanguageDirection; // 0x334
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private Action<MeshGenerationContext> <generateVisualContent>k__BackingField; // 0x338
	private static readonly ProfilerMarker k_GenerateVisualContentMarker; // 0x30
	private VisualElement.RenderTargetMode m_SubRenderTargetMode; // 0x340
	private static Material s_runtimeMaterial; // 0x38
	private Material m_defaultMaterial; // 0x348
	private List<IValueAnimationUpdate> m_RunningAnimations; // 0x350
	private static uint s_NextParentVersion; // 0x40
	private uint m_NextParentCachedVersion; // 0x358
	private uint m_NextParentRequiredVersion; // 0x35C
	private VisualElement m_CachedNextParentWithEventCallback; // 0x360
	private int m_EventCallbackCategories; // 0x368
	private int m_CachedEventCallbackParentCategories; // 0x36C
	private readonly int m_DefaultActionEventCategories; // 0x370
	private readonly int m_DefaultActionAtTargetEventCategories; // 0x374
	internal const string k_RootVisualContainerName = "rootVisualContainer";
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private VisualElement.Hierarchy <hierarchy>k__BackingField; // 0x378
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private bool <isRootVisualContainer>k__BackingField; // 0x380
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private bool <cacheAsBitmap>k__BackingField; // 0x381
	private VisualElement m_PhysicalParent; // 0x388
	private VisualElement m_LogicalParent; // 0x390
	private static readonly List<VisualElement> s_EmptyList; // 0x48
	private List<VisualElement> m_Children; // 0x398
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private BaseVisualElementPanel <elementPanel>k__BackingField; // 0x3A0
	private VisualTreeAsset m_VisualTreeAssetSource; // 0x3A8
	internal static VisualElement.CustomStyleAccess s_CustomStyleAccess; // 0x50
	internal InlineStyleAccess inlineStyleAccess; // 0x3B0
	internal List<StyleSheet> styleSheetList; // 0x3B8
	private static readonly Regex s_InternalStyleSheetPath; // 0x58
	internal static readonly PropertyName tooltipPropertyKey; // 0x60
	private static readonly Dictionary<Type, VisualElement.TypeData> s_TypeData; // 0x68
	private VisualElement.TypeData m_TypeData; // 0x3C0

	// Properties
	public IResolvedStyle resolvedStyle { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.backgroundColor { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.borderBottomColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderBottomLeftRadius { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderBottomRightRadius { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderBottomWidth { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.borderLeftColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderLeftWidth { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.borderRightColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderRightWidth { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.borderTopColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderTopLeftRadius { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderTopRightRadius { get; }
	private float UnityEngine.UIElements.IResolvedStyle.borderTopWidth { get; }
	private float UnityEngine.UIElements.IResolvedStyle.bottom { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.color { get; }
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.display { get; }
	private FlexDirection UnityEngine.UIElements.IResolvedStyle.flexDirection { get; }
	private float UnityEngine.UIElements.IResolvedStyle.flexGrow { get; }
	private float UnityEngine.UIElements.IResolvedStyle.flexShrink { get; }
	private float UnityEngine.UIElements.IResolvedStyle.height { get; }
	private float UnityEngine.UIElements.IResolvedStyle.left { get; }
	private float UnityEngine.UIElements.IResolvedStyle.marginBottom { get; }
	private float UnityEngine.UIElements.IResolvedStyle.marginLeft { get; }
	private float UnityEngine.UIElements.IResolvedStyle.marginRight { get; }
	private float UnityEngine.UIElements.IResolvedStyle.marginTop { get; }
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.minHeight { get; }
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.minWidth { get; }
	private float UnityEngine.UIElements.IResolvedStyle.opacity { get; }
	private float UnityEngine.UIElements.IResolvedStyle.paddingBottom { get; }
	private float UnityEngine.UIElements.IResolvedStyle.paddingLeft { get; }
	private float UnityEngine.UIElements.IResolvedStyle.paddingRight { get; }
	private float UnityEngine.UIElements.IResolvedStyle.paddingTop { get; }
	private float UnityEngine.UIElements.IResolvedStyle.right { get; }
	private Scale UnityEngine.UIElements.IResolvedStyle.scale { get; }
	private float UnityEngine.UIElements.IResolvedStyle.top { get; }
	private Vector3 UnityEngine.UIElements.IResolvedStyle.transformOrigin { get; }
	private Vector3 UnityEngine.UIElements.IResolvedStyle.translate { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.unityBackgroundImageTintColor { get; }
	private int UnityEngine.UIElements.IResolvedStyle.unitySliceLeft { get; }
	private int UnityEngine.UIElements.IResolvedStyle.unitySliceRight { get; }
	private float UnityEngine.UIElements.IResolvedStyle.unitySliceScale { get; }
	private Color UnityEngine.UIElements.IResolvedStyle.unityTextOutlineColor { get; }
	private float UnityEngine.UIElements.IResolvedStyle.unityTextOutlineWidth { get; }
	private Visibility UnityEngine.UIElements.IResolvedStyle.visibility { get; }
	private float UnityEngine.UIElements.IResolvedStyle.width { get; }
	internal bool hasRunningAnimations { get; }
	internal bool hasCompletedAnimations { get; }
	private int UnityEngine.UIElements.IStylePropertyAnimations.runningAnimationCount { get; set; }
	private int UnityEngine.UIElements.IStylePropertyAnimations.completedAnimationCount { get; set; }
	internal IStylePropertyAnimations styleAnimation { get; }
	internal bool isCompositeRoot { get; set; }
	internal bool isHierarchyDisplayed { get; set; }
	public string viewDataKey { get; set; }
	internal bool enableViewDataPersistence { get; set; }
	public object userData { get; set; }
	public override bool canGrabFocus { get; }
	public override FocusController focusController { get; }
	public UsageHints usageHints { get; set; }
	internal RenderHints renderHints { get; set; }
	public ITransform transform { get; }
	private Vector3 UnityEngine.UIElements.ITransform.position { get; set; }
	private Vector3 UnityEngine.UIElements.ITransform.scale { get; }
	internal bool isLayoutManual { get; set; }
	internal float scaledPixelsPerPoint { get; }
	public Rect layout { get; set; }
	public Rect contentRect { get; }
	protected Rect paddingRect { get; }
	internal bool isBoundingBoxDirty { get; set; }
	internal bool isWorldBoundingBoxDirty { set; }
	internal bool isWorldBoundingBoxOrDependenciesDirty { get; }
	internal Rect boundingBox { get; }
	internal Rect worldBoundingBox { get; }
	private Rect boundingBoxInParentSpace { get; }
	public Rect worldBound { get; }
	public Rect localBound { get; }
	internal Rect rect { get; }
	internal bool isWorldTransformDirty { get; set; }
	internal bool isWorldTransformInverseDirty { set; }
	internal bool isWorldTransformInverseOrDependenciesDirty { get; }
	public Matrix4x4 worldTransform { get; }
	internal Matrix4x4 worldTransformRef { get; }
	internal Matrix4x4 worldTransformInverse { get; }
	internal bool isWorldClipDirty { get; set; }
	internal Rect worldClip { get; }
	internal Rect worldClipMinusGroup { get; }
	internal bool worldClipIsInfinite { get; }
	internal PseudoStates pseudoStates { get; set; }
	internal int containedPointerIds { get; set; }
	public PickingMode pickingMode { get; set; }
	public string name { get; set; }
	internal List<string> classList { get; }
	internal string fullTypeName { get; }
	internal string typeName { get; }
	internal YogaNode yogaNode { get; set; }
	internal ComputedStyle computedStyle { get; }
	internal bool hasInlineStyle { get; }
	internal bool styleInitialized { get; set; }
	private bool isParentEnabledInHierarchy { get; }
	public bool enabledInHierarchy { get; }
	public bool enabledSelf { get; set; }
	public LanguageDirection languageDirection { get; }
	internal LanguageDirection localLanguageDirection { get; set; }
	public bool visible { get; set; }
	public Action<MeshGenerationContext> generateVisualContent { get; set; }
	internal bool requireMeasureFunction { get; set; }
	internal VisualElement.RenderTargetMode subRenderTargetMode { get; }
	internal Material defaultMaterial { get; }
	internal VisualElement nextParentWithEventCallback { get; }
	internal int eventCallbackCategories { get; set; }
	internal int eventCallbackParentCategories { get; }
	internal bool isEventCallbackParentCategoriesDirty { get; set; }
	public IExperimentalFeatures experimental { get; }
	private ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.animation { get; }
	public VisualElement.Hierarchy hierarchy { get; set; }
	internal bool isRootVisualContainer { get; set; }
	internal bool disableClipping { get; set; }
	public VisualElement parent { get; }
	internal BaseVisualElementPanel elementPanel { get; set; }
	public IPanel panel { get; }
	public virtual VisualElement contentContainer { get; }
	internal VisualTreeAsset visualTreeAssetSource { set; }
	public VisualElement Item { get; }
	public int childCount { get; }
	private Vector3 positionWithLayout { get; }
	internal bool hasDefaultRotationAndScale { get; }
	public IVisualElementScheduler schedule { get; }
	public IStyle style { get; }
	public ICustomStyle customStyle { get; }
	public VisualElementStyleSheetSet styleSheets { get; }
	public string tooltip { get; set; }
	private VisualElement.TypeData typeData { get; }

	// Methods

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	public IResolvedStyle get_resolvedStyle() { }

	// RVA: 0x2EF39B0 Offset: 0x2EF23B0 VA: 0x182EF39B0 Slot: 19
	private Color UnityEngine.UIElements.IResolvedStyle.get_backgroundColor() { }

	// RVA: 0x2EF39E0 Offset: 0x2EF23E0 VA: 0x182EF39E0 Slot: 20
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderBottomColor() { }

	// RVA: 0x2EF3A10 Offset: 0x2EF2410 VA: 0x182EF3A10 Slot: 21
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomLeftRadius() { }

	// RVA: 0x2EF3A40 Offset: 0x2EF2440 VA: 0x182EF3A40 Slot: 22
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomRightRadius() { }

	// RVA: 0x2EF3A70 Offset: 0x2EF2470 VA: 0x182EF3A70 Slot: 23
	private float UnityEngine.UIElements.IResolvedStyle.get_borderBottomWidth() { }

	// RVA: 0x2EF3AA0 Offset: 0x2EF24A0 VA: 0x182EF3AA0 Slot: 24
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderLeftColor() { }

	// RVA: 0x2EF3AD0 Offset: 0x2EF24D0 VA: 0x182EF3AD0 Slot: 25
	private float UnityEngine.UIElements.IResolvedStyle.get_borderLeftWidth() { }

	// RVA: 0x2EF3B00 Offset: 0x2EF2500 VA: 0x182EF3B00 Slot: 26
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderRightColor() { }

	// RVA: 0x2EF3B30 Offset: 0x2EF2530 VA: 0x182EF3B30 Slot: 27
	private float UnityEngine.UIElements.IResolvedStyle.get_borderRightWidth() { }

	// RVA: 0x2EF3B60 Offset: 0x2EF2560 VA: 0x182EF3B60 Slot: 28
	private Color UnityEngine.UIElements.IResolvedStyle.get_borderTopColor() { }

	// RVA: 0x2EF3B90 Offset: 0x2EF2590 VA: 0x182EF3B90 Slot: 29
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopLeftRadius() { }

	// RVA: 0x2EF3BC0 Offset: 0x2EF25C0 VA: 0x182EF3BC0 Slot: 30
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopRightRadius() { }

	// RVA: 0x2EF3BF0 Offset: 0x2EF25F0 VA: 0x182EF3BF0 Slot: 31
	private float UnityEngine.UIElements.IResolvedStyle.get_borderTopWidth() { }

	// RVA: 0x2EF3C20 Offset: 0x2EF2620 VA: 0x182EF3C20 Slot: 32
	private float UnityEngine.UIElements.IResolvedStyle.get_bottom() { }

	// RVA: 0x2EF3C50 Offset: 0x2EF2650 VA: 0x182EF3C50 Slot: 33
	private Color UnityEngine.UIElements.IResolvedStyle.get_color() { }

	// RVA: 0x2EF3C80 Offset: 0x2EF2680 VA: 0x182EF3C80 Slot: 34
	private DisplayStyle UnityEngine.UIElements.IResolvedStyle.get_display() { }

	// RVA: 0x2EF3C90 Offset: 0x2EF2690 VA: 0x182EF3C90 Slot: 35
	private FlexDirection UnityEngine.UIElements.IResolvedStyle.get_flexDirection() { }

	// RVA: 0x2EF3CA0 Offset: 0x2EF26A0 VA: 0x182EF3CA0 Slot: 36
	private float UnityEngine.UIElements.IResolvedStyle.get_flexGrow() { }

	// RVA: 0x2EF3CB0 Offset: 0x2EF26B0 VA: 0x182EF3CB0 Slot: 37
	private float UnityEngine.UIElements.IResolvedStyle.get_flexShrink() { }

	// RVA: 0x2EF3CC0 Offset: 0x2EF26C0 VA: 0x182EF3CC0 Slot: 38
	private float UnityEngine.UIElements.IResolvedStyle.get_height() { }

	// RVA: 0x2EF3CF0 Offset: 0x2EF26F0 VA: 0x182EF3CF0 Slot: 39
	private float UnityEngine.UIElements.IResolvedStyle.get_left() { }

	// RVA: 0x2EF3D20 Offset: 0x2EF2720 VA: 0x182EF3D20 Slot: 40
	private float UnityEngine.UIElements.IResolvedStyle.get_marginBottom() { }

	// RVA: 0x2EF3D50 Offset: 0x2EF2750 VA: 0x182EF3D50 Slot: 41
	private float UnityEngine.UIElements.IResolvedStyle.get_marginLeft() { }

	// RVA: 0x2EF3D80 Offset: 0x2EF2780 VA: 0x182EF3D80 Slot: 42
	private float UnityEngine.UIElements.IResolvedStyle.get_marginRight() { }

	// RVA: 0x2EF3DB0 Offset: 0x2EF27B0 VA: 0x182EF3DB0 Slot: 43
	private float UnityEngine.UIElements.IResolvedStyle.get_marginTop() { }

	// RVA: 0x2EF3DE0 Offset: 0x2EF27E0 VA: 0x182EF3DE0 Slot: 44
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minHeight() { }

	// RVA: 0x2EF3E10 Offset: 0x2EF2810 VA: 0x182EF3E10 Slot: 45
	private StyleFloat UnityEngine.UIElements.IResolvedStyle.get_minWidth() { }

	// RVA: 0x2EF3E40 Offset: 0x2EF2840 VA: 0x182EF3E40 Slot: 46
	private float UnityEngine.UIElements.IResolvedStyle.get_opacity() { }

	// RVA: 0x2EF3E50 Offset: 0x2EF2850 VA: 0x182EF3E50 Slot: 47
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingBottom() { }

	// RVA: 0x2EF3E80 Offset: 0x2EF2880 VA: 0x182EF3E80 Slot: 48
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingLeft() { }

	// RVA: 0x2EF3EB0 Offset: 0x2EF28B0 VA: 0x182EF3EB0 Slot: 49
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingRight() { }

	// RVA: 0x2EF3EE0 Offset: 0x2EF28E0 VA: 0x182EF3EE0 Slot: 50
	private float UnityEngine.UIElements.IResolvedStyle.get_paddingTop() { }

	// RVA: 0x2EF3F10 Offset: 0x2EF2910 VA: 0x182EF3F10 Slot: 51
	private float UnityEngine.UIElements.IResolvedStyle.get_right() { }

	// RVA: 0x2EF3F40 Offset: 0x2EF2940 VA: 0x182EF3F40 Slot: 52
	private Scale UnityEngine.UIElements.IResolvedStyle.get_scale() { }

	// RVA: 0x2EF3F70 Offset: 0x2EF2970 VA: 0x182EF3F70 Slot: 53
	private float UnityEngine.UIElements.IResolvedStyle.get_top() { }

	// RVA: 0x2EF3FA0 Offset: 0x2EF29A0 VA: 0x182EF3FA0 Slot: 54
	private Vector3 UnityEngine.UIElements.IResolvedStyle.get_transformOrigin() { }

	// RVA: 0x2EF3FD0 Offset: 0x2EF29D0 VA: 0x182EF3FD0 Slot: 55
	private Vector3 UnityEngine.UIElements.IResolvedStyle.get_translate() { }

	// RVA: 0x2EF4000 Offset: 0x2EF2A00 VA: 0x182EF4000 Slot: 56
	private Color UnityEngine.UIElements.IResolvedStyle.get_unityBackgroundImageTintColor() { }

	// RVA: 0x2EF4030 Offset: 0x2EF2A30 VA: 0x182EF4030 Slot: 57
	private int UnityEngine.UIElements.IResolvedStyle.get_unitySliceLeft() { }

	// RVA: 0x2EF4040 Offset: 0x2EF2A40 VA: 0x182EF4040 Slot: 58
	private int UnityEngine.UIElements.IResolvedStyle.get_unitySliceRight() { }

	// RVA: 0x2EF4050 Offset: 0x2EF2A50 VA: 0x182EF4050 Slot: 59
	private float UnityEngine.UIElements.IResolvedStyle.get_unitySliceScale() { }

	// RVA: 0x2EF4060 Offset: 0x2EF2A60 VA: 0x182EF4060 Slot: 60
	private Color UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineColor() { }

	// RVA: 0x2EF4090 Offset: 0x2EF2A90 VA: 0x182EF4090 Slot: 61
	private float UnityEngine.UIElements.IResolvedStyle.get_unityTextOutlineWidth() { }

	// RVA: 0x2EF40A0 Offset: 0x2EF2AA0 VA: 0x182EF40A0 Slot: 62
	private Visibility UnityEngine.UIElements.IResolvedStyle.get_visibility() { }

	// RVA: 0x2EF40B0 Offset: 0x2EF2AB0 VA: 0x182EF40B0 Slot: 63
	private float UnityEngine.UIElements.IResolvedStyle.get_width() { }

	// RVA: 0x2EF8530 Offset: 0x2EF6F30 VA: 0x182EF8530
	internal bool get_hasRunningAnimations() { }

	// RVA: 0x2EF83D0 Offset: 0x2EF6DD0 VA: 0x182EF83D0
	internal bool get_hasCompletedAnimations() { }

	[CompilerGenerated]
	// RVA: 0x4A7D90 Offset: 0x4A6790 VA: 0x1804A7D90 Slot: 84
	private int UnityEngine.UIElements.IStylePropertyAnimations.get_runningAnimationCount() { }

	[CompilerGenerated]
	// RVA: 0x54D060 Offset: 0x54BA60 VA: 0x18054D060 Slot: 85
	private void UnityEngine.UIElements.IStylePropertyAnimations.set_runningAnimationCount(int value) { }

	[CompilerGenerated]
	// RVA: 0x4CDA00 Offset: 0x4CC400 VA: 0x1804CDA00 Slot: 86
	private int UnityEngine.UIElements.IStylePropertyAnimations.get_completedAnimationCount() { }

	[CompilerGenerated]
	// RVA: 0x4E2B40 Offset: 0x4E1540 VA: 0x1804E2B40 Slot: 87
	private void UnityEngine.UIElements.IStylePropertyAnimations.set_completedAnimationCount(int value) { }

	// RVA: 0x2EEEB50 Offset: 0x2EED550 VA: 0x182EEEB50
	private IStylePropertyAnimationSystem GetStylePropertyAnimationSystem() { }

	// RVA: 0xBB7DD0 Offset: 0xBB67D0 VA: 0x180BB7DD0
	internal IStylePropertyAnimations get_styleAnimation() { }

	// RVA: 0x2EF4C00 Offset: 0x2EF3600 VA: 0x182EF4C00 Slot: 64
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, float from, float to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF5040 Offset: 0x2EF3A40 VA: 0x182EF5040 Slot: 65
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF4630 Offset: 0x2EF3030 VA: 0x182EF4630 Slot: 66
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Length from, Length to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF5240 Offset: 0x2EF3C40 VA: 0x182EF5240 Slot: 67
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Color from, Color to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF4430 Offset: 0x2EF2E30 VA: 0x182EF4430 Slot: 68
	private bool UnityEngine.UIElements.IStylePropertyAnimations.StartEnum(StylePropertyId id, int from, int to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF5850 Offset: 0x2EF4250 VA: 0x182EF5850 Slot: 69
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Background from, Background to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF5540 Offset: 0x2EF3F40 VA: 0x182EF5540 Slot: 70
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, FontDefinition from, FontDefinition to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF44F0 Offset: 0x2EF2EF0 VA: 0x182EF44F0 Slot: 71
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Font from, Font to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF56B0 Offset: 0x2EF40B0 VA: 0x182EF56B0 Slot: 72
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TextShadow from, TextShadow to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF4D50 Offset: 0x2EF3750 VA: 0x182EF4D50 Slot: 73
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Scale from, Scale to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF53B0 Offset: 0x2EF3DB0 VA: 0x182EF53B0 Slot: 74
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Translate from, Translate to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF4A70 Offset: 0x2EF3470 VA: 0x182EF4A70 Slot: 75
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, Rotate from, Rotate to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF4EC0 Offset: 0x2EF38C0 VA: 0x182EF4EC0 Slot: 76
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, TransformOrigin from, TransformOrigin to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF48F0 Offset: 0x2EF32F0 VA: 0x182EF48F0 Slot: 77
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundPosition from, BackgroundPosition to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF5100 Offset: 0x2EF3B00 VA: 0x182EF5100 Slot: 78
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundRepeat from, BackgroundRepeat to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF4770 Offset: 0x2EF3170 VA: 0x182EF4770 Slot: 79
	private bool UnityEngine.UIElements.IStylePropertyAnimations.Start(StylePropertyId id, BackgroundSize from, BackgroundSize to, int durationMs, int delayMs, Func<float, float> easingCurve) { }

	// RVA: 0x2EF4240 Offset: 0x2EF2C40 VA: 0x182EF4240 Slot: 82
	private void UnityEngine.UIElements.IStylePropertyAnimations.CancelAnimation(StylePropertyId id) { }

	// RVA: 0x2EF40E0 Offset: 0x2EF2AE0 VA: 0x182EF40E0 Slot: 83
	private void UnityEngine.UIElements.IStylePropertyAnimations.CancelAllAnimations() { }

	// RVA: 0x2EF59E0 Offset: 0x2EF43E0 VA: 0x182EF59E0 Slot: 80
	private void UnityEngine.UIElements.IStylePropertyAnimations.UpdateAnimation(StylePropertyId id) { }

	// RVA: 0x2EF42C0 Offset: 0x2EF2CC0 VA: 0x182EF42C0 Slot: 81
	private void UnityEngine.UIElements.IStylePropertyAnimations.GetAllAnimations(List<StylePropertyId> outPropertyIds) { }

	// RVA: 0x2EF32E0 Offset: 0x2EF1CE0 VA: 0x182EF32E0
	internal bool TryConvertLengthUnits(StylePropertyId id, ref Length from, ref Length to, int subPropertyIndex = 0) { }

	// RVA: 0x2EF3530 Offset: 0x2EF1F30 VA: 0x182EF3530
	internal bool TryConvertTransformOriginUnits(ref TransformOrigin from, ref TransformOrigin to) { }

	// RVA: 0x2EF35E0 Offset: 0x2EF1FE0 VA: 0x182EF35E0
	internal bool TryConvertTranslateUnits(ref Translate from, ref Translate to) { }

	// RVA: 0x2EF31F0 Offset: 0x2EF1BF0 VA: 0x182EF31F0
	internal bool TryConvertBackgroundSizeUnits(ref BackgroundSize from, ref BackgroundSize to) { }

	// RVA: 0x2EEE300 Offset: 0x2EECD00 VA: 0x182EEE300
	private Nullable<float> GetParentSizeForLengthConversion(StylePropertyId id, int subPropertyIndex = 0) { }

	// RVA: 0x2EF8590 Offset: 0x2EF6F90 VA: 0x182EF8590
	internal bool get_isCompositeRoot() { }

	// RVA: 0x2EF96D0 Offset: 0x2EF80D0 VA: 0x182EF96D0
	internal void set_isCompositeRoot(bool value) { }

	// RVA: 0x2EF85B0 Offset: 0x2EF6FB0 VA: 0x182EF85B0
	internal bool get_isHierarchyDisplayed() { }

	// RVA: 0x2EF9740 Offset: 0x2EF8140 VA: 0x182EF9740
	internal void set_isHierarchyDisplayed(bool value) { }

	// RVA: 0x4993C0 Offset: 0x497DC0 VA: 0x1804993C0
	public string get_viewDataKey() { }

	// RVA: 0x2EFA810 Offset: 0x2EF9210 VA: 0x182EFA810
	public void set_viewDataKey(string value) { }

	// RVA: 0x2EF8220 Offset: 0x2EF6C20 VA: 0x182EF8220
	internal bool get_enableViewDataPersistence() { }

	// RVA: 0x2EF95C0 Offset: 0x2EF7FC0 VA: 0x182EF95C0
	private void set_enableViewDataPersistence(bool value) { }

	// RVA: 0x2EF90F0 Offset: 0x2EF7AF0 VA: 0x182EF90F0
	public object get_userData() { }

	// RVA: 0x2EFA7A0 Offset: 0x2EF91A0 VA: 0x182EFA7A0
	public void set_userData(object value) { }

	// RVA: 0x2EF7CA0 Offset: 0x2EF66A0 VA: 0x182EF7CA0 Slot: 16
	public override bool get_canGrabFocus() { }

	// RVA: 0x2EF8290 Offset: 0x2EF6C90 VA: 0x182EF8290 Slot: 15
	public override FocusController get_focusController() { }

	// RVA: 0x2EF90C0 Offset: 0x2EF7AC0 VA: 0x182EF90C0
	public UsageHints get_usageHints() { }

	// RVA: 0x2EFA5D0 Offset: 0x2EF8FD0 VA: 0x182EFA5D0
	public void set_usageHints(UsageHints value) { }

	// RVA: 0x2DF7FB0 Offset: 0x2DF69B0 VA: 0x182DF7FB0
	internal RenderHints get_renderHints() { }

	// RVA: 0x2EFA300 Offset: 0x2EF8D00 VA: 0x182EFA300
	internal void set_renderHints(RenderHints value) { }

	// RVA: 0x2EEF550 Offset: 0x2EEDF50 VA: 0x182EEF550
	internal void MarkRenderHintsClean() { }

	// RVA: 0x1CC1010 Offset: 0x1CBFA10 VA: 0x181CC1010
	public ITransform get_transform() { }

	// RVA: 0x2EF5A60 Offset: 0x2EF4460 VA: 0x182EF5A60 Slot: 88
	private Vector3 UnityEngine.UIElements.ITransform.get_position() { }

	// RVA: 0x2EF5C20 Offset: 0x2EF4620 VA: 0x182EF5C20 Slot: 89
	private void UnityEngine.UIElements.ITransform.set_position(Vector3 value) { }

	// RVA: 0x2EF5B40 Offset: 0x2EF4540 VA: 0x182EF5B40 Slot: 90
	private Vector3 UnityEngine.UIElements.ITransform.get_scale() { }

	// RVA: 0x2EF85C0 Offset: 0x2EF6FC0 VA: 0x182EF85C0
	internal bool get_isLayoutManual() { }

	// RVA: 0x2EF9770 Offset: 0x2EF8170 VA: 0x182EF9770
	private void set_isLayoutManual(bool value) { }

	// RVA: 0x2EF8C50 Offset: 0x2EF7650 VA: 0x182EF8C50
	internal float get_scaledPixelsPerPoint() { }

	// RVA: 0x2EF8660 Offset: 0x2EF7060 VA: 0x182EF8660
	public Rect get_layout() { }

	// RVA: 0x2EF9800 Offset: 0x2EF8200 VA: 0x182EF9800
	internal void set_layout(Rect value) { }

	// RVA: 0x2EEC340 Offset: 0x2EEAD40 VA: 0x182EEC340
	internal void ClearManualLayout() { }

	// RVA: 0x2EF7F00 Offset: 0x2EF6900 VA: 0x182EF7F00
	public Rect get_contentRect() { }

	// RVA: 0x2EF8990 Offset: 0x2EF7390 VA: 0x182EF8990
	protected Rect get_paddingRect() { }

	// RVA: 0x2EF8580 Offset: 0x2EF6F80 VA: 0x182EF8580
	internal bool get_isBoundingBoxDirty() { }

	// RVA: 0x2EF96A0 Offset: 0x2EF80A0 VA: 0x182EF96A0
	internal void set_isBoundingBoxDirty(bool value) { }

	// RVA: 0x2EF97A0 Offset: 0x2EF81A0 VA: 0x182EF97A0
	internal void set_isWorldBoundingBoxDirty(bool value) { }

	// RVA: 0x2EF8620 Offset: 0x2EF7020 VA: 0x182EF8620
	internal bool get_isWorldBoundingBoxOrDependenciesDirty() { }

	// RVA: 0x2EF7C50 Offset: 0x2EF6650 VA: 0x182EF7C50
	internal Rect get_boundingBox() { }

	// RVA: 0x2EF92C0 Offset: 0x2EF7CC0 VA: 0x182EF92C0
	internal Rect get_worldBoundingBox() { }

	// RVA: 0x2EF7BF0 Offset: 0x2EF65F0 VA: 0x182EF7BF0
	private Rect get_boundingBoxInParentSpace() { }

	// RVA: 0x2EF60A0 Offset: 0x2EF4AA0 VA: 0x182EF60A0
	internal void UpdateBoundingBox() { }

	// RVA: 0x2EF6A30 Offset: 0x2EF5430 VA: 0x182EF6A30
	internal void UpdateWorldBoundingBox() { }

	// RVA: 0x2EF91C0 Offset: 0x2EF7BC0 VA: 0x182EF91C0
	public Rect get_worldBound() { }

	// RVA: 0x2EF8720 Offset: 0x2EF7120 VA: 0x182EF8720
	public Rect get_localBound() { }

	// RVA: 0x2EF8BE0 Offset: 0x2EF75E0 VA: 0x182EF8BE0
	internal Rect get_rect() { }

	// RVA: 0x1B39DD0 Offset: 0x1B387D0 VA: 0x181B39DD0
	internal bool get_isWorldTransformDirty() { }

	// RVA: 0x25753B0 Offset: 0x2573DB0 VA: 0x1825753B0
	internal void set_isWorldTransformDirty(bool value) { }

	// RVA: 0x25753E0 Offset: 0x2573DE0 VA: 0x1825753E0
	internal void set_isWorldTransformInverseDirty(bool value) { }

	// RVA: 0x2EF8640 Offset: 0x2EF7040 VA: 0x182EF8640
	internal bool get_isWorldTransformInverseOrDependenciesDirty() { }

	// RVA: 0x2EF9510 Offset: 0x2EF7F10 VA: 0x182EF9510
	public Matrix4x4 get_worldTransform() { }

	// RVA: 0x2EF94E0 Offset: 0x2EF7EE0 VA: 0x182EF94E0
	internal ref Matrix4x4 get_worldTransformRef() { }

	// RVA: 0x2EF9460 Offset: 0x2EF7E60 VA: 0x182EF9460
	internal ref Matrix4x4 get_worldTransformInverse() { }

	// RVA: 0x2EF6F50 Offset: 0x2EF5950 VA: 0x182EF6F50
	internal void UpdateWorldTransform() { }

	// RVA: 0x2EF6EE0 Offset: 0x2EF58E0 VA: 0x182EF6EE0
	internal void UpdateWorldTransformInverse() { }

	// RVA: 0x2EF8630 Offset: 0x2EF7030 VA: 0x182EF8630
	internal bool get_isWorldClipDirty() { }

	// RVA: 0x2EF97D0 Offset: 0x2EF81D0 VA: 0x182EF97D0
	internal void set_isWorldClipDirty(bool value) { }

	// RVA: 0x2EF9410 Offset: 0x2EF7E10 VA: 0x182EF9410
	internal Rect get_worldClip() { }

	// RVA: 0x2EF93C0 Offset: 0x2EF7DC0 VA: 0x182EF93C0
	internal Rect get_worldClipMinusGroup() { }

	// RVA: 0x2EF9380 Offset: 0x2EF7D80 VA: 0x182EF9380
	internal bool get_worldClipIsInfinite() { }

	// RVA: 0x2EED1C0 Offset: 0x2EEBBC0 VA: 0x182EED1C0
	internal void EnsureWorldTransformAndClipUpToDate() { }

	// RVA: 0x2EF6AC0 Offset: 0x2EF54C0 VA: 0x182EF6AC0
	private void UpdateWorldClip() { }

	// RVA: 0x2EECB60 Offset: 0x2EEB560 VA: 0x182EECB60
	private Rect CombineClipRects(Rect rect, Rect parentRect) { }

	// RVA: 0x2EF2AD0 Offset: 0x2EF14D0 VA: 0x182EF2AD0
	private Rect SubstractBorderPadding(Rect worldRect) { }

	// RVA: 0x2EECBF0 Offset: 0x2EEB5F0 VA: 0x182EECBF0
	internal static Rect ComputeAAAlignedBound(Rect position, Matrix4x4 mat) { }

	// RVA: 0x2EF8BD0 Offset: 0x2EF75D0 VA: 0x182EF8BD0
	internal PseudoStates get_pseudoStates() { }

	// RVA: 0x2EFA270 Offset: 0x2EF8C70 VA: 0x182EFA270
	internal void set_pseudoStates(PseudoStates value) { }

	[CompilerGenerated]
	// RVA: 0x2EF7EF0 Offset: 0x2EF68F0 VA: 0x182EF7EF0
	internal int get_containedPointerIds() { }

	[CompilerGenerated]
	// RVA: 0x2EF9580 Offset: 0x2EF7F80 VA: 0x182EF9580
	private void set_containedPointerIds(int value) { }

	// RVA: 0x2EF6920 Offset: 0x2EF5320 VA: 0x182EF6920
	private void UpdateHoverPseudoState() { }

	// RVA: 0x2EEF3A0 Offset: 0x2EEDDA0 VA: 0x182EEF3A0
	private static bool IsPartOfCapturedChain(VisualElement self, in IEventHandler capturingElement) { }

	// RVA: 0x2EF8B30 Offset: 0x2EF7530 VA: 0x182EF8B30
	public PickingMode get_pickingMode() { }

	// RVA: 0x2EFA220 Offset: 0x2EF8C20 VA: 0x182EFA220
	public void set_pickingMode(PickingMode value) { }

	// RVA: 0x2D0E1B0 Offset: 0x2D0CBB0 VA: 0x182D0E1B0
	public string get_name() { }

	// RVA: 0x2EFA1B0 Offset: 0x2EF8BB0 VA: 0x182EFA1B0
	public void set_name(string value) { }

	// RVA: 0x2EF7E20 Offset: 0x2EF6820 VA: 0x182EF7E20
	internal List<string> get_classList() { }

	// RVA: 0x2EF8370 Offset: 0x2EF6D70 VA: 0x182EF8370
	internal string get_fullTypeName() { }

	// RVA: 0x2EF8FE0 Offset: 0x2EF79E0 VA: 0x182EF8FE0
	internal string get_typeName() { }

	[CompilerGenerated]
	// RVA: 0x81EF90 Offset: 0x81D990 VA: 0x18081EF90
	internal YogaNode get_yogaNode() { }

	[CompilerGenerated]
	// RVA: 0x81F780 Offset: 0x81E180 VA: 0x18081F780
	private void set_yogaNode(YogaNode value) { }

	// RVA: 0x2EF7EE0 Offset: 0x2EF68E0 VA: 0x182EF7EE0
	internal ref ComputedStyle get_computedStyle() { }

	// RVA: 0x2EF8520 Offset: 0x2EF6F20 VA: 0x182EF8520
	internal bool get_hasInlineStyle() { }

	// RVA: 0x2EF8CB0 Offset: 0x2EF76B0 VA: 0x182EF8CB0
	internal bool get_styleInitialized() { }

	// RVA: 0x2EFA400 Offset: 0x2EF8E00 VA: 0x182EFA400
	internal void set_styleInitialized(bool value) { }

	// RVA: 0x2EEC000 Offset: 0x2EEAA00 VA: 0x182EEC000
	private void ChangeIMGUIContainerCount(int delta) { }

	// RVA: 0x2EF7700 Offset: 0x2EF6100 VA: 0x182EF7700
	public void .ctor() { }

	[EventInterest(new[] { typeof(MouseOverEvent), typeof(MouseOutEvent), typeof(MouseCaptureOutEvent), typeof(PointerEnterEvent), typeof(PointerLeaveEvent), typeof(PointerCaptureEvent), typeof(PointerCaptureOutEvent), typeof(BlurEvent), typeof(FocusEvent), typeof(TooltipEvent) })]
	// RVA: 0x2EED1F0 Offset: 0x2EEBBF0 VA: 0x182EED1F0 Slot: 12
	protected override void ExecuteDefaultAction(EventBase evt) { }

	// RVA: 0x2EEEB80 Offset: 0x2EED580 VA: 0x182EEEB80 Slot: 95
	internal virtual Rect GetTooltipRect() { }

	// RVA: 0x2EF2830 Offset: 0x2EF1230 VA: 0x182EF2830
	private void SetTooltip(TooltipEvent e) { }

	// RVA: 0x2EEDC80 Offset: 0x2EEC680 VA: 0x182EEDC80 Slot: 17
	public sealed override void Focus() { }

	// RVA: 0x2EF1C60 Offset: 0x2EF0660 VA: 0x182EF1C60
	internal void SetPanel(BaseVisualElementPanel p) { }

	// RVA: 0x2EF7250 Offset: 0x2EF5C50 VA: 0x182EF7250
	private void WillChangePanel(BaseVisualElementPanel destinationPanel) { }

	// RVA: 0x2EEEBB0 Offset: 0x2EED5B0 VA: 0x182EEEBB0
	private void HasChangedPanel(BaseVisualElementPanel prevPanel) { }

	// RVA: 0x2EF1390 Offset: 0x2EEFD90 VA: 0x182EF1390 Slot: 6
	public sealed override void SendEvent(EventBase e) { }

	// RVA: 0x2EF13B0 Offset: 0x2EEFDB0 VA: 0x182EF13B0 Slot: 7
	internal sealed override void SendEvent(EventBase e, DispatchMode dispatchMode) { }

	// RVA: 0x2EEF080 Offset: 0x2EEDA80 VA: 0x182EEF080
	internal void IncrementVersion(VersionChangeType changeType) { }

	// RVA: 0x2EEF380 Offset: 0x2EEDD80 VA: 0x182EEF380
	internal void InvokeHierarchyChanged(HierarchyChangeType changeType) { }

	// RVA: 0x2EF17F0 Offset: 0x2EF01F0 VA: 0x182EF17F0
	private bool SetEnabledFromHierarchyPrivate(bool state) { }

	// RVA: 0x2EF85D0 Offset: 0x2EF6FD0 VA: 0x182EF85D0
	private bool get_isParentEnabledInHierarchy() { }

	// RVA: 0x2EF8230 Offset: 0x2EF6C30 VA: 0x182EF8230
	public bool get_enabledInHierarchy() { }

	[CompilerGenerated]
	// RVA: 0x2EF8240 Offset: 0x2EF6C40 VA: 0x182EF8240
	public bool get_enabledSelf() { }

	[CompilerGenerated]
	// RVA: 0x2EF95F0 Offset: 0x2EF7FF0 VA: 0x182EF95F0
	private void set_enabledSelf(bool value) { }

	// RVA: 0x2EF1B90 Offset: 0x2EF0590 VA: 0x182EF1B90
	public void SetEnabled(bool value) { }

	// RVA: 0x2EEFF60 Offset: 0x2EEE960 VA: 0x182EEFF60
	private void PropagateEnabledToChildren(bool value) { }

	// RVA: 0x2EF8650 Offset: 0x2EF7050 VA: 0x182EF8650
	public LanguageDirection get_languageDirection() { }

	// RVA: 0x2EF87B0 Offset: 0x2EF71B0 VA: 0x182EF87B0
	internal LanguageDirection get_localLanguageDirection() { }

	// RVA: 0x2EFA0A0 Offset: 0x2EF8AA0 VA: 0x182EFA0A0
	internal void set_localLanguageDirection(LanguageDirection value) { }

	// RVA: 0x2EF9170 Offset: 0x2EF7B70 VA: 0x182EF9170
	public bool get_visible() { }

	// RVA: 0x2EFA890 Offset: 0x2EF9290 VA: 0x182EFA890
	public void set_visible(bool value) { }

	// RVA: 0x2EEF520 Offset: 0x2EEDF20 VA: 0x182EEF520
	public void MarkDirtyRepaint() { }

	[CompilerGenerated]
	// RVA: 0xA0ADA0 Offset: 0xA097A0 VA: 0x180A0ADA0
	public Action<MeshGenerationContext> get_generateVisualContent() { }

	[CompilerGenerated]
	// RVA: 0xA0AE70 Offset: 0xA09870 VA: 0x180A0AE70
	public void set_generateVisualContent(Action<MeshGenerationContext> value) { }

	// RVA: 0x2EEF220 Offset: 0x2EEDC20 VA: 0x182EEF220
	internal void InvokeGenerateVisualContent(MeshGenerationContext mgc) { }

	// RVA: 0x2EEE030 Offset: 0x2EECA30 VA: 0x182EEE030
	internal void GetFullHierarchicalViewDataKey(StringBuilder key) { }

	// RVA: 0x2EEDF50 Offset: 0x2EEC950 VA: 0x182EEDF50
	internal string GetFullHierarchicalViewDataKey() { }

	// RVA: -1 Offset: -1
	internal T GetOrCreateViewData<T>(object existing, string key) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF754A0 Offset: 0xF73EA0 VA: 0x180F754A0
	|-VisualElement.GetOrCreateViewData<object>
	*/

	// RVA: 0x2EEFA60 Offset: 0x2EEE460 VA: 0x182EEFA60
	internal void OverwriteFromViewData(object obj, string key) { }

	// RVA: 0x2EF1300 Offset: 0x2EEFD00 VA: 0x182EF1300
	internal void SaveViewData() { }

	// RVA: 0x2EEF470 Offset: 0x2EEDE70 VA: 0x182EEF470
	internal bool IsViewDataPersitenceSupportedOnChildren(bool existingState) { }

	// RVA: 0x2EEF9C0 Offset: 0x2EEE3C0 VA: 0x182EEF9C0
	internal void OnViewDataReady(bool enablePersistence) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 96
	internal virtual void OnViewDataReady() { }

	// RVA: 0x2EECE00 Offset: 0x2EEB800 VA: 0x182EECE00 Slot: 97
	public virtual bool ContainsPoint(Vector2 localPoint) { }

	// RVA: 0x2EF8C40 Offset: 0x2EF7640 VA: 0x182EF8C40
	internal bool get_requireMeasureFunction() { }

	// RVA: 0x2EFA370 Offset: 0x2EF8D70 VA: 0x182EFA370
	internal void set_requireMeasureFunction(bool value) { }

	// RVA: 0x2EEAEE0 Offset: 0x2EE98E0 VA: 0x182EEAEE0
	private void AssignMeasureFunction() { }

	// RVA: 0x2EF0BA0 Offset: 0x2EEF5A0 VA: 0x182EF0BA0
	private void RemoveMeasureFunction() { }

	// RVA: 0x2EECF40 Offset: 0x2EEB940 VA: 0x182EECF40 Slot: 98
	protected internal virtual Vector2 DoMeasure(float desiredWidth, VisualElement.MeasureMode widthMode, float desiredHeight, VisualElement.MeasureMode heightMode) { }

	// RVA: 0x2EEF570 Offset: 0x2EEDF70 VA: 0x182EEF570
	internal YogaSize Measure(YogaNode node, float width, YogaMeasureMode widthMode, float height, YogaMeasureMode heightMode) { }

	// RVA: 0x2EED910 Offset: 0x2EEC310 VA: 0x182EED910
	private void FinalizeLayout() { }

	// RVA: 0x2EF1BB0 Offset: 0x2EF05B0 VA: 0x182EF1BB0
	internal void SetInlineRule(StyleSheet sheet, StyleRule rule) { }

	// RVA: 0x2EF1570 Offset: 0x2EEFF70 VA: 0x182EF1570
	internal void SetComputedStyle(ref ComputedStyle newStyle) { }

	// RVA: 0x2EF2D60 Offset: 0x2EF1760 VA: 0x182EF2D60 Slot: 3
	public override string ToString() { }

	// RVA: 0x2D06A80 Offset: 0x2D05480 VA: 0x182D06A80
	internal List<string> GetClassesForIteration() { }

	// RVA: 0x2EEABA0 Offset: 0x2EE95A0 VA: 0x182EEABA0
	public void AddToClassList(string className) { }

	// RVA: 0x2EF0970 Offset: 0x2EEF370 VA: 0x182EF0970
	public void RemoveFromClassList(string className) { }

	// RVA: 0x2EED190 Offset: 0x2EEBB90 VA: 0x182EED190
	public void EnableInClassList(string className, bool enable) { }

	// RVA: 0x2EEC270 Offset: 0x2EEAC70 VA: 0x182EEC270
	public bool ClassListContains(string cls) { }

	// RVA: 0x2EEEA00 Offset: 0x2EED400 VA: 0x182EEEA00
	internal object GetProperty(PropertyName key) { }

	// RVA: 0x2EF27C0 Offset: 0x2EF11C0 VA: 0x182EF27C0
	internal void SetProperty(PropertyName key, object value) { }

	// RVA: 0x2EEF010 Offset: 0x2EEDA10 VA: 0x182EEF010
	internal bool HasProperty(PropertyName key) { }

	// RVA: 0x2EF3690 Offset: 0x2EF2090 VA: 0x182EF3690
	private bool TryGetPropertyInternal(PropertyName key, out object value) { }

	// RVA: 0x2EEC040 Offset: 0x2EEAA40 VA: 0x182EEC040
	private static void CheckUserKeyArgument(PropertyName key) { }

	// RVA: 0x2EF2500 Offset: 0x2EF0F00 VA: 0x182EF2500
	private void SetPropertyInternal(PropertyName key, object value) { }

	// RVA: 0x2EF65F0 Offset: 0x2EF4FF0 VA: 0x182EF65F0
	private void UpdateCursorStyle(long eventType) { }

	// RVA: 0x2EF8D70 Offset: 0x2EF7770 VA: 0x182EF8D70
	internal VisualElement.RenderTargetMode get_subRenderTargetMode() { }

	// RVA: 0x2EF8200 Offset: 0x2EF6C00 VA: 0x182EF8200
	internal Material get_defaultMaterial() { }

	// RVA: 0x2EEDDC0 Offset: 0x2EEC7C0 VA: 0x182EEDDC0
	private VisualElementAnimationSystem GetAnimationSystem() { }

	// RVA: 0x2EF07D0 Offset: 0x2EEF1D0 VA: 0x182EF07D0
	internal void RegisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x2EF5F90 Offset: 0x2EF4990 VA: 0x182EF5F90
	internal void UnregisterAnimation(IValueAnimationUpdate anim) { }

	// RVA: 0x2EF6010 Offset: 0x2EF4A10 VA: 0x182EF6010
	private void UnregisterRunningAnimations() { }

	// RVA: 0x2EF0900 Offset: 0x2EEF300 VA: 0x182EF0900
	private void RegisterRunningAnimations() { }

	// RVA: -1 Offset: -1
	private static ValueAnimation<T> StartAnimation<T>(ValueAnimation<T> anim, Func<VisualElement, T> fromValueGetter, T to, int durationMs, Action<VisualElement, T> onValueChanged) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF759F0 Offset: 0xF743F0 VA: 0x180F759F0
	|-VisualElement.StartAnimation<StyleValues>
	|
	|-RVA: 0xF758B0 Offset: 0xF742B0 VA: 0x180F758B0
	|-VisualElement.StartAnimation<__Il2CppFullySharedGenericType>
	*/

	// RVA: 0x2EEAF70 Offset: 0x2EE9970 VA: 0x182EEAF70
	private static void AssignStyleValues(VisualElement ve, StyleValues src) { }

	// RVA: 0x2EF0020 Offset: 0x2EEEA20 VA: 0x182EF0020
	private StyleValues ReadCurrentValues(VisualElement ve, StyleValues targetValuesToRead) { }

	// RVA: 0x2EF37A0 Offset: 0x2EF21A0 VA: 0x182EF37A0 Slot: 91
	private ValueAnimation<StyleValues> UnityEngine.UIElements.Experimental.ITransitionAnimations.Start(StyleValues to, int durationMs) { }

	// RVA: 0x2EF2970 Offset: 0x2EF1370 VA: 0x182EF2970
	private ValueAnimation<StyleValues> Start(Func<VisualElement, StyleValues> fromValueGetter, StyleValues to, int durationMs) { }

	// RVA: 0x2EECEB0 Offset: 0x2EEB8B0 VA: 0x182EECEB0
	private void DirtyNextParentWithEventCallback() { }

	// RVA: 0x2EF14A0 Offset: 0x2EEFEA0 VA: 0x182EF14A0
	private void SetAsNextParentWithEventCallback() { }

	// RVA: 0x2EEDE70 Offset: 0x2EEC870 VA: 0x182EEDE70
	internal bool GetCachedNextParentWithEventCallback(out VisualElement nextParent) { }

	// RVA: 0x2EF87C0 Offset: 0x2EF71C0 VA: 0x182EF87C0
	internal VisualElement get_nextParentWithEventCallback() { }

	// RVA: 0x2EEFEE0 Offset: 0x2EEE8E0 VA: 0x182EEFEE0
	private void PropagateCachedNextParentWithEventCallback(VisualElement nextParent, VisualElement stopParent) { }

	// RVA: 0x2C1A410 Offset: 0x2C18E10 VA: 0x182C1A410
	internal int get_eventCallbackCategories() { }

	// RVA: 0x2EF9600 Offset: 0x2EF8000 VA: 0x182EF9600
	internal void set_eventCallbackCategories(int value) { }

	// RVA: 0x2EF8250 Offset: 0x2EF6C50 VA: 0x182EF8250
	internal int get_eventCallbackParentCategories() { }

	// RVA: 0x2EF85A0 Offset: 0x2EF6FA0 VA: 0x182EF85A0
	internal bool get_isEventCallbackParentCategoriesDirty() { }

	// RVA: 0x2EF9710 Offset: 0x2EF8110 VA: 0x182EF9710
	internal void set_isEventCallbackParentCategoriesDirty(bool value) { }

	// RVA: 0x2EF63B0 Offset: 0x2EF4DB0 VA: 0x182EF63B0
	private void UpdateCallbackParentCategories() { }

	// RVA: 0x2EEEF00 Offset: 0x2EED900 VA: 0x182EEEF00
	internal bool HasEventCallbacks(EventCategory eventCategory) { }

	// RVA: 0x2EEEF90 Offset: 0x2EED990 VA: 0x182EEEF90
	internal bool HasParentEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x2EEEED0 Offset: 0x2EED8D0 VA: 0x182EEEED0
	internal bool HasEventCallbacksOrDefaultActions(EventCategory eventCategory) { }

	// RVA: 0x2EEEF20 Offset: 0x2EED920 VA: 0x182EEEF20
	internal bool HasParentEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x2EEEEA0 Offset: 0x2EED8A0 VA: 0x182EEEEA0
	internal bool HasEventCallbacksOrDefaultActionAtTarget(EventCategory eventCategory) { }

	// RVA: 0x2EEEE80 Offset: 0x2EED880 VA: 0x182EEEE80
	internal bool HasDefaultAction(EventCategory eventCategory) { }

	// RVA: 0x1CC1010 Offset: 0x1CBFA10 VA: 0x181CC1010
	public IExperimentalFeatures get_experimental() { }

	// RVA: 0x1CC1010 Offset: 0x1CBFA10 VA: 0x181CC1010 Slot: 92
	private ITransitionAnimations UnityEngine.UIElements.IExperimentalFeatures.get_animation() { }

	[CompilerGenerated]
	// RVA: 0xA02660 Offset: 0xA01060 VA: 0x180A02660
	public VisualElement.Hierarchy get_hierarchy() { }

	[CompilerGenerated]
	// RVA: 0x2EF9680 Offset: 0x2EF8080 VA: 0x182EF9680
	private void set_hierarchy(VisualElement.Hierarchy value) { }

	[CompilerGenerated]
	// RVA: 0x640FB0 Offset: 0x63F9B0 VA: 0x180640FB0
	internal bool get_isRootVisualContainer() { }

	[CompilerGenerated]
	// RVA: 0x641650 Offset: 0x640050 VA: 0x180641650
	internal void set_isRootVisualContainer(bool value) { }

	// RVA: 0x2EF8210 Offset: 0x2EF6C10 VA: 0x182EF8210
	internal bool get_disableClipping() { }

	// RVA: 0x2EF9590 Offset: 0x2EF7F90 VA: 0x182EF9590
	internal void set_disableClipping(bool value) { }

	// RVA: 0x2EF2930 Offset: 0x2EF1330 VA: 0x182EF2930
	internal bool ShouldClip() { }

	// RVA: 0x2EF8B20 Offset: 0x2EF7520 VA: 0x182EF8B20
	public VisualElement get_parent() { }

	[CompilerGenerated]
	// RVA: 0xA20A60 Offset: 0xA1F460 VA: 0x180A20A60
	internal BaseVisualElementPanel get_elementPanel() { }

	[CompilerGenerated]
	// RVA: 0xA20BA0 Offset: 0xA1F5A0 VA: 0x180A20BA0
	private void set_elementPanel(BaseVisualElementPanel value) { }

	// RVA: 0x2EF8B10 Offset: 0x2EF7510 VA: 0x182EF8B10
	public IPanel get_panel() { }

	// RVA: 0x1CC1010 Offset: 0x1CBFA10 VA: 0x181CC1010 Slot: 99
	public virtual VisualElement get_contentContainer() { }

	// RVA: 0xA20BD0 Offset: 0xA1F5D0 VA: 0x180A20BD0
	internal void set_visualTreeAssetSource(VisualTreeAsset value) { }

	// RVA: 0x2EEADC0 Offset: 0x2EE97C0 VA: 0x182EEADC0
	public void Add(VisualElement child) { }

	// RVA: 0x2EEF170 Offset: 0x2EEDB70 VA: 0x182EEF170
	public void Insert(int index, VisualElement element) { }

	// RVA: 0x2EECAE0 Offset: 0x2EEB4E0 VA: 0x182EECAE0
	public void Clear() { }

	// RVA: 0x2EED180 Offset: 0x2EEBB80 VA: 0x182EED180
	public VisualElement ElementAt(int index) { }

	// RVA: 0x2EF7B30 Offset: 0x2EF6530 VA: 0x182EF7B30
	public VisualElement get_Item(int key) { }

	// RVA: 0x2EF7D80 Offset: 0x2EF6780 VA: 0x182EF7D80
	public int get_childCount() { }

	// RVA: 0x2EEF0B0 Offset: 0x2EEDAB0 VA: 0x182EEF0B0
	public int IndexOf(VisualElement element) { }

	// RVA: 0x2EECF60 Offset: 0x2EEB960 VA: 0x182EECF60
	internal VisualElement ElementAtTreePath(List<int> childIndexes) { }

	// RVA: 0x2EEDB30 Offset: 0x2EEC530 VA: 0x182EEDB30
	internal bool FindElementInTree(VisualElement element, List<int> outChildIndexes) { }

	// RVA: 0x2EEC1B0 Offset: 0x2EEABB0 VA: 0x182EEC1B0
	public IEnumerable<VisualElement> Children() { }

	// RVA: 0x2EEBC30 Offset: 0x2EEA630 VA: 0x182EEBC30
	public void BringToFront() { }

	// RVA: 0x2EF13D0 Offset: 0x2EEFDD0 VA: 0x182EF13D0
	public void SendToBack() { }

	// RVA: 0x2EEFDD0 Offset: 0x2EEE7D0 VA: 0x182EEFDD0
	public void PlaceBehind(VisualElement sibling) { }

	// RVA: 0x2EF0AA0 Offset: 0x2EEF4A0 VA: 0x182EF0AA0
	public void RemoveFromHierarchy() { }

	// RVA: -1 Offset: -1
	public T GetFirstOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF75320 Offset: 0xF73D20 VA: 0x180F75320
	|-VisualElement.GetFirstOfType<object>
	*/

	// RVA: -1 Offset: -1
	public T GetFirstAncestorOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xF75220 Offset: 0xF73C20 VA: 0x180F75220
	|-VisualElement.GetFirstAncestorOfType<object>
	*/

	// RVA: 0x2EEDED0 Offset: 0x2EEC8D0 VA: 0x182EEDED0
	internal VisualElement GetFirstAncestorWhere(Predicate<VisualElement> predicate) { }

	// RVA: 0x2EECE60 Offset: 0x2EEB860 VA: 0x182EECE60
	public bool Contains(VisualElement child) { }

	// RVA: 0x2EEDD00 Offset: 0x2EEC700 VA: 0x182EEDD00
	private void GatherAllChildren(List<VisualElement> elements) { }

	// RVA: 0x2EED9A0 Offset: 0x2EEC3A0 VA: 0x182EED9A0
	public VisualElement FindCommonAncestor(VisualElement other) { }

	// RVA: 0x2EEEAD0 Offset: 0x2EED4D0 VA: 0x182EEEAD0
	internal VisualElement GetRoot() { }

	// RVA: 0x2EEEA80 Offset: 0x2EED480 VA: 0x182EEEA80
	internal VisualElement GetRootVisualContainer() { }

	// RVA: 0x2EEE0C0 Offset: 0x2EECAC0 VA: 0x182EEE0C0
	internal VisualElement GetNextElementDepthFirst() { }

	// RVA: 0x2EEE8D0 Offset: 0x2EED2D0 VA: 0x182EEE8D0
	internal VisualElement GetPreviousElementDepthFirst() { }

	// RVA: 0x2EF1260 Offset: 0x2EEFC60 VA: 0x182EF1260
	internal VisualElement RetargetElement(VisualElement retargetAgainst) { }

	// RVA: 0x2EF8B40 Offset: 0x2EF7540 VA: 0x182EF8B40
	private Vector3 get_positionWithLayout() { }

	// RVA: 0x2EEE540 Offset: 0x2EECF40 VA: 0x182EEE540
	internal void GetPivotedMatrixWithLayout(out Matrix4x4 result) { }

	// RVA: 0x2EF8420 Offset: 0x2EF6E20 VA: 0x182EF8420
	internal bool get_hasDefaultRotationAndScale() { }

	// RVA: 0x2EEF6F0 Offset: 0x2EEE0F0 VA: 0x182EEF6F0
	internal static float Min(float a, float b, float c, float d) { }

	// RVA: 0x2EEF560 Offset: 0x2EEDF60 VA: 0x182EEF560
	internal static float Max(float a, float b, float c, float d) { }

	// RVA: 0x2EF2F20 Offset: 0x2EF1920 VA: 0x182EF2F20
	private void TransformAlignedRectToParentSpace(ref Rect rect) { }

	// RVA: 0x2EEBC80 Offset: 0x2EEA680 VA: 0x182EEBC80
	internal static Rect CalculateConservativeRect(ref Matrix4x4 matrix, Rect rect) { }

	// RVA: 0x2EF3060 Offset: 0x2EF1A60 VA: 0x182EF3060
	internal static void TransformAlignedRect(ref Matrix4x4 matrix, ref Rect rect) { }

	// RVA: 0x2EEFA10 Offset: 0x2EEE410 VA: 0x182EEFA10
	internal static void OrderMinMaxRect(ref Rect rect) { }

	// RVA: 0x2EEF930 Offset: 0x2EEE330 VA: 0x182EEF930
	internal static Vector2 MultiplyMatrix44Point2(ref Matrix4x4 lhs, Vector2 point) { }

	// RVA: 0x2EEF980 Offset: 0x2EEE380 VA: 0x182EEF980
	internal static Vector2 MultiplyVector2(ref Matrix4x4 lhs, Vector2 vector) { }

	// RVA: 0x2EEF700 Offset: 0x2EEE100 VA: 0x182EEF700
	internal static void MultiplyMatrix34(ref Matrix4x4 lhs, ref Matrix4x4 rhs, out Matrix4x4 res) { }

	// RVA: 0x2EF30E0 Offset: 0x2EF1AE0 VA: 0x182EF30E0
	private static void TranslateMatrix34(ref Matrix4x4 lhs, Vector3 rhs, out Matrix4x4 res) { }

	// RVA: 0x2A395B0 Offset: 0x2A37FB0 VA: 0x182A395B0
	private static void TranslateMatrix34InPlace(ref Matrix4x4 lhs, Vector3 rhs) { }

	// RVA: 0x1CC1010 Offset: 0x1CBFA10 VA: 0x181CC1010
	public IVisualElementScheduler get_schedule() { }

	// RVA: 0x2EF5DB0 Offset: 0x2EF47B0 VA: 0x182EF5DB0 Slot: 93
	private IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action<TimerState> timerUpdateEvent) { }

	// RVA: 0x2EF5EA0 Offset: 0x2EF48A0 VA: 0x182EF5EA0 Slot: 94
	private IVisualElementScheduledItem UnityEngine.UIElements.IVisualElementScheduler.Execute(Action updateEvent) { }

	// RVA: 0x2EF8CF0 Offset: 0x2EF76F0 VA: 0x182EF8CF0
	public IStyle get_style() { }

	// RVA: 0x2EF8150 Offset: 0x2EF6B50 VA: 0x182EF8150
	public ICustomStyle get_customStyle() { }

	// RVA: 0x2EF8CC0 Offset: 0x2EF76C0 VA: 0x182EF8CC0
	public VisualElementStyleSheetSet get_styleSheets() { }

	// RVA: 0x2EEA940 Offset: 0x2EE9340 VA: 0x182EEA940
	internal void AddStyleSheetPath(string sheetPath) { }

	// RVA: 0x2EF0BD0 Offset: 0x2EEF5D0 VA: 0x182EF0BD0
	private StyleFloat ResolveLengthValue(Length length, bool isRow) { }

	// RVA: 0x2EF10C0 Offset: 0x2EEFAC0 VA: 0x182EF10C0
	private Vector3 ResolveTranslate() { }

	// RVA: 0x2EF0EC0 Offset: 0x2EEF8C0 VA: 0x182EF0EC0
	private Vector3 ResolveTransformOrigin() { }

	// RVA: 0x2EF0D10 Offset: 0x2EEF710 VA: 0x182EF0D10
	private Quaternion ResolveRotation() { }

	// RVA: 0x2EF0DF0 Offset: 0x2EEF7F0 VA: 0x182EF0DF0
	private Vector3 ResolveScale() { }

	// RVA: 0x2EF8D80 Offset: 0x2EF7780 VA: 0x182EF8D80
	public string get_tooltip() { }

	// RVA: 0x2EFA430 Offset: 0x2EF8E30 VA: 0x182EFA430
	public void set_tooltip(string value) { }

	// RVA: 0x2EEE1E0 Offset: 0x2EECBE0 VA: 0x182EEE1E0
	internal static VisualElement.TypeData GetOrCreateTypeData(Type t) { }

	// RVA: 0x2EF8E80 Offset: 0x2EF7880 VA: 0x182EF8E80
	private VisualElement.TypeData get_typeData() { }

	// RVA: 0x2EF73D0 Offset: 0x2EF5DD0 VA: 0x182EF73D0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2EEF570 Offset: 0x2EEDF70 VA: 0x182EEF570
	private YogaSize <AssignMeasureFunction>b__432_0(YogaNode node, float f, YogaMeasureMode mode, float f1, YogaMeasureMode heightMode) { }
}
