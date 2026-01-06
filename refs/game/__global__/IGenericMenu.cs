internal interface IGenericMenu // TypeDefIndex: 6300
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void AddItem(string itemName, bool isChecked, Action action);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void AddItem(string itemName, bool isChecked, Action<object> action, object data);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void DropDown(Rect position, VisualElement targetElement, bool anchored = False);
}
