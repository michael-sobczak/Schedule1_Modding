public class PanelEventHandler : UIBehaviour, IPointerMoveHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, ISubmitHandler, ICancelHandler, IMoveHandler, IScrollHandler, ISelectHandler, IDeselectHandler, IPointerExitHandler, IPointerEnterHandler, IRuntimePanelComponent, IPointerClickHandler // TypeDefIndex: 16513
{
	// Fields
	private BaseRuntimePanel m_Panel; // 0x20
	private readonly PanelEventHandler.PointerEvent m_PointerEvent; // 0x28
	private float m_LastClickTime; // 0x30
	private bool m_Selecting; // 0x34
	private Event m_Event; // 0x38
	private static EventModifiers s_Modifiers; // 0x0

	// Properties
	public IPanel panel { get; set; }
	private GameObject selectableGameObject { get; }
	private EventSystem eventSystem { get; }
	private bool isCurrentFocusedPanel { get; }
	private Focusable currentFocusedElement { get; }

	// Methods

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0 Slot: 30
	public IPanel get_panel() { }

	// RVA: 0x2F4CAC0 Offset: 0x2F4B4C0 VA: 0x182F4CAC0 Slot: 28
	public void set_panel(IPanel value) { }

	// RVA: 0x2F4CAA0 Offset: 0x2F4B4A0 VA: 0x182F4CAA0
	private GameObject get_selectableGameObject() { }

	// RVA: 0x2F4C900 Offset: 0x2F4B300 VA: 0x182F4C900
	private EventSystem get_eventSystem() { }

	// RVA: 0x2F4C9D0 Offset: 0x2F4B3D0 VA: 0x182F4C9D0
	private bool get_isCurrentFocusedPanel() { }

	// RVA: 0x2F4C8C0 Offset: 0x2F4B2C0 VA: 0x182F4C8C0
	private Focusable get_currentFocusedElement() { }

	// RVA: 0x2F4AB20 Offset: 0x2F49520 VA: 0x182F4AB20 Slot: 5
	protected override void OnEnable() { }

	// RVA: 0x2F4AA60 Offset: 0x2F49460 VA: 0x182F4AA60 Slot: 7
	protected override void OnDisable() { }

	// RVA: 0x2F4BEE0 Offset: 0x2F4A8E0 VA: 0x182F4BEE0
	private void RegisterCallbacks() { }

	// RVA: 0x2F4C530 Offset: 0x2F4AF30 VA: 0x182F4C530
	private void UnregisterCallbacks() { }

	// RVA: 0x2F4AD40 Offset: 0x2F49740 VA: 0x182F4AD40
	private void OnPanelDestroyed() { }

	// RVA: 0x2F4AA70 Offset: 0x2F49470 VA: 0x182F4AA70
	private void OnElementFocus(FocusEvent e) { }

	// RVA: 0x43CA80 Offset: 0x43B480 VA: 0x18043CA80
	private void OnElementBlur(BlurEvent e) { }

	// RVA: 0x2F4B840 Offset: 0x2F4A240 VA: 0x182F4B840 Slot: 24
	public void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2F4AA40 Offset: 0x2F49440 VA: 0x182F4AA40 Slot: 25
	public void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2F4B350 Offset: 0x2F49D50 VA: 0x182F4B350 Slot: 17
	public void OnPointerMove(PointerEventData eventData) { }

	// RVA: 0x2F4B4A0 Offset: 0x2F49EA0 VA: 0x182F4B4A0 Slot: 18
	public void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2F4ADC0 Offset: 0x2F497C0 VA: 0x182F4ADC0 Slot: 19
	public void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2F4B050 Offset: 0x2F49A50 VA: 0x182F4B050 Slot: 26
	public void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2F4AFE0 Offset: 0x2F499E0 VA: 0x182F4AFE0 Slot: 27
	public void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2F4ADA0 Offset: 0x2F497A0 VA: 0x182F4ADA0 Slot: 29
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2F4B8B0 Offset: 0x2F4A2B0 VA: 0x182F4B8B0 Slot: 20
	public void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2F4A870 Offset: 0x2F49270 VA: 0x182F4A870 Slot: 21
	public void OnCancel(BaseEventData eventData) { }

	// RVA: 0x2F4AB30 Offset: 0x2F49530 VA: 0x182F4AB30 Slot: 22
	public void OnMove(AxisEventData eventData) { }

	// RVA: 0x2F4B660 Offset: 0x2F4A060 VA: 0x182F4B660 Slot: 23
	public void OnScroll(PointerEventData eventData) { }

	// RVA: 0x2F4C090 Offset: 0x2F4AA90 VA: 0x182F4C090
	private void SendEvent(EventBase e, BaseEventData sourceEventData) { }

	// RVA: 0x2F4C100 Offset: 0x2F4AB00 VA: 0x182F4C100
	private void SendEvent(EventBase e, Event sourceEvent) { }

	// RVA: 0x2F4C6E0 Offset: 0x2F4B0E0 VA: 0x182F4C6E0
	internal void Update() { }

	// RVA: 0x2F4A860 Offset: 0x2F49260 VA: 0x182F4A860
	private void LateUpdate() { }

	// RVA: 0x2F4BA80 Offset: 0x2F4A480 VA: 0x182F4BA80
	private void ProcessImguiEvents(Focusable target) { }

	// RVA: 0x2F4BC30 Offset: 0x2F4A630 VA: 0x182F4BC30
	private void ProcessKeyboardEvent(Event e, Focusable target) { }

	// RVA: 0x2F4BCC0 Offset: 0x2F4A6C0 VA: 0x182F4BCC0
	private void ProcessTabEvent(Event e, Focusable target) { }

	// RVA: 0x2F4C3F0 Offset: 0x2F4ADF0 VA: 0x182F4C3F0
	private void SendTabEvent(Event e, NavigationMoveEvent.Direction direction, Focusable target) { }

	// RVA: 0x2F4C290 Offset: 0x2F4AC90 VA: 0x182F4C290
	private void SendKeyUpEvent(Event e, Focusable target) { }

	// RVA: 0x2F4C130 Offset: 0x2F4AB30 VA: 0x182F4C130
	private void SendKeyDownEvent(Event e, Focusable target) { }

	// RVA: 0x2F4BD30 Offset: 0x2F4A730 VA: 0x182F4BD30
	private bool ReadPointerData(PanelEventHandler.PointerEvent pe, PointerEventData eventData, PanelEventHandler.PointerEventType eventType = 0) { }

	// RVA: 0x2F4C820 Offset: 0x2F4B220 VA: 0x182F4C820
	public void .ctor() { }
}
