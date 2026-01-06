internal interface IDragAndDrop // TypeDefIndex: 6465
{
	// Properties
	public abstract DragAndDropData data { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void StartDrag(StartDragArgs args, Vector3 pointerPosition);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UpdateDrag(Vector3 pointerPosition);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void AcceptDrag();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void DragCleanup();

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void SetVisualMode(DragVisualMode visualMode);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract DragAndDropData get_data();
}
