public class PinchInputDetector : MonoBehaviour, IDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler // TypeDefIndex: 19173
{
	// Fields
	private IPinchStartHandler[] pinchStartHandlers; // 0x20
	private IPinchEndHandler[] pinchEndHandlers; // 0x28
	private IPinchZoomHandler[] pinchZoomHandlers; // 0x30
	private int touchCount; // 0x38
	private bool pinching; // 0x3C
	private PointerEventData firstPointer; // 0x40
	private PointerEventData secondPointer; // 0x48
	private float previousDistance; // 0x50
	private float delta; // 0x54
	[SerializeField]
	protected UnityEvent onPinchStart; // 0x58
	[SerializeField]
	protected UnityEvent onPinchEnd; // 0x60

	// Methods

	// RVA: 0x1A4ED60 Offset: 0x1A4D760 VA: 0x181A4ED60 Slot: 7
	protected virtual void Awake() { }

	// RVA: 0x1A4F600 Offset: 0x1A4E000 VA: 0x181A4F600 Slot: 8
	protected virtual void RegisterPointer(PointerEventData eventData) { }

	// RVA: 0x1A4F700 Offset: 0x1A4E100 VA: 0x181A4F700 Slot: 9
	protected virtual void UnregisterPointer(PointerEventData eventData) { }

	// RVA: 0x1A4F300 Offset: 0x1A4DD00 VA: 0x181A4F300 Slot: 10
	public virtual void OnBeginDrag(PointerEventData eventData) { }

	// RVA: 0x1A4F560 Offset: 0x1A4DF60 VA: 0x181A4F560 Slot: 11
	public virtual void OnEndDrag(PointerEventData eventData) { }

	// RVA: 0x1A4F3A0 Offset: 0x1A4DDA0 VA: 0x181A4F3A0 Slot: 12
	public virtual void OnDrag(PointerEventData eventData) { }

	// RVA: 0x1A4F2E0 Offset: 0x1A4DCE0 VA: 0x181A4F2E0
	private bool IsEqualPointer(PointerEventData a, PointerEventData b) { }

	// RVA: 0x1A4EE00 Offset: 0x1A4D800 VA: 0x181A4EE00 Slot: 13
	protected virtual void CalculateDistanceDelta() { }

	// RVA: 0x1A4F050 Offset: 0x1A4DA50 VA: 0x181A4F050 Slot: 14
	protected virtual void FireOnPinchStart(PinchEventData data) { }

	// RVA: 0x1A4EF00 Offset: 0x1A4D900 VA: 0x181A4EF00 Slot: 15
	protected virtual void FireOnPinchEnd(PinchEventData data) { }

	// RVA: 0x1A4F1A0 Offset: 0x1A4DBA0 VA: 0x181A4F1A0 Slot: 16
	protected virtual void FireOnPinchZoom(PinchEventData data) { }

	// RVA: 0x43CCF0 Offset: 0x43B6F0 VA: 0x18043CCF0
	public void .ctor() { }
}
