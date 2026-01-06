internal class UGUIInputFieldWrapper : UIInteropWrapper<InputField>, IInputField // TypeDefIndex: 18008
{
	// Properties
	public UnityEvent<string> OnValueChanged { get; }
	public string Text { get; set; }
	public bool IsFocused { get; }

	// Methods

	// RVA: 0x448D60 Offset: 0x447760 VA: 0x180448D60
	public void .ctor(InputField internalTarget) { }

	// RVA: 0x448DD0 Offset: 0x4477D0 VA: 0x180448DD0 Slot: 5
	public UnityEvent<string> get_OnValueChanged() { }

	// RVA: 0x448DF0 Offset: 0x4477F0 VA: 0x180448DF0 Slot: 6
	public string get_Text() { }

	// RVA: 0x448E10 Offset: 0x447810 VA: 0x180448E10 Slot: 7
	public void set_Text(string value) { }

	// RVA: 0x448DB0 Offset: 0x4477B0 VA: 0x180448DB0 Slot: 8
	public bool get_IsFocused() { }

	// RVA: 0x448D20 Offset: 0x447720 VA: 0x180448D20 Slot: 9
	public void ActivateInputField() { }

	// RVA: 0x448D40 Offset: 0x447740 VA: 0x180448D40 Slot: 10
	public void DeactivateInputField() { }
}
