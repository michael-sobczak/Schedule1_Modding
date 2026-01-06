public interface IUpdatableGraph // TypeDefIndex: 13118
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void UpdateArea(GraphUpdateObject o);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract void UpdateAreaInit(GraphUpdateObject o);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract void UpdateAreaPost(GraphUpdateObject o);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract GraphUpdateThreading CanUpdateAsync(GraphUpdateObject o);
}
