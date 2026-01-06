public interface ITraversalProvider // TypeDefIndex: 13199
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool CanTraverse(Path path, GraphNode node);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract uint GetTraversalCost(Path path, GraphNode node);
}
