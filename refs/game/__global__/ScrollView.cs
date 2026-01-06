public class ScrollView : VisualElement // TypeDefIndex: 6410
{
	// Fields
	private int m_FirstLayoutPass; // 0x3C8
	private ScrollerVisibility m_HorizontalScrollerVisibility; // 0x3CC
	private ScrollerVisibility m_VerticalScrollerVisibility; // 0x3D0
	private VisualElement m_AttachedRootVisualContainer; // 0x3D8
	private float m_SingleLineHeight; // 0x3E0
	internal bool m_MouseWheelScrollSizeIsInline; // 0x3E4
	private float m_HorizontalPageSize; // 0x3E8
	private float m_VerticalPageSize; // 0x3EC
	private float m_MouseWheelScrollSize; // 0x3F0
	private static readonly float k_DefaultScrollDecelerationRate; // 0x0
	private float m_ScrollDecelerationRate; // 0x3F4
	private float k_ScaledPixelsPerPointMultiplier; // 0x3F8
	private float k_TouchScrollInertiaBaseTimeInterval; // 0x3FC
	private static readonly float k_DefaultElasticity; // 0x4
	private float m_Elasticity; // 0x400
	private ScrollView.TouchScrollBehavior m_TouchScrollBehavior; // 0x404
	private ScrollView.NestedInteractionKind m_NestedInteractionKind; // 0x408
	private static readonly long k_DefaultElasticAnimationInterval; // 0x8
	private long m_ElasticAnimationIntervalMs; // 0x410
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly VisualElement <contentViewport>k__BackingField; // 0x418
	[CompilerGenerated]
	[DebuggerBrowsable(0)]
	private readonly Scroller <horizontalScroller>k__BackingField; // 0x420
	[DebuggerBrowsable(0)]
	[CompilerGenerated]
	private readonly Scroller <verticalScroller>k__BackingField; // 0x428
	private VisualElement m_ContentContainer; // 0x430
	private VisualElement m_ContentAndVerticalScrollContainer; // 0x438
	private float previousVerticalTouchScrollTimeStamp; // 0x440
	private float previousHorizontalTouchScrollTimeStamp; // 0x444
	private float elapsedTimeSinceLastVerticalTouchScroll; // 0x448
	private float elapsedTimeSinceLastHorizontalTouchScroll; // 0x44C
	public static readonly string ussClassName; // 0x10
	public static readonly string viewportUssClassName; // 0x18
	public static readonly string horizontalVariantViewportUssClassName; // 0x20
	public static readonly string verticalVariantViewportUssClassName; // 0x28
	public static readonly string verticalHorizontalVariantViewportUssClassName; // 0x30
	public static readonly string contentAndVerticalScrollUssClassName; // 0x38
	public static readonly string contentUssClassName; // 0x40
	public static readonly string horizontalVariantContentUssClassName; // 0x48
	public static readonly string verticalVariantContentUssClassName; // 0x50
	public static readonly string verticalHorizontalVariantContentUssClassName; // 0x58
	public static readonly string hScrollerUssClassName; // 0x60
	public static readonly string vScrollerUssClassName; // 0x68
	public static readonly string horizontalVariantUssClassName; // 0x70
	public static readonly string verticalVariantUssClassName; // 0x78
	public static readonly string verticalHorizontalVariantUssClassName; // 0x80
	public static readonly string scrollVariantUssClassName; // 0x88
	private ScrollViewMode m_Mode; // 0x450
	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; // 0x458
	private Vector2 m_StartPosition; // 0x460
	private Vector2 m_PointerStartPosition; // 0x468
	private Vector2 m_Velocity; // 0x470
	private Vector2 m_SpringBackVelocity; // 0x478
	private Vector2 m_LowBounds; // 0x480
	private Vector2 m_HighBounds; // 0x488
	private float m_LastVelocityLerpTime; // 0x490
	private bool m_StartedMoving; // 0x494
	private bool m_TouchPointerMoveAllowed; // 0x495
	private bool m_TouchStoppedVelocity; // 0x496
	private VisualElement m_CapturedTarget; // 0x498
	private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback; // 0x4A0
	private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback; // 0x4A8
	internal IVisualElementScheduledItem m_PostPointerUpAnimation; // 0x4B0

	// Properties
	public ScrollerVisibility horizontalScrollerVisibility { get; set; }
	public ScrollerVisibility verticalScrollerVisibility { get; set; }
	[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
	public bool showHorizontal { set; }
	[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
	public bool showVertical { set; }
	internal bool needsHorizontal { get; }
	internal bool needsVertical { get; }
	internal bool isVerticalScrollDisplayed { get; }
	internal bool isHorizontalScrollDisplayed { get; }
	public Vector2 scrollOffset { get; set; }
	public float horizontalPageSize { set; }
	public float verticalPageSize { set; }
	public float mouseWheelScrollSize { get; set; }
	internal float scrollableWidth { get; }
	internal float scrollableHeight { get; }
	private bool hasInertia { get; }
	public float scrollDecelerationRate { get; set; }
	public float elasticity { get; set; }
	public ScrollView.TouchScrollBehavior touchScrollBehavior { get; set; }
	public ScrollView.NestedInteractionKind nestedInteractionKind { get; set; }
	public long elasticAnimationIntervalMs { set; }
	public VisualElement contentViewport { get; }
	public Scroller horizontalScroller { get; }
	public Scroller verticalScroller { get; }
	public override VisualElement contentContainer { get; }
	public ScrollViewMode mode { get; set; }

	// Methods

	// RVA: 0x2E7ABE0 Offset: 0x2E795E0 VA: 0x182E7ABE0
	public ScrollerVisibility get_horizontalScrollerVisibility() { }

	// RVA: 0x2E7B070 Offset: 0x2E79A70 VA: 0x182E7B070
	public void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	// RVA: 0x2E7AF20 Offset: 0x2E79920 VA: 0x182E7AF20
	public ScrollerVisibility get_verticalScrollerVisibility() { }

	// RVA: 0x2E7B490 Offset: 0x2E79E90 VA: 0x182E7B490
	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	// RVA: 0x2E7B380 Offset: 0x2E79D80 VA: 0x182E7B380
	public void set_showHorizontal(bool value) { }

	// RVA: 0x2E7B3A0 Offset: 0x2E79DA0 VA: 0x182E7B3A0
	public void set_showVertical(bool value) { }

	// RVA: 0x2E7ACF0 Offset: 0x2E796F0 VA: 0x182E7ACF0
	internal bool get_needsHorizontal() { }

	// RVA: 0x2E7AD40 Offset: 0x2E79740 VA: 0x182E7AD40
	internal bool get_needsVertical() { }

	// RVA: 0x2E7AC60 Offset: 0x2E79660 VA: 0x182E7AC60
	internal bool get_isVerticalScrollDisplayed() { }

	// RVA: 0x2E7ABF0 Offset: 0x2E795F0 VA: 0x182E7ABF0
	internal bool get_isHorizontalScrollDisplayed() { }

	// RVA: 0x2E7ADB0 Offset: 0x2E797B0 VA: 0x182E7ADB0
	public Vector2 get_scrollOffset() { }

	// RVA: 0x2E7B1F0 Offset: 0x2E79BF0 VA: 0x182E7B1F0
	public void set_scrollOffset(Vector2 value) { }

	// RVA: 0x2E7B060 Offset: 0x2E79A60 VA: 0x182E7B060
	public void set_horizontalPageSize(float value) { }

	// RVA: 0x2E7B480 Offset: 0x2E79E80 VA: 0x182E7B480
	public void set_verticalPageSize(float value) { }

	// RVA: 0x2E7ACE0 Offset: 0x2E796E0 VA: 0x182E7ACE0
	public float get_mouseWheelScrollSize() { }

	// RVA: 0x2E7B130 Offset: 0x2E79B30 VA: 0x182E7B130
	public void set_mouseWheelScrollSize(float value) { }

	// RVA: 0x2E7AEA0 Offset: 0x2E798A0 VA: 0x182E7AEA0
	internal float get_scrollableWidth() { }

	// RVA: 0x2E7AE30 Offset: 0x2E79830 VA: 0x182E7AE30
	internal float get_scrollableHeight() { }

	// RVA: 0x2E7ABC0 Offset: 0x2E795C0 VA: 0x182E7ABC0
	private bool get_hasInertia() { }

	// RVA: 0x2E7ADA0 Offset: 0x2E797A0 VA: 0x182E7ADA0
	public float get_scrollDecelerationRate() { }

	// RVA: 0x2E7B1D0 Offset: 0x2E79BD0 VA: 0x182E7B1D0
	public void set_scrollDecelerationRate(float value) { }

	// RVA: 0x2E7ABB0 Offset: 0x2E795B0 VA: 0x182E7ABB0
	public float get_elasticity() { }

	// RVA: 0x2E7B040 Offset: 0x2E79A40 VA: 0x182E7B040
	public void set_elasticity(float value) { }

	// RVA: 0x2E7AF10 Offset: 0x2E79910 VA: 0x182E7AF10
	public ScrollView.TouchScrollBehavior get_touchScrollBehavior() { }

	// RVA: 0x2E7B3C0 Offset: 0x2E79DC0 VA: 0x182E7B3C0
	public void set_touchScrollBehavior(ScrollView.TouchScrollBehavior value) { }

	// RVA: 0x2E7AD90 Offset: 0x2E79790 VA: 0x182E7AD90
	public ScrollView.NestedInteractionKind get_nestedInteractionKind() { }

	// RVA: 0x2E7B1C0 Offset: 0x2E79BC0 VA: 0x182E7B1C0
	public void set_nestedInteractionKind(ScrollView.NestedInteractionKind value) { }

	// RVA: 0x2E7AF30 Offset: 0x2E79930 VA: 0x182E7AF30
	public void set_elasticAnimationIntervalMs(long value) { }

	// RVA: 0x2E76A80 Offset: 0x2E75480 VA: 0x182E76A80
	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2E77A60 Offset: 0x2E76460 VA: 0x182E77A60
	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2E78F90 Offset: 0x2E77990 VA: 0x182E78F90
	private void UpdateHorizontalSliderPageSize() { }

	// RVA: 0x2E795A0 Offset: 0x2E77FA0 VA: 0x182E795A0
	private void UpdateVerticalSliderPageSize() { }

	// RVA: 0x2E789D0 Offset: 0x2E773D0 VA: 0x182E789D0
	internal void UpdateContentViewTransform() { }

	// RVA: 0x2E77FD0 Offset: 0x2E769D0 VA: 0x182E77FD0
	public void ScrollTo(VisualElement child) { }

	// RVA: 0x2E75520 Offset: 0x2E73F20 VA: 0x182E75520
	private float GetXDeltaOffset(VisualElement child) { }

	// RVA: 0x2E757F0 Offset: 0x2E741F0 VA: 0x182E757F0
	private float GetYDeltaOffset(VisualElement child) { }

	// RVA: 0x2E754B0 Offset: 0x2E73EB0 VA: 0x182E754B0
	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	[CompilerGenerated]
	// RVA: 0x13E2490 Offset: 0x13E0E90 VA: 0x1813E2490
	public VisualElement get_contentViewport() { }

	[CompilerGenerated]
	// RVA: 0x2E49380 Offset: 0x2E47D80 VA: 0x182E49380
	public Scroller get_horizontalScroller() { }

	[CompilerGenerated]
	// RVA: 0x2DE0C60 Offset: 0x2DDF660 VA: 0x182DE0C60
	public Scroller get_verticalScroller() { }

	// RVA: 0x2E7ABA0 Offset: 0x2E795A0 VA: 0x182E7ABA0 Slot: 99
	public override VisualElement get_contentContainer() { }

	// RVA: 0x2E7AB90 Offset: 0x2E79590 VA: 0x182E7AB90
	public void .ctor() { }

	// RVA: 0x2E79C90 Offset: 0x2E78690 VA: 0x182E79C90
	public void .ctor(ScrollViewMode scrollViewMode) { }

	// RVA: 0x2E7ACD0 Offset: 0x2E796D0 VA: 0x182E7ACD0
	public ScrollViewMode get_mode() { }

	// RVA: 0x2E7B110 Offset: 0x2E79B10 VA: 0x182E7B110
	public void set_mode(ScrollViewMode value) { }

	// RVA: 0x2E782E0 Offset: 0x2E76CE0 VA: 0x182E782E0
	private void SetScrollViewMode(ScrollViewMode mode) { }

	// RVA: 0x2E75E30 Offset: 0x2E74830 VA: 0x182E75E30
	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	// RVA: 0x2E762C0 Offset: 0x2E74CC0 VA: 0x182E762C0
	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	// RVA: 0x2E76C50 Offset: 0x2E75650 VA: 0x182E76C50
	private void OnPointerCapture(PointerCaptureEvent evt) { }

	// RVA: 0x2E76B60 Offset: 0x2E75560 VA: 0x182E76B60
	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x2E76770 Offset: 0x2E75170 VA: 0x182E76770
	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2E77EB0 Offset: 0x2E768B0 VA: 0x182E77EB0
	private void ScheduleResetLayoutPass() { }

	// RVA: 0x2E77EA0 Offset: 0x2E768A0 VA: 0x182E77EA0
	private void ResetLayoutPass() { }

	// RVA: 0x2E74B60 Offset: 0x2E73560 VA: 0x182E74B60
	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	// RVA: 0x2E74CE0 Offset: 0x2E736E0 VA: 0x182E74CE0
	private void ComputeInitialSpringBackVelocity() { }

	// RVA: 0x2E78740 Offset: 0x2E77140 VA: 0x182E78740
	private void SpringBack() { }

	// RVA: 0x2E742D0 Offset: 0x2E72CD0 VA: 0x182E742D0
	internal void ApplyScrollInertia() { }

	// RVA: 0x2E77AD0 Offset: 0x2E764D0 VA: 0x182E77AD0
	private void PostPointerUpAnimation() { }

	// RVA: 0x2E76DB0 Offset: 0x2E757B0 VA: 0x182E76DB0
	private void OnPointerDown(PointerDownEvent evt) { }

	// RVA: 0x2E76FE0 Offset: 0x2E759E0 VA: 0x182E76FE0
	private void OnPointerMove(PointerMoveEvent evt) { }

	// RVA: 0x2E76AF0 Offset: 0x2E754F0 VA: 0x182E76AF0
	private void OnPointerCancel(PointerCancelEvent evt) { }

	// RVA: 0x2E77250 Offset: 0x2E75C50 VA: 0x182E77250
	private void OnPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2E75AD0 Offset: 0x2E744D0 VA: 0x182E75AD0
	internal void InitTouchScrolling(Vector2 position) { }

	// RVA: 0x2E74E40 Offset: 0x2E73840 VA: 0x182E74E40
	internal ScrollView.TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	// RVA: 0x2E74840 Offset: 0x2E73240 VA: 0x182E74840
	private bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	// RVA: 0x2E77DA0 Offset: 0x2E767A0 VA: 0x182E77DA0
	private bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	// RVA: 0x2E75230 Offset: 0x2E73C30 VA: 0x182E75230
	private void ExecuteElasticSpringAnimation() { }

	// RVA: 0x2E74140 Offset: 0x2E72B40 VA: 0x182E74140
	private void AdjustScrollers() { }

	// RVA: 0x2E790D0 Offset: 0x2E77AD0 VA: 0x182E790D0
	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	// RVA: 0x2E77880 Offset: 0x2E76280 VA: 0x182E77880
	private void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	// RVA: 0x2E77320 Offset: 0x2E75D20 VA: 0x182E77320
	private void OnScrollWheel(WheelEvent evt) { }

	// RVA: 0x2E77300 Offset: 0x2E75D00 VA: 0x182E77300
	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	// RVA: 0x2E77310 Offset: 0x2E75D10 VA: 0x182E77310
	private void OnRootPointerUp(PointerUpEvent evt) { }

	// RVA: 0x2E77C80 Offset: 0x2E76680 VA: 0x182E77C80
	private void ReadSingleLineHeight() { }

	// RVA: 0x2E78CD0 Offset: 0x2E776D0 VA: 0x182E78CD0
	private void UpdateElasticBehaviour() { }

	// RVA: 0x2E796E0 Offset: 0x2E780E0 VA: 0x182E796E0
	private static void .cctor() { }

	[CompilerGenerated]
	// RVA: 0x2E78930 Offset: 0x2E77330 VA: 0x182E78930
	private void <.ctor>b__126_0(float value) { }

	[CompilerGenerated]
	// RVA: 0x2E78980 Offset: 0x2E77380 VA: 0x182E78980
	private void <.ctor>b__126_1(float value) { }
}
