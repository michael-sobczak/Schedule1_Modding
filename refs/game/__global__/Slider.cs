public class Slider : Selectable, IDragHandler, IEventSystemHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 16477
{
	// Fields
	[SerializeField]
	private RectTransform m_FillRect; // 0x100
	[SerializeField]
	private RectTransform m_HandleRect; // 0x108
	[Space]
	[SerializeField]
	private Slider.Direction m_Direction; // 0x110
	[SerializeField]
	private float m_MinValue; // 0x114
	[SerializeField]
	private float m_MaxValue; // 0x118
	[SerializeField]
	private bool m_WholeNumbers; // 0x11C
	[SerializeField]
	protected float m_Value; // 0x120
	[SerializeField]
	[Space]
	private Slider.SliderEvent m_OnValueChanged; // 0x128
	private Image m_FillImage; // 0x130
	private Transform m_FillTransform; // 0x138
	private RectTransform m_FillContainerRect; // 0x140
	private Transform m_HandleTransform; // 0x148
	private RectTransform m_HandleContainerRect; // 0x150
	private Vector2 m_Offset; // 0x158
	private DrivenRectTransformTracker m_Tracker; // 0x160
	private bool m_DelayedUpdateVisuals; // 0x161

	// Properties
	public RectTransform fillRect { get; set; }
	public RectTransform handleRect { get; set; }
	public Slider.Direction direction { get; set; }
	public float minValue { get; set; }
	public float maxValue { get; set; }
	public bool wholeNumbers { get; set; }
	public virtual float value { get; set; }
	public float normalizedValue { get; set; }
	public Slider.SliderEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Slider.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public RectTransform get_fillRect() { }

	// RVA: 0x2F3DCF0 Offset: 0x2F3C6F0 VA: 0x182F3DCF0
	public void set_fillRect(RectTransform value) { }

	// RVA: 0x516260 Offset: 0x514C60 VA: 0x180516260
	public RectTransform get_handleRect() { }

	// RVA: 0x2F3DD60 Offset: 0x2F3C760 VA: 0x182F3DD60
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x21FCF70 Offset: 0x21FB970 VA: 0x1821FCF70
	public Slider.Direction get_direction() { }

	// RVA: 0x2F3DC90 Offset: 0x2F3C690 VA: 0x182F3DC90
	public void set_direction(Slider.Direction value) { }

	// RVA: 0x513360 Offset: 0x511D60 VA: 0x180513360
	public float get_minValue() { }

	// RVA: 0x2F3DE50 Offset: 0x2F3C850 VA: 0x182F3DE50
	public void set_minValue(float value) { }

	// RVA: 0x5933D0 Offset: 0x591DD0 VA: 0x1805933D0
	public float get_maxValue() { }

	// RVA: 0x2F3DDD0 Offset: 0x2F3C7D0 VA: 0x182F3DDD0
	public void set_maxValue(float value) { }

	// RVA: 0x5232C0 Offset: 0x521CC0 VA: 0x1805232C0
	public bool get_wholeNumbers() { }

	// RVA: 0x2F3DF40 Offset: 0x2F3C940 VA: 0x182F3DF40
	public void set_wholeNumbers(bool value) { }

	// RVA: 0x2F3DC70 Offset: 0x2F3C670 VA: 0x182F3DC70 Slot: 46
	public virtual float get_value() { }

	// RVA: 0x2F3DF20 Offset: 0x2F3C920 VA: 0x182F3DF20 Slot: 47
	public virtual void set_value(float value) { }

	// RVA: 0x2F3CEC0 Offset: 0x2F3B8C0 VA: 0x182F3CEC0 Slot: 48
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x2F3DB70 Offset: 0x2F3C570 VA: 0x182F3DB70
	public float get_normalizedValue() { }

	// RVA: 0x2F3DED0 Offset: 0x2F3C8D0 VA: 0x182F3DED0
	public void set_normalizedValue(float value) { }

	// RVA: 0x5233C0 Offset: 0x521DC0 VA: 0x1805233C0
	public Slider.SliderEvent get_onValueChanged() { }

	// RVA: 0x5EB2C0 Offset: 0x5E9CC0 VA: 0x1805EB2C0
	public void set_onValueChanged(Slider.SliderEvent value) { }

	// RVA: 0x2F3DC40 Offset: 0x2F3C640 VA: 0x182F3DC40
	private float get_stepSize() { }

	// RVA: 0x2F3DA50 Offset: 0x2F3C450 VA: 0x182F3DA50
	protected void .ctor() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 49
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 50
	public virtual void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 51
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2F3C5B0 Offset: 0x2F3AFB0 VA: 0x182F3C5B0 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F3C500 Offset: 0x2F3AF00 VA: 0x182F3C500 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F3DA00 Offset: 0x2F3C400 VA: 0x182F3DA00 Slot: 52
	protected virtual void Update() { }

	// RVA: 0x2F3C280 Offset: 0x2F3AC80 VA: 0x182F3C280 Slot: 13
	protected override void OnDidApplyAnimationProperties() { }

	// RVA: 0x2F3CFC0 Offset: 0x2F3B9C0 VA: 0x182F3CFC0
	private void UpdateCachedReferences() { }

	// RVA: 0x2F3C190 Offset: 0x2F3AB90 VA: 0x182F3C190
	private float ClampValue(float input) { }

	// RVA: 0x2F3CEE0 Offset: 0x2F3B8E0 VA: 0x182F3CEE0 Slot: 53
	protected virtual void Set(float input, bool sendCallback = True) { }

	// RVA: 0x2F3CCB0 Offset: 0x2F3B6B0 VA: 0x182F3CCB0 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2F3DB50 Offset: 0x2F3C550 VA: 0x182F3DB50
	private Slider.Axis get_axis() { }

	// RVA: 0x2F3DC20 Offset: 0x2F3C620 VA: 0x182F3DC20
	private bool get_reverseValue() { }

	// RVA: 0x2F3D610 Offset: 0x2F3C010 VA: 0x182F3D610
	private void UpdateVisuals() { }

	// RVA: 0x2F3D350 Offset: 0x2F3BD50 VA: 0x182F3D350
	private void UpdateDrag(PointerEventData eventData, Camera cam) { }

	// RVA: 0x1A47EE0 Offset: 0x1A468E0 VA: 0x181A47EE0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x2F3CA50 Offset: 0x2F3B450 VA: 0x182F3CA50 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2F3C530 Offset: 0x2F3AF30 VA: 0x182F3C530 Slot: 54
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2F3C600 Offset: 0x2F3B000 VA: 0x182F3C600 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x2F3C1F0 Offset: 0x2F3ABF0 VA: 0x182F3C1F0 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x2F3C220 Offset: 0x2F3AC20 VA: 0x182F3C220 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x2F3C250 Offset: 0x2F3AC50 VA: 0x182F3C250 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x2F3C1C0 Offset: 0x2F3ABC0 VA: 0x182F3C1C0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x1A48140 Offset: 0x1A46B40 VA: 0x181A48140 Slot: 55
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x2F3CCF0 Offset: 0x2F3B6F0 VA: 0x182F3CCF0
	public void SetDirection(Slider.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 42
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}
