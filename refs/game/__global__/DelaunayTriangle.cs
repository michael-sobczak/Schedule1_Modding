public class DelaunayTriangle // TypeDefIndex: 18650
{
	// Fields
	public FixedArray3<TriangulationPoint> Points; // 0x10
	public FixedArray3<DelaunayTriangle> Neighbors; // 0x28
	public FixedBitArray3 EdgeIsConstrained; // 0x40
	public FixedBitArray3 EdgeIsDelaunay; // 0x43
	[CompilerGenerated]
	private bool <IsInterior>k__BackingField; // 0x46

	// Properties
	public bool IsInterior { get; set; }

	// Methods

	// RVA: 0x1E824F0 Offset: 0x1E80EF0 VA: 0x181E824F0
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	[CompilerGenerated]
	// RVA: 0x1E82590 Offset: 0x1E80F90 VA: 0x181E82590
	public bool get_IsInterior() { }

	[CompilerGenerated]
	// RVA: 0x1E825A0 Offset: 0x1E80FA0 VA: 0x181E825A0
	public void set_IsInterior(bool value) { }

	// RVA: 0x1E810A0 Offset: 0x1E7FAA0 VA: 0x181E810A0
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x1E81070 Offset: 0x1E7FA70 VA: 0x181E81070
	public int IndexCWFrom(TriangulationPoint p) { }

	// RVA: 0x1E81040 Offset: 0x1E7FA40 VA: 0x181E81040
	public int IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0x1E80BB0 Offset: 0x1E7F5B0 VA: 0x181E80BB0
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x1E81A70 Offset: 0x1E80470 VA: 0x181E81A70
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0x1E81800 Offset: 0x1E80200 VA: 0x181E81800
	public void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0x1E81CD0 Offset: 0x1E806D0 VA: 0x181E81CD0
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x1E81C40 Offset: 0x1E80640 VA: 0x181E81C40
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0x1E81BB0 Offset: 0x1E805B0 VA: 0x181E81BB0
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0x1E81B40 Offset: 0x1E80540 VA: 0x181E81B40
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0x1E81D10 Offset: 0x1E80710 VA: 0x181E81D10
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0x1E81D80 Offset: 0x1E80780 VA: 0x181E81D80
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0x1E81DF0 Offset: 0x1E807F0 VA: 0x181E81DF0
	private void RotateCW() { }

	// RVA: 0x1E81140 Offset: 0x1E7FB40 VA: 0x181E81140
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0x1E822A0 Offset: 0x1E80CA0 VA: 0x181E822A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1E81690 Offset: 0x1E80090 VA: 0x181E81690
	public void MarkNeighborEdges() { }

	// RVA: 0x1E81560 Offset: 0x1E7FF60 VA: 0x181E81560
	public void MarkEdge(DelaunayTriangle triangle) { }

	// RVA: 0x1E813A0 Offset: 0x1E7FDA0 VA: 0x181E813A0
	public void MarkEdge(List<DelaunayTriangle> tList) { }

	// RVA: 0x1E81330 Offset: 0x1E7FD30 VA: 0x181E81330
	public void MarkConstrainedEdge(int index) { }

	// RVA: 0x1E81280 Offset: 0x1E7FC80 VA: 0x181E81280
	public void MarkConstrainedEdge(DTSweepConstraint edge) { }

	// RVA: 0x1E812B0 Offset: 0x1E7FCB0 VA: 0x181E812B0
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0x1E80940 Offset: 0x1E7F340 VA: 0x181E80940
	public double Area() { }

	// RVA: 0x1E80A40 Offset: 0x1E7F440 VA: 0x181E80A40
	public TriangulationPoint Centroid() { }

	// RVA: 0x1E80C00 Offset: 0x1E7F600 VA: 0x181E80C00
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x1E80D80 Offset: 0x1E7F780 VA: 0x181E80D80
	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x1E80E10 Offset: 0x1E7F810 VA: 0x181E80E10
	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0x1E80D00 Offset: 0x1E7F700 VA: 0x181E80D00
	public bool GetConstrainedEdgeAcross(TriangulationPoint p) { }

	// RVA: 0x1E81F50 Offset: 0x1E80950 VA: 0x181E81F50
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x1E82000 Offset: 0x1E80A00 VA: 0x181E82000
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x1E81EC0 Offset: 0x1E808C0 VA: 0x181E81EC0
	public void SetConstrainedEdgeAcross(TriangulationPoint p, bool ce) { }

	// RVA: 0x1E80F20 Offset: 0x1E7F920 VA: 0x181E80F20
	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x1E80FB0 Offset: 0x1E7F9B0 VA: 0x181E80FB0
	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0x1E80EA0 Offset: 0x1E7F8A0 VA: 0x181E80EA0
	public bool GetDelaunayEdgeAcross(TriangulationPoint p) { }

	// RVA: 0x1E82140 Offset: 0x1E80B40 VA: 0x181E82140
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x1E821F0 Offset: 0x1E80BF0 VA: 0x181E821F0
	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x1E820B0 Offset: 0x1E80AB0 VA: 0x181E820B0
	public void SetDelaunayEdgeAcross(TriangulationPoint p, bool ce) { }
}
