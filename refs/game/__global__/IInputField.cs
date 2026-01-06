public interface IInputField // TypeDefIndex: 18020
{
	// Properties
	public abstract UnityEvent<string> OnValueChanged { get; }
	public abstract string Text { get; set; }
	public abstract bool IsFocused { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract UnityEvent<string> get_OnValueChanged();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract string get_Text();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_Text(string value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool get_IsFocused();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void ActivateInputField();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void DeactivateInputField();
}
