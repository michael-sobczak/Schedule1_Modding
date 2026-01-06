public class ContextualMenuManipulator : MouseManipulator // TypeDefIndex: 6209
{
	// Fields
	private Action<ContextualMenuPopulateEvent> m_MenuBuilder; // 0x30

	// Methods

	// RVA: 0x2DB6B10 Offset: 0x2DB5510 VA: 0x182DB6B10
	public void .ctor(Action<ContextualMenuPopulateEvent> menuBuilder) { }

	// RVA: 0x2DB6610 Offset: 0x2DB5010 VA: 0x182DB6610 Slot: 5
	protected override void RegisterCallbacksOnTarget() { }

	// RVA: 0x2DB6890 Offset: 0x2DB5290 VA: 0x182DB6890 Slot: 6
	protected override void UnregisterCallbacksFromTarget() { }

	// RVA: 0x2DB6470 Offset: 0x2DB4E70 VA: 0x182DB6470
	private void OnMouseUpDownEvent(IMouseEvent evt) { }

	// RVA: 0x2DB6360 Offset: 0x2DB4D60 VA: 0x182DB6360
	private void OnMouseDownEventOSX(MouseDownEvent evt) { }

	// RVA: 0x2DB6510 Offset: 0x2DB4F10 VA: 0x182DB6510
	private void OnMouseUpEventOSX(MouseUpEvent evt) { }

	// RVA: 0x2DB6300 Offset: 0x2DB4D00 VA: 0x182DB6300
	private void OnKeyUpEvent(KeyUpEvent evt) { }

	// RVA: 0x2DB6230 Offset: 0x2DB4C30 VA: 0x182DB6230
	private void DoDisplayMenu(EventBase evt) { }

	// RVA: 0x2DB62E0 Offset: 0x2DB4CE0 VA: 0x182DB62E0
	private void OnContextualMenuEvent(ContextualMenuPopulateEvent evt) { }
}
