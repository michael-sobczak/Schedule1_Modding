internal class TMPInputFieldWrapper : UIInteropWrapper<TMP_InputField>, IInputField // TypeDefIndex: 18017
{
	// Properties
	public UnityEvent<string> OnValueChanged { get; }
	public string Text { get; set; }
	public bool IsFocused { get; }

	// Methods

	// RVA: 0x442EF0 Offset: 0x4418F0 VA: 0x180442EF0
	public void .ctor(TMP_InputField internalTarget) { }

	// RVA: 0x442F60 Offset: 0x441960 VA: 0x180442F60 Slot: 5
	public UnityEvent<string> get_OnValueChanged() { }

	// RVA: 0x442F80 Offset: 0x441980 VA: 0x180442F80 Slot: 6
	public string get_Text() { }

	// RVA: 0x442FA0 Offset: 0x4419A0 VA: 0x180442FA0 Slot: 7
	public void set_Text(string value) { }

	// RVA: 0x442F40 Offset: 0x441940 VA: 0x180442F40 Slot: 8
	public bool get_IsFocused() { }

	// RVA: 0x442EA0 Offset: 0x4418A0 VA: 0x180442EA0 Slot: 9
	public void ActivateInputField() { }

	// RVA: 0x442EC0 Offset: 0x4418C0 VA: 0x180442EC0 Slot: 10
	public void DeactivateInputField() { }
}
