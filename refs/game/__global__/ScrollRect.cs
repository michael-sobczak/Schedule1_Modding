public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController // TypeDefIndex: 16469
{
	// Fields
	[SerializeField]
	private RectTransform m_Content; // 0x20
	[SerializeField]
	private bool m_Horizontal; // 0x28
	[SerializeField]
	private bool m_Vertical; // 0x29
	[SerializeField]
	private ScrollRect.MovementType m_MovementType; // 0x2C
	[SerializeField]
	private float m_Elasticity; // 0x30
	[SerializeField]
	private bool m_Inertia; // 0x34
	[SerializeField]
	private float m_DecelerationRate; // 0x38
	[SerializeField]
	private float m_ScrollSensitivity; // 0x3C
	[SerializeField]
	private RectTransform m_Viewport; // 0x40
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar; // 0x48
	[SerializeField]
	private Scrollbar m_VerticalScrollbar; // 0x50
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_HorizontalScrollbarVisibility; // 0x58
	[SerializeField]
	private ScrollRect.ScrollbarVisibility m_VerticalScrollbarVisibility; // 0x5C
	[SerializeField]
	private float m_HorizontalScrollbarSpacing; // 0x60
	[SerializeField]
	private float m_VerticalScrollbarSpacing; // 0x64
	[SerializeField]
	private ScrollRect.ScrollRectEvent m_OnValueChanged; // 0x68
	private Vector2 m_PointerStartLocalCursor; // 0x70
	protected Vector2 m_ContentStartPosition; // 0x78
	private RectTransform m_ViewRect; // 0x80
	protected Bounds m_ContentBounds; // 0x88
	private Bounds m_ViewBounds; // 0xA0
	private Vector2 m_Velocity; // 0xB8
	private bool m_Dragging; // 0xC0
	private bool m_Scrolling; // 0xC1
	private Vector2 m_PrevPosition; // 0xC4
	private Bounds m_PrevContentBounds; // 0xCC
	private Bounds m_PrevViewBounds; // 0xE4
	private bool m_HasRebuiltLayout; // 0xFC
	private bool m_HSliderExpand; // 0xFD
	private bool m_VSliderExpand; // 0xFE
	private float m_HSliderHeight; // 0x100
	private float m_VSliderWidth; // 0x104
	private RectTransform m_Rect; // 0x108
	private RectTransform m_HorizontalScrollbarRect; // 0x110
	private RectTransform m_VerticalScrollbarRect; // 0x118
	private DrivenRectTransformTracker m_Tracker; // 0x120
	private readonly Vector3[] m_Corners; // 0x128

	// Properties
	public RectTransform content { get; set; }
	public bool horizontal { get; set; }
	public bool vertical { get; set; }
	public ScrollRect.MovementType movementType { get; set; }
	public float elasticity { get; set; }
	public bool inertia { get; set; }
	public float decelerationRate { get; set; }
	public float scrollSensitivity { get; set; }
	public RectTransform viewport { get; set; }
	public Scrollbar horizontalScrollbar { get; set; }
	public Scrollbar verticalScrollbar { get; set; }
	public ScrollRect.ScrollbarVisibility horizontalScrollbarVisibility { get; set; }
	public ScrollRect.ScrollbarVisibility verticalScrollbarVisibility { get; set; }
	public float horizontalScrollbarSpacing { get; set; }
	public float verticalScrollbarSpacing { get; set; }
	public ScrollRect.ScrollRectEvent onValueChanged { get; set; }
	protected RectTransform viewRect { get; }
	public Vector2 velocity { get; set; }
	private RectTransform rectTransform { get; }
	public Vector2 normalizedPosition { get; set; }
	public float horizontalNormalizedPosition { get; set; }
	public float verticalNormalizedPosition { get; set; }
	private bool hScrollingNeeded { get; }
	private bool vScrollingNeeded { get; }
	public virtual float minWidth { get; }
	public virtual float preferredWidth { get; }
	public virtual float flexibleWidth { get; }
	public virtual float minHeight { get; }
	public virtual float preferredHeight { get; }
	public virtual float flexibleHeight { get; }
	public virtual int layoutPriority { get; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public RectTransform get_content() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_content(RectTransform value) { }

	// RVA: 0x493120 Offset: 0x491B20 VA: 0x180493120
	public bool get_horizontal() { }

	// RVA: 0x493130 Offset: 0x491B30 VA: 0x180493130
	public void set_horizontal(bool value) { }

	// RVA: 0x5A9D10 Offset: 0x5A8710 VA: 0x1805A9D10
	public bool get_vertical() { }

	// RVA: 0x5A9D20 Offset: 0x5A8720 VA: 0x1805A9D20
	public void set_vertical(bool value) { }

	// RVA: 0x65E590 Offset: 0x65CF90 VA: 0x18065E590
	public ScrollRect.MovementType get_movementType() { }

	// RVA: 0x65E020 Offset: 0x65CA20 VA: 0x18065E020
	public void set_movementType(ScrollRect.MovementType value) { }

	// RVA: 0x497260 Offset: 0x495C60 VA: 0x180497260
	public float get_elasticity() { }

	// RVA: 0x49D320 Offset: 0x49BD20 VA: 0x18049D320
	public void set_elasticity(float value) { }

	// RVA: 0x66AFB0 Offset: 0x6699B0 VA: 0x18066AFB0
	public bool get_inertia() { }

	// RVA: 0x66B030 Offset: 0x669A30 VA: 0x18066B030
	public void set_inertia(bool value) { }

	// RVA: 0x4CD9F0 Offset: 0x4CC3F0 VA: 0x1804CD9F0
	public float get_decelerationRate() { }

	// RVA: 0x4E2CD0 Offset: 0x4E16D0 VA: 0x1804E2CD0
	public void set_decelerationRate(float value) { }

	// RVA: 0x4E2CC0 Offset: 0x4E16C0 VA: 0x1804E2CC0
	public float get_scrollSensitivity() { }

	// RVA: 0x4E2CE0 Offset: 0x4E16E0 VA: 0x1804E2CE0
	public void set_scrollSensitivity(float value) { }

	// RVA: 0x4945F0 Offset: 0x492FF0 VA: 0x1804945F0
	public RectTransform get_viewport() { }

	// RVA: 0x2F376E0 Offset: 0x2F360E0 VA: 0x182F376E0
	public void set_viewport(RectTransform value) { }

	// RVA: 0x4C1D80 Offset: 0x4C0780 VA: 0x1804C1D80
	public Scrollbar get_horizontalScrollbar() { }

	// RVA: 0x2F37340 Offset: 0x2F35D40 VA: 0x182F37340
	public void set_horizontalScrollbar(Scrollbar value) { }

	// RVA: 0x441BA0 Offset: 0x4405A0 VA: 0x180441BA0
	public Scrollbar get_verticalScrollbar() { }

	// RVA: 0x2F37550 Offset: 0x2F35F50 VA: 0x182F37550
	public void set_verticalScrollbar(Scrollbar value) { }

	// RVA: 0x4C3B30 Offset: 0x4C2530 VA: 0x1804C3B30
	public ScrollRect.ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	// RVA: 0x2F37330 Offset: 0x2F35D30 VA: 0x182F37330
	public void set_horizontalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x54CEC0 Offset: 0x54B8C0 VA: 0x18054CEC0
	public ScrollRect.ScrollbarVisibility get_verticalScrollbarVisibility() { }

	// RVA: 0x2F37540 Offset: 0x2F35F40 VA: 0x182F37540
	public void set_verticalScrollbarVisibility(ScrollRect.ScrollbarVisibility value) { }

	// RVA: 0x4B5440 Offset: 0x4B3E40 VA: 0x1804B5440
	public float get_horizontalScrollbarSpacing() { }

	// RVA: 0x2F37320 Offset: 0x2F35D20 VA: 0x182F37320
	public void set_horizontalScrollbarSpacing(float value) { }

	// RVA: 0x4CD1A0 Offset: 0x4CBBA0 VA: 0x1804CD1A0
	public float get_verticalScrollbarSpacing() { }

	// RVA: 0x2F37530 Offset: 0x2F35F30 VA: 0x182F37530
	public void set_verticalScrollbarSpacing(float value) { }

	// RVA: 0x4663D0 Offset: 0x464DD0 VA: 0x1804663D0
	public ScrollRect.ScrollRectEvent get_onValueChanged() { }

	// RVA: 0x5F4EB0 Offset: 0x5F38B0 VA: 0x1805F4EB0
	public void set_onValueChanged(ScrollRect.ScrollRectEvent value) { }

	// RVA: 0x2F371F0 Offset: 0x2F35BF0 VA: 0x182F371F0
	protected RectTransform get_viewRect() { }

	// RVA: 0xAA7210 Offset: 0xAA5C10 VA: 0x180AA7210
	public Vector2 get_velocity() { }

	// RVA: 0xAA7290 Offset: 0xAA5C90 VA: 0x180AA7290
	public void set_velocity(Vector2 value) { }

	// RVA: 0x2F36FC0 Offset: 0x2F359C0 VA: 0x182F36FC0
	private RectTransform get_rectTransform() { }

	// RVA: 0x2F36C40 Offset: 0x2F35640 VA: 0x182F36C40
	protected void .ctor() { }

	// RVA: 0x2F34880 Offset: 0x2F33280 VA: 0x182F34880 Slot: 38
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 39
	public virtual void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 40
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2F36060 Offset: 0x2F34A60 VA: 0x182F36060
	private void UpdateCachedData() { }

	// RVA: 0x2F34400 Offset: 0x2F32E00 VA: 0x182F34400 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F33F70 Offset: 0x2F32970 VA: 0x182F33F70 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F33380 Offset: 0x2F31D80 VA: 0x182F33380 Slot: 9
	public override bool IsActive() { }

	// RVA: 0x2F32DB0 Offset: 0x2F317B0 VA: 0x182F32DB0
	private void EnsureLayoutHasRebuilt() { }

	// RVA: 0x2F359A0 Offset: 0x2F343A0 VA: 0x182F359A0 Slot: 41
	public virtual void StopMovement() { }

	// RVA: 0x2F34660 Offset: 0x2F33060 VA: 0x182F34660 Slot: 42
	public virtual void OnScroll(PointerEventData data) { }

	// RVA: 0x2F345E0 Offset: 0x2F32FE0 VA: 0x182F345E0 Slot: 43
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x2F33E00 Offset: 0x2F32800 VA: 0x182F33E00 Slot: 44
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2F345B0 Offset: 0x2F32FB0 VA: 0x182F345B0 Slot: 45
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2F341B0 Offset: 0x2F32BB0 VA: 0x182F341B0 Slot: 46
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2F34970 Offset: 0x2F33370 VA: 0x182F34970 Slot: 47
	protected virtual void SetContentAnchoredPosition(Vector2 position) { }

	// RVA: 0x2F333F0 Offset: 0x2F31DF0 VA: 0x182F333F0 Slot: 48
	protected virtual void LateUpdate() { }

	// RVA: 0x2F364F0 Offset: 0x2F34EF0 VA: 0x182F364F0
	protected void UpdatePrevData() { }

	// RVA: 0x2F36A50 Offset: 0x2F35450 VA: 0x182F36A50
	private void UpdateScrollbars(Vector2 offset) { }

	// RVA: 0x2F36F80 Offset: 0x2F35980 VA: 0x182F36F80
	public Vector2 get_normalizedPosition() { }

	// RVA: 0x2F374D0 Offset: 0x2F35ED0 VA: 0x182F374D0
	public void set_normalizedPosition(Vector2 value) { }

	// RVA: 0x2F36E70 Offset: 0x2F35870 VA: 0x182F36E70
	public float get_horizontalNormalizedPosition() { }

	// RVA: 0x2F34BD0 Offset: 0x2F335D0 VA: 0x182F34BD0
	public void set_horizontalNormalizedPosition(float value) { }

	// RVA: 0x2F370E0 Offset: 0x2F35AE0 VA: 0x182F370E0
	public float get_verticalNormalizedPosition() { }

	// RVA: 0x2F35980 Offset: 0x2F34380 VA: 0x182F35980
	public void set_verticalNormalizedPosition(float value) { }

	// RVA: 0x2F34BD0 Offset: 0x2F335D0 VA: 0x182F34BD0
	private void SetHorizontalNormalizedPosition(float value) { }

	// RVA: 0x2F35980 Offset: 0x2F34380 VA: 0x182F35980
	private void SetVerticalNormalizedPosition(float value) { }

	// RVA: 0x2F35460 Offset: 0x2F33E60 VA: 0x182F35460 Slot: 49
	protected virtual void SetNormalizedPosition(float value, int axis) { }

	// RVA: 0x2F34910 Offset: 0x2F33310 VA: 0x182F34910
	private static float RubberDelta(float overStretching, float viewSize) { }

	// RVA: 0x2F34650 Offset: 0x2F33050 VA: 0x182F34650 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2F36DE0 Offset: 0x2F357E0 VA: 0x182F36DE0
	private bool get_hScrollingNeeded() { }

	// RVA: 0x2F37060 Offset: 0x2F35A60 VA: 0x182F37060
	private bool get_vScrollingNeeded() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 50
	public virtual void CalculateLayoutInputHorizontal() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 51
	public virtual void CalculateLayoutInputVertical() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 52
	public virtual float get_minWidth() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 53
	public virtual float get_preferredWidth() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 54
	public virtual float get_flexibleWidth() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 55
	public virtual float get_minHeight() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 56
	public virtual float get_preferredHeight() { }

	// RVA: 0xD1D190 Offset: 0xD1BB90 VA: 0x180D1D190 Slot: 57
	public virtual float get_flexibleHeight() { }

	// RVA: 0xB0B490 Offset: 0xB09E90 VA: 0x180B0B490 Slot: 58
	public virtual int get_layoutPriority() { }

	// RVA: 0x2F34BF0 Offset: 0x2F335F0 VA: 0x182F34BF0 Slot: 59
	public virtual void SetLayoutHorizontal() { }

	// RVA: 0x2F35330 Offset: 0x2F33D30 VA: 0x182F35330 Slot: 60
	public virtual void SetLayoutVertical() { }

	// RVA: 0x2F369F0 Offset: 0x2F353F0 VA: 0x182F369F0
	private void UpdateScrollbarVisibility() { }

	// RVA: 0x2F36400 Offset: 0x2F34E00 VA: 0x182F36400
	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollRect.ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	// RVA: 0x2F36610 Offset: 0x2F35010 VA: 0x182F36610
	private void UpdateScrollbarLayout() { }

	// RVA: 0x2F35A00 Offset: 0x2F34400 VA: 0x182F35A00
	protected void UpdateBounds() { }

	// RVA: 0x2F32B30 Offset: 0x2F31530 VA: 0x182F32B30
	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	// RVA: 0x2F32E10 Offset: 0x2F31810 VA: 0x182F32E10
	private Bounds GetBounds() { }

	// RVA: 0x2F33100 Offset: 0x2F31B00 VA: 0x182F33100
	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	// RVA: 0x2F32BD0 Offset: 0x2F315D0 VA: 0x182F32BD0
	private Vector2 CalculateOffset(Vector2 delta) { }

	// RVA: 0x2F32F50 Offset: 0x2F31950 VA: 0x182F32F50
	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, ScrollRect.MovementType movementType, ref Vector2 delta) { }

	// RVA: 0x2F34B50 Offset: 0x2F33550 VA: 0x182F34B50
	protected void SetDirty() { }

	// RVA: 0x2F34A90 Offset: 0x2F33490 VA: 0x182F34A90
	protected void SetDirtyCaching() { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 23
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}
