internal class ElementUnderPointer // TypeDefIndex: 6518
{
	// Fields
	private VisualElement[] m_PendingTopElementUnderPointer; // 0x10
	private VisualElement[] m_TopElementUnderPointer; // 0x18
	private IPointerEvent[] m_TriggerPointerEvent; // 0x20
	private IMouseEvent[] m_TriggerMouseEvent; // 0x28
	private Vector2[] m_PickingPointerPositions; // 0x30
	private bool[] m_IsPickingPointerTemporaries; // 0x38

	// Methods

	// RVA: 0x2E8C710 Offset: 0x2E8B110 VA: 0x182E8C710
	internal VisualElement GetTopElementUnderPointer(int pointerId, out Vector2 pickPosition, out bool isTemporary) { }

	// RVA: 0x21ACDF0 Offset: 0x21AB7F0 VA: 0x1821ACDF0
	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	// RVA: 0x2E8CB30 Offset: 0x2E8B530 VA: 0x182E8CB30
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, Vector2 pointerPos) { }

	// RVA: 0x2E8C610 Offset: 0x2E8B010 VA: 0x182E8C610
	private Vector2 GetEventPointerPosition(EventBase triggerEvent) { }

	// RVA: 0x2E8CCC0 Offset: 0x2E8B6C0 VA: 0x182E8CCC0
	internal void SetTemporaryElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	// RVA: 0x2E8CB10 Offset: 0x2E8B510 VA: 0x182E8CB10
	internal void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent) { }

	// RVA: 0x2E8C780 Offset: 0x2E8B180 VA: 0x182E8C780
	private void SetElementUnderPointer(VisualElement newElementUnderPointer, int pointerId, EventBase triggerEvent, bool temporary) { }

	// RVA: 0x2E8B7B0 Offset: 0x2E8A1B0 VA: 0x182E8B7B0
	internal void CommitElementUnderPointers(EventDispatcher dispatcher, ContextType contextType) { }

	// RVA: 0x2E8CCE0 Offset: 0x2E8B6E0 VA: 0x182E8CCE0
	public void .ctor() { }
}
