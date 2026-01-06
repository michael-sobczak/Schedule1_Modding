public class EventTrigger : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IInitializePotentialDragHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IDropHandler, IScrollHandler, IUpdateSelectedHandler, ISelectHandler, IDeselectHandler, IMoveHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 16546
{
	// Fields
	[FormerlySerializedAs("delegates")]
	[SerializeField]
	private List<EventTrigger.Entry> m_Delegates; // 0x20

	// Properties
	[EditorBrowsable(1)]
	[Obsolete("Please use triggers instead (UnityUpgradable) -> triggers", True)]
	public List<EventTrigger.Entry> delegates { get; set; }
	public List<EventTrigger.Entry> triggers { get; set; }

	// Methods

	// RVA: 0x2F48880 Offset: 0x2F47280 VA: 0x182F48880
	public List<EventTrigger.Entry> get_delegates() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_delegates(List<EventTrigger.Entry> value) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	protected void .ctor() { }

	// RVA: 0x2F48890 Offset: 0x2F47290 VA: 0x182F48890
	public List<EventTrigger.Entry> get_triggers() { }

	// RVA: 0x43EFF0 Offset: 0x43D9F0 VA: 0x18043EFF0
	public void set_triggers(List<EventTrigger.Entry> value) { }

	// RVA: 0x2F485D0 Offset: 0x2F46FD0 VA: 0x182F485D0
	private void Execute(EventTriggerType id, BaseEventData eventData) { }

	// RVA: 0x2F48810 Offset: 0x2F47210 VA: 0x182F48810 Slot: 21
	public virtual void OnPointerEnter(PointerEventData eventData) { }

	// RVA: 0x2F48820 Offset: 0x2F47220 VA: 0x182F48820 Slot: 22
	public virtual void OnPointerExit(PointerEventData eventData) { }

	// RVA: 0x2F487A0 Offset: 0x2F471A0 VA: 0x182F487A0 Slot: 23
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x2F487B0 Offset: 0x2F471B0 VA: 0x182F487B0 Slot: 24
	public virtual void OnDrop(PointerEventData eventData) { }

	// RVA: 0x2F48800 Offset: 0x2F47200 VA: 0x182F48800 Slot: 25
	public virtual void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x2F48830 Offset: 0x2F47230 VA: 0x182F48830 Slot: 26
	public virtual void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x2F487F0 Offset: 0x2F471F0 VA: 0x182F487F0 Slot: 27
	public virtual void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x2F48850 Offset: 0x2F47250 VA: 0x182F48850 Slot: 28
	public virtual void OnSelect(BaseEventData eventData) { }

	// RVA: 0x2F48790 Offset: 0x2F47190 VA: 0x182F48790 Slot: 29
	public virtual void OnDeselect(BaseEventData eventData) { }

	// RVA: 0x2F48840 Offset: 0x2F47240 VA: 0x182F48840 Slot: 30
	public virtual void OnScroll(PointerEventData eventData) { }

	// RVA: 0x2F487E0 Offset: 0x2F471E0 VA: 0x182F487E0 Slot: 31
	public virtual void OnMove(AxisEventData eventData) { }

	// RVA: 0x2F48870 Offset: 0x2F47270 VA: 0x182F48870 Slot: 32
	public virtual void OnUpdateSelected(BaseEventData eventData) { }

	// RVA: 0x2F487D0 Offset: 0x2F471D0 VA: 0x182F487D0 Slot: 33
	public virtual void OnInitializePotentialDrag(PointerEventData eventData) { }

	// RVA: 0x2F48770 Offset: 0x2F47170 VA: 0x182F48770 Slot: 34
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x2F487C0 Offset: 0x2F471C0 VA: 0x182F487C0 Slot: 35
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x2F48860 Offset: 0x2F47260 VA: 0x182F48860 Slot: 36
	public virtual void OnSubmit(BaseEventData eventData) { }

	// RVA: 0x2F48780 Offset: 0x2F47180 VA: 0x182F48780 Slot: 37
	public virtual void OnCancel(BaseEventData eventData) { }
}
