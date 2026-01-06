public interface Triangulatable // TypeDefIndex: 18664
{
	// Properties
	public abstract IList<TriangulationPoint> Points { get; }
	public abstract IList<DelaunayTriangle> Triangles { get; }
	public abstract TriangulationMode TriangulationMode { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 0
	public abstract void Prepare(TriangulationContext tcx);

	// RVA: -1 Offset: -1 Slot: 1
	public abstract IList<TriangulationPoint> get_Points();

	// RVA: -1 Offset: -1 Slot: 2
	public abstract IList<DelaunayTriangle> get_Triangles();

	// RVA: -1 Offset: -1 Slot: 3
	public abstract void AddTriangle(DelaunayTriangle t);

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void AddTriangles(IEnumerable<DelaunayTriangle> list);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void ClearTriangles();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract TriangulationMode get_TriangulationMode();
}
