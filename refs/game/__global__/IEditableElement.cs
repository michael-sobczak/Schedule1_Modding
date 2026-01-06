internal interface IEditableElement // TypeDefIndex: 6320
{
	// Properties
	internal abstract Action editingStarted { get; }
	internal abstract Action editingEnded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	internal abstract Action get_editingStarted();

	// RVA: -1 Offset: -1 Slot: 1
	internal abstract Action get_editingEnded();
}
