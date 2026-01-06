public interface IWorkItemContext // TypeDefIndex: 13191
{
	// Methods

	[Obsolete("Avoid using. This will force a full recalculation of the connected components. In most cases the HierarchicalGraph class takes care of things automatically behind the scenes now. In pretty much all cases you should be able to remove the call to this function.")]
	// RVA: -1 Offset: -1 Slot: 0
	public abstract void QueueFloodFill();

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void EnsureValidFloodFill();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void SetGraphDirty(NavGraph graph);
}
