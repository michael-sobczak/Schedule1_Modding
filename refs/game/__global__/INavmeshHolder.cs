public interface INavmeshHolder : ITransformedGraph, INavmesh // TypeDefIndex: 13248
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract Int3 GetVertex(int i);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract Int3 GetVertexInGraphSpace(int i);

	// RVA: -1 Offset: -1 Slot: 2
	public abstract int GetVertexArrayIndex(int index);

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void GetTileCoordinates(int tileIndex, out int x, out int z);
}
