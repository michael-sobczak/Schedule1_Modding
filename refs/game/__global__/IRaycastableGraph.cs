public interface IRaycastableGraph // TypeDefIndex: 13122
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract bool Linecast(Vector3 start, Vector3 end);

	[Obsolete]
	// RVA: -1 Offset: -1 Slot: 1
	public abstract bool Linecast(Vector3 start, Vector3 end, GraphNode hint);

	[Obsolete]
	// RVA: -1 Offset: -1 Slot: 2
	public abstract bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit);

	[Obsolete]
	// RVA: -1 Offset: -1 Slot: 3
	public abstract bool Linecast(Vector3 start, Vector3 end, GraphNode hint, out GraphHitInfo hit, List<GraphNode> trace);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Linecast(Vector3 start, Vector3 end, out GraphHitInfo hit, List<GraphNode> trace, Func<GraphNode, bool> filter);
}
