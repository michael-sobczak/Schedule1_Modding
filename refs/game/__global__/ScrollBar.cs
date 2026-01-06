public class Scrollbar : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IInitializePotentialDragHandler, ICanvasElement // TypeDefIndex: 16465
{
	// Fields
	[SerializeField]
	private RectTransform m_HandleRect; // 0x100
	[SerializeField]
	private Scrollbar.Direction m_Direction; // 0x108
	[SerializeField]
	[Range(0, 1)]
	private float m_Value; // 0x10C
	[Range(0, 1)]
	[SerializeField]
	private float m_Size; // 0x110
	[Range(0, 11)]
	[SerializeField]
	private int m_NumberOfSteps; // 0x114
	[Space(6)]
	[SerializeField]
	private Scrollbar.ScrollEvent m_OnValueChanged; // 0x118
	private RectTransform m_ContainerRect; // 0x120
	private Vector2 m_Offset; // 0x128
	private DrivenRectTransformTracker m_Tracker; // 0x130
	private Coroutine m_PointerDownRepeat; // 0x138
	private bool isPointerDownAndNotDragging; // 0x140
	private bool m_DelayedUpdateVisuals; // 0x141

	// Properties
	public RectTransform handleRect { get; set; }
	public Scrollbar.Direction direction { get; set; }
	public float value { get; set; }
	public float size { get; set; }
	public int numberOfSteps { get; set; }
	public Scrollbar.ScrollEvent onValueChanged { get; set; }
	private float stepSize { get; }
	private Scrollbar.Axis axis { get; }
	private bool reverseValue { get; }

	// Methods

	// RVA: 0x516250 Offset: 0x514C50 VA: 0x180516250
	public RectTransform get_handleRect() { }

	// RVA: 0x2F39170 Offset: 0x2F37B70 VA: 0x182F39170
	public void set_handleRect(RectTransform value) { }

	// RVA: 0x51D970 Offset: 0x51C370 VA: 0x18051D970
	public Scrollbar.Direction get_direction() { }

	// RVA: 0x2F39110 Offset: 0x2F37B10 VA: 0x182F39110
	public void set_direction(Scrollbar.Direction value) { }

	// RVA: 0x2F38F40 Offset: 0x2F37940 VA: 0x182F38F40
	protected void .ctor() { }

	// RVA: 0x2F390B0 Offset: 0x2F37AB0 VA: 0x182F390B0
	public float get_value() { }

	// RVA: 0x2F392D0 Offset: 0x2F37CD0 VA: 0x182F392D0
	public void set_value(float value) { }

	// RVA: 0x2F38650 Offset: 0x2F37050 VA: 0x182F38650 Slot: 47
	public virtual void SetValueWithoutNotify(float input) { }

	// RVA: 0x513110 Offset: 0x511B10 VA: 0x180513110
	public float get_size() { }

	// RVA: 0x2F39250 Offset: 0x2F37C50 VA: 0x182F39250
	public void set_size(float value) { }

	// RVA: 0x51DB70 Offset: 0x51C570 VA: 0x18051DB70
	public int get_numberOfSteps() { }

	// RVA: 0x2F391E0 Offset: 0x2F37BE0 VA: 0x182F391E0
	public void set_numberOfSteps(int value) { }

	// RVA: 0x5995D0 Offset: 0x597FD0 VA: 0x1805995D0
	public Scrollbar.ScrollEvent get_onValueChanged() { }

	// RVA: 0x599620 Offset: 0x598020 VA: 0x180599620
	public void set_onValueChanged(Scrollbar.ScrollEvent value) { }

	// RVA: 0x2F39080 Offset: 0x2F37A80 VA: 0x182F39080
	private float get_stepSize() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 48
	public virtual void Rebuild(CanvasUpdate executing) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 49
	public virtual void LayoutComplete() { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80 Slot: 50
	public virtual void GraphicUpdateComplete() { }

	// RVA: 0x2F37D40 Offset: 0x2F36740 VA: 0x182F37D40 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F37C40 Offset: 0x2F36640 VA: 0x182F37C40 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F38F20 Offset: 0x2F37920 VA: 0x182F38F20 Slot: 51
	protected virtual void Update() { }

	// RVA: 0x2F38830 Offset: 0x2F37230 VA: 0x182F38830
	private void UpdateCachedReferences() { }

	// RVA: 0x2F38700 Offset: 0x2F37100 VA: 0x182F38700
	private void Set(float input, bool sendCallback = True) { }

	// RVA: 0x2F38440 Offset: 0x2F36E40 VA: 0x182F38440 Slot: 10
	protected override void OnRectTransformDimensionsChange() { }

	// RVA: 0x2F39040 Offset: 0x2F37A40 VA: 0x182F39040
	private Scrollbar.Axis get_axis() { }

	// RVA: 0x2F39060 Offset: 0x2F37A60 VA: 0x182F39060
	private bool get_reverseValue() { }

	// RVA: 0x2F38CA0 Offset: 0x2F376A0 VA: 0x182F38CA0
	private void UpdateVisuals() { }

	// RVA: 0x2F38930 Offset: 0x2F37330 VA: 0x182F38930
	private void UpdateDrag(PointerEventData eventData) { }

	// RVA: 0x2F37820 Offset: 0x2F36220 VA: 0x182F37820
	private void DoUpdateDrag(Vector2 handleCorner, float remainingSize) { }

	// RVA: 0x1A47EE0 Offset: 0x1A468E0 VA: 0x181A47EE0
	private bool MayDrag(PointerEventData eventData) { }

	// RVA: 0x2F379A0 Offset: 0x2F363A0 VA: 0x182F379A0 Slot: 52
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2F37C70 Offset: 0x2F36670 VA: 0x182F37C70 Slot: 53
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2F38300 Offset: 0x2F36D00 VA: 0x182F38300 Slot: 32
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2F377B0 Offset: 0x2F361B0 VA: 0x182F377B0
	protected IEnumerator ClickRepeat(PointerEventData eventData) { }

	[IteratorStateMachine(typeof(Scrollbar.<ClickRepeat>d__58))]
	// RVA: 0x2F37710 Offset: 0x2F36110 VA: 0x182F37710
	protected IEnumerator ClickRepeat(Vector2 screenPosition, Camera camera) { }

	// RVA: 0x2F38400 Offset: 0x2F36E00 VA: 0x182F38400 Slot: 33
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2F37E10 Offset: 0x2F36810 VA: 0x182F37E10 Slot: 31
	public override void OnMove(AxisEventData eventData) { }

	// RVA: 0x2F37910 Offset: 0x2F36310 VA: 0x182F37910 Slot: 27
	public override Selectable FindSelectableOnLeft() { }

	// RVA: 0x2F37940 Offset: 0x2F36340 VA: 0x182F37940 Slot: 28
	public override Selectable FindSelectableOnRight() { }

	// RVA: 0x2F37970 Offset: 0x2F36370 VA: 0x182F37970 Slot: 29
	public override Selectable FindSelectableOnUp() { }

	// RVA: 0x2F378E0 Offset: 0x2F362E0 VA: 0x182F378E0 Slot: 30
	public override Selectable FindSelectableOnDown() { }

	// RVA: 0x1A48140 Offset: 0x1A46B40 VA: 0x181A48140 Slot: 54
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x2F38480 Offset: 0x2F36E80 VA: 0x182F38480
	public void SetDirection(Scrollbar.Direction direction, bool includeRectLayouts) { }

	// RVA: 0x4E26A0 Offset: 0x4E10A0 VA: 0x1804E26A0 Slot: 43
	private Transform UnityEngine.UI.ICanvasElement.get_transform() { }
}
