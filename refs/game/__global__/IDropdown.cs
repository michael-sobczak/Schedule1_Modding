public interface IDropdown // TypeDefIndex: 18019
{
	// Properties
	public abstract IText CaptionText { get; }
	public abstract int Value { get; set; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract IText get_CaptionText();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract int get_Value();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void set_Value(int value);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void ClearOptions();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void RefreshShownValue();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void AddOption(string text);
}
