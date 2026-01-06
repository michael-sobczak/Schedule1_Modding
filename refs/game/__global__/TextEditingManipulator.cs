internal class TextEditingManipulator // TypeDefIndex: 6913
{
	// Fields
	private TextElement m_TextElement; // 0x10
	internal TextEditorEventHandler editingEventHandler; // 0x18
	internal TextEditingUtilities editingUtilities; // 0x20
	private bool m_TouchScreenTextFieldInitialized; // 0x28
	private IVisualElementScheduledItem m_HardwareKeyboardPoller; // 0x30

	// Properties
	private bool touchScreenTextFieldChanged { get; }

	// Methods

	// RVA: 0x2F092F0 Offset: 0x2F07CF0 VA: 0x182F092F0
	private bool get_touchScreenTextFieldChanged() { }

	// RVA: 0x2F091E0 Offset: 0x2F07BE0 VA: 0x182F091E0
	public void .ctor(TextElement textElement) { }

	// RVA: 0x2F08DD0 Offset: 0x2F077D0 VA: 0x182F08DD0
	private void InitTextEditorEventHandler() { }

	// RVA: 0x2F08C70 Offset: 0x2F07670 VA: 0x182F08C70
	internal void ExecuteDefaultActionAtTarget(EventBase evt) { }

	// RVA: 0x2F08EB0 Offset: 0x2F078B0 VA: 0x182F08EB0
	private void OnFocusInEvent(FocusInEvent _) { }

	// RVA: 0x2F09130 Offset: 0x2F07B30 VA: 0x182F09130
	private void OnFocusOutEvent(FocusOutEvent _) { }

	[CompilerGenerated]
	// RVA: 0x2F09190 Offset: 0x2F07B90 VA: 0x182F09190
	private void <OnFocusInEvent>b__10_0() { }
}
