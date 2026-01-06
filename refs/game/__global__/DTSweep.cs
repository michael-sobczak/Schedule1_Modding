public static class DTSweep // TypeDefIndex: 18653
{
	// Fields
	private const double PI_div2 = 1.5707963267948966;
	private const double PI_3div4 = 2.356194490192345;

	// Methods

	// RVA: 0x1E80750 Offset: 0x1E7F150 VA: 0x181E80750
	public static void Triangulate(DTSweepContext tcx) { }

	// RVA: 0x1E80520 Offset: 0x1E7EF20 VA: 0x181E80520
	private static void Sweep(DTSweepContext tcx) { }

	// RVA: 0x1E7E180 Offset: 0x1E7CB80 VA: 0x181E7E180
	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0x1E807A0 Offset: 0x1E7F1A0 VA: 0x181E807A0
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0x1E7E9A0 Offset: 0x1E7D3A0 VA: 0x181E7E9A0
	private static void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0x1E7FDA0 Offset: 0x1E7E7A0 VA: 0x181E7FDA0
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0x1E7F860 Offset: 0x1E7E260 VA: 0x181E7F860
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0x1E7C710 Offset: 0x1E7B110 VA: 0x181E7C710
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7CF40 Offset: 0x1E7B940 VA: 0x181E7CF40
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7DC70 Offset: 0x1E7C670 VA: 0x181E7DC70
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7DD90 Offset: 0x1E7C790 VA: 0x181E7DD90
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7DA20 Offset: 0x1E7C420 VA: 0x181E7DA20
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7D8C0 Offset: 0x1E7C2C0 VA: 0x181E7D8C0
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7D6A0 Offset: 0x1E7C0A0 VA: 0x181E7D6A0
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7D580 Offset: 0x1E7BF80 VA: 0x181E7D580
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7D340 Offset: 0x1E7BD40 VA: 0x181E7D340
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7D1E0 Offset: 0x1E7BBE0 VA: 0x181E7D1E0
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1E7F400 Offset: 0x1E7DE00 VA: 0x181E7F400
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0x1E7C490 Offset: 0x1E7AE90 VA: 0x181E7C490
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0x1E803F0 Offset: 0x1E7EDF0 VA: 0x181E803F0
	private static void SplitEdge(TriangulationPoint ep, TriangulationPoint eq, TriangulationPoint p) { }

	// RVA: 0x1E7EB20 Offset: 0x1E7D520 VA: 0x181E7EB20
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x1E7FAD0 Offset: 0x1E7E4D0 VA: 0x181E7FAD0
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	// RVA: 0x1E7FC30 Offset: 0x1E7E630 VA: 0x181E7FC30
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0x1E7F000 Offset: 0x1E7DA00 VA: 0x181E7F000
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x1E7C8D0 Offset: 0x1E7B2D0 VA: 0x181E7C8D0
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0x1E7CC80 Offset: 0x1E7B680 VA: 0x181E7CC80
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x1E7CA70 Offset: 0x1E7B470 VA: 0x181E7CA70
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x1E7F500 Offset: 0x1E7DF00 VA: 0x181E7F500
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x1E7F2E0 Offset: 0x1E7DCE0 VA: 0x181E7F2E0
	private static double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0x1E7C3E0 Offset: 0x1E7ADE0 VA: 0x181E7C3E0
	private static double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0x1E7DFB0 Offset: 0x1E7C9B0 VA: 0x181E7DFB0
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x1E7F570 Offset: 0x1E7DF70 VA: 0x181E7F570
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0x1E800E0 Offset: 0x1E7EAE0 VA: 0x181E800E0
	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }
}
