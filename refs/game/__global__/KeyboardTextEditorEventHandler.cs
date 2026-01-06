internal class KeyboardTextEditorEventHandler : TextEditorEventHandler // TypeDefIndex: 6324
{
	// Fields
	private readonly Event m_ImguiEvent; // 0x20
	internal bool m_Changed; // 0x28

	// Methods

	// RVA: 0x2E62AC0 Offset: 0x2E614C0 VA: 0x182E62AC0
	public void .ctor(TextElement textElement, TextEditingUtilities editingUtilities) { }

	// RVA: 0x2E619C0 Offset: 0x2E603C0 VA: 0x182E619C0 Slot: 4
	public override void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x2E61F60 Offset: 0x2E60960 VA: 0x182E61F60
	private void OnFocus(FocusEvent _) { }

	// RVA: 0x2E61D10 Offset: 0x2E60710 VA: 0x182E61D10
	private void OnBlur(BlurEvent _) { }

	// RVA: 0x2E61FF0 Offset: 0x2E609F0 VA: 0x182E61FF0
	private void OnKeyDown(KeyDownEvent evt) { }

	// RVA: 0x2E628A0 Offset: 0x2E612A0 VA: 0x182E628A0
	private void UpdateLabel() { }

	// RVA: 0x2E626E0 Offset: 0x2E610E0 VA: 0x182E626E0
	private void OnValidateCommandEvent(ValidateCommandEvent evt) { }

	// RVA: 0x2E61D60 Offset: 0x2E60760 VA: 0x182E61D60
	private void OnExecuteCommandEvent(ExecuteCommandEvent evt) { }

	// RVA: -1 Offset: -1
	private void OnNavigationEvent<TEvent>(NavigationEventBase<TEvent> evt) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xEE89C0 Offset: 0xEE73C0 VA: 0x180EE89C0
	|-KeyboardTextEditorEventHandler.OnNavigationEvent<object>
	*/
}
