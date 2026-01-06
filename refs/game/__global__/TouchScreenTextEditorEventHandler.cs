internal class TouchScreenTextEditorEventHandler : TextEditorEventHandler // TypeDefIndex: 6333
{
	// Fields
	private IVisualElementScheduledItem m_TouchKeyboardPoller; // 0x20
	private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x28
	private bool m_IsClicking; // 0x29

	// Methods

	// RVA: 0x2E6D790 Offset: 0x2E6C190 VA: 0x182E6D790
	public void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x2E6D420 Offset: 0x2E6BE20 VA: 0x182E6D420
	private void PollTouchScreenKeyboard() { }

	// RVA: 0x2E6C3E0 Offset: 0x2E6ADE0 VA: 0x182E6C3E0
	private void DoPollTouchScreenKeyboard() { }

	// RVA: 0x2E6D640 Offset: 0x2E6C040 VA: 0x182E6D640
	private void UpdateStringPositionFromKeyboard() { }

	// RVA: 0x2E6C340 Offset: 0x2E6AD40 VA: 0x182E6C340
	private void CloseTouchScreenKeyboard() { }

	// RVA: 0x2E6D180 Offset: 0x2E6BB80 VA: 0x182E6D180
	private void OpenTouchScreenKeyboard() { }

	// RVA: 0x2E6C8D0 Offset: 0x2E6B2D0 VA: 0x182E6C8D0 Slot: 4
	public override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x2E6D010 Offset: 0x2E6BA10 VA: 0x182E6D010
	private void OnPointerDownEvent() { }

	// RVA: 0x2E6D150 Offset: 0x2E6BB50 VA: 0x182E6D150
	private void OnPointerUpEvent(PointerUpEvent evt) { }

	// RVA: 0x2E6CC90 Offset: 0x2E6B690 VA: 0x182E6CC90
	private void OnFocusInEvent() { }

	// RVA: 0x2E6CD80 Offset: 0x2E6B780 VA: 0x182E6CD80
	private void OnFocusOutEvent(FocusOutEvent evt) { }
}
