internal interface IVisualElementPanelActivatable // TypeDefIndex: 7044
{
	// Properties
	public abstract VisualElement element { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract VisualElement get_element();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool CanBeActivated();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void OnPanelActivate();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void OnPanelDeactivate();
}
