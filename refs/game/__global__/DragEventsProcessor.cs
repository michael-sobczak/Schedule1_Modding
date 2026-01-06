internal abstract class DragEventsProcessor // TypeDefIndex: 6463
{
	// Fields
	private bool m_IsRegistered; // 0x10
	private DragEventsProcessor.DragState m_DragState; // 0x14
	private Vector3 m_Start; // 0x18
	protected readonly VisualElement m_Target; // 0x28

	// Properties
	protected virtual bool supportsDragEvents { get; }
	private bool useDragEvents { get; }
	protected IDragAndDrop dragAndDrop { get; }
	internal virtual bool isEditorContext { get; }

	// Methods

	// RVA: 0x48A7D0 Offset: 0x4891D0 VA: 0x18048A7D0 Slot: 4
	protected virtual bool get_supportsDragEvents() { }

	// RVA: 0x2E8AA90 Offset: 0x2E89490 VA: 0x182E8AA90
	private bool get_useDragEvents() { }

	// RVA: 0x2E8A990 Offset: 0x2E89390 VA: 0x182E8A990
	protected IDragAndDrop get_dragAndDrop() { }

	// RVA: 0x2E8A9C0 Offset: 0x2E893C0 VA: 0x182E8A9C0 Slot: 5
	internal virtual bool get_isEditorContext() { }

	// RVA: 0x2E8A860 Offset: 0x2E89260 VA: 0x182E8A860
	internal void .ctor(VisualElement target) { }

	// RVA: 0x2E8A490 Offset: 0x2E88E90 VA: 0x182E8A490
	private void RegisterCallbacksFromTarget(AttachToPanelEvent evt) { }

	// RVA: 0x2E8A1C0 Offset: 0x2E88BC0 VA: 0x182E8A1C0
	private void RegisterCallbacksFromTarget() { }

	// RVA: 0x2E8A850 Offset: 0x2E89250 VA: 0x182E8A850
	private void UnregisterCallbacksFromTarget(DetachFromPanelEvent evt) { }

	// RVA: 0x2E8A4A0 Offset: 0x2E88EA0 VA: 0x182E8A4A0
	internal void UnregisterCallbacksFromTarget(bool unregisterPanelEvents = False) { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract bool CanStartDrag(Vector3 pointerPosition);

	// RVA: -1 Offset: -1 Slot: 7
	protected internal abstract StartDragArgs StartDrag(Vector3 pointerPosition);

	// RVA: -1 Offset: -1 Slot: 8
	protected internal abstract void UpdateDrag(Vector3 pointerPosition);

	// RVA: -1 Offset: -1 Slot: 9
	protected internal abstract void OnDrop(Vector3 pointerPosition);

	// RVA: -1 Offset: -1 Slot: 10
	protected abstract void ClearDragAndDropUI(bool dragCancelled);

	// RVA: 0x2E89A80 Offset: 0x2E88480 VA: 0x182E89A80
	private void OnPointerDownEvent(PointerDownEvent evt) { }

	// RVA: 0x2E89FD0 Offset: 0x2E889D0 VA: 0x182E89FD0
	internal void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x2E89B90 Offset: 0x2E88590 VA: 0x182E89B90
	private void OnPointerLeaveEvent(PointerLeaveEvent evt) { }

	// RVA: 0x2E89890 Offset: 0x2E88290 VA: 0x182E89890
	private void OnPointerCancelEvent(PointerCancelEvent evt) { }

	// RVA: 0x2E899A0 Offset: 0x2E883A0 VA: 0x182E899A0
	private void OnPointerCapturedOut(PointerCaptureOutEvent evt) { }

	// RVA: 0x2E89BB0 Offset: 0x2E885B0 VA: 0x182E89BB0
	private void OnPointerMoveEvent(PointerMoveEvent evt) { }

	// RVA: 0x2E89760 Offset: 0x2E88160 VA: 0x182E89760
	private DragEventsProcessor GetDropTarget(Vector2 position) { }
}
