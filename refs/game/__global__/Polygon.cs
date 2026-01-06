public class Polygon : Triangulatable // TypeDefIndex: 18647
{
	// Fields
	protected List<TriangulationPoint> _points; // 0x10
	protected List<TriangulationPoint> _steinerPoints; // 0x18
	protected List<Polygon> _holes; // 0x20
	protected List<DelaunayTriangle> _triangles; // 0x28
	protected PolygonPoint _last; // 0x30

	// Properties
	public TriangulationMode TriangulationMode { get; }
	public IList<TriangulationPoint> Points { get; }
	public IList<DelaunayTriangle> Triangles { get; }
	public IList<Polygon> Holes { get; }

	// Methods

	// RVA: 0x1E85450 Offset: 0x1E83E50 VA: 0x181E85450
	public void .ctor(IList<PolygonPoint> points) { }

	// RVA: 0x1E85850 Offset: 0x1E84250 VA: 0x181E85850
	public void .ctor(PolygonPoint[] points) { }

	// RVA: 0x6997D0 Offset: 0x6981D0 VA: 0x1806997D0 Slot: 10
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x1E84AC0 Offset: 0x1E834C0 VA: 0x181E84AC0
	public void AddSteinerPoint(TriangulationPoint point) { }

	// RVA: 0x1E84BC0 Offset: 0x1E835C0 VA: 0x181E84BC0
	public void AddSteinerPoints(List<TriangulationPoint> points) { }

	// RVA: 0x1E84D80 Offset: 0x1E83780 VA: 0x181E84D80
	public void ClearSteinerPoints() { }

	// RVA: 0x1E845C0 Offset: 0x1E82FC0 VA: 0x181E845C0
	public void AddHole(Polygon poly) { }

	// RVA: 0x1E84E40 Offset: 0x1E83840 VA: 0x181E84E40
	public void InsertPointAfter(PolygonPoint point, PolygonPoint newPoint) { }

	// RVA: 0x1E847C0 Offset: 0x1E831C0 VA: 0x181E847C0
	public void AddPoints(IEnumerable<PolygonPoint> list) { }

	// RVA: 0x1E846C0 Offset: 0x1E830C0 VA: 0x181E846C0
	public void AddPoint(PolygonPoint p) { }

	// RVA: 0x1E853B0 Offset: 0x1E83DB0 VA: 0x181E853B0
	public void RemovePoint(PolygonPoint p) { }

	// RVA: 0x43EFD0 Offset: 0x43D9D0 VA: 0x18043EFD0 Slot: 5
	public IList<TriangulationPoint> get_Points() { }

	// RVA: 0x4513C0 Offset: 0x44FDC0 VA: 0x1804513C0 Slot: 6
	public IList<DelaunayTriangle> get_Triangles() { }

	// RVA: 0x43EFC0 Offset: 0x43D9C0 VA: 0x18043EFC0
	public IList<Polygon> get_Holes() { }

	// RVA: 0x1E84C70 Offset: 0x1E83670 VA: 0x181E84C70 Slot: 7
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x1E84D20 Offset: 0x1E83720 VA: 0x181E84D20 Slot: 8
	public void AddTriangles(IEnumerable<DelaunayTriangle> list) { }

	// RVA: 0x1E84DE0 Offset: 0x1E837E0 VA: 0x181E84DE0 Slot: 9
	public void ClearTriangles() { }

	// RVA: 0x1E84F90 Offset: 0x1E83990 VA: 0x181E84F90 Slot: 4
	public void Prepare(TriangulationContext tcx) { }
}
